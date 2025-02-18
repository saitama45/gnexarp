<%@ Page Language="vb" AutoEventWireup="false" Codebehind="sys_menu_list.aspx.vb" Inherits="srx.sys_Menu_list" %>
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
				<div style="padding-top: 20px; margin-bottom: 50px">
					<h5 class="w3-left"><b><i class="fas fa-monument"></i>&nbsp;Sub Menu Administration</b></h5>
				</div>
				<!-- End Header -->					
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				<asp:panel id="panelForm" style="Z-INDEX: 0," runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4" style="margin: auto;MAX-WIDTH: 600px">
						<HEADER class="w3-container w3-light-grey w3-display-container w3-responsive">												
							<%response.write("<a class='w3-hover-blue' href='sys_menu_list'><span class='w3-button w3-large w3-hover-red w3-display-topright'>x</span></a>")%>
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
							<div class="w3-col s6" style="width:100px">Code:</div>
							<div class="w3-rest">
								<asp:textbox id="txtCode" class="w3-input w3-medium" runat="server" Placeholder="Type here..." MaxLength="128" tabindex="1" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								<asp:regularexpressionvalidator id="RegularExpressionValidator1" runat="server" Width="8px" ErrorMessage="Invalid code format." ControlToValidate="txtCode" ValidationExpression="^[A-Za-z0-9_]*$">*</asp:regularexpressionvalidator>
							</div>
							</P>
							<P>
							<div class="w3-col s6" style="width:100px">Main Menu:</div>
							<div class="w3-rest">
								<asp:DropDownList id="ddlMainMenu" runat="server" tabindex="2" CssClass="w3-input"></asp:DropDownList>
								<asp:Button id="btnAddMainMenu" CssClass="class: w3-btn w3-win8-violet w3-large" runat="server" Text="Add Main Menu" tabindex="3"></asp:Button>
							</div>
							</P>
							<P>
							<div class="w3-col s6" style="width:100px">Sub Menu:</div>
							<div class="w3-rest">
								<asp:textbox id="txtSub_Menu" class="w3-input w3-medium" runat="server" Placeholder="Type here..." MaxLength="50" tabindex="4" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</div>
							</P>
							<P>
							<div class="w3-col s6" style="width:100px">Link Page:</div>
							<div class="w3-rest">
								<asp:textbox id="txtLink_Page" class="w3-input w3-medium" runat="server" Placeholder="Type here..." MaxLength="128" tabindex="5" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</div>
							</P>
							<P>
							<div class="w3-col s6" style="width:100px">Link Parameter:</div>
							<div class="w3-rest">
								<asp:textbox id="txtLink_Parameter" class="w3-input w3-medium" runat="server" Placeholder="Type here..." MaxLength="50" tabindex="6" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</div>
							</P>
							<P>
							<div class="w3-col s6" style="width:100px">Sort Order:</div>
							<div class="w3-rest">
								<asp:textbox id="txtSubMenuSortOrder" class="w3-input w3-medium" runat="server" Placeholder="Type here..." MaxLength="50" tabindex="6" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</div>
							</P>
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER>
					</DIV>
				</asp:panel>
				<!-- End Input Form -->
				<!-- Panel Main Menu Form -->
				<asp:panel id="panelMainMenu" style="Z-INDEX: 0," runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4" style="margin: auto;MAX-WIDTH: 600px">
						<HEADER class="w3-container w3-light-grey w3-display-container w3-responsive">												
							<%response.write("<a class='w3-hover-blue' href='sys_menu_list'><span class='w3-button w3-large w3-hover-red w3-display-topright'>x</span></a>")%>
							<H2 class="w3-center">
								<asp:label id="lblMainMenuMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtMainMenuFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-container w3-section w3-medium">
							<p>
							<div class="w3-col s6" style="width:100px;display:none">ID:</div>
							<div class="w3-tag w3-red w3-rest">
								<asp:label id="lblMainMenuID" runat="server" Font-Bold="True" Visible="False">0</asp:label>
							</div>
							</p>
							<P>
							<div class="w3-col s6" style="width:100px">Main Menu Name:</div>
							<div class="w3-rest">
								<asp:textbox id="txtMainMenuName" class="w3-input w3-medium" runat="server" Placeholder="Type here..." MaxLength="30" tabindex="8"></asp:textbox>
							</div>
							</P>
							<P>
							<div class="w3-col s6" style="width:100px">Main Menu Code:</div>
							<div class="w3-rest">
								<asp:textbox id="txtMainMenuCode" class="w3-input w3-medium" runat="server" Placeholder="Type here..." MaxLength="30" tabindex="9"></asp:textbox>
							</div>
							</P>
							<P>
							<div class="w3-col s6" style="width:100px">Sort Order:</div>
							<div class="w3-rest">
								<asp:textbox id="txtSortOrder" class="w3-input w3-medium" runat="server" Placeholder="Type here..." MaxLength="3" tabindex="9"></asp:textbox>
							</div>
							</P>																
						</DIV>
						<DIV class="w3-padding w3-border-top w3-light-grey">
							<FOOTER class="w3-container">							
								<asp:button id="btnSaveMainMenu" CssClass="OnClick: document.getElementById('AlertSuccess').style.display='block'; class: w3-btn w3-deep-purple w3-large" runat="server" Width="56px" Text="OK" tabindex="10"></asp:button>
								<asp:Button id="btnCancelMainMenu" CssClass="class: w3-btn w3-deep-purple w3-large" runat="server" Text="Cancel" tabindex="11"></asp:Button>
								<SPAN>
									<asp:validationsummary id="ValidationSummary2" runat="server" Width="492px" Visible="False" Height="24px" ShowMessageBox="True"></asp:validationsummary>
									<asp:label id="lblMainMenuMessage" runat="server" Width="312px" Height="6px" ForeColor="Red"></asp:label>
								</SPAN>							
							</FOOTER>
						</DIV>
					</DIV>
				</asp:panel>
				<!-- End Panel Main Menu Form -->
				<%response.write("<a class='w3-btn w3-bar-item w3-indigo w3-medium' href='sys_group_list.aspx'>Go To Group Permission</a>")%>
				<!-- #include file ="html\SearchAndButtons.html" -->	
				<!-- Sys Group Table -->
				<div class="w3-responsive" style="margin-bottom: 50px">
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
				var fourthCol = rows[i].cells[4].textContent.toUpperCase();
				var fifthCol = rows[i].cells[5].textContent.toUpperCase();		
				if (fourthCol.indexOf(filter) > -1 || fifthCol.indexOf(filter) > -1) {
					rows[i].style.display = "";
				} else {
					rows[i].style.display = "none";
				}      
			}
		}

		document.querySelector('#myInput').addEventListener('keyup', filterTable, false);

		function clickButton(e, btnSave){
			var evt = e ? e : window.event;
			var bt = document.getElementById(btnSave);
				if (bt){
					if (evt.keyCode == 13){
							bt.click();
							return false;
				}
			}
		}
		</script>
	</body>
</HTML>