Imports CRM.BE
Imports CRM.DL
Public Class mobile_engineer_select_client
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub
    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try

            Dim strSearch1 As String = (If(txtClientName.Text <> "", txtClientName.Text, ""))
            Dim dstJobList As DataSet = (New clsDLClient()).GetClientDetailByName(strSearch1)
            grdClient.DataSource = dstJobList
            grdClient.DataBind()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdClient_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grdClient.RowCommand
        If e.CommandName = "Inspections" Then
            'Dim Id As String = Convert.ToString(e.CommandArgument)
            'Response.Redirect("mobile-engineer-select-client-gas.aspx?CientID=" + Id)
            Response.Redirect("gas-inspection_edit.aspx")
        End If

        If e.CommandName = "Catering" Then
            'Dim Id As String = Convert.ToString(e.CommandArgument)
            'Response.Redirect("mobile-engineer_select_client_jobs.aspx?CientID=" + Id)
            Response.Redirect("catering-gas-inspection.aspx")

        End If

        If e.CommandName = "View" Then
            Dim Id As String = Convert.ToString(e.CommandArgument)
            Response.Redirect("mobile-engineer_select_client_jobs.aspx?CientID=" + Id)
        End If
    End Sub
End Class