<%@ Page Language="vb" AutoEventWireup="false" Codebehind="sys_my_profile.aspx.vb" Inherits="srx.sys_my_profile" %>
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
				<!-- Profile -->
				<!-- #include file ="html\AlertPanel.html" -->
				<div class="w3-row w3-padding">
					<div class="w3-quarter">&nbsp;</div>
					<div class="w3-half">
						<div class="w3-card-4 w3-round w3-white w3-padding">
							<h4 class="w3-center">My Profile</h4>
							
							<hr class="w3-bottombar w3-border-blue">
							<p><i class="fas fa-id-badge fa-fw w3-margin-right w3-text-theme"></i>ID:
								<asp:label id="lblID" runat="server" Font-Bold="True" CssClass="w3-tag w3-red"></asp:label></p>
							<p><i class="fas fa-user-circle fa-fw w3-margin-right w3-text-theme"></i>User ID:
								<asp:label id="lblUserID" runat="server" Font-Bold="True"></asp:label></p>
							<p><i class="fas fa-user-secret fa-fw w3-margin-right w3-text-theme"></i>Account 
								as:
								<asp:label id="lblAccountGroup" runat="server" Font-Bold="True"></asp:label>&nbsp;
								<asp:label id="lblAccountGroupID" runat="server" Font-Bold="True"></asp:label>&nbsp;
								<asp:label id="lblSysGroupID" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p><i class="fas fa-address-card fa-fw w3-margin-right w3-text-theme"></i>Full 
								Name:
								<asp:label id="lblFullName" runat="server" Font-Bold="True"></asp:label></p>
							<p><i class="fas fa-envelope fa-fw w3-margin-right w3-text-theme"></i>Email 
								Address:
								<asp:textbox id="txtEmail" runat="server" Placeholder="type here..." Columns="50" MaxLength="320"
									Cssclass="w3-input w3-border w3-animate-input" pattern="[^@]+@[^@]+\.[a-zA-Z]{2,6}"></asp:textbox></p>
							<asp:panel id="panelNotedBy" Visible="False" Runat="server">
								<P><I class="fas fa-user fa-fw w3-margin-right w3-text-theme"></I><B>Noted By</B> (Your 
									Display Name when printing invoice):
									<asp:textbox id="txtNotedBy" runat="server" Placeholder="type here..." Columns="50" MaxLength="320"
										Cssclass="w3-input w3-border w3-animate-input"></asp:textbox></P>
							</asp:panel><asp:panel id="panelAuthorizedBy" Visible="False" Runat="server">
								<P><I class="fas fa-user fa-fw w3-margin-right w3-text-theme"></I><B>Authorized By</B>
									(Your Display Name when printing invoice):
									<asp:textbox id="txtAuthorizedBy" runat="server" Placeholder="type here..." Columns="50" MaxLength="320"
										Cssclass="w3-input w3-border w3-animate-input"></asp:textbox></P>
							</asp:panel>
							<p><i class="fas fa-upload fa-fw w3-margin-right w3-text-theme"></i>Upload 
								E-Signature (<b>.png</b> file type only): <INPUT id="FileUploadESign" class="w3-btn w3-bar-item w3-indigo w3-mobile" type="file"
									accept=".png" name="FileUploadESign" runat="server">
								
							</p>
							<p><i class="fas fa-file-signature fa-fw w3-margin-right w3-text-theme"></i>My E-Signature:
								<div id="divImgESign" runat="server" class="w3-card-4"></div>
							</P>							
							<hr class="w3-bottombar w3-border-blue">
							<asp:button id="btnSave" runat="server" CssClass="class: w3-btn w3-blue" Text="Save" Width="55px"></asp:button></div>
					</div>
					<div class="w3-quarter">&nbsp;</div>
				</div>
				<!-- End Profile --></div>
		</FORM>
		<script src="js/MyJS.js"></script>
	</body>
</HTML>
