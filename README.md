# ARIDCardProject_v2

> Project AR (Augmented Reality) berbasis Unity menggunakan Vuforia Engine.
> *(Ganti baris ini dengan deskripsi singkat fungsi aplikasi/lab kamu.)*

## ⚠️ Penting: Project ini pakai Git LFS

Salah satu file package (**Vuforia Engine `.tgz`**, ~132MB) disimpan pakai **Git LFS** (Large File Storage), bukan git biasa — karena GitHub punya limit 100MB per file.

Kalau kamu clone repo ini **tanpa Git LFS ter-install**, file itu cuma bakal ke-download sebagai file pointer teks kecil (bukan file asli), dan Unity **bakal gagal resolve package Vuforia-nya**. Jadi langkah install Git LFS di bawah ini **jangan sampai dilewatin**.

## Requirement Sebelum Mulai

- [Unity Hub](https://unity.com/download) sudah ter-install
- Unity Editor versi yang sesuai — cek file `ProjectSettings/ProjectVersion.txt` di repo ini, atau biarkan Unity Hub otomatis minta install versi yang cocok pas buka project
- [Git](https://git-scm.com/downloads) sudah ter-install
- [Git LFS](https://git-lfs.com) sudah ter-install (**wajib!**)

## Cara Install / Clone Project

### 1. Install Git LFS (sekali per komputer, bukan per-repo)
```bash
git lfs install
```

### 2. Clone repo ini
```bash
git clone https://github.com/FizhHaXD/ARIDCardProject_v2.git
```
Kalau Git LFS udah aktif sebelum clone, file besar (`.tgz` Vuforia) otomatis ikut ke-download penuh.

> **Kalau kamu terlanjur clone SEBELUM install Git LFS**, masuk ke folder project lalu jalankan:
> ```bash
> git lfs pull
> ```
> supaya file LFS-nya ke-download ulang dengan benar.

### 3. Buka project lewat Unity Hub
1. Buka **Unity Hub**
2. Klik **Add** → **Add project from disk**
3. Pilih folder hasil clone tadi (folder yang isinya ada `Assets`, `Packages`, `ProjectSettings`, dll)
4. Kalau Unity Hub minta install versi Editor tertentu → klik **Install**, ikutin aja
5. Buka project-nya

### 4. Tunggu Unity resolve semua package
Saat pertama kali dibuka, Unity otomatis import semua package dari `Packages/manifest.json`, termasuk **Vuforia Engine** dari file `.tgz` yang tadi ke-download lewat LFS. Proses ini bisa makan waktu beberapa menit — biarin sampai selesai, jangan ditutup di tengah jalan.

### 5. Aktivasi License Vuforia (kalau belum)
Vuforia butuh license key biar AR tracking-nya jalan:
1. Buka **Vuforia Engine → Configuration** di Unity
2. Masukkan **App License Key** dari [Vuforia Developer Portal](https://developer.vuforia.com/)
3. Belum punya akun/license? Daftar dulu di portal tersebut (gratis untuk development)

## Troubleshooting

| Masalah | Kemungkinan Penyebab | Solusi |
|---|---|---|
| Package Vuforia gagal resolve / error "file not found" | Git LFS belum ter-install pas clone | `git lfs install` lalu `git lfs pull` di folder project |
| File `.tgz` ukurannya cuma beberapa KB | LFS belum jalan, itu masih pointer file | Sama seperti di atas |
| Unity minta versi Editor yang beda | Versi di Unity Hub belum sesuai | Cek `ProjectSettings/ProjectVersion.txt`, install versi itu lewat Unity Hub |
| Kamera AR nggak muncul / tracking nggak jalan | Belum masukin License Key | Isi App License Key di Vuforia Configuration |

## Tech Stack

- Unity + Universal Render Pipeline (URP)
- Vuforia Engine 11.4.4 (AR tracking)
- Unity Input System
