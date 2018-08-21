Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Xml
Imports CRM.BE
Imports CRM.DL
Public Class GetAjaxData1
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEAppliances As clsBEAppliances = New clsBEAppliances
    Dim strFilename As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strResponceText As String = String.Empty
        Dim strDoAction As String = Request.Params.Get("DoAction")
        Response.Write(strDoAction)
        Try
            If strDoAction = "setModelInDropdown" Then
                Dim ManufactureValue As Integer = objFunction.ReturnInteger(Request.Params.Get("ManufacturerId"))
                Dim ApplianceValue As Integer = objFunction.ReturnInteger(Request.Params.Get("Applianceid"))
                objBEAppliances.ApplianceTypeID = ApplianceValue
                objBEAppliances.ManufacturerID = ManufactureValue
                Dim dstModel As DataSet = (New clsDLAppliances()).GetModelTypeFillInDD(objBEAppliances)
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

            ElseIf strDoAction = "CheckJobSheetRecord" Then
                Dim objBEToastUser As clsBEToastUser = New clsBEToastUser
                objBEToastUser.Whenx = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                Dim dstDetail As DataSet = (New clsDLToastUser()).GetToastUserDetails()
                If objFunction.CheckDataSet(dstDetail) Then
                    strResponceText += objFunction.ReturnString(dstDetail.Tables(0).Rows(0)("Engineer")) + "colSplit" + objFunction.ReturnString(dstDetail.Tables(0).Rows(0)("ClientName")) + "colSplit" + objFunction.ReturnString(dstDetail.Tables(0).Rows(0)("job_id")) + "colSplit" + objFunction.ReturnString(dstDetail.Tables(0).Rows(0)("ToastId")) + "colSplit" + objFunction.ReturnString(dstDetail.Tables(0).Rows(0)("JobCompleteStatus"))
                End If

            ElseIf strDoAction = "UpdateToastShownRecord" Then
                Dim objBEToastUser As clsBEToastUser = New clsBEToastUser
                objBEToastUser.ToastId = objFunction.ReturnInteger(Request.Params.Get("ToastID"))
                Dim intAffectedRow As Integer = (New clsDLToastUser()).UpdateToastUserDetails(objBEToastUser)
                If intAffectedRow > 0 Then
                    strResponceText = "Sucess"
                End If

            ElseIf strDoAction = "DeleteToastShownRecord" Then
                Dim intAffectedRow As Integer = (New clsDLToastUser()).DeleteToastUserDetails()
                If intAffectedRow > 0 Then
                    strResponceText = "Sucess"
                End If
            ElseIf strDoAction = "UpdateCSVRecord" Then
                Dim intAffectedRow As Integer = (New clsDLOrder()).UpdateOrderFlagDetails()
                If intAffectedRow > 0 Then
                    Dim intAffectedRow1 As Integer = (New clsDLClient()).UpdateClientFlag()
                    If intAffectedRow1 > 0 Then
                        strResponceText = "Sucess"
                    End If
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