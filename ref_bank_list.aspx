<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ref_bank_list.aspx.vb" Inherits="rasa.ref_bank_list" %>
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
					<h5 class="w3-left"><b><i class="fas fa-university"></i>&nbsp;Bank Lists</b></h5>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Bank Branch Form -->
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 w3-half"><HEADER class="w3-container w3-blue w3-display-container w3-responsive"><SPAN onclick="document.getElementById('id01').style.display='none'" class="w3-button w3-large w3-hover-red w3-display-topright">?</SPAN>
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-container w3-section w3-medium">
							<P><LABEL><B>ID</B></LABEL><BR>
								<asp:label tabIndex="1" id="lblID" runat="server" CssClass="w3-tag w3-red"></asp:label></P>
							<P><LABEL><B>Bank</B></LABEL><BR>
								<asp:dropdownlist tabIndex="2" id="ddlBank" runat="server"></asp:dropdownlist>
								<asp:Button id="btnAddBank" runat="server" CssClass="class: w3-btn w3-win8-violet w3-medium"
									Text="Add New Bank"></asp:Button>
								<asp:Button id="btnEditBank" runat="server" CssClass="class: w3-btn w3-green w3-medium" Text="Edit Bank"></asp:Button></P>
							<P><LABEL><B>Bank Branch</B></LABEL><BR>
								<asp:TextBox tabIndex="3" id="txtBankBranch" runat="server" Width="100%" MaxLength="100" Columns="50"></asp:TextBox></P>
						</DIV>
						<FOOTER class="w3-container w3-blue"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER></DIV>
				</asp:panel>
				<!-- End Bank Branch Form -->
				<!-- Bank Form -->
				<asp:panel id="panelBank" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 w3-half"><HEADER class="w3-container w3-blue w3-display-container w3-responsive"><SPAN onclick="document.getElementById('id01').style.display='none'" class="w3-button w3-large w3-hover-red w3-display-topright">?</SPAN>
							<H2 class="w3-center">
								<asp:label id="lblBankMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtBankFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-container w3-section w3-medium">
							<P><LABEL><B>ID</B></LABEL><BR>
								<asp:label tabIndex="4" id="lblBankID" runat="server" CssClass="w3-tag w3-red"></asp:label></P>
							<P><LABEL><B>Bank Name</B></LABEL><BR>
								<asp:TextBox tabIndex="5" id="txtBank" runat="server" Width="100%" MaxLength="100" Columns="50"></asp:TextBox></P>
							<P><LABEL><B>Bank Code</B></LABEL><BR>
								<asp:TextBox tabIndex="6" id="txtBankCode" runat="server" Width="100%" MaxLength="100" Columns="50"></asp:TextBox></P>
						</DIV>
						<FOOTER class="w3-container w3-blue">
							<asp:button tabIndex="30" id="btnBankSave" runat="server" CssClass="OnClick: document.getElementById('AlertSuccess').style.display='block'; class: w3-btn w3-green w3-large"
								Text="Save"></asp:button>
						</FOOTER></DIV>
				</asp:panel>
				<!-- End Bank Form -->
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
					var threeCol = rows[i].cells[3].textContent.toUpperCase();
					var fourCol = rows[i].cells[4].textContent.toUpperCase();				
					if (threeCol.indexOf(filter) > -1 || fourCol.indexOf(filter) > -1) {
						rows[i].style.display = "";
					} else {
						rows[i].style.display = "none";
					}      
				}
			}
	
			document.querySelector('#myInput').addEventListener('keyup', filterTable, false);
		</script>
		<P></P>
		<DIV></DIV>
		<DIV></DIV>
		<DIV></DIV>
		</FORM>
	</body>
</HTML>
