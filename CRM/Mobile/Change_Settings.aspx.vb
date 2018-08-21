Imports CRM.BE
Imports CRM.DL

Public Class Change_Settings1
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEStaff As clsBEStaff = New clsBEStaff



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim intUserId = objFunction.ReturnInteger(Session("LoginUserId"))
            FillDetails(intUserId)

        End If
    End Sub
    Public Sub FillDetails(ByVal id As Integer)

        Try
            Dim objDLStaff As clsDLStaff = New clsDLStaff
            objBEStaff.StaffID = id
            Dim dst As DataSet = objDLStaff.GetPasswordByStaffId(objBEStaff)
            If objFunction.CheckDataSet(dst) Then
                hdnCurrentPwd.Value = objFunction.ReturnString(dst.Tables(0).Rows(0)("Pwd"))
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        Try
            Dim objDLStaff As clsDLStaff = New clsDLStaff
            objBEStaff.Password = txtnewPassword.Text
            objBEStaff.StaffID = objFunction.ReturnString(Session("LoginUserId"))
            Dim intAffectedRow As Integer = objDLStaff.ChangeStaffMemberPassword(objBEStaff)
            Trace.Warn("intAffectedRow = " + objFunction.ReturnString(intAffectedRow))
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Password updated!','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

                If (Request.Cookies("LoginDetailMobile") IsNot Nothing) Then
                    Request.Cookies("LoginDetailMobile").Value = ""
                    Dim nameCookie As HttpCookie = Request.Cookies("LoginDetailMobile")
                    nameCookie.Expires = DateTime.Now.AddDays(-1)
                    Response.Cookies.Add(nameCookie)
                End If
            Else
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Try Again After Sometime.','error');"
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