Imports System.Data
Imports CRM.BE
Imports CRM.DL

Public Class pages_login_mobile
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEStaff As clsBEStaff = New clsBEStaff
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If (Request.Cookies("LoginDetailMobile") IsNot Nothing) Then
                If objFunction.ReturnInteger(Request.Cookies("LoginDetailMobile")("UserId")) > 0 Then
                    Session("LoginUserId") = objFunction.ReturnString(Request.Cookies("LoginDetailMobile")("UserId"))
                    Session("UserName") = objFunction.ReturnString(Request.Cookies("LoginDetailMobile")("UserName"))
                End If
            End If
            btnLogin.Enabled = True
            'If Request.Cookies("UserLoginSettings_Mobile") IsNot Nothing Then
            '    If objFunction.ReturnInteger(Request.Cookies("UserLoginSettings_Mobile")("LoginCount")) > 3 Then
            '        Dim message As String = "alert('You have been logged out. Please wait 15 mins and try again')"
            '        ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "alert", message, True)
            '        btnLogin.Enabled = False
            '    End If
            'End If

            If objFunction.ValidateLoginMobile() Then
                Response.Redirect("~/Mobile/Index-mobile.aspx")
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub



    Public Function GetLoginCode() As Boolean

        Dim flag As Boolean = False
        objBEStaff.Email = txtName.Value
        objBEStaff.RandomCode = txtPassword.Text
        Dim objDLStaff As clsDLStaff = New clsDLStaff
        Dim dstLogin As DataSet = objDLStaff.LoginStaffMemberByCode(objBEStaff)
        If objFunction.CheckDataSet(dstLogin) Then
            Session("LoginUserId") = Convert.ToString(dstLogin.Tables(0).Rows(0)("StaffID"))
            flag = True
        End If
        Return flag
    End Function

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If (GetLoginCode()) Then
            Response.Redirect("Change_Password.aspx")
        Else
            Try
                'Dim strArr() As String
                'strArr = txtName.Value.Split(" ")
                'objBEStaff.FirstName = strArr(0)
                'objBEStaff.LastName = strArr(1)
                'objBEStaff.Password = txtPassword.Value
                objBEStaff.Email = txtName.Value
                objBEStaff.Password = txtPassword.Text
                Dim objDLStaff As clsDLStaff = New clsDLStaff
                Dim dstLogin As DataSet = objDLStaff.StaffLogin(objBEStaff)
                If objFunction.CheckDataSet(dstLogin) Then
                    Session("LoginUserName") = Convert.ToString(dstLogin.Tables(0).Rows(0)("username"))
                    Session("LoginUserFirstName") = Convert.ToString(dstLogin.Tables(0).Rows(0)("firstname"))
                    Session("LoginUserId") = Convert.ToString(dstLogin.Tables(0).Rows(0)("StaffID"))
                    Session("UserName") = Convert.ToString(dstLogin.Tables(0).Rows(0)("Fullname"))
                    If (chkRemember.Checked = True) Then
                        Dim mycookie As HttpCookie = New HttpCookie("LoginDetailMobile")
                        mycookie.Values("UserId") = Session("LoginUserId").ToString()
                        mycookie.Values("UserName") = Session("UserName").ToString()
                        mycookie.Expires = System.DateTime.Now.AddDays(15)
                        Response.Cookies.Add(mycookie)
                    End If
                    If (Request.Cookies("UserLoginSettings_Mobile") IsNot Nothing) Then
                        If (objFunction.ReturnString(Request.Cookies("UserLoginSettings_Mobile")("CookieUserName")) = txtName.Value) Then
                            Request.Cookies("UserLoginSettings_Mobile").Value = ""
                            Dim nameCookie As HttpCookie = Request.Cookies("UserLoginSettings_Mobile")
                            nameCookie.Expires = DateTime.Now.AddDays(-1)
                            Response.Cookies.Add(nameCookie)
                        End If
                    End If
                    Response.Redirect("~/Mobile/Index-mobile.aspx")

                Else

                    Dim myCookie As HttpCookie = Request.Cookies("UserLoginSettings_Mobile")
                    If myCookie IsNot Nothing Then
                        Dim times As Integer = objFunction.ReturnInteger(Request.Cookies("UserLoginSettings_Mobile")("LoginCount").ToString())
                        If (times >= 3) Then
                            Dim message As String = "alert('You have been logged out. Please wait 15 mins and try again')"
                            ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "alert", message, True)
                            myCookie("CookieUserName") = txtName.Value
                            myCookie("CookieLoginTime") = DateTime.Now.ToShortTimeString()
                            myCookie.Expires = Now.AddMinutes(15)
                            Response.Cookies.Add(myCookie)
                            txtPassword.Text = ""
                            btnLogin.Enabled = False

                        Else

                            Request.Cookies("UserLoginSettings_Mobile")("LoginCount") = times + 1
                            Response.Cookies.Add(myCookie)
                            txtPassword.Text = ""
                            Dim message As String = "alert('Login details were incorrect')"
                            ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "alert", message, True)
                        End If
                    Else
                        myCookie = New HttpCookie("UserLoginSettings_Mobile")
                        myCookie.Values.Add("LoginCount", 1)
                        myCookie("CookieUserName") = txtName.Value
                        Response.Cookies.Add(myCookie)
                        Dim message As String = "alert('Login details were incorrect')"
                        ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "alert", message, True)
                        txtPassword.Text = ""
                    End If
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
        End If

    End Sub
End Class