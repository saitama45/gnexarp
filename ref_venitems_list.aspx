<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ref_venitems_list.aspx.vb" Inherits="srx.ref_venitems_list" %>
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
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;Supplier Details and Items</b></h5>
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
							<asp:button id="btnX" CssClass="w3-button w3-large w3-hover-red w3-right" runat="server" Text="x"></asp:button>
							<P style="display:none"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
							</P>
							<div class="w3-container">
								<LABEL><B>Item Barcode</B></LABEL><BR>
								<asp:textbox id="txtBarcode" runat="server" Placeholder="Scan barcode" CssClass="w3-input"></asp:textbox>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>Item Desc</B></LABEL><BR>
								<asp:dropdownlist tabIndex="2" id="ddlRawMats" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" ></asp:dropdownlist>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>Qty</B></LABEL><BR>
								<asp:textbox tabIndex="3" id="txtQty" runat="server" Placeholder="0.00" CssClass="w3-input" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>Cost</B></LABEL><BR>
								<asp:textbox tabIndex="4" id="txtCost" runat="server" Placeholder="0.00" CssClass="w3-input" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
							</div>																				
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER>
					</DIV>
				</asp:panel>
				<!-- End Input Form -->
				<asp:panel id="panelGrid" style="Z-INDEX: 0;" runat="server" Visible="True">
				<!-- Header -->
				<div class="w3-row">
					<div class="w3-third">
						<div class="w3-container w3-blue">
							<div style="display:none">
								<h5 class="w3-bar-item"><b><i class="fas fa-file-invoice"></i>&nbsp;Supplier</b></h5>
								<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top w3-bar-item" runat="server"
									Target="_blank" ToolTip="View transaction history. " Visible="False">Audit Trail</asp:hyperlink>								
								<asp:button id="btnBackToList" CssClass="Style: Class= w3-btn w3-ripple w3-khaki w3-bar-item w3-margin-top w3-mobile w3-right"
									runat="server" Text="Back to list"></asp:button>
							</div>
							<p>
								<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />
								<asp:ImageButton id="btnSaveImg" runat="server" ImageUrl="images/save_image.png" Tooltip="Save" CssClass="btnImg w3-hover-opacity w3-bar-item w3-right" />
							</p>										
							<br>																												
							<hr class="w3-bottombar w3-border-khaki">	
							<p style="display:none">
								<asp:label id="lblVendorID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
							</p>
							<p>
								Company:&nbsp;
								<asp:dropdownlist id="ddlCompany" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostback="True"></asp:dropdownlist>
							</p>
							<p>
								Status:&nbsp;
								<asp:dropdownlist id="ddlStatus" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl">
									<asp:ListItem Value="ACTIVE" Selected="True">ACTIVE</asp:ListItem>
									<asp:ListItem Value="INACTIVE">INACTIVE</asp:ListItem>
									<asp:ListItem Value="CLOSED">CLOSED</asp:ListItem>
								</asp:dropdownlist>
							</p>							
							<p>
								Type:&nbsp;
								<asp:dropdownlist id="ddlType" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl">
									<asp:ListItem Value="Vendor" Selected="True">Vendor</asp:ListItem>
									<asp:ListItem Value="Employee">Employee</asp:ListItem>
									<asp:ListItem Value="Manufacturing">Manufacturing</asp:ListItem>
								</asp:dropdownlist>
							</p>
							<p>
								Supplier:&nbsp;
								<asp:label id="lblSupplier" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
								<asp:textbox id="txtName" runat="server" Width="100%" Placeholder="Type here..." AutoPostback="True" required></asp:textbox>
							</p>
							<p>
								Client Code:&nbsp;
								<asp:textbox id="txtClientCode" runat="server" Width="100%" Placeholder="Type here..." AutoPostback="True"></asp:textbox>
							</p>													
							<p style="display:none">
								Supplier Code:&nbsp;
								<asp:label id="lblSupplierCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>
							<p>
								Contact Person:&nbsp;
								<asp:label id="lblContactPerson" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
								<asp:textbox id="txtContact" runat="server" Width="100%" Placeholder="Type here..." AutoPostback="True"></asp:textbox>
							</p>							
							<p>
								Contact #:&nbsp;
								<asp:label id="lblContactNo" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
								<asp:textbox id="txtContactNo" runat="server" Width="100%" Placeholder="Type here..." AutoPostback="True"></asp:textbox>
							</p>
							<p>
								Email:&nbsp;
								<asp:label id="lblEmail" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>
								<asp:textbox id="txtEmail" runat="server" Width="100%" Placeholder="Type here..." pattern="[^@]+@[^@]+\.[a-zA-Z]{2,6}" AutoPostback="True"></asp:textbox>
							</p>
							<p>
								Address:&nbsp;
								<asp:textbox id="txtAddress" runat="server" Width="100%" Placeholder="Type here..." TextMode="MultiLine" AutoPostback="True"></asp:textbox>
							</p>
							<p>
								City:&nbsp;
								<asp:dropdownlist id="ddlCity" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostback="True"></asp:dropdownlist>
							</p>
							<p>
								Industry:&nbsp;
								<asp:dropdownlist id="ddlIndustry" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostback="True"></asp:dropdownlist>
							</p>
							<p>
								Terms:&nbsp;
								<asp:textbox id="txtTerms" runat="server" Width="100%" Placeholder="Type here..." AutoPostback="True" required></asp:textbox>
							</p>
							<p>
								<asp:CheckBox id="chbNoContractExpiration" runat="server" Text=" w/o Contract" Checked="True" AutoPostBack="True"></asp:CheckBox>&nbsp;
								<asp:label id="lblContract" runat="server" Font-Bold="True" Visible="False"></asp:label>
								<ew:calendarpopup id="calContractExpiration" style="Z-INDEX: 0" runat="server"
									CellPadding="2px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
									ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" onkeypress="return clickButton(event,'btnSave')" AutoPostback="True">
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
								Note:&nbsp;
								<asp:textbox id="txtNote" runat="server" CssClass="w3-input w3-border" TextMode="MultiLine" Maxlength="1000" AutoPostback="True"></asp:textbox>
							</p>																	
						</div>
						<!-- End Header -->
					</div>
					<div class="w3-rest w3-padding w3-mobile">	
						<div style="display:none">
							<!-- #include file ="html\SearchAndButtons.html" -->	

						</div>	
						<p>
							<asp:ImageButton id="btnAddImg" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity" />
							<asp:ImageButton id="btnPrintImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print DR" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" />							
						</p>				
						<br><br>
						<p>
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
					</asp:panel>
					</div>
				</div>
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		<script>                        
            // Function to Disable comma when typing
			$('#txtTerms,#txtQty,#txtCost').on('input', function(event) {

				// Get the current value
				var currentValue = $(this).val();

				// Remove any non-numeric characters
				var newValue = currentValue.replace(/[^\d.]/g, '');
								
				// Update the input value
				$(this).val(newValue);
			});

			$('.myddl').select2({
				dropdownCssClass: 'w3-pale-blue',
				selectionCssClass: 'w3-pale-blue'								
			});

			$('input').click(function() {
				$(this).select(); 
			});

			$(function() { $("#id01").draggable(); });
		</script>
		
	</body>
</HTML>
