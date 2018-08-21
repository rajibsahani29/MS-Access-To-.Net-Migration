Imports System.Globalization
Imports CRM.BE
Imports CRM.DL
Public Class job_allocation
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Dim objBEPulldown As clsBEPulldown = New clsBEPulldown
    Dim objBEJobVisit As clsBEJobVisit = New clsBEJobVisit
    Dim objDLJobvisit As clsDLJobVisit = New clsDLJobVisit
    Dim objBElocOrder As clsBElocOrder = New clsBElocOrder
    Dim objBEInvoice As clsBEInvoice = New clsBEInvoice
    Dim dt As DateTime



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If objFunction.ReturnString(Session("JID")) = "" And Session("JID") Is Nothing Then
            Response.Redirect("job_select.aspx")
        End If

        If Not Page.IsPostBack Then
            txtAllocated.Text = DateTime.Now.ToString("dd/MM/yyyy")
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            GetOrderDetails(IntJobId)
            objBEPulldown.Group = "Engineer"
            Dim dstEngineer As DataSet = (New ClsDLPulldown()).GetPulldownEngineerFillInDD(objBEPulldown)
            objFunction.FillDropDownByDataSet(ddlEngineer, dstEngineer)
            ddlEngineer.Items.Insert(0, New ListItem("Select Engineer", ""))
            BindGridview1()
            BindGridview()
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
                BindVat()
                txtVat.Text = String.Format("{0:n2}", (objFunction.ReturnDouble(txtExvat.Text) * objFunction.ReturnDouble(dstJobList.Tables(0).Rows(0)("VatRate")))).ToString()
                txtOrderTotal.Text = (objFunction.ReturnDouble(txtExvat.Text) + objFunction.ReturnDouble(txtVat.Text)).ToString()
            End If


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub
    Protected Sub BindVat()

        Try
            Dim IntJobId = objFunction.ReturnInteger(Session("JID"))
            Dim dstJobCost As New DataSet()
            objBEInvoice.JOBID = IntJobId
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
    Protected Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        If (txtAllocated.Text = "" Or ddlstatus.SelectedItem.Value = "Select" Or ddlEngineer.SelectedItem.Value = "") Then

            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowPopupBlank('Fill All the Details First.');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        Else
            Try

                objBEJobVisit.Jobid = objFunction.ReturnInteger(Session("JID"))
                If (txtEngineer.Text <> "") Then
                    objBEJobVisit.EngineerFrom = txtEngineer.Text
                Else
                    objBEJobVisit.EngineerFrom = "<First Issue>"
                End If
                objBEJobVisit.EngineerTo = ddlEngineer.SelectedItem.Text
                objBEJobVisit.IssueType = ddlstatus.Text
                dt = DateTime.ParseExact(txtAllocated.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                objBEJobVisit.IssueDate = dt
                'objBEJobVisit.HoursSpent =
                If (txtIssueNote.Text <> "") Then
                    objBEJobVisit.IssueNotes = txtIssueNote.Text
                Else
                    objBEJobVisit.IssueNotes = "Added by=" & objFunction.ReturnString(Session("LoginUserFirstName"))
                End If

                Dim intVisitHistoryId As Integer = objDLJobvisit.AddVisitHistory(objBEJobVisit)
                If intVisitHistoryId > 0 Then
                    objBEOrder.Engineer = ddlEngineer.SelectedItem.Text
                    objBEOrder.JOBID = objFunction.ReturnInteger(Session("JID"))
                    objBEOrder.Status = "Job Allocated"
                    If (txtAllocated.Text <> "") Then
                        'objBEOrder.AllocatedDate = txtAllocated.Text
                        'objBEOrder.SheetDate = txtAllocated.Text
                        objBEOrder.AllocatedDate = dt
                        objBEOrder.SheetDate = dt

                    Else
                        objBEOrder.SheetDate = DateTime.Now.ToShortDateString()
                        objBEOrder.AllocatedDate = DateTime.Now.ToShortDateString()

                    End If
                    Dim intAffectedRow As Integer = (New clsDLOrder()).UpdateOrderDetailsByJobAllocation(objBEOrder)
                    If intAffectedRow > 0 Then
                        objBElocOrder.Engineer = ddlEngineer.SelectedItem.Text
                        objBElocOrder.JOBID = objFunction.ReturnInteger(Session("JID"))
                        objBElocOrder.Status = "Job Allocated"
                        If (txtAllocated.Text <> "") Then
                            objBElocOrder.SheetDate = Convert.ToDateTime(dt)
                        Else
                            objBElocOrder.SheetDate = DateTime.Now.ToShortDateString()
                        End If
                        Dim intAffectedRowlocOrder As Integer = (New clsDLlocOrder()).UpdatelocOrderDetailsByJobAllocation(objBElocOrder)
                        If intAffectedRowlocOrder > 0 Then
                            Dim MaxSortOrder As Integer
                            objBEOrder.Engineer = ddlEngineer.SelectedItem.Text
                            'objBEOrder.SheetDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                            objBEOrder.SheetDate = Convert.ToDateTime(dt)
                            Dim intMaxid As Integer = (New clsDLOrder()).GetSortOrderByEngineer(objBEOrder)
                            If (intMaxid > 0) Then
                                MaxSortOrder = intMaxid + 1
                            Else
                                MaxSortOrder = 1
                            End If
                            objBEOrder.JOBID = objFunction.ReturnInteger(Session("JID"))
                            objBEOrder.SortOrder = MaxSortOrder
                            Dim intAffectedRowSortOrder As Integer = (New clsDLOrder()).UpdateSortOrderByEngineer(objBEOrder)
                            If intAffectedRowSortOrder > 0 Then
                                Dim str As String = ddlEngineer.SelectedItem.Text
                                Dim javaScript As String = ""
                                javaScript += "<script type='text/javascript'>"
                                javaScript += "$(document).ready(function(){"
                                javaScript += "ShowPopup('Job has been allocated to " + str + "','success');"
                                javaScript += "});"
                                javaScript += "</script>"
                                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                                BindGridview()
                                BindGridview1()

                            Else
                                Dim javaScript As String = ""
                                javaScript += "<script type='text/javascript'>"
                                javaScript += "$(document).ready(function(){"
                                javaScript += "ShowPopup('Not Saved This Time.May be You Are Choosing Back Date.','error');"
                                javaScript += "});"
                                javaScript += "</script>"
                                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                            End If
                        End If
                    End If


                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

            End Try

        End If

    End Sub

    Protected Sub BindGridview()

        Try
            Dim intJobId = objFunction.ReturnInteger(Session("JID"))
            Dim dstJobAllocation As New DataSet()
            objBEJobVisit.Jobid = intJobId
            dstJobAllocation = (New clsDLJobVisit()).GetJobAllocationByJobID(objBEJobVisit)
            GridView1.DataSource = dstJobAllocation
            GridView1.DataBind()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub

    Protected Sub BindGridview1()

        Try
            Dim dstJobList As New DataSet()
            objBEOrder.SheetDate = DateTime.Now.ToShortDateString()
            dstJobList = (New clsDLOrder()).GetJobAllocationToday(objBEOrder)
            GridView2.DataSource = dstJobList
            GridView2.DataBind()
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



    Protected Sub GridView1_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles GridView1.RowDeleting

        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(GridView1.DataKeys(e.RowIndex).Values("VisitHistoryID")))
            objBEJobVisit.VisitHistoryID = id
            Dim intAffectedRow As Integer = objDLJobvisit.PerformGridViewOpertaion("DELETE", objBEJobVisit)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Job Allocation details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                'ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "scriptKey", "ShowPopup('Job Allocation details have been Deleted','success');", True)

            Else

            End If
            GridView1.EditIndex = -1
            BindGridview()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub

    Protected Sub GridView1_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles GridView1.RowCancelingEdit
        Try
            GridView1.EditIndex = -1
            BindGridview()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub GridView1_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles GridView1.RowEditing
        Try
            GridView1.EditIndex = e.NewEditIndex
            BindGridview()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub GridView1_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles GridView1.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(GridView1.DataKeys(e.RowIndex).Values("VisitHistoryID")))
            Dim txtHrs As TextBox = DirectCast(GridView1.Rows(e.RowIndex).FindControl("txthrs"), TextBox)
            Dim notes As TextBox = DirectCast(GridView1.Rows(e.RowIndex).FindControl("txtnotes"), TextBox)
            Dim IssueType As DropDownList = DirectCast(GridView1.Rows(e.RowIndex).FindControl("ddlIssueType"), DropDownList)
            Dim txtdate As TextBox = DirectCast(GridView1.Rows(e.RowIndex).FindControl("txtdate"), TextBox)
            Dim Pdate As Label = DirectCast(GridView1.Rows(e.RowIndex).FindControl("LABEL_PIssueDate"), Label)
            objBEJobVisit.HoursSpent = objFunction.ReturnDouble(txtHrs.Text)
            objBEJobVisit.IssueNotes = notes.Text
            objBEJobVisit.IssueType = IssueType.SelectedItem.Text
            If (txtdate.Text = Pdate.Text) Then
                objBEJobVisit.IssueDate = DateTime.ParseExact(txtdate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
            Else
                objBEJobVisit.IssueDate = DateTime.ParseExact(txtdate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
            End If

            objBEJobVisit.VisitHistoryID = id
            Dim intAffectedRow As Integer = objDLJobvisit.PerformGridViewOpertaion("UPDATE", objBEJobVisit)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Job Allocation details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                'ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "scriptKey", "ShowPopup('Job Allocation details have been updated','success');", True)

            Else

            End If
            GridView1.EditIndex = -1
            BindGridview()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub



    Protected Sub GridView1_OnRowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs) Handles GridView1.RowDataBound

        Try
            If e.Row.RowType = DataControlRowType.DataRow Then
                Dim lb As LinkButton = DirectCast(e.Row.Cells(7).Controls(2), LinkButton)

                If lb IsNot Nothing Then
                    If lb.Text = "Delete" Then
                        'Dim a As String = lb.ID
                        lb.Attributes.Add("onclick", "javascript:return ShowDeletePopup(this, 'Record will be Permanently Deleted')")
                        'lb.Attributes.Add("onclick", "javascript:return " + "confirm('Are you sure you want to delete this record ?')")

                    End If
                End If
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub


End Class