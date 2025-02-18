<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_projecttasks_list.aspx.vb" Inherits="srx.inv_projecttasks_list" %>
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
			
			.myForm {
				position: fixed;
				top: 50%;
				left: 50%;
				transform: translate(-50%, -50%);
				z-index: 10;
				background-color: #f1f1f1;
			}
			
			.backImg {
				height : 30px;				
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
				<div style="margin-top: 55px;">
					<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To Reports" CssClass="backImg w3-hover-opacity" UseSubmitBehavior="False"/>					
					<asp:label id="lblTitle" runat="server" Font-Bold="True" CssClass="w3-bar-item w3-large">Project tasks</asp:label>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				<asp:panel id="panelForm" style="z-index: 0;" runat="server" Visible="False">
					<DIV class="w3-card-4 myForm" id="id01"><HEADER class="w3-light-grey w3-display-container w3-responsive" style="display: none;">
							<H4 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox>
							</H4>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">
							<asp:button id="btnX" runat="server" UseSubmitBehavior="False" Text="x" CssClass="w3-button w3-large w3-hover-red w3-right"></asp:button>
							<P style="display: none;"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" Visible="False" CssClass="w3-tag w3-red"></asp:label>
							</P>	
							<div class="w3-row">
								<div class="w3-half">
									<DIV class="w3-container">
										<LABEL><B>Status</B></LABEL><BR>
										<asp:dropdownlist id="ddlStatus" runat="server" CssClass="w3-tag w3-input w3-pale-blue myddl">
											<asp:ListItem Value="PENDING" Selected="True">PENDING</asp:ListItem>
											<asp:ListItem Value="ON GOING">ON GOING</asp:ListItem>
											<asp:ListItem Value="DELAYED">DELAYED</asp:ListItem>								
											<asp:ListItem Value="CANCELLED">CANCELLED</asp:ListItem>
										</asp:dropdownlist>
									</DIV>																
								</div>
								<div class="w3-half">
									<DIV class="w3-container">
										<LABEL><B>Task Desc</B></LABEL><BR>
										<asp:textbox id="txtTaskDesc" runat="server" CssClass="w3-input" required Maxlength="250" height="80px"
											TextMode="MultiLine" Placeholder="type here..."></asp:textbox>
									</DIV>
								</div>
								<DIV class="w3-container"><LABEL><B>Details</B></LABEL><BR>
									<asp:textbox id="txtNote" runat="server" CssClass="w3-input" Maxlength="1000" height="100px"
									TextMode="MultiLine" Placeholder="type here..."></asp:textbox>
								</DIV>
								<br>
								<div class="w3-row">
									<div class="w3-half">
										<DIV class="w3-container"><LABEL><B>Start Date</B></LABEL><BR>
											<ew:calendarpopup id="calStartDate" style="z-index: 0;" runat="server" ControlDisplay="TextBoxImage"
												ImageUrl="images/calendar-icon-mac.jpg" DisableTextboxEntry="False" AllowArbitraryText="False"
												CalendarLocation="Bottom" ShowGoToToday="True" CellPadding="2px">
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
										</DIV>
									</div>
									<div class="w3-half">
										<DIV class="w3-container"><LABEL><B>End Date</B></LABEL><BR>
											<ew:calendarpopup id="calEndDate" style="z-index: 0;" runat="server" ControlDisplay="TextBoxImage"
												ImageUrl="images/calendar-icon-mac.jpg" DisableTextboxEntry="False" AllowArbitraryText="False"
												CalendarLocation="Bottom" ShowGoToToday="True" CellPadding="2px">
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
										</DIV>
									</div>	
								</div>
							</div>
							<br>					
							<DIV class="w3-container"><LABEL><B>Assigned To</B></LABEL>
								<asp:textbox id="txtAssignedTo" runat="server"
									CssClass="w3-input" Maxlength="1000" TextMode="MultiLine"></asp:textbox>
							</DIV>
							<BR>
							<DIV class="w3-container"><LABEL><B>Project Manager / Team Leader</B></LABEL>
								<asp:textbox id="txtTeamLead" onkeypress="return clickButton(event,'btnSave')" runat="server"
									CssClass="w3-input"></asp:textbox>
							</DIV>														
							<br>
							<DIV class="w3-container">
								<b><asp:CheckBox id="chbCompletedDate" runat="server" Text=" Date Completed?" AutoPostBack="True"></asp:CheckBox>&nbsp;</b>
								<ew:calendarpopup id="calCompletedDate" style="z-index: 0;" runat="server" Visible="False" ControlDisplay="TextBoxImage"
									ImageUrl="images/calendar-icon-mac.jpg" DisableTextboxEntry="False" AllowArbitraryText="False"
									CalendarLocation="Bottom" ShowGoToToday="True" CellPadding="2px">
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
							</DIV>														
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER></DIV>
				</asp:panel>
				<!-- End Input Form -->
				<asp:panel id="panelGrid" style="z-index: 0;" runat="server" Visible="True"> <!-- Header -->
					<DIV class="w3-container">
						<div class="w3-row">
							<div class="w3-half">
								<DIV style="display: none;">
									<asp:hyperlink class="s6 w3-tag w3-khaki w3-margin-top" id="hlViewFullHistory" runat="server" ToolTip="View transaction history. "
										Target="_blank">Audit Trail</asp:hyperlink>
									<P>
										Project Amount:&nbsp;
										<asp:label class="w3-rest s6 w3-medium" id="lblProjectAmount" runat="server" Font-Bold="True"></asp:label>
									</P>
									<P>
										Budget:&nbsp;
										<asp:label class="w3-rest s6 w3-medium" id="lblBudget" runat="server" Font-Bold="True"></asp:label>
									</P>
								</DIV>
								<P>									
									<asp:ImageButton id="btnSaveImg" runat="server" ImageUrl="images/save_image.png" Tooltip="Save" CssClass="btnImg w3-hover-opacity w3-bar-item w3-right" />
								</P>
								<P>
									<label class="header_class">SO #:&nbsp;</label>
									<asp:label class="w3-rest s6 w3-medium" id="lblSONo" runat="server" Font-Bold="True">0</asp:label>
								</P>
								<P>
									<label class="header_class">Project Name:&nbsp;</label>
									<asp:label class="w3-rest s6 w3-medium" id="lblProjectName" runat="server" Font-Bold="True"></asp:label>
								</P>
								<P>
									<label class="header_class">Account Name:&nbsp;</label>
									<asp:label class="w3-rest s6 w3-medium" id="lblCustomer" runat="server" Font-Bold="True"></asp:label>
								</P>
							</div>
							<div class="w3-half">
								<P>
									Note:&nbsp;
									<asp:textbox id="txtNoteHDR" runat="server" CssClass="w3-input w3-border w3-white" TextMode="MultiLine" Height="100px" Maxlength="1000" ReadOnly="True"></asp:textbox>
								</P>
							</div>
						</div>																			
					</DIV>
					

					<DIV style="display: none;">
						<asp:LinkButton id="btnPrint" runat="server" Visible="False" CssClass="w3-btn w3-ripple w3-indigo w3-bar-item w3-margin-top w3-mobile"><i class="fas fa-print">
							</i>&nbsp;Print PO</asp:LinkButton>								
						<!-- #include file ="html\SearchAndButtons.html" -->
					</DIV>
					<P>
						<asp:ImageButton id="btnAddImg" runat="server" CssClass="btnImg w3-bar-item w3-hover-opacity" ImageUrl="images/additem.png" Tooltip="New Record" />
						<asp:ImageButton id="btnPrintImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print DR" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" />								
					</P>
					<P><!-- Sys Group Table -->
						<DIV class="w3-responsive">
							<TABLE class="w3-table-all w3-hoverable" id="tblGroupList" border="0" cellSpacing="0" cellPadding="2">
								<TR>
									<TH>
										<asp:datagrid id="DataGrid" runat="server" CellPadding="3" BorderStyle="None" GridLines="Vertical"
											AllowSorting="True" BorderColor="#999999" BorderWidth="1px" BackColor="White" Height="24px"
											Width="100%" ShowFooter="True">
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
				</asp:panel>
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		<script>                        
            // Function to Disable comma when typing
			$('.txtNumbers').keyup(function(event) {

				// skip for arrow keys
				if(event.which >= 37 && event.which <= 40) return;

				// format number
				$(this).val(function(index, value) {
					return value
					.replace(/[,'"]/g, '');					
				});
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
						
		</script>
	</body>
</HTML>
