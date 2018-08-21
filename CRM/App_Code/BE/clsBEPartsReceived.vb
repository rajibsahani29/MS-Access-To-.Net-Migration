
Namespace BE
    Public Class clsBEPartsReceived

        Private intPartRecievedID As Integer
        Public Property PartRecievedID() As Integer
            Get
                Return intPartRecievedID
            End Get
            Set(ByVal value As Integer)
                intPartRecievedID = value
            End Set
        End Property

        Private intPartRequestID As Integer
        Public Property RequestID() As Integer
            Get
                Return intPartRequestID
            End Get
            Set(ByVal value As Integer)
                intPartRequestID = value
            End Set
        End Property

        Private intQuantity As Integer
        Public Property Quantity() As Integer
            Get
                Return intQuantity
            End Get
            Set(ByVal value As Integer)
                intQuantity = value
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

        Private strUser As String
        Public Property User() As String
            Get
                Return strUser
            End Get
            Set(ByVal value As String)
                strUser = value
            End Set
        End Property

        Private strComputer As String
        Public Property Computer() As String
            Get
                Return strComputer
            End Get
            Set(ByVal value As String)
                strComputer = value
            End Set
        End Property


        Private dtreceived As DateTime
        Public Property DateRecieved() As DateTime
            Get
                Return dtreceived
            End Get
            Set(ByVal value As DateTime)
                dtreceived = value
            End Set
        End Property

        Private strDEL As Boolean
        Public Property DEL() As Boolean
            Get
                Return strDEL
            End Get
            Set(ByVal value As Boolean)
                strDEL = value
            End Set
        End Property


    End Class
End Namespace