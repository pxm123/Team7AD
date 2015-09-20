﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClerkHistoryLogPengxiaomeng.aspx.cs" Inherits="LogicUniv1._1.webpage.stockClerk.ClerkHistoryLogPengxiaomeng" %>

<!DOCTYPE html>

<html>
<head>
	
	<title>Logic Unviersity Stationery Inventory System</title>
	<meta name="keywords" content="" />
	<meta name="description" content="" />
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css">
	<link href="../css/font-awesome.min.css" rel="stylesheet" type="text/css">
	<link href="../css/templatemo_style.css" rel="stylesheet" type="text/css">	
    <script src="../js/jquery-1.11.1.min.js" type="text/javascript"></script>
    <script src="../js/jquery-ui-1.10.2.custom.min.js" type="text/javascript"></script>
    <!-- bootstrap -->
    <link href="../css/bootstrap/bootstrap.css" rel="stylesheet" />

    <!-- libraries -->
    <link href="../css/lib/jquery-ui-1.10.2.custom.css" rel="stylesheet" type="text/css" />
    <link href="../css/lib/font-awesome.css" type="text/css" rel="stylesheet" />
    <!-- global styles -->
    <link rel="stylesheet" type="text/css" href="../css/compiled/layout.css">
    <link rel="stylesheet" type="text/css" href="../css/compiled/elements.css">
    <link rel="stylesheet" type="text/css" href="../css/compiled/icons.css">
    <!-- this page specific styles -->
    <link rel="stylesheet" href="../css/compiled/index.css" type="text/css" media="screen" />
    	<!-- scripts -->
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/jquery-ui-1.10.2.custom.min.js"></script>
    <!-- knob -->
    <script src="../js/jquery.knob.js"></script>
    <!-- flot charts -->
    <script src="../js/jquery.flot.js"></script>
    <script src="../js/jquery.flot.stack.js"></script>
    <script src="../js/jquery.flot.resize.js"></script>
    <script src="../js/theme.js"></script>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css" />
    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <script>
        $(function () {

            $("#<%=startdate.ClientID %>").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                showOn: 'button',
                buttonImage: '../../Images/Date.png',
                buttonImageOnly: true,
                onClose: function (selectedDate) {
                    $("#<%=enddate.ClientID %>").datepicker("option", "minDate", selectedDate);
                }
                

            });

            $("#<%=enddate.ClientID %>").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                showOn: 'button',
                buttonImage: '../../Images/Date.png',
                buttonImageOnly: true,
                onClose: function (selectedDate) {
                    $("#<%=startdate.ClientID %>").datepicker("option", "maxDate", selectedDate);
                }
            });
        });
    </script>
</head>

<body>
    <header class="navbar navbar-inverse" role="banner">
        <ul class="nav navbar-nav pull-right hidden-xs">
            <li class="hidden-xs hidden-sm">
                <input class="search" type="text" />
            </li>
            <li class="notification-dropdown hidden-xs hidden-sm">
                <a href="#" class="trigger">
                    <i class="icon-warning-sign"></i>
                    <span class="count">8</span>
                </a>
                <div class="pop-dialog">
                    <div class="pointer right">
                        <div class="arrow"></div>
                        <div class="arrow_border"></div>
                    </div>
                    <div class="body">
                        <a href="#" class="close-icon"><i class="icon-remove-sign"></i></a>
                        <div class="notifications">
                            <h3>你有6条信息</h3>
                            <a href="#" class="item">
                                <i class="icon-signin"></i> 新用户注册
                                <span class="time"><i class="icon-time"></i> 13分钟前.</span>
                            </a>
                            <a href="#" class="item">
                                <i class="icon-signin"></i> 新用户注册
                                <span class="time"><i class="icon-time"></i> 18分钟前.</span>
                            </a>
                            <a href="#" class="item">
                                <i class="icon-envelope-alt"></i> 新消息来自Alejandra
                                <span class="time"><i class="icon-time"></i> 28分钟前.</span>
                            </a>
                            <a href="#" class="item">
                                <i class="icon-signin"></i> 新用户注册
                                <span class="time"><i class="icon-time"></i> 49分钟前.</span>
                            </a>
                            <a href="#" class="item">
                                <i class="icon-download-alt"></i> 新订单
                                <span class="time"><i class="icon-time"></i> 1天前.</span>
                            </a>
                            <div class="footer">
                                <a href="#" class="logout">查看所有消息</a>
                            </div>
                        </div>
                    </div>
                </div>
            </li>
            <li class="dropdown">
                <a href="#" class="dropdown-toggle hidden-xs hidden-sm" data-toggle="dropdown">
                    My Account
                    <b class="caret"></b>
                </a>
            </li>
                
            <li class="settings hidden-xs hidden-sm">
<a href="../LogoutPage.aspx" role="button">
                    <i class="icon-share-alt"></i>
                </a>
            </li>
        </ul>
    </header>

    
	<form id="form1" runat="server">
        
	<div class="templatemo-container">
