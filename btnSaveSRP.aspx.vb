Imports System.Data.SqlClient
Imports System.Web.Security
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports Microsoft.VisualBasic.CompilerServices

Public Class btnSaveSRP
    Inherits System.Web.UI.Page
    Dim counter As Integer = 1 ' Declare counter at class level

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblCompanyName As System.Web.UI.WebControls.Label
    Protected WithEvents TopMenuCategories As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents lblTotalItemSRP As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalItemCount As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalItemCart As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotalCartAmount As System.Web.UI.WebControls.Label
    Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
    Protected WithEvents Div1 As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents btnDelete As System.Web.UI.WebControls.Button
    Protected WithEvents btnUpdate As System.Web.UI.WebControls.Button
    Protected WithEvents btnContinueShop As System.Web.UI.WebControls.Button
    Protected WithEvents btnCheckout As System.Web.UI.WebControls.Button

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

        If Not Page.IsPostBack Then


            If Request("FormAction") = "Save" Then
                SaveAmount()

            Else
                btnSaveSRPClicked()
            End If

        End If

    End Sub
    Private Function btnSaveBarcodeItemClick()

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        'the stored procedure and parameters
        Dim objCommand As New SqlCommand("Inv_POSDtl_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@FormAction", Request("FormAction"))
        objCommand.Parameters.Add("@id", 0)
        objCommand.Parameters.Add("@warehouse", Request("warehouse"))
        objCommand.Parameters.Add("@iss_id", Request("id"))
        objCommand.Parameters.Add("@dr_code", Request("dr_code"))
        objCommand.Parameters.Add("@barcode", Request("barcode"))
        objCommand.Parameters.Add("@qty", Request("qty"))
        objCommand.Parameters.Add("@srp", 0)
        objCommand.Parameters.Add("@discount", 0)
        objCommand.Parameters.Add("@sales_person", "")
        objCommand.Parameters.Add("@Session_fullname", Request("Session_fullname"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()


        Catch ex As Exception
            'in case of error

        Finally

            objConnection.Close()
        End Try
    End Function
    Private Function btnSaveSRPClicked()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Ref_ClientsItem_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "Edit")
        objCommand.Parameters.Add("@id", Request("id"))
        objCommand.Parameters.Add("@status", Request("status"))
        objCommand.Parameters.Add("@srp", Request("srp"))
        objCommand.Parameters.Add("@Session_fullname", Request("Session_fullname"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

        Catch ex As Exception
            'in case of error

        Finally

            objConnection.Close()
        End Try
    End Function
    Private Function SaveAmount()
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))

        Dim objCommand As New SqlCommand("Inv_PaidDTL_Save", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        objCommand.Parameters.Add("@FormAction", "Save")
        objCommand.Parameters.Add("@header_id", Request("header_id"))
        objCommand.Parameters.Add("@iss_id", Request("iss_id"))
        objCommand.Parameters.Add("@applied_amount", Request("applied_amount"))
        objCommand.Parameters.Add("@wtax_amount", Request("wtax_amount"))
        objCommand.Parameters.Add("@deduction_amount", Request("deduction_amount"))
        objCommand.Parameters.Add("@Session_fullname", Request("Session_fullname"))

        'the returned new id 
        Dim objNewID As New SqlParameter("@newID", SqlDbType.Int)
        objCommand.Parameters.Add(objNewID)
        objNewID.Direction = ParameterDirection.Output

        Try
            'open the connection and execute the query 
            objConnection.Open()
            objCommand.ExecuteNonQuery()

        Catch ex As Exception
            'in case of error

        Finally

            objConnection.Close()
        End Try
    End Function

End Class
