<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="add_company.aspx.vb" Inherits="CRM.add_company"  %>

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
            <h4 class="text-themecolor">Add Company</h4>
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

            <div class="form-main-warp cost-warp">
                <div class="row">
                    <div class="col-md-12">
                        <div class="card">
                            <div class="card-body">
                          
                                <div class="floating-labels m-t-40">

                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtCompanyName" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtCompanyName">Company Name</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtForename" CssClass="form-control input-sm" runat="server" /><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtForename">Forename</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtSurname" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtSurname">Surname</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtContactPos" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtContactPos">Contact Position</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtStreet" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtStreet">Street</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtArea" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtArea">Area</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtTown" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtTown">Town</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtPostCode" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtPostCode">Postcode</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtEmail" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtEmail">Email</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtPhone" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtPhone">Phone</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtFax" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtFax">Fax</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtMobNum" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtMobNum">Mobile Number</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <!-- <label>Fault</label>
                                        <asp:TextBox ID="txtArea1" CssClass="form-control" TextMode="multiline" Columns="50" Rows="5" runat="server" /> -->
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
                        <div class="card">
                            <div class="card-body">
                                <div class="table-responsive">
                                    <asp:Repeater ID="RptJobList" runat="server">
                                        <HeaderTemplate>
                                            <table id="example23" class="table table-striped">
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

                                <div class="button-group note-btn">
                                    <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Cancel" OnClientClick="window.close();" />
                                    <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Add New Company" OnClientClick="return ValidateControls()" />
                                </div>
                            </div>


                        </div>
                    </div>
                </div>
            </div>


        </div>


    </div>

    <script type="text/javascript">

       function ValidateControls() {
           var CompanyName, Forename, ContactPos, Street, Area;
           CompanyName = document.getElementById("ContentPlaceHolder1_txtCompanyName").value;
           Forename = document.getElementById("ContentPlaceHolder1_txtForename").value;
           ContactPos = document.getElementById("ContentPlaceHolder1_txtContactPos").value;
           Street = document.getElementById("ContentPlaceHolder1_txtStreet").value;
           Area = document.getElementById("ContentPlaceHolder1_txtArea").value;

            if (CompanyName == '')
            {
                ShowPopupBlank("Please Fill Company Name Field.");
                return false;
            }
            if (Forename == '')
            {
                ShowPopupBlank("Please Fill Fore Name Field.");
                return false;
            }
            if (ContactPos == '')
            {
                ShowPopupBlank("Please Fill Contact Position Field.");
                return false;
            }
            if (Street == '') {
                ShowPopupBlank("Please Fill Street Field.");
                return false;
            }
            if (Area == '') {
                ShowPopupBlank("Please Fill Area Field.");
                return false;
            }

       }
    
    </script>
</asp:Content>
