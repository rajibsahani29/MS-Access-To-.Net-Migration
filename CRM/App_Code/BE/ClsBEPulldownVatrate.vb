Namespace BE
    Public Class ClsBEPulldownVatrate
        Private dblVATRATE As Double
        Public Property VATRATE() As Double
            Get
                Return dblVATRATE
            End Get
            Set(ByVal value As Double)
                dblVATRATE = value
            End Set
        End Property


        Private dblVATRATE1 As Double
        Public Property VATRATEP() As Double
            Get
                Return dblVATRATE1
            End Get
            Set(ByVal value As Double)
                dblVATRATE1 = value
            End Set
        End Property
    End Class
End Namespace
