<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Mobile/Mobile.Master" CodeBehind="gas_jobs_edit.aspx.vb" Inherits="CRM.gas_jobs_edit" %>
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
                                        <div class="floating-labels">
                                            <div class="row">
                                                <div class="col-md-6">
                                                    <div class="button-group note-btn">
                                                          <asp:DropDownList ID="ddlShow" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                                              <asp:ListItem Value="0">Select</asp:ListItem>
                                                              <asp:ListItem Value="1">Show All Gas Inspections</asp:ListItem>
                                                              <asp:ListItem Value="2">Show All Catering Inspections</asp:ListItem>
                                                          </asp:DropDownList>
            
                                                                                                   
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
            <div class="company-form client-gas-section">
                <div class="row">
                    <div class="col-12">
                        <div class="card">
                            <div class="card-body">
                                <div class="table-responsive">
                                    <%--<asp:Repeater ID="RptJobList1" runat="server">
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
                                    </asp:Repeater>--%>
                                    <div id="divGas">
                                    <asp:GridView ID="grdGagInspection" runat="server" AutoGenerateColumns="False" DataKeyNames="InspectionId"  
                ShowHeaderWhenEmpty="True" CssClass="table table-striped clsResizeColumn" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
                                        <EditRowStyle BackColor="#999999" />
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle Font-Size="Large" Height="25px" BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                 <asp:BoundField DataField="InspectionId" Visible="false"/>
                 <asp:BoundField DataField="ReceivedBy" HeaderText="Received By" ReadOnly="true"/>
                  <asp:BoundField DataField="TotalScore" HeaderText="Total Score" ReadOnly="true"/>
                  <asp:BoundField DataField="PrintName" HeaderText="Print Name" ReadOnly="true"/>
                 <asp:BoundField DataField="IssuedBy" HeaderText="Issued By" ReadOnly="true"/>
                        <asp:TemplateField HeaderText="Issued Date">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_IssueDateCreated" runat="server" Text='<%# SetDateVal(Eval("IssuedDate")) %>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                <asp:CommandField ShowSelectButton="true" ItemStyle-ForeColor="Red" SelectText="EDIT"/>

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
                                    <div id="divCatering">
                                        
                                    <asp:GridView ID="grdCateringInspection" runat="server" AutoGenerateColumns="False" DataKeyNames="CateringId"  
                ShowHeaderWhenEmpty="True" CssClass="table table-striped clsResizeColumn" CellPadding="4" ForeColor="#333333" GridLines="Vertical" AllowPaging="True">
                                        <EditRowStyle BackColor="#999999" />
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle Font-Size="Large" Height="25px" BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                 <asp:BoundField DataField="CateringId" Visible="false"/>
                 <asp:BoundField DataField="RegNo" HeaderText="Reg No" ReadOnly="true"/>
                 <asp:BoundField DataField="Type" HeaderText="Type" ReadOnly="true"/>
                 <asp:BoundField DataField="ReceivedBy" HeaderText="Received By" ReadOnly="true"/>
                  <asp:BoundField DataField="PrintName" HeaderText="Print Name" ReadOnly="true"/>
                 <asp:BoundField DataField="IssuedBy" HeaderText="Issued By" ReadOnly="true"/>
                        <asp:TemplateField HeaderText="Issued Date">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_IssueDateCreated" runat="server" Text='<%# SetDateVal(Eval("IssuedDate")) %>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                <asp:CommandField ShowSelectButton="true" ItemStyle-ForeColor="Red" SelectText="EDIT"/>

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
            </div>
            <!-- ============================================================== -->
            <!-- End PAge Content -->
            <!-- ============================================================== -->
      
  
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>

     <script type="text/javascript">
       
         $("#divGas").hide();
         $("#divCatering").hide();

       $('#<%=ddlShow.ClientID %>').change(function () {
           if ($(this).val() == "1") {
               $("#divGas").show();
               $("#divCatering").hide();
           }
           else if ($(this).val() == "2")
           {
               $("#divGas").hide();
               $("#divCatering").show();
           }
           else
           {
               $("#divGas").hide();
               $("#divCatering").hide();
           }
               
       });
                     </script>

</asp:Content>
