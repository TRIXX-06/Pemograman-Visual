# Pengenalan Pemrograman Visual

## 1. Pengenalan

Pemrograman Visual adalah metode pemrograman untuk membuat aplikasi dengan memanfaatkan lingkungan pengembangan terpadu (Integrated Development Environment/IDE) yang menyediakan tampilan visual. Dengan metode ini, pengembang dapat merancang antarmuka menggunakan komponen seperti form, tombol, label, kotak teks, menu, dan komponen lainnya, kemudian mengatur perilakunya melalui kode program.

Pada mata kuliah **Praktikum Pemrograman Visual**, mahasiswa akan mempelajari cara membuat aplikasi desktop secara bertahap. Praktikum dimulai dari pengenalan IDE, pembuatan form, penggunaan kontrol antarmuka, penulisan kode Visual Basic, pengolahan input pengguna, sampai pembuatan aplikasi yang dapat dijalankan.

## 2. Pengertian Pemrograman Visual

Pemrograman Visual adalah pemrograman yang menggabungkan:

- **Perancangan antarmuka grafis (GUI)** secara visual.
- **Penulisan kode program** untuk mengatur logika dan respons aplikasi.
- **Pemrograman berbasis event**, yaitu kode dijalankan ketika suatu peristiwa terjadi, misalnya tombol diklik, form dibuka, atau isi kotak teks berubah.

Berbeda dengan program berbasis teks yang biasanya dijalankan melalui terminal, aplikasi visual menyediakan interaksi melalui jendela dan elemen grafis. Namun, desain visual saja belum cukup. Setiap kontrol harus diberi kode agar dapat melakukan fungsi yang diinginkan.

### Istilah penting

| Istilah | Pengertian |
| --- | --- |
| **IDE** | Aplikasi untuk menulis, menjalankan, menguji, dan memperbaiki kode program. |
| **Form** | Jendela atau halaman utama tempat kontrol aplikasi diletakkan. |
| **Control** | Komponen antarmuka seperti Button, Label, TextBox, ComboBox, dan CheckBox. |
| **Event** | Peristiwa yang dapat memicu kode, contohnya `Click` dan `Load`. |
| **Property** | Atribut suatu objek, contohnya `Name`, `Text`, `Size`, dan `BackColor`. |
| **Method** | Tindakan atau fungsi yang dapat dijalankan oleh suatu objek. |
| **Event handler** | Prosedur kode yang menangani event tertentu. |
| **.NET** | Platform pengembangan untuk membuat dan menjalankan berbagai aplikasi. |
| **Visual Basic** | Bahasa pemrograman dari Microsoft yang digunakan untuk membangun aplikasi, termasuk aplikasi Windows Forms. |

## 3. Toolbox Visual Studio dan Fungsinya

**Toolbox** adalah panel pada Visual Studio yang berisi berbagai kontrol atau komponen untuk membangun antarmuka pengguna (GUI) pada Windows Forms. Kontrol dapat dipindahkan ke form dengan cara **drag and drop**, sehingga perancangan tampilan aplikasi dapat dilakukan secara visual tanpa menulis seluruh tampilan dari awal.

### Kontrol yang Sering Digunakan

