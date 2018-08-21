Namespace BE
    Public Class clsBEPartsFitted
        Private intID As Integer
        Public Property ID() As Integer
            Get
                Return intID
            End Get
            Set(ByVal value As Integer)
                intID = value
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
        Private intqty As Integer
        Public Property qty() As Integer
            Get
                Return intqty
            End Get
            Set(ByVal value As Integer)
                intqty = value
            End Set
        End Property
        Private strProductCode As String
        Public Property ProductCode() As String
            Get
                Return strProductCode
            End Get
            Set(ByVal value As String)
                strProductCode = value
            End Set
        End Property

        Private strDescription As String
        Public Property Description() As String
            Get
                Return strDescription
            End Get
            Set(ByVal value As String)
                strDescription = value
            End Set
        End Property

        Private dblprice As Double
        Public Property Partprice() As Double
            Get
                Return dblprice
            End Get
            Set(ByVal value As Double)
                dblprice = value
            End Set
        End Property
    End Class
End Namespace
