<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Index.aspx.vb" Inherits="CRM.Index" %>
<%@ import namespace=" CRM.BE"%>
<%@ import namespace=" CRM.DL"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <script src="../assets/node_modules/jquery/jquery-3.2.1.min.js"></script>

     <style type="text/css">
              /*==================================================
 * Effect 2
 * ===============================================*/
.effect2
{

box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
}
 


              .row1:after 
              {
                  clear:both;
                  width:350px;
              }
               .table, .table td 
               { padding: 0.2rem !important;
                 
               }
                      .table tr
{
border:1px solid #fff; 
}   
         </style>
                 <div class="row page-titles">
                    <div class="col-md-5 align-self-center">
                        <h4 class="text-themecolor">Scheduled Engineer Jobs</h4>
                    </div>
                </div>
   

                <div class="row">
                    <!-- Column -->
                    <div class="col-lg-12 col-md-12">
                        <div class="card">
                            <div class="card-body" style="text-align:Center">
                               
 <div class="col-md-3">
                                                                <div class="example datepicker form-selection-box">
                                                                    <div class="input-group">
                                                                    <asp:TextBox ID="txtDate" runat="server" CssClass="form-control mydatepicker" placeholder="Date"></asp:TextBox>
                                                                        
                                                                        <div class="input-group-append">
                                                                            <span class="input-group-text"><i class="icon-calender"></i></span>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                      </div>
                                     </div>  
                            <div class="button-group note-btn" style="margin-left:30px;">
                                <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-outline-success btn-rounded"/>
                                </div>
                        </div>
                        <asp:HiddenField ID="hdnDownload" runat="server" Value="0" />
     
                    </div>
              
                    <!-- Column -->
                </div>

    <div>
              
              
                  <div class="table-main-warp">
                    <div class="row">
                        
                        <%
                            If objFunction.CheckDataSet(dstEngineer) Then

                                For i = 0 To dstEngineer.Tables(0).Rows.Count - 1

    %>
                    <!-- Column -->
               <!-- 7 july  <div>
                        <div> -->
                            <div class="col-12 ">
                        <div class="card  effect2" style="width:90%;float:left">
                            <div class="card-body ">
                                <div class="table-content " style="border:2px solid #fff">
                                    <h3 class="text-themecolor" style="text-align:left; padding-left:10px;background-color:#fff;color:#5C7394;    margin-bottom: 0.01rem !important;"><i class="fa fa-wrench"></i>&nbsp;&nbsp;&nbsp;<%= dstEngineer.Tables(0).Rows(i)("Engineer") %></h3>
                                    <% objBEOrder.Engineer = dstEngineer.Tables(0).Rows(i)("Engineer")%>
<%--                                   <%objBEOrder.SheetDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())%>--%>
                                   <%objBEOrder.SheetDate = Convert.ToDateTime(dt)%>
                                   <% dstJobList = (New clsDLOrder()).GetJobSheetDataByIndividualEngineer(objBEOrder)%>
                                    <% If objFunction.CheckDataSet(dstJobList) Then
                                            For j = 0 To dstJobList.Tables(0).Rows.Count - 1
               %>
                                     <% objBEJobsheet.JOBID = dstJobList.Tables(0).Rows(j)("JobId")%>
                                     <% dstJobSheet = (New clsDLJobsheet()).GetJobSheetDetailsByJobid(objBEJobsheet)%>
                                          <% Dim strclass As String = "bg-primary"%>
                                          <% Dim strstatus As String = "Not started"%>
                                          <% Dim strclass1 As String = ""%>

                                    <% If objFunction.CheckDataSet(dstJobSheet) Then
                                            If (dstJobSheet.Tables(0).Rows(0)("JobCompleteStatus").ToString() = 0) Then
                                                strstatus = "Not finished"
                                                strclass = ""
                                                strclass1 = "background-color:yellow;"
                                            Else
                                                strstatus = "finished"
                                                strclass = ""
                                                strclass1 = "background-color:yellowgreen;"

                                            End If
                                        Else
                                            strclass = "bg-primary"
                                            strstatus = "Not started"

                                        End If
               %>
                    <!-- Column -->
                       
                       
                           
                                   <div class="<%=strclass %>" style="<%=strclass1 %>">
                                         <div class="row1">
                                               <table class="table" style="margin-bottom:0px;">
                                                  <tr>
                <td style="font-weight:500; width:50%;padding-right:0px; padding-left:10px !important;">
<%= dstJobList.Tables(0).Rows(j)("Name") %>                     
                </td>
                <td style="font-weight:500;width:15%;padding-right:0px;">
<%=strstatus %>                </td>
                <td style="text-align:right; width:20%;padding-right:0px;">
<button type="button" id="btnMove" onclick="return GetJobSheetId('<%= dstJobList.Tables(0).Rows(j)("JobId") %>') "> Show Job Sheet</button>                </td>
                <td style="text-align:right; width:15%;padding-right:0px;">
<button type="button" id="btnJob" onclick="return GetRedirectWithId('<%= dstJobList.Tables(0).Rows(j)("JobId") %>');">Show Job</button>                </td>
               
             </tr>
                                             </table>