| Kontrol | Fungsi |
| --- | --- |
| **Pointer** | Memilih, memindahkan, dan mengatur kontrol yang sudah berada di form. |
| **Button** | Menyediakan tombol yang dapat diklik untuk menjalankan perintah tertentu. |
| **Label** | Menampilkan teks atau keterangan yang tidak diisi langsung oleh pengguna. |
| **TextBox** | Menyediakan tempat bagi pengguna untuk memasukkan atau mengubah teks. |
| **RichTextBox** | Memasukkan dan menampilkan teks dengan format yang lebih lengkap dibandingkan TextBox biasa. |
| **CheckBox** | Memungkinkan pengguna memilih atau membatalkan satu pilihan secara mandiri. |
| **RadioButton** | Memungkinkan pengguna memilih satu pilihan dari beberapa pilihan dalam satu kelompok. |
| **ComboBox** | Menampilkan daftar pilihan dalam bentuk menu yang dapat dibuka. |
| **ListBox** | Menampilkan beberapa pilihan dalam bentuk daftar. |
| **PictureBox** | Menampilkan gambar pada form. |
| **Panel** | Mengelompokkan beberapa kontrol agar tampilan form lebih teratur. |
| **GroupBox** | Mengelompokkan kontrol yang memiliki hubungan atau fungsi yang sama, biasanya disertai judul. |
| **DateTimePicker** | Memudahkan pengguna memilih tanggal atau waktu. |
| **ProgressBar** | Menunjukkan kemajuan suatu proses dalam bentuk batang indikator. |
| **MenuStrip** | Membuat menu aplikasi seperti File, Edit, atau Help. |
| **Timer** | Menjalankan event secara berkala berdasarkan interval waktu tertentu. |

### Cara Menggunakan Toolbox

1. Buka project Windows Forms di Visual Studio.
2. Pastikan panel **Toolbox** terlihat. Jika belum terlihat, pilih menu **View > Toolbox** atau tekan `Ctrl+Alt+X`.
3. Cari kontrol yang diperlukan pada kotak pencarian Toolbox.
4. Seret kontrol dari Toolbox ke area **Form Designer**, atau klik dua kali nama kontrol untuk menambahkannya ke form.
5. Pilih kontrol pada form, lalu ubah pengaturannya melalui **Properties Window**.
6. Atur property penting seperti `Name`, `Text`, `Size`, `Location`, `Font`, dan `BackColor` sesuai kebutuhan.
7. Klik dua kali kontrol, misalnya **Button**, untuk membuat event handler `Click` dan menuliskan kode Visual Basic.
8. Jalankan project menggunakan tombol **Start** atau tombol `F5` untuk menguji tampilan dan fungsi kontrol.

### Hubungan Toolbox, Properties, dan Kode Program

Toolbox digunakan untuk menambahkan kontrol, **Properties Window** digunakan untuk mengatur karakteristik kontrol, sedangkan **Code Editor** digunakan untuk menulis logika program. Sebagai contoh, sebuah Button dapat ditambahkan dari Toolbox, teksnya diubah menjadi **Simpan** melalui property `Text`, lalu diberi kode pada event `Click` agar menjalankan proses penyimpanan data.

Dengan memahami Toolbox dan fungsi kontrolnya, mahasiswa dapat membuat rancangan aplikasi yang lebih terstruktur sebelum mempelajari logika program, event, validasi input, dan debugging secara lebih mendalam.

## 4. Perangkat yang Dibutuhkan

- Komputer atau laptop berbasis Windows yang memenuhi persyaratan sistem Visual Studio.
- Koneksi internet yang stabil untuk mengunduh installer dan komponen .NET.
- Akun Microsoft, jika diminta oleh Visual Studio untuk aktivasi atau penggunaan fitur tertentu.
- Ruang penyimpanan yang cukup. Ukuran instalasi bergantung pada workload dan komponen yang dipilih.

Untuk praktikum dasar, gunakan **Visual Studio Community** karena tersedia gratis untuk penggunaan individu, pembelajaran, dan pengembangan yang memenuhi ketentuan lisensinya. Gunakan hanya installer dari situs resmi Microsoft.

## 5. Cara Mengunduh Visual Studio

