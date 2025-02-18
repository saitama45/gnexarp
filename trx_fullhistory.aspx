<%@ Register TagPrefix="cc1" Namespace="AvgControls" Assembly="ScrollingGrid" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="trx_fullhistory.aspx.vb" Inherits="srx.trx_fullhistory" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<!-- #include file ="html\HTMLTitle.html" -->
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->		
	</HEAD>
	<!-- #include file ="html\BodyColor.html" -->
		<form id="Form1" method="post" runat="server">
			<div class="w3-container">
				<asp:label id="lblModule" runat="server" Font-Bold="True">Transaction History</asp:label>
				<br>
				<P>														
					<cc1:scrollinggrid id="ScrollingGrid1" style="Z-INDEX: 0" runat="server" Width="1330" Height="550"
						CssClass="sgTbl w3-light-grey" FirefoxBorderWorkaround="false">
						<asp:datagrid id="dgList" runat="server" ItemStyle-Wrap="False" ShowFooter="True" AllowSorting="True"
							BorderColor="#CCCCCC" BackColor="White" BorderStyle="None" EnableViewState="False" GridLines="None"
							CellSpacing="1" CellPadding="3">
							<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#008A8C"></SelectedItemStyle>
							<ItemStyle ForeColor="#000066" BackColor="White"></ItemStyle>
							<AlternatingItemStyle BackColor="WhiteSmoke"></AlternatingItemStyle>
							<HeaderStyle CssClass="ms-formlabel DataGridFixedHeader w3-green"></HeaderStyle>
							<FooterStyle ForeColor="Black" BackColor="Plum"></FooterStyle>
							<Columns></Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
						</asp:datagrid>
					</cc1:scrollinggrid><BR>
					<asp:label id="lblMessage" runat="server" ForeColor="Red"></asp:label>
				</P>
			</div>						
		</form>
	</body>
</HTML>
