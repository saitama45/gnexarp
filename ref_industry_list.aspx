<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ref_industry_list.aspx.vb" Inherits="srx.ref_industry_list" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<style>
			.backImg {
				height : 30px;				
			}
			/* Hide the 4th column cells */
			/* table td:nth-child(4) {
				display: none;
			} */
		</style>
	</HEAD>
	<!-- #include file ="html\BodyColor.html" -->
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<FORM id="Form1" style="FONT: menu" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main" style="MARGIN-TOP: 43px">
				<!-- Header -->
				<div style="MARGIN-TOP: 15px;">										
					<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To References" CssClass="backImg w3-hover-opacity" UseSubmitBehavior="False"/>
					<b class="w3-medium">&nbsp;Industry</b>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4" style="margin: auto;MAX-WIDTH: 600px">
						<HEADER class="w3-container w3-light-grey w3-display-container w3-responsive">
							<SPAN onclick="document.getElementById('id01').style.display='none'" class="w3-button w3-large w3-hover-red w3-display-topright">x</SPAN>
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-container w3-section w3-medium">
							<P><LABEL><B></B></LABEL><BR>
								<asp:label tabIndex="1" id="lblID" runat="server" Visible="false"></asp:label></P>
							<P><LABEL><B>Name</B></LABEL><BR>
								<asp:textbox tabIndex="1" id="txtName" runat="server" Width="100%" Placeholder="Type here..."></asp:textbox>
							</P>							
							<p><LABEL><B>SRP Code</B></LABEL><BR>
								<asp:dropdownlist id="ddlSRPCode" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl">
									<asp:ListItem Value="" Selected="True">&nbsp;</asp:ListItem>
									<asp:ListItem Value="SRP">SRP</asp:ListItem>
									<asp:ListItem Value="SRP2">SRP2</asp:ListItem>
									<asp:ListItem Value="SRP3">SRP3</asp:ListItem>
									<asp:ListItem Value="SRP4">SRP4</asp:ListItem>
									<asp:ListItem Value="SRP5">SRP5</asp:ListItem>									
								</asp:dropdownlist>
							</p>																		
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER></DIV>
				</asp:panel>
				<!-- End Input Form -->
				<!-- #include file ="html\SearchAndButtons.html" -->
				<!-- Sys Group Table -->
				<div class="w3-responsive">
					<TABLE id="tblGroupList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2"
						border="0">
						<tr>
							<th>
								<asp:datagrid id="DataGrid" runat="server" CellPadding="3" Width="100%" Height="24px" BackColor="White"
									BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical" BorderStyle="None">
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
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		<script src="js/MyJQueryScript.js"></script>
		<script>
			// Function for Datagrid Tables
			function filterTable(event) {
				var filter = event.target.value.toUpperCase();
				var rows = document.querySelector("#DataGrid tbody").rows;
				
				for (var i = 0; i < rows.length; i++) {
					var thridCol = rows[i].cells[3].textContent.toUpperCase();
					var fourthCol = rows[i].cells[4].textContent.toUpperCase();
					var fifthCol = rows[i].cells[5].textContent.toUpperCase();					
					if (thridCol.indexOf(filter) > -1 || fourthCol.indexOf(filter) > -1 || fifthCol.indexOf(filter) > -1) {
						rows[i].style.display = "";
					} else {
						rows[i].style.display = "none";
					}      
				}
			}
	
			document.querySelector('#myInput').addEventListener('keyup', filterTable, false);
		</script>
	</body>
</HTML>
