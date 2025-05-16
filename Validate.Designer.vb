<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmValidate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAnthropicApiKey = New System.Windows.Forms.TextBox()
        Me.cbAiService = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInstructions = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtOpenAI = New System.Windows.Forms.TextBox()
        Me.lblOpenAI = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Anthropic API key"
        '
        'txtAnthropicApiKey
        '
        Me.txtAnthropicApiKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnthropicApiKey.Location = New System.Drawing.Point(156, 106)
        Me.txtAnthropicApiKey.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAnthropicApiKey.Multiline = True
        Me.txtAnthropicApiKey.Name = "txtAnthropicApiKey"
        Me.txtAnthropicApiKey.Size = New System.Drawing.Size(1560, 32)
        Me.txtAnthropicApiKey.TabIndex = 23
        '
        'cbAiService
        '
        Me.cbAiService.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAiService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAiService.FormattingEnabled = True
        Me.cbAiService.Items.AddRange(New Object() {"gpt-4o", "gpt-4o-mini", "claude-3-5-sonnet-20240620"})
        Me.cbAiService.Location = New System.Drawing.Point(156, 60)
        Me.cbAiService.Name = "cbAiService"
        Me.cbAiService.Size = New System.Drawing.Size(1560, 28)
        Me.cbAiService.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "AI Service"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 201)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "AI Proofreading"
        '
        'txtInstructions
        '
        Me.txtInstructions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInstructions.Location = New System.Drawing.Point(156, 201)
        Me.txtInstructions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInstructions.Multiline = True
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.Size = New System.Drawing.Size(1560, 190)
        Me.txtInstructions.TabIndex = 27
        Me.txtInstructions.Text = "Here is OCRed text." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Find and correct typos." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do not provide any comments." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Provi" &
    "de output text only. If there are no problems just say: OK."
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(681, 420)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(147, 55)
        Me.btnOK.TabIndex = 28
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Location = New System.Drawing.Point(855, 420)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(147, 55)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtOpenAI
        '
        Me.txtOpenAI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOpenAI.Location = New System.Drawing.Point(156, 152)
        Me.txtOpenAI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOpenAI.Multiline = True
        Me.txtOpenAI.Name = "txtOpenAI"
        Me.txtOpenAI.Size = New System.Drawing.Size(1560, 32)
        Me.txtOpenAI.TabIndex = 31
        '
        'lblOpenAI
        '
        Me.lblOpenAI.AutoSize = True
        Me.lblOpenAI.Location = New System.Drawing.Point(13, 152)
        Me.lblOpenAI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpenAI.Name = "lblOpenAI"
        Me.lblOpenAI.Size = New System.Drawing.Size(122, 20)
        Me.lblOpenAI.TabIndex = 30
        Me.lblOpenAI.Text = "OpenAI API key"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1198, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "OCRed text can have typos.  This module uses AI (Anthropic or OpenAI) to correct " &
    "them.  You can also ask AI to remove hyphenation dashes and reference to footnot" &
    "es."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 37)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(774, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "1. Setup API Keys.          2. Process the text file against the AI.            3" &
    ".Review and accept proposed changes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 221)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Instructions"
        '
        'frmValidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1729, 487)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOpenAI)
        Me.Controls.Add(Me.lblOpenAI)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtInstructions)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbAiService)
        Me.Controls.Add(Me.txtAnthropicApiKey)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmValidate"
        Me.Text = "AI Proofreading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtAnthropicApiKey As TextBox
    Friend WithEvents cbAiService As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInstructions As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtOpenAI As TextBox
    Friend WithEvents lblOpenAI As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
