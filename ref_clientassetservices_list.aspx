<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ref_clientassetservices_list.aspx.vb" Inherits="srx.ref_clientassetservices_list" %>
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
				<div style="MARGIN-TOP: 45px">
					<div>						
						<b class="w3-medium">&nbsp;<asp:label id="lblClient" runat="server"></asp:label></b>						
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
							<label id="btnX" class="w3-button w3-large w3-hover-red w3-right">X</label>
							<P style="display:none"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
							</P>
							<div class="w3-row w3-container">
								<div class="w3-half">
									<LABEL><B>Date Reported</B></LABEL><br>
									<ew:calendarpopup id="calReportedDate" style="Z-INDEX: 0" runat="server" VisibleDate="2015-11-13"
										CellPadding="2px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
										ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" onkeypress="return clickButton(event,'btnSave')">
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
								</div>
								<div class="w3-half">
									<LABEL><B>Date Visited</B></LABEL><br>
									<ew:calendarpopup id="calServicedDate" style="Z-INDEX: 0" runat="server" VisibleDate="2015-11-13"
										CellPadding="2px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
										ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" onkeypress="return clickButton(event,'btnSave')">
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
								</div>								
							</div>							
							<div class="w3-container">
								<LABEL><B>Issues / Concerns</B></LABEL><BR>
									<asp:textbox id="txtIssues" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')" ></asp:textbox>
							</div>							
							<div class="w3-container">
								<LABEL><B>Service Rendered</B></LABEL><BR>
									<asp:dropdownlist id="ddlService" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl">
										<asp:ListItem Value="PMS" Selected="True">PMS (Preventive Maintenance Schedule)</asp:ListItem>
										<asp:ListItem Value="CALIBRATION">Calibration</asp:ListItem>
										<asp:ListItem Value="REPAIR">Repair</asp:ListItem>
										<asp:ListItem Value="INSTALL">Installation</asp:ListItem>
									</asp:dropdownlist>
							</div>							
							<div class="w3-container">
								<LABEL><B>Details</B></LABEL><BR>
									<asp:textbox id="txtDetails" runat="server" CssClass="w3-input w3-border" TextMode="MultiLine" Maxlength="1000"></asp:textbox>
							</div>																												
							<div class="w3-container">
								<LABEL><B>Amount</B></LABEL><BR>
									<asp:textbox id="txtAmount" runat="server" Placeholder="0.00" CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
							</div>
							<div class="w3-container">
								<LABEL><B>Technician</B></LABEL><BR>
									<asp:textbox id="txtTechnician" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')" ></asp:textbox>
							</div>							
							<div class="w3-container">								
								<asp:CheckBox id="chbDate" runat="server" Checked="True" AutoPostBack="True"></asp:CheckBox>&nbsp;
								<LABEL><B>Date Accomplished</B></LABEL><br>
								<ew:calendarpopup id="calAccomplishedDate" style="Z-INDEX: 0" runat="server" VisibleDate="2015-11-13"
									CellPadding="2px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
									ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" onkeypress="return clickButton(event,'btnSave')">
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
							</div>							
							<br>																										
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
								<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top w3-bar-item" runat="server"
									Target="_blank" ToolTip="View transaction history. " Visible="False">Audit Trail</asp:hyperlink>								
								<asp:label id="lblAccomplishedDate" runat="server"></asp:label>	
							</div>
							<p>
								<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />
								<asp:ImageButton id="btnSaveImg" runat="server" ImageUrl="images/save_image.png" Tooltip="Save" CssClass="btnImg w3-hover-opacity w3-bar-item w3-right" />
							</p>										
							<br>																												
							<hr class="w3-bottombar w3-border-khaki">	
							<p>								
								Status:&nbsp;
									<asp:dropdownlist id="ddlStatus" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True">
										<asp:ListItem Value="ACTIVE" Selected="True">ACTIVE</asp:ListItem>
										<asp:ListItem Value="INACTIVE">INACTIVE</asp:ListItem>
									</asp:dropdownlist>
							</p>													
							<p>
								Item Name:&nbsp;
								<asp:dropdownlist id="ddlItemName" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
							</p>
							<p>
								Description:&nbsp;
								<asp:textbox id="txtDesc" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" Autopostback="True" ></asp:textbox>
							</p>							
							<p>
								Brand:&nbsp;
								<asp:textbox id="txtBrand" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" Autopostback="True"></asp:textbox>
							</p>
							<p>
								Model:&nbsp;
								<asp:textbox id="txtModel" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" Autopostback="True"></asp:textbox>
							</p>
							<p>
								Serial#:&nbsp;
								<asp:textbox id="txtSerial" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" Autopostback="True"></asp:textbox>
							</p>
							<p>
								Type:&nbsp;
									<asp:dropdownlist id="ddlType" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True">
										<asp:ListItem Value="LAB EQUIPMENT" Selected="True">Laboratory Equipment</asp:ListItem>
										<asp:ListItem Value="FIXED ASSET">Fixed Asset</asp:ListItem>
									</asp:dropdownlist>
							</p>
							<p>
								Acquired Date:&nbsp;
								<ew:calendarpopup id="calAcquiredDate" style="Z-INDEX: 0" runat="server" VisibleDate="2015-11-13"
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
								Utilized By:&nbsp;
								<asp:textbox id="txtUtilizedBy" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" Autopostback="True"></asp:textbox>
							</p>
							<p>
								PMS every (Months):&nbsp;
								<asp:textbox id="txtPMSEvery" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount"></asp:textbox>
							</p>
							<p>
								Calibrate every (Months):&nbsp;
								<asp:textbox id="txtCalEvery" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount"></asp:textbox>
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
							<asp:ImageButton id="btnPrintImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print DR" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" />
						</div>	
						<p>
							<asp:ImageButton id="btnAddImg" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity" />							
						</p>				
						<p>
							<b>RENDERED SERVICES</b>
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
			$('#txtCost').keyup(function(event) {

				// skip for arrow keys
				if(event.which >= 37 && event.which <= 40) return;

				// format number
				$(this).val(function(index, value) {
					return value
					.replace(/[,'"]/g, '');					
				});
			});

			// Function to Disable comma when typing
			$('#txtDiscount').keyup(function(event) {

				// skip for arrow keys
				if(event.which >= 37 && event.which <= 40) return;

				// format number
				$(this).val(function(index, value) {
					return value
					.replace(/[,'"]/g, '');					
				});
			});

			// Function to Disable comma when typing
			$('#txtQty').keyup(function(event) {

				// skip for arrow keys
				if(event.which >= 37 && event.which <= 40) return;

				// format number
				$(this).val(function(index, value) {
					return value
					.replace(/[,'"]/g, '');					
				});
			});

			$(function() { $("#id01").draggable(); });

			$('.myddl').select2({
				dropdownCssClass: 'w3-pale-blue',
				selectionCssClass: 'w3-pale-blue',											
			});		

			$('input').click(function() {
				$(this).select(); 
			});

			$(document).ready(function(){				

				$("#btnX").click(function(){
					$("#id01").hide();
				});			
			});
		</script>
		
	</body>
</HTML>
