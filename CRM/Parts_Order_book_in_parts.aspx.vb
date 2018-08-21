Imports CRM.BE
Imports CRM.DL
Public Class Parts_Order_book_in_parts
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBERequestedPart As clsBERequestpart = New clsBERequestpart
    Dim objBEPartReceive As clsBEPartsReceived = New clsBEPartsReceived
    Dim objBEPartsOrder As clsBEPartsOrder = New clsBEPartsOrder

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Session("ID")) = "" And Session("ID") Is Nothing Then
            Response.Redirect("Parts_Part_OrderList.aspx")
        End If
        If Not Page.IsPostBack Then
            Dim intPartOrderId = objFunction.ReturnInteger(Session("ID"))
            Try
                Dim dstList As New DataSet()
                objBEPartsOrder.PartsOrderID = intPartOrderId
                dstList = (New clsDLPartsOrder()).GetPartsOrderDetailsByID(objBEPartsOrder)
                If objFunction.CheckDataSet(dstList) Then
                    txtOrderNo.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("OrderNumber"))
                    txtsupplier.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("SupplierName"))
                    txtTotalCost.Text = objFunction.ReturnDouble(dstList.Tables(0).Rows(0)("DeliveryCost"))
                End If
                FillBookinGrid()
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
            Dim intPartOrderId = objFunction.ReturnInteger(Session("ID"))
            objBERequestedPart.PartsOrderID = intPartOrderId
            dstList = (New clsDLRequestParts()).GetRequestedPartsReceived(objBERequestedPart)
            If objFunction.CheckDataSet(dstList) Then
                grdPartReceived.DataSource = dstList
                grdPartReceived.DataBind()
            Else
                grdPartReceived.DataSource = New List(Of String)
                grdPartReceived.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Public Sub FillBookinGrid()
        Try
            Dim dstList As New DataSet()
            Dim intPartOrderId = objFunction.ReturnInteger(Session("ID"))
            objBERequestedPart.PartsOrderID = intPartOrderId
            dstList = (New clsDLRequestParts()).GetRequestedPartstoBookIn(objBERequestedPart)
            If objFunction.CheckDataSet(dstList) Then
                grdPartsBook.DataSource = dstList
                grdPartsBook.DataBind()
            Else
                grdPartsBook.DataSource = New List(Of String)
                grdPartsBook.DataBind()
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

    Protected Sub grdPartReceived_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdPartReceived.RowDataBound
        Try
            If e.Row.RowType = DataControlRowType.DataRow Then
                Dim lb As LinkButton = DirectCast(e.Row.Cells(0).Controls(0), LinkButton)
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

    Protected Sub grdPartReceived_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdPartReceived.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdPartReceived.DataKeys(e.RowIndex).Values("PartRecievedID")))
            objBEPartReceive.PartRecievedID = id
            Dim intAffectedRow As Integer = (New clsDLPartsReceived()).DeletePartsReceiveDetailsByID(objBEPartReceive)

            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Part details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdPartReceived.EditIndex = -1
            FillGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub


    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (hdnRequestid.Value = "") Then
            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowPopupBlank('Sorry You Have Not Select Any Partnumber.');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        Else
            objBEPartReceive.RequestID = hdnRequestid.Value
            objBEPartReceive.DateRecieved = DateTime.Now
            objBEPartReceive.Quantity = txtqty.Text
            objBEPartReceive.DEL = 0
            If Len(txtnotes.Text) > 0 Then
                objBEPartReceive.Notes = txtnotes.Text
            Else
                'objBEPartReceive.Notes = "Booked in by:=  " + GetCurrentUserName() + "/" + GetComputerName()
            End If
            Dim intAffectedRow As Integer = (New clsDLPartsReceived()).AddPartsReceiveDetails(objBEPartReceive)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Selected Part Added Sucessfully','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                txtnotes.Text = ""
                txtqty.Text = 0
                FillGrid()
                FillBookinGrid()
            End If
        End If

    End Sub
    Protected Sub grdPartsBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grdPartsBook.SelectedIndexChanged
        txtqty.Text = grdPartsBook.SelectedRow.Cells(8).Text
        Dim intRequestId = objFunction.ReturnInteger(grdPartsBook.SelectedRow.Cells(1).Text)
        hdnRequestid.Value = intRequestId

    End Sub

End Class