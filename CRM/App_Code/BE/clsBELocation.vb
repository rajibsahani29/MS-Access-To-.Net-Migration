Namespace BE
    Public Class clsBELocation
        Private intLocationID As Integer
        Public Property LocationID() As Integer
            Get
                Return intLocationID
            End Get
            Set(ByVal value As Integer)
                intLocationID = value
            End Set
        End Property
        Private strtype As String
        Public Property LocationType() As String
            Get
                Return strtype
            End Get
            Set(ByVal value As String)
                strtype = value
            End Set
        End Property

        Private strLocation As String
        Public Property Location() As String
            Get
                Return strLocation
            End Get
            Set(ByVal value As String)
                strLocation = value
            End Set
        End Property
        Private strnote As String
        Public Property Notes() As String
            Get
                Return strnote
            End Get
            Set(ByVal value As String)
                strnote = value
            End Set
        End Property
    End Class

End Namespace
