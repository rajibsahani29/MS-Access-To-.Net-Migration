Imports CRM.BE
Imports CRM.DL
Public Class Parts_order_Print
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEPartsOrder As clsBEPartsOrder = New clsBEPartsOrder
    Dim objBESupplier As clsBESupplier = New clsBESupplier


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If objFunction.ReturnString(Request.QueryString("ID")) = "" Or objFunction.ReturnString(Request.QueryString("ID")) Is Nothing Then
            Response.Redirect("Parts_Order.aspx")
        End If

        If Not Page.IsPostBack Then
            Dim strPartOrderId = objFunction.ReturnString(Request.QueryString("ID"))
            Try
                Dim dstList As New DataSet()
                objBEPartsOrder.PartsOrderID = strPartOrderId
                dstList = (New clsDLPartsOrder()).GetPartsOrderDetailsByID(objBEPartsOrder)
                If objFunction.CheckDataSet(dstList) Then
                    txtPartno.Value = objFunction.ReturnString(dstList.Tables(0).Rows(0)("PartNo"))
                    hdnSupplierId.Value = objFunction.ReturnString(dstList.Tables(0).Rows(0)("SupplierID"))
                    txtnotes.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("OrderNotes"))
                    hdnOrderno.Value = objFunction.ReturnString(dstList.Tables(0).Rows(0)("OrderNumber"))
                    FillGrid()
                    FillSupplierDetails()
                End If

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
        End If

    End Sub
    Public Sub FillGrid()
        Try
            Dim dstOrderList As New DataSet()
            objBEPartsOrder.OrderNumber = hdnOrderno.Value
            dstOrderList = (New clsDLPartsOrder()).PartsOnOrder(objBEPartsOrder)
            If objFunction.CheckDataSet(dstOrderList) Then
                grdOrderedParts.DataSource = dstOrderList
                grdOrderedParts.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Public Sub FillSupplierDetails()
        Try
            Dim dstdetails As New DataSet()
            objBESupplier.SupplierID = hdnSupplierId.Value
            dstdetails = (New clsDLSupplier()).GetSupplierDetailsById(objBESupplier)
            If objFunction.CheckDataSet(dstdetails) Then
                txtsuppliername.Text = objFunction.ReturnString(dstdetails.Tables(0).Rows(0)("SupplierName"))
                txtaddress1.Text = objFunction.ReturnString(dstdetails.Tables(0).Rows(0)("address1"))
                txtaddress2.Text = objFunction.ReturnString(dstdetails.Tables(0).Rows(0)("Address2"))
                txttowncode.Text = objFunction.ReturnString(dstdetails.Tables(0).Rows(0)("Town") + "" + dstdetails.Tables(0).Rows(0)("postcode"))
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub
End Class