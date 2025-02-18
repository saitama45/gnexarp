<%@ Page Language="vb" aspcompat="true" EnableEventValidation="false" AutoEventWireup="true" Codebehind="item_search.aspx.vb" Inherits="srx.item_search" %>

<!DOCTYPE html>
<html>
<head>
<title>EMS Shop | Item Search</title>
<!-- #include file ="html\ShopMeta.html" -->
</head>
<body>
	
	<!-- #include file ="html\ShopTopMenu.html" -->	
	
		<!--breadcrumbs-->
		<div class="breadcrumbs w3-large">
			<div class="container">
				<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
					<li><a href="sys_home"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
					<li class="active">Search Results for: <asp:label id="lblName" runat="server"></asp:label></li>
				</ol>
			</div>
		</div>
		<!--//breadcrumbs-->
		<!--products-->
		<div class="new">
			<div class="container">
				<div class="w3-row w3-mobile">
					<span id="Div1" runat="server"></span>					
				</div>
				<br>
				<div class="w3-center w3-bar">
					<div class="w3-bar">	
						<asp:button runat="server" id="btnPrev" CssClass="w3-button w3-bar-item w3-border w3-deep-orange" Text="&laquo;" Enabled="False"></asp:button>
						<div class="w3-bar-item">
							<span>Page&nbsp;</span><b><asp:textbox runat="server" id="txtCurrentPage" CssClass="w3-center" width="30px" Autopostback="True">1</asp:textbox></b>&nbsp;of&nbsp;<asp:label runat="server" id="lblPageTotal">2</asp:label>
						</div>						
						<asp:button runat="server" id="btnNext" CssClass="w3-button w3-bar-item w3-border w3-deep-orange" Text="&raquo;"></asp:button>														
					</div>
				</div>				
			</div>			
		</div>	
	
	<br/>
	<!--//products-->

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

		// prevent users from Typing letters | Numbers only
		$(document).ready(function() {
			// Get the total number of pages
			var totalPages = parseInt($('#lblPageTotal').text());

			// Set the maximum value for the input field
			$('#txtCurrentPage').attr('max', totalPages);

			$('#txtCurrentPage').attr('inputmode', 'numeric').on('keydown input', function(e) {
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
				
				if (currentValue > totalPages) {
					$(this).val(totalPages);
				}

				if (currentValue === 0 || isNaN(currentValue)) {
					$(this).val(1);
				}
			});
		});

		$(document).ready(function() {
			$("#txtCurrentPage").click(function() {
				$(this).select();
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
