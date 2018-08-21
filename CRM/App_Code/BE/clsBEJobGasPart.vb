
Namespace BE
    Public Class clsBEJobGasPart
        Private intJobGasPartId As Integer
        Public Property JobGasPartId() As Integer
            Get
                Return intJobGasPartId
            End Get
            Set(ByVal value As Integer)
                intJobGasPartId = value
            End Set
        End Property
        Private intID As Integer
        Public Property InspectionId() As Integer
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
        Private strApplianceMake As String
        Public Property ApplianceMake() As String
            Get
                Return strApplianceMake
            End Get
            Set(ByVal value As String)
                strApplianceMake = value
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
        Private strManufacturer As String
        Public Property Manufacturer() As String
            Get
                Return strManufacturer
            End Get
            Set(ByVal value As String)
                strManufacturer = value
            End Set
        End Property
        Private strPressure As String
        Public Property Pressure() As String
            Get
                Return strPressure
            End Get
            Set(ByVal value As String)
                strPressure = value
            End Set
        End Property

        Private strHeatInput As String
        Public Property HeatInput() As String
            Get
                Return strHeatInput
            End Get
            Set(ByVal value As String)
                strHeatInput = value
            End Set
        End Property

        Private strMaxCO As String
        Public Property MaxCO() As String
            Get
                Return strMaxCO
            End Get
            Set(ByVal value As String)
                strMaxCO = value
            End Set
        End Property
        Private strMaxCO2 As String
        Public Property MaxCO2() As String
            Get
                Return strMaxCO2
            End Get
            Set(ByVal value As String)
                strMaxCO2 = value
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

        Private strFittedStatus As String
        Public Property FittedStatus() As String
            Get
                Return strFittedStatus
            End Get
            Set(ByVal value As String)
                strFittedStatus = value
            End Set
        End Property

        Private strIsolator As String
        Public Property Isolator() As String
            Get
                Return strIsolator
            End Get
            Set(ByVal value As String)
                strIsolator = value
            End Set
        End Property
        Private strFSDFitted As String
        Public Property FSDFitted() As String
            Get
                Return strFSDFitted
            End Get
            Set(ByVal value As String)
                strFSDFitted = value
            End Set
        End Property

        Private strFSDOperating As String
        Public Property FSDOperating() As String
            Get
                Return strFSDOperating
            End Get
            Set(ByVal value As String)
                strFSDOperating = value
            End Set
        End Property
        Private strPipework As String
        Public Property Pipework() As String
            Get
                Return strPipework
            End Get
            Set(ByVal value As String)
                strPipework = value
            End Set
        End Property
        Private strSafety As String
        Public Property Safety() As String
            Get
                Return strSafety
            End Get
            Set(ByVal value As String)
                strSafety = value
            End Set
        End Property
        Private strDefects As String
        Public Property Defects() As String
            Get
                Return strDefects
            End Get
            Set(ByVal value As String)
                strDefects = value
            End Set
        End Property
        Private strWarning As String
        Public Property Warning() As String
            Get
                Return strWarning
            End Get
            Set(ByVal value As String)
                strWarning = value
            End Set
        End Property

        Private strRemedical As String
        Public Property Remedical() As String
            Get
                Return strRemedical
            End Get
            Set(ByVal value As String)
                strRemedical = value
            End Set
        End Property
        Private strDetails As String
        Public Property Details() As String
            Get
                Return strDetails
            End Get
            Set(ByVal value As String)
                strDetails = value
            End Set
        End Property
    End Class
End Namespace
