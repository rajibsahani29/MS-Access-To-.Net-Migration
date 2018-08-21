<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Manufacturer_list.aspx.vb" Inherits="CRM.Manufacturer_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>
     
              <div class="form-main-warp">
                            <div class="row">
                            <div class="col-md-6">
                              <div class="card">
                                    <div class="card-body">
                                       <div class="floating-labels m-t-40">
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtname" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtname">Manufacture Name</label>
                                        </div>
                                       
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <label for="ContentPlaceHolder1_txtPhone">Phone Number</label>
                                        </div>
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtfax" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <label for="ContentPlaceHolder1_txtfax">Fax</label>
                                        </div>
                                      <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtmobile" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <label for="ContentPlaceHolder1_txtPassword">Mobile</label>
                                        </div>
                                                                                   <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <label for="ContentPlaceHolder1_txtEmail">Email</label>
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
                                            <asp:TextBox ID="txtaddress1" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <label for="ContentPlaceHolder1_txtaddress1">Address1</label>
                                        </div>
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtaddress2" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <label for="ContentPlaceHolder1_txtaddress2">Address2</label>
                                        </div>
                                          <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtCity" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <label for="ContentPlaceHolder1_txtCity">City</label>
                                        </div>
                                         
                                                                            
                                       <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtpostcode1" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <label for="ContentPlaceHolder1_txtpostcode2">Postcode1</label>
                                        </div>
                                       
                                           <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtpostcode2" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <label for="ContentPlaceHolder1_txtpostcode2">Postcode2</label>
                                        </div>   

                                       
                                    </div>
                                      <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Add" OnClientClick="return ValidateControl();"/>
                                      </div>

                                </div>
                            </div>
                        </div>
                        </div>
    
    <div class="row">
        <div class="col-12">
            <div class="card">
                <div class="card-body">
                    <h5 class="card-title m-b-20">Manufacturer List</h5>
                    <div class="table-responsive">
                  
                <asp:GridView ID="grdManufacturer" runat="server" 
                AllowPaging="True" PageSize="20" CssClass="table table-striped" OnRowDataBound="grdManufacturer_OnRowDataBound"  AutoGenerateColumns="False" DataKeyNames="ManufacturerID" 
                emptydatatext="No Records Found" ShowHeaderWhenEmpty="True">
                <HeaderStyle Font-Size="Large" Height="25px" />
                <Columns>
                    <asp:BoundField DataField="ManufacturerID" HeaderText="ID" Visible="false" />
                    <asp:TemplateField HeaderText="Manufacturer Name">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_fname" runat="server" Text='<%#Eval("ManufacturerName")%>'/>
                        </ItemTemplate>
                              <EditItemTemplate>
                            <asp:TextBox ID="txtname" runat="server" Text='<%# Eval("ManufacturerName")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                       <asp:TemplateField HeaderText="Address1">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_add1" runat="server" Text='<%#Eval("Address1")%>'/>
                        </ItemTemplate>
                              <EditItemTemplate>
                            <asp:TextBox ID="txtaddress1" runat="server" Text='<%# Eval("Address1")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>   
                    <asp:TemplateField HeaderText="Address2">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_add2" runat="server" Text='<%#Eval("Address2")%>'/>
                        </ItemTemplate>
                              <EditItemTemplate>
                            <asp:TextBox ID="txtaddress2" runat="server" Text='<%# Eval("Address2")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>   
                    <asp:TemplateField HeaderText="City">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_City" runat="server" Text='<%#Eval("City")%>'/>
                        </ItemTemplate>
                              <EditItemTemplate>
                            <asp:TextBox ID="txtCity" runat="server" Text='<%# Eval("City")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>   
                    <asp:TemplateField HeaderText="PCode1">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_PCode1" runat="server" Text='<%#Eval("PCode1")%>'/>
                        </ItemTemplate>
                              <EditItemTemplate>
                            <asp:TextBox ID="txtPCode1" runat="server" Text='<%# Eval("PCode1")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                       <asp:TemplateField HeaderText="PCode2">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_PCode2" runat="server" Text='<%#Eval("PCode2")%>'/>
                        </ItemTemplate>
                              <EditItemTemplate>
                            <asp:TextBox ID="txtPCode2" runat="server" Text='<%# Eval("PCode2")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                    
                    
                       <asp:TemplateField HeaderText="Phone Number">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_Phone" runat="server" Text='<%#Eval("PhoneNumber")%>'/>
                        </ItemTemplate>
                              <EditItemTemplate>
                            <asp:TextBox ID="txtPhoneNumber" runat="server" Text='<%# Eval("PhoneNumber")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                          <asp:TemplateField HeaderText="FAX">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_fax" runat="server" Text='<%#Eval("FAX")%>'/>
                        </ItemTemplate>
                              <EditItemTemplate>
                            <asp:TextBox ID="txtFAX" runat="server" Text='<%# Eval("FAX")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                          <asp:TemplateField HeaderText="Mobile">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_Mobile" runat="server" Text='<%#Eval("Mobile")%>'/>
                        </ItemTemplate>
                              <EditItemTemplate>
                            <asp:TextBox ID="txtMobile" runat="server" Text='<%# Eval("Mobile")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
                          <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_Email" runat="server" Text='<%#Eval("Email")%>'/>
                        </ItemTemplate>
                              <EditItemTemplate>
                            <asp:TextBox ID="txtEmail" runat="server" Text='<%# Eval("Email")%>'/>
                        </EditItemTemplate>
                   </asp:TemplateField>
             <asp:CommandField ShowEditButton="True" ShowDeleteButton="true" />

              </Columns>
              <RowStyle HorizontalAlign="Center" Font-Size="Medium" Height="50px"/>
                        </asp:GridView>

                         
                    </div>
                </div>
            </div>
        </div>
    </div>
     <script>

        function ValidateControl() {
            var name;
            name = document.getElementById("ContentPlaceHolder1_txtname").value;
            if (name == '')
            {
                ShowPopupBlank("Enter Manufacturer Name Field First.");
                return false;
            }

        }
    </script>
</asp:Content>
