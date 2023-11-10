namespace gui
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
            BtnTambah = new Button();
            BtnKurang = new Button();
            BtnBagi = new Button();
            BtnKali = new Button();
            Angka1 = new Label();
            Angka2 = new Label();
            input1 = new TextBox();
            input2 = new TextBox();
            outputhasil = new TextBox();
            hasil = new Label();
            SuspendLayout();
            // 
            // BtnTambah
            // 
            BtnTambah.Location = new Point(135, 183);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(94, 29);
            BtnTambah.TabIndex = 0;
            BtnTambah.Text = "+";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // BtnKurang
            // 
            BtnKurang.Location = new Point(270, 183);
            BtnKurang.Name = "BtnKurang";
            BtnKurang.Size = new Size(94, 29);
            BtnKurang.TabIndex = 1;
            BtnKurang.Text = "-";
            BtnKurang.UseVisualStyleBackColor = true;
            BtnKurang.Click += BtnKurang_Click;
            // 
            // BtnBagi
            // 
            BtnBagi.Location = new Point(409, 183);
            BtnBagi.Name = "BtnBagi";
            BtnBagi.Size = new Size(94, 29);
            BtnBagi.TabIndex = 2;
            BtnBagi.Text = "/";
            BtnBagi.UseVisualStyleBackColor = true;
            BtnBagi.Click += BtnBagi_Click;
            // 
            // BtnKali
            // 
            BtnKali.Location = new Point(551, 183);
            BtnKali.Name = "BtnKali";
            BtnKali.Size = new Size(94, 29);
            BtnKali.TabIndex = 3;
            BtnKali.Text = "*";
            BtnKali.UseVisualStyleBackColor = true;
            BtnKali.Click += BtnKali_Click;
            // 
            // Angka1
            // 
            Angka1.AutoSize = true;
            Angka1.Location = new Point(106, 78);
            Angka1.Name = "Angka1";
            Angka1.Size = new Size(63, 20);
            Angka1.TabIndex = 4;
            Angka1.Text = "Angka 1";
            Angka1.Click += label1_Click;
            // 
            // Angka2
            // 
            Angka2.AutoSize = true;
            Angka2.Location = new Point(106, 121);
            Angka2.Name = "Angka2";
            Angka2.Size = new Size(63, 20);
            Angka2.TabIndex = 5;
            Angka2.Text = "Angka 2";
            Angka2.Click += label1_Click_1;
            // 
            // input1
            // 
            input1.Location = new Point(187, 75);
            input1.Name = "input1";
            input1.Size = new Size(253, 27);
            input1.TabIndex = 6;
            // 
            // input2
            // 
            input2.Location = new Point(187, 118);
            input2.Name = "input2";
            input2.Size = new Size(253, 27);
            input2.TabIndex = 7;
            // 
            // outputhasil
            // 
            outputhasil.Location = new Point(187, 290);
            outputhasil.Name = "outputhasil";
            outputhasil.Size = new Size(253, 27);
            outputhasil.TabIndex = 8;
            outputhasil.TextChanged += hasil_TextChanged;
            // 
            // hasil
            // 
            hasil.AutoSize = true;
            hasil.Location = new Point(121, 293);
            hasil.Name = "hasil";
            hasil.Size = new Size(39, 20);
            hasil.TabIndex = 9;
            hasil.Text = "hasil";
            hasil.Click += label1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hasil);
            Controls.Add(outputhasil);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(Angka2);
            Controls.Add(Angka1);
            Controls.Add(BtnKali);
            Controls.Add(BtnBagi);
            Controls.Add(BtnKurang);
            Controls.Add(BtnTambah);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnTambah;
        private Button BtnKurang;
        private Button BtnBagi;
        private Button BtnKali;
        private Label Angka1;
        private Label Angka2;
        private TextBox input1;
        private TextBox input2;
        private TextBox outputhasil;
        private Label hasil;
    }
}