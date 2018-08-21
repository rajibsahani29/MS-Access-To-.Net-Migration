Imports CRM.BE
Imports CRM.DL
Public Class Job_parts_order
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEParts As clsBEParts = New clsBEParts
    Dim objBEReqParts As clsBERequestpart = New clsBERequestpart
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Dim objBEPartsPrice As clsBEPartPrices = New clsBEPartPrices
    Dim objBEStock As clsBEStock = New clsBEStock



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If objFunction.ReturnString(Session("JID")) = "" And Session("JID") Is Nothing Then
            Response.Redirect("job_select.aspx")
        End If

        If Not Page.IsPostBack Then
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            GetOrderDetails(IntJobId)
            GetStockPartDetails(IntJobId)
            BindGrid()
            BindAllParts()
            BindPartsUsed()
            Dim dstPulldown As DataSet = (New clsDLPulldownIntegers()).GetPulldownIntegersFillInDD()
            objFunction.FillDropDownByDataSet(ddlqty, dstPulldown)
            ddlqty.Items.Insert(0, New ListItem("Qty", ""))
        End If
    End Sub
    Protected Sub GetOrderDetails(ByVal id As Integer)


        Try
            Dim dstJobList As New DataSet()
            objBEOrder.JOBID = id
            dstJobList = (New clsDLOrder()).GetJobDetailsByJobID(objBEOrder)
            If dstJobList IsNot Nothing Then
                txtCompany.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Name"))
                txtEngineer.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Engineer"))
                txtJobNumber.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("JobNumber"))
                txtStatus.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Status"))
            End If


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub

    Protected Sub GetStockPartDetails(ByVal id As Integer)

        Try
            Dim dstStockList As New DataSet()
            objBEStock.JOBID = id
            dstStockList = (New clsDLStock()).GetStockDetailsByJobID(objBEStock)
            grdStock.DataSource = dstStockList
            grdStock.DataBind()


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub

    Protected Sub BindAllParts()

        Try
            Dim strSearchByAppliance As String = (If(txtAppliance.Text <> "", txtAppliance.Text, ""))
            Dim strSearchByPart As String = (If(txtpart.Text <> "", txtpart.Text, ""))
            Dim strSearchByorder As String = (If(txtOrderNo.Text <> "", txtOrderNo.Text, ""))
            Dim dstParts As New DataSet()
            dstParts = (New clsDLParts()).GetPartsDetailBySearch(strSearchByAppliance, strSearchByPart, strSearchByorder)
            grdParts.DataSource = dstParts
            grdParts.DataBind()

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdParts_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdParts.SelectedIndexChanging
        Try

            Dim ID As Integer = objFunction.ReturnInteger(grdParts.DataKeys(e.NewSelectedIndex).Value)
            Dim dstPartsList As New DataSet()
            objBEParts.PartID = ID
            hdnPartId.Value = ID.ToString()
            dstPartsList = (New clsDLParts()).GetPartsDetailByID(objBEParts)
            If dstPartsList IsNot Nothing Then
                txtPartNo.Text = objFunction.ReturnString(dstPartsList.Tables(0).Rows(0)("PartNumber"))
                txtDescription.Text = objFunction.ReturnString(dstPartsList.Tables(0).Rows(0)("Description"))
                txtMenuList.Text = objFunction.ReturnDouble(dstPartsList.Tables(0).Rows(0)("ManufacturersListPrice"))
                txtxFFsellPrice.Text = objFunction.ReturnDouble(dstPartsList.Tables(0).Rows(0)("FastFixxSellingPrice"))
                txtSellingPriceDate.Text = Convert.ToDateTime(dstPartsList.Tables(0).Rows(0)("SellingPriceDate"))
                txtFFSellPrice.Text = objFunction.ReturnDouble(dstPartsList.Tables(0).Rows(0)("FastFixxSellingPrice"))

            End If
            GetPriceDetailsByPartId(ID)
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
    Protected Sub GetPriceDetailsByPartId(ByVal id As Integer)


        Try
            Dim dstPriceList As New DataSet()
            objBEPartsPrice.PartID = id
            dstPriceList = (New clsDLPartPrices()).GetPriceDetailsByPartID(objBEPartsPrice)
            If objFunction.CheckDataSet(dstPriceList) Then
                grdPartsPrice.DataSource = dstPriceList
                grdPartsPrice.DataBind()

            End If


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        BindAllParts()
    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            objBEReqParts.JOBID = IntJobId
            objBEReqParts.Quantity = objFunction.ReturnInteger(ddlqty.Text)
            objBEReqParts.PartID = objFunction.ReturnInteger(hdnPartId.Value)
            objBEReqParts.SystemDatex = DateTime.Now
            objBEReqParts.EngineersNos = txtEngiRef.Text
            objBEReqParts.PartsOrderID = 0
            objBEReqParts.deletex = 0
            Dim intAffectedRow As Integer = (New clsDLRequestParts()).AddRequestedPartOnPartOrder(objBEReqParts)
            If intAffectedRow > 0 Then
                Dim str As String = objFunction.ReturnString(Session("JID"))
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Parts Added To This JobID " + str + "','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                BindGrid()
                'Have to update LocOrder Table qty, rec, await
                BindPartsUsed()
                ddlqty.SelectedItem.Value = ""
                ddlqty.Text = ""
                hdnPartId.Value = ""
                txtEngiRef.Text = ""

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

    Protected Sub grdParts_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdParts.PageIndexChanging
        Try

            grdParts.PageIndex = e.NewPageIndex
            BindAllParts()

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAppliance.Text = ""
        txtpart.Text = ""
        txtOrderNo.Text = ""
    End Sub


    Protected Sub BindGrid()

        Try
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            Dim dstOrderedParts As New DataSet()
            objBEReqParts.JOBID = IntJobId
            dstOrderedParts = (New clsDLRequestParts()).GetRequestedPartsOrderByJobID(objBEReqParts)
            grdOrder.DataSource = dstOrderedParts
            grdOrder.DataBind()
            Dim dblTotalqty As Integer = 0
            For i = 0 To dstOrderedParts.Tables(0).Rows.Count - 1
                dblTotalqty += objFunction.ReturnDouble(dstOrderedParts.Tables(0).Rows(i)("Qty"))
            Next
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub BindPartsUsed()

        Try
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            Dim dstUsedParts As New DataSet()
            objBEReqParts.JOBID = IntJobId
            dstUsedParts = (New clsDLRequestParts()).GetRequestedPartsUsedByJobID(objBEReqParts)
            If objFunction.CheckDataSet(dstUsedParts) Then
                grdUsed.DataSource = dstUsedParts
                grdUsed.DataBind()
                Dim dblTotalCostVal As Double = 0
                For i = 0 To dstUsedParts.Tables(0).Rows.Count - 1
                    dblTotalCostVal += objFunction.ReturnDouble(dstUsedParts.Tables(0).Rows(i)("TotalCost"))
                Next
                txttotalpriceBYFF.Text = dblTotalCostVal.ToString()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub grdOrder_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdOrder.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdOrder.DataKeys(e.RowIndex).Values("RequestID")))
            objBEReqParts.RequestID = id
            Dim intAffectedRow As Integer = (New clsDLRequestParts()).PerformGridViewOpertaion("DELETE", objBEReqParts)
            If intAffectedRow > 0 Then
                'Dim javaScript As String = ""
                'javaScript += "<script type='text/javascript'>"
                'javaScript += "$(document).ready(function(){"
                'javaScript += "ShowPopup('Requested Parts Order details have been Deleted','success');"
                'javaScript += "});"
                'javaScript += "</script>"
                'ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "Script1", "ShowPopup('Requested Parts Order details have been Deleted','success');", True)

            Else

            End If

            grdOrder.EditIndex = -1
            BindGrid()
            BindPartsUsed()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdOrder_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdOrder.RowEditing
        Try
            grdOrder.EditIndex = e.NewEditIndex
            BindGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdOrder_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdOrder.RowCancelingEdit
        Try
            grdOrder.EditIndex = -1
            BindGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdOrder_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdOrder.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdOrder.DataKeys(e.RowIndex).Values("RequestID")))
            Dim notes As TextBox = DirectCast(grdOrder.Rows(e.RowIndex).FindControl("txtNotes"), TextBox)
            Dim qty As TextBox = DirectCast(grdOrder.Rows(e.RowIndex).FindControl("txtqty"), TextBox)
            Dim txtengref As TextBox = DirectCast(grdOrder.Rows(e.RowIndex).FindControl("txtengineers"), TextBox)
            objBEReqParts.Notes = notes.Text
            objBEReqParts.Quantity = objFunction.ReturnString(qty.Text)
            objBEReqParts.EngineersNos = txtengref.Text
            objBEReqParts.RequestID = id
            Dim intAffectedRow As Integer = (New clsDLRequestParts()).PerformGridViewOpertaion("UPDATE", objBEReqParts)
            If intAffectedRow > 0 Then
                'Dim javaScript As String = ""
                'javaScript += "<script type='text/javascript'>"
                'javaScript += "$(document).ready(function(){"
                'javaScript += "ShowPopup('Parts Order details have been updated','success');"
                'javaScript += "});"
                'javaScript += "</script>"
                'ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "Script1", "ShowPopup('Parts Order details have been updated','success');", True)
            Else

            End If
            grdOrder.EditIndex = -1
            BindGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdOrder_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdOrder.RowDataBound
        Try
            If e.Row.RowType = DataControlRowType.DataRow Then
                Dim lb As LinkButton = DirectCast(e.Row.Cells(11).Controls(2), LinkButton)

                If lb IsNot Nothing Then
                    If lb.Text = "Delete" Then
                        'lb.Attributes.Add("onclick", "javascript:return ShowDeletePopup(this, 'Record will be Permanently Deleted')")
                        lb.Attributes.Add("onclick", "javascript:return ShowDeletePopupUpdatePanel(this, 'Record will be Permanently Deleted')")

                    End If
                End If
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
End Class