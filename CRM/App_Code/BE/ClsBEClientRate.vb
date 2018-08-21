Namespace BE
    Public Class ClsBEClientRate
        Private intId As Integer
        Public Property Id() As Integer
            Get
                Return intId
            End Get
            Set(ByVal value As Integer)
                intId = value
            End Set
        End Property

        Private intClientId As Integer
        Public Property ClientId() As Integer
            Get
                Return intClientId
            End Get
            Set(ByVal value As Integer)
                intClientId = value
            End Set
        End Property

        Private intrateID As Integer
        Public Property rateID() As Integer
            Get
                Return intrateID
            End Get
            Set(ByVal value As Integer)
                intrateID = value
            End Set
        End Property

    End Class
End Namespace
