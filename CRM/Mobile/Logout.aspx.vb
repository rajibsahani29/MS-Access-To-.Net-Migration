Public Class Logout1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Session("LoginUserName") = Nothing
            Session("LoginUserFirstName") = Nothing
            Session("LoginUserId") = Nothing
            Session("UserName") = Nothing
            If (Request.Cookies("LoginDetailMobile") IsNot Nothing) Then
                Request.Cookies("LoginDetailMobile").Value = ""
                Dim nameCookie As HttpCookie = Request.Cookies("LoginDetailMobile")
                nameCookie.Expires = DateTime.Now.AddDays(-1)
                Response.Cookies.Add(nameCookie)
            End If

            If (Request.Cookies("UserLoginSettings_Mobile") IsNot Nothing) Then
                Request.Cookies("UserLoginSettings_Mobile").Value = ""
                Dim nameCookie As HttpCookie = Request.Cookies("UserLoginSettings_Mobile")
                nameCookie.Expires = DateTime.Now.AddDays(-1)
                Response.Cookies.Add(nameCookie)
            End If
            Response.Redirect("~/pages-login-mobile.aspx")
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

End Class