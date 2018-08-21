<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Job_orderdetailsShow.aspx.vb" Inherits="CRM.Job_orderdetailsShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>

    <!-- ============================================================== -->
    <!-- Container fluid  -->
    <!-- ============================================================== -->

    <!-- ============================================================== -->
    <!-- Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <div class="row page-titles">
        <div class="col-md-5 align-self-center">
            <h4 class="text-themecolor">Job - Order Details</h4>
        </div>
    </div>
    <div class="row">

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
                                                    <asp:TextBox ID="txtCompany" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox><span class="bar"></span>
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

                                        <div class="row">
                                            <div class="col-md-3">
                                                <div class="form-group m-b-30">
                                                    <asp:TextBox ID="txtExvat" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox><span class="bar"></span>
                                                    <label for="ContentPlaceHolder1_txtExvat">Ex VAT</label>
                                                </div>
                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-group m-b-30">
                                                    <asp:TextBox ID="txtVat" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox><span class="bar"></span>
                                                    <label for="ContentPlaceHolder1_txtVat">VAT</label>
                                                </div>
                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-group m-b-30">
                                                    <asp:TextBox ID="txtOrderTotal" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox><span class="bar"></span>
                                                    <label for="ContentPlaceHolder1_txtOrderTotal">Order total </label>
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
            <div class="form-main-warp">
                <div class="row">
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-body">
                                <div class="floating-labels m-t-40">
                                     <div class="form-selection-box padddng-btn m-b-40">
                                        <asp:DropDownList ID="ddlCompany" runat="server" CssClass="selectpicker">
                                        </asp:DropDownList>

                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtPhone">Phone</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtStatus1" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtStatus1">Status</label>
                                    </div>
                                    <div class="form-selection-box padddng-btn m-b-40">
                                        <asp:DropDownList ID="ddlstatus" runat="server" CssClass="selectpicker">
                                        </asp:DropDownList>

                                    </div>
                                    <div class="example datepicker form-selection-box m-b-40">
                                        <div class="input-group">
                                            <asp:TextBox ID="txtCalender" runat="server" CssClass="form-control mydatepicker" placeholder="inquiry date"></asp:TextBox>

                                            <div class="input-group-append">
                                                <span class="input-group-text"><i class="icon-calender"></i></span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtAssetNumber" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtAssetNumber">Asset Number</label>
                                    </div>

                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtJobNumber1" runat="server" CssClass="form-control input-sm"> </asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtJobNumber1">Job Number</label>
                                    </div>


                                    <div class="form-group m-b-40">
                                        <label  style="font-size:16px;    padding-left: 10px;">Fault</label>
                                        <asp:TextBox ID="txtFault" runat="server" CssClass="form-control" TextMode="MultiLine"> </asp:TextBox>

                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtOrderNumber" runat="server" CssClass="form-control input-sm"> </asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtOrderNumber">Order Number</label>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-body">
                                <div class="floating-labels m-t-40">
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtResponse" runat="server" CssClass="form-control input-sm"> </asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtResponse">Response</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtPermission" runat="server" CssClass="form-control input-sm"> </asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtPermission">Premises</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtAddress1" runat="server" CssClass="form-control input-sm"> </asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtAddress1">Address 1</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtAddress2" runat="server" CssClass="form-control input-sm"> </asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtAddress2">Address 2</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtAddress3" runat="server" CssClass="form-control input-sm"> </asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtAddress3">Address 3</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtPermissionPostCode" runat="server" CssClass="form-control input-sm"> </asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtPermissionPostCode">Premises postcode</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtEngineer1" runat="server" CssClass="form-control input-sm"> </asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtEngineer1">Engineer</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtEngineersheetdate" runat="server" CssClass="form-control input-sm"> </asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtEngineersheetdate">Engineer SheetDate</label>
                                    </div>

                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtAppliance" runat="server" CssClass="form-control input-sm"> </asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtAppliance">Appliance</label>
                                    </div>
                                    <div class="form-selection-box padddng-btn m-b-30">
                                        <asp:DropDownList ID="ddlAppliance" runat="server" CssClass="selectpicker">
                                        </asp:DropDownList>

                                    </div>
                                     <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtContactName" runat="server" CssClass="form-control input-sm"> </asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtContactName">Contact Name</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtTelphone" runat="server" CssClass="form-control input-sm"> </asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtTelphone">Telephone</label>
                                    </div>
                                    <div class="form-selection-box padddng-btn m-b-30">
                                        <asp:DropDownList ID="ddlstatus3" runat="server" CssClass="selectpicker">
                                            <asp:ListItem Text="Repair" Value="Repair"></asp:ListItem>
                                            <asp:ListItem Text="PPM" Value="PPM"></asp:ListItem>
                                            <asp:ListItem Text="Installation" Value="Instalation"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>




                                </div>
                                    <div class="button-group note-btn">
                                <asp:Button ID="Update" runat="server" Text="Update" CssClass="btn btn-outline-success btn-rounded m-t-30" />
                                <asp:Button ID="btnArchive" runat="server" Text="Archive" CssClass="btn btn-outline-success btn-rounded m-t-30" OnClientClick="return ShowDeletePopup(this, 'Record will be Permanently Deleted');" />
                                <asp:Button ID="btnPrint" runat="server" Text="Print" CssClass="btn btn-outline-success btn-rounded m-t-30"/>

                            </div>
                                </div>

                        </div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="hdnCid" runat="server" />
            <asp:HiddenField ID="hdnJobid" runat="server" />

        </div>
    </div>
 <div class="col-md-5 align-self-center">
         <h4 class="text-themecolor" style="font-weight:bold;">Parts Ordered On Job</h4>
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
     <script type="text/javascript">
        $(document).ready(function () {
            $("#jobsli").attr("class", "has-arrow waves-effect waves-dark active");
            $("#jobsul").attr("class","collapse in");
            $("#jobhref").attr("class", "active");
           
        });
    </script>
</asp:Content>
