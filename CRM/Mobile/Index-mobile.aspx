<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Mobile/Mobile.Master" CodeBehind="Index-mobile.aspx.vb" Inherits="CRM.Index_mobile" %>
<%@ import namespace=" CRM.BE"%>
<%@ import namespace=" CRM.DL"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">

        .table-main-warp tr {
            float: left;
            width: 100%;
            margin-bottom: 5px;
        }

        .table-main-warp th, .table-main-warp td {
            color: #fff;
        }

        .table-content h2 {
            font-size: 16px;
            margin-bottom: 10px;
            text-transform: uppercase;
            font-weight: 600;
            color: #fff;
            letter-spacing: 1.5px;
        }

        .table-text-content {
            color: #fff;
            margin-bottom: 0;
            font-weight: 500;
            letter-spacing: 1px;
            position: relative;
            padding-left: 20px;
        }

        .table-content ul {
            margin: 0px;
            padding: 15px 0;
            list-style: none;
        }

            .table-content ul li {
                display: inline-block;
            }

                .table-content ul li p {
                    margin: 0px;
                    font-size: 16px;
                    letter-spacing: 1px;
                    color: #fff;
                }

        .table-content h3 {
            margin: 0;
            font-weight: 600;
            color: #fff;
            padding-bottom: 10px;
            letter-spacing: 1px;
            float: left;
            width: 100%;
        }

        .table-content .text-right {
            float: right;
        }

        .table-content p {
            margin: 0;
            color: #fff;
        }

        ul.btn-section {
            display: table;
            margin: 0 auto;
        }

        .content-show:before {
            content: none !important;
        }

        .btn-section li {
            margin: 0 10px;
        }

        .table-text-content:before {
            position: absolute;
            content: "\f041";
            color: #fff;
            left: 0;
            font-family: FontAwesome;
        }

        .btn-section button {
            color: #fff;
            border-color: #fff;
        }

            .btn-section button:hover {
                border-color: #00c292;
            }

        @media (max-width: 480px) 
        {
            .btn-section li {
                margin: 0 4px;
            }

                .btn-section li .btn-rounded {
                    padding: 7px 13px !important;
                }

            .table-content ul {
                float: left;
                width: 100%;
            }

            .table-content .text-left {
                text-align: left !important;
            }

            .table-content .text-right {
                float: none;
                text-align: left !important;
            }

            ul.btn-section {
                float: none !important;
                width: auto !important;
            }

            .table-content ul li p {
                font-size: 12px;
            }

            .btn-section {
                padding-top: 40px !important;
                padding-bottom: 0 !important;
            }
        }
    </style>
    <!-- ============================================================== -->
        <!-- Page wrapper  -->
        <!-- ============================================================== -->
                <!-- Row -->
               
                  <div class="table-main-warp">
                    <div class="row">
                        
                        <%
                            If objFunction.CheckDataSet(dstJobList) Then

                                For i = 0 To dstJobList.Tables(0).Rows.Count - 1
                                    'Dim strclass As String = "card bg-primary"
                                    'If objFunction.ReturnString(dstJobList.Tables(0).Rows(i)("Status")) <> "Paid" Then
                                    '    strclass = "card bg-info"
                                    'End If
                                    %>
                        <% objBEJobsheet.JOBID = dstJobList.Tables(0).Rows(i)("JobId")%>
                                     <% dstJobSheet = (New clsDLJobsheet()).GetJobSheetDetailsByJobid(objBEJobsheet)%>
                                          <% Dim strclass As String = "card bg-info"%>

                                    <% If objFunction.CheckDataSet(dstJobSheet) Then
                                            strclass = "card bg-primary"
                                        Else
                                            strclass = "card bg-info"
                                        End If
               %>
                    <!-- Column -->
                    <div class="col-lg-3 col-md-6">
                        <div class="<%=strclass %>" style="height: 410px;">
                            <div class="col-10">
                        <div class="card">
                            <div class="card-body">
                                <div class="table-content">
                                    <h2><%= dstJobList.Tables(0).Rows(i)("Name") %></h2>
                                    <p class="table-text-content"><%= dstJobList.Tables(0).Rows(i)("address1") %></p>
                                    <p class="table-text-content content-show"><%= dstJobList.Tables(0).Rows(i)("address2") %></p>
                                    <p class="table-text-content content-show"><%= dstJobList.Tables(0).Rows(i)("address3") %></p>

                                    <ul>
                                        <li class="text-left"><p><b>FF Ref:</b> <%= dstJobList.Tables(0).Rows(i)("Jobnumber") %></p></li>
                                        <li class="text-right"><p>Appliance: <%= dstJobList.Tables(0).Rows(i)("Appliance") %></p></li>
                                    </ul>
                                    <h3>Fault:</h3>
                                    <p style="height:200px;"><%= dstJobList.Tables(0).Rows(i)("Fault") %></p>
                                    <p>Please fix ASAP.</p>
                                     <ul class="btn-section" style="margin-top:-35px;">
                                        <li><button type="button" class="btn btn-outline-success btn-rounded" id="btnMove" onclick="return setSortOrderIdInCookie('<%= dstJobList.Tables(0).Rows(i)("SortOrder") %>','<%= dstJobList.Tables(0).Rows(i)("JobId") %>') "><i class="fa fa-arrow-up"></i> Move Up</button></li>
                                      <li><button type="button" class="btn btn-outline-success btn-rounded" id="btnJob" onclick="return GetRedirectWithId('<%= dstJobList.Tables(0).Rows(i)("JobId") %>');"><i class="fa fa-arrow-up"></i> Start Job</button></li>

                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                        </div>
                    </div>
                    <!-- Column -->
           <%
                    Next

                End If
    %>         
                   
                   
                </div>
                </div>                   
       
    <script type="text/javascript">

           function GetRedirectWithId(Id)
            {
                    var doaction = "GetJobSheetId";
                    $.post('GetAjaxData.aspx', { DoAction: doaction, JobID: Id }, function (responseText)
                    {
                        if (responseText.toString() != "Error")
                        {
                            ShowPopup("This Job Sheet Has Already Been Added.", "success");
                        }
                        else
                        {
                            location.href = "job_sheet.aspx?JobId=" + Id;
                        }
                    });
                }         function setSortOrderIdInCookie(Id,JobID) {
              if (Id != "" && parseInt(Id) > 0) {
                  var doaction = "setSortOrderIdInCookie";
                  $.post('GetAjaxData.aspx', { DoAction: doaction, Id: Id, JobID: JobID }, function (responseText) {
                      var Result = responseText.toString();
                      if (Result == "Success")
                      {
                          location.href = "Index-mobile.aspx"
                      }
                  else {
                          //ShowPopup("Sorry You are Trying To Moveup The First One.Try From Second One.", "error");
                          ShowPopupBlank("Sorry You are Trying To Moveup The First One.Try From Second One.");
                     
                  }
                  });
          }
          else {
                  //ShowPopup("Sorry You are Trying To Moveup The First One.Try From Second One.", "error");
                  ShowPopupBlank("Sorry You are Trying To Moveup The First One.Try From Second One.");

          }
          }
      </script>
                <!-- ============================================================== -->
                <!-- End PAge Content -->
                <!-- ============================================================== -->
           
        <!-- ============================================================== -->
        <!-- End Page wrapper  -->
        <!-- ============================================================== -->
    
</asp:Content>
