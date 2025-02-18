<%@ Page Language="vb" AutoEventWireup="false" Codebehind="sys_special_access_list.aspx.vb" Inherits="srx.sys_Special_Access_list" %>
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
			<div id="main" class="w3-container w3-main" style="MARGIN-TOP: 43px;">
				<!-- Header -->
				<div style="PADDING-TOP: 20px; margin-bottom: 50px">
					<h5 class="w3-left"><b><i class="fas fa-sign-language"></i></i>&nbsp;Special Access Permission</b></h5>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4" style="margin: auto;MAX-WIDTH: 600px">
						<HEADER class="w3-container w3-light-grey w3-display-container w3-responsive">												
							<%response.write("<a class='w3-hover-blue' href='sys_special_access_list'><span class='w3-button w3-large w3-hover-red w3-display-topright'>x</span></a>")%>
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-container w3-section w3-medium">
							<p>
							<div class="w3-col s6" style="width:100px;display:none">ID:</div>
							<div class="w3-tag w3-red w3-rest">
								<asp:label id="lblID" runat="server" Font-Bold="True" Visible="False">0</asp:label>
							</div>
							</p>
							<P>
							<div class="w3-col s6" style="width:100px">Group:</div>
							<div class="w3-rest">
								<asp:DropDownList id="ddlGroup" runat="server" tabindex="1" CssClass="w3-input"></asp:DropDownList>
							</div>
							</P>
							<P>
							<div class="w3-col s6" style="width:100px">Menu:</div>
							<div class="w3-rest">
								<asp:DropDownList id="ddlMenu" runat="server" tabindex="2" CssClass="w3-input"></asp:DropDownList>
							</div>
							</P>
							<P>
							<div class="w3-col s6" style="width:100px">Special Button:</div>
							<div class="w3-rest">
								<asp:textbox id="txtSpecial_Access" class="w3-input w3-medium" runat="server" Placeholder="Type here..." MaxLength="50" tabindex="3"></asp:textbox>
							</div>
							</P>
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER>
					</DIV>
				</asp:panel>
				<!-- End Input Form -->
				<!-- #include file ="html\SearchAndButtons.html" -->
				<!-- Sys Group Table -->
				<div class="w3-responsive">
					<TABLE id="tblGroupList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2" border="0">
						<tr>
							<th>
								<asp:datagrid id="DataGrid" runat="server" CellPadding="3" Width="100%" Height="24px" BackColor="White"
									BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical" BorderStyle="None">
									<FooterStyle ForeColor="Black" BackColor="#CCCCCC"></FooterStyle>
									<SelectedItemStyle Font-Bold="True" ForeColor="Black" CssClass="w3-pale-blue" BackColor="Green"></SelectedItemStyle>
									<EditItemStyle></EditItemStyle>
									<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
									<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
									<HeaderStyle Font-Bold="True" ForeColor="White" CssClass="Class: w3-blue" BackColor="#000084"></HeaderStyle>
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
		<script>
			// Function for Datagrid Tables
			function filterTable(event) {
				var filter = event.target.value.toUpperCase();
				var rows = document.querySelector("#DataGrid tbody").rows;
				
				for (var i = 0; i < rows.length; i++) {
					var thirdCol = rows[i].cells[3].textContent.toUpperCase();
					var fourthCol = rows[i].cells[4].textContent.toUpperCase();
					var fifthCol = rows[i].cells[5].textContent.toUpperCase();					
					if (thirdCol.indexOf(filter) > -1 || fourthCol.indexOf(filter) > -1 || fifthCol.indexOf(filter) > -1) {
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