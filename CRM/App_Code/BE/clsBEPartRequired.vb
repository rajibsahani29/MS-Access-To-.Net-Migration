Namespace BE
    Public Class clsBEPartRequired
        Private intID As Integer
        Public Property ID() As Integer
            Get
                Return intID
            End Get
            Set(ByVal value As Integer)
                intID = value
            End Set
        End Property
        Private intJOBID As Integer
        Public Property JOBID() As Integer
            Get
                Return intJOBID
            End Get
            Set(ByVal value As Integer)
                intJOBID = value
            End Set
        End Property
        Private intqty As Integer
        Public Property Quantity() As Integer
            Get
                Return intqty
            End Get
            Set(ByVal value As Integer)
                intqty = value
            End Set
        End Property
        Private strPartDetail As String
        Public Property PartDetail() As String
            Get
                Return strPartDetail
            End Get
            Set(ByVal value As String)
                strPartDetail = value
            End Set
        End Property
    End Class
End Namespace
