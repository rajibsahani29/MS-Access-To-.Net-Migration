Imports Microsoft.VisualBasic


Namespace BE
    Public Class clsBEJobVisit
        Private intVisitHistoryID As Integer
        Public Property VisitHistoryID() As Integer
            Get
                Return intVisitHistoryID
            End Get
            Set(ByVal value As Integer)
                intVisitHistoryID = value
            End Set
        End Property

        Private intJobid As Integer
        Public Property Jobid() As Integer
            Get
                Return intJobid
            End Get
            Set(ByVal value As Integer)
                intJobid = value
            End Set
        End Property

        Private strEngineerFrom As String
        Public Property EngineerFrom() As String
            Get
                Return strEngineerFrom
            End Get
            Set(ByVal value As String)
                strEngineerFrom = value
            End Set
        End Property
        Private strEngineerTo As String
        Public Property EngineerTo() As String
            Get
                Return strEngineerTo
            End Get
            Set(ByVal value As String)
                strEngineerTo = value
            End Set
        End Property

        Private strIssueType As String
        Public Property IssueType() As String
            Get
                Return strIssueType
            End Get
            Set(ByVal value As String)
                strIssueType = value
            End Set
        End Property

        Private dtIssueDate As DateTime
        Public Property IssueDate() As DateTime
            Get
                Return dtIssueDate
            End Get
            Set(ByVal value As DateTime)
                dtIssueDate = value
            End Set
        End Property
        Private dblHoursSpent As Double
        Public Property HoursSpent() As Double
            Get
                Return dblHoursSpent
            End Get
            Set(ByVal value As Double)
                dblHoursSpent = value
            End Set
        End Property
        Private strIssueNotes As String
        Public Property IssueNotes() As String
            Get
                Return strIssueNotes
            End Get
            Set(ByVal value As String)
                strIssueNotes = value
            End Set
        End Property


    End Class
End Namespace
