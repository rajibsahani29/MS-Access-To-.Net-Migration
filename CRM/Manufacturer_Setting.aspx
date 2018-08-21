<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Manufacturer_Setting.aspx.vb" Inherits="CRM.Manufacturer_Setting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>


    <!-- ============================================================== -->
    <!-- Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <div class="row page-titles">
        <div class="col-md-5 align-self-center">
            <h4 class="text-themecolor">Setting</h4>
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
                        </span><span class="hidden-xs-down">Edit Appliances</span></a> </li>
                        <li class="nav-item"><a class="nav-link" id="profileNav" data-toggle="tab" href="#profile" role="tab"><span class="hidden-sm-up">
                            <!-- <i class="ti-user"></i> -->
                        </span><span class="hidden-xs-down">Location</span></a> </li>
                      
                    </ul>
                    <!-- Tab panes -->
                    <div class="tab-content tabcontent-border">
                        <div class="tab-pane" id="home" role="tabpanel">
                            <div class="first-tab-warp">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="tab-heading">
                                            <div class="card">
                                                <div class="card-body">
                                                    <h3>Search for Appliance</h3>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-3">
                                        <div class="form-gride">
                                            <div class="card">
                                                <div class="card-body">
                                                    <div class="floating-labels">
                                                       
                                                        <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtManufacture" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtManufacture">Manufacturer Name</label>
                                                        </div>
                                                         <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtAppliance" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtAppliance">Appliance</label>
                                                        </div>
                                                        <div class="form-group m-b-40">
                                                            <asp:TextBox ID="txtModel" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtModel">Appliance Model</label>
                                                        </div>
                                                        <div class="form-group m-b-40">
                                                            <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Search" />
                                                            <asp:Button ID="btnClear" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Clear Search" />
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-9">
                                        <div class="table-warp">
                                            <div class="row">
                                                <div class="col-12">
                                                    <div class="card">
                                                        <div class="card-body">
                                                            <div class="table-responsive">
                                                            
                                                                <asp:GridView ID="grdParts" runat="server"
                                                                    AllowPaging="True" PageSize="10" CssClass="display nowrap table table-hover table-striped table-bordered" CellSpacing="0" Width="100%" AutoGenerateColumns="False"
                                                                    EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="ApplianceID">
                                                                    <HeaderStyle Font-Size="Small" Height="25px" />
                                                                    <Columns>
                                                                        <asp:BoundField DataField="ApplianceID" HeaderText="ID" Visible="false" />
                                                                        <asp:TemplateField HeaderText="Manufacturer Name">
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lblManufacturer" runat="server" Text='<%#Eval("ManufacturerName")%>'/>
                                                                            </ItemTemplate>
                                                                                    <EditItemTemplate>
                                                                                <asp:TextBox ID="txtMId" runat="server" Text='<%# Eval("ManufacturerID")%>' Visible ="false"/>
                                                                          <asp:DropDownList ID="ddlManufacturer" runat="server">
                                                                                </asp:DropDownList>
                                                                            </EditItemTemplate>

                                                                        </asp:TemplateField>
                                                                         <asp:TemplateField HeaderText="Appliance Type">
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="LABEL_appType" runat="server" Text='<%#Eval("ApplianceType")%>'/>
                                                                            </ItemTemplate>
                                                                                    <EditItemTemplate>
                                                                                <asp:TextBox ID="txtAppType" runat="server" Text='<%# Eval("ApplianceTypeID")%>' Visible="false"/>
                                                                                        <asp:DropDownList ID="ddlAppliance" runat="server">
                                                                                </asp:DropDownList>
                                                                            </EditItemTemplate>
                                                                        </asp:TemplateField>
                                                                          <asp:TemplateField HeaderText="Model">
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="LABEL_Model" runat="server" Text='<%#Eval("Model")%>'/>
                                                                            </ItemTemplate>
                                                                                    <EditItemTemplate>
                                                                                <asp:TextBox ID="txtModel" runat="server" Text='<%# Eval("Model")%>'/>
                                                                            </EditItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="SerialNumber" HeaderText="SerialNumber" ReadOnly="true" />
                                                                        <asp:CommandField ShowEditButton="True" ShowDeleteButton="true" />

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
                                    <div class="row">
                                    <div class="col-14">
                                        <div class="card">
                                            <div class="card-body">
                                                <h4 class="card-title">Appliance Types</h4>
                                                <div class="table-responsive m-t-40">
                                                            <asp:GridView ID="grdAppliance" runat="server"
                                                                AllowPaging="True" PageSize="10" CssClass="display nowrap table table-hover table-striped table-bordered" CellSpacing="0" Width="100%" AutoGenerateColumns="False"
                                                                EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="Id">
                                                                <HeaderStyle Font-Size="Small" Height="25px" />
                                                                <Columns>
                                                                    <asp:BoundField DataField="Id" HeaderText="ID" Visible="false" />
                                                                   <asp:TemplateField HeaderText="Appliance Type">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="LABEL_AppType" runat="server" Text='<%#Eval("Value")%>' />
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <asp:TextBox ID="txtAppType" runat="server" Text='<%# Eval("Value")%>' />
                                                                        </EditItemTemplate>
                                                                    </asp:TemplateField>
                                                                                                                                     
                                                                  
                                                                    <asp:CommandField ShowEditButton="true" ShowDeleteButton="true"/>

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
                        <div class="tab-pane  p-20" id="profile" role="tabpanel">
                            <div class="datagride-tab-two">
                                <div class="row">
                                    <div class="col-12">
                                        <div class="card">
                                            <div class="card-body">
                                                <h4 class="card-title">Location</h4>
                                                <div class="table-responsive m-t-40">
                                                            <asp:GridView ID="grdLocation" runat="server"
                                                                AllowPaging="True" PageSize="10" CssClass="display nowrap table table-hover table-striped table-bordered" CellSpacing="0" Width="100%" AutoGenerateColumns="False"
                                                                EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="LocationID">
                                                                <HeaderStyle Font-Size="Small" Height="25px" />
                                                                <Columns>

                                                                    <asp:BoundField DataField="LocationID" HeaderText="ID" Visible="false" />
                                                                    <asp:TemplateField HeaderText="Location Type">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="LABEL_locType" runat="server" Text='<%#Eval("LocationType")%>' />
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                              <asp:DropDownList ID="ddlLocType" runat="server" CssClass="selectpicker">
                                                <asp:ListItem Text="Main Store" Value="Main Store"></asp:ListItem>
                                                <asp:ListItem Text="Van" Value="Van"></asp:ListItem>
                                            </asp:DropDownList>
                                                                        </EditItemTemplate>
                                                                    </asp:TemplateField>
                                                                       <asp:TemplateField HeaderText="Location Name">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="LABEL_loc" runat="server" Text='<%#Eval("Location")%>' />
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <asp:TextBox ID="txtLocation" runat="server" Text='<%# Eval("Location")%>' />
                                                                        </EditItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField HeaderText="Notes">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="LABEL_notes" runat="server" Text='<%#Eval("Notes")%>' />
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <asp:TextBox ID="txtNotes" runat="server" Text='<%# Eval("Notes")%>' />
                                                                        </EditItemTemplate>
                                                                    </asp:TemplateField>
                                                                   
                                                                  
                                                                    <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" />

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
            </div>
                            <asp:HiddenField ID="hdnStatus" runat="server" />

        </div>

    </div>

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
           else {
                $("#home").attr("class", "tab-pane p-20 active");
                $("#homeNav").attr("class", "nav-link active");

            }
        });
    </script>
</asp:Content>
