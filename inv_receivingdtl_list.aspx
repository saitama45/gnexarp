<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_receivingdtl_list.aspx.vb" Inherits="srx.inv_receivingdtl_list" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
		<script src="js/jquery.draggableTouch.js"></script>
		<style>		

			#mydivheader {				
				cursor: move;
				z-index: 10;								
			}

			p {
				font-size: 14px !important;
				color: black;
		
			}

			.btnImg {
				height : 35px;				
			}

			.myForm {
				margin: auto;
				width: 410px;
				position: absolute;
				z-index: 10;
				background-color: #f1f1f1;
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
				<div style="MARGIN-TOP: 30px">
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;Receiving Items</b></h5>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 myForm">
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">																			
							<H4 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox>
							</H4>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">
							<asp:button id="btnX" CssClass="w3-button w3-large w3-hover-red w3-right" runat="server" Text="x" UseSubmitBehavior="False"></asp:button>
							<P style="display:none"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
							</P>
							<div class="w3-container" style="display:none">
								<LABEL><B>Barcode</B></LABEL><BR>
								<asp:textbox tabIndex="7" id="txtBarcode" runat="server" Placeholder="Scan barcode" CssClass="w3-input" AutoPostBack="True"></asp:textbox>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>Item Desc</B></LABEL><BR>
								<asp:dropdownlist tabIndex="8" id="ddlRawMats" runat="server" Width="100%" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostBack="True" required></asp:dropdownlist>
							</div>	
							<br>
							<div class="w3-container">
								<LABEL><B>Recent PO Date</B></LABEL>
								<asp:label id="lblRecentPODate" runat="server"></asp:label>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>PO Qty</B></LABEL>
								<asp:label id="lblRecentPOQty" runat="server"></asp:label>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>PO Cost</B></LABEL>
								<asp:label id="lblRecentPOCost" runat="server"></asp:label>
							</div>	
							<br>					
							<div class="w3-container">
								<LABEL><B>Qty</B></LABEL><BR>
								<asp:textbox tabIndex="9" id="txtQty" runat="server" CssClass="w3-input txtNumbers" Placeholder="0.00" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
							</div>	
							<br>																				
							<div class="w3-container">
								<LABEL><B>Cost</B></LABEL><BR>
								<asp:textbox tabIndex="10" id="txtCost" runat="server" CssClass="w3-input txtNumbers" Placeholder="0.00" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
							</div>	 
						</div>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER>
					</DIV>												
				</asp:panel>
				<!-- End Input Form -->
				<asp:panel id="panelGrid" style="Z-INDEX: 0;" runat="server" Visible="True">
				<!-- Header -->
				<div class="w3-row">
					<div class="w3-third">
						<div class="w3-container w3-blue">							
							<div style="display:none">
								<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top w3-bar-item" runat="server"
								Target="_blank" ToolTip="View transaction history. ">View Full History</asp:hyperlink>								
								<asp:button id="btnBackToList" CssClass="Style: Class= w3-btn w3-ripple w3-khaki w3-bar-item w3-margin-top w3-mobile w3-right"
								runat="server" Text="Back to list"></asp:button>	
							</div>
							<p>
								<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />								
								<asp:ImageButton id="btnSaveImg" runat="server" ImageUrl="images/save_image.png" Tooltip="Save" CssClass="btnImg w3-hover-opacity w3-bar-item w3-right" />									
								<div style="display:none">
									<asp:LinkButton id="btnCompleted" runat="server" CssClass="w3-btn w3-ripple w3-green w3-bar-item w3-right w3-round w3-mobile" OnClientClick="return confirm('Are you sure you want to proceed?');">&nbsp;COMPLETE</asp:LinkButton>
								</div>								
							</p>										
							<br>																											
							<hr class="w3-bottombar w3-border-khaki">																						
							<p>
								Status:&nbsp;
								<asp:label id="lblStatus" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>														
							<p>
								PO #:&nbsp;
								<asp:label id="lblPRCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								<asp:label id="lblIsPO" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
							</p>
							<p>
								PO Date:&nbsp;
								<asp:label id="lblPRDate" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>							
							<p>
								Warehouse:&nbsp;
								<asp:dropdownlist id="ddlWarehouse" runat="server" CssClass="w3-tag w3-btn w3-bar-item w3-border w3-pale-blue w3-mobile myddl" AutoPostback="True"></asp:dropdownlist>
								<asp:label id="lblWarehouse" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>								
							</p>
							<p>
								Supplier Name:&nbsp;
								<asp:label id="lblVendorName" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>&nbsp;|
								<asp:label id="lblVendorCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>								
							</p>							
							<p style="display:none">
								Supplier Email:&nbsp;
								<asp:label id="lblEmail" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
								<asp:label id="lblPRID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>
							<p>
								Supplier DR#:&nbsp;
								<asp:textbox id="txtSupplierDRNo" CssClass="w3-input w3-white w3-border" runat="server" Autopostback="True"></asp:textbox>
							</p>
							<p>
								Supplier SI#:&nbsp;
								<asp:textbox id="txtSupplierSINo" CssClass="w3-input w3-white w3-border" runat="server" Autopostback="True"></asp:textbox>
							</p>
							<p>
								Requested By:&nbsp;
								<asp:label id="lblRequestedBy" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
							</p>
							<div style="display:none">
								Department:&nbsp;
								<asp:label id="lblDept" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
								<p>
									Terms:&nbsp;
									<asp:label id="lblTerms" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
								</p>
								<p>
									Discount:&nbsp;
									<asp:label id="lblDiscount" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>%
								</p>
								<p>
									Total Cost:&nbsp;
									<asp:label id="lblTotalCost" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
								</p>							
								<p>
									Discounted Amount:&nbsp;
									<asp:label id="lblDiscountedAmount" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
								</p>
								<p>
									PO Amount:&nbsp;
									<asp:label id="lblNetAmount" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
								</p>							
								<p>
									Payable Amount:&nbsp;
									<asp:label id="lblNetPayable" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
								</p>
							</div>																													
							<p>
								Note:&nbsp;
								<asp:textbox id="txtNote" runat="server" CssClass="w3-input w3-border w3-white" TextMode="MultiLine" Maxlength="1000" Enabled="True"></asp:textbox>
							</p>						
						</div>
						<!-- End Header -->
					</div>
					<div class="w3-rest w3-padding w3-mobile">																	
						<div style="display:none">							
							<asp:LinkButton id="btnPrint" CssClass="w3-btn w3-ripple w3-indigo w3-bar-item w3-mobile"
								runat="server" Visible="False"><i class="fas fa-print"></i>&nbsp;Receiving Report</asp:LinkButton>
							<asp:LinkButton id="btnPrintWOPO" CssClass="w3-btn w3-ripple w3-indigo w3-bar-item w3-mobile"
								runat="server" Visible="False"><i class="fas fa-print"></i>&nbsp;Receiving Report</asp:LinkButton>
							<asp:LinkButton id="btnNoVariance" CssClass="w3-btn w3-ripple w3-blue w3-bar-item w3-mobile"
								runat="server" Visible="False"><i class="fas fa-thumbs-up"></i>&nbsp;No Variance</asp:LinkButton>							
							<asp:label id="lblSelectWarehouse" runat="server"><b>Select Warehouse</b>&nbsp;</asp:label>
							<!-- #include file ="html\SearchAndButtons.html" -->
						</div>						
						<p>														
							<asp:ImageButton id="btnAddImg" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity" />
							<asp:ImageButton id="btnPrintImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print Receiving Report" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" />
							<asp:ImageButton id="btnNoVarianceImg" runat="server" ImageUrl="images/no_variance.png" Tooltip="No Variance" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" Visible="False" />
						</p>
						<br>
						<p>
							<!-- Sys Group Table -->
							<div class="w3-responsive">
								<TABLE id="tblGroupList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2"
									border="0">
									<tr>
										<th>
											<asp:datagrid id="DataGrid" runat="server" ShowFooter="True" CellPadding="3" Width="100%" Height="24px"
												BackColor="White" BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical"
												BorderStyle="None">
												<FooterStyle ForeColor="White" BackColor="#708090"></FooterStyle>
												<SelectedItemStyle Font-Bold="True" ForeColor="Black" CssClass="w3-pale-blue" BackColor="Green"></SelectedItemStyle>
												<EditItemStyle></EditItemStyle>
												<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
												<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
												<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#708090"></HeaderStyle>
												<Columns>
													<asp:ButtonColumn Text="Open" CommandName="Open"></asp:ButtonColumn>												
												</Columns>
												<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
											</asp:datagrid>
										</th>
									</tr>
								</TABLE>
							</div>
							<!-- End Sys Group Table -->
						</p>						
					</div>
				</div>
				</asp:panel>
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		<script>        
            // Function to Disable comma when typing
			$('#txtQty,#txtCost').on('input', function(event) {

				// Get the current value
				var currentValue = $(this).val();

				// Remove any non-numeric characters
				var newValue = currentValue.replace(/[^\d.]/g, '');
								
				// Update the input value
				$(this).val(newValue);
			});									

			$(function() { $("#id01").draggable(); });
						
			$(document).ready(function() {
				$(".w3-input:text").focus(function() { $(this).select(); } );
			});

			$('.myddl').select2({
				dropdownCssClass: 'w3-pale-blue',
				selectionCssClass: 'w3-pale-blue'								
			});
			
			$(document).on('select2:open', () => {
				document.querySelector('.select2-search__field').focus();
			});
		</script>
		
	</body>
</HTML>
