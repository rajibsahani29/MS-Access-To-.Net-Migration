<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="CRM.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <!-- Favicon icon -->
<link rel="apple-touch-icon" sizes="57x57" href="/apple-icon-57x57.png">
<link rel="apple-touch-icon" sizes="60x60" href="/apple-icon-60x60.png">
<link rel="apple-touch-icon" sizes="72x72" href="/apple-icon-72x72.png">
<link rel="apple-touch-icon" sizes="76x76" href="/apple-icon-76x76.png">
<link rel="apple-touch-icon" sizes="114x114" href="/apple-icon-114x114.png">
<link rel="apple-touch-icon" sizes="120x120" href="/apple-icon-120x120.png">
<link rel="apple-touch-icon" sizes="144x144" href="/apple-icon-144x144.png">
<link rel="apple-touch-icon" sizes="152x152" href="/apple-icon-152x152.png">
<link rel="apple-touch-icon" sizes="180x180" href="/apple-icon-180x180.png">
<link rel="icon" type="image/png" sizes="192x192"  href="/android-icon-192x192.png">
<link rel="icon" type="image/png" sizes="32x32" href="/favicon-32x32.png">
<link rel="icon" type="image/png" sizes="96x96" href="/favicon-96x96.png">
<link rel="icon" type="image/png" sizes="16x16" href="/favicon-16x16.png">
<link rel="manifest" href="/manifest.json">
<meta name="msapplication-TileColor" content="#ffffff">
<meta name="msapplication-TileImage" content="/ms-icon-144x144.png">
<meta name="theme-color" content="#ffffff">
    <title>Fastfixx System developed by Tentacle Solutions</title>
    
    <!-- page css -->
    <link href="../assets/node_modules/sweetalert/sweetalert.css" rel="stylesheet" type="text/css">
    <link href="dist/css/pages/login-register-lock.css" rel="stylesheet">
    <!-- Custom CSS -->
    <link href="dist/css/style.min.css" rel="stylesheet">


    <style>
        .logo-login {
            display: table;
            margin: 0 auto 20px;
            float: none;
        }
        .logo-login img {
            width: 70%;
            display: table;
            margin: 0 auto;
        }
        .card-body{
            padding: 2.25rem 1.25rem 1.25rem 1.25rem;
        }
        .card .card-body{
            padding-bottom: 0px;
        }
        html body .p-b-20 {
            padding-bottom: 0px;
        }
    </style>
</head>
<body>
   
    <!-- ============================================================== -->
    <!-- Preloader - style you can find in spinners.css -->
    <!-- ============================================================== -->
    <div class="preloader">
        <div class="loader">
            <div class="loader__figure"></div>
            <p class="loader__label">Elite admin</p>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- Main wrapper - style you can find in pages.scss -->
    <!-- ============================================================== -->
    <section id="wrapper">
        <div class="login-register" style="background-image:url(../assets/images/background/login-register.jpg);">
            <div class="login-box card">
                <div class="card-body">
                    <form class="form-horizontal form-material" runat="server" id="loginform">
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
                        <div class="logo-login">
                            <img src="../assets/images/Fast-Fixx-Catering-Engineers-Ltd-logo.png" alt="logo">
                        </div>
                        <h3 class="box-title m-b-20">Sign In</h3>
                        <div class="form-group ">
                            <div class="col-xs-12">
                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" required="" placeholder="Username"></asp:TextBox>
                                </div>
                        </div>
                        <div class="form-group">
                            <div class="col-xs-12">
                               
                             <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password"  required="" TextMode="Password" ></asp:TextBox>
                                <br /><br />
                                      <a  href="Forgotten_Password.aspx"  >Forgot Password?</a>
                          </div>
                        </div>
                       <div class="form-group">
                            <div class="col-xs-12">
                                <asp:CheckBox ID="chkRemember" runat="server" Text="Remember Me" />
                          </div>
                        </div>
                        <div class="form-group text-center">
                            <div class="col-xs-12 p-b-20">
                                <div class="card">
                                    <div class="card-body">

                        <asp:Button ID="btnLogin" runat="server" Text="Log In" CssClass="btn btn-block btn-lg btn-info btn-rounded model_img" OnClick="btnLogin_Click"></asp:Button>
                                    </div>
                                </div>
                            </div>
                        </div>
        </ContentTemplate>
        <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnLogin" />                        
                    </Triggers>
    </asp:UpdatePanel>
                    </form>
                  
                </div>
            </div>
        </div>
    </section>
    
    <!-- ============================================================== -->
    <!-- End Wrapper -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- All Jquery -->
    <!-- ============================================================== -->
    <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>
    <!-- Bootstrap tether Core JavaScript -->
    <script src="../assets/node_modules/popper/popper.min.js"></script>
    <script src="../assets/node_modules/bootstrap/dist/js/bootstrap.min.js"></script>
    <script src="../assets/node_modules/sweetalert/sweetalert.min.js"></script>
    <script src="../assets/node_modules/sweetalert/jquery.sweet-alert.custom.js"></script>
    <!--Custom JavaScript -->
    <script type="text/javascript">
        $(function () {
            $(".preloader").fadeOut();
        });
        $(function () {
            $('[data-toggle="tooltip"]').tooltip()
        });
        // ============================================================== 
        // Login and Recover Password 
        // ============================================================== 
        $('#to-recover').on("click", function () {
            $("#loginform").slideUp();
            $("#recoverform").fadeIn();
        });


        function ShowPopupBlank(Msg) {
            swal(Msg);
        }
    </script>
    

   
</body>
</html>
