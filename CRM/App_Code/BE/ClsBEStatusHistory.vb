Namespace BE
    Public Class ClsBEStatusHistory
        Private intStatusHistoryID As Integer
        Public Property StatusHistoryID() As Integer
            Get
                Return intStatusHistoryID
            End Get
            Set(ByVal value As Integer)
                intStatusHistoryID = value
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

        Private strFrom As String
        Public Property From() As String
            Get
                Return strFrom
            End Get
            Set(ByVal value As String)
                strFrom = value
            End Set
        End Property
        Private strTo As String
        Public Property ToStatus() As String
            Get
                Return strTo
            End Get
            Set(ByVal value As String)
                strTo = value
            End Set
        End Property
        Private dtdate As DateTime
        Public Property TodayDate() As DateTime
            Get
                Return dtdate
            End Get
            Set(ByVal value As DateTime)
                dtdate = value
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
