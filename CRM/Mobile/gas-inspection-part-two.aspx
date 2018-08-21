<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Mobile/Mobile.Master" CodeBehind="gas-inspection-part-two.aspx.vb" Inherits="CRM.gas_inspection_part_two" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="page-wrapper">
        <!-- ============================================================== -->
        <!-- Container fluid  -->
        <!-- ============================================================== -->
        <div class="container-fluid">
            <!-- ============================================================== -->
            <!-- Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
        
            <!-- ============================================================== -->
            <!-- End Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- Start Page Content -->
            <!-- ============================================================== -->
            <div class="gas-main-warp">
                 <div class="row">
                                                    <div class="col-lg-12">
                                                        <table>
                                                            <tbody>
                                                                 <tr>
                                                <td><asp:Button ID="btnBack" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="GO BACK" /></td>
                                                <td>
                                                    <asp:Button ID="btnComplete" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="COMPLETE" />
                                                </td>
                                            </tr>
                                                            </tbody>
                                                        </table>
                                                          </div>
                                                </div>
                <div class="row">
                                                    <div class="col-lg-12">
                                                        <div class="table-responsive">
                                                            <asp:GridView ID="grdJobGasPart" runat="server"  
                CssClass="print_border" AutoGenerateColumns="False" Font-Size="12px"  
                ShowHeaderWhenEmpty="True" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="JobGasPartId">
                                                                <EditRowStyle BackColor="#999999" />
                                                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle Font-Size="Small" Height="16px" BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                <asp:BoundField DataField="JobGasPartId" Visible="false"/>
                      <asp:TemplateField HeaderText="Appliance Type">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_Type" runat="server" Text='<%# Eval("ApplianceType")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtType" runat="server" Text='<%#Eval("ApplianceType")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                     <asp:TemplateField HeaderText="Appliance Make">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_Make" runat="server" Text='<%# Eval("ApplianceMake")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtMake" runat="server" Text='<%#Eval("ApplianceMake")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                      <asp:TemplateField HeaderText="Model">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_model" runat="server" Text='<%# Eval("Model")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtModel" runat="server" Text='<%#Eval("Model")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                    <asp:TemplateField HeaderText="Manufacturers Instructions(Y/N)">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_manufacture" runat="server" Text='<%# Eval("Manufacturer")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtmanufacture" runat="server" Text='<%#Eval("Manufacturer")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                    <asp:TemplateField HeaderText="Operating Pressure(mbar)">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_pressure" runat="server" Text='<%# Eval("Pressure")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtpressure" runat="server" Text='<%#Eval("Pressure")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                      <asp:TemplateField HeaderText="Heat Input(kW)">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_heat" runat="server" Text='<%# Eval("HeatInput")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtheat" runat="server" Text='<%#Eval("HeatInput")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                     <asp:TemplateField HeaderText="Max CO reading appliance">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_maxco" runat="server" Text='<%# Eval("MaxCO")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtco" runat="server" Text='<%#Eval("MaxCO")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                     <asp:TemplateField HeaderText="Max CO² reading appliance">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_maxco2" runat="server" Text='<%# Eval("MaxCO2")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtco2" runat="server" Text='<%#Eval("MaxCO2")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gas Isolation Valve fitted?(Y/N)">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_isolation" runat="server" Text='<%# Eval("IsolationValve")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtIsolation" runat="server" Text='<%#Eval("IsolationValve")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                     <asp:TemplateField HeaderText="Gas Hose & Restraint fitted correctly?(Y/N)">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_fitted" runat="server" Text='<%# Eval("FittedStatus")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtfitted" runat="server" Text='<%#Eval("FittedStatus")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                      <asp:TemplateField HeaderText="Electrical Isolator fitted and fused correctly?(Y/N)">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_isolator" runat="server" Text='<%# Eval("Isolator")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtisolator" runat="server" Text='<%#Eval("Isolator")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                       <asp:TemplateField HeaderText="FSD fitted to all burners?(Y/N)">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_fsdfit" runat="server" Text='<%# Eval("FSDFitted")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtfsdfit" runat="server" Text='<%#Eval("FSDFitted")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                     <asp:TemplateField HeaderText="FSD operating correctly?(Y/N)">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_fsdOperating" runat="server" Text='<%# Eval("FSDOperating")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtfsdOperating" runat="server" Text='<%#Eval("FSDOperating")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                      <asp:TemplateField HeaderText="Pipework gas tight?(Y/N)">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_pipework" runat="server" Text='<%# Eval("Pipework")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtpipework" runat="server" Text='<%#Eval("Pipework")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                     <asp:TemplateField HeaderText="Safe to use?(Y/N)">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_safety" runat="server" Text='<%# Eval("Safety")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtsafety" runat="server" Text='<%#Eval("Safety")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                      <asp:TemplateField HeaderText="Defect(s) identified">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_defects" runat="server" Text='<%# Eval("Defects")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtdefects" runat="server" Text='<%#Eval("Defects")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                    <asp:TemplateField HeaderText="Warning Advice Issued?(Y/N)">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_warning" runat="server" Text='<%# Eval("Warning")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtwarning" runat="server" Text='<%#Eval("Warning")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                       <asp:TemplateField HeaderText="Remedial work undertaken">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_remedical" runat="server" Text='<%# Eval("Remedical")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtremedical" runat="server" Text='<%#Eval("Remedical")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                     <asp:TemplateField HeaderText="Details of work required">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_details" runat="server" Text='<%# Eval("Details")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtdetails" runat="server" Text='<%#Eval("Details")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                   <asp:CommandField ShowEditButton="True" ShowDeleteButton="true" />

              </Columns>
                                                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
              <RowStyle HorizontalAlign="Center" Font-Size="Medium" Height="50px" BackColor="#F7F6F3" ForeColor="#333333"/>
                                                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                                                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                                                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                                                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                                                        </div>
                                                    </div>
                                                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="card">
                            
                            <div class="card-body">
                                <div class="table-responsive new-table-warp">
                                    <table class="table color-table primary-table radio-table form-table-warp">
                                        <tbody>
                                            <tr>
                                                <td>Appliance Type</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="table-form">
                                                        <div class="table-form">
                                                            <div class="form-group">
                                                                <asp:TextBox ID="txtAppType" CssClass="form-control input-sm removereadonly" runat="server" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Appliance Make</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="table-form">
                                                        <div class="form-group">
                                                            <asp:TextBox ID="txtApplianceMake" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Appliance Model</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="table-form">
                                                        <div class="form-group">
                                                            <asp:TextBox ID="txtAppModel" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Manufacturers Instructions available?</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="btn-group rgOne" data-toggle="buttons" role="group">
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton168" CssClass="check" GroupName="Group1" value="Yes" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                        </label>
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton1" CssClass="check" GroupName="Group1" value="No" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>No
                                                        </label>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Operating Pressure (mbar)</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="table-form">
                                                        <div class="form-group">
                                                            <asp:TextBox ID="txtOpPressure" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Heat Input (kW)</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="table-form">
                                                        <div class="form-group">
                                                            <asp:TextBox ID="txtHeatInput" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Max CO reading appliance</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="table-form">
                                                        <div class="form-group">
                                                            <asp:TextBox ID="txtMaxRead" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Max CO²  reading around appliance</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="table-form">
                                                        <div class="form-group">
                                                            <asp:TextBox ID="txtMax" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Gas Isolation Valve fitted?</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="btn-group rgTwo" data-toggle="buttons" role="group">
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton2" CssClass="check" GroupName="Group2" value="Yes" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                        </label>
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton3" CssClass="check" GroupName="Group2" value="No" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>No
                                                        </label>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Gas Hose & Restraint fitted correctly?</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="btn-group rgThree" data-toggle="buttons" role="group">
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton4" CssClass="check" GroupName="Group3" value="Yes" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                        </label>
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton5" CssClass="check" GroupName="Group3" value="No" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>No
                                                        </label>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Electrical Isolator fitted and fused correctly?</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="btn-group rgFour" data-toggle="buttons" role="group">
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton6" CssClass="check" GroupName="Group4" value="Yes" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                        </label>
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton7" CssClass="check" GroupName="Group4" value="No" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>No
                                                        </label>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>FSD fitted to all burners?</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="btn-group rgFive" data-toggle="buttons" role="group">
                                                        <label class="btn btn-outline btn-info">
                                                           <asp:RadioButton ID="RadioButton8" CssClass="check" GroupName="Group5" value="Yes" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                        </label>
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton9" CssClass="check" GroupName="Group5" value="No" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>No
                                                        </label>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>FSD operating correctly?</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="btn-group rgSix" data-toggle="buttons" role="group">
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton10" CssClass="check" GroupName="Group6" value="Yes" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                        </label>
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton11" CssClass="check" GroupName="Group6" value="No" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>No
                                                        </label>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Pipework gas tight?</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="btn-group rgSeven" data-toggle="buttons" role="group">
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton12" CssClass="check" GroupName="Group7" value="Yes" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                        </label>
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton13" CssClass="check" GroupName="Group7" value="No" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>No
                                                        </label>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Safe to use?</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="btn-group rgEight" data-toggle="buttons" role="group">
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton14" CssClass="check" GroupName="Group8" value="Yes" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                        </label>
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton15" CssClass="check" GroupName="Group8" value="No" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>No
                                                        </label>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Defect(s) identified</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="table-form">
                                                        <div class="form-group">
                                                            <asp:TextBox ID="txtDefIdentified" CssClass="form-control input-sm removereadonly" runat="server" />

                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Warning Advice Issued?</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="btn-group rgNine" data-toggle="buttons" role="group">
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton16" CssClass="check" GroupName="Group9" value="Yes" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                        </label>
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton17" CssClass="check" GroupName="Group9" value="No" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>No
                                                        </label>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Remedial work undertaken</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="table-form">
                                                        <div class="form-group">
                                                            <asp:TextBox ID="txtWork" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Details of work required</td>
                                                 </tr>
                                    <tr>
                                                <td>
                                                    <div class="table-form">
                                                        <div class="form-group">
                                                            <asp:TextBox ID="txtDetails" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>
                                                    <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Submit"  OnClientClick="return ValidateControls()"/>

                                                </td>
                                            </tr>
                                            <tr>
                                                <td><asp:HiddenField ID="hdnID" runat="server" />
                                                     <asp:HiddenField ID="hdnConfirm" runat="server" />

                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
                </div>
            <!-- ============================================================== -->
            <!-- End PAge Content -->
            <!-- ============================================================== -->
        </div>
        <!-- ============================================================== -->
        <!-- End Container fluid  -->
        <!-- ============================================================== -->
    </div>
     

         <script>

             function ShowConfirmationPopup(Msg) {
           
                swal({
                    title: "Are you sure you wish to leave?",
                    text: Msg,
                    type: "warning",
                    showCancelButton: true,
                    confirmButtonColor: "#DD6B55",
                    confirmButtonText: "Proceed",
                    cancelButtonText: "cancel and return",
                    closeOnConfirm: false,
                    closeOnCancel: true

                }, function (isConfirm) {
                    if (isConfirm) {
                        $("#<%= hdnConfirm.ClientID %>").val(isConfirm)
                         var confirmvalue = $("#<%= hdnConfirm.ClientID %>").val()
                        if (confirmvalue = true)
                        {
                            var Id = $("#<%= hdnID.ClientID %>").val()
                            location.href = "gas-inspection_edit.aspx?GasInspectionID=" + Id;
                        }
                    }
                    else {

                    }

                });
            
        }


              function ShowConfirmationPopupComplete(Msg) {
           
                swal({
                    title: "Are you sure you wish to leave?",
                    text: Msg,
                    type: "warning",
                    showCancelButton: true,
                    confirmButtonColor: "#DD6B55",
                    confirmButtonText: "Proceed",
                    cancelButtonText: "cancel and return",
                    closeOnConfirm: false,
                    closeOnCancel: true

                }, function (isConfirm) {
                    if (isConfirm) {
                        $("#<%= hdnConfirm.ClientID %>").val(isConfirm)
                         var confirmvalue = $("#<%= hdnConfirm.ClientID %>").val()
                        if (confirmvalue = true)
                        {
                            location.href = "Index-mobile.aspx";
                        }
                    }
                    else {

                    }

                });
            
        }
    </script>

      <script type="text/javascript">
        function ValidateControls()
        {
            var clsArray = Array("rgOne");
            var bnlError = false;
            for (i = 0; i < clsArray.length; i++) {
                if ($("." + clsArray[i] + " input:checked").length == 0) {
                    bnlError = true;
                    break;
                }
            }

                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Manufacturers Instructions available Field.");
                    return false;
                }

                var clsArray = Array("rgTwo");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0)
                    {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Gas Isolation Valve fitted Field.");
                    return false;

                }
                var clsArray = Array("rgThree");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Gas Hose & Restraint fitted correctly Field.");
                    return false;

                }
                var clsArray = Array("rgFour");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Electrical Isolator fitted and fused correctly Field.");
                    return false;

                }

                
                var clsArray = Array("rgFive");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose FSD fitted to all burners Field.");
                    return false;

                }

                var clsArray = Array("rgSix");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose FSD operating correctly Field.");
                    return false;

                }
                var clsArray = Array("rgSeven");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Pipework gas tight Field.");
                    return false;

                }

                var clsArray = Array("rgEight");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Safe to use Field.");
                    return false;

                }

               
                var clsArray = Array("rgNine");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Warning Advice Issued Field.");
                    return false;

                }
                                          


                var apptype, ApplianceMake, model, OpPressure, HeatInput, Maxread, Maxread1, defects, work, details;
                apptype = document.getElementById("ContentPlaceHolder1_txtAppType").value;
                ApplianceMake = document.getElementById("ContentPlaceHolder1_txtApplianceMake").value;
                model = document.getElementById("ContentPlaceHolder1_txtAppModel").value;
                OpPressure = document.getElementById("ContentPlaceHolder1_txtOpPressure").value;
                HeatInput = document.getElementById("ContentPlaceHolder1_txtHeatInput").value;
                Maxread = document.getElementById("ContentPlaceHolder1_txtMaxRead").value;
                Maxread1 = document.getElementById("ContentPlaceHolder1_txtMax").value;
                defects = document.getElementById("ContentPlaceHolder1_txtDefIdentified").value;
                work = document.getElementById("ContentPlaceHolder1_txtWork").value;
                details = document.getElementById("ContentPlaceHolder1_txtDetails").value;
               
                if (apptype == '')
                {
                    ShowPopupBlank("Please Fill Appliance Type Field");
                    return false;
                }
                if (ApplianceMake == '') {
                    ShowPopupBlank("Please Fill Appliance Make Field");
                    return false;
                }
               
                if (model == '')
                {
                    ShowPopupBlank("Please Fill Appliance Model Field");
                    return false;

                }
                if (OpPressure == '') {
                    ShowPopupBlank("Please Fill Operating Pressure Field");
                    return false;
                }
               
             
                if (HeatInput == '') {
                    ShowPopupBlank("Please Fill Heat Input Field.");
                    return false;
                }
                if (Maxread == '') {
                    ShowPopupBlank("Please Fill Max CO reading appliance Field");
                    return false;
                }
                if (Maxread1 == '') {
                    ShowPopupBlank("Please Fill Max CO² reading appliance Field");
                    return false;
                }
                if (defects == '') {
                    ShowPopupBlank("Please Fill Defects Identified Field");
                    return false;
                }
                if (work == '') {
                    ShowPopupBlank("Please Fill Remedical Work Undertaken Field");
                    return false;
                }
                if (details == '') {
                    ShowPopupBlank("Please Fill Details Of work Field");
                    return false;
                }
               
        }
    </script>
</asp:Content>
