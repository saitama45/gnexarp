<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_receivingdtl2_list.aspx.vb" Inherits="ems.inv_receivingdtl2_list" %>
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
					<DIV id="id01" class="w3-card-4 w3-third myForm">											
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">
							<H4 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox>
							</H4>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">
							<asp:button id="btnX" CssClass="w3-button w3-large w3-hover-red w3-right" runat="server" Text="x"></asp:button>
							<div class="w3-container">
								<asp:LinkButton id="btnNextItem" tabIndex="2" CssClass="w3-btn w3-right w3-light-green w3-mobile"
									runat="server" Visible="False"><i class="fas fa-arrow-alt-circle-right"></i></asp:LinkButton>
								&nbsp;
								<asp:LinkButton id="btnPrevItem" CssClass="w3-btn w3-right w3-light-green w3-mobile"
									runat="server" Visible="False"><i class="fas fa-arrow-alt-circle-left"></i></asp:LinkButton>								
							</div>							
							<P style="display:none"><LABEL><B>Ref#</B></LABEL>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red"></asp:label>
							</P>
							<asp:panel id="panelRPO" style="Z-INDEX: 0" runat="server" Visible="False">
								<br>
								<div class="w3-container">
									<LABEL style="display:none"><B>P.O. Item</B></LABEL>
									<asp:label id="lblItem" runat="server"></asp:label>
								</div>
								<div class="w3-row">
									<div class="w3-half">
										<div class="w3-container">
											<LABEL><B>P.O. Qty</B></LABEL>
											<asp:label id="lblPOQty" runat="server"></asp:label>
										</div>
									</div>									
									<div class="w3-half">
										<div class="w3-container">
											<LABEL><B>P.O. Cost</B></LABEL>
											<asp:label id="lblPOCost" runat="server"></asp:label>
										</div>
									</div>
								</div>	
								<br>																						
							</asp:panel>
							<asp:panel id="panelNPO" style="Z-INDEX: 0" runat="server" Visible="False">
								<div class="w3-container">
									<LABEL><B>Barcode</B></LABEL><BR>
									<asp:textbox tabIndex="3" id="txtBarcode" runat="server" Placeholder="Scan barcode" CssClass="w3-input" AutoPostBack="True"></asp:textbox>
								</div>
								<br>
								<div class="w3-container">
									<LABEL><B>Item Desc</B></LABEL><BR>
									<asp:dropdownlist tabIndex="4" id="ddlRawMats" runat="server" Width="100%" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostBack="True"></asp:dropdownlist>
								</div>
								<br>
								<div class="w3-container">
									<LABEL><B>Cost</B></LABEL><BR>
									<asp:textbox tabIndex="5" id="txtCost" runat="server" CssClass="w3-input" Placeholder="0.00" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
								</div>
							</asp:panel>
							<br>
							<div class="w3-container">
								<LABEL><B>Received Date</B></LABEL>
								<ew:calendarpopup required tabIndex="6" id="calReceivedDate" style="Z-INDEX: 0" runat="server" Width="53%"
									Height="30px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
									ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage">
									<WeekdayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="White"></WeekdayStyle>
									<MonthHeaderStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="#8080FF"></MonthHeaderStyle>
									<OffMonthStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Gray"
										BackColor="AntiqueWhite"></OffMonthStyle>
									<GoToTodayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="White"></GoToTodayStyle>
									<TodayDayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="LightGoldenrodYellow"></TodayDayStyle>
									<DayHeaderStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="MediumSeaGreen"></DayHeaderStyle>
									<WeekendStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="LightGray"></WeekendStyle>
									<SelectedDateStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="Yellow"></SelectedDateStyle>
									<ClearDateStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="White"></ClearDateStyle>
									<HolidayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="White"></HolidayStyle>
								</ew:calendarpopup>
							</div>
							<br>
							<div class="w3-container">
								<div class="w3-row">
									<div class="w3-half">
										<P><LABEL><B>Received Qty</B></LABEL><BR>
											<asp:textbox tabIndex="1" id="txtActualQty" runat="server" required Cssclass="w3-input w3-border" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
										</P>
									</div>
									<div class="w3-half">
										<P><LABEL><B>Free Qty Received</B></LABEL><BR>
											<asp:textbox tabIndex="7" id="txtFreeQty" runat="server" required Cssclass="w3-input w3-border" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
										</P>
									</div>
								</div>
							</div>
							<br>																																			
							<div class="w3-container">
								<LABEL><B>Notes:</B></LABEL><BR>
								<asp:textbox tabIndex="8" id="txtDetailedReason" runat="server" TextMode="MultiLine" Maxlength="250" Cssclass="w3-input w3-border"></asp:textbox>
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
						<div class="w3-container w3-blue">
							<div style="display:none">
								<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top w3-bar-item" runat="server"
									Target="_blank" ToolTip="View transaction history. ">View Full History</asp:hyperlink>								
								<asp:button id="btnBackToList" CssClass="Style: Class= w3-btn w3-ripple w3-khaki w3-bar-item w3-margin-top w3-mobile w3-right"
									runat="server" Text="Back to list"></asp:button>	
							</div>	
							<p>
								<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />								
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
								<asp:label id="lblWarehouse" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>								
							</p>														
							<p>
								Supplier Name:&nbsp;
								<asp:label id="lblVendorName" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>&nbsp;|
								<asp:label id="lblVendorCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>								
							</p>							
							<p style="display:none">
								Supplier Email:&nbsp;
								<asp:label id="lblEmail" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Requested By:&nbsp;
								<asp:label id="lblRequestedBy" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p style="display:none">
								Department:&nbsp;
								<asp:label id="lblDept" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
							</p>
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
							<p>
								Note:&nbsp;
								<asp:textbox id="txtNote" runat="server" CssClass="w3-input w3-border w3-white" TextMode="MultiLine" Maxlength="1000" Enabled="False"></asp:textbox>
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
							<!-- #include file ="html\SearchAndButtons.html" -->
						</div>						
						<p>
							<asp:label id="lblSelectWarehouse" runat="server"><b>Select Warehouse</b>&nbsp;</asp:label>
							<asp:dropdownlist id="ddlWarehouse" runat="server" CssClass="w3-tag w3-btn w3-bar-item w3-border w3-pale-blue w3-mobile myddl" AutoPostback="True" AppendDataBoundItems="True">
								<asp:ListItem></asp:ListItem>
							</asp:dropdownlist>							
							<asp:ImageButton id="btnPrintImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print Receiving Report" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right w3-margin-left" />							
							<asp:ImageButton id="btnNoVarianceImg" runat="server" ImageUrl="images/no_variance.png" Tooltip="No Variance" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" />
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
													<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Cancel" EditText="Edit"></asp:EditCommandColumn>
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
			$("#calReceivedDate").keyup(function (e) {
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

			$(document).on('select2:open', () => {
				document.querySelector('.select2-search__field').focus();
			});
		</script>
		
	</body>
</HTML>
