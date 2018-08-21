<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Invoice_Preview.aspx.vb" Inherits="CRM.Invoice_Preview" %>

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
    <title>Invoice</title>
    <!-- This page CSS -->
    <!-- chartist CSS -->
    <link href="../assets/node_modules/morrisjs/morris.css" rel="stylesheet">
    <!--Toaster Popup message CSS -->
    <link href="../assets/node_modules/toast-master/css/jquery.toast.css" rel="stylesheet">
    <link href="../assets/node_modules/sweetalert/sweetalert.css" rel="stylesheet" type="text/css">
    <link href="dist/css/pages/other-pages.css" rel="stylesheet">
    <link href="../assets/node_modules/bootstrap-datepicker/bootstrap-datepicker.min.css" rel="stylesheet" type="text/css" />
    <link href="../assets/node_modules/select2/dist/css/select2.min.css" rel="stylesheet" type="text/css" />
    <link href="../assets/node_modules/switchery/dist/switchery.min.css" rel="stylesheet" />
    <link href="../assets/node_modules/bootstrap-select/bootstrap-select.min.css" rel="stylesheet" />
    <link href="../assets/node_modules/bootstrap-tagsinput/dist/bootstrap-tagsinput.css" rel="stylesheet" />
    <link href="../assets/node_modules/bootstrap-touchspin/dist/jquery.bootstrap-touchspin.min.css" rel="stylesheet" />
    <link href="../assets/node_modules/multiselect/css/multi-select.css" rel="stylesheet" type="text/css" />
     <link href="../assets/node_modules/bootstrap-material-datetimepicker/css/bootstrap-material-datetimepicker.css" rel="stylesheet">
    <!-- Page plugins css -->
    <link href="../assets/node_modules/clockpicker/dist/jquery-clockpicker.min.css" rel="stylesheet">
    <!-- Color picker plugins css -->
    <link href="../assets/node_modules/jquery-asColorPicker-master/css/asColorPicker.css" rel="stylesheet">
    <!-- Date picker plugins css -->
    <link href="../assets/node_modules/bootstrap-datepicker/bootstrap-datepicker.min.css" rel="stylesheet" type="text/css" />
    <!-- Daterange picker plugins css -->
    <link href="../assets/node_modules/timepicker/bootstrap-timepicker.min.css" rel="stylesheet">
    <link href="../assets/node_modules/bootstrap-daterangepicker/daterangepicker.css" rel="stylesheet">
    <link href="dist/css/pages/floating-label.css" rel="stylesheet">
    <link href="../assets/node_modules/icheck/skins/all.css" rel="stylesheet">

 <link href="dist/css/style.min.css" rel="stylesheet">
  <link href="dist/css/new-style.css" rel="stylesheet">
 <link href="dist/css/pages/form-icheck.css" rel="stylesheet">

</head>

