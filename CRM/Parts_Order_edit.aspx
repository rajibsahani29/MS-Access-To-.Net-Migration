<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Parts_Order_edit.aspx.vb" Inherits="CRM.Parts_Order_edit" ValidateRequest="false" %>

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
            <h4 class="text-themecolor">Parts Order Edit</h4>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Info box -->
    <!-- ============================================================== -->



    <div class="row">
        <div class="col-md-12">
            <div class="card">
                <div class="card-body">
                    <!-- Nav tabs -->
                    <ul class="nav nav-tabs" role="tablist">
                        <li class="nav-item"><a class="nav-link" id="homeNav" data-toggle="tab" href="#home" role="tab"><span class="hidden-sm-up">
                            <!-- <i class="ti-home"></i> -->
                        </span><span class="hidden-xs-down">Part Detail</span></a> </li>
                        <li class="nav-item"><a class="nav-link" data-toggle="tab" id="profileNav" href="#profile" role="tab"><span class="hidden-sm-up">
                            <!-- <i class="ti-user"></i> -->
                        </span><span class="hidden-xs-down">Job Detail</span></a> </li>
                        <li class="nav-item"><a class="nav-link" data-toggle="tab" id="messagesNav" href="#messages" role="tab"><span class="hidden-sm-up">
                            <!-- <i class="ti-email"></i> -->
                        </span><span class="hidden-xs-down">Job Notes</span></a> </li>
                        <li class="nav-item"><a class="nav-link" data-toggle="tab" id="allocationNav" href="#allocation" role="tab"><span class="hidden-sm-up">
                            <!-- <i class="ti-email"></i> -->
                        </span><span class="hidden-xs-down">Allocation</span></a> </li>
                    </ul>
                    <!-- Tab panes -->
                    <div class="tab-content tabcontent-border">
                        <div class="tab-pane" id="home" role="tabpanel">
                            <div class="first-tab-warp">
                                <br />
                                <br />
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="form-gride">
                                            <div class="card">
                                                <div class="card-body">
                                                    <div class="floating-labels">
                                                        <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtPartNo" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtPartNo">Part Number</label>
                                                        </div>
                                                        <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtDescription">Description</label>
                                                        </div>
                                                        <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtSerialNo" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtSerialNo">Serial Number</label>
                                                        </div>
                                                        <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtManufactureName" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtManufactureName">Manufacture Name</label>
                                                        </div>
                                                        <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtModel" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtModel">Model</label>
                                                        </div>
                                                        <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtApplianceType" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtApplianceType">Appliance type</label>
                                                        </div>
                                                        <asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Update" />
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <div class="form-gride">
                                            <div class="card">
                                                <div class="card-body">
                                                    <div class="floating-labels">
                                                        <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtengineers" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtengineers">Engineers Number</label>
                                                        </div>
                                                        <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtqty" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtqty">Quantity</label>
                                                        </div>
                                                        <div class="form-group m-b-40">
                                                            <label>Notes:</label>
                                                            <asp:HiddenField ID="hdnJobid" runat="server" />
                                                            <asp:TextBox ID="txtNotes" CssClass="form-control" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                                                        </div>
                                                        <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtCostExvat" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtCostExvat">Cost EXVAT</label>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>


                                </div>
                            </div>
                        </div>
                        <div class="tab-pane  p-20" id="profile" role="tabpanel">


                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-gride">
                                        <div class="card">
                                            <div class="card-body">
                                                <div class="floating-labels">
                                                    <div class="form-group m-b-30">
                                                        <asp:TextBox ID="txtffnumber" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                        <span class="bar"></span>
                                                    </div>
                                                    <div class="form-group m-b-30">
                                                        <asp:TextBox ID="txtCompName" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtCompName">Company Name</label>
                                                    </div>
                                                    <div class="form-group m-b-30">
                                                        <asp:TextBox ID="txtStreet" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtStreet">Street</label>
                                                    </div>
                                                    <div class="form-group m-b-30">
                                                        <asp:TextBox ID="txtTown" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtTown">Town</label>
                                                    </div>
                                                    <div class="form-group m-b-30">
                                                        <asp:TextBox ID="txtEng" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtEng">Engineer</label>
                                                    </div>
                                                    <div class="form-group m-b-30">
                                                        <asp:TextBox ID="txtPermission" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtPermission">Permission</label>
                                                    </div>
                                                    <div class="form-group m-b-30">
                                                        <asp:TextBox ID="txtAddr1" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtAddr1">Address 1</label>
                                                    </div>
                                                    <div class="form-group m-b-30">
                                                        <asp:TextBox ID="txtPermPostCode" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtPermPostCode">Permission Post Code</label>
                                                    </div>
                                                    <div class="form-group m-b-30">
                                                        <asp:TextBox ID="txtAppliance" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtAppliance">Appliance</label>
                                                    </div>
                                                    <div class="form-group m-b-30">
                                                        <asp:TextBox ID="txtModelOfAppliance" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                                        <span class="bar"></span>
                                                        <label for="ContentPlaceHolder1_txtModelOfAppliance">Model Of Appliance</label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="col-md-6">
                                    <div class="form-gride">
                                        <div class="card">
                                            <div class="card-body">
                                                <div class="floating-labels">
                                                    <div class="form-group m-b-40">
                                                        <label>Fault:</label>
                                                        <asp:TextBox ID="txtFault" CssClass="form-control" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                                                    </div>
                                                </div>
                                                <asp:Button ID="btnUpdateJob" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Update" />

                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>


                        </div>
                        <div class="tab-pane p-20" id="messages" role="tabpanel">
                            <div class="datagride-tab-two">
                                <div class="row">
                                    <div class="col-12">
                                        <div class="card">
                                            <div class="card-body">
                                                <div class="col-md-4">
                                                    <div class="floating-labels">
                                                        <div class="form-group m-b-30">
                                                            <asp:TextBox ID="txtNote" CssClass="form-control input-sm" runat="server" />
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtNotes">Notes</label>
                                                        </div>

                                                        <div class="form-group m-b-30">
                                                            <asp:Button ID="btnAdd" runat="server" Text="Add Notes" CssClass="btn btn-outline-success btn-rounded m-t-30" />

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
                                                    <asp:GridView ID="grdNotes" runat="server"
                                                        AllowPaging="True" PageSize="10" AutoGenerateColumns="False"
                                                        EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="JobNotesID">
                                                        <HeaderStyle Font-Size="Small" Height="25px" CssClass="table table-striped" />
                                                        <Columns>
                                                            <asp:BoundField DataField="JobNotesID" HeaderText="ID" Visible="false" />
                                                            <asp:BoundField DataField="RecordedByPC" HeaderText="RecordedByPC" ReadOnly="true" />
                                                            <asp:BoundField DataField="RecordedByUser" HeaderText="RecordedByUser" ReadOnly="true" />
                                                            <asp:TemplateField HeaderText="Date">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_Date" runat="server" Text='<%# SetDateVal(Eval("Date")) %>' />
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Notes">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_notes" runat="server" Text='<%#Eval("Notes")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtnotes" runat="server" TextMode="MultiLine" Text='<%#Eval("Notes")%>' Width="400px" />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>

                                                            <asp:CommandField ShowEditButton="True" />
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
                        <div class="tab-pane p-20" id="allocation" role="tabpanel">
                            <div class="datagride-tab-two">
                                <div class="row">
                                    <div class="col-12">
                                        <div class="card">
                                            <div class="card-body">
                                                <div class="col-md-4">
                                                    <div class="floating-labels">
                                                        <div class="form-group m-b-30">
                                                            <asp:TextBox ID="txtsheetdate" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtsheetdate">Sheet Date</label>
                                                        </div>
                                                        <div class="form-group m-b-30">
                                                            <asp:TextBox ID="txtengineer" CssClass="form-control input-sm" runat="server" ReadOnly="true" />
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtengineer">Engineers:</label>
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
                                                    <asp:GridView ID="grdallocation" runat="server"
                                                        AllowPaging="True" PageSize="10" AutoGenerateColumns="False"
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
                                                            <asp:TemplateField HeaderText="Notes">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_notes" runat="server" Text='<%#Eval("IssueNotes")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtnotes" runat="server" Text='<%#Eval("IssueNotes")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Issue Date" HeaderStyle-Width="50%">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_IssueDateCreated" runat="server" Text='<%# SetDateVal(Eval("IssueDate")) %>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <div class="input-group-append">
                                                                        <asp:TextBox ID="txtdate" runat="server" CssClass="mydatepicker" Text='<%#Eval("IssueDate")%>' />

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
                    </div>
                </div>
                <asp:HiddenField ID="hdnStatus" runat="server" />
            </div>
        </div>
    </div>

    <!-- ============================================================== -->
    <!-- End Container fluid  -->
    <!-- ============================================================== -->

    <script type="text/javascript">

        $(document).ready(function () {
            var Status = $("#<%= hdnStatus.ClientID %>").val();
            if (Status == "home") {
                $("#home").attr("class", "tab-pane p-20 active");
                $("#homeNav").attr("class", "nav-link active");
            }
            else if (Status == "profile") {
                $("#profileNav").attr("class", "nav-link active");
                $("#profile").attr("class", "tab-pane p-20 active");
            }
            else if (Status == "messages") {
                $("#messagesNav").attr("class", "nav-link active");
                $("#messages").attr("class", "tab-pane p-20 active");
            }
            else if (Status == "allocation") {
                $("#allocationNav").attr("class", "nav-link active");
                $("#allocation").attr("class", "tab-pane p-20 active");
            }
            else {
                $("#home").attr("class", "tab-pane p-20 active");
                $("#homeNav").attr("class", "nav-link active");

            }
        });
    </script>
</asp:Content>
