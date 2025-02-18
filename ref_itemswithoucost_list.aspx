<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ref_itemswithoucost_list.aspx.vb" Inherits="srx.ref_itemswithoucost_list" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		
		<style>
			.backImg {
				height : 30px;				
			}
			.custom-file-input {
				color: transparent;
				display: none;
			}
			.custom-file-input::-webkit-file-upload-button {
				visibility: hidden;
			}
			.custom-file-input::before {
				content: 'Import CSV';
				color: black;
				display: inline-block;
				background: -webkit-linear-gradient(top, #084cdf, #e3e3e3);
				border: 1px solid #999;
				border-radius: 3px;
				padding: 5px 8px;
				outline: none;
				white-space: nowrap;
				-webkit-user-select: none;
				font-size: 10pt;
			}
			.custom-file-input:hover::before {
				border-color: black;
			}
			.custom-file-input:active {
				outline: 0;
			}
			.custom-file-input:active::before {
				background: -webkit-linear-gradient(top, #e3e3e3, #f9f9f9); 
			}		
			.custom-file-input::after {
				content: attr(data-file-name);
				display: inline-block;
				margin-left: 10px;
				color: black;
				font-size: 10pt;
			}
			
			/* Hiding of column ID in datagrid */			
			.myDataGrid tr th:nth-child(2),
			.myDataGrid tr td:nth-child(2) {
				display: none;
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
					<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To References" CssClass="backImg w3-hover-opacity"/>
					<b class="w3-medium">&nbsp;Items</b>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<div style="margin: auto;MAX-WIDTH: 300px">
					<asp:table id="tblShowValidation" runat="server" CssClass="w3-text-red w3-center" Visible="False"></asp:table>									
				</div>	
				<!-- Input Form -->
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4" style="margin: auto;MAX-WIDTH: 600px">
						<HEADER class="w3-container w3-display-container w3-responsive">
							<%response.write("<a class='w3-hover-blue' href='ref_itemswithoucost_list'><span class='w3-button w3-large w3-hover-red w3-display-topright'>x</span></a>")%>
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-container w3-section w3-medium">
							<P><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
								<asp:label id="lblCode" runat="server" Visible="False"></asp:label>
							</P>
							<P><LABEL><B>Status</B></LABEL><BR>								
								<asp:dropdownlist tabIndex="1" id="ddlStatus" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl">
									<asp:ListItem Value="ACTIVE" Selected="True">ACTIVE</asp:ListItem>
									<asp:ListItem Value="INACTIVE">INACTIVE</asp:ListItem>
								</asp:dropdownlist>
							</P>	
							<P><LABEL><B>Company</B></LABEL><BR>
								<asp:dropdownlist id="ddlCompany" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
							</P>
							<P style="display:none"><LABEL><B>Warehouse</B></LABEL><BR>
								<asp:CheckBoxList tabIndex="2" id="chbWarehouse" runat="server" RepeatColumns="1" Visible="False" ></asp:CheckBoxList>
							</P>												
							<P><LABEL><B>Barcode</B></LABEL><BR>
								<asp:textbox tabIndex="3" id="txtBarcode" runat="server" Width="100%" Placeholder="Type here..." onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</P>
							<P><LABEL><B>Sub Code</B></LABEL><BR>
								<asp:textbox tabIndex="4" id="txtClientCode" runat="server" Width="100%" Placeholder="Type here..." onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</P>
							<P><LABEL><B>Type</B></LABEL><BR>
								<asp:dropdownlist tabIndex="5" id="ddlType" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl">
									<asp:ListItem Value="MI" Selected="True">Merchandise Inventory</asp:ListItem>
									<asp:ListItem Value="NON-MI">NON-Merchandise Inventory</asp:ListItem>
									<asp:ListItem Value="FA">Fixed Assets</asp:ListItem>
								</asp:dropdownlist>
							</P>
							<P><LABEL><B>Brand</B></LABEL><BR>
								<asp:dropdownlist tabIndex="6" id="ddlBrand" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
							</P>
							<P><LABEL><B>Category</B></LABEL><BR>
								<asp:dropdownlist tabIndex="7" id="ddlCategory" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
							</P>
							<P><LABEL><B>SubCategory</B></LABEL><BR>
								<asp:dropdownlist tabIndex="8" id="ddlSubCategory" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
							</P>
							<P><LABEL><B>Item Name</B></LABEL><BR>
								<asp:textbox tabIndex="9" id="txtName" runat="server" Width="100%" Placeholder="Type here..." onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
							</P>	
							<P><LABEL><B>Specs</B></LABEL><BR>
								<asp:textbox tabIndex="10" id="txtSpecs" runat="server" Width="100%" Placeholder="Type here..." TextMode="MultiLine"></asp:textbox>
							</P>					
							<P><LABEL><B>UOM</B></LABEL><BR>
								<asp:dropdownlist tabIndex="11" id="ddlUOM" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
							</P>																			
							<P><LABEL><B>SRP</B></LABEL><BR>
								<asp:textbox tabIndex="13" id="txtSRP" runat="server" Width="100%" Placeholder="0" CssClass="amount" required onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</P>
							<P><LABEL><B>SRP2</B></LABEL><BR>
								<asp:textbox tabIndex="14" id="txtSRP2" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</P>
							<P><LABEL><B>SRP3</B></LABEL><BR>
								<asp:textbox tabIndex="15" id="txtSRP3" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</P>
							<P><LABEL><B>SRP4</B></LABEL><BR>
								<asp:textbox tabIndex="16" id="txtSRP4" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</P>
							<P><LABEL><B>SRP5</B></LABEL><BR>
								<asp:textbox tabIndex="17" id="txtSRP5" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</P>
							<P><LABEL><B>SRP6</B></LABEL><BR>
								<asp:textbox tabIndex="18" id="txtSRP6" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</P>
							<P><LABEL><B>SRP7</B></LABEL><BR>
								<asp:textbox tabIndex="18" id="txtSRP7" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</P>
							<div style="display:none;">
								<P><LABEL><B>SRP8</B></LABEL><BR>
									<asp:textbox tabIndex="18" id="txtSRP8" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</P>
								<P><LABEL><B>SRP9</B></LABEL><BR>
									<asp:textbox tabIndex="18" id="txtSRP9" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</P>
								<P><LABEL><B>SRP10</B></LABEL><BR>
									<asp:textbox tabIndex="18" id="txtSRP10" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</P>
								<P><LABEL><B>SRP11</B></LABEL><BR>
									<asp:textbox tabIndex="18" id="txtSRP11" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</P>
								<P><LABEL><B>SRP12</B></LABEL><BR>
									<asp:textbox tabIndex="18" id="txtSRP12" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</P>
								<P><LABEL><B>SRP13</B></LABEL><BR>
									<asp:textbox tabIndex="18" id="txtSRP13" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</P>
								<P><LABEL><B>SRP14</B></LABEL><BR>
									<asp:textbox tabIndex="18" id="txtSRP14" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</P>
								<P><LABEL><B>SRP15</B></LABEL><BR>
									<asp:textbox tabIndex="18" id="txtSRP15" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</P>
							</div>														
							<P><LABEL><B>Incentive 1</B></LABEL><BR>
								<asp:textbox tabIndex="19" id="txtInc1" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</P>
							<P><LABEL><B>Incentive 2</B></LABEL><BR>
								<asp:textbox tabIndex="20" id="txtInc2" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</P>
							<P><LABEL><B>Incentive 3</B></LABEL><BR>
								<asp:textbox tabIndex="21" id="txtInc3" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
							</P>
							<asp:panel id="panelSafetyLevel" style="Z-INDEX: 0" runat="server" Visible="False">
								<P><LABEL><B>Safety Level</B></LABEL><BR>
									<asp:textbox tabIndex="22" id="txtSafetyLevel" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')"></asp:textbox>
								</P>							
							</asp:panel>							
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER></DIV>
				</asp:panel>
				<!-- End Input Form -->
				<asp:panel id="panelGrid" style="Z-INDEX: 0;" runat="server" Visible="True">
					<!-- Hidden Paginations -->
					<asp:textbox id="txtMorePage" style="POSITION: absolute; LEFT: 440px; Z-INDEX: 101; TOP: 8px" runat="server" Width="32px" Visible="False" Height="18px">0</asp:textbox>
					<asp:label id="Label2" style="POSITION: absolute; LEFT: 368px; Z-INDEX: 102; TOP: 8px" runat="server" Width="64px" Visible="False" Height="2px">More Page</asp:label>
					<asp:label id="Label3" style="POSITION: absolute; LEFT: 488px; Z-INDEX: 103; TOP: 8px" runat="server" Visible="False" Width="48px" Height="8px">Page #</asp:label>
					<asp:textbox id="txtPageNo" style="POSITION: absolute; LEFT: 544px; Z-INDEX: 104; TOP: 8px" runat="server" Visible="False" Width="32px" Height="18px">0</asp:textbox>
					<!-- End Hidden Paginations -->

					<!-- Pagination Buttons -->
					<div class="w3-cell-row">
						<div class="w3-bar w3-margin-right w3-mobile w3-responsive">
							<p>    
								<asp:button id="btnApplyInvoice" CssClass="w3-bar-item w3-btn w3-green w3-mobile" tabIndex="15"
									style="Z-INDEX: 0" runat="server" Visible="False" CausesValidation="False" Text="Apply Invoice"></asp:button>
								<asp:button id="btnUnpost" CssClass="w3-bar-item w3-btn w3-blue w3-mobile" runat="server" Text="Unpost" Visible="False"></asp:button>
								<asp:button id="btnBack" CssClass="w3-bar-item w3-btn w3-khaki w3-mobile" runat="server" Text="Back to List"
									CausesValidation="False" Visible="False"></asp:button>       
								<asp:LinkButton id="btnAddRecord" accessKey="R" runat="server" CssClass="w3-bar-item w3-block w3-btn w3-ripple w3-green w3-mobile"
									Text="New Record" ToolTip="Add a new record. Alt-R." CausesValidation="False"></asp:LinkButton>            
								<asp:button id="BtnFirst" accessKey="F" runat="server" CssClass="w3-bar-item w3-block w3-btn w3-ripple w3-blue-grey w3-mobile"
									Text="(F)irst" ToolTip="Go to the first page of records. Alt-F." CausesValidation="False" Visible="False"></asp:button>
								<asp:button id="btnPrevious" accessKey="P" runat="server" Text="(P)revious" CssClass="w3-bar-item w3-block w3-btn w3-ripple w3-blue-grey w3-mobile"
									CausesValidation="False" ToolTip="Go to the previous page of records. Alt-P." Visible="False"></asp:button>
								<asp:button id="BtnNext2" accessKey="N" runat="server" Text="(N)ext" CssClass="w3-bar-item w3-block w3-btn w3-ripple w3-blue-grey w3-mobile"
									CausesValidation="False" ToolTip="Go to the next page of records. Alt-N." Visible="False"></asp:button>
								<asp:button id="btnLast" accessKey="L" runat="server" CssClass="w3-bar-item w3-block w3-btn w3-ripple w3-blue-grey w3-mobile"
									Text="(L)ast" ToolTip="Go to the last page of records. Alt-L." CausesValidation="False" Visible="False"></asp:button>
								<asp:panel id="panelSearchBy" runat="server" Visible="False">
									<label id="lblSearchBy" class="w3-bar-item w3-block"><b>Search By:&nbsp;</b></label>
									<asp:dropdownlist id="ddlSearchBy" runat="server" CssClass="w3-bar-item w3-tag w3-blue w3-hover-blue w3-mobile" AutoPostBack="False">
										<asp:ListItem Value="0">Billing #</asp:ListItem>
										<asp:ListItem Value="1" Selected="True">Invoice #</asp:ListItem>
										<asp:ListItem Value="2">Particulars</asp:ListItem>
										<asp:ListItem Value="3">BS Amount (w/o comma ",")</asp:ListItem> 
										<asp:ListItem Value="4">Client Name</asp:ListItem>        
									</asp:dropdownlist>
								</asp:panel>            
								<asp:textbox id="txtSearch" class="w3-bar-item w3-input w3-white w3-border w3-mobile" accessKey="K" runat="server" Placeholder="Search.." MaxLength="50" onkeypress="return clickButton(event,'btnSearch')"></asp:textbox>
								<asp:button id="btnSearch" accessKey="S" runat="server" Text="Go" CssClass="w3-bar-item w3-btn w3-green w3-mobile" CausesValidation="False" OnClientClick="searchButtonClick()"></asp:button>																		
								<asp:hyperlink id="hlViewFullTrail" class="w3-bar-item w3-tag w3-khaki w3-small w3-mobile" runat="server" Target="_blank" ToolTip="View transaction trail" Visible="False">Audit Trail</asp:hyperlink>            									
							</p>
						</div>      
					</div>
					<!-- End Pagination Buttons -->
					<br>
					<!-- Page Records -->
					<div class="w3-padding w3-light-grey w3-bottombar w3-border-blue-grey w3-border w3-medium" style="display:none;">
						<asp:label id="lblPageRecordCount" runat="server" Height="16px" Visible="False">Records in this page - Page X of Y</asp:label>
						&nbsp;Records per page:
						<asp:dropdownlist id="ddlRecordsPerPage" runat="server" AutoPostBack="True">
							<asp:ListItem Value="5">5</asp:ListItem>
							<asp:ListItem Value="10">10</asp:ListItem>
							<asp:ListItem Value="25">25</asp:ListItem>
							<asp:ListItem Value="100" Selected="True">100</asp:ListItem>
						</asp:dropdownlist>
					</div>					
					<asp:panel id="panelPaginations" runat="server">
						<asp:button runat="server" id="btnPrev" CssClass="w3-text-small w3-button w3-hover-blue" Text="&#10094;" Enabled="False" style="background-color: #708090;"></asp:button>
						<span>Page&nbsp;</span><b><asp:textbox runat="server" id="txtCurrentPage" CssClass="w3-text-small w3-center" width="30px" Autopostback="True">1</asp:textbox></b>&nbsp;of&nbsp;<b><asp:label runat="server" id="lblPageTotal" CssClass="w3-text-small">1</asp:label></b>
						<asp:button runat="server" id="btnNext" CssClass="w3-text-small w3-button w3-hover-blue" Text="&#10095;" style="background-color: #708090;"></asp:button>
					</asp:panel>
					<!-- End Page Records -->
					<!-- Sys Group Table -->
					<div class="w3-responsive">
						<TABLE id="tblGroupList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2"
							border="0">
							<tr>
								<th>
									<asp:datagrid id="DataGrid" runat="server" CellPadding="3" Width="100%" Height="24px" BackColor="White"
										BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical" BorderStyle="None" ShowFooter="False"
										Cssclass="myDataGrid">
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
						<asp:label id="lblTotalRecords" style="Z-INDEX: 0" runat="server" Font-Bold="True"></asp:label>
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
			$('.amount').on('input', function(event) {
				// Get the current value
				var currentValue = $(this).val();
    
				// Remove any non-numeric characters
				var newValue = currentValue.replace(/[^\d.]/g, '');
								
				// Update the input value
				$(this).val(newValue);
			});
			
			$('.myddl').select2({
				dropdownCssClass: 'w3-pale-blue',
				selectionCssClass: 'w3-pale-blue'								
			});

			$(document).ready(function() {
				// Hide the btnUploadSO button initially
				$('#btnUploadSO').hide();

				// Show the btnUploadSO button when a file is selected
				$('#FileUploadSO').change(function() {
					$('#btnUploadSO').show();
				});
			});
		</script>
	</body>
</HTML>
