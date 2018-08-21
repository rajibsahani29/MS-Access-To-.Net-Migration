Imports CRM.BE
Imports CRM.DL

Public Class job_sheet
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Dim objBEPartsFitted As clsBEPartsFitted = New clsBEPartsFitted
    Dim objBEJobsheet As clsBEJobsheet = New clsBEJobsheet
    Dim objBEPartRequired As clsBEPartRequired = New clsBEPartRequired
    Dim objBEToastUser As clsBEToastUser = New clsBEToastUser
    Dim objBEAppliances As clsBEAppliances = New clsBEAppliances


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Request.QueryString("JobId")) = "" Or objFunction.ReturnString(Request.QueryString("JobId")) Is Nothing Then
            Response.Redirect("Index-mobile.aspx")
        End If

        If Not Page.IsPostBack Then
            Dim strJobId = objFunction.ReturnString(Request.QueryString("JobId"))
            GetOrderDetails(strJobId)
            hdnJobId.Value = objFunction.ReturnString(objFunction.ReturnString(Request.QueryString("JobId")))
            hdnVat.Value = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings("VAT"))
            Dim dstManufacturer As DataSet = (New clsDLManufacturer()).GetManufactureFillInDD()
            objFunction.FillDropDownByDataSet(ddlManufacturer, dstManufacturer)
            ddlManufacturer.Items.Insert(0, New ListItem("Select Manufacturer", ""))

        End If
    End Sub

    Protected Sub GetOrderDetails(ByVal id As String)


        Try
            Dim dstJobList As New DataSet()
            objBEOrder.JOBID = id
            dstJobList = (New clsDLOrder()).GetJobDetailsByJobID(objBEOrder)
            If dstJobList IsNot Nothing Then
                txtCustomer.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Premises"))
                'txtCustomer.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Name"))
                'txtEngineer.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Engineer"))
                txtFaultReported.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Fault"))
                'txtPermission.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Premises"))
                txtAddress.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("ADD1")) + "," + objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("ADD2")) + "," + objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("PPCode"))
                hdnName.Value = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Name"))
                'txtPermissionPostCode.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("PPCode"))
                txtAssetNo.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Asset"))
                'txtResponse.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Response"))
                'txtPhone.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Phone"))
                'txtTelphone.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Telephone"))
                'txtJobNumber.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("JobNumber"))
                'txtStatus.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Status"))
                txtOrderNo.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("OrderNo"))
                txtJobRef.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("FFNUMBER"))
                txtEquipment.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Appliance"))
                'txtModel.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Model"))
                hdnModel.Value = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Model"))
                hdncid.Value = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("OID"))

            End If


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub
    Private Sub BindGrid(IntJobId As Integer)

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

    Protected Sub btnAddpart_Click(sender As Object, e As EventArgs) Handles btnAddpart.Click
        Try
            Dim IntJobId = objFunction.ReturnInteger(Request.QueryString("JobId"))
            objBEPartRequired.JOBID = IntJobId
            objBEPartRequired.Quantity = txtqty.Text
            objBEPartRequired.PartDetail = txtpartdescription.Text
            Dim intAffectedRowPart As Integer = (New clsDLPartsRequired()).AddPartRequiredDetails(objBEPartRequired)
            If intAffectedRowPart > 0 Then
                BindGrid(objFunction.ReturnInteger(Request.QueryString("JobId")))
                txtpartdescription.Text = String.Empty
                txtqty.Text = String.Empty
                txtpartdescription.Focus()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try



    End Sub

    Protected Sub btnPartsFit_Click(sender As Object, e As EventArgs) Handles btnPartsFit.Click
        Try
            Dim IntJobId = objFunction.ReturnInteger(Request.QueryString("JobId"))
            objBEPartsFitted.JOBID = IntJobId
            objBEPartsFitted.qty = txtqtyfitted.Text
            objBEPartsFitted.ProductCode = txtproductcode.Text
            objBEPartsFitted.Description = txtdescription.Text
            objBEPartsFitted.Partprice = "0"
            Dim intAffectedRow As Integer = (New clsDLPartsFitted()).AddPartFittedDetails(objBEPartsFitted)
            If intAffectedRow > 0 Then
                txtqtyfitted.Text = ""
                txtproductcode.Text = ""
                txtdescription.Text = ""
                txtprice.Text = ""
                FillPartFittedGrid()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub

    Public Sub FillPartFittedGrid()
        Try
            Dim dstList As New DataSet()
            Dim IntJobId = objFunction.ReturnInteger(Request.QueryString("JobId"))
            objBEPartsFitted.JOBID = IntJobId
            dstList = (New clsDLPartsFitted()).GetPartFittedDetailsByJobId(objBEPartsFitted)
            If objFunction.CheckDataSet(dstList) Then
                grdPartsFitted.DataSource = dstList
                grdPartsFitted.DataBind()
                Dim dblTotalAmount As Double = 0
                For i = 0 To dstList.Tables(0).Rows.Count - 1
                    dblTotalAmount += objFunction.ReturnDouble(dstList.Tables(0).Rows(i)("Partprice"))
                Next
                txtTotalMaterials.Text = dblTotalAmount.ToString()
                txtSubTotal.Text = (objFunction.ReturnDouble(txtLabour.Text) + objFunction.ReturnDouble(txtMiscCharge.Text) + dblTotalAmount).ToString()
                txtVAT.Text = (objFunction.ReturnDouble(hdnVat.Value) * objFunction.ReturnDouble(txtSubTotal.Text)).ToString()
                txtTotalVAT.Text = (objFunction.ReturnDouble(txtSubTotal.Text) + objFunction.ReturnDouble(txtVAT.Text)).ToString()
            Else
                grdPartsFitted.DataSource = Nothing
                grdPartsFitted.DataBind()
            End If
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


                Dim IntJobId = objFunction.ReturnInteger(Request.QueryString("JobId"))
                objBEJobsheet.JOBID = IntJobId
                objBEJobsheet.clientId = objFunction.ReturnInteger(hdncid.Value)
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
            objBEJobsheet.Manufacturer = ddlManufacturer.SelectedItem.Text
            objBEJobsheet.Model = ddlModel.SelectedItem.Text
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
                objBEJobsheet.Engineerid = objFunction.ReturnInteger(Session("LoginUserId"))
                objBEJobsheet.Whenx = DateTime.Now
                Dim intAffectedRow As Integer = (New clsDLJobsheet()).AddJobSheetDetails(objBEJobsheet)
                If intAffectedRow > 0 Then

                    objBEToastUser.userid = objFunction.ReturnInteger(Session("LoginUserId"))
                    objBEToastUser.Engineer = objFunction.ReturnString(Session("UserName"))
                    objBEToastUser.ClientName = objFunction.ReturnString(hdnName.Value)
                    objBEToastUser.job_id = IntJobId
                    objBEToastUser.Whenx = DateTime.Now.ToShortDateString()
                    objBEToastUser.Flag = 0

                    Dim intAffectedRowToastUser As Integer = (New clsDLToastUser()).AddToastUserDetails(objBEToastUser)
                    If intAffectedRowToastUser > 0 Then
                        Dim javaScript As String = ""
                        javaScript += "<script type='text/javascript'>"
                        javaScript += "$(document).ready(function(){"
                        javaScript += "ShowPopup('New Job sheet has been submitted.','success');"
                        javaScript += "});"
                        javaScript += "</script>"
                        ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                        btnSubmit.Enabled = False
                    End If

                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

            End Try

    End Sub

    Protected Sub grdPartsFitted_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdPartsFitted.RowEditing
        Try
            grdPartsFitted.EditIndex = e.NewEditIndex
            FillPartFittedGrid()
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
            FillPartFittedGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPartsFitted_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdPartsFitted.RowCancelingEdit
        Try
            grdPartsFitted.EditIndex = -1
            FillPartFittedGrid()
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
            FillPartFittedGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPartsRequire_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdPartsRequire.RowEditing
        Try
            grdPartsRequire.EditIndex = e.NewEditIndex
            BindGrid(objFunction.ReturnInteger(hdnJobId.Value))
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
            BindGrid(objFunction.ReturnInteger(hdnJobId.Value))
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
            BindGrid(objFunction.ReturnInteger(hdnJobId.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPartsRequire_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdPartsRequire.RowCancelingEdit
        Try
            grdPartsRequire.EditIndex = -1
            BindGrid(objFunction.ReturnInteger(hdnJobId.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdPartsFitted_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdPartsFitted.RowDataBound
        Try
            If e.Row.RowType = DataControlRowType.DataRow Then
                Dim lb As LinkButton = DirectCast(e.Row.Cells(5).Controls(2), LinkButton)

                If lb IsNot Nothing Then
                    If lb.Text = "Delete" Then
                        lb.Attributes.Add("onclick", "javascript:return ShowDeletePopup(this, 'Record will be Permanently Deleted')")

                    End If
                End If
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub grdPartsRequire_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdPartsRequire.RowDataBound
        Try
            If e.Row.RowType = DataControlRowType.DataRow Then
                Dim lb As LinkButton = DirectCast(e.Row.Cells(3).Controls(2), LinkButton)

                If lb IsNot Nothing Then
                    If lb.Text = "Delete" Then
                        lb.Attributes.Add("onclick", "javascript:return ShowDeletePopup(this, 'Record will be Permanently Deleted')")

                    End If
                End If
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub ddlManufacturer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlManufacturer.SelectedIndexChanged

        If (ddlManufacturer.SelectedItem.Value <> "") Then
            'objBEAppliances.ApplianceTypeID = ddlApplianceType.SelectedItem.Value
            objBEAppliances.ManufacturerID = ddlManufacturer.SelectedItem.Value
            Dim dstModel As DataSet = (New clsDLAppliances()).GetModelTypeFillInDDByManufacturerID(objBEAppliances)
            objFunction.FillDropDownByDataSet(ddlModel, dstModel)
            ddlModel.Items.Insert(0, New ListItem("Select Model", ""))
            ddlManufacturer.Focus()
        Else
            ddlModel.Items.Clear()
        End If
    End Sub
End Class