Namespace BE
    Public Class clsBEGasInspection
        Private intID As Integer
        Public Property InspectionId() As Integer
            Get
                Return intID
            End Get
            Set(ByVal value As Integer)
                intID = value
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
        Private intEngineerId As Integer
        Public Property EngineerId() As Integer
            Get
                Return intEngineerId
            End Get
            Set(ByVal value As Integer)
                intEngineerId = value
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

        Private strsatisfactory As String
        Public Property satisfactory() As String
            Get
                Return strsatisfactory
            End Get
            Set(ByVal value As String)
                strsatisfactory = value
            End Set
        End Property

        Private strAccesible As String
        Public Property Accesible() As String
            Get
                Return strAccesible
            End Get
            Set(ByVal value As String)
                strAccesible = value
            End Set
        End Property

        Private strsuitable As String
        Public Property suitable() As String
            Get
                Return strsuitable
            End Get
            Set(ByVal value As String)
                strsuitable = value
            End Set
        End Property

        Private strvalve As String
        Public Property valve() As String
            Get
                Return strvalve
            End Get
            Set(ByVal value As String)
                strvalve = value
            End Set
        End Property
        Private strDirection As String
        Public Property Direction() As String
            Get
                Return strDirection
            End Get
            Set(ByVal value As String)
                strDirection = value
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
        Private strautopressure As String
        Public Property autopressure() As String
            Get
                Return strautopressure
            End Get
            Set(ByVal value As String)
                strautopressure = value
            End Set
        End Property
        Private strflameguard As String
        Public Property flameguard() As String
            Get
                Return strflameguard
            End Get
            Set(ByVal value As String)
                strflameguard = value
            End Set
        End Property
        Private strmanual As String
        Public Property manual() As String
            Get
                Return strmanual
            End Get
            Set(ByVal value As String)
                strmanual = value
            End Set
        End Property

        Private strwarning As String
        Public Property warning() As String
            Get
                Return strwarning
            End Get
            Set(ByVal value As String)
                strwarning = value
            End Set
        End Property
        Private strPrimarySafety As String
        Public Property PrimarySafety() As String
            Get
                Return strPrimarySafety
            End Get
            Set(ByVal value As String)
                strPrimarySafety = value
            End Set
        End Property
        Private strPrimaryInterlock As String
        Public Property PrimaryInterlock() As String
            Get
                Return strPrimaryInterlock
            End Get
            Set(ByVal value As String)
                strPrimaryInterlock = value
            End Set
        End Property
        Private strSecondaryInterlock As String
        Public Property SecondaryInterlock() As String
            Get
                Return strSecondaryInterlock
            End Get
            Set(ByVal value As String)
                strSecondaryInterlock = value
            End Set
        End Property
        Private strPrimarySatisfactory As String
        Public Property PrimarySatisfactory() As String
            Get
                Return strPrimarySatisfactory
            End Get
            Set(ByVal value As String)
                strPrimarySatisfactory = value
            End Set
        End Property
        Private strSecondary As String
        Public Property SecondarySatisfactory() As String
            Get
                Return strSecondary
            End Get
            Set(ByVal value As String)
                strSecondary = value
            End Set
        End Property
        Private strmanualover As String
        Public Property manuallyOveridden() As String
            Get
                Return strmanualover
            End Get
            Set(ByVal value As String)
                strmanualover = value
            End Set
        End Property
        Private strApparant As String
        Public Property Apparant() As String
            Get
                Return strApparant
            End Get
            Set(ByVal value As String)
                strApparant = value
            End Set
        End Property
        Private strEvidence As String
        Public Property Evidenceventilation() As String
            Get
                Return strEvidence
            End Get
            Set(ByVal value As String)
                strEvidence = value
            End Set
        End Property
        Private strUnsatisfactory As String
        Public Property Unsatisfactory() As String
            Get
                Return strUnsatisfactory
            End Get
            Set(ByVal value As String)
                strUnsatisfactory = value
            End Set
        End Property
        Private strsign As String
        Public Property signventilation() As String
            Get
                Return strsign
            End Get
            Set(ByVal value As String)
                strsign = value
            End Set
        End Property
        Private strvolume As String
        Public Property volume() As String
            Get
                Return strvolume
            End Get
            Set(ByVal value As String)
                strvolume = value
            End Set
        End Property
        Private strEvidenceSys As String
        Public Property Evidencesystems() As String
            Get
                Return strEvidenceSys
            End Get
            Set(ByVal value As String)
                strEvidenceSys = value
            End Set
        End Property
        Private strSignMaintenance As String
        Public Property SignMaintenance() As String
            Get
                Return strSignMaintenance
            End Get
            Set(ByVal value As String)
                strSignMaintenance = value
            End Set
        End Property
        Private strExtensive As String
        Public Property Extensive() As String
            Get
                Return strExtensive
            End Get
            Set(ByVal value As String)
                strExtensive = value
            End Set
        End Property
        Private strAging As String
        Public Property Aging() As String
            Get
                Return strAging
            End Get
            Set(ByVal value As String)
                strAging = value
            End Set
        End Property
        Private strFitted As String
        Public Property Fitted() As String
            Get
                Return strFitted
            End Get
            Set(ByVal value As String)
                strFitted = value
            End Set
        End Property
        Private strTotal As String
        Public Property TotalScore() As String
            Get
                Return strTotal
            End Get
            Set(ByVal value As String)
                strTotal = value
            End Set
        End Property
        Private dtReceive As DateTime
        Public Property ReceiveDate() As DateTime
            Get
                Return dtReceive
            End Get
            Set(ByVal value As DateTime)
                dtReceive = value
            End Set
        End Property
        Private strCorrect As String
        Public Property CorrectMatterials() As String
            Get
                Return strCorrect
            End Get
            Set(ByVal value As String)
                strCorrect = value
            End Set
        End Property
        Private strIdentified As String
        Public Property Identified() As String
            Get
                Return strIdentified
            End Get
            Set(ByVal value As String)
                strIdentified = value
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
        Private strsleeves As String
        Public Property sleeves() As String
            Get
                Return strsleeves
            End Get
            Set(ByVal value As String)
                strsleeves = value
            End Set
        End Property
        Private strSuitablePurge As String
        Public Property SuitablePurge() As String
            Get
                Return strSuitablePurge
            End Get
            Set(ByVal value As String)
                strSuitablePurge = value
            End Set
        End Property
        Private strAdditinal As String
        Public Property AdditinalIsolation() As String
            Get
                Return strAdditinal
            End Get
            Set(ByVal value As String)
                strAdditinal = value
            End Set
        End Property
        Private strElectrical As String
        Public Property Electrical() As String
            Get
                Return strElectrical
            End Get
            Set(ByVal value As String)
                strElectrical = value
            End Set
        End Property
        Private strProtective As String
        Public Property Protective() As String
            Get
                Return strProtective
            End Get
            Set(ByVal value As String)
                strProtective = value
            End Set
        End Property
        Private strappropiate As String
        Public Property appropiate() As String
            Get
                Return strappropiate
            End Get
            Set(ByVal value As String)
                strappropiate = value
            End Set
        End Property
        Private strCanopy As String
        Public Property CanopySystem() As String
            Get
                Return strCanopy
            End Get
            Set(ByVal value As String)
                strCanopy = value
            End Set
        End Property
        Private strOverhang As String
        Public Property Overhang() As String
            Get
                Return strOverhang
            End Get
            Set(ByVal value As String)
                strOverhang = value
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
        Private strfilterSatisfactory As String
        Public Property filterSatisfactory() As String
            Get
                Return strfilterSatisfactory
            End Get
            Set(ByVal value As String)
                strfilterSatisfactory = value
            End Set
        End Property
        Private strmechanically As String
        Public Property mechanically() As String
            Get
                Return strmechanically
            End Get
            Set(ByVal value As String)
                strmechanically = value
            End Set
        End Property
        Private strnaturally As String
        Public Property naturally() As String
            Get
                Return strnaturally
            End Get
            Set(ByVal value As String)
                strnaturally = value
            End Set
        End Property
        Private strboth As String
        Public Property both() As String
            Get
                Return strboth
            End Get
            Set(ByVal value As String)
                strboth = value
            End Set
        End Property
        Private strMechVentilation As String
        Public Property MechVentilation() As String
            Get
                Return strMechVentilation
            End Get
            Set(ByVal value As String)
                strMechVentilation = value
            End Set
        End Property
        Private strVentilation As String
        Public Property SatisfatoryVentilation() As String
            Get
                Return strVentilation
            End Get
            Set(ByVal value As String)
                strVentilation = value
            End Set
        End Property
        Private stradequate As String
        Public Property adequate() As String
            Get
                Return stradequate
            End Get
            Set(ByVal value As String)
                stradequate = value
            End Set
        End Property
        Private strHigh As String
        Public Property High() As String
            Get
                Return strHigh
            End Get
            Set(ByVal value As String)
                strHigh = value
            End Set
        End Property

        Private strlow As String
        Public Property low() As String
            Get
                Return strlow
            End Get
            Set(ByVal value As String)
                strlow = value
            End Set
        End Property

        Private strCOdetect As String
        Public Property COdetect() As String
            Get
                Return strCOdetect
            End Get
            Set(ByVal value As String)
                strCOdetect = value
            End Set
        End Property

        Private strCO2detect As String
        Public Property CO2detect() As String
            Get
                Return strCO2detect
            End Get
            Set(ByVal value As String)
                strCO2detect = value
            End Set
        End Property

        Private strdetectionInterlock As String
        Public Property detectionInterlock() As String
            Get
                Return strdetectionInterlock
            End Get
            Set(ByVal value As String)
                strdetectionInterlock = value
            End Set
        End Property

        Private strCO2recorded As String
        Public Property CO2recorded() As String
            Get
                Return strCO2recorded
            End Get
            Set(ByVal value As String)
                strCO2recorded = value
            End Set
        End Property

        Private strModel1 As String
        Public Property Model1() As String
            Get
                Return strModel1
            End Get
            Set(ByVal value As String)
                strModel1 = value
            End Set
        End Property
        Private strModel2 As String
        Public Property Model2() As String
            Get
                Return strModel2
            End Get
            Set(ByVal value As String)
                strModel2 = value
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
        Private strcenter As String
        Public Property center() As String
            Get
                Return strcenter
            End Get
            Set(ByVal value As String)
                strcenter = value
            End Set
        End Property
        Private strIdcard As String
        Public Property IdcardNo() As String
            Get
                Return strIdcard
            End Get
            Set(ByVal value As String)
                strIdcard = value
            End Set
        End Property
        Private dtCollabrationDate1 As DateTime
        Public Property CollabrationDate1() As DateTime
            Get
                Return dtCollabrationDate1
            End Get
            Set(ByVal value As DateTime)
                dtCollabrationDate1 = value
            End Set
        End Property
        Private dtCollabrationDate2 As DateTime
        Public Property CollabrationDate2() As DateTime
            Get
                Return dtCollabrationDate2
            End Get
            Set(ByVal value As DateTime)
                dtCollabrationDate2 = value
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
