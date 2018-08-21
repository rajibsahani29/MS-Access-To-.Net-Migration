Namespace BE
    Public Class clsBEAppliances

        Private intApplianceID As Integer
        Public Property ApplianceID() As Integer
            Get
                Return intApplianceID
            End Get
            Set(ByVal value As Integer)
                intApplianceID = value
            End Set
        End Property
        Private intATypeID As Integer
        Public Property ApplianceTypeID() As Integer
            Get
                Return intATypeID
            End Get
            Set(ByVal value As Integer)
                intATypeID = value
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
        Private strModel As String
        Public Property Model() As String
            Get
                Return strModel
            End Get
            Set(ByVal value As String)
                strModel = value
            End Set
        End Property

        Private strSNumber As String
        Public Property SerialNumber() As String
            Get
                Return strSNumber
            End Get
            Set(ByVal value As String)
                strSNumber = value
            End Set
        End Property

        Private strrefnos As String
        Public Property refnos() As String
            Get
                Return strrefnos
            End Get
            Set(ByVal value As String)
                strrefnos = value
            End Set
        End Property
        Private strDoubler As String
        Public Property Doubler() As String
            Get
                Return strDoubler
            End Get
            Set(ByVal value As String)
                strDoubler = value
            End Set
        End Property

        Private blnFlag As Boolean
        Public Property DellFlag() As Boolean
            Get
                Return blnFlag
            End Get
            Set(ByVal value As Boolean)
                blnFlag = value
            End Set
        End Property

    End Class
End Namespace
