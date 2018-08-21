Namespace BE
    Public Class clsBEPEcos
        Private strPECOSCODE As String
        Public Property PECOSCODE() As String
            Get
                Return strPECOSCODE
            End Get
            Set(ByVal value As String)
                strPECOSCODE = value
            End Set
        End Property
        Private strDESCRIPTION As String
        Public Property DESCRIPTION() As String
            Get
                Return strDESCRIPTION
            End Get
            Set(ByVal value As String)
                strDESCRIPTION = value
            End Set
        End Property
        Private blnFFStandard As Boolean
        Public Property FFStandard() As Boolean
            Get
                Return blnFFStandard
            End Get
            Set(ByVal value As Boolean)
                blnFFStandard = value
            End Set
        End Property
    End Class
End Namespace
