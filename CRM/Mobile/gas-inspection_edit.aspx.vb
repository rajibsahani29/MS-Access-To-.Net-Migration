Imports System.Globalization
Imports CRM.BE
Imports CRM.DL
Public Class gas_inspection_edit1
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEGas As clsBEGasInspection = New clsBEGasInspection
    Dim objBEClient As clsBEClient = New clsBEClient
    Dim Status As String
    Dim objBEOrder As clsBEOrder = New clsBEOrder
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If objFunction.ReturnString(Request.QueryString("GasInspectionID")) = "" Or objFunction.ReturnString(Request.QueryString("GasInspectionID")) Is Nothing Then
            Status = "SAVE"
        Else
            Status = "UPDATE"
        End If
        If Not Page.IsPostBack Then
            If Status = "UPDATE" Then
                FillDetails(objFunction.ReturnInteger(Request.QueryString("GasInspectionID")))
            End If
            Dim dstcompany As DataSet = (New clsDLClient()).GetClientFillInDD()
            objFunction.FillDropDownByDataSet(ddlCompany, dstcompany)
            ddlCompany.Items.Insert(0, New ListItem("Select Company", ""))
            objBEOrder.Engineer = objFunction.ReturnString(Session("UserName"))
            objBEOrder.SheetDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
            Dim dstJob As DataSet = (New clsDLOrder()).GetJobIdFillInDD(objBEOrder)
            objFunction.FillDropDownByDataSet(ddlJobId, dstJob)
            ddlJobId.Items.Insert(0, New ListItem("Select JobID", ""))
            btnGo.Enabled = False
        End If
    End Sub

    Public Sub FillDetails(ByVal IntId As Integer)

        Try
            Dim dstList As New DataSet()
            objBEGas.InspectionId = IntId
            dstList = (New clsDLGasInspection()).GetJobsGasDetails(objBEGas)
            If objFunction.CheckDataSet(dstList) Then
                ddlCompany.SelectedValue = objFunction.ReturnString(dstList.Tables(0).Rows(0)("ClientId"))
                ddlJobId.SelectedValue = objFunction.ReturnString(dstList.Tables(0).Rows(0)("JobId"))
                Dim satisfactoryStatus As String = objFunction.ReturnString(dstList.Tables(0).Rows(0)("satisfactory"))
                If (satisfactoryStatus = "Yes") Then
                    RadioButton1.Checked = True
                ElseIf (satisfactoryStatus = "No") Then
                    RadioButton2.Checked = True
                ElseIf (satisfactoryStatus = "N/A") Then
                    RadioButton3.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Accesible")) = "Yes") Then
                    RadioButton4.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Accesible")) = "No") Then
                    RadioButton5.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Accesible")) = "N/A") Then
                    RadioButton6.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("suitable")) = "Yes") Then
                    RadioButton7.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("suitable")) = "No") Then
                    RadioButton8.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("suitable")) = "N/A") Then
                    RadioButton9.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("valve")) = "Yes") Then
                    RadioButton10.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("valve")) = "No") Then
                    RadioButton11.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("valve")) = "N/A") Then
                    RadioButton12.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Direction")) = "Yes") Then
                    RadioButton13.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Direction")) = "No") Then
                    RadioButton14.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Direction")) = "N/A") Then
                    RadioButton15.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Emergency")) = "Yes") Then
                    RadioButton16.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Emergency")) = "No") Then
                    RadioButton17.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Emergency")) = "N/A") Then
                    RadioButton18.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("autopressure")) = "Yes") Then
                    RadioButton19.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("autopressure")) = "No") Then
                    RadioButton20.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("autopressure")) = "N/A") Then
                    RadioButton21.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("flameguard")) = "Yes") Then
                    RadioButton22.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("flameguard")) = "No") Then
                    RadioButton23.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("flameguard")) = "N/A") Then
                    RadioButton24.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("manual")) = "Yes") Then
                    RadioButton25.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("manual")) = "No") Then
                    RadioButton26.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("manual")) = "N/A") Then
                    RadioButton27.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("warning")) = "Yes") Then
                    RadioButton28.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("warning")) = "No") Then
                    RadioButton29.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("warning")) = "N/A") Then
                    RadioButton30.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("PrimarySafety")) = "Yes") Then
                    RadioButton31.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("PrimarySafety")) = "No") Then
                    RadioButton32.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("PrimarySafety")) = "N/A") Then
                    RadioButton33.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("PrimaryInterlock")) = "Yes") Then
                    RadioButton34.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("PrimaryInterlock")) = "No") Then
                    RadioButton35.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("PrimaryInterlock")) = "N/A") Then
                    RadioButton36.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SecondaryInterlock")) = "Yes") Then
                    RadioButton37.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SecondaryInterlock")) = "No") Then
                    RadioButton38.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SecondaryInterlock")) = "N/A") Then
                    RadioButton39.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("PrimarySatisfactory")) = "Yes") Then
                    RadioButton40.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("PrimarySatisfactory")) = "No") Then
                    RadioButton41.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("PrimarySatisfactory")) = "N/A") Then
                    RadioButton42.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SecondarySatisfactory")) = "Yes") Then
                    RadioButton43.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SecondarySatisfactory")) = "No") Then
                    RadioButton44.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SecondarySatisfactory")) = "N/A") Then
                    RadioButton45.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("manuallyOveridden")) = "Yes") Then
                    RadioButton46.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("manuallyOveridden")) = "No") Then
                    RadioButton47.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("manuallyOveridden")) = "N/A") Then
                    RadioButton48.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Apparant")) = "1") Then
                    RadioButton49.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Apparant")) = "2") Then
                    RadioButton50.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Apparant")) = "3") Then
                    RadioButton51.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Apparant")) = "4") Then
                    RadioButton52.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Apparant")) = "5") Then
                    RadioButton53.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Evidenceventilation")) = "1") Then
                    RadioButton54.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Evidenceventilation")) = "2") Then
                    RadioButton55.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Evidenceventilation")) = "3") Then
                    RadioButton56.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Evidenceventilation")) = "4") Then
                    RadioButton57.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Evidenceventilation")) = "5") Then
                    RadioButton58.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Unsatisfactory")) = "1") Then
                    RadioButton59.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Unsatisfactory")) = "2") Then
                    RadioButton60.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Unsatisfactory")) = "3") Then
                    RadioButton61.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Unsatisfactory")) = "4") Then
                    RadioButton62.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Unsatisfactory")) = "5") Then
                    RadioButton63.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("signventilation")) = "1") Then
                    RadioButton64.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("signventilation")) = "2") Then
                    RadioButton65.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("signventilation")) = "3") Then
                    RadioButton66.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("signventilation")) = "4") Then
                    RadioButton67.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("signventilation")) = "5") Then
                    RadioButton68.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("volume")) = "1") Then
                    RadioButton69.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("volume")) = "2") Then
                    RadioButton70.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("volume")) = "3") Then
                    RadioButton71.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("volume")) = "4") Then
                    RadioButton72.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("volume")) = "5") Then
                    RadioButton73.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("volume")) = "1") Then
                    RadioButton69.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("volume")) = "2") Then
                    RadioButton70.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("volume")) = "3") Then
                    RadioButton71.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("volume")) = "4") Then
                    RadioButton72.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("volume")) = "5") Then
                    RadioButton73.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Evidencesystems")) = "1") Then
                    RadioButton74.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Evidencesystems")) = "2") Then
                    RadioButton75.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Evidencesystems")) = "3") Then
                    RadioButton76.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Evidencesystems")) = "4") Then
                    RadioButton77.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Evidencesystems")) = "5") Then
                    RadioButton78.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SignMaintenance")) = "1") Then
                    RadioButton79.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SignMaintenance")) = "2") Then
                    RadioButton80.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SignMaintenance")) = "3") Then
                    RadioButton81.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SignMaintenance")) = "4") Then
                    RadioButton82.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SignMaintenance")) = "5") Then
                    RadioButton83.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Extensive")) = "1") Then
                    RadioButton84.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Extensive")) = "2") Then
                    RadioButton85.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Extensive")) = "3") Then
                    RadioButton86.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Extensive")) = "4") Then
                    RadioButton87.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Extensive")) = "5") Then
                    RadioButton88.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Aging")) = "1") Then
                    RadioButton89.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Aging")) = "2") Then
                    RadioButton90.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Aging")) = "3") Then
                    RadioButton91.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Aging")) = "4") Then
                    RadioButton92.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Aging")) = "5") Then
                    RadioButton93.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Fitted")) = "1") Then
                    RadioButton94.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Fitted")) = "2") Then
                    RadioButton95.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Fitted")) = "3") Then
                    RadioButton96.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Fitted")) = "4") Then
                    RadioButton97.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Fitted")) = "5") Then
                    RadioButton98.Checked = True
                End If

                txtTotal.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("TotalScore"))
                txtReceiveDate.Text = Convert.ToDateTime(dstList.Tables(0).Rows(0)("ReceiveDate")).ToString("dd/MM/yyyy")

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("CorrectMatterials")) = "Yes") Then
                    RadioButton99.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("CorrectMatterials")) = "No") Then
                    RadioButton100.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("CorrectMatterials")) = "N/A") Then
                    RadioButton101.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Identified")) = "Yes") Then
                    RadioButton102.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Identified")) = "No") Then
                    RadioButton103.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Identified")) = "N/A") Then
                    RadioButton104.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Pipework")) = "Yes") Then
                    RadioButton105.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Pipework")) = "No") Then
                    RadioButton106.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Pipework")) = "N/A") Then
                    RadioButton107.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("sleeves")) = "Yes") Then
                    RadioButton108.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("sleeves")) = "No") Then
                    RadioButton109.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("sleeves")) = "N/A") Then
                    RadioButton110.Checked = True
                End If


                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SuitablePurge")) = "Yes") Then
                    RadioButton111.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SuitablePurge")) = "No") Then
                    RadioButton112.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SuitablePurge")) = "N/A") Then
                    RadioButton113.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("AdditinalIsolation")) = "Yes") Then
                    RadioButton114.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("AdditinalIsolation")) = "No") Then
                    RadioButton115.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("AdditinalIsolation")) = "N/A") Then
                    RadioButton116.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Electrical")) = "Yes") Then
                    RadioButton117.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Electrical")) = "No") Then
                    RadioButton118.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Electrical")) = "N/A") Then
                    RadioButton119.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Protective")) = "Yes") Then
                    RadioButton120.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Protective")) = "No") Then
                    RadioButton121.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Protective")) = "N/A") Then
                    RadioButton122.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("appropiate")) = "Yes") Then
                    RadioButton123.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("appropiate")) = "No") Then
                    RadioButton124.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("appropiate")) = "N/A") Then
                    RadioButton125.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("CanopySystem")) = "Yes") Then
                    RadioButton126.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("CanopySystem")) = "No") Then
                    RadioButton127.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("CanopySystem")) = "N/A") Then
                    RadioButton128.Checked = True
                End If


                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Overhang")) = "Yes") Then
                    RadioButton129.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Overhang")) = "No") Then
                    RadioButton130.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Overhang")) = "N/A") Then
                    RadioButton131.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Type")) = "Yes") Then
                    RadioButton132.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Type")) = "No") Then
                    RadioButton133.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Type")) = "N/A") Then
                    RadioButton134.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("filterSatisfactory")) = "Yes") Then
                    RadioButton135.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("filterSatisfactory")) = "No") Then
                    RadioButton136.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("filterSatisfactory")) = "N/A") Then
                    RadioButton137.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("mechanically")) = "Yes") Then
                    RadioButton138.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("mechanically")) = "No") Then
                    RadioButton139.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("mechanically")) = "N/A") Then
                    RadioButton140.Checked = True
                End If


                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("naturally")) = "Yes") Then
                    RadioButton141.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("naturally")) = "No") Then
                    RadioButton142.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("naturally")) = "N/A") Then
                    RadioButton143.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("both")) = "Yes") Then
                    RadioButton144.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("both")) = "No") Then
                    RadioButton145.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("both")) = "N/A") Then
                    RadioButton146.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("MechVentilation")) = "Yes") Then
                    RadioButton147.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("MechVentilation")) = "No") Then
                    RadioButton148.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("MechVentilation")) = "N/A") Then
                    RadioButton149.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SatisfatoryVentilation")) = "Yes") Then
                    RadioButton150.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SatisfatoryVentilation")) = "No") Then
                    RadioButton151.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("SatisfatoryVentilation")) = "N/A") Then
                    RadioButton152.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("adequate")) = "Yes") Then
                    RadioButton153.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("adequate")) = "No") Then
                    RadioButton154.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("adequate")) = "N/A") Then
                    RadioButton155.Checked = True
                End If

                txtProvideDetails1.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("High"))
                txtProvideDetails2.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("low"))

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("COdetect")) = "Yes") Then
                    RadioButton156.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("COdetect")) = "No") Then
                    RadioButton157.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("COdetect")) = "N/A") Then
                    RadioButton158.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("CO2detect")) = "Yes") Then
                    RadioButton159.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("CO2detect")) = "No") Then
                    RadioButton160.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("CO2detect")) = "N/A") Then
                    RadioButton161.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("detectionInterlock")) = "Yes") Then
                    RadioButton162.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("detectionInterlock")) = "No") Then
                    RadioButton163.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("detectionInterlock")) = "N/A") Then
                    RadioButton164.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("CO2recorded")) = "Yes") Then
                    RadioButton165.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("CO2recorded")) = "No") Then
                    RadioButton166.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("CO2recorded")) = "N/A") Then
                    RadioButton167.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("center")) = "Yes") Then
                    RadioButton168.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("center")) = "No") Then
                    RadioButton169.Checked = True
                ElseIf (objFunction.ReturnString(dstList.Tables(0).Rows(0)("center")) = "N/A") Then
                    RadioButton170.Checked = True
                End If

                txtModel1.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Model1"))
                txtModel2.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Model2"))
                txtDate.Text = Convert.ToDateTime(dstList.Tables(0).Rows(0)("CollabrationDate1")).ToString("dd/MM/yyyy")
                txtDate1.Text = Convert.ToDateTime(dstList.Tables(0).Rows(0)("CollabrationDate2")).ToString("dd/MM/yyyy")
                txtReceivedBy.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("ReceivedBy"))
                txtPrintName.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("PrintName"))
                txtIssuedBy.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("IssuedBy"))
                txtIDCard.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("IdcardNo"))
                txtDate2.Text = Convert.ToDateTime(dstList.Tables(0).Rows(0)("IssuedDate")).ToString("dd/MM/yyyy")

            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub



    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try
            Dim satisfactoryStatus As String = ""
            Dim AccesibleStatus As String = ""
            Dim suitStatus As String = ""
            Dim strvalve As String = ""
            Dim strdirection As String = ""
            Dim stremergency As String = ""
            Dim strpressure As String = ""
            Dim strflame As String = ""
            Dim strmanual As String = ""
            Dim strwarning As String = ""
            Dim strsafty As String = ""
            Dim strprimary As String = ""
            Dim strsecondary As String = ""
            Dim strPrimarySatis As String = ""
            Dim strSecondarySatis As String = ""
            Dim strmanualOver As String = ""
            Dim strapparant As String = ""
            Dim strventilation As String = ""
            Dim strunsatisfactory As String = ""
            Dim strsign As String = ""
            Dim strvolume As String = ""
            Dim strevidence As String = ""
            Dim strmaintenance As String = ""
            Dim strcorrect As String = ""
            Dim stridentified As String = ""
            Dim strpipework As String = ""
            Dim strsleeves As String = ""
            Dim strsuitable As String = ""
            Dim strmech As String = ""
            Dim strsatisVentillation As String = ""
            Dim stradequate As String = ""
            Dim strco As String = ""
            Dim strco2 As String = ""
            Dim strdetection As String = ""
            Dim strrecord As String = ""
            Dim strcenter As String = ""

            If RadioButton1.Checked() Then
                satisfactoryStatus = "Yes"
            ElseIf RadioButton2.Checked() Then
                satisfactoryStatus = "No"
            ElseIf RadioButton3.Checked() Then
                satisfactoryStatus = "N/A"
            End If
            If RadioButton4.Checked() Then
                AccesibleStatus = "Yes"
            ElseIf RadioButton5.Checked() Then
                AccesibleStatus = "No"
            ElseIf RadioButton6.Checked() Then
                AccesibleStatus = "N/A"
            End If
            If RadioButton7.Checked() Then
                suitStatus = "Yes"
            ElseIf RadioButton8.Checked() Then
                suitStatus = "No"
            ElseIf RadioButton9.Checked() Then
                suitStatus = "N/A"
            End If

            If RadioButton10.Checked() Then
                strvalve = "Yes"
            ElseIf RadioButton11.Checked() Then
                strvalve = "No"
            ElseIf RadioButton12.Checked() Then
                strvalve = "N/A"
            End If

            If RadioButton13.Checked() Then
                strdirection = "Yes"
            ElseIf RadioButton14.Checked() Then
                strdirection = "No"
            ElseIf RadioButton15.Checked() Then
                strdirection = "N/A"
            End If

            If RadioButton16.Checked() Then
                stremergency = "Yes"
            ElseIf RadioButton17.Checked() Then
                stremergency = "No"
            ElseIf RadioButton18.Checked() Then
                stremergency = "N/A"
            End If

            If RadioButton19.Checked() Then
                strpressure = "Yes"
            ElseIf RadioButton20.Checked() Then
                strpressure = "No"
            ElseIf RadioButton21.Checked() Then
                strpressure = "N/A"
            End If

            If RadioButton22.Checked() Then
                strflame = "Yes"
            ElseIf RadioButton23.Checked() Then
                strflame = "No"
            ElseIf RadioButton24.Checked() Then
                strflame = "N/A"
            End If

            If RadioButton25.Checked() Then
                strmanual = "Yes"
            ElseIf RadioButton26.Checked() Then
                strmanual = "No"
            ElseIf RadioButton27.Checked() Then
                strmanual = "N/A"
            End If
            If RadioButton28.Checked() Then
                strwarning = "Yes"
            ElseIf RadioButton29.Checked() Then
                strwarning = "No"
            ElseIf RadioButton30.Checked() Then
                strwarning = "N/A"
            End If
            If RadioButton31.Checked() Then
                strsafty = "Yes"
            ElseIf RadioButton32.Checked() Then
                strsafty = "No"
            ElseIf RadioButton33.Checked() Then
                strsafty = "N/A"
            End If

            If RadioButton34.Checked() Then
                strprimary = "Yes"
            ElseIf RadioButton35.Checked() Then
                strprimary = "No"
            ElseIf RadioButton36.Checked() Then
                strprimary = "N/A"
            End If

            If RadioButton37.Checked() Then
                strsecondary = "Yes"
            ElseIf RadioButton38.Checked() Then
                strsecondary = "No"
            ElseIf RadioButton39.Checked() Then
                strsecondary = "N/A"
            End If

            If RadioButton40.Checked() Then
                strPrimarySatis = "Yes"
            ElseIf RadioButton41.Checked() Then
                strPrimarySatis = "No"
            ElseIf RadioButton42.Checked() Then
                strPrimarySatis = "N/A"
            End If

            If RadioButton43.Checked() Then
                strSecondarySatis = "Yes"
            ElseIf RadioButton44.Checked() Then
                strSecondarySatis = "No"
            ElseIf RadioButton45.Checked() Then
                strSecondarySatis = "N/A"
            End If
            If RadioButton46.Checked() Then
                strmanualOver = "Yes"
            ElseIf RadioButton47.Checked() Then
                strmanualOver = "No"
            ElseIf RadioButton48.Checked() Then
                strmanualOver = "N/A"
            End If
            If RadioButton49.Checked() Then
                strapparant = "1"
            ElseIf RadioButton50.Checked() Then
                strapparant = "2"
            ElseIf RadioButton51.Checked() Then
                strapparant = "3"
            ElseIf RadioButton52.Checked() Then
                strapparant = "4"
            ElseIf RadioButton53.Checked() Then
                strapparant = "5"
            End If
            If RadioButton54.Checked() Then
                strventilation = "1"
            ElseIf RadioButton55.Checked() Then
                strventilation = "2"
            ElseIf RadioButton56.Checked() Then
                strventilation = "3"
            ElseIf RadioButton57.Checked() Then
                strventilation = "4"
            ElseIf RadioButton58.Checked() Then
                strventilation = "5"
            End If
            If RadioButton59.Checked() Then
                strunsatisfactory = "1"
            ElseIf RadioButton60.Checked() Then
                strunsatisfactory = "2"
            ElseIf RadioButton61.Checked() Then
                strunsatisfactory = "3"
            ElseIf RadioButton62.Checked() Then
                strunsatisfactory = "4"
            ElseIf RadioButton63.Checked() Then
                strunsatisfactory = "5"
            End If

            If RadioButton64.Checked() Then
                strsign = "1"
            ElseIf RadioButton65.Checked() Then
                strsign = "2"
            ElseIf RadioButton66.Checked() Then
                strsign = "3"
            ElseIf RadioButton67.Checked() Then
                strsign = "4"
            ElseIf RadioButton68.Checked() Then
                strsign = "5"
            End If

            If RadioButton69.Checked() Then
                strvolume = "1"
            ElseIf RadioButton70.Checked() Then
                strvolume = "2"
            ElseIf RadioButton71.Checked() Then
                strvolume = "3"
            ElseIf RadioButton72.Checked() Then
                strvolume = "4"
            ElseIf RadioButton73.Checked() Then
                strvolume = "5"
            End If
            If RadioButton74.Checked() Then
                strevidence = "1"
            ElseIf RadioButton75.Checked() Then
                strevidence = "2"
            ElseIf RadioButton76.Checked() Then
                strevidence = "3"
            ElseIf RadioButton77.Checked() Then
                strevidence = "4"
            ElseIf RadioButton78.Checked() Then
                strevidence = "5"
            End If

            If RadioButton79.Checked() Then
                strmaintenance = "1"
            ElseIf RadioButton80.Checked() Then
                strmaintenance = "2"
            ElseIf RadioButton81.Checked() Then
                strmaintenance = "3"
            ElseIf RadioButton82.Checked() Then
                strmaintenance = "4"
            ElseIf RadioButton83.Checked() Then
                strmaintenance = "5"
            End If
            Dim strextensive As String = ""
            Dim straging As String = ""
            Dim strappliance As String = ""
            If RadioButton84.Checked() Then
                strextensive = "1"
            ElseIf RadioButton85.Checked() Then
                strextensive = "2"
            ElseIf RadioButton86.Checked() Then
                strextensive = "3"
            ElseIf RadioButton87.Checked() Then
                strextensive = "4"
            ElseIf RadioButton88.Checked() Then
                strextensive = "5"
            End If

            If RadioButton89.Checked() Then
                straging = "1"
            ElseIf RadioButton90.Checked() Then
                straging = "2"
            ElseIf RadioButton91.Checked() Then
                straging = "3"
            ElseIf RadioButton92.Checked() Then
                straging = "4"
            ElseIf RadioButton93.Checked() Then
                straging = "5"
            End If

            If RadioButton89.Checked() Then
                strappliance = "1"
            ElseIf RadioButton90.Checked() Then
                strappliance = "2"
            ElseIf RadioButton91.Checked() Then
                strappliance = "3"
            ElseIf RadioButton92.Checked() Then
                strappliance = "4"
            ElseIf RadioButton93.Checked() Then
                strappliance = "5"
            End If
            If RadioButton99.Checked() Then
                strcorrect = "Yes"
            ElseIf RadioButton100.Checked() Then
                strcorrect = "No"
            ElseIf RadioButton101.Checked() Then
                strcorrect = "N/A"
            End If

            If RadioButton102.Checked() Then
                stridentified = "Yes"
            ElseIf RadioButton103.Checked() Then
                stridentified = "No"
            ElseIf RadioButton104.Checked() Then
                stridentified = "N/A"
            End If

            If RadioButton105.Checked() Then
                strpipework = "Yes"
            ElseIf RadioButton106.Checked() Then
                strpipework = "No"
            ElseIf RadioButton107.Checked() Then
                strpipework = "N/A"
            End If

            If RadioButton108.Checked() Then
                strsleeves = "Yes"
            ElseIf RadioButton109.Checked() Then
                strsleeves = "No"
            ElseIf RadioButton110.Checked() Then
                strsleeves = "N/A"
            End If

            If RadioButton111.Checked() Then
                strsuitable = "Yes"
            ElseIf RadioButton112.Checked() Then
                strsuitable = "No"
            ElseIf RadioButton113.Checked() Then
                strsuitable = "N/A"
            End If
            Dim strisolation As String = ""
            Dim strelectrical As String = ""
            Dim strprotective As String = ""
            Dim strappropiate As String = ""
            If RadioButton114.Checked() Then
                strisolation = "Yes"
            ElseIf RadioButton115.Checked() Then
                strisolation = "No"
            ElseIf RadioButton16.Checked() Then
                strisolation = "N/A"
            End If

            If RadioButton117.Checked() Then
                strelectrical = "Yes"
            ElseIf RadioButton118.Checked() Then
                strelectrical = "No"
            ElseIf RadioButton119.Checked() Then
                strelectrical = "N/A"
            End If

            If RadioButton120.Checked() Then
                strprotective = "Yes"
            ElseIf RadioButton121.Checked() Then
                strprotective = "No"
            ElseIf RadioButton122.Checked() Then
                strprotective = "N/A"
            End If


            If RadioButton123.Checked() Then
                strappropiate = "Yes"
            ElseIf RadioButton124.Checked() Then
                strappropiate = "No"
            ElseIf RadioButton125.Checked() Then
                strappropiate = "N/A"
            End If
            Dim strcanopy As String = ""
            Dim strover As String = ""
            Dim strtype As String = ""
            If RadioButton126.Checked() Then
                strcanopy = "Yes"
            ElseIf RadioButton127.Checked() Then
                strcanopy = "No"
            ElseIf RadioButton128.Checked() Then
                strcanopy = "N/A"
            End If
            If RadioButton129.Checked() Then
                strover = "Yes"
            ElseIf RadioButton130.Checked() Then
                strover = "No"
            ElseIf RadioButton131.Checked() Then
                strover = "N/A"
            End If

            If RadioButton132.Checked() Then
                strtype = "Yes"
            ElseIf RadioButton133.Checked() Then
                strtype = "No"
            ElseIf RadioButton134.Checked() Then
                strtype = "N/A"
            End If
            Dim strfilter As String = ""
            Dim strmechanical As String = ""
            Dim strnatually As String = ""
            Dim strboth As String = ""
            If RadioButton135.Checked() Then
                strfilter = "Yes"
            ElseIf RadioButton136.Checked() Then
                strfilter = "No"
            ElseIf RadioButton137.Checked() Then
                strfilter = "N/A"
            End If
            If RadioButton138.Checked() Then
                strmechanical = "Yes"
            ElseIf RadioButton139.Checked() Then
                strmechanical = "No"
            ElseIf RadioButton140.Checked() Then
                strmechanical = "N/A"
            End If
            If RadioButton141.Checked() Then
                strnatually = "Yes"
            ElseIf RadioButton142.Checked() Then
                strnatually = "No"
            ElseIf RadioButton143.Checked() Then
                strnatually = "N/A"
            End If


            If RadioButton144.Checked() Then
                strboth = "Yes"
            ElseIf RadioButton145.Checked() Then
                strboth = "No"
            ElseIf RadioButton146.Checked() Then
                strboth = "N/A"
            End If



            If RadioButton147.Checked() Then
                strmech = "Yes"
            ElseIf RadioButton148.Checked() Then
                strmech = "No"
            ElseIf RadioButton149.Checked() Then
                strmech = "N/A"
            End If
            If RadioButton150.Checked() Then
                strsatisVentillation = "Yes"
            ElseIf RadioButton151.Checked() Then
                strsatisVentillation = "No"
            ElseIf RadioButton152.Checked() Then
                strsatisVentillation = "N/A"
            End If

            If RadioButton153.Checked() Then
                stradequate = "Yes"
            ElseIf RadioButton154.Checked() Then
                stradequate = "No"
            ElseIf RadioButton155.Checked() Then
                stradequate = "N/A"
            End If

            If RadioButton156.Checked() Then
                strco = "Yes"
            ElseIf RadioButton157.Checked() Then
                strco = "No"
            ElseIf RadioButton158.Checked() Then
                strco = "N/A"
            End If

            If RadioButton159.Checked() Then
                strco2 = "Yes"
            ElseIf RadioButton160.Checked() Then
                strco2 = "No"
            ElseIf RadioButton161.Checked() Then
                strco2 = "N/A"
            End If
            If RadioButton162.Checked() Then
                strdetection = "Yes"
            ElseIf RadioButton163.Checked() Then
                strdetection = "No"
            ElseIf RadioButton164.Checked() Then
                strdetection = "N/A"
            End If
            If RadioButton165.Checked() Then
                strrecord = "Yes"
            ElseIf RadioButton166.Checked() Then
                strrecord = "No"
            ElseIf RadioButton167.Checked() Then
                strrecord = "N/A"
            End If

            If RadioButton168.Checked() Then
                strcenter = "Yes"
            ElseIf RadioButton169.Checked() Then
                strcenter = "No"
            ElseIf RadioButton170.Checked() Then
                strcenter = "N/A"
            End If
            objBEGas.ClientId = ddlCompany.SelectedValue
            objBEGas.JobId = objFunction.ReturnInteger(ddlJobId.SelectedItem.Text)
            objBEGas.EngineerId = objFunction.ReturnInteger(Session("LoginUserId"))
            objBEGas.satisfactory = satisfactoryStatus
            objBEGas.Accesible = AccesibleStatus
            objBEGas.suitable = suitStatus
            objBEGas.valve = strvalve
            objBEGas.Direction = strdirection
            objBEGas.Emergency = stremergency
            objBEGas.autopressure = strpressure
            objBEGas.flameguard = strflame
            objBEGas.manual = strmanual
            objBEGas.warning = strwarning
            objBEGas.PrimarySafety = strsafty
            objBEGas.PrimaryInterlock = strprimary
            objBEGas.SecondaryInterlock = strsecondary
            objBEGas.PrimarySatisfactory = strPrimarySatis
            objBEGas.SecondarySatisfactory = strSecondarySatis
            objBEGas.manuallyOveridden = strmanualOver
            objBEGas.Apparant = strapparant
            objBEGas.Evidenceventilation = strventilation
            objBEGas.Unsatisfactory = strunsatisfactory
            objBEGas.signventilation = strsign
            objBEGas.volume = strvolume
            objBEGas.Evidencesystems = strevidence
            objBEGas.SignMaintenance = strmaintenance
            objBEGas.Extensive = strextensive
            objBEGas.Aging = straging
            objBEGas.Fitted = strappliance
            objBEGas.TotalScore = txtTotal.Text
            objBEGas.ReceiveDate = DateTime.ParseExact(txtReceiveDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
            objBEGas.CorrectMatterials = strcorrect
            objBEGas.Identified = stridentified
            objBEGas.Pipework = strpipework
            objBEGas.sleeves = strsleeves
            objBEGas.SuitablePurge = strsuitable
            objBEGas.AdditinalIsolation = strisolation
            objBEGas.Electrical = strelectrical
            objBEGas.Protective = strprotective
            objBEGas.appropiate = strappropiate
            objBEGas.CanopySystem = strcanopy
            objBEGas.Overhang = strover
            objBEGas.Type = strtype
            objBEGas.filterSatisfactory = strfilter
            objBEGas.mechanically = strmechanical
            objBEGas.naturally = strnatually
            objBEGas.both = strboth
            objBEGas.MechVentilation = strmech
            objBEGas.SatisfatoryVentilation = strsatisVentillation
            objBEGas.adequate = stradequate
            objBEGas.High = txtProvideDetails1.Text
            objBEGas.low = txtProvideDetails2.Text
            objBEGas.COdetect = strco
            objBEGas.CO2detect = strco2
            objBEGas.detectionInterlock = strdetection
            objBEGas.CO2recorded = strrecord
            objBEGas.center = strcenter
            objBEGas.Model1 = txtModel1.Text
            objBEGas.Model2 = txtModel2.Text
            objBEGas.CollabrationDate1 = DateTime.ParseExact(txtDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
            objBEGas.CollabrationDate2 = DateTime.ParseExact(txtDate1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
            objBEGas.ReceivedBy = txtReceivedBy.Text
            objBEGas.PrintName = txtPrintName.Text
            objBEGas.IssuedBy = txtIssuedBy.Text
            objBEGas.IdcardNo = txtIDCard.Text
            objBEGas.IssuedDate = DateTime.ParseExact(txtDate2.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
            objBEGas.InspectionId = objFunction.ReturnInteger(Request.QueryString("GasInspectionID"))
            If (Status = "SAVE") Then
                Dim intJobsGasId As Integer = (New clsDLGasInspection()).AddJobsGasDetails(objBEGas)
                If intJobsGasId > 0 Then
                    hdnID.Value = objFunction.ReturnString(intJobsGasId)
                    Dim javaScript As String = ""
                    javaScript += "<script type='text/javascript'>"
                    javaScript += "$(document).ready(function(){"
                    javaScript += "ShowPopup('New Job Gas Inspection has been submitted.','success');"
                    javaScript += "});"
                    javaScript += "</script>"
                    ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                    btnSubmit.Enabled = False
                    btnGo.Enabled = True

                End If
            Else
                Dim intAffectedRow As Integer = (New clsDLGasInspection()).UpdateJobsGasDetails(objBEGas)
                If intAffectedRow > 0 Then
                    Dim javaScript As String = ""
                    javaScript += "<script type='text/javascript'>"
                    javaScript += "$(document).ready(function(){"
                    javaScript += "ShowPopup('Job Gas Inspection has been updated.','success');"
                    javaScript += "});"
                    javaScript += "</script>"
                    ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                    btnSubmit.Enabled = False
                    btnGo.Enabled = True

                End If
            End If



        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try


    End Sub

    Protected Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Try
            Dim objBEGasPart As clsBEJobGasPart = New clsBEJobGasPart
            Dim dstList As New DataSet()
            Dim IntId As String

            If (hdnID.Value = "") Then
                IntId = objFunction.ReturnString(Request.QueryString("GasInspectionID"))

            Else
                IntId = hdnID.Value
            End If
            objBEGasPart.InspectionId = objFunction.ReturnInteger(IntId)
            dstList = (New clsDLJobGasPart()).GetJobsGasPart2DetailsById(objBEGasPart)
            If objFunction.CheckDataSet(dstList) Then
                Status = "UPDATE"
                Response.Redirect("gas-inspection-part-two.aspx?JobGasID=" + IntId + "&SStatus=" + Status)

            Else

                Status = "SAVE"
                Response.Redirect("gas-inspection-part-two.aspx?JobGasID=" + IntId + "&SStatus=" + Status)

            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try

        'If (Status = "SAVE") Then
        '    Dim Id As String = hdnID.Value
        '    Response.Redirect("gas-inspection-part-two.aspx?JobGasID=" + Id)

        'Else
        '    Dim Id As String = objFunction.ReturnString(Request.QueryString("GasInspectionID"))
        '    Response.Redirect("gas-inspection-part-two_edit.aspx?JobGasID=" + Id)
        'End If

    End Sub
End Class