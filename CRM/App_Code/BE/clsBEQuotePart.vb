Imports Microsoft.VisualBasic

Namespace BE
    Public Class clsBEQuotePart
        Private intJobPartID As Integer
        Public Property JobPartID() As Integer
            Get
                Return intJobPartID
            End Get
            Set(ByVal value As Integer)
                intJobPartID = value
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

        Private dblqty As Double
        Public Property Quantity() As Double
            Get
                Return dblqty
            End Get
            Set(ByVal value As Double)
                dblqty = value
            End Set
        End Property

        Private decUnitPrice As Decimal
        Public Property UnitPrice() As Decimal
            Get
                Return decUnitPrice
            End Get
            Set(ByVal value As Decimal)
                decUnitPrice = value
            End Set
        End Property
        Private strSupplier As String
        Public Property Supplier() As String
            Get
                Return strSupplier
            End Get
            Set(ByVal value As String)
                strSupplier = value
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
        Private strPartNumber As String
        Public Property PartNumber() As String
            Get
                Return strPartNumber
            End Get
            Set(ByVal value As String)
                strPartNumber = value
            End Set
        End Property

        Private decSellPrice As Decimal
        Public Property SellPrice() As Decimal
            Get
                Return decSellPrice
            End Get
            Set(ByVal value As Decimal)
                decSellPrice = value
            End Set
        End Property

    End Class
End Namespace
