<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Parts_Order_book_in_parts.aspx.vb" Inherits="CRM.Parts_Order_book_in_parts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>
     <style type="text/css">
  .Hide { display:none; }
</style>
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
                    <h4 class="text-themecolor">Parts Order - Book in Parts</h4>
                </div>
            </div>
            <!-- ============================================================== -->
            <!-- End Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- Info box -->
            <!-- ============================================================== -->
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
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
            <div class="row">
                <div class="col-lg-12 col-md-12">
                    <div class="row">
                        <div class="col-12">
                            <div class="card">
                                <div class="card-body">
                                    <div class="table-responsive">
                                        <asp:GridView ID="grdPartsBook" runat="server" 
                CssClass="table table-striped clsResizeColumn" AutoGenerateColumns="False" 
                emptydatatext="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="RequestID" AutoGenerateSelectButton="True">
                <HeaderStyle Font-Size="Small" Height="25px" />
                <Columns>
                     <asp:BoundField DataField="RequestID" HeaderText="RequestID">
                        <ItemStyle CssClass="Hide" />
                        <HeaderStyle CssClass="Hide" />
                    </asp:BoundField>
                      <asp:BoundField DataField="PartNumber" HeaderText="PartNumber" ReadOnly="true" />
                    <asp:BoundField DataField="Appliance" HeaderText="Appliance" ReadOnly="true" />
                     <asp:BoundField DataField="Model" HeaderText="Model" ReadOnly="true" />
                    <asp:BoundField DataField="ManufacturerName" HeaderText="Manufacturer" ReadOnly="true" />
                    <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="true" />
                     <asp:BoundField DataField="JobNumber" HeaderText="Job Number" ReadOnly="true" />
                     <asp:BoundField DataField="Quantity" HeaderText="Quantity" ReadOnly="true" />
                     <asp:BoundField DataField="Recieved" HeaderText="Recieved" ReadOnly="true" />
                     <asp:BoundField DataField="Awaiting" HeaderText="Awaiting" ReadOnly="true" />

              </Columns>
              <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px"/>
                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="hdnRequestid" runat="server" />
            <div class="row">
                <div class="col-lg-12 col-md-12">
                    <div class="row">
                        <div class="col-12">
                            <div class="card">
                                <div class="card-body">
                                    <div class="table-responsive">
                                        <asp:GridView ID="grdPartReceived" runat="server" 
                CssClass="table table-striped clsResizeColumn" AutoGenerateColumns="False" 
                emptydatatext="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="PartRecievedID">
                <HeaderStyle Font-Size="Small" Height="25px" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True"/>
                  <asp:BoundField DataField="PartRecievedID" HeaderText="ID" Visible="false" />
                   <asp:BoundField DataField="PartNumber" HeaderText="PartNumber" ReadOnly="true" />
                   <asp:BoundField DataField="Model" HeaderText="Model" ReadOnly="true" />
                    <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="true" />
                   
                     <asp:TemplateField HeaderText="Date">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_PriceDt" runat="server" Text='<%# SetDateVal(Eval("DateRecieved")) %>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:BoundField DataField="Quantity" HeaderText="Quantity" ReadOnly="true" />
                     <asp:BoundField DataField="Notes" HeaderText="Notes" ReadOnly="true" />
                                         <asp:BoundField DataField="Type" HeaderText="Type" ReadOnly="true" />

              </Columns>
              <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px"/>
                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="part_footer">
                <div class="row">
                    <div class="form-main-warp">
                        <div class="card">
                            <div class="card-body">
                                <div class="col-md-6">
                                    <div class="floating-labels search-table">
                                       <br /><br />
                                        <div class="form-group m-b-40">
                                             <asp:TextBox ID="txtqty" CssClass="form-control input-sm" runat="server" />
                                             <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtqty">Numbers</label>
                                        </div>
                                        <div class="form-group m-b-40">
                                             <asp:TextBox ID="txtnotes" runat="server" CssClass="form-control input-sm" TextMode="multiline" Rows="3" ></asp:TextBox>
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtnotes">Notes</label>
                                        </div>
                                        <div class="button-group note-btn">
         <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Add Receipt of Part"/> 
</div>


                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>                                                       

                </div>

            </div>
            



      
    <!-- ============================================================== -->
    <!-- End Container fluid  -->
    <!-- ============================================================== -->
</asp:Content>
