Imports CRM.BE
Imports CRM.DL

Public Class Manufacturer_list
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEManufacture As clsBEManufacture = New clsBEManufacture

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            FillGrid()
        End If
    End Sub
    Public Sub FillGrid()
        Try
            Dim dstList As New DataSet()
            dstList = (New clsDLManufacturer()).GetManufactureDetails()
            If objFunction.CheckDataSet(dstList) Then
                grdManufacturer.DataSource = dstList
                grdManufacturer.DataBind()
            Else
                grdManufacturer.DataSource = Nothing
                grdManufacturer.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub grdManufacturer_OnRowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdManufacturer.RowDataBound
        Try
            If e.Row.RowType = DataControlRowType.DataRow Then
                Dim lb As LinkButton = DirectCast(e.Row.Cells(11).Controls(2), LinkButton)
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

    Protected Sub grdManufacturer_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdManufacturer.PageIndexChanging
        Try

            grdManufacturer.PageIndex = e.NewPageIndex
            FillGrid()

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdManufacturer_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdManufacturer.RowCancelingEdit
        Try
            grdManufacturer.EditIndex = -1
            FillGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdManufacturer_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdManufacturer.RowEditing
        Try
            grdManufacturer.EditIndex = e.NewEditIndex
            FillGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdManufacturer_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdManufacturer.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdManufacturer.DataKeys(e.RowIndex).Values("ManufacturerID")))
            objBEManufacture.ManufacturerID = id
            Dim intAffectedRow As Integer = (New clsDLManufacturer()).PerformGridViewOpertaion("DELETE", objBEManufacture)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Manufacturer details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else

            End If
            grdManufacturer.EditIndex = -1
            FillGrid()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdManufacturer_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdManufacturer.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdManufacturer.DataKeys(e.RowIndex).Values("ManufacturerID")))
            Dim txtname As TextBox = DirectCast(grdManufacturer.Rows(e.RowIndex).FindControl("txtname"), TextBox)
            Dim txtaddress1 As TextBox = DirectCast(grdManufacturer.Rows(e.RowIndex).FindControl("txtaddress1"), TextBox)
            Dim txtaddress2 As TextBox = DirectCast(grdManufacturer.Rows(e.RowIndex).FindControl("txtaddress2"), TextBox)
            Dim txtCity As TextBox = DirectCast(grdManufacturer.Rows(e.RowIndex).FindControl("txtCity"), TextBox)
            Dim txtPCode1 As TextBox = DirectCast(grdManufacturer.Rows(e.RowIndex).FindControl("txtPCode1"), TextBox)
            Dim txtPCode2 As TextBox = DirectCast(grdManufacturer.Rows(e.RowIndex).FindControl("txtPCode2"), TextBox)
            Dim txtPhoneNumber As TextBox = DirectCast(grdManufacturer.Rows(e.RowIndex).FindControl("txtPhoneNumber"), TextBox)
            Dim txtFAX As TextBox = DirectCast(grdManufacturer.Rows(e.RowIndex).FindControl("txtFAX"), TextBox)
            Dim txtMobile As TextBox = DirectCast(grdManufacturer.Rows(e.RowIndex).FindControl("txtMobile"), TextBox)
            Dim txtEmail As TextBox = DirectCast(grdManufacturer.Rows(e.RowIndex).FindControl("txtEmail"), TextBox)

            objBEManufacture.ManufacturerID = id
            objBEManufacture.ManufacturerName = txtname.Text
            objBEManufacture.Address1 = txtaddress1.Text
            objBEManufacture.Address2 = txtaddress2.Text
            objBEManufacture.City = txtCity.Text
            objBEManufacture.PCode1 = txtPCode1.Text
            objBEManufacture.PCode2 = txtPCode2.Text
            objBEManufacture.PhoneNumber = txtPhoneNumber.Text
            objBEManufacture.FAX = txtFAX.Text
            objBEManufacture.Mobile = txtMobile.Text
            objBEManufacture.Email = txtEmail.Text

            Dim intAffectedRow As Integer = (New clsDLManufacturer()).PerformGridViewOpertaion("UPDATE", objBEManufacture)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Manufacturer details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else

            End If

            grdManufacturer.EditIndex = -1
            FillGrid()

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try

            objBEManufacture.ManufacturerName = txtname.Text
            objBEManufacture.Address1 = txtaddress1.Text
            objBEManufacture.Address2 = txtaddress2.Text
            objBEManufacture.City = txtCity.Text
            objBEManufacture.PCode1 = txtpostcode1.Text
            objBEManufacture.PCode2 = txtpostcode2.Text
            objBEManufacture.PhoneNumber = txtPhone.Text
            objBEManufacture.FAX = txtfax.Text
            objBEManufacture.Mobile = txtmobile.Text
            objBEManufacture.Email = txtEmail.Text
            objBEManufacture.DelFlag = 0

            Dim intAffectedRow As Integer = (New clsDLManufacturer()).AddManufactureDetails(objBEManufacture)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('New Manufacturer Added Sucessfully','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                txtname.Text = ""
                txtaddress1.Text = ""
                txtaddress2.Text = ""
                txtCity.Text = ""
                txtEmail.Text = ""
                txtpostcode1.Text = ""
                txtpostcode2.Text = ""
                txtPhone.Text = ""
                txtfax.Text = ""
                txtmobile.Text = ""
                FillGrid()


            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub
End Class