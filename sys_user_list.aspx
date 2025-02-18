<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<%@ Page Language="vb" aspcompat=true AutoEventWireup="false" Codebehind="sys_user_list.aspx.vb" Inherits="srx.sys_User_list" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
	</HEAD>
	<body>
		<!-- #include file ="html\BodyColor.html" -->
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<FORM id="Form1" style="font: 400 14pt/normal Segoe UI; font: menu;" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main" style="margin-top: 43px;">
				<!-- Header -->
				<div style="padding-top: 20px; margin-bottom: 50px; ">
					<h5 class="w3-left"><b><i class="fas fa-users"></i>&nbsp;User Administration</b></h5>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- PanelBU -->
				<asp:panel id="PanelBU" style="z-index: 0;" runat="server" Visible="False"> <!-- Group Menu Header -->
					<DIV class="w3-container w3-win8-blue w3-padding-32">
						<DIV class="w3-row">
							<H5 class="w3-bottombar w3-border-khaki"><B><I class="fas fa-newspaper-o"></I>&nbsp; 
									Company Permission</B>
							</H5>
							<DIV class="w3-container w3-third">
								<P>Fullname:&nbsp;
									<asp:Label id="lblFullname" runat="server" Font-Bold="True"></asp:Label>&nbsp; 
									(
									<asp:Label id="lblUsername" runat="server" Font-Bold="True"></asp:Label>)
								</P>
							</DIV>
							<DIV class="w3-container w3-third">
								<P>Role:&nbsp;
									<asp:Label id="lblRole" runat="server" Font-Bold="True" Width="100%">Label</asp:Label></P>
							</DIV>
							<DIV class="w3-container w3-third">
								<P>Default Screen:&nbsp;
									<asp:Label id="lblDefault_Screen" runat="server" Font-Bold="True" Width="100%">Label</asp:Label></P>
							</DIV>
						</DIV>
					</DIV> <!-- End Group Menu Header -->
					<DIV class="w3-container">
						<DIV class="w3-row">
							<DIV class="w3-container w3-row">
								<div class="w3-quarter">
									<P>
										<B>Company List</B>
										<asp:CheckBox id="chkAllList" runat="server" Text="Select All"></asp:CheckBox>
									</P>
									<P>
										<asp:CheckBoxList id="cblBUList" runat="server"></asp:CheckBoxList>
									</P>
								</div>
								<div class="w3-quarter">
									<P>
										<B>Default</B>										
									</P>
									<P>
										<asp:CheckBoxList id="cblDefaultList" runat="server"></asp:CheckBoxList>
									</P>
								</div>																
							</DIV>
						</DIV>
						
						<asp:Label id="lblBUMessage" runat="server" Width="312px" Height="6px" ForeColor="Red">lblBUMessage</asp:Label><BR>
						<asp:Button id="btnBUOK" runat="server" Width="69px" Text="Save" CssClass="Class: w3-btn w3-ripple w3-teal w3-bar-item w3-mobile"></asp:Button>&nbsp;&nbsp;&nbsp;
						<asp:Button id="btnBUCancel" runat="server" Text="Cancel" CssClass="Class: w3-btn w3-ripple w3-red w3-bar-item w3-mobile"></asp:Button></DIV>
				</asp:panel>
				<!-- End PanelBU -->
				<!-- PanelClient -->
				<asp:panel id="PanelClient" style="z-index: 0;" runat="server" Visible="False"> <!-- Group Menu Header -->
					<DIV class="w3-container w3-win8-blue w3-padding-32">
						<DIV class="w3-row">
							<H5 class="w3-bottombar w3-border-khaki"><B><I class="fas fa-newspaper-o"></I>&nbsp;User 
									Client Permission</B>
							</H5>
							<DIV class="w3-container w3-third">
								<P>Fullname:&nbsp;
									<asp:Label id="lblFullnameClient" runat="server" Font-Bold="True"></asp:Label>&nbsp; 
									(
									<asp:Label id="lblUsernameClient" runat="server" Font-Bold="True"></asp:Label>)
								</P>
							</DIV>
							<DIV class="w3-container w3-third">
								<P>Role:&nbsp;
									<asp:Label id="lblRoleClient" runat="server" Font-Bold="True" Width="100%">Label</asp:Label></P>
							</DIV>
							<DIV class="w3-container w3-third">
								<P>Default Screen:&nbsp;
									<asp:Label id="lblDefault_ScreenClient" runat="server" Font-Bold="True" Width="100%">Label</asp:Label></P>
							</DIV>
						</DIV>
					</DIV> <!-- End Group Menu Header -->
					<DIV class="w3-container">
						<DIV class="w3-row">
							<DIV class="w3-container w3-half">
								<P><B>Client List</B>
									<asp:CheckBox id="chkAllListClient" runat="server" Text="Select All"></asp:CheckBox></P>
								<P>
									<asp:CheckBoxList id="cblClientList" runat="server"></asp:CheckBoxList></P>
							</DIV>
						</DIV>
						<asp:Label id="lblClientMessage" runat="server" Width="312px" Height="6px" ForeColor="Red">lblClientMessage</asp:Label><BR>
						<asp:Button id="btnClientOK" runat="server" Text="Save" CssClass="w3-btn w3-input w3-ripple w3-teal w3-bar-item w3-mobile"></asp:Button>&nbsp;&nbsp;&nbsp;
						<asp:Button id="btnClientCancel" runat="server" Text="Cancel" CssClass="Class: w3-btn w3-ripple w3-red w3-bar-item w3-mobile"></asp:Button></DIV>
				</asp:panel>
				<!-- End PanelClient -->
				<!-- Input Form -->
				<asp:panel id="panelForm" runat="server" Visible="False">
					<DIV class="w3-card-4" id="id01" style="margin: auto; max-width: 600px;"><HEADER class="w3-container w3-light-grey w3-display-container w3-responsive"><%response.write("<a class='w3-hover-blue' href='sys_user_list'><span class='w3-button w3-large w3-hover-red w3-display-topright'>x</span></a>")%>
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-container w3-section w3-medium">
							<DIV class="w3-col s6" style="width: 100px; display: none;">ID:</DIV>
							<DIV class="w3-tag w3-red w3-rest">
								<asp:label id="lblID" runat="server" Visible="False" Font-Bold="True">0</asp:label></DIV>
							<DIV class="w3-col s6" style="width: 100px;">Username:</DIV>
							<DIV class="w3-rest">
								<asp:textbox id="txtUID" runat="server" CssClass="w3-input w3-medium" Placeholder="Username"
									MaxLength="50" required></asp:textbox>
								<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Width="8px" Display="Dynamic" ErrorMessage="User ID must be filled."
									ControlToValidate="txtUID">*</asp:RequiredFieldValidator>
								<asp:regularexpressionvalidator id="RegularExpressionValidator1" runat="server" Width="8px" ErrorMessage="Invalid User ID format."
									ControlToValidate="txtUID" ValidationExpression="^[A-Za-z0-9.]*$">*</asp:regularexpressionvalidator><BR>
								<asp:CheckBox id="cbResetPassword" runat="server" Text="Reset password :"></asp:CheckBox>&nbsp;*User's 
								password will be same as user ID.
							</DIV>
							<DIV class="w3-col s6" style="width: 100px;">Full Name:</DIV>
							<DIV class="w3-rest">
								<asp:textbox id="txtFullname" runat="server" CssClass="w3-input w3-medium" Placeholder="Full Name"
									MaxLength="50"></asp:textbox>
								<asp:RequiredFieldValidator id="Requiredfieldvalidator2" runat="server" Width="8px" Display="Dynamic" ErrorMessage="Full Name must be filled."
									ControlToValidate="txtFullname">*</asp:RequiredFieldValidator>
							</DIV>
							<DIV class="w3-col s6" style="width: 100px;">First Name:</DIV>
							<DIV class="w3-rest">
								<asp:textbox id="txtFirstname" runat="server" CssClass="w3-input w3-medium" Placeholder="First Name"
									MaxLength="250"></asp:textbox>
								<asp:RequiredFieldValidator id="Requiredfieldvalidator3" runat="server" Width="8px" Display="Dynamic" ErrorMessage="First Name must be filled."
									ControlToValidate="txtFirstname">*</asp:RequiredFieldValidator>
							</DIV>
							<DIV class="w3-col s6" style="width: 100px;">Last Name:</DIV>
							<DIV class="w3-rest">
								<asp:textbox id="txtLastname" runat="server" CssClass="w3-input w3-medium" Placeholder="Last Name"
									MaxLength="250"></asp:textbox>
								<asp:RequiredFieldValidator id="Requiredfieldvalidator4" runat="server" Width="8px" Display="Dynamic" ErrorMessage="Last Name must be filled."
									ControlToValidate="txtLastname">*</asp:RequiredFieldValidator>
							</DIV>
							<DIV class="w3-col s6" style="width: 100px;">Email Address:</DIV>
							<DIV class="w3-rest">
								<asp:textbox class="w3-input w3-medium" id="txtEmail" runat="server" Placeholder="Email"
									MaxLength="50" pattern="[^@]+@[^@]+\.[a-zA-Z]{2,6}"></asp:textbox></DIV>
							<DIV class="w3-col s6" style="width: 100px;">Access Inclusive Dates:
							</DIV>
							<DIV class="w3-rest">
								<asp:CheckBox id="cbAccess_Start" runat="server" Text="Set access start date"></asp:CheckBox><BR>
								<ew:calendarpopup id="calAccess_Start" style="z-index: 0;" runat="server" Width="53%"
									Height="30px" ControlDisplay="TextBoxImage" ImageUrl="images/calendar-icon-mac.jpg" DisableTextboxEntry="False"
									AllowArbitraryText="False" CalendarLocation="Bottom" ShowGoToToday="True">
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
								</ew:calendarpopup><BR>
								<asp:CheckBox id="cbAccess_End" runat="server" Text="Set access end date"></asp:CheckBox><BR>
								<ew:calendarpopup tabIndex="8" id="calAccess_End" style="z-index: 0;" runat="server" Width="53%" Height="30px"
									ControlDisplay="TextBoxImage" ImageUrl="images/calendar-icon-mac.jpg" DisableTextboxEntry="False"
									AllowArbitraryText="False" CalendarLocation="Bottom" ShowGoToToday="True">
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
								</ew:calendarpopup></DIV>
							<P></P>
							<P></P>
							<DIV class="w3-col s6" style="width: 100px;">Group:</DIV>
							<DIV class="w3-rest">
								<asp:DropDownList id="ddlGroup" runat="server" CssClass="w3-input"></asp:DropDownList>
							</DIV>
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER></DIV>
				</asp:panel>
				<!-- End Input Form -->
				<!-- #include file ="html\SearchAndButtons.html" -->
				<!-- Sys Group Table -->
				<div class="w3-responsive">
					<TABLE id="tblGroupList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2"
						border="0">
						<tr>
							<th>
								<asp:datagrid id="DataGrid" runat="server" CellPadding="3" Width="100%" Height="24px" BackColor="White"
									BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical" BorderStyle="None">
									<SelectedItemStyle Font-Bold="True" ForeColor="Black" CssClass="w3-pale-blue" BackColor="Green"></SelectedItemStyle>
									<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
									<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
									<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#708090"></HeaderStyle>
									<FooterStyle ForeColor="Black" BackColor="#CCCCCC"></FooterStyle>
									<Columns>
										<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Cancel" EditText="Edit"></asp:EditCommandColumn>										
										<asp:ButtonColumn Text="Company" CommandName="Company"></asp:ButtonColumn>
									</Columns>
									<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
								</asp:datagrid>
							</th>
						</tr>
					</TABLE>
				</div>
				<!-- End Sys Group Table -->
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		<script>
			// Function for Datagrid Tables
			function filterTable(event) {
				var filter = event.target.value.toUpperCase();
				var rows = document.querySelector("#DataGrid tbody").rows;
				
				for (var i = 0; i < rows.length; i++) {
					var thirdCol = rows[i].cells[3].textContent.toUpperCase();
					var fourthCol = rows[i].cells[4].textContent.toUpperCase();
					var fifthCol = rows[i].cells[5].textContent.toUpperCase();
					if (thirdCol.indexOf(filter) > -1 || fourthCol.indexOf(filter) > -1 || fifthCol.indexOf(filter) > -1) {
						rows[i].style.display = "";
					} else {
						rows[i].style.display = "none";
					}      
				}
			}
	
			document.querySelector('#myInput').addEventListener('keyup', filterTable, false);
		</script>
		<script type="text/javascript">
			$(function () {
         		$("[id*=chkAllList]").bind("click", function () {
         			if ($(this).is(":checked")) {
         				$("[id*=cblBUList] input").attr("checked", "checked");
         			} else {
         				$("[id*=cblBUList] input").removeAttr("checked");
         			}
         		});
         		$("[id*=cblBUList] input").bind("click", function () {
         			if ($("[id*=cblBUList] input:checked").length == $("[id*=cblBUList] input").length) {
         				$("[id*=chkAllList]").attr("checked", "checked");
         			} else {
         				$("[id*=chkAllList]").removeAttr("checked");
         			}
         		});
         		
         		$("[id*=chkAllListClient]").bind("click", function () {
         			if ($(this).is(":checked")) {
         				$("[id*=cblClientList] input").attr("checked", "checked");
         			} else {
         				$("[id*=cblClientList] input").removeAttr("checked");
         			}
         		});
         		$("[id*=cblClientList] input").bind("click", function () {
         			if ($("[id*=cblClientList] input:checked").length == $("[id*=cblClientList] input").length) {
         				$("[id*=chkAllListClient]").attr("checked", "checked");
         			} else {
         				$("[id*=chkAllListClient]").removeAttr("checked");
         			}
         		});
			});
		</script>
	</body>
</HTML>
