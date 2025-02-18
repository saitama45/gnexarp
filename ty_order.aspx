
<%@ Page CodeBehind="ty_order.aspx.vb" Language="vb" AutoEventWireup="false" Inherits="srx.ty_order" %>
<!DOCTYPE html>
<html>
<head>
<title>EMS Shop</title>
<!-- #include file ="html\ShopMeta.html" -->

</head>
<body>
	<!-- #include file ="html\ShopTopMenu.html" -->	
	
	<!--breadcrumbs-->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="sys_home"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Thank You</li>
			</ol>
		</div>
	</div>
	<!--//breadcrumbs-->
	
	<!--body-->
	<div class="cart-items">
		<div class="container w3-center">
			<h3 class="wow fadeInUp animated" data-wow-delay=".5s">Your Order Has Been Received</h3>
			<h4>Thank you for shopping with us</h4>
			<br>
			<h5>Your order no. is <b><asp:label id="lblOrderNo" runat="server"></asp:label></b></h5>
			<br>
			<h5>You should be receiving an automated email with details of your order.</h5>
			<br>
			<asp:button id="btnContinueShop" runat="server" CssClass="w3-btn w3-border-0 w3-large w3-blue" Text="Continue Shopping"></asp:button>			
			
		</div>
		
	</div>
	<!--//body-->	
	<br/>
	<!-- #include file ="html\ShopFooterMenu.html" -->

	<!--search jQuery-->
	<script src="js/main.js"></script>
	<!--//search jQuery-->
	<!--smooth-scrolling-of-move-up-->
	<script type="text/javascript">
		$(document).ready(function() {
		
			var defaults = {
				containerID: 'toTop', // fading element id
				containerHoverID: 'toTopHover', // fading element hover id
				scrollSpeed: 1200,
				easingType: 'linear' 
			};
			
			$().UItoTop({ easingType: 'easeOutQuart' });
			
		});

		$(function() {
			var form = $("#Form1");
			var searchBox = $("#txtSearch");

			searchBox.keypress(function(event) {
				if (event.keyCode === 13) { // 13 is the "Enter" key code
					event.preventDefault(); // prevent default form submission
					form.submit(); // submit the form programmatically
				}
			});
		});
	</script>
	<!--//smooth-scrolling-of-move-up-->
	<!--Bootstrap core JavaScript
    ================================================== -->
    <!--Placed at the end of the document so the pages load faster -->
	
    <script src="js/bootstrap.js"></script>
	<script src="https://smtpjs.com/v3/smtp.js"></script>	
	
</body>
</html>