Imports CRM.BE
Imports CRM.DL

Public Class Manufacturer_Setting
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEAppliance As clsBEAppliances = New clsBEAppliances
    Dim objBELocation As clsBELocation = New clsBELocation
    Dim objBEApplianceType As clsBEApplianceType = New clsBEApplianceType


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hdnStatus.Value = "home"
        If Not Page.IsPostBack Then
            FillGrid()
            FillGridLocation()
            FillGridApplianceType()
        End If
    End Sub

    Protected Sub FillGridApplianceType()

        Try
            Dim dstAppType As New DataSet()
            dstAppType = (New clsDLApplianceType()).GetApplianceTypeFillInDD()
            If objFunction.CheckDataSet(dstAppType) Then
                grdAppliance.DataSource = dstAppType
                grdAppliance.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub FillGridLocation()

        Try
            Dim dstLocation As New DataSet()
            dstLocation = (New clsDLLocation()).GetLocationDetails()
            If objFunction.CheckDataSet(dstLocation) Then
                grdLocation.DataSource = dstLocation
                grdLocation.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAppliance.Text = ""
        txtModel.Text = ""
        txtManufacture.Text = ""
    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FillGrid()
    End Sub
    Protected Sub FillGrid()

        Try
            Dim strSearchByAppliance As String = (If(txtAppliance.Text <> "", txtAppliance.Text, ""))
            Dim strSearchByModel As String = (If(txtModel.Text <> "", txtModel.Text, ""))
            Dim strSearchByManufacturer As String = (If(txtManufacture.Text <> "", txtManufacture.Text, ""))
            Dim dstAppliance As New DataSet()
            dstAppliance = (New clsDLAppliances()).GetApplianceDetailsBySearch(strSearchByManufacturer, strSearchByAppliance, strSearchByModel)
            If objFunction.CheckDataSet(dstAppliance) Then
                grdParts.DataSource = dstAppliance
                grdParts.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdParts_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdParts.PageIndexChanging
        Try
            grdParts.PageIndex = e.NewPageIndex
            FillGrid()

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdParts_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdParts.RowEditing
        Try
            grdParts.EditIndex = e.NewEditIndex
            FillGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdParts_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdParts.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdParts.DataKeys(e.RowIndex).Values("ApplianceID")))
            objBEAppliance.ApplianceID = id
            Dim intAffectedRow As Integer = (New clsDLAppliances()).PerformGridViewOpertaion("DELETE", objBEAppliance)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Appliance details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else

            End If
            grdParts.EditIndex = -1
            FillGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdParts_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdParts.RowCancelingEdit
        Try
            grdParts.EditIndex = -1
            FillGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdParts_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdParts.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdParts.DataKeys(e.RowIndex).Values("ApplianceID")))
            Dim ddlManufacturer As DropDownList = DirectCast(grdParts.Rows(e.RowIndex).FindControl("ddlManufacturer"), DropDownList)
            Dim ddlAppliance As DropDownList = DirectCast(grdParts.Rows(e.RowIndex).FindControl("ddlAppliance"), DropDownList)
            Dim txtModel As TextBox = DirectCast(grdParts.Rows(e.RowIndex).FindControl("txtModel"), TextBox)
            If (ddlManufacturer.SelectedIndex = 0) Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopupBlank('Please Select Any Manufacturer Before Update.');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            ElseIf (ddlAppliance.SelectedIndex = 0) Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopupBlank('Please Select Any Manufacturer Before Update.');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else
                objBEAppliance.ApplianceID = id
                objBEAppliance.ManufacturerID = ddlManufacturer.SelectedItem.Value
                objBEAppliance.ApplianceTypeID = ddlAppliance.SelectedItem.Value
                objBEAppliance.Model = txtModel.Text
                Dim intAffectedRow As Integer = (New clsDLAppliances()).PerformGridViewOpertaion("UPDATE", objBEAppliance)
                If intAffectedRow > 0 Then
                    Dim javaScript As String = ""
                    javaScript += "<script type='text/javascript'>"
                    javaScript += "$(document).ready(function(){"
                    javaScript += "ShowPopup('Appliance details have been updated','success');"
                    javaScript += "});"
                    javaScript += "</script>"
                    ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                Else

                End If

                grdParts.EditIndex = -1
                FillGrid()
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdParts_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdParts.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim lb As LinkButton = DirectCast(e.Row.Cells(5).Controls(2), LinkButton)
            If lb IsNot Nothing Then
                If lb.Text = "Delete" Then
                    lb.Attributes.Add("onclick", "javascript:return ShowDeletePopup(this, 'Record will be Permanently Deleted')")
                End If
            End If
        End If
        If (e.Row.RowType = DataControlRowType.DataRow AndAlso grdParts.EditIndex = e.Row.RowIndex) Then

            Dim dstmanufacturer As DataSet = (New clsDLManufacturer()).GetManufactureFillInDD()
            'Find the DropDownList in the Row
            Dim ddlManufacturer As DropDownList = CType(e.Row.FindControl("ddlManufacturer"), DropDownList)
            ddlManufacturer.DataSource = dstmanufacturer
            ddlManufacturer.DataTextField = "Value"
            ddlManufacturer.DataValueField = "Id"
            ddlManufacturer.DataBind()
            'Add Default Item in the DropDownList
            ddlManufacturer.Items.Insert(0, New ListItem("Select Manufacturer", ""))
            'Select the SupplierName in DropDownList
            Dim manufacture As String = CType(e.Row.FindControl("txtMId"), TextBox).Text
            ddlManufacturer.Items.FindByValue(manufacture).Selected = True



            Dim dstApplianceType As DataSet = (New clsDLApplianceType()).GetApplianceTypeFillInDD()
            'Find the DropDownList in the Row
            Dim ddlAppliance As DropDownList = CType(e.Row.FindControl("ddlAppliance"), DropDownList)
            ddlAppliance.DataSource = dstApplianceType
            ddlAppliance.DataTextField = "Value"
            ddlAppliance.DataValueField = "Id"
            ddlAppliance.DataBind()
            'Add Default Item in the DropDownList
            ddlAppliance.Items.Insert(0, New ListItem("Select Appliance", ""))
            'Select the SupplierName in DropDownList
            Dim ApplianceType As String = CType(e.Row.FindControl("txtAppType"), TextBox).Text
            ddlAppliance.Items.FindByValue(ApplianceType).Selected = True

        End If
    End Sub

    Protected Sub grdLocation_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdLocation.RowEditing
        hdnStatus.Value = "profile"
        Try
            grdLocation.EditIndex = e.NewEditIndex
            FillGridLocation()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdLocation_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdLocation.RowDeleting
        hdnStatus.Value = "profile"
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdLocation.DataKeys(e.RowIndex).Values("LocationID")))
            objBELocation.LocationID = id
            Dim intAffectedRow As Integer = (New clsDLLocation()).PerformGridViewOpertaion("DELETE", objBELocation)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Location details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else

            End If
            grdLocation.EditIndex = -1
            FillGridLocation()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdLocation_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdLocation.RowCancelingEdit
        hdnStatus.Value = "profile"
        Try
            grdLocation.EditIndex = -1
            FillGridLocation()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdLocation_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdLocation.RowUpdating
        hdnStatus.Value = "profile"
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdLocation.DataKeys(e.RowIndex).Values("LocationID")))
            Dim ddlLocType As DropDownList = DirectCast(grdLocation.Rows(e.RowIndex).FindControl("ddlLocType"), DropDownList)
            Dim txtLocation As TextBox = DirectCast(grdLocation.Rows(e.RowIndex).FindControl("txtLocation"), TextBox)
            Dim txtNotes As TextBox = DirectCast(grdLocation.Rows(e.RowIndex).FindControl("txtNotes"), TextBox)
            objBELocation.LocationID = id
            objBELocation.LocationType = ddlLocType.SelectedItem.Value
            objBELocation.Location = txtLocation.Text
            objBELocation.Notes = txtNotes.Text
            Dim intAffectedRow As Integer = (New clsDLLocation()).PerformGridViewOpertaion("UPDATE", objBELocation)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Location details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            End If
            grdLocation.EditIndex = -1
            FillGridLocation()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdLocation_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdLocation.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim lb As LinkButton = DirectCast(e.Row.Cells(4).Controls(2), LinkButton)
            If lb IsNot Nothing Then
                If lb.Text = "Delete" Then
                    lb.Attributes.Add("onclick", "javascript:return ShowDeletePopup(this, 'Record will be Permanently Deleted')")
                End If
            End If
        End If
    End Sub

    Protected Sub grdLocation_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdLocation.PageIndexChanging
        hdnStatus.Value = "profile"
        Try
            grdLocation.PageIndex = e.NewPageIndex
            FillGridLocation()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdAppliance.RowEditing
        hdnStatus.Value = "home"
        Try
            grdAppliance.EditIndex = e.NewEditIndex
            FillGridApplianceType()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdAppliance.RowCancelingEdit
        hdnStatus.Value = "home"
        Try
            grdAppliance.EditIndex = -1
            FillGridApplianceType()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdAppliance.RowUpdating
        hdnStatus.Value = "home"
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdAppliance.DataKeys(e.RowIndex).Values("Id")))
            Dim txtAppType As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtAppType"), TextBox)
            objBEApplianceType.ApplianceTypeID = id
            objBEApplianceType.ApplianceType = txtAppType.Text
            Dim intAffectedRow As Integer = (New clsDLApplianceType()).PerformGridViewOpertaion("UPDATE", objBEApplianceType)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Appliance Type details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            End If
            grdAppliance.EditIndex = -1
            FillGridApplianceType()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdAppliance.RowDeleting
        hdnStatus.Value = "home"
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdAppliance.DataKeys(e.RowIndex).Values("Id")))
            objBEApplianceType.ApplianceTypeID = id
            Dim intAffectedRow As Integer = (New clsDLApplianceType()).PerformGridViewOpertaion("DELETE", objBEApplianceType)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Appliance Type details have been deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            End If
            grdAppliance.EditIndex = -1
            FillGridApplianceType()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdAppliance.PageIndexChanging
        Try
            grdAppliance.PageIndex = e.NewPageIndex
            FillGridApplianceType()

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdAppliance.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim lb As LinkButton = DirectCast(e.Row.Cells(2).Controls(2), LinkButton)
            If lb IsNot Nothing Then
                If lb.Text = "Delete" Then
                    lb.Attributes.Add("onclick", "javascript:return ShowDeletePopup(this, 'Record will be Permanently Deleted')")
                End If
            End If
        End If
    End Sub
End Class