<body class="skin-default-dark fixed-layout">

    <form id="frm1" runat="server">
    <!-- ============================================================== -->
    <!-- Preloader - style you can find in spinners.css -->
    <!-- ============================================================== -->
                     <div id="HTMLtoPDF">
    <div id="main-wrapper">
       
        <div class="page-wrapper invoice-page-warp">
            <!-- ============================================================== -->
            <!-- Container fluid  -->
            <!-- ============================================================== -->
            <div class="container-fluid">
                
                <div class="invoice-main-warp">
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
                                        <br>Unit 9, 95 Boden Street
                                        <br>GLASGOW G40 3QF
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
                                    <p>Faq</p>
                                </div>
                                <span style="margin: -5px 0px;"><asp:Label ID="txtcompany" runat="server" CssClass="form-control" BorderStyle="None"> </asp:Label><br>
                                    <asp:Label ID="txtStreet" runat="server" CssClass="form-control" BorderStyle="None"></asp:Label><br>
                                    <asp:Label ID="txtArea" runat="server" CssClass="form-control" BorderStyle="None"></asp:Label><br>
                                      <asp:Label ID="txtTown" runat="server" CssClass="form-control" BorderStyle="None"></asp:Label><br>
                                    <asp:Label ID="txtPostCode" runat="server" CssClass="form-control" BorderStyle="None"></asp:Label></span>
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
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Appliance</label>
                                            <div class="col-sm-9">
                                              <asp:Label ID="txtappliance" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                          <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Fault</label>
                                            <div class="col-sm-9">
                                               <asp:TextBox ID="txtfault" runat="server" CssClass="form-control" TextMode="MultiLine"> </asp:TextBox>
                                            </div>
                                          </div>
                                          <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Premises</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtpremises" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <div>
                                          <div class="form-group row">
                                            <label for="inputEmail3" class="col-sm-3 col-form-label">Order Date</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtorderdate" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                         
                                          <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Your Ref</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtref" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="invoice-table">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="table" >
                <Columns>
                    <asp:BoundField DataField="Line" HeaderText="Line" />
                    <asp:BoundField DataField="Nos" HeaderText="Qty"/>
                    <asp:BoundField DataField="ItemDesctiption" HeaderText="ItemDesctiption"/>
                    <asp:BoundField DataField="UNIT" HeaderText="Unit"/>
                    <asp:BoundField DataField="Cost" HeaderText="Cost" DataFormatString="{0:N2}"/>
                    <asp:BoundField DataField="Total" HeaderText="Total" DataFormatString="{0:N2}"/>
                 </Columns>
                        </asp:GridView>
                            </div>

                            <div class="invoice-table-footer">
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="left-footer-invoice">
                                            <p><i>Invoice / Tax Date :</i></p>
                                            <span><asp:Label ID="txtInvoicedate" runat="server" CssClass="form-control"> </asp:Label></span>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="right-footer-invoice">
                                            <div>
                                              <div class="form-group row">
                                                <label class="col-sm-4 col-form-label">Total Ex Vat</label>
                                                <div class="col-sm-8">
                                                     <asp:Label ID="txttotalExvat" runat="server" CssClass="form-control"> </asp:Label>
                                                </div>
                                              </div>
                                              <div class="form-group row">
                                                <label class="col-sm-4 col-form-label">Vat Rate</label>
                                                <div class="col-sm-8">
                                                     <asp:Label ID="txtvatrate" runat="server" CssClass="form-control"> </asp:Label>
                                                </div>
                                              </div>
                                              <div class="form-group row">
                                                <label class="col-sm-4 col-form-label">Vat</label>
                                                <div class="col-sm-8">
                                                     <asp:Label ID="txtvat" runat="server" CssClass="form-control"> </asp:Label>
                                                 </div>
                                              </div>
                                              <div class="form-group row">
                                                <label class="col-sm-4 col-form-label">Totla including Vat</label>
                                                <div class="col-sm-8">
                                                     <asp:Label ID="txttotal" runat="server" CssClass="form-control"> </asp:Label>
                                                </div>
                                              </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="invoice-footer">
                                <div class="invoice-footer-heading">
                                    <h3 class="text-center"><i>Remittance slip</i></h3>
                                    <p class="text-center">Glasgow City Council Independent Living Equipment</p>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="invoice-bottom-left">
                                            <h2>Payment Method</h2>
                                                <div class="invoice-left-main-footer">
                                                    <div class="form-check">
                                                      <input class="form-check-input" type="checkbox" value="" id="defaultCheck1">
                                                      <label class="form-check-label" for="defaultCheck1">
                                                        Cheque Payable to Fast Fixx Catering
                                                      </label>
                                                    </div>
                                                    <div class="form-check">
                                                      <input class="form-check-input" type="checkbox" value="" id="defaultCheck2">
                                                      <label class="form-check-label" for="defaultCheck2">
                                                        BACS To: Fast Fixx | Bank of Scotland | Sort 80-11-80 <br> Acc 10215163
                                                      </label>
                                                    </div>
                                                </div>
                                                <p>&nbsp;</p>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="invoice-bottom-right">
                                            <div>
                                              <div class="form-group row">
                                                <label class="col-sm-3 col-form-label">Total inc Vat</label>
                                                <div class="col-sm-9">
                                                  <asp:Label ID="txttotal1" runat="server" CssClass="form-control"> </asp:Label>
                                                    
                                                </div>
                                              </div>
                                              <div class="form-group row">
                                                <label class="col-sm-3 col-form-label">Fast Fixx Nos</label>
                                                <div class="col-sm-9">
                                                  <asp:Label ID="txtjobno" runat="server" CssClass="form-control"> </asp:Label>
                                                </div>
                                              </div>
                                              <div class="form-group row">
                                                <label for="inputPassword3" class="col-sm-3 col-form-label">Your Ref</label>
                                                <div class="col-sm-9">
                                                   <asp:Label ID="txtorderno" runat="server" CssClass="form-control"> </asp:Label>

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
        </div>

        <!-- ============================================================== -->
        <!-- End footer -->
        <!-- ============================================================== -->

    </div>
      </div>

           <!-- ============================================================== -->
    <!-- End Wrapper -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- All Jquery -->
    <!-- ============================================================== -->
         
  </form>

</body>
</html>

