
<%@ Page CodeBehind="checkout.aspx.vb" Language="vb" AutoEventWireup="false" Inherits="srx.checkout" %>
<%@ Import Namespace="System.Net" %> 
<%@ Import Namespace="System.Net.Mail" %>
<%@ Import Namespace="System.Configuration" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="System.Text" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Web" %>
<!DOCTYPE html>
<script runat="server"> 
	private Sub btnPlaceOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)				

		Save_Shipping()
		
		Dim objConnection As New SqlConnection(ConfigurationManager.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Web_ItemsCart_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

		objCommand.Parameters.Add("@FormAction", Request("FormAction"))
		objCommand.Parameters.Add("@id", Request("id"))
		objCommand.Parameters.Add("@Qty", Request("Qty"))
		objCommand.Parameters.Add("@user_id", Session("NoLoginClient_Cookie"))

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
        Dim strTo as String = txtEmail.Text
        Dim strTo2 as String = "genermagbanua45@gmail.com"
		Dim DateToday = DateTime.UTCNow.AddHours(8).ToString("MMMM d, yyyy hh:mmtt")

		Dim MailMsg As New MailMessage()
		MailMsg.BodyEncoding = Encoding.Default
		MailMsg.To.Add(strTo)
		MailMsg.Bcc.Add(strTo2)        
		MailMsg.From = strFrom
        MailMsg.Subject = "Order No. " + lblOrderNo.Text + " Is Being Processed"
		
		if ddlEntity.SelectedValue = "1" Then
			MailMsg.Body &= ("<center><h2><b>Thank you for shopping with us!</b></h2></center><br/> Hi " + txtFirstname.Text + " " + txtLastname.Text + ", <br/><br/>" & _ 
							"We received your order no. <b>" + lblOrderNo.Text + "</b> on <b>" + DateToday + "</b> and your payment option is via <b>" + ddlPaymentOption.SelectedValue + "</b>." & _ 
							"You will be notified on its delivery status. <br><br>" & _
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
			MailMsg.Body &= ("<center><h2><b>Thank you for shopping with us!</b></h2></center><br/> Hi " + txtFullname.Text + ", <br/><br/>" & _ 
							"We received your order no. <b>" + lblOrderNo.Text + "</b> on <b>" + DateToday + "</b> and your payment option is via <b>" + ddlPaymentOption.SelectedValue + "</b>." & _ 
							"You will be notified on its delivery status. <br><br>" & _
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
			lblStatus.Text ="sent successfully"			
	
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
				lblStatus.Text ="sent successfully"  
				
			Catch ex As Exception
				Response.Write (ex.Message)
				Response.Write ("<BR><BR>* Please double check the user From Address and Password to confirm that both of them are correct. <br>")
				Response.end
			
			Finally
				End Try	
        End If			

		Save_Shipping2()		
		Response.Redirect("ty_order?&order_no=" & lblOrderNo.Text)

    End Sub 

	Private Sub Save_Shipping()
        Dim objConnection As New SqlConnection(ConfigurationManager.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Web_ItemsShipping_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "Add")
        objCommand.Parameters.Add("@order_no", lblOrderNo.Text)
        objCommand.Parameters.Add("@pay_type", ddlPaymentOption.SelectedValue)
		objCommand.Parameters.Add("@ref_no", txtRefNo.text)
        objCommand.Parameters.Add("@user_id", Session("NoLoginClient_Cookie"))
        objCommand.Parameters.Add("@is_company", ddlEntity.SelectedValue)
        objCommand.Parameters.Add("@fullname", txtFullname.Text)
        objCommand.Parameters.Add("@firstname", txtFirstname.Text)
        objCommand.Parameters.Add("@lastname", txtLastname.Text)
        objCommand.Parameters.Add("@home_details", txtHomeDetails.Text)
        objCommand.Parameters.Add("@barangay", txtBarangay.Text)
        objCommand.Parameters.Add("@city", ddlCity.SelectedValue)
        objCommand.Parameters.Add("@zip_code", txtPostalCode.Text)
        objCommand.Parameters.Add("@email", txtEmail.Text)
        objCommand.Parameters.Add("@mobile_no", txtMobileNo.Text)
        objCommand.Parameters.Add("@notes", txtNotes.Text)
        objCommand.Parameters.Add("@cart_total", lblCartTotal.Text)
        objCommand.Parameters.Add("@shipping_fee", lblShippingFee.Text)
        objCommand.Parameters.Add("@grand_total", lblOrderTotal.Text)

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

        Catch ex As Exception
            'in case of error

        Finally

            objConnection.Close()
        End Try
    End Sub

	Private Sub Save_Shipping2()
        Dim objConnection As New SqlConnection(ConfigurationManager.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Web_ItemsShipping2_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "Add")
        objCommand.Parameters.Add("@order_no", lblOrderNo.Text)
        objCommand.Parameters.Add("@pay_type", ddlPaymentOption.SelectedValue)
		objCommand.Parameters.Add("@ref_no", txtRefNo.text)
        objCommand.Parameters.Add("@user_id", Session("NoLoginClient_Cookie"))
        objCommand.Parameters.Add("@is_company", ddlEntity.SelectedValue)
        objCommand.Parameters.Add("@fullname", txtFullname.Text)
        objCommand.Parameters.Add("@firstname", txtFirstname.Text)
        objCommand.Parameters.Add("@lastname", txtLastname.Text)
        objCommand.Parameters.Add("@home_details", txtHomeDetails.Text)
        objCommand.Parameters.Add("@barangay", txtBarangay.Text)
        objCommand.Parameters.Add("@city", ddlCity.SelectedValue)
        objCommand.Parameters.Add("@zip_code", txtPostalCode.Text)
        objCommand.Parameters.Add("@email", txtEmail.Text)
        objCommand.Parameters.Add("@mobile_no", txtMobileNo.Text)
        objCommand.Parameters.Add("@notes", txtNotes.Text)
        objCommand.Parameters.Add("@cart_total", lblCartTotal.Text)
        objCommand.Parameters.Add("@shipping_fee", lblShippingFee.Text)
        objCommand.Parameters.Add("@grand_total", lblOrderTotal.Text)

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

        Catch ex As Exception
            'in case of error

        Finally

            objConnection.Close()
        End Try
		
    End Sub
</script> 
<html>
<head>
<title>EMS Shop</title>
<!-- #include file ="html\ShopMeta.html" -->
<link href="css/select2.min.css" rel="stylesheet" />
<script src="js/select2.min.js"></script>

<style>	
	.header_class {
		display: inline-block;
		width: 210px;					
	}
</style>
</head>
<body>
	<!-- #include file ="html\ShopTopMenu.html" -->	
	
	<!--breadcrumbs-->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="sys_home"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Check Out</li>
			</ol>
		</div>
	</div>
	<!--//breadcrumbs-->
	<!--shipping_info-->	
	<div class="cart-items">
		<div class="w3-container w3-row">
			<div class="w3-half">
				<h3 class="wow fadeInUp animated" data-wow-delay=".5s">My Shipping Address</h3>
					<div class="w3-padding">
						<label>Order No.:</label>&nbsp;<asp:label id="lblOrderNo" runat="server">#</asp:label>
					</div>
					<div class="w3-padding">
						<label>Payment Option:</label>
						<asp:dropdownlist Cssclass="ddlPaymentOption w3-input w3-mobile" id="ddlPaymentOption" runat="server" Autopostback="True">	
							<asp:ListItem value="" disabled selected>Select</asp:ListItem>						
							<asp:ListItem value="COD">CASH ON DELIVERY (COD)</asp:ListItem>
							<asp:ListItem value="GCASH">GCASH</asp:ListItem>
							<asp:ListItem value="BANK">BANK</asp:ListItem>
						</asp:dropdownlist>
					</div>
					
					<asp:panel id="panelRefNo" CssClass="w3-padding ref_no" runat="server" Visible="False">
													
						<label>Ref No.</label>						
						<asp:textbox id="txtRefNo" runat="server" CssClass="w3-input w3-border"></asp:textbox>
						
						<br>
						<asp:panel id="panelGCASH" runat="server" CssClass="gcash_qrcode w3-center" Visible="False">
							<img src="images/gcash_qrcode.jpg" alt="" style="max-width:200px;height:200px;border:0;">
						</asp:panel>
						<asp:panel id="panelBank" runat="server" CssClass="bank_details" Visible="False">
							
							<label class="header_class">Bank:</label>&nbsp; BDO							
							<br>
							<label class="header_class">Account Name:</label>&nbsp; ABC Corp.
							<br>
							<label class="header_class">Account No.:</label>&nbsp; 123456789
						
						</asp:panel>
						
					</asp:panel>

					<div class="w3-padding">
						<label>Company or Individual?</label>
						<asp:dropdownlist Cssclass="w3-input w3-mobile ddlEntity" id="ddlEntity" runat="server" Autopostback="True">	
							<asp:ListItem value="" disabled selected>Select</asp:ListItem>						
							<asp:ListItem value="1">Individual</asp:ListItem>
							<asp:ListItem value="2">Company</asp:ListItem>						
						</asp:dropdownlist>
					</div>	
					<asp:panel id="panelCompany" CssClass="w3-padding company" runat="server" Visible="False">	
						<label>Company</label>						
						<asp:textbox id="txtFullname" runat="server" CssClass="w3-input w3-border"></asp:textbox>
					</asp:panel>			

					<asp:panel id="panelIndividual" CssClass="individual" runat="server" Visible="False">
						<div class="w3-padding w3-half">
							<label>First Name</label>
							<asp:textbox id="txtFirstname" runat="server" CssClass="w3-input w3-border"></asp:textbox>
						</div>
						<div class="w3-padding w3-half">
							<label>Last Name</label>
							<asp:textbox id="txtLastname" runat="server" CssClass="w3-input w3-border"></asp:textbox>
						</div>						
					</asp:panel>		
					
					<br>
					<div class="w3-padding">
						<label>House No. / Building / Street / Subdivision</label>
						<asp:textbox id="txtHomeDetails" runat="server" CssClass="w3-input w3-border" TextMode="MultiLine" Maxlength="250" required></asp:textbox>
					</div>				
					<div class="w3-padding w3-third">
						<label>Barangay</label>
						<asp:textbox id="txtBarangay" runat="server" CssClass="w3-input w3-border" required></asp:textbox>
					</div>
					<div class="w3-padding w3-third">
						<label>City</label>
						<asp:dropdownlist id="ddlCity" runat="server" CssClass="w3-input w3-border w3-mobile myddl" AutoPostback="True" required></asp:dropdownlist>
					</div>
					<div class="w3-padding w3-third">
						<label>Postal Code</label>
						<asp:textbox id="txtPostalCode" runat="server" CssClass="w3-input w3-border"></asp:textbox>
					</div>
					<br>
					<div class="w3-padding w3-half">
						<label>Email</label>
						<asp:textbox id="txtEmail" runat="server" CssClass="w3-input w3-border" pattern="[^@]+@[^@]+\.[a-zA-Z]{2,6}" required></asp:textbox>
					</div>
					<div class="w3-padding w3-half">
						<label>Mobile No.</label>
						<asp:textbox id="txtMobileNo" runat="server" CssClass="w3-input w3-border" Placeholder="09xx xxx xxxx" required></asp:textbox>
					</div>
					<br>
					<div class="w3-padding">
						<label>Notes</label>
						<asp:textbox id="txtNotes" runat="server" CssClass="w3-input w3-border" TextMode="MultiLine" Maxlength="1000"></asp:textbox>
					</div>
				
			</div>
			<div class="w3-half">
				<h3 class="wow fadeInUp animated" data-wow-delay=".5s">My Orders</h3>
				<div class="w3-container w3-row">
					<table class="w3-table w3-bordered">
						<tr>
							<th>Item</th>
							<th>SRP</th>
							<th>Quantity</th>
							<th>Total</th>
						</tr>
						<span id="Div1" runat="server"></span>					
					</table>	
					<br>
					<div class="w3-bar">
						<label class="w3-left"><b>Cart Total</b></label>
						<div class="w3-right">
							<b>&#8369;<asp:label id="lblCartTotalShow" runat="server">100,000.00</asp:label></b>
							<b><asp:label id="lblCartTotal" runat="server" Visible="False">100,000.00</asp:label></b>
						</div>							
					</div>
					<hr>
					<div class="w3-bar">
						<label class="w3-left"><b>Shipping Fee</b></label>
						<div class="w3-right">
							<b>&#8369;<asp:label id="lblShippingFeeShow" runat="server" CssClass="w3-right">0.00</asp:label></b>
							<b><asp:label id="lblShippingFee" runat="server" Visible="False">0.00</asp:label></b>
						</div>						
					</div>												
					<hr>
					<div class="w3-bar">
						<label class="w3-left"><h3><b>Order Total</b></h3></label>
						<div class="w3-right">
							<h3>&#8369;<asp:label id="lblOrderTotalShow" runat="server" CssClass="w3-right">100,100.00</asp:label></h3>
							<b><asp:label id="lblOrderTotal" runat="server" Visible="False">100,000.00</asp:label></b>
						</div>						
					</div>					
					<hr>
					<asp:button id="btnPlaceOrder" OnClick="btnPlaceOrder_Click" OnClientClick="return confirm('Are you sure you want to place the order?');" runat="server" CssClass="w3-btn w3-border-0 w3-large w3-blue w3-left btnPlaceOrder" Text="Place Order"></asp:button>
					<asp:Label ID="lblStatus" runat="server" forecolor=Green Font-Size="15" Bold = true> 
        </asp:Label>
				</div>
			</div>

		</div>
	</div>
	<!--//shipping_info-->	
	<br/>
	<!-- #include file ="html\ShopFooterMenu.html" -->

	<!--search jQuery-->
	<script src="js/main.js"></script>
	<!--//search jQuery-->
	<!--smooth-scrolling-of-move-up-->
	<script type="text/javascript">
		$(document).ready(function() {
		
			var defaults = {
				containerID: 'toTop', // fading element id
				containerHoverID: 'toTopHover', // fading element hover id
				scrollSpeed: 1200,
				easingType: 'linear' 
			};
			
			$().UItoTop({ easingType: 'easeOutQuart' });
			
		});
	</script>
	<!--//smooth-scrolling-of-move-up-->
	<!--Bootstrap core JavaScript
    ================================================== -->
    <!--Placed at the end of the document so the pages load faster -->
	
    <script src="js/bootstrap.js"></script>
	<script src="https://smtpjs.com/v3/smtp.js"></script>
	<script>		

		const submitInputs = document.querySelectorAll('.btnDelete');
		const numButtons = submitInputs.length; // Count the number of <input type="submit"> elements on the page

		const txtQtyInputs = []; // array to hold references to the input fields

		for (let i = 1; i <= numButtons; i++) {
			const btnDelete = document.getElementById(`btnDelete${i}`);
			const btnUpdate = document.getElementById(`btnUpdate${i}`);
			const txtQty = document.getElementById(`txtQty${i}`);
			const lblSOH = document.getElementById(`lblSOH${i}`);

			// Get the total number of soh
			const soh = parseInt(lblSOH.textContent);

			// Set the maximum value for the input field
			txtQty.setAttribute('max', soh);
			
			const hey = txtQtyInputs.push(txtQty);

			if (btnDelete) {
				btnDelete.addEventListener("click", function(e) {					
					
					// set the URL to redirect to
					const url = "http://127.0.0.1/ems_shop/checkout?&id=" + btnDelete.getAttribute("name") + "&FormAction=Delete";

					const confirmed = confirm("Are you sure you want to delete this item?");

					if (confirmed) {				
						// redirect the user to the URL
						window.location.href = url;
					} else {
						// do nothing
						e.preventDefault();
					}
				});
			}

			if (btnUpdate) {
				btnUpdate.addEventListener("click", function(e) {
					// Get the value of txtQty
					const txtQtyValue = parseInt(txtQty.value);
					
					// set the URL to redirect to
					const url = "http://127.0.0.1/ems_shop/checkout?&id=" + btnDelete.getAttribute("name") + "&FormAction=Update&Qty=" + txtQtyValue;

					const confirmed = confirm("Are you sure you want to update this item?");

					if (confirmed) {				
						// redirect the user to the URL
						window.location.href = url;
					} else {
						// do nothing
						e.preventDefault();
					}
				});
			}
		}

		txtQtyInputs.forEach(function(inputField) {
			inputField.setAttribute('inputmode', 'numeric');
			inputField.addEventListener('input', function(e) {

				const currentValue = inputField.value;
				const key = e.key; // get the key pressed by the user
				const soh = parseInt(inputField.getAttribute('max'));

				if ((isNaN(key) || key == " ") && key != "Backspace" && key != "Delete" && key != "ArrowLeft" && key != "ArrowRight" && key != "Enter") {
					e.preventDefault();
				}

				if (inputField.value > soh) {
					inputField.value = soh;
				}

				if (inputField.value < 1 || isNaN(inputField.value)) {
					inputField.value = 1;
				}

				// Convert the value to a whole number without decimal places
				inputField.value = Math.floor(parseFloat(inputField.value));
				console.log(inputField.value);
			});
		});

		
	</script>
	
	<script>
		$(document).ready(function(){
					
			$('.ddlPaymentOption').change(function() {			
				const paymentOption = $(".ddlPaymentOption").val();
				if(paymentOption === "GCASH") {
					$(".ref_no").show();					
					$(".gcash_qrcode").show();	
					$(".bank_details").hide();																
									
				} else if (paymentOption === "BANK") {
					$(".ref_no").show();
					$(".bank_details").show();
					$(".gcash_qrcode").hide();
	
				} else {					
					$(".ref_no").hide();	
					$(".gcash_qrcode").hide();
					$(".bank_details").hide();	
			
				}					
			});


			$('.ddlEntity').change(function() {			
				if($(".ddlEntity").val() == "2") {
					$(".company").show();	
					$(".individual").hide();												
				}				
				else {
					$(".individual").show();						
					$(".company").hide();	
				}					
			});				
		});

		$('.myddl').select2({
							
		});

		$('.myddl').click(function() {
				$(this).select(); 
			});

		$(function() {
			const mobileNumberInput = $("#txtMobileNo");

			mobileNumberInput.on("input", function() {
				// Get the current value of the input field
				let value = this.value;
				
				// Remove any non-numeric characters from the value
				value = value.replace(/\D/g, "");

				// Limit the value to 11 characters
				if (value.length > 11) {
					value = value.slice(0, 11);
				}

				// Format the value as "xxxx xxx xxx" if it has 11 digits, otherwise leave it as is
				if (value.length === 11) {
					value = value.replace(/^(\d{4})(\d{3})(\d{4})$/, "$1 $2 $3");
				}

				// Update the input field value with the formatted value
				this.value = value;
			});
		});

		$(function() {
			var form = $("#Form1");
			var searchBox = $("#txtSearch");

			searchBox.keypress(function(event) {
				if (event.keyCode === 13) { // 13 is the "Enter" key code
					event.preventDefault(); // prevent default form submission
					form.submit(); // submit the form programmatically
				}
			});
		});
	</script>
	
</body>
</html>