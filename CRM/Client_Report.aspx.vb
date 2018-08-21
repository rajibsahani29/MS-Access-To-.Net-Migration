Imports CRM.BE
Imports CRM.DL
Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.tool.xml
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text
Imports System.Globalization

Public Class Client_Report
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEClient As clsBEClient = New clsBEClient
    Dim objBEClientContact As clsBEClientcontact = New clsBEClientcontact


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim dstcompany As DataSet = (New clsDLClient()).GetClientFillInDD()
            objFunction.FillDropDownByDataSet(ddlcompany, dstcompany)
            ddlcompany.Items.Insert(0, "Select Company")
            ddlCount.SelectedIndex = 1
        End If

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

    Protected Sub ddlcompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlcompany.SelectedIndexChanged
        Try
            Dim dstClientEmail As New DataSet()
            objBEClientContact.ClientId = objFunction.ReturnInteger(ddlcompany.SelectedItem.Value)
            dstClientEmail = (New clsDLClientcontact()).GetClientContactEmail(objBEClientContact)
            objFunction.FillDropDownByDataSet(ddlEmail, dstClientEmail)
            ddlEmail.Items.Insert(0, "Select")

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Public Sub FillGrid()
        Try
            Dim dstJobList As New DataSet()
            Dim strSearchFromDate As String = ""
            If txtstartdate.Text <> "" Then

                Dim dt As DateTime = DateTime.ParseExact(txtstartdate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                Dim dtSearchByDate As DateTime = (If(txtstartdate.Text <> "", dt, DateTime.MinValue))
                strSearchFromDate = dtSearchByDate.ToString("MM/dd/yyyy")
            End If
            Dim strSearchToDate As String = ""
            If txtEnddate.Text <> "" Then
                Dim dt As DateTime = DateTime.ParseExact(txtEnddate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                Dim dtSearchToDate As DateTime = (If(txtEnddate.Text <> "", dt, DateTime.MinValue))
                strSearchToDate = dtSearchToDate.ToString("MM/dd/yyyy")
            End If
            Dim strSearchByClient As String = (If(ddlcompany.SelectedValue <> "Select Company", ddlcompany.SelectedItem.Value, ""))
            Dim strSearchByRefrigeration As String = ""
            If (chkRefrigiration.Checked()) Then
                strSearchByRefrigeration = "R"
            Else
                strSearchByRefrigeration = "F"
            End If
            Dim strSearchByStype As String = (If(ddlSType.SelectedValue <> "Type", ddlSType.SelectedItem.Value, ""))

            dstJobList = (New clsDLClientReport()).GetClientReprotBySearchCriteria(strSearchFromDate, strSearchToDate, strSearchByClient, strSearchByRefrigeration, strSearchByStype)
            If objFunction.CheckDataSet(dstJobList) Then
                grdJoblist.DataSource = dstJobList
                grdJoblist.DataBind()
            Else
                grdJoblist.DataSource = Nothing
                grdJoblist.DataBind()
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub
    ''' <summary>
    ''' Show the data on searching
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FillGrid()
        FillGridFirstVisitFix()
    End Sub
    Public Sub FillGridFirstVisitFix()
        Try
            Dim dstJobList As New DataSet()
            Dim strSearchFromDate As String = ""
            If txtstartdate.Text <> "" Then
                Dim dtSearchByDate As DateTime = (If(txtstartdate.Text <> "", DateTime.ParseExact(txtstartdate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture), DateTime.MinValue))
                strSearchFromDate = dtSearchByDate.ToString("MM/dd/yyyy")
            End If
            Dim strSearchToDate As String = ""
            If txtEnddate.Text <> "" Then
                Dim dtSearchToDate As DateTime = (If(txtEnddate.Text <> "", DateTime.ParseExact(txtEnddate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture), DateTime.MinValue))
                strSearchToDate = dtSearchToDate.ToString("MM/dd/yyyy")
            End If
            Dim strSearchByClient As String = (If(ddlcompany.SelectedItem.Value <> "", ddlcompany.SelectedItem.Value, ""))
            dstJobList = (New clsDLClientReport()).ClientReportForFirstVisitFix(strSearchFromDate, strSearchToDate, strSearchByClient)
            If objFunction.CheckDataSet(dstJobList) Then
                grdFirstVisit.DataSource = dstJobList
                grdFirstVisit.DataBind()
                Dim totalCount As Double = 0
                For i = 0 To dstJobList.Tables(0).Rows.Count - 1
                    totalCount += objFunction.ReturnDouble(dstJobList.Tables(0).Rows(i)("CountOfFirstVisitFix"))
                Next
                txtTotal.Text = totalCount.ToString()
            Else
                grdFirstVisit.DataSource = Nothing
                grdFirstVisit.DataBind()
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub
    Protected Sub grdJoblist_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdJoblist.PageIndexChanging
        grdJoblist.PageIndex = e.NewPageIndex
        FillGrid()
    End Sub

    Protected Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If txtstartdate.Text <> "" And txtEnddate.Text <> "" And ddlcompany.SelectedIndex <> 0 Then
            If ddlEmail.SelectedIndex <> 0 Then
                Session("ID") = ddlcompany.SelectedValue
                Session("Sdate") = txtstartdate.Text
                Session("Edate") = txtEnddate.Text
                SendMailWithPDF()
            Else
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopupBlank('Choose EmailId for Email Sending.');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            End If

        Else
            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowPopupBlank('Please Enter Company Name,Start Date And End Date First!');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        End If

    End Sub


    Protected Sub SendMailWithPDF()
        Try
            Dim bytes As Byte() = Nothing
            Dim sw As StringWriter = New StringWriter()
            HttpContext.Current.Server.Execute("ClientReport_Pdf.aspx", sw)
            Dim htmlText = sw.ToString()
            Using memoryStream As New MemoryStream()
                Using document As New Document()
                    Dim writer = PdfWriter.GetInstance(document, memoryStream)
                    document.Open()
                    Using cssMemoryStream As New MemoryStream(System.Text.Encoding.UTF8.GetBytes("")) 'cssText1 + cssText2
                        Using htmlMemoryStream As New MemoryStream(System.Text.Encoding.UTF8.GetBytes(htmlText))
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, htmlMemoryStream, cssMemoryStream)
                        End Using
                    End Using
                End Using
                bytes = memoryStream.ToArray()
            End Using
            Dim strMailStatus As String = clsEmail.SendEmail(ddlEmail.SelectedItem.Text, "Client Report Attached", "Please find attached report generated fom fast fixx client system", bytes, Me)
            'Dim strMailStatus As String = clsEmail.SendReport("niharika.sahoo@shaeronsoftware.com", "Client Report Attached", "Please find attached report generated fom fast fixx client system", "ClientReport.pdf", bytes, Me)

            If strMailStatus = "Success" Then

                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Email sent successfully','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
        Catch ex As Exception
            Response.Write(ex.Message)

        End Try
    End Sub

    Protected Sub grdFirstVisit_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grdFirstVisit.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim iText As String = e.Row.Cells(3).Text
            If iText <> "" Then
                e.Row.Cells(2).Text = String.Format("{0:n2}", ((e.Row.Cells(1).Text / e.Row.Cells(3).Text) * 100)).ToString() + "%"
            End If
        End If
    End Sub
End Class