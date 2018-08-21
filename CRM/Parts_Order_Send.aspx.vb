Imports CRM.BE
Imports CRM.DL
Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.tool.xml
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text
Public Class Parts_Order_Send
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEPartsOrder As clsBEPartsOrder = New clsBEPartsOrder
    Dim objBESupplier As clsBESupplier = New clsBESupplier

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Session("ID")) = "" And Session("ID") Is Nothing Then
            Response.Redirect("Parts_Part_OrderList.aspx")
        End If
        If Not Page.IsPostBack Then
            Dim intPartOrderId = objFunction.ReturnInteger(Session("ID"))
            Try
                Dim dstList As New DataSet()
                objBEPartsOrder.PartsOrderID = intPartOrderId
                dstList = (New clsDLPartsOrder()).GetPartsOrderDetailsByID(objBEPartsOrder)
                If objFunction.CheckDataSet(dstList) Then
                    txtOrderNo.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("OrderNumber"))
                    txtsupplier.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("SupplierName"))
                    txtTotalCost.Text = objFunction.ReturnDouble(dstList.Tables(0).Rows(0)("DeliveryCost"))
                    hdnSupplierId.Value = objFunction.ReturnString(dstList.Tables(0).Rows(0)("SupplierID"))

                End If
                FillSupplierDetails()

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
        End If
    End Sub
    Public Sub FillSupplierDetails()
        Try
            Dim dstdetails As New DataSet()
            objBESupplier.SupplierID = hdnSupplierId.Value
            dstdetails = (New clsDLSupplier()).GetSupplierDetailsById(objBESupplier)
            If objFunction.CheckDataSet(dstdetails) Then
                txtSupplierName.Text = objFunction.ReturnString(dstdetails.Tables(0).Rows(0)("SupplierName"))
                txtAddress1.Text = objFunction.ReturnString(dstdetails.Tables(0).Rows(0)("address1"))
                txtAddress2.Text = objFunction.ReturnString(dstdetails.Tables(0).Rows(0)("Address2"))
                txtTown.Text = objFunction.ReturnString(dstdetails.Tables(0).Rows(0)("Town"))
                txtPostCode.Text = objFunction.ReturnString(dstdetails.Tables(0).Rows(0)("postcode"))
                txtPhone.Text = objFunction.ReturnString(dstdetails.Tables(0).Rows(0)("phone"))
                txtNotes.Text = objFunction.ReturnString(dstdetails.Tables(0).Rows(0)("Notes"))
                txtEmail.Text = objFunction.ReturnString(dstdetails.Tables(0).Rows(0)("Email"))

            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub
    Protected Sub flatradio1_CheckedChanged(sender As Object, e As EventArgs) Handles flatradio1.CheckedChanged
        Dim PartsOrderID = objFunction.ReturnString(Session("ID"))
        Response.Write("<script>window.open ('Parts_order_Print.aspx?ID=" + PartsOrderID + "','_blank');</script>")
    End Sub

    Protected Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        If txtEmailMsg.Text <> "" And txtEmail.Text <> "" Then
            SendMailWithPDF()
        Else
            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowPopupBlank('Fill The EmailId and Email Message First for Email Sending.');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        End If


    End Sub

    Protected Sub SendMailWithPDF()
        Try
            Dim bytes As Byte() = Nothing
            Dim sw As StringWriter = New StringWriter()
            HttpContext.Current.Server.Execute("Part_Order_Pdf.aspx", sw)
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
            'Dim strLink As String = "~InvoicePDF/Test.txt"
            Dim strMailStatus As String = clsEmail.SendEmail(txtEmail.Text, "Purchase Order ~ " + txtOrderNo.Text + "", txtEmailMsg.Text, bytes, Me)
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


End Class