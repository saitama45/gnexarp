<%@ Page Language="vb" AutoEventWireup="false" Codebehind="trx_cv_print_fixus.aspx.vb" Inherits="srx.trx_cv_print_fixus" %>
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
			LABEL {FONT-WEIGHT:bold;  width: 130px; display: inline-block; text-align: right;}			
			BODY { FONT-SIZE: 11px; FONT-FAMILY: Verdana }	
			DIV.form_title { POSITION: absolute;PADDING-LEFT: 60em; TOP: 5px }
			DIV.company_logo { POSITION: absolute;PADDING-LEFT: 6em; TOP: 1px; }
			DIV.address { FONT-SIZE: 11px; POSITION: absolute; TOP: 68px }				
			DIV.voucher_no { FONT-SIZE: 14px; POSITION: absolute; TOP: 100px }			
			DIV.date { FONT-SIZE: 14px; POSITION: absolute;PADDING-LEFT: 12em; TOP: 100px }									
			DIV.due_date { FONT-SIZE: 14px; POSITION: absolute;PADDING-LEFT: 28em; TOP: 100px }
			DIV.payee { FONT-SIZE: 14px; POSITION: absolute; TOP: 120px }
			DIV.particulars { FONT-SIZE: 14px; POSITION: absolute; TOP: 140px }
			DIV.cash_no { FONT-SIZE: 14px; POSITION: absolute;PADDING-LEFT: 43em; TOP: 60px }
			DIV.check_no { FONT-SIZE: 14px; POSITION: absolute;PADDING-LEFT: 43em; TOP: 80px }		
			DIV.check_date { FONT-SIZE: 14px; POSITION: absolute;PADDING-LEFT: 43em; TOP: 100px }		
			DIV.check_amount { FONT-SIZE: 14px; POSITION: absolute;PADDING-LEFT: 43em; TOP: 120px }		
			
			DIV.signatories_underline { FONT-SIZE: 14px; display: flex; justify-content: space-between; }									
			DIV.signatories { FONT-SIZE: 11px; display: flex; justify-content: space-between; }			
			
			DIV.received_underline { FONT-SIZE: 14px; display: flex; flex-wrap: wrap; row-gap: 10px; column-gap: 3em;  }
			DIV.received_by { FONT-SIZE: 14px; display: flex; flex-wrap: wrap; row-gap: 10px; column-gap: 1em; }									
							
			DIV.footer { POSITION: absolute; PADDING-LEFT: 2em; TOP: 730px }			
			.created_by { FONT-SIZE: 14px; PADDING-LEFT: 3em; }	
			DIV.createdby_esign { PADDING-LEFT: 3em; display: inline-block; }		
			.approved_by { FONT-SIZE: 14px; PADDING-LEFT: 45em; }
			DIV.approvedby_esign { PADDING-LEFT: 35em; display: inline-block; }
			#imgCreatedByESignResize { WIDTH: 150px }
			#imgApprovedByESignResize { WIDTH: 150px }
			LABEL.received { MARGIN-LEFT: 200px }
			LABEL.authorize { POSITION: absolute; PADDING-LEFT: 25em; TOP: 720px }
			LABEL.signature { MARGIN-LEFT: 280px }				
			.centerHeaderText td { text-align: center; }
			table { table-layout: auto; width: 100%; }

			.page-header, .page-header-space {
				height: 180px;
			}

			.page-footer, .page-footer-space {
				height: 90px;
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

			.push_left {
				margin-left: auto;
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
			
			DIV.datagrid { FONT-SIZE: 14px; WIDTH: 850px;   }
		</style>
	</HEAD>
	<body>		
		<form id="Form1" runat="server">
			<div class="printed_on">
				<div style="display:none;">
					<button id="btnPrinting" type="button" onClick="window.print()" style="background: khaki">
						Print
					</button>
				</div>
			</div>		
			<div class="page-header">
				<div class="form_title">
					<h1>Check Voucher</h1>
					<asp:label id="lblTitle" runat="server" Visible="False"></asp:label>
				</div>		
				<div class="company_logo">
					<a target="_blank">
						<div id="divCompanyLogo" runat="server"></div>
					</a>		
				</div>					
				<div class="address">
					<label>&ensp;</label>
					<asp:label id="lblAddress" runat="server"></asp:label>
				</div>
				<div class="voucher_no">
					<label>Voucher No.&ensp;</label>
					<asp:label id="lblVoucherNo" runat="server"></asp:label>
				</div>
				<div class="date">
					<label>Date&ensp;</label>
					<asp:label id="lblDate" runat="server"></asp:label>
				</div>
				<div class="due_date">
					<label>Due Date&ensp;</label>
					<asp:label id="lblDueDate" runat="server"></asp:label>
				</div>			
				<div class="payee">
					<label>Payee&ensp;</label>
					<asp:label id="lblPayee" runat="server"></asp:label>
				</div>	
				<div class="particulars">
					<label>Particulars&ensp;</label>
					<asp:label id="lblParticulars" runat="server"></asp:label>
				</div>	
				<div class="cash_no">
					<label>RFB No.&ensp;</label>
					<asp:label id="lblCashNo" runat="server"></asp:label>
				</div>
				<div class="check_no">
					<label>Check No.&ensp;</label>
					<asp:label id="lblCheckNo" runat="server"></asp:label>
				</div>
				<div class="check_date">
					<label>Check Date&ensp;</label>
					<asp:label id="lblCheckDate" runat="server"></asp:label>
				</div>
				<div class="check_amount">
					<label>Amount&ensp;</label>
					<asp:label id="lblCheckAmount" runat="server"></asp:label>
				</div>					
			</div>	
		
			<div class="page-footer">
				
				
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
										ShowFooter="True">
										<ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
										<HeaderStyle Font-Bold="True" ForeColor="Black" BackColor="White" CssClass="centerHeaderText"></HeaderStyle>
										<FooterStyle Font-Bold="True" ForeColor="Black" HorizontalAlign="Center"></FooterStyle>
										<PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
									</asp:datagrid>																						
								</div>
								<br><br>	
								<div class="signatories_underline">
									<label>________________</label>
									<label>________________</label>
									<label>________________</label>
								</div>
								<div class="signatories">
									<label>PREPARED BY:</label>
									<label>VERIFIED BY:</label>
									<label>APPROVED BY:</label>
								</div>
								<br><br>
								<div class="received_underline">
									<label>________________</label>
									<label>________________</label>
								</div>	
								<div class="received_by">				
									<label>RECEIVED BY:</label>
									<label>DATE</label>
									<div class="push_left">
										Printed On:&nbsp;<asp:label id="lblPrintedOn" runat="server"></asp:label>
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
