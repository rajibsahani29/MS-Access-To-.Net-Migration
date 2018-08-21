Imports System.Web.Script.Serialization
Imports CRM.BE
Imports CRM.DL
Public Class GetAjaxData
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Dim objBEAppliances As clsBEAppliances = New clsBEAppliances

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strResponceText As String = String.Empty
        Dim strDoAction As String = Request.Params.Get("DoAction")
        'Response.Write(strDoAction)
        Dim strname = objFunction.ReturnString(Session("UserName"))
        Try
            If strDoAction = "setSortOrderIdInCookie" Then
                Dim intSelectsortOrder As Integer = objFunction.ReturnInteger(Request.Params.Get("Id"))
                Dim intSelectJobid As Integer = objFunction.ReturnInteger(Request.Params.Get("JobID"))
                objBEOrder.Engineer = strname
                objBEOrder.SheetDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                'objBEOrder.SheetDate = "05/11/2017"
                objBEOrder.SortOrder = intSelectsortOrder - 1
                Dim intPreviousJobid As Integer = (New clsDLOrder()).GetJobIDBySortOrder(objBEOrder)
                If (intPreviousJobid > 0) Then
                    objBEOrder.JOBID = intSelectJobid
                    objBEOrder.SortOrder = intSelectsortOrder - 1
                    Dim intAffectedRow As Integer = (New clsDLOrder()).UpdateSortOrderByJobId(objBEOrder)
                    If intAffectedRow > 0 Then
                        objBEOrder.JOBID = intPreviousJobid
                        objBEOrder.SortOrder = intSelectsortOrder
                        Dim intAffectedRow1 As Integer = (New clsDLOrder()).UpdateSortOrderByJobId(objBEOrder)
                        If intAffectedRow > 0 Then
                            strResponceText = "Success"
                        End If

                    Else

                    End If

                End If
            ElseIf strDoAction = "setModelInDropdownByManufacturerId" Then
                Dim ManufactureValue As Integer = objFunction.ReturnInteger(Request.Params.Get("ManufacturerId"))
                'Dim ApplianceValue As Integer = objFunction.ReturnInteger(Request.Params.Get("Applianceid"))
                'objBEAppliances.ApplianceTypeID = ApplianceValue
                objBEAppliances.ManufacturerID = ManufactureValue
                Dim dstModel As DataSet = (New clsDLAppliances()).GetModelTypeFillInDDByManufacturerID(objBEAppliances)
                'objFunction.FillDropDownByDataSet(ddlModel, dstModel)
                'ddlModel.Items.Insert(0, New ListItem("Select", ""))
                Dim lstCalendarData = New List(Of Dictionary(Of String, Object))()

                If objFunction.CheckDataSet(dstModel) Then

                    For i As Integer = 0 To dstModel.Tables(0).Rows.Count - 1

                        Dim objDiaryGeneralEventsCalendar1 As New Dictionary(Of String, Object)()
                        objDiaryGeneralEventsCalendar1.Add("Id", objFunction.ReturnString(dstModel.Tables(0).Rows(i)("Id")))
                        objDiaryGeneralEventsCalendar1.Add("Value", objFunction.ReturnString(dstModel.Tables(0).Rows(i)("Value")))
                        lstCalendarData.Add(objDiaryGeneralEventsCalendar1)

                    Next
                    Dim serializer As New JavaScriptSerializer()
                    strResponceText = serializer.Serialize(lstCalendarData)
                Else
                    strResponceText = "Error"
                End If
            ElseIf strDoAction = "GetJobSheetId" Then
                Dim objBEJobsheet As clsBEJobsheet = New clsBEJobsheet
                Dim JobID As Integer = objFunction.ReturnInteger(Request.Params.Get("JobID"))
                objBEJobsheet.JOBID = JobID
                Dim dstDetail As DataSet = (New clsDLJobsheet()).GetJobSheetDetailsByJobid(objBEJobsheet)
                If objFunction.CheckDataSet(dstDetail) Then
                    strResponceText = objFunction.ReturnString(dstDetail.Tables(0).Rows(0)("Id"))
                Else
                    strResponceText = "Error"
                End If

            End If
            Response.Clear()
            Response.Write(strResponceText)
            Response.End()

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

End Class