<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Parts_Part_OrderList.aspx.vb" Inherits="CRM.Parts_Part_OrderList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Page wrapper  -->
    <!-- ============================================================== -->

    <!-- ============================================================== -->
    <!-- Container fluid  -->
    <!-- ============================================================== -->

    <!-- ============================================================== -->
    <!-- Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <div class="row page-titles">
        <div class="col-md-5 align-self-center">
            <h4 class="text-themecolor">Parts Order List</h4>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Info box -->
    <!-- ============================================================== -->

    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="row">
                <div class="col-12">
                    <div class="card">
                        <div class="card-body">
                            <div class="table-responsive">
                                <%--<asp:Repeater ID="RptJobList" runat="server">
                                            <HeaderTemplate>
                                                <table id="example24" class="table table-striped">
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
                                <asp:GridView ID="grdOrderedParts" runat="server"
                                    AllowPaging="True" PageSize="50" CssClass="table table-striped clsResizeColumn" AutoGenerateColumns="False" DataKeyNames="PartsOrderID"
                                    EmptyDataText="No Records Found" ShowHeaderWhenEmpty="True" AllowSorting="true" OnSorting="grdOrderedParts_Sorting">
                                    <HeaderStyle Font-Size="Small" Height="25px" HorizontalAlign="Center"/>
                                    <PagerStyle CssClass="PageClass" />
                                    <Columns>
                                        <asp:BoundField DataField="PartsOrderID" HeaderText="ID" Visible="false" />
                                        <asp:BoundField DataField="SupplierName" HeaderText="SupplierName" ReadOnly="true" SortExpression="SupplierName" />
                                        <asp:TemplateField HeaderText="Order Created Date" SortExpression="DateOrderCreated">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_DateCreated" runat="server" Text='<%# SetDateVal(Eval("DateOrderCreated")) %>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Order Closed Date" SortExpression="DateOrderClosed">
                                            <ItemTemplate>
                                                <asp:Label ID="LABEL_DateClosed" runat="server" Text='<%# SetDateVal(Eval("DateOrderClosed")) %>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:BoundField DataField="PartNo" HeaderText="Order Number" ReadOnly="true" SortExpression="PartNo" />
                                        <asp:BoundField DataField="SumOfQuantity" HeaderText="Qty" ReadOnly="true" SortExpression="SumOfQuantity" />
                                        <asp:BoundField DataField="SumOfRecieved" HeaderText="Received" ReadOnly="true" SortExpression="SumOfRecieved" />
                                        <asp:BoundField DataField="SumOfAwaiting" HeaderText="Await" ReadOnly="true" SortExpression="SumOfAwaiting" />
                                        <asp:CommandField ShowSelectButton="true" HeaderText="Information" SelectText="View" ItemStyle-Font-Bold="true"/>
                                    </Columns>
                                    <RowStyle HorizontalAlign="Center" Font-Size="Small" Height="50px" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">

        <div class="col-lg-12 col-md-12">

            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-body">
                            <div class="floating-labels">
                                <div class="form-group m-b-40">
                                    <div class="skin skin-flat m-t-30 check-main-warp">
                                        <div class="form-group">
                                            <label>Viewing Options</label>
                                            <div class="input-group ">
                                                <ul class="icheck-list costs-main">
                                                    <li>
                                                        <asp:RadioButton ID="flatradio1" CssClass="check" name="flat-radio" data-radio="iradio_flat-red" Checked="true" GroupName="1stGroup" runat="server" />
                                                        <label for="ContentPlaceHolder1_flatradio1">All</label>
                                                    </li>
                                                    <li>
                                                        <asp:RadioButton ID="flatradio2" CssClass="check" name="flat-radio" data-radio="iradio_flat-red" GroupName="1stGroup" runat="server" />
                                                        <label for="ContentPlaceHolder1_flat-radio-2">Awaiting Parts</label>
                                                    </li>

                                                    <%-- <li>
                                                                    <asp:RadioButton ID="flatradio3" CssClass="check" name="flat-radio" data-radio="iradio_flat-red" GroupName="1stGroup" runat="server" />
                                                                    <label for="ContentPlaceHolder1_flat-radio-3">Job Await Parts</label>
                                                                </li>--%>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="form-selection-box padddng-btn m-b-40">
                                    <asp:DropDownList ID="ddlSupplier" runat="server" CssClass="selectpicker" data-style="form-control btn-secondary">
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group m-b-40">
                                    <asp:TextBox ID="txtOrderno" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                    <span class="bar"></span>
                                    <label for="ContentPlaceHolder1_txtvalue">Order Nos</label>
                                </div>
                                <div class="form-group m-b-40">
                                    <asp:TextBox ID="txtFFNos" runat="server" CssClass="form-control input-sm"></asp:TextBox><span class="bar"></span>
                                    <label for="ContentPlaceHolder1_txtFFNos">Parts Order ID</label>
                                </div>


                                <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="SEARCH" />
                                <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-outline-success btn-rounded m-t-30" Text="ADD NEW"/>
                                <br />

                            </div>
                        </div>

                    </div>
                </div>
            </div>

        </div>




    </div>

    <!-- ============================================================== -->
    <!-- End Container fluid  -->
    <!-- ============================================================== -->


</asp:Content>
