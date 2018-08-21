Namespace BE
    Public Class clsBEParts
        Private intPartID As Integer
        Public Property PartID() As Integer
            Get
                Return intPartID
            End Get
            Set(ByVal value As Integer)
                intPartID = value
            End Set
        End Property
        Private intManufacturerID As Integer
        Public Property ManufacturerID() As Integer
            Get
                Return intManufacturerID
            End Get
            Set(ByVal value As Integer)
                intManufacturerID = value
            End Set
        End Property
        Private intApplianceID As Integer
        Public Property ApplianceID() As Integer
            Get
                Return intApplianceID
            End Get
            Set(ByVal value As Integer)
                intApplianceID = value
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

        Private strPartUse As String
        Public Property PartUse() As String
            Get
                Return strPartUse
            End Get
            Set(ByVal value As String)
                strPartUse = value
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

        Private intLastSupplierID As Integer
        Public Property LastSupplierID() As Integer
            Get
                Return intLastSupplierID
            End Get
            Set(ByVal value As Integer)
                intLastSupplierID = value
            End Set
        End Property
        Private strLastPrice As Decimal
        Public Property LastPrice() As Decimal
            Get
                Return strLastPrice
            End Get
            Set(ByVal value As Decimal)
                strLastPrice = value
            End Set
        End Property
        Private strListPrice As Decimal
        Public Property ManufacturersListPrice() As Decimal
            Get
                Return strListPrice
            End Get
            Set(ByVal value As Decimal)
                strListPrice = value
            End Set
        End Property
        Private dtSellingPrice As DateTime
        Public Property SellingPriceDate() As DateTime
            Get
                Return dtSellingPrice
            End Get
            Set(ByVal value As DateTime)
                dtSellingPrice = value
            End Set
        End Property

        Private strFFFixxSelling As Decimal
        Public Property FastFixxSellingPrice() As Decimal
            Get
                Return strFFFixxSelling
            End Get
            Set(ByVal value As Decimal)
                strFFFixxSelling = value
            End Set
        End Property
        Private dtListPrice As DateTime
        Public Property ListPriceDate() As DateTime
            Get
                Return dtListPrice
            End Get
            Set(ByVal value As DateTime)
                dtListPrice = value
            End Set
        End Property
    End Class
End Namespace
