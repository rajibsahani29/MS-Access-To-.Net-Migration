<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Client_Report.aspx.vb" Inherits="CRM.Client_Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>
     <style type="text/css">
  .Hide { display:none; }
</style>

                <div class="row page-titles">
                    <div class="col-md-5 align-self-center">
                        <h4 class="text-themecolor">Client Report</h4>
                    </div>
                </div>
                <!-- ============================================================== -->
                <!-- End Bread crumb and right sidebar toggle -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <!-- Info box -->
                <!-- ============================================================== -->

                
                   
                         <div class="row">
                <div class="form-main-warp search-main-warp cost-warp select-warp-section">
                    <div class="card">
                        <div class="card-body">
                            <div class="floating-labels m-t-30">
                                <div class="floating-labels search-table m-t-30">
                                    <div class="floating-labels">
                                      
                                        <div class="form-group m-b-40">
                                             <div class="form-selection-box padddng-btn m-b-40">
                                                <asp:DropDownList ID="ddlcompany" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary" AutoPostBack="true">
                                                </asp:DropDownList>
                                            </div>
                                            <label for="ContentPlaceHolder1_ddlcompany">Company Name</label>
                                        </div>
                                          <div class="form-group m-b-40">
                                           <div class="example datepicker form-selection-box">
                                            <div class="input-group">
                                                <asp:TextBox ID="txtstartdate" runat="server" CssClass="form-control mydatepicker" placeholder="Start Date"></asp:TextBox>
                                                <div class="input-group-append">
                                                    <span class="input-group-text"><i class="icon-calender"></i></span>
                                                </div>
                                            </div>
                                           </div>
                                              </div>

                                          <div class="form-group m-b-40">
                                         <div class="example datepicker form-selection-box">
                                            <div class="input-group">
                                                <asp:TextBox ID="txtEnddate" runat="server" CssClass="form-control mydatepicker" placeholder="End Date"></asp:TextBox>
                                                <div class="input-group-append">
                                                    <span class="input-group-text"><i class="icon-calender"></i></span>
                                                </div>
                                            </div>
                                           </div>
                                              </div>
                                          <div class="form-group m-b-40">
                                           <div class="form-selection-box padddng-btn m-b-40">
                                                <asp:DropDownList ID="ddlCount" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                           <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                          <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                           <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                           <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                           <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <label for="ContentPlaceHolder1_ddlCount">Count As Single Visit</label>
                                        </div>
                                      
                                           <div>
                                         <label style="top: 386px;margin-left: 16px;">Refigeration</label>
                                            <asp:CheckBox ID="chkRefrigiration" runat="server"/>
                                        </div>
                                        <div class="form-group m-b-40"></div>
                                        <div class="form-group m-b-40">
                                           <div class="form-selection-box padddng-btn m-b-40">
                                                 <asp:DropDownList ID="ddlSType" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
<%--                                                <asp:ListItem Text="Select Type" Value="Type"></asp:ListItem>--%>
                                                 <asp:ListItem Text="Repairs" Value="Repairs"></asp:ListItem>
                                                <asp:ListItem Text="Sales" Value="Sales"></asp:ListItem>
                                            </asp:DropDownList>
                                            </div>
                                        </div>
                                          <div class="form-group m-b-40">
                                           <div class="form-selection-box padddng-btn m-b-40">
                                                <asp:DropDownList ID="ddlEmail" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                                </asp:DropDownList>
                                            </div>
                                            <label for="ContentPlaceHolder1_ddlEmail">Email Id</label>
                                        </div>
                                             <div class="button-group note-btn">  
                                      <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="SEARCH"/>
                                      <asp:Button ID="btnSend" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Send Report"/>

                                                                <asp:HiddenField ID="hdnMid" runat="server"/>
