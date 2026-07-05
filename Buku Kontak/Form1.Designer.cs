namespace Buku_Kontak
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // === Deklarasi semua kontrol ===
            pnlSidebar = new Panel();
            lblAppIcon = new Label();
            lblAppName = new Label();
            pnlDivider1 = new Panel();
            pnlStatsCard = new Panel();
            lblStatsTitle = new Label();
            lblStatsCount = new Label();
            lblFilterTitle = new Label();
            btnFilterSemua = new Button();
            btnFilterKeluarga = new Button();
            btnFilterTeman = new Button();
            btnFilterBisnis = new Button();
            pnlTopBar = new Panel();
            lblPageTitle = new Label();
            txtSearch = new TextBox();
            pnlContent = new Panel();
            pnlInputCard = new Panel();
            lblFormTitle = new Label();
            lblNama = new Label();
            txtNama = new TextBox();
            lblTelepon = new Label();
            txtTelepon = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblKategori = new Label();
            cboKategori = new ComboBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            pnlGridCard = new Panel();
            lblGridTitle = new Label();
            dgvKontak = new DataGridView();
            pnlGridFooter = new Panel();
            lblJumlahData = new Label();
            btnEdit = new Button();
            btnHapus = new Button();

            pnlSidebar.SuspendLayout();
            pnlStatsCard.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlInputCard.SuspendLayout();
            pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKontak).BeginInit();
            pnlGridFooter.SuspendLayout();
            SuspendLayout();

            // ────────────────────────────────────────────
            //  SIDEBAR
            // ────────────────────────────────────────────
            pnlSidebar.BackColor = Color.FromArgb(15, 23, 42);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Width = 260;
            pnlSidebar.Padding = new Padding(20, 24, 20, 20);
            pnlSidebar.Controls.Add(btnFilterBisnis);
            pnlSidebar.Controls.Add(btnFilterTeman);
            pnlSidebar.Controls.Add(btnFilterKeluarga);
            pnlSidebar.Controls.Add(btnFilterSemua);
            pnlSidebar.Controls.Add(lblFilterTitle);
            pnlSidebar.Controls.Add(pnlStatsCard);
            pnlSidebar.Controls.Add(pnlDivider1);
            pnlSidebar.Controls.Add(lblAppName);
            pnlSidebar.Controls.Add(lblAppIcon);

            // App Icon
            lblAppIcon.Text = "📒";
            lblAppIcon.Font = new Font("Segoe UI Emoji", 32F);
            lblAppIcon.Location = new Point(20, 28);
            lblAppIcon.AutoSize = true;

            // App Name
            lblAppName.Text = "Buku Kontak";
            lblAppName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(80, 36);
            lblAppName.AutoSize = true;

            // Divider
            pnlDivider1.BackColor = Color.FromArgb(51, 65, 85);
            pnlDivider1.Location = new Point(20, 95);
            pnlDivider1.Size = new Size(220, 1);

            // ── Stats Card ──
            pnlStatsCard.BackColor = Color.FromArgb(30, 41, 59);
            pnlStatsCard.Location = new Point(20, 116);
            pnlStatsCard.Size = new Size(220, 90);
            pnlStatsCard.Controls.Add(lblStatsCount);
            pnlStatsCard.Controls.Add(lblStatsTitle);

            lblStatsTitle.Text = "TOTAL KONTAK";
            lblStatsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatsTitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblStatsTitle.Location = new Point(16, 14);
            lblStatsTitle.AutoSize = true;

            lblStatsCount.Text = "0";
            lblStatsCount.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblStatsCount.ForeColor = Color.FromArgb(56, 189, 248);
            lblStatsCount.Location = new Point(14, 38);
            lblStatsCount.AutoSize = true;

            // ── Filter Buttons ──
            lblFilterTitle.Text = "FILTER KATEGORI";
            lblFilterTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFilterTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblFilterTitle.Location = new Point(20, 230);
            lblFilterTitle.AutoSize = true;

            // Helper variables untuk posisi tombol
            int filterY = 258;
            int filterH = 40;
            int filterGap = 4;
            Size filterSize = new(220, filterH);
            Font filterFont = new("Segoe UI", 10F);
            FlatStyle filterFlat = FlatStyle.Flat;

            // Tombol: Semua
            btnFilterSemua.Text = "📋  Semua";
            btnFilterSemua.Location = new Point(20, filterY);
            btnFilterSemua.Size = filterSize;
            btnFilterSemua.Font = filterFont;
            btnFilterSemua.FlatStyle = filterFlat;
            btnFilterSemua.FlatAppearance.BorderSize = 0;
            btnFilterSemua.ForeColor = Color.FromArgb(148, 163, 184);
            btnFilterSemua.TextAlign = ContentAlignment.MiddleLeft;
            btnFilterSemua.Padding = new Padding(12, 0, 0, 0);
            btnFilterSemua.Cursor = Cursors.Hand;
            btnFilterSemua.Click += BtnFilterSemua_Click;

            // Tombol: Keluarga
            btnFilterKeluarga.Text = "👨‍👩‍👧  Keluarga";
            btnFilterKeluarga.Location = new Point(20, filterY + (filterH + filterGap));
            btnFilterKeluarga.Size = filterSize;
            btnFilterKeluarga.Font = filterFont;
            btnFilterKeluarga.FlatStyle = filterFlat;
            btnFilterKeluarga.FlatAppearance.BorderSize = 0;
            btnFilterKeluarga.ForeColor = Color.FromArgb(148, 163, 184);
            btnFilterKeluarga.TextAlign = ContentAlignment.MiddleLeft;
            btnFilterKeluarga.Padding = new Padding(12, 0, 0, 0);
            btnFilterKeluarga.Cursor = Cursors.Hand;
            btnFilterKeluarga.Click += BtnFilterKeluarga_Click;

            // Tombol: Teman
            btnFilterTeman.Text = "👥  Teman";
            btnFilterTeman.Location = new Point(20, filterY + 2 * (filterH + filterGap));
            btnFilterTeman.Size = filterSize;
            btnFilterTeman.Font = filterFont;
            btnFilterTeman.FlatStyle = filterFlat;
            btnFilterTeman.FlatAppearance.BorderSize = 0;
            btnFilterTeman.ForeColor = Color.FromArgb(148, 163, 184);
            btnFilterTeman.TextAlign = ContentAlignment.MiddleLeft;
            btnFilterTeman.Padding = new Padding(12, 0, 0, 0);
            btnFilterTeman.Cursor = Cursors.Hand;
            btnFilterTeman.Click += BtnFilterTeman_Click;

            // Tombol: Bisnis
            btnFilterBisnis.Text = "💼  Bisnis";
            btnFilterBisnis.Location = new Point(20, filterY + 3 * (filterH + filterGap));
            btnFilterBisnis.Size = filterSize;
            btnFilterBisnis.Font = filterFont;
            btnFilterBisnis.FlatStyle = filterFlat;
            btnFilterBisnis.FlatAppearance.BorderSize = 0;
            btnFilterBisnis.ForeColor = Color.FromArgb(148, 163, 184);
            btnFilterBisnis.TextAlign = ContentAlignment.MiddleLeft;
            btnFilterBisnis.Padding = new Padding(12, 0, 0, 0);
            btnFilterBisnis.Cursor = Cursors.Hand;
            btnFilterBisnis.Click += BtnFilterBisnis_Click;

            // ────────────────────────────────────────────
            //  TOP BAR (Header)
            // ────────────────────────────────────────────
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Height = 65;
            pnlTopBar.Padding = new Padding(28, 0, 28, 0);
            pnlTopBar.Controls.Add(txtSearch);
            pnlTopBar.Controls.Add(lblPageTitle);

            lblPageTitle.Text = "📋  Semua Kontak";
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblPageTitle.Location = new Point(28, 16);
            lblPageTitle.AutoSize = true;

            txtSearch.PlaceholderText = "🔍 Cari nama, telepon, atau email...";
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.BackColor = Color.FromArgb(241, 245, 249);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Size = new Size(300, 30);
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(680, 18);
            txtSearch.TextChanged += TxtSearch_TextChanged;

            // ────────────────────────────────────────────
            //  CONTENT AREA
            // ────────────────────────────────────────────
            pnlContent.BackColor = Color.FromArgb(241, 245, 249);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Padding = new Padding(24, 20, 24, 20);
            pnlContent.Controls.Add(pnlGridCard);
            pnlContent.Controls.Add(pnlInputCard);

            // ────────────────────────────────────────────
            //  INPUT CARD (Form Tambah/Edit)
            // ────────────────────────────────────────────
            pnlInputCard.BackColor = Color.White;
            pnlInputCard.Dock = DockStyle.Top;
            pnlInputCard.Height = 240;
            pnlInputCard.Padding = new Padding(24, 16, 24, 16);
            pnlInputCard.Controls.Add(btnBatal);
            pnlInputCard.Controls.Add(btnSimpan);
            pnlInputCard.Controls.Add(cboKategori);
            pnlInputCard.Controls.Add(lblKategori);
            pnlInputCard.Controls.Add(txtEmail);
            pnlInputCard.Controls.Add(lblEmail);
            pnlInputCard.Controls.Add(txtTelepon);
            pnlInputCard.Controls.Add(lblTelepon);
            pnlInputCard.Controls.Add(txtNama);
            pnlInputCard.Controls.Add(lblNama);
            pnlInputCard.Controls.Add(lblFormTitle);

            // Label & font helpers
            Font labelFont = new("Segoe UI", 9F, FontStyle.Bold);
            Font inputFont = new("Segoe UI", 11F);
            Color labelColor = Color.FromArgb(100, 116, 139);
            int col1X = 24;
            int col2X = 260;
            int col3X = 496;
            int labelRow = 52;
            int inputRow = 76;
            int labelRow2 = 128;
            int inputRow2 = 152;
            int inputW = 220;
            int inputH = 32;

            lblFormTitle.Text = "➕  Tambah Kontak Baru";
            lblFormTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblFormTitle.Location = new Point(col1X, 16);
            lblFormTitle.AutoSize = true;

            // -- Baris 1: Nama & Telepon --
            lblNama.Text = "NAMA LENGKAP";
            lblNama.Font = labelFont;
            lblNama.ForeColor = labelColor;
            lblNama.Location = new Point(col1X, labelRow);
            lblNama.AutoSize = true;

            txtNama.Font = inputFont;
            txtNama.Location = new Point(col1X, inputRow);
            txtNama.Size = new Size(inputW, inputH);
            txtNama.BorderStyle = BorderStyle.FixedSingle;
            txtNama.BackColor = Color.FromArgb(248, 250, 252);

            lblTelepon.Text = "NOMOR TELEPON";
            lblTelepon.Font = labelFont;
            lblTelepon.ForeColor = labelColor;
            lblTelepon.Location = new Point(col2X, labelRow);
            lblTelepon.AutoSize = true;

            txtTelepon.Font = inputFont;
            txtTelepon.Location = new Point(col2X, inputRow);
            txtTelepon.Size = new Size(inputW, inputH);
            txtTelepon.BorderStyle = BorderStyle.FixedSingle;
            txtTelepon.BackColor = Color.FromArgb(248, 250, 252);

            // -- Baris 2: Email & Kategori --
            lblEmail.Text = "EMAIL";
            lblEmail.Font = labelFont;
            lblEmail.ForeColor = labelColor;
            lblEmail.Location = new Point(col3X, labelRow);
            lblEmail.AutoSize = true;

            txtEmail.Font = inputFont;
            txtEmail.Location = new Point(col3X, inputRow);
            txtEmail.Size = new Size(inputW, inputH);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.BackColor = Color.FromArgb(248, 250, 252);

            lblKategori.Text = "KATEGORI";
            lblKategori.Font = labelFont;
            lblKategori.ForeColor = labelColor;
            lblKategori.Location = new Point(col1X, labelRow2);
            lblKategori.AutoSize = true;

            cboKategori.Font = inputFont;
            cboKategori.Location = new Point(col1X, inputRow2);
            cboKategori.Size = new Size(inputW, inputH);
            cboKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKategori.BackColor = Color.FromArgb(248, 250, 252);
            cboKategori.FlatStyle = FlatStyle.Flat;

            // -- Tombol Simpan --
            btnSimpan.Text = "💾  Simpan";
            btnSimpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSimpan.BackColor = Color.FromArgb(16, 185, 129);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.Size = new Size(140, 40);
            btnSimpan.Location = new Point(col2X, inputRow2);
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.Click += BtnSimpan_Click;

            // -- Tombol Batal --
            btnBatal.Text = "❌  Batal";
            btnBatal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBatal.BackColor = Color.FromArgb(241, 245, 249);
            btnBatal.ForeColor = Color.FromArgb(100, 116, 139);
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.FlatAppearance.BorderSize = 1;
            btnBatal.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnBatal.Size = new Size(120, 40);
            btnBatal.Location = new Point(col2X + 148, inputRow2);
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.Click += BtnBatal_Click;

            // ────────────────────────────────────────────
            //  GRID CARD (Tabel Data)
            // ────────────────────────────────────────────
            pnlGridCard.BackColor = Color.White;
            pnlGridCard.Dock = DockStyle.Fill;
            pnlGridCard.Padding = new Padding(0, 16, 0, 0);
            pnlGridCard.Controls.Add(dgvKontak);
            pnlGridCard.Controls.Add(pnlGridFooter);
            pnlGridCard.Controls.Add(lblGridTitle);

            lblGridTitle.Text = "📊  Data Kontak";
            lblGridTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Padding = new Padding(24, 8, 0, 8);
            lblGridTitle.Height = 44;

            // DataGridView
            dgvKontak.Dock = DockStyle.Fill;
            dgvKontak.BackgroundColor = Color.White;
            dgvKontak.CellDoubleClick += DgvKontak_CellDoubleClick;

            // Footer Tabel
            pnlGridFooter.BackColor = Color.FromArgb(248, 250, 252);
            pnlGridFooter.Dock = DockStyle.Bottom;
            pnlGridFooter.Height = 56;
            pnlGridFooter.Controls.Add(btnHapus);
            pnlGridFooter.Controls.Add(btnEdit);
            pnlGridFooter.Controls.Add(lblJumlahData);

            lblJumlahData.Text = "Menampilkan 0 dari 0 kontak";
            lblJumlahData.Font = new Font("Segoe UI", 10F);
            lblJumlahData.ForeColor = Color.FromArgb(100, 116, 139);
            lblJumlahData.Location = new Point(24, 17);
            lblJumlahData.AutoSize = true;

            // Tombol Edit
            btnEdit.Text = "✏️ Edit";
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.BackColor = Color.FromArgb(59, 130, 246);
            btnEdit.ForeColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Size = new Size(100, 36);
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(600, 10);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Click += BtnEdit_Click;

            // Tombol Hapus
            btnHapus.Text = "🗑️ Hapus";
            btnHapus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHapus.BackColor = Color.FromArgb(239, 68, 68);
            btnHapus.ForeColor = Color.White;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.Size = new Size(100, 36);
            btnHapus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHapus.Location = new Point(708, 10);
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.Click += BtnHapus_Click;

            // ────────────────────────────────────────────
            //  FORM UTAMA
            // ────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            MinimumSize = new Size(1100, 600);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.FromArgb(241, 245, 249);
            Text = "Buku Kontak — Manajemen Kontak Sederhana";
            Font = new Font("Segoe UI", 10F);

            // Urutan penambahan kontrol menentukan dock order
            // (yang ditambahkan terakhir di-dock pertama)
            Controls.Add(pnlContent);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);

            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlStatsCard.ResumeLayout(false);
            pnlStatsCard.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlInputCard.ResumeLayout(false);
            pnlInputCard.PerformLayout();
            pnlGridCard.ResumeLayout(false);
            pnlGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKontak).EndInit();
            pnlGridFooter.ResumeLayout(false);
            pnlGridFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // === Deklarasi field kontrol ===

        // Sidebar
        private Panel pnlSidebar;
        private Label lblAppIcon;
        private Label lblAppName;
        private Panel pnlDivider1;
        private Panel pnlStatsCard;
        private Label lblStatsTitle;
        private Label lblStatsCount;
        private Label lblFilterTitle;
        private Button btnFilterSemua;
        private Button btnFilterKeluarga;
        private Button btnFilterTeman;
        private Button btnFilterBisnis;

        // Top Bar
        private Panel pnlTopBar;
        private Label lblPageTitle;
        private TextBox txtSearch;

        // Content
        private Panel pnlContent;

        // Input Card
        private Panel pnlInputCard;
        private Label lblFormTitle;
        private Label lblNama;
        private TextBox txtNama;
        private Label lblTelepon;
        private TextBox txtTelepon;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblKategori;
        private ComboBox cboKategori;
        private Button btnSimpan;
        private Button btnBatal;

        // Grid Card
        private Panel pnlGridCard;
        private Label lblGridTitle;
        private DataGridView dgvKontak;
        private Panel pnlGridFooter;
        private Label lblJumlahData;
        private Button btnEdit;
        private Button btnHapus;
    }
}
