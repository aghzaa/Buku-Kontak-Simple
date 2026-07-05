using System.ComponentModel;

namespace Buku_Kontak
{
    public partial class Form1 : Form
    {
        // ===================== STATE & DATA =====================

        /// <summary>Master list — menyimpan semua kontak.</summary>
        private readonly List<Kontak> _semuaKontak = new();

        /// <summary>Index baris yang sedang di-edit. -1 = mode tambah.</summary>
        private int _indexEdit = -1;

        /// <summary>Kategori filter yang sedang aktif.</summary>
        private string _filterKategori = "Semua";

        // Referensi tombol filter agar mudah di-loop saat styling.
        private Button[] _tombolFilter = [];

        // ===================== INISIALISASI =====================

        public Form1()
        {
            InitializeComponent();
            InisialisasiForm();
        }

        /// <summary>
        /// Setup awal: isi dropdown, bindingkan DataGridView, dan
        /// persiapkan state default.
        /// </summary>
        private void InisialisasiForm()
        {
            // Kumpulkan tombol filter ke array untuk kemudahan styling
            _tombolFilter = [btnFilterSemua, btnFilterKeluarga, btnFilterTeman, btnFilterBisnis];

            // Isi combo box kategori
            cboKategori.Items.AddRange(["Keluarga", "Teman", "Bisnis"]);
            cboKategori.SelectedIndex = 0;

            // Styling DataGridView
            StylingDataGridView();

            // Set state awal
            SetFilterAktif(btnFilterSemua);
            RefreshTampilan();
        }

        // ==================== C R E A T E ====================

        /// <summary>Menambahkan kontak baru ke master list.</summary>
        private void TambahKontak(Kontak kontak)
        {
            _semuaKontak.Add(kontak);
            RefreshTampilan();
        }

        // ==================== R E A D ====================

        /// <summary>
        /// Menerapkan filter kategori dan pencarian, lalu
        /// menampilkan hasilnya di DataGridView.
        /// </summary>
        private void RefreshTampilan()
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            // Mulai dari semua kontak
            IEnumerable<Kontak> hasil = _semuaKontak;

            // Filter berdasarkan kategori (jika bukan "Semua")
            if (_filterKategori != "Semua")
                hasil = hasil.Where(k => k.Kategori == _filterKategori);

            // Filter berdasarkan kata kunci pencarian
            if (!string.IsNullOrEmpty(keyword))
                hasil = hasil.Where(k =>
                    k.Nama.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ||
                    k.NomorTelepon.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ||
                    k.Email.Contains(keyword, StringComparison.CurrentCultureIgnoreCase));

            // Rebind DataGridView dengan hasil filter
            dgvKontak.DataSource = new BindingList<Kontak>(hasil.ToList());

            // Update statistik di sidebar & footer
            UpdateStatistik();
        }

        // ==================== U P D A T E ====================

        /// <summary>Memperbarui data kontak pada index tertentu.</summary>
        private void UpdateKontak(int index, Kontak kontakBaru)
        {
            _semuaKontak[index] = kontakBaru;
            RefreshTampilan();
        }

        // ==================== D E L E T E ====================

        /// <summary>Menghapus kontak pada index tertentu dari master list.</summary>
        private void HapusKontak(int index)
        {
            _semuaKontak.RemoveAt(index);
            RefreshTampilan();
        }

        // ==================== VALIDASI ====================

        /// <summary>
        /// Memvalidasi input form. Menampilkan pesan error dan
        /// mem-focus field yang bermasalah.
        /// </summary>
        private bool ValidasiInput()
        {
            // Nama wajib diisi
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                TampilkanPeringatan("Nama tidak boleh kosong!");
                txtNama.Focus();
                return false;
            }

            // Nomor telepon wajib diisi
            if (string.IsNullOrWhiteSpace(txtTelepon.Text))
            {
                TampilkanPeringatan("Nomor telepon tidak boleh kosong!");
                txtTelepon.Focus();
                return false;
            }

            // Nomor telepon hanya boleh angka, +, dan -
            if (!txtTelepon.Text.All(c => char.IsDigit(c) || c == '+' || c == '-'))
            {
                TampilkanPeringatan("Nomor telepon hanya boleh berisi angka, + dan -");
                txtTelepon.Focus();
                return false;
            }

            // Kategori wajib dipilih
            if (cboKategori.SelectedIndex < 0)
            {
                TampilkanPeringatan("Pilih kategori terlebih dahulu!");
                cboKategori.Focus();
                return false;
            }

