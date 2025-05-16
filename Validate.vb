Public Class frmValidate

    Public bCancel As Boolean = False
    Public sAIService As String = ""
    Public sOpenAiApiKey As String = ""
    Public sAnthropicKey As String = ""
    Public sAIInstructions As String = ""

    Private Sub Validate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sAIInstructions <> "" Then txtInstructions.Text = sAIInstructions
        txtAnthropicApiKey.Text = sAnthropicKey
        txtOpenAI.Text = sOpenAiApiKey
        SetComboBox(cbAiService, sAIService)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        bCancel = False
        sAIInstructions = txtInstructions.Text
        sAIService = GetComboBoxVal(cbAiService, sAIService)
        sAnthropicKey = txtAnthropicApiKey.Text
        sOpenAiApiKey = txtOpenAI.Text
        Me.Close()
    End Sub

    Private Function GetComboBoxVal(ByRef oComboBox As ComboBox, sDefaultValue As String) As String
        If oComboBox.SelectedIndex = -1 Then
            Return sDefaultValue
        End If

        Return oComboBox.Items(oComboBox.SelectedIndex)
    End Function

    Private Sub SetComboBox(ByRef oComboBox As ComboBox, sValue As String)
        For i As Integer = 0 To oComboBox.Items.Count - 1
            If oComboBox.Items(i) = sValue Then
                oComboBox.SelectedIndex = i
                Exit Sub
            End If
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        bCancel = True
        Me.Close()
    End Sub
End Class