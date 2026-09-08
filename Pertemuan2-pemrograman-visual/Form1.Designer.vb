<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblNAMA = New Label()
        txtNAMA = New TextBox()
        lblNIM = New Label()
        txtNIM = New TextBox()
        lblKOM = New Label()
        txtKOM = New TextBox()
        btnTAMPILKAN = New Button()
        btnHAPUS = New Button()
        btnKELUAR = New Button()
        SuspendLayout()
        ' 
        ' lblNAMA
        ' 
        lblNAMA.AutoSize = True
        lblNAMA.Location = New Point(126, 45)
        lblNAMA.Name = "lblNAMA"
        lblNAMA.Size = New Size(45, 15)
        lblNAMA.TabIndex = 0
        lblNAMA.Text = "Nama :"
        ' 
        ' txtNAMA
        ' 
        txtNAMA.Location = New Point(177, 42)
        txtNAMA.Name = "txtNAMA"
        txtNAMA.Size = New Size(100, 23)
        txtNAMA.TabIndex = 1
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(126, 94)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(36, 15)
        lblNIM.TabIndex = 2
        lblNIM.Text = "NIM :"
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(177, 86)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(100, 23)
        txtNIM.TabIndex = 3
        ' 
        ' lblKOM
        ' 
        lblKOM.AutoSize = True
        lblKOM.Location = New Point(126, 131)
        lblKOM.Name = "lblKOM"
        lblKOM.Size = New Size(39, 15)
        lblKOM.TabIndex = 4
        lblKOM.Text = "KOM :"
        ' 
        ' txtKOM
        ' 
        txtKOM.Location = New Point(177, 128)
        txtKOM.Name = "txtKOM"
        txtKOM.Size = New Size(100, 23)
        txtKOM.TabIndex = 5
        ' 
        ' btnTAMPILKAN
        ' 
        btnTAMPILKAN.Location = New Point(126, 180)
        btnTAMPILKAN.Name = "btnTAMPILKAN"
        btnTAMPILKAN.Size = New Size(75, 23)
        btnTAMPILKAN.TabIndex = 6
        btnTAMPILKAN.Text = "Tampilkan"
        btnTAMPILKAN.UseVisualStyleBackColor = True
        ' 
        ' btnHAPUS
        ' 
        btnHAPUS.Location = New Point(207, 180)
        btnHAPUS.Name = "btnHAPUS"
        btnHAPUS.Size = New Size(75, 23)
        btnHAPUS.TabIndex = 7
        btnHAPUS.Text = "Hapus"
        btnHAPUS.UseVisualStyleBackColor = True
        ' 
        ' btnKELUAR
        ' 
        btnKELUAR.Location = New Point(167, 222)
        btnKELUAR.Name = "btnKELUAR"
        btnKELUAR.Size = New Size(75, 23)
        btnKELUAR.TabIndex = 8
        btnKELUAR.Text = "Keluar"
        btnKELUAR.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(703, 451)
        Controls.Add(btnKELUAR)
        Controls.Add(btnHAPUS)
        Controls.Add(btnTAMPILKAN)
        Controls.Add(txtKOM)
        Controls.Add(lblKOM)
        Controls.Add(txtNIM)
        Controls.Add(lblNIM)
        Controls.Add(txtNAMA)
        Controls.Add(lblNAMA)
        Name = "Form1"
        Text = "Profile Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNAMA As Label
    Friend WithEvents txtNAMA As TextBox
    Friend WithEvents lblNIM As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents lblKOM As Label
    Friend WithEvents txtKOM As TextBox
    Friend WithEvents btnTAMPILKAN As Button
    Friend WithEvents btnHAPUS As Button
    Friend WithEvents btnKELUAR As Button

End Class
