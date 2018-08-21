<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Parts_order_Print.aspx.vb" Inherits="CRM.Parts_order_Print" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <!-- Favicon icon -->
    <link rel="icon" type="image/png" sizes="16x16" href="../assets/images/favicon.png">
    <title></title>
    <!-- This page CSS -->
    <!-- chartist CSS -->
   
 <link href="dist/css/style.min.css" rel="stylesheet">
  <link href="dist/css/new-style.css" rel="stylesheet">
 <link href="dist/css/pages/form-icheck.css" rel="stylesheet">
     <style type="text/css">
        @media print {
            .page {
                 width: 24cm;
            }
        }
      
        .nvalue { float:left;}
    </style>
</head>

<body class="skin-default-dark fixed-layout">
    <form id="frm1" runat="server">
    <!-- ============================================================== -->
    <!-- Preloader - style you can find in spinners.css -->
    <!-- ============================================================== -->
    <div class="preloader">
        <div class="loader">
            <div class="loader__figure"></div>
            <p class="loader__label">Tentacle Solutions</p>
        </div>
    </div>
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
                                 <div style="float:left;width:9%;">
                    <div class="left-footer-invoice">
                        <p><i>Parts Order:</i></p>
                    </div>
                </div>
                                <span> <asp:Label ID="txtsuppliername" runat="server" CssClass="nvalue"> </asp:Label>
                                  
                                    <asp:Label ID="txtaddress1" runat="server" CssClass="nvalue"> </asp:Label>
                                    <br />
                                    <asp:Label ID="txtaddress2" runat="server" CssClass="nvalue"> </asp:Label>
                                     <br />
                                    <asp:Label ID="txttowncode" runat="server" CssClass="nvalue"> </asp:Label>
                                   </span>
                                <div style="clear: both;"></div>
                            </div>

                            <div class="invoice-form">
                                <div class="row">
                                    

                                    
                                </div>
                                <asp:HiddenField ID="hdnSupplierId" runat="server" />
                                                                <asp:HiddenField ID="hdnOrderno" runat="server" />

                            </div>
                            <div class="left-footer-invoice">
                                            <p><i>Order Number:</i></p>
                             <input type="text"  class="form-control" id="txtPartno" runat="server">
                                               
                            </div>
                               <div class="left-footer-invoice">
                                            <p><i>Parts On Order:</i></p>
                                                                                   </div>
                         <div class="invoice-table">
            
               <asp:GridView ID="grdOrderedParts" runat="server" 
                AllowPaging="True" PageSize="50" CssClass="table" AutoGenerateColumns="False" DataKeyNames="RequestID" 
                emptydatatext="No Records Found" ShowHeaderWhenEmpty="True">
                <HeaderStyle Font-Size="Small" Height="25px" />
                <Columns>
                     
                    <asp:BoundField DataField="RequestID" HeaderText="ID" Visible="false"/>
                    <asp:BoundField DataField="EngineersNos" HeaderText="Our Ref" ReadOnly="true" />

                    <asp:BoundField DataField="ApplianceType" HeaderText="Appliance" ReadOnly="true" />
                    <asp:BoundField DataField="ManufacturerName" HeaderText="Manufacturer Name" ReadOnly="true" />
                    <asp:BoundField DataField="Model" HeaderText="Model" ReadOnly="true" />
                    <asp:BoundField DataField="PartNumber" HeaderText="Part Number" ReadOnly="true" />
                   <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="true" />
                    <asp:BoundField DataField="Quantity" HeaderText="Qty" ReadOnly="true" />

              </Columns>
              <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px"/>
                        </asp:GridView>
            <div style="background-color: #000;height:2px;"></div>
        </div>

                            <div class="invoice-table-footer">
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="left-footer-invoice">
                                            <p><i>Ordered Notes :</i></p>
                                       <asp:TextBox ID="txtnotes" runat="server" TextMode="MultiLine" CssClass="form-control" Width="1000px"> </asp:TextBox>

                                        </div>
                                    </div>
                                    <br />
                                    <br />
                                    
                                    <div class="col-md-6">
                                        <div class="left-footer-invoice">

                                           </div>   
                                             
                                         
                                        </div>
                                    <div class="col-md-6">
                                        <div class="left-footer-invoice">

                                           </div>   
                                             
                                         
                                        </div>
                                                                                  <div style="height:2px;"></div>

                                   
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
    <!-- ============================================================== -->
    <!-- End Wrapper -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- All Jquery -->
    <!-- ============================================================== -->
    <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>
    <!-- Bootstrap popper Core JavaScript -->
    <script src="../assets/node_modules/popper/popper.min.js"></script>
    <script src="../assets/node_modules/bootstrap/dist/js/bootstrap.min.js"></script>
    <!-- slimscrollbar scrollbar JavaScript -->
    <script src="dist/js/perfect-scrollbar.jquery.min.js"></script>
    <!--Wave Effects -->
    <script src="dist/js/waves.js"></script>
    <!--Menu sidebar -->
    <script src="dist/js/sidebarmenu.js"></script>
    <!--Custom JavaScript -->
    <script src="../assets/node_modules/sticky-kit-master/dist/sticky-kit.min.js"></script>
    <script src="../assets/node_modules/sparkline/jquery.sparkline.min.js"></script>
    <script src="../assets/node_modules/sweetalert/sweetalert.min.js"></script>
    <script src="../assets/node_modules/sweetalert/jquery.sweet-alert.custom.js"></script>
    <script src="dist/js/custom.min.js"></script>
    <script src="../assets/node_modules/icheck/icheck.min.js"></script>
    <script src="../assets/node_modules/icheck/icheck.init.js"></script>
    <!-- ============================================================== -->
    <!-- This page plugins -->
    <!-- ============================================================== -->
    <!--morris JavaScript -->
    <script src="../assets/node_modules/raphael/raphael-min.js"></script>
    <script src="../assets/node_modules/morrisjs/morris.min.js"></script>
    <script src="../assets/node_modules/jquery-sparkline/jquery.sparkline.min.js"></script>
    <!-- Popup message jquery -->
    <script src="../assets/node_modules/toast-master/js/jquery.toast.js"></script>
    <!-- Chart JS -->
    <script src="dist/js/dashboard1.js"></script>
    <script src="../assets/node_modules/toast-master/js/jquery.toast.js"></script>
    <script src="dist/js/pages/toastr.js"></script>
    <!-- jQuery peity -->
    <script src="../assets/node_modules/peity/jquery.peity.min.js"></script>
    <script src="../assets/node_modules/peity/jquery.peity.init.js"></script>
     <script src="../assets/node_modules/datatables/jquery.dataTables.min.js"></script>
     <script src="../assets/node_modules/switchery/dist/switchery.min.js"></script>
    <script src="../assets/node_modules/select2/dist/js/select2.full.min.js" type="text/javascript"></script>
     <script src="../assets/node_modules/bootstrap-select/bootstrap-select.min.js" type="text/javascript"></script>
     <script src="../assets/node_modules/bootstrap-tagsinput/dist/bootstrap-tagsinput.min.js"></script>
    <script src="../assets/node_modules/bootstrap-touchspin/dist/jquery.bootstrap-touchspin.js" type="text/javascript"></script>
     <script src="js/dff.js" type="text/javascript"></script>
    <script type="text/javascript" src="../assets/node_modules/multiselect/js/jquery.multi-select.js"></script>
    <!-- start - This is for export functionality only -->
    <script src="https://cdn.datatables.net/buttons/1.2.2/js/dataTables.buttons.min.js"></script>
    <script src="https://cdn.datatables.net/buttons/1.2.2/js/buttons.flash.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jszip/2.5.0/jszip.min.js"></script>
    <script src="https://cdn.rawgit.com/bpampuch/pdfmake/0.1.18/build/pdfmake.min.js"></script>
    <script src="https://cdn.rawgit.com/bpampuch/pdfmake/0.1.18/build/vfs_fonts.js"></script>
    <script src="https://cdn.datatables.net/buttons/1.2.2/js/buttons.html5.min.js"></script>
    <script src="https://cdn.datatables.net/buttons/1.2.2/js/buttons.print.min.js"></script>
      <!-- Plugin JavaScript -->
    <script src="../assets/node_modules/moment/moment.js"></script>
    <script src="../assets/node_modules/bootstrap-material-datetimepicker/js/bootstrap-material-datetimepicker.js"></script>
    <!-- Clock Plugin JavaScript -->
    <script src="../assets/node_modules/clockpicker/dist/jquery-clockpicker.min.js"></script>
    <!-- Color Picker Plugin JavaScript -->
    <script src="../assets/node_modules/jquery-asColorPicker-master/libs/jquery-asColor.js"></script>
    <script src="../assets/node_modules/jquery-asColorPicker-master/libs/jquery-asGradient.js"></script>
    <script src="../assets/node_modules/jquery-asColorPicker-master/dist/jquery-asColorPicker.min.js"></script>
    <!-- Date Picker Plugin JavaScript -->
    <script src="../assets/node_modules/bootstrap-datepicker/bootstrap-datepicker.min.js"></script>
    <!-- Date range Plugin JavaScript -->
    <script src="../assets/node_modules/timepicker/bootstrap-timepicker.min.js"></script>
    <script src="../assets/node_modules/bootstrap-daterangepicker/daterangepicker.js"></script>
    <script src="dist/js/pages/jasny-bootstrap.js"></script>


     <script>
    jQuery(document).ready(function() {
        // Switchery
        var elems = Array.prototype.slice.call(document.querySelectorAll('.js-switch'));
        $('.js-switch').each(function() {
            new Switchery($(this)[0], $(this).data());
        });
        // For select 2
        $(".select2").select2();
        $('.selectpicker').selectpicker();
        //Bootstrap-TouchSpin
        $(".vertical-spin").TouchSpin({
            verticalbuttons: true,
            verticalupclass: 'ti-plus',
            verticaldownclass: 'ti-minus'
        });
        var vspinTrue = $(".vertical-spin").TouchSpin({
            verticalbuttons: true
        });
        if (vspinTrue) {
            $('.vertical-spin').prev('.bootstrap-touchspin-prefix').remove();
        }
        $("input[name='tch1']").TouchSpin({
            min: 0,
            max: 100,
            step: 0.1,
            decimals: 2,
            boostat: 5,
            maxboostedstep: 10,
            postfix: '%'
        });
        $("input[name='tch2']").TouchSpin({
            min: -1000000000,
            max: 1000000000,
            stepinterval: 50,
            maxboostedstep: 10000000,
            prefix: '$'
        });
        $("input[name='tch3']").TouchSpin();
        $("input[name='tch3_22']").TouchSpin({
            initval: 40
        });
        $("input[name='tch5']").TouchSpin({
            prefix: "pre",
            postfix: "post"
        });
        // For multiselect
        $('#pre-selected-options').multiSelect();
        $('#optgroup').multiSelect({
            selectableOptgroup: true
        });
        $('#public-methods').multiSelect();
        $('#select-all').click(function() {
            $('#public-methods').multiSelect('select_all');
            return false;
        });
        $('#deselect-all').click(function() {
            $('#public-methods').multiSelect('deselect_all');
            return false;
        });
        $('#refresh').on('click', function() {
            $('#public-methods').multiSelect('refresh');
            return false;
        });
        $('#add-option').on('click', function() {
            $('#public-methods').multiSelect('addOption', {
                value: 42,
                text: 'test 42',
                index: 0
            });
            return false;
        });
        $(".ajax").select2({
            ajax: {
                url: "https://api.github.com/search/repositories",
                dataType: 'json',
                delay: 250,
                data: function(params) {
                    return {
                        q: params.term, // search term
                        page: params.page
                    };
                },
                processResults: function(data, params) {
                    // parse the results into the format expected by Select2
                    // since we are using custom formatting functions we do not need to
                    // alter the remote JSON data, except to indicate that infinite
                    // scrolling can be used
                    params.page = params.page || 1;
                    return {
                        results: data.items,
                        pagination: {
                            more: (params.page * 30) < data.total_count
                        }
                    };
                },
                cache: true
            },
            escapeMarkup: function(markup) {
                return markup;
            }, // let our custom formatter work
            minimumInputLength: 1,
            templateResult: formatRepo, // omitted for brevity, see the source of this page
            templateSelection: formatRepoSelection // omitted for brevity, see the source of this page
        });
    });
    </script>
    

     <script>
        $(function() {
            $('#myTable').DataTable();

            var table = $('#example').DataTable({
                "columnDefs": [{
                    "visible": false,
                    "targets": 2
                }],
                "order": [
                    [2, 'asc']
                ],
                "displayLength": 25,
                "drawCallback": function(settings) {
                    var api = this.api();
                    var rows = api.rows({
                        page: 'current'
                    }).nodes();
                    var last = null;

                    api.column(2, {
                        page: 'current'
                    }).data().each(function(group, i) {
                        if (last !== group) {
                            $(rows).eq(i).before(
                                '<tr class="group"><td colspan="5">' + group + '</td></tr>'
                            );

                            last = group;
                        }
                    });
                }
            });

            // Order by the grouping
            $('#example tbody').on('click', 'tr.group', function() {
                var currentOrder = table.order()[0];
                if (currentOrder[0] === 2 && currentOrder[1] === 'asc') {
                    table.order([2, 'desc']).draw();
                } else {
                    table.order([2, 'asc']).draw();
                }
            });

        });
        $('#example23').DataTable({
            dom: 'Bfrtip',
            buttons: [
                'copy', 'csv', 'excel', 'pdf', 'print'
            ]
        });
          $('#example24').DataTable({
            dom: 'Bfrtip',
            buttons: [
                'copy', 'csv', 'excel', 'pdf', 'print'
            ]
        });
          $('#example25 ').DataTable({
            dom: 'Bfrtip',
            buttons: [
                'copy', 'csv', 'excel', 'pdf', 'print'
            ]
        });
           $('#example26').DataTable({
            dom: 'Bfrtip',
            buttons: [
                'copy', 'csv', 'excel', 'pdf', 'print'
            ]
        });

    </script>

    <script>
    // MAterial Date picker    
    $('#mdate').bootstrapMaterialDatePicker({ weekStart: 0, time: false });
    $('#timepicker').bootstrapMaterialDatePicker({ format: 'HH:mm', time: true, date: false });
    $('#date-format').bootstrapMaterialDatePicker({ format: 'dddd DD MMMM YYYY - HH:mm' });

    $('#min-date').bootstrapMaterialDatePicker({ format: 'DD/MM/YYYY HH:mm', minDate: new Date() });
    // Clock pickers
    $('#single-input').clockpicker({
        placement: 'bottom',
        align: 'left',
        autoclose: true,
        'default': 'now'
    });
    $('.clockpicker').clockpicker({
        donetext: 'Done',
    }).find('input').change(function() {
        console.log(this.value);
    });
    $('#check-minutes').click(function(e) {
        // Have to stop propagation here
        e.stopPropagation();
        input.clockpicker('show').clockpicker('toggleView', 'minutes');
    });
    if (/mobile/i.test(navigator.userAgent)) {
        $('input').prop('readOnly', true);
    }
    // Colorpicker
    $(".colorpicker").asColorPicker();
    $(".complex-colorpicker").asColorPicker({
        mode: 'complex'
    });
    $(".gradient-colorpicker").asColorPicker({
        mode: 'gradient'
    });
    // Date Picker
    jQuery('.mydatepicker, #datepicker').datepicker();
    jQuery('#datepicker-autoclose').datepicker({
        autoclose: true,
        todayHighlight: true
    });
    jQuery('#date-range').datepicker({
        toggleActive: true
    });
    jQuery('#datepicker-inline').datepicker({
        todayHighlight: true
    });
    // Daterange picker
    $('.input-daterange-datepicker').daterangepicker({
        buttonClasses: ['btn', 'btn-sm'],
        applyClass: 'btn-danger',
        cancelClass: 'btn-inverse'
    });
    $('.input-daterange-timepicker').daterangepicker({
        timePicker: true,
        format: 'MM/DD/YYYY h:mm A',
        timePickerIncrement: 30,
        timePicker12Hour: true,
        timePickerSeconds: false,
        buttonClasses: ['btn', 'btn-sm'],
        applyClass: 'btn-danger',
        cancelClass: 'btn-inverse'
    });
    $('.input-limit-datepicker').daterangepicker({
        format: 'MM/DD/YYYY',
        minDate: '06/01/2015',
        maxDate: '06/30/2015',
        buttonClasses: ['btn', 'btn-sm'],
        applyClass: 'btn-danger',
        cancelClass: 'btn-inverse',
        dateLimit: {
            days: 6
        }
    });
    </script>

   
</body>

</html>