<div class="col-lg-3 col-md-3 col-sm-3  black-bg left-container" id="leftlayer">
			<h1 class="logo-left hidden-xs margin-bottom-60" style="color:white">Logic</h1>			
			<div class="tm-left-inner-container">
			<ul class="nav nav-stacked templatemo-nav">
				  <li><a href="ClerkManageRequisition.aspx"><i class="fa fa-file-word-o fa-medium"></i>View Requisition</a></li>
				  <li><a href="ClerkInventory.aspx"><i class="fa fa-shopping-cart fa-medium"></i>Inventory</a></li>
                 <li><a href="Reorder.aspx"><i class="fa fa-file-word-o fa-medium"></i>Purchase Order</a></li>  
                <li><a href="ClerkRetrivalForm.aspx"  class="active"><i class="fa fa-search-plus fa-medium"></i>Retrieve Form</a></li>
                  <li><a href="ViewCurrentPendingByItems.aspx"><i class="fa fa-search-plus fa-medium"></i>Pending Form</a></li>
                  <li><a href="CheckCurrentDisbursementList.aspx"><i class="fa fa-comments-o fa-medium"></i>Disbursement</a></li>
				  <li><a href="ClerkReportDiscrepancy.aspx"><i class="fa  fa-exclamation-triangle fa-medium"></i>Discrepancy</a></li>
				  <li><a href="ClerkMainSupplierPengxiaomeng.aspx"><i class="fa fa-reply-all fa-medium"></i>Manage Supplier</a></li>
                 
				</ul>
			</div>

		</div> <!-- left section -->
        <div class="copyrights">Collect from <a href="http://www.mycodes.net/" >
            
            </a></div>
<div class="col-lg-9 col-md-9 col-sm-9  white-bg right-container" id="rightlayer">

			<h1 class="logo-right hidden-xs margin-bottom-60">University</h1>
            <div class="tm-right-inner-container" id="prelayer">
                <div>
            <asp:DropDownList ID="viewby" runat="server" OnSelectedIndexChanged="viewby_SelectedIndexChanged" ValidateRequestMode="Enabled" AutoPostBack="True" Height="26px" Width="130px" style="margin-left:auto">
                <asp:ListItem>View By Department</asp:ListItem>
                <asp:ListItem Selected="True">View By Item</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;            
            <asp:Button ID="CurrentWeek" runat="server" Text="Current Week" OnClick="CurrentWeek_Click" CssClass="btn btn-info" Height="30px" Width="164px" />
            <asp:RadioButtonList ID="Department" runat="server" Height="16px" Width="299px" AutoPostBack="True" OnSelectedIndexChanged="Department_SelectedIndexChanged1" Visible="False">
                <asp:ListItem>COMM</asp:ListItem>
                <asp:ListItem>CPSC</asp:ListItem>
                <asp:ListItem>ENGL</asp:ListItem>
                <asp:ListItem>REGR</asp:ListItem>
                <asp:ListItem>STORE</asp:ListItem>
                <asp:ListItem>ZOOL</asp:ListItem>
            </asp:RadioButtonList>
                    <br />
            <br />
            <asp:TextBox ID="startdate" runat="server" style="margin-left:auto" Width="120px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="TO"></asp:Label>
            <asp:TextBox ID="enddate" runat="server" Width="130px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Submit" Width="134px" CssClass="btn btn-info" Height="27px" />
            <br />
            <br />
                    <div id="Print">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True"  OnPageIndexChanging="GridView1_PageIndexChanging" Width="674px" CssClass="table table-striped table-bordered table-condensed">
                <EditRowStyle Height="35px" />
                <HeaderStyle Height="35px" />
            </asp:GridView>          
                    </div> 
                          <asp:Button ID="P" runat="server" Text="Print" Width="104px" OnClientClick="PrintGridView()" CssClass="btn btn-info"/> 
                    </div>
            </div>
    <footer>
					<p class="col-lg-3 col-md-3  templatemo-copyright">Copyright &copy; 2015 Logic University designed by NUS ISS SA 40 Team 7 </p>
					<p class="col-lg-9 col-md-9  templatemo-social">
						<a href="#"><i class="fa fa-facebook fa-medium"></i></a>
						<a href="#"><i class="fa fa-twitter fa-medium"></i></a>
						<a href="#"><i class="fa fa-google-plus fa-medium"></i></a>
						<a href="#"><i class="fa fa-youtube fa-medium"></i></a>
						<a href="#"><i class="fa fa-linkedin fa-medium"></i></a>
					</p>
				</footer>
       </div>
    </div>	
		<!-- right section -->
  </form>
     <script>
         $(function () {
             console.log(window.innerHeight);
             var height = $("#prelayer").height() + 500;
             console.log(height);
             document.getElementById("leftlayer").setAttribute("style", "height:" + height + "px");
             document.getElementById("rightlayer").setAttribute("style", "height:" + height + "px");
         });
    </script>

  <script>
      function PrintGridView() {
          // 打开一个新网页
          var newwindow = window.open('');

          // 将指定DIV中的内容写入该网页
          newwindow.document.write(document.getElementById('Print').innerHTML);
          newwindow.document.close();

          // 打印该网页
          newwindow.focus();
          newwindow.print();

          // 打印完毕后关闭该窗口
          newwindow.close();
          return;
      }
</script>

</body>
    </html>