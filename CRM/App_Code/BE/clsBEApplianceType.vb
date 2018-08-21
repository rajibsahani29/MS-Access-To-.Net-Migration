Namespace BE
    Public Class clsBEApplianceType
        Private intATypeID As Integer
        Public Property ApplianceTypeID() As Integer
            Get
                Return intATypeID
            End Get
            Set(ByVal value As Integer)
                intATypeID = value
            End Set
        End Property
        Private strAType As String
        Public Property ApplianceType() As String
            Get
                Return strAType
            End Get
            Set(ByVal value As String)
                strAType = value
            End Set
        End Property
        Private blnFlag As Boolean
        Public Property DelFlag() As Boolean
            Get
                Return blnFlag
            End Get
            Set(ByVal value As Boolean)
                blnFlag = value
            End Set
        End Property
    End Class
End Namespace