</div>
                                       </div>
                                
                           
                        
                                       
                    <!-- Column -->
           <%
                   Next

               End If
    %>         
                                </div>
                            </div>
                        </div>
                    </div>
                          <!-- 7 july  </div>
                    </div>-->
                    <!-- Column -->
           <%
                   Next

               End If
    %>         
                   
                   </div></div>
              
                <!-- /.row -->
                <!-- ============================================================== -->
                <!-- End Page Content -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <!-- Right sidebar -->
                <!-- ============================================================== -->
                <!-- .right-sidebar -->
                <div class="right-sidebar">
                    <div class="slimscrollright">
                        <div class="rpanel-title"> Service Panel <span><i class="ti-close right-side-toggle"></i></span> </div>
                        <div class="r-panel-body">
                            <ul id="themecolors" class="m-t-20">
                                <li><b>With Light sidebar</b></li>
                                <li><a href="javascript:void(0)" data-skin="skin-default" class="default-theme">1</a></li>
                                <li><a href="javascript:void(0)" data-skin="skin-green" class="green-theme">2</a></li>
                                <li><a href="javascript:void(0)" data-skin="skin-red" class="red-theme">3</a></li>
                                <li><a href="javascript:void(0)" data-skin="skin-blue" class="blue-theme">4</a></li>
                                <li><a href="javascript:void(0)" data-skin="skin-purple" class="purple-theme">5</a></li>
                                <li><a href="javascript:void(0)" data-skin="skin-megna" class="megna-theme">6</a></li>
                                <li class="d-block m-t-30"><b>With Dark sidebar</b></li>
                                <li><a href="javascript:void(0)" data-skin="skin-default-dark" class="default-dark-theme working">7</a></li>
                                <li><a href="javascript:void(0)" data-skin="skin-green-dark" class="green-dark-theme">8</a></li>
                                <li><a href="javascript:void(0)" data-skin="skin-red-dark" class="red-dark-theme">9</a></li>
                                <li><a href="javascript:void(0)" data-skin="skin-blue-dark" class="blue-dark-theme">10</a></li>
                                <li><a href="javascript:void(0)" data-skin="skin-purple-dark" class="purple-dark-theme">11</a></li>
                                <li><a href="javascript:void(0)" data-skin="skin-megna-dark" class="megna-dark-theme ">12</a></li>
                            </ul>
                            <ul class="m-t-20 chatonline">
                                <li><b>Chat option</b></li>
                                <li>
                                    <a href="javascript:void(0)"><img src="../assets/images/users/1.jpg" alt="user-img" class="img-circle"> <span>Varun Dhavan <small class="text-success">online</small></span></a>
                                </li>
                                <li>
                                    <a href="javascript:void(0)"><img src="../assets/images/users/2.jpg" alt="user-img" class="img-circle"> <span>Genelia Deshmukh <small class="text-warning">Away</small></span></a>
                                </li>
                                <li>
                                    <a href="javascript:void(0)"><img src="../assets/images/users/3.jpg" alt="user-img" class="img-circle"> <span>Ritesh Deshmukh <small class="text-danger">Busy</small></span></a>
                                </li>
                                <li>
                                    <a href="javascript:void(0)"><img src="../assets/images/users/4.jpg" alt="user-img" class="img-circle"> <span>Arijit Sinh <small class="text-muted">Offline</small></span></a>
                                </li>
                                <li>
                                    <a href="javascript:void(0)"><img src="../assets/images/users/5.jpg" alt="user-img" class="img-circle"> <span>Govinda Star <small class="text-success">online</small></span></a>
                                </li>
                                <li>
                                    <a href="javascript:void(0)"><img src="../assets/images/users/6.jpg" alt="user-img" class="img-circle"> <span>John Abraham<small class="text-success">online</small></span></a>
                                </li>
                                <li>
                                    <a href="javascript:void(0)"><img src="../assets/images/users/7.jpg" alt="user-img" class="img-circle"> <span>Hritik Roshan<small class="text-success">online</small></span></a>
                                </li>
                                <li>
                                    <a href="javascript:void(0)"><img src="../assets/images/users/8.jpg" alt="user-img" class="img-circle"> <span>Pwandeep rajan <small class="text-success">online</small></span></a>
                                </li>
                            </ul>
                        </div>
                                                <asp:HiddenField ID="hdnCount" runat="server"/>

                    </div>
                </div>
                <!-- ============================================================== -->
                <!-- End Right sidebar -->
                <!-- ============================================================== -->
        
            <!-- ============================================================== -->
            <!-- End Container fluid  -->
            <!-- ============================================================== -->
       </div>


    <script type="text/javascript">

            function GetRedirectWithId(Id)
            {
                var jobid = Id;
              <%--  '<% Session("JID") = "' +jobid + '" %>';
                alert('<%=Session("JID") %>');--%>
                location.href = "Job_orderdetailsShow.aspx?JID=" + jobid;
            }

        function GetJobSheetId(JobID) {
               if (JobID != "") {
                  var doaction = "GetJobSheetId";
                  $.post('GetAjaxData.aspx', { DoAction: doaction, JobID: JobID }, function (responseText) {
                      if (responseText.toString() != "Error")
                      {
                          var jobsheetId = responseText.toString();
                          location.href = "view_job_sheet_edit.aspx?ID=" + jobsheetId;
                      }
                      else
                      {
                          ShowPopup("This Job Sheet Has Not Been Entered Yet.", "warning");
                      }
                  }); 
              }
               else
              {
                  ShowPopup("Sorry There Is No JobId To Show Details.", "error");
              }
          }
      </script>
</asp:Content>
