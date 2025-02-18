<%@ Page Language="vb" AutoEventWireup="false" Codebehind="trx_si_form.aspx.vb" Inherits="ems.trx_si_form" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE html>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!--  Desktop Favicons  -->
		<link rel="icon" type="image/png" href="./images/favicon_96x96.ico" sizes="96x96">
		<link href="css/print_forms.css" rel="stylesheet" />
		<link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
		<script src="https://code.jquery.com/jquery-1.12.4.js"></script>
		<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
		
		<style>
			BODY { FONT-SIZE: 11px; FONT-FAMILY: Verdana }	
			DIV.form_title { POSITION: absolute;PADDING-LEFT: 35em; TOP: 5px }		
			DIV.company_logo { POSITION: absolute;PADDING-LEFT: 6em; TOP: 1px; }
			DIV.printed_on { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 3em; TOP: 1180px; display:none }
			DIV.pr_code { FONT-SIZE: 12px; POSITION: absolute;PADDING-LEFT: 59em; TOP: 92px }
			DIV.pr_date { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 59em; TOP: 72px }
			DIV.invoice_no { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 59em; TOP: 55px }
			DIV.vendor_name { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 16em; TOP: 84px }
			DIV.vendor_code { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 16em; TOP: 110px; display:none }
			DIV.email { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 16em; TOP: 128px; display:none }			
			DIV.vendor_contact { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 16em; TOP: 140px }
			DIV.vendor_contactno { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 16em; TOP: 164px; display:none }
			DIV.vendor_address { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 16em; TOP: 160px }
			DIV.note { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 16em; TOP: 180px }
			DIV.terms { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 16em; TOP: 122px }

			LABEL.vat_sales { FONT-SIZE: 12px; MARGIN-LEFT: 55em; width: 90px; display: inline-block;}
			SPAN.vat_sales {FONT-SIZE: 12px; width: 90px; text-align: right; display: inline-block;}	

			SPAN.vatlabel { FONT-SIZE: 12px; MARGIN-LEFT: 55em; width: 90px; display: inline-block;}
			SPAN.vat {FONT-SIZE: 12px; width: 90px; text-align: right; display: inline-block;}	

			LABEL.net_amount { FONT-SIZE: 12px; MARGIN-LEFT: 55em; width: 90px; display: inline-block;}
			SPAN.net_amount {FONT-SIZE: 12px; FONT-WEIGHT: bold; width: 90px; text-align: right; display: inline-block;}	

			LABEL.discount { FONT-SIZE: 12px; MARGIN-LEFT: 55em; width: 90px; display: inline-block;}
			SPAN.discount {FONT-SIZE: 12px; width: 90px; text-align: right; display: inline-block;}	

			LABEL.net_sales { FONT-SIZE: 12px; MARGIN-LEFT: 55em; width: 90px; display: inline-block;}
			SPAN.net_sales {FONT-SIZE: 12px; FONT-WEIGHT: bold; width: 90px; text-align: right; display: inline-block;}	

			DIV.requested_by { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 16em; TOP: 216px }
			DIV.dept { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 16em; TOP: 237px }
			DIV.contact_no { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 46em; TOP: 216px }			
			
			.created_by { FONT-SIZE: 12px; PADDING-LEFT: 3em; }	
			DIV.createdby_esign { PADDING-LEFT: 3em; display: inline-block; }		
			.approved_by { FONT-SIZE: 12px; PADDING-LEFT: 45em; }
			DIV.approvedby_esign { PADDING-LEFT: 35em; display: inline-block; }
			DIV.button { POSITION: absolute; PADDING-LEFT: 40em; TOP: 0px }	
			.button { CURSOR: pointer; TEXT-DECORATION: none; BORDER-TOP: medium none; BORDER-RIGHT: medium none; BORDER-BOTTOM: medium none; COLOR: white; PADDING-BOTTOM: 10px; TEXT-ALIGN: center; PADDING-TOP: 10px; PADDING-LEFT: 10px; BORDER-LEFT: medium none; MARGIN: 4px 2px; DISPLAY: inline-block; PADDING-RIGHT: 10px; transition-duration: 0.4s }			
			.btnApprove { BORDER-TOP: #4caf50 2px solid; BORDER-RIGHT: #4caf50 2px solid; BORDER-BOTTOM: #4caf50 2px solid; COLOR: white; BORDER-LEFT: #4caf50 2px solid; BACKGROUND-COLOR: #4caf50 }
			.btnApprove:hover {COLOR: white; BACKGROUND-COLOR: #008cba; box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19) }
			#imgCreatedByESignResize { WIDTH: 150px }
			#imgApprovedByESignResize { WIDTH: 150px }
			LABEL.payout_date { MARGIN-LEFT: 10px }
			LABEL.received { MARGIN-LEFT: 200px }
			LABEL.authorize { POSITION: absolute; PADDING-LEFT: 25em; TOP: 720px }
			LABEL.signature { MARGIN-LEFT: 280px }				
			
			.centerHeaderText td { text-align: center; }
			
			.page-header, .page-header-space {
				height: 200px;
			}

			.page-footer, .page-footer-space {
				height: 60px;
			}
				
			.page-header {
				position: fixed;
				top: 0mm;
				width: 100%;

			}

			.page-footer {
				position: fixed;
				bottom: 0;
				width: 100%;

			}

			.page {
				page-break-after: auto;
			}
			
			@page {
				margin: 15mm
			}

			@media print {
				thead {display: table-header-group;} 
				tfoot {display: table-footer-group;}
				
				button {display: none;}
				
				body {margin: 0;}
			}			

			.image_header {
				position: relative;				
			}
			
			#dgList {
				table-layout: auto;
				width: 100%; 				
			}
			
			DIV.datagrid { FONT-SIZE: 11px; WIDTH: 850px;  PADDING-LEFT: 2.5em;  }
		</style>
	</HEAD>
	<body>		
		<form id="Form1" runat="server">
			<div style="display:none">
				<div class="button">
					<font style="FONT-FAMILY: Arial">
						<center>
							<STRONG>
								<asp:button id="btnPost" style="Z-INDEX: 0" runat="server" CausesValidation="False" Text="Post"
									Visible="False" CssClass="button btnApprove"></asp:button>
								<asp:button id="btnApprove" style="Z-INDEX: 0" runat="server" CausesValidation="False" Text="Approve"
									Visible="False" CssClass="button btnApprove"></asp:button>
								<asp:button id="btnCancel" style="Z-INDEX: 0" runat="server" CausesValidation="False" Text="Cancel"
									Visible="False" CssClass="button btnApprove"></asp:button>
								<asp:button id="btnForReplacement" style="Z-INDEX: 0" runat="server" CausesValidation="False"
									Text="For Replacement" Visible="False" CssClass="button btnApprove"></asp:button>
								<asp:button id="btnReturn" style="Z-INDEX: 0" runat="server" CausesValidation="False" Text="Return For Adjustment"
									Visible="False"></asp:button>
								<asp:button id="btnForAcctgCancel" style="Z-INDEX: 0" runat="server" CausesValidation="False"
									Text="For Acctg Cancel" Visible="False"></asp:button>
								<asp:button id="btnARPost" style="Z-INDEX: 0" runat="server" CausesValidation="False" Text="AR Post"
									Visible="False"></asp:button>
								<asp:button id="btnUnpostCancel" style="Z-INDEX: 0" runat="server" CausesValidation="False"
									Text="Unpost Cancel" Visible="False"></asp:button>
							</STRONG>
						</center>
					</font>
				</div>
				<div class="AlertMessage">
					<asp:Label id="lblMessage" Runat="server" Visible="false" Font-Size="x-small" ForeColor="red"
						Font-Bold="True"></asp:Label>
				</div>
				<div class="BackToApprovalList">
					<asp:button id="btnBackToApprovalList" CssClass="w3-btn w3-khaki" runat="server" Text="Back To Approval List" Visible="False"></asp:button>
				</div>
				<div class="CancelledReason">
					<asp:label id="lblCancelledReason" style="Z-INDEX: 0; BACKGROUND-COLOR: yellow" runat="server"
						Visible="False" Font-Size="X-Small" Font-Bold="True" Font-Names="Verdana" ForeColor="Black">Reason:</asp:label>&nbsp;
					<asp:dropdownlist id="ddlCancelledReason" style="Z-INDEX: 0" runat="server" Visible="False"></asp:dropdownlist>
					<br>
					<asp:label id="lblDetailedReason" style="Z-INDEX: 0; BACKGROUND-COLOR: yellow" runat="server"
						Visible="False" Font-Size="X-Small" Font-Bold="True" Font-Names="Verdana" ForeColor="Black">Detailed Explanation:</asp:label>&nbsp;
					<asp:textbox tabIndex="14" id="txtDetailedReason" style="Z-INDEX: 0" runat="server" CssClass="rightjustify"
						Visible="False" TextMode="MultiLine" Placeholder="Explain the reason here..."></asp:textbox>
					<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ErrorMessage="Detailed Explanation is required."
						ControlToValidate="txtDetailedReason">*</asp:requiredfieldvalidator>
				</div>
				<div class="AccountingEntry">
					<asp:label id="lblRPayoutDate" style="Z-INDEX: 0; BACKGROUND-COLOR: yellow" runat="server"
						Visible="False" Font-Size="X-Small" Font-Bold="True" Font-Names="Verdana" ForeColor="Black">Reporting Date:</asp:label>
					&nbsp;
					<ew:calendarpopup id="calReportingDate" style="Z-INDEX: 0" runat="server" ControlDisplay="TextBoxImage"
						ImageUrl="images/calendar-icon-mac.jpg" DisableTextboxEntry="False" AllowArbitraryText="False"
						CalendarLocation="Bottom" ShowGoToToday="True" CellPadding="2px" VisibleDate="2015-11-13" Visible="False"
						Font-Size="XX-Small" Height="24px" Width="112px"></ew:calendarpopup><WEEKDAYSTYLE Font-Size="XX-Small" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
						BackColor="White"></WEEKDAYSTYLE><MONTHHEADERSTYLE Font-Size="XX-Small" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
						BackColor="#8080FF"></MONTHHEADERSTYLE><OFFMONTHSTYLE Font-Size="XX-Small" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Gray"
						BackColor="AntiqueWhite"></OFFMONTHSTYLE><GOTOTODAYSTYLE Font-Size="XX-Small" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
						BackColor="White"></GOTOTODAYSTYLE><TODAYDAYSTYLE Font-Size="XX-Small" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
						BackColor="LightGoldenrodYellow"></TODAYDAYSTYLE><DAYHEADERSTYLE Font-Size="XX-Small" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
						BackColor="Orange"></DAYHEADERSTYLE><WEEKENDSTYLE Font-Size="XX-Small" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
						BackColor="LightGray"></WEEKENDSTYLE><SELECTEDDATESTYLE Font-Size="XX-Small" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
						BackColor="Yellow"></SELECTEDDATESTYLE><CLEARDATESTYLE Font-Size="XX-Small" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
						BackColor="White"></CLEARDATESTYLE><HOLIDAYSTYLE Font-Size="XX-Small" Font-Names="Verdana,Helvetica,Tahoma,Arial" ForeColor="Black"
						BackColor="White"></HOLIDAYSTYLE>
					<br>
					<asp:label id="lblBType" style="Z-INDEX: 0; BACKGROUND-COLOR: yellow" runat="server" Visible="False"
						Font-Size="X-Small" Font-Bold="True" Font-Names="Verdana" ForeColor="Black">Billing Type:</asp:label>&nbsp;
					<asp:dropdownlist id="ddlBType" style="Z-INDEX: 0" runat="server" Visible="False"></asp:dropdownlist>
				</div>
			</div>

			<div class="page-header">
				<div class="image_header">
					<img src="./images/siform.jpg" alt="receivingform" class="img_background" >
					<div class="form_title">				
						<h1>Sales Invoice</h1>
					</div>
					<div style="display:none;">
						<button id="btnPrinting" type="button" onClick="window.print()" style="background: khaki">
							Print
						</button>
					</div>
				</div>
				
				<div class="company_logo">
					<a target="_blank">
						<div id="divCompanyLogo" runat="server"></div>
					</a>
				</div>
				<div class="printed_on">
					Printed On:
					<asp:label id="lblPrintedOn" runat="server"></asp:label>
				</div>
				<div class="invoice_no">
					<asp:label id="lblInvoiceNo" runat="server"></asp:label>
				</div>
				<div class="pr_code">
					<asp:label id="lblPRCode" runat="server"></asp:label>
				</div>						
				<div class="pr_date">
					<asp:label id="lblPRDate" runat="server"></asp:label>
				</div>
				<div class="vendor_name">
					<asp:label id="lblVendorName" runat="server"></asp:label>
				</div>
				<div class="vendor_code">
					<asp:label id="lblVendorCode" runat="server"></asp:label>
				</div>
				<div class="vendor_address">
					<asp:label id="lblVendorAddress" runat="server"></asp:label>
				</div>			
				<div class="email">
					<asp:label id="lblEmail" Runat="server"></asp:label>
				</div>
				<div class="vendor_contact">
					<asp:label id="lblVendorContact" Runat="server"></asp:label>
				</div>
				<div class="vendor_contactno">
					<asp:label id="lblVendorContactNo" Runat="server"></asp:label>				
				</div>
				<div class="note">
					<asp:label id="lblNote" Runat="server"></asp:label>				
				</div>
				<div class="terms">
					<asp:label id="lblTerms" Runat="server"></asp:label>&nbsp;				
				</div>			
				<div class="requested_by">
					<asp:label id="lblRequestedBy" runat="server"></asp:label>
				</div>
				<div class="dept">
					<asp:label id="lblDept" runat="server"></asp:label>
				</div>
				<div class="contact_no">
					<asp:label id="lblContactNo" runat="server"></asp:label>
				</div>			
			</div>
			
			<div class="page-footer">
				<label STYLE="FONT-SIZE: 12px; FONT-WEIGHT: bold; PADDING-LEFT: 2em;">PREPARED BY:</label>
				<label STYLE="FONT-SIZE: 12px; FONT-WEIGHT: bold; PADDING-LEFT: 40em;">APPROVED BY:</label>
				<br><br>	
				<div id="divCreatedByESignDrag" class="createdby_esign" runat="server"></div>
				<div id="divApprovedByESignDrag" class="approvedby_esign" runat="server"></div>
				<br>
				<asp:label id="lblCreatedBy" Cssclass= "created_by" runat="server" Font-Bold="True"></asp:label>
				<asp:label id="lblApprovedBy" Cssclass= "approved_by" runat="server" Font-Bold="True"></asp:label>
			</div>

			<table>
				<thead>
					<tr>
						<td>
							<!--place holder for the fixed-position header-->
							<div class="page-header-space"></div>
						</td>
					</tr>
				</thead>

				<tbody>
					<tr>
					  	<td>
							<div class="page">
								<!--*** CONTENT GOES HERE ***-->
								<div class="datagrid">
									<asp:datagrid id="dgList" runat="server" ItemStyle-Wrap="false" CellPadding="1" BackColor="Transparent" 
										BorderWidth="1px" BorderColor="Black" AllowSorting="True" GridLines="both" BorderStyle="Solid"
										ShowFooter="False">
										<ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
										<HeaderStyle Font-Bold="True" ForeColor="Black" BackColor="White" CssClass="centerHeaderText"></HeaderStyle>
										<FooterStyle Font-Bold="True" ForeColor="Black" HorizontalAlign="Center"></FooterStyle>
										<PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
									</asp:datagrid>			
									<br>
									<div class="vat_sales" style="display:none">
										<label class="vat_sales">Vatable Sales:</label>
										<asp:label id="lblVatableSales" runat="server" CssClass="vat_sales"></asp:label>
									</div>								
									<br>							
									<div class="net_amount">
										<label class="net_amount">Net AMOUNT:</label>
										<asp:label id="lblNetAmount" runat="server" CssClass="net_amount"></asp:label>
									</div>					
									<div class="vat">
										<asp:label id="lblVATLabel" runat="server" CssClass="vatlabel">VAT:</asp:label>										
										<asp:label id="lblVAT" runat="server" CssClass="vat"></asp:label>
									</div>					
									<div class="discount">
										<label class="discount">Discount (%):</label>
										<asp:label id="lblDiscount" runat="server" CssClass="discount"></asp:label>
									</div>
									<div class="net_sales">
										<label class="net_sales">Net Sales:</label>
										<asp:label id="lblNetSales" runat="server" CssClass="net_sales"></asp:label>
									</div>														
								</div>	
							</div>
						</td>
					</tr>
			 	 </tbody>

				<tfoot>
					<tr>
						<td>
							<!--place holder for the fixed-position footer-->
							<div class="page-footer-space"></div>
						</td>
					</tr>
			  	</tfoot>
			</table>			
			
			<div style="display:none">
				<asp:button id="BtnFirst" style="Z-INDEX: 0" accessKey="F" runat="server" Width="40px" CausesValidation="False"
				Text="(F)irst" Visible="False" ToolTip="Go to the first page of records. Alt-F."></asp:button>
			<asp:button id="btnPrevious" style="Z-INDEX: 0" accessKey="P" runat="server" Width="64px" CausesValidation="False"
				Text="(P)revious" Visible="False" ToolTip="Go to the previous page of records. Alt-P."></asp:button>
			<asp:button id="BtnNext" style="Z-INDEX: 0" accessKey="N" runat="server" Width="40px" CausesValidation="False"
				Text="(N)ext" Visible="False" ToolTip="Go to the next page of records. Alt-N."></asp:button>
			<asp:button id="btnLast" style="Z-INDEX: 0" accessKey="L" runat="server" Width="40px" CausesValidation="False"
				Text="(L)ast" Visible="False" ToolTip="Go to the last page of records. Alt-L."></asp:button>
			<asp:dropdownlist id="ddlRecordsPerPage" style="Z-INDEX: 0" runat="server" Width="44px" Height="54px"
				Visible="False" AutoPostBack="False">
				<asp:ListItem Value="5">5</asp:ListItem>
				<asp:ListItem Value="10">10</asp:ListItem>
				<asp:ListItem Value="25">25</asp:ListItem>
				<asp:ListItem Value="5000" Selected="True">5000</asp:ListItem>
			</asp:dropdownlist>
			<asp:textbox id="txtSearch" style="Z-INDEX: 0" accessKey="K" runat="server" Width="90px" Visible="False"
				ToolTip="Type your search key here and press the search button to perform search on the sorted column.  Alt-K."
				MaxLength="20"></asp:textbox>
			<asp:textbox id="txtFormAction" style="Z-INDEX: 0" runat="server" Width="56px" Visible="False"></asp:textbox>
			<asp:button id="btnSearch" style="Z-INDEX: 0" accessKey="S" runat="server" Width="64px" CausesValidation="False"
				Text="(S)earch!" Height="24px" Visible="False" ToolTip="Press this button after typing your search key to perform search on the sorted column.  Alt-S."></asp:button>
			<asp:label id="lblPageRecordCount" style="Z-INDEX: 0" runat="server" Visible="False">Records in this page - Page X of Y</asp:label>
			<asp:textbox id="txtMorePage" style="Z-INDEX: 0" runat="server" Width="32px" Height="18px" Visible="False">0</asp:textbox>
			<asp:textbox id="txtPageNo" style="Z-INDEX: 0" runat="server" Width="32px" Height="18px" Visible="False">0</asp:textbox>
			<asp:label id="lblClient_ID" style="Z-INDEX: 0" runat="server" Visible="False" Font-Size="X-Small"
				Font-Bold="True" Font-Names="Verdana" ForeColor="Black"></asp:label>
			</div>		
			
		</form>
		
		<script>			
			$(function() { $("#divCreatedByESignDrag").draggable(); });
			$(function() { $("#imgCreatedByESignResize").resizable(); });
			
			$(function() { $("#divApprovedByESignDrag").draggable(); });
			$(function() { $("#imgApprovedByESignResize").resizable(); });
			
			$(document).ready(function() {
				$('#btnPrinting').click(); // Trigger the button click event
			});						

		</script>
	</body>
</HTML>
