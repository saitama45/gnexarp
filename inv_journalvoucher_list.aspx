<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_journalvoucher_list.aspx.vb" Inherits="srx.inv_journalvoucher_list" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<style>
			/* Hiding of column ID in datagrid */			
			.myDataGrid tr th:nth-child(2),
			.myDataGrid tr td:nth-child(2) {
				display: none;
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
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;Journal Voucher</b></h5>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4" style="margin: auto;MAX-WIDTH: 600px">
						
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">																		
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-section w3-medium">
							<%response.write("<a class='w3-hover-blue' href='inv_journalvoucher_list'><span class='w3-button w3-large w3-hover-red w3-right'>x</span></a>")%>
							<P style="display:none"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
							</P>
							<div class="w3-row">
								<div class="w3-half">
									<div class="w3-container">
										<LABEL><B>Company</B></LABEL><BR>
											<asp:dropdownlist id="ddlCompany" runat="server" CssClass="w3-tag w3-input w3-border w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
									</div>
								</div>
								<div class="w3-half">
									<div class="w3-container">
										<LABEL><B>Voucher #</B></LABEL><BR>
										<asp:label id="lblVoucherNo" runat="server" CssClass="w3-input" Placeholder="type here..."></asp:label>
									</div>
								</div>
							</div>							
							<br>
							<div class="w3-row">
								<div class="w3-half">
									<div class="w3-container">
										<LABEL><B>Application Date</B></LABEL><BR>
											<ew:calendarpopup id="calDate" style="Z-INDEX: 0" runat="server" Width="53%"
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
								</div>
								<div class="w3-half">
									<div class="w3-container">
										<LABEL><B>Due Date</B></LABEL><BR>
										<ew:calendarpopup id="calDueDate" style="Z-INDEX: 0" runat="server" Width="53%"
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
								</div>
							</div>																										
							<br>
							<div class="w3-container w3-row">
								<LABEL><B>Particulars</B></LABEL><BR>
									<asp:textbox id="txtParticulars" runat="server" CssClass="w3-input w3-white w3-border" TextMode="MultiLine" required></asp:textbox>
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
									<asp:button id="BtnNext2" accessKey="N" runat="server" Text="(N)ext" CssClass="w3-bar-item w3-block w3-btn w3-ripple w3-blue-grey w3-mobile"
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
									<asp:button id="btnSearch" accessKey="S" runat="server" Text="Go" CssClass="w3-bar-item w3-btn w3-green w3-mobile" CausesValidation="False" OnClientClick="searchButtonClick()"></asp:button>																		
									<%response.write("<a class='w3-btn w3-blue w3-hover-light-blue w3-mobile w3-right' style='width:10%' href='rep_costanalysis'>Cost Analysis</a>")%>&nbsp;
									<asp:hyperlink id="hlViewFullTrail" class="w3-bar-item w3-tag w3-khaki w3-small w3-mobile" runat="server" Target="_blank" ToolTip="View transaction trail" Visible="False">Audit Trail</asp:hyperlink>            									
								</p>
							</div>      
						</div>
						<!-- End Pagination Buttons -->
						<br>
						<!-- Page Records -->
						<div class="w3-padding w3-light-grey w3-bottombar w3-border-blue-grey w3-border w3-medium" style="display:none;">
							<asp:label id="lblPageRecordCount" runat="server" Height="16px" Visible="False">Records in this page - Page X of Y</asp:label>
							&nbsp;Records per page:
							<asp:dropdownlist id="ddlRecordsPerPage" runat="server" AutoPostBack="True">
								<asp:ListItem Value="5">5</asp:ListItem>
								<asp:ListItem Value="10">10</asp:ListItem>
								<asp:ListItem Value="25">25</asp:ListItem>
								<asp:ListItem Value="100" Selected="True">100</asp:ListItem>
							</asp:dropdownlist>
						</div>
						<asp:panel id="panelPaginations" runat="server">
							<asp:button runat="server" id="btnPrev" CssClass="w3-text-small w3-button w3-hover-blue" Text="&#10094;" Enabled="False" style="background-color: #708090;"></asp:button>
							<span>Page&nbsp;</span><b><asp:textbox runat="server" id="txtCurrentPage" CssClass="w3-text-small w3-center" width="30px" Autopostback="True">1</asp:textbox></b>&nbsp;of&nbsp;<b><asp:label runat="server" id="lblPageTotal" CssClass="w3-text-small">1</asp:label></b>
							<asp:button runat="server" id="btnNext" CssClass="w3-text-small w3-button w3-hover-blue" Text="&#10095;" style="background-color: #708090;"></asp:button>
						</asp:panel>
						<!-- End Page Records -->
						<!-- Sys Group Table -->
						<div class="w3-responsive">
							<TABLE id="tblGroupList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2"
								border="0">
								<tr>
									<th>
										<asp:datagrid id="DataGrid" runat="server" ShowFooter="False" CellPadding="3" Width="100%" Height="24px"
											BackColor="White" BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical"
											BorderStyle="None" Cssclass="myDataGrid">
											<FooterStyle ForeColor="Black" BackColor="#708090"></FooterStyle>
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
							<asp:label id="lblTotalRecords" style="Z-INDEX: 0" runat="server" Font-Bold="True"></asp:label>
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
			$('#txtCost').keyup(function(event) {

				// skip for arrow keys
				if(event.which >= 37 && event.which <= 40) return;

				// format number
				$(this).val(function(index, value) {
					return value
					.replace(/,/g, '');					
				});
			});

			// Function to auto-format the date when typing
			$("#calSIDate").keyup(function (e) {
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
