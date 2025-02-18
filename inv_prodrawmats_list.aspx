<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_prodrawmats_list.aspx.vb" Inherits="rasa.inv_prodrawmats_list" %>
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
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;Product Raw Mats List</b></h5>
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
							<P><LABEL><B>Raw Material</B></LABEL><BR>
								<asp:dropdownlist tabIndex="1" id="ddlRawMats" runat="server" CssClass="w3-tag w3-pale-blue w3-mobile"></asp:dropdownlist>
							</P>							
							<P><LABEL><B>UOM</B></LABEL><BR>
								<asp:dropdownlist tabIndex="2" id="ddlUOM" runat="server" CssClass="w3-tag w3-pale-blue w3-mobile"></asp:dropdownlist>
							</P>
							<P><LABEL><B>Qty</B></LABEL><BR>
								<asp:textbox tabIndex="3" id="txtQty" runat="server" Placeholder="0.00"></asp:textbox>
							</P>							
						</DIV>
						<FOOTER class="w3-container w3-blue"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER></DIV>
				</asp:panel>
				<!-- End Input Form -->
				<!-- Header -->
				<div class="w3-row">
					<div class="w3-third">
						<div class="w3-container w3-cyan">
							<div class="w3-bar w3-bottombar w3-border-khaki">
								<h5 class="w3-bar-item"><b><i class="fas fa-file-invoice"></i>&nbsp;Product Version Details</b></h5>
								<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top w3-bar-item" runat="server"
									Target="_blank" ToolTip="View transaction history. ">View Full History</asp:hyperlink>								
								<asp:button id="btnBackToList" CssClass="Style: Class= w3-btn w3-ripple w3-khaki w3-bar-item w3-margin-top w3-mobile w3-right"
									runat="server" Text="Back to list"></asp:button>
							</div>
							<p>
								Product Version Ref#:&nbsp;
								<asp:label id="lblProdVersionRefNo" class="w3-rest s6 w3-tag w3-red w3-small" runat="server" Font-Bold="True">0</asp:label>
							</p>
							<p>
								Product Code:&nbsp;
								<asp:label id="lblProductCode" class="w3-rest s6 w3-tag w3-amber w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>
							<p>
								Product Name:&nbsp;
								<asp:label id="lblProduct" class="w3-rest s6 w3-tag w3-aqua w3-medium" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Version:&nbsp;
								<asp:label id="lblVersion" class="w3-rest s6 w3-tag w3-blue w3-medium" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Description:&nbsp;
								<asp:label id="lblDesc" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Is Active?:&nbsp;
								<asp:label id="lblIsActive" class="w3-rest s6 w3-tag w3-green w3-medium" runat="server" Font-Bold="True"></asp:label>
							</p>							
						</div>
						<!-- End Header -->
					</div>
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
					.replace(/,/g, '');					
				});
			});
		</script>
		
	</body>
</HTML>
