<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Job_parts_order.aspx.vb" Inherits="CRM.Job_parts_order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>


    <!-- ============================================================== -->
    <!-- Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <div class="row page-titles">
        <div class="col-md-5 align-self-center">
            <h4 class="text-themecolor">Job Parts Order</h4>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Info box -->
    <!-- ============================================================== -->

    <div class="col-lg-12 col-md-12">
        <div class="form-main-warp">
            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-body">
                            <div class="floating-labels m-t-30">
                                <div class="floating-labels m-t-30">
                                    <div class="row">
                                        <div class="col-md-3">
                                            <div class="form-group m-b-30">
                                                <asp:TextBox ID="txtCompany" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                <span class="bar"></span>
                                                <label for="ContentPlaceHolder1_txtCompany">Company Name</label>
                                            </div>
                                        </div>
                                        <div class="col-md-3">
                                            <div class="form-group m-b-30">
                                                <asp:TextBox ID="txtEngineer" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox><span class="bar"></span>
                                                <label for="ContentPlaceHolder1_txtEngineer">Engineer</label>
                                            </div>
                                        </div>
                                        <div class="col-md-3">
                                            <div class="form-group m-b-30">
                                                <asp:TextBox ID="txtJobNumber" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox><span class="bar"></span>
                                                <label for="ContentPlaceHolder1_txtJobNumber">Job Number</label>
                                            </div>
                                        </div>
                                        <div class="col-md-3">
                                            <div class="form-group m-b-30">
                                                <asp:TextBox ID="txtStatus" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox><span class="bar"></span>
                                                <label for="ContentPlaceHolder1_txtStatus">Status</label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-md-12">
            <div class="card">
                <div class="card-body">
                    <!-- Nav tabs -->
                    <ul class="nav nav-tabs" role="tablist">
                        <li class="nav-item"><a class="nav-link active" data-toggle="tab" href="#home" role="tab"><span class="hidden-sm-up">
                            <!-- <i class="ti-home"></i> -->
                        </span><span class="hidden-xs-down">Order Parts</span></a> </li>
                        <li class="nav-item"><a class="nav-link" data-toggle="tab" href="#profile" role="tab"><span class="hidden-sm-up">
                            <!-- <i class="ti-user"></i> -->
                        </span><span class="hidden-xs-down">Parts Ordered</span></a> </li>
                        <li class="nav-item"><a class="nav-link" data-toggle="tab" href="#messages" role="tab"><span class="hidden-sm-up">
                            <!-- <i class="ti-email"></i> -->
                        </span><span class="hidden-xs-down">Parts Used</span></a> </li>
                    </ul>
                    <!-- Tab panes -->
                    <div class="tab-content tabcontent-border">
                        <div class="tab-pane active" id="home" role="tabpanel">
                            <div class="first-tab-warp">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="tab-heading">
                                            <div class="card">
                                                <div class="card-body">
                                                    <h3>Search for Parts</h3>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-3">
                                        <div class="form-gride">
                                            <div class="card">
                                                <div class="card-body">
                                                    <div class="floating-labels">
                                                        <div class="form-group m-b-40">


                                                            <asp:TextBox ID="txtAppliance" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtAppliance">Appliance</label>
                                                        </div>
                                                        <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtpart" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtFault">Part Number</label>
                                                        </div>
                                                        <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtOrderNo" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtOrderNo">Manufacturer Name</label>
                                                        </div>
                                                        <div class="form-group m-b-40">
                                                            <asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Search" />
                                                            <asp:Button ID="btnClear" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Clear Search" />
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-9">
                                        <div class="table-warp">
                                            <div class="row">
                                                <div class="col-12">
                                                    <div class="card">
                                                        <div class="card-body">
                                                            <div class="table-responsive">

                                                                <%--<asp:Repeater id="RptJobList"  runat="server">
                     <HeaderTemplate>
              <table id="example23" class="display nowrap table table-hover table-striped table-bordered" cellspacing="0" width="100%">
              <thead>
                <tr>
                   <th>
                      A
                   </th>
                   <th>
                     B
                   </th>
                   <th>
                      C
                   </th>
                   <th>
                      D
                   </th>
                   <th>
                     E
                   </th>
                </tr>
                </thead>
                 <tbody>
          </HeaderTemplate>
          <ItemTemplate>
             <tr>
                <td>
                   <%#Eval("A")%>
                     
                </td>
                <td>
                    <%#Eval("B")%>
                </td>
                <td>
                    <%#Eval("C")%>
                </td>
                <td>
                    <%#Eval("D")%>
                </td>
                <td>
                   <%#Eval("E")%>
                </td>
             </tr>
          </ItemTemplate>
           <FooterTemplate>
               </tbody>     
               </table>       
           </FooterTemplate>
