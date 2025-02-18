<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_paiddtl_list.aspx.vb" Inherits="srx.inv_paiddtl_list" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->	
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->	
		<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
		<script src="js/jquery.draggableTouch.js"></script>

		<!-- Toastr -->
		<link rel="stylesheet" type="text/css" href="css/toastr.min.css">
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

			.btnLCostImg {
				height : 35px;				
			}

			.myForm {
				margin: auto;
				width: 410px;
				position: absolute;
				z-index: 10;
				background-color: #f1f1f1;
			}

			.dropdown-container {
				max-width: 100%;
				overflow: hidden;
			}

			.w3-table-all tr th:nth-child(1),
			.w3-table-all tr td:nth-child(1),
			.w3-table-all tr th:nth-child(2),
			.w3-table-all tr td:nth-child(2) {
				display: none;
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
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;Batch Payment</b></h5>
					<div style="display:none;">
						<asp:Label ID="lblCompany" runat="server" Visible="True"></asp:Label>
					</div>					
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->

				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
																
				</asp:panel>				
				<!-- Header -->			
				<div class="w3-row">
					<div class="w3-third">
						<div class="w3-container w3-blue">	
							<div style="display:none">								
								<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top" runat="server"
								Target="_blank" ToolTip="View transaction history. ">Audit Trail</asp:hyperlink>	
								<asp:label id="lblBalance" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>		
								<asp:label id="lblID" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>												
								<asp:textbox id="txtFormAction" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:textbox>												
							</div>
							<p>
								<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />
								<asp:ImageButton id="btnSaveImg" runat="server" ImageUrl="images/save_image.png" Tooltip="Save" CssClass="btnImg w3-hover-opacity w3-bar-item w3-right" />								
							</p>										
							<br>																												
							<hr class="w3-bottombar w3-border-khaki">	
							<p><LABEL><B>BU</B></LABEL><BR>
								<asp:dropdownlist id="ddlCompany" runat="server" CssClass="w3-tag w3-input w3-border w3-pale-blue w3-mobile myddl" required></asp:dropdownlist>
							</p>	
							<p><LABEL><B>Account Name</B></LABEL><BR>
								<asp:dropdownlist id="ddlCustomer" runat="server" CssClass="w3-tag w3-input w3-border w3-pale-blue w3-mobile myddl" required></asp:dropdownlist>
							</p>						
							<p>
								Remitted Date:&nbsp;<br>
								<ew:calendarpopup id="calRemittedDate" style="Z-INDEX: 0" runat="server" VisibleDate="2015-11-13"
									CellPadding="2px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
									ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" >
									<WEEKDAYSTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></WEEKDAYSTYLE>
									<MONTHHEADERSTYLE BackColor="#8080FF" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></MONTHHEADERSTYLE>
									<OFFMONTHSTYLE BackColor="AntiqueWhite" ForeColor="Gray" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></OFFMONTHSTYLE>
									<GOTOTODAYSTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></GOTOTODAYSTYLE>
									<TODAYDAYSTYLE BackColor="LightGoldenrodYellow" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></TODAYDAYSTYLE>
									<DAYHEADERSTYLE BackColor="Orange" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></DAYHEADERSTYLE>
									<WEEKENDSTYLE BackColor="LightGray" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></WEEKENDSTYLE>
									<SELECTEDDATESTYLE BackColor="Yellow" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></SELECTEDDATESTYLE>
									<CLEARDATESTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></CLEARDATESTYLE>
									<HOLIDAYSTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></HOLIDAYSTYLE>
								</ew:calendarpopup>
							</p>	
							<p>
								OR Date:&nbsp;<br>
								<ew:calendarpopup id="calORDate" style="Z-INDEX: 0" runat="server" VisibleDate="2015-11-13"
									CellPadding="2px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
									ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" >
									<WEEKDAYSTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></WEEKDAYSTYLE>
									<MONTHHEADERSTYLE BackColor="#8080FF" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></MONTHHEADERSTYLE>
									<OFFMONTHSTYLE BackColor="AntiqueWhite" ForeColor="Gray" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></OFFMONTHSTYLE>
									<GOTOTODAYSTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></GOTOTODAYSTYLE>
									<TODAYDAYSTYLE BackColor="LightGoldenrodYellow" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></TODAYDAYSTYLE>
									<DAYHEADERSTYLE BackColor="Orange" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></DAYHEADERSTYLE>
									<WEEKENDSTYLE BackColor="LightGray" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></WEEKENDSTYLE>
									<SELECTEDDATESTYLE BackColor="Yellow" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></SELECTEDDATESTYLE>
									<CLEARDATESTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></CLEARDATESTYLE>
									<HOLIDAYSTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
										Font-Size="Medium"></HOLIDAYSTYLE>
								</ew:calendarpopup>
							</p>
							<p>
								<span>OR No.</span>:&nbsp;								
								<asp:textbox id="txtORNo" runat="server" CssClass="w3-input w3-white w3-border"></asp:textbox>
							</p>	
							<P><span>OR Amount</span>:&nbsp;		
								<asp:textbox id="txtORAmount" runat="server" Placeholder="0.00" CssClass="w3-input amount"></asp:textbox>
							</P>																			
							<p>
								Payment Type:&nbsp;								
								<asp:dropdownlist id="ddlPayType" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True">
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
							</p>
							<P>Remarks:&nbsp;		
								<asp:textbox id="txtRemarks" runat="server" CssClass="w3-input w3-border" TextMode="MultiLine"></asp:textbox>
							</P>
							<asp:panel id="panelBank" style="Z-INDEX: 0" runat="server" Visible="True">
								<p>
									Bank:&nbsp;								
									<asp:dropdownlist id="ddlBank" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl">									
									</asp:dropdownlist>
								</p>
							</asp:panel>
							<asp:panel id="panelCard" style="Z-INDEX: 0" runat="server" Visible="True">
								<div class="w3-border w3-container">
									<P><LABEL><B>Card #</B></LABEL><BR>
										<asp:textbox id="txtCardNo" runat="server" Placeholder="type here..." CssClass="w3-input amount" Enabled="False" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
									</P>
									<P><LABEL><B>Approval #</B></LABEL><BR>
										<asp:textbox id="txtApprovalNo" runat="server" Placeholder="type here..." CssClass="w3-input amount" Enabled="False" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
									</P>
									<P><LABEL><B>Bank Charge %</B></LABEL><BR>
										<asp:textbox id="txtBankCharge" runat="server" Placeholder="0.00" CssClass="w3-input amount" Enabled="False" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
									</P>
								</div>
							</asp:panel>
							<asp:panel id="panelCheck" style="Z-INDEX: 0" runat="server" Visible="True">
								<div class="w3-border w3-container">									
									<P><LABEL><B>Cheque #</B></LABEL><BR>
										<asp:textbox id="txtCheckNo" runat="server" Placeholder="0.00" CssClass="w3-input amount" Enabled="False" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>								
									</P>
								
									<P><LABEL><B>Cheque Date</B></LABEL><BR>
										<ew:calendarpopup id="calCheckDate" style="Z-INDEX: 0" runat="server"
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
							</asp:panel>
							<P><LABEL><B>Deposited Cheque Date</B></LABEL><BR>
								<ew:calendarpopup id="calDepositedCheckDate" style="Z-INDEX: 0" runat="server"
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
					</div>
				<!-- End Input Form -->
				
				<asp:panel id="panelGrid" style="Z-INDEX: 0;" runat="server" Visible="True">										
						<div class="w3-rest w3-padding w3-mobile">
							<div style="display:none">						
								
								<asp:button id="btnSaveAmount" class="btn btn-primary" runat="server" Text="Save" Visible="True"></asp:button>
								<asp:textbox id="txtSessionFullname" runat="server" Visible="true"></asp:textbox>
								
								<asp:textbox id="txtHeaderID" runat="server" Placeholder="txtHeaderID" Visible="True">0</asp:textbox>							
								<asp:textbox id="txtSysID" Placeholder="txtSysID" runat="server"></asp:textbox>
								<asp:textbox id="txtAppliedPaymentValue" runat="server" Placeholder="txtAppliedPaymentValue" Visible="True">0</asp:textbox>
								<asp:textbox id="txtWTaxAmountValue" runat="server" Placeholder="txtWTaxAmountValue" Visible="True">0</asp:textbox>
								<asp:textbox id="txtDeductionValue" runat="server" Placeholder="txtDeductionValue" Visible="True">0</asp:textbox>
								<asp:textbox id="txtDiscountValue" runat="server" Placeholder="txtDiscountValue" Visible="True">0</asp:textbox>
								<asp:textbox id="txtPayTypeValue" runat="server" Placeholder="txtDiscountValue" Visible="True">0</asp:textbox>
								<asp:textbox id="txtGroup" runat="server" Placeholder="txtGroup" Visible="True">0</asp:textbox>

								<!-- #include file ="html\SearchAndButtons.html" -->
								<div class="w3-row-container">
									<asp:ImageButton id="btnAddImg" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity" />
								</div>
								<br>
								<div class="w3-row-container">
									<asp:datagrid id="DataGrid" runat="server" ShowFooter="True" Width="100%"
										 BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical"
										BorderStyle="None" Cssclass="w3-table-all w3-hoverable">
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
								</div>					
							</div>								
							<br>								
							<p>									

								<div class="w3-container" style="height: 400px; overflow-y: scroll;">
									<!-- Sys Group Table -->
									<table class="w3-table-all w3-hoverable w3-card-4 w3-centered">
					
										<tr class="w3-blue-grey">
											<th><input class="chkHeader" type="checkbox"></th>
											<th>ID</th>
											<th>Invoice No.</th>
											<th>Date</th>																						
											<th>AR</th>
											<th>Amount to Apply</th>																		
											<th>Withholding Tax</th>
											<th>Deductions</th>
											<th>Discount</th>
											<th>Payments</th>
											<th>Balance</th>
										</tr>									
										<asp:Literal ID="litTableRows" runat="server"></asp:Literal>
									</table>
									<!-- End Sys Group Table -->
								</div>
							</p>
							<div class="w3-row-container">
								<div class="w3-container w3-third">
									<label><b>OR Amount:</b></label>
									<asp:textbox id="txtAmountReceived" runat="server" class="w3-large w3-white w3-input" disabled></asp:textbox>									
								</div>
								<div class="w3-container w3-third">
									<label><b>Applied:</b></label>									
									<asp:textbox id="txtApplied" runat="server" class="w3-large w3-white w3-input" disabled></asp:textbox>
								</div>	
								<div class="w3-container w3-third">
									<label><b>To Apply:</b></label>									
									<asp:textbox id="txtToApply" runat="server" class="w3-large w3-white w3-input" disabled></asp:textbox>
								</div>							
							</div>								
						</div>							
																		
				</asp:panel>
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		<script type="text/javascript" src="js/toastr.min.js"></script>
		<script>                        
           // Function to Disable comma when typing
			$('.txtNumbers, .txtAppliedPayment, .txtWTaxAmount, .txtDeduction').on('input', function(event) {

				// Get the current value
				var currentValue = $(this).val();

				// Remove any non-numeric characters
				var newValue = currentValue.replace(/[^\d.]/g, '');
								
				// Update the input value
				$(this).val(newValue);
			});

			$(function() { $("#id01").draggable(); });	
			
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

			$(document).ready(function () {
				// Add an input event handler to the <input type="text">
				$(".tdAppliedPayment input[type='text']").on('input', function () {
					updateFormValues($(this));
				});
			
				$(".tdWTaxAmount input[type='text']").on('input', function () {
					updateFormValues($(this));
				});

				$(".tdtxtDeduction input[type='text']").on('input', function () {
					updateFormValues($(this));
				});

				$(".tdtxtDiscount input[type='text']").on('input', function () {
					updateFormValues($(this));
				});
			
				// Add a change event handler to the <input type="text">
				$(".tdAppliedPayment input[type='text'], .tdWTaxAmount input[type='text'], .tdtxtDeduction input[type='text'], .tdtxtDiscount input[type='text']").on('change', function () {
					// Trigger the form submission when the value changes
					$("#btnSaveAmount").click();
				});
			
				// Add a keyup event handler for "Enter" key press
				$(".tdAppliedPayment input[type='text']").on('keyup', function (event) {
					if (event.keyCode === 13) { // 13 is the keycode for "Enter"
						// Prevent the default Enter key behavior (form submission)
						event.preventDefault();
			
						// Trigger the click event of #btnSaveAmount
						$("#btnSaveAmount").click();
					}
				});	

				// Initialize the total balance from the value of td with class .tdtxtBalance
				var totalBalance = parseFloat($(".tdtxtBalance").text().replace(/,/g, '')) || 0;

				// Update total sum and applied amount on page load
				updateTotalSum();
    			updateToApply();
				
				// Add an input event handler to all input type='text' elements within <td>
				$("td input[type='text']").on('input', function () {
					updateTotalSum($(this));
					updateToApply($(this));
					validateInput($(this));
				});
			
				// Event handler for #btnSaveAmount click
				$("#btnSaveAmount").click(function (e) {
					// Prevent the default form submission behavior
					e.preventDefault();
			
					// Your form data
					var formData = $("#Form1").serialize(); // Replace "yourFormId" with the actual ID of your form
			
					// Additional parameters for your stored procedure
					var additionalData = {
						FormAction: "Save",
						header_id: $("#txtHeaderID").val(),
						iss_id: $("#txtSysID").val(),
						pay_type: $("#txtPayTypeValue").val(),
						applied_amount: $("#txtAppliedPaymentValue").val(),
						wtax_amount: $("#txtWTaxAmountValue").val(),
						deduction_amount: $("#txtDeductionValue").val(),
						discount_amount: $("#txtDiscountValue").val(),
						Session_fullname: $("#txtSessionFullname").val(), // Replace with the actual ID of your session element	
					};
			
					// Combine form data and additional parameters
					var requestData = formData + "&" + $.param(additionalData);
			
					// AJAX request
					$.ajax({
						type: "POST",
						url: "inv_paiddtl_list.aspx",
						data: additionalData,
						success: function (response) {
							// Handle the success response
							console.log("Form submitted successfully");
			
							// Display a success toast
							toastr.options.positionClass = "toast-bottom-right";
							toastr.success('Successfully Saved!');
			
							updateTotalSum();
							// Call the function to load the grid
							//loadItemDiscount();

							// var tbody = $(".w3-table-all tbody");

							// // Find the row with the standard_srp
							// var standardsrpValue = $(".iss_id:contains('" + additionalData.id + "')").siblings(".standardsrp").text();

							// // Find the row with the matching iss_id
							// var rowToUpdate = tbody.find("tr:not(.w3-blue) .iss_id:contains(" + additionalData.id + ")").closest('tr');

							// // Check if a matching row is found
							// if (rowToUpdate.length > 0) {
							// 	// Parse numeric values
							// 	standardsrpValue = parseFloat(standardsrpValue);
							// 	var srp = parseFloat(additionalData.srp);

							// 	// Calculate the expression
							// 	var newDiscount = 0;
							// 	if (!isNaN(standardsrpValue) && !isNaN(srp) && standardsrpValue !== 0) {
							// 		newDiscount = ((standardsrpValue - srp) / standardsrpValue) * 100.0;
							// 		newDiscount = parseFloat(newDiscount.toFixed(2)); // Parse as float and round to 2 decimal places
							// 	}
							// 	newDiscount = isNaN(newDiscount) ? 0 : newDiscount;

							// 	// Update the discount value in the corresponding td with class "discount"
							// 	rowToUpdate.find(".discount").text(newDiscount.toFixed(2)); // Assuming you want to round to 2 decimal places
							// } else {
							// 	console.log("No matching row found for iss_id: " + additionalData.id);
							// }
							
						},
						error: function (error) {
							// Handle the error response
							console.error("Error submitting form: ", error);
						}
					});
				});
			
				// Function to load the customer item grid
				function loadItemDiscount() {
					// Make an AJAX request to fetch the updated data
					$.ajax({
						type: "GET",
						url: "aLoadCustomerItemGrid.aspx?id=" + $("#txtSysID").val(),
						success: function (response) {
							// Handle the success response
			
							// Replace the content of the table body
							var newDiscount = response; // Assuming your AJAX response contains the new discount value
							var tbody = $(".w3-table-all tbody");
							var sysIdToUpdate = $("#txtSysID").val(); // Get the iss_id value to update
			
							// Find the row with the matching iss_id
							var rowToUpdate = tbody.find("tr:not(.w3-blue) .iss_id:contains(" + sysIdToUpdate + ")").closest('tr');
			
							// Update the discount value in the corresponding td with class "discount"
							rowToUpdate.find(".discount").text(newDiscount);
			
							console.log("Customer item grid loaded successfully");
							// You can perform additional actions if needed
						},
						error: function (error) {
							// Handle the error response
							console.error("Error loading customer item grid: ", error);
							// You can perform additional actions if needed
						}
					});
				}
			
				// Function to update form values
				function updateFormValues(input) {
					// Get the Sys ID from the first <td> in the same row
					var sysId = input.closest('tr').find('.iss_id').text();

					// Determine which textbox to update based on the input's parent's class
					var parentClass = input.parent().attr('class');

					// Convert the input value to '0.00' if the user types '0'
					var inputValue = parseFloat(input.val().replace(/,/g, '')) || 0;
					input.val(inputValue === 0 ? '0.00' : input.val());

					switch (parentClass) {
						case 'tdAppliedPayment':
							$("#txtAppliedPaymentValue").val(input.val());
							var selectedPayType = $("#ddlPayType").val();
							$("#txtPayTypeValue").val(selectedPayType);

							$("#txtWTaxAmountValue").val('0.00'); // Set to '0.00' immediately
							$("#txtDeductionValue").val('0.00'); // Set to '0.00' immediately
							$("#txtDiscountValue").val('0.00'); // Set to '0.00' immediately
							updateTotalSum('.tdAppliedPayment', '#txtApplied');
							break;
						case 'tdWTaxAmount':
							$("#txtWTaxAmountValue").val(input.val());
							$("#txtPayTypeValue").val('WITHHOLDING TAX');

							$("#txtAppliedPaymentValue").val('0.00'); // Set to '0.00' immediately
							$("#txtDeductionValue").val('0.00'); // Set to '0.00' immediately
							$("#txtDiscountValue").val('0.00'); // Set to '0.00' immediately
							break;
						case 'tdtxtDeduction':
							$("#txtDeductionValue").val(input.val());
							$("#txtPayTypeValue").val('DEDUCTIONS');

							$("#txtAppliedPaymentValue").val('0.00'); // Set to '0.00' immediately
							$("#txtWTaxAmountValue").val('0.00'); // Set to '0.00' immediately
							$("#txtDiscountValue").val('0.00'); // Set to '0.00' immediately
							break;
						case 'tdtxtDiscount':
							$("#txtDeductionValue").val('0.00'); // Set to '0.00' immediately
							$("#txtAppliedPaymentValue").val('0.00'); // Set to '0.00' immediately
							$("#txtWTaxAmountValue").val('0.00'); // Set to '0.00' immediately

							$("#txtDiscountValue").val(input.val());
							$("#txtPayTypeValue").val('DEDUCTIONS');
							break;
						default:
							break;
					}

					// Always update the Sys ID
					$("#txtSysID").val(sysId);
					
				}

				// Function to update the total sum and set it in #txtApplied
				function updateTotalSum(input) {
					var totalSum = 0;

					// Iterate over all input type='text' elements within <td> and sum up the values
					// $("td input[type='text']").not(input).each(function () {
					// 	var value = parseFloat($(this).val()) || 0;
					// 	totalSum += value;
					// });

					$("td input[type='text']").not(input).each(function () {
						totalSum += parseFloat($(this).val().replace(/,/g, '')) || 0;
					});
					
					// Update #txtApplied with the total sum formatted with commas
					$("#txtApplied").val(totalSum.toLocaleString('en-US', { minimumFractionDigits: 2, maximumFractionDigits: 2 }));

					 // Update #txtToApply based on the difference between #txtAmountReceived and #txtApplied
					 updateToApply();
				}

				// Function to update #txtToApply based on the difference between #txtAmountReceived and #txtApplied
				function updateToApply() {
					var amountReceived = $("#txtAmountReceived").val().replace(/,/g, '') || 0;
					var applied = $("#txtApplied").val().replace(/,/g, '') || 0;

					// Calculate the difference and update #txtToApply
					var toApply = amountReceived - applied;
					console.log(toApply);
					$("#txtToApply").val(toApply.toLocaleString('en-US', { minimumFractionDigits: 2, maximumFractionDigits: 2 }));					

					// Check conditions to disable textboxes
					var txtGroupValue = $("#txtGroup").val();
					if (txtGroupValue !== "GENADMIN" && toApply === 0) {
						$("td input[type='text']").prop('disabled', true);
						$("#calRemittedDate, #calORDate, #txtORNo, #txtORAmount, #txtCardNo, #txtApprovalNo, #txtBankCharge, #txtCheckNo, #calCheckDate, #calDepositedCheckDate").prop('disabled', true);
						$("select").prop('disabled', true);
						$("textarea").prop('disabled', true);
						$("a[href='javascript:calRemittedDate_Up_CallClick();'], a[href='javascript:calORDate_Up_CallClick();'], a[href='javascript:calCheckDate_Up_CallClick();'], a[href='javascript:calDepositedCheckDate_Up_CallClick();']").hide();
						$("#btnSaveImg").hide();
					} else {
						$("td input[type='text']").prop('disabled', false);
						//$("#txtCardNo, #txtApprovalNo, #txtBankCharge, #ddlBank, #txtCheckNo, #calCheckDate").prop("disabled", false);						
					}
				}

				// Function to validate input and ensure it doesn't exceed the total balance
				function validateInput(input) {					
					var amountReceived = parseFloat($("#txtAmountReceived").val().replace(/,/g, '')) || 0;
    				var totalApplied = 0;													

					// Calculate the total applied amount from all input type='text' elements within <td>
					$("td input[type='text']").not(input).each(function () {
						totalApplied += parseFloat($(this).val().replace(/,/g, '')) || 0;
					});
					//console.log(totalApplied);
					// If the total applied amount, including the current input, exceeds the amount received, set it to the amount received
					var inputValue = parseFloat(input.val().replace(/,/g, '')) || 0;
					if (totalApplied + inputValue > amountReceived) {
						var remainingValue = amountReceived - totalApplied;

						// Update the input value with the remaining value
						input.val(remainingValue);	
						
						// Update corresponding form values after validation
						updateFormValues(input);
					}
				}
			});

			$(document).ready(function () {
				// Initial assignment on page load
				updateTxtPayTypeValue();

				// Add a change event handler to #ddlPayType
				$("#ddlPayType").change(function () {
					updateTxtPayTypeValue();
					
				});

				$("#ddlPayType").on("change", function () {
					
					var selectedValue = $(this).val();

					// Reset all fields
					$("#txtCardNo, #txtApprovalNo, #txtBankCharge, #ddlBank, #txtCheckNo, #calCheckDate").val("");
					$("#txtCardNo, #txtApprovalNo, #txtBankCharge, #ddlBank, #txtCheckNo, #calCheckDate").prop("disabled", true);

					// Enable/disable fields based on the selected value
					if (selectedValue === "CARD" || selectedValue === "DEBITCARD") {
						$("#txtCardNo, #txtApprovalNo, #txtBankCharge, #ddlBank").prop("disabled", false);
						$("#txtCheckNo, #calCheckDate").prop("disabled", true);
					} else if (selectedValue === "CHEQUE") {
						$("#txtCheckNo, #calCheckDate, #ddlBank").prop("disabled", false);
						$("#txtCardNo, #txtApprovalNo, #txtBankCharge").prop("disabled", true);
					} else if (selectedValue === "BANK" || selectedValue === "GCASH" || selectedValue === "PAYPAL" || selectedValue === "PAYMAYA" || selectedValue === "SHOPEEPAY") {
						$("#ddlBank").prop("disabled", false);
						$("#txtCardNo, #txtApprovalNo, #txtBankCharge, #txtCheckNo, #calCheckDate").prop("disabled", true);
					} else {
						// Disable all fields
						$("#ddlBank, #txtCardNo, #txtApprovalNo, #txtBankCharge, #txtCheckNo, #calCheckDate").prop("disabled", true);
					}
				});
			});

			// Function to update #txtPayTypeValue based on the selected value of #ddlPayType
			function updateTxtPayTypeValue() {
				var selectedPayType = $("#ddlPayType").val();
				$("#txtPayTypeValue").val(selectedPayType);
				
			}
						
		</script>
		
	</body>
</HTML>
