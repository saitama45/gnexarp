<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_porequestsdtl_list.aspx.vb" Inherits="srx.inv_porequestsdtl_list" %>
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
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;PR Items</b></h5>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->

				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 myForm">
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">																			
							<H4 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox>
							</H4>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">
							<asp:button id="btnX" CssClass="w3-button w3-large w3-hover-red w3-right" runat="server" Text="x" UseSubmitBehavior="False"></asp:button>
							<P style="display:none"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
							</P>														
							<div class="w3-container">
								<LABEL><B>Item Desc</B></LABEL><BR>
								<asp:dropdownlist id="ddlRawMats" runat="server" Width="100%" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostBack="True"></asp:dropdownlist>
								<asp:label id="lblRawMats" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
								<asp:CheckBox id="chbItemNotFound" runat="server" Text=" Item Not Found?" Checked="False" AutoPostBack="True"></asp:CheckBox>&nbsp;
								<asp:textbox id="txtItemDesc" runat="server" CssClass="w3-input" Placeholder="Type your Item Desc here..." Visible="False"></asp:textbox>
							</div>
							<br>								
							<div class="w3-container">
								<LABEL><B>Brand</B></LABEL>
								<asp:dropdownlist id="ddlBrand" runat="server" Width="100%" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostBack="True"></asp:dropdownlist>
								<asp:label id="lblBrand" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
								<asp:CheckBox id="chbBrandNotFound" runat="server" Text=" Brand Not Found?" Checked="False" AutoPostBack="True"></asp:CheckBox>&nbsp;
								<asp:textbox id="txtBrand" runat="server" CssClass="w3-input" Placeholder="Type your Brand here..." Visible="False"></asp:textbox>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>UOM</B></LABEL>
								<asp:dropdownlist id="ddlUOM" runat="server" Width="100%" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" required></asp:dropdownlist>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>Requested Qty</B></LABEL>
								<asp:textbox id="txtRequestedQty" runat="server" CssClass="w3-input" Placeholder="0.00" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
							</div>														
						</div>	
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
									<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top" runat="server"
									Target="_blank" ToolTip="View transaction history. ">Audit Trail</asp:hyperlink>								
								</div>
								<p>
									<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />
									<asp:ImageButton id="btnSaveImg" runat="server" ImageUrl="images/save_image.png" Tooltip="Save" CssClass="btnImg w3-hover-opacity w3-bar-item w3-right" />									
								</p>										
								<br>																												
								<hr class="w3-bottombar w3-border-khaki">	
								<p>
									Status:&nbsp;
									<asp:label id="lblPRID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
									<asp:label id="lblStatus" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								</p>							
								<p>
									PR #:&nbsp;									
									<asp:label id="lblPRCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								</p>
								<p>
									SO # / ProjID:&nbsp;
									<asp:textbox id="txtSONo" runat="server" CssClass="w3-input w3-white w3-border" Autopostback="True"></asp:textbox>
									<asp:label id="lblSONo" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
								</p>
								<p>
									Account Name:&nbsp;		
									<asp:label id="lblCustomer" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
									<asp:label id="lblCustomerCode" class="w3-rest s6 w3-medium" runat="server" Visible="False">0</asp:label>
								</p>
								<p>
									Date Requested:&nbsp;									
									<ew:calendarpopup id="calPRDate" style="Z-INDEX: 0" runat="server" CellPadding="2px" ShowGoToToday="True" 
									CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False" ImageUrl="images/calendar-icon-mac.jpg" 
									ControlDisplay="TextBoxImage" Autopostback="True">
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
									Requested By:&nbsp;
									<asp:label id="lblRequestedBy" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>
									<asp:textbox id="txtRequestedBy" runat="server" CssClass="w3-input w3-white w3-border" Autopostback="True"></asp:textbox>
								</p>
								<p>
									Due Date:&nbsp;									
									<ew:calendarpopup id="calDueDate" style="Z-INDEX: 0" runat="server" CellPadding="2px" ShowGoToToday="True" 
									CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False" ImageUrl="images/calendar-icon-mac.jpg" 
									ControlDisplay="TextBoxImage" Autopostback="True">
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
									Total Requested Qty:&nbsp;
									<asp:label id="lblTotalRequestedQty" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>									
								</p>						
								<p>
									Note:&nbsp;
									<asp:textbox id="txtNote" runat="server" CssClass="w3-input w3-border w3-white" TextMode="MultiLine" Maxlength="1000" Enabled="True" Autopostback="True"></asp:textbox>
								</p>																																										
							</div>							
						</div>						
						<div class="w3-rest w3-padding w3-mobile">
							<div style="display:none">																
								<!-- #include file ="html\SearchAndButtons.html" -->
							</div>	
							<p>
								<asp:ImageButton id="btnAddImg" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity" />								
								<asp:ImageButton id="btnPrintImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print PR" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" />
								<asp:ImageButton id="btnReplicateImg" runat="server" ImageUrl="images/replicatebtn.png" Tooltip="Replicate PR" CssClass="btnImg w3-bar-item w3-hover-opacity w3-margin-left" />
							</p>	
							<br>						
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
						</div>	
					</div>																
				</asp:panel>
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		<script>                        
            // Function to Disable comma when typing
			$('#txtRequestedQty').on('input', function(event) {

				// Get the current value
				var currentValue = $(this).val();
    
				// Remove any non-numeric characters
				var newValue = currentValue.replace(/[^\d.]/g, '');
								
				// Update the input value
				$(this).val(newValue);
			});

			$(function() { $("#id01").draggable(); });	
			
			// Function to auto-format the date when typing
			$("#calPRDate").keyup(function (e) {
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
