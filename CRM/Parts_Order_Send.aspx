<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Parts_Order_Send.aspx.vb" Inherits="CRM.Parts_Order_Send" %>

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
                    <h4 class="text-themecolor">Send Parts Order</h4>
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
                                                                                        <asp:HiddenField ID="hdnSupplierId" runat="server" />

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

                                                    <p>Purchase Orders Output Options</p>

                                                    <li>
                                                        <asp:RadioButton ID="flatradio1" CssClass="check" GroupName="1stGroup" data-radio="iradio_flat-red" runat="server" AutoPostBack="true" />
                                                        <label for="flat-radio-1">Print Preview</label>
                                                    </li>
                                                    <li>
                                                        <asp:RadioButton ID="flatradio2" CssClass="check" GroupName="1stGroup" data-radio="iradio_flat-red" runat="server" Visible="false"  />
                                                        <label for="flat-radio-2"></label>
                                                    </li>
                                                    <li>
                                                        <asp:RadioButton ID="flatradio3" CssClass="check" GroupName="1stGroup" data-radio="iradio_flat-red" runat="server" />
                                                        <label for="flat-radio-3">Send As Email</label>
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
                <div class="form-main-warp search-main-warp cost-warp select-warp-section">
                    <div class="card">
                        <div class="card-body">
                            <div class="floating-labels search-table m-t-30">
                                <div class="floating-labels">
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtSupplierName" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtSupplierName">SupplierName</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtAddress1" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtAddress1">Address1</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtAddress2" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtAddress2">Address2</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtTown" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtTown">Town</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtPostCode" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtPostCode">Postcode</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtPhone">phone</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtEmail">Email</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtNotes" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtNotes">Notes</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <label>Email Message:</label>
                                        <asp:TextBox ID="txtEmailMsg" CssClass="form-control" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                                    </div>
                                         <div class="button-group note-btn">
                             <asp:Button ID="btnSend" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Send"/>
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

     <script language="javascript" type="text/javascript">

   function printPDF(pdfUrl)
   {
var w = window.open(pdfUrl);
w.print();
w.close();
}

</script>
</asp:Content>
