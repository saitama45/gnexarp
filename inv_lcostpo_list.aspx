<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_lcostpo_list.aspx.vb" Inherits="srx.inv_lcostpo_list" %>
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
				height : 30px;				
			}

			.myForm {
				margin: auto;
				position:	absolute;
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
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;Landed Costs</b></h5>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">										
					<DIV id="id01" class="w3-card-4 w3-third myForm">
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">													
							<H4 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox>
							</H4>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">
							<label id="btnX" class="w3-button w3-large w3-hover-red w3-right">X</label>
							<P style="display:none"><LABEL><B>Ref#</B></LABEL>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red"></asp:label>
							</P>																																													
							<div class="w3-row w3-container">
								<LABEL><B>Landed Cost Desc</B></LABEL><BR>
									<asp:dropdownlist id="ddlLCostDesc" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
							</div>	
							<br>						
							<div class="w3-row w3-container">
								<LABEL><B>Amount</B></LABEL><BR>
									<asp:textbox id="txtAmount" runat="server" CssClass="w3-input w3-border txtNumbers"></asp:textbox>
							</div>	
							<br>
							<div class="w3-row w3-container">
								<LABEL><B>Note</B></LABEL><BR>
									<asp:textbox id="txtNote" runat="server" CssClass="w3-input w3-border w3-white" TextMode="MultiLine" Maxlength="1000" Enabled="True"></asp:textbox>
							</div>																							
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER>
					</DIV>
				</asp:panel>
				<!-- End Input Form -->
				<asp:panel id="panelGrid" style="Z-INDEX: 0;" runat="server" Visible="True">
				<!-- Header -->
				<div class="w3-row">
					<div class="w3-third">
						<div class="w3-container w3-teal">
							<div style="display:none">								
								<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top w3-bar-item" runat="server"
								Target="_blank" ToolTip="View transaction history. ">View Full History</asp:hyperlink>								
								<asp:button id="btnBackToList" CssClass="Style: Class= w3-btn w3-ripple w3-khaki w3-bar-item w3-margin-top w3-mobile w3-right"
								runat="server" Text="Back to list"></asp:button>
								<asp:label id="lblPRID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								<asp:label id="lblDummy" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</div>
							<p>
								<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />
								<asp:LinkButton id="btnApplyLCost" CssClass="w3-btn w3-ripple w3-blue w3-bar-item w3-right w3-mobile"
									runat="server">&nbsp;Apply Landed Costs</asp:LinkButton>
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
							</p>
							<p>
								PO Date:&nbsp;
								<asp:label id="lblPRDate" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>																				
							<p>
								Supplier Name:&nbsp;
								<asp:label id="lblVendorName" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>&nbsp;|
								<div style="display:none">
									<asp:label id="lblVendorCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
								</div>								
							</p>
							<p>
								PO Amount:&nbsp;
								<asp:label id="lblNetAmountShow" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>
								<asp:label id="lblNetAmount" class="w3-rest s6 w3-large" runat="server" Font-Bold="True" Visible="False"></asp:label>
								<asp:label id="lblDiscount" class="w3-rest s6 w3-large" runat="server" Font-Bold="True" Visible="False"></asp:label>
							</p>
							<p>
								Landed Costs:&nbsp;
								<asp:label id="lblLCostsShow" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>
								<asp:label id="lblLCosts" class="w3-rest s6 w3-large" runat="server" Font-Bold="True" Visible="False"></asp:label>
							</p>																															
							<p>
								Note:&nbsp;
								<asp:textbox id="txtNoteHeader" runat="server" CssClass="w3-input w3-border w3-white" TextMode="MultiLine" Maxlength="1000" Enabled="False"></asp:textbox>
							</p>						
						</div>
						<!-- End Header -->
					</div>
					<div class="w3-rest w3-padding w3-mobile">
						<div style="display:none">
							<asp:LinkButton id="btnPrint" CssClass="w3-btn w3-ripple w3-indigo w3-bar-item w3-mobile"
							runat="server" Visible="False"><i class="fas fa-print"></i>&nbsp;Receiving Report</asp:LinkButton>												
							<!-- #include file ="html\SearchAndButtons.html" -->
						</div>
						<p>
							<asp:ImageButton id="btnAddImg" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity" />
						</p>
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
													<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Cancel" EditText="Edit"></asp:EditCommandColumn>												
													<asp:ButtonColumn Text="Delete" CommandName="Delete"></asp:ButtonColumn>												
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
			$('#txtCost').keyup(function(event) {

				// skip for arrow keys
				if(event.which >= 37 && event.which <= 40) return;

				// format number
				$(this).val(function(index, value) {
					return value
					.replace(/[,'"]/g, '');					
				});
			});							

			$(function() { $("#id01").draggable(); });
						
			$(document).ready(function() {
				$(".w3-input:text").focus(function() { $(this).select(); } );
			});

			// Function to auto-format the date when typing
			$('#calReceivedDate, #calExpiryDate').keyup(function (e) {
				if (e.keyCode != 193 && e.keyCode != 111) {
					console.log(e.keyCode);
					if (e.keyCode != 8) {
						if ($(this).val().length == 2) {
							$(this).val($(this).val() + "/");
						} else if ($(this).val().length == 5) {
							$(this).val($(this).val() + "/");
						}
					} else {
						var temp = $(this).val();
						if ($(this).val().length == 5) {
							$(this).val(temp.substring(0, 4));
						} else if ($(this).val().length == 2) {
							$(this).val(temp.substring(0, 1));
						}
					}
				} else {
					var temp = $(this).val();
					var tam = $(this).val().length;
					$(this).val(temp.substring(0, tam-1));
				}
			});

			$('.myddl').select2({
				dropdownCssClass: 'w3-pale-blue',
				selectionCssClass: 'w3-pale-blue'								
			});
			
			$(document).on('select2:open', () => {
				document.querySelector('.select2-search__field').focus();
			});
			
			$(document).ready(function(){				

				$("#btnX").click(function(){
					$("#id01").hide();
				});			
			});
		</script>
		
	</body>
</HTML>
