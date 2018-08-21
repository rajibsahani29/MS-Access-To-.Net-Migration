Imports Microsoft.VisualBasic
Namespace BE
    Public Class clsBElocOrder
#Region "locOrder"


        Private intJOBID As Integer
        Public Property JOBID() As Integer
            Get
                Return intJOBID
            End Get
            Set(ByVal value As Integer)
                intJOBID = value
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

        Private strStatus As String
        Public Property Status() As String
            Get
                Return strStatus
            End Get
            Set(ByVal value As String)
                strStatus = value
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
        Private strPremises As String
        Public Property Premises() As String
            Get
                Return strPremises
            End Get
            Set(ByVal value As String)
                strPremises = value
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


        Private intqty As Integer
        Public Property Qty() As String
            Get
                Return intqty
            End Get
            Set(ByVal value As String)
                intqty = value
            End Set
        End Property
        Private intreceived As Integer
        Public Property Received() As String
            Get
                Return intreceived
            End Get
            Set(ByVal value As String)
                intreceived = value
            End Set
        End Property

        Private intawait As Integer
        Public Property await() As String
            Get
                Return intawait
            End Get
            Set(ByVal value As String)
                intawait = value
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


        Private strJobType As String
        Public Property JobType() As String
            Get
                Return strJobType
            End Get
            Set(ByVal value As String)
                strJobType = value
            End Set
        End Property



        Private strInvoiceStatus As String
        Public Property InvoiceStatus() As String
            Get
                Return strInvoiceStatus
            End Get
            Set(ByVal value As String)
                strInvoiceStatus = value
            End Set
        End Property
#End Region
    End Class
End Namespace
