<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Mobile/Mobile.Master" CodeBehind="job_sheet_edit.aspx.vb" Inherits="CRM.job_sheet_edit" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                    <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>

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
                        <div class="card">
                            <div class="card-body">
                                
                                    <div class="accordion-group">

                                        <div class="accordion-main">
                                            <a href="javascript:void(0)" class="accordion-custom">Customer Details</a>
                                            <div class="panel-custom">

                                                <div class="row">

                                                    <div class="col-lg-6">
                                                        <div class="form-group">
                                                            <label for="customer_name">Customer</label>
                                                            <asp:TextBox ID="txtCustomer" CssClass="form-control input-sm" runat="server" />
                                                        </div>
                                                        <div class="form-group">
                                                            <label for="address">Address</label>
                                                            <asp:TextBox ID="txtAddress" CssClass="form-control" TextMode="multiline" runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6">
                                                        <div class="row">

                                                            <div class="col-md-6">
                                                                <div class="form-group">
                                                                    <label for="customer_name">Order No.</label>
                                                                    <asp:TextBox ID="txtOrderNo" CssClass="form-control input-sm" runat="server" />
                                                                </div>
                                                            </div>

                                                            <div class="col-md-6" style="display:none;">
                                                                <div class="form-group">
                                                                    <label for="customer_name">Invoice No.</label>
                                                                    <asp:TextBox ID="txtInvoiceNo" CssClass="form-control input-sm" runat="server" />
                                                                </div>
                                                            </div>

                                                            <div class="col-md-6">
                                                                <div class="form-group">
                                                                    <label for="customer_name">Job Ref.</label>
                                                                    <asp:TextBox ID="txtJobRef" CssClass="form-control input-sm" runat="server" />
                                                                </div>
                                                            </div>

                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label for="customer_name">Invoice To</label>
                                                                    <asp:TextBox ID="txtInvoiceTo" CssClass="form-control input-sm removereadonly" runat="server" />
                                                                </div>
                                                            </div>

                                                        </div>
                                                    </div>

                                                    <div class="col-lg-12">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton1" CssClass="check" GroupName="services" value="Service Call" runat="server" />
                                                                <i class="ti-check text-active" aria-hidden="true"></i>&nbsp; Service Call
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton2" CssClass="check" GroupName="services" value="Maintenance" runat="server" />
                                                                <i class="ti-check text-active" aria-hidden="true"></i>&nbsp; Maintenance
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton3" CssClass="check" GroupName="services" value="Fabrication" runat="server" />
                                                                <i class="ti-check text-active" aria-hidden="true"></i>&nbsp; Fabrication
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton4" CssClass="check" GroupName="services" value="Installation" runat="server" />
                                                                <i class="ti-check text-active" aria-hidden="true"></i>&nbsp; Installation
                                                            </label>
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-12">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton5" CssClass="check" GroupName="service_schedule" value="initial1" runat="server" />
                                                                <i class="ti-check text-active" aria-hidden="true"></i>&nbsp; Planned Maintenance as per standard service schedule
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton6" CssClass="check" GroupName="service_schedule" value="initial2" runat="server" />
                                                                <i class="ti-check text-active" aria-hidden="true"></i>&nbsp; Equipment Identification Completed
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton7" CssClass="check" GroupName="service_schedule" value="initial3" runat="server" />
                                                                <i class="ti-check text-active" aria-hidden="true"></i>&nbsp; Equipment installed and commissioned as per manufacturer's instructions
                                                            </label>
                                                        </div>
                                                    </div>

                                                </div>

                                            </div>
                                        </div>

                                        <div class="accordion-main">
                                            <a href="javascript:void(0)" class="accordion-custom">Work Details</a>
                                            <div class="panel-custom">


                                                <div class="row">

                                                    <div class="col-lg-6">
                                                        <div class="form-group">
                                                            <label for="customer_name">Equipment</label>
                                                            <asp:TextBox ID="txtEquipment" CssClass="form-control input-sm" runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6">
                                                        <div class="form-group">
                                                            <label for="address">Manufacturer</label>
                                                            <asp:TextBox ID="txtManufacturer" CssClass="form-control input-sm" runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6">
                                                        <div class="form-group">
                                                            <label for="customer_name">Model</label>
                                                            <asp:TextBox ID="txtModel" CssClass="form-control input-sm" runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6">
                                                        <div class="form-group">
                                                            <label for="customer_name">Serial No.</label>
                                                            <asp:TextBox ID="txtSerialNo" CssClass="form-control input-sm" runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6">
                                                        <div class="form-group">
                                                            <label for="customer_name">Asset No.</label>
                                                            <asp:TextBox ID="txtAssetNo" CssClass="form-control input-sm" runat="server" />
                                                        </div>
                                                    </div>
                                                        <div class="col-lg-6">
                                                    <div class="form-group">
                                                        <label for="customer_name">Total Time</label>
                                                        <asp:TextBox ID="txtTotalTime" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>
                                                </div>
                                                    <div class="col-lg-6" style="display:none;">
                                                        <div class="form-group">
                                                            <label for="customer_name">Gas Leak Test</label>
                                                            <asp:TextBox ID="txtGasLeakTest" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>
                                                      <div class="col-lg-6" style="display:none;">
                                                        <div class="form-group">
                                                            <label for="customer_name">Earth Leakage Test</label>
                                                            <asp:TextBox ID="txtearthleakTest" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>
                                                    <div class="col-lg-6" style="display:none;">
                                                        <div class="form-group">
                                                            <label for="customer_name">Load Test</label>
                                                            <asp:TextBox ID="txtLoadTest" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6" style="display:none;">
                                                        <div class="form-group">
                                                            <label for="customer_name">Flash Test</label>
                                                            <asp:TextBox ID="txtFlashTest" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6" style="display:none;">
                                                        <div class="form-group">
                                                            <label for="customer_name">Ins. Res. @500V</label>
                                                            <asp:TextBox ID="txtIns" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6" style="display:none;">
                                                        <div class="form-group">
                                                            <label for="customer_name">E.C.</label>
                                                            <asp:TextBox ID="txtEC" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6" style="display:none;">
                                                        <div class="form-group">
                                                            <label for="customer_name">Microwave Leakage</label>
                                                            <asp:TextBox ID="txtMicrowaveLeak" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6" style="display:none;">
                                                        <div class="form-group">
                                                            <label for="customer_name">Power Output</label>
                                                            <asp:TextBox ID="txtPowerOutput" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6">
                                                        <div class="form-group">
                                                            <label for="customer_name">Fault Reported</label>
                                                            <asp:TextBox ID="txtFaultReported" CssClass="form-control" TextMode="multiline"  runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6">
                                                        <div class="form-group">
                                                            <label for="customer_name">Work Details</label>
                                                            <asp:TextBox ID="txtWorkDetails" CssClass="form-control" TextMode="multiline"  runat="server" />
                                                        </div>
                                                    </div>

                                                </div>

                                            </div>

                                        </div>

                                        <div class="accordion-main">
                                            <a href="javascript:void(0)"  class="accordion-custom">Parts Required</a>
                                                  <div class="panel-custom">

                                                     <%--   <div class="row">
                                                    <div class="col-lg-6">
                                                        <div class="form-group">
                                                              <label for="parts">Parts Description</label>
                                                <asp:TextBox ID="txtpartdescription" CssClass="form-control input-sm" runat="server" />
                                                        </div>
                                                      
                                                    </div>
                                                   <div class="col-lg-6">
                                                        <div class="form-group">
                                                              <label for="parts">Quantity</label>
                                                <asp:TextBox ID="txtqty" CssClass="form-control input-sm" runat="server" />
                                                        </div>
                                                        
                                                    </div>
                              <asp:Button ID="btnAddpart" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Add Part"/>
                                                </div>--%>
                                                <div class="row">
                                                    <div class="col-lg-12">
                                           
                                                <div class="table-responsive">
                                                     <asp:GridView ID="grdPartsRequire" DataKeyNames="ID" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" AlternatingRowStyle-ForeColor="Black" CellPadding="4" ForeColor="#333333" GridLines="None">
                                           
