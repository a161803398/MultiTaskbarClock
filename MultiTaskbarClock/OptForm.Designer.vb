<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OptForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptForm))
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FontBtn = New System.Windows.Forms.Button()
        Me.ColorBtn = New System.Windows.Forms.Button()
        Me.Format1Text = New System.Windows.Forms.TextBox()
        Me.Format2Text = New System.Windows.Forms.TextBox()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.Format1Label = New System.Windows.Forms.Label()
        Me.Format2Label = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FontBtn
        '
        resources.ApplyResources(Me.FontBtn, "FontBtn")
        Me.FontBtn.Name = "FontBtn"
        Me.FontBtn.UseVisualStyleBackColor = True
        '
        'ColorBtn
        '
        resources.ApplyResources(Me.ColorBtn, "ColorBtn")
        Me.ColorBtn.Name = "ColorBtn"
        Me.ColorBtn.UseVisualStyleBackColor = True
        '
        'Format1Text
        '
        resources.ApplyResources(Me.Format1Text, "Format1Text")
        Me.Format1Text.Name = "Format1Text"
        '
        'Format2Text
        '
        resources.ApplyResources(Me.Format2Text, "Format2Text")
        Me.Format2Text.Name = "Format2Text"
        '
        'OkBtn
        '
        resources.ApplyResources(Me.OkBtn, "OkBtn")
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'Format1Label
        '
        resources.ApplyResources(Me.Format1Label, "Format1Label")
        Me.Format1Label.Name = "Format1Label"
        '
        'Format2Label
        '
        resources.ApplyResources(Me.Format2Label, "Format2Label")
        Me.Format2Label.Name = "Format2Label"
        '
        'ExitBtn
        '
        resources.ApplyResources(Me.ExitBtn, "ExitBtn")
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'OptForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Format2Label)
        Me.Controls.Add(Me.Format1Label)
        Me.Controls.Add(Me.Format2Text)
        Me.Controls.Add(Me.Format1Text)
        Me.Controls.Add(Me.ColorBtn)
        Me.Controls.Add(Me.FontBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FontBtn As Button
    Friend WithEvents ColorBtn As Button
    Friend WithEvents Format1Text As TextBox
    Friend WithEvents Format2Text As TextBox
    Friend WithEvents OkBtn As Button
    Friend WithEvents Format1Label As Label
    Friend WithEvents Format2Label As Label
    Friend WithEvents ExitBtn As Button
End Class
