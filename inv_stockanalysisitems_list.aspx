<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_stockanalysisitems_list.aspx.vb" Inherits="srx.inv_stockanalysisitems_list" %>
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
					<asp:ImageButton id="btnBackImg" runat="server" ImageUrl="images/backarrow.png" Tooltip="Back To Reports" CssClass="backImg w3-hover-opacity" UseSubmitBehavior="False"/>					
					<asp:label id="lblTitle" runat="server" Font-Bold="True" CssClass="w3-bar-item w3-large">Stock Analysis Items</asp:label>
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
								<p>
									<asp:LinkButton id="btnCreateDR" OnClientClick="return confirm('Are you sure you want to proceed?');" CssClass="w3-btn w3-ripple w3-green w3-mobile w3-bar-item" runat="server"><i class="fas fa-file-import"></i>&nbsp;Create DR</asp:LinkButton>									
								</p>								
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
								<th><input class="chkHeader" type="checkbox"></th>
								<th>Sys Code</th>
								<th>Barcode</th>
								<th>Brand</th>
								<th>Item Desc</th>
								<th>SOH</th>
								<th>Safety Level</th>								
								<th>For Delivery</th>
								<th>For Issuance</th>
								<th>Main Whse SOH</th>
								<th>Last DR No.</th>
								<th>Last DR Date</th>
								<th>Last DR Status</th>
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
            
			$(document).ready(function() {
				$('#btnCreateDR').hide();

				// Function to check if any checkbox should be visible based on SOH value
				function updateCheckboxesVisibility() {
					// Loop through rows
					$('.w3-table-all tbody tr').each(function() {
						var forDrValue = parseFloat($(this).find('.for_dr span').text().replace(',', ''));
						var mainSohValue = parseFloat($(this).find('.mainwarehouse_soh span').text().replace(',', ''));
						var checkbox = $(this).find('.w3-check-small');

						if ((forDrValue === 0 && mainSohValue === 0) || (forDrValue > 0 && mainSohValue === 0) || (forDrValue === 0 && mainSohValue > 0)) {
							checkbox.hide();
						} else {
							checkbox.show();
						}
					});

					// Check if any checkbox is visible
					var anyCheckboxVisible = $('.w3-check-small:visible').length > 0;

					// Hide all checkboxes if none are visible
					if (!anyCheckboxVisible) {
						$('.chkHeader').hide();
					}
				}

				// Attach a click event handler to the checkbox in the table header
				$('.chkHeader').click(function() {
					// Check or uncheck all checkboxes in the table
					var isChecked = $(this).prop('checked');
					$('.w3-check-small').prop('checked', isChecked);
					updateTxtSelected();
					updateBtnCreateDR(); // Call the function to update #btnCreateDR visibility
				});

				// Attach a click event handler to all checkboxes with class 'w3-check-small'
				$('.w3-check-small').click(function() {
					updateTxtSelected();
					updateCheckAllCheckbox();
					updateBtnCreateDR(); // Call the function to update #btnCreateDR visibility
				});

				// Function to update the #txtSelected input
				function updateTxtSelected() {
					var selectedValues = [];

					// Loop through all checkboxes with class 'w3-check-small'
					$('.w3-check-small:visible').each(function() {
						// Check if the checkbox is checked
						if ($(this).prop('checked')) {
							// Find the closest 'tr' element and get the text of the span with class 'item_code'
							var itemCode = $(this).closest('tr').find('.item_code span').text();
							// Push the itemCode to the selectedValues array
							selectedValues.push(itemCode);
						}
					});

					// Update the #txtSelected input with the selected values separated by a comma
					$('#txtSelected').val(selectedValues.join(','));
				}

				// Function to update the "Select All" checkbox in the table header
				function updateCheckAllCheckbox() {
					var totalCheckboxes = $('.w3-check-small').length;
					var checkedCheckboxes = $('.w3-check-small:checked').length;

					// Check or uncheck the header checkbox based on the count of checked checkboxes
					$('.chkHeader').prop('checked', checkedCheckboxes === totalCheckboxes);
				}

				// Attach a click event handler to the "Select All" checkbox in the table header
				$('.chkHeader').click(function() {
					// Check or uncheck all checkboxes in the table based on the header checkbox state
					var isChecked = $(this).prop('checked');
					$('.w3-check-small').prop('checked', isChecked);
					updateTxtSelected();
					updateBtnCreateDR(); // Call the function to update #btnCreateDR visibility
				});

				// Initial check for the "Select All" checkbox
				updateCheckAllCheckbox();

				// Function to update the visibility of #btnCreateDR
				function updateBtnCreateDR() {
					// Check if any checkbox is checked
					var anyCheckboxChecked = $('.w3-check-small:checked').length > 0;

					// Show or hide the #btnCreateDR button based on the result
					$('#btnCreateDR').toggle(anyCheckboxChecked);
				}

				// Call the function to update checkboxes visibility initially
				updateCheckboxesVisibility();
			});

			$(document).ready(function() {
				// Check if #panelDRMessage is visible
				var panelDRMessageVisible = $("#panelDRMessage").is(":visible");

				// Function to handle the beforeunload event
				function handleBeforeUnload(e) {
					if (panelDRMessageVisible) {
					// Display a confirmation message to the user
					var confirmationMessage = "You have already created stock issuances. Are you sure you want to reload this page?";
					e.returnValue = confirmationMessage; // For most browsers
					return confirmationMessage; // For older browsers
					}
				}

				// Attach the beforeunload event handler
				window.onbeforeunload = handleBeforeUnload;

				// Detect Ctrl+R or Ctrl+Shift+R key presses
				$(document).keydown(function(e) {
					if ((e.ctrlKey || e.metaKey) && (e.key === "r" || e.key === "R")) {
					if (panelDRMessageVisible) {
						// Prevent reloading the page
						e.preventDefault();
					}
					}
				});

				// Wait for a moment (you can adjust the delay as needed)
				setTimeout(function() {
					// Trigger a click on the <a> tag inside the <span>
					// Find the <a> tag inside the <span>
						var $aTag = $("#span1 a");

					// Remove the target="_blank" attribute
					$aTag.removeAttr("target");

					// Trigger a click on the <a> tag
					$aTag[0].click();
				}, 1000); // 2000 milliseconds (2 seconds) delay in this example
			});

		</script>
	</body>
</HTML>
