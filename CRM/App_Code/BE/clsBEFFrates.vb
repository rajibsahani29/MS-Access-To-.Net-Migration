
Namespace BE
    Public Class clsBEFFrates
        Private intrateID As Integer
        Public Property rateID() As Integer
            Get
                Return intrateID
            End Get
            Set(ByVal value As Integer)
                intrateID = value
            End Set
        End Property


        Private strRateName As String
        Public Property RateName() As String
            Get
                Return strRateName
            End Get
            Set(ByVal value As String)
                strRateName = value
            End Set
        End Property

        Private strHourlyRate As Decimal
        Public Property HourlyRate() As Decimal
            Get
                Return strHourlyRate
            End Get
            Set(ByVal value As Decimal)
                strHourlyRate = value
            End Set
        End Property

    End Class
End Namespace
