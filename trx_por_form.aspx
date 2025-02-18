<%@ Page Language="vb" AutoEventWireup="false" Codebehind="trx_por_form.aspx.vb" Inherits="srx.trx_por_form" %>
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
			DIV.company_logo { POSITION: absolute;PADDING-LEFT: 6em; TOP: 1px; }				
			DIV.form_title { POSITION: absolute;PADDING-LEFT: 30em; TOP: 5px }					
			DIV.printed_on { FONT-SIZE: 12px; POSITION: fixed; PADDING-LEFT: 3em; TOP: 1180px; display:none }
			DIV.pr_code { FONT-SIZE: 12px; POSITION: fixed;PADDING-LEFT: 61em; TOP: 43px }
			DIV.pr_date { FONT-SIZE: 12px; POSITION: fixed; PADDING-LEFT: 61em; TOP: 60px }
			DIV.requested_by { FONT-SIZE: 12px; POSITION: fixed; PADDING-LEFT: 61em; TOP: 80px }
			DIV.due_date { FONT-SIZE: 12px; POSITION: fixed; PADDING-LEFT: 61em; TOP: 100px }			
			DIV.so_no { FONT-SIZE: 12px; POSITION: fixed; PADDING-LEFT: 16em; TOP: 140px }			
			DIV.proj_desc { FONT-SIZE: 12px; POSITION: fixed; PADDING-LEFT: 16em; TOP: 160px }
			DIV.account_name { FONT-SIZE: 12px; POSITION: fixed; PADDING-LEFT: 16em; TOP: 180px }			
			DIV.note { FONT-SIZE: 12px; POSITION: fixed; PADDING-LEFT: 16em; TOP: 200px }			
																						
			.created_by { FONT-SIZE: 12px; PADDING-LEFT: 3em; }	
			DIV.createdby_esign { PADDING-LEFT: 3em; display: inline-block; }		
			.approved_by { FONT-SIZE: 12px; PADDING-LEFT: 45em; }
			DIV.approvedby_esign { PADDING-LEFT: 35em; display: inline-block; }
					
			#imgCreatedByESignResize { WIDTH: 150px }
			#imgApprovedByESignResize { WIDTH: 150px }
						
			.centerHeaderText td { text-align: center; }			
				
			.page-header, .page-header-space {
				height: 255px;
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

			<div class="page-header">
				<div class="image_header">					
					<img src="./images/porform.jpg" alt="prform"  >
					<div class="form_title">
						<h1>Purchase Request</h1>
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
				<div class="pr_code">
					<asp:label id="lblPRCode" runat="server"></asp:label>
				</div>						
				<div class="pr_date">
					<asp:label id="lblPRDate" runat="server"></asp:label>
				</div>
				<div class="requested_by">
					<asp:label id="lblRequestedBy" runat="server"></asp:label>
				</div>
				<div class="due_date">
					<asp:label id="lblDueDate" runat="server"></asp:label>
				</div>
				<div class="so_no">
					<asp:label id="lblSONo" runat="server"></asp:label>
				</div>
				<div class="proj_desc">
					<asp:label id="lblProjectDesc" runat="server"></asp:label>
				</div>
				<div class="account_name">
					<asp:label id="lblAccountName" runat="server"></asp:label>
				</div>			
				<div class="note">
					<asp:label id="lblNote" Runat="server"></asp:label>
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
			
		<script>		
			
			$(document).ready(function() {
				$('#btnPrinting').click(); // Trigger the button click event	
			});
			
			$(function() { $("#divCreatedByESignDrag").draggable(); });
			$(function() { $("#imgCreatedByESignResize").resizable(); });
			
			$(function() { $("#divApprovedByESignDrag").draggable(); });
			$(function() { $("#imgApprovedByESignResize").resizable(); });
			
			
		</script>
	</body>
</HTML>
