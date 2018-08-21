Imports CRM.BE
Imports CRM.DL
Public Class add_company
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEClient As clsBEClient = New clsBEClient

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

        End If
    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            objBEClient.CompanyName = txtCompanyName.Text
            objBEClient.Forename = txtForename.Text
            objBEClient.Surname = txtSurname.Text
            objBEClient.Fax = txtFax.Text
            objBEClient.Email = txtEmail.Text
            objBEClient.ContactPosition = txtContactPos.Text
            objBEClient.Street = txtStreet.Text
            objBEClient.Town = txtTown.Text
            objBEClient.Postcode = txtPostCode.Text
            objBEClient.Phone = txtPhone.Text
            objBEClient.MobileNumber = txtMobNum.Text
            objBEClient.Area = txtArea.Text
            objBEClient.OnStatementList = 0
            objBEClient.UpliftPayment = 0
            objBEClient.RemittanceSlip = 0
            objBEClient.OnStop = 0
            objBEClient.NullNoJob = 0
            Dim intAffectedRow As Integer = (New clsDLClient()).AddClientDetails(objBEClient)
            If intAffectedRow > 0 Then
                'Dim str As String = txtPartNo.Text

                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('New Client Added Sucessfully','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub
End Class