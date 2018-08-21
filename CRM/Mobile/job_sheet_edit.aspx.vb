Imports CRM.BE
Imports CRM.DL
Public Class job_sheet_edit
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEJobsheet As clsBEJobsheet = New clsBEJobsheet
    Dim objBEPartsFitted As clsBEPartsFitted = New clsBEPartsFitted
    Dim objBEPartRequired As clsBEPartRequired = New clsBEPartRequired
    Dim objBEOrder As clsBEOrder = New clsBEOrder



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Request.QueryString("ID")) = "" Or objFunction.ReturnString(Request.QueryString("ID")) Is Nothing Then
            Response.Redirect("mobile-engineer_select_client_jobs.aspx")
        End If
        If Not Page.IsPostBack Then
            hdnVat.Value = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("VAT"))
            Dim intJobsheetId = objFunction.ReturnInteger(Request.QueryString("ID"))
            GetJobSheetDetails(intJobsheetId)

        End If
    End Sub
    Protected Sub GetJobSheetDetails(ByVal id As Integer)
        Try
            Dim dstJobSheet As New DataSet()
            objBEJobsheet.Id = id
            dstJobSheet = (New clsDLJobsheet()).GetJobSheetDetailsById(objBEJobsheet)
            If objFunction.CheckDataSet(dstJobSheet) Then
                txtCustomer.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("Customername"))
                txtFaultReported.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("Fault"))
                txtAddress.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("address"))
                txtAssetNo.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("AssetNumber"))
                txtTotalTime.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("TotalTime"))
                txtJobRef.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("JobNumber"))
                If (objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("ChargeableStatus")) = "1") Then
                    chargeable.Checked = True
                Else
                    chargeable.Checked = False
                End If
                If (objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("warrantyStatus")) = "1") Then
                    warranty.Checked = True
                End If
                If (objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("JobCompleteStatus")) = "1") Then
                    job_completed.Checked = True
                End If

                If (objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("ServiceType")) = "1") Then
                    RadioButton1.Checked = True
                ElseIf (objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("ServiceType")) = "2") Then
                    RadioButton2.Checked = True
                ElseIf (objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("ServiceType")) = "3") Then
                    RadioButton3.Checked = True
                ElseIf (objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("ServiceType")) = "4") Then
                    RadioButton4.Checked = True
                End If

                If (objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("PlannedMaintenance")) = "1") Then
                    RadioButton5.Checked = True
                Else
                    RadioButton5.Checked = False

                End If
                If (objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("EquipmentIdentification")) = "1") Then
                    RadioButton6.Checked = True
                Else
                    RadioButton6.Checked = False

                End If
                If (objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("EquipmentInstallation")) = "1") Then
                    RadioButton7.Checked = True
                Else
                    RadioButton7.Checked = False
                End If

                txtOrderNo.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("OrderNumber"))
                txtEquipment.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("Appliance"))
                txtModel.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("Model"))
                txtManufacturer.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("Manufacturer"))
                'ddlManufacturer.SelectedItem.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("Manufacturer"))
                txtSerialNo.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("SerialNo"))
                txtGasLeakTest.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("GasLeakTest"))
                txtearthleakTest.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("EarthLeakageTest"))
                txtLoadTest.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("LoadTest"))
                txtFlashTest.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("flashTest"))
                txtIns.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("InsRes"))
                txtEC.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("EC"))
                txtMicrowaveLeak.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("MicrowaveLeakage"))
                txtPowerOutput.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("PowerOutput"))
                txtWorkDetails.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("workDetails"))
                txtTotalMaterials.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("TotalParts"))
                txtLabour.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("TotalLabour"))
                txtMiscCharge.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("charges"))
                txtSubTotal.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("SubTotal"))
                txtVAT.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("Vat"))
                txtTotalVAT.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("TotalIncVat"))
                job_unfinished.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("Reason"))
                txtPrintName.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("PrintName"))
                txtJobTitle.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("JobTitle"))
                txtInvoiceNo.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("InvoiceNumber"))
                txtInvoiceTo.Text = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("InvoiceTo"))
                hdnJobId.Value = objFunction.ReturnString(dstJobSheet.Tables(0).Rows(0)("Job_id"))
                FillPartFittedGrid(objFunction.ReturnInteger(hdnJobId.Value))
                FillPartRequireGrid(objFunction.ReturnInteger(hdnJobId.Value))
                BindPartsOrderOnThisJob(objFunction.ReturnInteger(hdnJobId.Value))

            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub
    Protected Sub BindPartsOrderOnThisJob(ByVal id As Integer)

        Try
            Dim dstJobList As New DataSet()
            objBEOrder.JOBID = id
            dstJobList = (New clsDLOrder()).GetPartsOrderForJob(objBEOrder)
            grdPartsOrderForthisJob.DataSource = dstJobList
            grdPartsOrderForthisJob.DataBind()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub



    Public Sub FillPartFittedGrid(ByVal IntJobId As Integer)
        Try
            Dim dstList As New DataSet()
            objBEPartsFitted.JOBID = IntJobId
            dstList = (New clsDLPartsFitted()).GetPartFittedDetailsByJobId(objBEPartsFitted)
            If objFunction.CheckDataSet(dstList) Then
                grdPartsFitted.DataSource = dstList
                grdPartsFitted.DataBind()
                Dim dblTotalAmount As Double = 0
                For i = 0 To dstList.Tables(0).Rows.Count - 1
                    dblTotalAmount += objFunction.ReturnDouble(dstList.Tables(0).Rows(i)("Partprice"))
                Next
                'txtTotalMaterials.Text = dblTotalAmount.ToString()
                'txtSubTotal.Text = (objFunction.ReturnDouble(txtLabour.Text) + objFunction.ReturnDouble(txtMiscCharge.Text) + dblTotalAmount).ToString()
                'txtVAT.Text = (objFunction.ReturnDouble(hdnVat.Value) * objFunction.ReturnDouble(txtSubTotal.Text)).ToString()
                'txtTotalVAT.Text = (objFunction.ReturnDouble(txtSubTotal.Text) + objFunction.ReturnDouble(txtVAT.Text)).ToString()
            Else
                grdPartsFitted.DataSource = Nothing
                grdPartsFitted.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Public Sub FillPartRequireGrid(ByVal IntJobId As Integer)
        Try
            Dim dstList As New DataSet()
            objBEPartRequired.JOBID = IntJobId
            dstList = (New clsDLPartsRequired()).GetPartRequiredDetailsByJobId(objBEPartRequired)
            If objFunction.CheckDataSet(dstList) Then
                grdPartsRequire.DataSource = dstList
                grdPartsRequire.DataBind()
            Else
                grdPartsRequire.DataSource = Nothing
                grdPartsRequire.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPartsRequire_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdPartsRequire.RowEditing
        Try
            grdPartsRequire.EditIndex = e.NewEditIndex
            FillPartRequireGrid(objFunction.ReturnInteger(hdnJobId.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPartsRequire_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdPartsRequire.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdPartsRequire.DataKeys(e.RowIndex).Values("ID")))
            objBEPartRequired.ID = id
            Dim intAffectedRow As Integer = (New clsDLPartsRequired()).PerformGridViewOpertaion("DELETE", objBEPartRequired)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Part Required details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdPartsRequire.EditIndex = -1
            FillPartRequireGrid(objFunction.ReturnInteger(hdnJobId.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub grdPartsRequire_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdPartsRequire.RowCancelingEdit
        Try
            grdPartsRequire.EditIndex = -1
            FillPartRequireGrid(objFunction.ReturnInteger(hdnJobId.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPartsRequire_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdPartsRequire.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdPartsRequire.DataKeys(e.RowIndex).Values("ID")))
            Dim txtpart As TextBox = DirectCast(grdPartsRequire.Rows(e.RowIndex).FindControl("txtpart"), TextBox)
            Dim txtqty As TextBox = DirectCast(grdPartsRequire.Rows(e.RowIndex).FindControl("txtqty"), TextBox)
            objBEPartRequired.PartDetail = txtpart.Text
            objBEPartRequired.Quantity = txtqty.Text
            objBEPartRequired.ID = id
            Dim intAffectedRow As Integer = (New clsDLPartsRequired()).PerformGridViewOpertaion("UPDATE", objBEPartRequired)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Part Required details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdPartsRequire.EditIndex = -1
            FillPartRequireGrid(objFunction.ReturnInteger(hdnJobId.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPartsFitted_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdPartsFitted.RowEditing
        Try
            grdPartsFitted.EditIndex = e.NewEditIndex
            FillPartFittedGrid(objFunction.ReturnInteger(hdnJobId.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPartsFitted_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdPartsFitted.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdPartsFitted.DataKeys(e.RowIndex).Values("ID")))
            objBEPartsFitted.ID = id
            Dim intAffectedRow As Integer = (New clsDLPartsFitted()).PerformGridViewOpertaion("DELETE", objBEPartsFitted)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Part Fitted details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdPartsFitted.EditIndex = -1
            FillPartFittedGrid(objFunction.ReturnInteger(hdnJobId.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPartsFitted_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdPartsFitted.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdPartsFitted.DataKeys(e.RowIndex).Values("ID")))
            Dim txtpart As TextBox = DirectCast(grdPartsFitted.Rows(e.RowIndex).FindControl("txtpcode"), TextBox)
            Dim txtqty As TextBox = DirectCast(grdPartsFitted.Rows(e.RowIndex).FindControl("txtqty"), TextBox)
            'Dim txtprice As TextBox = DirectCast(grdPartsFitted.Rows(e.RowIndex).FindControl("txtprice"), TextBox)
            Dim txtdesc As TextBox = DirectCast(grdPartsFitted.Rows(e.RowIndex).FindControl("txtdesc"), TextBox)
            objBEPartsFitted.ProductCode = txtpart.Text
            'objBEPartsFitted.Partprice = txtprice.Text
            objBEPartsFitted.Partprice = "0"
            objBEPartsFitted.Description = txtdesc.Text
            objBEPartsFitted.qty = txtqty.Text
            objBEPartsFitted.ID = id
            Dim intAffectedRow As Integer = (New clsDLPartsFitted()).PerformGridViewOpertaion("UPDATE", objBEPartsFitted)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Part Fitted details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdPartsFitted.EditIndex = -1
            FillPartFittedGrid(objFunction.ReturnInteger(hdnJobId.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPartsFitted_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdPartsFitted.RowCancelingEdit
        Try
            grdPartsFitted.EditIndex = -1
            FillPartFittedGrid(objFunction.ReturnInteger(hdnJobId.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim blnchargeable As String = ""
            Dim ServiceStatus As String = ""
            Dim PlannedMaintainance As String = ""
            Dim EquipmentIdef As String = ""
            Dim EquipmentInstal As String = ""
            Dim blnwarranty As String = ""
            Dim blncompleted As String = ""

            If chargeable.Checked() Then
                blnchargeable = "1"
            Else
                blnchargeable = "0"
            End If

            If warranty.Checked() Then
                blnwarranty = "1"
            Else
                blnwarranty = "0"
            End If
            If job_completed.Checked() Then
                blncompleted = "1"
            Else
                blncompleted = "0"
            End If

            If RadioButton1.Checked() Then
                ServiceStatus = "1"
            ElseIf RadioButton2.Checked() Then
                ServiceStatus = "2"
            ElseIf RadioButton3.Checked() Then
                ServiceStatus = "3"
            ElseIf RadioButton4.Checked() Then
                ServiceStatus = "4"
            End If

            If RadioButton5.Checked() Then
                PlannedMaintainance = "1"
            Else
                PlannedMaintainance = "0"
            End If

            If RadioButton6.Checked() Then
                EquipmentIdef = "1"
            Else
                EquipmentIdef = "0"
            End If

            If RadioButton7.Checked() Then
                EquipmentInstal = "1"
            Else
                EquipmentInstal = "0"

            End If


            Dim IntJobSheetId = objFunction.ReturnInteger(Request.QueryString("ID"))
            objBEJobsheet.Id = IntJobSheetId
            objBEJobsheet.Customername = txtCustomer.Text
            objBEJobsheet.address = txtAddress.Text
            objBEJobsheet.JobNumber = txtJobRef.Text
            objBEJobsheet.OrderNumber = txtOrderNo.Text
            objBEJobsheet.AssetNumber = txtAssetNo.Text
            objBEJobsheet.InvoiceNumber = txtInvoiceNo.Text
            objBEJobsheet.InvoiceTo = txtInvoiceTo.Text
            objBEJobsheet.ServiceType = ServiceStatus
            objBEJobsheet.PlannedMaintenance = PlannedMaintainance
            objBEJobsheet.EquipmentIdentification = EquipmentIdef
            objBEJobsheet.EquipmentInstallation = EquipmentInstal
            objBEJobsheet.Appliance = txtEquipment.Text
            objBEJobsheet.Manufacturer = txtManufacturer.Text
            objBEJobsheet.Model = txtModel.Text
            objBEJobsheet.SerialNo = txtSerialNo.Text
            objBEJobsheet.TotalTime = txtTotalTime.Text
            objBEJobsheet.GasLeakTest = txtGasLeakTest.Text
            objBEJobsheet.EarthLeakageTest = txtearthleakTest.Text
            objBEJobsheet.LoadTest = txtLoadTest.Text
            objBEJobsheet.flashTest = txtFlashTest.Text
            objBEJobsheet.InsRes = txtIns.Text
            objBEJobsheet.EC = txtEC.Text
            objBEJobsheet.MicrowaveLeakage = txtMicrowaveLeak.Text
            objBEJobsheet.PowerOutput = txtPowerOutput.Text
            objBEJobsheet.fault = txtFaultReported.Text
            objBEJobsheet.workDetails = txtWorkDetails.Text
            objBEJobsheet.TotalParts = txtTotalMaterials.Text
            objBEJobsheet.TotalLabour = txtLabour.Text
            objBEJobsheet.charges = txtMiscCharge.Text
            objBEJobsheet.SubTotal = txtSubTotal.Text
            objBEJobsheet.Vat = txtVAT.Text
            objBEJobsheet.TotalIncVat = txtTotalVAT.Text
            objBEJobsheet.ChargeableStatus = blnchargeable
            objBEJobsheet.warrantyStatus = blnwarranty
            objBEJobsheet.JobCompleteStatus = blncompleted
            objBEJobsheet.Reason = job_unfinished.Text
            objBEJobsheet.PrintName = txtPrintName.Text
            objBEJobsheet.JobTitle = txtJobTitle.Text
            objBEJobsheet.Whenxupdate = DateTime.Now


            Dim intAffectedRow As Integer = (New clsDLJobsheet()).UpdateJobSheetDetails(objBEJobsheet)
            If intAffectedRow > 0 Then

                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Job sheet Details has been Updated.','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)


            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try



    End Sub
End Class