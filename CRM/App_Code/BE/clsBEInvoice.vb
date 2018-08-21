
Namespace BE
    Public Class clsBEInvoice

        Private intInvoiceItemlID As Integer
        Public Property InvoiceItemlID() As Integer
            Get
                Return intInvoiceItemlID
            End Get
            Set(ByVal value As Integer)
                intInvoiceItemlID = value
            End Set
        End Property

        Private intJOBID As Integer
        Public Property JOBID() As Integer
            Get
                Return intJOBID
            End Get
            Set(ByVal value As Integer)
                intJOBID = value
            End Set
        End Property
        Private intLine As Integer
        Public Property Line() As Integer
            Get
                Return intLine
            End Get
            Set(ByVal value As Integer)
                intLine = value
            End Set
        End Property

        Private decNos As Decimal
        Public Property Nos() As Decimal
            Get
                Return decNos
            End Get
            Set(ByVal value As Decimal)
                decNos = value
            End Set
        End Property

        Private strItemDesctiption As String
        Public Property ItemDesctiption() As String
            Get
                Return strItemDesctiption
            End Get
            Set(ByVal value As String)
                strItemDesctiption = value
            End Set
        End Property
        Private strUNIT As String
        Public Property UNIT() As String
            Get
                Return strUNIT
            End Get
            Set(ByVal value As String)
                strUNIT = value
            End Set
        End Property
        Private decCost As Decimal
        Public Property Cost() As Decimal
            Get
                Return decCost
            End Get
            Set(ByVal value As Decimal)
                decCost = value
            End Set
        End Property
        Private dtfrom As DateTime
        Public Property DateFrom() As DateTime
            Get
                Return dtfrom
            End Get
            Set(ByVal value As DateTime)
                dtfrom = value
            End Set
        End Property
        Private dtTo As DateTime
        Public Property DateTo() As DateTime
            Get
                Return dtTo
            End Get
            Set(ByVal value As DateTime)
                dtTo = value
            End Set
        End Property



    End Class
End Namespace
