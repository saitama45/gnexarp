<%@ Page Language="vb" aspcompat="true" AutoEventWireup="false" Codebehind="sys_login.aspx.vb" Inherits="rasa.Login" %>
<%
Session.Abandon()
FormsAuthentication.SignOut()

Dim username
Dim password
Dim conn
Dim rs
Dim connStr
Dim objCommand
Dim sql

'Pass the parameter from inputed textbox
username = request.form("txtUserName")
password = request.form("txtPassword")

conn = Server.CreateObject("ADODB.Connection")

conn.Open("Provider=SQLOLEDB.1;Data Source=127.0.0.1;Initial Catalog=rasa;User Id=sa;Password=masterkey;Timeout=100")

rs = Server.CreateObject("ADODB.recordset")

sql = "select su.access_start, su.access_end, sg.code, sg.id, ltrim(rtrim(su.fullname)), sg.default_screen from SYS_USER su left outer join SYS_GROUP sg on sg.id = su.sys_group where su.uid = '" & username & "' and pwdcompare('" & password & "', su.password) = 1"

Dim loginRS = conn.Execute(sql)

Session("Group") = loginRS("code")


%>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<title>Home Login</title>
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<meta charset="UTF-8" />
		<link rel="stylesheet" href="css/w3layouts.css" type="text/css" media="all" />	
		<link rel="stylesheet" href="css/font-awesome.min.css">
		<link href="//fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i&amp;subset=devanagari,latin-ext"
	 rel="stylesheet">
		
		<!--  Desktop Favicons  -->
		<link rel="icon" type="image/png" href="./images/favicon_96x96.ico" sizes="96x96">
		
		<script>
			addEventListener("load", function () {
				setTimeout(hideURLbar, 0);
			}, false);

			function hideURLbar() {
				window.scrollTo(0, 1);
		}
	</script>

	</HEAD>
	<body>
		<div class="main-w3ls">
			<div class="left-content">				
				<div class="w3ls-content">					
					<!-- logo -->
					<h1>
						<a target="_blank"><IMG style="WIDTH: 200px; margin-bottom: 20px" src="images/company_logo.png"></a>
					</h1>
					<!-- //logo -->
					<h2>Inventory Management System</h2>				
				</div>
				<!-- copyright -->
				<div class="copyright">
					<p>
					</p>
				</div>
				<!-- //copyright -->
			</div>
			<div class="right-form-agile">
				<!-- content -->
				<div class="sub-main-w3">
					<h3 style="text-align: center;"></h3>					
					<form id="Form1" method="post" runat="server">
						<div class="form-style-agile">
							<label>Username</label>
							<div class="pom-agile">
								<span class="fa fa-user"></span>																
								<asp:textbox id="txtUserName" tabIndex="1" runat="server" MaxLength="15" placeholder="User Name" autocomplete="off"></asp:textbox>
								<asp:requiredfieldvalidator id="Requiredfieldvalidator2" runat="server" ErrorMessage="Please enter your user ID."
									ControlToValidate="txtUserName">*
								</asp:requiredfieldvalidator>
							</div>
						</div>						
						<div class="form-style-agile">
							<label>Password</label>
							<div class="pom-agile">
								<span class="fa fa-key"></span>								
								<asp:textbox id="txtPassword" tabIndex="2" runat="server" MaxLength="255" placeholder="Password" TextMode="Password" autocomplete="off"></asp:textbox>
							</div>
						</div>												
						<asp:button id="btnSubmit" tabIndex="3" runat="server" Text="Login"></asp:button>
						<br><br>					
						<!-- logo -->
						<h1 style="text-align: center;">
							<a href="https://www.mykeysystems.com/" target="_blank"><IMG style="WIDTH: 200px; margin-bottom: 20px" src="images/mykey_logo.png"></a>
						</h1>
						<!-- //logo -->
						<br>
						<asp:validationsummary id="ValidationSummary1" runat="server" ShowMessageBox="True" style="color:red;"></asp:validationsummary> 
						<!-- <asp:label id="lblPrompt" runat="server" style="color:red;"></asp:label> -->
					</form>					
				</div>
			</div>
		</div>
		<!-- //content -->				

	<script type="text/javascript">
		$(document).ready(function () {            
			var url = window.location.href;
			window.history.go(-window.history.length);
			window.location.href = 'sys_login'; // REDIRECT TO LOGIN PAGE
		});
	
	</script>
	</body>
</HTML>
