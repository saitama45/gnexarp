<%@ Page Language="vb" AutoEventWireup="false" Codebehind="trx_pos_receipt.aspx.vb" Inherits="srx.trx_pos_receipt" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<!DOCTYPE html>
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!--  Desktop Favicons  -->
		<link rel="icon" type="image/png" href="./images/favicon_96x96.ico" sizes="96x96">
		<link rel="stylesheet" href="css/w3.css">
		<script src="js/jquery/3.6.0/jquery.min.js"></script>
		<style>
			img {
				max-width: 250px;
				width: 250px;
			}

			* {
				font-size: 13px;
				font-family: 'Arial';
				/* font-family: 'Lucida Console'; */
			}
		
			.centerHeaderText td { text-align: center; }						
			
			@page {
				margin: 1mm
			}

			@media print {
				thead {display: table-header-group;} 
				tfoot {display: table-footer-group;}
				
				button {display: none;}
				
				body {margin: 0;}
			}					

			td,
			th,
			tr,
			table {
				border-top: 1px solid black;
				border-collapse: collapse;
			}

			
			td {
				/* width: 400px; */
   				max-width: 400px;
				white-space: normal;
			}
						
			.header_class {
				display: inline-block;
				width: 260px;					
			}

			.centered {
				text-align: center;
				align-content: center;
			}

			.page-ticket {
				width: 400px;
    			max-width: 400px;
			}
		</style>

	</head>

	<body>
		<div style="display:none;">
			<button id="btnPrinting" type="button" onClick="window.print()" style="background: khaki">
				Print
			</button>
		</div>
		
		<div class="page-ticket">			
			
				<p class="centered">
					<span id="divCompanyLogo" runat="server" Visible="False"></span>
					<asp:Literal ID="litCompanyName" runat="server"></asp:Literal>					
					<b><label class="w3-large">Acknowledgement Receipt</label></b>
					<br><br>
					<asp:label id="lblPrintedOn" runat="server"></asp:label>
					<br>
					<asp:label id="lblCustomerName" runat="server"></asp:label>
					<br>Contact#:
					<asp:label id="lblContactNo" runat="server"></asp:label>
					<br>OF#:
					<asp:label id="lblSINo" runat="server"></asp:label>
						
				</p>
				
				<div style="text-align:center; display: flex; justify-content: center; align-items: center;">
					<asp:datagrid id="dgList" runat="server" ItemStyle-Wrap="false" CellPadding="1" BackColor="Transparent" 
						BorderWidth="0px" BorderColor="Black" AllowSorting="True" GridLines="none" BorderStyle="Solid" ShowFooter="False">
						<ItemStyle Wrap="False" HorizontalAlign="Left" Width="100%"></ItemStyle>
						<HeaderStyle Font-Bold="True" ForeColor="Black" BackColor="White" CssClass="centerHeaderText"></HeaderStyle>
						<FooterStyle Font-Bold="True" ForeColor="Black" HorizontalAlign="Center"></FooterStyle>
						<PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
					</asp:datagrid>	
					
				</div>				
				<br>
				<div class="discounted_amount">
					<label class="header_class">LESS:</label>
					<asp:label id="lblDiscountedAmount" runat="server" CssClass="discounted_amount"></asp:label>
				</div>							
				<div class="net_amount">
					<label class="header_class">NET AMOUNT:</label>
					<asp:label id="lblNetAmount" runat="server" CssClass="net_amount"></asp:label>
				</div>
				<br>	
				<div class="payment">
					<label class="header_class">PAYMENT:</label>
					<asp:label id="lblCash" runat="server" CssClass="net_amount"></asp:label>														
				</div>					
				<div class="payment">
					<label class="header_class">CHANGE:</label>
					<asp:label id="lblChange" runat="server" CssClass="net_amount"></asp:label>														
				</div>
				<br>
				<div class="cashier">
					<label class="header_class">ASSISTED BY:</label>
					<asp:label id="lblCashier" runat="server" CssClass="net_amount"></asp:label>										
				</div>				
				<div class="pay_type">
					<label class="header_class">PAY TYPE:</label>
					<asp:label id="lblPayType" runat="server" CssClass="net_amount"></asp:label>										
				</div>				
				<div class="ref_no">
					<label class="header_class">Reference #:</label>
					<asp:label id="lblRefNo" runat="server" CssClass="net_amount"></asp:label>								
				</div>				
				<div class="pos_notes">
					<label class="header_class">Notes:</label>
					<br>
					<asp:label id="lblNotes" runat="server" CssClass=""></asp:label>
					<br>					
				</div>
				<br>
				<div class="remarks">
					<label class="">*No Change of Mind Policy</label>						
					<br>
					<label class="">*If items are Damaged, please return within 7 days.</label>						
					<br>
					<label class="">*This is NOT a sales invoice, please ask for a Sales Invoice</label>						
				</div>
				
		</div>				
		
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
		</script>			
	</body>
</html>
