<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Task_Management.aspx.vb" Inherits="CRM.Task_Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row page-titles">
        <div class="col-md-5 align-self-center">
            <h4 class="text-themecolor">Task Management</h4>
        </div>
    </div>
      <div class="col-lg-12 col-md-12">
                    <div class="form-main-warp">
                        <div class="row">
                            <div class="col-md-12">
                              <div class="card">
                                    <div class="card-body">
                                       <div class="floating-labels m-t-30">
                                                                                            
                                           <div class="row">
                                                <div class="col-md-6">
                                                    <div class="form-group m-b-30">
                                                        <asp:DropDownList ID="ddlstatus" runat="server" CssClass="selectpicker">
                                        <asp:ListItem Text="Active" Value="Active"></asp:ListItem>
                                        <asp:ListItem Text="No Action Required" Value="No Action Required"></asp:ListItem>
                                          <asp:ListItem Text="Resolved" Value="Resolved"></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </div>
                                                </div>                                         
                                                <div class="col-md-6">
                                                    <div class="form-group m-b-30">
                                                         <asp:DropDownList ID="ddlStaff" runat="server" CssClass="selectpicker">
                                                         </asp:DropDownList>
                                                    </div>
                                                </div>
                                                       <div class="col-md-6">
                                                    <div class="form-group m-b-30">
                                                         <asp:DropDownList ID="ddlStaffFor" runat="server" CssClass="selectpicker">
                                                         </asp:DropDownList>
                                                    </div>
                                                </div>
                                                      <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-outline-success btn-rounded" style="width:95px; height:35px;" />
                                            </div>
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
                    <h5 class="card-title m-b-20">Search Results</h5>
                    <div class="table-responsive">

                                           <asp:GridView ID="grdTask" runat="server" 
                AllowPaging="True" PageSize="30" CssClass="table table-striped clsResizeColumn" AutoGenerateColumns="False" DataKeyNames="enquireID" 
                emptydatatext="No Records Found" ShowHeaderWhenEmpty="True" OnRowDataBound="grdTask_RowDataBound">
                <HeaderStyle Font-Size="Small" Height="25px" />
                <Columns>
                    <asp:BoundField DataField="enquireID" HeaderText="ID" Visible="false" />
                     <asp:BoundField DataField="By" HeaderText="Taken By" ReadOnly="true" />
                    <asp:BoundField DataField="FOR" HeaderText="For" ReadOnly="true" />

                     <asp:TemplateField HeaderText="Contact Date">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_DateCreated" runat="server" Text='<%# SetDateVal(Eval("ReportDate")) %>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Status" HeaderText="Status" ReadOnly="true" />
                    
                    <asp:BoundField DataField="" HeaderText="Comapany Name" ReadOnly="true" />
                      <asp:TemplateField HeaderText="Complete">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_completedate" runat="server" Text='<%# SetDateVal(Eval("SignOffDate")) %>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ReportedAs" HeaderText="Request" ReadOnly="true" />
                    <asp:BoundField DataField="ActionTaken" HeaderText="Action Taken" ReadOnly="true" />
                    <asp:BoundField DataField="Job Number" HeaderText="Job Number" ReadOnly="true" />
                    <asp:BoundField DataField="Appliance" HeaderText="Appliance" ReadOnly="true" />
                    <asp:BoundField DataField="Fault" HeaderText="Fault" ReadOnly="true" />
              </Columns>
              <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px"/>
                        </asp:GridView>
                      
                                           <asp:GridView ID="grdStaffStatus" runat="server" 
                AllowPaging="True" PageSize="50" CssClass="table table-striped clsResizeColumn" AutoGenerateColumns="False" 
                emptydatatext="No Records Found" ShowHeaderWhenEmpty="True" OnRowDataBound="grdTask_RowDataBound">
                <HeaderStyle Font-Size="Small" Height="25px" />
                <Columns>
                    <asp:BoundField DataField="Staff" HeaderText="Staff" ReadOnly="true" />
                     <asp:BoundField DataField="Resolved" HeaderText="Resolved" ReadOnly="true" />
                    <asp:BoundField DataField="Active" HeaderText="Active" ReadOnly="true" />
                    <asp:BoundField DataField="No Action Required" HeaderText="No Action Required" ReadOnly="true" />
              </Columns>
              <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px"/>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
