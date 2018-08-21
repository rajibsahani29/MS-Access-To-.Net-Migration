Imports System.Globalization
Imports CRM.BE
Imports CRM.DL
Public Class Job_OrderPrint
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Dim dt As DateTime

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Session("JID")) = "" And Session("JID") Is Nothing Then
            Response.Redirect("job_select.aspx")
        End If
        If Not Page.IsPostBack Then
            Dim intJobId = objFunction.ReturnInteger(Session("JID"))
            GetOrderDetails(intJobId)
            BindPartsOrderOnThisJob(intJobId)

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
                txtfault.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Fault"))
                txtpremises.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Premises"))
                txtAddress1.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("ADD1"))
                txtAddress2.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("ADD2"))
                txtAddress3.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("ADD3"))
                txtAssetNumber.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Asset"))
                txtappliance.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Appliance"))
                txtresponse.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Response"))
                txtTelphone.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Telephone"))
                txtJobNumber.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("JobNumber"))
                txtStatus.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Status"))
                txtOrderNumber.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("OrderNo"))
                txtContactName.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("ContactName"))
                txtQuotenumber.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Quote"))
                txtModel.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Model"))
                txtRemarks.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Remarks"))
                txtCalender.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("EnquiryDate"))
                txtEngineersheetdate.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Sdate"))
                If (txtCalender.Text <> "") Then
                    dt = DateTime.ParseExact(txtCalender.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                    txtCalender.Text = dt
                Else
                    txtCalender.Text = ""
                End If
                If (txtEngineersheetdate.Text <> "") Then
                    dt = DateTime.ParseExact(txtEngineersheetdate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                    txtEngineersheetdate.Text = dt
                Else
                    txtEngineersheetdate.Text = ""
                End If

                txtInvoicedate.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("Invoicedate"))
                txtcompletedate.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("completiondate"))
                txtrequiredDate.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("RequiredDate"))
                txtorderdate.Text = objFunction.ReturnString(dstJobList.Tables(0).Rows(0)("OrderDate"))
            End If


        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub

    Protected Sub BindPartsOrderOnThisJob(ByVal id As Integer)

        Try
            Dim dstJobList As New DataSet()
            objBEOrder.JOBID = id
            dstJobList = (New clsDLOrder()).GetPartsOrderForJob(objBEOrder)

            If objFunction.CheckDataSet(dstJobList) Then
                grdPartsOrderForthisJob.DataSource = dstJobList
                grdPartsOrderForthisJob.DataBind()
                Dim dblTotalqty As Double = 0
                For i = 0 To dstJobList.Tables(0).Rows.Count - 1
                    dblTotalqty += objFunction.ReturnDouble(dstJobList.Tables(0).Rows(i)("Awaiting"))
                Next
                txttotal.Text = dblTotalqty.ToString()

            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

    End Sub
End Class