Namespace BE
    Public Class clsBEAudit

        Private intID As Integer
        Public Property AuditTrailID() As Integer
            Get
                Return intID
            End Get
            Set(ByVal value As Integer)
                intID = value
            End Set
        End Property


        Private strName As String
        Public Property UserName() As String
            Get
                Return strName
            End Get
            Set(ByVal value As String)
                strName = value
            End Set
        End Property
    End Class
End Namespace