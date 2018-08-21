<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Mobile/Mobile.Master" CodeBehind="mobile-engineer-select-client-gas.aspx.vb" Inherits="CRM.mobile_engineer_select_client_gas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .btn-body-section button {
            width: 100%;
        }
    </style>

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
                                    <div class="card-body btn-body-section">
                                        <form class="floating-labels">
                                            <div class="row">
                                                <div class="col-md-6">
                                                    <div class="button-group note-btn">
                                                        <button type="button" class="btn waves-effect waves-light btn-rounded btn-outline-success">Add New Gas Inspection</button>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="button-group note-btn">
                                                        <button type="button" class="btn waves-effect waves-light btn-rounded btn-outline-success">Add New Mobile Catering Inspection</button>
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
            </div>
            <div class="company-form client-gas-section">
                <div class="row">
                    <div class="col-12">
                        <div class="card">
                            <div class="card-body">
                                <div class="table-responsive">
                                    <asp:Repeater ID="RptJobList1" runat="server">
                                        <HeaderTemplate>
                                            <table id="example25" class="table table-striped">
                                                <thead>
                                                    <tr>
                                                        <th>Fore Name</th>
                                                        <th>Surname</th>
                                                        <th>Email</th>
                                                        <th>DirectLine</th>
                                                        <th>Notes</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <tr>
                                                <td>
                                                    <%#Eval("ForeName")%>
                                                </td>
                                                <td>
                                                    <%#Eval("Surname")%>
                                                </td>
                                                <td>
                                                    <%#Eval("Email")%>
                                                </td>
                                                <td>
                                                    <%#Eval("DirectLine")%>
                                                </td>
                                                <td>
                                                    <%#Eval("Notes")%>
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            </tbody>     
               </table>       
                                        </FooterTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>


                        </div>
                    </div>
                </div>
            </div>
            <!-- ============================================================== -->
            <!-- End PAge Content -->
            <!-- ============================================================== -->
 
</asp:Content>
