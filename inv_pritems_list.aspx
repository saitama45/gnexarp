<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_pritems_list.aspx.vb" Inherits="srx.inv_pritems_list" %>
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
			.myddl {
				word-wrap: break-word;
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
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;PO Items</b></h5>
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
							<div class="w3-container" style="display:none">
								<LABEL><B>Barcode</B></LABEL><BR>
								<asp:textbox tabIndex="7" id="txtBarcode" runat="server" Placeholder="Scan barcode" CssClass="w3-input" AutoPostBack="True"></asp:textbox>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>Item Desc</B></LABEL><BR>
								<asp:dropdownlist tabIndex="8" id="ddlRawMats" runat="server" Width="100%" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" AutoPostBack="True" required></asp:dropdownlist>
							</div>	
							<br>
							<div class="w3-container">
								<LABEL><B>Recent PO Date</B></LABEL>
								<asp:label id="lblRecentPODate" runat="server"></asp:label>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>PO Qty</B></LABEL>
								<asp:label id="lblRecentPOQty" runat="server"></asp:label>
							</div>
							<br>
							<div class="w3-container" style="display:none">
								<LABEL><B>PO Cost</B></LABEL>
								<asp:label id="lblRecentPOCost" runat="server"></asp:label>
							</div>	
							<br style="display:none">					
							<div class="w3-container">
								<LABEL><B>Qty</B></LABEL><BR>
								<asp:textbox tabIndex="9" id="txtQty" runat="server" CssClass="w3-input txtNumbers" Placeholder="0.00" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
							</div>	
							<br>																				
							<div class="w3-container">
								<LABEL><B>Cost (PHP)</B></LABEL><BR>
								<asp:textbox tabIndex="10" id="txtCost" runat="server" CssClass="w3-input txtNumbers" Placeholder="0.00" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
							</div>	
							<br>
							<div class="w3-container">
								<LABEL><B>Cost (Import)</B></LABEL><BR>
								<asp:textbox tabIndex="10" id="txtCostImport" runat="server" CssClass="w3-input txtNumbers" Placeholder="Optional / Not Required" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
							</div> 
						</div>
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
								<LABEL><B>PO Qty</B></LABEL>
								<asp:textbox id="txtPOQty" runat="server" CssClass="w3-input txtNumbers" onkeypress="return clickButton(event,'btnSave2')" required></asp:textbox>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>PO Unit Cost</B></LABEL>
								<asp:textbox id="txtPOUnitCost" runat="server" CssClass="w3-input txtNumbers" onkeypress="return clickButton(event,'btnSave2')" required></asp:textbox>
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
				<!-- Header -->			
				<div class="w3-row">
					<div class="w3-third">
						<div class="w3-container w3-blue">	
							<div style="display:none">
								<asp:button id="btnBackToList" CssClass="w3-btn w3-ripple w3-khaki w3-bar-item w3-margin-top w3-mobile"
								runat="server" Text="Back to list"></asp:button>								
								<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top" runat="server"
								Target="_blank" ToolTip="View transaction history. ">Audit Trail</asp:hyperlink>								
							</div>
							<p>
								<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />
								<asp:ImageButton id="btnSaveImg" runat="server" ImageUrl="images/save_image.png" Tooltip="Save" CssClass="btnImg w3-hover-opacity w3-bar-item w3-right" />									
								<asp:LinkButton id="btnLCost" CssClass="w3-btn w3-ripple w3-green w3-bar-item w3-right w3-mobile"
									runat="server" Visible="False">&nbsp;Landed Costs</asp:LinkButton>
								<asp:LinkButton id="btnCompleted" runat="server" Visible="False" CssClass="w3-btn w3-ripple w3-green w3-bar-item w3-right w3-round w3-mobile" OnClientClick="return confirm('Are you sure you want to proceed?');">&nbsp;CLOSE PO</asp:LinkButton>
							</p>										
							<br>																												
							<hr class="w3-bottombar w3-border-khaki">	
							<p>
								Status:&nbsp;
								<asp:label id="lblStatus" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								<div class="dropdown-container">
									<asp:dropdownlist id="ddlStatus" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Visible="False" AutoPostback="True">
										<asp:ListItem Value="ON PROCESS">ON PROCESS</asp:ListItem>
										<asp:ListItem Value="APPROVED">APPROVED</asp:ListItem>
										<asp:ListItem Value="CANCELLED">CANCELLED</asp:ListItem>
										<asp:ListItem Value="INCOMPLETE">INCOMPLETE</asp:ListItem>
									</asp:dropdownlist>
								</div>
							</p>							
							<p>
								PO #:&nbsp;
								<asp:label id="lblPRCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>
							<p>
								PO Date:&nbsp;
								<asp:label id="lblPRDate" CssClass="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
								<ew:calendarpopup id="calPODate" style="Z-INDEX: 0" runat="server" VisibleDate="2015-11-13"
									CellPadding="2px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
									ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" Autopostback="True">
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
								<asp:CheckBox id="chbDueDate" runat="server" Text=" w/ Due Date" Checked="True" AutoPostBack="True"></asp:CheckBox>&nbsp;
								<asp:label id="lblDueDate" CssClass="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
								<ew:calendarpopup id="calDueDate" style="Z-INDEX: 0" runat="server" VisibleDate="2015-11-13"
									CellPadding="2px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
									ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" Autopostback="True">
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
								Supplier:&nbsp;
								<asp:label id="lblVendorName" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>
								<asp:label id="lblVendorCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>								
								<div class="dropdown-container">
									<asp:dropdownlist id="ddlVendor" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>	
								</div>								
							</p>
							<p style="display:none">
								Supplier Email:&nbsp;
								<asp:label id="lblEmail" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
								<asp:label id="lblPRID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								<asp:label id="lblPRItemsID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>
							<p>
								<span>Requested By</span>:&nbsp;
								<asp:label id="lblRequestedBy" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>
								<asp:textbox id="txtRequestedBy" runat="server" TextMode="MultiLine" CssClass="w3-input w3-white w3-border" Autopostback="True"></asp:textbox>
							</p>
							<p style="display:none;">
								Department:&nbsp;
								<asp:label id="lblDept" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Terms:&nbsp;
								<asp:label id="lblTerms" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>
								<asp:textbox id="txtTerms" runat="server" CssClass="w3-input w3-border" Autopostback="True" TextMode="MultiLine" Maxlength="1000" required></asp:textbox>
							</p>
							<p>
								VAT Exclusive?
								<asp:CheckBox id="chbIsVatExclusive" runat="server" CssClass="checkbox-group" Checked="False" AutoPostBack="True"></asp:CheckBox>&nbsp;
							</p>
							<p>
								Non-VAT?
								<asp:CheckBox id="chbIsNonVat" runat="server" CssClass="checkbox-group" Checked="False" AutoPostBack="True"></asp:CheckBox>&nbsp;
							</p>
							<p>
								Currency:&nbsp;
								<div class="dropdown-container">
									<asp:dropdownlist id="ddlCurrency" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
								</div>								
							</p>
							<p>
								Current Forex:&nbsp;
								<asp:textbox id="txtCurrentForex" runat="server" CssClass="w3-input w3-border txtNumbers" Autopostback="True"></asp:textbox>
							</p>								
							<p>
								Discount (%):
								<asp:label id="lblDiscount" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>
								<asp:textbox id="txtDiscount" runat="server" CssClass="w3-input w3-border txtNumbers" Placeholder="0.00" Autopostback="True" required></asp:textbox>									
							</p>
							<p>
								Total Cost:&nbsp;
								<asp:label id="lblTotalCost" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Discounted Amount:&nbsp;
								<asp:label id="lblDiscountedAmount" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								PO Amount:&nbsp;
								<asp:label id="lblNetAmount" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Note:&nbsp;
								<asp:textbox id="txtNote" tabIndex="6" runat="server" CssClass="w3-input w3-border w3-white" TextMode="MultiLine" Maxlength="1000" Enabled="True" Autopostback="True"></asp:textbox>
							</p>																																										
						</div>							
					</div>
				<!-- End Input Form -->
				<asp:panel id="panelGrid2" style="Z-INDEX: 0;" runat="server" Visible="False">
					
					<div class="w3-rest w3-padding w3-mobile">
						<p>
							<asp:ImageButton id="btnBackImg2" runat="server" ImageUrl="images/backarrow_yellow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />
							<asp:ImageButton id="btnAddImg2" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity" />							
							<asp:ImageButton id="btnPrintImg2" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print PO" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" />														
						</p>	
						<br>						
						<p>								
							<!-- Sys Group Table -->
							<div class="w3-responsive">
								<TABLE id="tblGroupList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2"
									border="0">
									<tr>
										<th>
											<asp:datagrid id="DataGrid3" runat="server" ShowFooter="True" CellPadding="3" Width="100%" Height="24px"
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
								<asp:LinkButton id="btnPrint" CssClass="w3-btn w3-ripple w3-indigo w3-bar-item w3-margin-top w3-mobile"
									runat="server" Visible="False"><i class="fas fa-print"></i>&nbsp;Print PO</asp:LinkButton>
								<asp:LinkButton id="btnReplicate" CssClass="w3-btn w3-ripple w3-orange w3-bar-item w3-margin-top w3-mobile"
									runat="server" Visible="False"><i class="fas fa-clone"></i>&nbsp;Replicate This PO</asp:LinkButton>
								<!-- #include file ="html\SearchAndButtons.html" -->
							</div>	
							<p>
								<asp:ImageButton id="btnAddImg" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity" />
								<asp:LinkButton id="btnPrintRR" CssClass="w3-btn w3-green w3-bar-item w3-right w3-margin-left"
									runat="server" Visible="False">RR</asp:LinkButton>
								<asp:LinkButton id="btnPrintItemized" CssClass="w3-btn w3-ripple w3-indigo w3-mobile w3-bar-item w3-right w3-margin-left"
									runat="server"><i class="fas fa-print"></i>&nbsp;Itemized</asp:LinkButton>
								<asp:LinkButton id="btnPrintImport" CssClass="w3-btn w3-ripple w3-indigo w3-mobile w3-bar-item w3-right w3-margin-left"
									runat="server"><i class="fas fa-print"></i>&nbsp;Import</asp:LinkButton>								
								<asp:LinkButton id="btnPrintLocal" CssClass="w3-btn w3-ripple w3-indigo w3-mobile w3-bar-item w3-right w3-margin-left"
									runat="server"><i class="fas fa-print"></i>&nbsp;Local</asp:LinkButton>
								<asp:ImageButton id="btnPrintImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print PO" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" Visible="False"/>
								<asp:ImageButton id="btnPrintImportImg" runat="server" ImageUrl="images/printbtn2.png" Tooltip="Print PO (Import Cost)" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right w3-margin-right" Visible="False" />
								<asp:ImageButton id="btnReplicateImg" runat="server" ImageUrl="images/replicatebtn.png" Tooltip="Replicate PO" CssClass="btnImg w3-bar-item w3-hover-opacity w3-margin-left" />
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
														<asp:ButtonColumn Text="Open" CommandName="Open"></asp:ButtonColumn>
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
			$('.txtNumbers').on('input', function(event) {

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

			$(document).ready(function() {
				// Get the text of the label with ID "lblCompany"
				var companyText = $('#<%= lblCompany.ClientID %>').text().trim();

				// Check if the company text is not "COSMOMED"
				if (companyText !== "COSMOMED") {
					// Hide the third column of DataGrid3
					$('#<%= Datagrid.ClientID %> tr td:nth-child(3)').hide();	
					// Hide the #btnPrintItemized element
					$('#btnPrintItemized').hide();				
				}

				// Check if the company text is "COSMOMED"
				if (companyText === "COSMOMED") {					
					 // Change the text of the label to "Project Name"
					 $('span:contains("Requested By")').text("Project Name");
				}
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
