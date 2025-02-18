<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_prodversions_list.aspx.vb" Inherits="rasa.inv_prodversions_list" %>
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
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;RM Formula Versions Lists</b></h5>
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
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red"></asp:label>
							</P>
							<asp:panel id="panelVersion" style="Z-INDEX: 0" runat="server" Visible="False">
								<P><LABEL><B>Version</B></LABEL><BR>
									<asp:label id="lblVersion" runat="server" CssClass="w3-tag w3-orange"></asp:label>
								</P>
							</asp:Panel>							
							<P><LABEL><B>Product</B></LABEL><BR>
								<asp:dropdownlist tabIndex="1" id="ddlProduct" runat="server" CssClass="w3-tag w3-pale-blue w3-mobile"></asp:dropdownlist>
							</P>
							<P><LABEL><B>Description</B></LABEL><BR>
								<asp:textbox tabIndex="2" id="txtDesc" runat="server" TextMode="MultiLine" MaxLength="250" Placeholder="Type here..."
									Width="100%"></asp:textbox>
							</P>
							<P><LABEL><B>Is Active?</B></LABEL><BR>
								<asp:checkbox tabIndex="3" id="cbxIsActive" runat="server"></asp:checkbox>								
							</P>
						</DIV>
						<FOOTER class="w3-container w3-blue"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER></DIV>
				</asp:panel>
				<!-- End Input Form -->
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
										<FooterStyle ForeColor="Black" BackColor="Plum"></FooterStyle>
										<SelectedItemStyle Font-Bold="True" ForeColor="White" CssClass="w3-pale-blue" BackColor="Green"></SelectedItemStyle>
										<EditItemStyle></EditItemStyle>
										<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
										<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
										<HeaderStyle Font-Bold="True" ForeColor="White" CssClass="Class: w3-deep-purple" BackColor="#000084"></HeaderStyle>
										<Columns>
											<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Cancel" EditText="Edit"></asp:EditCommandColumn>
											<asp:ButtonColumn Text="RawMats" CommandName="RawMats"></asp:ButtonColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
									</asp:datagrid>
								</th>
							</tr>
						</TABLE>
					</div>
					<!-- End Sys Group Table -->
				</div>
			</div>
			<DIV></DIV>
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
					.replace(/,/g, '');					
				});
			});
		</script>
	</body>
</HTML>
