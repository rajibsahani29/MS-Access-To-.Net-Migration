<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="gas-inspection-select-company.aspx.vb" Inherits="CRM.gas_inspection_select_company" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- ============================================================== -->
    <!-- Container fluid  -->
    <!-- ============================================================== -->

    <!-- ============================================================== -->
    <!-- Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <div class="row page-titles">
        <div class="col-md-5 align-self-center">
            <h4 class="text-themecolor">Gas Inspection - Select Company</h4>
        </div>
        <div class="col-md-7 align-self-center text-right">
            <div class="d-flex justify-content-end align-items-center">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="index.aspx">Home</a></li>
                    <li class="breadcrumb-item active">Gas Inspection - Select Company</li>
                </ol>
                <button type="button" class="btn btn-info d-none d-lg-block m-l-15"><i class="fa fa-plus-circle"></i>Create New</button>
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Start Page Content -->
    <!-- ============================================================== -->

    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="form-main-warp">
                <div class="row">
                    <div class="col-md-12">
                        <div class="card">
                            <div class="card-body">

                                <div class="row">
                                    <div class="col-md-5">
                                        <div class="form-group m-b-30" style="margin-top:10px;margin-left:10px;">
                                            <asp:DropDownList ID="ddlCompany" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary"></asp:DropDownList>

                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-5">
                                      
                                <div class="button-group note-btn">
                                            <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Search" OnClientClick="return ValidateControls()" />

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
    <div class="company-form">
        <div class="row">
            <div class="col-12">
                <div class="card" style="left: 0px; top: 0px">
                    <div class="card-body">
                        <div class="table-responsive">
                            <asp:GridView ID="grdGagInspection" runat="server" AutoGenerateColumns="False" DataKeyNames="InspectionId"
                                ShowHeaderWhenEmpty="True" CssClass="table table-striped clsResizeColumn" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle Font-Size="Small" Height="25px" BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:BoundField DataField="InspectionId" Visible="false" />
                                    <asp:BoundField DataField="ReceivedBy" HeaderText="Received By" ReadOnly="true" />
                                    <asp:BoundField DataField="TotalScore" HeaderText="Total Score" ReadOnly="true" />
                                    <asp:BoundField DataField="PrintName" HeaderText="Print Name" ReadOnly="true" />
                                    <asp:BoundField DataField="IssuedBy" HeaderText="Issued By" ReadOnly="true" />
                                    <asp:TemplateField HeaderText="Issued Date">
                                        <ItemTemplate>
                                            <asp:Label ID="LABEL_IssueDateCreated" runat="server" Text='<%# SetDateVal(Eval("IssuedDate")) %>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:CommandField ShowSelectButton="true" ItemStyle-ForeColor="Red" HeaderText="Information"/>

                                </Columns>
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" BackColor="#F7F6F3" ForeColor="#333333" />
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
    </div>
    <!-- ============================================================== -->
    <!-- End PAge Content -->
    <!-- ============================================================== -->

    <!-- ============================================================== -->
    <!-- End Container fluid  -->
    <!-- ============================================================== -->
     <script type="text/javascript">

       function ValidateControls() {
           var CompanyName;
           CompanyName = document.getElementById("ContentPlaceHolder1_ddlCompany").value;
           
            if (CompanyName == '')
            {
                ShowPopupBlank("Please Choose Any Company Name For Searching Data.");
                return false;
            }
          

       }
    
    </script>

</asp:Content>
