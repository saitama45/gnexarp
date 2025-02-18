Imports System.data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Web.SessionState
Imports System.Text.RegularExpressions
Imports System.Web.UI.WebControls



Public Class This_Class

    Public Shared Sub DisplayProduct_byID(ByVal ProductCode As String, ByVal imgObject As Image)

        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        Dim objCommand As New SqlCommand("mas_product_get", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@id", ProductCode)
        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        objReader.Read()
        Dim txtName As String = objReader("name")
        objReader.Close()
        objConnection.Close()
        This_Class.DisplayProduct(txtName, imgObject)

    End Sub

    Public Shared Sub DisplayProduct(ByVal ProductCode As String, ByVal imgObject As Image)
        If InStr(ProductCode, "<") <> 0 Then
            ProductCode = Left(ProductCode, (InStr(ProductCode, "<") - 1))
            'then trim nay spaces
            ProductCode = Trim(ProductCode)
        End If

        '"1<br><img src='images\products\1.jpg' width='30' alt='Product picture'>"
        If Dir("c:\inetpub\wwwroot\" & _
            "unizap\" & _
            "images\products\" & ProductCode & _
            ".jpg") <> "" Then

            imgObject.Visible = True
            imgObject.ImageUrl = "images\products\" & ProductCode & ".jpg"
            imgObject.AlternateText = "Product picture."
        Else
            UnDisplayProduct(imgObject)
        End If
    End Sub





    Public Shared Sub UnDisplayProduct(ByVal imgobject As Image)
        imgobject.Visible = False
        imgobject.ImageUrl = ""
        imgobject.AlternateText = ""
    End Sub



    Public Shared Sub dgProducts_ItemDataBound(ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)

        Dim i As Integer

        For i = 0 To (e.Item.Cells.Count - 1)
            If (e.Item.ItemType = ListItemType.Item Or _
                e.Item.ItemType = ListItemType.AlternatingItem) Or _
                e.Item.ItemType = ListItemType.SelectedItem Then

                Dim ProductCell As Integer = 1 ' the product description cell

                If i = 0 Then ' the product code cell - display the product pict at the product code cell

                    If Dir("c:\inetpub\wwwroot\" & _
                        ConfigurationSettings.AppSettings("appName") & _
                        "\images\products\" & Trim(e.Item.Cells(ProductCell).Text.ToString) & _
                        ".jpg") <> "" Then

                        Dim objItem As LinkButton
                        objItem = CType(e.Item.Cells(i).Controls(0), LinkButton)
                        'then display the image
                        objItem.Text = objItem.Text & _
                            "<br><img src='images\products\" & _
                            Trim(e.Item.Cells(ProductCell).Text.ToString) & _
                            ".jpg' width='30' alt='Product picture'>"

                    End If

                ElseIf i = 3 And Trim(e.Item.Cells(i).Text) <> "" Then  ' the selling price code cell 

                    e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Right
                    e.Item.Cells(i).Text = FormatNumber(e.Item.Cells(i).Text, 2)

                ElseIf (i = 4 Or i = 5 Or i = 6 Or i = 7) And _
                    Trim(e.Item.Cells(i).Text) <> "" And _
                    Trim(e.Item.Cells(i).Text) <> "&nbsp;" Then    ' the good cell 

                    e.Item.Cells(i).HorizontalAlign = HorizontalAlign.Right
                    e.Item.Cells(i).Text = FormatNumber(e.Item.Cells(i).Text, 0)
                End If


            End If
        Next
    End Sub



    Public Shared Sub CheckStatus(ByVal lblstatus As Label, ByVal btnsave As Button)

        If lblstatus.Text = "Empty" Or lblstatus.Text = "For Posting" Then
            'btnAddRecord.Enabled = True
        End If
        If lblstatus.Text = "For Posting" Then
            'btnsave.Enabled = True
        End If
        If lblstatus.Text = "Posted" Or lblstatus.Text = "Cancelled" Then
            btnsave.Enabled = False
        End If
    End Sub



    Public Shared Sub btnSearchProduct(ByVal txtProduct_UI As TextBox, _
                                    ByVal lblMessage As Label, _
                                    ByVal dgProducts As DataGrid, _
                                    ByVal strSearchType As String)

        If txtProduct_UI.Text = "" Then
            lblMessage.Text = "Please enter a search key first."
            Exit Sub
        End If

        dgProducts.Visible = True

        'the connection 
        Dim strConnection As String = ConfigurationSettings.AppSettings("appConn")
        Dim objConnection As New SqlConnection(strConnection)
        'the stored proc
        Dim objCommand As New SqlCommand("Mas_Product_Search", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Parameters.Add("@String", txtProduct_UI.Text)
        objCommand.Parameters.Add("@SearchType", strSearchType)

        objConnection.Open()
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        'bind the grid to the reader
        dgProducts.DataSource = objReader
        dgProducts.DataBind()
        objReader.Close()
        objConnection.Close()

        If dgProducts.Items.Count = 0 Then
            lblMessage.Text = "No product found for that search key."
            dgProducts.Visible = False
        End If
    End Sub



    Public Shared Function GoPost(ByVal intID As Integer, _
                                    ByVal dtTrx_Date As DateTime, _
                                    ByVal SESSION_username As String, _
                                    ByVal strTableName As String, _
                                    ByVal strSPValidate_Status As String, _
                                    ByVal strSPValidate_Negative As String, _
                                    ByVal strSPValidate_Supersede As String, _
                                    ByVal strSP_Post As String)

        Dim strPostMessage As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()


        '********** Validation # 1 **************
        'validation #1 - check if not For Posting
        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strSPValidate_Status, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
        objCommand.Parameters.Add("@FormAction", "Post")
        objCommand.Parameters.Add("@ID", intID)

        'execute the reader 
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        If objReader.HasRows Then
            strPostMessage = "Cannot proceed with your Post request due to an error:<br>"
            While objReader.Read
                strPostMessage = strPostMessage & objReader("Error_Message") & "<br>"
            End While
        End If


        '********** Validation # 2 **************
        'this validation will be used for OUTGOING transactions ONLY
        'pass strSPValidate_Negative = "" to avoid this proc
        'if OK or For Posting, check if will cause negative balances
        If strSPValidate_Negative <> "" And _
            strPostMessage = "ok" Then 'didnt have error base on first validation above

            objCommand = New SqlCommand(strSPValidate_Negative, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@Trx_Date", dtTrx_Date)

            'reexecute the reader 
            objReader.Close()
            objReader = objCommand.ExecuteReader
            If objReader.HasRows Then
                strPostMessage = "Cannot proceed with your Post request due to an error:<br>"
                While objReader.Read
                    strPostMessage = strPostMessage & objReader("Error_Message") & "<br>"
                End While
            End If
        End If


        '********** Validation # 3 **************
        'pass strSPValidate_Supersede = "" to avoid this proc
        'if OK or will not cause negative, check if will supersede beggining balances
        If strSPValidate_Supersede <> "" And _
            strPostMessage = "ok" Then 'didnt have error base on second validation above
            objCommand = New SqlCommand(strSPValidate_Supersede, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@Trx_Date", dtTrx_Date)

            'reexecute the reader 
            objReader.Close()
            objReader = objCommand.ExecuteReader
            If objReader.HasRows Then
                strPostMessage = "Cannot proceed with your Post request due to an error:<br>"
                While objReader.Read
                    strPostMessage = strPostMessage & objReader("Error_Message") & "<br>"
                End While
            End If
        End If


        '********** actual posting **************
        'if OK or will not supersede balances, POST 
        If strPostMessage = "ok" Then 'didnt have error base on third validation above
            objCommand = New SqlCommand(strSP_Post, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@SESSION_username", SESSION_username)

            Try
                'execute the actual post
                objReader.Close()
                objCommand.ExecuteNonQuery()
                'save to audit trail 
                Sys_Class.SaveToAuditTrail(SESSION_username, _
                                            "Post", _
                                            strTableName, _
                                            strTableName, _
                                            intID, _
                                            "")
            Catch ex As Exception
                'in case of error
                strPostMessage = "There were error(s) while posting record(s).<br>Please report the ff.:<br> " & ex.ToString
            End Try
        End If

        'close reader and connection object 
        objReader.Close()
        objConnection.Close()

        GoPost = strPostMessage
    End Function
    Public Shared Function GoCancel(ByVal intID As Integer, _
                                ByVal dtFrom As DateTime, _
                                ByVal dtTo As DateTime, _
                                ByVal intClientOutlet As Integer, _
                                ByVal SESSION_username As String, _
                                ByVal strTableName As String, _
                                ByVal strSPValidate_Status As String, _
                                ByVal strSPValidate_Negative As String, _
                                ByVal strSPValidate_Supersede As String, _
                                ByVal strSP_Cancel As String)

        Dim strCancelMessage As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()


        '********** Validation # 1 **************
        'validation #1 - check if not Posted
        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strSPValidate_Status, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
        objCommand.Parameters.Add("@FormAction", "Cancel")
        objCommand.Parameters.Add("@ID", intID)
        objCommand.Parameters.Add("@client_outlet", intClientOutlet)
        objCommand.Parameters.Add("@cover_fr", dtFrom)
        objCommand.Parameters.Add("@cover_to", dtTo)

        'execute the reader 
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        If objReader.HasRows Then            
            While objReader.Read
                strCancelMessage = objReader("Error_Message")
            End While
        End If

        '********** actual posting **************
        'if OK or will not void balances, CANCEL
        If strCancelMessage = "ok" Then 'didnt have error base on third validation above
            objCommand = New SqlCommand(strSP_Cancel, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@SESSION_username", SESSION_username)

            Try
                'execute the actual post
                objReader.Close()
                objCommand.ExecuteNonQuery()
                'save to audit trail 
                Sys_Class.SaveToAuditTrail(SESSION_username, _
                                            "Cancel", _
                                            strTableName, _
                                            strTableName, _
                                            intID, _
                                            0)
            Catch ex As Exception
                'in case of error
                strCancelMessage = "There was an error(s) while cancelling record(s).<br>Please report the ff.:<br> " & ex.ToString
            End Try
        End If

        'close reader and connection object 
        objReader.Close()
        objConnection.Close()

        GoCancel = strCancelMessage
    End Function
    'Gener created AS OF 13APR16 for trx_cosdtl_list.aspx
    Public Shared Function GoCancel_V2(ByVal intID As Integer, _
                                    ByVal SESSION_username As String, _
                                    ByVal strTableName As String, _
                                    ByVal strSPValidate_Status As String, _
                                    ByVal strSPValidate_Negative As String, _
                                    ByVal strSPValidate_Void As String, _
                                    ByVal strSP_Cancel As String)

        Dim strCancelMessage As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()


        '********** Validation # 1 **************
        'validation #1 - check if not Posted
        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strSPValidate_Status, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
        objCommand.Parameters.Add("@FormAction", "Cancel")
        objCommand.Parameters.Add("@ID", intID)

        'execute the reader 
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        If objReader.HasRows Then
            strCancelMessage = "Cannot proceed with your Cancel request due to an error:<br>"
            While objReader.Read
                strCancelMessage = strCancelMessage & objReader("Error_Message") & "<br>"
            End While
        End If


        '********** Validation # 2 **************
        'this validation will be used for INCOMING transactions ONLY
        'pass strSPValidate_Negative = "" to avoid this proc
        'if OK or Posted, check if cancelling will cause negative balances
        If strSPValidate_Negative <> "" And _
            strCancelMessage = "ok" Then 'didnt have error base on first validation above
            objCommand = New SqlCommand(strSPValidate_Negative, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            'objCommand.Parameters.Add("@Trx_Date", dtTrx_Date)

            'reexecute the reader 
            objReader.Close()
            objReader = objCommand.ExecuteReader
            If objReader.HasRows Then
                strCancelMessage = "Cannot proceed with your Cancel request due to an error:<br>"
                While objReader.Read
                    strCancelMessage = strCancelMessage & objReader("Error_Message") & "<br>"
                End While
            End If
        End If


        '********** Validation # 3 **************
        'pass strSPValidate_Void = "" to avoid this proc
        'if OK or will not cause negative, check if will void beggining balances
        If strSPValidate_Void <> "" And _
            strCancelMessage = "ok" Then 'didnt have error base on second validation above
            objCommand = New SqlCommand(strSPValidate_Void, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            'objCommand.Parameters.Add("@Trx_Date", dtTrx_Date)

            'reexecute the reader 
            objReader.Close()
            objReader = objCommand.ExecuteReader
            If objReader.HasRows Then
                strCancelMessage = "Cannot proceed with your Cancel request due to an error:<br>"
                While objReader.Read
                    strCancelMessage = strCancelMessage & objReader("Error_Message") & "<br>"
                End While
            End If
        End If


        '********** actual posting **************
        'if OK or will not void balances, CANCEL
        If strCancelMessage = "ok" Then 'didnt have error base on third validation above
            objCommand = New SqlCommand(strSP_Cancel, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@SESSION_username", SESSION_username)

            Try
                'execute the actual post
                objReader.Close()
                objCommand.ExecuteNonQuery()
                'save to audit trail 
                Sys_Class.SaveToAuditTrail(SESSION_username, _
                                            "Cancel", _
                                            strTableName, _
                                            strTableName, _
                                            intID, _
                                            "")
            Catch ex As Exception
                'in case of error
                strCancelMessage = "There was an error(s) while cancelling record(s).<br>Please report the ff.:<br> " & ex.ToString
            End Try
        End If

        'close reader and connection object 
        objReader.Close()
        objConnection.Close()

        GoCancel_V2 = strCancelMessage
    End Function

    Public Shared Function GoPost_IS(ByVal strRef As String, _
                                    ByVal intID As Integer, _
                                    ByVal calReportingDate As Date, _
                                    ByVal intBillingType As Integer, _                                   
                                    ByVal SESSION_username As String, _
                                    ByVal strTableName As String, _
                                    ByVal strSPValidate_Status As String, _
                                    ByVal strSPValidate_Negative As String, _
                                    ByVal strSPValidate_Supersede As String, _
                                    ByVal strSP_Post As String)

        Dim strMessage As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        '********** Validation # 1 **************
        'validation #1 - check if not For Posting
        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strSPValidate_Status, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
        objCommand.Parameters.Add("@FormAction", "Approve")
        objCommand.Parameters.Add("@ID", intID)        

        'execute the reader 
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then            
            While objReader.Read
                strMessage = objReader("Error_Message")
            End While
        End If

        '********** actual posting **************
        'if OK or will not supersede balances, POST 
        If strMessage = "ok" Then 'didnt have error base on third validation above
            objCommand = New SqlCommand(strSP_Post, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure            
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@SESSION_fullname", SESSION_username)
            objCommand.Parameters.Add("@reporting_date", calReportingDate)
            objCommand.Parameters.Add("@billing_type", intBillingType)

            Try
                'execute the actual post
                objReader.Close()
                objCommand.ExecuteNonQuery()
                'save to audit trail 
                Sys_Class.SaveToAuditTrail(SESSION_username, _
                                            "Post", _
                                            strTableName, _
                                            strRef, _
                                            intID, _
                                            0)
            Catch ex As Exception
                'in case of error
                strMessage = "There were error(s) while posting record(s).<br>Please report the ff.:<br> " & ex.ToString
            End Try
        End If

        'close reader and connection object 
        objReader.Close()
        objConnection.Close()

        GoPost_IS = strMessage
    End Function
    'Gener created AS OF 13APR16 for trx_cosdtl_list.aspx
    Public Shared Function GoPost_IS_V2(ByVal intID As Integer, _
                                    ByVal intClient_Outlet As Integer, _
                                    ByVal SESSION_username As String, _
                                    ByVal strTableName As String, _
                                    ByVal strSPValidate_Status As String, _
                                    ByVal strSPValidate_Negative As String, _
                                    ByVal strSPValidate_Supersede As String, _
                                    ByVal strSP_Post As String)

        Dim strPostMessage As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()


        '********** Validation # 1 **************
        'validation #1 - check if not For Posting
        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strSPValidate_Status, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
        objCommand.Parameters.Add("@FormAction", "Post")
        objCommand.Parameters.Add("@ID", intID)
        objCommand.Parameters.Add("@client_outlet", intClient_Outlet)

        'execute the reader 
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        If objReader.HasRows Then
            strPostMessage = "Cannot proceed with your Post request due to an error:<br>"
            While objReader.Read
                strPostMessage = strPostMessage & objReader("Error_Message") & "<br>"
            End While
        End If


        ''********** Validation # 2 **************
        ''this validation will be used for OUTGOING transactions ONLY
        ''pass strSPValidate_Negative = "" to avoid this proc
        ''if OK or For Posting, check if will cause negative balances
        'If strSPValidate_Negative <> "" And _
        '    strPostMessage = "ok" Then 'didnt have error base on first validation above

        '    objCommand = New SqlCommand(strSPValidate_Negative, objConnection)
        '    objCommand.CommandType = CommandType.StoredProcedure
        '    objCommand.Parameters.Add("@ID", intID)
        '    objCommand.Parameters.Add("@Trx_Date", dtTrx_Date)

        '    'reexecute the reader 
        '    objReader.Close()
        '    objReader = objCommand.ExecuteReader
        '    If objReader.HasRows Then
        '        strPostMessage = "Cannot proceed with your Post request due to an error:<br>"
        '        While objReader.Read
        '            strPostMessage = strPostMessage & objReader("Error_Message") & "<br>"
        '        End While
        '    End If
        'End If


        ''********** Validation # 3 **************
        ''pass strSPValidate_Supersede = "" to avoid this proc
        ''if OK or will not cause negative, check if will supersede beggining balances
        'If strSPValidate_Supersede <> "" And _
        '    strPostMessage = "ok" Then 'didnt have error base on second validation above
        '    objCommand = New SqlCommand(strSPValidate_Supersede, objConnection)
        '    objCommand.CommandType = CommandType.StoredProcedure
        '    objCommand.Parameters.Add("@ID", intID)
        '    objCommand.Parameters.Add("@Trx_Date", dtTrx_Date)

        '    'reexecute the reader 
        '    objReader.Close()
        '    objReader = objCommand.ExecuteReader
        '    If objReader.HasRows Then
        '        strPostMessage = "Cannot proceed with your Post request due to an error:<br>"
        '        While objReader.Read
        '            strPostMessage = strPostMessage & objReader("Error_Message") & "<br>"
        '        End While
        '    End If
        'End If


        '********** actual posting **************
        'if OK or will not supersede balances, POST 
        If strPostMessage = "ok" Then 'didnt have error base on third validation above
            objCommand = New SqlCommand(strSP_Post, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@SESSION_username", SESSION_username)

            Try
                'execute the actual post
                objReader.Close()
                objCommand.ExecuteNonQuery()
                'save to audit trail 
                Sys_Class.SaveToAuditTrail(SESSION_username, _
                                            "Post", _
                                            strTableName, _
                                            strTableName, _
                                            intID, _
                                            "")
            Catch ex As Exception
                'in case of error
                strPostMessage = "There were error(s) while posting record(s).<br>Please report the ff.:<br> " & ex.ToString
            End Try
        End If

        'close reader and connection object 
        objReader.Close()
        objConnection.Close()

        GoPost_IS_V2 = strPostMessage
    End Function
    Public Shared Function GoUnPost_Collection(ByVal intID As Integer, _
                                    ByVal intORNo As String, _
                                    ByVal intCheckNo As String, _
                                    ByVal ddlCheckAmount As Double, _
                                    ByVal ddlCheckBank As Integer, _
                                    ByVal ddlAppliedAmount As Double, _
                                    ByVal SESSION_username As String, _
                                    ByVal ddlClient As Integer, _
                                    ByVal strTableName As String, _
                                    ByVal strSPValidate_Status As String, _
                                    ByVal strSPValidate_Negative As String, _
                                    ByVal strSPValidate_Supersede As String, _
                                    ByVal strSP_UnPost As String)

        Dim strPostMessage As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()


        '********** Validation # 1 **************
        'validation #1 - check if not For Posting
        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strSPValidate_Status, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
        objCommand.Parameters.Add("@FormAction", "UnPost")
        objCommand.Parameters.Add("@ID", intID)
        objCommand.Parameters.Add("@or_no", intORNo)
        objCommand.Parameters.Add("@check_no", intCheckNo)
        objCommand.Parameters.Add("@check_amount", ddlCheckAmount)
        objCommand.Parameters.Add("@check_bank", ddlCheckBank)
        objCommand.Parameters.Add("@applied_amount", ddlAppliedAmount)
        objCommand.Parameters.Add("@client", ddlClient)

        'execute the reader 
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        If objReader.HasRows Then
            strPostMessage = "Cannot proceed with your Post request due to an error:<br>"
            While objReader.Read
                strPostMessage = strPostMessage & objReader("Error_Message") & "<br>"
            End While
        End If


        '********** actual posting **************
        'if OK or will not supersede balances, POST 
        If strPostMessage = "ok" Then 'didnt have error base on third validation above
            objCommand = New SqlCommand(strSP_UnPost, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@FormAction", "UnPost")
            objCommand.Parameters.Add("@SESSION_username", SESSION_username)

            Try
                'execute the actual post
                objReader.Close()
                objCommand.ExecuteNonQuery()
                'save to audit trail 
                Sys_Class.SaveToAuditTrail(SESSION_username, _
                                            "Approve", _
                                            strTableName, _
                                            intID, _
                                            intID, _
                                            0)
            Catch ex As Exception
                'in case of error
                strPostMessage = "There were error(s) while posting record(s).<br>Please report the ff.:<br> " & ex.ToString
            End Try
        End If

        'close reader and connection object 
        objReader.Close()
        objConnection.Close()

        GoUnPost_Collection = strPostMessage
    End Function
    Public Shared Function GoUnPost_IS(ByVal intID As Integer, _
                                        ByVal dtFrom As DateTime, _
                                        ByVal dtTo As DateTime, _
                                        ByVal intClient_Outlet As Integer, _
                                        ByVal SESSION_username As String, _
                                        ByVal strTableName As String, _
                                        ByVal strSPValidate_Status As String, _
                                        ByVal strSPValidate_Negative As String, _
                                        ByVal strSPValidate_Supersede As String, _
                                        ByVal strSP_UnPost As String)

        Dim strUnpostMessage As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()


        '********** Validation # 1 **************
        'validation #1 - check if not For Posting
        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strSPValidate_Status, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
        objCommand.Parameters.Add("@FormAction", "Unpost")
        objCommand.Parameters.Add("@ID", intID)
        objCommand.Parameters.Add("@client_outlet", intClient_Outlet)
        objCommand.Parameters.Add("@cover_fr", dtFrom)
        objCommand.Parameters.Add("@cover_to", dtTo)

        'execute the reader 
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        If objReader.HasRows Then
            While objReader.Read
                strUnpostMessage = objReader("Error_Message")
            End While
        End If


        '********** actual posting **************
        'if OK or will not supersede balances, POST 
        If strUnpostMessage = "ok" Then 'didnt have error base on third validation above
            objCommand = New SqlCommand(strSP_UnPost, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@SESSION_username", SESSION_username)

            Try
                'execute the actual post
                objReader.Close()
                objCommand.ExecuteNonQuery()
                'save to audit trail 
                Sys_Class.SaveToAuditTrail(SESSION_username, _
                                            "Unpost", _
                                            strTableName, _
                                            strTableName, _
                                            intID, _
                                            0)
            Catch ex As Exception
                'in case of error
                strUnpostMessage = "There were error(s) while posting record(s).<br>Please report the ff.:<br> " & ex.ToString
            End Try
        End If

        'close reader and connection object 
        objReader.Close()
        objConnection.Close()

        GoUnPost_IS = strUnpostMessage
    End Function
    'Gener created AS OF 13APR16 for trx_cosdtl_list.aspx
    Public Shared Function GoUnPost_IS_V2(ByVal intID As Integer, _
                                            ByVal intClient_Outlet As Integer, _
                                            ByVal SESSION_username As String, _
                                            ByVal strTableName As String, _
                                            ByVal strSPValidate_Status As String, _
                                            ByVal strSPValidate_Negative As String, _
                                            ByVal strSPValidate_Supersede As String, _
                                            ByVal strSP_UnPost As String)

        Dim strPostMessage As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()


        '********** Validation # 1 **************
        'validation #1 - check if not For Posting
        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strSPValidate_Status, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
        objCommand.Parameters.Add("@FormAction", "Unpost")
        objCommand.Parameters.Add("@ID", intID)
        objCommand.Parameters.Add("@client_outlet", intClient_Outlet)


        'execute the reader 
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        If objReader.HasRows Then
            strPostMessage = "Cannot proceed with your Post request due to an error:<br>"
            While objReader.Read
                strPostMessage = strPostMessage & objReader("Error_Message") & "<br>"
            End While
        End If


        '********** actual posting **************
        'if OK or will not supersede balances, POST 
        If strPostMessage = "ok" Then 'didnt have error base on third validation above
            objCommand = New SqlCommand(strSP_UnPost, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@SESSION_username", SESSION_username)

            Try
                'execute the actual post
                objReader.Close()
                objCommand.ExecuteNonQuery()
                'save to audit trail 
                Sys_Class.SaveToAuditTrail(SESSION_username, _
                                            "Unpost", _
                                            strTableName, _
                                            strTableName, _
                                            intID, _
                                            "")
            Catch ex As Exception
                'in case of error
                strPostMessage = "There were error(s) while posting record(s).<br>Please report the ff.:<br> " & ex.ToString
            End Try
        End If

        'close reader and connection object 
        objReader.Close()
        objConnection.Close()

        GoUnPost_IS_V2 = strPostMessage
    End Function


    Public Shared Function GoApprove_IS(ByVal strRef As String, _
                                    ByVal intID As Integer, _
                                    ByVal intBSNo As String, _
                                    ByVal strClient As String, _
                                    ByVal SESSION_username As String, _
                                    ByVal strTableName As String, _
                                    ByVal strSPValidate_Status As String, _
                                    ByVal strSPValidate_Negative As String, _
                                    ByVal strSPValidate_Supersede As String, _
                                    ByVal strSP_Approve As String)

        Dim strMessage As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        '********** Validation # 1 **************
        'validation #1 - check if not For Posting
        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strSPValidate_Status, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
        objCommand.Parameters.Add("@FormAction", "Approve")
        objCommand.Parameters.Add("@ID", intID)

        'execute the reader 
        Dim objReader As SqlDataReader = objCommand.ExecuteReader

        If objReader.HasRows Then
            While objReader.Read
                strMessage = objReader("Error_Message")
            End While
        End If

        '********** actual posting **************
        'if OK or will not supersede balances, POST 
        If strMessage = "ok" Then 'didnt have error base on third validation above
            objCommand = New SqlCommand(strSP_Approve, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@account_no", strClient)
            objCommand.Parameters.Add("@bs_no", intBSNo)
            objCommand.Parameters.Add("@SESSION_fullname", SESSION_username)

            Try
                'execute the actual post
                objReader.Close()
                objCommand.ExecuteNonQuery()
                'save to audit trail 
                Sys_Class.SaveToAuditTrail(SESSION_username, _
                                            "Approve", _
                                            strTableName, _
                                            strRef, _
                                            intID, _
                                            0)

            Catch ex As Exception
                'in case of error
                strMessage = "There were error(s) while approving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End Try
        End If

        'close reader and connection object 
        objReader.Close()
        objConnection.Close()

        GoApprove_IS = strMessage
    End Function
    Public Shared Function GoCancel_IS(ByVal strRef As String, _
                                    ByVal intID As Integer, _
                                    ByVal intCancelledReason As Integer, _
                                    ByVal strDetailedReason As String, _
                                    ByVal dblBSAmount As Double, _
                                    ByVal SESSION_username As String, _
                                    ByVal strTableName As String, _
                                    ByVal strSPValidate_Status As String, _
                                    ByVal strSPValidate_Negative As String, _
                                    ByVal strSPValidate_Supersede As String, _
                                    ByVal strSP_Cancel As String)

        Dim strMessage As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        '********** Validation # 1 **************
        'validation #1 - check if not For Posting
        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strSPValidate_Status, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
        objCommand.Parameters.Add("@FormAction", "Approve")
        objCommand.Parameters.Add("@ID", intID)

        'execute the reader 
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        If objReader.HasRows Then
            While objReader.Read
                strMessage = objReader("Error_Message")
            End While
        End If

        '********** actual posting **************
        'if OK or will not supersede balances, POST 
        If strMessage = "ok" Then 'didnt have error base on third validation above
            objCommand = New SqlCommand(strSP_Cancel, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@SESSION_fullname", SESSION_username)
            objCommand.Parameters.Add("@reason", intCancelledReason)
            objCommand.Parameters.Add("@detailed_reason", strDetailedReason)
            objCommand.Parameters.Add("@bs_amount", dblBSAmount)

            Try
                'execute the actual post
                objReader.Close()
                objCommand.ExecuteNonQuery()
                'save to audit trail 
                Sys_Class.SaveToAuditTrail(SESSION_username, _
                                            "Cancel", _
                                            strTableName, _
                                            strRef, _
                                            intID, _
                                            0)

            Catch ex As Exception
                'in case of error
                strMessage = "There were error(s) while cancelling record(s).<br>Please report the ff.:<br> " & ex.ToString
            End Try
        End If

        'close reader and connection object 
        objReader.Close()
        objConnection.Close()

        GoCancel_IS = strMessage
    End Function

    Public Shared Function GoForReplacement_IS(ByVal strRef As String, _
                                    ByVal intID As Integer, _                                    
                                    ByVal SESSION_username As String, _
                                    ByVal strTableName As String, _
                                    ByVal strSPValidate_Status As String, _
                                    ByVal strSPValidate_Negative As String, _
                                    ByVal strSPValidate_Supersede As String, _
                                    ByVal strSP_ForReplacement As String)

        Dim strMessage As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        '********** Validation # 1 **************
        'validation #1 - check if not For Posting
        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strSPValidate_Status, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
        objCommand.Parameters.Add("@FormAction", "Approve")
        objCommand.Parameters.Add("@ID", intID)

        'execute the reader 
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        If objReader.HasRows Then
            While objReader.Read
                strMessage = objReader("Error_Message")
            End While
        End If

        '********** actual posting **************
        'if OK or will not supersede balances, POST 
        If strMessage = "ok" Then 'didnt have error base on third validation above
            objCommand = New SqlCommand(strSP_ForReplacement, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@SESSION_fullname", SESSION_username)

            Try
                'execute the actual post
                objReader.Close()
                objCommand.ExecuteNonQuery()
                'save to audit trail 
                Sys_Class.SaveToAuditTrail(SESSION_username, _
                                            "ForReplace", _
                                            strTableName, _
                                            strRef, _
                                            intID, _
                                            0)
            Catch ex As Exception
                'in case of error
                strMessage = "There were error(s) while approving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End Try
        End If

        'close reader and connection object 
        objReader.Close()
        objConnection.Close()

        GoForReplacement_IS = strMessage
    End Function

    Public Shared Function GoReturn_IS(ByVal strRef As String, _
                                    ByVal intID As Integer, _
                                    ByVal intCancelledReason As Integer, _
                                    ByVal strDetailedReason As String, _
                                    ByVal SESSION_username As String, _
                                    ByVal strTableName As String, _
                                    ByVal strSPValidate_Status As String, _
                                    ByVal strSPValidate_Negative As String, _
                                    ByVal strSPValidate_Supersede As String, _
                                    ByVal strSP_ForReplacement As String)

        Dim strMessage As String = "ok"

        'the connection 
        Dim objConnection As New SqlConnection(ConfigurationSettings.AppSettings("appConn"))
        objConnection.Open()

        '********** Validation # 1 **************
        'validation #1 - check if not For Posting
        'the stored procedure and parameters
        Dim objCommand As New SqlCommand(strSPValidate_Status, objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandTimeout = ConfigurationSettings.AppSettings("QueryTimeout")
        objCommand.Parameters.Add("@FormAction", "Approve")
        objCommand.Parameters.Add("@ID", intID)

        'execute the reader 
        Dim objReader As SqlDataReader = objCommand.ExecuteReader
        If objReader.HasRows Then
            While objReader.Read
                strMessage = objReader("Error_Message")
            End While
        End If

        '********** actual posting **************
        'if OK or will not supersede balances, POST 
        If strMessage = "ok" Then 'didnt have error base on third validation above
            objCommand = New SqlCommand(strSP_ForReplacement, objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.Add("@ID", intID)
            objCommand.Parameters.Add("@SESSION_fullname", SESSION_username)
            objCommand.Parameters.Add("@reason", intCancelledReason)
            objCommand.Parameters.Add("@detailed_reason", strDetailedReason)

            Try
                'execute the actual post
                objReader.Close()
                objCommand.ExecuteNonQuery()
                'save to audit trail 
                Sys_Class.SaveToAuditTrail(SESSION_username, _
                                            "ForReplace", _
                                            strTableName, _
                                            strRef, _
                                            intID, _
                                            0)
            Catch ex As Exception
                'in case of error
                strMessage = "There were error(s) while approving record(s).<br>Please report the ff.:<br> " & ex.ToString
            End Try
        End If

        'close reader and connection object 
        objReader.Close()
        objConnection.Close()

        GoReturn_IS = strMessage
    End Function

End Class





