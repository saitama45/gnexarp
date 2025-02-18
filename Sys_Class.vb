Imports System.data
Imports System.Data.SqlClient
Imports System.Web.SessionState
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Imports System.Web.UI.Page


Public Class Sys_Class
    Inherits System.Web.UI.Page

    Public Shared Sub TopMenu(ByVal lblCompanyName As Label, _
                              ByVal TopMenuCategories As HtmlGenericControl, _
                              ByVal sessionNoLoginClient_Cookie As String, _
                              ByVal lblTotalItemSRP As Label, _
                              ByVal lblTotalItemCount As Label)

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Ref_Categories_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@id", 0)

        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        Dim ItemCategory As String = String.Empty

        While objReader.Read

            ItemCategory &= ("<li><a class='w3-hover-blue' href='item_category?&id=" & Trim(objReader("id")) & "'>" & Trim(objReader("name")) & "</a></li>")

        End While

        TopMenuCategories.InnerHtml = ItemCategory

        objReader.Close()

        objCommand = New SqlCommand("Web_ItemsCount_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@user_id", sessionNoLoginClient_Cookie)

        objReader = objCommand.ExecuteReader
        objReader.Read()

        lblCompanyName.Text = Trim(objReader("company_name"))
        lblTotalItemCount.Text = Trim(objReader("totalItemCount"))
        lblTotalItemSRP.Text = Trim(objReader("totalSRP"))

        objReader.Close()
        objConnection.Close()
    End Sub
    
    Public Shared Sub DisplaySideBarMenu(ByVal lblUser As Label, _
                                        ByVal lblUserTab As Label, _
                                        ByVal lblCompanyName As HtmlGenericControl, _
                                        ByVal sessionSysGroup As String, _
                                        ByVal lblDashboard As Label, _
                                        ByVal panelDashboard As Panel, _
                                        ByVal tblDashboard As Table, _
                                        ByVal lblPO As Label, _
                                        ByVal panelPO As Panel, _
                                        ByVal tblPO As Table, _
                                        ByVal lblMyAccount As Label, _
                                        ByVal panelMyAccount As Panel, _
                                        ByVal tblMyAccount As Table, _
                                        ByVal lblAR As Label, _
                                        ByVal panelAR As Panel, _
                                        ByVal tblAR As Table, _
                                        ByVal lblDR As Label, _
                                        ByVal panelDR As Panel, _
                                        ByVal tblDR As Table, _
                                        ByVal lblInvoice As Label, _
                                        ByVal panelInvoice As Panel, _
                                        ByVal tblInvoice As Table, _
                                        ByVal lblReference As Label, _
                                        ByVal panelReference As Panel, _
                                        ByVal tblReference As Table, _
                                        ByVal lblReports As Label, _
                                        ByVal panelReports As Panel, _
                                        ByVal tblReports As Table, _
                                        ByVal lblSetting As Label, _
                                        ByVal panelSetting As Panel, _
                                        ByVal tblSetting As Table, _
                                        ByVal lblMenu1 As Label, _
                                        ByVal panelMenu1 As Panel, _
                                        ByVal tblMenu1 As Table, _
                                        ByVal lblMenu2 As Label, _
                                        ByVal panelMenu2 As Panel, _
                                        ByVal tblMenu2 As Table, _
                                        ByVal lblMenu3 As Label, _
                                        ByVal panelMenu3 As Panel, _
                                        ByVal tblMenu3 As Table, _
                                        ByVal lblMenu4 As Label, _
                                        ByVal panelMenu4 As Panel, _
                                        ByVal tblMenu4 As Table, _
                                        ByVal lblMenu5 As Label, _
                                        ByVal panelMenu5 As Panel, _
                                        ByVal tblMenu5 As Table, _
                                        ByVal lblCountNotif As Label, _
                                        ByVal tblNotif As Table)
        'Function will display side bar menu and the access permission if the user is allowed

        'request the cookie from the user's pc
        Dim objCookie As HttpCookie = HttpContext.Current.Request.Cookies(ConfigurationSettings.AppSettings("appName"))

        ' load values to textboxes if cookie exist 
        If Not IsNothing(objCookie) Then
            lblUser.Text = objCookie.Values("Fullname")
            lblUserTab.Text = objCookie.Values("Fullname")
            'lblPrompt.Text = "Welcome back " & objCookie.Values("Fullname") & "! Your last visit was on " & objCookie.Values("LastVisit")

            Dim htmlCompanyName As String = String.Empty
            htmlCompanyName = objCookie.Values("CompanyName")
            lblCompanyName.InnerHtml = htmlCompanyName
        End If

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Sys_Menu_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Sys_Group", sessionSysGroup)
        'objCommand.Parameters.Add("@Session_username", objCookie.Values("UserName"))

        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        Dim strCurrentMainMenu As String = ""

        Dim aAccessList As New ArrayList

        While objReader.Read

            Dim tblRow As New TableRow
            Dim tblCell As New TableCell

            Dim strLink_Parameter As String = Trim(objReader("link_parameter"))

            If Trim(objReader("main_menu")) = lblDashboard.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    panelDashboard.Visible = True

                    tblCell.Text = "<a class=""w3-bar-item w3-button w3-large w3-center sidebarcolor w3-hover-blue"" href=" & Trim(objReader("link_page")) & strLink_Parameter & "><i class=""fas fa-chart-line""></i>&nbsp;&nbsp;" & Trim(objReader("main_menu")) & "</a>"
                    tblCell.ToolTip = Trim(objReader("main_menu"))

                    tblRow.Cells.Add(tblCell)
                    tblDashboard.Rows.Add(tblRow)

                Else
                    panelDashboard.Visible = False

                End If

            End If

            If Trim(objReader("main_menu")) = lblPO.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    panelPO.Visible = True

                    tblCell.Text = "<a class=""w3-bar-item w3-btn w3-hover-pale-blue"" href=" & Trim(objReader("link_page")) & strLink_Parameter & ">" & Trim(objReader("sub_menu")) & "</a>"
                    tblCell.ToolTip = Trim(objReader("main_menu")) & " | " & Trim(objReader("sub_menu"))

                    tblRow.Cells.Add(tblCell)
                    tblPO.Rows.Add(tblRow)

                Else
                    panelPO.Visible = False

                End If

            End If

            If Trim(objReader("main_menu")) = lblAR.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    panelAR.Visible = True

                    tblCell.Text = "<a class=""w3-bar-item w3-btn w3-hover-pale-blue"" href=" & Trim(objReader("link_page")) & strLink_Parameter & ">" & Trim(objReader("sub_menu")) & "</a>"
                    tblCell.ToolTip = Trim(objReader("main_menu")) & " | " & Trim(objReader("sub_menu"))

                    tblRow.Cells.Add(tblCell)
                    tblAR.Rows.Add(tblRow)

                Else
                    panelAR.Visible = False

                End If

            End If

            If Trim(objReader("main_menu")) = lblDR.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    panelDR.Visible = True

                    tblCell.Text = "<a class=""w3-bar-item w3-btn w3-hover-pale-blue"" href=" & Trim(objReader("link_page")) & strLink_Parameter & ">" & Trim(objReader("sub_menu")) & "</a>"
                    tblCell.ToolTip = Trim(objReader("main_menu")) & " | " & Trim(objReader("sub_menu"))

                    tblRow.Cells.Add(tblCell)
                    tblDR.Rows.Add(tblRow)

                Else
                    panelDR.Visible = False

                End If

            End If

            If Trim(objReader("main_menu")) = lblMyAccount.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    panelMyAccount.Visible = True

                    tblCell.Text = "<a class=""w3-bar-item w3-btn w3-hover-pale-blue"" href=" & Trim(objReader("link_page")) & strLink_Parameter & ">" & Trim(objReader("sub_menu")) & "</a>"
                    tblCell.ToolTip = Trim(objReader("main_menu")) & " | " & Trim(objReader("sub_menu"))

                    tblRow.Cells.Add(tblCell)
                    tblMyAccount.Rows.Add(tblRow)

                Else
                    panelMyAccount.Visible = False

                End If

            End If

            If Trim(objReader("main_menu")) = lblInvoice.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    panelInvoice.Visible = True

                    tblCell.Text = "<a class=""w3-bar-item w3-btn w3-hover-pale-blue"" href=" & Trim(objReader("link_page")) & strLink_Parameter & ">" & Trim(objReader("sub_menu")) & "</a>"
                    tblCell.ToolTip = Trim(objReader("main_menu")) & " | " & Trim(objReader("sub_menu"))

                    tblRow.Cells.Add(tblCell)
                    tblInvoice.Rows.Add(tblRow)

                Else
                    panelInvoice.Visible = False

                End If

            End If

            If Trim(objReader("main_menu")) = lblReference.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    panelReference.Visible = True

                    tblCell.Text = "<a class=""w3-bar-item w3-btn w3-hover-pale-blue"" href=" & Trim(objReader("link_page")) & strLink_Parameter & ">" & Trim(objReader("sub_menu")) & "</a>"
                    tblCell.ToolTip = Trim(objReader("main_menu")) & " | " & Trim(objReader("sub_menu"))

                    tblRow.Cells.Add(tblCell)
                    tblReference.Rows.Add(tblRow)
                Else

                    panelReference.Visible = False

                End If

            End If

            If Trim(objReader("main_menu")) = lblReports.Text Then

                If Trim(objReader("link_page")) <> "" Then

                    panelReports.Visible = True

                    tblCell.Text = "<a class=""w3-bar-item w3-btn w3-hover-pale-blue"" href=" & Trim(objReader("link_page")) & strLink_Parameter & ">" & Trim(objReader("sub_menu")) & "</a>"
                    tblCell.ToolTip = Trim(objReader("main_menu")) & " | " & Trim(objReader("sub_menu"))

                    tblRow.Cells.Add(tblCell)
                    tblReports.Rows.Add(tblRow)
                Else

                    panelReports.Visible = False
                End If

            End If

            If Trim(objReader("main_menu")) = lblMenu1.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    panelMenu1.Visible = True

                    tblCell.Text = "<a class=""w3-bar-item w3-btn w3-hover-pale-blue"" href=" & Trim(objReader("link_page")) & strLink_Parameter & ">" & Trim(objReader("sub_menu")) & "</a>"
                    tblCell.ToolTip = Trim(objReader("main_menu")) & " | " & Trim(objReader("sub_menu"))

                    tblRow.Cells.Add(tblCell)
                    tblMenu1.Rows.Add(tblRow)

                Else

                    panelMenu1.Visible = False

                End If

            End If

            If Trim(objReader("main_menu")) = lblMenu2.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    panelMenu2.Visible = True

                    tblCell.Text = "<a class=""w3-bar-item w3-btn w3-hover-pale-blue"" href=" & Trim(objReader("link_page")) & strLink_Parameter & ">" & Trim(objReader("sub_menu")) & "</a>"
                    tblCell.ToolTip = Trim(objReader("main_menu")) & " | " & Trim(objReader("sub_menu"))

                    tblRow.Cells.Add(tblCell)
                    tblMenu2.Rows.Add(tblRow)

                Else

                    panelMenu2.Visible = False

                End If

            End If

            If Trim(objReader("main_menu")) = lblSetting.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    panelSetting.Visible = True

                    tblCell.Text = "<a class=""w3-bar-item w3-btn w3-hover-pale-blue"" href=" & Trim(objReader("link_page")) & strLink_Parameter & ">" & Trim(objReader("sub_menu")) & "</a>"
                    tblCell.ToolTip = Trim(objReader("main_menu")) & " | " & Trim(objReader("sub_menu"))

                    tblRow.Cells.Add(tblCell)
                    tblSetting.Rows.Add(tblRow)

                Else

                    panelSetting.Visible = False

                End If

            End If

            'user is allowed to view this menu code
            aAccessList.Add(Trim(objReader("code")) & "_access")

            'if user is allowed to perform add
            If objReader("add_mode") Then
                aAccessList.Add(Trim(objReader("code")) & "_add")
            End If

            'if user is allowed to perform edit
            If objReader("edit_mode") Then
                aAccessList.Add(Trim(objReader("code")) & "_edit")
            End If

            'if user is allowed to perform delete
            If objReader("delete_mode") Then
                aAccessList.Add(Trim(objReader("code")) & "_delete")
            End If

        End While

        'close, reopen immediately
        objReader.Close()

        'get the special access at sys_special_access
        objCommand = New SqlCommand("Sys_Special_Access_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Sys_Group", sessionSysGroup)

        objReader = objCommand.ExecuteReader

        While objReader.Read
            aAccessList.Add(Trim(objReader("sys_menu")) & "_" & Trim(objReader("special_access")))
        End While

        HttpContext.Current.Session("Sys_AccessList") = aAccessList

        objReader.Close()

        'get the special access at sys_special_access
        objCommand = New SqlCommand("Sys_Notif2_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", 0)
        objCommand.Parameters.Add("@Session_username", objCookie.Values("UserName"))

        objReader = objCommand.ExecuteReader

        While objReader.Read

            Dim tblRow2 As New TableRow
            Dim tblCell2 As New TableCell

            'tblCell2.Text = "<a class=""w3-bar-item w3-small w3-button w3-hover-blue"" target=""_blank"" href=""rep_for_service"">" & Trim(objReader("notif")) & "</a>"
            tblCell2.Text = Trim(objReader("notif"))

            tblRow2.Cells.Add(tblCell2)
            tblNotif.Rows.Add(tblRow2)

        End While
        objReader.Close()

        'get the special access at sys_special_access
        objCommand = New SqlCommand("Sys_Notif3_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", 0)
        objCommand.Parameters.Add("@Session_username", objCookie.Values("UserName"))

        objReader = objCommand.ExecuteReader
        objReader.Read()

        lblCountNotif.Text = Trim(objReader("total_count"))

        objReader.Close()
        objConnection.Close()

    End Sub    

    Public Shared Sub ReadyInput(ByVal PanelBrowse As Panel, _
                            ByVal PanelRecord As Panel, _
                            ByVal lblMessage As Label, _
                            ByVal ValidationSummary1 As ValidationSummary, _
                            ByVal lblMode As Label, _
                            ByVal txtFormAction As TextBox)
        'function shows the panel record for adding|editing|deleting

        'hide the browse panel
        PanelBrowse.Visible = False

        'show the record panel
        PanelRecord.Visible = True
        PanelRecord.Enabled = True
        lblMessage.Visible = False
        ValidationSummary1.Visible = True

        'set the value based on desired action
        lblMode.Text = "<< " & txtFormAction.Text & " record >>"
    End Sub
    Public Shared Sub ReadyForm(ByVal panelForm As Panel, _
                            ByVal panelSuccess As Panel, _
                            ByVal panelInfo As Panel, _
                            ByVal lblNotify As Label, _
                            ByVal ValidationSummary1 As ValidationSummary, _
                            ByVal lblMode As Label, _
                            ByVal txtFormAction As TextBox)
        'function shows the panel record for adding|editing|deleting                

        'show the form panel
        panelForm.Visible = True
        panelSuccess.Visible = False
        panelInfo.Visible = False

        lblNotify.Visible = False
        ValidationSummary1.Visible = True

        'set the value based on desired action
        lblMode.Text = txtFormAction.Text & " Record"
    End Sub
    Public Shared Sub ReadyOutletForm(ByVal panelOutlet As Panel, _
                            ByVal panelSuccess As Panel, _
                            ByVal panelInfo As Panel, _
                            ByVal lblNotify As Label, _
                            ByVal ValidationSummary2 As ValidationSummary, _
                            ByVal lblModeOutlet As Label, _
                            ByVal txtFormActionOutlet As TextBox)
        'function shows the panel record for adding|editing|deleting                

        'show the form panel
        panelOutlet.Visible = True
        panelSuccess.Visible = False
        panelInfo.Visible = False

        lblNotify.Visible = False
        ValidationSummary2.Visible = True

        'set the value based on desired action
        lblModeOutlet.Text = "<< " & txtFormActionOutlet.Text & " Record >>"
    End Sub

    Public Shared Sub BindGrid_SetDisplay(ByVal DataGrid As DataGrid, _
                                            ByVal strStoredProc As String, _
                                            ByVal session_SortKey As String, _
                                            ByVal strKeyField As String, _
                                            ByVal btnFirst As Button, _
                                            ByVal btnPrevious As Button, _
                                            ByVal btnNext As Button, _
                                            ByVal btnLast As Button, _
                                            ByVal txtPageNo As TextBox, _
                                            ByVal txtMorePage As TextBox, _
                                            ByVal ddlRecordsPerPage As DropDownList, _
                                            ByVal txtSearch As TextBox, _
                                            ByVal lblPageRecordCount As Label, _
                                            Optional ByVal intHeaderLink As String = Nothing)

        'ian@2004/11/02 originally accepts integer only, intHeaderLink must not accomodate other types
        'Optional ByVal intHeaderLink As integer= 0

        'binds the passed grid and set the buttons, labels and textboxes of the calling page

        'the connection 
        Dim strConnection As String = ConfigurationSettings.AppSettings("appConn")
        Dim objConnection As New SqlConnection(strConnection)

        'the stored proc
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@pPageNo", txtPageNo.Text)
        objCommand.Parameters.Add("@pRowPerPage", ddlRecordsPerPage.SelectedValue)

        'code for passing "*" on the aSortKeys() array
        'if the passed sortkey has the "*" char
        If Left(session_SortKey, 1) = "*" Then

            'trim the "*"
            objCommand.Parameters.Add("@pSortKey", Mid(session_SortKey, 2))
            If Trim(txtSearch.Text) <> "" Then
                'disable the searching when that field is non-searachable
                txtSearch.Text = ""
            End If
        Else

            objCommand.Parameters.Add("@pSortKey", session_SortKey)
        End If

        objCommand.Parameters.Add("@pSearchKey", txtSearch.Text.ToString)

        'if there is a keyfield filter specified
        'ian@2004/11/02 originally accepts integer only, intHeaderLink must not accomodate other types
        'If intHeaderLink <> 0 Then
        '    objCommand.Parameters.Add("@pKeyFieldFilter", intHeaderLink)
        'End If
        If intHeaderLink <> Nothing Then
            objCommand.Parameters.Add("@pKeyFieldFilter", intHeaderLink)
        End If


        'stored proc output parameter: @outMoreRecords
        Dim objOutputParam1 As New SqlParameter("@outMoreRecords", SqlDbType.Int)
        objCommand.Parameters.Add(objOutputParam1)
        objOutputParam1.Direction = ParameterDirection.Output

        'stored proc output parameter: @outPageNo
        Dim objOutputParam2 As New SqlParameter("@outPageNo", SqlDbType.SmallInt)
        objCommand.Parameters.Add(objOutputParam2)
        objOutputParam2.Direction = ParameterDirection.Output

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'bind the grid to the reader
        DataGrid.DataSource = objReader

        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
        'reopen connection and execute the non query 
        objConnection.Open()
        objCommand.ExecuteNonQuery()

        ' get the more MoreRecords (as the last column)
        ' from the first item of the grid
        If DataGrid.Items.Count = 0 Then
            txtMorePage.Text = 0
        Else
            txtMorePage.Text = Math.Ceiling(Val(Val(objOutputParam1.Value) / (ddlRecordsPerPage.SelectedValue)))
        End If

        'when txtPageNo.Text = 0 (intention to display the last page) get the real page 
        'no as returned from the resultset
        If txtPageNo.Text = 0 Then
            txtPageNo.Text = Val(objOutputParam2.Value)
        End If

        'set the nav buttons visibility
        btnFirst.Enabled = (txtPageNo.Text > 1)
        btnPrevious.Enabled = (txtPageNo.Text > 1)
        btnNext.Enabled = (txtMorePage.Text > 0)
        btnLast.Enabled = (txtMorePage.Text > 0)

        'set the "Records in this page" and the Page X of Y
        lblPageRecordCount.Text = "Record(s) in this page: " & DataGrid.Items.Count.ToString & ". " & _
                                    "Page " & txtPageNo.Text & " of " & (Val(txtPageNo.Text) + Val(txtMorePage.Text)) & ". "

        'close connection
        objConnection.Close()

    End Sub

    Public Shared Sub BindGrid_SetDisplay_v2(ByVal DataGrid As DataGrid, _
                                                ByVal strStoredProc As String, _
                                                ByVal session_username As String, _
                                                ByVal session_SortKey As String, _
                                                ByVal strKeyField As String, _
                                                ByVal btnFirst As Button, _
                                                ByVal btnPrevious As Button, _
                                                ByVal btnNext As Button, _
                                                ByVal btnLast As Button, _
                                                ByVal txtPageNo As TextBox, _
                                                ByVal txtMorePage As TextBox, _
                                                ByVal ddlRecordsPerPage As DropDownList, _
                                                ByVal txtSearch As TextBox, _
                                                ByVal lblPageRecordCount As Label, _
                                                Optional ByVal intHeaderLink As String = Nothing)

        'ian@2004/11/02 originally accepts integer only, intHeaderLink must not accomodate other types
        'Optional ByVal intHeaderLink As integer= 0

        'binds the passed grid and set the buttons, labels and textboxes of the calling page

        'the connection 
        Dim strConnection As String = ConfigurationSettings.AppSettings("appConn")
        Dim objConnection As New SqlConnection(strConnection)

        'the stored proc
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", session_username)
        objCommand.Parameters.Add("@pPageNo", txtPageNo.Text)
        objCommand.Parameters.Add("@pRowPerPage", ddlRecordsPerPage.SelectedValue)

        'code for passing "*" on the aSortKeys() array
        'if the passed sortkey has the "*" char
        If Left(session_SortKey, 1) = "*" Then

            'trim the "*"
            objCommand.Parameters.Add("@pSortKey", Mid(session_SortKey, 2))
            If Trim(txtSearch.Text) <> "" Then
                'disable the searching when that field is non-searachable
                txtSearch.Text = ""
            End If
        Else

            objCommand.Parameters.Add("@pSortKey", session_SortKey)
        End If

        objCommand.Parameters.Add("@pSearchKey", txtSearch.Text.ToString)

        'if there is a keyfield filter specified
        'ian@2004/11/02 originally accepts integer only, intHeaderLink must not accomodate other types
        'If intHeaderLink <> 0 Then
        '    objCommand.Parameters.Add("@pKeyFieldFilter", intHeaderLink)
        'End If
        If intHeaderLink <> Nothing Then
            objCommand.Parameters.Add("@pKeyFieldFilter", intHeaderLink)
        End If


        'stored proc output parameter: @outMoreRecords
        Dim objOutputParam1 As New SqlParameter("@outMoreRecords", SqlDbType.Int)
        objCommand.Parameters.Add(objOutputParam1)
        objOutputParam1.Direction = ParameterDirection.Output

        'stored proc output parameter: @outPageNo
        Dim objOutputParam2 As New SqlParameter("@outPageNo", SqlDbType.Int)
        objCommand.Parameters.Add(objOutputParam2)
        objOutputParam2.Direction = ParameterDirection.Output

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'bind the grid to the reader
        DataGrid.DataSource = objReader

        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
        'reopen connection and execute the non query 
        objConnection.Open()
        objCommand.ExecuteNonQuery()

        ' get the more MoreRecords (as the last column)
        ' from the first item of the grid
        If DataGrid.Items.Count = 0 Then
            txtMorePage.Text = 0
        Else
            txtMorePage.Text = Math.Ceiling(Val(Val(objOutputParam1.Value) / (ddlRecordsPerPage.SelectedValue)))
        End If

        'when txtPageNo.Text = 0 (intention to display the last page) get the real page 
        'no as returned from the resultset
        If txtPageNo.Text = 0 Then
            txtPageNo.Text = Val(objOutputParam2.Value)
        End If

        'set the nav buttons visibility
        btnFirst.Enabled = (txtPageNo.Text > 1)
        btnPrevious.Enabled = (txtPageNo.Text > 1)
        btnNext.Enabled = (txtMorePage.Text > 0)
        btnLast.Enabled = (txtMorePage.Text > 0)

        'set the "Records in this page" and the Page X of Y
        lblPageRecordCount.Text = "Record(s) in this page: " & DataGrid.Items.Count.ToString & ". " & _
                                    "Page " & txtPageNo.Text & " of " & (Val(txtPageNo.Text) + Val(txtMorePage.Text)) & ". "

        'close connection
        objConnection.Close()

    End Sub
    Public Shared Sub BindGrid_SetDisplay_v4(ByVal DataGrid As DataGrid, _
                                                ByVal strStoredProc As String, _
                                                ByVal session_username As Integer, _
                                                ByVal session_SortKey As String, _
                                                ByVal strKeyField As String, _
                                                ByVal btnFirst As Button, _
                                                ByVal btnPrevious As Button, _
                                                ByVal btnNext As Button, _
                                                ByVal btnLast As Button, _
                                                ByVal txtPageNo As TextBox, _
                                                ByVal txtMorePage As TextBox, _
                                                ByVal ddlRecordsPerPage As DropDownList, _
                                                ByVal txtSearch As TextBox, _
                                                ByVal lblPageRecordCount As Label, _
                                                Optional ByVal intHeaderLink As String = Nothing)

        'ian@2004/11/02 originally accepts integer only, intHeaderLink must not accomodate other types
        'Optional ByVal intHeaderLink As integer= 0

        'binds the passed grid and set the buttons, labels and textboxes of the calling page

        'the connection 
        Dim strConnection As String = ConfigurationSettings.AppSettings("appConn")
        Dim objConnection As New SqlConnection(strConnection)

        'the stored proc
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", session_username)
        objCommand.Parameters.Add("@pPageNo", txtPageNo.Text)
        objCommand.Parameters.Add("@pRowPerPage", ddlRecordsPerPage.SelectedValue)

        'code for passing "*" on the aSortKeys() array
        'if the passed sortkey has the "*" char
        If Left(session_SortKey, 1) = "*" Then

            'trim the "*"
            objCommand.Parameters.Add("@pSortKey", Mid(session_SortKey, 2))
            If Trim(txtSearch.Text) <> "" Then
                'disable the searching when that field is non-searachable
                txtSearch.Text = ""
            End If
        Else

            objCommand.Parameters.Add("@pSortKey", session_SortKey)
        End If

        objCommand.Parameters.Add("@pSearchKey", txtSearch.Text.ToString)

        'if there is a keyfield filter specified
        'ian@2004/11/02 originally accepts integer only, intHeaderLink must not accomodate other types
        'If intHeaderLink <> 0 Then
        '    objCommand.Parameters.Add("@pKeyFieldFilter", intHeaderLink)
        'End If
        If intHeaderLink <> Nothing Then
            objCommand.Parameters.Add("@pKeyFieldFilter", intHeaderLink)
        End If


        'stored proc output parameter: @outMoreRecords
        Dim objOutputParam1 As New SqlParameter("@outMoreRecords", SqlDbType.Int)
        objCommand.Parameters.Add(objOutputParam1)
        objOutputParam1.Direction = ParameterDirection.Output

        'stored proc output parameter: @outPageNo
        Dim objOutputParam2 As New SqlParameter("@outPageNo", SqlDbType.Int)
        objCommand.Parameters.Add(objOutputParam2)
        objOutputParam2.Direction = ParameterDirection.Output

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'bind the grid to the reader
        DataGrid.DataSource = objReader

        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
        'reopen connection and execute the non query 
        objConnection.Open()
        objCommand.ExecuteNonQuery()

        ' get the more MoreRecords (as the last column)
        ' from the first item of the grid
        If DataGrid.Items.Count = 0 Then
            txtMorePage.Text = 0
        Else
            txtMorePage.Text = Math.Ceiling(Val(Val(objOutputParam1.Value) / (ddlRecordsPerPage.SelectedValue)))
        End If

        'when txtPageNo.Text = 0 (intention to display the last page) get the real page 
        'no as returned from the resultset
        If txtPageNo.Text = 0 Then
            txtPageNo.Text = Val(objOutputParam2.Value)
        End If

        'set the nav buttons visibility
        btnFirst.Enabled = (txtPageNo.Text > 1)
        btnPrevious.Enabled = (txtPageNo.Text > 1)
        btnNext.Enabled = (txtMorePage.Text > 0)
        btnLast.Enabled = (txtMorePage.Text > 0)

        'set the "Records in this page" and the Page X of Y
        lblPageRecordCount.Text = "Record(s) in this page: " & DataGrid.Items.Count.ToString & ". " & _
                                    "Page " & txtPageNo.Text & " of " & (Val(txtPageNo.Text) + Val(txtMorePage.Text)) & ". "

        'close connection
        objConnection.Close()

    End Sub
    Public Shared Sub BindGrid_SetDisplay_v3(ByVal DataGrid As DataGrid, _
                                            ByVal strStoredProc As String, _
                                            ByVal strClient As String, _
                                            ByVal strDue As String, _
                                            ByVal session_username As String, _
                                            ByVal session_SortKey As String, _
                                            ByVal strKeyField As String, _
                                            ByVal btnFirst As Button, _
                                            ByVal btnPrevious As Button, _
                                            ByVal btnNext As Button, _
                                            ByVal btnLast As Button, _
                                            ByVal txtPageNo As TextBox, _
                                            ByVal txtMorePage As TextBox, _
                                            ByVal ddlRecordsPerPage As DropDownList, _
                                            ByVal txtSearch As TextBox, _
                                            ByVal lblPageRecordCount As Label, _
                                            Optional ByVal intHeaderLink As String = Nothing)

        'ian@2004/11/02 originally accepts integer only, intHeaderLink must not accomodate other types
        'Optional ByVal intHeaderLink As integer= 0

        'binds the passed grid and set the buttons, labels and textboxes of the calling page

        'the connection 
        Dim strConnection As String = ConfigurationSettings.AppSettings("appConn")
        Dim objConnection As New SqlConnection(strConnection)

        'the stored proc
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@account_no", strClient)
        objCommand.Parameters.Add("@due_mode", strDue)
        objCommand.Parameters.Add("@Session_username", session_username)
        objCommand.Parameters.Add("@pPageNo", txtPageNo.Text)
        objCommand.Parameters.Add("@pRowPerPage", ddlRecordsPerPage.SelectedValue)

        'code for passing "*" on the aSortKeys() array
        'if the passed sortkey has the "*" char
        If Left(session_SortKey, 1) = "*" Then

            'trim the "*"
            objCommand.Parameters.Add("@pSortKey", Mid(session_SortKey, 2))
            If Trim(txtSearch.Text) <> "" Then
                'disable the searching when that field is non-searachable
                txtSearch.Text = ""
            End If
        Else

            objCommand.Parameters.Add("@pSortKey", session_SortKey)
        End If

        objCommand.Parameters.Add("@pSearchKey", txtSearch.Text.ToString)

        'if there is a keyfield filter specified
        'ian@2004/11/02 originally accepts integer only, intHeaderLink must not accomodate other types
        'If intHeaderLink <> 0 Then
        '    objCommand.Parameters.Add("@pKeyFieldFilter", intHeaderLink)
        'End If
        If intHeaderLink <> Nothing Then
            objCommand.Parameters.Add("@pKeyFieldFilter", intHeaderLink)
        End If


        'stored proc output parameter: @outMoreRecords
        Dim objOutputParam1 As New SqlParameter("@outMoreRecords", SqlDbType.Int)
        objCommand.Parameters.Add(objOutputParam1)
        objOutputParam1.Direction = ParameterDirection.Output

        'stored proc output parameter: @outPageNo
        Dim objOutputParam2 As New SqlParameter("@outPageNo", SqlDbType.Int)
        objCommand.Parameters.Add(objOutputParam2)
        objOutputParam2.Direction = ParameterDirection.Output

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'bind the grid to the reader
        DataGrid.DataSource = objReader

        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
        'reopen connection and execute the non query 
        objConnection.Open()
        objCommand.ExecuteNonQuery()

        ' get the more MoreRecords (as the last column)
        ' from the first item of the grid
        If DataGrid.Items.Count = 0 Then
            txtMorePage.Text = 0
        Else
            txtMorePage.Text = Math.Ceiling(Val(Val(objOutputParam1.Value) / (ddlRecordsPerPage.SelectedValue)))
        End If

        'when txtPageNo.Text = 0 (intention to display the last page) get the real page 
        'no as returned from the resultset
        If txtPageNo.Text = 0 Then
            txtPageNo.Text = Val(objOutputParam2.Value)
        End If

        'set the nav buttons visibility
        btnFirst.Enabled = (txtPageNo.Text > 1)
        btnPrevious.Enabled = (txtPageNo.Text > 1)
        btnNext.Enabled = (txtMorePage.Text > 0)
        btnLast.Enabled = (txtMorePage.Text > 0)

        'set the "Records in this page" and the Page X of Y
        lblPageRecordCount.Text = "Record(s) in this page: " & DataGrid.Items.Count.ToString & ". " & _
                                    "Page " & txtPageNo.Text & " of " & (Val(txtPageNo.Text) + Val(txtMorePage.Text)) & ". "

        'close connection
        objConnection.Close()

    End Sub
    Public Shared Sub BindGrid_SetDisplay_v8(ByVal DataGrid As DataGrid, _
                                                ByVal strStoredProc As String, _
                                                ByVal strClient As String, _
                                                ByVal intBillingID As Integer, _
                                                ByVal session_username As String, _
                                                ByVal session_SortKey As String, _
                                                ByVal strKeyField As String, _
                                                ByVal btnFirst As Button, _
                                                ByVal btnPrevious As Button, _
                                                ByVal btnNext As Button, _
                                                ByVal btnLast As Button, _
                                                ByVal txtPageNo As TextBox, _
                                                ByVal txtMorePage As TextBox, _
                                                ByVal ddlRecordsPerPage As DropDownList, _
                                                ByVal txtSearch As TextBox, _
                                                ByVal lblPageRecordCount As Label, _
                                                Optional ByVal intHeaderLink As String = Nothing)

        'ian@2004/11/02 originally accepts integer only, intHeaderLink must not accomodate other types
        'Optional ByVal intHeaderLink As integer= 0

        'binds the passed grid and set the buttons, labels and textboxes of the calling page

        'the connection 
        Dim strConnection As String = ConfigurationSettings.AppSettings("appConn")
        Dim objConnection As New SqlConnection(strConnection)

        'the stored proc
        Dim objCommand As New SqlCommand(strStoredProc, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Session_username", session_username)
        objCommand.Parameters.Add("@pPageNo", txtPageNo.Text)
        objCommand.Parameters.Add("@pRowPerPage", ddlRecordsPerPage.SelectedValue)
        objCommand.Parameters.Add("@account_no", strClient)
        objCommand.Parameters.Add("@old_billing_id", intBillingID)

        'code for passing "*" on the aSortKeys() array
        'if the passed sortkey has the "*" char
        If Left(session_SortKey, 1) = "*" Then

            'trim the "*"
            objCommand.Parameters.Add("@pSortKey", Mid(session_SortKey, 2))
            If Trim(txtSearch.Text) <> "" Then
                'disable the searching when that field is non-searachable
                txtSearch.Text = ""
            End If
        Else

            objCommand.Parameters.Add("@pSortKey", session_SortKey)
        End If

        objCommand.Parameters.Add("@pSearchKey", txtSearch.Text.ToString)

        'if there is a keyfield filter specified
        'ian@2004/11/02 originally accepts integer only, intHeaderLink must not accomodate other types
        'If intHeaderLink <> 0 Then
        '    objCommand.Parameters.Add("@pKeyFieldFilter", intHeaderLink)
        'End If
        If intHeaderLink <> Nothing Then
            objCommand.Parameters.Add("@pKeyFieldFilter", intHeaderLink)
        End If


        'stored proc output parameter: @outMoreRecords
        Dim objOutputParam1 As New SqlParameter("@outMoreRecords", SqlDbType.Int)
        objCommand.Parameters.Add(objOutputParam1)
        objOutputParam1.Direction = ParameterDirection.Output

        'stored proc output parameter: @outPageNo
        Dim objOutputParam2 As New SqlParameter("@outPageNo", SqlDbType.SmallInt)
        objCommand.Parameters.Add(objOutputParam2)
        objOutputParam2.Direction = ParameterDirection.Output

        'open the connection and execute the reader 
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'bind the grid to the reader
        DataGrid.DataSource = objReader

        'the key field
        DataGrid.DataKeyField = strKeyField
        DataGrid.DataBind()

        'close immediately the reader and connection object 
        objReader.Close()
        objConnection.Close()
        'reopen connection and execute the non query 
        objConnection.Open()
        objCommand.ExecuteNonQuery()

        ' get the more MoreRecords (as the last column)
        ' from the first item of the grid
        If DataGrid.Items.Count = 0 Then
            txtMorePage.Text = 0
        Else
            txtMorePage.Text = Math.Ceiling(Val(Val(objOutputParam1.Value) / (ddlRecordsPerPage.SelectedValue)))
        End If

        'when txtPageNo.Text = 0 (intention to display the last page) get the real page 
        'no as returned from the resultset
        If txtPageNo.Text = 0 Then
            txtPageNo.Text = Val(objOutputParam2.Value)
        End If

        'set the nav buttons visibility
        btnFirst.Enabled = (txtPageNo.Text > 1)
        btnPrevious.Enabled = (txtPageNo.Text > 1)
        btnNext.Enabled = (txtMorePage.Text > 0)
        btnLast.Enabled = (txtMorePage.Text > 0)

        'set the "Records in this page" and the Page X of Y
        lblPageRecordCount.Text = "Record(s) in this page: " & DataGrid.Items.Count.ToString & ". " & _
                                    "Page " & txtPageNo.Text & " of " & (Val(txtPageNo.Text) + Val(txtMorePage.Text)) & ". "

        'close connection
        objConnection.Close()

    End Sub
    Public Shared Sub SaveToAuditTrail(ByVal strSys_User As String, _
                                    ByVal strSys_Event As String, _
                                    ByVal strSys_Table As String, _
                                    ByVal strSys_Reference As String, _
                                    ByVal intHDR_ID As Integer, _
                                    ByVal intDTL_ID As Integer)
        'saves to audit trail

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Sys_Audit_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Sys_User", strSys_User)
        objCommand.Parameters.Add("@Sys_Event", strSys_Event)
        objCommand.Parameters.Add("@Sys_Table", strSys_Table)
        objCommand.Parameters.Add("@Sys_Reference", strSys_Reference)
        objCommand.Parameters.Add("@hdr_id", intHDR_ID)
        objCommand.Parameters.Add("@dtl_id", intDTL_ID)
        objConnection.Open()
        objCommand.ExecuteNonQuery()
        objConnection.Close()
    End Sub
    Public Shared Sub MutliSaveToAuditTrail(ByVal strSys_User As String, _
                                    ByVal strPRCode As String, _
                                    ByVal strSys_Event As String, _
                                    ByVal strSys_Table As String, _
                                    ByVal strSys_Reference As String, _
                                    ByVal intHDR_ID As Integer, _
                                    ByVal intDTL_ID As Integer)
        'saves to audit trail

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Sys_Audit_MultiSave", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Sys_User", strSys_User)
        objCommand.Parameters.Add("@PRCOde", strPRCode)
        objCommand.Parameters.Add("@Sys_Event", strSys_Event)
        objCommand.Parameters.Add("@Sys_Table", strSys_Table)
        objCommand.Parameters.Add("@Sys_Reference", strSys_Reference)
        objCommand.Parameters.Add("@hdr_id", intHDR_ID)
        objCommand.Parameters.Add("@dtl_id", intDTL_ID)
        objConnection.Open()
        objCommand.ExecuteNonQuery()
        objConnection.Close()
    End Sub



    Public Shared Sub DataGrid_ItemCreated(ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs, _
                                ByVal aColumns As Array, _
                                ByVal aHeaders As Array, _
                                ByVal aSortKeys As Array, _
                                ByVal aDisableFields As ArrayList, _
                                ByVal session_SortKey As String, _
                                ByVal strStoredproc As String, _
                                ByVal session_Sys_AccessList As ArrayList)
        'generic handler for each item(ROW) created

        'loop counter
        Dim i As Integer

        'loop though each cells(columns of that item(ROW)) created regardless of type
        For i = 0 To (e.Item.Cells.Count - 1)

            'if type is header
            If e.Item.ItemType = ListItemType.Header _
                And e.Item.Cells(i).HasControls Then

                'convert to the item to link button
                Dim objItem As LinkButton
                objItem = CType(e.Item.Cells(i).Controls(0), LinkButton)

                'get the item's index from aColumns
                Dim intColumnIndex As Integer = Array.IndexOf(aColumns, objItem.Text)

                'is the header item NOT on the aColumn list?
                If intColumnIndex < 0 Then
                    'then hide
                    e.Item.Cells(i).Visible = False

                    'then add to disablefield list (for later disabling of items in this field)
                    aDisableFields.Add(i)

                Else 'the column is in the display (aColumns)list 

                    'display the desired header
                    objItem.Text = aHeaders(intColumnIndex)

                    'is there a sort key 
                    If aSortKeys(intColumnIndex) <> "" Then

                        'is the aSortKeys(intColumnIndex) = session("SortKey") (the current sort key)
                        If aSortKeys(intColumnIndex) = session_SortKey Then
                            'disable the sortability and mark the header
                            e.Item.Cells(i).Text = aHeaders(intColumnIndex) & _
                            "<img src='images\greenarrow.gif' alt='Records are sorted by this column.'>"

                        Else
                            'pass the desired sort key 
                            objItem.CommandArgument = aSortKeys(intColumnIndex)

                            'if the column is tagged as sortable ONLY (not searchable)
                            If Left(objitem.CommandArgument, 1) = "*" Then
                                'enhance the tooltip
                                objItem.ToolTip = "Sort by this column. Search feature on this column (along with others tagged with *) is disabled."
                            Else
                                objItem.ToolTip = "Sort by this column."
                            End If

                        End If

                    Else
                        'disable the sortability
                        e.Item.Cells(i).Text = aHeaders(intColumnIndex)

                    End If

                End If


            ElseIf e.Item.ItemType = ListItemType.Item Or _
                e.Item.ItemType = ListItemType.AlternatingItem Or _
                e.Item.ItemType = ListItemType.SelectedItem Then   'items goes here

                'is the item on the aDisableColumn list?
                If aDisableFields.IndexOf(i) >= 0 Then
                    'then hide the item
                    e.Item.Cells(i).Visible = False

                Else
                    'trying to disable the edit and delete based on Session("Sys_AccessList")
                    'HasControls must be to edit and delte linkbuttons
                    If e.Item.Cells(i).HasControls Then
                        'convert to the item to link button
                        Dim objItem As LinkButton
                        objItem = CType(e.Item.Cells(i).Controls(0), LinkButton)

                        'check if linkbutton is enabled at Session("Sys_AccessList")
                        'applies to EDIT, DELETE, APPROVE, CANCEL, etc.
                        If session_Sys_AccessList.IndexOf(strStoredproc.ToLower & "_" & objitem.text.ToLower) < 0 Then
                            objitem.Text() = ""
                        End If

                    End If

                End If

            ElseIf e.Item.ItemType = ListItemType.Footer Then

                If aDisableFields.IndexOf(i) >= 0 Then
                    'then hide the item
                    e.Item.Cells(i).Visible = False
                Else
                    e.Item.Cells(i).Text = i
                End If
            End If
        Next
    End Sub


    Public Shared Sub DataGrid_ItemCreated_v2(ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs, _
                                    ByVal aColumns As Array, _
                                    ByVal aHeaders As Array, _
                                    ByVal aFormats As Array, _
                                    ByVal aSortKeys As Array, _
                                    ByVal aFooters As Array, _
                                    ByVal aEnableFields_List As ArrayList, _
                                    ByVal aEnableFields_Format As ArrayList, _
                                    ByVal aEnableFields_Footer As ArrayList, _
                                    ByVal session_SortKey As String, _
                                    ByVal strStoredproc As String, _
                                    ByVal session_Sys_AccessList As ArrayList, _
                                    Optional ByVal strStatus As String = "", _
                                    Optional ByVal dataGrid As DataGrid = Nothing)
        'generic handler for each item(ROW) created

        'loop counter
        Dim i As Integer

        'loop though each cells(columns of that item(ROW)) created regardless of type
        For i = 0 To (e.Item.Cells.Count - 1)
            'if type is header            
            If e.Item.ItemType = ListItemType.Header Then
                If e.Item.Cells(i).HasControls Then

                    'center the header
                    e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Center

                    'convert to the item to link button
                    Dim objItem As LinkButton
                    objItem = CType(e.Item.Cells(i).Controls(0), LinkButton)
                    objItem.ForeColor = Color.Green

                    'get the item's index from aColumns
                    Dim intColumnIndex As Integer = Array.IndexOf(aColumns, objItem.Text)

                    'is the header item NOT on the aColumn list?
                    If intColumnIndex < 0 Then
                        'then hide
                        e.Item.Cells(i).Visible = False

                    Else 'the column is in the display (aColumns)list 
                        'then add to enablefield list (for later enabling of items in this field)
                        'e.Item.Cells(i).Visible = true by default
                        aEnableFields_List.Add(i)
                        'add the format specified 
                        aEnableFields_Format.Add(aFormats(intColumnIndex))
                        'add the footer specified 
                        aEnableFields_Footer.Add(aFooters(intColumnIndex))
                        'display the desired header
                        objItem.Text = aHeaders(intColumnIndex)

                        'is there a sort key 
                        If aSortKeys(intColumnIndex) <> "" Then
                            'is the aSortKeys(intColumnIndex) = session("SortKey") (the current sort key)
                            If aSortKeys(intColumnIndex) = session_SortKey Then
                                'disable the sortability and mark the header
                                e.Item.Cells(i).Text = aHeaders(intColumnIndex) & _
                                "<img src='images\greenarrow.gif' alt='Records are sorted by this column.'>"

                            Else
                                'pass the desired sort key 
                                objItem.CommandArgument = aSortKeys(intColumnIndex)

                                'if the column is tagged as sortable ONLY (not searchable)
                                If Left(objitem.CommandArgument, 1) = "*" Then
                                    'enhance the tooltip
                                    objItem.ToolTip = "Sort by this column. Search feature on this column (along with others tagged with *) is disabled."
                                Else
                                    objItem.ToolTip = "Sort by this column."
                                End If
                            End If

                        Else
                            'disable the sortability
                            e.Item.Cells(i).Text = aHeaders(intColumnIndex)
                        End If
                    End If
                Else
                End If



            ElseIf e.Item.ItemType = ListItemType.Item Or _
                e.Item.ItemType = ListItemType.AlternatingItem Or _
                e.Item.ItemType = ListItemType.SelectedItem Then   'items goes here


                'does it have linkbuttons?
                If e.Item.Cells(i).HasControls Then

                    'convert the item to a link button
                    Dim objItem As LinkButton
                    objItem = CType(e.Item.Cells(i).Controls(0), LinkButton)
                    objItem.ForeColor = Color.Green


                    'diff cases and hardcodings for the item links
                    Select Case objitem.Text
                        Case "Open"
                            'do nothing - serial link remains regardless of trx status
                            'objitem.Text = "<img src='images\delete.png'>"

                        Case "Void"
                            'void can only be done where record is posted
                            If strStatus <> "Posted" Then
                                objitem.Text = ""
                            End If

                        Case Else
                            'check and disable if linkbutton is NOT enabled(included) at Session("Sys_AccessList")
                            'or DISABLE controls if status is cancelled  or posted
                            'applies to EDIT, DELETE, APPROVE, CANCEL, etc. (ALL control links)
                            If session_Sys_AccessList.IndexOf(strStoredproc.ToLower & "_" & objitem.text.ToLower) < 0 Or _
                                                    strStatus = "POSTED" Or _
                                                    strStatus = "CANCELLED" Or _
                                                    strStatus = "APPROVED" Or _
                                                    strStatus = "CANVASSING" Or _
                                                    strStatus = "DELIVERED" Or _
                                                    strStatus = "COMPLETED" Or _
                                                    strStatus = "LIQUIDATED" Or _
                                                    strStatus = "DISAPPROVED" Or _
                                                    strStatus = "RECEIVED" Then


                                objitem.Text = ""
                            End If
                    End Select

                    aEnableFields_List.Add(i)
                    'add a blank format 
                    aEnableFields_Format.Add("")
                    'add a blank footer 
                    aEnableFields_Footer.Add("")


                Else ' no link controls 
                    'is I on the aEnableField list?
                    If aEnableFields_List.IndexOf(i) >= 0 Then

                        'if YES, disable the edit and delete based on Session("Sys_AccessList")

                    Else
                        'if NOT then hide the item
                        e.Item.Cells(i).Visible = False
                    End If
                End If


            ElseIf e.Item.ItemType = ListItemType.Footer Then
                'get the index from aColumns
                Dim intColumnIndex As Integer = aEnableFields_List.IndexOf(i)

                'is I on the aEnableField list?
                If aEnableFields_List.IndexOf(i) >= 0 Then
                    'is there a specified footer?
                    If aEnableFields_Footer(intcolumnindex) <> "" Then
                        'what kind?

                        'show in bold
                        e.Item.Cells(i).Font.Bold = True

                        If aEnableFields_Footer(intcolumnindex) = "_COUNT_RECORD_" Then
                            'SYSTEM: COUNT RECORDS on this grid
                            If Not dataGrid Is Nothing Then
                                e.Item.Cells(i).Text = "Total record/s : " & FormatNumber(dataGrid.Items.Count, 0)
                            End If


                        ElseIf aEnableFields_Footer(intcolumnindex) = "_SUM_" Or aEnableFields_Footer(intcolumnindex) = "_AVG_" Then
                            'SYSTEM: SUM RECORDS on this grid column
                            If Not dataGrid Is Nothing Then
                                Dim _SUM_Ctr As Integer
                                Dim _SUM_Field As Double = 0
                                Dim _SUM_AllBlank As Boolean = True


                                For _SUM_Ctr = 0 To (dataGrid.Items.Count - 1)

                                    If dataGrid.Items(_SUM_Ctr).Cells(i).Text <> "" And _SUM_AllBlank Then
                                        _SUM_AllBlank = False
                                    End If

                                    If IsNumeric(dataGrid.Items(_SUM_Ctr).Cells(i).Text) Then
                                        _SUM_Field += dataGrid.Items(_SUM_Ctr).Cells(i).Text
                                    End If
                                Next

                                If Not _SUM_AllBlank Then
                                    e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Right 'hardcoded assuming you sum only those numerics ian@20051112
                                    If aEnableFields_Footer(intcolumnindex) = "_SUM_" Then
                                        e.Item.Cells(i).Text = FormatNumber(_SUM_Field, Mid(aEnableFields_Format(intcolumnindex), 2, 1))
                                    Else : aEnableFields_Footer(intcolumnindex) = "_AVG_"
                                        e.Item.Cells(i).Text = FormatNumber(_SUM_Field / dataGrid.Items.Count, Mid(aEnableFields_Format(intcolumnindex), 2, 1))
                                    End If

                                End If

                            End If

                        Else

                            Select Case Left(aEnableFields_Format(intcolumnindex), 1)

                                Case "D" ' Date
                                    Select Case Mid(aEnableFields_Format(intColumnIndex), 2, 1)
                                        Case "L" ' long date
                                            e.Item.Cells(i).Text = FormatDateTime(aEnableFields_Footer(intcolumnindex), DateFormat.LongDate)
                                        Case "S" ' short date
                                            e.Item.Cells(i).Text = FormatDateTime(aEnableFields_Footer(intcolumnindex), DateFormat.ShortDate)
                                        Case "M" ' Long Time
                                            e.Item.Cells(i).Text = FormatDateTime(aEnableFields_Footer(intcolumnindex), DateFormat.LongTime)
                                        Case "O" ' short Time
                                            e.Item.Cells(i).Text = FormatDateTime(aEnableFields_Footer(intcolumnindex), DateFormat.ShortTime)
                                        Case Else 'general date
                                            e.Item.Cells(i).Text = FormatDateTime(aEnableFields_Footer(intcolumnindex), DateFormat.GeneralDate)
                                    End Select

                                Case "C"
                                    Select Case Mid(aEnableFields_Format(intcolumnindex), 2, 1)
                                        Case ""
                                            e.Item.Cells(i).Text = aEnableFields_Footer(intcolumnindex)
                                        Case Else
                                            e.Item.Cells(i).Text = Left(aEnableFields_Footer(intcolumnindex), Mid(aEnableFields_Format(intcolumnindex), 2))
                                    End Select

                                Case "N"
                                    e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Right
                                    Select Case Mid(aEnableFields_Format(intcolumnindex), 2, 1)
                                        Case ""
                                            e.Item.Cells(i).Text = FormatNumber(aEnableFields_Footer(intcolumnindex), 0)
                                        Case Else
                                            e.Item.Cells(i).Text = FormatNumber(aEnableFields_Footer(intcolumnindex), Mid(aEnableFields_Format(intcolumnindex), 2, 1))
                                    End Select

                                Case Else
                                    ' "" goes here - display as is 
                                    e.Item.Cells(i).Text = aEnableFields_Footer(intcolumnindex)
                            End Select
                        End If

                    End If

                Else
                    e.Item.Cells(i).Visible = False
                End If
            End If
        Next

        If i >= e.Item.Cells.Count And _
            e.Item.ItemType = ListItemType.Footer Then
            'ian@2004/11/15 
            'clean up this variables to avoid being reused by other calling modules
            aEnableFields_List.Clear()
            aEnableFields_Format.Clear()
            aEnableFields_Footer.Clear()
        End If

    End Sub


    Public Shared Sub DataGrid_ItemDataBound_v2(ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs, _
                                                ByVal aEnableFields_Lists As ArrayList, _
                                                ByVal aEnableFields_Format As ArrayList)

        'intPictCol is only specifically used for the display of product image 
        'in the product master list

        Dim i As Integer

        For i = 0 To (e.Item.Cells.Count - 1)

            e.Item.Cells(i).VerticalAlign = VerticalAlign.Top

            Dim intColumnIndex As Integer = aEnableFields_Lists.IndexOf(i)

            If e.Item.ItemType = ListItemType.Header And _
                intColumnIndex >= 0 Then

                'is there a specified format?
                If aEnableFields_Format(intColumnIndex) <> "" Then
                    'what kind?
                    Select Case Left(aEnableFields_Format(intColumnIndex), 1)

                        Case "N" ' numeric 
                            e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Right
                    End Select

                Else ' left justified by default

                    e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Left
                End If


                'ListItemType.Item Or _
                'e.Item.ItemType = ListItemType.AlternatingItem) And _
                'e.Item.Cells(i).HasControls = False And _
                'intColumnIndex >= 0 Then


            ElseIf (e.Item.ItemType = ListItemType.Item Or _
                e.Item.ItemType = ListItemType.AlternatingItem Or _
                e.Item.ItemType = ListItemType.SelectedItem) And _
                e.Item.Cells(i).HasControls = False And _
                intColumnIndex >= 0 Then

                Dim cellValue As String = e.Item.Cells(i).Text

                'is there a specified format?
                If aEnableFields_Format(intColumnIndex) <> "" Then  'And Trim(cellValue) <> ""

                    '20131212 (Ian) [start]: this IF..EndIF solves UI error when nulls (resulting to "&nbsp;") are returned by record set 
                    If cellValue <> "&nbsp;" Then

                        'what kind?
                        Select Case Left(aEnableFields_Format(intColumnIndex), 1)

                            Case "D" ' Date
                                Select Case Mid(aEnableFields_Format(intColumnIndex), 2, 1)
                                    Case "L" ' long date
                                        e.Item.Cells(i).Text = FormatDateTime(cellValue, DateFormat.LongDate)
                                    Case "S" ' short date
                                        e.Item.Cells(i).Text = FormatDateTime(cellValue, DateFormat.ShortDate)
                                    Case Else 'general date
                                        e.Item.Cells(i).Text = FormatDateTime(cellValue, DateFormat.GeneralDate)
                                End Select

                            Case "C" ' character 
                                e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Center
                                Select Case Mid(aEnableFields_Format(intColumnIndex), 2, 1)
                                    Case ""
                                        'e.Item.Cells(i).Text = cellValue 'no need to reverse 
                                    Case Else
                                        e.Item.Cells(i).Text = Left(cellValue, Mid(aEnableFields_Format(intColumnIndex), 2))
                                End Select

                            Case "R" ' character 
                                e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Right
                                Select Case Mid(aEnableFields_Format(intColumnIndex), 2, 1)
                                    Case ""
                                        'e.Item.Cells(i).Text = cellValue 'no need to reverse 
                                    Case Else
                                        e.Item.Cells(i).Text = Left(cellValue, Mid(aEnableFields_Format(intColumnIndex), 2))
                                End Select

                            Case "N" ' numeric 
                                e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Right

                                If Trim(cellValue) <> "" And _
                                        cellValue <> "&nbsp;" Then
                                    Select Case Mid(aEnableFields_Format(intColumnIndex), 2, 1)
                                        Case ""
                                            e.Item.Cells(i).Text = FormatNumber(cellValue, 0)
                                        Case Else
                                            e.Item.Cells(i).Text = FormatNumber(cellValue, Mid(aEnableFields_Format(intColumnIndex), 2, 1))
                                    End Select
                                Else
                                    e.Item.Cells(i).Text = ""
                                End If


                            Case "B" ' boolean - true or false 
                                If cellValue.ToLower = "true" Then
                                    e.Item.Cells(i).Text = "<img src='images\checkbox.gif' >"
                                Else
                                    e.Item.Cells(i).Text = " "
                                End If


                            Case "M" ' email link display 
                                If cellValue <> "" And InStr(cellValue, "@") <> 0 Then
                                    e.Item.Cells(i).Text = "<A HREF='mailto:" & cellValue & "'>" & cellValue & "</A>"
                                End If


                            Case "W" ' url link display 
                                If cellValue <> "" Then
                                    e.Item.Cells(i).Text = "<A HREF='http://" & cellValue & "'>" & cellValue & "</A>"
                                End If

                            Case "X" ' the special case specifier
                                Select Case Mid(aEnableFields_Format(intColumnIndex), 2, 1)
                                    Case "1" ' display product pict
                                        If Dir("c:\inetpub\wwwroot\" & _
                                                                ConfigurationSettings.AppSettings("appName") & _
                                                                "\images\products\" & Trim(e.Item.Cells(i).Text.ToString) & _
                                                                ".jpg") <> "" Then
                                            'then display the image
                                            e.Item.Cells(i).Text = e.Item.Cells(i).Text & _
                                                                                        "<br><img src='images\products\" & _
                                                                                        Trim(e.Item.Cells(i).Text.ToString) & _
                                                                                        ".jpg' width='30' alt='Product picture'>"
                                        End If

                                    Case "2" ' mark the entire row if bit=1 
                                        e.Item.Cells(i).Text = " "

                                        If cellValue.ToLower = "true" Then
                                            e.Item.ForeColor = System.Drawing.Color.Gray
                                            'e.Item.ForeColor = System.Drawing.Color.Orange '.LightPink
                                            'e.Item.Font.Italic = True
                                            e.Item.Font.Strikeout = True
                                            'e.Item.
                                        End If

                                    Case "3" 'display counter of ALL ITEMS
                                        e.Item.Cells(i).Text = (e.Item.ItemIndex + 1)

                                    Case "4" 'pads the item with 10 zeros from left
                                        e.Item.Cells(i).Text = e.Item.Cells(i).Text.PadLeft(10, "0")

                                    Case "5" 'display the image whose filename is base on the column value where this is placed
                                        If Trim(cellValue) <> "" And _
                                        cellValue <> "&nbsp;" And _
                                        Dir("c:\inetpub\wwwroot\unizap\images\products\" & cellValue & ".jpg") <> "" Then
                                            e.Item.Cells(i).Text = "<A target='_blank' HREF='images/products/" & cellValue & ".jpg' >" & "<img  width='40' alt='Product photo.' src ='images/products/" & cellValue & ".jpg' > " & "</A>"
                                            e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Center
                                        Else
                                            e.Item.Cells(i).Text = ""
                                        End If

                                    Case "6" ' mark the entire row if bit=1 
                                        e.Item.Cells(i).Text = " "

                                        If cellValue.ToLower <> "" Then
                                            e.Item.ForeColor = System.Drawing.Color.FromName(cellValue)
                                            'e.Item.BackColor = System.Drawing.Color.FromName(cellValue)
                                            ' System.Drawing.Color.Gray
                                            'e.Item.ForeColor = System.Drawing.Color.Orange '.LightPink
                                            'e.Item.Font.Italic = True
                                            'e.Item.Font.Strikeout = True
                                            'e.Item.
                                        End If

                                    Case "7" 'display the image whose filename is base on the column value where this is placed
                                        If Trim(cellValue) <> "" And cellValue <> "&nbsp;" Then

                                            e.Item.Cells(i).Text = "<A target='_blank' HREF='" & cellValue & "' >" & Mid(aEnableFields_Format(intColumnIndex), 3) & "</A>"
                                            'aEnableFields_Format(intColumnIndex)
                                            'mid(aEnableFields_Format(intColumnIndex), 3,3)
                                            e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Center
                                        Else
                                            e.Item.Cells(i).Text = ""
                                        End If

                                    Case "8" ' mark the entire row if bit=1 
                                        e.Item.Cells(i).Text = " "

                                        If cellValue.ToLower <> "" Then
                                            'e.Item.ForeColor = System.Drawing.Color.FromName(cellValue)
                                            e.Item.BackColor = System.Drawing.Color.FromName(cellValue)
                                            ' System.Drawing.Color.Gray
                                            'e.Item.ForeColor = System.Drawing.Color.Orange '.LightPink
                                            'e.Item.Font.Italic = True
                                            'e.Item.Font.Strikeout = True
                                            'e.Item.
                                        End If

                                End Select


                            Case Else
                                ' "" goes here - display as is 
                                'e.Item.Cells(i).Text = aEnableFields_Footer(intColumnIndex) 'no need to reverse 
                        End Select

                    Else
                        e.Item.Cells(i).Text = ""

                    End If
                    ' 20131212 (Ian) [end]: this IF..EndIF solves UI error when nulls (resulting to "&nbsp;") are returned by record set                     

                End If
            End If
        Next

    End Sub


    Public Shared Sub DataGrid_ItemDataBound(ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs, _
                                               Optional ByVal intPictCol As Integer = 0)

        'intPictCol is only specifically used for the display of product image 
        'in the product master list

        Dim i As Integer

        For i = 0 To (e.Item.Cells.Count - 1)

            e.Item.Cells(i).VerticalAlign = VerticalAlign.Top

            If (e.Item.ItemType = ListItemType.Item Or _
                e.Item.ItemType = ListItemType.AlternatingItem) And _
                e.Item.Cells(i).HasControls = False Then

                'e.Item.Cells(i).VerticalAlign = VerticalAlign.Top

                Dim thisValue As String = e.Item.Cells(i).Text

                If IsNumeric(thisValue) Then
                    'numeric mods

                    If InStr(thisValue, ".") <> 0 Then

                        e.Item.Cells(i).Text = FormatNumber(e.Item.Cells(i).Text)
                        e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Right
                    End If

                ElseIf InStr(thisValue, "@") <> 0 Then
                    'must be an email address?
                    'If IsValidEmail(thisValue) Then
                    e.Item.Cells(i).Text = "<A HREF='mailto:" & thisValue & "'>" & thisValue & "</A>"
                    'End If

                ElseIf thisValue.ToLower = "true" Or thisValue.ToLower = "false" Then
                    'boolean mods
                    If thisValue = True Then
                        e.Item.Cells(i).Text = "<img src='images\checkbox.gif' >"
                    Else
                        e.Item.Cells(i).Text = " "
                    End If
                End If

                'condition for displaying the product image
                If intPictCol <> 0 And i = intPictCol Then

                    'does the file exist?
                    If Dir("c:\inetpub\wwwroot\" & _
                        ConfigurationSettings.AppSettings("appName") & _
                        "\images\products\" & Trim(e.Item.Cells(i).Text.ToString) & _
                        ".jpg") <> "" Then
                        'then display the image
                        e.Item.Cells(i).Text = e.Item.Cells(i).Text & _
                                                                    "<br><img src='images\products\" & _
                                                                    Trim(e.Item.Cells(i).Text.ToString) & _
                                                                    ".jpg' width='30' alt='Product picture'>"
                    End If

                End If

            End If


        Next
    End Sub
    Public Shared Sub DataGrid_ItemCreated_v3(ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs, _
                                        ByVal aColumns As Array, _
                                        ByVal aHeaders As Array, _
                                        ByVal aFormats As Array, _
                                        ByVal aSortKeys As Array, _
                                        ByVal aFooters As Array, _
                                        ByVal aEnableFields_List As ArrayList, _
                                        ByVal aEnableFields_Format As ArrayList, _
                                        ByVal aEnableFields_Footer As ArrayList, _
                                        ByVal session_SortKey As String, _
                                        ByVal strStoredproc As String, _
                                        ByVal session_Sys_AccessList As ArrayList, _
                                        Optional ByVal strStatus As String = "", _
                                        Optional ByVal dataGrid As DataGrid = Nothing)
        'generic handler for each item(ROW) created

        'loop counter
        Dim i As Integer

        'loop though each cells(columns of that item(ROW)) created regardless of type
        For i = 0 To (e.Item.Cells.Count - 1)
            'if type is header
            If e.Item.ItemType = ListItemType.Header Then
                If e.Item.Cells(i).HasControls Then

                    'center the header
                    e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Center

                    'convert to the item to link button
                    Dim objItem As LinkButton
                    objItem = CType(e.Item.Cells(i).Controls(0), LinkButton)

                    'get the item's index from aColumns
                    Dim intColumnIndex As Integer = Array.IndexOf(aColumns, objItem.Text)

                    'is the header item NOT on the aColumn list?
                    If intColumnIndex < 0 Then
                        'then hide
                        e.Item.Cells(i).Visible = False

                    Else 'the column is in the display (aColumns)list 
                        'then add to enablefield list (for later enabling of items in this field)
                        'e.Item.Cells(i).Visible = true by default
                        aEnableFields_List.Add(i)
                        'add the format specified 
                        aEnableFields_Format.Add(aFormats(intColumnIndex))
                        'add the footer specified 
                        aEnableFields_Footer.Add(aFooters(intColumnIndex))
                        'display the desired header
                        objItem.Text = aHeaders(intColumnIndex)

                        'is there a sort key 
                        If aSortKeys(intColumnIndex) <> "" Then
                            'is the aSortKeys(intColumnIndex) = session("SortKey") (the current sort key)
                            If aSortKeys(intColumnIndex) = session_SortKey Then
                                'disable the sortability and mark the header
                                e.Item.Cells(i).Text = aHeaders(intColumnIndex) & _
                                "<img src='images\greenarrow.gif' alt='Records are sorted by this column.'>"

                            Else
                                'pass the desired sort key 
                                objItem.CommandArgument = aSortKeys(intColumnIndex)

                                'if the column is tagged as sortable ONLY (not searchable)
                                If Left(objitem.CommandArgument, 1) = "*" Then
                                    'enhance the tooltip
                                    objItem.ToolTip = "Sort by this column. Search feature on this column (along with others tagged with *) is disabled."
                                Else
                                    objItem.ToolTip = "Sort by this column."
                                End If
                            End If

                        Else
                            'disable the sortability
                            e.Item.Cells(i).Text = aHeaders(intColumnIndex)
                        End If
                    End If
                Else
                End If



            ElseIf e.Item.ItemType = ListItemType.Item Or _
                e.Item.ItemType = ListItemType.AlternatingItem Or _
                e.Item.ItemType = ListItemType.SelectedItem Then   'items goes here


                'does it have linkbuttons?
                If e.Item.Cells(i).HasControls Then

                    'convert the item to a link button
                    Dim objItem As LinkButton
                    objItem = CType(e.Item.Cells(i).Controls(0), LinkButton)

                    'diff cases and hardcodings for the item links
                    Select Case objitem.Text
                        Case "Serial"
                            'do nothing - serial link remains regardless of trx status

                        Case "Void"
                            'void can only be done where record is posted
                            If strStatus <> "Posted" Then
                                objitem.Text = ""
                            End If

                        Case Else
                            'check and disable if linkbutton is NOT enabled(included) at Session("Sys_AccessList")
                            'or DISABLE controls if status is cancelled  or posted
                            'applies to EDIT, DELETE, APPROVE, CANCEL, etc. (ALL control links)
                            If session_Sys_AccessList.IndexOf(strStoredproc.ToLower & "_" & objitem.text.ToLower) < 0 Or _
                                                    strStatus = "Posted" Or _
                                                    strStatus = "Cancelled" Or _
                                                    strStatus = "Approved" Or _
                                                    strStatus = "Rejected" Then

                                objitem.Text = ""
                            End If
                    End Select

                    aEnableFields_List.Add(i)
                    'add a blank format 
                    aEnableFields_Format.Add("")
                    'add a blank footer 
                    aEnableFields_Footer.Add("")


                Else ' no link controls 
                    'is I on the aEnableField list?
                    If aEnableFields_List.IndexOf(i) >= 0 Then

                        'if YES, disable the edit and delete based on Session("Sys_AccessList")

                    Else
                        'if NOT then hide the item
                        e.Item.Cells(i).Visible = False
                    End If
                End If


            ElseIf e.Item.ItemType = ListItemType.Footer Then
                'get the index from aColumns
                Dim intColumnIndex As Integer = aEnableFields_List.IndexOf(i)

                'is I on the aEnableField list?
                If aEnableFields_List.IndexOf(i) >= 0 Then
                    'is there a specified footer?
                    If aEnableFields_Footer(intcolumnindex) <> "" Then
                        'what kind?

                        'show in bold
                        e.Item.Cells(i).Font.Bold = True

                        If aEnableFields_Footer(intcolumnindex) = "_COUNT_RECORD_" Then
                            'SYSTEM: COUNT RECORDS on this grid
                            If Not dataGrid Is Nothing Then
                                e.Item.Cells(i).Text = "TOTAL"
                            End If


                        ElseIf aEnableFields_Footer(intcolumnindex) = "_SUM_" Or aEnableFields_Footer(intcolumnindex) = "_AVG_" Then
                            'SYSTEM: SUM RECORDS on this grid column
                            If Not dataGrid Is Nothing Then
                                Dim _SUM_Ctr As Integer
                                Dim _SUM_Field As Double = 0
                                Dim _SUM_AllBlank As Boolean = True


                                For _SUM_Ctr = 0 To (dataGrid.Items.Count - 1)

                                    If dataGrid.Items(_SUM_Ctr).Cells(i).Text <> "" And _SUM_AllBlank Then
                                        _SUM_AllBlank = False
                                    End If

                                    If IsNumeric(dataGrid.Items(_SUM_Ctr).Cells(i).Text) Then
                                        _SUM_Field += dataGrid.Items(_SUM_Ctr).Cells(i).Text
                                    End If
                                Next

                                If Not _SUM_AllBlank Then
                                    e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Right 'hardcoded assuming you sum only those numerics ian@20051112
                                    If aEnableFields_Footer(intcolumnindex) = "_SUM_" Then
                                        e.Item.Cells(i).Text = FormatNumber(_SUM_Field, Mid(aEnableFields_Format(intcolumnindex), 2, 1))
                                    Else : aEnableFields_Footer(intcolumnindex) = "_AVG_"
                                        e.Item.Cells(i).Text = FormatNumber(_SUM_Field / dataGrid.Items.Count, Mid(aEnableFields_Format(intcolumnindex), 2, 1))
                                    End If

                                End If

                            End If

                        Else

                            Select Case Left(aEnableFields_Format(intcolumnindex), 1)

                                Case "D" ' Date
                                    Select Case Mid(aEnableFields_Format(intColumnIndex), 2, 1)
                                        Case "L" ' long date
                                            e.Item.Cells(i).Text = FormatDateTime(aEnableFields_Footer(intcolumnindex), DateFormat.LongDate)
                                        Case "S" ' short date
                                            e.Item.Cells(i).Text = FormatDateTime(aEnableFields_Footer(intcolumnindex), DateFormat.ShortDate)
                                        Case "M" ' Long Time
                                            e.Item.Cells(i).Text = FormatDateTime(aEnableFields_Footer(intcolumnindex), DateFormat.LongTime)
                                        Case "O" ' short Time
                                            e.Item.Cells(i).Text = FormatDateTime(aEnableFields_Footer(intcolumnindex), DateFormat.ShortTime)
                                        Case Else 'general date
                                            e.Item.Cells(i).Text = FormatDateTime(aEnableFields_Footer(intcolumnindex), DateFormat.GeneralDate)
                                    End Select

                                Case "C"
                                    e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Center
                                    Select Case Mid(aEnableFields_Format(intcolumnindex), 2, 1)
                                        Case "C"
                                            e.Item.Cells(i).Text = aEnableFields_Footer(intcolumnindex)
                                        Case Else
                                            e.Item.Cells(i).Text = Left(aEnableFields_Footer(intcolumnindex), Mid(aEnableFields_Format(intcolumnindex), 2))
                                    End Select

                                Case "N"
                                    e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Right
                                    Select Case Mid(aEnableFields_Format(intcolumnindex), 2, 1)
                                        Case ""
                                            e.Item.Cells(i).Text = FormatNumber(aEnableFields_Footer(intcolumnindex), 0)
                                        Case Else
                                            e.Item.Cells(i).Text = FormatNumber(aEnableFields_Footer(intcolumnindex), Mid(aEnableFields_Format(intcolumnindex), 2, 1))
                                    End Select
                                Case Else
                                    ' "" goes here - display as is 
                                    e.Item.Cells(i).Text = aEnableFields_Footer(intcolumnindex)
                            End Select
                        End If

                    End If

                Else
                    e.Item.Cells(i).Visible = False
                End If
            End If
        Next


        If i >= e.Item.Cells.Count And _
            e.Item.ItemType = ListItemType.Footer Then
            'ian@2004/11/15 
            'clean up this variables to avoid being reused by other calling modules
            aEnableFields_List.Clear()
            aEnableFields_Format.Clear()
            aEnableFields_Footer.Clear()
        End If

    End Sub

    Public Shared Function IsValidEmail(ByVal strIn As String) As Boolean
        ' Return true if strIn is in valid e-mail format.
        Dim validator1 As String = "^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@(([0-9a-zA-Z])+([-\w]*[0-9a-zA-Z])*\.)+[a-zA-Z]{2,9})$"
        Dim validator2 As String = "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"


        Return Regex.IsMatch(strIn, (validator1))
    End Function

    Public Shared Sub SaveToAuditTrail_v2(ByVal strSys_User, _
                                    ByVal strSys_Event, _
                                    ByVal strSys_Table, _
                                    ByVal strSys_Reference, _
                                    ByVal strSys_Sub_Ref, _
                                    ByVal intHDR_ID, _
                                    ByVal intDTL_ID, _
                                    ByVal intB_ID, _
                                    ByVal intOB_ID)
        'saves to audit trail

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Sys_Audit_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Sys_User", strSys_User)
        objCommand.Parameters.Add("@Sys_Event", strSys_Event)
        objCommand.Parameters.Add("@Sys_Table", strSys_Table)
        objCommand.Parameters.Add("@Sys_Reference", strSys_Reference)
        objCommand.Parameters.Add("@Sys_Sub_Ref", strSys_Sub_Ref)
        objCommand.Parameters.Add("@hdr_id", intHDR_ID)
        objCommand.Parameters.Add("@dtl_id", intDTL_ID)
        objCommand.Parameters.Add("@b_id", intB_ID)
        objCommand.Parameters.Add("@ob_id", intOB_ID)
        objConnection.Open()
        objCommand.ExecuteNonQuery()
        objConnection.Close()
    End Sub

End Class

