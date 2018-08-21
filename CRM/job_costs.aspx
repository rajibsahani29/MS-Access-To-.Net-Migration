<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="job_costs.aspx.vb" Inherits="CRM.job_costs" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="ckeditor/ckeditor.js"></script>
    <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>


    <!-- ============================================================== -->
    <!-- Container fluid  -->
    <!-- ============================================================== -->

    <!-- ============================================================== -->
    <!-- Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <div class="row page-titles">
        <div class="col-md-5 align-self-center">
            <h4 class="text-themecolor">Job - Costs</h4>
        </div>
    </div>


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
                                                    <asp:TextBox ID="txtCompany" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox>
                                                    <span class="bar"></span>
                                                    <label for="ContentPlaceHolder1_txtCompany">Company Name</label>
                                                </div>
                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-group m-b-30">
                                                    <asp:TextBox ID="txtEngineer" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox><span class="bar"></span>
                                                    <label for="ContentPlaceHolder1_txtEngineer">Engineer</label>
                                                </div>
                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-group m-b-30">
                                                    <asp:TextBox ID="txtJobNumber" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox><span class="bar"></span>
                                                    <label for="ContentPlaceHolder1_txtJobNumber">Job Number</label>
                                                </div>
                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-group m-b-30">
                                                    <asp:TextBox ID="txtStatus" runat="server" CssClass="form-control input-sm" ReadOnly="true"></asp:TextBox><span class="bar"></span>
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
            <div class="row">
                <div class="col-12">
                    <div class="card">
                        <div class="card-body">
                            <h5 class="card-title m-b-20">Search Results</h5>
                            <h6 class="card-subtitle m-b-30">Search Results data</h6>
                            <div class="table-responsive">
                                
                                <asp:GridView ID="grdInvoice" runat="server" Width="100%"
                                    AllowPaging="True" PageSize="10" AutoGenerateColumns="False" DataKeyNames="InvoiceItemlID"
                                    EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True">
                                    <HeaderStyle Font-Size="Small" Height="25px" CssClass="table table-striped" />
                                    <Columns>
                                        <asp:BoundField DataField="InvoiceItemlID" HeaderText="ID" Visible="false" />
                                         <asp:TemplateField HeaderText="Line">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_line" runat="server" Text='<%#Eval("Line")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtline" runat="server" Text='<%# Eval("Line")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                          <asp:TemplateField HeaderText="Item Desctiption">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_desc" runat="server" Text='<%#Eval("ItemDesctiption")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtdesc" runat="server" Text='<%# Eval("ItemDesctiption")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="Unit">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_unit" runat="server" Text='<%#Eval("UNIT")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtUnit" runat="server" Text='<%# Eval("UNIT")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Qty">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_qty" runat="server" Text='<%#Eval("Nos")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtqty" runat="server" Text='<%# Eval("Nos")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                          <asp:TemplateField HeaderText="Cost">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_cost" runat="server" Text='<%#Eval("Cost", "{0:n2}")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtcost" runat="server" Text='<%# Eval("Cost", "{0:n2}")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="Total" HeaderText="Total" ReadOnly="true" DataFormatString="{0:N2}" />
                                        <asp:CommandField ShowEditButton="true" ShowDeleteButton="true"/>

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
                                <h5 class="card-title m-b-20">Add a new cost</h5>

                                <div class="floating-labels m-t-40">
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="txtItemDescription" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                    </div>
                                    <div class="form-selection-box padddng-btn m-b-40" id="divddlqty">
                                        <asp:DropDownList ID="ddlqty" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-group m-b-40" id="divqty">
                                          <asp:TextBox ID="txthourqty" runat="server" CssClass="form-control input-sm" onchange="checkInput(event);"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txthourqty">Quantity</label>
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtCost" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtCost">Cost</label>
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
                                        <asp:DropDownList ID="ddlunit" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-group m-b-20">
                                        <div class="skin skin-flat m-t-30 check-main-warp">
                                            <div class="form-group">
                                                <label>Credit Control and Account</label>
                                                <div class="input-group">
                                                    <ul class="icheck-list costs-main">
                                                        <li>
                                                            <asp:RadioButton ID="rdoFast" runat="server" data-checkbox="icheckbox_flat-red" Checked="true" GroupName="a" AutoPostBack="true" />
                                                            <label for="ContentPlaceHolder1_rdoFast">Fast Fixx Generaly Used Only</label>
                                                        </li>
                                                        <li>
                                                            <asp:RadioButton ID="rdoFull" runat="server" data-checkbox="icheckbox_flat-red" GroupName="a" AutoPostBack="True" />
                                                            <label for="ContentPlaceHolder1_rdoFull">Full PECOS List</label>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="example datepicker form-selection-box m-b-40">
                                    </div>
                                    <div class="form-group m-b-40">
                                        <asp:TextBox ID="txtVatRate" runat="server" CssClass="form-control input-sm" Text="20.00%"></asp:TextBox>
                                        <span class="bar"></span>
                                        <label for="ContentPlaceHolder1_txtVatRate"></label>
                                    </div>
                                </div>
                            </div>

                        </div>
                        <div class="input-group">
                            <input type="text" class="form-control mydatepicker" placeholder="Invoice Date" id="txtInvoiceDate" runat="server" />

                            <div class="input-group-append">
                                <span class="input-group-text"><i class="icon-calender"></i></span>
                            </div>
                        </div>

                        <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Add..." OnClientClick="return ValidateControls()" />


                    </div>
                </div>
            </div>

            <div class="form-main-warp">
                <div class="row">
                    <div class="col-md-6">
                        <div class="card">


                            <div class="card-body border-section">
                                <h5 class="card-title m-b-20">Action Costs</h5>
                                <div class="floating-labels m-t-40">
                                    <div class="form-selection-box padddng-btn m-b-40">

                                        <asp:DropDownList ID="ddlEmail" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary"></asp:DropDownList>
                                    </div>
                                    <div class="form-group m-b-30">
                                        <asp:TextBox ID="InvoiceMessage" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="8">Enter email text below</asp:TextBox>
                                    </div>
                                  
                                    <div class="form-group m-b-40" style="display:none;">
                                        <div class="skin skin-flat m-t-30 check-main-warp">
                                            <div class="form-group">
                                                <label style="font-size:16px;padding-left:10px;">Credit Control and Account</label>
                                                <div class="input-group">
                                                    <ul class="icheck-list costs-main">
                                                        <li>
                                                            <asp:RadioButton ID="rdopreview" runat="server" class="check" GroupName="forInvoice" data-radio="iradio_flat-red" AutoPostBack="true" />
                                                            <label for="flat-radio-1">Preview First</label>
                                                        </li>
                                                        <li>
                                                            <asp:RadioButton ID="rdoprint" runat="server" class="check" GroupName="forInvoice" data-radio="iradio_flat-red" AutoPostBack="true" />
                                                            <label for="flat-radio-2">Just Print</label>
                                                        </li>
                                                        <li>                                                            
                                                            <asp:RadioButton ID="rdoEmail" runat="server" class="check" GroupName="forInvoice" data-radio="iradio_flat-red" AutoPostBack="true" />
                                                            <label for="flat-radio-2">Email</label>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                      <div class="form-group m-b-40">
                                        <div class="skin skin-flat m-t-30 check-main-warp">
                                            <div class="form-group">
                                                <div class="button-group note-btn">
                                       <asp:Button ID="btnPreview" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Preview" />
                                    <asp:Button ID="btnPrint" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Print" />
                                    <asp:Button ID="btnEmail" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="Email" />

                                                </div>
                                            </div>
                                        </div>
                                    </div>



                                      
                                </div>

                            </div>

                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-body">
                                <h5 class="card-title m-b-20">Output GCC Invoice in CSV Format</h5>
                                <div class="floating-labels m-t-40">
                                    <div class="form-group costs-file-upload">
                                        <label>Default file upload</label>
                                        <input type="file" class="form-control" id="exampleInputFile" aria-describedby="fileHelp">
                                       <input type="text" class="form-control" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <asp:HiddenField ID="hdnCid" runat="server" />
    <asp:HiddenField ID="hdnIncVat" runat="server" />
    <script type="text/javascript">
        CKEDITOR.replace('<%=txtItemDescription.ClientID %>', {
            toolbarGroups: [
                { "name": "basicstyles", "groups": ["basicstyles"] },
                { "name": "links", "groups": ["links"] },
                { "name": "document", "groups": ["mode"] },
                { "name": "insert", "groups": ["insert"] },
                { "name": "styles", "groups": ["styles"] },
                //{"name":"about","groups":["about"]}
            ],
            // Remove the redundant buttons from toolbar groups defined above.
            removeButtons: 'Underline,Strike,Subscript,Superscript,Anchor,Styles,Specialchar,Save,Print,Font',
            enterMode: CKEDITOR.ENTER_BR,
            removePlugins: 'elementspath'

        });

                CKEDITOR.replace('<%=InvoiceMessage.ClientID %>', {
            toolbarGroups: [
                { "name": "basicstyles", "groups": ["basicstyles"] },
                { "name": "links", "groups": ["links"] },
                { "name": "document", "groups": ["mode"] },
                { "name": "insert", "groups": ["insert"] },
                { "name": "styles", "groups": ["styles"] },
                //{"name":"about","groups":["about"]}
            ],
            // Remove the redundant buttons from toolbar groups defined above.
            removeButtons: 'Underline,Strike,Subscript,Superscript,Anchor,Styles,Specialchar,Save,Print,Font',
            enterMode: CKEDITOR.ENTER_BR,
            removePlugins: 'elementspath'

        });


    </script>
    
 <script type="text/javascript">

       function ValidateControls() {
           var description, unit, qty,qty1, Cost, invoicedate;
           //description = document.getElementById("ContentPlaceHolder1_txtItemDescription").value;
           qty = document.getElementById("ContentPlaceHolder1_ddlqty").value;
           qty1 = document.getElementById("ContentPlaceHolder1_txthourqty").value;
           unit = document.getElementById("ContentPlaceHolder1_ddlunit").value;
           Cost = document.getElementById("ContentPlaceHolder1_txtCost").value;
           invoicedate = document.getElementById("ContentPlaceHolder1_txtInvoiceDate").value;

           //if (description == '')
           // {
           //     ShowPopupBlank("Please Fill Item Description Field.");
           //     return false;
           //}
           
          
           if (unit == 'Select Unit')
            {
                ShowPopupBlank("Please Choose Unit Field.");
                return false;
            }
           if ($("#<%= ddlunit.ClientID %>").val() == 'HR')
           {
               if (qty1 == '') {
                   ShowPopupBlank("Please Fill Quantity Field.");
                   return false;
               }
           }
           else
            {
               if (qty == 'Select Qty') {
                   ShowPopupBlank("Please Choose Quantity Field.");
                   return false;
               }
            }
           if (Cost == '') {
                ShowPopupBlank("Please Fill Cost Field.");
                return false;
           }

           if (invoicedate == '') {
               ShowPopupBlank("Please Fill Invoice Date Field.");
               return false;
           }
           
       }
     function checkInput(e)
    {
         var numbersOnly = /^\d+$/;
         var decimalOnly = /^[-+]?[0-9]+\.[0-9]+$/;

         var inputval = $("#<%= txthourqty.ClientID %>").val();
         if (numbersOnly.test(inputval) || decimalOnly.test(inputval))
        {
           return true;
        } else
        {
            ShowPopupBlank("Enter Quantity Field In Correct Format.");
            return false;
        }
         
    }

       $(document).ready(function ()
           {
           $("#divqty").hide();
           $("#divddlqty").show();
           });
   

     $("#<%= ddlunit.ClientID %>").change(function ()
     {
         if ($("#<%= ddlunit.ClientID %>").val() == 'HR')
         {
             $("#divqty").show();
             $("#divddlqty").hide();
         }
         else
         {
              $("#divqty").hide();
              $("#divddlqty").show();
         }

     });

      $("#<%= ddlEmail.ClientID %>").change(function ()
     {
          if ($("#<%= ddlEmail.ClientID %>").val() == 'Select Email Address')
         {
              CKEDITOR.instances["<%= InvoiceMessage.ClientID %>"].setData("Enter email text below");
         }
         else
          {
              var Jobnumber = $("#<%= txtJobNumber.ClientID %>").val();
              var message = "";
              message += "Please find attached invoice for job number " + Jobnumber + " total including VAT is £ " + $("#<%= hdnIncVat.ClientID %>").val() + ""+"<br>"
              message+= "Payment can be made to"+"<br>"
              message += "Bank of Scotland" + "<br>"
              message += "A/c Number:  10215163" + "<br>"
              message += "Sort code:  80-11-80" + "<br>"

              CKEDITOR.instances["<%= InvoiceMessage.ClientID %>"].setData(message);
          }

     });
    </script>
</asp:Content>
