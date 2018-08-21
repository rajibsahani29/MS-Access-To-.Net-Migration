Namespace BE
    Public Class clsBESupplier
        Private intSupplierID As Integer
        Public Property SupplierID() As Integer
            Get
                Return intSupplierID
            End Get
            Set(ByVal value As Integer)
                intSupplierID = value
            End Set
        End Property
        Private strSupplier As String
        Public Property SupplierName() As String
            Get
                Return strSupplier
            End Get
            Set(ByVal value As String)
                strSupplier = value
            End Set
        End Property

        Private straddress1 As String
        Public Property address1() As String
            Get
                Return straddress1
            End Get
            Set(ByVal value As String)
                straddress1 = value
            End Set
        End Property
        Private straddress2 As String
        Public Property Address2() As String
            Get
                Return straddress2
            End Get
            Set(ByVal value As String)
                straddress2 = value
            End Set
        End Property
        Private strtown As String
        Public Property Town() As String
            Get
                Return strtown
            End Get
            Set(ByVal value As String)
                strtown = value
            End Set
        End Property
        Private strpostcode As String
        Public Property postcode() As String
            Get
                Return strpostcode
            End Get
            Set(ByVal value As String)
                strpostcode = value
            End Set
        End Property

        Private strphone As String
        Public Property phone() As String
            Get
                Return strphone
            End Get
            Set(ByVal value As String)
                strphone = value
            End Set
        End Property

        Private strNotes As String
        Public Property Notes() As String
            Get
                Return strphone
            End Get
            Set(ByVal value As String)
                strNotes = value
            End Set
        End Property
        Private strEmail As String
        Public Property Email() As String
            Get
                Return strEmail
            End Get
            Set(ByVal value As String)
                strEmail = value
            End Set
        End Property
    End Class
End Namespace
