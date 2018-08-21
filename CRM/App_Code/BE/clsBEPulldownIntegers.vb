
Namespace BE
    Public Class clsBEPulldownIntegers
        Private decNos As Decimal
        Public Property Nos() As Decimal
            Get
                Return decNos
            End Get
            Set(ByVal value As Decimal)
                decNos = value
            End Set
        End Property

    End Class
End Namespace
