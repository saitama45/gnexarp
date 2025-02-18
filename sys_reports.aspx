<%@ Page Language="vb" aspcompat=true AutoEventWireup="false" Codebehind="sys_reports.aspx.vb" Inherits="srx.sys_reports" %>
<%@ Register TagPrefix="web" Namespace="WebChart" Assembly="WebChart" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<style>
			body::after {
			/* background: url(./images/reports_image.jpg); */
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
		</style>
	</HEAD>
	<body>		
		<!-- #include file ="html\BodyColor.html" -->
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<FORM id="Form1" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main" style="MARGIN-TOP: 43px">
				<!-- Header -->
				<div style="MARGIN-BOTTOM: 50px; PADDING-TOP: 20px">
					<h5 class="w3-left"><b><i class="fab fa-elementor"></i>&nbsp;Reports</b></h5>
				</div>
				<!-- End Header -->
				<hr class="w3-bottombar w3-border-deep-purple w3-mobile">
				<!-- Product grid -->				
				<div class="w3-row">
					<div class="w3-quarter">
						<div class="w3-container">
							<h5 class="w3-bottombar w3-border-green w3-center"><b>Inventories</b></h5>
							<span id="spanInventories" runat="server"></span>
						</div>
					</div>
					<div class="w3-quarter">
						<div class="w3-container">
							<h5 class="w3-bottombar w3-border-green w3-center"><b>Accounts</b></h5>
							<span id="spanAccounts" runat="server"></span>							
						</div>
					</div>
					<div class="w3-quarter">
						<div class="w3-container">
							<h5 class="w3-bottombar w3-border-green w3-center"><b>Sales / Expenses</b></h5>
							<span id="spanSales" runat="server"></span>
						</div>
					</div>
					<div class="w3-quarter">
						<div class="w3-container">
							<h5 class="w3-bottombar w3-border-green w3-center"><b>Financials</b></h5>							
							<span id="spanFinancials" runat="server"></span>
						</div>
					</div>
				</div>														
				<!-- End Grid -->
				<hr>
			</div>
		</FORM>
		<script src="js/MyJS.js"></script>
	</body>
</HTML>
