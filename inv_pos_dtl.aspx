<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_pos_dtl.aspx.vb" Inherits="srx.inv_pos_dtl" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<%@ Register TagPrefix="cc1" Namespace="AvgControls" Assembly="ScrollingGrid" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->

		<link rel="stylesheet" href="css/new.css">

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
				height : 70px;				
			}

			.backImg {
				height : 30px;				
			}	
			
			.btnSCImg {
				height : 48px;
			}

			.btnVoidImg {
				height : 70px;
			}
			
			.myForm {				
				width: 410px;
				z-index: 10;
				background-color: #f1f1f1; 
				position: absolute;				
							
			}								
			
			.dropdown-container {
				max-width: 100%;
				overflow: hidden;
			}
			
			INPUT.less {FONT-SIZE: 14px; width: 120px; text-align: right; display: inline-block;}			
			
			table { table-layout: auto; width: 100%; FONT-SIZE: 18px;}
		</style>
	</HEAD>
	<!-- #include file ="html\BodyColor.html" -->
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<FORM id="Form1" style="FONT: menu" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main">
				<!-- Header -->
				<div style="MARGIN-TOP: 45px">
					<div class="w3-col m6">
						<h4 class="w3-left"><b><asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="backImg w3-hover-opacity w3-bar-item" />&nbsp;Point of Sale</b></h4>										
					</div>
					<div class="w3-col m3 w3-container">
						<h6 class="w3-right">Total Items: <asp:label id="lblTotalItems" runat="server"></asp:label></h6>						
					</div>
					<div class="w3-col m1">
						<h6>Barcode:</h6> 
						<h6>Qty:</h6> 
					</div>
					<div class="w3-col m1">
						<asp:textbox id="txtBarcode" runat="server"></asp:textbox>
						<asp:textbox id="txtBarcodeQty" runat="server" CssClass="txtNumbers">1</asp:textbox>
					</div>
					<div style="display:none;">
						<asp:Label ID="lblCompany" runat="server" Visible="True"></asp:Label>
						<asp:button id="btnSaveBarcodeItem" class="btn btn-primary" runat="server" Text="Save" Visible="True"></asp:button>						
						<asp:textbox id="txtISSID" runat="server" Visible="true"></asp:textbox>
						<asp:textbox id="txtDRCode" runat="server" Visible="true"></asp:textbox>						

					</div>
				</div>
				<!-- End Header -->				
				<!-- #include file ="html\AlertPanel.html" -->								
				<!-- Input Form -->				
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 myForm w3-display-middle">
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">							
							<H4 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox>
							</H4>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">
							<asp:button id="btnX" CssClass="w3-button w3-large w3-hover-red w3-right" runat="server" Text="x" UseSubmitBehavior="False"></asp:button>
							<div class="w3-container" style="display:none">
								<LABEL><B></B></LABEL>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red"></asp:label>
							</div>
							<div class="w3-container">
								<div class="row">
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
							<div class="w3-container">
								<LABEL><B>Warehouse</B></LABEL><BR>									
									<asp:dropdownlist tabIndex="4" id="ddlWarehouse" runat="server" CssClass="w3-input w3-tag w3-btn w3-bar-item w3-border w3-pale-blue w3-mobile myddl" AutoPostback="True"></asp:dropdownlist>									
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>Item</B></LABEL><BR>
									<div class="dropdown-container">
										<asp:dropdownlist tabIndex="5" id="ddlRawMats" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostBack="True" required></asp:dropdownlist>
									</div>									
							</div>
							<br>							
							<div class="w3-container">
								<div class="row">
									<div class="w3-third">
										<LABEL><B>Qty</B></LABEL><BR>
										<asp:textbox tabIndex="6" id="txtQty" runat="server" Placeholder="0.00" CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
									</div>
									<div class="w3-third">
										<LABEL><B>SRP</B></LABEL><BR>
										<asp:textbox tabIndex="7" id="txtSRP" runat="server" Placeholder="0.00" CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
										<div style="display:none">
											<asp:label id="lblSRP" runat="server" CssClass="w3-tag w3-red"></asp:label>
										</div>
									</div>
									<div class="w3-third">
										<LABEL><B>Discount (%)</B></LABEL><BR>
											<asp:textbox tabIndex="8" id="txtDiscount" runat="server" Placeholder="0.00" CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')">0</asp:textbox>
									</div>
								</div>								
							</div>							
							<div class="w3-container">								
								<input type="text" id="lblResult" runat="server" style="border: 0; FONT-SIZE: 20px;" class="w3-text-red w3-light-grey w3-input w3-responsive" readonly>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>Sales Person</B></LABEL><BR>
									<asp:dropdownlist id="ddlSalesPerson" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" required></asp:dropdownlist>
							</div>	
							<br>						
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER>
					</DIV>
				</asp:panel>
				<!-- End Input Form -->				
				<asp:panel id="panelGrid" style="Z-INDEX: 0;" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 myForm w3-display-middle">
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">							
							<H4 class="w3-center">
								<asp:label id="lblMode2" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction2" runat="server" Visible="true"></asp:textbox>
							</H4>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">
							<asp:button id="btnX2" CssClass="w3-button w3-large w3-hover-red w3-right" runat="server" Text="x" UseSubmitBehavior="False"></asp:button>
							<div class="w3-container">
								<P><label><B>Payment Type</B></label><BR>								
									<asp:dropdownlist tabIndex="3" id="ddlPayType" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl">
										<asp:ListItem Value="CASH" Selected="True">CASH</asp:ListItem>
										<asp:ListItem Value="CARD">CREDIT CARD</asp:ListItem>
										<asp:ListItem Value="DEBITCARD">DEBIT CARD</asp:ListItem>
										<asp:ListItem Value="EPAY">E-PAY</asp:ListItem>
									</asp:dropdownlist>
								</P>

								<P><LABEL><B>Payment</B></LABEL><BR>
									<asp:textbox tabIndex="4" id="txtPaidAmount" runat="server" Placeholder="0.00" CssClass="w3-input amount" onkeypress="return clickButton(event,'btnSave')" required>0</asp:textbox>									
									<div style="display:none">
										<asp:textbox id="txtNetSales" runat="server" CssClass="w3-input amount" Visible="True">0</asp:textbox>
									</div>									
								</P>

								<div><LABEL><B>Change</B></LABEL><BR>
									<input type="text" id="lblPay" runat="server" style="border: 0; FONT-SIZE: 24px;" class="w3-text-red w3-light-grey w3-input w3-responsive" readonly>
								</div>
								
								<div class="epay">									
									<asp:label id="lblEType" runat="server" ><B>Type</B></asp:label>
									<BR>								
									<asp:dropdownlist id="ddlEType" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
									<asp:label id="lblRefNo" runat="server"><B>Reference#</B></asp:label>
									<br>
									<asp:textbox id="txtRefNo" runat="server" CssClass="w3-input amount" Visible="True">0</asp:textbox>											
								</div>

								<div class="cards">
									<asp:label id="lblBank" runat="server"><B>Bank</B></asp:label><BR>
									<asp:dropdownlist id="ddlBank" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" ></asp:dropdownlist>
									<asp:label id="lblCardNo" runat="server" ><B>Card #</B></asp:label><BR>
									<asp:textbox id="txtCardNo" runat="server" Placeholder="type here..." CssClass="w3-input amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
									<asp:label id="lblApprovalNo" runat="server" ><B>Ref #</B></asp:label><BR>
									<asp:textbox id="txtApprovalNo" runat="server" Placeholder="type here..." CssClass="w3-input amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
									<asp:label id="lblBankCharge" runat="server" ><B>Bank Charge %</B></asp:label><BR>
									<asp:textbox id="txtBankCharge" runat="server" Placeholder="0.00" CssClass="w3-input amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</div>	
								<br>
								<asp:label id="lblRemarks" runat="server"><B>Notes:</B></asp:label>
								<br>
								<asp:textbox id="txtRemarks" runat="server" CssClass="w3-input amount" TextMode="MultiLine"></asp:textbox>																																															
							</div>
						</DIV>	
						<br>					
						<div class="w3-padding w3-border">
							<asp:button id="btnSave2" tabIndex="30" CssClass="OnClick: document.getElementById('AlertSuccess').style.display='block'; class: w3-btn w3-green w3-block w3-large" runat="server" Text="Save"></asp:button>
						</div>
					</DIV>
					
				</asp:panel>	
				<!-- Header -->
				<asp:panel id="panelVoid" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 myForm w3-display-middle w3-responsive">						
						<HEADER class="w3-center w3-indigo w3-display-container w3-responsive">								
							<H4>
								Void Confirmation
							</H4>
						</HEADER>						
						<FOOTER class="w3-padding w3-center">
							<asp:button id="btnYes" CssClass="w3-btn w3-green w3-hover-blue w3-margin-right" runat="server" Text="Yes"></asp:button>
							<asp:button id="btnNo" CssClass="w3-btn w3-red w3-hover-blue" runat="server" Text="No"></asp:button>
						</FOOTER>
					</DIV>
				</asp:panel>
				<asp:panel id="panelCustomer" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 myForm w3-display-middle">
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">							
							<H4 class="w3-center">
								<asp:label id="lblClientID" runat="server" Visible="true"></asp:label>
								<asp:label id="lblMode3" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction3" runat="server" Visible="true"></asp:textbox>
							</H4>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">
							<asp:button id="btnX3" CssClass="w3-button w3-large w3-hover-red w3-right" runat="server" Text="x" UseSubmitBehavior="False"></asp:button>
							<div class="w3-container">
								<p><label><B>Name</B></label><BR>
									<asp:textbox id="txtCustomerName" runat="server" CssClass="w3-input" Placeholder="type here..." Visible="True"></asp:textbox>
								</p>
								<p><label><B>City</B></label><BR>
									<asp:dropdownlist id="ddlCity" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
								</p>
								<p><label><B>SC ID#</B></label><BR>
									<asp:textbox id="txtSCNo" runat="server" CssClass="w3-input" Placeholder="type here..." Visible="True"></asp:textbox>
								</p>
								<p><label><B>PWD ID#</B></label><BR>
									<asp:textbox id="txtPWDNo" runat="server" CssClass="w3-input" Placeholder="type here..." Visible="True"></asp:textbox>
								</p>
							</div>
						</DIV>
						<br>					
						<div class="w3-padding w3-border">
							<asp:button id="btnSave3" tabIndex="30" CssClass="OnClick: document.getElementById('AlertSuccess').style.display='block'; class: w3-btn w3-green w3-block w3-large" runat="server" Text="Save"></asp:button>
						</div>
					</DIV>
				</asp:panel>
				<div class="w3-row">										
					<div class="w3-col m9 w3-container">
						<div style="display:none">
							<!-- #include file ="html\SearchAndButtons.html" -->							
						</div>												
						<!-- Sys Group Table -->
						<div class="w3-responsive w3-mobile" style="margin-bottom: 260px;">							
							<asp:datagrid id="DataGrid" runat="server" ShowFooter="False" CellPadding="3" Width="100%"
								BackColor="White" BorderWidth="5px" AllowSorting="True" GridLines="None" 
								BorderStyle="None">
								<FooterStyle ForeColor="White" BackColor="#708090"></FooterStyle>
								<SelectedItemStyle Font-Bold="True" ForeColor="Black" CssClass="w3-pale-blue" BackColor="Green"></SelectedItemStyle>
								<EditItemStyle></EditItemStyle>
								<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
								<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#708090"></HeaderStyle>
								<Columns>										
									<asp:ButtonColumn Text="Delete" CommandName="Delete"></asp:ButtonColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
							</asp:datagrid>																				
						</div>
						<!-- End Sys Group Table -->
						<div class="w3-col m12">
							<p>
								<b></b>&nbsp;
								<div class="w3-col m11">
									<asp:dropdownlist tabIndex="1" id="ddlClient" runat="server" CssClass="w3-tag w3-input w3-border w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
									<asp:label id="lblClient" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>
								</div>
								<div class="w3-col m1">
									<ul class="tabs">
										<li class="active" id="Item">
											<div class="sc-pwd">
												<asp:ImageButton id="btnPWDImg" runat="server" ImageUrl="images/senior_img.png" Tooltip="Apply Senior/PWD Discount" CssClass="btnSCImg w3-hover-opacity" UseSubmitBehavior="False"/>												
											</div>																				
										</li>
									</ul>									
								</div>																
							</p>
							<div class="w3-col m4">
								<p>
									<b></b>&nbsp;<br>
									<asp:label id="lblStatus" runat="server" CssClass="status">On Process</asp:label>
									<asp:label id="lblDRCode" runat="server" CssClass="dr_code" Visible="False"></asp:label>
									<asp:label id="lblISSID" runat="server" CssClass="dr_code" Visible="False"></asp:label>	
								</p>
							</div>
							<div class="w3-col m4">
								<p>
									<b></b>&nbsp;<br>								
									<ew:calendarpopup tabIndex="2" id="calSIDate" style="Z-INDEX: 0" runat="server" Width="53%"
										Height="30px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
										ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" Autopostback="True">
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
								</p>
							</div>
							<div class="w3-col m4">
								<p>
									<b>SI #:</b><br>
									<asp:textbox tabIndex="2" id="txtSINo" runat="server" CssClass="w3-input" Placeholder="type here..." Autopostback="True"></asp:textbox>								
								</p>								
							</div>																																		
						</div>
					</div>								
					<div class="w3-col m3">
						<div class="w3-col m4">
							<ul class="tabs">
								<li class="active" id="Item">
									<div class="product-details">
										<asp:ImageButton id="btnNewRecordImg" runat="server" ImageUrl="images/buy_item.png" Tooltip="New Record" CssClass="btnImg w3-hover-opacity" UseSubmitBehavior="False"/>									
										<h6>New</h6>
									</div>
									<div class="product-details">
										<asp:ImageButton id="btnPayImg" runat="server" ImageUrl="images/cash_item.png" Tooltip="Payment" CssClass="btnImg w3-hover-opacity" UseSubmitBehavior="False"/>
										<h6>Payment</h6>
									</div>										
								</li>
							</ul>
						</div>

						<div class="w3-col m4">
							<ul class="tabs">
								<li class="active" id="Item">
									<div class="product-details">
										<asp:ImageButton id="btnAddImg" runat="server" ImageUrl="images/add_item.png" Tooltip="Add Item" CssClass="btnImg w3-hover-opacity" UseSubmitBehavior="False"/>									
										<h6>AddItem</h6>
									</div>
								</li>
								<li class="active" id="Item">
									<div class="product-details">
										<asp:ImageButton id="btnReceiptImg" runat="server" ImageUrl="images/receipt_item.png" Tooltip="Print Receipt" CssClass="btnImg w3-padding w3-bar-item w3-hover-opacity" UseSubmitBehavior="False"/>
										<h6>Receipt</h6>
									</div>
								</li>																
							</ul>
						</div>
						<div class="w3-col m4">
							<ul class="tabs">
								<li class="active" id="Item">
									<div class="product-details">
										<asp:ImageButton id="btnCustomerImg" runat="server" ImageUrl="images/customer_item.png" Tooltip="Customer" CssClass="btnImg w3-hover-opacity" UseSubmitBehavior="False"/>									
										<h6>Customer</h6>										
									</div>
								</li>
								<li id="Customer">
									<div class="product-details">
										<asp:ImageButton id="btnVoidImg" runat="server" ImageUrl="images/void_item.png" Tooltip="Void" CssClass="btnVoidImg w3-padding w3-bar-item w3-hover-opacity" UseSubmitBehavior="False"/>
										<h6>Void</h6>										
									</div>
								</li>																													
							</ul>
						</div>
						<div class="w3-col m12 w3-black">
							<div class="setvalue">
								<ul>
									<li>
										<asp:CheckBox id="chbIsNonVat" Text="Non-Vat?" runat="server" CssClass="checkbox-group" Checked="False" AutoPostBack="True"></asp:CheckBox>
										<asp:CheckBox id="chbIsVatExclusive" Text="Vat-Exclusive?" runat="server" CssClass="checkbox-group" Checked="False" AutoPostBack="True" Visible="False"></asp:CheckBox>&nbsp;
									</li>
									<li>
										<h5>Vatable Sales</h5>
										<h6><asp:label id="lblVatableSales" runat="server" CssClass="vatable_sales">0.00</asp:label></h6>
									</li>
									<li>
										<h5>VAT</h5>
										<h6><asp:label id="lblVAT" runat="server" CssClass="vat">0.00</asp:label></h6>
									</li>
									<li>
										<h5>Amount</h5>
										<h6><asp:label id="lblAmount" runat="server" CssClass="amount">0.00</asp:label></h6>
									</li>
									<li class="less">
										<h5>Less</h5>
										<h6><asp:textbox id="txtLess" runat="server" CssClass="less" Autopostback="True">0</asp:textbox></h6>
									</li>
									<li style="display:none">
										<h5>Discount</h5>
										<h6><asp:label id="lblDiscount" runat="server" CssClass="discount">0.00</asp:label></h6>
									</li>
									<li class="total-value">
										<h5>Total</h5>
										<h6><asp:label id="lblNetSales" runat="server" CssClass="net_sales">0.00</asp:label></h6>
									</li>
									<li>
										<h5>Payment</h5>
										<!-- <h6><asp:textbox id="txtPayment" runat="server" CssClass="less" Autopostback="True">0</asp:textbox></h6> -->
										<h6><asp:label id="lblPayment" runat="server" CssClass="payment">0.00</asp:label></h6>
									</li>
									<li>
										<h5>Change</h5>										
										<h6><asp:label id="lblChange" runat="server" CssClass="payment">0.00</asp:label></h6>
									</li>									
									<li>
										<h5>Balance</h5>
										<h6><asp:label id="lblBalance" runat="server" CssClass="balance">0.00</asp:label></h6>
									</li>
								</ul>
							</div>
						</div>												
					</div>							
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		
		<script>                        
            // Function to Disable comma when typing
			$('#txtLess,#txtSRP,#txtQty,#txtDiscount,#txtPaidAmount').on('input', function(event) {

				// Get the current value
				var currentValue = $(this).val();

				// Remove any non-numeric characters
				var newValue = currentValue.replace(/[^\d.]/g, '');
								
				// Update the input value
				$(this).val(newValue);
			});

			// $(function() { $("#id01").draggable(); });							
						
			$('#txtSRP, #txtQty, #txtDiscount').keyup(function(){
				// skip for arrow keys
				if(event.which >= 37 && event.which <= 40) return;

				var srp = parseFloat($("#txtSRP").val());
				var qty = parseFloat($("#txtQty").val());
				var discount = parseFloat($("#txtDiscount").val());				
				var res = srp * qty - ((srp * qty) * discount / 100 );
				
				$("#lblResult").val(res.toFixed(2).toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,"));				
								
			});	
			
			$('#txtPaidAmount').keyup(function(){
				// skip for arrow keys
				if(event.which >= 37 && event.which <= 40) return;

				var pay = parseFloat($("#txtPaidAmount").val());
				var total = parseFloat($("#txtNetSales").val());									
				var res = pay - total;
				
				$("#lblPay").val(res.toFixed(2).toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,"));				
								
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

			$('select').select2({
				dropdownCssClass: 'w3-pale-blue',
				selectionCssClass: 'w3-pale-blue',											
			});

			$(document).on('select2:open', () => {
				document.querySelector('.select2-search__field').focus();
			});

			$('input').click(function() {
				$(this).select(); 
			});

			$(document).keyup(function (e) {
				if (e.keyCode == 113) { $("#btnNewRecordImg").click(); } 	//F2		
				if (e.keyCode == 114) { $("#btnAddImg").click(); } 			//F3
				if (e.keyCode == 115) { $("#btnCustomerImg").click(); } 	//F4
				if (e.keyCode == 116) { $("#btnCashImg").click(); } 		//F5
				if (e.keyCode == 117) { $("#btnReceiptImg").click(); } 		//F6
				if (e.keyCode == 118) { $("#btnVoidImg").click(); } 		//F7
			}); 						

			$(document).ready(function(){	
					$(".cards").hide();
					$(".epay").hide();			
				$('#ddlPayType').change(function() {
					
					if($("#ddlPayType").val() == "EPAY") {
						$(".epay").show();
						$('#txtRefNo').select();
						$(".cards").hide();
					}
					else if ($("#ddlPayType").val() === "CARD" || $("#ddlPayType").val() === "DEBITCARD") {
						$(".cards").show();
						$('#ddlBank').select();
						$(".epay").hide();						
					}
					else {
						$('#txtPaidAmount').select();
						$(".cards").hide();
						$(".epay").hide();
					}					
				});				
			});
			
			$(document).ready(function() {
				$('.checkbox-group input[type="checkbox"]').change(function() {
					var checked = $(this).prop('checked');
					$('.checkbox-group input[type="checkbox"]').not(this).prop('checked', false);
				});
			});

			$(document).ready(function() {
				$('.txtNumbers').on('input', function(event) {

					// Get the current value
					var currentValue = $(this).val();

					// Remove any non-numeric characters
					var newValue = currentValue.replace(/[^\d.]/g, '');
									
					// Update the input value
					$(this).val(newValue);
				});

				// Get the text of the label with ID "lblCompany"
				var companyText = $('#<%= lblCompany.ClientID %>').text().trim();

				// Check if the company text is not "COSMOMED"
				if (companyText === "S4S") {				
					// Hide the #btnPrintItemized element
					$('.less').hide();				
				}
	
				// Show the txtBarcode element
				$('#txtBarcode, #txtBarcodeQty').on('keydown', function(e) {
					if (e.keyCode === 9) { // Check if the key pressed is Tab
						e.preventDefault(); // Prevent default tab behavior
						if ($(this).attr('id') === 'txtBarcode') {
							$('#txtBarcodeQty').focus().select(); // Move focus to txtBarcodeQty
						} else {
							$('#txtBarcode').focus(); // Move focus back to txtBarcode
						}
					}
				});

				$("#txtBarcode").focus();				
				
				$("#txtBarcode").keydown(function(event) {
					if (event.keyCode === 13) { // Check if the Enter key is pressed
						event.preventDefault(); // Prevent the default Enter key action
						$("#btnSaveBarcodeItem").click(); // Trigger the click event of btnSaveBarcodeItem
					}
				});

				$('#txtBarcodeQty').keyup(function() {
					// Get the value of the txtBarcodeQty field
					var qtyValue = $(this).val();
					
					// // Check if the value is a valid number
					// if (!isNaN(qtyValue)) {
					// 	// If it is a valid number, set a timeout to move the cursor back to txtBarcode after 1 second
					// 	setTimeout(function() {
					// 		$('#txtBarcode').focus();
					// 	}, 5000); // 1000 milliseconds = 1 second
					// }
				});
			});

			// Event handler for #btnSaveSRP click
			$("#btnSaveBarcodeItem").click(function (e) {
				// Prevent the default form submission behavior
				e.preventDefault();
		
				// Your form data
				var formData = $("#Form1").serialize(); // Replace "yourFormId" with the actual ID of your form
		
				// Additional parameters for your stored procedure
				var additionalData = {
					Mode: "Barcode",
					FormAction: "Add",
					warehouse: "WHSE-MIMI",
					id: $("#txtISSID").val(),
					dr_code: $("#txtDRCode").val(),
					barcode: $("#txtBarcode").val(),
					qty: $("#txtBarcodeQty").val(),					
					Session_fullname: $("#txtSessionFullname").val(), // Replace with the actual ID of your session element
					Customer_Code: $("#txtCustomerCode").val()
				};
		
				// Combine form data and additional parameters
				var requestData = formData + "&" + $.param(additionalData);
		
				// AJAX request
				$.ajax({
					type: "POST",
					url: "inv_pos_dtl.aspx",
					data: additionalData,
					success: function (response) {
						// Handle the success response
						console.log("Form submitted successfully");
		
						
		
						// Call the function to load current page url
						window.location.reload(); 		
						
					},
					error: function (error) {
						// Handle the error response
						console.error("Error submitting form: ", error);
					}
				});
			});
					
		</script>
		
	</body>
</HTML>
