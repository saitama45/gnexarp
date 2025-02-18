<%@ Page Language="vb" aspcompat="true" AutoEventWireup="false" Codebehind="sys_login.aspx.vb" Inherits="srx.Login" %>
<%
Session.Abandon()
FormsAuthentication.SignOut()
%>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<meta charset="UTF-8" />
		
		<!--  Desktop Favicons  -->
		<link rel="icon" type="image/png" href="./images/favicon_96x96.ico" sizes="96x96">
		
		<!-- External CSS libraries -->
		<link type="text/css" rel="stylesheet" href="./assets/login/css/bootstrap.min.css">
		<link type="text/css" rel="stylesheet" href="./assets/login/fonts/font-awesome/css/font-awesome.min.css">
		<link type="text/css" rel="stylesheet" href="./assets/login/fonts/flaticon/font/flaticon.css">

		<!-- Custom Stylesheet -->
		<link type="text/css" rel="stylesheet" href="./assets/login/css/style.css">
		<link rel="stylesheet" type="text/css" id="style_sheet" href="./assets/login/css/skins/default.css">

		<script>
            addEventListener("load", function () {
                setTimeout(hideURLbar, 0);
            }, false);

            function hideURLbar() {
                window.scrollTo(0, 1);
            }
        </script>

	</HEAD>
	<body id="top">
		<!-- Login 17 start -->
		<div class="login-17">
			<div class="container-fluid">
				<div class="row login-box">
					<div class="col-lg-6 bg-img">
						<div class="info clearfix">
							<%--<h1>Welcome</h1>--%>
							<%--<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type</p>--%>
						</div>
					</div>
					<div class="col-lg-6 form-section clip-home">
						<div class="form-inner">
							<!-- <a href="login-17.html" class="logo">
								<img src="assets/img/logos/logo-2.png" alt="logo">
							</a> -->
							<h3>Sign In</h3>
							<form id="Form1" method="post" runat="server">
								<div class="form-group form-box">
									<asp:textbox id="txtUserName" runat="server" MaxLength="15" class="form-control" placeholder="User Name" autocomplete="off" required></asp:textbox>
									<asp:requiredfieldvalidator id="Requiredfieldvalidator2" runat="server" ErrorMessage="Please enter your user ID."
										ControlToValidate="txtUserName">*
									</asp:requiredfieldvalidator>									
									<i class="flaticon-mail-2"></i>
								</div>
								<div class="form-group form-box">
									<asp:textbox id="txtPassword" class="form-control" runat="server" MaxLength="255" placeholder="Password" TextMode="Password" autocomplete="off"></asp:textbox>
									<i class="flaticon-password"></i>
								</div>
								
								<div class="form-group">
									
									<asp:button id="btnSubmit" class="btn-md btn-theme w-100" runat="server" Text="Login"></asp:button>
									<br>
									<asp:validationsummary id="ValidationSummary1" runat="server" ShowMessageBox="True" style="color:red;"></asp:validationsummary> 
									<asp:label id="lblPrompt" runat="server" style="color:red;"></asp:label>
								</div>
								<div class="form-group">
									<a href="#"><IMG style="WIDTH: 170px; margin-bottom: 20px" src="images/company_logo.png"></a>
								</div>
							</form>
							
						</div>
					</div>
				</div>
			</div>
		</div>
		<!-- Login 17 end -->

					
	<!-- External JS libraries -->
	<script src="./assets/login/js/jquery.min.js"></script>
	<script src="./assets/login/js/popper.min.js"></script>
	<script src="./assets/login/js/bootstrap.bundle.min.js"></script>

	
	</body>
</HTML>
