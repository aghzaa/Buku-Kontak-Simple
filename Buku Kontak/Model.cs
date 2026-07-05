namespace Buku_Kontak
{
    /// <summary>
    /// Model data untuk merepresentasikan satu kontak.
    /// Properti menggunakan tipe string agar format data tetap terjaga
    /// (contoh: nomor telepon yang diawali angka 0).
    /// </summary>
    public class Kontak
    {
        public string Nama { get; set; } = string.Empty;
        public string NomorTelepon { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Kategori { get; set; } = string.Empty;
    }
}
