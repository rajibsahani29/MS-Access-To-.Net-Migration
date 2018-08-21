<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Mobile/Mobile.Master" CodeBehind="gas-inspection_edit.aspx.vb" Inherits="CRM.gas_inspection_edit1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>


    <!-- ============================================================== -->
    <!-- Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
   
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Start Page Content -->
    <!-- ============================================================== -->
    <div class="gas-main-warp">
        <div class="row">
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-body">
                        <h4 class="card-title">Gas Installation Details & Gas Interlocks</h4>
                        <div class="table-responsive new-table-warp">

                            <table class="table color-table primary-table radio-table">
                                <thead>
                                    <tr>
                                        <th>GAS INSTALLATION DETAILS</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                     <tr>
                                        <td>Job Id</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:DropDownList ID="ddlJobId" runat="server" CssClass="selectpicker"></asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Company Name</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:DropDownList ID="ddlCompany" runat="server" CssClass="selectpicker"></asp:DropDownList>


                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Satisfactory location?</td>
                                    </tr>
                                    <!-- <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <input type="radio" name="options" autocomplete="off" value="Yes">
                                                                <i class="ti-check text-active" aria-hidden="true"></i> Yes
                                                            </label>
                                                        </div> -->

                                    <tr>
                                        <td>
                                            <div class="card-body rgOne">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton1" CssClass="check" GroupName="1stGroup" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton2" CssClass="check" GroupName="1stGroup" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton3" CssClass="check" GroupName="1stGroup" value="N/A" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                    </tr>

                                    <tr>
                                        <td>Accessible?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTwo">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton4" CssClass="check" GroupName="Group2" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton5" CssClass="check" GroupName="Group2" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton6" CssClass="check" GroupName="Group2" value="N/A" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Suitable valve type?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgThree">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton7" CssClass="check" GroupName="Group3" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton8" CssClass="check" GroupName="Group3" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton9" CssClass="check" GroupName="Group3" value="N/A" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Valve handle attached?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFour">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton10" CssClass="check" GroupName="Group4" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton11" CssClass="check" GroupName="Group4" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton12" CssClass="check" GroupName="Group4" value="N/A" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Direction of the operation shown?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFive">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton13" CssClass="check" GroupName="Group5" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton14" CssClass="check" GroupName="Group5" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton15" CssClass="check" GroupName="Group5" value="n/a" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Is an Emergency Notice present?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgSix">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton16" CssClass="check" GroupName="Group6" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton17" CssClass="check" GroupName="Group6" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton18" CssClass="check" GroupName="Group6" value="n/a" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                                <thead>
                                    <tr>
                                        <th>Automatic Isolation Valve</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Is the system fitted with automatic pressure proving?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgSeven">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton19" CssClass="check" GroupName="Group7" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton20" CssClass="check" GroupName="Group7" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton21" CssClass="check" GroupName="Group7" value="n/a" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>If yes - do appliances have a full flame guard?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgEight">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton22" CssClass="check" GroupName="Group8" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton23" CssClass="check" GroupName="Group8" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton24" CssClass="check" GroupName="Group8" value="n/a" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>If no - is there a manual reset facility?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgNine">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton25" CssClass="check" GroupName="Group9" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton26" CssClass="check" GroupName="Group9" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton27" CssClass="check" GroupName="Group9" value="n/a" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Is there a Warning Notice present?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTen">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton28" CssClass="check" GroupName="Group10" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton29" CssClass="check" GroupName="Group10" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton30" CssClass="check" GroupName="Group10" value="n/a" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                                <thead>
                                    <tr>
                                        <th>GAS INTERLOCKS</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Primary safety systems interlocked to the gas supply?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgEleven">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton31" CssClass="check" GroupName="Group11" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton32" CssClass="check" GroupName="Group11" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton33" CssClass="check" GroupName="Group11" value="n/a" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>If Yes is the primary interlock type: Power Monitoring or Pressure Flow?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTwelve">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton34" CssClass="check" GroupName="Group12" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton35" CssClass="check" GroupName="Group12" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton36" CssClass="check" GroupName="Group12" value="n/a" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Are secondary interlock monitoring system fitted?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgThirteen">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton37" CssClass="check" GroupName="Group13" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton38" CssClass="check" GroupName="Group13" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton39" CssClass="check" GroupName="Group13" value="n/a" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Are Primary means of interlocking satisfactory?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFourteen">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton40" CssClass="check" GroupName="Group14" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton41" CssClass="check" GroupName="Group14" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton42" CssClass="check" GroupName="Group14" value="n/a" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Are secondary means of interlocking satisfactory?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFifteen">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton43" CssClass="check" GroupName="Group15" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton44" CssClass="check" GroupName="Group15" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton45" CssClass="check" GroupName="Group15" value="n/a" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Can the interlocking system be manually overridden?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgSixteen">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton46" CssClass="check" GroupName="Group16" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton47" CssClass="check" GroupName="Group16" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton48" CssClass="check" GroupName="Group16" value="n/a" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/A
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <div class="row">
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-body">
                        <h4 class="card-title">Risk Analysis</h4>
                        <div class="table-responsive new-table-warp">
                            <table class="table color-table primary-table radio-table">
                                <thead>
                                    <tr>
                                        <th>RISK ANALYSIS (Use of mechanical ventilation system see HSE/C1S23)</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Apparant poor ductwork design</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgSeventeen rgSum">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton49" CssClass="check" GroupName="Group17" value="1" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>1
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton50" CssClass="check" GroupName="Group17" value="2" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>2
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton51" CssClass="check" GroupName="Group17" value="3" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>3
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton52" CssClass="check" GroupName="Group17" value="4" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>4
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton53" CssClass="check" GroupName="Group17" value="5" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>5
                                                    </label>
                                                </div>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>Evidence of ventilation system not used?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgEighteen rgSum">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton54" CssClass="check" GroupName="Group18" value="1" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>1
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton55" CssClass="check" GroupName="Group18" value="2" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>2
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton56" CssClass="check" GroupName="Group18" value="3" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>3
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton57" CssClass="check" GroupName="Group18" value="4" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>4
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton58" CssClass="check" GroupName="Group18" value="5" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>5
                                                    </label>
                                                </div>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>Unsatisfactory cooking fumes removal</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgNineteen rgSum">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton59" CssClass="check" GroupName="Group19" value="1" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>1
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton60" CssClass="check" GroupName="Group19" value="2" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>2
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton61" CssClass="check" GroupName="Group19" value="3" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>3
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton62" CssClass="check" GroupName="Group19" value="4" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>4
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton63" CssClass="check" GroupName="Group19" value="5" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>5
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Sign of poor ventilation</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTwenty rgSum">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton64" CssClass="check" GroupName="Group20" value="1" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>1
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton65" CssClass="check" GroupName="Group20" value="2" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>2
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton66" CssClass="check" GroupName="Group20" value="3" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>3
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton67" CssClass="check" GroupName="Group20" value="4" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>4
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton68" CssClass="check" GroupName="Group20" value="5" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>5
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Small room volume</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTwentyOne rgSum">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton69" CssClass="check" GroupName="Group21" value="1" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>1
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton70" CssClass="check" GroupName="Group21" value="2" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>2
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton71" CssClass="check" GroupName="Group21" value="3" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>3
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton72" CssClass="check" GroupName="Group21" value="4" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>4
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton73" CssClass="check" GroupName="Group21" value="5" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>5
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Evidence of safe systems of work</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTwentyTwo rgSum">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton74" CssClass="check" GroupName="Group22" value="1" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>1
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton75" CssClass="check" GroupName="Group22" value="2" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>2
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton76" CssClass="check" GroupName="Group22" value="3" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>3
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton77" CssClass="check" GroupName="Group22" value="4" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>4
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton78" CssClass="check" GroupName="Group22" value="5" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>5
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Sign of poor maintenance</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTwentyThree rgSum">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton79" CssClass="check" GroupName="Group23" value="1" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>1
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton80" CssClass="check" GroupName="Group23" value="2" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>2
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton81" CssClass="check" GroupName="Group23" value="3" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>3
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton82" CssClass="check" GroupName="Group23" value="4" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>4
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton83" CssClass="check" GroupName="Group23" value="5" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>5
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Extensive use of appliances</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTwentyFour rgSum">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton84" CssClass="check" GroupName="Group24" value="1" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>1
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton85" CssClass="check" GroupName="Group24" value="2" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>2
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton86" CssClass="check" GroupName="Group24" value="3" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>3
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton87" CssClass="check" GroupName="Group24" value="4" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>4
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton88" CssClass="check" GroupName="Group24" value="5" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>5
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Ageing system</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTwentyFive rgSum">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton89" CssClass="check" GroupName="Group25" value="1" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>1
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton90" CssClass="check" GroupName="Group25" value="2" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>2
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton91" CssClass="check" GroupName="Group25" value="3" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>3
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton92" CssClass="check" GroupName="Group25" value="4" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>4
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton93" CssClass="check" GroupName="Group25" value="5" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>5
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Type 'B' appliance fitted</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTwentySix rgSum">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton94" CssClass="check" GroupName="Group26" value="1" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>1
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton95" CssClass="check" GroupName="Group26" value="2" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>2
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton96" CssClass="check" GroupName="Group26" value="3" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>3
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton97" CssClass="check" GroupName="Group26" value="4" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>4
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton98" CssClass="check" GroupName="Group26" value="5" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>5
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>TOTAL SCORE:</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="txtTotal" CssClass="form-control input-sm removereadonly" runat="server"></asp:TextBox></td>

                                    </tr>

                                    <tr>

                                        <td>Date:</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="example datepicker form-selection-box">
                                                <div class="input-group">
                                                    <asp:TextBox ID="txtReceiveDate" runat="server" CssClass="form-control mydatepicker" placeholder="Receive Date"></asp:TextBox>

                                                </div>
                                                <div class="input-group-append">
                                                    <span class="input-group-text"><i class="icon-calender"></i></span>
                                                </div>
                                            </div>


                                        </td>

                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-body">
                        <h4 class="card-title">Gas Installation Details & Gas Interlocks</h4>
                        <div class="table-responsive new-table-warp">
                            <table class="table color-table primary-table radio-table">
                                <thead>
                                    <tr>
                                        <th>PIPEWORK</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Are correct materials being used?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTwentySeven">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton99" CssClass="check" GroupName="Group27" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton100" CssClass="check" GroupName="Group27" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton101" CssClass="check" GroupName="Group27" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>

                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Correctly identified and labelled?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTwentyEight">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton102" CssClass="check" GroupName="Group28" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton103" CssClass="check" GroupName="Group28" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton104" CssClass="check" GroupName="Group28" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Pipework correctly supported?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTwentyNine">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton105" CssClass="check" GroupName="Group29" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton106" CssClass="check" GroupName="Group29" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton107" CssClass="check" GroupName="Group29" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Do sleeves extend through walls/floors?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgThirty">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton108" CssClass="check" GroupName="Group30" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton109" CssClass="check" GroupName="Group30" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton110" CssClass="check" GroupName="Group30" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Are suitable purge and test points fitted?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgThirtyOne">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton111" CssClass="check" GroupName="Group31" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton112" CssClass="check" GroupName="Group32" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton113" CssClass="check" GroupName="Group33" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Are additional isolation valves fitted where needed?</td>
                                    </tr>
                                    <tr>
                                        <td>

                                            <div class="card-body rgThirtyTwo">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton114" CssClass="check" GroupName="Group34" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton115" CssClass="check" GroupName="Group34" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton116" CssClass="check" GroupName="Group34" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                                <thead>
                                    <tr>
                                        <th>SAFETY SYSTEMS WITHIN THE CATERING AREA</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Main electrical isolator fitted in kitchen?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgThirtyThree">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton117" CssClass="check" GroupName="Group35" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton118" CssClass="check" GroupName="Group35" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton119" CssClass="check" GroupName="Group35" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Main protective equipotential bond fitted?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgThirtyFour">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton120" CssClass="check" GroupName="Group36" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton121" CssClass="check" GroupName="Group36" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton122" CssClass="check" GroupName="Group36" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Are appropriate/correct labels displayed?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgThirtyFive">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton123" CssClass="check" GroupName="Group37" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton124" CssClass="check" GroupName="Group37" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton125" CssClass="check" GroupName="Group37" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                                <thead>
                                    <tr>
                                        <th>CANOPY</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Has a canopy system been installed?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgThirtySix">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton126" CssClass="check" GroupName="Group38" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton127" CssClass="check" GroupName="Group38" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton128" CssClass="check" GroupName="Group38" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>if yes - is the canopy overhang correct?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgThirtySeven">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton129" CssClass="check" GroupName="Group39" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton130" CssClass="check" GroupName="Group39" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton131" CssClass="check" GroupName="Group39" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Type of filteration (e.g., mesh / baffles / UV)</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgThirtyEight">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton132" CssClass="check" GroupName="Group40" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton133" CssClass="check" GroupName="Group40" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton134" CssClass="check" GroupName="Group40" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Is filteration satisfactorily maintained?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgThirtyNine">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton135" CssClass="check" GroupName="Group41" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton136" CssClass="check" GroupName="Group41" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton137" CssClass="check" GroupName="Group41" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <div class="row">
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-body">
                        <h4 class="card-title">Ventilation/Exhaust System, Atmosphere Monitoring/Sampling, Details of recording instrument</h4>
                        <div class="table-responsive new-table-warp">
                            <table class="table color-table primary-table radio-table">
                                <thead>
                                    <tr>
                                        <th>Is Ventilation Provided:</th>
                                        <th></th>

                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Mechanically?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFourty">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton138" CssClass="check" GroupName="Group42" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton139" CssClass="check" GroupName="Group42" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton140" CssClass="check" GroupName="Group42" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Naturally?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFourtyOne">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton141" CssClass="check" GroupName="Group43" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton142" CssClass="check" GroupName="Group43" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton143" CssClass="check" GroupName="Group43" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Both?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFourtyTwo">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton144" CssClass="check" GroupName="Group44" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton145" CssClass="check" GroupName="Group44" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton146" CssClass="check" GroupName="Group44" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Is the mechanical ventilation system interlocked?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFourtyThree">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton147" CssClass="check" GroupName="Group45" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton148" CssClass="check" GroupName="Group45" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton149" CssClass="check" GroupName="Group45" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Is satisfactory natural ventilation provided? (permanent)</td>
                                    </tr>
                                    <tr>
                                        <td>

                                            <div class="card-body rgFourtyFour">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton150" CssClass="check" GroupName="Group46" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton151" CssClass="check" GroupName="Group46" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton152" CssClass="check" GroupName="Group46" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>If yes - is free are adequate?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFourtyFive">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton153" CssClass="check" GroupName="Group47" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton154" CssClass="check" GroupName="Group47" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton155" CssClass="check" GroupName="Group47" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>(Provide details)</td>
                                        </tr><tr>
                                        <td>
                                            <div class="table-form">
                                                <div class="table-form">
                                                    <div class="form-group">
                                                        <asp:TextBox ID="txtProvideDetails1" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>
                                                    <div class="form-group">
                                                        <asp:TextBox ID="txtProvideDetails2" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                                <thead>
                                    <tr>
                                        <th>ATMOSPHERE MONITORING / SAMPLING</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Are automatic means of CO detection provided?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFourtySix">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton156" CssClass="check" GroupName="Group48" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton157" CssClass="check" GroupName="Group48" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton158" CssClass="check" GroupName="Group48" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Are automatic means of CO2 detection provided?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFourtySeven">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton159" CssClass="check" GroupName="Group49" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton160" CssClass="check" GroupName="Group49" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton161" CssClass="check" GroupName="Group49" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Are CO or CO2 detection interlocked to the gas supply?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFourtyEight">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton162" CssClass="check" GroupName="Group50" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton163" CssClass="check" GroupName="Group50" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton164" CssClass="check" GroupName="Group50" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Max. CO2 recorded at visit:</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFourtyNine">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton165" CssClass="check" GroupName="Group51" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton166" CssClass="check" GroupName="Group51" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton167" CssClass="check" GroupName="Group51" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Center of catering area 2m above floor</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFifty">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton168" CssClass="check" GroupName="Group52" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton169" CssClass="check" GroupName="Group52" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton170" CssClass="check" GroupName="Group52" value="N/P" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>N/P
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                                <thead>
                                    <tr>
                                        <th>DETAILS OF RECORDING INSTRUMENT</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Make/Model:<span>
                                            <asp:TextBox ID="txtModel1" CssClass="form-control input-sm removereadonly" runat="server" Width="650px" /></span></td>
                                        </tr><tr>
                                        <td>
                                            <div class="example datepicker form-selection-box">
                                                <div class="input-group">
                                                    <asp:TextBox ID="txtDate" runat="server" CssClass="form-control mydatepicker" placeholder="Calibration Date"></asp:TextBox>
                                                </div>
                                                <div class="input-group-append">
                                                    <span class="input-group-text"><i class="icon-calender"></i></span>
                                                </div>
                                            </div>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Make/Model:
                                            <asp:TextBox ID="txtModel2" CssClass="form-control input-sm removereadonly" runat="server" Width="650px" /></td>
                                        </tr><tr>
                                        <td>
                                            <div class="example datepicker form-selection-box">
                                                <div class="input-group">
                                                    <asp:TextBox ID="txtDate1" runat="server" CssClass="form-control mydatepicker" placeholder="Calibration Date"></asp:TextBox>

                                                </div>
                                                <div class="input-group-append">
                                                    <span class="input-group-text"><i class="icon-calender"></i></span>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                                <thead>
                                    <tr>
                                        <th>DETAILS OF RECORDING INSTRUMENT</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Received by:</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="table-form">
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtReceivedBy" CssClass="form-control input-sm removereadonly" runat="server" />
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Print Name:</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="table-form">
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtPrintName" CssClass="form-control input-sm removereadonly" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Issued by:</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="table-form">
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtIssuedBy" CssClass="form-control input-sm removereadonly" runat="server" />
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>ID Card No:</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="table-form">
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtIDCard" CssClass="form-control input-sm removereadonly" runat="server" />
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Date:</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="example datepicker form-selection-box">
                                                <div class="input-group">
                                                    <asp:TextBox ID="txtDate2" runat="server" CssClass="form-control mydatepicker" placeholder="Issue Date"></asp:TextBox>

                                                </div>
                                                <div class="input-group-append">
                                                    <span class="input-group-text"><i class="icon-calender"></i></span>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:HiddenField ID="hdnID" runat="server" />
                                            <div class="form-group" style="display: flex">

                                                <div style="width: 20%;">
                                                    <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Submit Report" OnClientClick="return ValidateControls()"/>
                                                </div>
                                                <div style="flex-grow: 1">
                                                    <asp:Button ID="btnGo" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Go Part2" />
                                                </div>

                                            </div>

                                        </td>
                                    </tr>
                                </tbody>

                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <!-- ============================================================== -->
    <!-- End PAge Content -->
    <!-- ============================================================== -->

    <script type="text/javascript">
        function ValidateControls()
        {
            //var clsArray = Array("rgOne","rgTwo", "rgThree", "rgFour", "rgFive", "rgSix", "rgSeven", "rgEight", "rgNine", "rgTen", "rgEleven", "rgTwelve", "rgThirteen", "rgFourteen", "rgFifteen", "rgSixteen", "rgSeventeen", "rgEighteen", "rgNineteen", "rgTwenty", "rgTwentyOne", "rgTwentyTwo", "rgTwentyThree", "rgTwentyFour", "rgTwentyFive", "rgTwentySix", "rgTwentySeven", "rgTwentyEight", "rgTwentyNine", "rgThirty", "rgThirtyOne", "rgThirtyTwo", "rgThirtyThree", "rgThirtyFour", "rgThirtyFive", "rgThirtySix", "rgThirtySeven", "rgThirtyEight", "rgThirtyNine", "rgFourty", "rgFourtyOne", "rgFourtyTwo", "rgFourtyThree", "rgFourtyFour", "rgFourtyFive", "rgFourtySix", "rgFourtySeven", "rgFourtyEight", "rgFourtyNine", "rgFifty");
            var clsArray = Array("rgOne");
            var bnlError = false;
            for (i = 0; i < clsArray.length; i++) {
                if ($("." + clsArray[i] + " input:checked").length == 0) {
                    bnlError = true;
                    break;
                }
            }

                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Satisfactory Location Field.");
                    return false;
                }

                var clsArray = Array("rgTwo");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0)
                    {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Accesible Field.");
                    return false;

                }
                var clsArray = Array("rgThree");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Suitable Valve Type Field.");
                    return false;

                }
                var clsArray = Array("rgFour");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Valve Handle Field.");
                    return false;

                }

                
                var clsArray = Array("rgFive");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Direction Of Operation Field.");
                    return false;

                }

                var clsArray = Array("rgSix");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Emergency Notice Period Field.");
                    return false;

                }
                var clsArray = Array("rgSeven");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose System Fitted with Automatic Pressure Field.");
                    return false;

                }

                var clsArray = Array("rgEight");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Appliance Have a Full flame guard Field.");
                    return false;

                }

                var clsArray = Array("rgNine");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Mannual Reset Facility Field.");
                    return false;

                }

                var clsArray = Array("rgTen");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Warning Notice Present Field.");
                    return false;

                }
                var clsArray = Array("rgEleven");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Primary safety systems interlocked to the gas supply Field.");
                    return false;

                }

                var clsArray = Array("rgTwelve");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Power Monitoring or Pressure Flow Field.");
                    return false;

                }

                var clsArray = Array("rgThirteen");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose secondary interlock monitoring system fitted Field.");
                    return false;

                }

                var clsArray = Array("rgFourteen");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Primary means of interlocking satisfactory Field.");
                    return false;

                }

                var clsArray = Array("rgFifteen");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Secondary means of interlocking satisfactory Field.");
                    return false;

                }

                var clsArray = Array("rgSixteen");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose interlocking system be manually overridden Field.");
                    return false;

                }
                var clsArray = Array("rgSeventeen");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Apparant poor ductwork design Field.");
                    return false;

                }
                var clsArray = Array("rgEighteen");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Evidence of ventilation system Field.");
                    return false;

                }

                
                var clsArray = Array("rgNineteen");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Unsatisfactory cooking fumes removal Field");
                    return false;

                }
                var clsArray = Array("rgTwenty");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Sign of poor ventilation Field");
                    return false;

                }
                var clsArray = Array("rgTwentyOne");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Small room volume Field");
                    return false;

                }

                var clsArray = Array("rgTwentyTwo");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Evidence of Safe systems of work Field");
                    return false;

                }

                

                var clsArray = Array("rgTwentyThree");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Sign of poor maintenance Field");
                    return false;

                }

                var clsArray = Array("rgTwentyFour");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Extensive use of appliances Field");
                    return false;

                }

                var clsArray = Array("rgTwentyFive");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Ageing system Field");
                    return false;

                }

                var clsArray = Array("rgTwentySix");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Type 'B' appliance fitted Field");
                    return false;

                }
                
                var clsArray = Array("rgTwentySeven");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Correct materials being used Field");
                    return false;

                }

                var clsArray = Array("rgTwentyEight");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Correctly identified and labelled Field");
                    return false;

                }
                var clsArray = Array("rgTwentyNine");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Pipework correctly supported Field");
                    return false;

                }

                var clsArray = Array("rgThirty");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Sleeves extend through walls/floors Field");
                    return false;

                }

                var clsArray = Array("rgThirtyOne");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Suitable purge and test points fitted Field");
                    return false;

                }

                var clsArray = Array("rgThirtyTwo");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose additional isolation valves fitted where needed Field");
                    return false;

                }

                var clsArray = Array("rgThirtyThree");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++)
                {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Main electrical isolator fitted in kitchen Field");
                    return false;

                }

                var clsArray = Array("rgThirtyFour");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Main protective equipotential bond fitted Field");
                    return false;

                }
                var clsArray = Array("rgThirtyFive");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Are appropriate/correct labels displayed Field");
                    return false;

                }
                var clsArray = Array("rgThirtySix");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Canopy system been installed Field");
                    return false;

                }
                var clsArray = Array("rgThirtySeven");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose the canopy overhang correct Field");
                    return false;

                }
                var clsArray = Array("rgThirtyEight");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Type of filteration Field");
                    return false;

                }

                var clsArray = Array("rgThirtyNine");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose filteration Satisfactory Maintained Field");
                    return false;

                }

                var clsArray = Array("rgFourty");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Mechanically Field");
                    return false;

                }

                var clsArray = Array("rgFourtyOne");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Naturally Field");
                    return false;

                }

                var clsArray = Array("rgFourtyTwo");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Both Field");
                    return false;

                }

                var clsArray = Array("rgFourtyThree");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose mechanical ventilation system interlocked Field");
                    return false;

                }
                var clsArray = Array("rgFourtyFour");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose satisfactory natural ventilation provided Field");
                    return false;

                }

                var clsArray = Array("rgFourtyFive");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Is free are adequate Field");
                    return false;

                }

                var clsArray = Array("rgFourtySix");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose automatic means of CO detection provided Field");
                    return false;

                }
                var clsArray = Array("rgFourtySeven");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose automatic means of CO2 detection provided Field");
                    return false;

                }
                
                var clsArray = Array("rgFourtyEight");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose CO or CO2 detection interlocked to the gas supply Field");
                    return false;

                }
                var clsArray = Array("rgFourtyNine");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Max CO2 recorded at visit Field");
                    return false;

                }
                var clsArray = Array("rgFifty");
                var bnlError = false;
                for (i = 0; i < clsArray.length; i++) {
                    if ($("." + clsArray[i] + " input:checked").length == 0) {
                        bnlError = true;
                        break;
                    }
                }
                if (bnlError == true) {
                    ShowPopupBlank("Please Choose Center of catering area 2m above floor Field");
                    return false;

                }
                 //   "", "", "", ""

                var Jobid,CalibrationDate,Total, CalibrationDate1, IssueDate, ReceiveDate, company, IDcard, IssuedBy, Printname, ReceivedBy, Model1, Model2, ProvideDetails1, ProvideDetails2;
                Jobid = document.getElementById("ContentPlaceHolder1_ddlJobId").value;
                company = document.getElementById("ContentPlaceHolder1_ddlCompany").value;
                Total = document.getElementById("ContentPlaceHolder1_txtTotal").value;
                CalibrationDate = document.getElementById("ContentPlaceHolder1_txtDate").value;
                CalibrationDate1 = document.getElementById("ContentPlaceHolder1_txtDate1").value;
                IssueDate = document.getElementById("ContentPlaceHolder1_txtDate2").value;
                ReceiveDate = document.getElementById("ContentPlaceHolder1_txtReceiveDate").value;
                IDcard = document.getElementById("ContentPlaceHolder1_txtIDCard").value;
                IssuedBy = document.getElementById("ContentPlaceHolder1_txtIssuedBy").value;
                Printname = document.getElementById("ContentPlaceHolder1_txtPrintName").value;
                ReceivedBy = document.getElementById("ContentPlaceHolder1_txtReceivedBy").value;
                Model2 = document.getElementById("ContentPlaceHolder1_txtModel2").value;
                Model1 = document.getElementById("ContentPlaceHolder1_txtModel1").value;
                ProvideDetails1 = document.getElementById("ContentPlaceHolder1_txtProvideDetails1").value;
                ProvideDetails2 = document.getElementById("ContentPlaceHolder1_txtProvideDetails2").value;
                if (Jobid == '')
                {
                    ShowPopupBlank("Please Choose JobId");
                    return false;
                }
                if (company == '')
                {
                    ShowPopupBlank("Please Choose Company Name.");
                    return false;
                }
                if (ReceiveDate == '') {
                    ShowPopupBlank("Please Fill Received Date Field");
                    return false;
                }
               
                if(ProvideDetails1 == '')
                {
                    ShowPopupBlank("Please Fill First Provide Details Field");
                    return false;

                }
                if (ProvideDetails2 == '') {
                    ShowPopupBlank("Please Fill Second Provide Details Field");
                    return false;
                }
               
             
                if (Model1 == '') {
                    ShowPopupBlank("Please Fill First Make/Model Field");
                    return false;
                }
                if (CalibrationDate == '') {
                    ShowPopupBlank("Please Fill First Calibration Date Field");
                    return false;
                }
                if (Model2 == '') {
                    ShowPopupBlank("Please Fill Second Make/Model Field");
                    return false;
                }
                if (CalibrationDate1 == '') {
                    ShowPopupBlank("Please Fill Second Calibration Date Field");
                    return false;
                }
                if (ReceivedBy == '') {
                    ShowPopupBlank("Please Fill Received By Field");
                    return false;
                }
                if (Printname == '') {
                    ShowPopupBlank("Please Fill Print Name Field");
                    return false;
                }
                if (IssuedBy == '') {
                    ShowPopupBlank("Please Fill Issued By Field");
                    return false;
                }

                if (IDcard == '') {
                    ShowPopupBlank("Please Fill ID Card No Field");
                    return false;
                   

                }
                if (IssueDate == '') {
                    ShowPopupBlank("Please Fill Issue Date Field.");
                    return false;
                }
        }
    </script>
    <script type="text/javascript">
   <%-- $(document).ready(function () {
        $(".SUM").click(function () {
            var total = 0;
            var div = $("div#radiodiv1");
            var radiosBtns = div.find("input[type='radio']:checked");         
            $.each(radiosBtns, function (i, v) {
                var v = $(this)[0].value;
                total += parseInt(v);
                alert(total);
                 $('#<%=txtTotal.ClientID%>').val(total);

            })
  
        }
           );
    });--%>

    $(document).ready(function () {
        $(".rgSum").click(function () {
            var clsArray = Array("rgSeventeen", "rgEighteen", "rgNineteen", "rgTwenty", "rgTwentyOne", "rgTwentyTwo", "rgTwentyThree", "rgTwentyFour", "rgTwentyFive", "rgTwentySix");
            var total = 0;
            for (i = 0; i < clsArray.length; i++)
            {
                if ($("." + clsArray[i] + " input:checked").length > 0)
                {
                    var rdovalue = $("." + clsArray[i] + " input:checked").val();
                    total += parseInt(rdovalue);
                }
                          
            }
            $('#<%=txtTotal.ClientID%>').val(total);
           }
           );
    });

        $('#<%=txtReceiveDate.ClientID%>').change(function () {
            var clsArray = Array("rgSeventeen", "rgEighteen", "rgNineteen", "rgTwenty", "rgTwentyOne", "rgTwentyTwo", "rgTwentyThree", "rgTwentyFour", "rgTwentyFive", "rgTwentySix");
            var total = 0;
            for (i = 0; i < clsArray.length; i++)
            {
                if ($("." + clsArray[i] + " input:checked").length > 0)
                {
                    var rdovalue = $("." + clsArray[i] + " input:checked").val();
                    total += parseInt(rdovalue);
                }
                          
            }
            $('#<%=txtTotal.ClientID%>').val(total);
           }
           );
</script>
</asp:Content>
