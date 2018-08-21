<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="job_Quote_Print.aspx.vb" Inherits="CRM.job_Quote_Print" %>

<!DOCTYPE html>

<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <!-- Favicon icon -->
    <link rel="icon" type="image/png" sizes="16x16" href="../assets/images/favicon.png">
    <title>Job Quote</title>
    <!-- This page CSS -->
    <!-- chartist CSS -->
   
    <link href="dist/css/style.min.css" rel="stylesheet">
    <link href="dist/css/new-style.css" rel="stylesheet">

    <style>
        .new_invoice_main_warp .invoice-form {
            border-top: 4px solid #000080;
            padding-top: 30px;
        }

        .new_invoice_main_warp .invoice-header {
            border-bottom: 0px;
            padding-bottom: 0px;
        }

        .invoice-table tbody tr:last-child {
            border: 0px;
        }

        .new_invoice_main_warp th {
            font-weight: 600;
        }

        .new-invoice-warp {
            float: left;
            width: 100%;
            border: 3px solid #ddd;
            padding: 20px;
        }

        .bottom-border-line {
            border-bottom: 1px solid #ddd;
        }

        .new-footer {
            float: left;
            width: 100%;
            padding: 5px 0;
        }
    </style>
</head>

<body class="skin-default-dark fixed-layout">
    <!-- ============================================================== -->
    <!-- Preloader - style you can find in spinners.css -->
    <!-- ============================================================== -->
   <form id="frm1" runat="server">
    <div id="main-wrapper">

        <div class="page-wrapper invoice-page-warp">
            <!-- ============================================================== -->
            <!-- Container fluid  -->
            <!-- ============================================================== -->
            <div class="container-fluid">

                <div class="invoice-main-warp new_invoice_main_warp">
                    <div class="main-invoice-warp">
                        <div class="invoice-header">
                            <div class="left-header">
                                <a href="#"><img src="images/FFlogo.png" alt="logo"></a>
                            </div>
                            <div class="middel-header">
                                <!-- <a href="#"><img src="images/FFlogo.png" alt="logo"></a> -->
                            </div>
                            <div class="right-header">
                                <div class="text-right">
                                    <p>
                                        Catering Engineers
                                        <br>Sales and Services
                                        <br>unit 9,95 Boden Street
                                        <br>Glasgow G40 3QF
                                    </p>
                                    <p>
                                        Tel: 0141 554 8306
                                        <br>Fax: 0141 5548375
                                        <br>Email: admin@fastfixx.co.uk
                                        <br>Web: www.fastfixx.co.uk
                                    </p>
                                    <p>VAT Reg Nos: 761 944 409</p>
                                </div>
                            </div>
                        </div>

                        <div class="invoice-content">
                            <div class="invoice-content-header">
                                <div class="faq-invoice">
                                    <p>Quote <br> FAO</p>
                                </div>
                                <span>
                                    <asp:Label ID="txtcompany" runat="server" Width="290px" BorderStyle="None"> </asp:Label><br/>
                                    <asp:Label ID="txtStreet" runat="server" Width="290px" BorderStyle="None"> </asp:Label><br/>
                                    <asp:Label ID="txtArea" runat="server" Width="290px" BorderStyle="None"> </asp:Label><br/>
                                    <asp:Label ID="txtTown" runat="server" Width="290px" BorderStyle="None"> </asp:Label><br/>
                                    <asp:Label ID="txtPostCode" runat="server" Width="290px" BorderStyle="None"> </asp:Label>

                                </span>
                            </div>

                            <div class="invoice-form">
                                <div class="row">
                                    <div class="col-md-6">
                                        <div>
                                            <div class="form-group row">
                                                <label for="inputEmail3" class="col-sm-3 col-form-label">Asset Number</label>
                                                <div class="col-sm-9">
                                        <asp:Label ID="txtasset" runat="server" CssClass="form-control"> </asp:Label>
                                                </div>
                                            </div>
                                            <div class="form-group row">
                                                <label for="inputPassword3" class="col-sm-3 col-form-label">Make Model:</label>
                                                <div class="col-sm-9">
                                             <asp:Label ID="txtmodel" runat="server" CssClass="form-control"> </asp:Label>
                                                </div>
                                            </div>
                                            <div class="form-group row">
                                                <label for="inputPassword3" class="col-sm-3 col-form-label">Appliance</label>
                                                <div class="col-sm-9">
                                             <asp:Label ID="txtappliance" runat="server" CssClass="form-control"> </asp:Label>                
                                                </div>
                                            </div>
                                            <div class="form-group row">
                                                <label for="inputPassword3" class="col-sm-3 col-form-label">Quote Number</label>
                                                <div class="col-sm-9">
                                             <asp:Label ID="txtquotenumber" runat="server" CssClass="form-control"> </asp:Label>
                                                </div>
                                            </div>
                                            <div class="form-group row">
                                                <label for="inputPassword3" class="col-sm-3 col-form-label">QuoteDate:</label>
                                                <div class="col-sm-9">
                                             <asp:Label ID="txtquoteDate" runat="server" CssClass="form-control"> </asp:Label>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                            <div class="form-group row">
                                                <label class="col-sm-3 col-form-label" for="exampleFormControlTextarea1">Fault/Requirements</label>
                                                <div class="col-sm-9">
                                    <asp:TextBox ID="txtfault" runat="server" CssClass="form-control" TextMode="MultiLine"> </asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="form-group row">
                                                <label for="inputPassword3" class="col-sm-3 col-form-label">Fast Fixx Nos</label>
                                                <div class="col-sm-9">
                                             <asp:Label ID="txtffnos" runat="server" CssClass="form-control"> </asp:Label>
                                                </div>
                                            </div>
                                            <div class="form-group row">
                                                <label for="inputPassword3" class="col-sm-3 col-form-label">Your Ref</label>
                                                <div class="col-sm-9">
                                             <asp:Label ID="txtref" runat="server" CssClass="form-control"> </asp:Label>
                                                </div>
                                            </div>
                                    </div>

                                    <div class="col-md-12">
                                        <div>
                                            <div class="form-group row">
                                                <label class="col-sm-2 col-form-label" for="exampleFormControlTextarea1">Job Premise</label>
                                                <div class="col-sm-10">
              <asp:Label ID="txtpremises" runat="server" CssClass="form-control"> </asp:Label>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="new-invoice-warp">
                                <div class="invoice-table">
                                    <asp:GridView ID="grdLabour" runat="server" AutoGenerateColumns="false" CssClass="table">
                                        <Columns>
                                            <asp:BoundField DataField="Description" HeaderText="Labour" />
                                            <asp:BoundField DataField="Quantity" HeaderText="Qty" />
                                             <asp:TemplateField HeaderText="Unit Price">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_rate" runat="server" Text='<%# Eval("UnitPrice", "{0:N2}")%>'/>
                        </ItemTemplate>
                            
                   </asp:TemplateField>
                                            <asp:BoundField DataField="Total" HeaderText="Total" />
                                            
                                        </Columns>
                                    </asp:GridView>
                                  
                                 <div class="form-group row" style="float:right" >
                                                <label  for="exampleFormControlTextarea1" style="font-weight:bold">Labour Total</label>
                                     <span>  </span>
                                         <asp:Label ID="lblLabourTotal" runat="server"> </asp:Label>
                                            
                                            </div>
                                    
                                </div>
                                   
                                        
                                            
                                <div class="invoice-table">
                                    <asp:GridView ID="grdParts" runat="server" AutoGenerateColumns="false" CssClass="table">
                                        <Columns>
                                            <asp:BoundField DataField="Description" HeaderText="Parts" />
                                            <asp:BoundField DataField="Quantity" HeaderText="Qty" />
