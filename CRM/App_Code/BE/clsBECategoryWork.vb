Namespace BE
    Public Class clsBECategoryWork
        Private intCateringWorkId As Integer
        Public Property CateringWorkId() As Integer
            Get
                Return intCateringWorkId
            End Get
            Set(ByVal value As Integer)
                intCateringWorkId = value
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

        Private strDefects As String
        Public Property Defects() As String
            Get
                Return strDefects
            End Get
            Set(ByVal value As String)
                strDefects = value
            End Set
        End Property

        Private strwarnings As String
        Public Property warnings() As String
            Get
                Return strwarnings
            End Get
            Set(ByVal value As String)
                strwarnings = value
            End Set
        End Property

        Private strRemedicals As String
        Public Property Remedicals() As String
            Get
                Return strRemedicals
            End Get
            Set(ByVal value As String)
                strRemedicals = value
            End Set
        End Property

        Private strWorkDetails As String
        Public Property WorkDetails() As String
            Get
                Return strWorkDetails
            End Get
            Set(ByVal value As String)
                strWorkDetails = value
            End Set
        End Property

    End Class

End Namespace
