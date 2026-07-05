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
            lblNama = new Label();
            textBox1 = new TextBox();
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
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lblNama);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(108, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 537);
            panel2.TabIndex = 2;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNama.ForeColor = Color.DimGray;
            lblNama.Location = new Point(40, 83);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(165, 28);
            lblNama.TabIndex = 3;
            lblNama.Text = "Nama Lengkap";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 31);
            textBox1.TabIndex = 4;
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
    }
}
