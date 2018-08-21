<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Day_Book.aspx.vb" Inherits="CRM.Day_Book" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>

        <div class="row page-titles">
        <div class="col-md-5 align-self-center">
            <h4 class="text-themecolor">Day Book</h4>
        </div>
    </div>
      <div class="row">                                                     <div class="col-md-3">

                                                  <div class="form-group m-b-20">
                                        <div class="skin skin-flat m-t-30 check-main-warp" id="optionforcheck" runat="server">
                                            <div class="form-group" >
                                     <label style="font-size:14px !important">Credit Control</label>
                                                <div class="input-group">
                                                    <ul class="icheck-list costs-main">
                                                        <li>
                                                            <asp:RadioButton ID="rdoCompany" runat="server" data-checkbox="icheckbox_flat-red" Checked="true" GroupName="a"/>
                                                            <label for="ContentPlaceHolder1_rdoFast">Company</label>
                                                        </li>
                                                        <li>
                                                            <asp:RadioButton ID="rdoTime" runat="server" data-checkbox="icheckbox_flat-red" GroupName="a" />
                                                            <label for="ContentPlaceHolder1_rdoFull">Time</label>
                                                        </li>
                                                         
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                            </div>
                                            </div>
      <div class="row">
                                                                                     
                                                
                                                     <div class="col-md-3">
                                                                <div class="example datepicker form-selection-box">
                                                                    <div class="input-group">
                                                                    <asp:TextBox ID="txtDate" runat="server" CssClass="form-control mydatepicker" placeholder="Date"></asp:TextBox>
                                                                        
                                                                        <div class="input-group-append">
                                                                            <span class="input-group-text"><i class="icon-calender"></i></span>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                      </div>
            <div class="button-group note-btn">
                                                      <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-outline-success btn-rounded" style="width:95px; height:35px;" />
                </div>
                                            </div>

    <div class="row">
        <div class="col-12">
            <div class="card">
                <div class="card-body">
                    <div class="table-responsive">
                  
                <asp:GridView ID="grdDaybook" runat="server" 
                AllowPaging="True" PageSize="20" CssClass="table table-striped clsResizeColumn" AutoGenerateColumns="False" DataKeyNames="JOB-ID" 
                emptydatatext="No Records Found" ShowHeaderWhenEmpty="True">
                <HeaderStyle Font-Size="Large" Height="25px" />
                <Columns>
                   <asp:BoundField DataField="JOB-ID" HeaderText="JOBID" Visible="false" />
                    <asp:BoundField DataField="Company Name" HeaderText="Comapany Name" ReadOnly="true" />
                    <asp:BoundField DataField="OnStopFlag" HeaderText="OnStop" ReadOnly="true" />
                    <asp:BoundField DataField="Uplift" HeaderText="Uplift" ReadOnly="true" />
                    <asp:BoundField DataField="Premises" HeaderText="Premises" ReadOnly="true" />
                    <asp:BoundField DataField="Response" HeaderText="Resp" ReadOnly="true" />
                    <asp:BoundField DataField="ViewJobN" HeaderText="FF Nos" ReadOnly="true" />
                    <asp:BoundField DataField="Order Number" HeaderText="Order N" ReadOnly="true" />
                    <asp:BoundField DataField="Appliance" HeaderText="Appliance" ReadOnly="true" />
                    <asp:BoundField DataField="Fault" HeaderText="Fault" ReadOnly="true" />
                    <asp:BoundField DataField="Status" HeaderText="Status" ReadOnly="true" />
                    <asp:BoundField DataField="Engineer" HeaderText="Engineer" ReadOnly="true" />
                  <asp:TemplateField HeaderText="Allocate">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_EnquiryDateCreated" runat="server" Text='<%# SetDateVal(Eval("SheetDate")) %>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                 <asp:CommandField ShowSelectButton="true" HeaderText="Information" SelectText="MORE.." ItemStyle-Font-Bold="true"/>
                     <asp:TemplateField HeaderText="Allocate">
                        <ItemTemplate>
<%--                            <asp:Button ID="btnAllocate" runat="server" Text='<%# SetDateVal(Eval("SheetDate")) %>' OnClick="javascript:openPopup('Add_Appliance_Popup.aspx?id=<%# Eval("ID") %>')" />--%>
                            <a href="javascript:openPopup('Job_Allocation_Popup.aspx?JobId=<%# Eval("JOB-ID") %>')"><b>Allocate</b></a>
                        </ItemTemplate>
                    </asp:TemplateField>
              </Columns>
              <RowStyle HorizontalAlign="Center" Font-Size="Medium" Height="50px"/>
                        </asp:GridView>

                        <asp:HiddenField ID="hdnCheck" runat="server" Value="1" />
                          
                    </div>
                </div>
            </div>
        </div>
    </div>

        <script type="text/javascript">
            
            $('#<%=rdoCompany.ClientID %>').click(function () {
                var id = 1
                $("#<%= hdnCheck.ClientID %>").val(id)
            });

            $('#<%=rdoTime.ClientID %>').click(function () {
                var id = 2
                $("#<%= hdnCheck.ClientID %>").val(id)
            });
        </script>

     <script type="text/javascript">


         function openPopup(strOpen) {
             window.open(strOpen, 'win01', 'toolbar=no,status=no, menubar=yes, scrollbars=no,width=700,height=580,top=50, left=250');

         }

    </script>
            

</asp:Content>
