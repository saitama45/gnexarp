<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ref_inventories_list.aspx.vb" Inherits="srx.ref_inventories_list" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<link rel="stylesheet" type="text/css" href="css/twitter-bootstrap/3.0.3/bootstrap.min.css">
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<style>
			.wrap-column {
				white-space: normal !important;
			}
		</style>
	</HEAD>
	<!-- #include file ="html\BodyColor.html" -->
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<FORM id="Form1" style="FONT: menu" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main" style="MARGIN-TOP: 43px">
				<!-- Header -->
				<div style="MARGIN-BOTTOM: 50px; PADDING-TOP: 20px">
					<h5 class="w3-left"><b><i class="fas fa-eye-dropper"></i>&nbsp;Inventory Status</b></h5>		
					<div style="display:none;">
						<asp:Label ID="lblCompany" runat="server" Visible="True"></asp:Label>
					</div>			
				</div>				
				<!-- End Header -->
				<hr class="w3-bottombar w3-border-deep-purple">
					<div class="w3-row w3-section">
						<div class="w3-third">
							<div class="w3-col s6" style="WIDTH:100px">Inventory Report:</div>
							<asp:listbox id="lstInvRep" runat="server" SelectionMode="Single" CssClass="ddl" AutoPostback="True">
								<asp:ListItem Value="SOH" Selected="True">Stock On Hand</asp:ListItem>
								<asp:ListItem Value="NearExpiry">Near Expiry</asp:ListItem>
								<asp:ListItem Value="SerialSOH">Lot#/Serial# SOH</asp:ListItem>
							</asp:listbox>
						</div>
						<div class="w3-third">
							<asp:panel id="panelYear" style="Z-INDEX: 0;" runat="server" Visible="False">
								<div class="w3-col s6" style="WIDTH:100px">Year:</div>
								<asp:listbox id="lstYear" runat="server" SelectionMode="Single" CssClass="ddl"></asp:listbox>
							</asp:panel>							
						</div>						
					</div>
					
				<hr class="w3-bottombar w3-border-deep-purple">
				<p>
					<div class="w3-row w3-section">
						<div class="w3-third" style="display:none;">
							<div class="w3-col s6" style="WIDTH:100px">Filter By:</div>
							<asp:listbox id="lstSOH" runat="server" SelectionMode="Single" CssClass="ddl">
								<asp:ListItem Value="WithSOH">WITH SOH</asp:ListItem>
								<asp:ListItem Value="NoSOH">NO SOH</asp:ListItem>
							</asp:listbox>
						</div>
						<div class="w3-third">
							<div class="w3-col s6" style="WIDTH:100px">Warehouse:</div>
							<asp:listbox id="lstWarehouse" runat="server" SelectionMode="Multiple" CssClass="ddl"></asp:listbox>
						</div>
						<div class="w3-third">
														
						</div>
						
						<div class="w3-row w3-section">
							<div class="w3-third">
								<div class="w3-col s6" style="WIDTH:100px">Items:</div>
								<asp:listbox id="lstItems" runat="server" SelectionMode="Multiple" CssClass="ddl"></asp:listbox>
							</div>
							<div class="w3-third">
								<div class="w3-col s6" style="WIDTH:100px">Cateogries:</div>
								<asp:listbox id="lstCategories" runat="server" SelectionMode="Multiple" CssClass="ddl"></asp:listbox>
							</div>	
							<div class="w3-third">
								<div class="w3-col s6" style="WIDTH:100px">SubCateogries:</div>
								<asp:listbox id="lstSubCategories" runat="server" SelectionMode="Multiple" CssClass="ddl"></asp:listbox>
							</div>										
						</div>						
					</div>
				</p>
				<hr>
				<p>
					<asp:button id="btnGenerate" runat="server" Text="Generate!" CssClass="w3-btn w3-bar-item w3-win8-violet w3-mobile"></asp:button>					
					<asp:button id="btnDownload" runat="server" Text="Export To Excel" CssClass="w3-btn w3-bar-item w3-green w3-mobile"></asp:button>
				</p>
				<asp:panel id="panelGrid" style="Z-INDEX: 0;" runat="server" Visible="True">
					<div style="display:none">
						<!-- #include file ="html\SearchAndButtons.html" -->
					</div>
					<!-- Sys Group Table -->
					<div class="w3-responsive">
						<TABLE id="tblGroupList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2"
							border="0">
							<tr>
								<th>
									<asp:datagrid id="Datagrid" runat="server" ItemStyle-Wrap="False" CellPadding="3" BackColor="White"
									BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical" BorderStyle="None"
									ShowFooter="True" Width="100%">									
									<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="Green"></SelectedItemStyle>
									<EditItemStyle></EditItemStyle>
									<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
									<ItemStyle ForeColor="Black" BackColor="#EEEEEE" CssClass="wrap-column"></ItemStyle>
									<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#708090"></HeaderStyle>
									<FooterStyle Font-Bold="True" ForeColor="White" BackColor="#708090"></FooterStyle>
									<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
								</asp:datagrid>
								</th>
							</tr>
						</TABLE>
					</div>
					<!-- End Sys Group Table -->
				</asp:panel>
				<hr>
				<p>
					<div class="w3-bar">
						<asp:button id="btnFullView" runat="server" Text="Full View" CssClass="w3-btn w3-indigo w3-mobile" Visible="False"></asp:button>
						<br>
						<asp:label id="lblMessage" style="Z-INDEX: 0" runat="server" ForeColor="Red" CssClass="Class: w3-bar-item w3-mobile"></asp:label>
					</div>
				</p>
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		<script>

			// Function to Disable comma when typing
			$('.amount').keyup(function(event) {
				// skip for arrow keys
				if(event.which >= 37 && event.which <= 40) return;

				// format number
				$(this).val(function(index, value) {
					return value
					.replace(/[,'"]/g, '');					
				});
			});

			$(function () {				
				$('.ddl').multiselect({
					includeSelectAllOption: true,					
					enableCaseInsensitiveFiltering: true,
					selectAllValue: 0
				});						
			});
		</script>
	</body>
</HTML>
