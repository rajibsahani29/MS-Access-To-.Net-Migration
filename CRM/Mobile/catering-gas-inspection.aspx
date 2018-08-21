<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Mobile/Mobile.Master" CodeBehind="catering-gas-inspection.aspx.vb" Inherits="CRM.catering_gas_inspection" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
                        <div class="table-responsive new-table-warp custom-cater-table">
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
                                            <div class="card-body col-lg-4">
                                                <div class="table-form">
                                                    <div class="table-form">
                                                        <div class="form-group">
                                                            <asp:DropDownList ID="ddlCompany" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                                            </asp:DropDownList>
                                                            <asp:HiddenField ID="hdnID" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Reg / Chasis No</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body col-lg-4">
                                                <div class="table-form">
                                                    <div class="table-form">
                                                        <div class="form-group">
                                                            <asp:TextBox ID="txtReg" CssClass="form-control input-sm removereadonly" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Type</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgOne">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton1" CssClass="check" GroupName="options" value="Yes" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Vehicle
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton2" CssClass="check" GroupName="options" value="No" runat="server" />
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Trailer
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>No of appliances tested</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body col-lg-4">
                                                <div class="table-form">
                                                    <div class="form-group">
                                                        <asp:TextBox ID="txtAppTested" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Is the LPG cylinder housing satisfactory?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgTwo">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton3" CssClass="check" GroupName="options1" value="Yes" runat="server" />
                                                        <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton4" CssClass="check" GroupName="options1" value="No" runat="server" />
                                                        <%--<input type="radio" name="options" autocomplete="off" value="No">--%>
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Is the Emergency Control Valve accessible and operable?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgThree">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton5" CssClass="check" GroupName="options2" value="Yes" runat="server" />
                                                        <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton6" CssClass="check" GroupName="options2" value="No" runat="server" />
                                                        <%--  <input type="radio" name="options" autocomplete="off" value="No">--%>
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Gas tightness test satisfactory?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFour">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton7" CssClass="check" GroupName="options3" value="Yes" runat="server" />
                                                        <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton8" CssClass="check" GroupName="options3" value="No" runat="server" />
                                                        <%--<input type="radio" name="options" autocomplete="off" value="No">--%>
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Is the gas installation pipework satisfactory?</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="card-body rgFive">
                                                <div class="btn-group" data-toggle="buttons" role="group">
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton9" CssClass="check" GroupName="options4" value="Yes" runat="server" />
                                                        <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                        <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                    </label>
                                                    <label class="btn btn-outline btn-info">
                                                        <asp:RadioButton ID="RadioButton10" CssClass="check" GroupName="options4" value="No" runat="server" />
                                                        <%--<input type="radio" name="options" autocomplete="off" value="No">--%>
                                                        <i class="ti-check text-active" aria-hidden="true"></i>No
                                                    </label>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>LPG regulator operating pressure (mbar)</td>
                                        <td>
                                            <div class="card-body col-lg-4">
                                                <div class="table-form">
                                                    <div class="form-group">
                                                        <asp:TextBox ID="txtLPGReg1" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>LPG regulator lock up pressure (mbar)</td>
                                        <td>
                                            <div class="card-body col-lg-4">
                                                <div class="table-form">
                                                    <div class="form-group">
                                                        <asp:TextBox ID="txtLPGReg2" CssClass="form-control input-sm removereadonly" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>

                        <div class="table-responsive dataTable-custom">
                            <%--<asp:Repeater ID="RptJobList1" runat="server">
                                        <HeaderTemplate>
                                            <table id="example23" class="table table-striped">
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
                                    </asp:Repeater>--%>

                            <asp:GridView ID="grdAppliance" runat="server" AutoGenerateColumns="False"
                                EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="CateringAppId">
                                <HeaderStyle Font-Size="Large" Height="25px" CssClass="table table-striped" />
                                <Columns>
                                    <asp:BoundField DataField="CateringAppId" Visible="false" />
                                    <asp:TemplateField HeaderText="Appliance Type">
                                        <ItemTemplate>
                                            <asp:Label ID="LABEL_Type" runat="server" Text='<%# Eval("ApplianceType")%>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtType" runat="server" Text='<%#Eval("ApplianceType")%>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Appliance Make">
                                        <ItemTemplate>
                                            <asp:Label ID="LABEL_Make" runat="server" Text='<%# Eval("ApplianceMake")%>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtMake" runat="server" Text='<%#Eval("ApplianceMake")%>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Model">
                                        <ItemTemplate>
                                            <asp:Label ID="LABEL_model" runat="server" Text='<%# Eval("Model")%>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtModel" runat="server" Text='<%#Eval("Model")%>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="SerialNo">
                                        <ItemTemplate>
                                            <asp:Label ID="LABEL_serial" runat="server" Text='<%# Eval("SerialNo")%>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtSerial" runat="server" Text='<%#Eval("SerialNo")%>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Type of Flue?">
                                        <ItemTemplate>
                                            <asp:Label ID="LABEL_Flue" runat="server" Text='<%# Eval("FlueType")%>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtFlue" runat="server" Text='<%#Eval("FlueType")%>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Is Appliance Secure?">
                                        <ItemTemplate>
                                            <asp:Label ID="LABEL_secure" runat="server" Text='<%# Eval("ApplianceSecure")%>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtSecure" runat="server" Text='<%#Eval("ApplianceSecure")%>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Is An Isolation Valve Fitted?(Y/N)">
                                        <ItemTemplate>
                                            <asp:Label ID="LABEL_valve" runat="server" Text='<%# Eval("IsolationValve")%>' />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtIsolationValve" runat="server" Text='<%#Eval("IsolationValve")%>' />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:CommandField ShowSelectButton="true" SelectText="Delete" />

                                    <%--                                         <asp:CommandField ShowEditButton="True" ShowDeleteButton="true" />--%>
                                </Columns>
                                <RowStyle HorizontalAlign="Center" Font-Size="Medium" Height="50px" />
                            </asp:GridView>
                        </div>


                        <div class="accordion-main" id="ChildDetails" runat="server">
                            <a href="javascript:void(0)" class="accordion-custom">New Appliance</a>
                            <div class="panel-custom">
                                <div class="table-responsive new-table-warp">
                                    <table class="table color-table primary-table radio-table">
                                        <thead>
                                            <tr>
                                                <th>Appliance Details</th>
                                                <th></th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>Appliance Type</td>
                                                <td>
                                                    <div class="card-body col-lg-4">
                                                        <div class="table-form">
                                                            <div class="form-group">
                                                                <asp:TextBox ID="txtAppliance" CssClass="form-control input-sm removereadonly" runat="server" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Appliance Make</td>
                                                <td>
                                                    <div class="card-body col-lg-4">
                                                        <div class="table-form">
                                                            <div class="form-group">
                                                                <asp:TextBox ID="txtApplianceMake" CssClass="form-control input-sm removereadonly" runat="server" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Appliance Model</td>
                                                <td>
                                                    <div class="card-body col-lg-4">
                                                        <div class="table-form">
                                                            <div class="form-group">
                                                                <asp:TextBox ID="txtApplianceModel" CssClass="form-control input-sm removereadonly" runat="server" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Appliance Serial Number</td>
                                                <td>
                                                    <div class="card-body col-lg-4">
                                                        <div class="table-form">
                                                            <div class="form-group">
                                                                <asp:TextBox ID="txtAppSerialNum" CssClass="form-control input-sm removereadonly" runat="server" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Type of Flue</td>
                                                <td>
                                                    <div class="card-body rgSix">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton11" CssClass="check" GroupName="options4" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton12" CssClass="check" GroupName="options4" value="No" runat="server" />
                                                                <%-- <input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Is Appliance secure?</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgSeven">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton13" CssClass="check" GroupName="options5" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton14" CssClass="check" GroupName="options5" value="No" runat="server" />
                                                                <%--        <input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Is an Isolation Valve fitted?</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgEight">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton15" CssClass="check" GroupName="options6" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton16" CssClass="check" GroupName="options6" value="No" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                        </tbody>
                                        <thead>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>
                                                    <asp:Button ID="btnSubmitAppliance" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Submit" OnClientClick="return ValidateControlsAppliance()" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <th>Inspection Details</th>
                                                <th></th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>Operating Pressure in mbar and/or Heat Input in KW/Btu/h</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgNine">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton17" CssClass="check" GroupName="options7" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton18" CssClass="check" GroupName="options7" value="No" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Are Safety Devices working?</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgTen">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton19" CssClass="check" GroupName="options8" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton20" CssClass="check" GroupName="options8" value="No" runat="server" />
                                                                <%-- <input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Satisfactory Ventilation?</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgEleven">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton21" CssClass="check" GroupName="options9" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton22" CssClass="check" GroupName="options9" value="No" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Flue Visual Condition</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgTwelve">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton23" CssClass="check" GroupName="options10" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton24" CssClass="check" GroupName="options10" value="No" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Flue Performance Checks</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgThirteen">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton25" CssClass="check" GroupName="options11" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton26" CssClass="check" GroupName="options11" value="No" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Appliance Serviced?</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgFourteen">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton27" CssClass="check" GroupName="options12" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton28" CssClass="check" GroupName="options12" value="No" runat="server" />
                                                                <%-- <input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Appliance Safe to use?</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgFifteen">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton29" CssClass="check" GroupName="options13" value="Yes" runat="server" />
                                                                <%-- <input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton30" CssClass="check" GroupName="options13" value="No" runat="server" />
                                                                <%-- <input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>
                                                    <asp:Button ID="btnInspection" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Submit" OnClientClick="return ValidateControlsInspection()" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">

                                                    <asp:GridView ID="grdInspection" runat="server" AutoGenerateColumns="False"
                                                        EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="CateringInspectionId">
                                                        <HeaderStyle Font-Size="Large" Height="25px" />
                                                        <Columns>
                                                            <asp:BoundField DataField="CateringInspectionId" Visible="false" />
                                                            <asp:TemplateField HeaderText="Operating Pressure">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_Operating" runat="server" Text='<%# Eval("Operating")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtOperating" runat="server" Text='<%#Eval("Operating")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Are Safety Devices working?">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_Safety" runat="server" Text='<%# Eval("Safety")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtSafety" runat="server" Text='<%#Eval("Safety")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Satisfactory Ventilation?(Y/N)">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_ventilation" runat="server" Text='<%# Eval("Satisfactory")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtVentillation" runat="server" Text='<%#Eval("Satisfactory")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Flue Visual Conditions(Y/N)">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_conditions" runat="server" Text='<%# Eval("Conditions")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtConditions" runat="server" Text='<%#Eval("Conditions")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Flue Performance Checks(Y/N)">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_Performances" runat="server" Text='<%# Eval("Performances")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtPerformances" runat="server" Text='<%#Eval("Performances")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Appliance Serviced?(Y/N)">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_secure0" runat="server" Text='<%# Eval("Serviced")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtserviced" runat="server" Text='<%#Eval("Serviced")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Is An Isolation Valve Fitted?(Y/N)">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_SafeToUse" runat="server" Text='<%# Eval("SafeToUse")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txttSafeToUse" runat="server" Text='<%#Eval("SafeToUse")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:CommandField ShowSelectButton="true" SelectText="Delete" />


                                                            <%--                                         <asp:CommandField ShowEditButton="True" ShowDeleteButton="true" />--%>
                                                        </Columns>
                                                        <RowStyle HorizontalAlign="Center" Font-Size="Medium" Height="50px" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                        </tbody>

                                        <thead>

                                            <tr>
                                                <th>Safety Details</th>
                                                <th></th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>Is a Fire Extinguisher available?</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgSixteen">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton31" CssClass="check" GroupName="options14" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton32" CssClass="check" GroupName="options14" value="No" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Is a Fire Blanket Available?</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgSeventeen">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton33" CssClass="check" GroupName="options15" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton34" CssClass="check" GroupName="options15" value="No" runat="server" />
                                                                <%-- <input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Is the current Safety Record on display?</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgEighteen">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton35" CssClass="check" GroupName="options16" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton36" CssClass="check" GroupName="options16" value="No" runat="server" />
                                                                <%-- <input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Is LPG Safety Information on display?</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgNineteen">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton37" CssClass="check" GroupName="options17" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton38" CssClass="check" GroupName="options17" value="No" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>
                                                    <asp:Button ID="btnSaftety" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Submit" OnClientClick="return ValidateControlsSafety()" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">

                                                    <asp:GridView ID="grdSafety" runat="server" AutoGenerateColumns="False"
                                                        EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="CateringSafetyId">
                                                        <HeaderStyle Font-Size="Large" Height="25px" />
                                                        <Columns>
                                                            <asp:BoundField DataField="CateringSafetyId" Visible="false" />
                                                            <asp:TemplateField HeaderText="Is a Fire Extinguisher available?(Y/N)">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_exstinguisher" runat="server" Text='<%# Eval("Exstinguisher")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtexstinguisher" runat="server" Text='<%#Eval("Exstinguisher")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Is a Fire Blanket available?(Y/N)">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_blanket" runat="server" Text='<%# Eval("Blanket")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtblanket" runat="server" Text='<%#Eval("Blanket")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Is the current Safety Record on display?(Y/N)">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_current" runat="server" Text='<%# Eval("CurrentSafety")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtcurrentSafety" runat="server" Text='<%#Eval("CurrentSafety")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Is LPG Safety Information on display?(Y/N)">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_lpgsafety" runat="server" Text='<%# Eval("LPGSafety")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtLpgSafety" runat="server" Text='<%#Eval("LPGSafety")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:CommandField ShowSelectButton="true" SelectText="Delete" />


                                                            <%--                                         <asp:CommandField ShowEditButton="True" ShowDeleteButton="true" />--%>
                                                        </Columns>
                                                        <RowStyle HorizontalAlign="Center" Font-Size="Medium" Height="50px" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                        </tbody>

                                        <thead>


                                            <tr>
                                                <th>Work Details</th>
                                                <th></th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>Defect(s) identified</td>
                                                <td>
                                                    <div class="card-body col-lg-4">
                                                        <div class="table-form">
                                                            <div class="form-group">
                                                                <asp:TextBox ID="txtDefects" CssClass="form-control input-sm removereadonly" runat="server" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Warning Advice Issued?</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body rgTwenty">
                                                        <div class="btn-group" data-toggle="buttons" role="group">
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton39" CssClass="check" GroupName="options18" value="Yes" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="Yes">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>Yes
                                                            </label>
                                                            <label class="btn btn-outline btn-info">
                                                                <asp:RadioButton ID="RadioButton40" CssClass="check" GroupName="options18" value="No" runat="server" />
                                                                <%--<input type="radio" name="options" autocomplete="off" value="No">--%>
                                                                <i class="ti-check text-active" aria-hidden="true"></i>No
                                                            </label>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Remedial work undertaken</td>

                                                <td>
                                                    <div class="card-body">
                                                        <div class="table-form">
                                                            <div class="table-form">
                                                                <div class="form-group">
                                                                    <asp:TextBox ID="txtRemedical" CssClass="form-control input-sm removereadonly" runat="server" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Details of work required</td>
                                                <td>
                                                    <div class="card-body">
                                                        <div class="table-form">
                                                            <div class="table-form">
                                                                <div class="form-group">
                                                                    <asp:TextBox ID="txtDetails" CssClass="form-control input-sm removereadonly" runat="server" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>
                                                    <asp:Button ID="btnSubmitWork" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Submit" OnClientClick="return ValidateControlsWork()" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">

                                                    <asp:GridView ID="grdWork" runat="server" AutoGenerateColumns="False"
                                                        EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True" DataKeyNames="CateringWorkId" Width="1250px">
                                                        <HeaderStyle Font-Size="Large" Height="25px" />
                                                        <Columns>
                                                            <asp:BoundField DataField="CateringWorkId" Visible="false" />
                                                            <asp:TemplateField HeaderText="Defect(s) identified?(Y/N)">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_defects" runat="server" Text='<%# Eval("Defects")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtdefects" runat="server" Text='<%#Eval("Defects")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Warnings advice Issued?(Y/N)">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_warnings" runat="server" Text='<%# Eval("warnings")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtwarnings" runat="server" Text='<%#Eval("warnings")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Remedical Work Undertaken">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_remedicals" runat="server" Text='<%# Eval("Remedicals")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtremedicals" runat="server" Text='<%#Eval("Remedicals")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Details Of Work">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="LABEL_details" runat="server" Text='<%# Eval("WorkDetails")%>' />
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtworkdetails" runat="server" Text='<%#Eval("WorkDetails")%>' />
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:CommandField ShowSelectButton="true" SelectText="Delete" />



                                                        </Columns>
                                                        <RowStyle HorizontalAlign="Center" Font-Size="Medium" Height="50px" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                        </tbody>


                                    </table>
                                </div>
                            </div>
                        </div>

                        <div class="accordion-main">
                            <div class="panel-custom">
                                <div class="table-responsive new-table-warp custom-cater-table">
                                    <table class="table color-table primary-table radio-table">

                                        <thead>
                                            <tr>
                                                <th></th>
                                                <th></th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>Received By</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body col-lg-4">
                                                        <div class="table-form">
                                                            <div class="table-form">
                                                                <div class="form-group">
                                                                    <asp:TextBox ID="txtReceiveBy" CssClass="form-control input-sm removereadonly" runat="server" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>

                                                <td>Issued By</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body col-lg-4">
                                                        <div class="table-form">
                                                            <div class="form-group">
                                                                <asp:TextBox ID="txtIssuedBy" CssClass="form-control input-sm removereadonly" runat="server" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>ID Card No</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body col-lg-4">
                                                        <div class="table-form">
                                                            <div class="table-form">
                                                                <div class="form-group">
                                                                    <asp:TextBox ID="txtIdCardNo" CssClass="form-control input-sm removereadonly" runat="server" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>Print Name</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="card-body col-lg-4">
                                                        <div class="table-form">
                                                            <div class="table-form">
                                                                <div class="form-group">
                                                                    <asp:TextBox ID="txtPrint" CssClass="form-control input-sm removereadonly" runat="server" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Issue Date</td>
                                            </tr>
                                            <tr>
                                                <td>

                                                    <div class="example datepicker form-selection-box">
                                                        <div class="input-group">
                                                            <asp:TextBox ID="txtDate" runat="server" CssClass="form-control mydatepicker" placeholder="Issue Date"></asp:TextBox>
                                                        </div>
                                                        <div class="input-group-append">
                                                            <span class="input-group-text"><i class="icon-calender"></i></span>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>
                                                    <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-outline-success btn-rounded" Text="Submit" OnClientClick="return ValidateControls()" />
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
        </div>
        <!-- ============================================================== -->
        <!-- End Container fluid  -->
        <!-- ============================================================== -->
    </div>
    <!-- ============================================================== -->
    <!-- End PAge Content -->
    <!-- ============================================================== -->

    <script type="text/javascript">
        function ValidateControls() {
            var clsArray = Array("rgOne");
            var bnlError = false;
            for (i = 0; i < clsArray.length; i++) {
                if ($("." + clsArray[i] + " input:checked").length == 0) {
                    bnlError = true;
                    break;
                }
            }

            if (bnlError == true) {
                ShowPopupBlank("Please Choose Type");
                return false;
            }

            var clsArray = Array("rgTwo");
            var bnlError = false;
            for (i = 0; i < clsArray.length; i++) {
                if ($("." + clsArray[i] + " input:checked").length == 0) {
                    bnlError = true;
                    break;
                }
            }

            if (bnlError == true) {
                ShowPopupBlank("Please Choose LPG cylinder housing satisfactory Field.");
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
                ShowPopupBlank("Please Choose the Emergency Control Valve accessible and operable Field");
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
                ShowPopupBlank("Please Choose Gas tightness test satisfactory Field");
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
                ShowPopupBlank("Please Choose the gas installation pipework satisfactory Field");
                return false;
            }
            var RegNo, AppTested, ReceiveDate, Jobid,company, IDcard, IssuedBy, Printname, ReceivedBy, LPGReg1, LPGReg2;
            Jobid = document.getElementById("ContentPlaceHolder1_ddlJobId").value;
            company = document.getElementById("ContentPlaceHolder1_ddlCompany").value;
            RegNo = document.getElementById("ContentPlaceHolder1_txtReg").value;
            AppTested = document.getElementById("ContentPlaceHolder1_txtAppTested").value;
            ReceiveDate = document.getElementById("ContentPlaceHolder1_txtDate").value;
            IDcard = document.getElementById("ContentPlaceHolder1_txtIdCardNo").value;
            Printname = document.getElementById("ContentPlaceHolder1_txtPrint").value;
            ReceivedBy = document.getElementById("ContentPlaceHolder1_txtReceiveBy").value;
            IssuedBy = document.getElementById("ContentPlaceHolder1_txtIssuedBy").value;
            LPGReg1 = document.getElementById("ContentPlaceHolder1_txtLPGReg1").value;
            LPGReg2 = document.getElementById("ContentPlaceHolder1_txtLPGReg2").value;
            if (Jobid == '') {
                ShowPopupBlank("Please Choose JobId");
                return false;
            }
            if (company == '') {
                ShowPopupBlank("Please Choose Company Name.");
                return false;
            }
            if (RegNo == '') {
                ShowPopupBlank("Please Fill Reg/Chasis No Field");
                return false;
            }
            if (AppTested == '') {
                ShowPopupBlank("Please Fill No of appliances tested Field");
                return false;
            }
            if (LPGReg1 == '') {
                ShowPopupBlank("Please Fill LPG regulator operating pressure Field");
                return false;
            }
            if (LPGReg2 == '') {
                ShowPopupBlank("Please Fill LPG regulator lock up pressure Field");
                return false;
            }
          

            if (ReceivedBy == '') {
                ShowPopupBlank("Please Fill Received By Field");
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
            if (Printname == '') {
                ShowPopupBlank("Please Fill Print Name Field");
                return false;
            }
            if (ReceiveDate == '') {
                ShowPopupBlank("Please Fill Issue Date Field");
                return false;
            }
           

        }

        function ValidateControlsInspection() {
            var clsArray = Array("rgNine");
            var bnlError = false;
            for (i = 0; i < clsArray.length; i++) {
                if ($("." + clsArray[i] + " input:checked").length == 0) {
                    bnlError = true;
                    break;
                }
            }

            if (bnlError == true) {
                ShowPopupBlank("Please Choose Operating Pressure in mbar and/or Heat Input in KW/Btu/h Field");
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
                ShowPopupBlank("Please Choose Safety Devices working Field");
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
                ShowPopupBlank("Please Choose Satisfactory Ventilation Field");
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
                ShowPopupBlank("Please Choose Flue Visual Condition Field");
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
                ShowPopupBlank("Please Choose Flue Performance Checks Field");
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
                ShowPopupBlank("Please Choose Appliance Serviced Field");
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
                ShowPopupBlank("Please Choose Appliance Safe to use Field");
                return false;
            }

        }

        function ValidateControlsAppliance() {
            var clsArray = Array("rgSix");
            var bnlError = false;
            for (i = 0; i < clsArray.length; i++) {
                if ($("." + clsArray[i] + " input:checked").length == 0) {
                    bnlError = true;
                    break;
                }
            }

            if (bnlError == true) {
                ShowPopupBlank("Please Choose Type of Flue Field");
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
                ShowPopupBlank("Please Choose Appliance secure Field");
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
                ShowPopupBlank("Please Choose Isolation Valve fitted Field");
                return false;
            }
            var Type, Make, Model, Serialno;
            Type = document.getElementById("ContentPlaceHolder1_txtAppliance").value;
            Make = document.getElementById("ContentPlaceHolder1_txtApplianceMake").value;
            Model = document.getElementById("ContentPlaceHolder1_txtApplianceModel").value;
            Serialno = document.getElementById("ContentPlaceHolder1_txtAppSerialNum").value;
            if (Type == '') {
                ShowPopupBlank("Please Fill Appliance Type Field");
                return false;
            }
            if (Make == '') {
                ShowPopupBlank("Please Fill Appliance Make Field");
                return false;
            }
            if (Model == '') {
                ShowPopupBlank("Please Fill Appliance Model Field");
                return false;
            }
            if (Serialno == '')
            {
                ShowPopupBlank("Please Fill Appliance Serial No. Field");
                return false;
            }
        }

        function ValidateControlsSafety() {
            var clsArray = Array("rgSixteen");
            var bnlError = false;
            for (i = 0; i < clsArray.length; i++) {
                if ($("." + clsArray[i] + " input:checked").length == 0) {
                    bnlError = true;
                    break;
                }
            }

            if (bnlError == true) {
                ShowPopupBlank("Please Choose Fire Extinguisher available Field");
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
                ShowPopupBlank("Please Choose Fire Blanket Available Field");
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
                ShowPopupBlank("Please Choose current Safety Record on display Field");
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
                ShowPopupBlank("Please Choose LPG Safety Information on display Field");
                return false;
            }
        }



        function ValidateControlsWork() {
            var clsArray = Array("rgTwenty");
            var bnlError = false;
            for (i = 0; i < clsArray.length; i++) {
                if ($("." + clsArray[i] + " input:checked").length == 0) {
                    bnlError = true;
                    break;
                }
            }

            if (bnlError == true) {
                ShowPopupBlank("Please Choose Warning Advice Issued Field");
                return false;
            }

            var Defects, Remedical, Details;
            Defects = document.getElementById("ContentPlaceHolder1_txtDefects").value;
            Remedical = document.getElementById("ContentPlaceHolder1_txtRemedical").value;
            Details = document.getElementById("ContentPlaceHolder1_txtDetails").value;
            if (Defects == '') {
                ShowPopupBlank("Please Fill Defects identified Field");
                return false;
            }
            if (Remedical == '') {
                ShowPopupBlank("Please Fill Remedical under Taken Field");
                return false;
            }
            if (Details == '') {
                ShowPopupBlank("Please Fill Details of work required");
                return false;
            }

        }
    </script>
</asp:Content>
