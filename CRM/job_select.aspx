<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="job_select.aspx.vb" Inherits="CRM.job_select" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row page-titles">
        <div class="col-md-5 align-self-center">
            <h4 class="text-themecolor">Job - Select</h4>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="form-main-warp">
                <div class="row">
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-body">
                                    <div class="form-selection-box">
                                    <h5 class="m-t-10 m-b-10">Status</h5>
                                    <asp:DropDownList ID="ddlStatus" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary" AutoPostBack="true">
                                        <asp:ListItem Value="">Select Status</asp:ListItem>
                                        <asp:ListItem style="color:red" Value="Enquiry">New Job - Red</asp:ListItem>
<%--                                        <asp:ListItem style="color:#CCCC00" Value="Job Allocated">Job Allocated - Yellow</asp:ListItem>--%>
                                        <asp:ListItem style="color:yellow" Value="Job Allocated">Job Allocated - Yellow</asp:ListItem>
                                        <asp:ListItem style="color:blue" Value="Quoted">Job quotes - Blue</asp:ListItem>
                                        <asp:ListItem style="color:pink" Value="Parts Ordered">Parts Ordered - Pink</asp:ListItem>
                                        <asp:ListItem style="color:lightblue" Value="To be Quoted">To be Quoted - Light Blue</asp:ListItem>
                                        <asp:ListItem Value="Parts Received" style="color:#A52A2A">Parts received - Brown</asp:ListItem>
                                        <asp:ListItem style="color:purple" Value="Parts Required">Parts Required - Purple</asp:ListItem>
                                        <asp:ListItem style="color:orange" Value="Invoice Sent">Invoice Sent - Orange</asp:ListItem>
                                        <asp:ListItem style="color:black" Value="Cancelled">Cancelled - Black</asp:ListItem>
                                        <asp:ListItem style="color:forestgreen" Value="Paid">Paid - Green</asp:ListItem>
                                        <asp:ListItem style="color:darkgrey" Value="Ready For Invoicing">Ready For Invoicing - Dark Grey</asp:ListItem>
                                        <asp:ListItem style="color:cyan" Value="Fit Parts">Fit Parts - Cyan</asp:ListItem>


                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="card-body">

                            </div>
                              <div class="card-body">

                            </div>
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
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="grdJob" runat="server"
                                    AllowPaging="True" PageSize="50" CssClass="table table-striped clsResizeColumn" AutoGenerateColumns="False" DataKeyNames="ID"
                                    EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True">
                                    <HeaderStyle Font-Size="Small" Height="25px" />
                                    <PagerStyle CssClass="PageClass" />
                                    <Columns>
                                        <asp:CommandField ShowSelectButton="true" HeaderText="Info." />
                                        <asp:BoundField DataField="ID" HeaderText="ID" Visible="false" />
                                        <asp:BoundField DataField="JobNumber" HeaderText="Job Number" ReadOnly="true" />
                                        <asp:TemplateField HeaderText="Enquiry Date">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_EnquiryDateCreated" runat="server" Text='<%# SetDateVal(Eval("EnquiryDate")) %>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="OrderNumber" HeaderText="Order Number" ReadOnly="true" />
                                        <asp:BoundField DataField="Company Name" HeaderText="Company Name" ReadOnly="true" />
                                        <asp:BoundField DataField="Status" HeaderText="Status" ReadOnly="true" />
                                        <asp:BoundField DataField="Appliance" HeaderText="Appliance" ReadOnly="true" />
                                        <asp:BoundField DataField="Fault" HeaderText="Fault" ReadOnly="true" />
                                        <asp:BoundField DataField="Premises" HeaderText="Premises" ReadOnly="true" />
                                        <asp:BoundField DataField="Engineer" HeaderText="Engineer" ReadOnly="true" />
                                        <asp:BoundField DataField="Quote" HeaderText="Quote Number" ReadOnly="true" />
                                       </Columns>
                                    <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" />
                                </asp:GridView>

                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="btnUpdate" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="form-main-warp">
                <div class="row">
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-body">
                                <h5 class="card-title m-b-20">Filter Results</h5>
                                <div class="form-selection-box">
                                    <h5 class="m-t-10 m-b-10">Engineer</h5>
                                    <asp:DropDownList ID="ddlEngineer" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                    </asp:DropDownList>

                                </div>
                            
                                <div class="floating-labels m-t-40">
                                    <div class="floating-labels m-t-40">
                                        <div class="form-group m-b-40">

                                            <asp:TextBox ID="txtCompany" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtCompany">Company</label>
                                        </div>
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtFFNos" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtFFNos">FF Nos</label>
                                        </div>
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtPermises" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtPermises">Premises</label>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-body">
                                <div class="floating-labels m-t-40">
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtAppliance" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtAppliance">Appliance</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtFault" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtFault">Fault</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtOrderNumber" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtOrderNumber">Order Number</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtQuote" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtQuote">Quote Number</label>
                                    </div>

                                </div>
                                <asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Search" />
                            </div>

                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>




</asp:Content>
