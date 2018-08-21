Public Class Mobile
    Inherits System.Web.UI.MasterPage
    Dim objFunction As New clsCommon()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If Not objFunction.ValidateLoginMobile() Then
                Response.Redirect("~/pages-login-mobile.aspx")
            End If

            If Not Page.IsPostBack Then
                lblname.Text = objFunction.ReturnString(Session("UserName"))

            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

End Class