<div align="center">

# PERTEMUAN 03
### Operator, Struktur Pengendalian, dan Validasi Input (VB.NET)

</div>

---

## 1. Deskripsi Praktikum

Praktikum ini berfokus pada penerapan logika komputasi dan kendali alur eksekusi program pada arsitektur **Windows Forms** menggunakan bahasa **Visual Basic .NET (VB.NET)**.

Studi kasus yang digunakan adalah sistem evaluasi nilai berdasarkan rentang skor. Program dilengkapi dengan validasi input untuk memastikan data yang dimasukkan berupa angka dan berada pada rentang **0 – 100**.

Selain itu, program juga menerapkan manipulasi aset gambar secara *runtime* berdasarkan hasil evaluasi nilai.

---

## 2. Arsitektur Komponen Visual (UI Controls)

| Kontrol UI | Identitas `(Name)` | Properti Kunci | Deskripsi Fungsional |
| :--- | :--- | :--- | :--- |
| **PictureBox** | `picImage` | `SizeMode: StretchImage` | Menampilkan gambar berdasarkan hasil evaluasi nilai |
| **TextBox** | `txtNilai` | `Text: ""` | Tempat memasukkan nilai numerik |
| **Button** | `btnInput` | `Text: "Input"` | Menjalankan proses validasi dan evaluasi nilai |

---

## 3. Logika Kode (`Form1.vb`)

```vb
Public Class Form1

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilai As Integer

        ' Validasi format numerik
        If Not Integer.TryParse(txtNilai.Text, nilai) Then
            MessageBox.Show("Masukkan dalam bentuk angka")
            txtNilai.Focus()
            Return
        End If

        ' Validasi jangkauan nilai 0 - 100
        If nilai < 0 OrElse nilai > 100 Then
            MessageBox.Show("Masukkan Nilai 0-100")
            txtNilai.Focus()
            Return
        End If

        ' Struktur pengkondisian pemilihan aset
        If nilai <= 50 Then
            picImage.Image = Image.FromFile("Asset\1.jpeg")
        ElseIf nilai <= 70 Then
            picImage.Image = Image.FromFile("Asset\2.png")
        Else
            picImage.Image = Image.FromFile("Asset\3.png")
        End If
    End Sub

    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        ' Restriksi karakter: hanya menerima angka dan tombol kontrol
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class
```

---

## 4. Pembahasan Detail Konsep Teknis

### `Integer.TryParse`
Digunakan untuk mengubah data bertipe `String` menjadi `Integer` dengan cara yang lebih aman. Jika input tidak valid atau kosong, program tidak akan mengalami *runtime exception*.

### Operator `OrElse` dan `AndAlso`
Kedua operator tersebut menggunakan konsep **short-circuiting**, yaitu evaluasi kondisi akan dihentikan apabila hasil akhirnya sudah dapat ditentukan.
- `OrElse` berhenti ketika kondisi pertama bernilai `True`.
- `AndAlso` berhenti ketika kondisi pertama bernilai `False`.

### Event Handler `KeyPress` dan `e.Handled`
Event `KeyPress` digunakan untuk membatasi karakter yang dapat dimasukkan ke dalam `TextBox`.

Program hanya mengizinkan:
- Angka `0 – 9`
- Tombol kontrol seperti `Backspace`

Jika karakter bukan angka atau tombol kontrol, maka `e.Handled = True` digunakan untuk mencegah karakter tersebut masuk ke dalam `TextBox`.

### Manajemen Aset dengan `Image.FromFile`
`Image.FromFile()` digunakan untuk memuat gambar secara dinamis berdasarkan kondisi nilai.

File gambar menggunakan **relative path**:
```text
Asset\1.jpeg
Asset\2.png
Asset\3.png
```

> [!NOTE]
> Pastikan file gambar berada pada folder `Asset` dan properti **Copy to Output Directory** diatur menjadi **Copy if newer** agar file tersedia ketika aplikasi dijalankan.

---

## 5. Aturan Bisnis & Logika Evaluasi Skor

| Rentang Nilai | Kondisi Logika | Output Aset | Aksi Sistem |
| :--- | :--- | :--- | :--- |
| **0 – 50** | `nilai <= 50` | `Asset\1.jpeg` | Menampilkan gambar tingkat rendah |
| **51 – 70** | `nilai > 50 AndAlso nilai <= 70` | `Asset\2.png` | Menampilkan gambar tingkat menengah |
| **71 – 100** | `nilai > 70 AndAlso nilai <= 100` | `Asset\3.png` | Menampilkan gambar tingkat tinggi |
| **Di luar 0 – 100** | `nilai < 0 OrElse nilai > 100` | `-` | Menampilkan dialog peringatan |

---

## 6. Kesimpulan

Pada praktikum ini diterapkan beberapa konsep dasar pemrograman menggunakan **VB.NET**, yaitu:

1. Validasi input menggunakan `Integer.TryParse`.
2. Penggunaan operator logika `OrElse` dan `AndAlso`.
3. Penggunaan struktur percabangan `If...ElseIf...Else`.
4. Pembatasan input menggunakan event `KeyPress`.
5. Penggunaan `e.Handled` untuk mencegah karakter yang tidak valid.
6. Pemanggilan dan manipulasi gambar menggunakan `Image.FromFile`.
7. Penggunaan aset eksternal dengan **relative path**.

Dengan konsep tersebut, program dapat menerima input nilai, melakukan validasi, mengevaluasi rentang nilai, kemudian menampilkan gambar yang sesuai dengan hasil evaluasi.