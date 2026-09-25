# Siskom Smeas — Sistem Informasi Kedisiplinan & Konseling Sekolah

Aplikasi desktop berbasis Windows Forms (C#) untuk membantu pihak sekolah mencatat, memantau, dan mengelola data pelanggaran siswa beserta status penanganannya secara terpusat. Dibangun sebagai solusi pengganti pencatatan manual yang selama ini rawan hilang, sulit dicari, dan tidak terdokumentasi dengan baik.

![Status](https://img.shields.io/badge/status-active-brightgreen)
![Platform](https://img.shields.io/badge/platform-Windows-blue)
![Language](https://img.shields.io/badge/language-C%23-239120)

---

## Daftar Isi

- [Latar Belakang](#latar-belakang)
- [Fitur Utama](#fitur-utama)
- [Teknologi yang Digunakan](#teknologi-yang-digunakan)
- [Struktur Basis Data](#struktur-basis-data)
- [Cara Menjalankan Proyek](#cara-menjalankan-proyek)
- [Struktur Proyek](#struktur-proyek)
- [Rencana Pengembangan](#rencana-pengembangan)
- [Kontak](#kontak)

---

## Latar Belakang

Di banyak sekolah, pencatatan pelanggaran siswa — mulai dari keterlambatan, ketidaklengkapan atribut, hingga pelanggaran yang lebih serius — masih dilakukan di buku catatan fisik oleh guru BK atau wali kelas. Cara ini punya beberapa kelemahan: data mudah hilang atau rusak, sulit direkap untuk keperluan evaluasi, dan tidak ada visibilitas terpusat bagi pihak sekolah untuk memantau tren pelanggaran maupun tindak lanjut konseling.

**Siskom Smeas** dibangun untuk menjawab masalah ini dengan menyediakan sistem pencatatan digital yang terstruktur, memisahkan hak akses antara **Administrator** dan **Guru**, serta menyimpan riwayat pelanggaran dan status konseling setiap siswa dalam satu basis data yang bisa diakses dan direkap kapan saja.

## Fitur Utama

**Autentikasi & Hak Akses**
- Login dengan verifikasi username dan password terhadap basis data.
- Dua peran pengguna dengan akses berbeda: **Administrator** dan **Guru**.

**Manajemen Data Master (Administrator)**
- Kelola data kategori pelanggaran beserta tingkat hukuman dan poin.
- Pencarian kategori pelanggaran secara real-time.
- Tambah, ubah, dan hapus data master.

**Pencatatan Pelanggaran (Guru & Administrator)**
- Catat pelanggaran siswa lengkap dengan kategori, deskripsi, tanggal kejadian, dan status konseling.
- Setiap catatan pelanggaran otomatis terhubung ke identitas pelapor yang sedang login.
- Riwayat pelanggaran ditampilkan dalam tabel yang menampilkan nama siswa, kategori, pelapor, status konseling, dan tanggal.

**Validasi Data**
- Validasi input wajib diisi sebelum data dapat disimpan.
- Validasi format dan panjang data numerik (misalnya NISN).
- Pencegahan duplikasi data melalui pengecekan constraint basis data.

## Teknologi yang Digunakan

| Komponen | Teknologi |
|---|---|
| Bahasa Pemrograman | C# |
| Framework UI | Windows Forms (.NET Framework) |
| ORM | Entity Framework 6 (Code/Database First) |
| Basis Data | Microsoft SQL Server |
| IDE | Visual Studio 2022 |
| Version Control | Git & GitHub |

## Struktur Basis Data

Basis data `db_siskom_smeas` terdiri dari beberapa tabel utama yang saling berelasi:

- **`users`** — menyimpan akun pengguna (Administrator dan Guru) beserta perannya.
- **`students`** — menyimpan data induk siswa.
- **`violation_categories`** — menyimpan jenis pelanggaran, tingkat hukuman, dan bobot poin.
- **`violation_records`** — menyimpan setiap catatan pelanggaran, dengan relasi foreign key ke `students`, `users` (sebagai pelapor), dan `violation_categories`.

Relasi antar tabel dijaga melalui foreign key constraint untuk memastikan konsistensi data — misalnya setiap catatan pelanggaran harus merujuk ke siswa dan pelapor yang benar-benar terdaftar di sistem.

## Cara Menjalankan Proyek

### Prasyarat

- Visual Studio 2022 (dengan workload **.NET desktop development**)
- SQL Server (Express/Developer/LocalDB)
- SQL Server Management Studio (opsional, untuk mengelola basis data)

### Langkah Instalasi

1. Clone repository ini:
   ```bash
   git clone https://github.com/Revrevayahthalib/project-siskomsmeas.git
   ```
2. Buka file solution `LKS_ITSoftware.sln` menggunakan Visual Studio.
3. Buat basis data `db_siskom_smeas` di SQL Server menggunakan skrip yang tersedia di folder `Database/` *(sesuaikan jika lokasi skrip berbeda)*.
4. Sesuaikan connection string pada `App.config` agar mengarah ke instance SQL Server milikmu.
5. Restore NuGet packages (klik kanan solution → **Restore NuGet Packages**).
6. Jalankan aplikasi dengan menekan `F5`.

### Akun Default untuk Pengujian

| Role | Username | Password |
|---|---|---|
| Administrator | admin | admin123 |
| Guru | gurubk1 | guru123 |

## Struktur Proyek

```
LKS_ITSoftware/
├── Forms/
│   ├── Form1.cs              # Halaman Login
│   ├── Form2.cs              # Dashboard/Menu Administrator
│   ├── Form3.cs              # Master Kategori Pelanggaran
│   └── Form6.cs              # Form Guru - Catat Pelanggaran
├── Helpers/
│   └── ValidationHelper.cs   # Validasi input form
├── Models/                   # Entity model hasil generate Entity Framework
├── Database/                 # Skrip pembuatan basis data
└── LKS_ITSoftware.sln
```

## Rencana Pengembangan

- [ ] Export laporan pelanggaran ke Excel/PDF
- [ ] Dashboard statistik dan grafik tren pelanggaran per periode
- [ ] Notifikasi otomatis ke wali kelas untuk pelanggaran tertentu
- [ ] Manajemen hak akses yang lebih granular

## Kontak

Dibuat oleh Revaya Helwa Thalib
📧 [Gmail](mailto:2009revayathalib@gmail.com) · 💼 [LinkedIn]([https://linkedin.com/in/username](https://www.linkedin.com/in/revaya-helwa-thalib-b26499376/)) · 🐙 [GitHub](https://github.com/Revrevayahthalib)

---

*Proyek ini dikembangkan sebagai bagian dari kompetisi/tugas LKS Bidang IT Software Solutions for Business.*
