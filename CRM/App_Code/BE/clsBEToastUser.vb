
Namespace BE
    Public Class clsBEToastUser
        Private intToastId As Integer
        Public Property ToastId() As Integer
            Get
                Return intToastId
            End Get
            Set(ByVal value As Integer)
                intToastId = value
            End Set
        End Property

        Private Intuserid As Integer
        Public Property userid() As Integer
            Get
                Return Intuserid
            End Get
            Set(ByVal value As Integer)
                Intuserid = value
            End Set
        End Property

        Private strClient As String
        Public Property ClientName() As String
            Get
                Return strClient
            End Get
            Set(ByVal value As String)
                strClient = value
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
        Private intJobid As Integer
        Public Property job_id() As Integer
            Get
                Return intJobid
            End Get
            Set(ByVal value As Integer)
                intJobid = value
            End Set
        End Property

        Private dtWhenx As DateTime
        Public Property Whenx() As DateTime
            Get
                Return dtWhenx
            End Get
            Set(ByVal value As DateTime)
                dtWhenx = value
            End Set
        End Property

        Private blnFlag As Boolean
        Public Property Flag() As Boolean
            Get
                Return blnFlag
            End Get
            Set(ByVal value As Boolean)
                blnFlag = value
            End Set
        End Property
    End Class
End Namespace

