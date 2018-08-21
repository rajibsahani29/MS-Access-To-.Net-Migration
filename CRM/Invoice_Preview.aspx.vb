Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html.simpleparser
Imports System.Xml
Imports CRM.BE
Imports CRM.DL

Public Class Invoice_Preview
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Dim objBEInvoice As clsBEInvoice = New clsBEInvoice
    Dim objBEClient As clsBEClient = New clsBEClient

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Session("JID")) = "" And Session("JID") Is Nothing Then
            Response.Redirect("job_select.aspx")
        End If
        If objFunction.ReturnString(Request.QueryString("JID")) = "" Or objFunction.ReturnString(Request.QueryString("JID")) Is Nothing Then
            Response.Redirect("job_select.aspx")
        End If
        If Not Page.IsPostBack Then
            Dim id = objFunction.ReturnInteger(Request.QueryString("JID").ToString())
            GetInvoiceDetails(id)
            BindGridview(id)

        End If

    End Sub
    Protected Sub GetClientDetails(ByVal id As Integer)
        Try
            Dim dstClient As New DataSet()
            objBEClient.ClientId = id
            dstClient = (New clsDLClient()).GetClientDetailById(objBEClient)
            If dstClient IsNot Nothing Then
                txtcompany.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Cname"))
                txtStreet.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Street"))
                txtArea.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Area"))
                txtTown.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Town"))
                txtPostCode.Text = objFunction.ReturnString(dstClient.Tables(0).Rows(0)("Postcode"))



            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub


    Protected Sub BindGridview(ByVal JID As Integer)

        Try
            Dim dstJobCost As New DataSet()
            objBEInvoice.JOBID = JID
            dstJobCost = (New clsDLInvoice()).GetInvoiceItemDetailsById(objBEInvoice)
            Dim dblTotalAmountVal As Double = 0
            Dim dblVat As Double = 0
            Dim dblIncVat As Double = 0
            If objFunction.CheckDataSet(dstJobCost) Then
                GridView1.DataSource = dstJobCost
                GridView1.DataBind()
                For i = 0 To dstJobCost.Tables(0).Rows.Count - 1
                    dblTotalAmountVal += objFunction.ReturnDouble(dstJobCost.Tables(0).Rows(i)("Total"))
                Next
                txttotalExvat.Text = String.Format("{0:n2}", dblTotalAmountVal).ToString()
                txtvatrate.Text = "20.00%"
                dblVat = dblTotalAmountVal * 20 / 100
                txtvat.Text = String.Format("{0:n2}", dblVat).ToString()
                dblIncVat = dblVat + dblTotalAmountVal
                txttotal.Text = String.Format("{0:n2}", dblIncVat).ToString()
                txttotal1.Text = String.Format("{0:n2}", dblIncVat).ToString()

            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub
    Protected Sub GetInvoiceDetails(ByVal id As Integer)


        Try
            Dim dstList As New DataSet()
            objBEOrder.JOBID = id
            dstList = (New clsDLOrder()).GetOrderDetailForInvoice(objBEOrder)
            If dstList IsNot Nothing Then
                'txtresponse.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("FFNUMBER"))
                txtasset.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Asset"))
                txtappliance.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Appliance"))
                txtfault.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Fault"))
                txtpremises.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Premises"))
                'txtinvoice.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("InvoiceNumber"))
                txtref.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Ref"))
                txtorderdate.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("OrderDate"))
                txtorderno.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Ref"))
                txtjobno.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("InvoiceNumber"))
                txtInvoicedate.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("InvoiceDate"))
                GetClientDetails(objFunction.ReturnInteger(dstList.Tables(0).Rows(0)("id")))
            End If


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub
End Class