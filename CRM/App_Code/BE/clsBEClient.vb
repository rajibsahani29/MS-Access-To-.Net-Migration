Imports Microsoft.VisualBasic

Namespace BE

    Public Class clsBEClient

        Private intClientId As Integer
        Public Property ClientId() As Integer
            Get
                Return intClientId
            End Get
            Set(ByVal value As Integer)
                intClientId = value
            End Set
        End Property

        Private blnUpliftPayment As Boolean
        Public Property UpliftPayment() As Boolean
            Get
                Return blnUpliftPayment
            End Get
            Set(ByVal value As Boolean)
                blnUpliftPayment = value
            End Set
        End Property

        Private blnOnStop As Boolean
        Public Property OnStop() As Boolean
            Get
                Return blnOnStop
            End Get
            Set(ByVal value As Boolean)
                blnOnStop = value
            End Set
        End Property

        Private intSageNos As Integer
        Public Property SageNos() As Integer
            Get
                Return intSageNos
            End Get
            Set(ByVal value As Integer)
                intSageNos = value
            End Set
        End Property
        Private strCompanyName As String
        Public Property CompanyName() As String
            Get
                Return strCompanyName
            End Get
            Set(ByVal value As String)
                strCompanyName = value
            End Set
        End Property

        Private strContactPosition As String
        Public Property ContactPosition() As String
            Get
                Return strContactPosition
            End Get
            Set(ByVal value As String)
                strContactPosition = value
            End Set
        End Property

        Private strForename As String
        Public Property Forename() As String
            Get
                Return strForename
            End Get
            Set(ByVal value As String)
                strForename = value
            End Set
        End Property
        Private strSurname As String
        Public Property Surname() As String
            Get
                Return strSurname
            End Get
            Set(ByVal value As String)
                strSurname = value
            End Set
        End Property

        Private strPhone As String
        Public Property Phone() As String
            Get
                Return strPhone
            End Get
            Set(ByVal value As String)
                strPhone = value
            End Set
        End Property

        Private strMobileNumber As String
        Public Property MobileNumber() As String
            Get
                Return strMobileNumber
            End Get
            Set(ByVal value As String)
                strMobileNumber = value
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

        Private strAlternativeContactPosition As String
        Public Property AlternativeContactPosition() As String
            Get
                Return strAlternativeContactPosition
            End Get
            Set(ByVal value As String)
                strAlternativeContactPosition = value
            End Set
        End Property

        Private strAlternativeForename As String
        Public Property AlternativeForename() As String
            Get
                Return strAlternativeForename
            End Get
            Set(ByVal value As String)
                strAlternativeForename = value
            End Set
        End Property

        Private strAlternativeSurname As String
        Public Property AlternativeSurname() As String
            Get
                Return strAlternativeSurname
            End Get
            Set(ByVal value As String)
                strAlternativeSurname = value
            End Set
        End Property

        Private strAlternativeEmail As String
        Public Property AlternativeEmail() As String
            Get
                Return strAlternativeEmail
            End Get
            Set(ByVal value As String)
                strAlternativeEmail = value
            End Set
        End Property

        Private strAlternativePhone As String
        Public Property AlternativePhone() As String
            Get
                Return strAlternativePhone
            End Get
            Set(ByVal value As String)
                strAlternativePhone = value
            End Set
        End Property
        Private dblHourlyRate As Double
        Public Property HourlyRate() As Double
            Get
                Return dblHourlyRate
            End Get
            Set(ByVal value As Double)
                dblHourlyRate = value
            End Set
        End Property
        Private strStreet As String
        Public Property Street() As String
            Get
                Return strStreet
            End Get
            Set(ByVal value As String)
                strStreet = value
            End Set
        End Property

        Private strArea As String
        Public Property Area() As String
            Get
                Return strArea
            End Get
            Set(ByVal value As String)
                strArea = value
            End Set
        End Property
        Private strTown As String
        Public Property Town() As String
            Get
                Return strTown
            End Get
            Set(ByVal value As String)
                strTown = value
            End Set
        End Property
        Private strPostcode As String
        Public Property Postcode() As String
            Get
                Return strPostcode
            End Get
            Set(ByVal value As String)
                strPostcode = value
            End Set
        End Property
        Private strFax As String
        Public Property Fax() As String
            Get
                Return strFax
            End Get
            Set(ByVal value As String)
                strFax = value
            End Set
        End Property
        Private blnOnStatementList As Boolean
        Public Property OnStatementList() As Boolean
            Get
                Return blnOnStatementList
            End Get
            Set(ByVal value As Boolean)
                blnOnStatementList = value
            End Set
        End Property
        Private strGroup As String
        Public Property Group() As String
            Get
                Return strGroup
            End Get
            Set(ByVal value As String)
                strGroup = value
            End Set
        End Property
        Private strEntryDate As DateTime
        Public Property EntryDate() As DateTime
            Get
                Return strGroup
            End Get
            Set(ByVal value As DateTime)
                strGroup = value
            End Set
        End Property
        Private strNotes As String
        Public Property Notes() As String
            Get
                Return strNotes
            End Get
            Set(ByVal value As String)
                strNotes = value
            End Set
        End Property
        Private strClientNumber As String
        Public Property ClientNumber() As String
            Get
                Return strClientNumber
            End Get
            Set(ByVal value As String)
                strClientNumber = value
            End Set
        End Property
        Private blnRemittanceSlip As Boolean
        Public Property RemittanceSlip() As Boolean
            Get
                Return blnRemittanceSlip
            End Get
            Set(ByVal value As Boolean)
                blnRemittanceSlip = value
            End Set
        End Property

        Private intFactorNumber As Integer
        Public Property FactorNumber() As Integer
            Get
                Return intFactorNumber
            End Get
            Set(ByVal value As Integer)
                intFactorNumber = value
            End Set
        End Property
        Private blnNullNoJob As Boolean
        Public Property NullNoJob() As Boolean
            Get
                Return blnNullNoJob
            End Get
            Set(ByVal value As Boolean)
                blnNullNoJob = value
            End Set
        End Property

        Private intRateID As Integer
        Public Property RateID() As Integer
            Get
                Return intRateID
            End Get
            Set(ByVal value As Integer)
                intRateID = value
            End Set
        End Property


    End Class

End Namespace
