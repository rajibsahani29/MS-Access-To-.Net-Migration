Imports CRM.BE
Imports CRM.DL
Public Class Parts_Part_add_new
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEAppliances As clsBEAppliances = New clsBEAppliances
    Dim objBEParts As clsBEParts = New clsBEParts
    Dim objBEPartsOrder As clsBEPartsOrder = New clsBEPartsOrder


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'If objFunction.ReturnString(Session("ID")) = "" And Session("ID") Is Nothing Then
        '    Response.Redirect("Parts_Part_OrderList.aspx")
        'End If
        If Not Page.IsPostBack Then
            'Dim intPartOrderId = objFunction.ReturnInteger(Session("ID"))
            Try
                'Dim dstList As New DataSet()
                'objBEPartsOrder.PartsOrderID = intPartOrderId
                'dstList = (New clsDLPartsOrder()).GetPartsOrderDetailsByID(objBEPartsOrder)
                'If objFunction.CheckDataSet(dstList) Then
                '    txtOrderNo.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("OrderNumber"))
                '    txtsupplier.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("SupplierName"))
                '    txtTotalCost.Text = objFunction.ReturnDouble(dstList.Tables(0).Rows(0)("DeliveryCost"))
                '    'hdnSupplierId.Value = objFunction.ReturnString(dstList.Tables(0).Rows(0)("SupplierID"))
                '    
                'End If
                Dim dstManufacturer As DataSet = (New clsDLManufacturer()).GetManufactureFillInDD()
                objFunction.FillDropDownByDataSet(ddlManufacturer, dstManufacturer)
                ddlManufacturer.Items.Insert(0, New ListItem("Select Manufacturer", ""))

                Dim dstAppType As DataSet = (New clsDLApplianceType()).GetApplianceTypeFillInDD()
                objFunction.FillDropDownByDataSet(ddlApplianceType, dstAppType)
                ddlApplianceType.Items.Insert(0, New ListItem("Select Appliace Type", ""))

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
        End If

    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            objBEParts.ManufacturerID = ddlManufacturer.SelectedItem.Value
            objBEParts.ApplianceID = ddlApplianceType.SelectedItem.Value
            objBEParts.FastFixxSellingPrice = 0
            objBEParts.ManufacturersListPrice = 0
            objBEParts.PartNumber = txtPartNo.Text
            objBEParts.Description = txtDescription.Text

            Dim intAffectedRow As Integer = (New clsDLParts()).AddPartsDetails(objBEParts)
            If intAffectedRow > 0 Then
                Dim str As String = txtPartNo.Text
                Dim strdesc As String = txtDescription.Text
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('New Part Has Been Added To system with PartNo " + str + " and " + strdesc + "','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
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

    Protected Sub ddlApplianceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlApplianceType.SelectedIndexChanged

        'objBEAppliances.ApplianceTypeID = ddlApplianceType.SelectedItem.Value
        'objBEAppliances.ManufacturerID = ddlManufacturer.SelectedItem.Value
        'Dim dstModel As DataSet = (New clsDLAppliances()).GetModelTypeFillInDD(objBEAppliances)
        'objFunction.FillDropDownByDataSet(ddlModel, dstModel)
        'ddlModel.Items.Insert(0, New ListItem("Select Model", ""))
    End Sub

    Protected Sub btnAddModel_Click(sender As Object, e As EventArgs) Handles btnAddModel.Click
        Try
            objBEAppliances.ManufacturerID = ddlManufacturer.SelectedItem.Value
            objBEAppliances.ApplianceTypeID = ddlApplianceType.SelectedItem.Value
            objBEAppliances.Model = txtModel.Text
            objBEAppliances.DellFlag = 0

            Dim intAffectedRow As Integer = (New clsDLAppliances()).AddApplianceDetails(objBEAppliances)
            If intAffectedRow > 0 Then
                Dim str As String = txtModel.Text
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('New Appliance Model " + str + " Has Been Added.','success');"
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