<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="job_add.aspx.vb" Inherits="CRM.job_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>
    <style>
        .bottom-main-section button {
            display: table;
            margin: 0 auto;
        }
    </style>

    <!-- ============================================================== -->
    <!-- Container fluid  -->
    <!-- ============================================================== -->

    <!-- ============================================================== -->
    <!-- Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <div class="row page-titles">
        <div class="col-md-5 align-self-center">
            <h4 class="text-themecolor">Job - Add</h4>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Info box -->
    <!-- ============================================================== -->
      <div class="col-md-12" style="padding-left:0">
            <div class="add-job">
         <div class="card">
                    <div class="card-body">
                        <div class="bottom-main-section">
                            <div class="floating-labels m-t-40">
                                <div class="form-group m-b-40">
                                    <asp:TextBox ID="txtsearchclient1" CssClass="form-control input-sm" runat="server" />
                                    <span class="bar"></span>
                                    <label for="input61">Search</label>
                                </div>
                                <div class="form-group m-b-40" style="display:none;">
                                    <asp:TextBox ID="txtsearchclient2" CssClass="form-control input-sm" runat="server" />
                                    <span class="bar"></span>
                                    <label for="input61">Search</label>
                                </div>
                                 <div class="button-group note-btn">
                                <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Search" />
                                <asp:Button ID="btnAddClient" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="ADD NEW CLIENT" />