            return true;
        }

        /// <summary>Shortcut untuk menampilkan MessageBox peringatan.</summary>
        private static void TampilkanPeringatan(string pesan)
        {
            MessageBox.Show(pesan, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ==================== UI HELPERS ====================

        /// <summary>Membuat objek Kontak dari input form saat ini.</summary>
        private Kontak AmbilDataDariForm()
        {
            return new Kontak
            {
                Nama = txtNama.Text.Trim(),
                NomorTelepon = txtTelepon.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Kategori = cboKategori.Text
            };
        }

        /// <summary>Mengosongkan form dan kembali ke mode Tambah.</summary>
        private void ResetForm()
        {
            txtNama.Clear();
            txtTelepon.Clear();
            txtEmail.Clear();
            cboKategori.SelectedIndex = 0;

            _indexEdit = -1;
            lblFormTitle.Text = "➕  Tambah Kontak Baru";
            btnSimpan.Text = "💾  Simpan";
            btnSimpan.BackColor = Warna.Hijau;
        }

        /// <summary>Mengisi form dari data kontak yang dipilih (mode Edit).</summary>
        private void MasukModeEdit(Kontak kontak, int indexMaster)
        {
            txtNama.Text = kontak.Nama;
            txtTelepon.Text = kontak.NomorTelepon;
            txtEmail.Text = kontak.Email;
            cboKategori.Text = kontak.Kategori;

            _indexEdit = indexMaster;
            lblFormTitle.Text = "✏️  Edit Kontak";
            btnSimpan.Text = "💾  Update";
            btnSimpan.BackColor = Warna.Biru;
            txtNama.Focus();
        }

        /// <summary>Update label statistik di sidebar dan footer tabel.</summary>
        private void UpdateStatistik()
        {
            int total = _semuaKontak.Count;
            int tampil = dgvKontak.Rows.Count;

            lblStatsCount.Text = total.ToString();
            lblJumlahData.Text = $"Menampilkan {tampil} dari {total} kontak";
        }

        /// <summary>Meng-highlight tombol filter yang aktif.</summary>
        private void SetFilterAktif(Button btnAktif)
        {
            foreach (Button btn in _tombolFilter)
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Warna.TextRedup;
            }

            btnAktif.BackColor = Warna.SidebarHover;
            btnAktif.ForeColor = Color.White;
        }

        /// <summary>
        /// Menemukan index kontak di master list berdasarkan
        /// baris yang dipilih di DataGridView (yang mungkin ter-filter).
        /// </summary>
        private int CariIndexMaster(Kontak kontakTampil)
        {
            return _semuaKontak.FindIndex(k =>
                k.Nama == kontakTampil.Nama &&
                k.NomorTelepon == kontakTampil.NomorTelepon &&
                k.Email == kontakTampil.Email &&
                k.Kategori == kontakTampil.Kategori);
        }

        /// <summary>Kustomisasi tampilan DataGridView.</summary>
        private void StylingDataGridView()
        {
            dgvKontak.EnableHeadersVisualStyles = false;
            dgvKontak.ColumnHeadersDefaultCellStyle.BackColor = Warna.Sidebar;
            dgvKontak.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKontak.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F);
            dgvKontak.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            dgvKontak.ColumnHeadersHeight = 45;

            dgvKontak.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvKontak.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            dgvKontak.DefaultCellStyle.SelectionBackColor = Warna.BiruMuda;
            dgvKontak.DefaultCellStyle.SelectionForeColor = Warna.Sidebar;

            dgvKontak.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);

            dgvKontak.RowTemplate.Height = 40;
            dgvKontak.RowHeadersVisible = false;
            dgvKontak.AllowUserToAddRows = false;
            dgvKontak.AllowUserToDeleteRows = false;
            dgvKontak.ReadOnly = true;
            dgvKontak.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKontak.MultiSelect = false;
            dgvKontak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKontak.BorderStyle = BorderStyle.None;
            dgvKontak.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKontak.GridColor = Color.FromArgb(226, 232, 240);
            dgvKontak.BackgroundColor = Color.White;
        }

        // ==================== EVENT HANDLERS ====================

        /// <summary>Klik Simpan — Create baru atau Update yang sudah ada.</summary>
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            Kontak kontak = AmbilDataDariForm();

            if (_indexEdit >= 0)
            {
                // MODE UPDATE — perbarui data pada index yang sedang di-edit
                UpdateKontak(_indexEdit, kontak);
            }
            else
            {
                // MODE CREATE — tambahkan kontak baru
                TambahKontak(kontak);
            }

            ResetForm();
        }

        /// <summary>Klik Batal — kosongkan form dan kembali ke mode Tambah.</summary>
        private void BtnBatal_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        /// <summary>Klik Edit — muat data baris terpilih ke form.</summary>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvKontak.SelectedRows.Count == 0)
            {
                TampilkanPeringatan("Pilih kontak yang ingin di-edit terlebih dahulu!");
                return;
            }

            // Ambil kontak dari baris yang dipilih
            if (dgvKontak.SelectedRows[0].DataBoundItem is not Kontak kontakTerpilih) return;

            // Cari index aslinya di master list
            int indexMaster = CariIndexMaster(kontakTerpilih);

            if (indexMaster >= 0)
                MasukModeEdit(kontakTerpilih, indexMaster);
        }

        /// <summary>Klik Hapus — hapus baris terpilih setelah konfirmasi.</summary>
        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (dgvKontak.SelectedRows.Count == 0)
            {
                TampilkanPeringatan("Pilih kontak yang ingin dihapus terlebih dahulu!");
                return;
            }

            if (dgvKontak.SelectedRows[0].DataBoundItem is not Kontak kontakTerpilih) return;

            // Konfirmasi sebelum menghapus
            DialogResult konfirmasi = MessageBox.Show(
                $"Yakin ingin menghapus kontak \"{kontakTerpilih.Nama}\"?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi != DialogResult.Yes) return;

            int indexMaster = CariIndexMaster(kontakTerpilih);

            if (indexMaster >= 0)
            {
                HapusKontak(indexMaster);
                ResetForm(); // Keluar dari mode edit jika yang di-edit terhapus
            }
        }

        /// <summary>Pencarian real-time saat user mengetik di search box.</summary>
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshTampilan();
        }

        // ---------- Filter Kategori ----------

        private void BtnFilterSemua_Click(object sender, EventArgs e)
        {
            _filterKategori = "Semua";
            SetFilterAktif(btnFilterSemua);
            lblPageTitle.Text = "📋  Semua Kontak";
            RefreshTampilan();
        }

        private void BtnFilterKeluarga_Click(object sender, EventArgs e)
        {
            _filterKategori = "Keluarga";
            SetFilterAktif(btnFilterKeluarga);
            lblPageTitle.Text = "👨‍👩‍👧  Kontak Keluarga";
            RefreshTampilan();
        }

        private void BtnFilterTeman_Click(object sender, EventArgs e)
        {
            _filterKategori = "Teman";
            SetFilterAktif(btnFilterTeman);
            lblPageTitle.Text = "👥  Kontak Teman";
            RefreshTampilan();
        }

        private void BtnFilterBisnis_Click(object sender, EventArgs e)
        {
            _filterKategori = "Bisnis";
            SetFilterAktif(btnFilterBisnis);
            lblPageTitle.Text = "💼  Kontak Bisnis";
            RefreshTampilan();
        }

        /// <summary>Double-click pada baris DataGridView untuk langsung edit.</summary>
        private void DgvKontak_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            BtnEdit_Click(sender, e);
        }
    }

    // ===================== KONSTANTA WARNA =====================

    /// <summary>
    /// Kelas statis berisi konstanta warna untuk konsistensi
    /// tampilan di seluruh aplikasi.
    /// </summary>
    internal static class Warna
    {
        public static readonly Color Sidebar = Color.FromArgb(15, 23, 42);
        public static readonly Color SidebarHover = Color.FromArgb(30, 41, 59);
        public static readonly Color StatsCard = Color.FromArgb(30, 41, 59);
        public static readonly Color Background = Color.FromArgb(241, 245, 249);
        public static readonly Color Kartu = Color.White;
        public static readonly Color Hijau = Color.FromArgb(16, 185, 129);
        public static readonly Color Biru = Color.FromArgb(59, 130, 246);
        public static readonly Color BiruMuda = Color.FromArgb(219, 234, 254);
        public static readonly Color Merah = Color.FromArgb(239, 68, 68);
        public static readonly Color AbuAbu = Color.FromArgb(148, 163, 184);
        public static readonly Color TextGelap = Color.FromArgb(15, 23, 42);
        public static readonly Color TextRedup = Color.FromArgb(148, 163, 184);
        public static readonly Color Border = Color.FromArgb(226, 232, 240);
    }
}
