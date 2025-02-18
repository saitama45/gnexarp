<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_stockanalysis_list.aspx.vb" Inherits="srx.inv_stockanalysis_list" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->

	<style>
	

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
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;Stock Analysis</b></h5>
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
							<%response.write("<a class='w3-hover-blue' href='inv_issuance_list'><span class='w3-button w3-large w3-hover-red w3-right'>x</span></a>")%>
							<P style="display:none"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
							</P>
							<div class="w3-row">
								<div class="w3-half">
									<div class="w3-container">
										<LABEL><B>SO #</B></LABEL><BR>
										<asp:label id="lblSONo" runat="server" CssClass="w3-input" Placeholder="type here..."></asp:label>
									</div>
								</div>
								<div class="w3-half">
									<div class="w3-container">
										<LABEL><B>SO Date</B></LABEL><BR>
										<asp:label id="lblSODate" runat="server" CssClass="w3-input" Placeholder="type here..."></asp:label>
									</div>
								</div>
							</div>							
							<br>
							<div class="w3-row">
								<div class="w3-half">
									<div class="w3-container">
										<LABEL><B>SI #</B></LABEL><BR>
										<asp:textbox tabIndex="1" id="txtSINo" runat="server" CssClass="w3-input" Placeholder="type here..." onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
									</div>
								</div>
								<div class="w3-half">
									<div class="w3-container">
										<LABEL><B>SI Date</B></LABEL><BR>
										<ew:calendarpopup tabIndex="2" id="calSIDate" style="Z-INDEX: 0" runat="server" Width="53%"
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
							<div class="w3-row">
								<div class="w3-half">
									<div class="w3-container">
										<LABEL><B>Customer</B></LABEL><BR>
										<asp:dropdownlist tabIndex="3" id="ddlClient" runat="server" CssClass="w3-tag w3-input w3-border w3-pale-blue w3-mobile myddl" AutoPostback="True"></asp:dropdownlist>
									</div>
								</div>
								<div class="w3-half">
									<div class="w3-container">
										<LABEL><B>Terms</B></LABEL><BR>
										<asp:textbox tabIndex="4" id="txtTerms" runat="server" CssClass="w3-input w3-white w3-border" required></asp:textbox>
									</div>
								</div>
							</div>						
							<br>
							<div class="w3-row">
								<div class="w3-half">
									<div class="w3-container">										
										<b><asp:CheckBox id="chbIsVatExclusive" runat="server" CssClass="checkbox-group" Text=" VAT Exclusive?" Checked="False"></asp:CheckBox>&nbsp;</b>
									</div>
								</div>
								<div class="w3-half">
									<div class="w3-container">										
										<b><asp:CheckBox id="chbIsNonVat" runat="server" CssClass="checkbox-group" Text=" Non-VAT?" Checked="False"></asp:CheckBox>&nbsp;</b>
									</div>
								</div>
							</div>						
							<br>
							<div class="w3-row">
								<div class="w3-half">
									<div class="w3-container">
										<LABEL><B>Discount (%)</B></LABEL><BR>
										<asp:textbox tabIndex="5" id="txtDiscount" runat="server" CssClass="w3-input w3-white w3-border" required></asp:textbox>
									</div>
								</div>
								<div class="w3-half">
									<div class="w3-container">
										<LABEL><B>Note</B></LABEL><BR>
										<asp:textbox tabIndex="6" id="txtNote" runat="server" CssClass="w3-input w3-border" TextMode="MultiLine" Maxlength="1000"></asp:textbox>
									</div>	
								</div>
							</div>
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER>
					</DIV>
				</asp:panel>
				<!-- End Input Form -->
				<asp:panel id="panelGrid" style="Z-INDEX: 0;" runat="server" Visible="True">
					<div class="w3-rest w3-padding w3-mobile">
						<div style="display:none;">
							<!-- #include file ="html\SearchAndButtons.html" -->
						</div>					
						<div class="w3-margin-bottom">
							<asp:dropdownlist id="ddlCompany" runat="server" Width="40%" CssClass="w3-input w3-text-small w3-mobile myddl" AutoPostBack="True"></asp:dropdownlist>	
						</div>												
						<!-- Sys Group Table -->
						<div class="w3-responsive">
							<TABLE id="tblGroupList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2"
								border="0">
								<tr>
									<th>
										<asp:datagrid id="DataGrid" runat="server" ShowFooter="True" CellPadding="3" Width="100%" Height="24px"
											BackColor="White" BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical"
											BorderStyle="None">
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
			$('#txtTerms,#txtDiscount').on('input', function(event) {

				// Get the current value
				var currentValue = $(this).val();

				// Remove any non-numeric characters
				var newValue = currentValue.replace(/[^\d.]/g, '');
								
				// Update the input value
				$(this).val(newValue);
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
	
			$(document).ready(function() {
				$('.checkbox-group input[type="checkbox"]').change(function() {
					var checked = $(this).prop('checked');
					$('.checkbox-group input[type="checkbox"]').not(this).prop('checked', false);
				});
			});
		</script>
	</body>
</HTML>
