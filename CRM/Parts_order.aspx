<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Parts_order.aspx.vb" Inherits="CRM.Parts_order" %>

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
            <h4 class="text-themecolor">Parts Order</h4>
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
                                        <div class="form-group m-b-30" id="divExisting" runat="server">
                                            <asp:TextBox ID="txtsupplier" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtsupplier">Supplier</label>
                                        </div>
                                          <div class="form-selection-box padddng-btn m-b-40"  id="divNew" runat="server">
                                    <asp:DropDownList ID="ddlSupplier" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                    </asp:DropDownList>
                                </div>
                                    </div>
                                    <div class="col-md-3">
                                        <div class="form-group m-b-30">
                                            <asp:TextBox ID="txtOrderNo1" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtOrderNo1">Order Number</label>
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
        <div class="form-main-warp search-main-warp cost-warp select-warp-section part_radio">
            <div class="card">
                <div class="card-body">
                    <div class="floating-labels search-table">
                        <div class="form-group">
                            <div class="skin skin-flat check-main-warp">
                                <div class="form-group">
                                    <div class="input-group">
                                        <ul class="icheck-list costs-main">
                                            <li>
                                                <p>View</p>
                                            </li>
                                            <li>
                                                <asp:RadioButton ID="flatradio1" runat="server" CssClass="check" GroupName="1stGroup" AutoPostBack="True" />
                                                <label for="flat-radio-1">To Be Ordered</label>
                                            </li>
                                            <li>
                                                <asp:RadioButton ID="flatradio2" CssClass="check" GroupName="1stGroup" runat="server" AutoPostBack="True" />
                                                <label for="flat-radio-2">On Order</label>
                                            </li>

                                        </ul>
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
        <div class="col-lg-12 col-md-12 select-main-table">
            <div class="row">
                <div class="card">
                    <div class="card-body">
                        <div class="table-responsive">
                            
                            <asp:GridView ID="grdOrderedParts" runat="server"
                                AllowPaging="True" PageSize="50" CssClass="table table-striped clsResizeColumn" AutoGenerateColumns="False" DataKeyNames="RequestID"
                                EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True">
                                <HeaderStyle Font-Size="Small" Height="25px" />
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkRow" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="RequestID" HeaderText="ID" Visible="false" />
                                    <asp:TemplateField HeaderText="Country" Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblRequestId" runat="server" Text='<%# Eval("RequestID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="ApplianceType" HeaderText="Appliance" ReadOnly="true" />
                                    <asp:BoundField DataField="ManufacturerName" HeaderText="Manufacturer Name" ReadOnly="true" />
                                    <asp:BoundField DataField="Model" HeaderText="Model" ReadOnly="true" />
                                    <asp:BoundField DataField="PartNumber" HeaderText="Part Number" ReadOnly="true" />
                                    <asp:BoundField DataField="Quantity" HeaderText="Req Qty" ReadOnly="true" />
                                    <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="true" />
                                    <asp:BoundField DataField="JobId" HeaderText="Job ID" ReadOnly="true" />
                                    <asp:BoundField DataField="EngineersNos" HeaderText="EngineersNos" ReadOnly="true" />
                                    <asp:TemplateField HeaderText="Cost">
                                        <ItemTemplate>
                                            <asp:Label ID="txtcost" runat="server" Text='<%#Eval("Cost", "{0:N2}") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Notes" HeaderText="Notes" ReadOnly="true" />
                                    <asp:CommandField ShowSelectButton="True" HeaderText="Information"/>
                                </Columns>
                                <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" />
                            </asp:GridView>

                            <asp:GridView ID="grdToBeOrder" runat="server"
                                AllowPaging="True" PageSize="10" CssClass="table table-striped" AutoGenerateColumns="False" DataKeyNames="RequestID"
                                EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True">
                                <HeaderStyle Font-Size="Small" Height="25px" />
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkRow" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="RequestID" HeaderText="ID" Visible="false" />
                                    <asp:TemplateField HeaderText="Country" Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblRequestId" runat="server" Text='<%# Eval("RequestID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="ApplianceType" HeaderText="Appliance" ReadOnly="true" />
                                    <asp:BoundField DataField="ManufacturerName" HeaderText="Manufacturer Name" ReadOnly="true" />
                                    <asp:BoundField DataField="Model" HeaderText="Model" ReadOnly="true" />
                                    <asp:BoundField DataField="PartNumber" HeaderText="Part Number" ReadOnly="true" />
                                    <asp:BoundField DataField="Quantity" HeaderText="Req Qty" ReadOnly="true" />
                                    <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="true" />
                                    <asp:BoundField DataField="Notes" HeaderText="Notes" ReadOnly="true" />
                                    <asp:BoundField DataField="JobNumber" HeaderText="Job" ReadOnly="true" />

                                </Columns>
                                <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" />
                            </asp:GridView>
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
                                <div class="example datepicker form-selection-box">
                                    <div class="input-group">
                                        <asp:TextBox ID="txtOrderDate" runat="server" CssClass="form-control mydatepicker" placeholder="Order Date"></asp:TextBox>
                                        <div class="input-group-append">
                                            <span class="input-group-text"><i class="icon-calender"></i></span>
                                        </div>
                                    </div>
                                </div>
                                <div class="example datepicker form-selection-box">
                                    <div class="input-group">
                                        <asp:TextBox ID="txtCloseDate" runat="server" CssClass="form-control mydatepicker" placeholder="Closed Date"></asp:TextBox>
                                        <div class="input-group-append">
                                            <span class="input-group-text"><i class="icon-calender"></i></span>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group m-b-30">
                                    <label>Order Footer Notes For Print:</label>
                                    <asp:TextBox ID="txtOrderFooterNotes" CssClass="form-control" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                                </div>
                                <div class="form-group m-b-40">
                                    <asp:TextBox ID="txtOrderNo" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                    <span class="bar"></span>
                                    <label for="ContentPlaceHolder1_txtOrderNo">Order Numbers</label>
                                </div>
                                <div class="button-group note-btn">
                                <asp:Button ID="btnProcess" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="PROCESS"/>
                                <asp:Button ID="btnPrint" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="PRINT" />
                                    </div>
                                <asp:HiddenField ID="hdnSupplierId" runat="server" />


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
    <script type="text/javascript">
           $(document).ready(function () {
               $('#<%=btnProcess.ClientID%>').click(
                   function (e) {
                       var legchecked = $("input[type='checkbox']:checked").length;
                       if (legchecked == 0) {
                           ShowPopupBlank("Please Check Any of these Checkbox before Process.");
                           e.preventDefault();
                       }
                   });
           });

       
        </script>
</asp:Content>
