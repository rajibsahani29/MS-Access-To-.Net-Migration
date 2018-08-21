Imports CRM.BE
Imports CRM.DL
Public Class Index_mobile
    Inherits System.Web.UI.Page
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Protected dstJobList As DataSet
    Protected objFunction As New clsCommon()
    Protected dstJobSheet As DataSet
    Protected objBEJobsheet As clsBEJobsheet = New clsBEJobsheet


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim strname = objFunction.ReturnString(Session("UserName"))
            GetJobsheetDetails(strname)
        End If
    End Sub
    Protected Sub GetJobsheetDetails(ByVal name As String)
        Try
            objBEOrder.Engineer = name
            objBEOrder.SheetDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
            dstJobList = (New clsDLOrder()).GetJobSheetDataByUser(objBEOrder)
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub

End Class