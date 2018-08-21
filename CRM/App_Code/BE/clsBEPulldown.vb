Imports Microsoft.VisualBasic

Namespace BE
    Public Class clsBEPulldown
#Region "Pulldown"

        Private intPullDownID As Integer
        Public Property PullDownID() As Integer
            Get
                Return intPullDownID
            End Get
            Set(ByVal value As Integer)
                intPullDownID = value
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

        Private strLable As String
        Public Property Lable() As String
            Get
                Return strLable
            End Get
            Set(ByVal value As String)
                strLable = value
            End Set
        End Property
        Private blnDisplay As Boolean
        Public Property Display() As Boolean
            Get
                Return blnDisplay
            End Get
            Set(ByVal value As Boolean)
                blnDisplay = value
            End Set
        End Property

#End Region
    End Class
End Namespace
