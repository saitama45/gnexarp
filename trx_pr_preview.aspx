<%@ Page Language="vb" AutoEventWireup="false" Codebehind="trx_pr_preview.aspx.vb" Inherits="ems.trx_pr_preview" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE html>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!--  Desktop Favicons  -->
		<link rel="icon" type="image/png" href="./images/favicon_96x96.ico" sizes="96x96">
		<link href="css/print_forms.css" rel="stylesheet" />
		<script src="js/jquery/3.6.0/jquery.min.js"></script>
		<style>
			BODY { FONT-SIZE: 11px; FONT-FAMILY: Verdana }			
			p {
				margin: 1px 0;
			}

			.companylogo {
				position: absolute;				
				text-align: center;
				top: 0;
				left: 50%;
				transform: translateX(-50%); 	
			}
			
			DIV.bu_info	{ 
				position: absolute;				
				text-align: center;
				top: 65px;
				left: 50%;
				width: 100%;
				transform: translateX(-50%); 
			}

			.form_title { 			
				position: absolute;	
				FONT-FAMILY: Arial; 
				FONT-SIZE: 25px; 	
				FONT-WEIGHT: bold; 		
				text-align: center;
				top: 100px;
				left: 50%;				
				transform: translateX(-50%);
			}					

			.header_class {
				display: inline-block;
				width: 100px;					
			}

			DIV.pr_code { FONT-SIZE: 12px; FONT-WEIGHT: bold; POSITION: absolute; PADDING-LEFT: 50em; TOP: 145px; width: 100%; }
			DIV.pr_date { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 50em; TOP: 165px; width: 100%; }
			DIV.terms { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 50em; TOP: 185px; width: 100%; }

			DIV.vendor_name { FONT-SIZE: 12px; FONT-WEIGHT: bold; POSITION: absolute; PADDING-LEFT: 1em; TOP: 145px; width: 100%; }
			DIV.vendor_contact { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 1em; TOP: 165px; width: 100%; }
			DIV.vendor_contactno { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 1em; TOP: 185px; width: 100%; }
			DIV.email { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 1em; TOP: 205px; width: 100%; }			
			DIV.vendor_address { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 1em; TOP: 225px; width: 150%; }

			DIV.requested_by { FONT-SIZE: 12px; FONT-WEIGHT: bold; POSITION: absolute; PADDING-LEFT: 50em; TOP: 205px; width: 100%; }
			/* DIV.note { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 1em; TOP: 245px; width: 100%; } */

			span.shipping {
				FONT-SIZE: 12px;
				COLOR: RED;
			}

			DIV.printed_on { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 3em; TOP: 1180px; display:none }
			DIV.vendor_code { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 16em; TOP: 110px; display:none }


			DIV.dept { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 16em; TOP: 216px }
			DIV.contact_no { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 46em; TOP: 211	px }	

			SPAN.vat {FONT-SIZE: 12px; width: 120px; text-align: right; display: inline-block;}	
			SPAN.vatlabel { FONT-SIZE: 12px; MARGIN-LEFT: 48em; width: 150px; display: inline-block;}

			LABEL.discount { FONT-SIZE: 12px; MARGIN-LEFT: 48em; width: 150px; display: inline-block;}
			SPAN.discount {FONT-SIZE: 12px; width: 120px; text-align: right; display: inline-block;}	
			
			LABEL.discounted_amount { FONT-SIZE: 12px; MARGIN-LEFT: 48em; width: 150px; display: inline-block;}
			SPAN.discounted_amount {FONT-SIZE: 12px; width: 120px; text-align: right; display: inline-block;}	
				
			LABEL.net_amount { FONT-SIZE: 12px; MARGIN-LEFT: 48em; width: 150px; display: inline-block;}
			SPAN.net_amount {FONT-SIZE: 12px; FONT-WEIGHT: bold; width: 120px; text-align: right; display: inline-block;}
			
			LABEL.php_net_amount { FONT-SIZE: 12px; MARGIN-LEFT: 48em; width: 150px; display: inline-block;}
			SPAN.php_net_amount {FONT-SIZE: 12px; FONT-WEIGHT: bold; width: 120px; text-align: right; display: inline-block;}
							
			.footer_info {
				display: grid;
				grid-template-columns: auto auto;
				justify-content: space-between;
				grid-gap: 10px;
			}

			.label-container {
				display: flex;
				flex-direction: column;
				align-items: center;
				FONT-SIZE: 12px; 
				FONT-WEIGHT: bold;
			}
		
			DIV.createdby_esign { PADDING-LEFT: 3em; display: none; }		
		
			DIV.approvedby_esign { PADDING-LEFT: 35em; display: none; }
					
			#imgCreatedByESignResize { WIDTH: 150px }
			#imgApprovedByESignResize { WIDTH: 150px }
						
			.centerHeaderText td { text-align: center; }	
				
			.header, .header-space {
				height: 285px;
			}
			.footer, .footer-space {
				height: 150px;
			}
			.header {
				position: fixed;
				top: 0;
				width: 100%;

			}
			.footer {
				/* position: fixed;
				bottom: 0; */
				width: 100%;			

			}

			@page {
				margin: 15mm
			}

			@media print {

				button {display: none;}
				
				body {margin: 0;}
			}		
			
			#dgList {
				table-layout: auto;
				width: 100%; 				
			}
			
			DIV.datagrid { FONT-SIZE: 11px; WIDTH: 850px;  PADDING-LEFT: 1em; }

		</style>
	</HEAD>
	<body>				
		
		<table>
		<thead><tr><td>
			<div class="header-space">&nbsp;</div>
		</td></tr></thead>
		<tbody><tr><td>
			
			<div class="content">
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
			<div class="vat">
				<asp:label id="lblVATLabel" runat="server" CssClass="vatlabel">VAT:</asp:label>
				<asp:label id="lblVAT" runat="server" CssClass="vat"></asp:label>
			</div>		
			<div class="discount">
				<label class="discount">DISCOUNT (%):</label>
				<asp:label id="lblDiscount" runat="server" CssClass="discount"></asp:label>
			</div>				
			<div class="discounted_amount">
				<label class="discounted_amount">LESS:</label>
				<asp:label id="lblDiscountedAmount" runat="server" CssClass="discounted_amount"></asp:label>
			</div>
			<br>
			<div class="net_amount">
				<label class="php_net_amount">NET AMOUNT (<b>PHP</b>):</label>
				<asp:label id="lblNetAmount" runat="server" CssClass="net_amount"></asp:label>
			</div>								
			<div class="php_net_amount">
				<asp:panel id="panelPHPNetAmount" runat="server" Visible="False">
					<label class="net_amount">NET AMOUNT (<asp:label id="lblCurrency" Font-Bold="True" runat="server"></asp:label>):</label>																			
					<asp:label id="lblPHPNetAmount" runat="server" CssClass="php_net_amount" Visible="False"></asp:label>
				</asp:panel>									
			</div>
		
			
		 </div>	
		<br>
		<div class="other_notes">
			<span class="shipping">
				<p><b>Shipping Notes</b></p>
				<br>
				<p>					
					<asp:label id="lblNote" Runat="server"></asp:label>						
				</p>
				<p style="display:none;">
					<b><asp:label id="lblBU" runat="server"></asp:label></b>
					<asp:label id="lblBUShippingAddress" runat="server"></asp:label>
				</p>										
			</span>	
			<br>
			<span class="po_note">
				<p><b>Purchase Order Note</b></p>
				<p>
					Conditions and Instructions:
				</p>
				<br>
				<p>
					1. Kindly send proforma invoice for payment with wire transfer information.
				</p>
				<p>
					2. Items must be shipped only to the address above.
				</p>
				<p>
					3. Goods are subject to inspection upon arrival and <asp:label id="lblBUName" runat="server"></asp:label> have the right to return wrong, damaged, excess and expired items.
				</p>
				<p>
					4. Please acknowledge upon receipt of this Purchase Order (PO) via phone or email and notify us immediately for any concerns.
				</p>
			</span>							
		</div>
			</div>

		</td></tr></tbody>
		<tfoot><tr><td>
			<div class="footer-space">&nbsp;</div>
		</td></tr></tfoot>
		</table>

		<div class="header">
			<div class="image_header">					
				<img src="./images/prform.jpg" alt="prform"  >
				<div>
					<label class="form_title">PURCHASE ORDER</label>
				</div>	
				<div style="display:none;">
					<button id="btnPrinting" type="button" onClick="window.print()" style="background: khaki">
						Print
					</button>
				</div>													
			</div>				
			
			<div class="companylogo">
				<a target="_blank">						
					<div id="divCompanyLogo" runat="server"></div>
				</a>										
			</div>			

			<div class="bu_info">
				<p>
					<asp:label id="lblBUAddress" CssClass="bu_address" runat="server"></asp:label>
				</p>
				<p>
					<asp:label id="lblBUContactNo" CssClass="bu_contact" runat="server"></asp:label>&nbsp;/&nbsp;<asp:label id="lblBUEmail" CssClass="bu_email" runat="server"></asp:label>					
				</p>						
			</div>
			<div class="printed_on">
				Printed On:
				<asp:label id="lblPrintedOn" runat="server"></asp:label>
			</div>

			<div class="pr_code">
				<LABEL class="header_class"><B>PO Number:</B></LABEL>
				<asp:label id="lblPRCode" runat="server"></asp:label>
			</div>						
			<div class="pr_date">
				<LABEL class="header_class">PO Date:</LABEL>
				<asp:label id="lblPRDate" runat="server"></asp:label>
			</div>
			<div class="terms">
				<LABEL class="header_class">PO Terms:</LABEL>
				<asp:label id="lblTerms" Runat="server"></asp:label>&nbsp;Days				
			</div>

			<div class="vendor_name">
				<LABEL class="header_class"><B>Supplier:</B></LABEL>
				<asp:label id="lblVendorName" runat="server"></asp:label>
			</div>
			<div class="vendor_contact">
				<LABEL class="header_class">Contact:</LABEL>
				<asp:label id="lblVendorContact" Runat="server"></asp:label>
			</div>
			<div class="vendor_contactno">
				<LABEL class="header_class">Phone No.:</LABEL>
				<asp:label id="lblVendorContactNo" Runat="server"></asp:label>				
			</div>
			<div class="email">
				<LABEL class="header_class">Email:</LABEL>
				<asp:label id="lblEmail" Runat="server"></asp:label>
			</div>
			<div class="vendor_address">
				<LABEL class="header_class">Address:</LABEL>
				<asp:label id="lblVendorAddress" runat="server"></asp:label>
			</div>	
			<div class="requested_by">
				<LABEL class="header_class"><b>Requested By:</b></LABEL>
				<asp:label id="lblRequestedBy" runat="server"></asp:label>
			</div>
			<div class="note">
							
			</div>

			<div class="vendor_code">
				<asp:label id="lblVendorCode" runat="server"></asp:label>
			</div>
			
			<div class="dept">
				<asp:label id="lblDept" runat="server"></asp:label>
			</div>
			<div class="contact_no">
				<asp:label id="lblContactNo" runat="server"></asp:label>
			</div>		
			
		</div>
		<div class="footer">
			<div class="footer_info">
				<div class="label-container">
					<label for="preparedBy">PREPARED BY:</label>
					<br>
					<div id="divCreatedByESignDrag" class="createdby_esign" runat="server"></div>
					<asp:label id="lblCreatedBy" Cssclass= "created_by" runat="server"></asp:label>	
				</div>
				<div class="label-container">
					<label for="approvedBy">APPROVED BY:</label>
					<br>
					<div id="divApprovedByESignDrag" class="approvedby_esign" runat="server"></div>
					<asp:label id="lblApprovedBy" Cssclass= "approved_by" runat="server"></asp:label>
				</div>					
			</div>
		</div>
							
			<div style="display:none">
				<!-- <asp:button id="BtnFirst" style="Z-INDEX: 0" accessKey="F" runat="server" Width="40px" CausesValidation="False"
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
					Font-Bold="True" Font-Names="Verdana" ForeColor="Black"></asp:label> -->
			</div>
			
		<script>			
			
			$(document).ready(function() {
				$('#btnPrinting').click(); // Trigger the button click event	
			});
		</script>
	</body>
</HTML>
