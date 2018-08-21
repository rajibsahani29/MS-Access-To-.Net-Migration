Imports CRM.BE
Imports CRM.DL
Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.tool.xml
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text
Public Class job_quote
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBELabour As clsBEQuoteLabour = New clsBEQuoteLabour
    Dim objBEPulldown As clsBEPulldown = New clsBEPulldown
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Dim objBEQuotePart As clsBEQuotePart = New clsBEQuotePart
    Dim objBEClientContact As clsBEClientcontact = New clsBEClientcontact
    Dim objBEInvoice As clsBEInvoice = New clsBEInvoice
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Session("JID")) = "" And Session("JID") Is Nothing Then
            Response.Redirect("job_select.aspx")
        End If
        If Not Page.IsPostBack Then
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            GetOrderDetails(IntJobId)
            FillGrid()
            FillGridPart()
            'Dim dstPulldown As DataSet = (New clsDLPulldownIntegers()).GetPulldownQtyFillInDD()
            'objFunction.FillDropDownByDataSet(ddlqty, dstPulldown)
            'ddlqty.Items.Insert(0, "Qty")

            objBEPulldown.Group = "Rate"
            Dim dstrate As DataSet = (New ClsDLPulldown()).GetPulldownEngineerFillInDD(objBEPulldown)
            objFunction.FillDropDownByDataSet(ddlcost, dstrate)
            ddlcost.Items.Insert(0, "Cost")

            objBEPulldown.Group = "Hours Type"
            Dim dstHour As DataSet = (New ClsDLPulldown()).GetPulldownEngineerFillInDD(objBEPulldown)
            objFunction.FillDropDownByDataSet(ddlhrs, dstHour)
            ddlhrs.Items.Insert(0, "Hours")

            objBEPulldown.Group = "Additional Charge"
            Dim dstAdditional As DataSet = (New ClsDLPulldown()).GetPulldownEngineerFillInDD(objBEPulldown)
            objFunction.FillDropDownByDataSet(ddlAdditional, dstAdditional)
            ddlAdditional.Items.Insert(0, "Additional Charge")
            ddlAdditional.Items.Insert(1, "Edit & Delete")






            Dim dstsupplier As DataSet = (New clsDLSupplier()).GetSupplierFillInDD()
            objFunction.FillDropDownByDataSet(ddlSupplier, dstsupplier)
            ddlSupplier.Items.Insert(0, "Select Supplier")

            Dim dstvat As DataSet = (New clsDLPulldownVatrate()).GetPullDownVatRatesFillInDD()
            objFunction.FillDropDownByDataSet(ddlVat, dstvat)
            ddlVat.Items.Insert(0, "Select Vat")
            ddlVat.Items.Insert(1, "Edit & Delete")

            Dim dstday As DataSet = (New clsDLPulldownIntegers()).GetPulldownDaysFillInDD()
            objFunction.FillDropDownByDataSet(ddldays, dstday)
            ddldays.Items.Insert(0, "Select Days")


            Dim dstqty As DataSet = (New clsDLPulldownIntegers()).GetPulldownIntegersFillInDD()
            objFunction.FillDropDownByDataSet(ddlqty1, dstqty)
            ddlqty1.Items.Insert(0, "Select")
        End If
    End Sub

    Protected Sub GetOrderDetails(ByVal id As Integer)
        Try
            Dim dstJobList As New DataSet()
            objBEOrder.JOBID = id
            dstJobList = (New clsDLOrder()).GetJobDetailsByJobID(objBEOrder)
            If dstJobList IsNot Nothing Then
                txtCompanyName.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Name"))
                txtEngineer.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Engineer"))
                txtJobNum.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("JobNumber"))
                txtStatus.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Status"))
                hdnCid.Value = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("OID"))
                BindVat()
                txtVat.Text = String.Format("{0:n2}", (objFunction.ReturnDouble(txtExvat.Text) * objFunction.ReturnDouble(dstJobList.Tables(0).Rows(0)("VatRate")))).ToString()
                txtOrderTotal.Text = (objFunction.ReturnDouble(txtExvat.Text) + objFunction.ReturnDouble(txtVat.Text)).ToString()
                txtQuoteNum.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("JobNumber"))
            End If
            objBEClientContact.ClientId = objFunction.ReturnInteger(hdnCid.Value)
            Dim dstEmail As DataSet = (New clsDLClientcontact()).GetClientEmailFillinDD(objBEClientContact)
            objFunction.FillDropDownByDataSet(ddlEmail, dstEmail)
            ddlEmail.Items.Insert(0, "Select")

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
    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            objBELabour.JOBID = IntJobId
            objBELabour.HoursCharged = ddlqty.Text
            objBELabour.HoursType = ddlhrs.SelectedItem.Text
            objBELabour.rate = ddlcost.SelectedItem.Text
            objBELabour.Comment = ""
            objBELabour.enquireID = 0
            Dim intAffectedRow As Integer = (New clsDLQuoteLabour()).AddLabourQuoteDetails(objBELabour)
            If intAffectedRow > 0 Then
                'Dim str As String = txtPartNo.Text
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Labour Added To This Job Sucessfully','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                ddlqty.Text = ""
                ddlhrs.SelectedIndex = 0
                ddlcost.SelectedIndex = 0
                FillGrid()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub

    Public Sub FillGrid()
        Try
            Dim dstList As New DataSet()
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            objBELabour.JOBID = IntJobId
            dstList = (New clsDLQuoteLabour()).GetLabourQuoteByJOBID(objBELabour)
            If objFunction.CheckDataSet(dstList) Then
                grdLabour.DataSource = dstList
                grdLabour.DataBind()
                Dim dblTotalAmount As Double = 0
                For i = 0 To dstList.Tables(0).Rows.Count - 1
                    dblTotalAmount += objFunction.ReturnDouble(dstList.Tables(0).Rows(i)("TotalCost"))
                Next
                txtLabour.Text = dblTotalAmount.ToString()
                txtTotal.Text = dblTotalAmount.ToString()
            Else
                grdLabour.DataSource = New List(Of String)
                grdLabour.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdLabour_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdLabour.RowEditing
        Try
            grdLabour.EditIndex = e.NewEditIndex
            FillGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdLabour_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdLabour.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdLabour.DataKeys(e.RowIndex).Values("QuoteLabourID")))
            Dim txtcharged As TextBox = DirectCast(grdLabour.Rows(e.RowIndex).FindControl("txtcharged"), TextBox)
            Dim txtrate As TextBox = DirectCast(grdLabour.Rows(e.RowIndex).FindControl("txtrate"), TextBox)
            Dim txthrs As TextBox = DirectCast(grdLabour.Rows(e.RowIndex).FindControl("txthrs"), TextBox)
            objBELabour.QuoteLabourID = id
            objBELabour.HoursCharged = txtcharged.Text
            objBELabour.HoursType = txthrs.Text
            objBELabour.rate = txtrate.Text
            Dim intAffectedRow As Integer = (New clsDLQuoteLabour()).UpdateLabourQuoteDetails(objBELabour)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Labour Quote details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else

            End If
            grdLabour.EditIndex = -1
            FillGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdLabour_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdLabour.RowCancelingEdit
        Try
            grdLabour.EditIndex = -1
            FillGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdLabour_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdLabour.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdLabour.DataKeys(e.RowIndex).Values("QuoteLabourID")))
            objBELabour.QuoteLabourID = id
            Dim intAffectedRow As Integer = (New clsDLQuoteLabour()).DeleteLabourQuoteDetails(objBELabour)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Job Allocation details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                'ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "scriptKey", "ShowPopup('Job Allocation details have been Deleted','success');", True)

            Else

            End If
            grdLabour.EditIndex = -1
            FillGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub grdLabour_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdLabour.RowDataBound
        Try
            If e.Row.RowType = DataControlRowType.DataRow Then
                Dim lb As LinkButton = DirectCast(e.Row.Cells(7).Controls(2), LinkButton)

                If lb IsNot Nothing Then
                    If lb.Text = "Delete" Then
                        lb.Attributes.Add("onclick", "javascript:return ShowDeletePopup(this, 'Record will be Permanently Deleted')")
                        'lb.Attributes.Add("onclick", "javascript:return " + "confirm('Are you sure you want to delete this record ?')")

                    End If
                End If
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub btnAdditional_Click(sender As Object, e As EventArgs) Handles btnAdditional.Click
        Dim dblTotalAmount As Double = 0
        hdnsum.Value = (objFunction.ReturnDouble(txtCharge.Text) + objFunction.ReturnDouble(hdnsum.Value)).ToString()
        txtAdditional.Text = hdnsum.Value.ToString()
        dblTotalAmount = objFunction.ReturnDouble(txtLabour.Text) + objFunction.ReturnDouble(txtAdditional.Text)
        txtTotal.Text = dblTotalAmount.ToString()
    End Sub

    Protected Sub btnAddpart_Click(sender As Object, e As EventArgs) Handles btnAddpart.Click
        Try
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            objBEQuotePart.JOBID = IntJobId
            objBEQuotePart.PartNumber = txtPartNum.Text
            objBEQuotePart.Quantity = ddlqty1.SelectedItem.Text
            objBEQuotePart.Supplier = ddlSupplier.SelectedItem.Text
            objBEQuotePart.SellPrice = txtSellPrice.Text
            objBEQuotePart.UnitPrice = txtCostPrice.Text
            objBEQuotePart.Description = txtAreaDescription.Text

            Dim intAffectedRow As Integer = (New clsDLQuotePart()).AddQuotePartsDetails(objBEQuotePart)
            If intAffectedRow > 0 Then
                'Dim str As String = txtPartNo.Text
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Part Details Added To This Job Sucessfully','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                ddlqty1.SelectedIndex = 0
                ddlSupplier.SelectedIndex = 0
                txtAreaDescription.Text = ""
                txtCostPrice.Text = ""
                txtSellPrice.Text = ""
                txtPartNum.Text = ""
                FillGridPart()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub

    Public Sub FillGridPart()
        Try
            Dim dstList As New DataSet()
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            objBEQuotePart.JOBID = IntJobId
            dstList = (New clsDLQuotePart()).GetQuotePartsDetailsByJOBID(objBEQuotePart)
            If objFunction.CheckDataSet(dstList) Then
                grdPart.DataSource = dstList
                grdPart.DataBind()
                Dim dblTotalAmount As Double = 0
                For i = 0 To dstList.Tables(0).Rows.Count - 1
                    dblTotalAmount += objFunction.ReturnDouble(dstList.Tables(0).Rows(i)("Total"))
                Next
                txtParts.Text = dblTotalAmount.ToString()
                txtTotal.Text = (dblTotalAmount + objFunction.ReturnDouble(txtTotal.Text)).ToString()
            Else
                grdPart.DataSource = Nothing
                grdPart.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPart_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdPart.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdPart.DataKeys(e.RowIndex).Values("JobPartID")))
            objBEQuotePart.JobPartID = id
            Dim intAffectedRow As Integer = (New clsDLQuotePart()).DeleteQuotePartsDetails(objBEQuotePart)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Job Part details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdPart.EditIndex = -1
            FillGridPart()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub grdPart_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdPart.RowDataBound
        Try
            If e.Row.RowType = DataControlRowType.DataRow Then
                Dim lb As LinkButton = DirectCast(e.Row.Cells(9).Controls(2), LinkButton)

                If lb IsNot Nothing Then
                    If lb.Text = "Delete" Then
                        lb.Attributes.Add("onclick", "javascript:return ShowDeletePopup(this, 'Record will be Permanently Deleted')")

                    End If
                End If
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPart_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdPart.RowEditing
        Try
            grdPart.EditIndex = e.NewEditIndex
            FillGridPart()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPart_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdPart.RowCancelingEdit
        Try
            grdPart.EditIndex = -1
            FillGridPart()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPart_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdPart.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdPart.DataKeys(e.RowIndex).Values("JobPartID")))
            objBEQuotePart.JobPartID = id
            Dim txtpartno As TextBox = DirectCast(grdPart.Rows(e.RowIndex).FindControl("txtpartno"), TextBox)
            Dim txtunitp As TextBox = DirectCast(grdPart.Rows(e.RowIndex).FindControl("txtunitp"), TextBox)
            Dim txtsellp As TextBox = DirectCast(grdPart.Rows(e.RowIndex).FindControl("txtsellp"), TextBox)
            objBEQuotePart.PartNumber = txtpartno.Text
            objBEQuotePart.UnitPrice = txtunitp.Text
            objBEQuotePart.SellPrice = txtsellp.Text
            Dim intAffectedRow As Integer = (New clsDLQuotePart()).UpdateQuotePartsDetails(objBEQuotePart)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Labour Quote details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else

            End If
            grdPart.EditIndex = -1
            FillGridPart()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
    Protected Sub UpdateQuote()
        Try
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            objBEOrder.JOBID = IntJobId
            Dim strArr() As String
            strArr = txtQuoteEnquiryDate.Text.Split("/")
            Dim dd As String = strArr(0)
            Dim mm As String = strArr(1)
            Dim yy As String = strArr(2)
            Dim dt As String = mm + "/" + dd + "/" + yy
            objBEOrder.QuoteDate = Convert.ToDateTime(dt)
            'objBEOrder.QuoteDate = txtQuoteEnquiryDate.Text
            objBEOrder.QuoteDays = ddldays.SelectedItem.Text
            objBEOrder.QuoteNumber = txtQuoteNum.Text
            objBEOrder.QuoteVatRate = ddlVat.SelectedItem.Text
            Dim intAffectedRow As Integer = (New clsDLOrder()).UpdateQuotationDetailsByJobID(objBEOrder)
            If intAffectedRow > 0 Then

            Else

            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
    Protected Sub ChooseLabourCostToSend()
        Try
            Dim flag As Boolean = False
            Dim labourid As String = ""
            Dim concanet As String = ""

            For Each row As GridViewRow In grdLabour.Rows
                If row.RowType = DataControlRowType.DataRow Then
                    Dim chkRow As CheckBox = TryCast(row.Cells(0).FindControl("chkRow"), CheckBox)
                    If chkRow.Checked Then
                        'Dim id As Integer = TryCast(row.Cells(1).FindControl("lblRequestId"), Label).Text
                        labourid = objFunction.ReturnString(grdLabour.DataKeys(row.RowIndex)("QuoteLabourID"))
                        flag = True
                        If (concanet = "") Then
                            concanet = labourid
                        Else
                            concanet = concanet + "," + labourid
                        End If
                    End If
                    hdnLabour.Value = concanet.ToString()
                    'hdnLabour.Value = labourid.ToString()

                End If
            Next

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
    Protected Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        If txtQuoteNum.Text <> "" And txtQuoteEnquiryDate.Text <> "" And ddldays.SelectedIndex <> 0 And ddlVat.SelectedIndex <> 0 Then
            UpdateQuote()
            ChooseLabourCostToSend()
            If rdopreview.Checked() Then
                Dim IntJobId = objFunction.ReturnString(Session("JID"))
                Session("QuoteLabourId") = hdnLabour.Value
                Response.Write("<script>window.open ('job_Quote_Print.aspx?ID=" + IntJobId + "','_blank');</script>")
            ElseIf rdoEmail.Checked() Then
                If txtMessage.Text <> "" And txtMessage.Text <> "" Then
                    SendMailWithPDF()
                Else
                    Dim javaScript As String = ""
                    javaScript += "<script type='text/javascript'>"
                    javaScript += "$(document).ready(function(){"
                    javaScript += "ShowPopupBlank('Fill All the Details First for Email Sending.');"
                    javaScript += "});"
                    javaScript += "</script>"
                    ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                End If
            Else
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopupBlank('Select Any One !');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            End If
        Else
            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowPopupBlank('Please Enter Vat Rate,Quote Days,Quote Date First!');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        End If



    End Sub

    Protected Sub SendMailWithPDF()
        Try
            Dim bytes As Byte() = Nothing
            Dim sw As StringWriter = New StringWriter()
            HttpContext.Current.Server.Execute("job_Quote_pdf.aspx", sw)
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
            Dim strMailStatus As String = clsEmail.SendEmail(ddlEmail.SelectedItem.Text, "Fast Fixx Quote ~" + txtQuoteNum.Text + "", txtMessage.Text, bytes, Me)

            If strMailStatus = "Success" Then

                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Email sent successfully','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
        Catch ex As Exception
            Response.Write(ex.Message)

        End Try
    End Sub

    Protected Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Response.Redirect("job_quote.aspx")
    End Sub
End Class