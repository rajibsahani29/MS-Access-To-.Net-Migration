Namespace BE
    Public Class clsBENotes
        Private intNotesID As Integer
        Public Property JobNotesID() As Integer
            Get
                Return intNotesID
            End Get
            Set(ByVal value As Integer)
                intNotesID = value
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

        Private strNotes As String
        Public Property Notes() As String
            Get
                Return strNotes
            End Get
            Set(ByVal value As String)
                strNotes = value
            End Set
        End Property
        Private dtNote As DateTime
        Public Property NoteDate() As DateTime
            Get
                Return dtNote
            End Get
            Set(ByVal value As DateTime)
                dtNote = value
            End Set
        End Property
        Private strByPC As String
        Public Property RecordedByPC() As String
            Get
                Return strByPC
            End Get
            Set(ByVal value As String)
                strByPC = value
            End Set
        End Property

        Private strByUser As String
        Public Property RecordedByUser() As String
            Get
                Return strByUser
            End Get
            Set(ByVal value As String)
                strByUser = value
            End Set
        End Property
    End Class
End Namespace
