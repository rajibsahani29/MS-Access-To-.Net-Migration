Namespace BE
    Public Class clsBECateringAppliance

        Private intCateringAppId As Integer
        Public Property CateringAppId() As Integer
            Get
                Return intCateringAppId
            End Get
            Set(ByVal value As Integer)
                intCateringAppId = value
            End Set
        End Property

        Private intID As Integer
        Public Property CateringId() As Integer
            Get
                Return intID
            End Get
            Set(ByVal value As Integer)
                intID = value
            End Set
        End Property
        Private strApplianceType As String
        Public Property ApplianceType() As String
            Get
                Return strApplianceType
            End Get
            Set(ByVal value As String)
                strApplianceType = value
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

        Private strApplianceMake As String
        Public Property ApplianceMake() As String
            Get
                Return strApplianceMake
            End Get
            Set(ByVal value As String)
                strApplianceMake = value
            End Set
        End Property
        Private strSerialNo As String
        Public Property SerialNo() As String
            Get
                Return strSerialNo
            End Get
            Set(ByVal value As String)
                strSerialNo = value
            End Set
        End Property

        Private strFlueType As String
        Public Property FlueType() As String
            Get
                Return strFlueType
            End Get
            Set(ByVal value As String)
                strFlueType = value
            End Set
        End Property

        Private strApplianceSecure As String
        Public Property ApplianceSecure() As String
            Get
                Return strApplianceSecure
            End Get
            Set(ByVal value As String)
                strApplianceSecure = value
            End Set
        End Property

        Private strIsolationValve As String
        Public Property IsolationValve() As String
            Get
                Return strIsolationValve
            End Get
            Set(ByVal value As String)
                strIsolationValve = value
            End Set
        End Property
    End Class
End Namespace
