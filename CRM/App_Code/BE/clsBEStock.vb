Namespace BE
    Public Class clsBEStock
        Private intTransactiontID As Integer
        Public Property TransactionID() As Integer
            Get
                Return intTransactiontID
            End Get
            Set(ByVal value As Integer)
                intTransactiontID = value
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
        Private intLocationID As Integer
        Public Property LocationID() As Integer
            Get
                Return intLocationID
            End Get
            Set(ByVal value As Integer)
                intLocationID = value
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
        Private intWithdrawal As Integer
        Public Property WithdrawalAmount() As Integer
            Get
                Return intWithdrawal
            End Get
            Set(ByVal value As Integer)
                intWithdrawal = value
            End Set
        End Property
        Private intDeposit As Integer
        Public Property DepositAmount() As Integer
            Get
                Return intDeposit
            End Get
            Set(ByVal value As Integer)
                intDeposit = value
            End Set
        End Property
        Private intRequestID As Integer
        Public Property RequestID() As Integer
            Get
                Return intRequestID
            End Get
            Set(ByVal value As Integer)
                intRequestID = value
            End Set
        End Property

        Private strDetails As String
        Public Property Details() As String
            Get
                Return strDetails
            End Get
            Set(ByVal value As String)
                strDetails = value
            End Set
        End Property

        Private strEngineers As String
        Public Property EngineersNumber() As String
            Get
                Return strEngineers
            End Get
            Set(ByVal value As String)
                strEngineers = value
            End Set
        End Property


        Private dtStock As DateTime
        Public Property StockDate() As DateTime
            Get
                Return dtStock
            End Get
            Set(ByVal value As DateTime)
                dtStock = value
            End Set
        End Property
    End Class
End Namespace
