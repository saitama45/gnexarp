<%@ Page Language="vb" AutoEventWireup="false" Codebehind="rep_projectstatus.aspx.vb" Inherits="srx.rep_projectstatus" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<link rel="stylesheet" type="text/css" href="css/twitter-bootstrap/3.0.3/bootstrap.min.css">
		<style>
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
					<b class="w3-medium">&nbsp;<asp:label id="lblTitle" style="Z-INDEX: 0" text="Project Status" runat="server" ForeColor="Red"
								CssClass="Class: w3-bar-item w3-mobile"></asp:label></b>
				</div>
				<!-- End Header -->
				<br>
				<hr class="w3-bottombar w3-border-deep-purple">
				<div class="w3-row-padding w3-margin-bottom">
					<div class="w3-quarter">
					  <div class="w3-container w3-pink w3-padding-16 w3-card-4">
						<div class="w3-left">
							<h4><b>DELAYED</b></h4>
						</div>						
						<div class="w3-clear"></div>
						<div class="w3-center">
							<h4><asp:label id="lblDelay" runat="server"></asp:label>&nbsp;</h4>
						</div>
					  </div>
					</div>
					<div class="w3-quarter">
					  <div class="w3-container w3-amber w3-padding-16 w3-card-4">
						<div class="w3-left">
							<h4><b>PENDING</b></h4>
						</div>						
						<div class="w3-clear"></div>
						<div class="w3-center">
							<h4><asp:label id="lblPending" runat="server"></asp:label></h4>
						</div>
					  </div>
					</div>
					<div class="w3-quarter">
					  <div class="w3-container w3-green w3-padding-16 w3-card-4">
						<div class="w3-left">
							<h4><b>ONGOING</b></h4>
						</div>						
						<div class="w3-clear"></div>
						<div class="w3-center">
							<h4><asp:label id="lblOnGoing" runat="server"></asp:label></h4>
						</div>
					  </div>
					</div>					
					<div class="w3-quarter">
						<a href="rep_projectprofitability" target="_blank">
							<div class="w3-container w3-red w3-text-white w3-padding-16 w3-card-4">							
							<div class="w3-left">
								<h4><b>OVER BUDGET</b></h4>
							</div>						
							<div class="w3-clear"></div>
							<div class="w3-center">
								<h4><asp:label id="lblCompleted" runat="server"></asp:label></h4>
							</div>
							</div>
						</a>
					  </div>
				</div>
				<p>
					<div class="w3-row">
						<div class="w3-third w3-section">
							<div class="w3-col" style="WIDTH:100px;">Start Date From:</div>
								<div class="w3-rest">
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
					
						<div class="w3-third w3-section">
							<div class="w3-col" style="WIDTH:100px">Start Date To:</div>
								<div class="w3-rest">
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
					</div>
				</p>
				<p>									
					<div class="w3-row w3-section">
						<div class="w3-quarter">
							<div class="w3-col s6" style="WIDTH:100px">SO No.:</div>
							<asp:listbox id="lstMotherCompany" runat="server" SelectionMode="Multiple" CssClass="ddl"></asp:listbox>
						</div>		
						<div class="w3-quarter">
							<div class="w3-col s6" style="WIDTH:100px">Account Name:</div>
							<asp:listbox id="lstCustomer" runat="server" SelectionMode="Multiple" CssClass="ddl"></asp:listbox>
						</div>	
						<div class="w3-quarter">
							<div class="w3-col s6" style="WIDTH:100px">Status:</div>
							<asp:listbox id="lstStatus" runat="server" SelectionMode="Multiple" CssClass="ddl">
								<asp:ListItem Value="PENDING">PENDING</asp:ListItem>
								<asp:ListItem Value="DELAYED">DELAYED</asp:ListItem>	
								<asp:ListItem Value="ON GOING">ON GOING</asp:ListItem>								
								<asp:ListItem Value="COMPLETED">COMPLETED</asp:ListItem>
								<asp:ListItem Value="CANCELLED">CANCELLED</asp:ListItem>
							</asp:listbox>
						</div>									
					</div>										
				<P></P>
				<hr>
				<p>
					<asp:button id="btnGenerate" runat="server" Text="Generate!" CssClass="w3-btn w3-bar-item w3-win8-violet w3-mobile"></asp:button>
					<asp:button id="btnDownload" runat="server" Text="Export To Excel" CssClass="w3-btn w3-bar-item w3-green w3-mobile"></asp:button>
				</p>
				<hr class="w3-bottombar w3-border-deep-purple">
				<!-- Sys Group Table -->
				<div class="w3-responsive">
					<TABLE id="tblCAHDRList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2"
						border="0">
						<tr>
							<th>
								<asp:datagrid id="dgList" runat="server" ItemStyle-Wrap="False" CellPadding="3" BackColor="White"
									BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical" BorderStyle="None"
									ShowFooter="True" Width="100%" ShowHeader="True">									
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
				$('[id*=lstMotherCompany]').multiselect({
					includeSelectAllOption: true,					
					enableCaseInsensitiveFiltering: true,
					selectAllValue: 0
				});	
				$('[id*=lstCustomer]').multiselect({
					includeSelectAllOption: true,					
					enableCaseInsensitiveFiltering: true,
					selectAllValue: 0
				});	
				$('[id*=lstStatus]').multiselect({
					includeSelectAllOption: true,					
					enableCaseInsensitiveFiltering: true,
					selectAllValue: 0
				});
			});

			// Function to auto-format the date when typing
			$("#calDateFrom,#calDateTo").keyup(function (e) {
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
		</script>
		<script language="JavaScript" src="js/ScrollingGrid.js"></script>
	</body>
</HTML>
