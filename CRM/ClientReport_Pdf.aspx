<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ClientReport_Pdf.aspx.vb" Inherits="CRM.ClientReport_Pdf" %>

<!DOCTYPE html>

<html>
    <head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <!-- Favicon icon -->
    <title>Client Report Pdf</title>
     <style type="text/css">
        <% Server.Execute("InvoicePDF/style.min.css") %>

       
    </style>
    <style type = "text/css" >
        <% Server.Execute("InvoicePDF/new-style.css") %>
        </style>
    <style type="text/css">
        @media print {
            .page {
                 width: 24cm;
            }
        }
        .table th, .table td { padding: 0.5rem !important;}
        .nrow { clear:both;}
        .ncontrolparent { float:left; padding: 5px 10px; }
        .nlabel { width:120px;float:left;}
        .nvalue { float:left;}
    </style>
</head>
<body>
    <form id="frm1" runat="server">
    <div class="page" style="margin: 0 auto; padding: 20px;">
        <div class="header" style="width: 100%;">
            <div style="float: left;">
                <img src="<%= strRootUrl %>images/FFlogo.png" alt="logo" style="margin: 55px 0; height: 65px;" />
            </div>
            <div style="float: right; padding-left: 10px;">
                <div class="text-right" style="text-align: right;">
                    <p>
                        Catering Engineers
                    <br />
                        Sales and Services
                    <br />
                        Unit 9, 95 Boden Street
                    <br />
                        GLASGOW G40 3QF
                    </p>
                    <p>
                        Tel: 0141 554 8306
                    <br />
                        Fax: 0141 5548375
                    <br />
                        Email: admin@fastfixx.co.uk
                    <br />
                        Web: www.fastfixx.co.uk
                    </p>
                    <p>VAT Reg Nos: 761 944 409</p>
                </div>
            </div>
            <div style="padding:20px 0;"><div style="clear: both;height:4px;background-color: #000080;"></div></div>
        </div>
        
        <div class="invoice-content" style="float: left; width: 100%;">
            <div class="invoice-content-header" style="">
                <div class="invoice-content-header">
                   <h6 style="font-size:24px;font-weight:bold;font-style:italic;">Fast Fixx Client Report</h6>
                    <div style="clear: both;"></div>
                </div>
            </div>
        </div>
        <div style="clear: both;"></div>
        <br />
        <div style="width:100%">
            <div class="nrow">
                <div class="ncontrolparent" style="width:49%;">
                    <div class="nlabel">Company Name:</div>
                  <asp:Label ID="txtcompany" runat="server" CssClass="nvalue" Width="469px"></asp:Label>
                </div>
                 
            </div>
               <div class="nrow">
                <div class="ncontrolparent" style="width:49%;">
                    <div class="nlabel">Start Date</div>
                    <asp:Label ID="txtStartDate" runat="server" CssClass="nvalue"> </asp:Label>                

                </div>
                 <div class="ncontrolparent">
                    <div class="nlabel">End Date</div>
                    <asp:Label ID="txtEndDate" runat="server" CssClass="nvalue"> </asp:Label>
                </div>
              
            </div>
        </div>
        <br />
        <div class="invoice-table" style="margin-bottom: 20px;">
            
             <asp:GridView ID="grdClient" runat="server" AutoGenerateColumns="false" CssClass="table">
                                        <Columns>
                                            <asp:BoundField DataField="Type" HeaderText="Type" />
                                             <asp:TemplateField HeaderText="Sum Of Labour">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_labour" runat="server" Text='<%# Eval("SumOfLabour", "{0:N2}")%>'/>
                        </ItemTemplate>
                            
                   </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Sum Of Parts">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_parts" runat="server" Text='<%# Eval("SumOfParts", "{0:N2}")%>'/>
                        </ItemTemplate>
                            
                   </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Total">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_total" runat="server" Text='<%# Eval("Total", "{0:N2}")%>'/>
                        </ItemTemplate>
                            
                   </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
              <div style="float:right;padding:0 10px">
                                            
                            
                                <div class="ncontrolparent">
                                    <div class="nlabel" style="width: 150px;"> Labour Total</div>
                                    <asp:Label ID="lblLabourTotal" runat="server" CssClass="nvalue" Font-Bold="true"> </asp:Label>
                                </div>
                                                      <br />

                   <div class="ncontrolparent">
                                    <div class="nlabel" style="width: 150px;"> Parts Total</div>
                                    <asp:Label ID="lblPartTotal" runat="server" CssClass="nvalue" Font-Bold="true"> </asp:Label>
                                </div>
                                                                        <br />

                   <div class="ncontrolparent">
                                    <div class="nlabel" style="width: 150px;"> Total</div>
                                    <asp:Label ID="lblTotal" runat="server" CssClass="nvalue" Font-Bold="true"> </asp:Label>
                                </div>

                   </div>
                 
                       
            <div style="background-color: #000;height:2px;"></div>
        </div>
        <br />
        <div class="invoice-table" style="margin-bottom: 20px;">
            <div style="background-color: #000;height:2px;"></div>

        </div>
               
             
    </div>
</form>
</body>

</html>
