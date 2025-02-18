Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports WebChart
Public Class sys_posmenu
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Protected WithEvents lblUser As System.Web.UI.WebControls.Label
    Protected WithEvents lblUserTab As System.Web.UI.WebControls.Label
    Protected WithEvents lblCompanyName As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents lblDashboard As System.Web.UI.WebControls.Label
    Protected WithEvents panelDashboard As System.Web.UI.WebControls.Panel
    Protected WithEvents tblDashboard As System.Web.UI.WebControls.Table
    Protected WithEvents lblPO As System.Web.UI.WebControls.Label
    Protected WithEvents panelPO As System.Web.UI.WebControls.Panel
    Protected WithEvents tblPO As System.Web.UI.WebControls.Table
    Protected WithEvents lblAR As System.Web.UI.WebControls.Label
    Protected WithEvents panelAR As System.Web.UI.WebControls.Panel
    Protected WithEvents tblAR As System.Web.UI.WebControls.Table
    Protected WithEvents lblDR As System.Web.UI.WebControls.Label
    Protected WithEvents panelDR As System.Web.UI.WebControls.Panel
    Protected WithEvents tblDR As System.Web.UI.WebControls.Table
    Protected WithEvents lblMyAccount As System.Web.UI.WebControls.Label
    Protected WithEvents panelMyAccount As System.Web.UI.WebControls.Panel
    Protected WithEvents tblMyAccount As System.Web.UI.WebControls.Table
    Protected WithEvents lblInvoice As System.Web.UI.WebControls.Label
    Protected WithEvents panelInvoice As System.Web.UI.WebControls.Panel
    Protected WithEvents tblInvoice As System.Web.UI.WebControls.Table
    Protected WithEvents lblReference As System.Web.UI.WebControls.Label
    Protected WithEvents panelReference As System.Web.UI.WebControls.Panel
    Protected WithEvents tblReference As System.Web.UI.WebControls.Table
    Protected WithEvents lblReports As System.Web.UI.WebControls.Label
    Protected WithEvents panelReports As System.Web.UI.WebControls.Panel
    Protected WithEvents tblReports As System.Web.UI.WebControls.Table
    Protected WithEvents lblSetting As System.Web.UI.WebControls.Label
    Protected WithEvents panelSetting As System.Web.UI.WebControls.Panel
    Protected WithEvents tblSetting As System.Web.UI.WebControls.Table
    Protected WithEvents lblMenu1 As System.Web.UI.WebControls.Label
    Protected WithEvents panelMenu1 As System.Web.UI.WebControls.Panel
    Protected WithEvents tblMenu1 As System.Web.UI.WebControls.Table
    Protected WithEvents lblMenu2 As System.Web.UI.WebControls.Label
    Protected WithEvents panelMenu2 As System.Web.UI.WebControls.Panel
    Protected WithEvents tblMenu2 As System.Web.UI.WebControls.Table
    Protected WithEvents lblMenu3 As System.Web.UI.WebControls.Label
    Protected WithEvents panelMenu3 As System.Web.UI.WebControls.Panel
    Protected WithEvents tblMenu3 As System.Web.UI.WebControls.Table
    Protected WithEvents lblMenu4 As System.Web.UI.WebControls.Label
    Protected WithEvents panelMenu4 As System.Web.UI.WebControls.Panel
    Protected WithEvents tblMenu4 As System.Web.UI.WebControls.Table
    Protected WithEvents lblMenu5 As System.Web.UI.WebControls.Label
    Protected WithEvents panelMenu5 As System.Web.UI.WebControls.Panel
    Protected WithEvents tblMenu5 As System.Web.UI.WebControls.Table
    Protected WithEvents lblCountNotif As System.Web.UI.WebControls.Label
    Protected WithEvents tblNotif As System.Web.UI.WebControls.Table
    Protected WithEvents lblItems As System.Web.UI.WebControls.Label
    Protected WithEvents lblCategories As System.Web.UI.WebControls.Label
    Protected WithEvents lblSubCategories As System.Web.UI.WebControls.Label
    Protected WithEvents Chart1 As WebChart.ChartControl
    Protected WithEvents btnItems As System.Web.UI.WebControls.Button
    Protected WithEvents btnPR As System.Web.UI.WebControls.Button
    Protected WithEvents btnPRApproval As System.Web.UI.WebControls.Button
    Protected WithEvents btnReceiving As System.Web.UI.WebControls.Button
    Protected WithEvents btnReceivingApproval As System.Web.UI.WebControls.Button
    Protected WithEvents btnJO As System.Web.UI.WebControls.Button
    Protected WithEvents btnJOApproval As System.Web.UI.WebControls.Button
    Protected WithEvents btnIssuanceReports As System.Web.UI.WebControls.Button
    Protected WithEvents btnSupplier As System.Web.UI.WebControls.Button
    Protected WithEvents btnCustomer As System.Web.UI.WebControls.Button
    Protected WithEvents btnUOM As System.Web.UI.WebControls.Button
    Protected WithEvents btnCategories As System.Web.UI.WebControls.Button
    Protected WithEvents btnSubCategories As System.Web.UI.WebControls.Button
    Protected WithEvents divPO As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divReceiving As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divInventory As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divSales As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divDelivery As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divCustomers As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divReports As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divReferences As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divPayables As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divReceivables As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divProjects As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents divBudget As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pPR As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pPROC As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pPO As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pPRApproval As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pWithPO As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pWithoutPO As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pReceivingApproval As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pInventoryStatus As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pSR As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pSRApproval As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pStockAdjustment As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pAuditTrail As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pSO As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pSOApproval As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pPayment As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pPOS As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pIssuance As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pIssuanceApproval As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pPrintDR As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pUpdateDelivery As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pAPVoucher As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pCheckRegister As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents pJournalVoucher As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents tblPOModule As System.Web.UI.WebControls.Table
    Protected WithEvents tblReceivingModule As System.Web.UI.WebControls.Table
    Protected WithEvents tblInventoryModule As System.Web.UI.WebControls.Table
    Protected WithEvents tblSalesModule As System.Web.UI.WebControls.Table
    Protected WithEvents tblDeliveryModule As System.Web.UI.WebControls.Table
    Protected WithEvents tblPayablesModule As System.Web.UI.WebControls.Table
    Protected WithEvents tblBudgetModule As System.Web.UI.WebControls.Table

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    'START MODS HERE OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

    'the stored proc to call
    Public strSubMenuName As String = "sys_mobilemenu"
    Public strStoredProc As String = "sys_mobilemenu"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

        Sys_Class.DisplaySideBarMenu(lblUser, _
                                    lblUserTab, _
                                    lblCompanyName, _
                                    Session("group"), _
                                    lblDashboard, _
                                    panelDashboard, _
                                    tblDashboard, _
                                    lblPO, _
                                    panelPO, _
                                    tblPO, _
                                    lblMyAccount, _
                                    panelMyAccount, _
                                    tblMyAccount, _
                                    lblAR, _
                                    panelAR, _
                                    tblAR, _
                                    lblDR, _
                                    panelDR, _
                                    tblDR, _
                                    lblInvoice, _
                                    panelInvoice, _
                                    tblInvoice, _
                                    lblReference, _
                                    panelReference, _
                                    tblReference, _
                                    lblReports, _
                                    panelReports, _
                                    tblReports, _
                                    lblSetting, _
                                    panelSetting, _
                                    tblSetting, _
                                    lblMenu1, _
                                    panelMenu1, _
                                    tblMenu1, _
                                    lblMenu2, _
                                    panelMenu2, _
                                    tblMenu2, _
                                    lblMenu3, _
                                    panelMenu3, _
                                    tblMenu3, _
                                    lblMenu4, _
                                    panelMenu4, _
                                    tblMenu4, _
                                    lblMenu5, _
                                    panelMenu5, _
                                    tblMenu5, _
                                    lblCountNotif, _
                                    tblNotif)

        'is this module in the list of accessable menus?
        If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
            'go somewhere
            Response.Redirect("sys_errorpage")
        End If

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("Sys_Menu_Get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@Sys_Group", Session("group"))

        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        While objReader.Read
            Dim tableRow As New TableRow
            Dim tableCell As New TableCell

            Dim strLink_Parameter2 As String = Trim(objReader("link_parameter"))

           

            If Trim(objReader("main_menu")) = lblMyAccount.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    divReceiving.Style.Remove("pointer-events")
                    divReceiving.Style.Remove("opacity")

                    tableCell.Text = "<p><a class=""w3-btn w3-win8-blue w3-hover-light-blue w3-block"" href=" & Trim(objReader("link_page")) & strLink_Parameter2 & "><span class='w3-text w3-small'>" & Trim(objReader("sub_menu")) & "</span></a></p>"

                    tableRow.Cells.Add(tableCell)
                    tblReceivingModule.Rows.Add(tableRow)

                Else
                    divReceiving.Style("pointer-events") = "none"
                    divReceiving.Style("opacity") = "0.5"

                End If

            End If

            If Trim(objReader("main_menu")) = lblInvoice.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    divInventory.Style.Remove("pointer-events")
                    divInventory.Style.Remove("opacity")

                    tableCell.Text = "<p><a class=""w3-btn w3-win8-blue w3-hover-light-blue w3-block"" href=" & Trim(objReader("link_page")) & strLink_Parameter2 & "><span class='w3-text w3-small'>" & Trim(objReader("sub_menu")) & "</span></a></p>"

                    tableRow.Cells.Add(tableCell)
                    tblInventoryModule.Rows.Add(tableRow)

                Else
                    divInventory.Style("pointer-events") = "none"
                    divInventory.Style("opacity") = "0.5"
                End If

            End If

            If Trim(objReader("main_menu")) = lblAR.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    tableCell.Text = "<p><a class=""w3-btn w3-win8-blue w3-hover-light-blue w3-block"" href=" & Trim(objReader("link_page")) & strLink_Parameter2 & "><span class='w3-text w3-small'>" & Trim(objReader("sub_menu")) & "</span></a></p>"

                    tableRow.Cells.Add(tableCell)
                    tblSalesModule.Rows.Add(tableRow)

                    divSales.Style.Remove("pointer-events")
                    divSales.Style.Remove("opacity")
                Else
                    divSales.Style("pointer-events") = "none"
                    divSales.Style("opacity") = "0.5"
                End If
            End If

            

            If Trim(objReader("main_menu")) = lblReports.Text Then
                If Trim(objReader("link_page")) <> "" Then

                    divReports.Style.Remove("pointer-events")
                    divReports.Style.Remove("opacity")
                Else
                    divReports.Style("pointer-events") = "none"
                    divReports.Style("opacity") = "0.5"
                End If
            End If

           

        End While

        'close, reopen immediately
        
    End Sub


End Class
