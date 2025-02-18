<%@ Page Language="vb" aspcompat=true AutoEventWireup="false" Codebehind="inv_paid_list.aspx.vb" Inherits="srx.inv_paid_list" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" --> 
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->		
	</HEAD>
	<!-- #include file ="html\BodyColor.html" -->
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<FORM id="Form1" style="FONT: menu" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main" style="MARGIN-TOP: 43px">
				<!-- Header -->
				<div style="MARGIN-BOTTOM: 50px; PADDING-TOP: 20px">
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;Batch Payment</b></h5>
					<div style="display:none;">
						<asp:Label ID="lblCompany" runat="server" Visible="True"></asp:Label>
					</div>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				
				<asp:panel id="panelForm" style="Z-INDEX: 0;" runat="server" Visible="False">				
					<DIV id="id01" class="w3-card-4" style="margin: auto; MAX-WIDTH: 600px">												
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">								
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox>
							</H2>
						</HEADER>
						<DIV class="w3-section w3-medium">							
							<%response.write("<a class='w3-hover-blue' href='inv_paid_list'><span class='w3-button w3-large w3-hover-red w3-right'>x</span></a>")%>
							<P style="display:none"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" Visible="false"></asp:label>
								<asp:label id="lblBalance" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>
								<asp:label id="lblISSID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								<asp:label id="lblCustomerCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
								<asp:label id="lblInvoiceNo" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								<asp:label id="lblSIDate" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">1/1/1999</asp:label>
							</P>														
							<div class="w3-row w3-border">
								<div class="w3-row w3-container">
									<p><LABEL><B>BU</B></LABEL><BR>
										<asp:dropdownlist id="ddlCompany" runat="server" CssClass="w3-tag w3-input w3-border w3-pale-blue w3-mobile myddl" Autopostback="True" required></asp:dropdownlist>
									</p>	
									<p><LABEL><B>Account Name</B></LABEL><BR>
										<asp:dropdownlist id="ddlCustomer" runat="server" CssClass="w3-tag w3-input w3-border w3-pale-blue w3-mobile myddl" required></asp:dropdownlist>
									</p>							
								</div>
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
									<P><LABEL><B>OR Amount</B></LABEL><BR>
										<asp:textbox tabIndex="4" id="txtORAmount" runat="server" Placeholder="0.00" CssClass="w3-input amount" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
									</P>
									
									<P><LABEL><B>Payment Type</B></LABEL><BR>								
										<asp:dropdownlist tabIndex="3" id="ddlPayType" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostback="True">
											<asp:ListItem Value="CASH">CASH</asp:ListItem>
											<asp:ListItem Value="CHEQUE">CHEQUE</asp:ListItem>
											<asp:ListItem Value="BANK" Selected="True">BANK DEPOSIT</asp:ListItem>
											<asp:ListItem Value="CARD">CREDIT CARD</asp:ListItem>
											<asp:ListItem Value="DEBITCARD">DEBIT CARD</asp:ListItem>																						
											<asp:ListItem Value="GCASH">GCASH</asp:ListItem>
											<asp:ListItem Value="PAYPAL">PAYPAL</asp:ListItem>
											<asp:ListItem Value="PAYMAYA">PAYMAYA</asp:ListItem>
											<asp:ListItem Value="SHOPEEPAY">SHOPEEPAY</asp:ListItem>																																	
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
										<asp:textbox id="txtORNo" runat="server" Placeholder="0.00" CssClass="w3-input" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
									</P>
									<P style="display:none;"><LABEL><B>Loan PayDate</B></LABEL><BR>								
										<asp:dropdownlist id="ddlLoanPayDate" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
									</P>
								</div>
								
								<div class="w3-container">
									<P><LABEL><B>Remarks</B></LABEL><BR>
										<asp:textbox id="txtRemarks" runat="server" CssClass="w3-input w3-border" TextMode="MultiLine" Maxlength="250"></asp:textbox>
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
					<div class="w3-rest w3-padding w3-mobile">
						<!-- Hidden Paginations -->
						<asp:textbox id="txtMorePage" style="POSITION: absolute; LEFT: 440px; Z-INDEX: 101; TOP: 8px" runat="server" Width="32px" Visible="False" Height="18px">0</asp:textbox>
						<asp:label id="Label2" style="POSITION: absolute; LEFT: 368px; Z-INDEX: 102; TOP: 8px" runat="server" Width="64px" Visible="False" Height="2px">More Page</asp:label>
						<asp:label id="Label3" style="POSITION: absolute; LEFT: 488px; Z-INDEX: 103; TOP: 8px" runat="server" Visible="False" Width="48px" Height="8px">Page #</asp:label>
						<asp:textbox id="txtPageNo" style="POSITION: absolute; LEFT: 544px; Z-INDEX: 104; TOP: 8px" runat="server" Visible="False" Width="32px" Height="18px">0</asp:textbox>
						<!-- End Hidden Paginations -->

						<!-- Pagination Buttons -->
						<div class="w3-cell-row">
							<div class="w3-bar w3-margin-right w3-mobile w3-responsive">
								<p>    
									<asp:button id="btnApplyInvoice" CssClass="w3-bar-item w3-btn w3-green w3-mobile" tabIndex="15"
										style="Z-INDEX: 0" runat="server" Visible="False" CausesValidation="False" Text="Apply Invoice"></asp:button>
									<asp:button id="btnUnpost" CssClass="w3-bar-item w3-btn w3-blue w3-mobile" runat="server" Text="Unpost" Visible="False"></asp:button>
									<asp:button id="btnBack" CssClass="w3-bar-item w3-btn w3-khaki w3-mobile" runat="server" Text="Back to List"
										CausesValidation="False" Visible="False"></asp:button>       
									<asp:LinkButton id="btnAddRecord" accessKey="R" runat="server" CssClass="w3-bar-item w3-block w3-btn w3-ripple w3-green w3-mobile"
										Text="New Record" ToolTip="Add a new record. Alt-R." CausesValidation="False"></asp:LinkButton>            
									<asp:button id="BtnFirst" accessKey="F" runat="server" CssClass="w3-bar-item w3-block w3-btn w3-ripple w3-blue-grey w3-mobile"
										Text="(F)irst" ToolTip="Go to the first page of records. Alt-F." CausesValidation="False" Visible="False"></asp:button>
									<asp:button id="btnPrevious" accessKey="P" runat="server" Text="(P)revious" CssClass="w3-bar-item w3-block w3-btn w3-ripple w3-blue-grey w3-mobile"
										CausesValidation="False" ToolTip="Go to the previous page of records. Alt-P." Visible="False"></asp:button>
									<asp:button id="BtnNext" accessKey="N" runat="server" Text="(N)ext" CssClass="w3-bar-item w3-block w3-btn w3-ripple w3-blue-grey w3-mobile"
										CausesValidation="False" ToolTip="Go to the next page of records. Alt-N." Visible="False"></asp:button>
									<asp:button id="btnLast" accessKey="L" runat="server" CssClass="w3-bar-item w3-block w3-btn w3-ripple w3-blue-grey w3-mobile"
										Text="(L)ast" ToolTip="Go to the last page of records. Alt-L." CausesValidation="False" Visible="False"></asp:button>
									<asp:panel id="panelSearchBy" runat="server" Visible="False">
										<label id="lblSearchBy" class="w3-bar-item w3-block"><b>Search By:&nbsp;</b></label>
										<asp:dropdownlist id="ddlSearchBy" runat="server" CssClass="w3-bar-item w3-tag w3-blue w3-hover-blue w3-mobile" AutoPostBack="False">
											<asp:ListItem Value="0">Billing #</asp:ListItem>
											<asp:ListItem Value="1" Selected="True">Invoice #</asp:ListItem>
											<asp:ListItem Value="2">Particulars</asp:ListItem>
											<asp:ListItem Value="3">BS Amount (w/o comma ",")</asp:ListItem> 
											<asp:ListItem Value="4">Client Name</asp:ListItem>        
										</asp:dropdownlist>
									</asp:panel>            
									<asp:textbox id="txtSearch" class="w3-bar-item w3-input w3-white w3-border w3-mobile" accessKey="K" runat="server" Placeholder="Search.." MaxLength="50" onkeypress="return clickButton(event,'btnSearch')"></asp:textbox>
									<asp:button id="btnSearch" accessKey="S" runat="server" Text="Go" CssClass="w3-bar-item w3-btn w3-green w3-mobile" CausesValidation="False" ToolTip="Press this button after typing your search key to perform search on the sorted column.  Alt-S."></asp:button>									
									<%response.write("<a class='w3-btn w3-padding w3-blue w3-hover-light-blue w3-mobile w3-right' style='width:10%' href='rep_aging_receivables'>Aging</a>")%>&nbsp;
									<%response.write("<a class='w3-btn w3-margin-right w3-blue w3-hover-light-blue w3-mobile w3-right' style='width:10%' href='rep_soa'>SOA</a>")%>&nbsp;
									<%response.write("<a class='w3-btn w3-margin-right w3-blue w3-hover-light-blue w3-mobile w3-right' style='width:10%' href='rep_account_receivables'>AR</a>")%>&nbsp;																											
									<asp:hyperlink id="hlViewFullTrail" class="w3-bar-item w3-tag w3-khaki w3-small w3-mobile" runat="server" Target="_blank" ToolTip="View transaction trail" Visible="False">Audit Trail</asp:hyperlink>            
								</p>
							</div>      
						</div>
						<!-- End Pagination Buttons -->
						<br>
						<!-- Page Records -->
						<div class="w3-padding w3-light-grey w3-bottombar w3-border-blue-grey w3-border w3-medium">
							<asp:label id="lblPageRecordCount" runat="server" Height="16px" Visible="False">Records in this page - Page X of Y</asp:label>
							&nbsp;Records per page:
							<asp:dropdownlist id="ddlRecordsPerPage" runat="server" AutoPostBack="True">
								<asp:ListItem Value="5">5</asp:ListItem>
								<asp:ListItem Value="10">10</asp:ListItem>
								<asp:ListItem Value="25">25</asp:ListItem>
								<asp:ListItem Value="100" Selected="True">100</asp:ListItem>
							</asp:dropdownlist>
						</div>
						<!-- End Page Records -->						
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
					</div>
				</asp:panel>
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>		
		<script>
			// Function to Disable comma when typing
			$('#txtDiscount,#txtCurrentForex').on('input', function(event) {

				// Get the current value
				var currentValue = $(this).val();

				// Remove any non-numeric characters
				var newValue = currentValue.replace(/[^\d.]/g, '');
								
				// Update the input value
				$(this).val(newValue);
			});

			// Function to auto-format the date when typing
			$("#calPODate").keyup(function (e) {
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

			$(document).ready(function() {
				// Get the text of the label with ID "lblCompany"
				var companyText = $('#<%= lblCompany.ClientID %>').text().trim();

				// Check if the company text is "COSMOMED"
				if (companyText === "COSMOMED") {					
					 // Change the text of the label to "Project Name"
					 $('label:contains("Requested By")').text("Project Name").css('font-weight', 'bold');
				}
			});			

			$(document).ready(function() {
				// Click event handler for #myDiv1
				$("#myDiv1").click(function() {
					// Set the value of #txtStatus to "APPROVED"
					$("#txtSearch").val("ON PROCESS");
					$("#btnSearch").trigger("click");
				});

				// Click event handler for #myDiv2
				$("#myDiv2").click(function() {
					// Set the value of #txtStatus to "ON PROCESS"
					$("#txtSearch").val("APPROVED");
					$("#btnSearch").trigger("click");
				});

				// Click event handler for #myDiv2
				$("#myDiv3").click(function() {
					// Set the value of #txtStatus to "ON PROCESS"
					$("#txtSearch").val("INCOMPLETE");
					$("#btnSearch").trigger("click");
				});
			});

			$(document).ready(function() {
				$('.checkbox-group input[type="checkbox"]').change(function() {
					var checked = $(this).prop('checked');
					$('.checkbox-group input[type="checkbox"]').not(this).prop('checked', false);
				});
			});
		</script>		
	</body>
</HTML>
