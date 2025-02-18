<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inv_dritems_printamort.aspx.vb" Inherits="srx.inv_dritems_printamort" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE html>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" --> 
		<!--  Desktop Favicons  -->
		<link rel="icon" type="image/png" href="./images/favicon_96x96.ico" sizes="96x96">
		<script src="js/jquery/3.6.0/jquery.min.js"></script>
		<style>
			LABEL {FONT-WEIGHT:bold; width: 160px;display: inline-block; text-align: right;}			
			BODY { FONT-SIZE: 11px; FONT-FAMILY: Verdana }	
			/* DIV.form_title { POSITION: absolute;PADDING-LEFT: 56em; TOP: 5px } */
			DIV.form_title { POSITION: absolute;PADDING-LEFT: 30em; TOP: 5px }		
			DIV.company_logo { POSITION: absolute;PADDING-LEFT: 6em; TOP: 1px; }
			DIV.address { FONT-SIZE: 12px; POSITION: absolute; TOP: 60px }				
			DIV.name { FONT-SIZE: 12px; POSITION: absolute; TOP: 90px }			
			DIV.first_pay_date { FONT-SIZE: 12px; POSITION: absolute; TOP: 110px;}									
			DIV.monthly_amort { FONT-SIZE: 12px; POSITION: absolute; TOP: 130px }
			DIV.application_date { FONT-SIZE: 12px; POSITION: absolute;PADDING-LEFT: 40em; TOP: 90px }
			DIV.loan_amount { FONT-SIZE: 12px; POSITION: absolute;PADDING-LEFT: 40em; TOP: 110px }
			DIV.monthly_terms { FONT-SIZE: 12px; POSITION: absolute;PADDING-LEFT: 40em; TOP: 130px }			
			
			DIV.signatories_underline { FONT-SIZE: 12px; display: flex; justify-content: space-between; }									
			DIV.signatories { FONT-SIZE: 11px; display: flex; justify-content: space-between; }

			/* DIV.prepared_underline { FONT-SIZE: 12px; POSITION: absolute; TOP: 980px }									
			DIV.prepared_by { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 1em; TOP: 1000px }
			
			DIV.verified_underline { FONT-SIZE: 12px; POSITION: relative; display: flex; justify-content: center; TOP: 980px }
			DIV.verified_by { FONT-SIZE: 12px; POSITION: relative; display: flex; justify-content: center; TOP: 1000px }
			
			DIV.approved_underline { FONT-SIZE: 12px; POSITION: relative; margin-left: auto; TOP: 980px }
			DIV.approved_by { FONT-SIZE: 12px; POSITION: relative; margin-left: auto; TOP: 1000px } */
			
			DIV.received_underline { FONT-SIZE: 12px; display: flex; flex-wrap: wrap; row-gap: 10px; column-gap: 3em;  }
			DIV.received_by { FONT-SIZE: 12px; display: flex; flex-wrap: wrap; row-gap: 10px; column-gap: 3em; }									
							
			DIV.footer { POSITION: absolute; PADDING-LEFT: 2em; TOP: 730px }			
			.created_by { FONT-SIZE: 12px; PADDING-LEFT: 3em; }	
			DIV.createdby_esign { PADDING-LEFT: 3em; display: inline-block; }		
			.approved_by { FONT-SIZE: 12px; PADDING-LEFT: 45em; }
			DIV.approvedby_esign { PADDING-LEFT: 35em; display: inline-block; }
			#imgCreatedByESignResize { WIDTH: 150px }
			#imgApprovedByESignResize { WIDTH: 150px }
			LABEL.received { MARGIN-LEFT: 200px }
			LABEL.authorize { POSITION: absolute; PADDING-LEFT: 25em; TOP: 720px }
			LABEL.signature { MARGIN-LEFT: 280px }				
			.centerHeaderText td { text-align: center; }
			table { table-layout: auto; width: 100%; }

			.page-header, .page-header-space {
				height: 150px;
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
			
			DIV.datagrid { FONT-SIZE: 11px; WIDTH: 850px;   }
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
				<div class="form_title w3-center">
					<h1>Loan Amortization</h1>
					<asp:label id="lblTitle" runat="server" Visible="False"></asp:label>
				</div>		
				<div class="company_logo">
					<a target="_blank">
						<div id="divCompanyLogo" runat="server"></div>
					</a>		
				</div>					
				<div class="address">
					<asp:label id="lblAddress" runat="server"></asp:label>
				</div>
				<div class="name">
					<label>Name:&ensp;</label>
					<asp:label id="lblClientName" runat="server"></asp:label>
				</div>
				<div class="first_pay_date">
					<label>First Amortization:&ensp;</label>
					<asp:label id="lblFirstAmortDate" runat="server"></asp:label>
				</div>
				<div class="monthly_amort">
					<label>Monthly Amortization:&ensp;</label>
					<asp:label id="lblMonthlyAmort" runat="server"></asp:label>
				</div>			
				<div class="application_date">
					<label>Application Date:&ensp;</label>
					<asp:label id="lblApplicationDate" runat="server"></asp:label>
				</div>	
				<div class="loan_amount">
					<label>Loan Amount:&ensp;</label>
					<asp:label id="lblLoanAmount" runat="server"></asp:label>
				</div>
				<div class="monthly_terms">
					<label>Loan Terms:&ensp;</label>
					<asp:label id="lblMonthlyTerms" runat="server"></asp:label>
				</div>								
			</div>	
		
			<div class="page-footer">
				<div class="signatories_underline">
					<label>________________</label>
					<label>________________</label>
				</div>
				<div class="signatories">
					<label>PREPARED BY:</label>
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
