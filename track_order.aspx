
<%@ Page CodeBehind="track_order.aspx.vb" Language="vb" AutoEventWireup="false" Inherits="srx.track_order" %>
<!DOCTYPE html>
<html>
<head>
<title>EMS Shop</title>
<!-- #include file ="html\ShopMeta.html" -->
<!-- Bootstrap CSS -->

<!-- <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"
        integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous"> -->
<style>	

	.h6, h6 {
		font-size: 1rem !important;
	}
	
	.h1, .h2, .h3, .h4, .h5, .h6, h1, h2, h3, h4, h5, h6 {
		margin-bottom: .5rem !important;
		font-family: inherit !important;
		font-weight: 500 !important;
		line-height: 1.2 !important;
		color: inherit !important;
	}

	.text-muted {
		color: #6c757d!important;
	}

	.mb-0, .my-0 {
		margin-bottom: 0!important;
	}

	ul.timeline {
		list-style-type: none;
		position: relative;		
	}
	
	ul.timeline:before {
		content: '\2713';
		background: #d4d9df;
		display: inline-block;
		position: absolute;
		left: 29px;
		width: 2px;
		height: 100%;
		z-index: 400;
	}

	ul.timeline > li {
		margin: 20px 0;
		padding-left: 80px;
	}
	ul.timeline > li:before {
		content: '\2713';
		background: #fff;
		display: inline-block;
		position: absolute;
		border-radius: 50%;
		border: 0;
		left: 5px;
		width: 50px;
		height: 50px;
		z-index: 400;
		text-align: center;
		line-height: 50px;
		color: #d4d9df;
		font-size: 24px;
		border: 2px solid #d4d9df;
	}
	
	ul.timeline > li.active:before {
		content: '\2713';
		background: #28a745;
		display: inline-block;
		position: absolute;
		border-radius: 50%;
		border: 0;
		left: 5px;
		width: 50px;
		height: 50px;
		z-index: 400;
		text-align: center;
		line-height: 50px;
		color: #fff;
		font-size: 30px;
		border: 2px solid #28a745;
	}
	/* end timeline */
</style>
</head>
<body>
	<!-- #include file ="html\ShopTopMenu.html" -->	
	
	<!--breadcrumbs-->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="sys_home"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Track Order</li>
			</ol>
		</div>
	</div>
	<!--//breadcrumbs-->
	
	<!--body-->	
	  
	<div class="cart-items w3-padding" style="display: flex; justify-content: center; align-items: center;">
		
		<div class="card mt-4">
			<div class="card-body w3-mobile">				
				<div class="w3-bar">
					<h4 class="w3-container">Order No:</h4>
					<asp:textbox id="txtOrderNo" runat="server" CssClass="w3-input w3-border w3-bar-item w3-margin"></asp:textbox>					
					<asp:button id="btnTrack" runat="server" CssClass="w3-btn w3-blue w3-bar-item w3-margin" Text="Track"></asp:button>
				</div>
				<asp:panel id="panelTimeline" CssClass="w3-padding timeline" runat="server" Visible="True">
					<ul id="Div1" runat="server"></ul>					
				</asp:panel>				
			</div>
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