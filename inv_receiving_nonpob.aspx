<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_receiving_nonpob.aspx.vb" Inherits="ems.inv_receiving_nonpob" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
	</HEAD>
	<!-- #include file ="html\BodyColor.html" -->
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<FORM id="Form1" style="FONT: menu" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main" style="MARGIN-TOP: 43px">
				<!-- Header -->
				<div style="MARGIN-BOTTOM: 50px; PADDING-TOP: 20px">
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;Stocks Receiving w/o PO</b></h5>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				
				<asp:panel id="panelForm" style="Z-INDEX: 0;" runat="server" Visible="False">
				
					<DIV id="id01" class="w3-card-4" style="margin: auto; MAX-WIDTH: 600px">
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">								
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox>
							</H2>
						</HEADER>
						<DIV class="w3-section w3-medium">
							<%response.write("<a class='w3-hover-blue' href='inv_receiving_nonpob'><span class='w3-button w3-large w3-hover-red w3-right'>x</span></a>")%>
							<P style="display:none"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red"></asp:label>
							</P>
							<div class="w3-container">
								<LABEL><B>Date</B></LABEL><BR>
								<ew:calendarpopup tabIndex="6" id="calPODate" style="Z-INDEX: 0" runat="server" VisibleDate="2015-11-13"
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
							<div class="w3-row">
								<div class="w3-half w3-container">
									<LABEL><B>Supplier</B></LABEL><BR>
										<asp:dropdownlist tabIndex="1" id="ddlVendor" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
								</div>
								<div class="w3-half w3-container">
									<LABEL><B>Requested By</B></LABEL><BR>
										<asp:textbox tabIndex="3" id="txtRequestedBy" runat="server" CssClass="w3-input w3-white w3-border"></asp:textbox>									
								</div>
							</div>
							<br>																			
							<P style="display:none"><LABEL><B>Department</B></LABEL><BR>
								<asp:dropdownlist tabIndex="2" id="ddlDepartment" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
							</P>
							<div class="w3-row">
								<div class="w3-half w3-container">
									<LABEL><B>Discount (%)</B></LABEL><BR>
										<asp:textbox tabIndex="4" id="txtDiscount" runat="server" CssClass="w3-input w3-border" Placeholder="0.00" required></asp:textbox>
								</div>
								<div class="w3-half w3-container">
									<LABEL><B>Terms (Days)</B></LABEL><BR>
										<asp:textbox tabIndex="5" id="txtTerms" runat="server" CssClass="w3-input w3-border" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
								</div>	
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>Note</B></LABEL><BR>
									<asp:textbox tabIndex="6" id="txtNote" runat="server" CssClass="w3-input w3-border" TextMode="MultiLine" Maxlength="1000"></asp:textbox>
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
										<FooterStyle ForeColor="White" BackColor="#708090"></FooterStyle>
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
			<DIV></DIV>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		<script>                        
            // Function to Disable comma when typing
			$('#txtDiscount').keyup(function(event) {

				// skip for arrow keys
				if(event.which >= 37 && event.which <= 40) return;

				// format number
				$(this).val(function(index, value) {
					return value
					.replace(/,/g, '');					
				});
			});

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