</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
                   

               <div class="row">
                    <div class="col-md-12">
                        <div class="card">
                            <div class="card-body">
                                <!-- Nav tabs -->
                                <ul class="nav nav-tabs" role="tablist">
                                    <li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#requirement" role="tab"><span class="hidden-sm-up"><!-- <i class="ti-requirement"></i> --></span> <span class="hidden-xs-down">Job List</span></a> </li>
                                    <li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#profile" role="tab"><span class="hidden-sm-up"><!-- <i class="ti-user"></i> --></span> <span class="hidden-xs-down">First Visit Fixx</span></a> </li>
                                  
                                </ul>
                                <!-- Tab panes -->
                                <div class="tab-content tabcontent-border">
                                    <div class="tab-pane p-20 active" id="requirement" role="tabpanel">
                                        <div class="first-tab-warp">
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <div class="tab-heading">
                                                        <div class="card">
                                                            <div class="card-body">
                                                              <h3>Job List</h3>  
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                           
                                                <div class="tab-datatable">
                                                <div class="row">
                                                    <div class="col-12">
                                                        <div class="card">
                                                            <div class="card-body">
                                                                <div class="table-responsive">
                                                                    

                                                                    <asp:GridView ID="grdJoblist" runat="server" 
                AllowPaging="True" PageSize="50" CssClass="display nowrap table table-hover table-striped table-bordered clsResizeColumn" AutoGenerateColumns="False" DataKeyNames="ID" 
                emptydatatext="No Records Found" ShowHeaderWhenEmpty="True">
                <HeaderStyle Font-Size="Large" Height="25px" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" Visible="false" />
                    <asp:BoundField DataField="JobNumber" HeaderText="Job Number" ReadOnly="true" />
                    <asp:TemplateField HeaderText="Invoice Date">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_InvoiceDateCreated" runat="server" Text='<%# SetDateVal(Eval("Invoice Date")) %>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                   <asp:BoundField DataField="Status" HeaderText="Status" ReadOnly="true" />
                   <asp:BoundField DataField="Premises" HeaderText="Premises" ReadOnly="true" />
                    <asp:BoundField DataField="Appliance" HeaderText="Appliance" ReadOnly="true" />
                   <asp:BoundField DataField="Fault" HeaderText="Fault" ReadOnly="true" />
                  <asp:BoundField DataField="Type" HeaderText="JobType" ReadOnly="true" />
                 <asp:BoundField DataField="FirstVisitFix" HeaderText="First Visit Fix" ReadOnly="true" />
                 <asp:BoundField DataField="Labour" HeaderText="Labour" ReadOnly="true" />
                 <asp:BoundField DataField="Parts" HeaderText="Parts" ReadOnly="true" />
                 <asp:BoundField DataField="Total" HeaderText="Total" ReadOnly="true" />

              </Columns>
              <RowStyle HorizontalAlign="Center" Font-Size="Medium" Height="50px"/>
                        </asp:GridView>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                           
                                        </div>
                                    </div>
                                    <div class="tab-pane p-20" id="profile" role="tabpanel">
                                        <div class="datagride-tab-two">
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <div class="tab-heading">
                                                        <div class="card">
                                                            <div class="card-body">
                                                              <h3>Job Status</h3> 
                                                           
                                                           </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            
                                            <div class="tab-datatable">
                                                <div class="row">
                                                    <div class="col-12">
                                                        <div class="card">
                                                            <div class="card-body">
                                                                <div class="table-responsive">
                                                                     <div id="chartdiv">
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
                                                                    

                                                                    <asp:GridView ID="grdFirstVisit" runat="server"  CssClass="display nowrap table table-hover table-striped table-bordered" AutoGenerateColumns="False"
                emptydatatext="No Records Found" ShowHeaderWhenEmpty="True">
                <HeaderStyle Font-Size="Large" Height="25px" />
                <Columns>
                    <asp:BoundField DataField="FirstVisitFix" HeaderText="First Visit Fix" ReadOnly="true" />
                    <asp:BoundField DataField="CountOfFirstVisitFix" HeaderText="Count Of First Visit Fix" ReadOnly="true" />
                   <asp:BoundField DataField="Percentage" HeaderText="Percentage" ReadOnly="true" />
                    <asp:BoundField DataField="SumOfCountOfFirstVisitFix" HeaderText="SumOfCountOfFirstVisitFix">
                        <ItemStyle CssClass="Hide" />
                        <HeaderStyle CssClass="Hide" />
                    </asp:BoundField>
              </Columns>
              <RowStyle HorizontalAlign="Center" Font-Size="Medium" Height="50px"/>
                        </asp:GridView>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                 <div class="row">
                                                      <div style="align-content:center;margin-left:500px;">
                                         <asp:TextBox ID="txtTotal" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>

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
                                                    <asp:HiddenField ID="hdnfromDate" runat="server" />
                                    <asp:HiddenField ID="hdnToDate" runat="server" />

            
</asp:Content>
