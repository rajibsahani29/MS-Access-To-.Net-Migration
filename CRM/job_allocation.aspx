<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="job_allocation.aspx.vb" Inherits="CRM.job_allocation" %>

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
            <h4 class="text-themecolor">Job Allocation</h4>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Info box -->
    <!-- ============================================================== -->

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


        <div class="row">
            <div class="col-lg-12 col-md-12">
                <div class="form-main-warp">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="card">
                                <div class="card-body">
                                    <div class="floating-labels m-t-30">
                                        <div class="row">
                                            <div class="col-md-3">
                                                <div class="example datepicker form-selection-box">
                                                    <div class="input-group">
                                                        <asp:TextBox ID="txtAllocated" runat="server" CssClass="form-control mydatepicker" placeholder="Allocated"></asp:TextBox>

                                                        <div class="input-group-append">
                                                            <span class="input-group-text"><i class="icon-calender"></i></span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-selection-box padddng-btn">

                                                    <asp:DropDownList ID="ddlEngineer" runat="server" CssClass="selectpicker"></asp:DropDownList>

                                                </div>

                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-group m-b-30">
                                                    <asp:TextBox ID="txtIssueNote" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                                    <label for="ContentPlaceHolder1_txtIssueNote">Issue Notes:</label>
                                                </div>
                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-selection-box padddng-btn">
                                                    <asp:DropDownList ID="ddlstatus" runat="server" CssClass="selectpicker">
                                                        <asp:ListItem Text="Select" Value="Select"></asp:ListItem>
                                                        <asp:ListItem Text="Standard Hours" Value="Standard Hours"></asp:ListItem>
                                                        <asp:ListItem Text="Recall" Value="Recall"></asp:ListItem>
                                                    </asp:DropDownList>

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                        <div class="button-group note-btn">
                                    <asp:Button ID="btnadd" runat="server" Text="Submit" CssClass="btn btn-outline-success btn-rounded m-t-30" />
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
            <div class="col-sm-6">
                <div class="card">
                    <div class="card-body">
                        <div class="table-responsive">

                            <asp:GridView ID="GridView1" runat="server"
                                AllowPaging="True" PageSize="10" OnRowDataBound="GridView1_OnRowDataBound" AutoGenerateColumns="False"
                                EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="VisitHistoryID">
                                <HeaderStyle Font-Size="Small" Height="25px" CssClass="table table-striped" />
                                <Columns>
                                    <asp:BoundField DataField="VisitHistoryID" HeaderText="ID" Visible="false" />
                                    <asp:BoundField DataField="EngineerFrom" HeaderText="From" ReadOnly="true" />
                                    <asp:BoundField DataField="EngineerTo" HeaderText="To" ReadOnly="true" />

                                    <asp:TemplateField HeaderText="IssueType">
                                        <ItemTemplate>
                                            <asp:Label ID="LABEL_IssueType" runat="server" Text='<%# Eval("IssueType") %>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:DropDownList ID="ddlIssueType" runat="server" CssClass="selectpicker">
                                                <asp:ListItem Text="Standard Hours" Value="Standard Hours"></asp:ListItem>
                                                <asp:ListItem Text="Recall" Value="Recall"></asp:ListItem>
                                            </asp:DropDownList>
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Issue Date" HeaderStyle-Width="50%">
                                        <ItemTemplate>
                                            <asp:Label ID="LABEL_IssueDateCreated" runat="server" Text='<%# SetDateVal(Eval("IssueDate")) %>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <div class="input-group-append">
                                            <asp:Label ID="LABEL_PIssueDate"  runat="server" Text='<%# SetDateVal(Eval("IssueDate")) %>' Visible="false"/>
                                                <asp:TextBox ID="txtdate" runat="server" CssClass="mydatepicker" Text='<%# SetDateVal(Eval("IssueDate"))%>' />
                                                <span class="input-group-text"><i class="icon-calender"></i></span>
                                            </div>

                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Hrs">
                                        <ItemTemplate>
                                            <asp:Label ID="LABEL_hrs" runat="server" Text='<%#Eval("HoursSpent")%>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txthrs" runat="server" Text='<%# Eval("HoursSpent")%>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Notes">
                                        <ItemTemplate>
                                            <asp:Label ID="LABEL_notes" runat="server" Text='<%#Eval("IssueNotes")%>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtnotes" runat="server" Text='<%#Eval("IssueNotes")%>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>

                                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="true" />

                                </Columns>
                                <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" />
                            </asp:GridView>


                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title m-b-0"></h5>
                        <div class="table-responsive">

                            <asp:GridView ID="GridView2" runat="server"
                                AllowPaging="True" PageSize="10" AutoGenerateColumns="False"
                                EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True">
                                <HeaderStyle Font-Size="Small" Height="25px" CssClass="table table-striped" />
                                <Columns>
                                    <asp:BoundField DataField="JobNumber" HeaderText="JobNumber" ReadOnly="true" />
                                    <asp:BoundField DataField="Engineer" HeaderText="Engineer" ReadOnly="true" />
                                    <asp:BoundField DataField="Name" HeaderText="Company Name" ReadOnly="true" />
                                    <asp:BoundField DataField="Location" HeaderText="Location" ReadOnly="true" />
                                    <asp:BoundField DataField="Appliance" HeaderText="Appliance" ReadOnly="true" />
                                    <asp:BoundField DataField="Fault" HeaderText="Fault" ReadOnly="true" />
                                </Columns>
                                <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" />
                            </asp:GridView>

                        </div>
                    </div>
                </div>
                </div>
    </div>
</asp:Content>
