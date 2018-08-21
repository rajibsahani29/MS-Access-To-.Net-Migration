Imports System.Globalization
Imports CRM.BE
Imports CRM.DL

Public Class catering_gas_inspection
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBECatering As clsBECateringInspection = New clsBECateringInspection
    Dim objBEClient As clsBEClient = New clsBEClient
    Dim objBECateringApp As clsBECateringAppliance = New clsBECateringAppliance
    Dim objBECateringIns As clsBECatering_Inspection = New clsBECatering_Inspection
    Dim objBECateringSafe As clsBECateringSafety = New clsBECateringSafety
    Dim objBECategoryWork As clsBECategoryWork = New clsBECategoryWork
    Dim objBEOrder As clsBEOrder = New clsBEOrder

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then

            Dim dstcompany As DataSet = (New clsDLClient()).GetClientFillInDD()
            objFunction.FillDropDownByDataSet(ddlCompany, dstcompany)
            ddlCompany.Items.Insert(0, New ListItem("Select Company", ""))

            objBEOrder.Engineer = objFunction.ReturnString(Session("UserName"))
            objBEOrder.SheetDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
            Dim dstJob As DataSet = (New clsDLOrder()).GetJobIdFillInDD(objBEOrder)
            objFunction.FillDropDownByDataSet(ddlJobId, dstJob)
            ddlJobId.Items.Insert(0, New ListItem("Select JobID", ""))
            ChildDetails.Visible = False
        End If
    End Sub



    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try

            Dim TypeStatus As String = ""
            Dim LpgStatus As String = ""
            Dim strEmergency As String = ""
            Dim strTightness As String = ""
            Dim strInstallation As String = ""
            If RadioButton1.Checked() Then
                TypeStatus = "Vehicle"
            ElseIf RadioButton2.Checked() Then
                TypeStatus = "Trailer"
            End If

            If RadioButton3.Checked() Then
                LpgStatus = "Yes"
            ElseIf RadioButton4.Checked() Then
                LpgStatus = "No"
            End If

            If RadioButton5.Checked() Then
                strEmergency = "Yes"
            ElseIf RadioButton6.Checked() Then
                strEmergency = "No"
            End If

            If RadioButton7.Checked() Then
                strTightness = "Yes"
            ElseIf RadioButton8.Checked() Then
                strTightness = "No"
            End If
            If RadioButton9.Checked() Then
                strInstallation = "Yes"
            ElseIf RadioButton10.Checked() Then
                strInstallation = "No"
            End If
            objBECatering.ClientId = ddlCompany.SelectedValue
            objBECatering.EngineerId = objFunction.ReturnInteger(Session("LoginUserId"))
            objBECatering.JobId = objFunction.ReturnInteger(ddlJobId.SelectedValue)
            objBECatering.RegNo = txtReg.Text
            objBECatering.Type = TypeStatus
            objBECatering.AppliancesTested = txtAppTested.Text
            objBECatering.LPG = LpgStatus
            objBECatering.Emergency = strEmergency
            objBECatering.Tightness = strTightness
            objBECatering.installation = strInstallation
            objBECatering.OperatingPressure = txtLPGReg1.Text
            objBECatering.LockupPressure = txtLPGReg2.Text
            objBECatering.ReceivedBy = txtReceiveBy.Text
            objBECatering.PrintName = txtPrint.Text
            objBECatering.IssuedBy = txtIssuedBy.Text
            objBECatering.IdCardNo = txtIdCardNo.Text
            objBECatering.IssuedDate = DateTime.ParseExact(txtDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
            Dim intCateringGasId As Integer = (New clsDLCateringInspection()).AddCateringGasDetails(objBECatering)
            If intCateringGasId > 0 Then
                hdnID.Value = objFunction.ReturnString(intCateringGasId)
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('New Catering Gas Inspection has been submitted.','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                btnSubmit.Enabled = False
                ChildDetails.Visible = True
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try

    End Sub

    Protected Sub btnSubmitAppliance_Click(sender As Object, e As EventArgs) Handles btnSubmitAppliance.Click
        Try

            Dim strFlue As String = ""
            Dim strSecure As String = ""
            Dim strIsolation As String = ""
            If RadioButton11.Checked() Then
                strFlue = "Yes"
            ElseIf RadioButton12.Checked() Then
                strFlue = "No"
            End If
            If RadioButton13.Checked() Then
                strSecure = "Yes"
            ElseIf RadioButton14.Checked() Then
                strSecure = "No"
            End If

            If RadioButton15.Checked() Then
                strIsolation = "Yes"
            ElseIf RadioButton16.Checked() Then
                strIsolation = "No"
            End If

            objBECateringApp.CateringId = hdnID.Value
            objBECateringApp.ApplianceType = txtAppliance.Text
            objBECateringApp.Model = txtApplianceModel.Text
            objBECateringApp.ApplianceMake = txtApplianceMake.Text
            objBECateringApp.SerialNo = txtAppSerialNum.Text
            objBECateringApp.FlueType = strFlue
            objBECateringApp.ApplianceSecure = strSecure
            objBECateringApp.IsolationValve = strIsolation
            Dim intCateringGasId As Integer = (New clsDLCateringAppliance()).AddCateringApplianceDetails(objBECateringApp)
            If intCateringGasId > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('New Catering Gas Appliance has been submitted.','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                FillCateringAppliance(objFunction.ReturnInteger(hdnID.Value))
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub

    Public Sub FillCateringAppliance(ByVal IntJobId As Integer)
        Try
            Dim dstList As New DataSet()
            objBECateringApp.CateringId = IntJobId
            dstList = (New clsDLCateringAppliance()).GetCateringApplianceDetails(objBECateringApp)
            If objFunction.CheckDataSet(dstList) Then
                grdAppliance.DataSource = dstList
                grdAppliance.DataBind()
            Else
                grdAppliance.DataSource = Nothing
                grdAppliance.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdAppliance.RowEditing
        Try
            grdAppliance.EditIndex = e.NewEditIndex
            FillCateringAppliance(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdAppliance.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdAppliance.DataKeys(e.RowIndex).Values("CateringAppId")))
            objBECateringApp.CateringAppId = id
            Dim intAffectedRow As Integer = (New clsDLCateringAppliance()).PerformGridViewOpertaion("DELETE", objBECateringApp)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Appliance details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdAppliance.EditIndex = -1
            FillCateringAppliance(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdAppliance.RowCancelingEdit
        Try
            grdAppliance.EditIndex = -1
            FillCateringAppliance(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdAppliance.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdAppliance.DataKeys(e.RowIndex).Values("CateringAppId")))
            Dim txtType As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtType"), TextBox)
            Dim txtMake As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtMake"), TextBox)
            Dim txtModel As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtModel"), TextBox)
            Dim txtSerial As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtSerial"), TextBox)
            Dim txtFlue As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtFlue"), TextBox)
            Dim txtSecure As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtSecure"), TextBox)
            Dim txtIsolationValve As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtIsolationValve"), TextBox)

            objBECateringApp.CateringAppId = id
            objBECateringApp.ApplianceType = txtType.Text
            objBECateringApp.ApplianceMake = txtMake.Text
            objBECateringApp.Model = txtModel.Text
            objBECateringApp.SerialNo = txtSerial.Text
            objBECateringApp.FlueType = txtFlue.Text
            objBECateringApp.ApplianceSecure = txtSecure.Text
            objBECateringApp.IsolationValve = txtIsolationValve.Text

            Dim intAffectedRow As Integer = (New clsDLCateringAppliance()).PerformGridViewOpertaion("UPDATE", objBECateringApp)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Catering Appliance details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdAppliance.EditIndex = -1
            FillCateringAppliance(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnInspection_Click(sender As Object, e As EventArgs) Handles btnInspection.Click
        Try

            Dim strOperating As String = ""
            Dim strSafety As String = ""
            Dim strsatisfactory As String = ""
            Dim strconditions As String = ""
            Dim strperformanace As String = ""
            Dim strServiced As String = ""
            Dim strSafeTouse As String = ""

            If RadioButton17.Checked() Then
                strOperating = "Yes"
            ElseIf RadioButton18.Checked() Then
                strOperating = "No"
            End If
            If RadioButton19.Checked() Then
                strSafety = "Yes"
            ElseIf RadioButton20.Checked() Then
                strSafety = "No"
            End If

            If RadioButton21.Checked() Then
                strsatisfactory = "Yes"
            ElseIf RadioButton22.Checked() Then
                strsatisfactory = "No"
            End If

            If RadioButton23.Checked() Then
                strconditions = "Yes"
            ElseIf RadioButton24.Checked() Then
                strconditions = "No"
            End If

            If RadioButton25.Checked() Then
                strperformanace = "Yes"
            ElseIf RadioButton26.Checked() Then
                strperformanace = "No"
            End If

            If RadioButton27.Checked() Then
                strServiced = "Yes"
            ElseIf RadioButton28.Checked() Then
                strServiced = "No"
            End If

            If RadioButton29.Checked() Then
                strSafeTouse = "Yes"
            ElseIf RadioButton30.Checked() Then
                strSafeTouse = "No"
            End If
            objBECateringIns.CateringId = hdnID.Value
            objBECateringIns.Operating = strOperating
            objBECateringIns.Safety = strSafety
            objBECateringIns.SafeToUse = strSafeTouse
            objBECateringIns.Satisfactory = strsatisfactory
            objBECateringIns.Performances = strperformanace
            objBECateringIns.Serviced = strServiced
            objBECateringIns.Conditions = strconditions

            Dim intCateringInspectionId As Integer = (New clsDLCatering_Inspection()).AddCateringInspectionDetails(objBECateringIns)
            If intCateringInspectionId > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Catering Inspection Details has been submitted.','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                FillCateringInspection(objFunction.ReturnInteger(hdnID.Value))
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub

    Public Sub FillCateringInspection(ByVal IntJobId As Integer)
        Try
            Dim dstList As New DataSet()
            objBECateringIns.CateringId = IntJobId
            dstList = (New clsDLCatering_Inspection()).GetCateringInspectionDetails(objBECateringIns)
            If objFunction.CheckDataSet(dstList) Then
                grdInspection.DataSource = dstList
                grdInspection.DataBind()
            Else
                grdInspection.DataSource = Nothing
                grdInspection.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnSaftety_Click(sender As Object, e As EventArgs) Handles btnSaftety.Click
        Try
            Dim strexstinguisher As String = ""
            Dim strBlanket As String = ""
            Dim strCurrentSafety As String = ""
            Dim strLPGSafety As String = ""

            If RadioButton31.Checked() Then
                strexstinguisher = "Yes"
            ElseIf RadioButton32.Checked() Then
                strexstinguisher = "No"
            End If

            If RadioButton33.Checked() Then
                strBlanket = "Yes"
            ElseIf RadioButton34.Checked() Then
                strBlanket = "No"
            End If

            If RadioButton35.Checked() Then
                strCurrentSafety = "Yes"
            ElseIf RadioButton36.Checked() Then
                strCurrentSafety = "No"
            End If

            If RadioButton37.Checked() Then
                strLPGSafety = "Yes"
            ElseIf RadioButton38.Checked() Then
                strLPGSafety = "No"
            End If


            objBECateringSafe.CateringId = hdnID.Value
            objBECateringSafe.Exstinguisher = strexstinguisher
            objBECateringSafe.Blanket = strBlanket
            objBECateringSafe.CurrentSafety = strCurrentSafety
            objBECateringSafe.LPGSafety = strLPGSafety

            Dim intCateringSafetyId As Integer = (New clsDLCateringSafety()).AddCateringSafetyDetails(objBECateringSafe)
            If intCateringSafetyId > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Catering Safety Details has been submitted.','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                FillCateringSafety(objFunction.ReturnInteger(hdnID.Value))
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub

    Public Sub FillCateringSafety(ByVal IntJobId As Integer)
        Try
            Dim dstList As New DataSet()
            objBECateringSafe.CateringId = IntJobId
            dstList = (New clsDLCateringSafety()).GetCateringSafetyDetails(objBECateringSafe)
            If objFunction.CheckDataSet(dstList) Then
                grdSafety.DataSource = dstList
                grdSafety.DataBind()
            Else
                grdSafety.DataSource = Nothing
                grdSafety.DataBind()

            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnSubmitWork_Click(sender As Object, e As EventArgs) Handles btnSubmitWork.Click
        Try
            Dim strwarning As String = ""

            If RadioButton39.Checked() Then
                strwarning = "Yes"
            ElseIf RadioButton40.Checked() Then
                strwarning = "No"
            End If
            objBECategoryWork.CateringId = hdnID.Value
            objBECategoryWork.Defects = txtDefects.Text
            objBECategoryWork.warnings = strwarning
            objBECategoryWork.Remedicals = txtRemedical.Text
            objBECategoryWork.WorkDetails = txtDetails.Text
            Dim intCateringSafetyId As Integer = (New clsDLCategoryWork()).AddCateringWorkDetails(objBECategoryWork)
            If intCateringSafetyId > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Catering Work Details has been submitted.','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                FillCateringWork(objFunction.ReturnInteger(hdnID.Value))
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub

    Public Sub FillCateringWork(ByVal IntJobId As Integer)
        Try
            Dim dstList As New DataSet()
            objBECategoryWork.CateringId = IntJobId
            dstList = (New clsDLCategoryWork()).GetCateringWorkDetails(objBECategoryWork)
            If objFunction.CheckDataSet(dstList) Then
                grdWork.DataSource = dstList
                grdWork.DataBind()
            Else
                grdWork.DataSource = Nothing
                grdWork.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
    Protected Sub grdSafety_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdSafety.SelectedIndexChanging
        Try
            Dim id As String = objFunction.ReturnString(grdSafety.DataKeys(e.NewSelectedIndex).Value)
            objBECateringSafe.CateringSafetyId = id
            Dim intAffectedRow As Integer = (New clsDLCateringSafety()).PerformGridViewOpertaion("DELETE", objBECateringSafe)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Safety details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else
            End If
            FillCateringSafety(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdInspection_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdInspection.SelectedIndexChanging
        Try
            Dim id As String = objFunction.ReturnString(grdInspection.DataKeys(e.NewSelectedIndex).Value)
            objBECateringIns.CateringInspectionId = id
            Dim intAffectedRow As Integer = (New clsDLCatering_Inspection()).PerformGridViewOpertaion("DELETE", objBECateringIns)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Inspection details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else
            End If
            FillCateringInspection(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdAppliance.SelectedIndexChanging
        Try
            Dim id As String = objFunction.ReturnString(grdAppliance.DataKeys(e.NewSelectedIndex).Value)
            objBECateringApp.CateringAppId = id
            Dim intAffectedRow As Integer = (New clsDLCateringAppliance()).PerformGridViewOpertaion("DELETE", objBECateringApp)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Appliance details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            FillCateringAppliance(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdWork_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdWork.SelectedIndexChanging
        Try
            Dim id As String = objFunction.ReturnString(grdWork.DataKeys(e.NewSelectedIndex).Value)
            objBECategoryWork.CateringWorkId = id
            Dim intAffectedRow As Integer = (New clsDLCategoryWork()).PerformGridViewOpertaion("DELETE", objBECategoryWork)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Work details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else
            End If
            FillCateringWork(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub


End Class