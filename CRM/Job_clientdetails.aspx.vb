Imports CRM.BE
Imports CRM.DL
Public Class Job_clientdetails
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Dim objBEClient As clsBEClient = New clsBEClient
    Dim objBEClientContact As clsBEClientcontact = New clsBEClientcontact
    Dim objBEInvoice As clsBEInvoice = New clsBEInvoice
    Dim objBEClientRate As ClsBEClientRate = New ClsBEClientRate




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If objFunction.ReturnString(Session("JID")) = "" And Session("JID") Is Nothing Then
            Response.Redirect("job_select.aspx")
        End If

        If Not Page.IsPostBack Then

            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            Dim dstFFrates As DataSet = (New clsDLFFrates()).GetFFratesFillInDD()
            objFunction.FillDropDownByDataSet(ddlHourlyRate, dstFFrates)
            ddlHourlyRate.Items.Insert(0, New ListItem("Select Rate", ""))
            ddlHourlyRate.Items.Insert(1, New ListItem("Edit Rate", "Edit"))
            GetOrderDetails(IntJobId)


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
                GetClientDetails(objFunction.ReturnInteger(hdnCid.Value))
                GetClientContactDetails(objFunction.ReturnInteger(hdnCid.Value))
                GetClientRateDetails(objFunction.ReturnInteger(hdnCid.Value))

            End If


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub


    Protected Sub GetClientDetails(ByVal id As Integer)
        Try
            Dim dstClient As New DataSet()
            objBEClient.ClientId = id
            dstClient = (New clsDLClient()).GetClientDetailById(objBEClient)
            If dstClient IsNot Nothing Then
                txtCompany1.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Cname"))
                txtContactPosition.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("contact"))
                txtForName.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Forename"))
                txtSurName.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Surname"))
                txtStreet.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Street"))
                txtArea.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Area"))
                txtTown.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Town"))
                txtPhone.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Phone"))
                txtFax.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Fax"))
                txtPostCode.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Postcode"))
                ddlHourlyRate.SelectedValue = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("RateID"))

                If (dstClient.Tables(0).Rows(0)("UpliftPayment") = False) Then
                    chkUplift.Checked = False
                Else
                    chkUplift.Checked = True

                End If
                If (dstClient.Tables(0).Rows(0)("onstatement") = False) Then
                    chkOnStatement.Checked = False
                Else
                    chkOnStatement.Checked = True

                End If
                If (dstClient.Tables(0).Rows(0)("OnStop") = True) Then
                    chkOnStop.Checked = True
                Else
                    chkOnStop.Checked = False
                End If
                If (dstClient.Tables(0).Rows(0)("RemittanceSlip") = True) Then
                    chkRemittance.Checked = True
                Else
                    chkRemittance.Checked = False
                End If

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
            objBEInvoice.JOBID = intJobId
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

    Protected Sub GetClientContactDetails(ByVal id As Integer)
        Try
            Dim dstClientContact As New DataSet()
            objBEClientContact.ClientId = id
            dstClientContact = (New clsDLClientcontact()).GetClientContactByClientId(objBEClientContact)
            GridView1.DataSource = dstClientContact
            GridView1.DataBind()

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub

    Protected Sub GetClientRateDetails(ByVal id As Integer)
        Try
            Dim dstClientRate As New DataSet()
            objBEClientRate.ClientId = id
            dstClientRate = (New ClsDLClientRate()).GetFFClientratesDetails(objBEClientRate)
            grdRate.DataSource = dstClientRate
            grdRate.DataBind()

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub



    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (ddlHourlyRate.SelectedValue = "") Then
            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowPopupBlank('Fill All the Details First.');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        Else

            Try

                Dim objBEclient As clsBEClient = New clsBEClient
                objBEclient.CompanyName = txtcompany1.Text
                objBEclient.Phone = txtPhone.Text
                objBEclient.ClientId = hdnCid.Value
                objBEclient.Postcode = txtPostCode.Text
                objBEclient.Street = txtStatus.Text
                objBEclient.Area = txtArea.Text
                objBEclient.ContactPosition = txtContactPosition.Text
                objBEclient.Forename = txtForName.Text
                objBEclient.Surname = txtSurName.Text
                objBEclient.Fax = txtFax.Text
                Dim strarr() As String
                strarr = ddlHourlyRate.SelectedItem.Text.Split(":-")
                Dim hourlyRate As String = strarr(1).Replace("-", "")
                objBEclient.HourlyRate = hourlyRate

                If (chkUplift.Checked) Then
                        objBEclient.UpliftPayment = True
                    Else
                        objBEclient.UpliftPayment = False

                    End If
                    If (chkOnStatement.Checked) Then
                        objBEclient.OnStatementList = True
                    Else
                        objBEclient.OnStatementList = False
                    End If
                    If (chkOnStop.Checked) Then
                        objBEclient.OnStop = True
                    Else
                        objBEclient.OnStop = False
                    End If
                If (chkRemittance.Checked) Then
                    objBEclient.RemittanceSlip = True
                Else
                    objBEclient.RemittanceSlip = False
                End If
                objBEclient.RateID = ddlHourlyRate.SelectedValue
                Dim intAffectedRow As Integer = (New clsDLClient()).UpdateClientDetailsByID(objBEclient)
                If intAffectedRow > 0 Then
                    objBEClientRate.rateID = ddlHourlyRate.SelectedValue
                    objBEClientRate.ClientId = objFunction.ReturnInteger(hdnCid.Value)
                    Dim intAffectedRowRate As Integer = (New ClsDLClientRate()).GetFFratesDetailsByClientId(objBEClientRate)
                    If (intAffectedRowRate > 0) Then

                    Else
                        Dim intAffectedRow1 As Integer = (New ClsDLClientRate()).AddFFClientratesDetails(objBEClientRate)
                        If intAffectedRow1 > 0 Then
                            Dim javaScript As String = ""
                            javaScript += "<script type='text/javascript'>"
                            javaScript += "$(document).ready(function(){"
                            javaScript += "ShowPopupReload('Client details have been updated','success');"
                            'javaScript += " $('.confirm').click(function () {"
                            'javaScript += "location.href = 'Job_clientdetails.aspx';"
                            'javaScript += " });"
                            javaScript += "});"
                            javaScript += "</script>"
                            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                        End If
                    End If


                    End If
            Catch ex As Exception
                    HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                    HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
                    Dim javaScript As String = ""
                    javaScript += "<script type='text/javascript'>"
                    javaScript += "$(document).ready(function(){"
                    javaScript += "ShowPopup(ex.Message,'error');"
                    javaScript += "});"
                    javaScript += "</script>"
                    ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                End Try
            End If

    End Sub

    Protected Sub GridView1_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles GridView1.RowEditing
        Try
            GridView1.EditIndex = e.NewEditIndex
            GetClientContactDetails(objFunction.ReturnInteger(hdnCid.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub GridView1_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles GridView1.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(GridView1.DataKeys(e.RowIndex).Values("ContactID")))
            Dim txtfname As TextBox = DirectCast(GridView1.Rows(e.RowIndex).FindControl("txtforename"), TextBox)
            Dim txtsname As TextBox = DirectCast(GridView1.Rows(e.RowIndex).FindControl("txtSurname"), TextBox)
            Dim txtline As TextBox = DirectCast(GridView1.Rows(e.RowIndex).FindControl("txtline"), TextBox)
            Dim txtnotes As TextBox = DirectCast(GridView1.Rows(e.RowIndex).FindControl("txtNotes"), TextBox)
            Dim txtEmail As TextBox = DirectCast(GridView1.Rows(e.RowIndex).FindControl("txtEmail"), TextBox)
            objBEClientContact.ClientContactId = id
            objBEClientContact.Forename = txtfname.Text
            objBEClientContact.Surname = txtsname.Text
            objBEClientContact.DirectLine = txtline.Text
            objBEClientContact.Notes = txtnotes.Text
            objBEClientContact.Email = txtEmail.Text

            Dim intAffectedRow As Integer = (New clsDLClientcontact()).PerformGridViewOpertaion("UPDATE", objBEClientContact)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Client Contact details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else

            End If
            GridView1.EditIndex = -1
            GetClientContactDetails(objFunction.ReturnInteger(hdnCid.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub GridView1_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles GridView1.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(GridView1.DataKeys(e.RowIndex).Values("ContactID")))
            objBEClientContact.ClientContactId = id

            Dim intAffectedRow As Integer = (New clsDLClientcontact()).PerformGridViewOpertaion("DELETE", objBEClientContact)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Client Contact details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else

            End If
            GridView1.EditIndex = -1
            GetClientContactDetails(objFunction.ReturnInteger(hdnCid.Value))
            'Response.Redirect("job_allocation.aspx", False)
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        Try
            GridView1.PageIndex = e.NewPageIndex
            GetClientContactDetails(objFunction.ReturnInteger(hdnCid.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub GridView1_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles GridView1.RowCancelingEdit
        Try
            GridView1.EditIndex = -1
            GetClientContactDetails(objFunction.ReturnInteger(hdnCid.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub GridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView1.RowDataBound
        Try
            If e.Row.RowType = DataControlRowType.DataRow Then
                Dim lb As LinkButton = DirectCast(e.Row.Cells(0).Controls(2), LinkButton)
                If lb IsNot Nothing Then
                    If lb.Text = "Delete" Then
                        'Dim a As String = lb.ID
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

    Protected Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Response.Redirect("Job_clientdetails.aspx")
    End Sub

    Protected Sub grdRate_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdRate.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdRate.DataKeys(e.RowIndex).Values("Id")))
            objBEClientRate.Id = id
            Dim intAffectedRow As Integer = (New ClsDLClientRate()).DeleteFFClientratesDetails(objBEClientRate)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Client Rate details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else

            End If
            grdRate.EditIndex = -1
            GetClientRateDetails(objFunction.ReturnInteger(hdnCid.Value))
            'Response.Redirect("job_allocation.aspx", False)
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdRate_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdRate.RowDataBound
        Try
            If e.Row.RowType = DataControlRowType.DataRow Then
                Dim lb As LinkButton = DirectCast(e.Row.Cells(3).Controls(0), LinkButton)
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

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            objBEClientContact.ClientId = objFunction.ReturnInteger(hdnCid.Value)
            objBEClientContact.Forename = txtforename1.Text
            objBEClientContact.Surname = txtSurname1.Text
            objBEClientContact.Email = txtemail.Text
            objBEClientContact.DirectLine = txtdirectline.Text
            objBEClientContact.Notes = txtnotes.Text
            Dim intAffectedRow As Integer = (New clsDLClientcontact()).AddClientContactDetails(objBEClientContact)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('New Client Contact Added Sucessfully','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                GetClientContactDetails(objFunction.ReturnInteger(hdnCid.Value))
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub
End Class