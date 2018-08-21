<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Parts_Part_add_new.aspx.vb" Inherits="CRM.Parts_Part_add_new" %>

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
                    <h4 class="text-themecolor">Add New Part </h4>
                </div>
            </div>
            <!-- ============================================================== -->
            <!-- End Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- Info box -->
            <!-- ============================================================== -->
          <%--  <div class="form-main-warp">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="card">
                                    <div class="card-body">
                                        <div class="floating-labels m-t-30">
                                            <div class="floating-labels m-t-30">
                                                <div class="row">
                                                    <div class="col-md-3">
                                                        <div class="form-group m-b-30">
                                                            <asp:TextBox ID="txtsupplier" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtsupplier">Supplier</label>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-3">
                                                        <div class="form-group m-b-30">
                                                            <asp:TextBox ID="txtOrderNo" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtOrderNo">Order Number</label>
                                                        </div>
                                                    </div>
                                                      <div class="col-md-3">
                                                        <div class="form-group m-b-30">
                                                            <asp:TextBox ID="txtTotalCost" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                            <span class="bar"></span>
                                                            <label for="ContentPlaceHolder1_txtTotalCost">Total EX VAT</label>
                                                        </div>
                                                    </div>
                                                
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>--%>
            <div class="row">
                <div class="form-main-warp search-main-warp cost-warp select-warp-section">
                    <div class="card">
                        <div class="card-body">
                            <div class="floating-labels m-t-30">
                                <div class="floating-labels search-table m-t-30">
                                    <div class="floating-labels">
                                        
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtPartNo" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtPartNo">PartNumber</label>
                                        </div>
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtDescription">Description</label>
                                        </div>
                                        <div class="form-group m-b-40">
                                             <div class="form-selection-box padddng-btn m-b-40">
                                                <asp:DropDownList ID="ddlManufacturer" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                                </asp:DropDownList>
                                            </div>
                                            <label for="ContentPlaceHolder1_ddlManufacturer">Manufacturer</label>
                                        </div>
                                        <div class="form-group m-b-40">
                                           <div class="form-selection-box padddng-btn m-b-40">
                                                <asp:DropDownList ID="ddlApplianceType" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                                </asp:DropDownList>
                                            </div>
                                            <label for="ContentPlaceHolder1_ddlApplianceType">Appliance Type</label>
                                        </div>
                                        <div class="form-group m-b-40">
                                            <div class="form-selection-box padddng-btn m-b-40">
                                                <select id="ddlModel" class="btn dropdown-toggle form-control btn-secondary"><option value="0" >Select Model</option></select>  

                                                 </div>                                           <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_ddlModel">Appliance Model Nos</label>
                                        </div>
                                             <div class="button-group note-btn">
                                      <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Add" OnClientClick="return ValidateControls();"/>
                                                                                <asp:HiddenField ID="hdnMid" runat="server"/>
</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

     <div class="col-md-5 align-self-center">
                    <h4 class="text-themecolor" style="font-weight:bold;">Add New Model</h4>
                </div>
    <div class="row">
                <div class="form-main-warp search-main-warp cost-warp select-warp-section">
                    <div class="card">
                        <div class="card-body">
                            <div class="floating-labels m-t-30">
                                <div class="floating-labels search-table m-t-30">
                                    <div class="floating-labels">
                                        
                                        <div class="form-group m-b-40">
                                            <asp:TextBox ID="txtModel" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                            <span class="bar"></span>
                                            <label for="ContentPlaceHolder1_txtModel">New Model</label>
                                        </div>
                                            <div class="button-group note-btn">
                                      <asp:Button ID="btnAddModel" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Add Model" OnClientClick="return ValidateControlsModel();"/>
</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    <!-- ============================================================== -->
    <!-- End Container fluid  -->
    <!-- ============================================================== -->
<script type="text/javascript">

       function ValidateControls() {
           var partno, description, Manufacturer, Appliance, model;
            partno = document.getElementById("ContentPlaceHolder1_txtPartNo").value;
            description = document.getElementById("ContentPlaceHolder1_txtDescription").value;
            Manufacturer = document.getElementById("ContentPlaceHolder1_ddlManufacturer").value;
            Appliance = document.getElementById("ContentPlaceHolder1_ddlApplianceType").value;
            //model = document.getElementById("ddlModel").value;

            if (partno == '')
            {
                ShowPopupBlank("Please Fill Part Number Field.");
                return false;
            }
            if (description == '')
            {
                ShowPopupBlank("Please Fill Description Field.");
                return false;
            }
            if (Manufacturer == '')
            {
                ShowPopupBlank("Please Choose Manufacturer.");
                return false;
            }
            if (Appliance == '') {
                ShowPopupBlank("Please Choose Appliance.");
                return false;
            }
            if (model == '') {
                ShowPopupBlank("Please Choose Appliance Model.");
                return false;
            }

        }
         
       function ValidateControlsModel() {
           var Manufacturer, Appliance, model;
           Manufacturer = document.getElementById("ContentPlaceHolder1_ddlManufacturer").value;
           Appliance = document.getElementById("ContentPlaceHolder1_ddlApplianceType").value;
           model = document.getElementById("ContentPlaceHolder1_txtModel").value;
        
           if (Manufacturer == '' || Appliance == '')
           {
               ShowPopupBlank("Please Select Manufacturer And Appliance Type.");
               return false;
           }
          
           if (model == '')
           {
               ShowPopupBlank("Please Fill Model Name Field.");
               return false;
           }

       }

       $("#<%= ddlManufacturer.ClientID %>").change(function () {
             var idx = $("#<%= ddlManufacturer.ClientID %>").val()
              $("#<%= hdnMid.ClientID %>").val(idx)
         });

       $("#<%= ddlApplianceType.ClientID %>").change(function () {
            var ManufacturerId= $("#<%= hdnMid.ClientID %>").val()
             var Applianceid = $("#<%= ddlApplianceType.ClientID %>").val()
             var doaction = "setModelInDropdown";
             $.post('GetAjaxData.aspx', { DoAction: doaction, ManufacturerId: ManufacturerId, Applianceid: Applianceid }, function (responseText) {
                 if (responseText.toString() != "Error")
                 {
                     var objModelDetails = JSON.parse(responseText)
                     $("#ddlModel").empty();
                     //$("#ddlModel option").remove();
                     $("#ddlModel").append("<option value='0'>Select Model</option>");  

                     for (var i = 0; i < objModelDetails.length; i++)
                     {
                         $("#ddlModel").append($("<option></option>").val(objModelDetails[i].Id).html(objModelDetails[i].Value));

                      }  

                 }
                 else
                 {
                     ShowPopupBlank("Sorry Appliance Model Nos In this Selection");
                     $("#ddlModel").empty();
                     $("#ddlModel").append("<option value='0'>Select Model</option>");


                 }
             });
             

        });
    </script>
</asp:Content>
