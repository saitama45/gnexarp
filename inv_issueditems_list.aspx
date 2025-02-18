<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_issueditems_list.aspx.vb" Inherits="srx.inv_issueditems_list" %>
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
				margin: 8px
			}

			.btnImg {
				height : 30px;				
			}

			.myForm {
				margin: auto;
				width: 410px;
				position: absolute;
				z-index: 10;
				background-color: #f1f1f1;
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
		<FORM id="Form1" style="FONT: menu" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main">
				<!-- Header -->
				<div style="MARGIN-TOP: 40px">
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;Issuance Items</b></h5>
					<div style="display:none;">
						<asp:Label ID="lblCompany" runat="server" Visible="True"></asp:Label>
					</div>
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
								<LABEL><B>Warehouse</B></LABEL><BR>
								<asp:label id="lblSourceWarehouse" runat="server" Visible="False"></asp:label>
								<asp:dropdownlist id="ddlWarehouse" runat="server" CssClass="w3-tag w3-input w3-btn w3-bar-item w3-border w3-pale-blue w3-mobile myddl" AutoPostback="True"></asp:dropdownlist>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>Item Desc</B></LABEL><BR>
								<asp:dropdownlist tabIndex="1" id="ddlRawMats" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostBack="True" required></asp:dropdownlist>
							</div>
							<br>
							<div class="w3-container" style="display:none">
								<LABEL><B>Current SOH</B></LABEL><BR>
								<asp:label id="lblCurrentSOH" runat="server"></asp:label>
							</div>							
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
								<asp:textbox tabIndex="2" id="txtBarcode" runat="server" Placeholder="Scan barcode" CssClass="w3-input"></asp:textbox>
								<asp:CheckBox id="cbIsFree" runat="server" Text="Free?" CssClass="ComputedAmount" Autopostback="True"></asp:CheckBox>
							</div>																					
							<div class="w3-container">
								<LABEL><B>Qty</B></LABEL><BR>
								<asp:textbox id="txtQty" runat="server" CssClass="txtNumbers" Placeholder="0.00" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>								
							</div>		
							<br>
							<div class="w3-container">		
								<asp:label id="lblAmount" runat="server" Visible="False"></asp:label>								
								<input type="text" id="lblResult" runat="server" style="border: 0; FONT-SIZE: 20px;" class="w3-text-red w3-light-grey w3-input w3-responsive" Autopostback="True" readonly>
							</div>
							<div class="w3-container">
								<LABEL><B>SRP</B></LABEL><BR>
									<asp:textbox id="txtSRP" runat="server" Placeholder="0.00" CssClass="w3-input w3-border txtNumbers" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
									<div style="display:none">
										<asp:label id="lblSRP" runat="server" CssClass="w3-tag w3-red"></asp:label>
									</div>							
							</div>
							<div class="w3-container">
								<LABEL><B>Note</B></LABEL><BR>
									<asp:textbox id="txtNote2" runat="server" Placeholder="Type here..." CssClass="w3-input" TextMode="MultiLine" Maxlength="1000"></asp:textbox>																					
							</div>													
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER>
					</DIV>
				</asp:panel>
				<asp:panel id="panelForm2" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 myForm">
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">																			
							<H4 class="w3-center">
								<asp:label id="lblMode2" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction2" runat="server" Visible="true"></asp:textbox>
							</H4>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">
							<asp:button id="btnX2" CssClass="w3-button w3-large w3-hover-red w3-right" runat="server" Text="x" UseSubmitBehavior="False"></asp:button>
							<P style="display:none"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID2" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
							</P>														
							<div class="w3-container">
								<LABEL><B>Part Number</B></LABEL><BR>
									<asp:textbox id="txtSKUCode" runat="server" CssClass="w3-input" onkeypress="return clickButton(event,'btnSave2')"></asp:textbox>
							</div>	
							<br>
							<div class="w3-container">
								<LABEL><B>Item Desc</B></LABEL>
								<asp:textbox id="txtItemDesc" runat="server" CssClass="w3-input" onkeypress="return clickButton(event,'btnSave2')" required></asp:textbox>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>Qty</B></LABEL>
								<asp:textbox id="txtDRQty" runat="server" CssClass="w3-input txtNumbers" onkeypress="return clickButton(event,'btnSave2')" required></asp:textbox>
							</div>														
						</div>
						<FOOTER class="w3-container"> 
							<DIV class="w3-border-top">
								<P>
									<asp:button id="btnSave2" CssClass="OnClick: document.getElementById('AlertSuccess').style.display='block'; class: w3-btn w3-green w3-block w3-large" runat="server" Text="Save"></asp:button>									     
								</P>    
							</DIV>						
						</FOOTER>
					</DIV>												
				</asp:panel>
				
				<!-- End Input Form -->
				
					<!-- Header -->
					<div class="w3-row">
						<div class="w3-third">
							<div class="w3-container w3-blue">
								<div style="display:none">
									<h5 class="w3-bar-item"><b><i class="fas fa-file-invoice"></i>&nbsp;Issuance</b></h5>
									<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top w3-bar-item" runat="server" Target="_blank" ToolTip="View transaction history. ">Audit Trail</asp:hyperlink>
									<asp:button id="btnBackToList" CssClass="Style: Class= w3-btn w3-ripple w3-khaki w3-bar-item w3-margin-top w3-mobile w3-right" runat="server" Text="Back to list"></asp:button>
								</div>
								<p>
									<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />
									<asp:ImageButton id="btnSaveImg" runat="server" ImageUrl="images/save_image.png" Tooltip="Save" CssClass="btnImg w3-hover-opacity w3-bar-item w3-right" />
								</p> <br>
								<hr class="w3-bottombar w3-border-khaki">
								<p style="display:none"> Invoice #:&nbsp; <asp:label id="lblInvoiceNo" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
									<asp:label id="lblISSID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								</p>
								<p style="display:none"> Warehouse:&nbsp; <asp:label id="lblWarehouse" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>
									<asp:label id="lblDRItemsID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								</p>
								<div class="w3-row">
									<div class="w3-half">
										<p> <label class="header_class">Ref #:&nbsp;</label><br>
											<asp:label id="lblDRCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
										</p>
									</div>
									<div class="w3-half">
										<p> <label class="header_class">DR #:&nbsp;</label><br>
											<asp:textbox id="txtDRNo" runat="server" CssClass="w3-input w3-white w3-border" AutoPostback="True"></asp:textbox>
										</p>
									</div>
								</div>
								<div class="w3-row">
									<div class="w3-half">
										<p> <label class="header_class">DR Date:&nbsp;</label>
											<asp:label id="lblDRDate" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
											<ew:calendarpopup id="calDRDate" style="Z-INDEX: 0" runat="server" Width="53%" Height="30px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False" ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage">
												<WeekdayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black" BackColor="White"></WeekdayStyle>
												<MonthHeaderStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black" BackColor="#8080FF"></MonthHeaderStyle>
												<OffMonthStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Gray" BackColor="AntiqueWhite"></OffMonthStyle>
												<GoToTodayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black" BackColor="White"></GoToTodayStyle>
												<TodayDayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black" BackColor="LightGoldenrodYellow"></TodayDayStyle>
												<DayHeaderStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black" BackColor="MediumSeaGreen"></DayHeaderStyle>
												<WeekendStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black" BackColor="LightGray"></WeekendStyle>
												<SelectedDateStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black" BackColor="Yellow"></SelectedDateStyle>
												<ClearDateStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black" BackColor="White"></ClearDateStyle>
												<HolidayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black" BackColor="White"></HolidayStyle>
											</ew:calendarpopup>
										</p>
									</div>
									<div class="w3-half">
										<P> <label class="header_class">Status:&nbsp;</label><br>
											<asp:label id="lblStatus" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
										</P>
									</div>
								</div>
								<div class="w3-row">
									<div class="w3-half">
										<p> <label class="header_class">BU:&nbsp;</label><br>
											<asp:dropdownlist id="ddlCompany" runat="server" CssClass="w3-tag w3-input w3-border w3-pale-blue w3-mobile myddl" AutoPostback="True"></asp:dropdownlist>
										</p>
									</div>
									<div class="w3-half">
										<p> <label class="header_class">Terms:&nbsp;</label><br>
											<asp:textbox id="txtTerms" runat="server" CssClass="w3-input w3-white w3-border" AutoPostback="True"></asp:textbox>
										</p>
									</div>
								</div>
								<div class="w3-row">
									<div class="w3-half">
										<p> <label class="header_class">Issued To:&nbsp;</label><br>
											<asp:label id="lblClientName" runat="server" CssClass="w3-medium" Font-Bold="True" Visible="False"></asp:label>
											<asp:dropdownlist id="ddlClient" runat="server" CssClass="w3-tag w3-input w3-border w3-pale-blue w3-mobile myddl" AutoPostback="True"></asp:dropdownlist>
										</p>
									</div>
									<div class="w3-half">
										<p> <label class="header_class">Delivered By:&nbsp;</label><br>
											<asp:textbox id="txtDeliveredBy" runat="server" CssClass="w3-input w3-white w3-border" AutoPostback="True"></asp:textbox>
										</p>
									</div>
								</div>
								<div class="w3-row">
									<p> Delivery Cost:&nbsp; <asp:textbox id="txtDeliveryCost" runat="server" CssClass="w3-input w3-white w3-border txtNumbers" AutoPostback="True">0</asp:textbox>
									</p>
								</div>
								<div class="w3-row">
									<p> Note:&nbsp; <asp:textbox id="txtNote" runat="server" CssClass="w3-input w3-border w3-white" TextMode="MultiLine" Maxlength="1000" Enabled="False" AutoPostback="True"></asp:textbox>
									</p>
								</div>
								<p style="display:none"> Net Amount:&nbsp; <asp:label id="lblNetAmount" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>
								</p>
							</div> <!-- End Header -->
						</div>
						<asp:panel id="panelGrid2" style="Z-INDEX: 0;" runat="server" Visible="False">
					
						<div class="w3-rest w3-padding w3-mobile">
							<p>
								<asp:ImageButton id="btnBackImg2" runat="server" ImageUrl="images/backarrow_yellow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />
								<asp:ImageButton id="btnAddImg2" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity" />														
							</p>	
							<br>						
							<p>								
								<!-- Sys Group Table -->
								<div class="w3-responsive">
									<TABLE id="tblGroupList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2"
										border="0">
										<tr>
											<th>
												<asp:datagrid id="DataGrid2" runat="server" ShowFooter="True" CellPadding="3" Width="100%" Height="24px"
													BackColor="White" BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical"
													BorderStyle="None" Cssclass="myDataGrid">
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
					</asp:panel>
					<asp:panel id="panelGrid" style="Z-INDEX: 0;" runat="server" Visible="True">
						<div class="w3-rest w3-padding w3-mobile">
							<div style="display:none">
								<asp:button id="btnPrint" CssClass="w3-btn w3-ripple w3-indigo w3-bar-item w3-mobile" runat="server" Text="Print DR"></asp:button>
								<p style="display:none">
									<asp:label id="lblSelectWarehouse" runat="server"><b>Select Warehouse</b>&nbsp;</asp:label>
								</p> <!-- #include file ="html\SearchAndButtons.html" -->
							</div>
							<p>
								<asp:ImageButton id="btnAddImg" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity" UseSubmitBehavior="False" />
								<asp:ImageButton id="btnPrintImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print DR" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" />
							</p> <br><br>
							<p>
								<!-- Sys Group Table -->
							<div class="w3-responsive w3-mobile">
								<TABLE id="tblGroupList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2" border="0">
									<tr>
										<th>
											<asp:datagrid id="DataGrid" runat="server" ShowFooter="True" CellPadding="3" Width="100%" Height="24px" BackColor="White" BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical" BorderStyle="None">
												<FooterStyle ForeColor="White" BackColor="#708090"></FooterStyle>
												<SelectedItemStyle Font-Bold="True" ForeColor="Black" CssClass="w3-pale-blue" BackColor="Green"></SelectedItemStyle>
												<EditItemStyle></EditItemStyle>
												<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
												<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
												<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#708090"></HeaderStyle>
												<Columns>
													<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Cancel" EditText="Edit"></asp:EditCommandColumn>
													<asp:ButtonColumn Text="Delete" CommandName="Delete"></asp:ButtonColumn>
													<asp:ButtonColumn Text="Open" CommandName="Open"></asp:ButtonColumn>
												</Columns>
												<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
											</asp:datagrid>
										</th>
									</tr>
								</TABLE>
							</div> <!-- End Sys Group Table -->
							</p>
						</div>
					</div>
				</asp:panel>																		
			
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

			// Function to Disable comma when typing
			$('.txtNumbers').on('input', function(event) {

				// Get the current value
				var currentValue = $(this).val();

				// Remove any non-numeric characters
				var newValue = currentValue.replace(/[^\d.]/g, '');
								
				// Update the input value
				$(this).val(newValue);
			});

			$(function() { $("#id01").draggable(); });	

			$('#txtSRP, #txtQty').keyup(function(){
				// skip for arrow keys
				if(event.which >= 37 && event.which <= 40) return;

				var srp = parseFloat($("#txtSRP").val());
				var qty = parseFloat($("#txtQty").val());		
				var res = srp * qty;
				
				$("#lblResult").val(res.toFixed(2).toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,"));				
								
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

				// Check if the company text is not "COSMOMED"
				if (companyText !== "COSMOMED") {
					// Hide the third column of DataGrid3
					$('#<%= Datagrid.ClientID %> tr td:nth-child(3)').hide();									
				}
				
			});
		</script>
		
	</body>
</HTML>
