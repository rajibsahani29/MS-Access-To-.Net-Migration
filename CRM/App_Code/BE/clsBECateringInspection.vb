Namespace BE
    Public Class clsBECateringInspection
        Private intID As Integer
        Public Property CateringId() As Integer
            Get
                Return intID
            End Get
            Set(ByVal value As Integer)
                intID = value
            End Set
        End Property
        Private intEngineerId As Integer
        Public Property EngineerId() As Integer
            Get
                Return intEngineerId
            End Get
            Set(ByVal value As Integer)
                intEngineerId = value
            End Set
        End Property
        Private intJobId As Integer
        Public Property JobId() As Integer
            Get
                Return intJobId
            End Get
            Set(ByVal value As Integer)
                intJobId = value
            End Set
        End Property
        Private intClientId As Integer
        Public Property ClientId() As Integer
            Get
                Return intClientId
            End Get
            Set(ByVal value As Integer)
                intClientId = value
            End Set
        End Property
        Private strRegNo As String
        Public Property RegNo() As String
            Get
                Return strRegNo
            End Get
            Set(ByVal value As String)
                strRegNo = value
            End Set
        End Property
        Private strType As String
        Public Property Type() As String
            Get
                Return strType
            End Get
            Set(ByVal value As String)
                strType = value
            End Set
        End Property

        Private strAppliancesTested As String
        Public Property AppliancesTested() As String
            Get
                Return strAppliancesTested
            End Get
            Set(ByVal value As String)
                strAppliancesTested = value
            End Set
        End Property

        Private strLPG As String
        Public Property LPG() As String
            Get
                Return strLPG
            End Get
            Set(ByVal value As String)
                strLPG = value
            End Set
        End Property

        Private strEmergency As String
        Public Property Emergency() As String
            Get
                Return strEmergency
            End Get
            Set(ByVal value As String)
                strEmergency = value
            End Set
        End Property
        Private strinstallation As String
        Public Property installation() As String
            Get
                Return strinstallation
            End Get
            Set(ByVal value As String)
                strinstallation = value
            End Set
        End Property

        Private strTightness As String
        Public Property Tightness() As String
            Get
                Return strTightness
            End Get
            Set(ByVal value As String)
                strTightness = value
            End Set
        End Property

        Private strOperatingPressure As String
        Public Property OperatingPressure() As String
            Get
                Return strOperatingPressure
            End Get
            Set(ByVal value As String)
                strOperatingPressure = value
            End Set
        End Property

        Private strLockupPressure As String
        Public Property LockupPressure() As String
            Get
                Return strLockupPressure
            End Get
            Set(ByVal value As String)
                strLockupPressure = value
            End Set
        End Property

        Private strReceive As String
        Public Property ReceivedBy() As String
            Get
                Return strReceive
            End Get
            Set(ByVal value As String)
                strReceive = value
            End Set
        End Property
        Private strPrintName As String
        Public Property PrintName() As String
            Get
                Return strPrintName
            End Get
            Set(ByVal value As String)
                strPrintName = value
            End Set
        End Property
        Private strIssuedBy As String
        Public Property IssuedBy() As String
            Get
                Return strIssuedBy
            End Get
            Set(ByVal value As String)
                strIssuedBy = value
            End Set
        End Property
        Private strIdcard As String
        Public Property IdCardNo() As String
            Get
                Return strIdcard
            End Get
            Set(ByVal value As String)
                strIdcard = value
            End Set
        End Property

        Private dtIssued As DateTime
        Public Property IssuedDate() As DateTime
            Get
                Return dtIssued
            End Get
            Set(ByVal value As DateTime)
                dtIssued = value
            End Set
        End Property
    End Class
End Namespace
