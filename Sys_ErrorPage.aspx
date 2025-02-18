<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Sys_ErrorPage.aspx.vb" Inherits="srx.Sys_ErrorPage" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<link rel="stylesheet" href="css/w3.css">
		<link rel="stylesheet" href="css/w3-colors-win8.css">
		<!--  Desktop Favicons  -->
		<link rel="icon" type="image/png" href="./images/favicon_96x96.ico" sizes="96x96">
		<style>
			body {
				background-color: black !important; 
				color: white;
			}			

			h1 {
				color: red;
			}

			h6{
				color: red;
				text-decoration: underline;
			}
			
		</style>
	</HEAD>	
	<body>
		<div class="w3-display-middle">
			<h1 class="w3-jumbo w3-animate-top w3-center"><code>Access Denied</code></h1>
			<hr class="w3-border-white w3-animate-left" style="margin:auto;width:50%">
			<h3 class="w3-center w3-animate-right">You dont have permission to view this site.</h3>
			<h4 class="w3-center w3-animate-zoom">Click the <b><i class="fas fa-arrow-left"></i></b> arrow at your browser, or click the button below.</h4>
			<div class="w3-center w3-animate-zoom">
				<%response.write("<a class='w3-btn w3-win8-violet' href='sys_login'><span class='w3-text'>Go To Login Page</span></a>")%>
			</div>
			<h6 class="w3-center w3-animate-zoom">error code:403 forbidden</h6>
		</div>
	</body>
</HTML>
