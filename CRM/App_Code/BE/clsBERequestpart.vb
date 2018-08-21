Namespace BE
    Public Class clsBERequestpart
        Private intRequestID As Integer
        Public Property RequestID() As Integer
            Get
                Return intRequestID
            End Get
            Set(ByVal value As Integer)
                intRequestID = value
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

        Private intPartID As Integer
        Public Property PartID() As Integer
            Get
                Return intPartID
            End Get
            Set(ByVal value As Integer)
                intPartID = value
            End Set
        End Property

        Private strEngineersNos As String
        Public Property EngineersNos() As String
            Get
                Return strEngineersNos
            End Get
            Set(ByVal value As String)
                strEngineersNos = value
            End Set
        End Property
        Private intqty As Integer
        Public Property Quantity() As Integer
            Get
                Return intqty
            End Get
            Set(ByVal value As Integer)
                intqty = value
            End Set
        End Property
        Private intReceived As Integer
        Public Property NosRecieved() As Integer
            Get
                Return intReceived
            End Get
            Set(ByVal value As Integer)
                intReceived = value
            End Set
        End Property
        Private strnote As String
        Public Property Notes() As String
            Get
                Return strnote
            End Get
            Set(ByVal value As String)
                strnote = value
            End Set
        End Property
        Private dtArrived As DateTime
        Public Property DateArrived() As DateTime
            Get
                Return dtArrived
            End Get
            Set(ByVal value As DateTime)
                dtArrived = value
            End Set
        End Property
        Private dtsystem As DateTime
        Public Property SystemDatex() As DateTime
            Get
                Return dtsystem
            End Get
            Set(ByVal value As DateTime)
                dtsystem = value
            End Set
        End Property
        Private intOrderid As Integer
        Public Property PartsOrderID() As Integer
            Get
                Return intOrderid
            End Get
            Set(ByVal value As Integer)
                intOrderid = value
            End Set
        End Property

        Private intdis As Integer
        Public Property discount() As Integer
            Get
                Return intdis
            End Get
            Set(ByVal value As Integer)
                intdis = value
            End Set
        End Property

        Private strcost As Decimal
        Public Property cost() As Decimal
            Get
                Return strcost
            End Get
            Set(ByVal value As Decimal)
                strcost = value
            End Set
        End Property

        Private blndeleteX As Boolean
        Public Property deletex() As Boolean
            Get
                Return blndeleteX
            End Get
            Set(ByVal value As Boolean)
                blndeleteX = value
            End Set
        End Property
    End Class
End Namespace
