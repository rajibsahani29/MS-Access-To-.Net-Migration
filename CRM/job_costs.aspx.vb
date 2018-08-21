Imports CRM.BE
Imports CRM.DL
Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.tool.xml
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text
Imports System.Globalization

Public Class job_costs
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Dim objBEPEcos As clsBEPEcos = New clsBEPEcos
    Dim objBEInvoice As clsBEInvoice = New clsBEInvoice
    Dim objBEClientContact As clsBEClientcontact = New clsBEClientcontact
    Dim objBEStatusHistory As ClsBEStatusHistory = New ClsBEStatusHistory

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Session("JID")) = "" And Session("JID") Is Nothing Then
            Response.Redirect("job_select.aspx")
        End If
        If Not Page.IsPostBack Then
            'btnEmail.Enabled = False
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            GetOrderDetails(IntJobId)
            objBEPEcos.FFStandard = True
            Dim dstFFunits As DataSet = (New clsDLPEcos()).GetPECOSFillInDD(objBEPEcos)
            objFunction.FillDropDownByDataSet(ddlunit, dstFFunits)
            ddlunit.Items.Insert(0, "Select Unit")

            Dim dstPulldown As DataSet = (New clsDLPulldownIntegers()).GetPulldownIntegersFillInDD()
            objFunction.FillDropDownByDataSet(ddlqty, dstPulldown)
            ddlqty.Items.Insert(0, "Select Qty")
            BindGridview()
        End If


    End Sub

    Protected Sub GetOrderDetails(ByVal id As Integer)
        Try
            Dim dstJobList As New DataSet()
            objBEOrder.JOBID = id
            dstJobList = (New clsDLOrder()).GetJobDetailsByJobID(objBEOrder)
            If dstJobList IsNot Nothing Then
                txtCompany.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Name"))
                txtEngineer.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Engineer"))
                txtJobNumber.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("JobNumber"))
                txtStatus.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Status"))
                Session("Edate") = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("EnquiryDate"))
                hdnCid.Value = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("OID"))
                BindVat()
                txtVat.Text = String.Format("{0:n2}", (objFunction.ReturnDouble(txtExvat.Text) * objFunction.ReturnDouble(dstJobList.Tables(0).Rows(0)("VatRate")))).ToString()
                txtOrderTotal.Text = (objFunction.ReturnDouble(txtExvat.Text) + objFunction.ReturnDouble(txtVat.Text)).ToString()
                GetClientEmailId()

            End If


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub
    Protected Sub BindVat()

        Try
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            Dim dstJobCost As New DataSet()
            objBEInvoice.JOBID = IntJobId
            dstJobCost = (New clsDLInvoice()).GetInvoiceItemDetailsById(objBEInvoice)
            Dim dblTotalAmountVal As Double = 0
            If objFunction.CheckDataSet(dstJobCost) Then
                For i = 0 To dstJobCost.Tables(0).Rows.Count - 1
                    dblTotalAmountVal += objFunction.ReturnDouble(dstJobCost.Tables(0).Rows(i)("Total"))
                Next
                txtExvat.Text = String.Format("{0:n2}", dblTotalAmountVal).ToString()

            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub rdoFull_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFull.CheckedChanged
        If rdoFull.Checked = True Then
            objBEPEcos.FFStandard = False
            Dim dstFFunits As DataSet = (New clsDLPEcos()).GetPECOSFillInDD(objBEPEcos)
            objFunction.FillDropDownByDataSet(ddlunit, dstFFunits)
            ddlunit.Items.Insert(0, "Select")
        End If
    End Sub

    Protected Sub rdoFast_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFast.CheckedChanged
        If rdoFast.Checked = True Then
            objBEPEcos.FFStandard = True
            Dim dstFFunits As DataSet = (New clsDLPEcos()).GetPECOSFillInDD(objBEPEcos)
            objFunction.FillDropDownByDataSet(ddlunit, dstFFunits)
            ddlunit.Items.Insert(0, "Select")
        End If
    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (txtItemDescription.Text <> "") Then
            Try
                Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
                objBEInvoice.JOBID = IntJobId
                objBEInvoice.Line = (New clsDLInvoice()).CurrentInvoiceLinNumbers(IntJobId)
                If (ddlunit.SelectedValue = "HR") Then
                    objBEInvoice.Nos = txthourqty.Text
                Else
                    objBEInvoice.Nos = ddlqty.Text
                End If

                objBEInvoice.ItemDesctiption = txtItemDescription.Text
                objBEInvoice.UNIT = ddlunit.Text
                objBEInvoice.Cost = txtCost.Text
                'objBEInvoice.DateFrom = txtOrderNumber.Text
                'objBEInvoice.DateTo = txtAssetNumber.Text
                Dim intAffectedRow As Integer = (New clsDLInvoice()).AddInvoiceItemDetails(objBEInvoice)
                If intAffectedRow > 0 Then
                    objBEOrder.JOBID = IntJobId
                    objBEOrder.VatRate = "0.2"
                    objBEOrder.InvoiceDate = DateTime.ParseExact(txtInvoiceDate.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                    Dim intAffectedRowOrder As Integer = (New clsDLOrder()).UpdateOrderDetailsByInvoice(objBEOrder)
                    If intAffectedRowOrder > 0 Then
                        Dim javaScript As String = ""
                        javaScript += "<script type='text/javascript'>"
                        javaScript += "$(document).ready(function(){"
                        javaScript += "ShowPopup('Job Costs were updated','success');"
                        javaScript += "});"
                        javaScript += "</script>"
                        ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                        txtCost.Text = ""
                        ddlunit.SelectedIndex = 0
                        txtInvoiceDate.Value = ""
                        txthourqty.Text = ""
                        ddlqty.SelectedIndex = 0
                        BindGridview()
                        Dim msg As String = "Please find attached invoice for job number " + txtJobNumber.Text + " total including VAT is £" + hdnIncVat.Value + "" & vbCrLf & vbCrLf
                        msg += "Payment can be made to" & vbCrLf
                        msg += "Bank of Scotland" & vbCrLf
                        msg += "A/c Number:  10215163" & vbCrLf
                        msg += "Sort code:  80-11-80" & vbCrLf
                        InvoiceMessage.Text = msg
                    End If
                End If

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

            End Try
        Else
            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowPopupBlank('Please Fill Description Field.');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        End If


    End Sub




    Protected Sub GetClientEmailId()
        Try
            Dim dstClientEmail As New DataSet()
            objBEClientContact.ClientId = hdnCid.Value
            dstClientEmail = (New clsDLClientcontact()).GetClientContactEmail(objBEClientContact)
            objFunction.FillDropDownByDataSet(ddlEmail, dstClientEmail)
            ddlEmail.Items.Insert(0, "Select Email Address")

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub
    Protected Sub BindGridview()

        Try
            Dim intJobId = objFunction.ReturnInteger(Session("JID"))
            Dim dstJobCost As New DataSet()
            objBEInvoice.JOBID = intJobId
            dstJobCost = (New clsDLInvoice()).GetInvoiceItemDetailsById(objBEInvoice)
            Dim dblTotalAmountVal As Double = 0
            Dim dblVat As Double = 0
            Dim dblIncVat As Double = 0
            If objFunction.CheckDataSet(dstJobCost) Then
                grdInvoice.DataSource = dstJobCost
                grdInvoice.DataBind()
                For i = 0 To dstJobCost.Tables(0).Rows.Count - 1
                    dblTotalAmountVal += objFunction.ReturnDouble(dstJobCost.Tables(0).Rows(i)("Total"))
                Next
                dblVat = dblTotalAmountVal * 20 / 100
                dblIncVat = dblVat + dblTotalAmountVal
                hdnIncVat.Value = String.Format("{0:n2}", dblIncVat).ToString()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        If InvoiceMessage.Text <> "" And ddlEmail.SelectedItem.Value <> "Select" Then
            SendMailWithPDF()
        Else
            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowPopupBlank('Please Select an EmailId to send Email');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        End If

    End Sub

    Protected Sub SendMailWithPDF()
        Try
            Dim bytes As Byte() = Nothing
            Dim sw As StringWriter = New StringWriter()
            HttpContext.Current.Server.Execute("invoice_Pdf.aspx", sw)
            Dim htmlText = sw.ToString()
            Using memoryStream As New MemoryStream()
                Using document As New Document()
                    Dim writer = PdfWriter.GetInstance(document, memoryStream)
                    document.Open()
                    Using cssMemoryStream As New MemoryStream(System.Text.Encoding.UTF8.GetBytes("")) 'cssText1 + cssText2
                        Using htmlMemoryStream As New MemoryStream(System.Text.Encoding.UTF8.GetBytes(htmlText))
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, htmlMemoryStream, cssMemoryStream)
                        End Using
                    End Using
                End Using
                bytes = memoryStream.ToArray()
            End Using
            'Dim strLink As String = "~InvoicePDF/Test.txt"
            Dim strMailStatus As String = clsEmail.SendEmail(ddlEmail.SelectedItem.Text, "Fast Fixx Quote ~", InvoiceMessage.Text, bytes, Me)

            If strMailStatus = "Success" Then
                If txtStatus.Text <> "Paid" Then
                    Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
                    objBEStatusHistory.JOBID = IntJobId
                    objBEStatusHistory.From = txtStatus.Text
                    objBEStatusHistory.ToStatus = "Invoice Sent"
                    objBEStatusHistory.TodayDate = DateTime.Now
                    Dim intAffectedRow As Integer = (New ClsDLStatusHistory()).AddStatusHistory(objBEStatusHistory)
                    If intAffectedRow > 0 Then
                        objBEOrder.JOBID = IntJobId
                        objBEOrder.Status = "Invoice Sent"
                        intAffectedRow = (New clsDLOrder()).UpdateOrderStatus(objBEOrder)
                        If intAffectedRow > 0 Then
                            Dim javaScript As String = ""
                            javaScript += "<script type='text/javascript'>"
                            javaScript += "$(document).ready(function(){"
                            javaScript += "ShowPopup('Email sent successfully','success');"
                            javaScript += "});"
                            javaScript += "</script>"
                            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                        End If
                    End If
                Else
                    Dim javaScript As String = ""
                    javaScript += "<script type='text/javascript'>"
                    javaScript += "$(document).ready(function(){"
                    javaScript += "ShowPopup('Email sent successfully','success');"
                    javaScript += "});"
                    javaScript += "</script>"
                    ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                End If
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub rdoEmail_CheckedChanged(sender As Object, e As EventArgs) Handles rdoEmail.CheckedChanged
        btnEmail.Enabled = True
        Dim msg As String = "Please find attached invoice for job number " + txtJobNumber.Text + " total including VAT is £" + hdnIncVat.Value + "" & vbCrLf & vbCrLf
        msg += "Payment can be made to" & vbCrLf
        msg += "Bank of Scotland" & vbCrLf
        msg += "A/c Number:  10215163" & vbCrLf
        msg += "Sort code:  80-11-80" & vbCrLf
        InvoiceMessage.Text = msg
    End Sub

    Protected Sub grdInvoice_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdInvoice.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdInvoice.DataKeys(e.RowIndex).Values("InvoiceItemlID")))
            objBEInvoice.InvoiceItemlID = id
            Dim intAffectedRow As Integer = (New clsDLInvoice()).PerformGridViewOpertaion("DELETE", objBEInvoice)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else

            End If
            grdInvoice.EditIndex = -1
            BindGridview()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub rdopreview_CheckedChanged(sender As Object, e As EventArgs) Handles rdopreview.CheckedChanged

        Dim JobID As String = objFunction.ReturnString(Session("JID"))
        Dim pageurl As String = "Invoice_Preview.aspx?JID=" + JobID + ""
        Response.Write("<script>window.open ('" + pageurl + "','_blank');</script>")

    End Sub

    Protected Sub grdInvoice_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdInvoice.RowCancelingEdit
        Try
            grdInvoice.EditIndex = -1
            BindGridview()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdInvoice_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdInvoice.RowEditing
        Try
            grdInvoice.EditIndex = e.NewEditIndex
            BindGridview()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdInvoice_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdInvoice.RowUpdating
        Try

            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdInvoice.DataKeys(e.RowIndex).Values("InvoiceItemlID")))
            Dim txtdesc As TextBox = DirectCast(grdInvoice.Rows(e.RowIndex).FindControl("txtdesc"), TextBox)
            Dim txtUnit As TextBox = DirectCast(grdInvoice.Rows(e.RowIndex).FindControl("txtUnit"), TextBox)
            Dim txtqty As TextBox = DirectCast(grdInvoice.Rows(e.RowIndex).FindControl("txtqty"), TextBox)
            Dim txtline As TextBox = DirectCast(grdInvoice.Rows(e.RowIndex).FindControl("txtline"), TextBox)
            Dim txtcost As TextBox = DirectCast(grdInvoice.Rows(e.RowIndex).FindControl("txtcost"), TextBox)

            objBEInvoice.InvoiceItemlID = id
            objBEInvoice.ItemDesctiption = txtdesc.Text
            objBEInvoice.UNIT = txtUnit.Text
            objBEInvoice.Nos = txtqty.Text
            objBEInvoice.Line = txtline.Text
            objBEInvoice.Cost = txtcost.Text


            Dim intAffectedRow As Integer = (New clsDLInvoice()).PerformGridViewOpertaion("UPDATE", objBEInvoice)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            End If
            grdInvoice.EditIndex = -1
            BindGridview()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdInvoice_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdInvoice.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim lb As LinkButton = DirectCast(e.Row.Cells(7).Controls(2), LinkButton)
            If lb IsNot Nothing Then
                If lb.Text = "Delete" Then
                    lb.Attributes.Add("onclick", "javascript:return ShowDeletePopup(this, 'Record will be Permanently Deleted')")
                End If
            End If
        End If
    End Sub

    Protected Sub rdoprint_CheckedChanged(sender As Object, e As EventArgs) Handles rdoprint.CheckedChanged

    End Sub

    Protected Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Dim JobID As String = objFunction.ReturnString(Session("JID"))
        Dim pageurl As String = "Invoice_Preview.aspx?JID=" + JobID + ""
        Response.Write("<script>window.open ('" + pageurl + "','_blank');</script>")
    End Sub

    Protected Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim JobID As String = objFunction.ReturnString(Session("JID"))
        Dim pageurl As String = "Invoice_Print.aspx?JID=" + JobID + ""
        Response.Write("<script>window.open ('" + pageurl + "','_blank');</script>")
    End Sub
End Class