</asp:Repeater>--%>

                                                                <asp:GridView ID="grdParts" runat="server"
                                                                    AllowPaging="True" PageSize="10" CssClass="display nowrap table table-hover table-striped table-bordered" CellSpacing="0" Width="100%" AutoGenerateColumns="False"
                                                                    EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="PartID">
                                                                    <HeaderStyle Font-Size="Small" Height="25px" />
                                                                    <Columns>
                                                                        <asp:CommandField ShowSelectButton="true" HeaderText="Information"/>
                                                                        <asp:BoundField DataField="PartID" HeaderText="ID" Visible="false" />
                                                                        <asp:BoundField DataField="PartNumber" HeaderText="Part Number" ReadOnly="true" />
                                                                        <asp:BoundField DataField="ManufacturerName" HeaderText="Manufacturer Name" ReadOnly="true" />
                                                                        <asp:BoundField DataField="Model" HeaderText="Model" ReadOnly="true" />
                                                                        <asp:BoundField DataField="SerialNumber" HeaderText="SerialNumber" ReadOnly="true" />
                                                                        <asp:BoundField DataField="ApplianceType" HeaderText="ApplianceType" ReadOnly="true" />
                                                                        <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="true" />

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
                            </div>

                            <div class="second-section">
                                <div class="second-section-heading">
                                    <div class="card">
                                        <div class="card-body">
                                            <h3 class="tab-heading">Search Results</h3>
                                        </div>
                                    </div>
                                </div>

                                <div class="tab-datatable">
                                    <div class="row">
                                        <div class="col-12">
                                            <div class="card">
                                                <div class="card-body">
                                                    <div class="table-responsive">
                                                        
                                                        <asp:GridView ID="grdPartsPrice" runat="server"
                                                            AllowPaging="True" PageSize="10" CssClass="display nowrap table table-hover table-striped table-bordered" CellSpacing="0" Width="100%" AutoGenerateColumns="False"
                                                            EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True">
                                                            <HeaderStyle Font-Size="Small" Height="25px" />
                                                            <Columns>

                                                                <asp:BoundField DataField="SupplierName" HeaderText="SupplierName" ReadOnly="true" />
                                                                <asp:BoundField DataField="Price" HeaderText="FF Cost Price" ReadOnly="true" />
                                                                <asp:TemplateField HeaderText="Price Date">
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="LABEL_PriceDt" runat="server" Text='<%# SetDateVal(Eval("PriceDate")) %>' />
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                                <asp:BoundField DataField="SuppliersPartNumber" HeaderText="Suppliers Part Number" ReadOnly="true" />
                                                                <asp:BoundField DataField="Notes" HeaderText="Notes" ReadOnly="true" />


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

                            <div class="section-three">
                                <div class="second-section-heading">
                                    <div class="card">
                                        <div class="card-body">
                                            <h3 class="tab-heading">Add part to job</h3>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="card">
                                            <div class="card-body">
                                                <div class="floating-labels">
                                                    <div class="form-selection-box padddng-btn m-b-40">
                                                        <asp:DropDownList ID="ddlqty" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                                        </asp:DropDownList>

                                                    </div>
                                                    <div class="form-group m-b-40">
                                                        <asp:TextBox ID="txtEngiRef" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtEngiRef">EngiRef:</label>
                                                    </div>
                                                    <div class="form-group m-b-40">
                                                        <asp:TextBox ID="txtPartNo" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtPartNo">Part Number</label>
                                                    </div>
                                                    <div class="form-group m-b-40">
                                                        <label>Description:</label>
                                                        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" CssClass="form-control input-sm"></asp:TextBox>
                                                    </div>
                                                    <div class="form-group m-b-40">
                                                        <asp:TextBox ID="txtMenuList" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtMenuList">Manufacturer List Price</label>
                                                    </div>
                                                    <div class="example datepicker form-selection-box m-b-40">
                                                        <div class="input-group">
                                                            <asp:TextBox ID="txtDate" runat="server" CssClass="form-control mydatepicker" placeholder="List Price Date"></asp:TextBox>

                                                            <div class="input-group-append">
                                                                <span class="input-group-text"><i class="icon-calender"></i></span>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="form-group m-b-40">
                                                        <asp:TextBox ID="txtxFFsellPrice" runat="server" TextMode="MultiLine" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtxFFsellPrice">FF SellPrice</label>
                                                    </div>
                                                    <div class="example datepicker form-selection-box m-b-40">
                                                        <div class="input-group">
                                                            <asp:TextBox ID="txtSellingPriceDate" runat="server" CssClass="form-control mydatepicker" placeholder="Selling Price Date"></asp:TextBox>

                                                            <div class="input-group-append">
                                                                <span class="input-group-text"><i class="icon-calender"></i></span>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="form-group m-b-40">
                                                        <asp:TextBox ID="txtFFSellPrice" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox><span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtFFSellPrice">FF SellPrice</label>
                                                    </div>


                                                </div>
                                                <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Add Part Order For This JOB ..." OnClientClick="return ValidateControls();" />

                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane  p-20" id="profile" role="tabpanel">
                            <div class="datagride-tab-two">
                                <div class="row">
                                    <div class="col-12">
                                        <div class="card">
                                            <div class="card-body">
                                                <h4 class="card-title">Parts Ordered</h4>
                                                <div class="table-responsive m-t-40">
                                                    <%--<asp:Repeater id="Repeater2"  runat="server">
                     <HeaderTemplate>
              <table id="example25" class="display nowrap table table-hover table-striped table-bordered" cellspacing="0" width="100%">
              <thead>
                <tr>
                   <th>
                      A
                   </th>
                   <th>
                     B
                   </th>
                   <th>
                      C
                   </th>
                   <th>
                      D
                   </th>
                   <th>
                     E
                   </th>
                </tr>
                </thead>
                 <tbody>
          </HeaderTemplate>
          <ItemTemplate>
             <tr>
                <td>
                   <%#Eval("A")%>
                     
                </td>
                <td>
                    <%#Eval("B")%>
                </td>
                <td>
                    <%#Eval("C")%>
                </td>
                <td>
                    <%#Eval("D")%>
                </td>
                <td>
                   <%#Eval("E")%>
                </td>
             </tr>
          </ItemTemplate>
           <FooterTemplate>
               </tbody>     
               </table>       
           </FooterTemplate>
