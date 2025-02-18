<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_paymentdtl_list.aspx.vb" Inherits="srx.inv_paymentdtl_list" %>
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
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;Payment Transaction</b></h5>
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
							<asp:button id="btnX" CssClass="w3-button w3-large w3-hover-red w3-display-topright" runat="server" Text="x" UseSubmitBehavior="False"></asp:button>
							<P style="display:none"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
							</P>
							<div class="w3-container">
								<div class="w3-row">
									<div class="w3-half">
										<p><LABEL><B>SI#</B></LABEL><BR>
											<asp:label id="lblSINo" class="w3-rest s6" runat="server">0</asp:label>
										</p>
									</div>
									<div class="w3-half">
										<p><LABEL><B>Account Name</B></LABEL><BR>
											<asp:label id="lblAccountName" class="w3-rest s6" runat="server">0</asp:label>
										</p>
									</div>
								</div>																
								<p><LABEL><B>Balance</B></LABEL><BR>
									<asp:label id="lblOwing" class="w3-rest s6" runat="server">0</asp:label>
								</p>
							</div>
							<div class="w3-row w3-border">
								<div class="w3-half w3-container">
									<P><LABEL><B>Remitted Date</B></LABEL><BR>
										<ew:calendarpopup tabIndex="1" id="calRemittedDate" style="Z-INDEX: 0" runat="server" Width="80%"
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
									</P>
									<P><LABEL><B>Amount Paid</B></LABEL><BR>
										<asp:textbox tabIndex="4" id="txtPaidAmount" runat="server" Placeholder="0.00" CssClass="w3-input amount" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
									</P>
									
									<P><LABEL><B>Payment Type</B></LABEL><BR>								
										<asp:dropdownlist tabIndex="3" id="ddlPayType" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostback="True">
											<asp:ListItem Value="CASH" Selected="True">CASH</asp:ListItem>
											<asp:ListItem Value="CARD">CREDIT CARD</asp:ListItem>
											<asp:ListItem Value="DEBITCARD">DEBIT CARD</asp:ListItem>
											<asp:ListItem Value="CHEQUE">CHEQUE</asp:ListItem>
											<asp:ListItem Value="WITHHOLDING TAX">WITHHOLDING TAX</asp:ListItem>
											<asp:ListItem Value="CM">CM</asp:ListItem>
											<asp:ListItem Value="BANK">BANK DEPOSIT</asp:ListItem>
											<asp:ListItem Value="GCASH">GCASH</asp:ListItem>
											<asp:ListItem Value="PAYPAL">PAYPAL</asp:ListItem>
											<asp:ListItem Value="PAYMAYA">PAYMAYA</asp:ListItem>
											<asp:ListItem Value="SHOPEEPAY">SHOPEEPAY</asp:ListItem>
											<asp:ListItem Value="DEDUCTIONS">DEDUCTIONS</asp:ListItem>											
											<asp:ListItem Value="DISCOUNTS">DISCOUNTS</asp:ListItem>
										</asp:dropdownlist>
									</P>
								</div>
								<div class="w3-half w3-container">
									<P><LABEL><B>OR Date</B></LABEL><BR>
										<ew:calendarpopup tabIndex="2" id="calORDate" style="Z-INDEX: 0" runat="server" Width="80%"
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
									</P>
									<P><LABEL><B>OR #</B></LABEL><BR>
										<asp:textbox tabIndex="5" id="txtORNo" runat="server" Placeholder="0.00" CssClass="w3-input" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
									</P>
									<P><LABEL><B>Loan PayDate</B></LABEL><BR>								
										<asp:dropdownlist tabIndex="3" id="ddlLoanPayDate" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
									</P>
								</div>
								
								<div class="w3-container">
									<P><LABEL><B>Remarks</B></LABEL><BR>
										<asp:textbox tabIndex="6" id="txtRemarks" runat="server" CssClass="w3-input w3-border" TextMode="MultiLine" Maxlength="250"></asp:textbox>
									</P>
								</div>
							</div>
							<asp:panel id="panelBank" style="Z-INDEX: 0" runat="server" Visible="True">
								<div class="w3-border w3-container">
									<P><LABEL><B>Bank</B></LABEL><BR>
										<asp:dropdownlist tabIndex="7" id="ddlBank" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Enabled="False"></asp:dropdownlist>
									</P>
								</div>
							</asp:panel>
							<asp:panel id="panelCard" style="Z-INDEX: 0" runat="server" Visible="True">
								<div class="w3-border w3-container">
									<P><LABEL><B>Card #</B></LABEL><BR>
										<asp:textbox tabIndex="8" id="txtCardNo" runat="server" Placeholder="type here..." CssClass="w3-input amount" Enabled="False" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
									</P>
									<P><LABEL><B>Approval #</B></LABEL><BR>
										<asp:textbox tabIndex="9" id="txtApprovalNo" runat="server" Placeholder="type here..." CssClass="w3-input amount" Enabled="False" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
									</P>
									<P><LABEL><B>Bank Charge %</B></LABEL><BR>
										<asp:textbox tabIndex="10" id="txtBankCharge" runat="server" Placeholder="0.00" CssClass="w3-input amount" Enabled="False" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
									</P>
								</div>
							</asp:panel>
							<asp:panel id="panelCheck" style="Z-INDEX: 0" runat="server" Visible="True">
								<div class="w3-border w3-container">
									<div class="w3-row">
										<div class="w3-half">
											<P><LABEL><B>Cheque #</B></LABEL><BR>
												<asp:textbox tabIndex="11" id="txtCheckNo" runat="server" Placeholder="0.00" CssClass="w3-input amount" Enabled="False" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>								
											</P>
										</div>
										<div class="w3-half">
											<P><LABEL><B>Cheque Date</B></LABEL><BR>
												<ew:calendarpopup tabIndex="12" id="calCheckDate" style="Z-INDEX: 0" runat="server" Width="53%"
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
											</P>
										</div>
									</div>
								</div>	
							</asp:panel>
							<div class="w3-border w3-container">
								<P><LABEL><B>Deposited Cheque Date</B></LABEL><BR>
									<ew:calendarpopup tabIndex="12" id="calDepositedCheckDate" style="Z-INDEX: 0" runat="server" Width="53%"
										Height="30px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
										ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" Enabled="True" Visible="False">
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
								</P>
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
								<h5 class="w3-bar-item"><b><i class="fas fa-file-invoice"></i>&nbsp;Payments</b></h5>
								<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top w3-bar-item" runat="server"
									Target="_blank" ToolTip="View transaction history. ">Audit Trail</asp:hyperlink>								
								<asp:button id="btnBackToList" CssClass="Style: Class= w3-btn w3-ripple w3-khaki w3-bar-item w3-margin-top w3-mobile w3-right"
									runat="server" Text="Back to list"></asp:button>
								<asp:label id="lblISSID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</div>	
							<p>
								<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />								
							</p>
							<br>
							<hr class="w3-bottombar w3-border-khaki">	
							<p>
								Invoice #:&nbsp;
								<asp:label id="lblInvoiceNo" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>													
							<p>
								SI Date #:&nbsp;
								<asp:label id="lblSIDate" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>
							<p>
								Account Name:&nbsp;
								<asp:label id="lblCustomer" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>&nbsp;|
								<asp:label id="lblCustomerCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
							</p>							
							<p>
								Invoice Amount:&nbsp;
								<asp:label id="lblInvoiceAmount" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>
							<p>
								Paid Amount:&nbsp;
								<asp:label id="lblPaidAmount" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Balance:&nbsp;
								<asp:label id="lblBalance" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>
							</p>																	
						</div>
						<!-- End Header -->
					</div>
					<div class="w3-rest w3-padding w3-mobile">
						<div style="display:none">
							<asp:button id="btnPrint" CssClass="w3-btn w3-ripple w3-indigo w3-bar-item w3-margin-top w3-mobile"
								runat="server" Text="Print DR" Visible="False"></asp:button>				
							<!-- #include file ="html\SearchAndButtons.html" -->
						</div>
						<p>
							<asp:ImageButton id="btnAddImg" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity" />
							<asp:ImageButton id="btnPrintImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Check Voucher" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" Visible="False" />							
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
					</asp:panel>
					</div>
				</div>
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		<script>                        
            // Function to Disable comma when typing
			$('.amount').on('input', function(event) {

				// Get the current value
				var currentValue = $(this).val();
    
				// Remove any non-numeric characters
				var newValue = currentValue.replace(/[^\d.]/g, '');
								
				// Update the input value
				$(this).val(newValue);
			});

			$(function() { $("#id01").draggable(); });

			// Function to auto-format the date when typing
			$("#calRemittedDate,#calORDate,#calCheckDate").keyup(function (e) {
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
				dropdownCssClass: 'w3-pale-blue w3-small',
				selectionCssClass: 'w3-pale-blue'						
			});

			$(document).on('select2:open', () => {
				document.querySelector('.select2-search__field').focus();
			});
		</script>
		
	</body>
</HTML>
