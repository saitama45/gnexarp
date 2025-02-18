<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ref_picitems_list.aspx.vb" Inherits="srx.ref_picitems_list" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
		<script src="js/jquery.draggableTouch.js"></script>
		<style>
			#mydivheader {				
				cursor: move;
				z-index: 10;								
			}

			p {
				font-size: 14px !important;
				color: black;
			}

			.btnImg {
				height : 30px;				
			}

			.myForm {
				margin: auto;
				width: 410px;
				position: absolute;
				z-index: 10;
				background-color: #f1f1f1;		
				
			}

			.myFooter {
				margin-top: 150px;
			}		
			
			input[type=file]::file-selector-button {
				margin-right: 20px;
				border: none;
				background: #084cdf;
				padding: 10px 20px;
				border-radius: 10px;
				color: #fff;
				cursor: pointer;
				transition: background .2s ease-in-out;
			}

			input[type=file]::file-selector-button:hover {
				background: #0d45a5;
			}
		</style>
	</HEAD>
	<!-- #include file ="html\BodyColor.html" -->
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<FORM id="Form1" style="FONT: menu" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main">
				<!-- Header -->
				<div style="MARGIN-TOP: 40px">
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;</b></h5>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 myForm">
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">								
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">
							<asp:button id="btnX" CssClass="w3-button w3-large w3-hover-red w3-right" runat="server" Text="x"></asp:button>
							<P style="display:none"><LABEL><B></B></LABEL><BR>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
								<asp:dropdownlist id="ddlRawMats" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" ></asp:dropdownlist>
							</P>							
							<div class="w3-container">
								<LABEL><B></B></LABEL><BR>
									<asp:CheckBox id="chbIsDefault" runat="server" Text=" Is Default?" Checked="True"></asp:CheckBox>
									<br><br>
									<INPUT id="FileUpload" class="drop-container" type="file" name="FileUpload" accept=".png" onchange="validateFile(this)" maxlength="800000" minlength="100000" runat="server">
										<br><br>
								<asp:panel id="panelItemPic" runat="server">
									<div id="ImgItemPic" runat="server" class="w3-card w3-center"></div>
								</asp:panel>										
							</div>																									
						</DIV>
						<FOOTER class="w3-container myFooter"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER>
					</DIV>
				</asp:panel>
				<!-- End Input Form -->
				<asp:panel id="panelGrid" style="Z-INDEX: 0;" runat="server" Visible="True">
				<!-- Header -->
				<div class="w3-row">
					<div class="w3-third">
						<div class="w3-container w3-teal">
							<div style="display:none">
								<h5 class="w3-bar-item"><b><i class="fas fa-file-invoice"></i>&nbsp;Supplier</b></h5>
								<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top w3-bar-item" runat="server"
									Target="_blank" ToolTip="View transaction history. " Visible="False">Audit Trail</asp:hyperlink>								
								<asp:button id="btnBackToList" CssClass="Style: Class= w3-btn w3-ripple w3-khaki w3-bar-item w3-margin-top w3-mobile w3-right"
									runat="server" Text="Back to list"></asp:button>
							</div>
							<p>
								<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />
								<asp:ImageButton id="btnSaveImg" runat="server" ImageUrl="images/save_image.png" Tooltip="Save" CssClass="btnImg w3-hover-opacity w3-bar-item w3-right" />								
							</p>										
							<br>																												
							<hr class="w3-bottombar w3-border-khaki">	
							<p style="display:none">
								<asp:label id="lblItemID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
							</p>
							<P><LABEL><B>Status</B></LABEL><BR>								
								<asp:dropdownlist id="ddlStatus" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True">
									<asp:ListItem Value="ACTIVE" Selected="True">ACTIVE</asp:ListItem>
									<asp:ListItem Value="INACTIVE">INACTIVE</asp:ListItem>
								</asp:dropdownlist>
							</P>	
							<P><LABEL><B>Company</B></LABEL><BR>
								<asp:dropdownlist id="ddlCompany" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
							</P>
							<P><LABEL><B>Item Code</B></LABEL><BR>
								<asp:label id="lblCode" runat="server"></asp:label>
							</P>
							<P><LABEL><B>Item Name</B></LABEL><BR>
								<asp:textbox id="txtName" runat="server" Width="100%" Placeholder="Type here..." onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>																			
							<P><LABEL><B>Barcode</B></LABEL><BR>
								<asp:textbox id="txtBarcode" runat="server" Width="100%" Placeholder="Type here..." onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>Sub Code</B></LABEL><BR>
								<asp:textbox id="txtClientCode" runat="server" Width="100%" Placeholder="Type here..." onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>Type</B></LABEL><BR>
								<asp:dropdownlist id="ddlType" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True">
									<asp:ListItem Value="MI" Selected="True">Merchandise Inventory</asp:ListItem>
									<asp:ListItem Value="NON-MI">NON-Merchandise Inventory</asp:ListItem>
								</asp:dropdownlist>
							</P>
							<P><LABEL><B>Brand</B></LABEL><BR>
								<asp:dropdownlist id="ddlBrand" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
							</P>
							<P><LABEL><B>Category</B></LABEL><BR>
								<asp:dropdownlist id="ddlCategory" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
							</P>
							<P><LABEL><B>SubCategory</B></LABEL><BR>
								<asp:dropdownlist id="ddlSubCategory" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
							</P>															
							<P><LABEL><B>Specs</B></LABEL><BR>
								<asp:textbox id="txtSpecs" runat="server" Width="100%" Placeholder="Type here..." onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>					
							<P><LABEL><B>UOM</B></LABEL><BR>
								<asp:dropdownlist id="ddlUOM" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
							</P>	
							<P><LABEL><B>Cost</B></LABEL><BR>
								<asp:textbox id="txtCost" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>Landed Cost</B></LABEL><BR>
								<asp:textbox id="txtLandedCost" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>						
							<P><LABEL><B>SRP</B></LABEL><BR>
								<asp:textbox id="txtSRP" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP2</B></LABEL><BR>
								<asp:textbox id="txtSRP2" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP3</B></LABEL><BR>
								<asp:textbox id="txtSRP3" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP4</B></LABEL><BR>
								<asp:textbox id="txtSRP4" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP5</B></LABEL><BR>
								<asp:textbox id="txtSRP5" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP6</B></LABEL><BR>
								<asp:textbox id="txtSRP6" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP7</B></LABEL><BR>
								<asp:textbox id="txtSRP7" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP8</B></LABEL><BR>
								<asp:textbox id="txtSRP8" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP9</B></LABEL><BR>
								<asp:textbox id="txtSRP9" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP10</B></LABEL><BR>
								<asp:textbox id="txtSRP10" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP11</B></LABEL><BR>
								<asp:textbox id="txtSRP11" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP12</B></LABEL><BR>
								<asp:textbox id="txtSRP12" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP13</B></LABEL><BR>
								<asp:textbox id="txtSRP13" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP14</B></LABEL><BR>
								<asp:textbox id="txtSRP14" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>SRP15</B></LABEL><BR>
								<asp:textbox id="txtSRP15" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>							
							<P><LABEL><B>Incentive 1</B></LABEL><BR>
								<asp:textbox id="txtInc1" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>Incentive 2</B></LABEL><BR>
								<asp:textbox id="txtInc2" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>
							<P><LABEL><B>Incentive 3</B></LABEL><BR>
								<asp:textbox id="txtInc3" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>	
							<P><LABEL><B>Safety Level</B></LABEL><BR>
								<asp:textbox id="txtSafetyLevel" runat="server" Width="100%" Placeholder="0" CssClass="amount" onkeypress="return clickButton(event,'btnSave')" Autopostback="True"></asp:textbox>
							</P>																
						</div>
						<!-- End Header -->
					</div>
					<div class="w3-rest w3-padding w3-mobile">	
						<div style="display:none">
							<asp:ImageButton id="btnPrintImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print DR" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" />							
							<!-- #include file ="html\SearchAndButtons.html" -->	

						</div>	
						<p>
							<h5><b>Pictures</b></h5>
							<asp:ImageButton id="btnAddImg" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity" />							
						</p>										
						<p>
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
													<asp:ButtonColumn Text="View" CommandName="Download"></asp:ButtonColumn>													
													<asp:ButtonColumn Text="Delete" CommandName="Delete"></asp:ButtonColumn>
												</Columns>
												<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
											</asp:datagrid>
										</th>
									</tr>
								</TABLE>
							</div>
							<!-- End Sys Group Table -->
						</p>																						
					</asp:panel>
					</div>
				</div>
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		<script>                        
            $('.myddl').select2({
				dropdownCssClass: 'w3-pale-blue',
				selectionCssClass: 'w3-pale-blue'								
			});

			$('input').click(function() {
				$(this).select(); 
			});

			$(function() { $("#id01").draggable(); });

			$(function() {
				$('#FileUpload').change(function() {
					var file = this.files[0];
					var fileSize = file.size;
					var maxSize = 800000; // Maximum file size in bytes (800kb)
					var minSize = 100000; // Minimum file size in bytes (100kb)

					if (fileSize > maxSize) {
					alert("File is too large! Maximum size allowed is 800kb.");
					this.value = "";
					return;
					}

					if (fileSize < minSize) {
					alert("File is too small! Minimum size allowed is 100kb.");
					this.value = "";
					return;
					}

					var reader = new FileReader();
					reader.onload = function(e) {
					var img = new Image();
					img.src = e.target.result;
					img.onload = function() {
						var width = this.width;
						var height = this.height;
						var mime = this.src.substring(this.src.indexOf(":") + 1, this.src.indexOf(";"));
						if (mime !== "image/png") {
						alert("Invalid file type! Only PNG files are allowed.");
						$('#FileUpload').val('');
						return;
						}
					};
					};
					reader.readAsDataURL(file);
				});
			});


		</script>
		
	</body>
</HTML>
