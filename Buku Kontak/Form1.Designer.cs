namespace Buku_Kontak
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblBantuan = new Label();
            lblEdit = new Label();
            lblFile = new Label();
            label1 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            lblNama = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblBantuan);
            panel1.Controls.Add(lblEdit);
            panel1.Controls.Add(lblFile);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 87);
            panel1.TabIndex = 0;
            // 
            // lblBantuan
            // 
            lblBantuan.AutoSize = true;
            lblBantuan.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBantuan.Location = new Point(277, 28);
            lblBantuan.Name = "lblBantuan";
            lblBantuan.Size = new Size(98, 28);
            lblBantuan.TabIndex = 2;
            lblBantuan.Text = "Bantuan";
            // 
            // lblEdit
            // 
            lblEdit.AutoSize = true;
            lblEdit.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEdit.Location = new Point(169, 28);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(54, 28);
            lblEdit.TabIndex = 1;
            lblEdit.Text = "Edit";
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFile.Location = new Point(70, 28);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(51, 28);
            lblFile.TabIndex = 0;
            lblFile.Text = "File";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 26);
            label1.Name = "label1";
            label1.Size = new Size(246, 28);
            label1.TabIndex = 2;
            label1.Text = "👤  Data Kontak Baru";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lblNama);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(108, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 537);
            panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 31);
            textBox1.TabIndex = 4;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNama.ForeColor = Color.DimGray;
            lblNama.Location = new Point(40, 92);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(165, 28);
            lblNama.TabIndex = 3;
            lblNama.Text = "Nama Lengkap";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 249);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(403, 31);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(40, 200);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 5;
            label2.Text = "No Hp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(40, 309);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 7;
            label3.Text = "Kategori";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(40, 358);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(403, 33);
            comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Candara", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(40, 432);
            button1.Name = "button1";
            button1.Size = new Size(403, 51);
            button1.TabIndex = 10;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 789);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblEdit;
        private Label lblFile;
        private Label lblBantuan;
        private Label label1;
        private Panel panel2;
        private TextBox textBox1;
        private Label lblNama;
        private Button button1;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
    }
}
