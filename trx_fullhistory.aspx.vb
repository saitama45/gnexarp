
Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState

Public Class trx_fullhistory
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblModule As System.Web.UI.WebControls.Label
    Protected WithEvents CompareValidator1 As System.Web.UI.WebControls.CompareValidator
    Protected WithEvents RangeValidator1 As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents txtFrom As System.Web.UI.WebControls.TextBox
    Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents txtTo As System.Web.UI.WebControls.TextBox
    Protected WithEvents dgList As System.Web.UI.WebControls.DataGrid
    Protected WithEvents ScrollingGrid1 As AvgControls.ScrollingGrid

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    'the stored proc to call
    Public strStoredProc As String = "trx_fullhistory"
    Public aEnableFields_List As New ArrayList
    Public aEnableFields_Format As New ArrayList
    Public aEnableFields_Footer As New ArrayList

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Load
        'Put user code to initialize the page here

        ''is this module in the list of accessable menus?
        'If Session("Sys_AccessList").indexof(strStoredProc.ToLower & "_access") < 0 Then
        '    'go somewhere
        '    Response.Redirect("sys_errorpage")
        'End If

        lblMessage.Text = ""

        If Not Page.IsPostBack Then

            dgList.SelectedIndex = -1

            Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
            Dim objCommand As New SqlCommand("Sys_Audit_Search", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@mode", Request("mode"))
            objCommand.Parameters.Add("@sys_table", Request("sys_table"))
            objCommand.Parameters.Add("@hdr_id", Request("id"))
            objConnection.Open()

            Dim objReader As SqlDataReader = objCommand.ExecuteReader
            dgList.DataSource = objReader
            'dgList.DataKeyField = "id"
            dgList.DataBind()
            objReader.Close()
            objConnection.Close()

            If dgList.Items.Count = 0 Then
                lblMessage.Text = "Record/s found :" & dgList.Items.Count
            End If
            dgList.Visible = True

            lblModule.Text += " for " & Request("sys_table") & " #" & Request("id")

        End If
    End Sub




    Private Sub dgList_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
    Handles dgList.ItemCreated

        'handles for each item(ROW) created
        'the columns (ONLY) to display, each items must exist from the resultset
        Dim aColumns() As String = {"sys_user", _
                                    "sys_date", _
                                    "sys_event", _                                    
                                    "sys_reference"}

        'the headers to diplay, instead of the default fieldname
        Dim aHeaders() As String = {"User", _
                                    "Date", _
                                    "Event", _                                    
                                    "Reference"}

        Dim aFooters() As String = {"_COUNT_RECORD_", _
                                    "", _
                                    "", _                                    
                                    ""}

        '_SUM_

        'aFormats - the way ITEMS and FOOTERS (if any) are to be displayed
        '****************************************************************************************************
        'aFormat settings: (use ONLY ONE of the below)
        '****************************************************************************************************
        ' ""  - as is
        '"Cn" - left-justified : display the first "n" chars in alphanumeric, display all if no "n" spePNied
        '"Nn" - right justified : displayed as FormatNumber(value, n)
        '"B"  - displays a boolean field in graphics
        '"M"  - displays as an email link
        '"W"  - display as a URL 
        '**special sets :
        '"X1" - display the product 
        '****************************************************************************************************
        Dim aFormats() As String = {"", _
                                    "", _                                    
                                    "", _
                                    ""}

        'the sort key expression to associate. pass "" to disable sorting
        Dim aSortKeys() As String = {"", _
                                    "", _                                    
                                    "", _
                                    ""}

        'sortkeys are control at the stored proc, not here
        Session("SortKey") = aSortKeys(0)

        srx.Sys_Class.DataGrid_ItemCreated_v2(e, _
                                            aColumns, _
                                            aHeaders, _
                                            aFormats, _
                                            aSortKeys, _
                                            aFooters, _
                                            aEnableFields_List, _
                                            aEnableFields_Format, _
                                            aEnableFields_Footer, _
                                            Session("SortKey"), _
                                            strStoredProc, _
                                            Session("Sys_AccessList"), _
                                            "", _
                                            dgList)
    End Sub


    Private Sub dgList_ItemDataBound(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) _
    Handles dgList.ItemDataBound
        srx.Sys_Class.DataGrid_ItemDataBound_v2(e, aEnableFields_List, aEnableFields_Format)
    End Sub

    Private Sub dgList_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) _
    Handles dgList.ItemCommand
        'go to the detail page      
        'dgProduct()
        If e.CommandName = "detail" Then
            'mark the selected item 
            dgList.SelectedIndex = e.Item.ItemIndex

            Dim strKeyFieldValue As String = dgList.DataKeys(dgList.SelectedIndex)

            'Response.Redirect("inq_ledger_qty_dtl?id=" + strKeyFieldValue)
            SetEndPopup("inq_ledger_qty_dtl?id=" + strKeyFieldValue)

        End If
    End Sub


    Private Sub SetEndPopup(ByVal strLink)
        Dim s As String = "<SCRIPT language='javascript'>window.open('" & strLink & "')</SCRIPT>"
        RegisterStartupScript("startup", s)
    End Sub


End Class