1. Buka browser, lalu kunjungi [visualstudio.microsoft.com](https://visualstudio.microsoft.com/).
2. Pilih menu **Downloads** atau buka halaman [Visual Studio Downloads](https://visualstudio.microsoft.com/downloads/).
3. Pada bagian **Visual Studio**, pilih **Community** lalu klik **Free download**. Edisi Professional dan Enterprise juga tersedia, tetapi memerlukan lisensi atau langganan sesuai ketentuan Microsoft.
4. Simpan file installer, kemudian buka file tersebut setelah proses download selesai.
5. Jika Windows menampilkan konfirmasi keamanan, pilih **Yes** untuk menjalankan installer.
6. Tunggu **Visual Studio Installer** memuat daftar komponen yang tersedia.

## 6. Cara Menginstal .NET melalui Visual Studio

Komponen .NET dipilih dari **Visual Studio Installer**, bukan hanya dari aplikasi Visual Studio yang sudah terbuka. Untuk membuat aplikasi desktop menggunakan Visual Basic, lakukan langkah berikut:

1. Pada tab **Workloads**, centang **.NET desktop development**.
2. Pastikan workload tersebut menampilkan dukungan untuk **Windows Forms** dan **Visual Basic**. Komponen bahasa biasanya dipasang sebagai bagian dari dukungan .NET desktop.
3. Pada panel **Installation details**, periksa komponen .NET yang akan dipasang. Pilih versi .NET yang dibutuhkan oleh materi atau project praktikum.
4. Jika perlu memilih versi atau komponen tambahan, buka tab **Individual components**, lalu cari dan centang .NET SDK atau target framework .NET yang diperlukan.
5. Pilih lokasi instalasi jika diperlukan. Lokasi default biasanya paling aman untuk pemula.
6. Klik **Install** atau **Modify**.
7. Tunggu sampai pengunduhan dan pemasangan selesai. Lama proses bergantung pada kecepatan internet dan spesifikasi komputer.
8. Jika diminta, lakukan restart komputer.

> **Catatan:** .NET SDK digunakan untuk membangun dan mengompilasi aplikasi, sedangkan .NET Runtime digunakan untuk menjalankan aplikasi. Workload **.NET desktop development** memasang komponen yang umum diperlukan untuk pengembangan aplikasi desktop. Jika project menggunakan target framework tertentu, pastikan target framework tersebut juga terpasang melalui Visual Studio Installer.

## 7. Memastikan Instalasi Berhasil

1. Buka **Visual Studio**.
2. Pilih **Create a new project**.
3. Cari `Windows Forms App`.
4. Pilih bahasa **Visual Basic** dan framework .NET yang sesuai, lalu klik **Next**.
5. Masukkan nama project dan lokasi penyimpanan, kemudian klik **Create**.
6. Pastikan form dan **Toolbox** tampil. Tambahkan sebuah **Button** ke form, lalu jalankan project dengan tombol **Start** atau tombol `F5`.
7. Jika aplikasi berjalan dan form dapat ditampilkan, instalasi dasar Visual Studio, Visual Basic, dan .NET telah siap digunakan.

Jika template Windows Forms atau pilihan Visual Basic tidak muncul, tutup Visual Studio, buka kembali **Visual Studio Installer**, pilih instalasi Visual Studio, klik **Modify**, lalu pastikan workload **.NET desktop development** sudah dicentang. Setelah itu, perbarui atau pasang komponen yang diperlukan.

## 8. Kesimpulan

Pemrograman Visual membantu pengembang membuat aplikasi dengan antarmuka grafis dan kode yang merespons berbagai event. Visual Studio berfungsi sebagai IDE, Visual Basic berfungsi sebagai bahasa pemrograman, dan .NET menyediakan platform serta komponen untuk membangun dan menjalankan aplikasi. Dengan memasang workload **.NET desktop development**, mahasiswa dapat mulai membuat project Windows Forms Visual Basic untuk mengikuti Praktikum Pemrograman Visual.

### Referensi Resmi

- [Visual Studio - Situs Resmi Microsoft](https://visualstudio.microsoft.com/)
- [Unduhan Visual Studio](https://visualstudio.microsoft.com/downloads/)
- [Dokumentasi Visual Basic](https://learn.microsoft.com/dotnet/visual-basic/)
- [Dokumentasi .NET Desktop Guide](https://learn.microsoft.com/dotnet/desktop/)
