<%@ Page Language="vb" aspcompat="true" EnableEventValidation="false" AutoEventWireup="true" Codebehind="item.aspx.vb" Inherits="srx.item" %>

<!DOCTYPE html>
<html>
<head>
<title>EMS Shop | Item</title>
<!-- #include file ="html\ShopMeta.html" -->
<style>
	.imagezoom-view {
		background-color: #fff !important; 
	}
</style>
</head>
<body>
	
	<!-- #include file ="html\ShopTopMenu.html" -->	
	
		<!--breadcrumbs-->
		<div class="breadcrumbs w3-large">
			<div class="container">
				<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
					<li><a href="sys_home"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
					<li class="active"><asp:label id="lblItemName" runat="server"></asp:label></li>
				</ol>
			</div>
		</div>
		<!--//breadcrumbs-->
		<!--item-->
		<div class="single">
			<div class="container">
				<div class="single-info">		
					<div class="col-md-6 single-top wow fadeInLeft animated" data-wow-delay=".5s">	
						<div class="flexslider">
							<ul class="slides">
								<li data-thumb="images/SKU1000001.png">
									<div class="thumb-image"> 
										<span id="Div1" runat="server"></span>										
									</div>
								</li>								
							</ul>
						</div>
					</div>
					<div class="col-md-6 single-top-left simpleCart_shelfItem wow fadeInRight animated" data-wow-delay=".5s">
						<h3><asp:label id="lblProductName" runat="server"></asp:label></h3>
						<br>
						<h6 class="item_price">							
							<span id="del" runat="server"><asp:label id="lblItemOrigPrice" runat="server"></asp:label></span>													
							&#8369;<asp:label id="lblItemPriceShow" runat="server"></asp:label>
							<asp:label id="lblItemPrice" runat="server" Visible="False"></asp:label>
						</h6>			
						<p>Etiam faucibus viverra libero vel efficitur. Ut semper nisl ut laoreet ultrices. Maecenas dictum arcu purus, sit amet volutpat purus viverra sit amet. Quisque lacinia quam sed tortor interdum, malesuada congue nunc ornare. Cum sociis natoque penatibus et magnis dis parturient montes</p>						
						<div class="clearfix"> </div>
						<div class="quantity">
							<asp:panel id="panelQty" runat="server">
								<p class="qty w3-xlarge"> Qty : </p>							
								<asp:textbox id="txtQty" runat="server" type="number" min="1" width="85px" CssClass="item_quantity w3-large w3-text-black w3-border w3-border-blue">1</asp:textbox>
								&nbsp;<asp:label id="lblSOHShow" runat="server" CssClass="w3-medium"></asp:label>&nbsp;stocks available
							</asp:panel>							
							<div style="display:none">
								<asp:label id="lblSOH" runat="server" CssClass="w3-medium"></asp:label>
							</div>							
						</div>
						<div class="btn_form">							
							<asp:button id="btnAddToCart" runat="server" CssClass="add-cart w3-btn w3-blue item_add" Text="ADD TO CART"></asp:button>							
							<asp:label id="lblOutOfStocks" runat="server" CssClass="w3-text-red w3-xlarge" Text="New stocks will be arriving soon."></asp:label>
						</div>
					</div>
				   <div class="clearfix"> </div>
				</div>
				<!--collapse-tabs-->
				<div class="collpse tabs">
					<div class="panel-group collpse" id="accordion" role="tablist" aria-multiselectable="true">
						<div class="panel panel-default wow fadeInUp animated" data-wow-delay=".5s">
							<div class="panel-heading" role="tab" id="headingOne">
								<h4 class="panel-title">
									<a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
										additional information
									</a>
								</h4>
							</div>
							<div id="collapseOne" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
								<div class="panel-body">
									Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
								</div>
							</div>
						</div>						
					</div>
				</div>
				<!--//collapse -->				
			</div>
		</div>
		<!--//item-->
	
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

		$(document).ready(function() {
			// Get the total number of pages
			var soh = parseInt($('#lblSOH').text());

			// Set the maximum value for the input field
			$('#txtQty').attr('max', soh);

			$('#txtQty').attr('inputmode', 'numeric').on('keydown input', function(e) {
				var currentValue = parseInt($(this).val());

				// Allow the following keys: left arrow, right arrow, and enter
				if ([37, 39, 13, 46, 8].indexOf(e.keyCode) !== -1) {
					return;
				}
				
				// Only allow numeric keys
				if (e.keyCode < 48 || e.keyCode > 57) {
					e.preventDefault();
					return;
				}

				if (currentValue > soh) {
					$(this).val(soh);
				}

				if (currentValue === 0 || isNaN(currentValue)) {
					$(this).val(1);
				}
			});

			// Handle input via the up and down arrows
			$('#txtQty').on('keydown', function(e) {
				if (e.keyCode === 38) { // up arrow
					e.preventDefault();
					var currentValue = parseInt($(this).val());
					if (currentValue < soh) {
						$(this).val(currentValue + 1);
					}
				} else if (e.keyCode === 40) { // down arrow
					e.preventDefault();
					var currentValue = parseInt($(this).val());
					if (currentValue > 1) {
						$(this).val(currentValue - 1);
					}
				}
			});
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
</body>
</html>
