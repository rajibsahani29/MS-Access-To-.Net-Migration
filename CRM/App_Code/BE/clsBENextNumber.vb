
Namespace BE
    Public Class clsBENextNumber

        Private intNextNo As Integer
        Public Property NextNo() As Integer
            Get
                Return intNextNo
            End Get
            Set(ByVal value As Integer)
                intNextNo = value
            End Set
        End Property

    End Class
End Namespace
