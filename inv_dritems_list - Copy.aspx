<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_dritems_list.aspx.vb" Inherits="ems.inv_dritems_list" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<%@ Import Namespace="System.Net" %> 
<%@ Import Namespace="System.Net.Mail" %>
<%@ Import Namespace="System.Configuration" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="System.Text" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Web" %>
<!DOCTYPE HTML>
<!-- <script runat="server">
	private Sub btnInTransit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		
		Dim objConnection As New SqlConnection(ConfigurationManager.AppSettings("appConn"))

		Dim objCommand As New SqlCommand("Web_ItemsForEmail_Get", objConnection)
		objCommand.CommandType = CommandType.StoredProcedure

		objCommand.Parameters.Add("@order_no", lblOrderNo.Text)		

		objConnection.Open()

		Dim objReader As SqlDataReader = objCommand.ExecuteReader

			Dim myItemsCart As String = String.Empty
			Dim counter As Integer = 1

			While objReader.Read

				myItemsCart &= ("<tr style='border-top: 1px solid black;'>" & _
									"<td style='text-align: left;'>" & _                                        
										"<h5>" & Trim(objReader("item_fullname")) & "</h5>" & _
										"<div class=clearfix'></div>" & _
									"</td>" & _
									"<td style='text-align: right;'>" & Trim(objReader("srp_show")) & "</td>" & _
									"<td style='text-align: center;'>" & _
										Trim(objReader("qty")) & _
									"</td>" & _
									"<td style='text-align: right;'>" & Trim(objReader("total_srp_show")) & "</td>" & _
								"</tr>")
			End While		

		objReader.Close()
		objConnection.Close()

		Dim strFrom = new MailAddress("Online Store <onlinestore@mykey.ph>") 
		Dim strTo as String = lblOnlineStoreCustomerEmail.Text
		Dim strTo2 as String = "genermagbanua45@gmail.com"
		Dim DateToday = DateTime.UtcNow.AddHours(8).ToShortDateString

		Dim MailMsg As New MailMessage()
		MailMsg.BodyEncoding = Encoding.Default
		MailMsg.To.Add(strTo)
		MailMsg.Bcc.Add(strTo2)        
		MailMsg.From = strFrom
		MailMsg.Subject = "Order No. " + lblOrderNo.Text + " IN TRANSIT"

		if lblFullname.Text <> "" Then
			MailMsg.Body &= ("<center><h2><b>Yehey! Your order is on its way!</b></h2></center><br/> Hi " + lblFirstname.Text + " " + lblLastname.Text + ", <br/><br/>" & _ 
							"Your order no. <b>" + lblOrderNo.Text + "</b> with payment via <b>" + lblPayType.Text + "</b> will attempt to deliver today, <b>" + DateToday + "</b>." & _ 
							"Thank you and have a great day. <br><br>" & _
							"<table style='border-collapse: collapse; width: 100%;'>" & _
								"<tr style='border-top: 1px solid black;'>" & _
									"<th style='text-align: center;'>Item</th>" & _
									"<th style='text-align: right;'>SRP</th>" & _
									"<th style='text-align: center;'>Quantity</th>" & _
									"<th style='text-align: right;'>Total</th>" & _
								"</tr>" & _
								myItemsCart & _					
							"</table>" & _
							"<br>" & _
							"<div class='w3-bar'>" & _
								"<label style='float: left;'><b>Cart Total</b></label>" & _
								"<div style='float: right;'>" & _
									"<b>" & lblCartTotalShow.Text & "</b>" & _									
								"</div>" & _
							"</div>" & _
							"<br>" & _
							"<div class='w3-bar'>" & _
								"<label style='float: left;'><b>Shipping Fee</b></label>" & _
								"<div style='float: right;'>" & _
									"<b>" & lblShippingFeeShow.Text & "</b>" & _									
								"</div>" & _
							"</div>" & _												
							"<br><br>" & _
							"<div class='w3-bar'>" & _
								"<label style='float: left;'><b>Order Total</b></label>" & _
								"<div style='float: right;'>" & _
									"<b>" & lblOrderTotalShow.Text & "</b>" & _									
								"</div>" & _
							"</div>")							
		else			
			MailMsg.Body &= ("<center><h2><b>Yehey! Your order is on its way!</b></h2></center><br/> Hi " + lblFullname.Text + ", <br/><br/>" & _ 
							"Your order no. <b>" + lblOrderNo.Text + "</b> with payment via <b>" + lblPayType.Text + "</b> will attempt to deliver today, <b>" + DateToday + "</b>." & _ 
							"Thank you and have a great day. <br><br>" & _
							"<table style='border-collapse: collapse; width: 100%;'>" & _
								"<tr style='border-top: 1px solid black;'>" & _
									"<th style='text-align: center;'>Item</th>" & _
									"<th style='text-align: right;'>SRP</th>" & _
									"<th style='text-align: center;'>Quantity</th>" & _
									"<th style='text-align: right;'>Total</th>" & _
								"</tr>" & _
								myItemsCart & _					
							"</table>" & _
							"<br>" & _
							"<div class='w3-bar'>" & _
								"<label style='float: left;'><b>Cart Total</b></label>" & _
								"<div style='float: right;'>" & _
									"<b>" & lblCartTotalShow.Text & "</b>" & _									
								"</div>" & _
							"</div>" & _
							"<br>" & _
							"<div class='w3-bar'>" & _
								"<label style='float: left;'><b>Shipping Fee</b></label>" & _
								"<div style='float: right;'>" & _
									"<b>" & lblShippingFeeShow.Text & "</b>" & _									
								"</div>" & _
							"</div>" & _												
							"<br><br>" & _
							"<div class='w3-bar'>" & _
								"<label style='float: left;'><b>Order Total</b></label>" & _
								"<div style='float: right;'>" & _
									"<b>" & lblOrderTotalShow.Text & "</b>" & _									
								"</div>" & _
							"</div>")
		end if

		MailMsg.Priority = MailPriority.High
		MailMsg.IsBodyHtml = True

		Dim SmtpMail As New SmtpClient
		Dim basicAuthenticationInfo
		SmtpMail.Host = "mail.mykey.ph"
		Dim StrA As String = "gmail.com"
		Dim StrB As String = lcase("onlinestore@mykey.ph")
		Dim Stu As Boolean= InStr(StrB, StrA)

		If Stu= True Then       
		Try	

			SmtpMail.Port=587
			SmtpMail.DeliveryMethod = SmtpDeliveryMethod.Network
			SmtpMail.UseDefaultCredentials = False
			SmtpMail.Credentials = new System.Net.NetworkCredential("onlinestore@mykey.ph","Asiapro@dmin2023")
			SmtpMail.EnableSsl = true
			SmtpMail.Send(MailMsg)
			lblEmailStatus.Text ="sent successfully"			

		Catch ex As Exception

			Response.Write (ex.Message)
			Response.Write ("<BR><BR>* Please double check the From Address and Password to confirm that both of them are correct. <br>")
			Response.Write ("<BR><BR>If you are using gmail smtp to send email for the first time, please refer to this KB to setup your gmail account: http://www.smarterasp.net/support/kb/a1546/send-email-from-gmail-with-smtp-authentication-but-got-5_5_1-authentication-required-error.aspx?KBSearchID=137388")
			Response.end

		Finally
		End Try

		Else

			Try
				SmtpMail.Port=25
				SmtpMail.DeliveryMethod = SmtpDeliveryMethod.Network
				SmtpMail.UseDefaultCredentials = False
				SmtpMail.Credentials = new System.Net.NetworkCredential("onlinestore@mykey.ph","Asiapro@dmin2023")
				SmtpMail.EnableSsl = false
				SmtpMail.Send(MailMsg)
				lblEmailStatus.Text ="sent successfully"  
				
			Catch ex As Exception
				Response.Write (ex.Message)
				Response.Write ("<BR><BR>* Please double check the user From Address and Password to confirm that both of them are correct. <br>")
				Response.end
			
			Finally
				End Try	
		End If
	End Sub 
