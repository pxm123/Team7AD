<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockManagerDiscrepancyItemPengxiaomeng.aspx.cs" Inherits="LogicUniv1._1.WebForm2" %>

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

    <!-- bootstrap -->
    <link href="../css/bootstrap/bootstrap.css" rel="stylesheet" />
    <link href="../css/bootstrap/bootstrap-overrides.css" type="text/css" rel="stylesheet" />
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
    <script src="../js/jquery-1.11.1.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/jquery-ui-1.10.2.custom.min.js"></script>
    <!-- knob -->
    <script src="../js/jquery.knob.js"></script>
    <!-- flot charts -->
    <script src="../js/jquery.flot.js"></script>
    <script src="../js/jquery.flot.stack.js"></script>
    <script src="../js/jquery.flot.resize.js"></script>
    <script src="../js/theme.js"></script>
</head>
<body>
    <header class="navbar navbar-inverse" role="banner">
        <ul class="nav navbar-nav pull-right hidden-xs">
          
            <li class="dropdown">
                <a href="#" class="dropdown-toggle hidden-xs hidden-sm" data-toggle="dropdown">
                    Your Account
                    <b class="caret"></b>
                </a>
                <ul class="dropdown-menu">
                    <li><a href="personal-info.html">Personal Info</a></li>
                     <li><a href="personal-info.html">Setting</a></li>
                </ul>
            </li>
            <li class="settings hidden-xs hidden-sm">
<a href="../LogoutPage.aspx" role="button">
                    <i class="icon-share-alt"></i>
                </a>
            </li>
        </ul>
    </header>

    
	<form id="form2" runat="server">
        
	<div class="templatemo-container">
<div class="col-lg-3 col-md-3 col-sm-3  black-bg left-container" id="leftlayer">
			<h1 class="logo-left hidden-xs margin-bottom-60" style="color:white">Logic</h1>			
			<div class="tm-left-inner-container">
				<ul class="nav nav-stacked templatemo-nav">
				  <li><a href="index.html" class="active"><i class="fa fa-home fa-medium"></i>Discrepancy</a></li>
				</ul>
			</div>

		</div> <!-- left section -->
        <div class="copyrights">Collect from <a href="http://www.mycodes.net/" ></a></div>

<div class="col-lg-9 col-md-9 col-sm-9  white-bg right-container" id="rightlayer">


			<h1 class="logo-right hidden-xs margin-bottom-60">University</h1>
            
           
			<div class="tm-right-inner-container">
                <div> 

    <div style="height: 262px; width: 991px">
    
        <asp:GridView ID="GridView1" runat="server" Width="879px" CaptionAlign="Bottom" HorizontalAlign="Center" Font-Bold="False" Font-Italic="False" Font-Names="Cambria" Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" ShowFooter="True" CssClass="table table-striped table-bordered table-condensed">
            <EditRowStyle Height="35px" />
            <HeaderStyle Height="35px" />
        </asp:GridView>   
    </div>
    <asp:Button ID="Button1" runat="server" Text="Approve" style="margin-left:51%" OnClick="Button1_Click" CssClass="btn btn-success" Width="80px" />&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Reject" style="margin-left:10px" OnClick="Button2_Click" CssClass="btn btn-danger" />
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
            var height = (window.innerHeight)+200;
            console.log(height);
            document.getElementById("leftlayer").setAttribute("style", "height:" + height + "px");
            document.getElementById("rightlayer").setAttribute("style", "height:" + height + "px");
        });
</script>

</body>
    </html>


