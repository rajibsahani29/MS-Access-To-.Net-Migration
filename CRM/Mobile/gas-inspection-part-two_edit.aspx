<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Mobile/Mobile.Master" CodeBehind="gas-inspection-part-two_edit.aspx.vb" Inherits="CRM.gas_inspection_part_two_edit" %>

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
                                                                                <h4>Appliance Details</h4>

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
                <asp:BoundField DataField="IsolationValve" HeaderText="Gas Isolation Valve fitted?(Y/N)"/>
                <asp:BoundField DataField="FittedStatus" HeaderText="Gas Hose & Restraint fitted correctly?(Y/N)"/>
                <asp:BoundField DataField="Isolator" HeaderText="Electrical Isolator fitted and fused correctly?(Y/N)"/>
                <asp:BoundField DataField="FSDFitted" HeaderText="FSD fitted to all burners?(Y/N)"/>
                <asp:BoundField DataField="FSDOperating" HeaderText="FSD operating correctly?(Y/N)"/>
                <asp:BoundField DataField="Pipework" HeaderText="Pipework gas tight?(Y/N)"/>
                <asp:BoundField DataField="Safety" HeaderText="Safe to use?(Y/N)"/>
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

                      </div></div>
                 <div class="row">
                  <div class="col-lg-12">

                      </div></div> <div class="row">
                  <div class="col-lg-12">

                      </div></div>
                <div class="row">
                    <div class="col-lg-12">
                        <h4> Defect Details</h4>
                        <asp:GridView ID="grdJobGasSection2" runat="server"  
                CssClass="print_border" AutoGenerateColumns="False"  
                ShowHeaderWhenEmpty="True" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="JobGasPartId">
                                                                <EditRowStyle BackColor="#999999" />
                                                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle Font-Size="Large" Height="25px" BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                 <asp:BoundField DataField="JobGasPartId" Visible="false"/>
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


            <!-- ============================================================== -->
            <!-- End PAge Content -->
            <!-- ============================================================== -->
        </div>
        <!-- ============================================================== -->
        <!-- End Container fluid  -->
        <!-- ============================================================== -->
    </div>
</asp:Content>
