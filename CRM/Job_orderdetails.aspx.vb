Imports System.Globalization
Imports CRM.BE
Imports CRM.DL

Partial Class Job_orderdetails
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Dim objBEClient As clsBEClient = New clsBEClient
    Dim objBElocorder As clsBElocOrder = New clsBElocOrder
    Dim objBEInvoice As clsBEInvoice = New clsBEInvoice
    Dim objBEStatusHistory As ClsBEStatusHistory = New ClsBEStatusHistory
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        'If objFunction.ReturnString(Request.QueryString("JID")) = "" Or objFunction.ReturnString(Request.QueryString("JID")) Is Nothing Then
        '    Response.Redirect("job_select.aspx")
        'End If
        If objFunction.ReturnString(Session("JID")) = "" And Session("JID") Is Nothing Then
            Response.Redirect("job_select.aspx")
        End If
        If Not Page.IsPostBack Then

            Dim dstcompany As DataSet = (New clsDLClient()).GetClientFillInDD()
            objFunction.FillDropDownByDataSet(ddlCompany, dstcompany)
            ddlCompany.Items.Insert(0, New ListItem("Select Company", ""))

            Dim intJobId = objFunction.ReturnInteger(Session("JID"))
            GetOrderDetails(intJobId)
            BindPartsOrderOnThisJob(intJobId)
            Dim dstStatus As DataSet = (New ClsDLPulldownStatus()).GetPulldownStatusFillInDD()
            objFunction.FillDropDownByDataSet(ddlstatus, dstStatus)
            ddlstatus.Items.Insert(0, New ListItem("Select Status", ""))

            Dim dstAppliance As DataSet = (New clsDLOrder()).GetOrderApplianceFillInDD()
            objFunction.FillDropDownByDataSet(ddlAppliance, dstAppliance)
            ddlAppliance.Items.Insert(0, New ListItem("Select Appliance", ""))
        End If



    End Sub

    Protected Sub GetOrderDetails(ByVal id As Integer)
        Try
            Dim dstJobList As New DataSet()
            objBEOrder.JOBID = id
            dstJobList = (New clsDLOrder()).GetJobDetailsByJobID(objBEOrder)
            If dstJobList IsNot Nothing Then
                txtCompany.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Name"))
                ddlCompany.SelectedValue = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("CID"))
                txtEngineer.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Engineer"))
                txtEngineer1.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Engineer"))
                txtEngineersheetdate.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Sdate"))
                txtFault.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Fault"))
                txtPermission.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Premises"))
                txtAddress1.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("ADD1"))
                txtAddress2.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("ADD2"))
                txtAddress3.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("ADD3"))
                txtPermissionPostCode.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("PPCode"))
                txtAssetNumber.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Asset"))
                txtAppliance.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Appliance"))
                txtResponse.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Response"))
                txtPhone.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Phone"))
                txtTelphone.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Telephone"))
                txtJobNumber.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("JobNumber"))
                txtJobNumber1.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("JobNumber"))
                txtStatus.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Status"))
                txtStatus1.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Status"))
                txtOrderNumber.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("OrderNo"))
                hdnCid.Value = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("CID"))
                txtCalender.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("EnquiryDate"))
                txtContactName.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("ContactName"))
                ddlstatus3.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Type"))
                ddlAppliance.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Appliance"))
                hdnJobid.Value = id
                BindVat()
                txtVat.Text = String.Format("{0:n2}", (objFunction.ReturnDouble(txtExvat.Text) * objFunction.ReturnDouble(dstJobList.Tables(0).Rows(0)("VatRate")))).ToString()
                txtOrderTotal.Text = (objFunction.ReturnDouble(txtExvat.Text) + objFunction.ReturnDouble(txtVat.Text)).ToString()
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
    Protected Sub BindVat()

        Try
            Dim intJobId = objFunction.ReturnInteger(hdnJobid.Value)
            Dim dstJobCost As New DataSet()
            objBEInvoice.JOBID = intJobId
            dstJobCost = (New clsDLInvoice()).GetInvoiceItemDetailsById(objBEInvoice)
            Dim dblTotalAmountVal As Double = 0
            If objFunction.CheckDataSet(dstJobCost) Then
                For i = 0 To dstJobCost.Tables(0).Rows.Count - 1
                    dblTotalAmountVal += objFunction.ReturnDouble(dstJobCost.Tables(0).Rows(i)("Total"))
                Next
                txtExvat.Text = String.Format("{0:n2}", dblTotalAmountVal).ToString()

            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub
    Protected Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Try
            objBEOrder.ID = ddlCompany.SelectedValue
            objBEOrder.Address1 = txtAddress1.Text
            objBEOrder.Address2 = txtAddress2.Text
            objBEOrder.Address3 = txtAddress3.Text
            If (ddlAppliance.SelectedValue <> "") Then
                objBEOrder.Appliance = ddlAppliance.SelectedItem.Text
            Else
                objBEOrder.Appliance = txtAppliance.Text
            End If
            objBEOrder.Response = txtResponse.Text
            objBEOrder.Telephone = txtTelphone.Text
            objBEOrder.Premises = txtPermission.Text
            objBEOrder.PremisesPostCode = txtPermissionPostCode.Text
            objBEOrder.Fault = txtFault.Text
            objBEOrder.Engineer = txtEngineer1.Text
            objBEOrder.OrderNumber = txtOrderNumber.Text
            objBEOrder.AssetNumber = txtAssetNumber.Text
            objBEOrder.JobNumber = txtJobNumber1.Text
            objBEOrder.Type = ddlstatus3.Text
            If (ddlstatus.SelectedValue <> "") Then
                objBEOrder.Status = ddlstatus.SelectedItem.Text
            Else
                objBEOrder.Status = txtStatus1.Text
            End If
            objBEOrder.JOBID = objFunction.ReturnInteger(hdnJobid.Value)

            If (txtEngineersheetdate.Text <> "") Then
                Dim dt As DateTime = DateTime.ParseExact(txtEngineersheetdate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                objBEOrder.SheetDate = Convert.ToDateTime(dt)
                'objBEOrder.SheetDate = txtEngineersheetdate.Text
            Else
                objBEOrder.SheetDate = DateTime.Now.ToString()
            End If
            If (txtCalender.Text <> "") Then
                Dim dt As DateTime = DateTime.ParseExact(txtCalender.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                objBEOrder.EnquiryDate = Convert.ToDateTime(dt)
                'objBEOrder.EnquiryDate = txtCalender.Text
            End If
            objBEOrder.ContactName = txtContactName.Text

            Dim intAffectedRow As Integer = (New clsDLOrder()).UpdateOrderDetails(objBEOrder)
            If intAffectedRow > 0 Then
                Dim objBEclient As clsBEClient = New clsBEClient
                objBEclient.Phone = txtPhone.Text
                objBEclient.ClientId = objFunction.ReturnInteger(hdnCid.Value)
                intAffectedRow = (New clsDLClient()).UpdateClientDetails(objBEclient)
                If intAffectedRow > 0 Then
                    'Dim objBElocOrder As clsBElocOrder = New clsBElocOrder
                    'If (ddlAppliance.SelectedValue <> "") Then
                    '    objBElocOrder.Appliance = ddlAppliance.SelectedItem.Text
                    'Else
                    '    objBElocOrder.Appliance = txtAppliance.Text
                    'End If
                    'objBElocOrder.Engineer = txtEngineer1.Text
                    'objBElocOrder.JobType = ddlstatus3.Text
                    'objBElocOrder.JobNumber = txtJobNumber1.Text
                    'objBElocOrder.Premises = txtPermission.Text
                    'objBElocOrder.OrderNumber = txtOrderNumber.Text
                    'objBElocOrder.Fault = txtFault.Text
                    'If (ddlstatus.SelectedValue <> "") Then
                    '    objBElocOrder.Status = ddlstatus.SelectedItem.Text
                    'Else
                    '    objBElocOrder.Status = txtStatus1.Text
                    'End If
                    'objBElocOrder.JOBID = hdnJobid.Value
                    'If (txtEngineersheetdate.Text <> "") Then
                    '    Dim dt As DateTime = DateTime.ParseExact(txtEngineersheetdate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                    '    objBElocOrder.SheetDate = Convert.ToDateTime(dt)
                    'Else
                    '    objBElocOrder.SheetDate = DateTime.Now.ToString()
                    'End If
                    'intAffectedRow = (New clsDLlocOrder()).UpdatelocOrderDetails(objBElocOrder)
                    objBEStatusHistory.JOBID = objFunction.ReturnInteger(hdnJobid.Value)
                    objBEStatusHistory.From = txtStatus1.Text
                    objBEStatusHistory.ToStatus = ddlstatus.SelectedItem.Text
                    objBEStatusHistory.TodayDate = DateTime.Now
                    intAffectedRow = (New ClsDLStatusHistory()).AddStatusHistory(objBEStatusHistory)

                    If intAffectedRow > 0 Then

                        Dim javaScript As String = ""
                        javaScript += "<script type='text/javascript'>"
                        javaScript += "$(document).ready(function(){"
                        javaScript += "ShowPopup('Order details were updated','success');"
                        javaScript += "});"
                        javaScript += "</script>"
                        ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                        Dim intJobId = objFunction.ReturnInteger(Session("JID"))
                        GetOrderDetails(intJobId)
                        BindPartsOrderOnThisJob(intJobId)

                    End If
                End If
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowPopup(ex.Message,'error');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        End Try
    End Sub

    Protected Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        Try
            objBEOrder.JOBID = objFunction.ReturnInteger(hdnJobid.Value)
            Dim intAffectedRow As Integer = (New clsDLOrder()).DeleteOrderDetailsByJobId(objBEOrder)
            If intAffectedRow > 0 Then

                objBElocorder.JOBID = objFunction.ReturnInteger(hdnJobid.Value)
                Dim intAffectedRow1 As Integer = (New clsDLlocOrder()).DeletelocOrderDetailsByJobId(objBElocorder)
                If intAffectedRow > 0 Then
                    Dim javaScript As String = ""
                    javaScript += "<script type='text/javascript'>"
                    javaScript += "$(document).ready(function(){"
                    javaScript += "ShowPopup('Job Order details have been deleted','success');"
                    javaScript += "});"
                    javaScript += "</script>"
                    ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                End If
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try

            Dim intJobId = objFunction.ReturnInteger(Session("JID"))
            Session("JID") = intJobId.ToString()
            'Response.Redirect("Job_OrderPrint.aspx")
            Dim pageurl As String = "Job_OrderPrint.aspx"
            Response.Write("<script>window.open ('" + pageurl + "','_blank');</script>")

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
End Class