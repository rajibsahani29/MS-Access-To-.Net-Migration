Namespace BE
    Public Class clsBEManufacture
        Private intManufacturerId As Integer
        Public Property ManufacturerID() As Integer
            Get
                Return intManufacturerId
            End Get
            Set(ByVal value As Integer)
                intManufacturerId = value
            End Set
        End Property
        Private strname As String
        Public Property ManufacturerName() As String
            Get
                Return strname
            End Get
            Set(ByVal value As String)
                strname = value
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
        Private strPCode1 As String
        Public Property PCode1() As String
            Get
                Return strPCode1
            End Get
            Set(ByVal value As String)
                strPCode1 = value
            End Set
        End Property

        Private strPCode2 As String
        Public Property PCode2() As String
            Get
                Return strPCode2
            End Get
            Set(ByVal value As String)
                strPCode2 = value
            End Set
        End Property

        Private strPhoneNumber As String
        Public Property PhoneNumber() As String
            Get
                Return strPhoneNumber
            End Get
            Set(ByVal value As String)
                strPhoneNumber = value
            End Set
        End Property
        Private strFAX As String
        Public Property FAX() As String
            Get
                Return strFAX
            End Get
            Set(ByVal value As String)
                strFAX = value
            End Set
        End Property
        Private strMobile As String
        Public Property Mobile() As String
            Get
                Return strMobile
            End Get
            Set(ByVal value As String)
                strMobile = value
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
        Private blnDelFlag As Boolean
        Public Property DelFlag() As Boolean
            Get
                Return blnDelFlag
            End Get
            Set(ByVal value As Boolean)
                blnDelFlag = value
            End Set
        End Property
    End Class
End Namespace
