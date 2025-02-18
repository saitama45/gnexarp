<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Sys_ExpiredPage.aspx.vb" Inherits="srx.Sys_ExpiredPage" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- Meta tag Keywords -->
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<meta charset="UTF-8" />			
		<!-- //Meta tag Keywords -->
		<!--/Style-CSS -->
		<link rel="stylesheet" href="css/2style.css" type="text/css" media="all" />
		<!--//Style-CSS -->
		<!-- font-awesome-icons -->
		<link href="css/2font-awesome.css" rel="stylesheet">
		<!-- //font-awesome-icons -->
		<link rel="stylesheet" href="css/w3.css">	
		<link rel="stylesheet" href="css/w3-colors-win8.css">	
		
		<!--  Desktop Favicons  -->
		<link rel="icon" type="image/png" href="./images/favicon_96x96.ico" sizes="96x96">

		<script src="js/jquery/3.6.0/jquery.min.js"></script>

		<style>
			body::after {
			/* background: url(./images/expired_page.jpg); */
			background-size: cover;
			content: "";
			opacity: 0.5;
			position: fixed;
			top: 0;
			bottom: 0;
			right: 0;
			left: 0;
			z-index: -1;   
			}

			.center {
				display: block;
				margin-left: auto;
				margin-right: auto;
				width: 70%;
			}
		</style>
		
	</HEAD>
	<body>
		
		<div class="w3-display-middle">
			<h1 class="w3-jumbo w3-animate-top w3-center"></h1>
			<!-- <div class="w3-center w3-animate-zoom">
				<a href="http://mykey.ph/" target="_blank"><IMG class="center" src="images/mykeyenterprise_logo.png"></a>
			</div>			 -->
			<hr class="w3-border-white w3-animate-left" style="margin:auto;width:50%">
			<h3 class="w3-center w3-animate-right">Your session has expired.</h3>
			<h4 class="w3-center w3-animate-zoom">You are now being redirected to the login page.</h4>
			<h2 id="countdown" class="w3-center"></h2>
			<!-- <div class="w3-center w3-animate-zoom">
				<%response.write("<a class='w3-btn w3-win8-blue' href='sys_home'><span class='w3-text'>Continue Shopping</span></a>")%>
			</div> -->
			<!-- <h6 class="w3-center w3-animate-zoom">error code:419 Page Expired</h6> -->
		</div>		

		<script type="text/javascript">					

			$(document).ready(function() {
				var countdown = 3; // Set the initial countdown value

				// Function to update the countdown value and redirect after 3 seconds
				function updateCountdown() {
					$('#countdown').text(countdown); // Display the current countdown value

					if (countdown === 0) {
					window.location.href = "sys_login"; // Replace with your login page URL
					} else {
					countdown--; // Decrease the countdown value by 1
					setTimeout(updateCountdown, 1000); // Call the function again after 1 second (1000 milliseconds)
					}
				}

				updateCountdown(); // Start the countdown
			});

		</script>
	</body>
</HTML>
