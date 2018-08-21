Namespace BE
    Public Class clsBECateringSafety
        Private intCateringSafetyId As Integer
        Public Property CateringSafetyId() As Integer
            Get
                Return intCateringSafetyId
            End Get
            Set(ByVal value As Integer)
                intCateringSafetyId = value
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


        Private strExstinguisher As String
        Public Property Exstinguisher() As String
            Get
                Return strExstinguisher
            End Get
            Set(ByVal value As String)
                strExstinguisher = value
            End Set
        End Property

        Private strBlanket As String
        Public Property Blanket() As String
            Get
                Return strBlanket
            End Get
            Set(ByVal value As String)
                strBlanket = value
            End Set
        End Property

        Private strCurrentSafety As String
        Public Property CurrentSafety() As String
            Get
                Return strCurrentSafety
            End Get
            Set(ByVal value As String)
                strCurrentSafety = value
            End Set
        End Property

        Private strLPGSafety As String
        Public Property LPGSafety() As String
            Get
                Return strLPGSafety
            End Get
            Set(ByVal value As String)
                strLPGSafety = value
            End Set
        End Property
    End Class
End Namespace
