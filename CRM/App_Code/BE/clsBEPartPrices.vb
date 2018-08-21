Imports Microsoft.VisualBasic
Namespace BE
    Public Class clsBEPartPrices
        Private intPartPriceID As Integer
        Public Property PartPriceID() As Integer
            Get
                Return intPartPriceID
            End Get
            Set(ByVal value As Integer)
                intPartPriceID = value
            End Set
        End Property

        Private intPartID As Integer
        Public Property PartID() As Integer
            Get
                Return intPartID
            End Get
            Set(ByVal value As Integer)
                intPartID = value
            End Set
        End Property
        Private intSupplierID As Integer
        Public Property SupplierID() As Integer
            Get
                Return intSupplierID
            End Get
            Set(ByVal value As Integer)
                intSupplierID = value
            End Set
        End Property


        Private decPrice As Decimal
        Public Property Price() As Decimal
            Get
                Return decPrice
            End Get
            Set(ByVal value As Decimal)
                decPrice = value
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


        Private deccost As Decimal
        Public Property DeliveryCost() As Decimal
            Get
                Return deccost
            End Get
            Set(ByVal value As Decimal)
                deccost = value
            End Set
        End Property

        Private strPartno As String
        Public Property SuppliersPartNumber() As String
            Get
                Return strPartno
            End Get
            Set(ByVal value As String)
                strPartno = value
            End Set
        End Property

        Private dtpPrice As DateTime
        Public Property PriceDate() As DateTime
            Get
                Return dtpPrice
            End Get
            Set(ByVal value As DateTime)
                dtpPrice = value
            End Set
        End Property
    End Class
End Namespace
