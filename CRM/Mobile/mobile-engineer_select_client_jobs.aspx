<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Mobile/Mobile.Master" CodeBehind="mobile-engineer_select_client_jobs.aspx.vb" Inherits="CRM.mobile_engineer_select_client_jobs" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
            <!-- ============================================================== -->
            <!-- Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
            <div class="row page-titles">
                <div class="col-md-5 align-self-center">
                    <h4 class="text-themecolor">mobile engineer select client Job</h4>
                </div>
                <div class="col-md-7 align-self-center text-right">
                    <div class="d-flex justify-content-end align-items-center">
                        <ol class="breadcrumb">
                            <li class="breadcrumb-item"><a href="javascript:void(0)">Home</a></li>
                            <li class="breadcrumb-item active">mobile engineer select client job</li>
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

            
            <div class="company-form">
                <div class="row">
                    <div class="col-12">
                        <div class="card" style="left: 0px; top: 0px">
                            <div class="card-body">
                                <div class="table-responsive">
                                    <asp:GridView ID="grdJob" runat="server" AutoGenerateColumns="False" DataKeyNames="Id"  
                ShowHeaderWhenEmpty="True" CssClass="table table-striped clsResizeColumn" CellPadding="4" ForeColor="#333333" GridLines="Vertical">
                                        <EditRowStyle BackColor="#999999" />
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle Font-Size="Large" Height="25px" BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                 <asp:BoundField DataField="Id" Visible="false"/>
                  <asp:BoundField DataField="Customername" HeaderText="Customer Name" ReadOnly="true"/>
                   <asp:BoundField DataField="address" HeaderText="Address" ReadOnly="true"/>
                      <asp:TemplateField HeaderText="Date">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_DateCreated" runat="server" Text='<%# SetDateVal(Eval("Whenx")) %>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                  <asp:BoundField DataField="JobNumber" HeaderText="Job Ref" ReadOnly="true"/>
                 <asp:BoundField DataField="ServiceType" HeaderText="Service" ReadOnly="true"/>

                    
                  <asp:CommandField ShowSelectButton="true" ItemStyle-ForeColor="Red"/>
                    
              </Columns>
                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
              <RowStyle HorizontalAlign="Center" Font-Size="Medium" Height="50px" BackColor="#F7F6F3" ForeColor="#333333"/>
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
      
</asp:Content>
