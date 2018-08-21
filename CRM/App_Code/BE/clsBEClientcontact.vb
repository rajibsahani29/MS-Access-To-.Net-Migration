Imports Microsoft.VisualBasic

Namespace BE
    Public Class clsBEClientcontact
        Private intClientContactId As Integer
        Public Property ClientContactId() As Integer
            Get
                Return intClientContactId
            End Get
            Set(ByVal value As Integer)
                intClientContactId = value
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

        Private strEmail As String
        Public Property Email() As String
            Get
                Return strEmail
            End Get
            Set(ByVal value As String)
                strEmail = value
            End Set
        End Property

        Private strDirectLine As String
        Public Property DirectLine() As String
            Get
                Return strDirectLine
            End Get
            Set(ByVal value As String)
                strDirectLine = value
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

    End Class
End Namespace