<asp:TemplateField HeaderText="Unit Price">
                        <ItemTemplate>
                            <asp:Label ID="LABEL_rate" runat="server" Text='<%# Eval("UnitPrice", "{0:N2}")%>'/>
                        </ItemTemplate>
                            
                   </asp:TemplateField>                                            <asp:BoundField DataField="Total" HeaderText="Total" />
                                            
                                        </Columns>
                                    </asp:GridView>
                                      <div class="form-group row" style="float:right" >
                                                <label  for="exampleFormControlTextarea1" style="font-weight:bold">Part Total</label>
                                     <span>  </span>
                                         <asp:Label ID="lblPartTotal" runat="server" > </asp:Label>
                                            
                                            </div>
                                </div>
                                <div class="invoice-table">
                                    <table class="table">
                                        
                                        <tbody>
                                            
                                            <tr class="bottom-border-line">
                                                <th scope="row"></th>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                            </tr>
                                           
                                            <tr>
                                                <th scope="row"></th>
                                                <td></td>
                                                <td>Total EX Vat:</td>
                                                <td><asp:Label ID="lblTotalExVat" runat="server"> </asp:Label>
</td>
                                            </tr>
                                            <tr>
                                                <th scope="row"></th>
                                                <td></td>
                                                <td>Vat</td>
                                                <td><asp:Label ID="lblTotalVat" runat="server"> </asp:Label></td>
                                            </tr>
                                            <tr>
                                                <th scope="row"></th>
                                                <td></td>
                                                <td>Totla Inc vat:</td>
                                                <td><asp:Label ID="lblTotalIncVat" runat="server"> </asp:Label></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <asp:HiddenField ID="hdnVat" runat="server" />
                            <div class="new-footer">
                                <p>Please Reply to this quote within  <asp:Label ID="lbldays" runat="server"> </asp:Label>days</p>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <!-- ============================================================== -->
        <!-- End footer -->
        <!-- ============================================================== -->
    </div>
    <!-- ============================================================== -->
    <!-- End Wrapper -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- All Jquery -->
    <!-- ============================================================== -->
    <asp:HiddenField ID="hdnCid" runat="server" />
</form> 

</body>

</html>
