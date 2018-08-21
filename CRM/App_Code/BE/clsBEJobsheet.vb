
Namespace BE
    Public Class clsBEJobsheet
        Private intID As Integer
        Public Property Id() As Integer
            Get
                Return intID
            End Get
            Set(ByVal value As Integer)
                intID = value
            End Set
        End Property
        Private intJobID As Integer
        Public Property JOBID() As Integer
            Get
                Return intJobID
            End Get
            Set(ByVal value As Integer)
                intJobID = value
            End Set
        End Property
        Private intClientId As Integer
        Public Property clientId() As Integer
            Get
                Return intClientId
            End Get
            Set(ByVal value As Integer)
                intClientId = value
            End Set
        End Property
        Private strCustomer As String
        Public Property Customername() As String
            Get
                Return strCustomer
            End Get
            Set(ByVal value As String)
                strCustomer = value
            End Set
        End Property
        Private straddress As String
        Public Property address() As String
            Get
                Return straddress
            End Get
            Set(ByVal value As String)
                straddress = value
            End Set
        End Property

        Private strOrderNumber As String
        Public Property OrderNumber() As String
            Get
                Return strOrderNumber
            End Get
            Set(ByVal value As String)
                strOrderNumber = value
            End Set
        End Property
        Private strJobNumber As String
        Public Property JobNumber() As String
            Get
                Return strJobNumber
            End Get
            Set(ByVal value As String)
                strJobNumber = value
            End Set
        End Property
        Private intInvNo As String
        Public Property InvoiceNumber() As String
            Get
                Return intInvNo
            End Get
            Set(ByVal value As String)
                intInvNo = value
            End Set
        End Property
        Private strInvoiceTo As String
        Public Property InvoiceTo() As String
            Get
                Return strInvoiceTo
            End Get
            Set(ByVal value As String)
                strInvoiceTo = value
            End Set
        End Property
        Private strServiceType As String
        Public Property ServiceType() As String
            Get
                Return strServiceType
            End Get
            Set(ByVal value As String)
                strServiceType = value
            End Set
        End Property
        Private strPlannedMaintenance As String
        Public Property PlannedMaintenance() As String
            Get
                Return strPlannedMaintenance
            End Get
            Set(ByVal value As String)
                strPlannedMaintenance = value
            End Set
        End Property

        Private strEquipmentIdentification As String
        Public Property EquipmentIdentification() As String
            Get
                Return strEquipmentIdentification
            End Get
            Set(ByVal value As String)
                strEquipmentIdentification = value
            End Set
        End Property
        Private strEquipmentInstallation As String
        Public Property EquipmentInstallation() As String
            Get
                Return strEquipmentInstallation
            End Get
            Set(ByVal value As String)
                strEquipmentInstallation = value
            End Set
        End Property
        Private strAppliance As String
        Public Property Appliance() As String
            Get
                Return strAppliance
            End Get
            Set(ByVal value As String)
                strAppliance = value
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
        Private strModel As String
        Public Property Model() As String
            Get
                Return strModel
            End Get
            Set(ByVal value As String)
                strModel = value
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

        Private strAssetNumber As String
        Public Property AssetNumber() As String
            Get
                Return strAssetNumber
            End Get
            Set(ByVal value As String)
                strAssetNumber = value
            End Set
        End Property

        Private strTotalTime As String
        Public Property TotalTime() As String
            Get
                Return strTotalTime
            End Get
            Set(ByVal value As String)
                strTotalTime = value
            End Set
        End Property

        Private strGasLeakTest As String
        Public Property GasLeakTest() As String
            Get
                Return strGasLeakTest
            End Get
            Set(ByVal value As String)
                strGasLeakTest = value
            End Set
        End Property
        Private strEarthTest As String
        Public Property EarthLeakageTest() As String
            Get
                Return strEarthTest
            End Get
            Set(ByVal value As String)
                strEarthTest = value
            End Set
        End Property
        Private strLoadTest As String
        Public Property LoadTest() As String
            Get
                Return strLoadTest
            End Get
            Set(ByVal value As String)
                strLoadTest = value
            End Set
        End Property
        Private strflashTest As String
        Public Property flashTest() As String
            Get
                Return strflashTest
            End Get
            Set(ByVal value As String)
                strflashTest = value
            End Set
        End Property
        Private strInsRes As String
        Public Property InsRes() As String
            Get
                Return strInsRes
            End Get
            Set(ByVal value As String)
                strInsRes = value
            End Set
        End Property
        Private strEC As String
        Public Property EC() As String
            Get
                Return strEC
            End Get
            Set(ByVal value As String)
                strEC = value
            End Set
        End Property

        Private strMicrowaveLeakage As String
        Public Property MicrowaveLeakage() As String
            Get
                Return strMicrowaveLeakage
            End Get
            Set(ByVal value As String)
                strMicrowaveLeakage = value
            End Set
        End Property

        Private strPowerOutput As String
        Public Property PowerOutput() As String
            Get
                Return strPowerOutput
            End Get
            Set(ByVal value As String)
                strPowerOutput = value
            End Set
        End Property
        Private strfault As String
        Public Property fault() As String
            Get
                Return strfault
            End Get
            Set(ByVal value As String)
                strfault = value
            End Set
        End Property

        Private strworkDetails As String
        Public Property workDetails() As String
            Get
                Return strworkDetails
            End Get
            Set(ByVal value As String)
                strworkDetails = value
            End Set
        End Property

        Private intTotalParts As Integer
        Public Property TotalParts() As Integer
            Get
                Return intTotalParts
            End Get
            Set(ByVal value As Integer)
                intTotalParts = value
            End Set
        End Property

        Private intTotalLabour As Integer
        Public Property TotalLabour() As Integer
            Get
                Return intTotalLabour
            End Get
            Set(ByVal value As Integer)
                intTotalLabour = value
            End Set
        End Property
        Private dblCharge As Double
        Public Property charges() As Double
            Get
                Return dblCharge
            End Get
            Set(ByVal value As Double)
                dblCharge = value
            End Set
        End Property
        Private dblSubTotal As Double
        Public Property SubTotal() As Double
            Get
                Return dblSubTotal
            End Get
            Set(ByVal value As Double)
                dblSubTotal = value
            End Set
        End Property
        Private dblVat As Double
        Public Property Vat() As Double
            Get
                Return dblVat
            End Get
            Set(ByVal value As Double)
                dblVat = value
            End Set
        End Property
        Private dblTotalIncVat As Double
        Public Property TotalIncVat() As Double
            Get
                Return dblTotalIncVat
            End Get
            Set(ByVal value As Double)
                dblTotalIncVat = value
            End Set
        End Property
        Private strchargeble As String
        Public Property ChargeableStatus() As String
            Get
                Return strchargeble
            End Get
            Set(ByVal value As String)
                strchargeble = value
            End Set
        End Property
        Private strwarranty As String
        Public Property warrantyStatus() As String
            Get
                Return strwarranty
            End Get
            Set(ByVal value As String)
                strwarranty = value
            End Set
        End Property
        Private strcomplete As String
        Public Property JobCompleteStatus() As String
            Get
                Return strcomplete
            End Get
            Set(ByVal value As String)
                strcomplete = value
            End Set
        End Property
        Private strReason As String
        Public Property Reason() As String
            Get
                Return strReason
            End Get
            Set(ByVal value As String)
                strReason = value
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
        Private strJobTitle As String
        Public Property JobTitle() As String
            Get
                Return strJobTitle
            End Get
            Set(ByVal value As String)
                strJobTitle = value
            End Set
        End Property
        Private intEngId As Integer
        Public Property Engineerid() As Integer
            Get
                Return intEngId
            End Get
            Set(ByVal value As Integer)
                intEngId = value
            End Set
        End Property
        Private dtWhenx As DateTime
        Public Property Whenx() As DateTime
            Get
                Return dtWhenx
            End Get
            Set(ByVal value As DateTime)
                dtWhenx = value
            End Set
        End Property

        Private dtWhenxUpdate As DateTime
        Public Property Whenxupdate() As DateTime
            Get
                Return dtWhenxUpdate
            End Get
            Set(ByVal value As DateTime)
                dtWhenxUpdate = value
            End Set
        End Property

        Private blnAction As Boolean
        Public Property Action_required() As Boolean
            Get
                Return blnAction
            End Get
            Set(ByVal value As Boolean)
                blnAction = value
            End Set
        End Property
    End Class
End Namespace
