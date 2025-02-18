<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ref_products_list.aspx.vb" Inherits="rasa.ref_products_list" %>
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
					<h5 class="w3-left"><b>&nbsp;Products Lists</b></h5>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4" style="MAX-WIDTH: 600px"><HEADER class="w3-container w3-blue w3-display-container w3-responsive"><SPAN onclick="document.getElementById('id01').style.display='none'" class="w3-button w3-large w3-hover-red w3-display-topright">x</SPAN>
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-container w3-section w3-medium">
							<P><LABEL><B>Ref#</B></LABEL><BR>
								<asp:label tabIndex="1" id="lblID" runat="server" CssClass="w3-tag w3-red"></asp:label></P>
							<P><LABEL><B>Product Name</B></LABEL><BR>
								<asp:textbox tabIndex="1" id="txtName" runat="server" Width="100%" Placeholder="Type here..."></asp:textbox>
							</P>
							<P><LABEL><B>Stock On Hand</B></LABEL><BR>
								<asp:textbox tabIndex="2" id="txtStock" runat="server" Placeholder="0"></asp:textbox>
							</P>
						</DIV>
						<FOOTER class="w3-container w3-blue"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER></DIV>
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
									<FooterStyle ForeColor="Black" BackColor="#CCCCCC"></FooterStyle>
									<SelectedItemStyle Font-Bold="True" ForeColor="White" CssClass="w3-pale-blue" BackColor="Green"></SelectedItemStyle>
									<EditItemStyle></EditItemStyle>
									<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
									<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
									<HeaderStyle Font-Bold="True" ForeColor="White" CssClass="Class: w3-blue" BackColor="#000084"></HeaderStyle>
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
