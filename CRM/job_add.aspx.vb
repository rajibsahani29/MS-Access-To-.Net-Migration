Imports CRM.BE
Imports CRM.DL
Public Class job_add
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEClient As clsBEClient = New clsBEClient
    Dim objBEAppliances As clsBEAppliances = New clsBEAppliances
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Dim objBElocOrder As clsBElocOrder = New clsBElocOrder
    Dim objBENextNumber As clsBENextNumber = New clsBENextNumber

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            FillGrid()
            'Dim dstModel As DataSet = (New clsDLOrder()).GetModelFillInDD()
            'objFunction.FillDropDownByDataSet(ddlModel, dstModel)
            'ddlModel.Items.Insert(0, New ListItem("Select Model", ""))

            'Dim dstAppliance As DataSet = (New clsDLOrder()).GetOrderApplianceFillInDD()
            'objFunction.FillDropDownByDataSet(ddlAppliance, dstAppliance)
            'ddlAppliance.Items.Insert(0, New ListItem("Select Appliance", ""))

            Dim dstManufacturer As DataSet = (New clsDLManufacturer()).GetManufactureFillInDD()
            objFunction.FillDropDownByDataSet(ddlManufacturer, dstManufacturer)
            ddlManufacturer.Items.Insert(0, New ListItem("Select Manufacturer", ""))
            ddlManufacturer.Items.Insert(1, New ListItem("Add New Manufacturer", "ADD"))

            Dim dstAppliance As DataSet = (New clsDLApplianceType()).GetApplianceTypeFillInDD()
            objFunction.FillDropDownByDataSet(ddlAppliance, dstAppliance)
            ddlAppliance.Items.Insert(0, New ListItem("Select Appliance", ""))
            ddlAppliance.Items.Insert(1, New ListItem("Edit & Delete Appliance", "Edit"))

        End If
    End Sub

    Public Sub FillGrid()
        'Try
        '    Dim dstList As New DataSet()
        '    dstList = (New clsDLClient()).GetClientDetails()
        '    If objFunction.CheckDataSet(dstList) Then
        '        grdclients.DataSource = dstList
        '        grdclients.DataBind()
        '    End If
        'Catch ex As Exception
        '    HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
        '    HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        'End Try
        Try

            Dim strSearch1 As String = (If(txtsearchclient1.Text <> "", txtsearchclient1.Text, ""))
            Dim strSearch2 As String = (If(txtsearchclient2.Text <> "", txtsearchclient2.Text, ""))
            Dim dstJobList As DataSet = (New clsDLClient()).GetClientDetailsBySearch(strSearch1, strSearch2)
            If objFunction.CheckDataSet(dstJobList) Then
                grdclients.DataSource = dstJobList
                grdclients.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub
    Protected Sub GetClientDetails(ByVal id As Integer)
        Try
            Dim dstClient As New DataSet()
            objBEClient.ClientId = id
            dstClient = (New clsDLClient()).GetClientDetailById(objBEClient)
            If dstClient IsNot Nothing Then
                txtCompanyName.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Cname"))
                txtContactPos.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("contact"))
                txtForeName.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Forename"))
                txtSurname.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Surname"))
                txtStreet.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Street"))
                txtArea.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Area"))
                txtTown.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Town"))
                txtPhone.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Phone"))
                txtFax.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Fax"))
                txtPostCode.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Postcode"))
                txtEmail.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Email"))
                txtMobNum.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("MobileNumber"))
                txtAddress.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Street"))
                txtAddress1.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Area"))
                txtaddress2.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Town"))
                txtPCode.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Postcode"))
                objBEClient.Postcode = txtPostCode.Text
                Dim dstPremises As DataSet = (New clsDLClient()).GetClientDetailByPostCode(objBEClient)
                objFunction.FillDropDownByDataSet(txtpremises, dstPremises)
                txtpremises.SelectedItem.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Cname"))

            End If


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub

    Protected Sub grdclients_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdclients.SelectedIndexChanging
        Try
            Dim ClientID As Integer = objFunction.ReturnInteger(grdclients.DataKeys(e.NewSelectedIndex).Value)
            hdnClientID.Value = ClientID
            GetClientDetails(ClientID)

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdclients_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdclients.PageIndexChanging
        Try
            grdclients.PageIndex = e.NewPageIndex
            FillGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        'Response.Redirect("~/add_company.aspx")
        Response.Write("<script>window.open('add_company.aspx','_blank');</script>")

    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FillGrid()
    End Sub

    Protected Sub btnAddJob_Click(sender As Object, e As EventArgs) Handles btnAddJob.Click

        If (hdnClientID.Value = "") Then
            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowPopupBlank('Sorry,You Have Not Select Any Company Name For Add The Job');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        Else

            Try

                objBEOrder.ID = objFunction.ReturnInteger(hdnClientID.Value)
                objBEOrder.OrderTakenBy = ""
                objBEOrder.Status = "Enquiry"
                'objBEOrder.Datex =
                objBEOrder.EnquiryDate = DateTime.Now
                objBEOrder.EnqDate = DateTime.Now.ToShortDateString()
                objBEOrder.OrderNumber = txtOrderNum.Text
                objBEOrder.AssetNumber = txtAssetNumber.Text
                objBEOrder.Type = ddlType.Text
                objBEOrder.ModelofAppliance = hdnModel.Value
                objBEOrder.Premises = txtpremises.SelectedItem.Text
                objBEOrder.PremisesPostCode = txtPCode.Text
                objBEOrder.Address1 = txtAddress.Text
                objBEOrder.Address2 = txtAddress1.Text
                objBEOrder.Address3 = txtaddress2.Text
                objBEOrder.Fault = txtAreaFault.Text
                objBEOrder.EngineerListed = 0
                Dim intNextInvoice As Integer = (New clsDLOrder()).GetNextInvoiceNumber()
                objBEOrder.FFNUMBER = intNextInvoice + 1
                If (chkRefrigiration.Checked()) Then
                    objBEOrder.JobNumber = "RFF" + (intNextInvoice + 1).ToString()
                Else
                    objBEOrder.JobNumber = "FF" + (intNextInvoice + 1).ToString()
                End If
                objBEOrder.ApplianceID = ddlAppliance.SelectedItem.Value
                objBEOrder.Telephone = txtPhone.Text
                objBEOrder.ContactName = txtContactPos.Text
                objBEOrder.RecallFlag = 0
                objBEOrder.StaffID = objFunction.ReturnString(Session("LoginUserId"))
                objBEOrder.ServiceType = ddlSType.Text

                Dim intAffectedRow As Integer = (New clsDLOrder()).AddOrderDetails(objBEOrder)
                If intAffectedRow > 0 Then
                    objBElocOrder.JOBID = intAffectedRow
                    objBElocOrder.ID = objFunction.ReturnInteger(hdnClientID.Value)
                    objBElocOrder.Status = "Enquiry"
                    objBElocOrder.EnquiryDate = DateTime.Now()
                    'objBElocOrder.EnqDate = DateTime.Now.ToShortDateString()
                    objBElocOrder.OrderNumber = txtOrderNum.Text
                    objBElocOrder.JobType = ddlType.Text
                    objBElocOrder.Appliance = ddlAppliance.SelectedItem.Text
                    objBElocOrder.Premises = txtpremises.SelectedItem.Text
                    objBElocOrder.Fault = txtAreaFault.Text
                    If (chkRefrigiration.Checked()) Then
                        objBElocOrder.JobNumber = "RFF" + (intNextInvoice + 1).ToString()
                    Else
                        objBElocOrder.JobNumber = "FF" + (intNextInvoice + 1).ToString()
                    End If
                    Dim intAffectedRow1 As Integer = (New clsDLlocOrder()).AddlocOrderDetails(objBElocOrder)
                    If (intAffectedRow1 > 0) Then
                        objBENextNumber.NextNo = intNextInvoice + 1
                        Dim intAffectedRow2 As Integer = (New clsDLNextNumber()).UpdateNextNumber(objBENextNumber)
                        If intAffectedRow2 > 0 Then
                            If (chkNew.Checked()) Then
                                objBEClient.CompanyName = txtpremises.SelectedItem.Text
                                objBEClient.Street = txtAddress.Text
                                objBEClient.Area = txtAddress1.Text
                                objBEClient.Town = txtaddress2.Text
                                objBEClient.Postcode = txtPCode.Text
                                objBEClient.OnStatementList = 0
                                objBEClient.UpliftPayment = 0
                                objBEClient.RemittanceSlip = 0
                                objBEClient.OnStop = 0
                                objBEClient.NullNoJob = 0
                                Dim intAffectedRow3 As Integer = (New clsDLClient()).AddClientDetailsInAddJob(objBEClient)
                                If intAffectedRow3 > 0 Then
                                    Dim javaScript As String = ""
                                    javaScript += "<script type='text/javascript'>"
                                    javaScript += "$(document).ready(function(){"
                                    javaScript += "ShowPopup('New Job Added Sucessfully','success');"
                                    javaScript += "});"
                                    javaScript += "</script>"
                                    ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                                End If
                            Else
                                Dim javaScript As String = ""
                                javaScript += "<script type='text/javascript'>"
                                javaScript += "$(document).ready(function(){"
                                javaScript += "ShowPopup('New Job Added Sucessfully','success');"
                                javaScript += "});"
                                javaScript += "</script>"
                                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                            End If


                        End If
                    End If
                End If

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

            End Try
        End If

    End Sub

    Protected Sub ddlManufacturer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlManufacturer.SelectedIndexChanged

        'If (ddlManufacturer.SelectedItem.Value <> "" And ddlManufacturer.SelectedItem.Value <> "ADD") Then
        '    'objBEAppliances.ApplianceTypeID = ddlApplianceType.SelectedItem.Value
        '    objBEAppliances.ManufacturerID = ddlManufacturer.SelectedItem.Value
        '    Dim dstModel As DataSet = (New clsDLAppliances()).GetModelTypeFillInDDByManufacturerID(objBEAppliances)
        '    objFunction.FillDropDownByDataSet(ddlModel, dstModel)
        '    ddlModel.Items.Insert(0, New ListItem("Select Model", ""))
        '    ddlModel.Items.Insert(1, New ListItem("Edit & Delete Model", "Edit"))
        '    ddlManufacturer.Focus()
        'Else
        '    ddlModel.Items.Clear()
        'End If


    End Sub

    Protected Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Response.Redirect("job_add.aspx")
    End Sub

    Protected Sub txtpremises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtpremises.SelectedIndexChanged
        'Try
        '    txtStreet.Text = ""
        '    txtArea.Text = ""
        '    txtTown.Text = ""
        '    hdnClientID.Value = ""
        '    Dim dstClient As New DataSet()
        '    objBEClient.ClientId = txtpremises.SelectedValue
        '    dstClient = (New clsDLClient()).GetClientDetailById(objBEClient)
        '    If dstClient IsNot Nothing Then
        '        hdnClientID.Value = txtpremises.SelectedValue
        '        txtStreet.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Street"))
        '        txtArea.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Area"))
        '        txtTown.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Town"))
        '    End If

        'Catch ex As Exception
        '    HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
        '    HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        'End Try
    End Sub
End Class