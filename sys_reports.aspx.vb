Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports WebChart
Public Class sys_reports
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
    Protected WithEvents spanInventories As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents spanAccounts As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents spanSales As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents spanFinancials As System.Web.UI.HtmlControls.HtmlGenericControl

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
    Public strSubMenuName As String = "sys_reports"
    Public strStoredProc As String = "sys_reports"

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

        LoadReports()

        'is this module in the list of accessable menus?
        If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
            'go somewhere
            Response.Redirect("sys_errorpage")
        End If


    End Sub

    Private Sub LoadReports()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("sys_reports_get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")

        objCommand.Parameters.Add("@sys_group", Session("Group"))
        objCommand.Parameters.Add("@header", "INVENTORIES")

        objConnection.Open()

        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        Dim myInventories As String = String.Empty

        While objReader.Read

            myInventories &= ("<p>" & _
                                "<a class='w3-btn w3-green w3-round-xxlarge w3-block w3-hover-light-blue' href=" + Trim(objReader("sub_menu_code")) + ">" & _
                                    "<span class='w3-text'>" + Trim(objReader("sub_menu")) + "</span>" & _
                                "</a>" & _
                            "</p>")

        End While

        spanInventories.InnerHtml = myInventories

        objReader.Close()

        objCommand = New SqlCommand("sys_reports_get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@sys_group", Session("Group"))
        objCommand.Parameters.Add("@header", "ACCOUNTS")

        objReader = objCommand.ExecuteReader

        Dim myAccounts As String = String.Empty

        While objReader.Read

            myAccounts &= ("<p>" & _
                                "<a class='w3-btn w3-green w3-round-xxlarge w3-block w3-hover-light-blue' href=" + Trim(objReader("sub_menu_code")) + ">" & _
                                    "<span class='w3-text'>" + Trim(objReader("sub_menu")) + "</span>" & _
                                "</a>" & _
                            "</p>")

        End While

        spanAccounts.InnerHtml = myAccounts

        objReader.Close()

        objCommand = New SqlCommand("sys_reports_get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@sys_group", Session("Group"))
        objCommand.Parameters.Add("@header", "SALES")

        objReader = objCommand.ExecuteReader

        Dim mySales As String = String.Empty

        While objReader.Read

            mySales &= ("<p>" & _
                                "<a class='w3-btn w3-green w3-round-xxlarge w3-block w3-hover-light-blue' href=" + Trim(objReader("sub_menu_code")) + ">" & _
                                    "<span class='w3-text'>" + Trim(objReader("sub_menu")) + "</span>" & _
                                "</a>" & _
                            "</p>")

        End While

        spanSales.InnerHtml = mySales

        objReader.Close()

        objCommand = New SqlCommand("sys_reports_get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@sys_group", Session("Group"))
        objCommand.Parameters.Add("@header", "FINANCIALS")

        objReader = objCommand.ExecuteReader

        Dim myFinancials As String = String.Empty

        While objReader.Read

            myFinancials &= ("<p>" & _
                                "<a class='w3-btn w3-green w3-round-xxlarge w3-block w3-hover-light-blue' href=" + Trim(objReader("sub_menu_code")) + ">" & _
                                    "<span class='w3-text'>" + Trim(objReader("sub_menu")) + "</span>" & _
                                "</a>" & _
                            "</p>")

        End While

        spanFinancials.InnerHtml = myFinancials

        objReader.Close()
        objConnection.Close()
    End Sub
End Class
