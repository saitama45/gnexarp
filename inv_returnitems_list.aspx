<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_returnitems_list.aspx.vb" Inherits="srx.inv_returnitems_list" %>
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

			#mydivheader {				
				cursor: move;
				z-index: 10;								
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
			<div id="main" class="w3-container w3-main">
				<!-- Header -->
				<div style="MARGIN-TOP: 40px">
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;Return Items</b></h5>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 myForm">
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">														
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">
							<asp:button id="btnX" CssClass="w3-button w3-large w3-hover-red w3-right" runat="server" Text="x" UseSubmitBehavior="False"></asp:button>
							<P style="display:none"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
							</P>
							<div class="w3-container">
								<div class="w3-row">
									<div class="w3-half">
										<LABEL><B>Warehouse</B></LABEL><BR>
											<asp:label id="lblSourceWarehouse" runat="server"></asp:label>											
									</div>
									<div class="w3-half" style="display:none">
										<LABEL><B>Current SOH</B></LABEL><BR>
										<asp:label id="lblCurrentSOH" runat="server"></asp:label>
									</div>
								</div>								
							</div>
							<br>
							<div class="w3-container">
								<div class="w3-row">
									<div style="display:none">
										<asp:label id="lblSerial" runat="server"></asp:label>
									</div>
									<asp:panel id="panel1" style="Z-INDEX: 0" runat="server" Visible="False">
										<div class="w3-half">
											<h7><b>On Process</b></h7><BR>
												<asp:label id="lblOnProcessSOH" runat="server"></asp:label>																													
										</div>
										<div class="w3-half">										
											<h7><B>Available SOH</B></h7><BR>
												<asp:label id="lblRemainingSOH" runat="server"></asp:label>																										
										</div>
									</asp:panel>
									<asp:panel id="panel2" style="Z-INDEX: 0" runat="server" Visible="False">
										<div class="w3-half">
											<h7><B>On Process</B></h7><BR>
												<asp:label id="lblOnProcessSOH2" runat="server"></asp:label>
										</div>
										<div class="w3-half">											
											<h7><B>Available SOH</B></h7><BR>
												<asp:label id="lblRemainingSOH2" runat="server"></asp:label>
										</div>
									</asp:panel>
								</div>								
							</div>
							<br>							
							<div class="w3-container" style="display:none">
								<LABEL><B>Barcode</B></LABEL><BR>
								<asp:textbox tabIndex="1" id="txtBarcode" runat="server" Placeholder="Scan barcode" CssClass="w3-input"></asp:textbox>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>Item Desc</B></LABEL><BR>
								<asp:dropdownlist tabIndex="2" id="ddlRawMats" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostBack="True"></asp:dropdownlist>
							</div>
							<br>														
							<div class="w3-container">
								<LABEL><B>Qty</B></LABEL><BR>
								<asp:textbox tabIndex="5" id="txtQty" runat="server" Placeholder="0.00" CssClass="w3-input amount" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>								
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
									Target="_blank" ToolTip="View transaction history. ">Audit Trail</asp:hyperlink>								
								<asp:button id="btnBackToList" CssClass="Style: Class= w3-btn w3-ripple w3-khaki w3-bar-item w3-margin-top w3-mobile w3-right"
									runat="server" Text="Back to list"></asp:button>
								<asp:label id="lblISSID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</div>
							<p>
								<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />
								<asp:ImageButton id="btnSaveImg" runat="server" ImageUrl="images/save_image.png" Tooltip="Save" CssClass="btnImg w3-hover-opacity w3-bar-item w3-right" />
							</p>
							<br>
							<hr class="w3-bottombar w3-border-khaki">	
							<p>
								Status:&nbsp;
								<asp:label id="lblStatus" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>
							<p>
								Source Warehouse:&nbsp;
								<asp:label id="lblWarehouse" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>
								<asp:dropdownlist id="ddlWarehouse" runat="server" CssClass="w3-tag w3-btn w3-bar-item w3-border w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
							</p>
							<p>
								SR#:&nbsp;
								<asp:label id="lblRefNo" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>																				
							<p>
								SR Date:&nbsp;
								<asp:label id="lblDate" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
								<ew:calendarpopup tabIndex="1" id="calDate" style="Z-INDEX: 0" runat="server" 
									Height="30px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
									ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" Autopostback="True">
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
							</p>														
							<p>
								Destination:&nbsp;
								<asp:label id="lblDestination" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>
								<asp:dropdownlist tabIndex="2" id="ddlClient" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
							</p>
							<p>
								Address:&nbsp;
								<asp:label id="lblAddress" runat="server" Font-Bold="True" Visible="False"></asp:label>
								<asp:textbox tabIndex="3" id="txtAddress" runat="server" CssClass="w3-input w3-border" TextMode="MultiLine" Maxlength="1000" Autopostback="True"></asp:textbox>
							</p>
							<p>
								Total Items:&nbsp;
								<asp:label id="lblTotalItems" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Total Qty:&nbsp;
								<asp:label id="lblTotalQty" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Total Cost:&nbsp;
								<asp:label id="lblTotalCost" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Note:&nbsp;
								<asp:textbox id="txtNote" runat="server" CssClass="w3-input w3-border w3-white" TextMode="MultiLine" Maxlength="1000" Enabled="True" Autopostback="True"></asp:textbox>
							</p>											
						</div>
						<!-- End Header -->
					</div>
					<div class="w3-rest w3-padding w3-mobile">
						<div style="display:none">
							<asp:LinkButton id="btnPrint" CssClass="w3-btn w3-ripple w3-indigo w3-bar-item w3-margin-top w3-mobile"
								runat="server"><i class="fas fa-print"></i>&nbsp;Print Report</asp:LinkButton>							
							<!-- #include file ="html\SearchAndButtons.html" -->
						</div>
						<p>
							<asp:ImageButton id="btnAddImg" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity" />
							<asp:ImageButton id="btnPrintImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print PO" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" />							
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
			$('#txtQty').on('input', function(event) {

				// Get the current value
				var currentValue = $(this).val();

				// Remove any non-numeric characters
				var newValue = currentValue.replace(/[^\d.]/g, '');
								
				// Update the input value
				$(this).val(newValue);
			});

			$(function() { $("#id01").draggable(); });

			// Function to auto-format the date when typing
			$("#calDate").keyup(function (e) {
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
		</script>
		
	</body>
</HTML>
