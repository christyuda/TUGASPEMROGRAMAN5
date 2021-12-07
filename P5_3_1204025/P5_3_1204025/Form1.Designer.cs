namespace P5_3_1204025
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbNim = new System.Windows.Forms.Label();
            this.lbnama = new System.Windows.Forms.Label();
            this.lbJenisKelamin = new System.Windows.Forms.Label();
            this.lbAlamat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.thak = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.txtThnAk = new System.Windows.Forms.TextBox();
            this.CbPs = new System.Windows.Forms.ComboBox();
            this.rbLakilaki = new System.Windows.Forms.RadioButton();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmrp = new System.Windows.Forms.GroupBox();
            this.rbkulum2006 = new System.Windows.Forms.RadioButton();
            this.rbkulum2010 = new System.Windows.Forms.RadioButton();
            this.rbkulum2014 = new System.Windows.Forms.RadioButton();
            this.cbmtk = new System.Windows.Forms.CheckBox();
            this.cbpemro1 = new System.Windows.Forms.CheckBox();
            this.cbpemro2 = new System.Windows.Forms.CheckBox();
            this.cbpemro3 = new System.Windows.Forms.CheckBox();
            this.cbpemro4 = new System.Windows.Forms.CheckBox();
            this.cbpemro5 = new System.Windows.Forms.CheckBox();
            this.cbpemro6 = new System.Windows.Forms.CheckBox();
            this.cbpemro7 = new System.Windows.Forms.CheckBox();
            this.cbpl = new System.Windows.Forms.CheckBox();
            this.cbjarkom = new System.Windows.Forms.CheckBox();
            this.cbso = new System.Windows.Forms.CheckBox();
            this.mnrp = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.charbox1 = new P5_3_1204025.Charbox();
            this.tbsemester = new P5_3_1204025.Numeric_TextBox();
            this.numeric_TextBox1 = new P5_3_1204025.Numeric_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.cbmrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNim
            // 
            this.lbNim.AutoSize = true;
            this.lbNim.Location = new System.Drawing.Point(50, 42);
            this.lbNim.Name = "lbNim";
            this.lbNim.Size = new System.Drawing.Size(81, 13);
            this.lbNim.TabIndex = 0;
            this.lbNim.Text = "NIM                 :";
            // 
            // lbnama
            // 
            this.lbnama.AutoSize = true;
            this.lbnama.Location = new System.Drawing.Point(50, 79);
            this.lbnama.Name = "lbnama";
            this.lbnama.Size = new System.Drawing.Size(80, 13);
            this.lbnama.TabIndex = 1;
            this.lbnama.Text = "Nama              :";
            // 
            // lbJenisKelamin
            // 
            this.lbJenisKelamin.AutoSize = true;
            this.lbJenisKelamin.Location = new System.Drawing.Point(50, 117);
            this.lbJenisKelamin.Name = "lbJenisKelamin";
            this.lbJenisKelamin.Size = new System.Drawing.Size(80, 13);
            this.lbJenisKelamin.TabIndex = 2;
            this.lbJenisKelamin.Text = "Jenis Kelamin  :";
            this.lbJenisKelamin.Click += new System.EventHandler(this.lbJenisKelamin_Click);
            // 
            // lbAlamat
            // 
            this.lbAlamat.AutoSize = true;
            this.lbAlamat.Location = new System.Drawing.Point(50, 157);
            this.lbAlamat.Name = "lbAlamat";
            this.lbAlamat.Size = new System.Drawing.Size(81, 13);
            this.lbAlamat.TabIndex = 3;
            this.lbAlamat.Text = "Alamat             :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Program Studi             :";
            // 
            // thak
            // 
            this.thak.AutoSize = true;
            this.thak.Location = new System.Drawing.Point(360, 79);
            this.thak.Name = "thak";
            this.thak.Size = new System.Drawing.Size(115, 13);
            this.thak.TabIndex = 5;
            this.thak.Text = "Tahun Akademik        :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Semester                    :";
            // 
            // tbalamat
            // 
            this.tbalamat.Location = new System.Drawing.Point(137, 154);
            this.tbalamat.Multiline = true;
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(150, 51);
            this.tbalamat.TabIndex = 7;
            // 
            // txtThnAk
            // 
            this.txtThnAk.Location = new System.Drawing.Point(496, 76);
            this.txtThnAk.Name = "txtThnAk";
            this.txtThnAk.Size = new System.Drawing.Size(160, 20);
            this.txtThnAk.TabIndex = 8;
            this.txtThnAk.TextChanged += new System.EventHandler(this.txtThnAk_TextChanged_1);
            // 
            // CbPs
            // 
            this.CbPs.FormattingEnabled = true;
            this.CbPs.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Teknik Sistem informasi",
            "Manajemen",
            "Akuntansi"});
            this.CbPs.Location = new System.Drawing.Point(496, 39);
            this.CbPs.Name = "CbPs";
            this.CbPs.Size = new System.Drawing.Size(160, 21);
            this.CbPs.TabIndex = 9;
            this.CbPs.Text = "- Pilih Program Studi -";
            // 
            // rbLakilaki
            // 
            this.rbLakilaki.AutoSize = true;
            this.rbLakilaki.Location = new System.Drawing.Point(137, 115);
            this.rbLakilaki.Name = "rbLakilaki";
            this.rbLakilaki.Size = new System.Drawing.Size(74, 17);
            this.rbLakilaki.TabIndex = 10;
            this.rbLakilaki.TabStop = true;
            this.rbLakilaki.Text = "Laki - Laki";
            this.rbLakilaki.UseVisualStyleBackColor = true;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(228, 115);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rbPerempuan.TabIndex = 11;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pilih Mata Kuliah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbkulum2014);
            this.groupBox1.Controls.Add(this.rbkulum2010);
            this.groupBox1.Controls.Add(this.rbkulum2006);
            this.groupBox1.Location = new System.Drawing.Point(53, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 132);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurikulum Pilihan";
            // 
            // cbmrp
            // 
            this.cbmrp.Controls.Add(this.mnrp);
            this.cbmrp.Controls.Add(this.cbso);
            this.cbmrp.Controls.Add(this.cbjarkom);
            this.cbmrp.Controls.Add(this.cbpl);
            this.cbmrp.Controls.Add(this.cbpemro7);
            this.cbmrp.Controls.Add(this.cbpemro6);
            this.cbmrp.Controls.Add(this.cbpemro5);
            this.cbmrp.Controls.Add(this.cbpemro4);
            this.cbmrp.Controls.Add(this.cbmtk);
            this.cbmrp.Controls.Add(this.cbpemro3);
            this.cbmrp.Controls.Add(this.cbpemro2);
            this.cbmrp.Controls.Add(this.cbpemro1);
            this.cbmrp.Location = new System.Drawing.Point(305, 249);
            this.cbmrp.Name = "cbmrp";
            this.cbmrp.Size = new System.Drawing.Size(461, 204);
            this.cbmrp.TabIndex = 17;
            this.cbmrp.TabStop = false;
            this.cbmrp.Text = "Mata Kuliah Pilihan";
            // 
            // rbkulum2006
            // 
            this.rbkulum2006.AutoSize = true;
            this.rbkulum2006.Location = new System.Drawing.Point(11, 19);
            this.rbkulum2006.Name = "rbkulum2006";
            this.rbkulum2006.Size = new System.Drawing.Size(98, 17);
            this.rbkulum2006.TabIndex = 0;
            this.rbkulum2006.TabStop = true;
            this.rbkulum2006.Text = "Kurikulum 2006";
            this.rbkulum2006.UseVisualStyleBackColor = true;
            // 
            // rbkulum2010
            // 
            this.rbkulum2010.AutoSize = true;
            this.rbkulum2010.Location = new System.Drawing.Point(11, 57);
            this.rbkulum2010.Name = "rbkulum2010";
            this.rbkulum2010.Size = new System.Drawing.Size(98, 17);
            this.rbkulum2010.TabIndex = 1;
            this.rbkulum2010.TabStop = true;
            this.rbkulum2010.Text = "Kurikulum 2010";
            this.rbkulum2010.UseVisualStyleBackColor = true;
            // 
            // rbkulum2014
            // 
            this.rbkulum2014.AutoSize = true;
            this.rbkulum2014.Location = new System.Drawing.Point(11, 94);
            this.rbkulum2014.Name = "rbkulum2014";
            this.rbkulum2014.Size = new System.Drawing.Size(98, 17);
            this.rbkulum2014.TabIndex = 2;
            this.rbkulum2014.TabStop = true;
            this.rbkulum2014.Text = "Kurikulum 2014";
            this.rbkulum2014.UseVisualStyleBackColor = true;
            // 
            // cbmtk
            // 
            this.cbmtk.AutoSize = true;
            this.cbmtk.Location = new System.Drawing.Point(19, 28);
            this.cbmtk.Name = "cbmtk";
            this.cbmtk.Size = new System.Drawing.Size(81, 17);
            this.cbmtk.TabIndex = 3;
            this.cbmtk.Text = "Matematika";
            this.cbmtk.UseVisualStyleBackColor = true;
            this.cbmtk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbpemro1
            // 
            this.cbpemro1.AutoSize = true;
            this.cbpemro1.Location = new System.Drawing.Point(19, 67);
            this.cbpemro1.Name = "cbpemro1";
            this.cbpemro1.Size = new System.Drawing.Size(100, 17);
            this.cbpemro1.TabIndex = 0;
            this.cbpemro1.Text = "Pemrograman 1";
            this.cbpemro1.UseVisualStyleBackColor = true;
            // 
            // cbpemro2
            // 
            this.cbpemro2.AutoSize = true;
            this.cbpemro2.Location = new System.Drawing.Point(19, 115);
            this.cbpemro2.Name = "cbpemro2";
            this.cbpemro2.Size = new System.Drawing.Size(100, 17);
            this.cbpemro2.TabIndex = 1;
            this.cbpemro2.Text = "Pemrograman 2";
            this.cbpemro2.UseVisualStyleBackColor = true;
            // 
            // cbpemro3
            // 
            this.cbpemro3.AutoSize = true;
            this.cbpemro3.Location = new System.Drawing.Point(19, 157);
            this.cbpemro3.Name = "cbpemro3";
            this.cbpemro3.Size = new System.Drawing.Size(100, 17);
            this.cbpemro3.TabIndex = 2;
            this.cbpemro3.Text = "Pemrograman 3";
            this.cbpemro3.UseVisualStyleBackColor = true;
            // 
            // cbpemro4
            // 
            this.cbpemro4.AutoSize = true;
            this.cbpemro4.Location = new System.Drawing.Point(159, 28);
            this.cbpemro4.Name = "cbpemro4";
            this.cbpemro4.Size = new System.Drawing.Size(100, 17);
            this.cbpemro4.TabIndex = 4;
            this.cbpemro4.Text = "Pemrograman 4";
            this.cbpemro4.UseVisualStyleBackColor = true;
            // 
            // cbpemro5
            // 
            this.cbpemro5.AutoSize = true;
            this.cbpemro5.Location = new System.Drawing.Point(159, 75);
            this.cbpemro5.Name = "cbpemro5";
            this.cbpemro5.Size = new System.Drawing.Size(100, 17);
            this.cbpemro5.TabIndex = 5;
            this.cbpemro5.Text = "Pemrograman 5";
            this.cbpemro5.UseVisualStyleBackColor = true;
            // 
            // cbpemro6
            // 
            this.cbpemro6.AutoSize = true;
            this.cbpemro6.Location = new System.Drawing.Point(159, 115);
            this.cbpemro6.Name = "cbpemro6";
            this.cbpemro6.Size = new System.Drawing.Size(100, 17);
            this.cbpemro6.TabIndex = 6;
            this.cbpemro6.Text = "Pemrograman 6";
            this.cbpemro6.UseVisualStyleBackColor = true;
            // 
            // cbpemro7
            // 
            this.cbpemro7.AutoSize = true;
            this.cbpemro7.Location = new System.Drawing.Point(159, 157);
            this.cbpemro7.Name = "cbpemro7";
            this.cbpemro7.Size = new System.Drawing.Size(100, 17);
            this.cbpemro7.TabIndex = 7;
            this.cbpemro7.Text = "Pemrograman 7";
            this.cbpemro7.UseVisualStyleBackColor = true;
            // 
            // cbpl
            // 
            this.cbpl.AutoSize = true;
            this.cbpl.Location = new System.Drawing.Point(308, 28);
            this.cbpl.Name = "cbpl";
            this.cbpl.Size = new System.Drawing.Size(114, 17);
            this.cbpl.TabIndex = 8;
            this.cbpl.Text = "Pengantar Logistik";
            this.cbpl.UseVisualStyleBackColor = true;
            // 
            // cbjarkom
            // 
            this.cbjarkom.AutoSize = true;
            this.cbjarkom.Location = new System.Drawing.Point(308, 75);
            this.cbjarkom.Name = "cbjarkom";
            this.cbjarkom.Size = new System.Drawing.Size(114, 17);
            this.cbjarkom.TabIndex = 9;
            this.cbjarkom.Text = "Jaringan Komputer";
            this.cbjarkom.UseVisualStyleBackColor = true;
            // 
            // cbso
            // 
            this.cbso.AutoSize = true;
            this.cbso.Location = new System.Drawing.Point(308, 115);
            this.cbso.Name = "cbso";
            this.cbso.Size = new System.Drawing.Size(96, 17);
            this.cbso.TabIndex = 10;
            this.cbso.Text = "Sistem Operasi";
            this.cbso.UseVisualStyleBackColor = true;
            // 
            // mnrp
            // 
            this.mnrp.AutoSize = true;
            this.mnrp.Location = new System.Drawing.Point(308, 157);
            this.mnrp.Name = "mnrp";
            this.mnrp.Size = new System.Drawing.Size(148, 17);
            this.mnrp.TabIndex = 11;
            this.mnrp.Text = "Manajemen Rantai Pasok";
            this.mnrp.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(363, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Batal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // charbox1
            // 
            this.charbox1.Location = new System.Drawing.Point(137, 72);
            this.charbox1.Name = "charbox1";
            this.charbox1.Size = new System.Drawing.Size(150, 20);
            this.charbox1.TabIndex = 14;
            // 
            // tbsemester
            // 
            this.tbsemester.Location = new System.Drawing.Point(496, 117);
            this.tbsemester.Name = "tbsemester";
            this.tbsemester.Size = new System.Drawing.Size(160, 20);
            this.tbsemester.TabIndex = 13;
            // 
            // numeric_TextBox1
            // 
            this.numeric_TextBox1.Location = new System.Drawing.Point(137, 39);
            this.numeric_TextBox1.Name = "numeric_TextBox1";
            this.numeric_TextBox1.Size = new System.Drawing.Size(150, 20);
            this.numeric_TextBox1.TabIndex = 12;
            this.numeric_TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_TextBox1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 231);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbmrp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.charbox1);
            this.Controls.Add(this.tbsemester);
            this.Controls.Add(this.numeric_TextBox1);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLakilaki);
            this.Controls.Add(this.CbPs);
            this.Controls.Add(this.txtThnAk);
            this.Controls.Add(this.tbalamat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.thak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAlamat);
            this.Controls.Add(this.lbJenisKelamin);
            this.Controls.Add(this.lbnama);
            this.Controls.Add(this.lbNim);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cbmrp.ResumeLayout(false);
            this.cbmrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNim;
        private System.Windows.Forms.Label lbnama;
        private System.Windows.Forms.Label lbJenisKelamin;
        private System.Windows.Forms.Label lbAlamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label thak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbalamat;
        private System.Windows.Forms.TextBox txtThnAk;
        private System.Windows.Forms.ComboBox CbPs;
        private System.Windows.Forms.RadioButton rbLakilaki;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private Numeric_TextBox numeric_TextBox1;
        private Numeric_TextBox tbsemester;
        private Charbox charbox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox cbmrp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbmtk;
        private System.Windows.Forms.RadioButton rbkulum2014;
        private System.Windows.Forms.RadioButton rbkulum2010;
        private System.Windows.Forms.RadioButton rbkulum2006;
        private System.Windows.Forms.CheckBox mnrp;
        private System.Windows.Forms.CheckBox cbso;
        private System.Windows.Forms.CheckBox cbjarkom;
        private System.Windows.Forms.CheckBox cbpl;
        private System.Windows.Forms.CheckBox cbpemro7;
        private System.Windows.Forms.CheckBox cbpemro6;
        private System.Windows.Forms.CheckBox cbpemro5;
        private System.Windows.Forms.CheckBox cbpemro4;
        private System.Windows.Forms.CheckBox cbpemro3;
        private System.Windows.Forms.CheckBox cbpemro2;
        private System.Windows.Forms.CheckBox cbpemro1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

