<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Mobile/Mobile.Master" CodeBehind="job_sheet.aspx.vb" Inherits="CRM.job_sheet" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="page-wrapper">
        <!-- ============================================================== -->
        <!-- Container fluid  -->
        <!-- ============================================================== -->
        <div class="container-fluid">
            <!-- ============================================================== -->
            <!-- Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
          
            <asp:HiddenField ID="hdncid" runat="server" />
            <asp:HiddenField ID="hdnName" runat="server" />

            <!-- ============================================================== -->
            <!-- End Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- Start Page Content -->
            <!-- ============================================================== -->
            <div class="gas-main-warp btn-gas">
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
                                                        <asp:TextBox ID="txtCustomer" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="address">Address</label>
                                                        <asp:TextBox ID="txtAddress" CssClass="form-control removereadonly" TextMode="multiline" runat="server" />
                                                    </div>
                                                </div>

                                                <div class="col-lg-6">
                                                    <div class="row">

                                                        <div class="col-md-6">
                                                            <div class="form-group">
                                                                <label for="customer_name">Order No.</label>
                                                                <asp:TextBox ID="txtOrderNo" CssClass="form-control input-sm removereadonly" runat="server" />
                                                            </div>
                                                        </div>

                                                        <div class="col-md-6" style="display:none;">
                                                            <div class="form-group">
                                                                <label for="customer_name">Invoice No.</label>
                                                                <asp:TextBox ID="txtInvoiceNo" CssClass="form-control input-sm removereadonly" runat="server" />
                                                            </div>
                                                        </div>

                                                        <div class="col-md-6">
                                                            <div class="form-group">
                                                                <label for="customer_name">Job Ref.</label>
                                                                <asp:TextBox ID="txtJobRef" CssClass="form-control input-sm removereadonly" runat="server" />
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

                                                <div class="col-lg-12 col-sm-6 rgOne">
                                                    <div class="btn-group" data-toggle="buttons" role="group">
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton1" CssClass="check" GroupName="services" value="Service Call" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>&nbsp; Service Call
                                                        </label>
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton2" CssClass="check" GroupName="services" value="Maintenance" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>&nbsp; Maintenance
                                                        </label>
                                                    </div>
                                                    <div class="clearfix"></div>
                                                    <div>
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

                                                <br />
                                                <div class="col-lg-12 rgTwo">
                                                    <div class="btn-group" data-toggle="buttons" role="group">
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton5" CssClass="check" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>&nbsp; Planned Maintenance as per standard service schedule
                                                        </label>
                                                    </div>
                                                    <div class="clearfix"></div>
                                                    <div>
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton6" CssClass="check" runat="server" />
                                                            <i class="ti-check text-active" aria-hidden="true"></i>&nbsp; Equipment Identification Completed
                                                        </label>
                                                    </div>
                                                    <div class="clearfix"></div>
                                                    <div>
                                                        <label class="btn btn-outline btn-info">
                                                            <asp:RadioButton ID="RadioButton7" CssClass="check"  runat="server" />
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
                                                        <asp:TextBox ID="txtEquipment" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>
                                                </div>

                                                <div class="col-lg-6">
                                                    <div class="form-group">
                                                        <label for="address">Manufacturer</label>
<%--                                                        <asp:TextBox ID="txtManufacturer" CssClass="form-control input-sm removereadonly" runat="server" />--%>
                                                         <asp:DropDownList ID="ddlManufacturer" runat="server" CssClass="selectpicker" AutoPostBack="true">
                                            </asp:DropDownList>
                                                    </div>
                                                      
                                                </div>

                                                <div class="col-lg-6">
                                                    <div class="form-group">
                                                        <label for="customer_name">Model</label>
