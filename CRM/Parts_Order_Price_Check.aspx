<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Parts_Order_Price_Check.aspx.vb" Inherits="CRM.Parts_Order_Price_Check" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>

    <!-- Page wrapper  -->
    <!-- ============================================================== -->
    
        <!-- ============================================================== -->
        <!-- Container fluid  -->
        <!-- ============================================================== -->
    
            <!-- ============================================================== -->
            <!-- Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
            <div class="row page-titles">
                <div class="col-md-5 align-self-center">
                    <h4 class="text-themecolor">Parts Order - Price Check</h4>
                </div>
            </div>
            <!-- ============================================================== -->
            <!-- End Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- Info box -->
            <!-- ============================================================== -->

            <div class="row">
                <div class="col-lg-12 col-md-12">
                    <div class="form-main-warp">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="card">
                                    <div class="card-body">
                                        <div class="floating-labels m-t-30">
                                            <form class="floating-labels m-t-30">
                                                <div class="row">
                                                    <div class="col-md-3">
                                                        <div class="form-group m-b-30">
                                                            <asp:TextBox ID="txtsupplier" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtsupplier">Supplier</label>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-3">
                                                        <div class="form-group m-b-30">
                                                            <asp:TextBox ID="txtOrderNo" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtOrderNo">Order Number</label>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-3">
                                                        <div class="form-group m-b-30">
                                                            <asp:TextBox ID="txtTotalCost" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtTotalCost">Total EX VAT</label>
                                                        </div>
                                                    </div>
                                                
                                                </div>
                                            </form>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="company-form">
                        <div class="row">
                            <div class="col-12">
                                <div class="card">
                                    <div class="card-body">
                                        <div class="table-responsive">
                                             <asp:GridView ID="grdPriceCheck" runat="server" 
                AllowPaging="True" PageSize="50" CssClass="table table-striped" AutoGenerateColumns="False" DataKeyNames="PartID" 
                emptydatatext="No Records Found" ShowHeaderWhenEmpty="True">
                <HeaderStyle Font-Size="Small" Height="25px" />
                <Columns>
                     <asp:CommandField ShowSelectButton="true" HeaderText="Information"/>
                    <asp:BoundField DataField="PartID" HeaderText="ID" Visible="false" />
                    <asp:BoundField DataField="Appliance" HeaderText="Appliance" ReadOnly="true" />
                    
              </Columns>
              <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px"/>
                        </asp:GridView>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="company-form">
                        <div class="row">
                            <div class="col-12">
                                <div class="card">
                                    <div class="card-body">
                                        <div class="table-responsive">
                                             <asp:GridView ID="grdSupplier" runat="server" 
                CssClass="table table-striped" AutoGenerateColumns="False" 
                emptydatatext="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="PartPriceID" OnRowDataBound="grdSupplier_RowDataBound" >
                <HeaderStyle Font-Size="Small" Height="25px" />
                <Columns>
                  <asp:BoundField DataField="PartPriceID" HeaderText="ID" Visible="false" />
                   <asp:BoundField DataField="PartID" HeaderText="PartID" Visible="false" />
                     <asp:TemplateField HeaderText = "Supplier">
            <ItemTemplate>
                <asp:Label ID="lblsupplier" runat="server" Text='<%# Eval("SupplierName") %>'/>
               
            </ItemTemplate>
          <EditItemTemplate>
           <asp:Label ID="lblsupplier" runat="server" Text='<%# Eval("SupplierID") %>' Visible ="false" />
          <asp:DropDownList ID="ddlSupplier" runat="server">
                </asp:DropDownList>
                             </EditItemTemplate>

        </asp:TemplateField>
                      <asp:TemplateField HeaderText="Price">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_price" runat="server" Text='<%# Eval("Price", "{0:N2}") %>'/>
                        </ItemTemplate>
                               <EditItemTemplate>
                            <asp:TextBox ID="txtprice" runat="server" Text='<%# Eval("Price", "{0:N2}") %>'/>
                        </EditItemTemplate>
                         </asp:TemplateField>

                     <asp:TemplateField HeaderText="Price Date">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_PriceDt" runat="server" Text='<%# SetDateVal(Eval("PriceDate")) %>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="SuppliersPartNumber" HeaderText="Suppliers Part Number" ReadOnly="true" />
                       <asp:TemplateField HeaderText="Notes">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_Notes" runat="server" Text='<%# Eval("Notes") %>'/>
                        </ItemTemplate>
                               <EditItemTemplate>
                            <asp:TextBox ID="txtnotes" runat="server" Text='<%# Eval("Notes") %>' TextMode="MultiLine"/>
                        </EditItemTemplate>
                         </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True"/>
              </Columns>
              <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px"/>
                        </asp:GridView>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <asp:HiddenField ID="hdnPartid" runat="server" />
                </div>
            </div>
    <!-- ============================================================== -->
    <!-- End Container fluid  -->
    <!-- ============================================================== -->
</asp:Content>
