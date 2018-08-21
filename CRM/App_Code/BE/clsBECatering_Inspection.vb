Namespace BE
    Public Class clsBECatering_Inspection
        Private intInspectionID As Integer
        Public Property CateringInspectionId() As Integer
            Get
                Return intInspectionID
            End Get
            Set(ByVal value As Integer)
                intInspectionID = value
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

        Private strOperating As String
        Public Property Operating() As String
            Get
                Return strOperating
            End Get
            Set(ByVal value As String)
                strOperating = value
            End Set
        End Property
        Private strSafety As String
        Public Property Safety() As String
            Get
                Return strSafety
            End Get
            Set(ByVal value As String)
                strSafety = value
            End Set
        End Property

        Private strSatisfactory As String
        Public Property Satisfactory() As String
            Get
                Return strSatisfactory
            End Get
            Set(ByVal value As String)
                strSatisfactory = value
            End Set
        End Property

        Private strCondition As String
        Public Property Conditions() As String
            Get
                Return strCondition
            End Get
            Set(ByVal value As String)
                strCondition = value
            End Set
        End Property

        Private strPerformances As String
        Public Property Performances() As String
            Get
                Return strPerformances
            End Get
            Set(ByVal value As String)
                strPerformances = value
            End Set
        End Property

        Private strServiced As String
        Public Property Serviced() As String
            Get
                Return strServiced
            End Get
            Set(ByVal value As String)
                strServiced = value
            End Set
        End Property

        Private strSafeToUse As String
        Public Property SafeToUse() As String
            Get
                Return strSafeToUse
            End Get
            Set(ByVal value As String)
                strSafeToUse = value
            End Set
        End Property

    End Class
End Namespace
