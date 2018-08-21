Imports System.Globalization
Imports CRM.BE
Imports CRM.DL
Public Class Parts_order
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEPartsOrder As clsBEPartsOrder = New clsBEPartsOrder
    Dim objBERequestPart As clsBERequestpart = New clsBERequestpart
    Dim objBEPONumber As clsBENextPONumber = New clsBENextPONumber
    Dim Status As String



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Session("NID")) = "" Or objFunction.ReturnString(Session("NID")) Is Nothing Then
            Status = "UPDATE"
            If objFunction.ReturnString(Session("ID")) = "" And Session("ID") Is Nothing Then
                Response.Redirect("Parts_Part_OrderList.aspx")
            End If
        Else
            Status = "SAVE"
        End If
        If Not Page.IsPostBack Then
            Dim dstsupplier As DataSet = (New clsDLSupplier()).GetSupplierFillInDD()
            objFunction.FillDropDownByDataSet(ddlSupplier, dstsupplier)
            ddlSupplier.Items.Insert(0, New ListItem("Select Supplier", ""))
            If Status = "UPDATE" Then
                '/*ADDED New Code on 16th Aug,2018*/
                divExisting.Visible = True
                divNew.Visible = True
                flatradio2.Checked = True
                grdToBeOrder.Visible = False
                grdOrderedParts.Visible = True
                '/*End of Code on 16th Aug,2018*/
                Dim strPartOrderId = objFunction.ReturnString(Session("ID"))
                Try
                    Dim dstList As New DataSet()
                    objBEPartsOrder.PartsOrderID = strPartOrderId
                    dstList = (New clsDLPartsOrder()).GetPartsOrderDetailsByID(objBEPartsOrder)
                    If objFunction.CheckDataSet(dstList) Then
                        txtOrderNo.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("OrderNumber"))
                        txtOrderNo1.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("OrderNumber"))
                        txtsupplier.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("SupplierName"))
                        txtTotalCost.Text = objFunction.ReturnDouble(dstList.Tables(0).Rows(0)("DeliveryCost"))
                        'hdnSupplierId.Value = objFunction.ReturnString(dstList.Tables(0).Rows(0)("SupplierID"))
                        ddlSupplier.SelectedValue = objFunction.ReturnString(dstList.Tables(0).Rows(0)("SupplierID"))
                        txtOrderDate.Text = Convert.ToDateTime(dstList.Tables(0).Rows(0)("DateOrderCreated")).ToString("dd/MM/yyyy")
                        FillGrid()
                    End If

                Catch ex As Exception
                    HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                    HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
                End Try
            Else
                '/*ADDED New Code on 16th Aug,2018*/
                divExisting.Visible = True
                divNew.Visible = True

                flatradio1.Checked = True
                grdOrderedParts.Visible = False
                grdToBeOrder.Visible = True
                FillGridToBeOrder()
                Dim intPoNumber As Integer = (New clsDLNextPONumber()).GetPONumber()
                txtOrderNo.Text = intPoNumber.ToString()
                txtOrderNo1.Text = intPoNumber.ToString()
                '/*End of Code on 16th Aug,2018*/
            End If

        End If

    End Sub
    Public Sub FillGrid()
        Try
            Dim dstOrderList As New DataSet()
            objBEPartsOrder.OrderNumber = txtOrderNo.Text
            dstOrderList = (New clsDLPartsOrder()).PartsOnOrder(objBEPartsOrder)
            If objFunction.CheckDataSet(dstOrderList) Then
                grdOrderedParts.DataSource = dstOrderList
                grdOrderedParts.DataBind()
            Else
                grdOrderedParts.DataSource = Nothing
                grdOrderedParts.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub
    Protected Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim flag As Boolean = False
        If (flatradio1.Checked) Then
            For Each row As GridViewRow In grdToBeOrder.Rows
                If row.RowType = DataControlRowType.DataRow Then
                    Dim chkRow As CheckBox = TryCast(row.Cells(0).FindControl("chkRow"), CheckBox)
                    If chkRow.Checked Then
                        If Status = "SAVE" Then
                            If ddlSupplier.SelectedValue <> "" Then
                                objBEPartsOrder.SupplierID = objFunction.ReturnInteger(ddlSupplier.SelectedValue)
                                If txtOrderDate.Text <> "" Then
                                    objBEPartsOrder.DateOrderCreated = DateTime.ParseExact(txtOrderDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                                Else
                                    objBEPartsOrder.DateOrderCreated = DateTime.Now
                                End If
                                objBEPartsOrder.OrderNumber = objFunction.ReturnInteger(txtOrderNo.Text)
                                objBEPartsOrder.DeliveryCost = "0"
                                Dim intAffectedRowPartOrderID As Integer = (New clsDLPartsOrder()).AddPartsOrderDetails(objBEPartsOrder)
                                If intAffectedRowPartOrderID > 0 Then
                                    Dim id As Integer = TryCast(row.Cells(2).FindControl("lblRequestId"), Label).Text
                                    objBERequestPart.RequestID = id
                                    objBERequestPart.PartsOrderID = intAffectedRowPartOrderID
                                    Session("NID") = intAffectedRowPartOrderID.ToString()
                                    Dim intAffectedRow As Integer = (New clsDLRequestParts()).UpdateRequestPartOrderId(objBERequestPart)
                                    If intAffectedRow > 0 Then
                                        objBEPONumber.NextNo = objFunction.ReturnInteger(txtOrderNo.Text) + 1
                                        Dim intAffectedRowUpdate As Integer = (New clsDLNextPONumber()).UpdateNextPONumber(objBEPONumber)
                                        If intAffectedRowUpdate > 0 Then
                                            flag = True
                                        End If
                                    End If
                                End If
                            Else

                                Dim javaScript As String = ""
                                javaScript += "<script type='text/javascript'>"
                                javaScript += "$(document).ready(function(){"
                                javaScript += "ShowPopupBlank('Please Choose Supplier Field.');"
                                javaScript += "});"
                                javaScript += "</script>"
                                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                            End If

                        Else
                                Dim id As Integer = TryCast(row.Cells(2).FindControl("lblRequestId"), Label).Text
                            objBERequestPart.RequestID = id
                            objBERequestPart.PartsOrderID = objFunction.ReturnInteger(Session("ID"))
                            Dim intAffectedRow As Integer = (New clsDLRequestParts()).UpdateRequestPartOrderId(objBERequestPart)
                            If intAffectedRow > 0 Then
                                flag = True
                            End If
                        End If




                    End If
                End If
            Next

            If (flag = True) Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Selected Parts Added To This Order Sucessfully.','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                FillGridToBeOrder()
            End If
        Else
            For Each row As GridViewRow In grdOrderedParts.Rows
                If row.RowType = DataControlRowType.DataRow Then
                    Dim chkRow As CheckBox = TryCast(row.Cells(0).FindControl("chkRow"), CheckBox)
                    If chkRow.Checked Then
                        Dim id As Integer = TryCast(row.Cells(2).FindControl("lblRequestId"), Label).Text
                        objBERequestPart.RequestID = id
                        Dim intAffectedRow As Integer = (New clsDLRequestParts()).PerformGridViewOpertaion("DELETE", objBERequestPart)
                        If intAffectedRow > 0 Then
                            flag = True
                        End If

                    End If
                End If
            Next

            If (flag = True) Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Requested Parts Order details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                FillGrid()

            End If
        End If

    End Sub
    Public Sub FillGridToBeOrder()
        Try
            Dim dstOrderList As New DataSet()
            dstOrderList = (New clsDLPartsOrder()).PartsToBeOrder()
            If objFunction.CheckDataSet(dstOrderList) Then
                grdToBeOrder.DataSource = dstOrderList
                grdToBeOrder.DataBind()
            Else
                grdToBeOrder.DataSource = Nothing
                grdToBeOrder.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
    Protected Sub flatradio1_CheckedChanged(sender As Object, e As EventArgs) Handles flatradio1.CheckedChanged
        grdOrderedParts.Visible = False
        grdToBeOrder.Visible = True
        FillGridToBeOrder()

    End Sub

    Protected Sub flatradio2_CheckedChanged(sender As Object, e As EventArgs) Handles flatradio2.CheckedChanged
        grdToBeOrder.Visible = False
        grdOrderedParts.Visible = True
        'Dim strPartOrderId = objFunction.ReturnString(Request.QueryString("ID"))
        Dim strPartOrderId = objFunction.ReturnString(Session("ID"))
        Try
            Dim dstList As New DataSet()
            objBEPartsOrder.PartsOrderID = strPartOrderId
            dstList = (New clsDLPartsOrder()).GetPartsOrderDetailsByID(objBEPartsOrder)
            If objFunction.CheckDataSet(dstList) Then
                txtOrderNo.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("OrderNumber"))
                FillGrid()
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim PartsOrderID = objFunction.ReturnString(Session("ID"))

        'Response.Redirect("Parts_order_Print.aspx?ID=" + PartsOrderID)
        Response.Write("<script>window.open ('Parts_order_Print.aspx?ID=" + PartsOrderID + "','_blank');</script>")

    End Sub

    Protected Sub grdOrderedParts_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdOrderedParts.SelectedIndexChanging
        Dim strRequestId As String = objFunction.ReturnString(grdOrderedParts.DataKeys(e.NewSelectedIndex).Value)
        Response.Redirect("Parts_Order_edit.aspx?ReqID=" + strRequestId)
    End Sub

End Class