<%@ Page Language="vb" AutoEventWireup="false" Codebehind="rep_for_service.aspx.vb" Inherits="srx.rep_for_service" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" --> 
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<link rel="stylesheet" type="text/css" href="css/twitter-bootstrap/3.0.3/bootstrap.min.css">
		<style>
			a {
				text-decoration: none;
			}
			.backImg {
				height : 30px;				
			}
		</style>
	</HEAD>
	<body class="w3-light-grey">
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<FORM id="Form1" style="FONT: menu" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main" style="MARGIN-TOP: 43px">
				<!-- Header -->
				<div style="MARGIN-TOP: 15px;">										
					<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To Reports" CssClass="backImg w3-hover-opacity" UseSubmitBehavior="False"/>
					<b class="w3-medium">&nbsp;<asp:label id="lblTitle" style="Z-INDEX: 0" text="Due For Maintenance" runat="server" ForeColor="Red"
								CssClass="Class: w3-bar-item w3-mobile"></asp:label></b>
				</div>
				<!-- End Header -->
				<br>
				<hr class="w3-bottombar w3-border-deep-purple">
				<p style="display:none">
					<div class="w3-row w3-section" style="display:none">
						<div class="w3-quarter">
							<div class="w3-col s6" style="WIDTH:100px">Delivery Date From:</div>
							<ew:calendarpopup id="calDateFrom" style="Z-INDEX: 0" runat="server" ShowGoToToday="True"
									CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False" ImageUrl="images/calendar-icon-mac.jpg"
									ControlDisplay="TextBoxImage">
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
				</p>
				<p>
					<div class="w3-row w3-section" style="display:none">
						<div class="w3-quarter">
							<div class="w3-col s6" style="WIDTH:100px">Delivery Date To:</div>
							<ew:calendarpopup id="calDateTo" style="Z-INDEX: 0" runat="server" ShowGoToToday="True"
									CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False" ImageUrl="images/calendar-icon-mac.jpg"
									ControlDisplay="TextBoxImage">
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
				</p>
				<p>
					<div class="w3-row w3-section">
						<div class="w3-quarter">
							<div class="w3-col s6" style="WIDTH:100px">Customers:</div>
							<asp:listbox id="lstCategories" runat="server" SelectionMode="Multiple"></asp:listbox>
						</div>		
						<div class="w3-quarter">
							<div class="w3-col s6" style="WIDTH:100px">Assets:</div>
							<asp:listbox id="lstSubCategories" runat="server" SelectionMode="Multiple"></asp:listbox>
						</div>	
						<div class="w3-quarter">
							<div class="w3-col s6" style="WIDTH:100px">Service Rendered:</div>
							<asp:listbox id="lstService" runat="server" SelectionMode="Multiple">
								<asp:ListItem Value="PMS">PMS (Preventive Maintenance Schedule)</asp:ListItem>
								<asp:ListItem Value="CALIBRATION">Calibration</asp:ListItem>
								<asp:ListItem Value="REPAIR">Repair</asp:ListItem>
								<asp:ListItem Value="INSTALL">Installation</asp:ListItem>
							</asp:listbox>
						</div>									
					</div>
				<P></P>
				<hr>
				<p>
					<asp:button id="btnGenerate" runat="server" Text="Generate!" CssClass="w3-btn w3-bar-item w3-win8-violet w3-mobile"></asp:button>
					<asp:button id="btnDownload" runat="server" Text="Export To Excel" CssClass="w3-btn w3-bar-item w3-green w3-mobile"></asp:button>
				</p>
				<div style="display:none">
					<!-- #include file ="html\SearchAndButtons.html" -->
				</div>
				<hr class="w3-bottombar w3-border-deep-purple">
				<!-- Sys Group Table -->
				<div class="w3-responsive">
					<TABLE id="tblCAHDRList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2"
						border="0">
						<tr>
							<th>
								<asp:datagrid id="dgList" runat="server" ItemStyle-Wrap="False" CellPadding="3" BackColor="White"
									BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical" BorderStyle="None"
									ShowFooter="True" Width="100%">									
									<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="Green"></SelectedItemStyle>
									<EditItemStyle></EditItemStyle>
									<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
									<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
									<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#708090"></HeaderStyle>
									<FooterStyle Font-Bold="True" ForeColor="White" BackColor="#708090"></FooterStyle>
									<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
								</asp:datagrid>
							</th>
						</tr>
					</TABLE>
				</div>
				<!-- End Sys Group Table -->
				<hr>
				<p>
					<div class="w3-bar">
						<asp:button id="btnFullView" runat="server" Text="Full View" CssClass="w3-btn w3-indigo w3-mobile" Visible="False"></asp:button>
						<br>
						<asp:label id="lblMessage" style="Z-INDEX: 0" runat="server" ForeColor="Red" CssClass="Class: w3-bar-item w3-mobile"></asp:label>
					</div>
				<P></P>
			</div>
		</FORM>
		<script src="js/MyJS.js"></script>
		<script type="text/javascript">
			$(function () {				
				$('[id*=lstCategories]').multiselect({
					includeSelectAllOption: true,					
					enableCaseInsensitiveFiltering: true,
					selectAllValue: 0
				});	
				$('#lstSubCategories').multiselect({
					includeSelectAllOption: true,					
					enableCaseInsensitiveFiltering: true,
					selectAllValue: 0
				});
				$('#lstService').multiselect({
					includeSelectAllOption: true,					
					enableCaseInsensitiveFiltering: true,
					selectAllValue: 0
				});						
			});
		</script>
		<script language="JavaScript" src="js/ScrollingGrid.js"></script>
	</body>
</HTML>
