🎓 RuangQuiz – Aplikasi Media & Kuis Interaktif Berbasis VB.NET + MySQL

RuangQuiz adalah aplikasi pembelajaran berbasis desktop yang dirancang untuk mempermudah proses belajar dan evaluasi menggunakan media materi, tugas, dan kuis interaktif. Aplikasi ini dapat digunakan oleh dua jenis pengguna, yaitu Guru dan Pelajar, masing-masing dengan fungsi dan akses yang berbeda.

Aplikasi ini mendukung sistem login, manajemen konten pembelajaran, hingga penilaian tugas dan kuis oleh guru, dan dapat menampilkan nilai yang hanya relevan dengan tiap pengguna (user-based access).

✨ Fitur Utama

👨‍🏫 Untuk Pelajar
Login & Register user
Akses materi
Akses kuis
Upload tugas
Melihat nilai tugas

🧑‍🏫 Untuk Guru

Upload materi
Mengelola tugas dan kuis
Melihat daftar siswa
Memberikan nilai tugas

🗃 Database

Menggunakan MySQL dengan tabel:
users
materi
tugas
pengumpulan_tugas
nilai

Aplikasi sudah mendukung:
CRUD Materi
CRUD Tugas
Filtering nilai berdasarkan ID user

🚀 Cara Menggunakan

Buka folder project
Import database ke MySQL
Sesuaikan koneksi:
MySqlConnection("server=localhost;user id=root;password=;database=kuis_db")
Run project melalui Visual Studio

👥 Roles Pengguna

Pelajar:
Melihat dan mengunduh materi
Mengikuti kuis
Mengirim tugas
Melihat nilai tugas pribadi

Guru:
Mengelola konten (materi & tugas)
Memberikan penilaian
Melihat daftar siswa

🚧 Status Pengembangan

Aplikasi sudah berjalan dengan baik dan mendukung fitur utama. Pengembangan lanjutan yang bisa ditambah:

Export nilai ke excel
Timer kuis
Role admin terpisah
Statistik belajar siswa