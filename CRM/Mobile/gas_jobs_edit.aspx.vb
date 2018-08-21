Imports CRM.BE
Imports CRM.DL
Public Class gas_jobs_edit
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEGas As clsBEGasInspection = New clsBEGasInspection
    Dim objBECatering As clsBECateringInspection = New clsBECateringInspection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        FillGasDetails()
        FillCateringDetails()

    End Sub
    Public Sub FillGasDetails()
        Try
            objBEGas.EngineerId = objFunction.ReturnInteger(Session("LoginUserId"))
            Dim dstJobList As DataSet = (New clsDLGasInspection()).GetJobsGasDetailsByEngineer(objBEGas)
            If objFunction.CheckDataSet(dstJobList) Then
                grdGagInspection.DataSource = dstJobList
                grdGagInspection.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Public Sub FillCateringDetails()
        Try
            objBECatering.EngineerId = objFunction.ReturnInteger(Session("LoginUserId"))
            Dim dstJobList As DataSet = (New clsDLCateringInspection()).GetCateringDetailsByEngineer(objBECatering)
            If objFunction.CheckDataSet(dstJobList) Then
                grdCateringInspection.DataSource = dstJobList
                grdCateringInspection.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    ''' <summary>
    ''' This function is used to set date value
    ''' </summary>
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

    Protected Sub grdGagInspection_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdGagInspection.PageIndexChanging
        Try
            grdGagInspection.PageIndex = e.NewPageIndex
            FillGasDetails()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdCateringInspection_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdCateringInspection.PageIndexChanging
        Try
            grdCateringInspection.PageIndex = e.NewPageIndex
            FillCateringDetails()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdCateringInspection_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdCateringInspection.SelectedIndexChanging
        Try
            Dim CateringId As String = objFunction.ReturnString(grdCateringInspection.DataKeys(e.NewSelectedIndex).Value)
            Response.Redirect("catering-gas-inspection_edit.aspx?GasCateringID=" + CateringId)
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub grdGagInspection_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdGagInspection.SelectedIndexChanging
        Try
            Dim GasInspectionId As String = objFunction.ReturnString(grdGagInspection.DataKeys(e.NewSelectedIndex).Value)
            Response.Redirect("gas-inspection_edit.aspx?GasInspectionID=" + GasInspectionId)
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
End Class