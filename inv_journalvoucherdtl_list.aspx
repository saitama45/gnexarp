<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_journalvoucherdtl_list.aspx.vb" Inherits="srx.inv_journalvoucherdtl_list" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
		<script src="js/jquery.draggableTouch.js"></script>
		<style> 
			#mydivheader { cursor: move; z-index: 10; }
			p { font-size: 14px !important; color: black; }
			.btnImg { height : 30px; }
			.myForm { margin: auto; width: 410px; position: absolute; z-index: 10; background-color: #f1f1f1; }
			.dropdown-container {
				max-width: 100%;
				overflow: hidden;
			}
			.header_class {
				display: inline-block;
				width: 110px;					
			}
		</style>
	</HEAD>	
		<!-- #include file ="html\BodyColor.html" -->
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<FORM id="Form1" style="font: 400 14pt/normal Segoe UI; font: menu;" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main">
				<!-- Header -->
				<div style="margin-top: 40px;">
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;Journal Voucher Details</b></h5>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				<asp:panel id="panelForm" style="z-index: 0;" runat="server" Visible="False">
					<DIV class="w3-card-4 myForm" id="id01"><HEADER class="w3-light-grey w3-display-container w3-responsive" style="display: none;">
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox>
							</H2>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">
							<asp:button id="btnX" runat="server" UseSubmitBehavior="False" Text="x" CssClass="w3-button w3-large w3-hover-red w3-right"></asp:button>
							<P style="display: none;"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" Visible="False" CssClass="w3-tag w3-red"></asp:label>
							</P>
							<DIV class="w3-container">								
								<LABEL><B>Cost Center</B></LABEL>
								<div class="w3-right">
									<asp:CheckBox id="chbIsCustomer" runat="server" Text=" Customer Lists" AutoPostBack="True"></asp:CheckBox>&nbsp;
								</div>								
								<BR>
								<asp:dropdownlist id="ddlCostCenter" runat="server" CssClass="w3-input w3-tag w3-btn w3-bar-item w3-border w3-pale-blue w3-mobile myddl"></asp:dropdownlist>								
							</DIV>
							<BR>
							<DIV class="w3-container"><LABEL><B>Account Title</B></LABEL><BR>
								<asp:dropdownlist id="ddlCOA" runat="server" CssClass="w3-tag w3-btn w3-bar-item w3-border w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
							</DIV>
							<BR>
							<DIV class="w3-container"><LABEL><B>Particulars</B></LABEL><BR>
								<asp:textbox id="txtParticularsDTL" onkeypress="return clickButton(event,'btnSave')" runat="server"
									Placeholder="type here..." CssClass="w3-input"></asp:textbox>
							</DIV>
							<BR>
							<div class="w3-row">
								<div class="w3-half">
									<DIV class="w3-container"><LABEL><B>Debit</B></LABEL><BR>
										<asp:textbox id="txtDebit" onkeypress="return clickButton(event,'btnSave')" runat="server" Placeholder="0.00"
											required=""></asp:textbox>
									</DIV>
								</div>
								<div class="w3-half">
									<DIV class="w3-container"><LABEL><B>Credit</B></LABEL><BR>
										<asp:textbox id="txtCredit" onkeypress="return clickButton(event,'btnSave')" runat="server" Placeholder="0.00"
											required=""></asp:textbox>
									</DIV>
								</div>
							</div>
							<br>
							<DIV class="w3-container">
								<asp:CheckBox id="chbMultipleCostCenter" runat="server" Text=" Multiple Cost Center" Checked="False"></asp:CheckBox>&nbsp;
							</DIV>							
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER>
					</DIV>
				</asp:panel>
				<!-- End Input Form -->
				
				<asp:panel id="panelGrid" style="z-index: 0;" runat="server" Visible="True"> <!-- Header -->
					<DIV class="w3-row">
						<DIV class="w3-third">
							<DIV class="w3-container w3-blue">
								<DIV style="display: none;">
									<H5 class="w3-bar-item"><B><I class="fas fa-file-invoice"></I>&nbsp;Issuance</B></H5>
									<asp:hyperlink class="s6 w3-tag w3-khaki w3-margin-top w3-bar-item" id="hlViewFullHistory" runat="server"
										ToolTip="View transaction history. " Target="_blank">Audit Trail</asp:hyperlink>
								</DIV>
								<P>
									<asp:ImageButton id="btnBackImg" runat="server" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left"
										Tooltip="Back To List" ImageUrl="images/backarrow.png"></asp:ImageButton>
									<asp:ImageButton id="btnSaveImg" runat="server" CssClass="btnImg w3-hover-opacity w3-bar-item w3-right"
										Tooltip="Save" ImageUrl="images/save_image.png"></asp:ImageButton>									
								</P>
								<BR>
								<HR class="w3-bottombar w3-border-khaki">
								<P style="display: none;">
									PayVoucher ID:&nbsp;
									<asp:label class="w3-rest s6 w3-medium" id="lblPVID" runat="server" Font-Bold="True">0</asp:label>
								</P>
								<p>
									<label class="header_class">Company:&nbsp;</label>	
									<div class="dropdown-container">
										<asp:dropdownlist id="ddlCompany" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostback="True"></asp:dropdownlist>
									</div>																	
								</p>
								<p>
									<label class="header_class">Status:&nbsp;</label>
									<asp:label id="lblStatus" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
									<asp:dropdownlist id="ddlStatus" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Visible="False" AutoPostback="True">
										<asp:ListItem Value="ON PROCESS" Selected="True">ON PROCESS</asp:ListItem>
										<asp:ListItem Value="POSTED">POSTED</asp:ListItem>
										<asp:ListItem Value="CANCELLED">CANCELLED</asp:ListItem>
									</asp:dropdownlist>
								</p>
								<P>
									<label class="header_class">Voucher #:&nbsp;</label>
									<asp:label class="w3-rest s6 w3-medium" id="lblVoucherNo" runat="server" Font-Bold="True">0</asp:label>
								</P>
								<P>
									<label class="header_class">Date Incurred:&nbsp;</label>
									<ew:calendarpopup id="calDate" style="z-index: 0;" runat="server" ImageUrl="images/calendar-icon-mac.jpg"
										ControlDisplay="TextBoxImage" DisableTextboxEntry="False" AllowArbitraryText="False" CalendarLocation="Bottom"
										ShowGoToToday="True" Height="30px" Width="53%" AutoPostback="True">
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
								<P>
									<label class="header_class">Due Date:&nbsp;</label>
									<ew:calendarpopup id="calDueDate" style="z-index: 0;" runat="server" ImageUrl="images/calendar-icon-mac.jpg"
										ControlDisplay="TextBoxImage" DisableTextboxEntry="False" AllowArbitraryText="False" CalendarLocation="Bottom"
										ShowGoToToday="True" Height="30px" Width="53%" AutoPostback="True">
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
								<P>
									<label class="header_class">Particulars:&nbsp;</label>
									<asp:textbox id="txtParticulars" runat="server" CssClass="w3-input w3-white w3-border" TextMode="MultiLine" AutoPostback="True"></asp:textbox>
								</P>
								<div class="w3-row">
									<div class="w3-half">
										<P>
											<label class="header_class" style="color: red">Debit:&nbsp;</label>									
											<asp:label class="w3-rest s6 w3-medium" id="lblDebitHDR" runat="server" Font-Bold="True">0</asp:label>
										</P>
									</div>
									<div class="w3-half">
										<P>
											<label class="header_class" style="color: green">Credit:&nbsp;</label>									
											<asp:label class="w3-rest s6 w3-medium" id="lblCreditHDR" runat="server" Font-Bold="True">0</asp:label>
										</P>
									</div>
								</div>																
								<P style="display:none">
									<label class="header_class">PO Payable:&nbsp;</label>
									<asp:label class="w3-rest s6 w3-medium" id="lblPayable" runat="server" Font-Bold="True">0</asp:label>
								</P>
							</DIV> <!-- End Header -->
						</DIV>
						<DIV class="w3-rest w3-padding w3-mobile">
							<DIV style="display: none;">
								<asp:button id="btnPrint" runat="server" Text="Print DR" CssClass="w3-btn w3-ripple w3-indigo w3-bar-item w3-mobile"></asp:button>								
								<!-- #include file ="html\SearchAndButtons.html" -->
							</DIV>														

							<P>
								<asp:ImageButton id="btnAddImg" runat="server" UseSubmitBehavior="False" CssClass="btnImg w3-bar-item w3-hover-opacity"
									Tooltip="New Record" ImageUrl="images/additem.png"></asp:ImageButton>
								<asp:ImageButton id="btnPrintImg" runat="server" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right"
									Tooltip="Print Check Voucher" ImageUrl="images/printbtn.png" 	></asp:ImageButton>
								<asp:ImageButton id="btnReplicateImg" runat="server" ImageUrl="images/replicatebtn.png" Tooltip="Replicate" CssClass="btnImg w3-bar-item w3-hover-opacity w3-margin-left" />
							</P>							
							<BR>
							<P><!-- Sys Group Table -->
								<DIV class="w3-responsive w3-mobile">
									<TABLE class="w3-table-all w3-hoverable" id="tblGroupList" border="0" cellSpacing="0" cellPadding="2">
										<TR>
											<TH>
												<asp:datagrid id="DataGrid" runat="server" Height="24px" Width="100%" BorderStyle="None" GridLines="Vertical"
													AllowSorting="True" BorderColor="#999999" BorderWidth="1px" BackColor="White" CellPadding="3"
													ShowFooter="True">
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
												</asp:datagrid></TH></TR>
									</TABLE>
								</DIV> <!-- End Sys Group Table -->
							</P>
							
						</DIV>
					</DIV>
				</asp:panel>
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		<script>     
			function openCity(evt, cityName) {
				var i, x, tablinks;
				x = document.getElementsByClassName("city");
				for (i = 0; i < x.length; i++) {
					x[i].style.display = "none";
				}
				tablinks = document.getElementsByClassName("tablink");
				for (i = 0; i < x.length; i++) {
					tablinks[i].className = tablinks[i].className.replace(" w3-border-red", "");
				}
				document.getElementById(cityName).style.display = "block";
				evt.currentTarget.firstElementChild.className += " w3-border-red";
			};                   
            // Function to Disable comma when typing
			$('#txtDebit,#txtCredit,#txtPayableAmount').on('input', function(event) {

				// Get the current value
				var currentValue = $(this).val();
    
				// Remove any non-numeric characters
				var newValue = currentValue.replace(/[^\d.]/g, '');
								
				// Update the input value
				$(this).val(newValue);
			});
			
			$(function() { $("#id01").draggable(); });	
			
			$('.myddl').select2({
				dropdownCssClass: 'w3-pale-blue',
				selectionCssClass: 'w3-pale-blue'								
			});

			$(document).on('select2:open', () => {
				document.querySelector('.select2-search__field').focus();
			});

			$('input').click(function() {
				$(this).select(); 
			});
		</script>
	</body>
</HTML>