</asp:Repeater>--%>

                                                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                        <ContentTemplate>
                                                            <asp:GridView ID="grdOrder" runat="server"
                                                                AllowPaging="True" PageSize="10" CssClass="display nowrap table table-hover table-striped table-bordered" CellSpacing="0" Width="100%" AutoGenerateColumns="False"
                                                                EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="RequestID">
                                                                <HeaderStyle Font-Size="Small" Height="25px" />
                                                                <Columns>

                                                                    <asp:BoundField DataField="RequestID" HeaderText="ID" Visible="false" />
                                                                    <asp:TemplateField HeaderText="Eng N">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="LABEL_engineers" runat="server" Text='<%#Eval("EngineersNos")%>' />
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <asp:TextBox ID="txtengineers" runat="server" Text='<%# Eval("EngineersNos")%>' />
                                                                        </EditItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:BoundField DataField="Appliance" HeaderText="Appliance" ReadOnly="true" />
                                                                    <asp:BoundField DataField="Manufacture" HeaderText="Manufacture Name" ReadOnly="true" />
                                                                    <asp:BoundField DataField="Model" HeaderText="Model" ReadOnly="true" />
                                                                    <asp:TemplateField HeaderText="Notes">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="LABEL_notes" runat="server" Text='<%#Eval("Notes")%>' />
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <asp:TextBox ID="txtNotes" runat="server" Text='<%# Eval("Notes")%>' />
                                                                        </EditItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:BoundField DataField="PartNumber" HeaderText="Part Number" ReadOnly="true" />
                                                                    <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="true" />
                                                                    <asp:TemplateField HeaderText="Qty">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="LABEL_qty" runat="server" Text='<%#Eval("Qty")%>' />
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <asp:TextBox ID="txtqty" runat="server" Text='<%# Eval("Qty")%>' />
                                                                        </EditItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:BoundField DataField="Rec" HeaderText="Rec" ReadOnly="true" />
                                                                    <asp:BoundField DataField="Await" HeaderText="Await" ReadOnly="true" />
                                                                    <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" />

                                                                </Columns>
                                                                <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" />
                                                            </asp:GridView>
                                                        </ContentTemplate>

                                                    </asp:UpdatePanel>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane p-20" id="messages" role="tabpanel">
                            <div class="datagride-tab-two">
                                <div class="row">
                                    <div class="col-12">
                                        <div class="card">
                                            <div class="card-body">
                                                <h4 class="card-title">Custom Order For Job,Specialy Bought in</h4>
                                                <div class="table-responsive m-t-40">
                                                    <asp:GridView ID="grdUsed" runat="server"
                                                        AllowPaging="True" PageSize="10" CssClass="display nowrap table table-hover table-striped table-bordered" CellSpacing="0" Width="100%" AutoGenerateColumns="False"
                                                        EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="RequestID">
                                                        <HeaderStyle Font-Size="Small" Height="25px" />
                                                        <Columns>
                                                            <%--                    <asp:CommandField ShowSelectButton="true" />--%>
                                                            <asp:BoundField DataField="RequestID" HeaderText="ID" Visible="false" />
                                                            <asp:BoundField DataField="Quantity" HeaderText="Quantity" ReadOnly="true" />
                                                            <asp:BoundField DataField="Parts" HeaderText="Parts" ReadOnly="true" />
                                                            <asp:BoundField DataField="Cost" HeaderText="Cost" ReadOnly="true" />
                                                            <asp:BoundField DataField="DiscountRecievedOnThisOrder" HeaderText="DiscountRecievedOnThisOrder" ReadOnly="true" />
                                                            <asp:BoundField DataField="TotalCost" HeaderText="TotalCost" ReadOnly="true" />

                                                        </Columns>
                                                        <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" />
                                                    </asp:GridView>

                                                    <div class="form-group m-b-30">
                                                        <label for="ContentPlaceHolder1_txttotalpricebyFF">Total Cost Price Paid by FF</label>
                                                        <asp:TextBox ID="txttotalpriceBYFF" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>

                                                    </div>
                                                </div>

                                                <div class="table-responsive m-t-40">
                                                    <asp:GridView ID="grdStock" runat="server"
                                                        PageSize="10" CssClass="display nowrap table table-hover table-striped table-bordered" CellSpacing="0" Width="100%" AutoGenerateColumns="False"
                                                        EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True">
                                                        <HeaderStyle Font-Size="Small" Height="25px" />
                                                        <Columns>
                                                            <asp:BoundField DataField="Description" HeaderText="Part" />
                                                            <asp:TemplateField HeaderText="Stock Date">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_Sdate" runat="server" Text='<%# SetDateVal(Eval("StockDate")) %>' />
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Location" HeaderText="Location" ReadOnly="true" />

                                                            <asp:TemplateField HeaderText="List Price">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_Listprice" runat="server" Text=' <%# Eval("ManufacturersListPrice","{0:N2}") %>' />
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Selling Price">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_sellingprice" runat="server" Text=' <%# Eval("FastFixxSellingPrice", "{0:N2}") %>' />
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Selling Price Date">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_SPriceDt" runat="server" Text='<%# SetDateVal(Eval("SellingPriceDate")) %>' />
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
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
                </div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="hdnPartId" runat="server" />
    <script type="text/javascript">
        function ValidateControls() {
            var qty;
            qty = document.getElementById("ContentPlaceHolder1_ddlqty").value;
            if (qty == '') {
                ShowPopupBlank("Please Fill Quantity Field.");
                return false;
            }

        }
    </script>
</asp:Content>

