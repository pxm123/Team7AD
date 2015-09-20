﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClerkSupplierTenderManagePengxiaomeng.aspx.cs" Inherits="LogicUniv1._1.webpage.stockClerk.ClerkSupplierTenderManagePengxiaomeng" EnableEventValidation="false"%>

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

    
	<form id="form1" runat="server">
        
	<div class="templatemo-container">
		<div class="col-lg-3 col-md-3 col-sm-3  black-bg left-container" id="leftlayer">
			<h1 class="logo-left hidden-xs margin-bottom-60" style="color:white">Logic</h1>			
			<div class="tm-left-inner-container">
			<ul class="nav nav-stacked templatemo-nav">
				  <li><a href="ClerkManageRequisition.aspx"><i class="fa fa-file-word-o fa-medium"></i>Manage Requisition</a></li>
				  <li><a href="ClerkInventory.aspx"><i class="fa fa-shopping-cart fa-medium"></i>Inventory</a></li>
                 <li><a href="Reorder.aspx"><i class="fa fa-file-word-o fa-medium"></i>Purchase Order</a></li>  
                <li><a href="ClerkRetrivalForm.aspx"  ><i class="fa fa-search-plus fa-medium"></i>Retrieve Form</a></li>
                  <li><a href="ViewCurrentPendingByItems.aspx"><i class="fa fa-search-plus fa-medium"></i>Pending Form</a></li>
                  <li><a href="CheckCurrentDisbursementList.aspx"><i class="fa fa-comments-o fa-medium"></i>Disbursement</a></li>
				  <li><a href="ClerkReportDiscrepancy.aspx"><i class="fa  fa-exclamation-triangle fa-medium"></i>Discrepancy</a></li>
				  <li><a href="ClerkMainSupplierPengxiaomeng.aspx" class="active"><i class="fa fa-reply-all fa-medium"></i>Manage Supplier</a></li>
                  
				</ul>
			</div>

		</div> <!-- left section -->
        <div class="copyrights">Collect from <a href="http://www.mycodes.net/" ></a></div>                    
<div class="col-lg-9 col-md-9 col-sm-9  white-bg right-container" id="rightlayer">
			<h1 class="logo-right hidden-xs margin-bottom-60">University</h1>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Supplier Id:" Font-Size="Large" Height="19px" style="margin-top: 0px" Width="122px"></asp:Label><asp:Label ID="Label2" runat="server" Text="Label" Font-Size="Large" Height="16px" Width="115px"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Supplier Name:" Font-Size="Large" Height="25px" Width="134px"></asp:Label><asp:Label ID="Label4" runat="server" Text="Label" Font-Size="Large" Height="25px" Width="275px"></asp:Label>
            <br />   
             <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;     
            <asp:TextBox ID="TextBox1" runat="server" Height="33px" Width="360px" style="margin-left:auto"></asp:TextBox>
            <asp:Button ID="search" runat="server" CssClass="btn btn-info" OnClick="search_Click" Text="Search" Width="83px" />
            
            <br />
       
            <%-- BootStrap popup wind --%>
            <div class="tm-right-inner-container">
                  <asp:Label ID="Label5" runat="server" ForeColor="Red"></asp:Label>
                  <br />
                 <asp:GridView ID="GridView1" runat="server" AllowPaging="True"  OnPageIndexChanging="GridView1_PageIndexChanging" Width="694px" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table table-striped table-bordered table-condensed">
                     <Columns>
                         <asp:BoundField DataField="Itemdescription" HeaderText="Itemdescription" />
                         <asp:BoundField DataField="itemid" HeaderText="Item Number" />
                         <asp:BoundField DataField="Unit" HeaderText="Unit" />
                         <asp:BoundField DataField="price" HeaderText="Existing Tender Price" />
                         <asp:CommandField ShowSelectButton="True" HeaderText="Update New Price" SelectText="Update" />
                     </Columns>
                     <EditRowStyle Height="35px" />
                     <HeaderStyle Height="35px" />
            </asp:GridView>
                <div> 
               <asp:Button ID="back" runat="server" CssClass="btn btn-info" OnClick="back_Click" Text="Back" Width="85px" /> 
              </div>
           

<%-- BootStrap popup wind --%>
        

<div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" id="exampleModalLabel">Update Price</h4>
      </div>
      <div class="modal-body">
       <%-- <form>--%>
          <div class="form-group">
            <label for="recipient-name" class="control-label">Item Description:</label>
            <asp:TextBox ID="ItemDescription" class="form-control" runat="server" Enabled="False" Width="164px"></asp:TextBox>
          </div>
          <div class="form-group">
             <label for="recipient-name" class="control-label">Item Code:</label>
            <asp:TextBox ID="ItemCode" class="form-control" runat="server" Enabled="False" Width="200px"></asp:TextBox>
          </div>
            <div class="form-group">
             <label for="recipient-name" class="control-label">Unit:</label>
            <asp:TextBox ID="Unit" class="form-control" runat="server" Enabled="False" Width="235px"></asp:TextBox>
          </div>
            <div class="form-group">
             <label for="recipient-name" class="control-label">Exisiting Price:</label>
            <asp:TextBox ID="ExisitingPricer" class="form-control" runat="server" Enabled="False" Width="175px"></asp:TextBox>
          </div>
             <div class="form-group">
             <label for="recipient-name" class="control-label">New Price:</label>
            <asp:TextBox ID="NewPrice" class="form-control" runat="server" Width="243px"></asp:TextBox>
         </div>
       <%-- </form>--%>
      
      <div class="modal-footer">
     <asp:Button ID="Close" class="btn btn-default" data-dismiss="modal" runat="server" Text="Close" />
     <asp:Button ID="Confirm" class="btn btn-primary" runat="server" Text="Confirm" CssClass="btn btn-primary" OnClick="Confirm_Click" />
      </div>
    </div>
  </div>
</div>


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
		<!-- right section -->
        </div>
    </form>
        <script>
    $(function () {
        console.log(window.innerHeight);
        var height = (window.innerHeight);
                console.log(height);
                document.getElementById("leftlayer").setAttribute("style", "height:" + height + "px");
                document.getElementById("rightlayer").setAttribute("style", "height:" + height + "px");
            });
</script>

</body>
    </html>