</div>
                            </div>
                        </div>
                    </div>
                </div>
                </div>
      </div>


    <div class="row">

        <div class="col-lg-4">
            <div class="form-main-warp cost-warp">
                <div class="row">
                    <div class="col-md-12">
                        <div class="card">
                            <div class="card-body">
                                <div class="floating-labels m-t-30">
                                    <div class="floating-labels">
                                        <div class="form-group m-b-20">
                                            <asp:TextBox ID="txtCompanyName" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtCompanyName">Company Name</label>
                                        </div>
                                        <div class="form-group m-b-20">
                                            <asp:TextBox ID="txtForeName" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtForeName">Forename</label>
                                        </div>
                                        <div class="form-group m-b-20">
                                            <asp:TextBox ID="txtSurname" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtSurname">Surname</label>
                                        </div>
                                        <div class="form-group m-b-20">
                                            <asp:TextBox ID="txtContactPos" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtContactPos">Contact Position</label>
                                        </div>
                                        <div class="form-group m-b-20">
                                            <asp:TextBox ID="txtStreet" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtStreet">Street</label>
                                        </div>
                                        <div class="form-group m-b-20">
                                            <asp:TextBox ID="txtArea" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtArea">Area</label>
                                        </div>
                                        <div class="form-group m-b-20">
                                            <asp:TextBox ID="txtTown" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtTown">Town</label>
                                        </div>
                                        <div class="form-group m-b-20">
                                            <asp:TextBox ID="txtPostCode" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtPostCode">Postcode</label>
                                        </div>
                                        <div class="form-group m-b-20">
                                            <asp:TextBox ID="txtEmail" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtEmail">Email</label>
                                        </div>
                                        <div class="form-group m-b-20">
                                            <asp:TextBox ID="txtPhone" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtPhone">Phone</label>
                                        </div>
                                        <div class="form-group m-b-20">
                                            <asp:TextBox ID="txtFax" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtFax">Fax</label>
                                        </div>
                                        <div class="form-group m-b-20">
                                            <asp:TextBox ID="txtMobNum" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtMobNum">Mobile Number</label>
                                        </div>

                                    </div>
                                    <asp:HiddenField ID="hdnClientID" runat="server" />

                                </div>
                            </div>

                        </div>


                    </div>
                </div>
            </div>
        </div>

        <div class="col-lg-8 col-md-12">
            <div class="row">
                <div class="col-12">
                    <div class="card">
                        <div class="card-body">
                            <h5 class="card-title m-b-20">Search Results</h5>
                            
                            <div class="table-responsive">
                                <asp:GridView ID="grdclients" runat="server" DataKeyNames="ID"
                                    AllowPaging="True" PageSize="10" CssClass="table table-striped" AutoGenerateColumns="False"
                                    EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True">
                                    <HeaderStyle Font-Size="Small" Height="25px" />
                                    <Columns>
                                        <asp:CommandField ShowSelectButton="true" HeaderText="Information"/>
                                        <asp:BoundField DataField="ID" Visible="false" />
                                        <asp:BoundField DataField="Cname" HeaderText="Company Name" />
                                        <asp:BoundField DataField="Street" HeaderText="Street" />
                                        <asp:BoundField DataField="Town" HeaderText="Town" />
                                        <asp:BoundField DataField="Postcode" HeaderText="Post code" />

                                    </Columns>
                                    <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>

        <div class="col-md-12">
            <div class="add-job">
           
                <div class="form-main-warp cost-warp">
                    <div class="row">
                        <div class="col-md-6">
                            <div class="card">
                                <div class="card-body">
                                    <h5 class="card-title m-b-20">Requirements and job details</h5>
                                    <div class="floating-labels m-t-40">

                                        <div class="form-selection-box padddng-btn m-b-40">
                                            <asp:DropDownList ID="ddlAppliance" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                            </asp:DropDownList>
                                        </div>
                                         <div class="form-selection-box padddng-btn m-b-40">
                                            <asp:DropDownList ID="ddlManufacturer" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                            </asp:DropDownList>
                                        </div>
                                         
                                        <div class="form-selection-box padddng-btn m-b-40">
                                           <%--<asp:DropDownList ID="ddlModel" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                            </asp:DropDownList>--%>
                                      <select id="ddlModel" runat="server" class="btn dropdown-toggle form-control btn-secondary"><option value="0" >Select Model</option></select>  

                                        </div>
                                
                                        <div class="form-group m-b-30">
                                            <label class="card-title m-b-20" style="font-size:16px">Fault</label>
                                            <asp:TextBox ID="txtAreaFault" CssClass="form-control" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                                           
                                        </div>

                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="card">
                                <div class="card-body">
                                    <div class="floating-labels m-t-40">
                                           <div class="form-selection-box padddng-btn m-b-30">
                                            <asp:DropDownList ID="ddlType" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                                <asp:ListItem Text="Select Job Type" Value="Job Type"></asp:ListItem>
                                                <asp:ListItem Text="Repair" Value="Repair"></asp:ListItem>
                                                <asp:ListItem Text="PPM" Value="PPM"></asp:ListItem>
                                                <asp:ListItem Text="Installation" Value="Instalation"></asp:ListItem>

                                            </asp:DropDownList>
                                        </div>
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtAssetNumber" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtAssetNumber">Asset Number</label>
                                        </div>
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtOrderNum" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtOrderNum">Order Number</label>
                                        </div>
                                         <div>                                            
                                         <label style="top: 296px;margin-left: 16px;">Refigeration</label>
                                            <asp:CheckBox ID="chkRefrigiration" runat="server" /> 
                                        </div> 
                                        <div class="form-group m-b-40">

                                        </div>
                                       <div class="form-selection-box padddng-btn m-b-30">
                                            <asp:DropDownList ID="ddlSType" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                                <asp:ListItem Text="Select Type" Value="Type"></asp:ListItem>
                                                <asp:ListItem Text="Sales" Value="Sales"></asp:ListItem>
                                                <asp:ListItem Text="Repairs" Value="Repairs"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>                                    
                                    </div>
                                </div>

                            </div>
                        </div>


                    </div>
                </div>

                <div class="form-main-warp cost-warp">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="card">
                                <div class="card-body border-section">
                                    <div class="floating-labels m-t-40">
                                        <div class="form-group m-b-40">
                                             <asp:DropDownList ID="txtpremises" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                              </asp:DropDownList>
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtpremises">Premises</label>
                                        </div>
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtAddress" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtAddress">Address Line 1</label>
                                        </div>
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtAddress1" CssClass="form-control input-sm" runat="server" /><span class="bar"></span>
                                            <label for="input21">Address Line 2</label>
                                        </div>
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtaddress2" CssClass="form-control input-sm" runat="server" />
                                            <span class="bar"></span>
                                            <label for="input21">Address Line 3</label>
                                        </div>
                                        <div class="form-group m-b-40" style="margin-top:32px;">
                                               <asp:CheckBox ID="chkNew" runat="server" Text="NEW ADDRESS"  /> 
                                        </div>
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtPCode" CssClass="form-control input-sm" runat="server" /><span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtPCode">prem P Code:</label>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>

                <div class="bottom-form"></div>
                <div class="card">
                    <div class="card-body">
                        <div class="bottom-main-section">
                            <div class="floating-labels m-t-40">
                                <div class="form-group m-b-40" style="display:none;">
                                    <asp:TextBox ID="txtSearchAddress" CssClass="form-control input-sm" runat="server" />
                                    <span class="bar"></span>
                                    <label for="input61">Search address for Job Premises</label>
                                </div>
                                    <div class="button-group note-btn">
                                <asp:Button ID="btnAddJob" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Add new job" OnClientClick="return ValidateControls();" />
                                <asp:Button ID="btnReload" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Reload"/>
                                  </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <asp:HiddenField id = "hdnModel" runat="server" />
    </div>
    <script type="text/javascript">
        
        function ValidateControls()
        {
            var Appliance = document.getElementById("ContentPlaceHolder1_ddlAppliance").value;
            var Manufacturer = document.getElementById("ContentPlaceHolder1_ddlManufacturer").value;
            var Model = document.getElementById("ContentPlaceHolder1_ddlModel").value;
            var Jtype = document.getElementById("ContentPlaceHolder1_ddlType").value;
            var AssetNumber = document.getElementById("ContentPlaceHolder1_txtAssetNumber").value;
            var OrderNumber = document.getElementById("ContentPlaceHolder1_txtOrderNum").value;
            var Stype = document.getElementById("ContentPlaceHolder1_ddlSType").value;
            
            
            if (Appliance == '') {
                ShowPopupBlank("Please Choose Appliance Field");
                return false;
            }
            if (Manufacturer == '') {
                ShowPopupBlank("Please Choose Manufacturer Field");
                return false;
            }
            if (Model == '0') {
                ShowPopupBlank("Please Choose Appliance Model.");
                return false;
            }
            if (Jtype == 'Job Type') {
                ShowPopupBlank("Please Choose Job Type");
                return false;
            }
            //if (AssetNumber == '') {
            //    ShowPopupBlank("Please Enter AssetNumber Field.");
            //    return false;
            //}
            if (OrderNumber == '') {
                ShowPopupBlank("Please Enter OrderNumber Field.");
                return false;
            }
            if (Stype == 'Type') {
                ShowPopupBlank("Please Choose Type");
                return false;
            }
        }

         $("#<%=ddlAppliance.ClientID %>").change(function () {
              var idx = $("#<%= ddlAppliance.ClientID %>").val();
              if(idx=="Edit")
              {
                  window.open('Add_Appliance_Popup.aspx', 'win01', 'toolbar=no,status=no, menubar=yes, scrollbars=no,width=700,height=580,top=50, left=250');
              }
              else
              {

              }
         });

          $("#<%= ddlModel.ClientID %>").change(function () {
              var idx = $("#<%= ddlModel.ClientID %>").val();
              var e = document.getElementById("ContentPlaceHolder1_ddlModel");
              var strValue= e.options[e.selectedIndex].text;
              document.getElementById("<%= hdnModel.ClientID %>").value = strValue;
              if(idx=="1")
              {
                  window.open('Add_Model_Popup.aspx', 'win01', 'toolbar=no,status=no, menubar=yes, scrollbars=no,width=700,height=580,top=50, left=250');
              }
              else
              {

              }
          });

       <%--  $("#<%=ddlManufacturer.ClientID %>").change(function () {
              var idx = $("#<%= ddlManufacturer.ClientID %>").val();
             if (idx == 'ADD')
              {
                  window.open('Add_Manufacture_Popup.aspx', 'win01', 'toolbar=no,status=no, menubar=yes, scrollbars=no,width=700,height=580,top=50, left=250');
              }
              else
              {

              }
         });--%>


         $("#<%= ddlManufacturer.ClientID %>").change(function () {
             var ManufacturerId = $("#<%= ddlManufacturer.ClientID %>").val();
             if (ManufacturerId == 'ADD') {
                 window.open('Add_Manufacture_Popup.aspx', 'win01', 'toolbar=no,status=no, menubar=yes, scrollbars=no,width=700,height=580,top=50, left=250');
             }
             else {
                 var doaction = "setModelInDropdownByManufacturerId";
                 $.post('GetAjaxData.aspx', { DoAction: doaction, ManufacturerId: ManufacturerId }, function (responseText) {
                     if (responseText.toString() != "Error") {
                         var objModelDetails = JSON.parse(responseText)
                         $("#<%= ddlModel.ClientID %>").empty();
                         //$("#ddlModel option").remove();
                         $("#<%= ddlModel.ClientID %>").append("<option value='0'>Select Model</option>");
                         $("#<%= ddlModel.ClientID %>").append("<option value='1'>Edit & Delete Model</option>");

                         for (var i = 0; i < objModelDetails.length; i++) {
                             $("#<%= ddlModel.ClientID %>").append($("<option></option>").val(objModelDetails[i].Id).html(objModelDetails[i].Value));

                         }

                     }
                     else {
                         ShowPopupBlank("Sorry Appliance Model Nos In this Selection");
                         $("#<%= ddlModel.ClientID %>").empty();
                         $("#<%= ddlModel.ClientID %>").append("<option value='0'>Select Model</option>");
                         $("#<%= ddlModel.ClientID %>").append("<option value='1'>Edit & Delete Model</option>");


                     }
                 });
             }

        });



    </script>
</asp:Content>
