Imports CRM.BE
Imports CRM.DL
Public Class ClientReport_Pdf
    Inherits System.Web.UI.Page
    Public strRootUrl As String
    Dim objFunction As New clsCommon()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Uri = Request.Url
        strRootUrl = Uri.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath + If(HttpContext.Current.Request.ApplicationPath <> "", "/", "")
        Try
            Dim IntId = objFunction.ReturnString(Session("ID"))
            Dim StrStartDate = objFunction.ReturnString(Session("Sdate"))
            Dim StrEndDate = objFunction.ReturnString(Session("Edate"))
            Dim dtSDate As DateTime = Convert.ToDateTime(StrStartDate)
            txtStartDate.Text = dtSDate.ToString("dd-MM-yyyy")
            Dim dtEDate As DateTime = Convert.ToDateTime(StrEndDate)
            txtEndDate.Text = dtEDate.ToString("dd-MM-yyyy")

            GetReportDetails(IntId, StrStartDate, StrEndDate)


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
    Protected Sub GetReportDetails(ByVal id As String, ByVal startdate As String, ByVal Enddate As String)


        Try
            Dim dstJobList As New DataSet()
            Dim strSearchFromDate As String = ""
            If startdate <> "" Then
                Dim dtSearchByDate As DateTime = Convert.ToDateTime(startdate)
                strSearchFromDate = dtSearchByDate.ToString("MM/dd/yyyy")
            End If
            Dim strSearchToDate As String = ""
            If Enddate <> "" Then
                Dim dtSearchToDate As DateTime = Convert.ToDateTime(Enddate)
                strSearchToDate = dtSearchToDate.ToString("MM/dd/yyyy")
            End If
            Dim strSearchByClient As String = id
            dstJobList = (New clsDLClientReport()).ClientReportDetails(strSearchFromDate, strSearchToDate, strSearchByClient)
            If objFunction.CheckDataSet(dstJobList) Then
                grdClient.DataSource = dstJobList
                grdClient.DataBind()
                txtcompany.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Company Name"))
                Dim dblTotalAmount As Double = 0
                Dim dblTotalLabour As Double = 0
                Dim dblTotalParts As Double = 0

                For i = 0 To dstJobList.Tables(0).Rows.Count - 1
                    dblTotalAmount += objFunction.ReturnDouble(dstJobList.Tables(0).Rows(i)("Total"))
                    dblTotalLabour += objFunction.ReturnDouble(dstJobList.Tables(0).Rows(i)("SumOfLabour"))
                    dblTotalParts += objFunction.ReturnDouble(dstJobList.Tables(0).Rows(i)("SumOfParts"))

                Next
                lblLabourTotal.Text = objFunction.ReturnFloatingValue(dblTotalLabour).ToString()
                lblPartTotal.Text = objFunction.ReturnFloatingValue(dblTotalParts).ToString()
                lblTotal.Text = objFunction.ReturnFloatingValue(dblTotalAmount).ToString()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub
End Class