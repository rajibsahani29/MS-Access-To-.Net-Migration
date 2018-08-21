Imports CRM.BE
Imports CRM.DL
Public Class Parts_Order_Price_Check
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEPartsPrice As clsBEPartPrices = New clsBEPartPrices
    Dim objBEPartsOrder As clsBEPartsOrder = New clsBEPartsOrder

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Session("ID")) = "" And Session("ID") Is Nothing Then
            Response.Redirect("Parts_Part_OrderList.aspx")
        End If
        If Not Page.IsPostBack Then
            Dim strPartOrderId = objFunction.ReturnString(Session("ID"))
            Try
                Dim dstList As New DataSet()
                objBEPartsOrder.PartsOrderID = strPartOrderId
                dstList = (New clsDLPartsOrder()).GetPartsOrderDetailsByID(objBEPartsOrder)
                If objFunction.CheckDataSet(dstList) Then
                    txtOrderNo.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("OrderNumber"))
                    txtsupplier.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("SupplierName"))
                    txtTotalCost.Text = objFunction.ReturnDouble(dstList.Tables(0).Rows(0)("DeliveryCost"))
                End If

                FillGrid()
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
        End If
    End Sub


    Public Sub FillGrid()
        Try
            Dim dstList As New DataSet()
            dstList = (New clsDLRequestParts()).GetPriceCheck()
            If objFunction.CheckDataSet(dstList) Then
                grdPriceCheck.DataSource = dstList
                grdPriceCheck.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub grdPriceCheck_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdPriceCheck.SelectedIndexChanging
        Try

            Dim intPartId = objFunction.ReturnInteger(grdPriceCheck.DataKeys(e.NewSelectedIndex).Value)
            hdnPartid.Value = intPartId.ToString()
            GetPriceDetailsByPartId(intPartId)
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub


    Protected Sub GetPriceDetailsByPartId(ByVal id As Integer)

        Try
            Dim dstPriceList As New DataSet()
            objBEPartsPrice.PartID = id
            dstPriceList = (New clsDLPartPrices()).GetPriceDetailsByPartID(objBEPartsPrice)
            If objFunction.CheckDataSet(dstPriceList) Then
                grdSupplier.DataSource = dstPriceList
                grdSupplier.DataBind()
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub

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

    Protected Sub grdSupplier_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdSupplier.RowEditing
        Try
            grdSupplier.EditIndex = e.NewEditIndex
            GetPriceDetailsByPartId(objFunction.ReturnInteger(hdnPartid.Value))

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdSupplier_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdSupplier.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdSupplier.DataKeys(e.RowIndex).Values("PartPriceID")))
            Dim txtprice As TextBox = DirectCast(grdSupplier.Rows(e.RowIndex).FindControl("txtprice"), TextBox)
            Dim notes As TextBox = DirectCast(grdSupplier.Rows(e.RowIndex).FindControl("txtnotes"), TextBox)
            Dim ddlSupplier As DropDownList = DirectCast(grdSupplier.Rows(e.RowIndex).FindControl("ddlSupplier"), DropDownList)
            objBEPartsPrice.Price = objFunction.ReturnDouble(txtprice.Text)
            objBEPartsPrice.Notes = notes.Text
            objBEPartsPrice.PartPriceID = id
            If (ddlSupplier.SelectedIndex = 0) Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopupBlank('Please Select Any Supplier Before Update.');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else
                objBEPartsPrice.SupplierID = ddlSupplier.SelectedItem.Value

                Dim intAffectedRow As Integer = (New clsDLPartPrices()).PerformGridViewOpertaion("UPDATE", objBEPartsPrice)
                If intAffectedRow > 0 Then
                    Dim javaScript As String = ""
                    javaScript += "<script type='text/javascript'>"
                    javaScript += "$(document).ready(function(){"
                    javaScript += "ShowPopup('Parts Order Price Have Been Updated','success');"
                    javaScript += "});"
                    javaScript += "</script>"
                    ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

                Else
                    Dim javaScript As String = ""
                    javaScript += "<script type='text/javascript'>"
                    javaScript += "$(document).ready(function(){"
                    javaScript += "ShowPopup('Can Not Updated At this Time.Try again After Sometime.','error');"
                    javaScript += "});"
                    javaScript += "</script>"
                    ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                End If
                grdSupplier.EditIndex = -1
                GetPriceDetailsByPartId(objFunction.ReturnInteger(hdnPartid.Value))
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdSupplier_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdSupplier.RowCancelingEdit
        Try
            grdSupplier.EditIndex = -1
            GetPriceDetailsByPartId(objFunction.ReturnInteger(hdnPartid.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdSupplier_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdSupplier.RowDataBound

        If (e.Row.RowType = DataControlRowType.DataRow AndAlso grdSupplier.EditIndex = e.Row.RowIndex) Then

            Dim dstsupplier As DataSet = (New clsDLSupplier()).GetSupplierFillInDD()
            'Find the DropDownList in the Row
            Dim ddlSupplier As DropDownList = CType(e.Row.FindControl("ddlSupplier"), DropDownList)
            ddlSupplier.DataSource = dstsupplier
            ddlSupplier.DataTextField = "Value"
            ddlSupplier.DataValueField = "Id"
            ddlSupplier.DataBind()
            'Add Default Item in the DropDownList
            ddlSupplier.Items.Insert(0, New ListItem("Select Supplier", ""))
            'Select the SupplierName in DropDownList
            Dim country As String = CType(e.Row.FindControl("lblsupplier"), Label).Text
            ddlSupplier.Items.FindByValue(country).Selected = True

        End If
    End Sub


End Class