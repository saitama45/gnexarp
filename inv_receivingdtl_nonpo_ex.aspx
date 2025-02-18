<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_receivingdtl_nonpo_ex.aspx.vb" Inherits="srx.inv_receivingdtl_nonpo_ex" %>
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
							<P style="display:none"><LABEL><B>Ref#</B></LABEL>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red"></asp:label>
							</P>
							<div class="w3-container">
								<div class="w3-row">
									<div class="w3-half">
										<LABEL><B>P.O. Qty</B></LABEL>&nbsp;
										<asp:label id="lblPO_Qty" runat="server"></asp:label>&nbsp;
									</div>									
									<div class="w3-half">
										<LABEL><B>Total Qty</B></LABEL>&nbsp;
										<asp:label id="lblTotalReceived_Qty" runat="server"></asp:label>
									</div>
								</div>																
							</div>	
							<br>
							<div class="w3-container">
								<div class="w3-row">
									<div class="w3-half" style="display:none">
										<LABEL><B>P.O. Date</B></LABEL>&nbsp;
										<asp:label id="lblPO_Date" runat="server"></asp:label>
									</div>
									<div>
										<LABEL><B>Item Desc</B></LABEL><BR>
										<asp:label id="lblItem" runat="server"></asp:label>
									</div>
								</div>
							</div>
							<br>
							<div class="w3-container">
								<div class="w3-row">
									<div class="w3-half">
										<LABEL><B>Serial# / Lot#</B></LABEL><BR>
										<asp:textbox tabIndex="1" id="txtSerial" runat="server" Placeholder="type here..." CssClass="w3-input" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
									</div>
									<div class="w3-half">										
										<LABEL><B>Received Date</B></LABEL>
										<ew:calendarpopup required tabIndex="3" id="calReceivedDate" style="Z-INDEX: 0" runat="server" Width="53%"
											Height="30px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
											ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" Enabled="False">
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
								</div>								
							</div>	
							<br>																			
							<div class="w3-container">
								<div class="w3-row">
									<div class="w3-half">
										<asp:CheckBox tabIndex="3" id="chbNoExpiryDate" runat="server" Text=" w/o Expiry Date" Checked="True" AutoPostBack="True"></asp:CheckBox>&nbsp;
									</div>
									<div class="w3-half">
										<LABEL><B>Expiry Date</B></LABEL>
										<ew:calendarpopup required tabIndex="4" id="calExpiryDate" style="Z-INDEX: 0" runat="server" Width="53%"
											Height="30px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
											ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" Enabled="False">
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
								</div>
							</div>
							<br>
							<div class="w3-container">
								<div class="w3-row">
									<div class="w3-half">
										<LABEL><B>Received Qty</B></LABEL><BR>
											<asp:textbox tabIndex="5" id="txtActualQty" runat="server" required Cssclass="w3-input w3-border" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
									</div>
									<div class="w3-half">
										<LABEL><B>Free Qty Received</B></LABEL><BR>
											<asp:textbox tabIndex="6" id="txtFreeQty" runat="server" required Cssclass="w3-input w3-border" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
									</div>
								</div>
							</div>	
							<br>							
							<asp:panel id="panelCost" style="Z-INDEX: 0" runat="server" Visible="False">
								<div class="w3-container">
									<P><LABEL><B>Cost</B></LABEL><BR>
										<asp:textbox tabIndex="7" id="txtCost" runat="server" Placeholder="type here..." CssClass="w3-input" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
									</P>
								</div>	
							</asp:panel>																									
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
								<h5 class="w3-bar-item"><b><i class="fas fa-file-invoice"></i>&nbsp;</b></h5>
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
								<asp:label id="lblPRStatus" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
							</p>													
							<p>
								REF #:&nbsp;
								<asp:label id="lblPRCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								<asp:label id="lblIsPO" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
							</p>
							<p>
								Date:&nbsp;
								<asp:label id="lblPRDate" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>							
							<p>
								Warehouse:&nbsp;
								<asp:label id="lblWarehouse" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>								
							</p>							
							<div style="display:none">															
								<p>
									P.O. Qty:&nbsp;
									<asp:label id="lblPOQty" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>								
									<asp:label id="lblPRID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								</p>
								<p>
									Payable Amount:&nbsp;
									<asp:label id="lblNetPayable" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>								
								</p>
							</div>
							<p>
								Supplier Name:&nbsp;
								<asp:label id="lblVendorName" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>&nbsp;|
								<asp:label id="lblVendorCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>	
							</p>
							<p>
								Item Desc:&nbsp;
								<asp:label id="lblItemName" class="w3-rest s6 w3-medium w3-red" runat="server" Font-Bold="True"></asp:label>&nbsp;|
								<asp:label id="lblItemCode" class="w3-rest s6 w3-medium w3-red" runat="server" Font-Bold="True"></asp:label>
							</p>
														
							<p>
								Received Qty:&nbsp;
								<asp:label id="lblTotalReceivedQty" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>								
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
			$('#txtActualQty,#txtFreeQty').on('input', function(event) {

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

			$(document).on('select2:open', () => {
				document.querySelector('.select2-search__field').focus();
			});
		</script>
		
	</body>
</HTML>
