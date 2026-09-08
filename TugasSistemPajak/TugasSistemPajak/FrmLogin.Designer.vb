<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        picImage = New PictureBox()
        cmbRole = New ComboBox()
        lblRole = New Label()
        Label1 = New Label()
        txtNama = New TextBox()
        label2 = New Label()
        btnLogin = New Button()
        txtNIM = New TextBox()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(133, 12)
        picImage.Name = "picImage"
        picImage.Size = New Size(100, 111)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' cmbRole
        ' 
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Staff", "Manager"})
        cmbRole.Location = New Point(129, 129)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(121, 23)
        cmbRole.TabIndex = 1
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(79, 132)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(36, 15)
        lblRole.TabIndex = 2
        lblRole.Text = "Role :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(79, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 3
        Label1.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(129, 166)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(121, 23)
        txtNama.TabIndex = 4
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(79, 201)
        label2.Name = "label2"
        label2.Size = New Size(39, 15)
        label2.TabIndex = 5
        label2.Text = "NIM : "
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(150, 261)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(73, 36)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(129, 201)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(121, 23)
        txtNIM.TabIndex = 7
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(373, 450)
        Controls.Add(txtNIM)
        Controls.Add(btnLogin)
        Controls.Add(label2)
        Controls.Add(txtNama)
        Controls.Add(Label1)
        Controls.Add(lblRole)
        Controls.Add(cmbRole)
        Controls.Add(picImage)
        MaximizeBox = False
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblRole As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtNIM As TextBox

End Class