</script> -->
<HTML>
	<HEAD>
		<title>SO Items | Sales </title> 
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
		<script src="js/jquery.draggableTouch.js"></script>		
		<style>						

			input[type="file"] {
				position: absolute;
				z-index: -1;
				top: 10px;
				left: 57px;
				
				color: #949494;
			}

			.select2-results__option {
				font-size: 14px;
			}

			.button-wrap {
				position: relative;
			}

			.button {
				display: inline-block;
				padding: 12px 18px;
				cursor: pointer;
				border-radius: 5px;
				background-color: rgb(16, 199, 16);
				
				font-weight: bold;
				color: #fff;
			}

			/* #mydivheader {				
				cursor: move;
				z-index: 10;								
			} */

			p {
				font-size: 14px !important;
				color: black;
			}

			.btnImg {
				height : 30px;				
			}

			.btnVImg {
				height : 20px;				
			}

			.ComputedAmount {
				position: relative;
   				 top: 3px;
			}
			.myForm {
				margin: auto;
				width: 410px;
				position: absolute;
				z-index: 10;
				background-color: #f1f1f1;
			}

			.header_class {
				display: inline-block;
				width: 180px;					
			}

			.dropdown-container {
				max-width: 100%;
				overflow: hidden;
			}
			.myddl {
				word-wrap: break-word;
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
					<h5 class="w3-left"><b><i class="fas fa-file-invoice"></i>&nbsp;SO Items</b></h5>
				</div>
				<!-- End Header -->				
				<!-- #include file ="html\AlertPanel.html" -->
				<div style="margin: auto;MAX-WIDTH: 600px">					
					<asp:table id="tblShowValidation" runat="server" CssClass="w3-text-red" Visible="False"></asp:table>
				</div>
				<br>
				<!-- Input Form -->				
				<asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 myForm">
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">							
							<H4 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox>
							</H4>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">
							<asp:button id="btnX" CssClass="w3-button w3-large w3-hover-red w3-right" runat="server" Text="x" UseSubmitBehavior="False"></asp:button>
							<div class="w3-container" style="display:none">
								<LABEL><B></B></LABEL>
								<asp:label id="lblID" runat="server" CssClass="w3-tag w3-red"></asp:label>
							</div>
							<div class="w3-container">
								<LABEL><B>Warehouse</B></LABEL><BR>
									<asp:label id="lblSourceWarehouse" runat="server" Visible="False"></asp:label>
									<asp:dropdownlist id="ddlWarehouse" runat="server" CssClass="w3-input w3-tag w3-btn w3-bar-item w3-border w3-pale-blue w3-mobile myddl" AutoPostback="True"></asp:dropdownlist>
									<div style="display:none">
										<LABEL><B>Current SOH</B></LABEL><BR>
										<asp:label id="lblCurrentSOH" runat="server"></asp:label>						
									</div>
							</div>
							<br>
							<div class="w3-container">
								<LABEL><B>Item</B></LABEL><BR>
									<asp:dropdownlist id="ddlRawMats" runat="server" CssClass="w3-tag w3-input w3-text-small w3-pale-blue w3-mobile myddl" AutoPostBack="True" required></asp:dropdownlist>
							</div>
							<br>
							<div class="w3-container">
								<div class="w3-row">
									<div style="display:none">
										<asp:label id="lblSerial" runat="server"></asp:label>
									</div>
									<asp:panel id="panel1" style="Z-INDEX: 0" runat="server" Visible="False">
										<div class="w3-half">
											<h7><b>On Process</b></h7><BR>
												<asp:label id="lblOnProcessSOH" runat="server"></asp:label>																													
										</div>
										<div class="w3-half">										
											<h7><B>Available SOH</B></h7><BR>
												<asp:label id="lblRemainingSOH" runat="server"></asp:label>																										
										</div>
									</asp:panel>
									<asp:panel id="panel2" style="Z-INDEX: 0" runat="server" Visible="False">
										<div class="w3-half">
											<h7><B>On Process</B></h7><BR>
												<asp:label id="lblOnProcessSOH2" runat="server"></asp:label>
										</div>
										<div class="w3-half">											
											<h7><B>Available SOH</B></h7><BR>
												<asp:label id="lblRemainingSOH2" runat="server"></asp:label>
										</div>
									</asp:panel>
								</div>
							</div>
							<br>														
							<div class="w3-container" style="display:none">
								<LABEL><B>Barcode</B></LABEL><BR>
									<asp:textbox id="txtBarcode" runat="server" Placeholder="Scan barcode" CssClass="w3-input"></asp:textbox>																					
							</div>	
							<div class="w3-container">
								<div class="w3-row">
									<div class="w3-quarter w3-margin-right">
										<LABEL><B>Qty</B></LABEL><BR>
										<asp:textbox id="txtQty" runat="server" Placeholder="0.00" CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
									</div>
									<div class="w3-rest">
										<label></label><BR>
										<asp:CheckBox id="cbIsFree" runat="server" Text="Free?" CssClass="ComputedAmount" Autopostback="True"></asp:CheckBox>
									</div>									
								</div>
								<div class="w3-rest">		
									<asp:label id="lblAmount" runat="server" Visible="False"></asp:label>								
									<input type="text" id="lblResult" runat="server" style="border: 0; FONT-SIZE: 20px;" class="w3-text-red w3-light-grey w3-input w3-responsive" Autopostback="True" readonly>
								</div>
							</div>																													
							<div class="w3-container">
								<div class="w3-row">
									<div class="w3-twothird">
										<LABEL><B>SRP</B></LABEL><BR>
										<asp:textbox id="txtSRP" runat="server" Placeholder="0.00" CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
										<div style="display:none">
											<asp:label id="lblSRP" runat="server" CssClass="w3-tag w3-red"></asp:label>
										</div>
									</div>
									<div class="w3-third">
										<LABEL><B>Discount (%)</B></LABEL><BR>
										<asp:textbox id="txtDiscount" runat="server" Placeholder="0.00" CssClass="w3-input w3-border amount" onkeypress="return clickButton(event,'btnSave')" required></asp:textbox>
									</div>									
								</div>
								
							</div>
							<br>																										
							<div class="w3-container">
								<LABEL><B>Note</B></LABEL><BR>
									<asp:textbox id="txtNote2" runat="server" Placeholder="Type here..." CssClass="w3-input" TextMode="MultiLine" Maxlength="1000"></asp:textbox>																					
							</div>	
							<br>
							<div class="w3-container">
								<LABEL><B>Sales Person</B></LABEL><BR>
									<asp:dropdownlist id="ddlSalesPerson" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl"></asp:dropdownlist>
							</div>											
						</DIV>
						<FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER>
					</DIV>
				</asp:panel>
				<asp:panel id="panelOnlineStore" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 myForm w3-container">
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">							
							<H4 class="w3-center">
								<asp:label id="lblModeOnlineStore" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormActionOnlineStore" runat="server" Visible="true"></asp:textbox>
							</H4>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">

							<div class="w3-container" style="display:none">
								<LABEL><B></B></LABEL>
								<asp:label id="lblIDOnlineStoreID" runat="server" CssClass="w3-tag w3-red"></asp:label>
							</div>
							<div class="w3-container">
								<LABEL class="header_class"><B>Order No.:</B></LABEL>
								<asp:label id="lblOrderNo" runat="server" CssClass="w3-medium"></asp:label>																																				
							</div>

							<div class="w3-container">								
								<LABEL class="header_class"><B>Payment Type:</B></LABEL>
								<asp:label id="lblPayType" runat="server" CssClass="w3-medium"></asp:label>
							</div>
							
							<div class="w3-container">								
								<LABEL class="header_class"><B>Ref No.:</B></LABEL>
								<asp:label id="lblRefNo" runat="server" CssClass="w3-medium"></asp:label>
							</div>

							<div class="w3-container">								
								<LABEL class="header_class"><B>Name / Company:</B></LABEL>
								<asp:label id="lblFullname" runat="server" CssClass="w3-medium"></asp:label>
							</div>

							<div class="w3-container">								
								<LABEL class="header_class"><B>House No. / Building / Street / Subdivision:</B></LABEL>
								<asp:label id="lblHouseDetails" runat="server" CssClass="w3-medium"></asp:label>
							</div>

							<div class="w3-container">								
								<LABEL class="header_class"><B>Barangay:</B></LABEL>
								<asp:label id="lblBaranggay" runat="server" CssClass="w3-medium"></asp:label>
							</div>

							<div class="w3-container">								
								<LABEL class="header_class"><B>City:</B></LABEL>
								<asp:label id="lblCity" runat="server" CssClass="w3-medium"></asp:label>
							</div>

							<div class="w3-container">								
								<LABEL class="header_class"><B>Postal Code:</B></LABEL>
								<asp:label id="lblPostalCode" runat="server" CssClass="w3-medium"></asp:label>
							</div>

							<div class="w3-container">								
								<LABEL class="header_class"><B>Email:</B></LABEL>
								<asp:label id="lblOnlineStoreCustomerEmail" runat="server" CssClass="w3-medium"></asp:label>
							</div>

							<div class="w3-container">								
								<LABEL class="header_class"><B>Mobile No.:</B></LABEL>
								<asp:label id="lblMobileNo" runat="server" CssClass="w3-medium"></asp:label>
							</div>

							<div class="w3-container">								
								<LABEL class="header_class"><B>Notes:</B></LABEL>
								<asp:label id="lblOnlineNotes" runat="server" CssClass="w3-medium"></asp:label>
							</div>

							<div class="w3-container">								
								<LABEL class="header_class"><B>Cart Total:</B></LABEL>
								<asp:label id="lblCartTotal" runat="server" CssClass="w3-medium" Visible="False"></asp:label>
								<asp:label id="lblCartTotalShow" runat="server" CssClass="w3-medium"></asp:label>
							</div>

							<div class="w3-container">								
								<LABEL class="header_class"><B>Shipping Fee:</B></LABEL>
								<asp:label id="lblShippingFee" runat="server" CssClass="w3-medium" Visible="False"></asp:label>
								<asp:label id="lblShippingFeeShow" runat="server" CssClass="w3-medium"></asp:label>
							</div>

							<div class="w3-container">								
								<LABEL class="header_class"><B>Order Total:</B></LABEL>
								<asp:label id="lblOrderTotal" runat="server" CssClass="w3-medium" Visible="False"></asp:label>
								<asp:label id="lblOrderTotalShow" runat="server" CssClass="w3-medium"></asp:label>
							</div>
																		
						</DIV>
						<FOOTER class="w3-container" style="display:none"> 
							<DIV class="w3-border-top">
								<P>
									<asp:button id="btnSaveOnlineStore" tabIndex="30" CssClass="w3-btn w3-green w3-block w3-large" runat="server" Text="Save"></asp:button>								
									<SPAN>
										<asp:validationsummary id="ValidationSummaryOnlineStore" runat="server" Width="492px" Visible="False" Height="24px" ShowMessageBox="True" ForeColor="Red"></asp:validationsummary>
										<h2><asp:label id="lblMessageOnlineStore" runat="server" ForeColor="Red"></asp:label></h2>
									</SPAN>       
								</P>    
							</DIV>
						</FOOTER>
					</DIV>
				</asp:panel>
				<asp:panel id="panelLoan" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 myForm">
						<HEADER class="w3-light-grey w3-display-container w3-responsive" style="display:none">							
							<H4 class="w3-center">
								<asp:label id="lblModeLoan" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormActionLoan" runat="server" Visible="true"></asp:textbox>
							</H4>
						</HEADER>
						<DIV class="w3-medium" id="mydivheader">

							<div class="w3-container" style="display:none">
								<LABEL><B></B></LABEL>
								<asp:label id="lblIDLoan" runat="server" CssClass="w3-tag w3-red"></asp:label>
							</div>
							<div class="w3-container">
								<LABEL class="header_class"><B>Total Amount:</B></LABEL>
								<asp:label id="lblNetSalesLoanShow" runat="server" CssClass="w3-large"></asp:label>
								<div style="display:none">
									<asp:label id="lblNetSalesLoan" runat="server"></asp:label>
								</div>																														
							</div>

							<div class="w3-container">								
								<LABEL class="header_class"><B>Down Payment</B></LABEL>
									<asp:textbox id="txtDownpayment" runat="server" Placeholder="0.00" CssClass="w3-input w3-border amount" required></asp:textbox>															
							</div>
							<br>
							<div class="w3-container w3-row">
								<div class="w3-col s6 m6 l6">
									<LABEL class="header_class"><B>Registration</B></LABEL><BR>
										<asp:textbox id="txtRegistration" Placeholder="0.00" CssClass="w3-rest w3-input w3-border amount" runat="server" required></asp:textbox>
								</div>
								<div class="w3-col s6 m6 l6">
									<LABEL class="header_class"><B>Docs Stamp</B></LABEL><BR>
										<asp:textbox id="txtDocsStamp" Placeholder="0.00" CssClass="w3-input w3-border amount" runat="server" required></asp:textbox>
								</div>								
							</div>																				
							<br>
							<div class="w3-container">
								<LABEL class="header_class"><B>Select Loan Terms:</B></LABEL>
								<asp:dropdownlist id="ddlMonthsToPay" runat="server" CssClass="w3-tag w3-pale-blue w3-mobile"></asp:dropdownlist>								
							</div>
							<br>
							<div class="w3-container">
								<LABEL class="header_class"><B>Approvable Loan Amount:</B></LABEL>
								<asp:label id="lblApprovableLoanAmountShow" runat="server" CssClass="w3-large w3-text-red"></asp:label>
								<div style="display:none">
									<asp:label id="lblApprovableLoanAmount" runat="server"></asp:label>
								</div>																
							</div>
							<br>
							<div class="w3-container w3-row">
								<LABEL class="header_class"><B>Monthly Amortization:</B></LABEL>
								<asp:label id="lblMonthlyPaymentShow" runat="server" CssClass="w3-large w3-text-teal"></asp:label>	
								<div style="display:none">
									<asp:label id="lblMonthlyPayment" runat="server"></asp:label>
								</div>														
							</div>
							<br>
							<div class="w3-container w3-row">
								<LABEL class="header_class"><B>First Amortization Date:</B></LABEL><br>
									<ew:calendarpopup id="calStartPayDate" style="Z-INDEX: 0" runat="server" Width="53%"
									Height="30px" ShowGoToToday="True" CalendarLocation="right" AllowArbitraryText="False" DisableTextboxEntry="False"
									ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage">
									<WeekdayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="White"></WeekdayStyle>
									<MonthHeaderStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="#8080FF"></MonthHeaderStyle>
									<OffMonthStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Gray"
										BackColor="AntiqueWhite"></OffMonthStyle>
									<GoToTodayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="White"></GoToTodayStyle>
									<TodayDayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="LightGoldenrodYellow"></TodayDayStyle>
									<DayHeaderStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="MediumSeaGreen"></DayHeaderStyle>
									<WeekendStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="LightGray"></WeekendStyle>
									<SelectedDateStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="Yellow"></SelectedDateStyle>
									<ClearDateStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="White"></ClearDateStyle>
									<HolidayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
										BackColor="White"></HolidayStyle>
								</ew:calendarpopup>															
							</div>		
							<br>
							<div class="w3-container">								
								<label class="header_class"><asp:button id="btnCalculate" CssClass="w3-btn w3-blue w3-small w3-round" runat="server" Text="Calculate"></asp:button></label>
								<asp:LinkButton id="btnPrintAmort" CssClass="w3-btn w3-ripple w3-indigo w3-mobile w3-rest w3-small w3-round"
									runat="server"><i class="fas fa-print"></i>&nbsp;Print</asp:LinkButton>
							</div>
							<br>						
						</DIV>
						<FOOTER class="w3-container"> 
							<DIV class="w3-border-top">
								<P>
									<asp:button id="btnSaveLoan" tabIndex="30" CssClass="w3-btn w3-green w3-block w3-large" runat="server" Text="Save"></asp:button>								
									<SPAN>
										<asp:validationsummary id="ValidationSummaryLoan" runat="server" Width="492px" Visible="False" Height="24px" ShowMessageBox="True" ForeColor="Red"></asp:validationsummary>
										<h2><asp:label id="lblMessageLoan" runat="server" ForeColor="Red"></asp:label></h2>
									</SPAN>       
								</P>    
							</DIV>
						</FOOTER>
					</DIV>
				</asp:panel>
				<!-- End Input Form -->
				<asp:panel id="panelVoid" style="Z-INDEX: 0" runat="server" Visible="False">
					<DIV id="id01" class="w3-card-4 myForm w3-display-center w3-responsive">						
						<HEADER class="w3-center w3-indigo w3-display-container w3-responsive">								
							<H4>
								Void Confirmation
							</H4>
						</HEADER>						
						<FOOTER class="w3-padding w3-center">
							<asp:button id="btnYes" CssClass="w3-btn w3-green w3-hover-blue w3-margin-right" runat="server" Text="Yes"></asp:button>
							<asp:button id="btnNo" CssClass="w3-btn w3-red w3-hover-blue" runat="server" Text="No"></asp:button>
						</FOOTER>
					</DIV>
				</asp:panel>
				<asp:panel id="panelGrid" style="Z-INDEX: 0;" runat="server" Visible="True">
				<!-- Header -->
				<div class="w3-row">
					<div class="w3-third">
						<div class="w3-container w3-blue">
							<div style="display:none">								
								<asp:hyperlink id="hlViewFullHistory" class="s6 w3-tag w3-khaki w3-margin-top w3-bar-item" runat="server"
									Target="_blank" ToolTip="View transaction history. ">Audit Trail</asp:hyperlink>								
								<asp:button id="btnBackToList" CssClass="Style: Class= w3-btn w3-ripple w3-khaki w3-bar-item w3-margin-top w3-mobile w3-right"
									runat="server" Text="Back to list"></asp:button>
							</div>
							<p>
								<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="btnImg w3-hover-opacity w3-bar-item w3-left" />
								<asp:ImageButton id="btnSaveImg" runat="server" ImageUrl="images/save_image.png" Tooltip="Save" CssClass="btnImg w3-hover-opacity w3-bar-item w3-right" />
								<asp:ImageButton id="btnVoidImg" runat="server" ImageUrl="images/void_button.png" Tooltip="Void" CssClass="btnVImg w3-hover-opacity w3-bar-item w3-right w3-margin-right" />
							</p>
							<p style="display:none">
								Warehouse:&nbsp;
								<asp:label id="lblWarehouse" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>								
								<asp:label id="lblISSID" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>								
								<asp:label id="lblEmailStatus" runat="server" CssClass="w3-medium"></asp:label>
								<asp:label id="lblFirstname" runat="server" CssClass="w3-medium"></asp:label>
								<asp:label id="lblLastname" runat="server" CssClass="w3-medium"></asp:label>
								DR #:&nbsp;
								<asp:label id="lblDRCode" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</p>	
							<br>																												
								<hr class="w3-bottombar w3-border-khaki">	
							<div class="w3-medium w3-text-black">
								Status:&nbsp;
								<asp:label id="lblStatus" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
							</div>	
							<br>
							<div class="w3-row w3-medium w3-text-black">
								<div class="w3-half">
									SO #:&nbsp;
									<asp:label id="lblSONo" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								</div>
								<div class="w3-half">
									SO Date:&nbsp;
									<asp:label id="lblSODate" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True">0</asp:label>
								</div>								
							</div>	
							<br>													
							<div class="w3-row w3-text-black">
								<div class="w3-half">									
									<label class="w3-medium"><b>SI #:&nbsp;</b></label>
									<asp:label id="lblInvoiceNo" class="w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
									<asp:textbox id="txtSINo" runat="server" Width="80%" CssClass="w3-input" Placeholder="type here..." Autopostback="True"></asp:textbox>									
								</div>
								<div class="w3-half">									
									<label class="w3-medium"><b>SI Date:&nbsp;</b></label>
									<asp:label id="lblSIDate" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False">0</asp:label>
									<ew:calendarpopup id="calSIDate" style="Z-INDEX: 0" runat="server" Width="53%"
										Height="30px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
										ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" Autopostback="True">
										<WeekdayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
											BackColor="White"></WeekdayStyle>
										<MonthHeaderStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
											BackColor="#8080FF"></MonthHeaderStyle>
										<OffMonthStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Gray"
											BackColor="AntiqueWhite"></OffMonthStyle>
										<GoToTodayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
											BackColor="White"></GoToTodayStyle>
										<TodayDayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
											BackColor="LightGoldenrodYellow"></TodayDayStyle>
										<DayHeaderStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
											BackColor="MediumSeaGreen"></DayHeaderStyle>
										<WeekendStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
											BackColor="LightGray"></WeekendStyle>
										<SelectedDateStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
											BackColor="Yellow"></SelectedDateStyle>
										<ClearDateStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
											BackColor="White"></ClearDateStyle>
										<HolidayStyle Font-Size="Medium" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
											BackColor="White"></HolidayStyle>
									</ew:calendarpopup>									
								</div>
							</div>	
							<br>																																																										
							<div class="w3-row w3-medium w3-text-black">
								Account Name:&nbsp;								
								<asp:label id="lblClientName" class="w3-rest s6 w3-medium" runat="server" Font-Bold="True" Visible="False"></asp:label>
								<asp:label id="lblClientCode" class="w3-rest s6 w3-small" runat="server" Font-Bold="True" Visible="False"></asp:label>
								<div class="dropdown-container">
									<asp:dropdownlist id="ddlClient" runat="server" CssClass="w3-tag w3-input w3-border w3-pale-blue w3-mobile myddl" AutoPostback="True"></asp:dropdownlist>
								</div>								
							</div>
							<p>
								Terms:&nbsp;
								<asp:textbox id="txtTerms" runat="server" Width="30%" CssClass="w3-input w3-white w3-border" Autopostback="True" required></asp:textbox>
							</p>
							<p>
								<label class="header_class">Vatable Sales:&nbsp;</label>
								<asp:label id="lblVatableSales" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>
							</p>
							<p>
								<label class="header_class">VAT:&nbsp;</label>
								<asp:label id="lblVAT" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>
							</p>								
							<p>
								<label class="header_class">Net Amount:&nbsp;</label>
								<asp:label id="lblNetAmount" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>
							</p>																			
							<div class="w3-row w3-medium w3-text-black">
							
								<div class="w3-half">										
									<label class="w3-text-black w3-medium">Less:&nbsp;</label>
									<asp:textbox id="txtLessAmount" Width="70%" CssClass="w3-input w3-medium w3-white w3-border" Autopostback="True" runat="server"></asp:textbox>																				
								</div>
								<div class="w3-half">			
									<label class="w3-text-black w3-medium">(%)&nbsp;</label>
									<asp:label id="lblDiscount" class="w3-rest s6 w3-large" runat="server" Font-Bold="True" Visible="False"></asp:label>
									<asp:textbox id="txtDiscountHDR" runat="server" CssClass="w3-input w3-blue w3-text-black w3-large w3-border-0" Font-Bold="True" readonly></asp:textbox>
								</div>
							
							</div>							
							<p>								
								<label class="header_class">Net Sales:&nbsp;</label>
								<asp:label id="lblNetSales" class="w3-rest s6 w3-large" runat="server" Font-Bold="True"></asp:label>								
							</p>
							<div class="w3-medium w3-text-black">
								Budget:&nbsp;
								<asp:textbox id="txtBudget" runat="server" CssClass="w3-input" Placeholder="type here..." Autopostback="True"></asp:textbox>
							</div>	
							<div class="w3-medium w3-text-black">
								PO No.:&nbsp;
								<asp:textbox id="txtPONo" runat="server" CssClass="w3-input" Placeholder="type here..." Autopostback="True"></asp:textbox>
							</div>	
							<div class="w3-row w3-medium w3-text-black">
								Project Name:&nbsp;
								<asp:textbox id="txtProjectDesc" runat="server" CssClass="w3-input" Placeholder="type here..." Autopostback="True"></asp:textbox>
							</div>																																									
							<p>
								Note:&nbsp;
								<asp:textbox id="txtNote" runat="server" CssClass="w3-input w3-border w3-white" TextMode="MultiLine" Maxlength="1000" Enabled="False" Autopostback="True"></asp:textbox>
							</p>											
						</div>
						<!-- End Header -->
					</div>
					<div class="w3-rest w3-padding w3-mobile">																														
	
						<div style="display:none">							
							<asp:panel id="panelUpload" style="Z-INDEX: 0;" runat="server" Visible="True">
							
							<div class="container">
								<div class="button-wrap">
									<label class="button" for="FileUploadSO"><i class="fas fa-upload"></i> Select CSV File</label>
									<input id="FileUploadSO" runat="server" accept=".csv" type="file"><br><br>
									<asp:Button onclick="UploadSO" id="btnUploadSO" runat="server" CssClass="w3-btn w3-bar-item w3-green w3-mobile"
									Text="Upload CSV"></asp:Button>	
								</div>
								
							</div>														
						</asp:panel>
													
							<asp:ImageButton id="btnReplicateImg" runat="server" ImageUrl="images/replicatebtn.png" Tooltip="Replicate PO" CssClass="btnImg w3-bar-item w3-hover-opacity w3-margin-left" />

							<asp:ImageButton id="btnPrintSOImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print Sales Order" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" />
							<asp:ImageButton id="btnPrintSIImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print Sales Invoice" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" />
							<asp:ImageButton id="btnPrintImg" runat="server" ImageUrl="images/printbtn.png" Tooltip="Print DR" CssClass="btnImg w3-bar-item w3-hover-opacity w3-right" />							
							<!-- #include file ="html\SearchAndButtons.html" -->																					
						</div>
						<p>
							
							<asp:ImageButton id="btnAddImg" runat="server" ImageUrl="images/additem.png" Tooltip="New Record" CssClass="btnImg w3-bar-item w3-hover-opacity w3-left" UseSubmitBehavior="False"/>
							<asp:LinkButton id="btnInTransit" runat="server" OnClick="btnInTransit_Click" CssClass="w3-btn w3-ripple w3-blue w3-mobile w3-bar-item w3-left w3-margin-left w3-round"><i class="fas fa-truck"></i>&nbsp;FOR DELIVERY</asp:LinkButton>
							<asp:LinkButton id="btnLoan" runat="server" CssClass="w3-btn w3-ripple w3-green w3-mobile w3-bar-item w3-left w3-margin-left w3-round"><i class="fas fa-truck-loading"></i>&nbsp;Loan</asp:LinkButton>
							<asp:LinkButton id="btnOnlineStore" runat="server" CssClass="w3-btn w3-ripple w3-deep-orange w3-mobile w3-bar-item w3-left w3-margin-left w3-round"><i class="fas fa-sort"></i>&nbsp;Online Store</asp:LinkButton>
							<asp:LinkButton id="btnPrintSO" CssClass="w3-btn w3-ripple w3-indigo w3-mobile w3-bar-item w3-right w3-margin-left"
								runat="server"><i class="fas fa-print"></i>&nbsp;Print Sales Order</asp:LinkButton>
							<asp:LinkButton id="btnPrintSI" CssClass="w3-btn w3-ripple w3-indigo w3-mobile w3-bar-item w3-right w3-margin-left"
								runat="server"><i class="fas fa-print"></i>&nbsp;Print Sales Invoice</asp:LinkButton>	
							<asp:LinkButton id="btnPrint" CssClass="w3-btn w3-ripple w3-indigo w3-mobile w3-bar-item w3-right w3-margin-left"
								runat="server"><i class="fas fa-print"></i>&nbsp;Print DR</asp:LinkButton>		
						</p>
						<p style="display:none">
							<asp:label id="lblSelectWarehouse" runat="server"><b>Select Warehouse</b>&nbsp;</asp:label>							
						</p>
						<br><br>
						<p>
							<!-- Sys Group Table -->
							<div class="w3-responsive w3-mobile">
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
            // Function to Disable comma when typing
			$('.amount').keyup(function(event) {

				// skip for arrow keys
				if(event.which >= 37 && event.which <= 40) return;

				// format number
				$(this).val(function(index, value) {
					return value
					.replace(/[,'"]/g, '');					
				});
			});

			$(function() { 
				$("#id01").draggable({
					handle: "label, input"
				}); 
			});
		
			$('#txtSRP, #txtQty, #txtDiscount').keyup(function(){
				// skip for arrow keys
				if(event.which >= 37 && event.which <= 40) return;

				var srp = parseFloat($("#txtSRP").val());
				var qty = parseFloat($("#txtQty").val());
				var discount = parseFloat($("#txtDiscount").val());				
				var res = srp * qty - ((srp * qty) * discount / 100 );
				
				$("#lblResult").val(res.toFixed(2).toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,"));				
								
			});			
				
			// Function to auto-format the date when typing
			$('#calSIDate','#calStartPayDate').keyup(function (e) {
				if (e.keyCode != 193 && e.keyCode != 111) {
					console.log(e.keyCode);
					if (e.keyCode != 8) {
						if ($(this).val().length == 2) {
							$(this).val($(this).val() + "/");
						} else if ($(this).val().length == 5) {
							$(this).val($(this).val() + "/");
						}
					} else {
						var temp = $(this).val();
						if ($(this).val().length == 5) {
							$(this).val(temp.substring(0, 4));
						} else if ($(this).val().length == 2) {
							$(this).val(temp.substring(0, 1));
						}
					}
				} else {
					var temp = $(this).val();
					var tam = $(this).val().length;
					$(this).val(temp.substring(0, tam-1));
				}
			});

			$('.myddl').select2({
				dropdownCssClass: 'w3-pale-blue',
				selectionCssClass: 'w3-pale-blue'								
			});

			$('input').click(function() {
				$(this).select(); 
			});

			$(document).on('select2:open', () => {
				document.querySelector('.select2-search__field').focus();
			});	
			
			// prevent users from Typing letters | Numbers only
			$(document).ready(function() {
				// Get the Total Amount
				var total_amount = parseInt($('#lblNetSalesLoan').text());

				// Set the maximum value for the input field
				$('#txtDownpayment').attr('max', total_amount);

				$('#txtDownpayment','#txtRegistration','#txtDocsStamp').attr('inputmode', 'numeric').on('keydown input', function(e) {
					var currentValue = $(this).val();
					if ((e.which < 48 || e.which > 57) && e.which != 8 && e.which != 46 && e.which != 37 && e.which != 39 && e.which != 13) {
					e.preventDefault();
					} 
					
					if (parseInt(currentValue) > total_amount) {
						$(this).val(total_amount);
					}

					if (parseInt(currentValue) === 0) {
						$(this).val(1);
					}
					
				});
			});
		</script>
		
	</body>
</HTML>
