Public Class FrmLogin

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.SelectedItem IsNot Nothing Then
            Dim selectedRole As String = cmbRole.SelectedItem.ToString()

            If selectedRole = "Manager" Then
                picImage.Image = Image.FromFile("Asset\manajer.png")
            ElseIf selectedRole = "Staff" Then
                picImage.Image = Image.FromFile("Asset\staff.png")
            End If
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cmbRole.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih Role terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Nama tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNIM.Text) Then
            MessageBox.Show("NIM tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIM.Focus()
            Return
        End If

        Dim role As String = cmbRole.SelectedItem.ToString()
        Dim namaInput As String = txtNama.Text.Trim().ToLower()
        Dim nimInput As String = txtNIM.Text.Trim()

        Dim isValid As Boolean = False

        If role = "Staff" AndAlso namaInput = "nadya" AndAlso nimInput = "241712051" Then
            isValid = True
        ElseIf role = "Manager" AndAlso namaInput = "shata diyaul haq" AndAlso nimInput = "241712061" Then
            isValid = True
        End If

        If isValid Then
            txtNama.Clear()
            txtNIM.Clear()

            FrmPajak.Show()
            Me.Hide()
        Else
            MessageBox.Show("Kombinasi Role, Nama, atau NIM tidak sesuai!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNIM.Focus()
        End If
    End Sub

End Class