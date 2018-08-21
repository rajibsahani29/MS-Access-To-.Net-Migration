<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Mobile/Mobile.Master" CodeBehind="Change_Settings.aspx.vb" Inherits="CRM.Change_Settings1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
                              <div class="col-lg-12 col-md-12">
                    
                

                    <div class="form-main-warp cost-warp">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="card">
                                    <div class="card-body">
                                        <h5 class="card-title m-b-20">Change Settings</h5>

                                        <div class="floating-labels m-t-40">

                                            <div class="form-group m-b-40">
                                                <asp:TextBox ID="txtcurrentpassword" runat="server" CssClass="form-control input-sm removereadonly" onchange="checkCurrentPassword();"></asp:TextBox>
                                                <span class="bar"></span>
                                                <label for="ContentPlaceHolder1_txtcurrentpassword">Current Password</label>
                                            </div>
                                            <div class="form-group m-b-40">
                                                <asp:TextBox ID="txtnewPassword" runat="server" CssClass="form-control input-sm removereadonly"></asp:TextBox><span class="bar"></span>
                                                <label for="ContentPlaceHolder1_txtnewPassword">New Password</label>
                                            </div>
                                            <div class="form-group m-b-40">
                                                 <input type="text" id="txtConfirmPassword" runat="server"  class="form-control input-sm removereadonly" onchange="checkPasswordMatch();" />
                                                <span class="bar"></span>
                                                <label for="ContentPlaceHolder1_txtnewPassword">Repeat New Password</label>
                                            </div>
             

                                            <div class="button-group note-btn">
                                               <asp:Button ID="btnPassword" runat="server" Text="Update Settings" CssClass="btn btn-outline-success btn-rounded" OnClientClick="return ValidateControls()"></asp:Button>
                                            </div>


                                        </div>
                                                                                        <asp:HiddenField ID="hdnCurrentPwd" runat="server" />

                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>


            </div>
    <script>

        function ValidateControls()
        {
            var currentpassword, newPassword, ConfirmPassword;
            currentpassword = document.getElementById("ContentPlaceHolder1_txtcurrentpassword").value;
            newPassword = document.getElementById("ContentPlaceHolder1_txtnewPassword").value;
            ConfirmPassword = document.getElementById("ContentPlaceHolder1_txtConfirmPassword").value;
            if (currentpassword == '') {
                ShowPopupBlank("Please Fill Current Password Field");
                return false;
            }
            if (newPassword == '') {
                ShowPopupBlank("Please Fill New Password Field");
                return false;
            }

            if (ConfirmPassword == '') {
                ShowPopupBlank("Please Fill Repeat New Password Field");
                return false;

            }
        }

        function checkPasswordMatch() {
            var password = $("#<%= txtnewPassword.ClientID %>").val();
            var confirmPassword = $("#<%= txtconfirmpassword.ClientID %>").val();
            if (password != confirmPassword)
            {
                ShowPopupBlank("New passwords do not match");
                return false;
            }
            else
            {
            }
           
        }
        
        function checkCurrentPassword() {
            var Givenpassword = $("#<%= txtcurrentpassword.ClientID %>").val();
            var OriginalPassword = $("#<%= hdnCurrentPwd.ClientID %>").val();
            if (Givenpassword != OriginalPassword)
            {
                ShowPopupBlank("Current password do not match");
                return false;

            }
            else
            {
            }
           
        }
    </script>
</asp:Content>
