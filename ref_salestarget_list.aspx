<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ref_salestarget_list.aspx.vb" Inherits="srx.ref_salestarget_list" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<style>
			.backImg {
				height : 30px;				
			}
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
					<b class="w3-medium">&nbsp;Sales Target</b>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->				
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4" style="margin: auto;MAX-WIDTH: 600px">
						<HEADER class="w3-container w3-display-container w3-responsive">
							<%response.write("<a class='w3-hover-blue' href='ref_salestarget_list'><span class='w3-button w3-large w3-hover-red w3-display-topright'>x</span></a>")%>
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-container w3-section w3-medium">
							<P><LABEL><B></B></LABEL><BR>
								<asp:label tabIndex="1" id="lblID" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label></P>
							<P><LABEL><B>Company</B></LABEL><BR>
								<asp:dropdownlist id="ddlCompany" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
							</P>
							<P><LABEL><B>Year</B></LABEL><BR>
								<asp:dropdownlist tabIndex="1" id="ddlYear" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
							</P>
							<P><LABEL><B>Month</B></LABEL><BR>
								<asp:dropdownlist tabIndex="2" id="ddlMonth" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl">
									<asp:ListItem Value="JAN" Selected="True">JAN</asp:ListItem>
									<asp:ListItem Value="FEB">FEB</asp:ListItem>
									<asp:ListItem Value="MAR">MAR</asp:ListItem>
									<asp:ListItem Value="APR">APR</asp:ListItem>
									<asp:ListItem Value="MAY">MAY</asp:ListItem>
									<asp:ListItem Value="JUN">JUN</asp:ListItem>
									<asp:ListItem Value="JUL">JUL</asp:ListItem>
									<asp:ListItem Value="AUG">AUG</asp:ListItem>
									<asp:ListItem Value="SEP">SEP</asp:ListItem>
									<asp:ListItem Value="OCT">OCT</asp:ListItem>
									<asp:ListItem Value="NOV">NOV</asp:ListItem>
									<asp:ListItem Value="DEC">DEC</asp:ListItem>
								</asp:dropdownlist>
							</P>
							<P><LABEL><B>Amount</B></LABEL><BR>
								<asp:textbox tabIndex="3" id="txtAmount" runat="server" Width="100%" Placeholder="0.00" CssClass="txtNumbers" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
							</P>							
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER></DIV>
				</asp:panel>
				<!-- End Input Form -->
				<asp:panel id="panelGrid" style="Z-INDEX: 0;" runat="server" Visible="True">
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
		</script>
	</body>
</HTML>
