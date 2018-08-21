
Namespace BE
    Public Class ClsBEPulldownStatus
        Private strPullDownStatus As String
        Public Property Status() As String
            Get
                Return strPullDownStatus
            End Get
            Set(ByVal value As String)
                strPullDownStatus = value
            End Set
        End Property
    End Class
End Namespace
