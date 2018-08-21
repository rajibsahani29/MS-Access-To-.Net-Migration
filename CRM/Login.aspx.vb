Imports System.Data
Imports CRM.BE
Imports CRM.DL

Public Class Login
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEStaff As clsBEStaff = New clsBEStaff

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If (Request.Cookies("LoginDetail") IsNot Nothing) Then
                If objFunction.ReturnInteger(Request.Cookies("LoginDetail")("UserId")) > 0 Then
                    Session("LoginUserId") = objFunction.ReturnString(Request.Cookies("LoginDetail")("UserId"))
                    Session("UserName") = objFunction.ReturnString(Request.Cookies("LoginDetail")("UserName"))

                End If
            End If

            btnLogin.Enabled = True
            'If Request.Cookies("UserLoginSettings") IsNot Nothing Then
            '    If objFunction.ReturnInteger(Request.Cookies("UserLoginSettings")("LoginCount")) >= 3 Then
            '        Dim message As String = "alert('You have been logged out. Please wait 15 mins and try again')"
            '        ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "alert", message, True)
            '        btnLogin.Enabled = False
            '    End If
            'End If

            If objFunction.ValidateLogin() Then
                Response.Redirect("index.aspx")
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (GetLoginCode()) Then
            Response.Redirect("Change_Password.aspx")
        Else
            Try
                objBEStaff.Email = txtName.Text
                objBEStaff.Password = txtPassword.Text
                Dim objDLStaff As clsDLStaff = New clsDLStaff
                Dim dstLogin As DataSet = objDLStaff.StaffLogin(objBEStaff)
                If objFunction.CheckDataSet(dstLogin) Then
                    Session("LoginUserName") = Convert.ToString(dstLogin.Tables(0).Rows(0)("username"))
                    Session("LoginUserFirstName") = Convert.ToString(dstLogin.Tables(0).Rows(0)("firstname"))
                    Session("LoginUserId") = Convert.ToString(dstLogin.Tables(0).Rows(0)("StaffID"))
                    Session("UserName") = Convert.ToString(dstLogin.Tables(0).Rows(0)("Fullname"))
                    If (chkRemember.Checked = True) Then
                        Dim mycookie As HttpCookie = New HttpCookie("LoginDetail")
                        mycookie.Values("UserId") = Session("LoginUserId").ToString()
                        mycookie.Values("UserName") = Session("UserName").ToString()
                        mycookie.Expires = System.DateTime.Now.AddDays(15)
                        Response.Cookies.Add(mycookie)
                    End If

                    If (Request.Cookies("UserLoginSettings") IsNot Nothing) Then
                        If (objFunction.ReturnString(Request.Cookies("UserLoginSettings")("CookieUserName")) = txtName.Text) Then
                            Request.Cookies("UserLoginSettings").Value = ""
                            Dim nameCookie As HttpCookie = Request.Cookies("UserLoginSettings")
                            nameCookie.Expires = DateTime.Now.AddDays(-1)
                            Response.Cookies.Add(nameCookie)
                        End If
                    End If
                    Response.Redirect("index.aspx")

                Else

                    Dim myCookie As HttpCookie = Request.Cookies("UserLoginSettings")
                    If myCookie IsNot Nothing Then
                        Dim times As Integer = objFunction.ReturnInteger(Request.Cookies("UserLoginSettings")("LoginCount").ToString())
                        If (times >= 3) Then
                            Dim message As String = "alert('You have been logged out. Please wait 15 mins and try again')"
                            ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "alert", message, True)
                            myCookie("CookieUserName") = txtName.Text
                            myCookie("CookieLoginTime") = DateTime.Now.ToShortTimeString()
                            myCookie.Expires = Now.AddMinutes(15)
                            Response.Cookies.Add(myCookie)
                            txtPassword.Text = ""
                            btnLogin.Enabled = False

                        Else

                            Request.Cookies("UserLoginSettings")("LoginCount") = times + 1
                            Response.Cookies.Add(myCookie)
                            txtPassword.Text = ""
                            Dim message As String = "alert('Login details were incorrect')"
                            ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "alert", message, True)
                        End If
                    Else
                        myCookie = New HttpCookie("UserLoginSettings")
                        myCookie.Values.Add("LoginCount", 1)
                        myCookie("CookieUserName") = txtName.Text
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

    Public Function GetLoginCode() As Boolean

        Dim flag As Boolean = False
        objBEStaff.Email = txtName.Text
        objBEStaff.RandomCode = txtPassword.Text
        Dim objDLStaff As clsDLStaff = New clsDLStaff
        Dim dstLogin As DataSet = objDLStaff.LoginStaffMemberByCode(objBEStaff)
        If objFunction.CheckDataSet(dstLogin) Then
            Session("LoginUserId") = Convert.ToString(dstLogin.Tables(0).Rows(0)("StaffID"))
            flag = True
        End If
        Return flag
    End Function
End Class