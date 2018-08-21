Imports System.IO
Imports CRM.BE
Imports CRM.DL
Imports Ionic.Zip

Public Class Index
    Inherits System.Web.UI.Page
    Protected objBEOrder As clsBEOrder = New clsBEOrder
    Protected objBEJobsheet As clsBEJobsheet = New clsBEJobsheet
    Protected dstEngineer As DataSet
    Protected dstJobList As DataSet
    Protected dstJobSheet As DataSet
    Protected objFunction As New clsCommon()
    Protected dt As String
    Dim strFilename As String
    Dim strId As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not objFunction.ValidateLogin() Then
                Response.Redirect("~/Login.aspx")
            End If
            If objFunction.ReturnString(Request.QueryString("CsvFlag")) = "" Or objFunction.ReturnString(Request.QueryString("CsvFlag")) Is Nothing Then

            Else
                Dim strId = objFunction.ReturnString(Request.QueryString("CsvFlag"))
                If (strId = 1) Then
                    DownloadInvoiceCsv()
                Else
                    hdnDownload.Value = "1"
                    DownloadClientCsv()
                End If
            End If
            If Not Page.IsPostBack Then
                txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy")
                GetJobsheetDetails()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            If (hdnDownload.Value = "1") Then
                UpdateFlag()
            End If
        End Try
    End Sub

    Public Sub UpdateFlag()

        Dim intAffectedRow As Integer = (New clsDLOrder()).UpdateOrderFlagDetails()
        If intAffectedRow > 0 Then
            Dim intAffectedRow1 As Integer = (New clsDLClient()).UpdateClientFlag()
            If intAffectedRow1 > 0 Then
            End If
        End If
    End Sub
    Public Sub DownloadClientCsv()
        Try
            Dim strFilename1 As String
            Dim dstData As New DataSet()
            dstData = (New ClsDLCSV()).GetClientForSage()
            If dstData Is Nothing Then

                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowSucess2('There is no new clients to download.');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else
                Dim rand As New Random()
                Dim randomx2 As Integer = rand.Next(1, 9999999)
                strFilename1 = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + randomx2.ToString() + "CustomersForSage.csv"
                Dim strFilePath As String = Server.MapPath("~/DownloadCSV/" + strFilename1)
                Dim objStreamWriter As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(strFilePath, True)
                If objFunction.CheckDataSet(dstData) Then
                    For i = 0 To dstData.Tables(0).Rows.Count - 1
                        Dim strFileData As String = objFunction.ReturnString(dstData.Tables(0).Rows(i)("C1")) + "," +
                                                    objFunction.ReturnString(dstData.Tables(0).Rows(i)("C2"))

                        objStreamWriter.WriteLine(strFileData)
                    Next
                End If

                objStreamWriter.Close()

                Dim memStream As New MemoryStream()
                Using fileStream As FileStream = File.OpenRead(Server.MapPath("~/DownloadCSV/" + strFilename1))
                    memStream.SetLength(fileStream.Length)
                    fileStream.Read(memStream.GetBuffer(), 0, CInt(Fix(fileStream.Length)))
                End Using
                Response.Clear()
                Response.ContentType = "application/force-download"
                Response.AddHeader("content-disposition", "attachment; filename=" + strFilename1 + "")
                Response.Buffer = True
                Dim bytes = memStream.ToArray()
                Response.OutputStream.Write(bytes, 0, bytes.Length)
                Response.OutputStream.Flush()
                Response.End()
            End If


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Public Sub DownloadInvoiceCsv()
        Try
            Dim dstData As New DataSet()
            dstData = (New ClsDLCSV()).GetInvoiceForSage()
            If dstData Is Nothing Then

                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowSucess1('There is no new Invoice to download.');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else
                Dim rand As New Random()
                Dim randomx2 As Integer = rand.Next(1, 9999999)
                strFilename = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + randomx2.ToString() + "InvoicesForSage.csv"
                Dim strFilePath As String = Server.MapPath("~/DownloadCSV/" + strFilename)
                Dim objStreamWriter As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(strFilePath, True)
                If objFunction.CheckDataSet(dstData) Then
                    For i = 0 To dstData.Tables(0).Rows.Count - 1
                        Dim strFileData As String = objFunction.ReturnString(dstData.Tables(0).Rows(i)("C1")) + "," +
                                                    objFunction.ReturnString(dstData.Tables(0).Rows(i)("C2")) + "," +
                                                    objFunction.ReturnString(dstData.Tables(0).Rows(i)("C3")) + "," +
                                                    objFunction.ReturnString(dstData.Tables(0).Rows(i)("C4")) + "," +
                                                    objFunction.ReturnString(dstData.Tables(0).Rows(i)("C5")) + "," +
                                                    objFunction.ReturnString(dstData.Tables(0).Rows(i)("C6")) + "," +
                                                    objFunction.ReturnString(dstData.Tables(0).Rows(i)("C7")) + "," +
                                                    objFunction.ReturnString(dstData.Tables(0).Rows(i)("C8")) + "," +
                                                    objFunction.ReturnString(dstData.Tables(0).Rows(i)("C9")) + "," +
                                                    objFunction.ReturnString(dstData.Tables(0).Rows(i)("C10"))

                        objStreamWriter.WriteLine(strFileData)
                    Next
                End If

                objStreamWriter.Close()

                Dim memStream As New MemoryStream()
                Using fileStream As FileStream = File.OpenRead(Server.MapPath("~/DownloadCSV/" + strFilename))
                    memStream.SetLength(fileStream.Length)
                    fileStream.Read(memStream.GetBuffer(), 0, CInt(Fix(fileStream.Length)))
                End Using
                Response.Clear()
                Response.ContentType = "application/force-download"
                Response.AddHeader("content-disposition", "attachment; filename=" + strFilename + "")
                Response.Buffer = True
                Dim bytes = memStream.ToArray()
                Response.OutputStream.Write(bytes, 0, bytes.Length)
                Response.OutputStream.Flush()
                Response.End()
                'DownloadClientCsv()
                'Dim list As New List(Of String)()
                'list.Add(Server.MapPath("~/DownloadCSV/" + strFilename))
                'list.Add(Server.MapPath("~/DownloadCSV/" + strFilename1))
                'Using zip As New ZipFile()
                '    zip.AlternateEncodingUsage = ZipOption.AsNecessary
                '    zip.AddDirectoryByName("Files")

                '    Dim i As Integer
                '    For i = 0 To list.Count - 1
                '        zip.AddFile(list.Item(i), "Files")
                '    Next i

                '    Response.Clear()
                '    Response.BufferOutput = False
                '    Dim zipName As String = [String].Format("Zip_{0}.zip", DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"))
                '    Response.ContentType = "application/zip"
                '    Response.AddHeader("content-disposition", "attachment; filename=" + zipName)
                '    zip.Save(Response.OutputStream)
                '    Response.[End]()
                'End Using


            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub
    Protected Sub GetJobsheetDetails()
        Try
            Dim strArr() As String
            strArr = txtDate.Text.Split("/")
            Dim dd As String = strArr(0)
            Dim mm As String = strArr(1)
            Dim yy As String = strArr(2)
            dt = mm + "/" + dd + "/" + yy
            'objBEOrder.SheetDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
            objBEOrder.SheetDate = Convert.ToDateTime(dt)
            dstEngineer = (New clsDLOrder()).GetJobSheetEngineer(objBEOrder)
            'If objFunction.CheckDataSet(dstEngineer) Then
            '    For i = 0 To dstEngineer.Tables(0).Rows.Count - 1
            '        objBEOrder.Engineer = dstEngineer.Tables(0).Rows(i)("Engineer")
            '        objBEOrder.SheetDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
            '        dstJobList = (New clsDLOrder()).GetJobSheetDataByIndividualEngineer(objBEOrder)
            '    Next
            'End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        GetJobsheetDetails()
    End Sub
End Class