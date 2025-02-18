<%@ Page Language="vb" aspcompat="true" AutoEventWireup="false" Codebehind="sys_password.aspx.vb" Inherits="srx.sys_password" %>
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
				<div class="w3-quarter">&nbsp;</div>
				<div class="w3-half">
					<DIV class="w3-light-grey w3-card-4 w3-animate-opacity w3-panel w3-display-container w3-responsive">
						<%response.write("<a class='w3-hover-blue' href='sys_password.aspx'><span class='w3-button w3-large w3-hover-red w3-display-topright'>x</span></a>")%>
							<DIV class="w3-center">
								<H2>
									<asp:label id="lblMode" runat="server" Visible="true">Change Password</asp:label>									
								</H2>
							</DIV>
							<div>
								<div style="display:none">
									<p>
										<div class="w3-col s6" style="width:150px">ID:</div>		
										<div class="w3-tag w3-red w3-rest">																		
											<asp:label id="lblID" runat="server" Font-Bold="True">0</asp:label>										
										</div>
									</p>
								</div>
								<p>
									<div class="w3-col s6" style="width:150px">Old Password:</div>		
									<div class="w3-rest">
										<asp:TextBox id="txtOldPassword" tabindex="1" runat="server" MaxLength="255" CssClass="w3-input w3-border" TextMode="Password"></asp:TextBox>
										<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Width="8px" ControlToValidate="txtOldPassword"
											ErrorMessage="Old password must be filled." Display="Dynamic">*</asp:RequiredFieldValidator>
									</div>
								</p>
								<p>
									<div class="w3-col s6" style="width:150px">New Password:</div>		
									<div class="w3-rest">
										<asp:TextBox id="txtNewPassword" tabindex="2" runat="server" CssClass="w3-input w3-border" MaxLength="255" TextMode="Password"></asp:TextBox>
										<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" Width="9px" Height="16px" ControlToValidate="txtNewPassword"
											ErrorMessage="New password must be filled.">*</asp:RequiredFieldValidator>
										<asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" Width="8px" ControlToValidate="txtNewPassword"
											ErrorMessage="Invalid password format. Valid chars: a-z A-Z 0-9" ValidationExpression="^[a-zA-Z0-9.@$^!]{0,25}$">*</asp:RegularExpressionValidator>
									</div>
								</p>
								<p>
									<div class="w3-col s6" style="width:150px">Confirm New Password:</div>		
									<div class="w3-rest">
										<asp:TextBox id="txtConfirmPassword" tabindex="3" runat="server" CssClass="w3-input w3-border" MaxLength="255" TextMode="Password"></asp:TextBox>
										<asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" Width="1px" Height="16px" ControlToValidate="txtConfirmPassword"
											ErrorMessage="New password confirmation must be filled.">*</asp:RequiredFieldValidator>
										<asp:CompareValidator id="CompareValidator1" runat="server" Width="1px" Height="15px" ControlToValidate="txtConfirmPassword"
											ErrorMessage="New password does not match." ControlToCompare="txtNewPassword">*</asp:CompareValidator>
									</div>
								</p>
							</div>
							
							<DIV class="w3-border-top w3-light-grey">
								<P>
									<asp:button id="btnSave" tabindex="4" CssClass="w3-btn w3-blue w3-large w3-input" runat="server" Text="OK"></asp:button>									
										<SPAN>
											<asp:validationsummary id="ValidationSummary1" runat="server" Width="492px" Visible="False" Height="24px" ShowMessageBox="True"></asp:validationsummary>
											<asp:label id="lblMessage" runat="server" Width="312px" Height="6px" ForeColor="Red"></asp:label>
										</SPAN>
								</P>
							</DIV>
						</DIV> 	
				</div>
				<br>								
			</div>	
			<!-- End !PAGE CONTENT! Main Div -->
		</FORM>

		<script src="js/MyJS.js"></script>		
	</body>
</HTML>