<%--                                                        <asp:TextBox ID="txtModel" CssClass="form-control input-sm removereadonly" runat="server" />--%>
                                                  <%--<select id="ddlModel" runat="server" class="selectpicker">
                                                      <option value="0" >Select Model</option></select>  --%>
                                                       <asp:DropDownList ID="ddlModel" runat="server" CssClass="selectpicker"></asp:DropDownList>
                                                    </div>
                                                </div>

                                                <div class="col-lg-6">
                                                    <div class="form-group">
                                                        <label for="customer_name">Serial No.</label>
                                                        <asp:TextBox ID="txtSerialNo" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>
                                                </div>

                                                <div class="col-lg-6">
                                                    <div class="form-group">
                                                        <label for="customer_name">Asset No.</label>
                                                        <asp:TextBox ID="txtAssetNo" CssClass="form-control input-sm removereadonly" runat="server" />
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
                                                        <asp:TextBox ID="txtFaultReported" CssClass="form-control removereadonly" TextMode="multiline" runat="server" />
                                                    </div>
                                                </div>

                                                <div class="col-lg-6">
                                                    <div class="form-group">
                                                        <label for="customer_name">Work Details</label>
                                                        <asp:TextBox ID="txtWorkDetails" CssClass="form-control removereadonly" TextMode="multiline" runat="server" />
                                                    </div>
                                                </div>

                                            </div>

                                        </div>

                                    </div>

                                    <div class="accordion-main">
                                        <a href="javascript:void(0)" class="accordion-custom">Parts Required</a>
                                        <div class="panel-custom">

                                            <div class="row">
                                                <div class="col-lg-6">
                                                    <div class="form-group">
                                                        <label for="parts">Parts Description</label>
                                                        <asp:TextBox ID="txtpartdescription" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>

                                                </div>
                                                <div class="col-lg-6">
                                                    <div class="form-group">
                                                        <label for="parts">Quantity</label>
                                                        <asp:TextBox ID="txtqty" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>

                                                </div>
                                                 <div class="col-lg-6">
                                                <asp:Button ID="btnAddpart" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Add Part" OnClientClick="return ValidatePartsRequire()" />
                                                     </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-lg-12">

                                                    <div class="table-responsive">
                                                        <asp:GridView ID="grdPartsRequire" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" CssClass="table table-striped" AlternatingRowStyle-ForeColor="Black" CellPadding="4" ForeColor="#333333" GridLines="None">

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
                                            <div class="row">

                                                <div class="col-lg-6">
                                                    <div class="form-group">
                                                        <label for="parts">Quantity</label>
                                                        <asp:TextBox ID="txtqtyfitted" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>

                                                </div>
                                                <div class="col-lg-6">
                                                    <div class="form-group">
                                                        <label for="parts">Product Code</label>
                                                        <asp:TextBox ID="txtproductcode" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>

                                                </div>
                                            </div>
                                            <div class="row">

                                                <div class="col-lg-6">
                                                    <div class="form-group">
                                                        <label for="parts">Description</label>
                                                        <asp:TextBox ID="txtdescription" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>

                                                </div>
                                                <div class="col-lg-6" style="display:none;">
                                                    <div class="form-group">
                                                        <label for="parts">Price</label>
                                                        <asp:TextBox ID="txtprice" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>

                                                </div>
                                                <div class="col-lg-6">
                                                    <asp:Button ID="btnPartsFit" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Add Parts Fitted" OnClientClick="return ValidatePartsFitted()" />
                                                </div>

                                            </div>
                                            <div class="row">
                                                <div class="col-lg-12">
                                                    <div class="table-responsive">
                                                        <asp:GridView ID="grdPartsFitted" runat="server"
                                                            CssClass="table table-striped" AutoGenerateColumns="False" DataKeyNames="ID"
                                                            ShowHeaderWhenEmpty="True" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                                                            <RowStyle HorizontalAlign="Center" Font-Size="Medium" Height="50px" BackColor="#F7F6F3" ForeColor="#333333" />
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

                                                    <div class="col-lg-6">
                                                        <div class="form-group" style="display:none;">
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

                                                    <div class="col-lg-6">
                                                        <div class="form-group" style="display:none;">
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
                                                        <asp:TextBox ID="job_unfinished" CssClass="form-control removereadonly" TextMode="multiline" runat="server" />
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
                                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Submit Report" OnClientClick="return ValidateControls(this);" />

                            </div>
                             <asp:HiddenField ID="hdnJobId" runat="server" />
                             <asp:HiddenField ID="hdnVat" runat="server" />
                             <asp:HiddenField ID="hdnConfirm" runat="server" />
                             <asp:HiddenField id = "hdnModel" runat="server" />

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
                            <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>

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

    <script type="text/javascript">
        function ValidateControls(e)
        {
            var isFlag = false;
            var clsArray = Array("rgOne");
            var bnlError = false;
            for (i = 0; i < clsArray.length; i++) {
                if ($("." + clsArray[i] + " input:checked").length == 0) {
                    bnlError = true;
                    break;
                }
            }

                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Service Type Field.");
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
                    ShowPopupBlank("Please Choose Any Of Maintenance Type Field.");
                    return false;

                }
                    

                var InvoiceNo,InvoiceTo, Equipment, model, Manufacturer, SerialNo, AssetNo,TotalTime,GasLeakTest, LoadTest, FlashTest, earthleakTest, Ins, EC, MicrowaveLeak, PowerOutput, FaultReported, WorkDetails, PrintName, JobTitle;
                InvoiceNo = document.getElementById("ContentPlaceHolder1_txtInvoiceNo").value;
                InvoiceTo = document.getElementById("ContentPlaceHolder1_txtInvoiceTo").value;
                Equipment = document.getElementById("ContentPlaceHolder1_txtEquipment").value;
                model = document.getElementById("ContentPlaceHolder1_ddlModel").value;
                Manufacturer = document.getElementById("ContentPlaceHolder1_ddlManufacturer").value;
                SerialNo = document.getElementById("ContentPlaceHolder1_txtSerialNo").value;
                AssetNo = document.getElementById("ContentPlaceHolder1_txtAssetNo").value;
                TotalTime = document.getElementById("ContentPlaceHolder1_txtTotalTime").value;
                GasLeakTest = document.getElementById("ContentPlaceHolder1_txtGasLeakTest").value;
                earthleakTest = document.getElementById("ContentPlaceHolder1_txtearthleakTest").value;
                LoadTest = document.getElementById("ContentPlaceHolder1_txtLoadTest").value;
                FlashTest = document.getElementById("ContentPlaceHolder1_txtFlashTest").value;
                Ins = document.getElementById("ContentPlaceHolder1_txtIns").value;
                EC = document.getElementById("ContentPlaceHolder1_txtEC").value;
                MicrowaveLeak = document.getElementById("ContentPlaceHolder1_txtMicrowaveLeak").value;
                PowerOutput = document.getElementById("ContentPlaceHolder1_txtPowerOutput").value;
                FaultReported = document.getElementById("ContentPlaceHolder1_txtFaultReported").value;
                WorkDetails = document.getElementById("ContentPlaceHolder1_txtWorkDetails").value;
                PrintName = document.getElementById("ContentPlaceHolder1_txtPrintName").value;
                JobTitle = document.getElementById("ContentPlaceHolder1_txtJobTitle").value;
                //if (InvoiceNo == '') {
                //    ShowPopupBlank("Please Fill Invoice Number Field");
                //    return false;
                //}

                //if (InvoiceTo == '')
                //{
                //    ShowPopupBlank("Please Fill Invoice To Field");
                //    return false;
                //}
                if (Equipment == '')
                {
                    ShowPopupBlank("Please Fill Equipment Field");
                    return false;
                }
               
              
                if (Manufacturer == '') {
                    ShowPopupBlank("Please Choose Manufacturer Field");
                    return false;
                }
               
                if (model == '0') {
                    ShowPopupBlank("Please Fill Appliance Model Field");
                    return false;

                }
                if (SerialNo == '') {
                    ShowPopupBlank("Please Fill Serial No Field.");
                    return false;
                }

                if (TotalTime == '') {
                    ShowPopupBlank("Please Fill Total Time Field.");
                    return false;
                }
                //if (AssetNo == '') {
                //    ShowPopupBlank("Please Fill Asset No Field");
                //    return false;
                //}
                //if (GasLeakTest == '') {
                //    ShowPopupBlank("Please Fill Gas Leak Test Field");
                //    return false;
                //}
                //if (earthleakTest == '') {
                //    ShowPopupBlank("Please Fill earth leakage Test Field");
                //    return false;
                //}
                //if (LoadTest == '') {
                //    ShowPopupBlank("Please Fill Load Test Field");
                //    return false;
                //}
               
                //if (FlashTest == '') {
                //    ShowPopupBlank("Please Fill Flash Test Field");
                //    return false;
                //}
                
                //if (Ins == '') {
                //    ShowPopupBlank("Please Fill Ins. Res @500V Field");
                //    return false;
                //}

                
                //if (EC == '') {
                //    ShowPopupBlank("Please Fill E.C. Field");
                //    return false;
                //}
                
                //if (MicrowaveLeak == '') {
                //    ShowPopupBlank("Please Fill Microwave Leakage Field");
                //    return false;
                //}

                //if (PowerOutput == '') {
                //    ShowPopupBlank("Please Fill Power Output Field");
                //    return false;
                //}
                if (FaultReported == '') {
                    ShowPopupBlank("Please Fill Fault Reported Field");
                    return false;
                }
                
                if (WorkDetails == '') {
                    ShowPopupBlank("Please Fill Work Details Field");
                    return false;
                }
                if (PrintName == '') {
                    ShowPopupBlank("Please Fill Print Name Field");
                    return false;
                }
                if (JobTitle == '') {
                    ShowPopupBlank("Please Fill Job Title Field");
                    return false;
                }
                var chkStatus = document.getElementById("ContentPlaceHolder1_chkdeclaration");
                if (chkStatus.checked)
                {
                }
                else
                {
                    ShowPopupBlank("Kindly Check The Acknowledgement First.");
                    return false;
                }
                isFlag = true;
                var isFlagConfirmation = false;
                if (isFlag = true) {
                    isFlagConfirmation = ShowConfirmationPopup(e);
                    return isFlagConfirmation;

                }

        }

        function ValidatePartsRequire()
        {
            var Parts = document.getElementById("ContentPlaceHolder1_txtpartdescription").value;
            var Qty = document.getElementById("ContentPlaceHolder1_txtqty").value;

            if (Parts == '') {
                ShowPopupBlank("Please Fill Parts Description Field");
                return false;
            }
            if (Qty == '') {
                ShowPopupBlank("Please Fill Quantity Field");
                return false;
            }
        }

        function ValidatePartsFitted() {
            var Qty = document.getElementById("ContentPlaceHolder1_txtqtyfitted").value;
            var ProductCode = document.getElementById("ContentPlaceHolder1_txtproductcode").value;
            var description = document.getElementById("ContentPlaceHolder1_txtdescription").value;
            var price = document.getElementById("ContentPlaceHolder1_txtprice").value;

           
            if (Qty == '') {
                ShowPopupBlank("Please Fill Quantity Field");
                return false;
            }
            if (ProductCode == '') {
                ShowPopupBlank("Please Fill Product Code Field");
                return false;
            }
            
            if (description == '') {
                ShowPopupBlank("Please Fill Description Field");
                return false;
            }
            //if (price == '') {
            //    ShowPopupBlank("Please Fill Price Field");
            //    return false;
            //}
        }

       <%-- $("#<%= ddlModel.ClientID %>").change(function () {
              var e = document.getElementById("ContentPlaceHolder1_ddlModel");
              var strValue= e.options[e.selectedIndex].text;
              document.getElementById("<%= hdnModel.ClientID %>").value = strValue;
             
          });--%>

         <%--$("#<%= ddlManufacturer.ClientID %>").change(function () {
             var ManufacturerId = $("#<%= ddlManufacturer.ClientID %>").val();
               var doaction = "setModelInDropdownByManufacturerId";
                 $.post('GetAjaxData.aspx', { DoAction: doaction, ManufacturerId: ManufacturerId }, function (responseText) {
                     if (responseText.toString() != "Error") {
                         var objModelDetails = JSON.parse(responseText)
                         $("#<%= ddlModel.ClientID %>").empty();
                         //$("#ddlModel option").remove();
                         $("#<%= ddlModel.ClientID %>").append("<option value='0'>Select Model</option>");
                         for (var i = 0; i < objModelDetails.length; i++) {
                             $("#<%= ddlModel.ClientID %>").append($("<option></option>").val(objModelDetails[i].Id).html(objModelDetails[i].Value));

                         }

                     }
                     else {
                         ShowPopupBlank("Sorry Appliance Model Nos In this Selection");
                         $("#<%= ddlModel.ClientID %>").empty();
                         $("#<%= ddlModel.ClientID %>").append("<option value='0'>Select Model</option>");


                     }
                 });
             

        });--%>


     </script>

    <script>
        var isDelete = false;

        function ShowConfirmationPopup(ele) {

            if (isDelete == false) {
                swal({
                    title: "Have you filled in Parts fitted/required?",
                    text: "",
                    type: "warning",
                    showCancelButton: true,
                    confirmButtonColor: "#DD6B55",
                    confirmButtonText: "Yes, submit form",
                    cancelButtonText: "Return to form",
                    closeOnConfirm: false,
                    closeOnCancel: true

                }, function (isConfirm) {
                    if (ele, isConfirm) {
                        isDelete = true;
                        ele.click();
                    }
                    else {

                    }

                });
            }

            return isDelete;


        }



        
    </script>
</asp:Content>
