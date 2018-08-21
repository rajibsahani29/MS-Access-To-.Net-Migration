Namespace BE
    Public Class clsBEPartsOrder
        Private intPartOID As Integer
        Public Property PartsOrderID() As Integer
            Get
                Return intPartOID
            End Get
            Set(ByVal value As Integer)
                intPartOID = value
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
        Private intOrderNumber As Integer
        Public Property OrderNumber() As Integer
            Get
                Return intOrderNumber
            End Get
            Set(ByVal value As Integer)
                intOrderNumber = value
            End Set
        End Property
        Private dtOrderCreated As DateTime
        Public Property DateOrderCreated() As DateTime
            Get
                Return dtOrderCreated
            End Get
            Set(ByVal value As DateTime)
                dtOrderCreated = value
            End Set
        End Property
        Private dtOrderClosed As DateTime
        Public Property DateOrderClosed() As DateTime
            Get
                Return dtOrderClosed
            End Get
            Set(ByVal value As DateTime)
                dtOrderClosed = value
            End Set
        End Property
        Private strNotes As String
        Public Property OrderNotes() As String
            Get
                Return strNotes
            End Get
            Set(ByVal value As String)
                strNotes = value
            End Set
        End Property

        Private decDeliveryCost As Decimal
        Public Property DeliveryCost() As Decimal
            Get
                Return decDeliveryCost
            End Get
            Set(ByVal value As Decimal)
                decDeliveryCost = value
            End Set
        End Property
    End Class
End Namespace
