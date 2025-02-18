<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ref_clients_dtl.aspx.vb" Inherits="srx.ref_clients_dtl" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE HTML>
<HTML>
   <HEAD>
      <!-- #include file ="html\HTMLTitle.html" -->
      <!-- #include file ="html\MetaAndLinkStylesheet.html" -->		
      <!-- Include Toastr CSS and JS files from CDN -->
      <!-- Toastr -->
      <link rel="stylesheet" type="text/css" href="css/toastr.min.css">
      <style>													
         .backImg {
         height : 30px;				
         }	
         .btnImg {
         height : 50px;	
         float: left;			
         }
         .btnImg span {
         display: inline;
         vertical-align: middle;
         margin: 0 auto;
         }
         .myForm {				
         width: 410px;
         z-index: 10;
         background-color: #f1f1f1; 
         position: absolute;				
         }
         td a {
         color: blue;
         }
         a {
         text-decoration: none;
         }
         .w3-table-all tr th:nth-child(1),
         .w3-table-all tr td:nth-child(1),
         .w3-table-all tr th:nth-child(2),
         .w3-table-all tr td:nth-child(2) {
         display: none;
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
         <div style="MARGIN-TOP: 45px">
            <div>
               <asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To List" CssClass="backImg w3-hover-opacity" UseSubmitBehavior="False"/>
               <b class="w3-medium">
                  &nbsp;
                  <asp:label id="lblClient" runat="server"></asp:label>
               </b>
               <div class="w3-right" style="display:none">
                  <asp:ImageButton id="btnClientAssetImg" runat="server" ImageUrl="images/client_assets.png" Tooltip="Go To Assets" CssClass="btnImg w3-hover-opacity" UseSubmitBehavior="False"/>
                  <asp:textbox id="txtSessionFullname" runat="server" Visible="true"></asp:textbox>
                  <asp:textbox id="txtCustomerCode" runat="server" Visible="true"></asp:textbox>
               </div>
            </div>
         </div>
         <!-- End Header -->				
         <!-- #include file ="html\AlertPanel.html" -->								
         <!-- Input Form -->				
         <asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
            <DIV id="id01" class="w3-card-4" style="margin: auto;MAX-WIDTH: 600px">
               <HEADER class="w3-container w3-light-grey w3-display-container w3-responsive">
                  <asp:button id="btnX" class="w3-button w3-large w3-hover-red w3-display-topright" runat="server" Text="x" Visible="True"></asp:button>
                  <H2 class="w3-center">
                     <asp:label id="lblMode" runat="server" Visible="true"></asp:label>
                     <asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox>
                  </H2>
               </HEADER>
               <DIV class="w3-container w3-section w3-medium">
                  <P style="display:none">
                     <LABEL><B></B></LABEL><BR>
                     <asp:label id="lblID" runat="server" CssClass="w3-tag w3-red" Visible="False"></asp:label>
                  </P>
                  <P>
                     <LABEL><B>Item Desc</B></LABEL><BR>								
                     <asp:dropdownlist id="ddlItem" runat="server" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
                  </P>
                  <P>
                     <LABEL><B>Current SRP</B></LABEL><BR>								
                     <asp:label id="lblStandardSRP" runat="server"></asp:label>
                  </P>
                  <P>
                     <LABEL><B>New SRP</B></LABEL><BR>								
                     <asp:textbox id="txtItemSRP" runat="server" Width="100%" Placeholder="Type here..." required></asp:textbox>
                  </P>
               </DIV>
               <FOOTER class="w3-container">
                  <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" -->
               </FOOTER>
            </DIV>
         </asp:panel>
         <!-- End Input Form -->				
         <asp:panel id="panelGrid" style="Z-INDEX: 0" runat="server" Visible="True">
            <div class="w3-row-padding w3-margin-bottom">
               <div class="w3-quarter">
                  <div class="w3-container w3-blue w3-padding-16 w3-card-4">
                     <div class="w3-left">
                        <h6><b>On Process Orders</b></h6>
                     </div>
                     <div class="w3-clear"></div>
                     <h4>
                        <asp:label id="lblOnProcessOrders" runat="server"></asp:label>
                        &nbsp;
                     </h4>
                  </div>
               </div>
               <div class="w3-quarter">
                  <div class="w3-container w3-blue w3-padding-16 w3-card-4">
                     <div class="w3-left">
                        <h6><b>Total Transactions</b></h6>
                     </div>
                     <div class="w3-clear"></div>
                     <h4>
                        <asp:label id="lblOrderCount" runat="server"></asp:label>
                     </h4>
                  </div>
               </div>
               <div class="w3-quarter">
                  <div class="w3-container w3-blue w3-padding-16 w3-card-4">
                     <div class="w3-left">
                        <h6><b>Last Transaction Date</b></h6>
                     </div>
                     <div class="w3-clear"></div>
                     <h4>
                        <asp:label id="lblLastOrdered" runat="server"></asp:label>
                     </h4>
                  </div>
               </div>
               <div class="w3-quarter">
                  <div class="w3-container w3-blue w3-text-white w3-padding-16 w3-card-4">
                     <div class="w3-left">
                        <h6><b>Balance</b></h6>
                     </div>
                     <div class="w3-clear"></div>
                     <h4>
                        <asp:label id="lblBalance" runat="server"></asp:label>
                     </h4>
                  </div>
               </div>
            </div>
            <div class="w3-row w3-container w3-medium">
               <a href="javascript:void(0)" onclick="openCity(event, 'Info');">
                  <div class="w3-fifth tablink w3-bottombar w3-border-blue w3-pale-blue w3-hover-pale-blue w3-padding w3-border-red">Contact Info</div>
               </a>
               <a href="javascript:void(0)" onclick="openCity(event, 'Address');">
                  <div class="w3-fifth tablink w3-bottombar w3-border-blue w3-pale-blue w3-hover-pale-blue w3-padding">Address</div>
               </a>
               <a href="javascript:void(0)" onclick="openCity(event, 'Order');">
                  <div class="w3-fifth tablink w3-bottombar w3-border-blue w3-pale-blue w3-hover-pale-blue w3-padding">Order History</div>
               </a>
               <a href="javascript:void(0)" onclick="openCity(event, 'Settings');">
                  <div class="w3-fifth tablink w3-bottombar w3-border-blue w3-pale-blue w3-hover-pale-blue w3-padding">Settings</div>
               </a>
               <a href="javascript:void(0)" onclick="openCity(event, 'Pricing');">
                  <div class="w3-fifth tablink w3-bottombar w3-border-blue w3-pale-blue w3-hover-pale-blue w3-padding">Pricing Scheme</div>
               </a>
            </div>
            <div class="w3-container" style="display:none">
               <!-- #include file ="html\SearchAndButtons.html" -->
            </div>
            <div id="Info" class="w3-container city">
               <h6>Account Name</h6>
               <p>
                  <asp:textbox id="txtName" CssClass="w3-input" runat="server" Width="100%" Placeholder="Type here..." Autopostback="True" required></asp:textbox>
               </p>
               <h6>Business Name</h6>
               <p>
                  <asp:textbox id="txtBranch" CssClass="w3-input" runat="server" Width="100%" Placeholder="Type here..." Autopostback="True" ></asp:textbox>
               </p>
               <h6>Email</h6>
               <p>
                  <asp:textbox id="txtEmail" CssClass="w3-input" runat="server" Width="50%" Placeholder="Type here..." pattern="[^@]+@[^@]+\.[a-zA-Z]{2,6}" Autopostback="True"></asp:textbox>
               </p>
               <h6>Tin #</h6>
               <p>
                  <asp:textbox id="txtTin" CssClass="w3-input" runat="server" Width="50%" Placeholder="Type here..." Autopostback="True"></asp:textbox>
               </p>
               <h6>Contact Person</h6>
               <p>
                  <asp:textbox id="txtContact" CssClass="w3-input" runat="server" Width="50%" Placeholder="Type here..." Autopostback="True"></asp:textbox>
               </p>
               <h6>Contact #</h6>
               <p>
                  <asp:textbox id="txtContactNo" CssClass="w3-input" runat="server" Width="50%" Placeholder="Type here..." Autopostback="True"></asp:textbox>
               </p>
            </div>
            <div id="Address" class="w3-container city" style="display:none">
               <h6>Billing Address</h6>
               <p>
                  <asp:textbox id="txtAddress" CssClass="w3-input" runat="server" Width="100%" Placeholder="Type here..." Autopostback="True"></asp:textbox>
               </p>
               <h6>Delivery Address</h6>
               <p>
                  <asp:textbox id="txtDeliveryAddress" CssClass="w3-input" runat="server" Width="100%" Placeholder="Type here..." Autopostback="True"></asp:textbox>
               </p>
               <h6>City</h6>
               <p>
                  <asp:dropdownlist id="ddlCity" runat="server" Width="30%" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
               </p>
            </div>
            <div id="Order" class="w3-container city" style="display:none">
				<br>
               <!-- Sys Group Table -->
               <div class="w3-responsive w3-mobile">                  
					<asp:datagrid id="DataGrid" runat="server" ShowFooter="True" CellPadding="3" Width="100%" Height="24px"
						BackColor="White" BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical"
						BorderStyle="None">
						<FooterStyle ForeColor="White" BackColor="#708090"></FooterStyle>
						<SelectedItemStyle Font-Bold="True" ForeColor="Black" CssClass="w3-pale-blue" BackColor="Green"></SelectedItemStyle>
						<EditItemStyle></EditItemStyle>
						<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
						<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
						<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#708090"></HeaderStyle>
						<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
					</asp:datagrid>                       
               </div>
               <!-- End Sys Group Table -->					
            </div>
            <div id="Settings" class="w3-container city" style="display:none">
               <h6>BU</h6>
               <p>
                  <asp:dropdownlist id="ddlCompany" runat="server" Width="30%" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
               </p>
               <h6>Client Since</h6>
               <p>
                  <ew:calendarpopup tabIndex="15" id="calClientSince" style="Z-INDEX: 0" runat="server" VisibleDate="2015-11-13"
                     CellPadding="2px" ShowGoToToday="True" CalendarLocation="Bottom" AllowArbitraryText="False" DisableTextboxEntry="False"
                     ImageUrl="images/calendar-icon-mac.jpg" ControlDisplay="TextBoxImage" onkeypress="return clickButton(event,'btnSave')" Autopostback="True">
                     <WEEKDAYSTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                        Font-Size="Medium"></WEEKDAYSTYLE>
                     <MONTHHEADERSTYLE BackColor="#8080FF" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                        Font-Size="Medium"></MONTHHEADERSTYLE>
                     <OFFMONTHSTYLE BackColor="AntiqueWhite" ForeColor="Gray" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                        Font-Size="Medium"></OFFMONTHSTYLE>
                     <GOTOTODAYSTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                        Font-Size="Medium"></GOTOTODAYSTYLE>
                     <TODAYDAYSTYLE BackColor="LightGoldenrodYellow" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                        Font-Size="Medium"></TODAYDAYSTYLE>
                     <DAYHEADERSTYLE BackColor="Orange" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                        Font-Size="Medium"></DAYHEADERSTYLE>
                     <WEEKENDSTYLE BackColor="LightGray" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                        Font-Size="Medium"></WEEKENDSTYLE>
                     <SELECTEDDATESTYLE BackColor="Yellow" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                        Font-Size="Medium"></SELECTEDDATESTYLE>
                     <CLEARDATESTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                        Font-Size="Medium"></CLEARDATESTYLE>
                     <HOLIDAYSTYLE BackColor="White" ForeColor="Black" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                        Font-Size="Medium"></HOLIDAYSTYLE>
                  </ew:calendarpopup>
               </p>
               <h6>Status</h6>
               <p>
                  <asp:dropdownlist id="ddlStatus" runat="server" Width="20%" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True">
                     <asp:ListItem Value="ACTIVE" Selected="True">ACTIVE</asp:ListItem>
                     <asp:ListItem Value="INACTIVE">INACTIVE</asp:ListItem>
                     <asp:ListItem Value="CLOSED">CLOSED</asp:ListItem>
                  </asp:dropdownlist>
               </p>
               <h6>Industry</h6>
               <p>
                  <asp:dropdownlist id="ddlIndustry" runat="server" Width="30%" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
               </p>
               <h6>Customer Group</h6>
               <p>
                  <asp:dropdownlist id="ddlCGroup" runat="server" Width="30%" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True"></asp:dropdownlist>
               </p>
               <h6>Terms (How many Days?)</h6>
               <p>
                  <asp:textbox id="txtTerms" runat="server" Width="20%" CssClass="w3-input" Placeholder="Type here..." Autopostback="True"></asp:textbox>
               </p>
               <h6>Discount (%)</h6>
               <p>
                  <asp:textbox id="txtDiscount" runat="server" Width="20%" CssClass="w3-input" Placeholder="Type here..." Autopostback="True"></asp:textbox>
               </p>
               <div>
                  <h6>Pricing</h6>
                  <p>
                     <asp:dropdownlist id="ddlPricing" runat="server" Width="20%" CssClass="w3-tag w3-input w3-pale-blue w3-mobile myddl" Autopostback="True">
                        <asp:ListItem Value="SRP" Selected="True">SRP</asp:ListItem>
                        <asp:ListItem Value="SRP2">SRP2</asp:ListItem>
                        <asp:ListItem Value="SRP3">SRP3</asp:ListItem>
                        <asp:ListItem Value="SRP4">SRP4</asp:ListItem>
                        <asp:ListItem Value="SRP5">SRP5</asp:ListItem>
                     </asp:dropdownlist>
                  </p>
               </div>
            </div>
            <div id="Pricing" class="w3-container city" style="display:none">
               <div class="w3-padding">
                  <div style="display:none;">
                     <asp:textbox id="txtCustomerItemID" runat="server" Visible="True">id</asp:textbox>
                     <asp:textbox id="txtCustomerItemSRPValue" runat="server" Visible="True">0</asp:textbox>
                     <asp:textbox id="txtItemStatusValue" runat="server" Visible="True">status</asp:textbox>
                     <asp:button id="btnSaveSRP" class="btn btn-primary" runat="server" Text="Save" Visible="True"></asp:button>
                  </div>
                  <asp:button id="btnAdd" class="w3-btn w3-green w3-card-4" runat="server" Text="Add" Visible="True"></asp:button>
                  <br><br>	
                  <table class="w3-table-all w3-hoverable w3-card-4 w3-centered">
                     <tr class="w3-blue">
                        <th>Sys ID</th>
                        <th>Sys Code</th>
                        <th>Status</th>
                        <th>Barcode</th>
                        <th>Brand</th>
                        <th>Item Desc</th>
                        <th>UOM</th>
                        <th>Current SRP</th>
                        <th>Disc (%)</th>
                        <th>SRP</th>
                     </tr>
                     <span id="Div1" runat="server"></span>
                  </table>
               </div>
            </div>
      	</div>
      </asp:panel>
   </FORM>
   <script src="js/MyJS.js"></script>
   <script type="text/javascript" src="js/toastr.min.js"></script>
   <script>    
      function openCity(evt, cityName) {
      	var i, x, tablinks;
      	x = document.getElementsByClassName("city");
      	for (i = 0; i < x.length; i++) {
      		x[i].style.display = "none";
      	}
      	tablinks = document.getElementsByClassName("tablink");
      	for (i = 0; i < x.length; i++) {
      		tablinks[i].className = tablinks[i].className.replace(" w3-border-red", "");
      	}
      	document.getElementById(cityName).style.display = "block";
      	evt.currentTarget.firstElementChild.className += " w3-border-red";
      };                    
               // Function to Disable comma when typing
      $('#txtTerms,#txtDiscount,#txtItemSRP,.CustomerItemSRP').on('input', function(event) {
      
      	// Get the current value
      	var currentValue = $(this).val();
      
      	// Remove any non-numeric characters
      	var newValue = currentValue.replace(/[^\d.]/g, '');
      					
      	// Update the input value
      	$(this).val(newValue);
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
      
      $('#txtPaidAmount').keyup(function(){
      	// skip for arrow keys
      	if(event.which >= 37 && event.which <= 40) return;
      
      	var pay = parseFloat($("#txtPaidAmount").val());
      	var total = parseFloat($("#txtNetSales").val());									
      	var res = pay - total;
      	
      	$("#lblPay").val(res.toFixed(2).toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,"));				
      					
      });
      	
      // Function to auto-format the date when typing
      $("#calSIDate").keyup(function (e) {
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
      
      $('select').select2({
      	dropdownCssClass: 'w3-pale-blue',
      	selectionCssClass: 'w3-pale-blue',											
      });		
      
      
      
      $(document).keyup(function (e) {
      	if (e.keyCode == 113) { $("#btnNewRecordImg").click(); } 	//F2		
      	if (e.keyCode == 114) { $("#btnAddImg").click(); } 			//F3
      	if (e.keyCode == 115) { $("#btnCustomerImg").click(); } 	//F4
      	if (e.keyCode == 116) { $("#btnCashImg").click(); } 		//F5
      	if (e.keyCode == 117) { $("#btnReceiptImg").click(); } 		//F6
      	if (e.keyCode == 118) { $("#btnVoidImg").click(); } 		//F7
      }); 							
      
      $(document).ready(function () {
      	// Add an input event handler to the <input type="text">
      	$(".txtCustomerItemSRP input[type='text']").on('input', function () {
      		updateFormValues($(this));
      	});
      
      	// Add a change event handler to the <select>
      	$(".ddlItemStatus").on('change', function () {
      		// Update #txtCustomerItemID and #txtCustomerItemSRPValue with the selected values
      		updateFormValuesForSelect($(this));
      		$("#btnSaveSRP").click();
      	});
      
      	// Add a change event handler to the <input type="text">
      	$(".txtCustomerItemSRP input[type='text']").on('change', function () {
      		// Trigger the form submission when the value changes
      		$("#btnSaveSRP").click();
      	});
      
      	// Add a keyup event handler for "Enter" key press
      	$(".txtCustomerItemSRP input[type='text']").on('keyup', function (event) {
      		if (event.keyCode === 13) { // 13 is the keycode for "Enter"
      			// Prevent the default Enter key behavior (form submission)
      			event.preventDefault();
      
      			// Trigger the click event of #btnSaveSRP
      			$("#btnSaveSRP").click();
      		}
      	});				
      
      	// Event handler for #btnSaveSRP click
      	$("#btnSaveSRP").click(function (e) {
      		// Prevent the default form submission behavior
      		e.preventDefault();
      
      		// Your form data
      		var formData = $("#Form1").serialize(); // Replace "yourFormId" with the actual ID of your form
      
      		// Additional parameters for your stored procedure
      		var additionalData = {
      			FormAction: "Edit",
      			status: $("#txtItemStatusValue").val(),
      			id: $("#txtCustomerItemID").val(),
      			srp: $("#txtCustomerItemSRPValue").val(),
      			Session_fullname: $("#txtSessionFullname").val(), // Replace with the actual ID of your session element
      			Customer_Code: $("#txtCustomerCode").val()
      		};
      
      		// Combine form data and additional parameters
      		var requestData = formData + "&" + $.param(additionalData);
      
      		// AJAX request
      		$.ajax({
      			type: "POST",
      			url: "btnSaveSRP.aspx",
      			data: additionalData,
      			success: function (response) {
      				// Handle the success response
      				console.log("Form submitted successfully");
      
      				// Display a success toast
      				toastr.options.positionClass = "toast-bottom-right";
      				toastr.success('Successfully Saved!');
      
      				// Call the function to load the grid
      				//loadItemDiscount();

                  var tbody = $(".w3-table-all tbody");

                  // Find the row with the standard_srp
                  var standardsrpValue = $(".sys_id:contains('" + additionalData.id + "')").siblings(".standardsrp").text();

                  // Find the row with the matching sys_id
                  var rowToUpdate = tbody.find("tr:not(.w3-blue) .sys_id:contains(" + additionalData.id + ")").closest('tr');

                  // Check if a matching row is found
                  if (rowToUpdate.length > 0) {
                     // Parse numeric values
                     standardsrpValue = parseFloat(standardsrpValue);
                     var srp = parseFloat(additionalData.srp);

                     // Calculate the expression
                     var newDiscount = 0;
                     if (!isNaN(standardsrpValue) && !isNaN(srp) && standardsrpValue !== 0) {
                        newDiscount = ((standardsrpValue - srp) / standardsrpValue) * 100.0;
                        newDiscount = parseFloat(newDiscount.toFixed(2)); // Parse as float and round to 2 decimal places
                     }
                     newDiscount = isNaN(newDiscount) ? 0 : newDiscount;

                     // Update the discount value in the corresponding td with class "discount"
                     rowToUpdate.find(".discount").text(newDiscount.toFixed(2)); // Assuming you want to round to 2 decimal places
                  } else {
                     console.log("No matching row found for sys_id: " + additionalData.id);
                  }
      				
      			},
      			error: function (error) {
      				// Handle the error response
      				console.error("Error submitting form: ", error);
      			}
      		});
      	});
      
      	// Function to load the customer item grid
      	function loadItemDiscount() {
      		// Make an AJAX request to fetch the updated data
      		$.ajax({
      			type: "GET",
      			url: "aLoadCustomerItemGrid.aspx?id=" + $("#txtCustomerItemID").val(),
      			success: function (response) {
      				// Handle the success response
      
      				// Replace the content of the table body
      				var newDiscount = response; // Assuming your AJAX response contains the new discount value
      				var tbody = $(".w3-table-all tbody");
      				var sysIdToUpdate = $("#txtCustomerItemID").val(); // Get the sys_id value to update
      
      				// Find the row with the matching sys_id
      				var rowToUpdate = tbody.find("tr:not(.w3-blue) .sys_id:contains(" + sysIdToUpdate + ")").closest('tr');
      
      				// Update the discount value in the corresponding td with class "discount"
      				rowToUpdate.find(".discount").text(newDiscount);
      
      				console.log("Customer item grid loaded successfully");
      				// You can perform additional actions if needed
      			},
      			error: function (error) {
      				// Handle the error response
      				console.error("Error loading customer item grid: ", error);
      				// You can perform additional actions if needed
      			}
      		});
      	}
      
      	// Function to update form values
      	function updateFormValues(input) {
      		// Get the Sys ID from the first <td> in the same row
      		var sysId = input.closest('tr').find('.sys_id').text();
      
      		// Update #txtSLID and #txtSLValue with the Sys ID and input value
      		$("#txtCustomerItemID").val(sysId);
      		$("#txtCustomerItemSRPValue").val(input.val());
      		$("#txtItemStatusValue").val('status');
      	}
      
      	// Function to update form values for select element
      	function updateFormValuesForSelect(select) {
      		// Get the Sys ID from the first <td> in the same row
      		var sysId = select.closest('tr').find('.sys_id').text();
      
      		// Update #txtCustomerItemID with the Sys ID and selected value from the dropdown
      		$("#txtCustomerItemID").val(sysId);
      		// Update #txtCustomerItemSRPValue with the selected value from the dropdown
      		$("#txtItemStatusValue").val(select.val());
      		$("#txtCustomerItemSRPValue").val(0);
      	}
      });
      
      $(document).ready(function () {
      
      	if (localStorage.getItem("my_scroll_position") != null) {
      		$(window).scrollTop(localStorage.getItem("my_scroll_position"));
      	}
      
      	$(window).on("scroll", function() {
      		localStorage.setItem("my_scroll_position", $(window).scrollTop());
      	});
      
      });		
      
   </script>
   </body>
</HTML>