Imports CRM.BE
Imports CRM.DL
Public Class job_Quote_Print
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Dim objBELabour As clsBEQuoteLabour = New clsBEQuoteLabour
    Dim objBEClient As clsBEClient = New clsBEClient



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Request.QueryString("ID")) = "" Or objFunction.ReturnString(Request.QueryString("ID")) Is Nothing Then
            Response.Redirect("job_quote.aspx")
        End If

        If Not Page.IsPostBack Then
            Try
                Dim IntJobId = objFunction.ReturnInteger(Request.QueryString("ID"))
                Dim strLabourId = Session("QuoteLabourId").ToString()
                GetJobDetails(IntJobId)
                GetLabourDetails(IntJobId, strLabourId)
                GetPartDetails(IntJobId)

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
        End If

    End Sub
    Protected Sub GetJobDetails(ByVal id As Integer)


        Try
            Dim dstList As New DataSet()
            objBEOrder.JOBID = id
            dstList = (New clsDLOrder()).GetOrderDetailForInvoice(objBEOrder)
            If dstList IsNot Nothing Then
                txtasset.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Asset"))
                txtappliance.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Appliance"))
                txtfault.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Fault"))
                txtpremises.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Premises"))
                txtffnos.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("InvoiceNumber"))
                txtref.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Ref"))
                txtquoteDate.Text = Convert.ToDateTime(dstList.Tables(0).Rows(0)("QuoteDate"))
                txtmodel.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Model"))
                txtquotenumber.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("QuoteNumber"))
                lbldays.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("QuoteDays"))
                hdnCid.Value = objFunction.ReturnString(dstList.Tables(0).Rows(0)("ID"))
                GetClientDetails(objFunction.ReturnInteger(hdnCid.Value))

            End If


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


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


    Protected Sub GetPartDetails(ByVal id As Integer)


        Try
            Dim dstList As New DataSet()
            objBELabour.JOBID = id
            objBELabour.Type = "PartsTotal"
            dstList = (New clsDLQuoteLabour()).GetQuoteCostsByJobId(objBELabour)
            If objFunction.CheckDataSet(dstList) Then
                grdParts.DataSource = dstList
                grdParts.DataBind()
                Dim dblTotalAmount As Double = 0
                Dim dblTotalVat As Double = 0
                For i = 0 To dstList.Tables(0).Rows.Count - 1
                    dblTotalAmount += objFunction.ReturnDouble(dstList.Tables(0).Rows(i)("Total"))
                    dblTotalVat += objFunction.ReturnDouble(dstList.Tables(0).Rows(i)("Vat"))
                Next
                lblPartTotal.Text = dblTotalAmount.ToString()
                lblTotalExVat.Text = (objFunction.ReturnDouble(lblLabourTotal.Text) + dblTotalAmount).ToString()
                lblTotalVat.Text = (objFunction.ReturnFloatingValue(hdnVat.Value) + dblTotalVat).ToString()
                lblTotalIncVat.Text = (objFunction.ReturnDouble(lblTotalExVat.Text) + objFunction.ReturnDouble(lblTotalVat.Text)).ToString()
            Else
                lblPartTotal.Text = "0"
                lblTotalExVat.Text = (objFunction.ReturnDouble(lblLabourTotal.Text)).ToString()
                lblTotalVat.Text = (objFunction.ReturnFloatingValue(hdnVat.Value)).ToString()
                lblTotalIncVat.Text = (objFunction.ReturnDouble(lblTotalExVat.Text) + objFunction.ReturnDouble(lblTotalVat.Text)).ToString()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub

    'Protected Sub GetLabourDetails(ByVal id As Integer)


    '    Try
    '        Dim dstList As New DataSet()
    '        objBELabour.JOBID = id
    '        objBELabour.Type = "LabourTotal"
    '        dstList = (New clsDLQuoteLabour()).GetQuoteCostsByJobId(objBELabour)
    '        If objFunction.CheckDataSet(dstList) Then
    '            grdLabour.DataSource = dstList
    '            grdLabour.DataBind()
    '            Dim dblTotalAmount As Double = 0
    '            Dim dblTotalVat As Double = 0
    '            For i = 0 To dstList.Tables(0).Rows.Count - 1
    '                dblTotalAmount += objFunction.ReturnDouble(dstList.Tables(0).Rows(i)("Total"))
    '                dblTotalVat += objFunction.ReturnDouble(dstList.Tables(0).Rows(i)("Vat"))
    '            Next
    '            lblLabourTotal.Text = dblTotalAmount.ToString()
    '            hdnVat.Value = dblTotalVat.ToString()
    '        End If
    '    Catch ex As Exception
    '        HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
    '        HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
    '    End Try


    'End Sub

    Protected Sub GetLabourDetails(ByVal id As Integer, ByVal PrintValueId As String)


        Try
            Dim dstList As New DataSet()
            objBELabour.JOBID = id
            objBELabour.Type = "LabourTotal"
            objBELabour.PID = PrintValueId

            dstList = (New clsDLQuoteLabour()).GetQuoteCostsForLabourByJobId(objBELabour)
            If objFunction.CheckDataSet(dstList) Then
                grdLabour.DataSource = dstList
                grdLabour.DataBind()
                Dim dblTotalAmount As Double = 0
                Dim dblTotalVat As Double = 0
                For i = 0 To dstList.Tables(0).Rows.Count - 1
                    dblTotalAmount += objFunction.ReturnDouble(dstList.Tables(0).Rows(i)("Total"))
                    dblTotalVat += objFunction.ReturnDouble(dstList.Tables(0).Rows(i)("Vat"))
                Next
                lblLabourTotal.Text = dblTotalAmount.ToString()
                hdnVat.Value = dblTotalVat.ToString()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub
End Class