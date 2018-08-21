Imports CRM.BE
Imports CRM.DL
Imports System.Web.Services

Public Class Main
    Inherits System.Web.UI.MasterPage
    Dim objFunction As New clsCommon()
    Dim objBEStaff As clsBEStaff = New clsBEStaff


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If Not objFunction.ValidateLogin() Then
                Response.Redirect("~/login.aspx")
            End If

            If Not Page.IsPostBack Then
                DisablePartOrderSystem()
                DisablePartEditorSystem()
                DisableJobSystem()
                DisableReport()
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try


    End Sub

    Public Sub DisablePartOrderSystem()

        If objFunction.ReturnString(Session("ID")) = "" And Session("ID") Is Nothing And objFunction.ReturnString(Session("NID")) = "" And Session("NID") Is Nothing Then

            partorder1.Attributes.Add("onclick", "return false")
            partorder2.Attributes.Add("onclick", "return false")
            partorder3.Attributes.Add("onclick", "return false")
            partorder4.Attributes.Add("onclick", "return false")
            partorder5.Attributes.Add("onclick", "return false")
            partorder6.Attributes.Add("onclick", "return false")
            'partorder7.Attributes.Add("onclick", "return false")
            partorder8.Attributes.Add("onclick", "return false")
            partorder9.Attributes.Add("onclick", "return false")

        Else
            hdnClickPart.Value = "1"
            partorder1.Attributes.Add("onclick", "return true")
            partorder2.Attributes.Add("onclick", "return true")
            partorder3.Attributes.Add("onclick", "return true")
            partorder4.Attributes.Add("onclick", "return true")
            partorder5.Attributes.Add("onclick", "return true")
            partorder6.Attributes.Add("onclick", "return true")
            'partorder7.Attributes.Add("onclick", "return true")
            partorder8.Attributes.Add("onclick", "return true")
            partorder9.Attributes.Add("onclick", "return true")
        End If
    End Sub

    Public Sub DisablePartEditorSystem()

        If objFunction.ReturnString(Session("PartID")) = "" And Session("PartID") Is Nothing Then

            'parteditor1.Attributes.Add("onclick", "return false")
            'parteditor2.Attributes.Add("onclick", "return false")
            'parteditor3.Attributes.Add("onclick", "return false")
            'parteditor4.Attributes.Add("onclick", "return false")
            'parteditor5.Attributes.Add("onclick", "return false")
            'parteditor6.Attributes.Add("onclick", "return false")

        Else
            hdnClickPartEditor.Value = "1"
            'parteditor1.Attributes.Add("onclick", "return true")
            'parteditor2.Attributes.Add("onclick", "return true")
            'parteditor3.Attributes.Add("onclick", "return true")
            'parteditor4.Attributes.Add("onclick", "return true")
            'parteditor5.Attributes.Add("onclick", "return true")
            'parteditor6.Attributes.Add("onclick", "return true")

        End If
    End Sub

    Public Sub DisableJobSystem()

        If objFunction.ReturnString(Session("JID")) = "" And Session("JID") Is Nothing Then

            job2.Attributes.Add("onclick", "return false")
            job3.Attributes.Add("onclick", "return false")
            job4.Attributes.Add("onclick", "return false")
            job5.Attributes.Add("onclick", "return false")
            job6.Attributes.Add("onclick", "return false")
            job7.Attributes.Add("onclick", "return false")
            job8.Attributes.Add("onclick", "return false")
            job9.Attributes.Add("onclick", "return false")
            job10.Attributes.Add("onclick", "return false")
            job11.Attributes.Add("onclick", "return false")

        Else
            hdnClickJob.Value = "1"
            job2.Attributes.Add("onclick", "return true")
            job3.Attributes.Add("onclick", "return true")
            job4.Attributes.Add("onclick", "return true")
            job5.Attributes.Add("onclick", "return true")
            job6.Attributes.Add("onclick", "return true")
            job7.Attributes.Add("onclick", "return true")
            job8.Attributes.Add("onclick", "return true")
            job9.Attributes.Add("onclick", "return true")
            job10.Attributes.Add("onclick", "return true")
            job11.Attributes.Add("onclick", "return true")


        End If
    End Sub

    Public Sub DisableReport()
        objBEStaff.StaffID = objFunction.ReturnInteger(Session("LoginUserId"))
        Dim objDLStaff As clsDLStaff = New clsDLStaff
        Dim dstLogin As DataSet = objDLStaff.CheckManagementForReport(objBEStaff)
        If objFunction.CheckDataSet(dstLogin) Then
            If (Convert.ToString(dstLogin.Tables(0).Rows(0)("Office")) = "True" And Convert.ToString(dstLogin.Tables(0).Rows(0)("Current")) = "True") Then
                report1.Attributes.Add("onclick", "return true")
                report2.Attributes.Add("onclick", "return true")
                report3.Attributes.Add("onclick", "return true")
                report4.Attributes.Add("onclick", "return true")

            Else
                report1.Attributes.Add("onclick", "return false")
                report2.Attributes.Add("onclick", "return false")
                report3.Attributes.Add("onclick", "return false")
                report4.Attributes.Add("onclick", "return true")

            End If
        End If
    End Sub

End Class