<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ref_safetylevelitems_list.aspx.vb" Inherits="srx.ref_safetylevelitems_list" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
		<script src="js/jquery.draggableTouch.js"></script>
		<style> 
			#mydivheader { cursor: move; z-index: 10; }
			p { font-size: 14px !important; color: black; }
			.btnImg { height : 30px; }
			
			.myForm {
				position: fixed;
				top: 50%;
				left: 50%;
				transform: translate(-50%, -50%);
				z-index: 10;
				background-color: #f1f1f1;
			}
			
			.backImg {
				height : 30px;				
			}

			.header_class {
				display: inline-block;
				width: 110px;					
			}

			input[type="text"] {
            	text-align: center;
        	}

			.w3-table-all tr th:nth-child(1),
			.w3-table-all tr td:nth-child(1) {
				display: none;
			}
		</style>
	</HEAD>
	<!-- #include file ="html\BodyColor.html" -->
		<!-- #include file ="html\TopContainerMenu.html" -->
		<!-- #include file ="html\SideBarMenu.html" -->
		<FORM id="Form1" style="font: 400 14pt/normal Segoe UI; font: menu;" method="post" runat="server">
			<!-- !PAGE CONTENT! Main Div -->
			<div id="main" class="w3-container w3-main">
				<!-- Header -->
				<div style="margin-top: 55px;">
					<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To Lists" CssClass="backImg w3-hover-opacity"/>					
					<asp:label id="lblTitle" runat="server" Font-Bold="True" CssClass="w3-bar-item w3-large">Safety Level Items</asp:label>										

					<div style="display:none;">
						<asp:textbox id="txtSLID" runat="server" Visible="True">id</asp:textbox>
						<asp:textbox id="txtSLValue" runat="server" Visible="True">value</asp:textbox>												
						<asp:button id="btnSave" class="btn btn-primary" runat="server" Text="Save" Visible="True"></asp:button>
					</div>			
				</div>
				<!-- End Header -->
				<!-- #include file ="html\AlertPanel.html" -->
				<!-- Input Form -->
				<asp:panel id="panelForm" style="z-index: 0;" runat="server" Visible="False">
					
				</asp:panel>
				<!-- End Input Form -->
				<asp:panel id="panelGrid" style="z-index: 0;" runat="server" Visible="True"> <!-- Header -->
					<DIV class="w3-container">
						<div class="w3-row">
							<div class="w3-half">
								<DIV style="display: none;">									
									<asp:label id="lblWhsID" runat="server"></asp:label>								
									<asp:textbox id="txtSelected" runat="server" TextMode="MultiLine" Visible="True"></asp:textbox>
								</DIV>								
								<P>
									<label class="header_class">BU&nbsp;</label>
									<asp:label class="w3-rest s6 w3-medium" id="lblBUName" runat="server" Font-Bold="True">0</asp:label>
									<asp:label class="w3-rest s6 w3-medium" id="lblBUCode" runat="server" Font-Bold="True" Visible="False">0</asp:label>
								</P>
								<P>
									<label class="header_class">Warehouse:&nbsp;</label>
									<asp:label class="w3-rest s6 w3-medium" id="lblWhsName" runat="server" Font-Bold="True"></asp:label>
									<asp:label class="w3-rest s6 w3-medium" id="lblWhsCode" runat="server" Font-Bold="True" Visible="False"></asp:label>
								</P>																
							</div>							
						</div>																			
					</DIV>				
					<asp:panel id="panelDRMessage" runat="server" Visible="False">
						<div class="w3-row-padding w3-mobile">
							<div class="w3-quarter">
								<label>&nbsp;</label>
							</div>
							<div class="w3-half">
								<ul class="w3-ul w3-card-4 w3-pale-green w3-animate-zoom" style="width:100%;">
									<li class="w3-bar">
									  <span onclick="this.parentElement.style.display='none'" class="w3-bar-item w3-button w3-white w3-xlarge w3-right w3-pale-green w3-hover-red">&times;</span>
									  <img src="images/check_icon.png" class="w3-bar-item w3-circle w3-hide-small" style="width:85px">
									  <div class="w3-bar-item">
										<span class="w3-large">Stock Issuance has been successfully created!</span><br>										
										<span id="span1" runat="server"></span>
									  </div>
									</li>    
								  </ul>
							</div>
							<div class="w3-quarter">
								<label>&nbsp;</label>
							</div>						
						</div>
					</asp:panel>						
					<br>
					<div class="w3-row-padding">
						<table class="w3-table-all w3-hoverable w3-card-4 w3-centered">
				
							<tr class="w3-blue">
								<th>Sys ID</th>																
								<th>Sys Code</th>
								<th>Barcode</th>
								<th>Brand</th>
								<th>Item Desc</th>								
								<th>Safety Level</th>
								<th>Critical Level</th>							
							</tr>									
							<span id="Div1" runat="server"></span>
						</table>
					</div>
					
				</asp:panel>
			</div>
			<!-- End !PAGE CONTENT! Main Div -->
			<!-- End Div Main -->
		</FORM>
		<script src="js/MyJS.js"></script>
		<script>                        
            
			// Function to Disable comma when typing
			$('.safetylevel').on('input', function(event) {

				// Get the current value
				var currentValue = $(this).val();

				// Remove any non-numeric characters
				var newValue = currentValue.replace(/[^\d.]/g, '');
								
				// Update the input value
				$(this).val(newValue);
			});

			$(document).ready(function() {
				// Add an input event handler to the <input type="text">
				$(".txtSafetyLevel input[type='text']").on('input', function() {
					// Get the Sys ID from the first <td> in the same row
					var sysId = $(this).closest('tr').find('.sys_id').text();
					
					// Update #txtSLID and #txtSLValue with the Sys ID and input value
					$("#txtSLID").val(sysId);
					$("#txtSLValue").val($(this).val());
				});

				// Add a keyup event handler for "Enter" key press
				$(".txtSafetyLevel input[type='text']").on('keydown', function(event) {
					if (event.keyCode === 13) { // 13 is the keycode for "Enter"
					// Prevent the default Enter key behavior (form submission)
					event.preventDefault();
					// Delay the click event of #btnSave for a short time (e.g., 100 milliseconds)
					setTimeout(function() {
						$("#btnSave").click();
					}, 100);
					}
				});

				// Add a blur event handler to the <input type="text">
				$(".txtSafetyLevel input[type='text']").on('blur', function() {
					// Delay the click event of #btnSave for a short time (e.g., 100 milliseconds)
					setTimeout(function() {
					$("#btnSave").click();
					}, 100);
				});
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
