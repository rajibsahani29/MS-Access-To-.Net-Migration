<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="job_quote.aspx.vb" Inherits="CRM.job_quote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>

    <style>
        .btn-cost {
            display: table;
            margin: 0 auto 50px;
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
            <h4 class="text-themecolor">Job Quote</h4>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Info box -->
    <!-- ============================================================== -->

    <div class="row">

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
                                                    <asp:TextBox ID="txtCompanyName" CssClass="form-control input-sm" runat="server" ReadOnly="true" /><span class="bar"></span>
                                                    <label for="ContentPlaceHolder1_txtCompanyName">Company Name</label>
                                                </div>
                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-group m-b-30">
                                                    <asp:TextBox ID="txtEngineer" CssClass="form-control input-sm" runat="server" ReadOnly="true" /><span class="bar"></span>
                                                    <label for="ContentPlaceHolder1_txtEngineer">Engineer</label>
                                                </div>
                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-group m-b-30">
                                                    <asp:TextBox ID="txtJobNum" CssClass="form-control input-sm" runat="server" ReadOnly="true" />
                                                    <span class="bar"></span>
                                                    <label for="ContentPlaceHolder1_txtJobNum">Job Number</label>
                                                </div>
                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-group m-b-30">
                                                    <asp:TextBox ID="txtStatus" CssClass="form-control input-sm" runat="server" ReadOnly="true" />
                                                    <span class="bar"></span>
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


            <div class="form-main-warp">
                <div class="row">
                    <div class="col-md-6" style="border-style:ridge;">
                        <div class="card">
                            <div class="card-body">
                                <h4 class="text-themecolor">Add Labour</h4>
                                <div class="floating-labels m-t-30">
                                   <%-- <div class="form-selection-box padddng-btn m-b-40">
                                        <asp:DropDownList ID="ddlqty" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                        </asp:DropDownList>
                                    </div>--%>
                                      <div class="form-group m-b-30">
                                        <asp:TextBox ID="ddlqty" CssClass="form-control input-sm" runat="server" onchange="checkInput(event);"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_ddlqty">Quantity</label>
                                    </div>
                                    <div class="form-selection-box padddng-btn m-b-40">
                                        <asp:DropDownList ID="ddlcost" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-selection-box padddng-btn m-b-40">
                                        <asp:DropDownList ID="ddlhrs" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-selection-box padddng-btn m-b-40">
                                     <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Add Labour" OnClientClick="return ValidateControlsLabour()"/>

                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="col-md-6" style="border-style:ridge;">
                        <div class="card">
                            <div class="card-body">
                                <div class="floating-labels m-t-40">
                                    <div class="form-selection-box padddng-btn m-b-40">
                                        <asp:DropDownList ID="ddlAdditional" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtCharge" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtCharge">Charge</label>
                                    </div>
                                    <asp:Button ID="btnAdditional" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Add" OnClientClick="return ValidateControls()" />

                                </div>

                                <asp:HiddenField ID="hdnsum" runat="server" Value="0" />



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
                                <asp:GridView ID="grdLabour" runat="server" DataKeyNames="QuoteLabourID"
                                    AllowPaging="True" PageSize="10" CssClass="table table-striped" AutoGenerateColumns="False"
                                    EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True">
                                    <HeaderStyle Font-Size="Small" Height="25px" />
                                    <Columns>
                                        <asp:BoundField DataField="QuoteLabourID" Visible="false" />
                                          <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkRow" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Hours">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_charged" runat="server" Text='<%# Eval("HoursCharged")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtcharged" runat="server" Text='<%# Eval("HoursCharged")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Rate">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_rate" runat="server" Text='<%# Eval("rate", "{0:N2}")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtrate" runat="server" Text='<%# Eval("rate", "{0:N2}")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Hours Type">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_hrs" runat="server" Text='<%# Eval("Hours Type")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txthrs" runat="server" Text='<%# Eval("Hours Type")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="Comment" HeaderText="Notes" ReadOnly="true" />
                                        <asp:BoundField DataField="TotalCost" HeaderText="Total" ReadOnly="true" />
                                        <asp:CommandField ShowEditButton="True" ShowDeleteButton="true" />

                                    </Columns>
                                    <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


            <div class="row">
                <div class="col-12">
                    <div class="card">
                        <div class="card-body">
                            <h5 class="card-title m-b-20">Add Part Details</h5>
                            <div class="table-responsive">
                                <asp:GridView ID="grdPart" runat="server" DataKeyNames="JobPartID"
                                    AllowPaging="True" PageSize="10" CssClass="table table-striped" AutoGenerateColumns="False"
                                    EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True">
                                    <HeaderStyle Font-Size="Small" Height="25px" />
                                    <Columns>
                                        <asp:BoundField DataField="JobPartID" Visible="false" />
                                        <asp:TemplateField HeaderText="Quantity">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_qty" runat="server" Text='<%# Eval("Quantity")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtqty" runat="server" Text='<%# Eval("Quantity")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>


                                        <asp:TemplateField HeaderText="Part Number">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_part" runat="server" Text='<%# Eval("Part Number")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtpartno" runat="server" Text='<%# Eval("Part Number")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="true" />
                                        <asp:BoundField DataField="Supplier" HeaderText="Supplier" ReadOnly="true" />
                                        <asp:TemplateField HeaderText="Unit Price">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_unitprice" runat="server" Text='<%# Eval("UnitPrice", "{0:N2}")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtunitp" runat="server" Text='<%# Eval("UnitPrice", "{0:N2}")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Sell Price">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_sellprice" runat="server" Text='<%# Eval("SellPrice", "{0:N2}")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtsellp" runat="server" Text='<%# Eval("SellPrice", "{0:N2}")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="%MarkUp">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_markup" runat="server" Text='<%# Eval("%MarkUp", "{0:N2}")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtmarkup" runat="server" Text='<%# Eval("%MarkUp", "{0:N2}")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="Total" HeaderText="Total" ReadOnly="true" />
                                        <asp:CommandField ShowDeleteButton="true" ShowEditButton="true" />

                                    </Columns>
                                    <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="form-main-warp">
                <div class="row">
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-body">
                                <h4 class="text-themecolor">Add Parts</h4>
                                <div class="floating-labels m-t-30">
                                    <div class="form-selection-box padddng-btn m-b-40">
                                        <asp:DropDownList ID="ddlqty1" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtCostPrice" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtCostPrice">Cost Price</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtSellPrice" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtSellPrice">Sell Price</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtPartNum" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtPartNum">Part Number </label>
                                    </div>
                                    <div>
                                        <asp:Button ID="btnAddpart" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Add Part" OnClientClick="return ValidateControlsPart()"/>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-body">
                                <div class="floating-labels m-t-40">
                                    <div class="form-group">
                                        <label>Description</label>
                                        <asp:TextBox ID="txtAreaDescription" CssClass="form-control" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                                    </div>
                                    <div class="form-selection-box padddng-btn m-b-40">
                                        <asp:DropDownList ID="ddlSupplier" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                        </asp:DropDownList>
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
                            <h5 class="card-title m-b-20">Add from Quote Investigation</h5>
                            <div class="table-responsive">
                                <asp:Repeater ID="RptJobList3" runat="server">
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
                                </asp:Repeater>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


            <div class="form-main-warp">
                <div class="row">
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-body">
                                <h4 class="text-themecolor">Total and Email</h4>
                                <div class="floating-labels m-t-30">
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtQuoteNum" CssClass="form-control input-sm" runat="server" ReadOnly="true" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtQuoteNum">Quote Number</label>
                                    </div>
                                    <div class="example datepicker form-selection-box m-b-40">
                                        <div class="input-group">
                                            <asp:TextBox ID="txtQuoteEnquiryDate" runat="server" CssClass="form-control mydatepicker" placeholder="Quote date"></asp:TextBox>
                                            <div class="input-group-append">
                                                <span class="input-group-text"><i class="icon-calender"></i></span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtLabour" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtLabour">Labour</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtParts" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtParts">Parts</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtAdditional" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtAdditional">Additional</label>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtTotal" Font-Bold="true" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtTotal">Total</label>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-body">
                                <div class="floating-labels m-t-40">
                                    <div class="form-selection-box padddng-btn m-b-40">
                                        <asp:DropDownList ID="ddlVat" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-selection-box padddng-btn m-b-40">
                                        <asp:DropDownList ID="ddldays" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-selection-box padddng-btn m-b-40">
                                        <asp:DropDownList ID="ddlEmail" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtMessage" CssClass="form-control input-sm" runat="server" />
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtMessage">Message</label>
                                    </div>

                                </div>
                                <div class="form-group m-b-40">
                                    <div class="skin skin-flat m-t-30 check-main-warp">
                                        <div class="form-group">
                                            <label>Print Out Option</label>
                                            <div class="input-group">
                                                <ul class="icheck-list costs-main">
                                                    <li>
                                                        <asp:RadioButton ID="rdopreview" runat="server" class="check" GroupName="forInvoice" data-radio="iradio_flat-red" />
                                                        <label for="flat-radio-1">Preview First</label>
                                                    </li>

                                                    <li>
                                                        <asp:RadioButton ID="rdoEmail" runat="server" class="check" GroupName="forInvoice" data-radio="iradio_flat-red" />
                                                        <label for="flat-radio-2">Send As Email</label>

                                                    </li>
                                                </ul>
                                            </div>
                                        </div>

                                        <div class="form-group m-b-30">
                                            <asp:Button ID="btnEmail" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30 btn-cost" Text="Print/Email" />

                                        </div>
                                         
                                      
                                    </div>

                                </div>
                            </div>
                            <asp:HiddenField ID="hdnCid" runat="server" />

                        </div>
                    </div>
                    <asp:Button ID="btnInvestigation" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30 btn-cost" Text="Add From Quote investigation..." OnClientClick="Popup();return false;" />
                                             <asp:Button ID="btnReload" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30 btn-cost" Text="Reload" style="margin-left: -420px;"/>

                    <asp:HiddenField ID="hdnLabour" runat="server" />
                </div>


            </div>

        </div>


    </div>
    <script type="text/javascript">
        function Popup() {
            popupWindow = window.open("job_add_investigate.aspx", 'popUpWindow', 'height=400,width=900,left=200,top=230,resizable=No,scrollbars=yes,toolbar=no,menubar=no,location=no,directories=no, status=No');
        }

         $("#<%=ddlAdditional.ClientID %>").change(function () {
              var idx = $("#<%= ddlAdditional.ClientID %>").val();
             if (idx == "Edit & Delete")
              {
                 window.open('Add_AdditionalCharges_Popup.aspx', 'win01', 'toolbar=no,status=no, menubar=yes, scrollbars=no,width=700,height=580,top=50, left=250');
              }
              else
              {

              }
         });

         $("#<%=ddlVat.ClientID %>").change(function () {
              var idx = $("#<%= ddlVat.ClientID %>").val();
             if (idx == "Edit & Delete")
              {
                 window.open('Add_VAT_Popup.aspx', 'win01', 'toolbar=no,status=no, menubar=yes, scrollbars=no,width=700,height=580,top=50, left=250');
              }
              else
              {

              }
         });

        function ValidateControls() {
            var chargeType,charges;
            chargeType = document.getElementById("ContentPlaceHolder1_ddlAdditional").value;
            charges = document.getElementById("ContentPlaceHolder1_txtCharge").value;

            if (chargeType == 'Additional Charge' || chargeType == 'Edit & Delete') {
                ShowPopupBlank("Please Choose Additional Charge Field.");
                return false;
            }
           

            if (charges == '') {
                ShowPopupBlank("Please Fill Charge Field.");
                return false;
            }

          
        }

        

        function ValidateControlsLabour()
        {
            var qty, cost,hours;
            qty = document.getElementById("ContentPlaceHolder1_ddlqty").value;
            cost = document.getElementById("ContentPlaceHolder1_ddlcost").value;
            hours = document.getElementById("ContentPlaceHolder1_ddlhrs").value;

            if (qty == '')
            {
                ShowPopupBlank("Please Enter Quanity Field.");
                return false;
            }
            if (cost == 'Cost') {
                ShowPopupBlank("Please Choose Cost Field.");
                return false;
            }
          
            if (hours == 'Hours') {
                ShowPopupBlank("Please Choose Hours Field.");
                return false;
            }
        }

        
        function ValidateControlsPart() {
            var qty1, cost, sellprice, PartNum, supplier;
            qty1 = document.getElementById("ContentPlaceHolder1_ddlqty1").value;
            cost = document.getElementById("ContentPlaceHolder1_txtCostPrice").value;
            sellprice = document.getElementById("ContentPlaceHolder1_txtSellPrice").value;
            PartNum = document.getElementById("ContentPlaceHolder1_txtPartNum").value;
            supplier = document.getElementById("ContentPlaceHolder1_ddlSupplier").value;

            
            
            if (qty1 == 'Select') {
                ShowPopupBlank("Please Choose Part Quanity Field.");
                return false;
            }
            if (cost == '') {
                ShowPopupBlank("Please Enter Cost Price Field.");
                return false;
            }

            if (sellprice == '') {
                ShowPopupBlank("Please Enter Sell Price Field.");
                return false;
            }
            if (PartNum == '') {
                ShowPopupBlank("Please Enter Part Number Field.");
                return false;
            }
            if (supplier == 'Select Supplier')
            {
                ShowPopupBlank("Please Choose Supplier Field.");
                return false;
            }

        }

         function checkInput(e)
    {
         var numbersOnly = /^\d+$/;
         var decimalOnly = /^[-+]?[0-9]+\.[0-9]+$/;

         var inputval = $("#<%= ddlqty.ClientID %>").val();
             if (numbersOnly.test(inputval))
        {
           return true;
        } else
        {
            ShowPopupBlank("Enter Quantity Field In Correct Format.");
            return false;
        }
         
    }

    </script>

    <script type="text/javascript">
           $(document).ready(function () {
               $('#<%=btnEmail.ClientID%>').click(
                   function (e) {
                       var legchecked = $("input[type='checkbox']:checked").length;
                       if (legchecked == 0) {
                           ShowPopupBlank("Please Check Any of these Checkbox before Proceed For Sending Mail.");
                           e.preventDefault();
                       }
                   });
           });

                  
       </script>
</asp:Content>
