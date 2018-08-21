<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Job_clientdetails.aspx.vb" Inherits="CRM.Job_clientdetails" %>

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
            <h4 class="text-themecolor">Job - Client Details</h4>
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
                                                <asp:HiddenField ID="hdnCid" runat="server" />

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

                                <div class="floating-labels m-t-30">
                                    <div class="floating-labels m-t-30">
                                        <div class="form-group m-b-30">

                                            <asp:TextBox ID="txtcompany1" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtcompany1">Company Name</label>
                                        </div>
                                        <div class="form-group m-b-30">
                                            <asp:TextBox ID="txtContactPosition" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtContactPosition">Contact Position</label>
                                        </div>
                                        <div class="form-group m-b-30">
                                            <asp:TextBox ID="txtForName" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtForName">Fore Name</label>
                                        </div>
                                        <div class="form-group m-b-30">
                                            <asp:TextBox ID="txtSurName" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtSurName">Surname</label>
                                        </div>
                                        <div class="form-group m-b-30">
                                            <div class="skin skin-flat m-t-30 check-main-warp">
                                                <div class="form-group">
                                                    <label>Credit Control and Account</label>
                                                    <div class="input-group">
                                                        <ul class="icheck-list">
                                                            <li>
                                                                <asp:CheckBox ID="chkUplift" runat="server" data-checkbox="icheckbox_flat-red" />
                                                                <label for="flat-checkbox-1">Uplift Payment</label>
                                                            </li>
                                                            <li>
                                                                <asp:CheckBox ID="chkOnStop" runat="server" data-checkbox="icheckbox_flat-red" />
                                                                <label for="flat-checkbox-2">On Stop</label>
                                                            </li>
                                                            <li>
                                                                <asp:CheckBox ID="chkRemittance" runat="server" data-checkbox="icheckbox_flat-red" />
                                                                <label for="flat-checkbox-3">Remittance Slip with invoice</label>
                                                            </li>
                                                            <li>
                                                                <asp:CheckBox ID="chkOnStatement" runat="server" data-checkbox="icheckbox_flat-red" />
                                                                <label for="flat-checkbox-4">On Statement List</label>
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
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-body">
                                <div class="floating-labels m-t-30">
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtStreet" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtStreet">Street:</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtArea" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtArea">Area:</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtTown" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtTown">Town:</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtPostCode" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtPostCode">PostCode:</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtPhone">Phone:</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtFax" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtFax">Fax</label>
                                    </div>
                                    <div class="form-selection-box padddng-btn m-b-40">
                                        <asp:DropDownList ID="ddlHourlyRate" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                        </asp:DropDownList>
                                    </div>
                                    <%-- <i class="fa fa-check"></i>--%>
                                    <asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Update" />
                                    <asp:Button ID="btnReload" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Reload" />
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
        <div class="col-12">
            <div class="card">
                <div class="card-body">
                  
                    <div class="table-responsive">
               
                                <asp:GridView ID="grdRate" runat="server"
                                     CssClass="table table-striped clsResizeColumn" AutoGenerateColumns="False" DataKeyNames="Id"
                                    EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True">
                                    <HeaderStyle Font-Size="Small" Height="25px" />
                                    <PagerStyle CssClass="PageClass" />
                                    <Columns>
                                        <asp:BoundField DataField="Id" HeaderText="Id" Visible="false" />
                                        <asp:BoundField DataField="RateName" HeaderText="Rate Name" ReadOnly="true" />
                                        <asp:TemplateField HeaderText="Hourly Rate">
                                        <ItemTemplate>
                                            <asp:Label ID="LABEL_RATE" runat="server" Text='<%# Eval("HourlyRate", "{0:N2}") %>'/>
                                        </ItemTemplate>
                                       </asp:TemplateField>
                                       <asp:CommandField ShowDeleteButton="true" HeaderText="Info." />
                                       </Columns>
                                    <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" />
                                </asp:GridView>

                           
                    </div>
                </div>
            </div>
        </div>
    </div>
            <div class="row">
                <div class="col-12">
                    <div class="card">
                        <div class="card-body">
                            <h5 class="card-title m-b-20">Client Contact Details</h5>
                              <ul class="nav nav-tabs" role="tablist" id="myTab">
                                    <li class="nav-item"> <a class="nav-link active" id="oneNav" data-toggle="tab" href="#one" role="tab"><span class="hidden-sm-up"></span> <span class="hidden-xs-down">Show Client Contact</span></a> </li>
                                    <li class="nav-item"> <a class="nav-link" id="twoNav" data-toggle="tab" href="#two" role="tab"><span class="hidden-sm-up"></span> <span class="hidden-xs-down">Add Client Contact</span></a> </li>

                                </ul>
                            <div class="tab-content tabcontent-border">
                                <div class="tab-pane p-20 active" id="one" role="tabpanel">
                                        <div class="datagride-tab-two">
                                             <div class="row">
                                                 <div class="col-12">
                                                    <div class="card">
                                                        <div class="card-body">  
                                                             <div class="table-responsive">
                                
                                <asp:GridView ID="GridView1" runat="server" DataKeyNames="ContactID"
                                    AllowPaging="True" PageSize="10" CssClass="table table-striped clsResizeColumn" AutoGenerateColumns="False"
                                    EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True">
                                    <HeaderStyle Font-Size="Small" Height="25px" />
                                    <Columns>
                                        <asp:CommandField ShowEditButton="True" ShowDeleteButton="true" />

                                        <asp:BoundField DataField="ContactID" Visible="false" />
                                        <asp:TemplateField HeaderText="Forename">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_Forename" runat="server" Text='<%# Eval("Forename")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtforename" runat="server" Text='<%# Eval("Forename")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Surname">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_Surname" runat="server" Text='<%# Eval("Surname")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtSurname" runat="server" Text='<%# Eval("Surname")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Email">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_Email" runat="server" Text='<%# Eval("Email")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtEmail" runat="server" Text='<%# Eval("Email")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="DirectLine">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_line" runat="server" Text='<%# Eval("DirectLine")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtline" runat="server" Text='<%# Eval("DirectLine")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Notes">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_Notes" runat="server" Text='<%# Eval("Notes")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtNotes" runat="server" Text='<%# Eval("Notes")%>' />
                                            </EditItemTemplate>
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
                                <div class="tab-pane p-20" id="two" role="tabpanel">

                                        <div class="datagride-tab-two">
                                           
                                            <div class="row">
                                                <div class="col-12">
                                                    <div class="card">
                                                        <div class="card-body">                   
                                                    <div class="floating-labels m-t-30">
                                    <div class="floating-labels m-t-30">
                                        <div class="form-group m-b-30">

                                            <asp:TextBox ID="txtforename1" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtforename1">Forename</label>
                                        </div>
                                        <div class="form-group m-b-30">
                                            <asp:TextBox ID="txtSurname1" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtSurname1">Surname</label>
                                        </div>
                                        <div class="form-group m-b-30">
                                            <asp:TextBox ID="txtemail" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtemail">Email</label>
                                        </div>
                                        <div class="form-group m-b-30">
                                            <asp:TextBox ID="txtdirectline" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtdirectline">Direct Line</label>
                                        </div>
                                          <div class="form-group m-b-30">
                                            <asp:TextBox ID="txtnotes" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtnotes">Notes</label>
                                        </div>
                                                                            <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Add New Contact" OnClientClick="return ValidateControls();" />

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
            </div>
        </div>
    </div>
    <script type="text/javascript">
        function ValidateControls() {
            var forename = document.getElementById("ContentPlaceHolder1_txtforename1").value;
            var surname = document.getElementById("ContentPlaceHolder1_txtSurname1").value;
            var email = document.getElementById("ContentPlaceHolder1_txtemail").value;
            var directline = document.getElementById("ContentPlaceHolder1_txtdirectline").value;
            if (forename == '') {
                ShowPopupBlank("Please Enter Forename Field");
                return false;
            }
            if (surname == '') {
                ShowPopupBlank("Please Enter Sur Name Field");
                return false;
            }
            if (email == '') {
                ShowPopupBlank("Please Enter Email Field");
                return false;
            }
            if (directline == '') {
                ShowPopupBlank("Please Enter Direct Line Field");
                return false;
            }
           
        }







          $("#<%= ddlHourlyRate.ClientID %>").change(function () {
              var idx = $("#<%= ddlHourlyRate.ClientID %>").val();
              if(idx=="Edit")
              {
                  window.open('Add_Rate_Popup.aspx', 'win01', 'toolbar=no,status=no, menubar=yes, scrollbars=no,width=700,height=580,top=50, left=250');
              }
              else
              {

              }
         });

    </script>
</asp:Content>
