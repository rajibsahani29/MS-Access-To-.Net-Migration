Imports Microsoft.VisualBasic
Namespace BE
    Public Class clsBEOrder
#Region "Order"


        Private intJOBID As Integer
        Public Property JOBID() As Integer
            Get
                Return intJOBID
            End Get
            Set(ByVal value As Integer)
                intJOBID = value
            End Set
        End Property
        Private intSortOrder As Integer
        Public Property SortOrder() As Integer
            Get
                Return intSortOrder
            End Get
            Set(ByVal value As Integer)
                intSortOrder = value
            End Set
        End Property
        Private intID As Integer
        Public Property ID() As Integer
            Get
                Return intID
            End Get
            Set(ByVal value As Integer)
                intID = value
            End Set
        End Property


        Private strOrderTakenBy As String
        Public Property OrderTakenBy() As String
            Get
                Return strOrderTakenBy
            End Get
            Set(ByVal value As String)
                strOrderTakenBy = value
            End Set
        End Property

        Private strStatus As String
        Public Property Status() As String
            Get
                Return strStatus
            End Get
            Set(ByVal value As String)
                strStatus = value
            End Set
        End Property
        Private dtDate As DateTime
        Public Property Datex() As DateTime
            Get
                Return dtDate
            End Get
            Set(ByVal value As DateTime)
                dtDate = value
            End Set
        End Property
        Private dtEnquiryDate As DateTime
        Public Property EnquiryDate() As DateTime
            Get
                Return dtEnquiryDate
            End Get
            Set(ByVal value As DateTime)
                dtEnquiryDate = value
            End Set
        End Property
        Private dtEnquiryTime As DateTime
        Public Property EnquiryTime() As DateTime
            Get
                Return dtEnquiryTime
            End Get
            Set(ByVal value As DateTime)
                dtEnquiryTime = value
            End Set
        End Property
        Private dtOrderDate As DateTime
        Public Property OrderDate() As DateTime
            Get
                Return dtOrderDate
            End Get
            Set(ByVal value As DateTime)
                dtOrderDate = value
            End Set
        End Property
        Private dtOrderTime As DateTime
        Public Property OrderTime() As DateTime
            Get
                Return dtOrderTime
            End Get
            Set(ByVal value As DateTime)
                dtOrderTime = value
            End Set
        End Property

        Private dtRequiredDate As DateTime
        Public Property RequiredDate() As DateTime
            Get
                Return dtRequiredDate
            End Get
            Set(ByVal value As DateTime)
                dtRequiredDate = value
            End Set
        End Property
        Private dtAllocatedDate As DateTime
        Public Property AllocatedDate() As DateTime
            Get
                Return dtAllocatedDate
            End Get
            Set(ByVal value As DateTime)
                dtAllocatedDate = value
            End Set
        End Property
        Private dtCompletionDate As DateTime
        Public Property CompletionDate() As DateTime
            Get
                Return dtCompletionDate
            End Get
            Set(ByVal value As DateTime)
                dtCompletionDate = value
            End Set
        End Property

        Private dtInvoiceDate As DateTime
        Public Property InvoiceDate() As DateTime
            Get
                Return dtInvoiceDate
            End Get
            Set(ByVal value As DateTime)
                dtInvoiceDate = value
            End Set
        End Property
        Private strJobNumber As String
        Public Property JobNumber() As String
            Get
                Return strJobNumber
            End Get
            Set(ByVal value As String)
                strJobNumber = value
            End Set
        End Property
        Private strOrderNumber As String
        Public Property OrderNumber() As String
            Get
                Return strOrderNumber
            End Get
            Set(ByVal value As String)
                strOrderNumber = value
            End Set
        End Property
        Private strAssetNumber As String
        Public Property AssetNumber() As String
            Get
                Return strAssetNumber
            End Get
            Set(ByVal value As String)
                strAssetNumber = value
            End Set
        End Property
        Private strEngineer As String
        Public Property Engineer() As String
            Get
                Return strEngineer
            End Get
            Set(ByVal value As String)
                strEngineer = value
            End Set
        End Property
        Private blnEngineerListed As Boolean
        Public Property EngineerListed() As Boolean
            Get
                Return blnEngineerListed
            End Get
            Set(ByVal value As Boolean)
                blnEngineerListed = value
            End Set
        End Property
        Private strEngineersNotes As String
        Public Property EngineersNotes() As String
            Get
                Return strEngineersNotes
            End Get
            Set(ByVal value As String)
                strEngineersNotes = value
            End Set
        End Property
        Private strPremises As String
        Public Property Premises() As String
            Get
                Return strPremises
            End Get
            Set(ByVal value As String)
                strPremises = value
            End Set
        End Property

        Private strAddress1 As String
        Public Property Address1() As String
            Get
                Return strAddress1
            End Get
            Set(ByVal value As String)
                strAddress1 = value
            End Set
        End Property
        Private strAddress2 As String
        Public Property Address2() As String
            Get
                Return strAddress2
            End Get
            Set(ByVal value As String)
                strAddress2 = value
            End Set
        End Property
        Private strAddress3 As String
        Public Property Address3() As String
            Get
                Return strAddress3
            End Get
            Set(ByVal value As String)
                strAddress3 = value
            End Set
        End Property

        Private strPremisesPostCode As String
        Public Property PremisesPostCode() As String
            Get
                Return strPremisesPostCode
            End Get
            Set(ByVal value As String)
                strPremisesPostCode = value
            End Set
        End Property
        Private strTelephone As String
        Public Property Telephone() As String
            Get
                Return strTelephone
            End Get
            Set(ByVal value As String)
                strTelephone = value
            End Set
        End Property
        Private strContactName As String
        Public Property ContactName() As String
            Get
                Return strContactName
            End Get
            Set(ByVal value As String)
                strContactName = value
            End Set
        End Property
        Private strResponse As String
        Public Property Response() As String
            Get
                Return strResponse
            End Get
            Set(ByVal value As String)
                strResponse = value
            End Set
        End Property
        Private strAppliance As String
        Public Property Appliance() As String
            Get
                Return strAppliance
            End Get
            Set(ByVal value As String)
                strAppliance = value
            End Set
        End Property
        Private strHomeEmail As String
        Public Property HomeEmail() As String
            Get
                Return strHomeEmail
            End Get
            Set(ByVal value As String)
                strHomeEmail = value
            End Set
        End Property
        Private strFault As String
        Public Property Fault() As String
            Get
                Return strFault
            End Get
            Set(ByVal value As String)
                strFault = value
            End Set
        End Property
        Private strQuoteNumber As String
        Public Property QuoteNumber() As String
            Get
                Return strQuoteNumber
            End Get
            Set(ByVal value As String)
                strQuoteNumber = value
            End Set
        End Property
        Private strQuoteAcc As String
        Public Property QuoteAcc() As String
            Get
                Return strQuoteAcc
            End Get
            Set(ByVal value As String)
                strQuoteAcc = value
            End Set
        End Property
        Private strModelofAppliance As String
        Public Property ModelofAppliance() As String
            Get
                Return strModelofAppliance
            End Get
            Set(ByVal value As String)
                strModelofAppliance = value
            End Set
        End Property
        Private intLabour As Integer
        Public Property Labour() As Integer
            Get
                Return intLabour
            End Get
            Set(ByVal value As Integer)
                intLabour = value
            End Set
        End Property
        Private strRemarks As String
        Public Property Remarks() As String
            Get
                Return strRemarks
            End Get
            Set(ByVal value As String)
                strRemarks = value
            End Set
        End Property
        Private strNotes As String
        Public Property Notes() As String
            Get
                Return strNotes
            End Get
            Set(ByVal value As String)
                strNotes = value
            End Set
        End Property
        Private intFFNUMBER As Integer
        Public Property FFNUMBER() As Integer
            Get
                Return intFFNUMBER
            End Get
            Set(ByVal value As Integer)
                intFFNUMBER = value
            End Set
        End Property
        Private dtEnqDate As DateTime
        Public Property EnqDate() As DateTime
            Get
                Return dtEnqDate
            End Get
            Set(ByVal value As DateTime)
                dtEnqDate = value
            End Set
        End Property

        Private dtSheetDate As DateTime
        Public Property SheetDate() As DateTime
            Get
                Return dtSheetDate
            End Get
            Set(ByVal value As DateTime)
                dtSheetDate = value
            End Set
        End Property

        Private strChargeableStatus As String
        Public Property ChargeableStatus() As String
            Get
                Return strChargeableStatus
            End Get
            Set(ByVal value As String)
                strChargeableStatus = value
            End Set
        End Property

        Private intChargedUnder As Integer
        Public Property ChargedUnder() As Integer
            Get
                Return intChargedUnder
            End Get
            Set(ByVal value As Integer)
                intChargedUnder = value
            End Set
        End Property
        Private intApplianceID As Integer
        Public Property ApplianceID() As Integer
            Get
                Return intApplianceID
            End Get
            Set(ByVal value As Integer)
                intApplianceID = value
            End Set
        End Property

        Private intPremisesID As Integer
        Public Property PremisesID() As Integer
            Get
                Return intPremisesID
            End Get
            Set(ByVal value As Integer)
                intPremisesID = value
            End Set
        End Property
        Private strCSVfile As String
        Public Property CSVfile() As String
            Get
                Return strCSVfile
            End Get
            Set(ByVal value As String)
                strCSVfile = value
            End Set
        End Property
        Private intBatchID As Integer
        Public Property BatchID() As Integer
            Get
                Return intBatchID
            End Get
            Set(ByVal value As Integer)
                intBatchID = value
            End Set
        End Property
        Private intJJNUMBER As Integer
        Public Property JJNUMBER() As Integer
            Get
                Return intJJNUMBER
            End Get
            Set(ByVal value As Integer)
                intJJNUMBER = value
            End Set
        End Property

        Private blnRecallFlag As Boolean
        Public Property RecallFlag() As Boolean
            Get
                Return blnRecallFlag
            End Get
            Set(ByVal value As Boolean)
                blnRecallFlag = value
            End Set
        End Property
        Private strRecallNote As String
        Public Property RecallNote() As String
            Get
                Return strRecallNote
            End Get
            Set(ByVal value As String)
                strRecallNote = value
            End Set
        End Property
        Private dblVatRate As Double
        Public Property VatRate() As Double
            Get
                Return dblVatRate
            End Get
            Set(ByVal value As Double)
                dblVatRate = value
            End Set
        End Property

        Private strAccountCode As String
        Public Property AccountCode() As String
            Get
                Return strAccountCode
            End Get
            Set(ByVal value As String)
                strAccountCode = value
            End Set
        End Property
        Private intQuoteDays As Integer
        Public Property QuoteDays() As Integer
            Get
                Return intQuoteDays
            End Get
            Set(ByVal value As Integer)
                intQuoteDays = value
            End Set
        End Property
        Private strType As String
        Public Property Type() As String
            Get
                Return strType
            End Get
            Set(ByVal value As String)
                strType = value
            End Set
        End Property

        Private dblQuoteVatRate As Double
        Public Property QuoteVatRate() As Double
            Get
                Return dblQuoteVatRate
            End Get
            Set(ByVal value As Double)
                dblQuoteVatRate = value
            End Set
        End Property
        Private intRecallCount As Integer
        Public Property RecallCount() As Integer
            Get
                Return intRecallCount
            End Get
            Set(ByVal value As Integer)
                intRecallCount = value
            End Set
        End Property

        Private dtQuoteDate As DateTime
        Public Property QuoteDate() As DateTime
            Get
                Return dtQuoteDate
            End Get
            Set(ByVal value As DateTime)
                dtQuoteDate = value
            End Set
        End Property
        Private intStaffID As Integer
        Public Property StaffID() As Integer
            Get
                Return intStaffID
            End Get
            Set(ByVal value As Integer)
                intStaffID = value
            End Set
        End Property
        Private strIssueStatus As String
        Public Property IssueStatus() As String
            Get
                Return strIssueStatus
            End Get
            Set(ByVal value As String)
                strIssueStatus = value
            End Set
        End Property

        Private strSType As String
        Public Property ServiceType() As String
            Get
                Return strSType
            End Get
            Set(ByVal value As String)
                strSType = value
            End Set
        End Property
#End Region
    End Class
End Namespace