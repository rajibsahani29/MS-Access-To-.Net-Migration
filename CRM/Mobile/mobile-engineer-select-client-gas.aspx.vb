Imports CRM.BE
Imports CRM.DL
Public Class mobile_engineer_select_client_gas
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Request.QueryString("CientID")) = "" Or objFunction.ReturnString(Request.QueryString("CientID")) Is Nothing Then
            Response.Redirect("mobile-engineer_select_client.aspx")
        End If
        If Not Page.IsPostBack Then
            Dim strClientId = objFunction.ReturnString(Request.QueryString("CientID"))
        End If
    End Sub

    Private Sub FIllDataList()
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("ForeName")
        dt.Columns.Add("Surname")
        dt.Columns.Add("Email")
        dt.Columns.Add("DirectLine")
        dt.Columns.Add("Notes")
        dt.Rows.Add()
        dt.Rows(0)(0) = 1
        dt.Rows(0)(1) = "Randy Stanley"
        dt.Rows(0)(2) = "Meevee"
        dt.Rows(0)(3) = "rstanley0@apache.org"
        dt.Rows(0)(4) = "86-(350)855-6849"

        dt.Rows.Add()
        dt.Rows(1)(0) = 2
        dt.Rows(1)(1) = "Kathy Watkins"
        dt.Rows(1)(2) = "Youopia"
        dt.Rows(1)(3) = "kwatkins1@lulu.com"
        dt.Rows(1)(4) = "234-(738)389-4577"

        dt.Rows.Add()
        dt.Rows(2)(0) = 3
        dt.Rows(2)(1) = "Melissa Romero"
        dt.Rows(2)(2) = "Rhyzio"
        dt.Rows(2)(3) = "mromero2@list-manage.com"
        dt.Rows(2)(4) = "56-(950)327-4426"

        dt.Rows.Add()
        dt.Rows(3)(0) = 4
        dt.Rows(3)(1) = "Rachel Ford"
        dt.Rows(3)(2) = "Zava"
        dt.Rows(3)(3) = "rford3@howstuffworks.com"
        dt.Rows(3)(4) = "212-(450)201-2264"

        RptJobList1.DataSource = dt
        RptJobList1.DataBind()

    End Sub

End Class