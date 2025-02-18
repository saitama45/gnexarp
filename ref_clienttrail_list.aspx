<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ref_clienttrail_list.aspx.vb" Inherits="ibcms.ref_clienttrail_list" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<link rel="stylesheet" type="text/css" href="css/twitter-bootstrap/3.0.3/bootstrap.min.css">
	</HEAD>
	<body class="w3-light-grey">
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<FORM id="Form1" style="FONT: menu" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main" style="MARGIN-TOP: 43px">
				<!-- Header -->
				<div style="MARGIN-BOTTOM: 50px; PADDING-TOP: 20px">
					<h5 class="w3-left"><b><i class="fas fa-history"></i>&nbsp;Client Trail Lists</b></h5>
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 w3-half"><HEADER class="w3-container w3-blue w3-display-container w3-responsive"><SPAN onclick="document.getElementById('id01').style.display='none'" class="w3-button w3-large w3-hover-red w3-display-topright">�</SPAN>
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-container w3-section w3-medium">
							<P><LABEL><B>ID</B></LABEL><BR>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red"></asp:label>
							</P>
							<P><LABEL><B>Status</B></LABEL><BR>
								<asp:label id="lblCTStatus" runat="server" CssClass="w3-tag w3-orange"></asp:label>
							</P>
							<P><LABEL><B>LSC / MPC</B></LABEL><BR>
								<asp:listbox id="lstLSC" runat="server" SelectionMode="Single"></asp:listbox>
							</P>
							<P><LABEL><B>Business Platform</B></LABEL><BR>
								<asp:listbox id="lstBP" runat="server" SelectionMode="Single"></asp:listbox>
							</P>
							<P><LABEL><B>Satellite Office</B></LABEL><BR>
								<asp:listbox id="lstBranch" runat="server" SelectionMode="Single"></asp:listbox>
							</P>
							<P><LABEL><B>Effectivity Date</B></LABEL><BR>
								<ew:calendarpopup id="calEffectivityDate" style="Z-INDEX: 0" runat="server" VisibleDate="2015-11-13" CellPadding="2px"
									ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
									ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" tabIndex="4" onkeypress="return clickButton(event,'btnSave')">								
									<WEEKDAYSTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
									Font-Size="Medium"></WEEKDAYSTYLE><MONTHHEADERSTYLE BackColor="#8080FF" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
									Font-Size="Medium"></MONTHHEADERSTYLE><OFFMONTHSTYLE BackColor="AntiqueWhite" ForeColor="Gray" Font-Names="Verdana,Helvetica,Tahoma,Arial"
									Font-Size="Medium"></OFFMONTHSTYLE><GOTOTODAYSTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
									Font-Size="Medium"></GOTOTODAYSTYLE><TODAYDAYSTYLE BackColor="LightGoldenrodYellow" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
									Font-Size="Medium"></TODAYDAYSTYLE><DAYHEADERSTYLE BackColor="Orange" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
									Font-Size="Medium"></DAYHEADERSTYLE><WEEKENDSTYLE BackColor="LightGray" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
									Font-Size="Medium"></WEEKENDSTYLE><SELECTEDDATESTYLE BackColor="Yellow" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
									Font-Size="Medium"></SELECTEDDATESTYLE><CLEARDATESTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
									Font-Size="Medium"></CLEARDATESTYLE><HOLIDAYSTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
									Font-Size="Medium"></HOLIDAYSTYLE>
								</ew:calendarpopup></P>
							
						</DIV>
						<FOOTER class="w3-container w3-blue"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER></DIV>
				</asp:panel>
				<!-- End Input Form -->
				<!-- Header -->
				<div class="w3-row">
					<div class="w3-third">
						<div class="w3-container w3-cyan">
							<div class="w3-bar w3-bottombar w3-border-khaki">
								<h5 class="w3-bar-item"><b><i class="fas fa-newspaper-o"></i>&nbsp;Client Details</b></h5>
								<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top w3-bar-item" runat="server"
									Target="_blank" ToolTip="View transaction history. ">View Full History</asp:hyperlink>
								<asp:button id="btnBackToList" CssClass="w3-btn w3-ripple w3-khaki w3-bar-item w3-margin-top w3-mobile w3-right"
									runat="server" Text="Back to Lists"></asp:button>
							</div>
							<p>
								Status:&nbsp;
								<asp:label id="lblStatus" class="w3-rest s6 w3-tag w3-blue w3-medium" runat="server"
									Font-Bold="True">0</asp:label>
							</p>
							<p>
								Client Code:&nbsp;
								<asp:label id="lblClientCode" class="w3-rest s6 w3-tag w3-win8-violet w3-medium" runat="server"
									Font-Bold="True">0</asp:label>
							</p>
							<p>
								BU :&nbsp;
								<asp:label id="lblBU" runat="server" Font-Bold="True"></asp:label>&nbsp; 
								(<asp:label id="lblBUID" runat="server" Font-Bold="True"></asp:label>)
							</p>
							<p>
								Mother Client:&nbsp;
								<asp:label id="lblMotherClient" runat="server" Font-Bold="True"></asp:label>&nbsp; 
								<asp:label id="lblMotherCode" class="w3-rest s6 w3-tag w3-green w3-medium" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Client:&nbsp;
								<asp:label id="lblClient" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Account #:&nbsp;
								<asp:label id="lblClientAccountNo" class="w3-rest s6 w3-tag w3-orange w3-medium" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Payment Terms:&nbsp;
								<asp:label id="lblPaymentTerms" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Admin Fee:&nbsp;
								<asp:label id="lblAdminFee" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								DGA Fee:&nbsp;
								<asp:label id="lblDGAFee" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								DCA Fee:&nbsp;
								<asp:label id="lblDCAFee" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Others Fee:&nbsp;
								<asp:label id="lblOthersFee" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								Remarks:&nbsp;
								<asp:textbox class="w3-input w3-medium" id="txtRemarks" runat="server" MaxLength="1024" TextMode="MultiLine"
									Enabled="False"></asp:textbox>
							</p>
						</div>
					</div>
					<!-- End Header -->
					<div class="w3-rest w3-padding w3-mobile">
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
											<HeaderStyle Font-Bold="True" ForeColor="White" CssClass="Class: w3-deep-purple" BackColor="#000084"></HeaderStyle>
											<Columns>
												<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Cancel" EditText="Edit"></asp:EditCommandColumn>
												<asp:ButtonColumn Text="Approve" CommandName="Approve"></asp:ButtonColumn>
												<asp:ButtonColumn Text="Post" CommandName="Post"></asp:ButtonColumn>
											</Columns>
											<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
										</asp:datagrid>
									</th>
								</tr>
							</TABLE>
						</div>
					</div>
					<!-- End Sys Group Table -->
				</div>
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
                    var zeroCol = rows[i].cells[0].textContent.toUpperCase();
                    var oneCol = rows[i].cells[1].textContent.toUpperCase();
                    var twoCol = rows[i].cells[2].textContent.toUpperCase();        
                    if (zeroCol.indexOf(filter) > -1 || oneCol.indexOf(filter) > -1 || twoCol.indexOf(filter) > -1) {
                        rows[i].style.display = "";
                    } else {
                        rows[i].style.display = "none";
                    }
                }
            }

            document.querySelector('#myInput').addEventListener('keyup', filterTable, false);
		</script>
		<script type="text/javascript">
			$(function () {								
				$('[id*=lstLSC]').multiselect({
					includeSelectAllOption: true,					
					enableCaseInsensitiveFiltering: true,
					selectAllValue: 0
				});	
				$('[id*=lstBP]').multiselect({
					includeSelectAllOption: true,					
					enableCaseInsensitiveFiltering: true,
					selectAllValue: 0
				});
				$('[id*=lstBranch]').multiselect({
					includeSelectAllOption: true,					
					enableCaseInsensitiveFiltering: true,
					selectAllValue: 0
				});				
			});
		</script>
		
	</body>
</HTML>
