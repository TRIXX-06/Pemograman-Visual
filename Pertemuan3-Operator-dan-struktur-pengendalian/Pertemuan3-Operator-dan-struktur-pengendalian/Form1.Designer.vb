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
        Label1 = New Label()
        txtNilai = New TextBox()
        picImage = New PictureBox()
        btnInput = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(133, 183)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' txtNilai
        ' 
        txtNilai.Location = New Point(154, 175)
        txtNilai.Name = "txtNilai"
        txtNilai.Size = New Size(145, 23)
        txtNilai.TabIndex = 1
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(177, 40)
        picImage.Name = "picImage"
        picImage.Size = New Size(100, 94)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 2
        picImage.TabStop = False
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(193, 220)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(75, 23)
        btnInput.TabIndex = 3
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(473, 450)
        Controls.Add(btnInput)
        Controls.Add(picImage)
        Controls.Add(txtNilai)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNilai As TextBox
    Friend WithEvents picImage As PictureBox
    Friend WithEvents btnInput As Button

End Class
