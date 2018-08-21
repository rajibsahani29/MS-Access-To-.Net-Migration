Imports Microsoft.VisualBasic

Namespace BE
    Public Class clsBECallList
        Private intenquireID As Integer
        Public Property enquireID() As Integer
            Get
                Return intenquireID
            End Get
            Set(ByVal value As Integer)
                intenquireID = value
            End Set
        End Property

        Private intJobID As Integer
        Public Property JobID() As Integer
            Get
                Return intJobID
            End Get
            Set(ByVal value As Integer)
                intJobID = value
            End Set
        End Property
        Private dtReportDate As DateTime
        Public Property ReportDate() As DateTime
            Get
                Return dtReportDate
            End Get
            Set(ByVal value As DateTime)
                dtReportDate = value
            End Set
        End Property
        Private dtRequiredDate As DateTime
        Public Property RequiredDate() As DateTime
            Get
                Return dtRequiredDate
            End Get
            Set(ByVal value As DateTime)
                dtRequiredDate = value
            End Set
        End Property
        Private dtSignOffDate As DateTime
        Public Property SignOffDate() As DateTime
            Get
                Return dtSignOffDate
            End Get
            Set(ByVal value As DateTime)
                dtSignOffDate = value
            End Set
        End Property

        Private intStaffTakenBy As Integer
        Public Property StaffTakenBy() As Integer
            Get
                Return intStaffTakenBy
            End Get
            Set(ByVal value As Integer)
                intStaffTakenBy = value
            End Set
        End Property
        Private intStaffFor As Integer
        Public Property StaffFor() As Integer
            Get
                Return intStaffFor
            End Get
            Set(ByVal value As Integer)
                intStaffFor = value
            End Set
        End Property

        Private intContactInOrganisation As Integer
        Public Property ContactInOrganisation() As Integer
            Get
                Return intContactInOrganisation
            End Get
            Set(ByVal value As Integer)
                intContactInOrganisation = value
            End Set
        End Property
        Private strStatus As String
        Public Property Status() As String
            Get
                Return strStatus
            End Get
            Set(ByVal value As String)
                strStatus = value
            End Set
        End Property

        Private strReportedAs As String
        Public Property ReportedAs() As String
            Get
                Return strReportedAs
            End Get
            Set(ByVal value As String)
                strReportedAs = value
            End Set
        End Property

        Private strActionTaken As String
        Public Property ActionTaken() As String
            Get
                Return strActionTaken
            End Get
            Set(ByVal value As String)
                strActionTaken = value
            End Set
        End Property

        Private strType As String
        Public Property Type() As String
            Get
                Return strType
            End Get
            Set(ByVal value As String)
                strType = value
            End Set
        End Property

        Private strWhatFor As String
        Public Property WhatFor() As String
            Get
                Return strWhatFor
            End Get
            Set(ByVal value As String)
                strWhatFor = value
            End Set
        End Property

        Private decCostToFF As Decimal
        Public Property CostToFF() As Decimal
            Get
                Return decCostToFF
            End Get
            Set(ByVal value As Decimal)
                decCostToFF = value
            End Set
        End Property

        Private decFFSellPrice As Decimal
        Public Property FF_Sell_Price() As Decimal
            Get
                Return decFFSellPrice
            End Get
            Set(ByVal value As Decimal)
                decFFSellPrice = value
            End Set
        End Property
        Private intPartID As Integer
        Public Property PartID() As Integer
            Get
                Return intPartID
            End Get
            Set(ByVal value As Integer)
                intPartID = value
            End Set
        End Property

        Private intQuantity As Integer
        Public Property Quantity() As Integer
            Get
                Return intQuantity
            End Get
            Set(ByVal value As Integer)
                intQuantity = value
            End Set
        End Property
        Private blnAddToQuote As Boolean
        Public Property AddToQuote() As Boolean
            Get
                Return blnAddToQuote
            End Get
            Set(ByVal value As Boolean)
                blnAddToQuote = value
            End Set
        End Property

    End Class
End Namespace
