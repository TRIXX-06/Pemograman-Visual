<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPajak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtPendapatan = New TextBox()
        btnHitung = New Button()
        lblLimaJuta = New Label()
        lblTigaPuluhJuta = New Label()
        btnKeluar = New Button()
        lblSeratusJuta = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(68, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(113, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 15)
        Label2.TabIndex = 1
        Label2.Text = "Masukkan Pendapatan :" & vbCrLf
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(98, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(27, 15)
        Label3.TabIndex = 2
        Label3.Text = "Rp :"
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(131, 173)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(115, 23)
        txtPendapatan.TabIndex = 3
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(149, 227)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(75, 23)
        btnHitung.TabIndex = 4
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' lblLimaJuta
        ' 
        lblLimaJuta.AutoSize = True
        lblLimaJuta.Location = New Point(98, 63)
        lblLimaJuta.Name = "lblLimaJuta"
        lblLimaJuta.Size = New Size(216, 15)
        lblLimaJuta.TabIndex = 5
        lblLimaJuta.Text = "Pendapatan lebih dari 5 juta , 10% Pajak"
        ' 
        ' lblTigaPuluhJuta
        ' 
        lblTigaPuluhJuta.AutoSize = True
        lblTigaPuluhJuta.Location = New Point(92, 87)
        lblTigaPuluhJuta.Name = "lblTigaPuluhJuta"
        lblTigaPuluhJuta.Size = New Size(222, 15)
        lblTigaPuluhJuta.TabIndex = 6
        lblTigaPuluhJuta.Text = "Pendapatan lebih dari 30 juta , 20% Pajak"
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(149, 256)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(75, 23)
        btnKeluar.TabIndex = 7
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' lblSeratusJuta
        ' 
        lblSeratusJuta.AutoSize = True
        lblSeratusJuta.Location = New Point(92, 116)
        lblSeratusJuta.Name = "lblSeratusJuta"
        lblSeratusJuta.Size = New Size(228, 15)
        lblSeratusJuta.TabIndex = 8
        lblSeratusJuta.Text = "Pendapatan lebih dari 100 juta , 30% Pajak"
        ' 
        ' FrmPajak
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(380, 450)
        Controls.Add(lblSeratusJuta)
        Controls.Add(btnKeluar)
        Controls.Add(lblTigaPuluhJuta)
        Controls.Add(lblLimaJuta)
        Controls.Add(btnHitung)
        Controls.Add(txtPendapatan)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmPajak"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pajak"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents lblLimaJuta As Label
    Friend WithEvents lblTigaPuluhJuta As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblSeratusJuta As Label
End Class
