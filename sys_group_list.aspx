<%@ Page Language="vb" AutoEventWireup="false" Codebehind="sys_group_list.aspx.vb" Inherits="srx.sys_group_list" %>
<!DOCTYPE HTML>
<HTML>
   <HEAD>
      <!-- #include file ="html\HTMLTitle.html" -->
      <!-- #include file ="html\MetaAndLinkStylesheet.html" -->
      <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
   </HEAD>
   <!-- #include file ="html\BodyColor.html" -->
      <!-- #include file ="html\TopContainerMenu.html" -->
      <!-- #include file ="html\SideBarMenu.html" -->
      <FORM id="Form1" style="FONT: menu" method="post" runat="server">
         <!-- !PAGE CONTENT! Main Div -->
         <div id="main" class="w3-container w3-main" style="MARGIN-TOP: 43px">
            <!-- Header -->
            <div style="MARGIN-BOTTOM: 50px; PADDING-TOP: 20px">
               <h5 class="w3-left"><b><i class="fas fa-universal-access"></i>&nbsp;Group Permission</b></h5>
            </div>
            <!-- End Header -->
            <!-- #include file ="html\AlertPanel.html" -->
            <!-- Input Form -->
            <asp:panel id="panelForm" style="Z-INDEX: 0" runat="server" Visible="False">
               <DIV id="id01" class="w3-card-4" style="margin: auto;MAX-WIDTH: 600px">
						<HEADER class="w3-container w3-light-grey w3-display-container w3-responsive">												
							<%response.write("<a class='w3-hover-blue' href='sys_group_list'><span class='w3-button w3-large w3-hover-red w3-display-topright'>x</span></a>")%>
							<H2 class="w3-center">
								<asp:label id="lblMode" runat="server" Visible="true"></asp:label>
								<asp:textbox id="txtFormAction" runat="server" Visible="true"></asp:textbox></H2>
						</HEADER>
						<DIV class="w3-container w3-section w3-medium">
                     <P></P>
                     <DIV class="w3-col s6" style="WIDTH: 100px;display:none">ID:</DIV>
                     <DIV class="w3-tag w3-red w3-rest">
                        <asp:label id="txtID" runat="server" Font-Bold="True" Visible="False">0</asp:label>
                     </DIV>
                     <P></P>
                     <P></P>
                     <DIV class="w3-col s6" style="WIDTH: 100px">Code:</DIV>
                     <DIV class="w3-rest">
                        <asp:textbox tabIndex="1" id="txtCode" class="w3-input w3-medium" runat="server"
                           Placeholder="Type here..." MaxLength="10"></asp:textbox>
                        <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Width="8px" Display="Dynamic" ErrorMessage="Code must be filled."
                           ControlToValidate="txtCode">*</asp:RequiredFieldValidator>
                        <asp:regularexpressionvalidator id="RegularExpressionValidator1" runat="server" Width="8px" ErrorMessage="Invalid code format."
                           ControlToValidate="txtCode" ValidationExpression="^[A-Za-z0-9]*$">*</asp:regularexpressionvalidator>
                     </DIV>
                     <P></P>
                     <P></P>
                     <DIV class="w3-col s6" style="WIDTH: 100px">Description:</DIV>
                     <DIV class="w3-rest">
                        <asp:textbox tabIndex="2" id="txtDescription" class="w3-input w3-medium" runat="server"
                           Placeholder="Type here..." MaxLength="50"></asp:textbox>
                        <asp:RequiredFieldValidator id="Requiredfieldvalidator2" runat="server" Width="8px" Display="Dynamic" ErrorMessage="Description must be filled."
                           ControlToValidate="txtDescription">*</asp:RequiredFieldValidator>
                     </DIV>
                     <P></P>
                     <P></P>
                     <DIV class="w3-col s6" style="WIDTH: 100px;">Default Screen:</DIV>
                     <DIV class="w3-rest">
                        <asp:textbox tabIndex="3" id="txtDefault_Screen" class="w3-input w3-medium" runat="server"
                           Placeholder="Type here..." MaxLength="50"></asp:textbox>
                     </DIV>
                     <P></P>
                  </DIV>
                  <FOOTER class="w3-container"> <!-- #include file ="html\btnSave-btnCancel-lblMessage.html" --></FOOTER>
               </DIV>
            </asp:panel>
            <!-- End Input Form -->
            <!-- PanelMenu -->
            <asp:panel id="PanelMenu" style="Z-INDEX: 0" runat="server" Visible="False">
               <!-- Group Menu Header -->
               <DIV class="w3-container w3-win8-blue w3-padding-32">
                  <DIV class="w3-row">
                     <H5 class="w3-bottombar w3-border-khaki"><B><I class="fa fa-newspaper-o"></I>&nbsp;Group 
                        Menu Permission</B>
                     </H5>
                     <DIV class="w3-container w3-third">
                        <P>
                           Group Code:&nbsp;
                           <asp:Label id="lblCode" runat="server" Font-Bold="True"></asp:Label>
                           &nbsp; (
                           <asp:Label id="lblID" runat="server" Font-Bold="True"></asp:Label>
                           )
                        </P>
                     </DIV>
                     <DIV class="w3-container w3-third">
                        <P>
                           Description:&nbsp;
                           <asp:Label id="lblDescription" runat="server" Font-Bold="True" Width="100%">Label</asp:Label>
                        </P>
                     </DIV>
                     <DIV class="w3-container w3-third">
                        <P>
                           Default Screen:&nbsp;
                           <asp:Label id="lblDefault_Screen" runat="server" Font-Bold="True" Width="100%">Label</asp:Label>
                        </P>
                     </DIV>
                  </DIV>
               </DIV>
               <!-- End Group Menu Header -->
               <DIV class="w3-container w3-padding-32">
                  <DIV class="w3-container w3-row">
                     <DIV class="w3-quarter">
                        <P>
                           <B>View</B>
                           <asp:CheckBox id="chkAllList" runat="server" Text="Select All"></asp:CheckBox>
                        </P>
                        <P>
                           <asp:CheckBoxList id="cblList" runat="server" RepeatColumns="1"></asp:CheckBoxList>
                        </P>
                     </DIV>
                     <DIV class="w3-quarter">
                        <P>
                           <B>Add</B>
                           <asp:CheckBox id="chkAllAdd" runat="server" Text="Select All"></asp:CheckBox>
                        </P>
                        <P>
                           <asp:CheckBoxList id="cblAdd" runat="server" RepeatColumns="1"></asp:CheckBoxList>
                        </P>
                     </DIV>
                     <DIV class="w3-quarter">
                        <P>
                           <B>Edit</B>
                           <asp:CheckBox id="chkAllEdit" runat="server" Text="Select All"></asp:CheckBox>
                        </P>
                        <P>
                           <asp:CheckBoxList id="cblEdit" runat="server" RepeatColumns="1"></asp:CheckBoxList>
                        </P>
                     </DIV>
                     <DIV class="w3-quarter">
                        <P>
                           <B>Delete</B>
                           <asp:CheckBox id="chkAllDelete" runat="server" Text="Select All"></asp:CheckBox>
                        </P>
                        <P>
                           <asp:CheckBoxList id="cblDelete" runat="server" RepeatColumns="1"></asp:CheckBoxList>
                        </P>
                     </DIV>
                  </DIV>
                  <asp:Label id="lblMenuMessage" runat="server" Width="312px" Height="6px" ForeColor="Red">lblMenuMessage</asp:Label>
                  <BR>
                  <asp:Button id="btnMenuOK" runat="server" Width="69px" Text="OK" CssClass="Class: w3-btn w3-ripple w3-teal w3-bar-item w3-mobile"></asp:Button>
                  &nbsp;&nbsp;&nbsp;
                  <asp:Button id="btnMenuCancel" runat="server" Text="Cancel" CssClass="Class: w3-btn w3-ripple w3-red w3-bar-item w3-mobile"></asp:Button>
               </DIV>
            </asp:panel>
            <!-- End PanelMenu -->
            <!-- PanelAccount -->
            <asp:panel id="PanelAccount" style="Z-INDEX: 0" runat="server" Visible="False">
               <!-- Group Account Header -->
               <DIV class="w3-container w3-win8-blue w3-padding-32">
                  <DIV class="w3-row">
                     <H5 class="w3-bottombar w3-border-khaki"><B><I class="fas fa-user-circle"></I>&nbsp;Group 
                        Account Permission</B>
                     </H5>
                     <DIV class="w3-container w3-third">
                        <P>
                           Group Code:&nbsp;
                           <asp:Label id="lblAccountCode" runat="server" Font-Bold="True"></asp:Label>
                           &nbsp; 
                           (
                           <asp:Label id="lblAccountID" runat="server" Font-Bold="True"></asp:Label>
                           )
                        </P>
                     </DIV>
                     <DIV class="w3-container w3-third">
                        <P>
                           Description:&nbsp;
                           <asp:Label id="lblAccountDescription" runat="server" Font-Bold="True" Width="100%">Label</asp:Label>
                        </P>
                     </DIV>
                     <DIV class="w3-container w3-third">
                        <P>
                           Default Screen:&nbsp;
                           <asp:Label id="lblAccountDefault_Screen" runat="server" Font-Bold="True" Width="100%">Label</asp:Label>
                        </P>
                     </DIV>
                  </DIV>
               </DIV>
               <!-- End Group Account Header -->
               <DIV class="w3-container w3-padding-32">
                  <P class="w3-center">
                     <B>Select Client:</B>
                     <asp:dropdownlist id="ddlAccount" class="w3-padding" runat="server" type="text" AutoPostBack="True"
                        width="50%"></asp:dropdownlist>
                  </P>
                  <DIV class="w3-bar-item">
                     <P><B>Check Account Access:</B>
                     </P>
                     <P>
                        <asp:CheckBoxList id="cblAccount" runat="server" Width="500px" Height="0%" RepeatColumns="1"></asp:CheckBoxList>
                     </P>
                  </DIV>
               </DIV>
               <asp:Label id="lblAccountMessage" runat="server" Width="750px" Height="6px" ForeColor="Red">lblAccountMessage</asp:Label>
               <BR><BR>
               <asp:Button id="btnAccountOK" runat="server" Width="69px" Text="OK" CssClass="Class: w3-btn w3-ripple w3-teal w3-bar-item w3-mobile"></asp:Button>
               &nbsp;&nbsp;&nbsp; 
               <asp:Button id="btnAccountCancel" runat="server" Text="Cancel" CssClass="Class: w3-btn w3-ripple w3-red w3-bar-item w3-mobile"></asp:Button>
            </asp:panel>
            <!-- End PanelAccount -->
            <br>
            <!-- #include file ="html\SearchAndButtons.html" -->
            <!-- Sys Group Table -->
            <div class="w3-responsive">
               <TABLE id="tblGroupList" class="w3-table-all w3-hoverable" cellSpacing="0" cellPadding="2"
                  border="0">
                  <tr>
                     <th>
                        <asp:datagrid id="DataGrid" runat="server" CellPadding="3" Width="100%" Height="24px" BackColor="White"
                           BorderWidth="1px" BorderColor="#999999" AllowSorting="True" GridLines="Vertical" BorderStyle="None">
                           <FooterStyle ForeColor="Black" BackColor="#CCCCCC"></FooterStyle>
                           <SelectedItemStyle Font-Bold="True" ForeColor="Black" CssClass="w3-pale-blue" BackColor="Green"></SelectedItemStyle>
                           <EditItemStyle></EditItemStyle>
                           <AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
                           <ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
                           <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#708090"></HeaderStyle>
                           <Columns>
                              <asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Cancel" EditText="Edit"></asp:EditCommandColumn>
                              <asp:ButtonColumn Text="Delete" CommandName="Delete"></asp:ButtonColumn>
                              <asp:ButtonColumn Text="Menu" CommandName="Menu"></asp:ButtonColumn>
                           </Columns>
                           <PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
                        </asp:datagrid>
                     </th>
                  </tr>
               </TABLE>
            </div>
            <!-- End Sys Group Table -->
         </div>
         <!-- End !PAGE CONTENT! Main Div -->
         <!-- End Div Main -->
      </FORM>
      <script src="js/MyJS.js"></script>
      <script>
         // Function for Datagrid Tables
         function filterTable(event) {
         	var filter = event.target.value.toUpperCase();
         	var rows = document.querySelector("#DataGrid tbody").rows;
         	
         	for (var i = 0; i < rows.length; i++) {					
         		var fourthCol = rows[i].cells[4].textContent.toUpperCase();
         		var fifthCol = rows[i].cells[5].textContent.toUpperCase();
         		var sixthCol = rows[i].cells[6].textContent.toUpperCase();
         		if (fourthCol.indexOf(filter) > -1 || fifthCol.indexOf(filter) > -1 || sixthCol.indexOf(filter) > -1) {
         			rows[i].style.display = "";
         		} else {
         			rows[i].style.display = "none";
         		}      
         	}
         }
         
         document.querySelector('#myInput').addEventListener('keyup', filterTable, false);
      </script>
      <script type="text/javascript">
         $(function () {
         	$("[id*=chkAllList]").bind("click", function () {
         		if ($(this).is(":checked")) {
         			$("[id*=cblList] input").attr("checked", "checked");
         		} else {
         			$("[id*=cblList] input").removeAttr("checked");
         		}
         	});
         	$("[id*=cblList] input").bind("click", function () {
         		if ($("[id*=cblList] input:checked").length == $("[id*=cblList] input").length) {
         			$("[id*=chkAllList]").attr("checked", "checked");
         		} else {
         			$("[id*=chkAllList]").removeAttr("checked");
         		}
         	});
         	
         	$("[id*=chkAllAdd]").bind("click", function () {
         		if ($(this).is(":checked")) {
         			$("[id*=cblAdd] input").attr("checked", "checked");
         		} else {
         			$("[id*=cblAdd] input").removeAttr("checked");
         		}
         	});
         	$("[id*=cblAdd] input").bind("click", function () {
         		if ($("[id*=cblAdd] input:checked").length == $("[id*=cblAdd] input").length) {
         			$("[id*=chkAllAdd]").attr("checked", "checked");
         		} else {
         			$("[id*=chkAllAdd]").removeAttr("checked");
         		}
         	});
         	
         	$("[id*=chkAllEdit]").bind("click", function () {
         		if ($(this).is(":checked")) {
         			$("[id*=cblEdit] input").attr("checked", "checked");
         		} else {
         			$("[id*=cblEdit] input").removeAttr("checked");
         		}
         	});
         	$("[id*=cblEdit] input").bind("click", function () {
         		if ($("[id*=cblEdit] input:checked").length == $("[id*=cblEdit] input").length) {
         			$("[id*=chkAllEdit]").attr("checked", "checked");
         		} else {
         			$("[id*=chkAllEdit]").removeAttr("checked");
         		}
         	});
         	
         	$("[id*=chkAllDelete]").bind("click", function () {
         		if ($(this).is(":checked")) {
         			$("[id*=cblDelete] input").attr("checked", "checked");
         		} else {
         			$("[id*=cblDelete] input").removeAttr("checked");
         		}
         	});
         	$("[id*=cblDelete] input").bind("click", function () {
         		if ($("[id*=cblDelete] input:checked").length == $("[id*=cblDelete] input").length) {
         			$("[id*=chkAllDelete]").attr("checked", "checked");
         		} else {
         			$("[id*=chkAllDelete]").removeAttr("checked");
         		}
         	});
         });
      </script>
   </body>
</HTML>