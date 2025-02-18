<%@ Register TagPrefix="web" Namespace="WebChart" Assembly="WebChart" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="sys_dashboard.aspx.vb" Inherits="srx.sys_dashboard" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<style>
			a {text-decoration: none;}
			LABEL.receivables { FONT-WEIGHT: bold; FONT-SIZE: 12px; width: 120px; display: inline-block;}
			SPAN.receivables {FONT-SIZE: 12px; Color: red; width: 120px; text-align: right; display: inline-block;}
			
			LABEL.undelivered_dr { FONT-WEIGHT: bold; FONT-SIZE: 12px; width: 120px; display: inline-block;}
			SPAN.undelivered_dr {FONT-SIZE: 12px; Color: red; width: 120px; text-align: right; display: inline-block;}

			LABEL.near_expiry_items { FONT-WEIGHT: bold; FONT-SIZE: 12px; width: 128px; display: inline-block;}
			SPAN.near_expiry_items {FONT-SIZE: 12px; Color: red; width: 112px; text-align: right; display: inline-block;}

			LABEL.critical_level_items { FONT-WEIGHT: bold; FONT-SIZE: 12px; width: 136px; display: inline-block;}
			SPAN.critical_level_items {FONT-SIZE: 12px; Color: red; width: 104px; text-align: right; display: inline-block;}

			LABEL.activeaccounts { FONT-WEIGHT: bold; FONT-SIZE: 12px; width: 120px; display: inline-block;}
			SPAN.activeaccounts {FONT-SIZE: 12px; Color: red; width: 120px; text-align: right; display: inline-block;}

			LABEL.inactiveaccounts { FONT-WEIGHT: bold; FONT-SIZE: 12px; width: 126px; display: inline-block;}
			SPAN.inactiveaccounts {FONT-SIZE: 12px; Color: red; width: 114px; text-align: right; display: inline-block;}

			LABEL.depleted_items { FONT-WEIGHT: bold; FONT-SIZE: 12px; width: 120px; display: inline-block;}
			SPAN.depleted_items {FONT-SIZE: 12px; Color: red; width: 120px; text-align: right; display: inline-block;}
		</style>
	</HEAD>
	<body>
		<!-- #include file ="html\BodyColor.html" -->
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<FORM id="Form1" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main">
				<!-- Header -->
				<div style="MARGIN-TOP: 65px;">	
					<b><i class="fas fa-chart-line"></i>&nbsp;Dashboard</b>
					<asp:dropdownlist id="ddlCompany" runat="server" Width="40%" CssClass="w3-input w3-text-small w3-mobile myddl" AutoPostBack="True"></asp:dropdownlist>
					<asp:dropdownlist id="ddlYear" runat="server" Width="10%" CssClass="w3-input w3-text-small w3-mobile myddl" AutoPostBack="True"></asp:dropdownlist>
				</div>
				<!-- End Header -->
				<hr class="w3-bottombar w3-border-deep-purple w3-mobile">
				<!-- Boxes -->
				<div class="w3-row-padding w3-container">
					<div class="w3-row-padding w3-margin-bottom">
						<div class="w3-quarter">
						  <div class="w3-container w3-blue w3-padding-16 w3-card-4">
							<div class="w3-left">
								<h4><b>SALES</b></h4>
							</div>						
							<div class="w3-clear"></div>
							<div class="w3-center">
								<h4><asp:label id="lblSales" runat="server"></asp:label>&nbsp;</h4>
							</div>
						  </div>
						</div>
						<div class="w3-quarter">
						  <div class="w3-container w3-red w3-padding-16 w3-card-4">
							<div class="w3-left">
								<h4><b>TARGET</b></h4>
							</div>						
							<div class="w3-clear"></div>
							<div class="w3-center">
								<h4><asp:label id="lblTarget" runat="server"></asp:label></h4>
							</div>
						  </div>
						</div>
						<div class="w3-quarter">
						  <div class="w3-container w3-amber w3-padding-16 w3-card-4">
							<div class="w3-left">
								<h4><b>% GAIN</b></h4>
							</div>						
							<div class="w3-clear"></div>
							<div class="w3-center">
								<h4><asp:label id="lblGain" runat="server"></asp:label></h4>
							</div>
						  </div>
						</div>					
						<div class="w3-quarter">
							<div class="w3-container w3-green w3-text-white w3-padding-16 w3-card-4">
							  <div class="w3-left">
								  <h4><b>GROSS PROFIT</b></h4>
							  </div>						
							  <div class="w3-clear"></div>
							  <div class="w3-center">
								  <h4><asp:label id="lblGrossProfit" runat="server"></asp:label></h4>
							  </div>
							</div>
						  </div>
					</div>
					<div class="w3-row-padding">
						<div class="w3-twothird">	
							<asp:label id="lblSerialHD" runat="server" Visible="False"></asp:label>					
							<P><LABEL><B>Sales YTD vs Target</B></LABEL><BR>
								<asp:datagrid id="DataGrid" runat="server" ShowFooter="True" CellPadding="3" Width="100%" Height="24px"
									BackColor="White" BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical"
									BorderStyle="None">
									<FooterStyle ForeColor="Black" BackColor="#3e65ff"></FooterStyle>
									<SelectedItemStyle Font-Bold="True" ForeColor="Black" CssClass="w3-pale-blue" BackColor="Green"></SelectedItemStyle>
									<EditItemStyle></EditItemStyle>
									<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
									<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
									<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#3e65ff"></HeaderStyle>														
								</asp:datagrid>
							</P>
											
						</div>
						<div class="w3-third">
							<P><LABEL><B>Collection vs Expenses</B></LABEL><BR>
								<asp:datagrid id="DataGrid2" runat="server" ShowFooter="True" CellPadding="3" Width="100%" Height="24px"
									BackColor="White" BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical"
									BorderStyle="None">
									<FooterStyle ForeColor="Black" BackColor="#3e65ff"></FooterStyle>
									<SelectedItemStyle Font-Bold="True" ForeColor="Black" CssClass="w3-pale-blue" BackColor="Green"></SelectedItemStyle>
									<EditItemStyle></EditItemStyle>
									<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
									<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
									<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#3e65ff"></HeaderStyle>														
								</asp:datagrid>
							</P>
						</div>
					</div>					
				</div>
				<div class="w3-row-padding w3-container">
					<div class="w3-half">
						<P>
							<label class="receivables">Receivables:</label>
							<asp:label id="lblReceivables" runat="server" CssClass="receivables"></asp:label>
						</P>
						<P>
							<label class="undelivered_dr">Undelivered DR:</label>
							<asp:label id="lblUndeliveredDR" runat="server" CssClass="undelivered_dr"></asp:label>
						</P>
						<P>
							<label class="near_expiry_items">Near Expiry Items:</label>
							<asp:label id="lblNearExpiryItems" runat="server" CssClass="near_expiry_items"></asp:label>
						</P>
						<P>
							<label class="critical_level_items">Critical Level Items:</label>
							<asp:label id="lblCriticialLevelItems" runat="server" CssClass="critical_level_items"></asp:label>
						</P>
					</div>
					<div class="w3-half">
						<P>
							<label class="activeaccounts">Active Accounts:</label>
							<asp:label id="lblActiveAccounts" runat="server" CssClass="activeaccounts"></asp:label>
						</P>
						<P>
							<label class="inactiveaccounts">Inactive Accounts:</label>
							<asp:label id="lblInactiveAccounts" runat="server" CssClass="inactiveaccounts"></asp:label>
						</P>
						<P>
							<label class="depleted_items">Depleted Items:</label>
							<asp:label id="lblDepletedItems" runat="server" CssClass="depleted_items"></asp:label>
						</P>
					</div>
				</div>
				<div class="w3-container w3-dark-grey w3-padding-32">
					<div class="w3-row">
					  <div class="w3-container w3-quarter">
						<h5 class="w3-bottombar w3-border-green">Inventories</h5>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_available_stocks' target='_blank'><span class='w3-text'>Available Stocks</span></a>")%></p>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_depleted_stocks' target='_blank'><span class='w3-text'>Depleted Stocks</span></a>")%></p>							
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_undelivered_dr' target='_blank'><span class='w3-text'>Underlivered DR</span></a>")%></p>														
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_received_stocks' target='_blank'><span class='w3-text'>Received Stocks</span></a>")%></p>															
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_level_notif' target='_blank'><span class='w3-text'>SOH Safety / Critical Level</span></a>")%></p>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_expiry_notif' target='_blank'><span class='w3-text'>Expiry Items</span></a>")%></p>
					  </div>
					  <div class="w3-container w3-quarter">
						<h5 class="w3-bottombar w3-border-red">Accounts</h5>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_clients_list' target='_blank'><span class='w3-text'>Customer List</span></a>")%></p>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_vendors_list' target='_blank'><span class='w3-text'>Supplier List</span></a>")%></p>																							
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_for_service' target='_blank'><span class='w3-text'>Due For Maintenance</span></a>")%></p>
					  </div>
					  <div class="w3-container w3-quarter">
						<h5 class="w3-bottombar w3-border-blue">Sales / Expenses</h5>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_net_sales' target='_blank'><span class='w3-text'>Sales</span></a>")%></p>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_sales_history' target='_blank'><span class='w3-text'>Product Sales History</span></a>")%></p>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_collections' target='_blank'><span class='w3-text'>Collections</span></a>")%></p>						
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_checkdeposit_notif' target='_blank'><span class='w3-text'>For Cheque Deposits</span></a>")%></p>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_loan_collection' target='_blank'><span class='w3-text'>For Collection</span></a>")%></p>
					  </div>
					  <div class="w3-container w3-quarter">
						<h5 class="w3-bottombar w3-border-orange">Financials</h5>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_account_receivables' target='_blank'><span class='w3-text'>Account Receivables</span></a>")%></p>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_soa' target='_blank'><span class='w3-text'>Statement of Accounts</span></a>")%></p>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_aging_receivables' target='_blank'><span class='w3-text'>Aging Reports</span></a>")%></p>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_financial_status' target='_blank'><span class='w3-text'>Financial Status</span></a>")%></p>
						<p><%response.write("<a class='w3-hover-light-blue' href='rep_costanalysis' target='_blank'><span class='w3-text'>Cost Analysis</span></a>")%></p>
					  </div>
					</div>
				</div>
			</div>
		</FORM>
		<script src="js/MyJS.js"></script>
		<script language="JavaScript" src="js/ScrollingGrid.js"></script>
		<script>
			$('.myddl').select2({
				dropdownCssClass: 'w3-pale-blue',
				selectionCssClass: 'w3-pale-blue'								
			});

			$('input').click(function() {
				$(this).select(); 
			});
		</script>
	</body>
</HTML>
