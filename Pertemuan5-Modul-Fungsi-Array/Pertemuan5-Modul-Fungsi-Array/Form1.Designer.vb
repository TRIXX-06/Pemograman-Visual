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
        btnTampilkan = New Button()
        txtPanjang = New TextBox()
        txtLebar = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lstNilai = New ListBox()
        SuspendLayout()
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(333, 222)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(112, 34)
        btnTampilkan.TabIndex = 0
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' txtPanjang
        ' 
        txtPanjang.Location = New Point(310, 89)
        txtPanjang.Name = "txtPanjang"
        txtPanjang.Size = New Size(150, 31)
        txtPanjang.TabIndex = 1
        ' 
        ' txtLebar
        ' 
        txtLebar.Location = New Point(310, 164)
        txtLebar.Name = "txtLebar"
        txtLebar.Size = New Size(150, 31)
        txtLebar.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(310, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 25)
        Label1.TabIndex = 3
        Label1.Text = "Panjang :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(310, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 25)
        Label2.TabIndex = 4
        Label2.Text = "Lebar :"
        ' 
        ' lstNilai
        ' 
        lstNilai.FormattingEnabled = True
        lstNilai.Location = New Point(295, 276)
        lstNilai.Name = "lstNilai"
        lstNilai.Size = New Size(180, 129)
        lstNilai.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstNilai)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtLebar)
        Controls.Add(txtPanjang)
        Controls.Add(btnTampilkan)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampilkan As Button
    Friend WithEvents txtPanjang As TextBox
    Friend WithEvents txtLebar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstNilai As ListBox

End Class
