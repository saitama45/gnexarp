<%@ Page Language="vb" AutoEventWireup="false" Codebehind="SendEmail.aspx.vb" Inherits="srx.SendEmail" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Send Mail From ASP.Net</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<SCRIPT language="javascript" src="js/TextEdit.js"></SCRIPT>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" encType="multipart/form-data" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 120; LEFT: 5px; POSITION: absolute; TOP: 5px" runat="server"
				Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#FF6600">Compose New Mail Message</asp:label>
			<asp:Label id="lblMessage" style="Z-INDEX: 120; LEFT: 300px; POSITION: absolute; TOP: 5px"
				runat="server" Font-Names="Verdana" Font-Size="X-Small" Width="540" Visible="False" ForeColor="#FF8000"
				Font-Bold="True"></asp:Label>
			<HR style="Z-INDEX: 115; LEFT: 1px; WIDTH: 451px; POSITION: absolute; TOP: 22px" align="center"
				width="100%" color="#cccccc" SIZE="1">
			<asp:label id="Label3" style="Z-INDEX: 120; LEFT: 50px; POSITION: absolute; TOP: 27px" runat="server"
				Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#000000">From :</asp:label>
			<asp:textbox id="TextBox2" style="Z-INDEX: 129; LEFT: 100px; POSITION: absolute; TOP: 25px" runat="server"
				Height="21px" Width="353px"></asp:textbox>
			<HR style="Z-INDEX: 117; LEFT: 0px; WIDTH: 451px; POSITION: absolute; TOP: 47px" align="center"
				width="100%" color="#cccccc" SIZE="1">
			<asp:label id="Label4" style="Z-INDEX: 121; LEFT: 68px; POSITION: absolute; TOP: 53px" runat="server"
				Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#000000">To :</asp:label>
			<asp:textbox id="TextBox3" style="Z-INDEX: 130; LEFT: 100px; POSITION: absolute; TOP: 50px" runat="server"
				Height="21px" Width="353px"></asp:textbox>
			<HR style="Z-INDEX: 117; LEFT: 0px; WIDTH: 451px; POSITION: absolute; TOP: 72px" align="center"
				width="100%" color="#cccccc" SIZE="1">
			<asp:label id="Label2" style="Z-INDEX: 121; LEFT: 68px; POSITION: absolute; TOP: 78px" runat="server"
				Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#000000">Cc :</asp:label>
			<asp:textbox id="txtcc" style="Z-INDEX: 130; LEFT: 100px; POSITION: absolute; TOP: 75px" runat="server"
				Height="21px" Width="353px"></asp:textbox>
			<HR style="Z-INDEX: 117; LEFT: 0px; WIDTH: 451px; POSITION: absolute; TOP: 97px" align="center"
				width="100%" color="#cccccc" SIZE="1">
			<asp:label id="Label6" style="Z-INDEX: 121; LEFT: 61px; POSITION: absolute; TOP: 102px" runat="server"
				Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#000000">Bcc :</asp:label>
			<asp:textbox id="txtbcc" style="Z-INDEX: 130; LEFT: 100px; POSITION: absolute; TOP: 100px" runat="server"
				Height="21px" Width="353px"></asp:textbox>
			<HR style="Z-INDEX: 119; LEFT: 0px; WIDTH: 451px; POSITION: absolute; TOP: 122px" align="center"
				width="100%" color="#cccccc" SIZE="1">
			<asp:label id="Label5" style="Z-INDEX: 122; LEFT: 33px; POSITION: absolute; TOP: 128px" runat="server"
				Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#000000">Subject :</asp:label>
			<asp:textbox id="TextBox4" style="Z-INDEX: 131; LEFT: 100px; POSITION: absolute; TOP: 125px"
				runat="server" Height="21px" Width="353px"></asp:textbox>
			<HR style="Z-INDEX: 119; LEFT: 0px; WIDTH: 451px; POSITION: absolute; TOP: 147px" align="center"
				width="100%" color="#cccccc" SIZE="1">
			<asp:label id="Label7" style="Z-INDEX: 122; LEFT: 6px; POSITION: absolute; TOP: 154px" runat="server"
				Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#000000">Attachment :</asp:label>
			<asp:button id="Button2" style="Z-INDEX: 119; LEFT: 99px; POSITION: absolute; TOP: 149px" runat="server"
				Text="Add Attachments" Width="145" Height="22"></asp:button>
			<input id="attachFile1" style="LEFT: 300px; POSITION: absolute; TOP: 149px" size="30" type="file"
				visible="false" runat="server">
			<asp:textbox id="TextBox5" style="Z-INDEX: 133; LEFT: 73px; POSITION: absolute; TOP: 125px" runat="server"
				Height="25px" Width="500px" TextMode="MultiLine" Visible="false"></asp:textbox>
			<input type="hidden" runat="server" id="hdnmsg" NAME="hdnmsg">
			<asp:button id="Button1" style="Z-INDEX: 132; LEFT: 98px; POSITION: absolute; TOP: 428px" runat="server"
				Text="Click to Send Email" Width="145" Height="22"></asp:button>
			<p></p>
			<DIV id="divContent">
				<asp:panel id="pnlContentMgmt" style="Z-INDEX: 133; LEFT: 100px; POSITION: absolute; TOP: 175px"
					runat="server" width="550px">
					<TABLE style="WIDTH: 500px; BORDER-COLLAPSE: collapse; HEIGHT: 77px" borderColor="black"
						cellSpacing="0" cellPadding="0" width="500" align="left" bgColor="buttonface" border="1">
						<TR>
							<TD height="20">
								<TABLE height="18" cellSpacing="1" cellPadding="0" border="0">
									<TR>
										<TD><IMG height="21" src="Images/VertLine2.jpg" width="10">
										</TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('cut')" onmouseout="button_out(this);"><IMG height="19" alt="Cut" hspace="1" src="Images/Cut.gif" width="20" align="absMiddle"
													vspace="1">
											</DIV>
										</TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('copy')" onmouseout="button_out(this);"><IMG height="19" alt="Copy" hspace="1" src="Images/Copy.gif" width="20" align="absMiddle"
													vspace="1">
											</DIV>
										</TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('paste')" onmouseout="button_out(this);"><IMG height="19" alt="Paste" hspace="1" src="Images/Paste.gif" width="20" align="absMiddle"
													vspace="1">
											</DIV>
										</TD>
										<TD><IMG height="21" src="Images/VertLine.jpg" width="10">
										</TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('createLink')" onmouseout="button_out(this);"><IMG height="19" alt="Link" hspace="2" src="Images/Link.gif" width="20" align="absMiddle"
													vspace="1">
											</DIV>
										</TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('Unlink')" onmouseout="button_out(this);"><IMG height="19" alt="Unlink" hspace="2" src="Images/unlink.gif" width="20" align="absMiddle"
													vspace="1">
											</DIV>
										</TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('RemoveFormat')" onmouseout="button_out(this);"><IMG height="19" alt="Remove Format" hspace="2" src="Images/UnSelect.gif" width="20"
													align="absMiddle" vspace="1">
											</DIV>
										</TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="setImage()" onmouseout="button_out(this);"><IMG height="19" alt="Insert Image" hspace="2" src="Images/InsertImage.gif" width="20"
													align="absMiddle" vspace="1">
											</DIV>
										</TD>
										<TD><IMG height="21" src="Images/VertLine.jpg" width="10">
										</TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('bold')" onmouseout="button_out(this);"><IMG height="19" alt="Bold" hspace="1" src="Images/Bold.gif" width="20" align="absMiddle"
													vspace="1">
											</DIV>
										</TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('italic')" onmouseout="button_out(this);"><IMG height="19" alt="Italic" hspace="1" src="Images/Italic.gif" width="20" align="absMiddle"
													vspace="1">
											</DIV>
										</TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('underline')" onmouseout="button_out(this);"><IMG height="19" alt="Underline" hspace="1" src="Images/Under.gif" width="20" align="absMiddle"
													vspace="1">
											</DIV>
										</TD>
										<TD><IMG height="21" src="Images/VertLine.jpg" width="10"></TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('justifyleft')" onmouseout="button_out(this);"><IMG height="19" alt="Justify Left" hspace="1" src="Images/Left.gif" width="20" align="absMiddle"
													vspace="1">
											</DIV>
										</TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('justifycenter')" onmouseout="button_out(this);"><IMG height="19" alt="Center" hspace="1" src="Images/Center.gif" width="20" align="absMiddle"
													vspace="1">
											</DIV>
										</TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('justifyright')" onmouseout="button_out(this);"><IMG height="19" alt="Justify Right" hspace="1" src="Images/Right.gif" width="20" align="absMiddle"
													vspace="1">
											</DIV>
										</TD>
										<TD><IMG height="21" src="Images/VertLine.jpg" width="10"></TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('insertorderedlist')" onmouseout="button_out(this);"><IMG height="19" alt="Ordered List" hspace="2" src="Images/numlist.GIF" width="20" align="absMiddle"
													vspace="1">
											</DIV>
										</TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="cmdExec('insertunorderedlist')" onmouseout="button_out(this);"><IMG height="19" alt="Unordered List" hspace="2" src="Images/bullist.GIF" width="20"
													align="absMiddle" vspace="1">
											</DIV>
										</TD>
										<TD><IMG height="21" src="Images/VertLine.jpg" width="10"></TD>
										<TD>
											<DIV onmouseup="button_up(this);" class="cbtn" onmousedown="button_down(this);" onmouseover="button_over(this);"
												onclick="foreColor()" onmouseout="button_out(this);"><IMG id="BtnColor" height="19" alt="Forecolor" hspace="2" src="Images/fgcolor.gif" width="20"
													align="absMiddle" vspace="1"></DIV>
										</TD>
										<TD><IMG height="21" src="Images/VertLine.jpg" width="10"></TD>
										<TD><SELECT style="WIDTH: 80px" onchange="cmdExec('fontname',this[this.selectedIndex].value);"
												name="selfontname">
												<OPTION selected>Font</OPTION>
												<OPTION value="Arial">Arial</OPTION>
												<OPTION value="Arial Black">Arial Black</OPTION>
												<OPTION value="Arial Narrow">Arial Narrow</OPTION>
												<OPTION value="Comic Sans MS">Comic Sans MS</OPTION>
												<OPTION value="Courier New">Courier New</OPTION>
												<OPTION value="System">System</OPTION>
												<OPTION value="Tahoma">Tahoma</OPTION>
												<OPTION value="Times">Times</OPTION>
												<OPTION value="Verdana">Verdana</OPTION>
												<OPTION value="Wingdings">Wingdings</OPTION>
											</SELECT>
										</TD>
										<TD><SELECT onchange="cmdExec('fontsize',this[this.selectedIndex].value);" name="selfontsize">
												<OPTION selected>Size</OPTION>
												<OPTION value="1">1</OPTION>
												<OPTION value="2">2</OPTION>
												<OPTION value="3">3</OPTION>
												<OPTION value="4">4</OPTION>
												<OPTION value="5">5</OPTION>
												<OPTION value="6">6</OPTION>
												<OPTION value="7">7</OPTION>
												<OPTION value="8">8</OPTION>
												<OPTION value="9">9</OPTION>
												<OPTION value="10">10</OPTION>
											</SELECT>
										</TD>
										<TD><IMG height="21" src="Images/VertLine2.jpg" width="10"></TD>
									</TR>
								</TABLE>
							</TD>
						</TR>
						<TR>
							<TD height="5"></TD>
						</TR>
						<TR>
							<TD id="mam" height="180">
								<IFRAME id="NewsBody_rich" src="MsgBody.htm" width="100%" height="100%" Font-Name="Verdana">
								</IFRAME>
							</TD>
						</TR>
						<TR>
							<TD vAlign="bottom" align="left" height="20">
								<TABLE height="35" cellSpacing="0" cellPadding="0" width="100%" border="0">
									<TR>
										<TD width="8">&nbsp;</TD>
										<TD width="50"><A onclick="setMode(1,0);"><IMG height="20" src="Images/Normal_on.jpg" width="51" name="Normalbut"></A></TD>
										<TD width="50"><A onclick="setMode(0,1,1,0);"><IMG height="20" src="Images/HTML_off.jpg" width="44" name="HTMLbut"></A></TD>
										<TD>&nbsp;</TD>
										<TD>&nbsp;</TD>
									</TR>
								</TABLE>
							</TD>
						</TR>
					</TABLE>
				</asp:panel>
			</DIV>
		</form>
	</body>
</HTML>
