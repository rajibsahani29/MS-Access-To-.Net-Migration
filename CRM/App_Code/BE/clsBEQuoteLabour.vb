Namespace BE
    Public Class clsBEQuoteLabour
        Private intQuoteLabourID As Integer
        Public Property QuoteLabourID() As Integer
            Get
                Return intQuoteLabourID
            End Get
            Set(ByVal value As Integer)
                intQuoteLabourID = value
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

        Private dblHoursCharged As Double
        Public Property HoursCharged() As Double
            Get
                Return dblHoursCharged
            End Get
            Set(ByVal value As Double)
                dblHoursCharged = value
            End Set
        End Property
        Private strHoursType As String
        Public Property HoursType() As String
            Get
                Return strHoursType
            End Get
            Set(ByVal value As String)
                strHoursType = value
            End Set
        End Property
        Private decrate As Decimal
        Public Property rate() As Decimal
            Get
                Return decrate
            End Get
            Set(ByVal value As Decimal)
                decrate = value
            End Set
        End Property
        Private strComment As String
        Public Property Comment() As String
            Get
                Return strComment
            End Get
            Set(ByVal value As String)
                strComment = value
            End Set
        End Property
        Private intenquireID As Integer
        Public Property enquireID() As Integer
            Get
                Return intenquireID
            End Get
            Set(ByVal value As Integer)
                intenquireID = value
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

        Private strPID As String
        Public Property PID() As String
            Get
                Return strPID
            End Get
            Set(ByVal value As String)
                strPID = value
            End Set
        End Property


    End Class
End Namespace
