Imports CRM.BE
Imports CRM.DL

Partial Class job_select
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBElocOrder As clsBElocOrder = New clsBElocOrder
    Dim objBEOrder As clsBEOrder = New clsBEOrder

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            If Not Page.IsPostBack Then
                Dim JobNumber As String = objFunction.ReturnString(Request.QueryString("Search"))
                If JobNumber <> "" Then
                    BindJobsByJobNumber(JobNumber)
                Else
                    BindGridview(flag:=True)
                End If
                Dim dstOrder As DataSet = (New clsDLOrder()).GetOrderDetailFillInDD()
                objFunction.FillDropDownByDataSet(ddlEngineer, dstOrder)
                ddlEngineer.Items.Insert(0, New ListItem("View All", "0"))
                ddlEngineer.Items.Insert(1, New ListItem("Not Recorded", ""))

                'Dim dstStatus As DataSet = (New clsDLOrder()).GetOrderStatusFillInDD()
                'objFunction.FillDropDownByDataSet(ddlStatus, dstStatus)
                'ddlStatus.Items.Insert(0, New ListItem("Select Status", ""))

            End If


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub
    Protected Sub BindAllJobs()

        Try
            Dim dstJobList As New DataSet()
            dstJobList = (New clsDLOrder()).GetAllJobOrders()
            grdJob.DataSource = dstJobList
            grdJob.DataBind()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub
    Protected Sub BindJobsByJobNumber(ByVal strJobNo As String)

        Try
            Dim dstJobList As New DataSet()
            objBEOrder.JobNumber = strJobNo
            dstJobList = (New clsDLOrder()).GetJobDetailsByJobNumber(objBEOrder)
            grdJob.DataSource = dstJobList
            grdJob.DataBind()
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub
    Protected Sub BindJobsBySearch()
        Try
            'Dim intUserId = objFunction.ReturnInteger(Session("LoginUserId"))
            Dim strSearchByEngineer As String = (If(ddlEngineer.Text <> "", ddlEngineer.SelectedValue, ""))
            Dim strSearchByStatus As String = (If(ddlStatus.Text <> "", ddlStatus.SelectedItem.Value, ""))
            Dim strSearchByCompany As String = (If(txtCompany.Text <> "", txtCompany.Text, ""))
            Dim strSearchByFFNos As String
            If (txtFFNos.Text <> "") Then
                strSearchByFFNos = "FF" + txtFFNos.Text
            Else
                strSearchByFFNos = ""
            End If
            Dim strSearchByPermises As String = (If(txtPermises.Text <> "", txtPermises.Text, ""))
            Dim strSearchByAppliance As String = (If(txtAppliance.Text <> "", txtAppliance.Text, ""))
            Dim strSearchByFault As String = (If(txtFault.Text <> "", txtFault.Text, ""))
            Dim strSearchByOrder As String = (If(txtOrderNumber.Text <> "", txtOrderNumber.Text, ""))
            Dim strSearchByQuote As String = (If(txtQuote.Text <> "", txtQuote.Text, ""))

            Dim dstJobList As DataSet = (New clsDLOrder()).GetOrderDetail(strSearchByEngineer, strSearchByStatus, strSearchByCompany, strSearchByFFNos, strSearchByPermises, strSearchByAppliance, strSearchByFault, strSearchByOrder, strSearchByQuote)
            If objFunction.CheckDataSet(dstJobList) Then
                grdJob.DataSource = dstJobList
                grdJob.DataBind()
            Else
                grdJob.DataSource = Nothing
                grdJob.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub
    Protected Sub BindGridview(ByVal flag As Boolean)

        If flag = True Then
            BindAllJobs()
            ViewState.Add("Flag", True)

        Else
            BindJobsBySearch()
        End If
    End Sub


    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        BindGridview(flag:=False)
        ViewState.Add("Flag", False)

    End Sub
    ''' <summary>
    ''' This function is used to set date value
    ''' </summary>
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

    Protected Sub grdJob_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdJob.PageIndexChanging
        Try
            Dim strflag As String = CType(ViewState("Flag"), String)
            If strflag = True Then
                grdJob.PageIndex = e.NewPageIndex
                BindGridview(flag:=True)
            Else
                grdJob.PageIndex = e.NewPageIndex
                BindGridview(flag:=False)
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub



    Protected Sub grdJob_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdJob.SelectedIndexChanging
        Try
            'Dim JobID As String = objFunction.ReturnString(grdJob.DataKeys(e.NewSelectedIndex).Value)
            'Response.Redirect("job_orderdetails.aspx?JID=" + JobID)

            Session("JID") = objFunction.ReturnString(grdJob.DataKeys(e.NewSelectedIndex).Value)
            Response.Redirect("job_orderdetails.aspx")


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdJob_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdJob.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim iText As String = e.Row.Cells(6).Text

            If iText = "Enquiry" Then
                e.Row.BackColor = System.Drawing.Color.Red
                e.Row.ForeColor = System.Drawing.Color.White
            ElseIf iText = "Job Allocated" Then
                e.Row.BackColor = System.Drawing.Color.Yellow
                e.Row.ForeColor = System.Drawing.Color.Black
                e.Row.Cells(0).Font.Bold = True
            ElseIf iText = "Quoted" Then
                e.Row.BackColor = System.Drawing.Color.Blue
                e.Row.ForeColor = System.Drawing.Color.White
            ElseIf iText = "Parts Ordered" Then
                e.Row.BackColor = System.Drawing.Color.Pink
                e.Row.Cells(0).Font.Bold = True
            ElseIf iText = "Parts Received" Then
                e.Row.BackColor = System.Drawing.Color.Brown
                e.Row.ForeColor = System.Drawing.Color.White
                e.Row.Cells(0).Font.Bold = True
            ElseIf iText = "Parts Required" Then
                e.Row.BackColor = System.Drawing.Color.Purple
                e.Row.ForeColor = System.Drawing.Color.White
            ElseIf iText = "Invoice Sent" Then
                e.Row.BackColor = System.Drawing.Color.Orange
                e.Row.Cells(0).ForeColor = System.Drawing.Color.Black
                e.Row.Cells(0).Font.Bold = True
            ElseIf iText = "To be Quoted" Then
                e.Row.BackColor = System.Drawing.Color.LightBlue
                e.Row.Cells(0).ForeColor = System.Drawing.Color.Black
                e.Row.Cells(0).Font.Bold = True
            ElseIf iText = "Paid" Then
                e.Row.BackColor = System.Drawing.Color.Green
                e.Row.ForeColor = System.Drawing.Color.White
            ElseIf iText = "Cancelled" Then
                e.Row.BackColor = System.Drawing.Color.Black
                e.Row.ForeColor = System.Drawing.Color.White
            ElseIf iText = "To be Quoted" Then
                e.Row.BackColor = System.Drawing.Color.LightBlue
                e.Row.ForeColor = System.Drawing.Color.White
                e.Row.Cells(0).ForeColor = System.Drawing.Color.White
            ElseIf iText = "Ready For Invoicing" Then
                e.Row.BackColor = System.Drawing.Color.DarkGray
                e.Row.Cells(0).ForeColor = System.Drawing.Color.White
                e.Row.Cells(0).Font.Bold = True
            ElseIf iText = "Fit Parts" Then
                e.Row.BackColor = System.Drawing.Color.Cyan
                e.Row.Cells(0).ForeColor = System.Drawing.Color.Black
                e.Row.Cells(0).Font.Bold = True
            End If
        End If
    End Sub

    Protected Sub ddlStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlStatus.SelectedIndexChanged
        BindGridview(flag:=False)
        ViewState.Add("Flag", False)
        'BindJobsBySearch()
    End Sub
End Class