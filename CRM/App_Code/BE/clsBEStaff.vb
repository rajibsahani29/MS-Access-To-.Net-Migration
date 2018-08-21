Imports Microsoft.VisualBasic

Namespace BE

    Public Class clsBEStaff

#Region "Staff"

        Private intStaffId As Integer
        Public Property StaffID() As Integer
            Get
                Return intStaffId
            End Get
            Set(ByVal value As Integer)
                intStaffId = value
            End Set
        End Property

        Private blnSite As Boolean
        Public Property Site() As Boolean
            Get
                Return blnSite
            End Get
            Set(ByVal value As Boolean)
                blnSite = value
            End Set
        End Property

        Private blnOffice As Boolean
        Public Property Office() As Boolean
            Get
                Return blnOffice
            End Get
            Set(ByVal value As Boolean)
                blnOffice = value
            End Set
        End Property

        Private blnCurrent As Boolean
        Public Property Current() As Boolean
            Get
                Return blnCurrent
            End Get
            Set(ByVal value As Boolean)
                blnCurrent = value
            End Set
        End Property
        Private strTitle As String
        Public Property Title() As String
            Get
                Return strTitle
            End Get
            Set(ByVal value As String)
                strTitle = value
            End Set
        End Property

        Private strFirstName As String
        Public Property FirstName() As String
            Get
                Return strFirstName
            End Get
            Set(ByVal value As String)
                strFirstName = value
            End Set
        End Property

        Private strLastName As String
        Public Property LastName() As String
            Get
                Return strLastName
            End Get
            Set(ByVal value As String)
                strLastName = value
            End Set
        End Property
        Private intEmployeeID As Integer
        Public Property EmployeeID() As Integer
            Get
                Return intEmployeeID
            End Get
            Set(ByVal value As Integer)
                intEmployeeID = value
            End Set
        End Property


        Private strAddress1 As String
        Public Property Address1() As String
            Get
                Return strAddress1
            End Get
            Set(ByVal value As String)
                strAddress1 = value
            End Set
        End Property
        Private strAddress2 As String
        Public Property Address2() As String
            Get
                Return strAddress2
            End Get
            Set(ByVal value As String)
                strAddress2 = value
            End Set
        End Property

        Private strCity As String
        Public Property City() As String
            Get
                Return strCity
            End Get
            Set(ByVal value As String)
                strCity = value
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
        Private strEmail As String
        Public Property Email() As String
            Get
                Return strEmail
            End Get
            Set(ByVal value As String)
                strEmail = value
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
        Private strGender As String
        Public Property Gender() As String
            Get
                Return strGender
            End Get
            Set(ByVal value As String)
                strGender = value
            End Set
        End Property
        Private strFile As String
        Public Property File() As String
            Get
                Return strFile
            End Get
            Set(ByVal value As String)
                strFile = value
            End Set
        End Property
        Private dtDOB As DateTime
        Public Property DOB() As DateTime
            Get
                Return dtDOB
            End Get
            Set(ByVal value As DateTime)
                dtDOB = value
            End Set
        End Property
        Private strPath As String
        Public Property Path() As String
            Get
                Return strPath
            End Get
            Set(ByVal value As String)
                strPath = value
            End Set
        End Property
        Private blnEngineer As Boolean
        Public Property Engineer() As Boolean
            Get
                Return blnEngineer
            End Get
            Set(ByVal value As Boolean)
                blnEngineer = value
            End Set
        End Property
        Private intTeamID As Integer
        Public Property TeamID() As Integer
            Get
                Return intTeamID
            End Get
            Set(ByVal value As Integer)
                intTeamID = value
            End Set
        End Property
        Private dtBirthDate As DateTime
        Public Property BirthDate() As DateTime
            Get
                Return dtBirthDate
            End Get
            Set(ByVal value As DateTime)
                dtBirthDate = value
            End Set
        End Property
        Private dtHireDate As DateTime
        Public Property HireDate() As DateTime
            Get
                Return dtHireDate
            End Get
            Set(ByVal value As DateTime)
                dtHireDate = value
            End Set
        End Property
        Private strRegion As String
        Public Property Region() As String
            Get
                Return strRegion
            End Get
            Set(ByVal value As String)
                strRegion = value
            End Set
        End Property
        Private strPostalCode As String
        Public Property PostalCode() As String
            Get
                Return strPostalCode
            End Get
            Set(ByVal value As String)
                strPostalCode = value
            End Set
        End Property
        Private strCountry As String
        Public Property Country() As String
            Get
                Return strCountry
            End Get
            Set(ByVal value As String)
                strCountry = value
            End Set
        End Property
        Private strHomePhone As String
        Public Property HomePhone() As String
            Get
                Return strHomePhone
            End Get
            Set(ByVal value As String)
                strHomePhone = value
            End Set
        End Property
        Private strMobilePhone As String
        Public Property MobilePhone() As String
            Get
                Return strMobilePhone
            End Get
            Set(ByVal value As String)
                strMobilePhone = value
            End Set
        End Property
        Private strHomeEmail As String
        Public Property HomeEmail() As String
            Get
                Return strHomeEmail
            End Get
            Set(ByVal value As String)
                strHomeEmail = value
            End Set
        End Property
        Private strPhoto As String
        Public Property Photo() As String
            Get
                Return strPhoto
            End Get
            Set(ByVal value As String)
                strPhoto = value
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
        Private strDriving As String
        Public Property Driving() As String
            Get
                Return strDriving
            End Get
            Set(ByVal value As String)
                strDriving = value
            End Set
        End Property
        Private strNextofKin As String
        Public Property NextofKin() As String
            Get
                Return strNextofKin
            End Get
            Set(ByVal value As String)
                strNextofKin = value
            End Set
        End Property
        Private strNoKname As String
        Public Property NoKname() As String
            Get
                Return strNoKname
            End Get
            Set(ByVal value As String)
                strNoKname = value
            End Set
        End Property
        Private strNoKaddress As String
        Public Property NoKaddress() As String
            Get
                Return strNoKaddress
            End Get
            Set(ByVal value As String)
                strNoKaddress = value
            End Set
        End Property
        Private strNokphone As String
        Public Property Nokphone() As String
            Get
                Return strNokphone
            End Get
            Set(ByVal value As String)
                strNokphone = value
            End Set
        End Property
        Private intEmloyeeMTNo As Integer
        Public Property EmloyeeMTNo() As Integer
            Get
                Return intEmloyeeMTNo
            End Get
            Set(ByVal value As Integer)
                intEmloyeeMTNo = value
            End Set
        End Property

        Private strPassword As String
        Public Property Password() As String
            Get
                Return strPassword
            End Get
            Set(ByVal value As String)
                strPassword = value
            End Set
        End Property

        Private blnPCuser As Boolean
        Public Property PCuser() As Boolean
            Get
                Return blnPCuser
            End Get
            Set(ByVal value As Boolean)
                blnPCuser = value
            End Set
        End Property
        Private strUsername As String
        Public Property UserName() As String
            Get
                Return strUsername
            End Get
            Set(ByVal value As String)
                strUsername = value
            End Set
        End Property
        Private strRNumber As String
        Public Property RandomCode() As String
            Get
                Return strRNumber
            End Get
            Set(ByVal value As String)
                strRNumber = value
            End Set
        End Property
        Private strOldPwd As String
        Public Property OldPassword() As String
            Get
                Return strOldPwd
            End Get
            Set(ByVal value As String)
                strOldPwd = value
            End Set
        End Property
#End Region



    End Class

End Namespace