<AlternatingRowStyle ForeColor="#284775" BackColor="White"></AlternatingRowStyle>
                                           
                <Columns>
                                     <asp:BoundField DataField="ID" Visible="false"/>
                <asp:TemplateField HeaderText="Brief Description">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_product" runat="server" Text='<%# Eval("PartDetail")%>'/>
                        </ItemTemplate>
                     <EditItemTemplate>
                            <asp:TextBox ID="txtpart" runat="server" Text='<%#Eval("PartDetail")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                 <asp:TemplateField HeaderText="Qty">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_qty" runat="server" Text='<%# Eval("Quantity")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtqty" runat="server" Text='<%#Eval("Quantity")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                                         <asp:CommandField ShowEditButton="True" ShowDeleteButton="true" />

            </Columns>
                                                         <EditRowStyle BackColor="#999999" />
                                                         <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                         <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                         <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                         <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                         <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                         <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                                         <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                                         <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                                         <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                                                </div>
                                           </div>
                                                    </div>
                                        </div>

                                        </div>

                                        <div class="accordion-main">
                                            <a href="javascript:void(0)" class="accordion-custom">Parts Fitted</a>
                                            <div class="panel-custom">
                                           <%--     <div class="row">
                                                 
                                                   <div class="col-lg-6">
                                                        <div class="form-group">
                                                              <label for="parts">Quantity</label>
                                                <asp:TextBox ID="txtqtyfitted" CssClass="form-control input-sm" runat="server" />
                                                        </div>
                                                        
                                                    </div>
                                                       <div class="col-lg-6">
                                                        <div class="form-group">
                                                              <label for="parts">Product Code</label>
                                                <asp:TextBox ID="txtproductcode" CssClass="form-control input-sm" runat="server" />
                                                        </div>
                                                      
                                                    </div>
                                                </div>--%>
                                             <%--   <div class="row">
                                                 
                                                   <div class="col-lg-6">
                                                        <div class="form-group">
                                                              <label for="parts">Description</label>
                                                <asp:TextBox ID="txtdescription" CssClass="form-control input-sm" runat="server" />
                                                        </div>
                                                        
                                                    </div>
                                                       <div class="col-lg-6">
                                                        <div class="form-group">
                                                              <label for="parts">Price</label>
                                                <asp:TextBox ID="txtprice" CssClass="form-control input-sm" runat="server" />
                                                        </div>
                                                      
                                                    </div>
                                   <asp:Button ID="btnPartsFit" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Add Parts Fitted"/>

                                                </div>--%>
                                                <div class="row">
                                                    <div class="col-lg-12">
                                                        <div class="table-responsive">
                                                            <asp:GridView ID="grdPartsFitted" runat="server"  
                CssClass="table table-striped clsResizeColumn" AutoGenerateColumns="False"  
                ShowHeaderWhenEmpty="True" CellPadding="4" ForeColor="#333333" GridLines="Both" DataKeyNames="ID">
                                                                <EditRowStyle BackColor="#999999" />
                                                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle Font-Size="Large" Height="25px" BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                 <asp:BoundField DataField="ID" Visible="false"/>
                      <asp:TemplateField HeaderText="Qty">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_qty" runat="server" Text='<%# Eval("qty")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtqty" runat="server" Text='<%#Eval("qty")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                     <asp:TemplateField HeaderText="Product Code">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_pcode" runat="server" Text='<%# Eval("ProductCode")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtpcode" runat="server" Text='<%#Eval("ProductCode")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                      <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_desc" runat="server" Text='<%# Eval("Description")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtdesc" runat="server" Text='<%#Eval("Description")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                   <%--  <asp:TemplateField HeaderText="Partprice">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_price" runat="server" Text='<%# Eval("Partprice")%>'/>
                        </ItemTemplate>
                      <EditItemTemplate>
                            <asp:TextBox ID="txtprice" runat="server" Text='<%#Eval("Partprice")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>--%>
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

                                                <div class="col-lg-12">
                                                   
                                                        <div class="row">

                                                            <div class="col-lg-6" style="display:none;">
                                                                <div class="form-group">
                                                                    <label for="customer_name">Total Materials / Parts</label>
                                                                    <asp:TextBox ID="txtTotalMaterials" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                                </div>
                                                            </div>

                                                            <div class="col-lg-6" style="display:none;">
                                                                <div class="form-group">
                                                                    <label for="address">Labour</label>
                                                                    <asp:TextBox ID="txtLabour" runat="server" CssClass="form-control input-sm removereadonly" Text="0"></asp:TextBox>
                                                                </div>
                                                            </div>

                                                            <div class="col-lg-6">
                                                                <div class="form-group">
                                                                    <label for="customer_name">Misc Charges</label>
                                                                    <asp:TextBox ID="txtMiscCharge" runat="server" CssClass="form-control input-sm removereadonly" Text="0"></asp:TextBox>
                                                                </div>
                                                            </div>

                                                            <div class="col-lg-6" style="display:none;">
                                                                <div class="form-group">
                                                                    <label for="customer_name">Sub Total</label>
                                                                    <asp:TextBox ID="txtSubTotal" runat="server" CssClass="form-control input-sm" ReadOnly="true">0</asp:TextBox>
                                                                </div>
                                                            </div>

                                                            <div class="col-lg-6" style="display:none;">
                                                                <div class="form-group">
                                                                    <label for="customer_name">VAT</label>
                                                                    <asp:TextBox ID="txtVAT" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                                </div>
                                                            </div>

                                                            <div class="col-lg-6" style="display:none;">
                                                                <div class="form-group">
                                                                    <label for="customer_name">Total (incl VAT)</label>
                                                                    <asp:TextBox ID="txtTotalVAT" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                                </div>
                                                            </div>

                                                        </div>
                                                    
                                                </div>
                                            </div>
                                        </div>

                                        <div class="accordion-main">
                                            <a href="javascript:void(0)" class="accordion-custom">Finish Job</a>
                                            <div class="panel-custom">

                                                <div class="row">

                                                    <div class="col-lg-6">
                                                        <div class="row">

                                                            <div class="col-md-12">

                                                                <div class="custom-checkbox-job">
                                                                    <asp:CheckBox ID="chargeable" class="check" runat="server" />
                                                                    <%--<input type="checkbox" class="check" id="chargeable" data-checkbox="icheckbox_flat-red">--%>
                                                                    <label for="chargeable">Chargeable</label>
                                                                </div>

                                                                <div class="custom-checkbox-job">
                                                                    <asp:CheckBox ID="warranty" class="check" runat="server" />
                                                                    <%-- <input type="checkbox" class="check" id="warranty" data-checkbox="icheckbox_flat-red">--%>
                                                                    <label for="Warranty">Warranty</label>
                                                                </div>

                                                                <div class="custom-checkbox-job">
                                                                    <asp:CheckBox ID="job_completed" class="check" runat="server" />
                                                                    <%--<input type="checkbox" class="check" id="job_completed" data-checkbox="icheckbox_flat-red">--%>
                                                                    <label for="job_completed">Job Completed</label>
                                                                </div>

                                                            </div>

                                                        </div>

                                                    </div>

                                                    <div class="col-lg-12">
                                                        <div class="form-group">
                                                            <label for="job_unfinished">Job Unfinished / Reason</label>
                                                            <asp:TextBox ID="job_unfinished" CssClass="form-control" TextMode="multiline"  runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6">
                                                        <div class="form-group">
                                                            <label for="print_name">Print Name</label>
                                                            <asp:TextBox ID="txtPrintName" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6">
                                                        <div class="form-group">
                                                            <label for="job_title">Job Title</label>
                                                            <asp:TextBox ID="txtJobTitle" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-6">
                                                        <div class="custom-checkbox-job">
                                                            <asp:CheckBox ID="chkdeclaration" CssClass="check" runat="server" />
                                                            <%--<input type="checkbox" class="check" id="declaration" data-checkbox="icheckbox_flat-red">--%>
                                                            &nbsp;
	                                                                <label for="declaration">I/We hereby acknowledge that the work detailed above has been carried out to my / our satisfaction.</label>
                                                        </div>
                                                    </div>

                                                </div>

                                            </div>

                                        </div>
                                    </div>
                            </div>

                            <div class="form-group text-center">
                              <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="UPDATE"/>

                                

                            </div>


                        </div>

                        <asp:HiddenField ID="hdnJobId" runat="server" />
                        <asp:HiddenField ID="hdnVat" runat="server" />

                    </div>
                </div>

                <div class="row">
            <div class="col-12">
            <div class="card">
                <div class="card-body">
                    <div class="table-responsive">
                                <asp:GridView ID="grdPartsOrderForthisJob" runat="server"
                                    AllowPaging="True" PageSize="50" CssClass="table table-striped clsResizeColumn" AutoGenerateColumns="False" 
                                    EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True">
                                    <HeaderStyle Font-Size="Small" Height="25px" />
                                    <PagerStyle CssClass="PageClass" />
                                    <Columns>
                                        <asp:BoundField DataField="EngineersNos" HeaderText="EngineersNos" ReadOnly="true" />
                                        <asp:BoundField DataField="Appliance" HeaderText="Appliance" ReadOnly="true" />
                                        <asp:BoundField DataField="Manu" HeaderText="Manufacturer" ReadOnly="true" />
                                        <asp:BoundField DataField="Model" HeaderText="Model" ReadOnly="true" />
                                        <asp:BoundField DataField="PartNumber" HeaderText="Part Number" ReadOnly="true" />
                                        <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="true" />
                                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" ReadOnly="true" />
                                        <asp:BoundField DataField="Recieved" HeaderText="Recieved" ReadOnly="true" />
                                        <asp:BoundField DataField="Awaiting" HeaderText="Awaiting" ReadOnly="true" />
                                       </Columns>
                                    <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" />
                                </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
            </div>
        </div>
    </div>
     <script>

        $('#<%= txtLabour.ClientID %>').change(function ()
        {
            
            var TotMaterial= $("#<%= txtTotalMaterials.ClientID %>").val()
            var TotLabour = $("#<%= txtLabour.ClientID %>").val()
            var TotMisc = $("#<%= txtMiscCharge.ClientID %>").val()
            var Vatvalue=$("#<%= hdnVat.ClientID %>").val()
            var total, vat, TotVat;
            total = parseInt(TotMaterial) + parseInt(TotLabour) + parseInt(TotMisc);
            $("#<%= txtSubTotal.ClientID %>").val(total)
            vat = (parseFloat(total) * parseFloat(Vatvalue)).toFixed(2)
            $("#<%= txtVAT.ClientID %>").val(vat)
            TotVat = (parseFloat(total) + parseFloat(vat)).toFixed(2)
            $("#<%= txtTotalVAT.ClientID %>").val(TotVat)

        });

         $('#<%= txtMiscCharge.ClientID %>').change(function ()
        {
            
          var TotMaterial= $("#<%= txtTotalMaterials.ClientID %>").val()
            var TotLabour = $("#<%= txtLabour.ClientID %>").val()
            var TotMisc = $("#<%= txtMiscCharge.ClientID %>").val()
            var Vatvalue=$("#<%= hdnVat.ClientID %>").val()
            var total, vat, TotVat;
            total = parseInt(TotMaterial) + parseInt(TotLabour) + parseInt(TotMisc);
            $("#<%= txtSubTotal.ClientID %>").val(total)
            vat = (parseFloat(total) * parseFloat(Vatvalue)).toFixed(2)
            $("#<%= txtVAT.ClientID %>").val(vat)
            TotVat = (parseFloat(total) + parseFloat(vat)).toFixed(2)
            $("#<%= txtTotalVAT.ClientID %>").val(TotVat)
        });
     
</script>
</asp:Content>
