<%@ Page Language="vb" AutoEventWireup="false" Codebehind="trx_dr_form_ecpack.aspx.vb" Inherits="srx.trx_dr_form_ecpack" %>
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
			BODY { 
					FONT-SIZE: 11px; 
					FONT-FAMILY: Verdana;
					/* background-image: url('./images/drform_fixus.jpg');            
                	background-repeat: no-repeat; */
				}	
			DIV.form_title { POSITION: absolute;PADDING-LEFT: 35em; TOP: 5px }		
			DIV.company_logo { POSITION: absolute;PADDING-LEFT: 6em; TOP: 1px; }
			DIV.printed_on { FONT-SIZE: 12px; POSITION: absolute; PADDING-LEFT: 3em; TOP: 1180px; display:none }

            DIV.vendor_name { FONT-SIZE: 14px; POSITION: absolute; PADDING-LEFT: 8em; TOP: 145px }
			DIV.vendor_address { FONT-SIZE: 14px; POSITION: absolute; PADDING-LEFT: 8em; TOP: 165px }
           
			DIV.pr_code { FONT-SIZE: 14px; POSITION: absolute; PADDING-LEFT: 40em; TOP: 90px; display:none }
            DIV.pr_date { FONT-SIZE: 14px; POSITION: absolute; PADDING-LEFT: 40em; TOP: 120px }
			DIV.tin_no { FONT-SIZE: 14px; POSITION: absolute; PADDING-LEFT: 40em; TOP: 150px }
			DIV.terms { FONT-SIZE: 14px; POSITION: absolute; PADDING-LEFT: 40em; TOP: 165px }	
			
			DIV.net_sales { FONT-SIZE: 14px; POSITION: absolute; PADDING-LEFT: 40em; TOP: 700px }
			
			.created_by { FONT-SIZE: 12px; PADDING-LEFT: 3em; }	
			DIV.createdby_esign { PADDING-LEFT: 3em; display: none; }		
			.approved_by { FONT-SIZE: 12px; PADDING-LEFT: 45em; }
			DIV.approvedby_esign { PADDING-LEFT: 35em; display: none; }
			
			#imgCreatedByESignResize { WIDTH: 150px }
			#imgApprovedByESignResize { WIDTH: 150px }								            

            .label_prepared_by { FONT-SIZE: 12px; POSITION: absolute; LEFT: 210px; top: 930px;}
            .label_approved_by { FONT-SIZE: 12px; POSITION: absolute; LEFT: 330px; top: 930px;}
            .label_delivered_by { FONT-SIZE: 12px; POSITION: absolute; LEFT: 450px; top: 930px;}

			.created_by { FONT-SIZE: 12px; POSITION: absolute; LEFT: 180px; top: 950px;}

			table {								
				position: absolute;
				margin-left: 25px;
				top: 270px;
				border-style: none;
			}
			table td {				
				word-wrap: break-word;
				border-style: none;
				
			}
			.qty {
				width: 100px; /* Specify the width for the first column */
			}
			.uom {
				width: 70px; /* Specify the width for the second column */
			}
			.item {
				width: 450px; /* Specify the width for the third column */
			}

			.cost {
				width: 180px; /* Specify the width for the third column */
			}
			.netcost {
				width: 180px; /* Specify the width for the third column */
			}

		</style>
	</HEAD>
	<body>		

		<div class="page-header">				
			<div style="display:none;">
				<button id="btnPrinting" type="button" onClick="window.print()" style="background: khaki">
					Print
				</button>
			</div>
			<div class="company_logo" style="display:none">
				<a target="_blank">
					<div id="divCompanyLogo" runat="server"></div>
				</a>
			</div>
			<div class="printed_on">
				Printed On:
				<asp:label id="lblPrintedOn" runat="server"></asp:label>
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
			<div class="vendor_address">
				<asp:label id="lblVendorAddress" runat="server"></asp:label>
			</div>			
			<div class="tin_no">
				<asp:label id="lblVendorTinNo" Runat="server"></asp:label>				
			</div>	
			<div class="terms">
				<asp:label id="lblVendorTerms" Runat="server"></asp:label>			
			</div>	
			<div class="net_sales">										
				<asp:label id="lblNetSales" runat="server"></asp:label>
			</div>		
		</div>

		<div class="page">                                
							
			<!-- <asp:table id="tblQty" runat="server" CssClass="qty"></asp:table>	
			<asp:table id="tblUOM" runat="server" CssClass="uom"></asp:table>
			<asp:table id="tblItem" runat="server" CssClass="item"></asp:table>	
			<asp:table id="tblCost" runat="server" CssClass="cost"></asp:table>	
			<asp:table id="tblNetCost" runat="server" CssClass="netcost"></asp:table>-->

			<form id="Form1" runat="server">
				<asp:datagrid id="Datagrid" runat="server" BorderStyle="None"
					ShowFooter="False" ShowHeader="False" Cssclass="">
					<SelectedItemStyle></SelectedItemStyle>
					<AlternatingItemStyle></AlternatingItemStyle>
					<ItemStyle></ItemStyle>
					<HeaderStyle></HeaderStyle>
					<FooterStyle></FooterStyle>
					<PagerStyle></PagerStyle>
				</asp:datagrid>
			</form>																																									

			<br>
			<div class="note">
				<asp:label id="lblNote" Runat="server"></asp:label>				
			</div>
		</div>
		
		<div class="page-footer">
			
			<div id="divCreatedByESignDrag" class="createdby_esign" runat="server"></div>
			<div id="divApprovedByESignDrag" class="approvedby_esign" runat="server"></div>
			
		</div>            						
		
		<script>			
			$(function() { $("#divCreatedByESignDrag").draggable(); });
			$(function() { $("#imgCreatedByESignResize").resizable(); });
			
			$(function() { $("#divApprovedByESignDrag").draggable(); });
			$(function() { $("#imgApprovedByESignResize").resizable(); });

			$(document).ready(function() {

				$('#btnPrinting').click(); // Trigger the button click event
				
				// Add the CSS classes to the specific td elements within the DataGrid
				$("#Datagrid td:nth-child(1)").addClass("qty");
				$("#Datagrid td:nth-child(2)").addClass("uom");
				$("#Datagrid td:nth-child(3)").addClass("item");
				$("#Datagrid td:nth-child(4)").addClass("cost");
				$("#Datagrid td:nth-child(5)").addClass("netcost");
			});

		</script>
	</body>
</HTML>
