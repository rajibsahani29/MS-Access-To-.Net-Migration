Imports System.Globalization
Imports CRM.BE
Imports CRM.DL

Public Class Day_Book
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy")
            FillGrid()
        End If
    End Sub

    Protected Sub FillGrid()

        Try
            Dim dstJobList As New DataSet()
            objBEOrder.EnqDate = DateTime.ParseExact(txtDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
            dstJobList = (New clsDLOrder()).GetDetailsForDayBookByCompany(objBEOrder)
            If objFunction.CheckDataSet(dstJobList) Then
                grdDaybook.DataSource = dstJobList
                grdDaybook.DataBind()
            Else
                grdDaybook.DataSource = Nothing
                grdDaybook.DataBind()
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
    Protected Sub FillGridByTime()

        Try
            Dim dstJobList As New DataSet()
            objBEOrder.EnqDate = DateTime.ParseExact(txtDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
            dstJobList = (New clsDLOrder()).GetDetailsForDayBookByTime(objBEOrder)
            If objFunction.CheckDataSet(dstJobList) Then
                grdDaybook.DataSource = dstJobList
                grdDaybook.DataBind()
            Else
                grdDaybook.DataSource = Nothing
                grdDaybook.DataBind()
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub
    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If (hdnCheck.Value = "1") Then
            FillGrid()
        Else
            FillGridByTime()
        End If
    End Sub

    Protected Sub grdDaybook_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdDaybook.SelectedIndexChanging
        Try
            Session("JID") = objFunction.ReturnString(grdDaybook.DataKeys(e.NewSelectedIndex).Value)
            Response.Redirect("job_orderdetails.aspx")
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdDaybook_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdDaybook.PageIndexChanging
        Try
            grdDaybook.PageIndex = e.NewPageIndex

            If (hdnCheck.Value = "1") Then
                FillGrid()
            Else
                FillGridByTime()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
End Class