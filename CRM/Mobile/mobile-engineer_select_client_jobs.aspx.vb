Imports CRM.BE
Imports CRM.DL
Public Class mobile_engineer_select_client_jobs
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEJobsheet As clsBEJobsheet = New clsBEJobsheet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Request.QueryString("CientID")) = "" Or objFunction.ReturnString(Request.QueryString("CientID")) Is Nothing Then
            Response.Redirect("mobile-engineer_select_client.aspx")
        End If

        If Not Page.IsPostBack Then
            Dim intClientId = objFunction.ReturnInteger(Request.QueryString("CientID"))
            GetJobDetails(intClientId)
        End If
    End Sub
    Protected Sub GetJobDetails(ByVal id As Integer)
        Try
            Dim dstJobList As New DataSet()
            objBEJobsheet.clientId = id
            objBEJobsheet.Engineerid = objFunction.ReturnInteger(Session("LoginUserId"))
            dstJobList = (New clsDLJobsheet()).GetJobSheetDetailsByClientId(objBEJobsheet)
            If objFunction.CheckDataSet(dstJobList) Then
                grdJob.DataSource = dstJobList
                grdJob.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub
    Public Function SetDateVal(ByVal value As Object) As String
        Try
            If objFunction.ReturnString(value) <> "" Then
                Dim dt As DateTime = Convert.ToDateTime(value)
                Return dt.ToString("dd-MM-yyyy")
            Else
                Return ""
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
        Return ""
    End Function

    Protected Sub grdJob_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdJob.SelectedIndexChanging
        Try
            Dim JobsheetId As String = objFunction.ReturnString(grdJob.DataKeys(e.NewSelectedIndex).Value)
            Response.Redirect("job_sheet_edit.aspx?ID=" + JobsheetId)
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
End Class