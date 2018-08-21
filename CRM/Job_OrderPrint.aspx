<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Job_OrderPrint.aspx.vb" Inherits="CRM.Job_OrderPrint" %>

<!DOCTYPE html>

<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
   
    <title>JOB ORDER PRINT</title>
     <style>
@page { size: auto;  margin: 0mm; }
</style>
  <link href="dist/css/pages/other-pages.css" rel="stylesheet">
    <link href="dist/css/style.min.css" rel="stylesheet">
  <link href="dist/css/new-style.css" rel="stylesheet">
 <link href="dist/css/pages/form-icheck.css" rel="stylesheet">
   
</head>
<body class="skin-default-dark fixed-layout" onload="window.print();">
    <form id="frm1" runat="server">
    <!-- ============================================================== -->
    <!-- Preloader - style you can find in spinners.css -->
    <!-- ============================================================== -->
            
    <div id="main-wrapper">
       
        <div class="page-wrapper invoice-page-warp">
            <!-- ============================================================== -->
            <!-- Container fluid  -->
            <!-- ============================================================== -->
              
            <div class="container-fluid">
                <div class="invoice-main-warp">
                    <div class="main-invoice-warp">
                       
                        <div class="invoice-content">
                             <div class="invoice-form">
                                 <div class="row">
                <div class="col-12">
                   
                                <div style="font-weight:bold;font-size:26px;margin-bottom:-37px;">
                                              <div class="form-group row">
                                            <label for="inputEmail3" class="col-sm-3 col-form-label">Customer:</label>
                                            <div class="col-sm-9">
                                                <asp:Label ID="txtCompany" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                     
                    </div>
                    <div style="font-weight:bold;font-size:26px;">
                                              <div class="form-group row">
                                            <label for="inputEmail3" class="col-sm-3 col-form-label">Engineer:</label>
                                            <div class="col-sm-9">
                                                <asp:Label ID="txtEngineer" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                     
                    </div>
                </div>
                  </div>
           
                                <div class="row">
                                    <div class="col-md-6">
                                        <div>
                                              <div class="form-group row">
                                            <label for="inputEmail3" class="col-sm-3 col-form-label">Job Number</label>
                                            <div class="col-sm-9">
                                                <asp:Label ID="txtJobNumber" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                             <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Order Number</label>
                                            <div class="col-sm-9">
                                              <asp:Label ID="txtOrderNumber" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                          <div class="form-group row">
                                            <label for="inputEmail3" class="col-sm-3 col-form-label">Asset Number</label>
                                            <div class="col-sm-9">
                                                <asp:Label ID="txtAssetNumber" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                           <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Premises</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtpremises" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                             <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Address</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtAddress1" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div> <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label"></label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtAddress2" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div> 
                                            <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label"></label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtAddress3" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div> 
                                            <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Contact Name</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtContactName" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                             <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Telephone</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtTelphone" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>

                                                 <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Current Status</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtStatus" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                         
                                        
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <div>
                                           <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Response</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtresponse" runat="server" CssClass="form-control"> </asp:Label>
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
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Model</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtModel" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                            <div class="form-group row">
                                            <label for="inputEmail3" class="col-sm-3 col-form-label">Remarks</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtRemarks" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                          <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Enquiry</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtCalender" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                             <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Order</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtorderdate" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>

                                           <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Required</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtrequiredDate" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                              <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Allocated Date</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtEngineersheetdate" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>  
                                            <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Completion</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtcompletedate" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>  
                                            <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Invoice Date</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtInvoicedate" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                            
                                               <div class="form-group row">
                                            <label for="inputPassword3" class="col-sm-3 col-form-label">Quote  Number</label>
                                            <div class="col-sm-9">
                                               <asp:Label ID="txtQuotenumber" runat="server" CssClass="form-control"> </asp:Label>
                                            </div>
                                          </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            </div>

                            <div class="invoice-table">
                                <asp:GridView ID="grdPartsOrderForthisJob" runat="server"
                                     CssClass="table" AutoGenerateColumns="False" >
                                   
                                    <Columns>
                                        <asp:BoundField DataField="EngineersNos" HeaderText="EngineersNos" ReadOnly="true" />
                                        <asp:BoundField DataField="Appliance" HeaderText="Appliance" ReadOnly="true" />
                                        <asp:BoundField DataField="Manu" HeaderText="Manufacturer" ReadOnly="true" />
                                        <asp:BoundField DataField="Model" HeaderText="Model" ReadOnly="true" />
                                        <asp:BoundField DataField="PartNumber" HeaderText="Part Number" ReadOnly="true" />
                                        <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="true" />
                                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" ReadOnly="true" />
                                        <asp:BoundField DataField="Recieved" HeaderText="Recieved" ReadOnly="true" />
                                        <asp:BoundField DataField="Awaiting" HeaderText="Awaiting" ReadOnly="true" />
                                       </Columns>
                                </asp:GridView>
                                   <div class="form-group row" style="margin-right:-1647px;">
                                                <label class="col-sm-4 col-form-label"></label>
                                                <div class="col-sm-8">
                                                     <asp:Label ID="txttotal" runat="server" CssClass="form-control"> </asp:Label>
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
                   
   </form>
</body>
       

    
</html>
 