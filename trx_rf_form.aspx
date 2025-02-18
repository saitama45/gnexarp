<%@ Page Language="vb" AutoEventWireup="false" Codebehind="trx_rf_form.aspx.vb" Inherits="srx.trx_rf_form" %>
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
				/* text-align: center; */
				top: 0;
				/* left: 50%; */
				/* transform: translateX(-50%); 	 */
			}
			
			DIV.bu_info	{ 
				position: absolute;				
				text-align: left;
				top: 20px;
				left: 65%;
				width: 40%;
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
				width: 150px;					
			}

			DIV.ref_no { FONT-SIZE: 12px; FONT-WEIGHT: bold; POSITION: absolute; PADDING-LEFT: 50em; TOP: 145px; width: 100%; }
			DIV.date_requested { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 50em; TOP: 165px; width: 100%; }
			DIV.date_needed { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 50em; TOP: 185px; width: 100%; }					

			DIV.account_name { FONT-SIZE: 12px; FONT-WEIGHT: bold; POSITION: absolute; PADDING-LEFT: 1em; TOP: 145px; width: 100%; }
			DIV.location { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 1em; TOP: 165px; width: 100%; }
			DIV.budget_holder { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 1em; TOP: 185px; width: 100%; }
			DIV.rf_no { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 1em; TOP: 205px; width: 100%; }						
			DIV.particulars { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 1em; TOP: 225px; width: 100%; }
						
			DIV.printed_on { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 3em; TOP: 1180px; display:none }						
							
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
				height: 50px;
			}
			.header {
				position: fixed;
				top: 0;
				width: 100%;

			}
			.footer {
				position: fixed;
				bottom: 0;
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
				ShowFooter="true">
				<ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="Black" BackColor="White" CssClass="centerHeaderText"></HeaderStyle>
				<FooterStyle Font-Bold="True" ForeColor="Black" HorizontalAlign="Center"></FooterStyle>
				<PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
			</asp:datagrid>			
			
		</div>				

		</td></tr></tbody>
		<tfoot><tr><td>
			<div class="footer-space">&nbsp;</div>
		</td></tr></tfoot>
		</table>

		<div class="header">
			<div class="image_header">					
				<!-- <img src="./images/prform.jpg" alt="prform"  > -->
				<div>
					<label class="form_title">REQUEST FORM</label>
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
					<asp:label id="lblBUContactNo" CssClass="bu_contact" runat="server"></asp:label>
				</p>
				<p>
					<asp:label id="lblBUEmail" CssClass="bu_email" runat="server"></asp:label>					
				</p>															
			</div>
			<div class="printed_on">
				Printed On:
				<asp:label id="lblPrintedOn" runat="server"></asp:label>
			</div>

			<div class="ref_no">
				<LABEL class="header_class"><B>Ref No.:</B></LABEL>
				<asp:label id="lblRefNo" runat="server"></asp:label>
			</div>						
			<div class="date_requested">
				<LABEL class="header_class">Date Requested:</LABEL>
				<asp:label id="lblDateRequested" runat="server"></asp:label>
			</div>
			<div class="date_needed">
				<LABEL class="header_class">Date Needed:</LABEL>
				<asp:label id="lblDateNeeded" runat="server"></asp:label>
			</div>
			
			<div class="account_name">
				<LABEL class="header_class"><B>Account Name:</B></LABEL>
				<asp:label id="lblAccountName" runat="server"></asp:label>
			</div>
			<div class="location">
				<LABEL class="header_class">Location:</LABEL>
				<asp:label id="lblLocation" Runat="server"></asp:label>
			</div>
			<div class="budget_holder">
				<LABEL class="header_class">Budget Holder:</LABEL>
				<asp:label id="lblBudgetHolder" Runat="server"></asp:label>&nbsp;				
			</div>		
			<div class="rf_no">
				<LABEL class="header_class">RF No.:</LABEL>
				<asp:label id="lblRFNo" Runat="server"></asp:label>&nbsp;				
			</div>				
			<div class="particulars">
				<LABEL class="header_class"><b>Particulars:</b></LABEL>
				<asp:label id="lblParticulars" runat="server"></asp:label>
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