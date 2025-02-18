<%@ Page Language="vb" aspcompat=true AutoEventWireup="false" Codebehind="sys_mobilemenu.aspx.vb" Inherits="srx.sys_mobilemenu" %>
<%@ Register TagPrefix="web" Namespace="WebChart" Assembly="WebChart" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<style>
			p {
				margin: 0.1em
			}

			.display-middle {
				position: absolute;
				top: 0%;
				left: 50%;
				transform: translate(-50%,-50%);
				-ms-transform: translate(-50%,-50%);
			}
			#tblPOModule td {
				padding-top: 0.01px;
  				padding-bottom: 0.01px;
			}

			.bg-image {
				/* The image used */
				background-image: url("./images/image_background_main.jpg");
				 /* Add the blur effect */
				filter: blur(1px);
				-webkit-filter: blur(1px);
				
				/* Full height */
				height: 100%; 
				
				/* Center and scale the image nicely */
				background-position: center;
				background-repeat: no-repeat;
				background-size: cover;
			}

			/* Position text in the middle of the page/image */
			.bg-text {
				background-color: rgb(0,0,0); /* Fallback color */
				background-color: rgba(0,0,0, 0.5); /* Black w/opacity/see-through */
				color: white;				
				position: absolute;
				top: 27%;
				left: 50%;
				transform: translate(-50%, 3%);
				z-index: 1;
				width: 60%;			
				padding: 20px;	
				text-align: center;
			}

			html, body {
				height: 100%;
			}

		</style>
	</HEAD>
	<body>		
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<div class="bg-image">			
		</div>		
		
		<FORM id="Form1" method="post" runat="server">
			
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main bg-text w3-mobile">				
				
				<div style="display:none">
					<a href="#"><IMG style="WIDTH: 200px;" src="images/company_logo.png"></a>
				</div>
				
				<div style="display:none">
					<hr class="w3-bottombar w3-border-deep-purple">
				</div>				
				
				<div class="w3-row-padding w3-margin-bottom">
					<div class="w3-quarter">
						<div class="w3-container" runat="server" id="divPO">
							<div class="w3-display-container toggle-div">
								<IMG style='WIDTH: 100%' src='./images/purchase_order_image.png'>							
								<span class="w3-center w3-text-white w3-small w3-responsive">Purchase Order</span>
								<div id="purchase_order" class="display-middle w3-cell toggle-content" style="display: none;">
									<asp:table id="tblPOModule" runat="server" CellPadding="0" Width="100%"></asp:table>									
								</div>
							</div>
						</div>
					</div>
					<div class="w3-quarter">
						<div class="w3-container" runat="server" id="divReceiving">
							<div class="w3-display-container toggle-div">
								<IMG style='WIDTH: 100%' src='./images/receiving_image.png'>								
								<span class="w3-center w3-text-white w3-small w3-responsive">Receiving</span>
								<div id="receiving" class="display-middle w3-cell toggle-content" style="display: none;">									
									<asp:table id="tblReceivingModule" runat="server" CellPadding="0" Width="100%"></asp:table>
								</div>
							</div>
						</div>
					</div>
					<div class="w3-quarter">
						<div class="w3-container" runat="server" id="divInventory">
							<div class="w3-display-container toggle-div">
								<IMG style='WIDTH: 100%' src='./images/inventory_image.png'>							
								<span class="w3-center w3-text-white w3-small w3-responsive">Inventory</span>
								<div id="inventory" class="display-middle w3-cell toggle-content" style="display: none;">
									<asp:table id="tblInventoryModule" runat="server" CellPadding="0" Width="100%"></asp:table>
								</div>
							</div>
						</div>
					</div>
					<div class="w3-quarter">
						<div class="w3-container" runat="server" id="divSales">
							<div class="w3-display-container toggle-div">
								<IMG style='WIDTH: 100%' src='./images/cashregister_image.png'>							
								<span class="w3-center w3-text-white w3-small w3-responsive">Sales</span>
								<div id="sales" class="display-middle w3-cell toggle-content" style="display: none;">
									<asp:table id="tblSalesModule" runat="server" CellPadding="0" Width="100%"></asp:table>
								</div>
							</div>
						</div>
					</div>
				</div>

				<div class="w3-row-padding w3-margin-bottom">
					<div class="w3-quarter">
						<div class="w3-container" runat="server" id="divDelivery">
							<div class="w3-display-container toggle-div">
								<IMG style='WIDTH: 100%' src='./images/delivery_image.png'>						
								<span class="w3-center w3-text-white w3-small w3-responsive">Delivery</span>
								<div id="delivery" class="display-middle w3-cell toggle-content" style="display: none;">
									<asp:table id="tblDeliveryModule" runat="server" CellPadding="0" Width="100%"></asp:table>
								</div>
							</div>
						</div>
					</div>
					<div class="w3-quarter">
						<div class="w3-container" runat="server" id="divCustomers">
							<div class="w3-display-container">
								<%response.write("<a href='ref_clients_list'><IMG style='WIDTH: 100%' src='./images/customers_image.png'></a>")%>
								<span class="w3-center w3-text-white w3-small w3-responsive">Customers</span>								
							</div>
						</div>
					</div>
					<div class="w3-quarter">
						<div class="w3-container" runat="server" id="divReports">
							<div class="w3-display-container">
								<%response.write("<a href='sys_reports'><IMG style='WIDTH: 100%' src='./images/reports_image.png'></a>")%>
								<span class="w3-center w3-text-white w3-small w3-responsive">Reports</span>								
							</div>
						</div>
					</div>
					<div class="w3-quarter">
						<div class="w3-container" runat="server" id="divReferences">
							<div class="w3-display-container">
								<%response.write("<a href='sys_references'><IMG style='WIDTH: 100%' src='./images/reference_image.png'></a>")%>
								<span class="w3-center w3-text-white w3-small w3-responsive">References</span>							
							</div>
						</div>
					</div>
				</div>

				<div class="w3-row-padding w3-margin-bottom">
					<div class="w3-quarter">
						<div class="w3-container" runat="server" id="divBudget">
							<div class="w3-display-container toggle-div">
								<IMG style='WIDTH: 100%' src='./images/budget_image.png'>
								<span class="w3-center w3-text-white w3-small w3-responsive">Budget Requests</span>
								<div id="budget" class="display-middle toggle-content" style="display:none;">
									<asp:table id="tblBudgetModule" runat="server" CellPadding="0" Width="100%"></asp:table>
								</div>
							</div>
						</div>
					</div>
					<div class="w3-quarter">												
						<div class="w3-container" runat="server" id="divPayables">
							<div class="w3-display-container toggle-div">
								<IMG style='WIDTH: 100%' src='./images/expenses_image.png'>
								<span class="w3-center w3-text-white w3-small w3-responsive">Payables</span>
								<div id="payables" class="display-middle toggle-content" style="display:none;">
									<asp:table id="tblPayablesModule" runat="server" CellPadding="0" Width="100%"></asp:table>
								</div>
							</div>
						</div>																								
					</div>	
					<div class="w3-quarter">
						<div class="w3-container" runat="server" id="divReceivables">
							<div class="w3-display-container">
								<%response.write("<a href='inv_payments_list'><IMG style='WIDTH: 100%' src='./images/receivables_image.png'></a>")%>
								<span class="w3-center w3-text-white w3-small w3-responsive">Receivables</span>								
							</div>
						</div>
					</div>
					<div class="w3-quarter" style="display:none">																	
						<div class="w3-container" runat="server" id="divProjects">
							<div class="w3-display-container">
								<%response.write("<a href='inv_projects_list'><IMG style='WIDTH: 100%' src='./images/project_image.png'></a>")%>								
								<span class="w3-center w3-text-white w3-small w3-responsive">Project Mgmt.</span>								
							</div>
						</div>																														
					</div>
					<div class="w3-quarter">

					</div>
				</div>												
			</div>
		
		</FORM>
		<script src="js/MyJS.js"></script>
		<script>

			$(document).ready(function() {
				// Set a value in localStorage
				localStorage.setItem('homepage', 'DEFAULT');
			});

			// Get all target divs
			var divs = document.querySelectorAll('.toggle-div');

			// Add click event listener to each target div
			divs.forEach(function(div) {
			div.addEventListener('click', function() {
				// Toggle visibility of clicked div
				var isVisible = this.querySelector('.toggle-content').style.display === 'block';
				this.querySelector('.toggle-content').style.display = isVisible ? 'none' : 'block';
			});
			});

			// Add click event listener to document object
			document.addEventListener('click', function(event) {
			// Check if click happened outside of target divs
			var isOutsideDivs = true;
			divs.forEach(function(div) {
				if (div.contains(event.target)) {
				isOutsideDivs = false;
				}
			});

			// Hide all visible divs if necessary
			if (isOutsideDivs) {
				divs.forEach(function(div) {
				div.querySelector('.toggle-content').style.display = 'none';
				});
			}
			});
		</script>		  
		
	</body>
</HTML>
