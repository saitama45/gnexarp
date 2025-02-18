<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ref_clientassets_list.aspx.vb" Inherits="srx.ref_clientassets_list" %>
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

			.backImg {
				height : 30px;				
			}

			.myForm {
				margin: auto;
				MAX-WIDTH: 600px
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
						<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To Client Profile" CssClass="backImg w3-hover-opacity" UseSubmitBehavior="False"/>						
						<b class="w3-medium">&nbsp;<asp:label id="lblClient" runat="server"></asp:label> | Assets</b>						
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
								<LABEL><B>Status</B></LABEL><BR>
									<asp:dropdownlist id="ddlStatus" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl">
										<asp:ListItem Value="ACTIVE" Selected="True">ACTIVE</asp:ListItem>
										<asp:ListItem Value="INACTIVE">INACTIVE</asp:ListItem>
									</asp:dropdownlist>							
							</div>
						
							<div class="w3-row w3-container">
								<LABEL><B>Item Name</B></LABEL><BR>
									<asp:dropdownlist id="ddlItemName" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
							</div>							
							<div class="w3-row w3-container">
								<LABEL><B>Description</B></LABEL><BR>
									<asp:textbox id="txtDesc" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')" ></asp:textbox>
							</div>
							<div class="w3-row w3-container">
								<div class="w3-half">
									<LABEL><B>Brand</B></LABEL><BR>
										<asp:textbox id="txtBrand" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</div>
								<div class="w3-half">
									<LABEL><B>Model</B></LABEL><BR>
										<asp:textbox id="txtModel" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</div>
							</div>
													
							<div class="w3-row w3-container">
								<div class="w3-half">
									<LABEL><B>Serial#</B></LABEL><BR>
										<asp:textbox id="txtSerial" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</div>
								<div class="w3-half">
									<LABEL><B>Type</B></LABEL><BR>
										<asp:dropdownlist id="ddlType" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl">
											<asp:ListItem Value="LAB EQUIPMENT" Selected="True">Laboratory Equipment</asp:ListItem>
											<asp:ListItem Value="FIXED ASSET">Fixed Asset</asp:ListItem>
										</asp:dropdownlist>
								</div>																	
							</div>
							
							<div class="w3-row w3-container">								
								<div class="w3-half">
									<LABEL><B>Acquired Date</B></LABEL><br>
									<ew:calendarpopup id="calAcquiredDate" style="Z-INDEX: 0" runat="server" VisibleDate="2015-11-13"
										CellPadding="2px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
										ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" onkeypress="return clickButton(event,'btnSave')" Autopostback="True">
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
									<LABEL><B>Utilized By</B></LABEL><BR>
										<asp:textbox id="txtUtilizedBy" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</div>
							</div>
							<div class="w3-row w3-container">
								<div class="w3-half">
									<LABEL><B>PMS every (Months)</B></LABEL>
									<asp:textbox id="txtPMSEvery" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</div>
								<div class="w3-half">
									<LABEL><B>Calibrate every (Months)</B></LABEL>
									<asp:textbox id="txtCalEvery" runat="server" Placeholder="type here..." CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</div>								
							</div>
							<div class="w3-container">
								<LABEL><B>Note</B></LABEL><BR>
									<asp:textbox id="txtNote" runat="server" CssClass="w3-input w3-border" TextMode="MultiLine" Maxlength="1000"></asp:textbox>
							</div>
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER>
					</DIV>
				</asp:panel>
				<!-- End Input Form -->
				<asp:panel id="panelGrid" style="Z-INDEX: 0;" runat="server" Visible="True">
					<div class="w3-rest w3-padding w3-mobile">
						<!-- #include file ="html\SearchAndButtons.html" -->
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

			$(document).on('select2:open', () => {
				document.querySelector('.select2-search__field').focus();
			});

			$(document).ready(function(){				

				$("#btnX").click(function(){
					$("#id01").hide();
				});			
			});
		</script>
		
	</body>
</HTML>
