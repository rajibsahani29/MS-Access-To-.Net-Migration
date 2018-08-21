Imports CRM.BE
Imports CRM.DL
Imports System.Net

Public Class Parts_Order_edit
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBERequestpart As clsBERequestpart = New clsBERequestpart
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Dim objBENotes As clsBENotes = New clsBENotes
    Dim objBEJobVisit As clsBEJobVisit = New clsBEJobVisit

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Request.QueryString("ReqID")) = "" Or objFunction.ReturnString(Request.QueryString("ReqID")) Is Nothing Then
            Response.Redirect("Parts_order.aspx")
        End If
        hdnStatus.Value = "home"
        If Not Page.IsPostBack Then
            Dim intRequestID = objFunction.ReturnInteger(Request.QueryString("ReqID"))
            Try
                Dim dstList As New DataSet()
                objBERequestpart.RequestID = intRequestID
                dstList = (New clsDLRequestParts()).PartDetailsByRequestID(objBERequestpart)
                If objFunction.CheckDataSet(dstList) Then
                    txtPartNo.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("PartNumber"))
                    txtDescription.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Description"))
                    txtManufactureName.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("ManufacturerName"))
                    txtModel.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Model"))
                    txtSerialNo.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("SerialNumber"))
                    txtApplianceType.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("ApplianceType"))
                    txtengineers.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("EngineersNos"))
                    txtqty.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Quantity"))
                    txtNotes.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Notes"))
                    txtCostExvat.Text = objFunction.ReturnFloatingValue(dstList.Tables(0).Rows(0)("Cost"))
                    hdnJobid.Value = objFunction.ReturnString(dstList.Tables(0).Rows(0)("JobId"))
                    FillJobDetails()
                    BindGridview()
                    BindJobAllocationGrid()
                End If

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
        End If
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        hdnStatus.Value = "home"
        Try
            Dim intRequestID = objFunction.ReturnInteger(Request.QueryString("ReqID"))
            objBERequestpart.Notes = objFunction.ReturnString(txtNotes.Text)
            objBERequestpart.Quantity = objFunction.ReturnInteger(txtqty.Text)
            objBERequestpart.cost = objFunction.ReturnFloatingValue(txtCostExvat.Text)
            objBERequestpart.RequestID = intRequestID
            Dim intAffectedRow As Integer = (New clsDLRequestParts()).UpdateRequestPartsForPartOrder(objBERequestpart)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Parts Order details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else

            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Public Sub FillJobDetails()
        Try
            Dim dstList As New DataSet()
            objBEOrder.JOBID = objFunction.ReturnInteger(hdnJobid.Value)
            dstList = (New clsDLOrder()).GetJobDetailsPartOrder(objBEOrder)
            If objFunction.CheckDataSet(dstList) Then
                txtffnumber.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Jobnumber"))
                txtStreet.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Street"))
                txtTown.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Town"))
                txtEng.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Engineer"))
                txtengineer.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Engineer"))
                txtCompName.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Name"))
                txtAddr1.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("address1"))
                txtPermPostCode.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("code"))
                txtAppliance.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Appliance"))
                txtModelOfAppliance.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Model"))
                txtFault.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Fault"))
                txtPermission.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Premises"))
                txtsheetdate.Text = Convert.ToDateTime(dstList.Tables(0).Rows(0)("SheetDate"))
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        hdnStatus.Value = "messages"
        Dim client As IPHostEntry
        client = Dns.GetHostEntry(HttpContext.Current.Request.ServerVariables.Item("REMOTE_HOST"))
        Try
            objBENotes.JOBID = objFunction.ReturnInteger(hdnJobid.Value)
            objBENotes.Notes = txtNote.Text
            objBENotes.NoteDate = DateTime.Now
            objBENotes.RecordedByPC = client.HostName.ToUpper()
            objBENotes.RecordedByUser = Session("LoginUserFirstName").ToString()
            Dim intAccomRoomTypeId As Integer = (New clsDLNotes()).AddJobNotesDetails(objBENotes)
            If intAccomRoomTypeId > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Job Notes Has Been Added','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                txtNote.Text = ""
                BindGridview()

            Else
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Not Saved This Time','error');"
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
    Protected Sub BindGridview()

        Try
            Dim intJobId = objFunction.ReturnInteger(hdnJobid.Value)
            Dim dstJobNotes As New DataSet()
            objBENotes.JOBID = intJobId
            objBENotes.NoteDate = DateTime.Now
            dstJobNotes = (New clsDLNotes()).GetJobNotesDetails(objBENotes)
            grdNotes.DataSource = dstJobNotes
            grdNotes.DataBind()
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

    Protected Sub grdNotes_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdNotes.RowEditing
        hdnStatus.Value = "messages"
        Try
            grdNotes.EditIndex = e.NewEditIndex
            BindGridview()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdNotes_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdNotes.RowUpdating
        hdnStatus.Value = "messages"
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdNotes.DataKeys(e.RowIndex).Values("JobNotesID")))
            Dim notes As TextBox = DirectCast(grdNotes.Rows(e.RowIndex).FindControl("txtnotes"), TextBox)
            objBENotes.Notes = notes.Text
            objBENotes.JobNotesID = id
            Dim intAffectedRow As Integer = (New clsDLNotes()).PerformGridViewOpertaion("UPDATE", objBENotes)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Job Note Has been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdNotes.EditIndex = -1
            BindGridview()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdNotes_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdNotes.RowCancelingEdit
        hdnStatus.Value = "messages"
        Try
            grdNotes.EditIndex = -1
            BindGridview()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub BindJobAllocationGrid()

        Try
            Dim intJobId = objFunction.ReturnInteger(hdnJobid.Value)
            Dim dstJobAllocation As New DataSet()
            objBEJobVisit.Jobid = intJobId
            dstJobAllocation = (New clsDLJobVisit()).GetJobAllocationByJobID(objBEJobVisit)
            grdallocation.DataSource = dstJobAllocation
            grdallocation.DataBind()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub btnUpdateJob_Click(sender As Object, e As EventArgs) Handles btnUpdateJob.Click
        hdnStatus.Value = "profile"
        objBEOrder.Appliance = txtAppliance.Text
        objBEOrder.Fault = txtFault.Text
        objBEOrder.ModelofAppliance = txtModelOfAppliance.Text
        objBEOrder.JOBID = objFunction.ReturnInteger(hdnJobid.Value)
        Dim intAffectedRow As Integer = (New clsDLOrder()).UpdateJobDetailsPartOrder(objBEOrder)
        If intAffectedRow > 0 Then
            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowPopup('Job Details Has Been Updated','success');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        End If
    End Sub
End Class