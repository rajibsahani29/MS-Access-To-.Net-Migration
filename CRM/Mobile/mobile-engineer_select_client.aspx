<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Mobile/Mobile.Master" CodeBehind="mobile-engineer_select_client.aspx.vb" Inherits="CRM.mobile_engineer_select_client" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- ============================================================== -->
    <!-- Container fluid  -->
    <!-- ============================================================== -->

    <!-- ============================================================== -->
    <!-- Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <div class="row page-titles">
        <div class="col-md-5 align-self-center">
            <h4 class="text-themecolor">mobile engineer select client</h4>
        </div>
        <div class="col-md-7 align-self-center text-right">
            <div class="d-flex justify-content-end align-items-center">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="javascript:void(0)">Home</a></li>
                    <li class="breadcrumb-item active">mobile engineer select client</li>
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
                                <div class="floating-labels m-t-30">
                                    <div class="floating-labels m-t-30">
                                        <div class="row">
                                            <div class="col-md-6">
                                                <div class="form-group m-b-30">
                                                    <asp:TextBox ID="txtClientName" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    <span class="bar"></span>
                                                    <label for="ContentPlaceHolder1_txtClientName">Enter client name</label></div></div>
                                        </div>
                                    <div class="row">
                                        <div class="col-md-2">
                                            <div class="button-group note-btn">
                                                <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Search" />
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
    <div class="company-form">
        <div class="row">
            <div class="col-12">
                <div class="card" style="left: 0px; top: 0px">
                    <div class="card-body">
                        <div class="table-responsive">
                            <asp:GridView ID="grdClient" runat="server" AutoGenerateColumns="False" DataKeyNames="ID"
                                ShowHeaderWhenEmpty="True" CssClass="clsResizeColumn" CellPadding="4" ForeColor="#333333" GridLines="Vertical">
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle Font-Size="Large" Height="25px" BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:BoundField DataField="ID" Visible="false" />
                                    <asp:BoundField DataField="Cname" HeaderText="Company Name" ReadOnly="true" />
                                    <asp:BoundField DataField="Forename" HeaderText="Forename" ReadOnly="true" />
                                    <asp:BoundField DataField="Surname" HeaderText="Surname" ReadOnly="true" />
                                    <asp:BoundField DataField="Address" HeaderText="Address" ReadOnly="true" />
                                    <asp:TemplateField ShowHeader="False" HeaderStyle-Width="450px">
                                        <ItemTemplate>
                                            <asp:Button ID="btnInspections" runat="server" CausesValidation="false" CommandName="Inspections"
                                                Text="Gas Safety" CommandArgument='<%# Eval("ID") %>' />
                                            <asp:Button ID="btnJobs" runat="server" CausesValidation="false" CommandName="Catering"
                                                Text="Mobile Catering" CommandArgument='<%# Eval("ID") %>' />
                                            <asp:Button ID="btnView" runat="server" CausesValidation="false" CommandName="View"
                                                Text="View Jobs" CommandArgument='<%# Eval("ID") %>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>

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
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End PAge Content -->
    <!-- ============================================================== -->

    <!-- ============================================================== -->
    <!-- End Container fluid  -->
    <!-- ============================================================== -->


</asp:Content>
