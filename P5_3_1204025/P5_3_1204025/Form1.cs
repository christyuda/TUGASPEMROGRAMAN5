using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_1204025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        public delegate void InvalidUserEntryEvent(object sender, KeyPressEventArgs e);
        public event InvalidUserEntryEvent InvalidUserEntry;

        private void numeric_TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void charbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asciiInteger = Convert.ToInt32(e.KeyChar);
            if (!(asciiInteger >= 47 && asciiInteger <= 57))
            {
                e.Handled = false;
                return;
            }
            if (asciiInteger == 0)
            {
                e.Handled = false;
            }

            e.Handled = true;

            if (InvalidUserEntry != null)
            {
                InvalidUserEntry(this, e);
            }
        }

        private void txtThnAk_TextChanged_1(object sender, EventArgs e)
        {
            Regex regex = new Regex("^.*/.*$", RegexOptions.IgnoreCase);
            if (regex.IsMatch(txtThnAk.Text))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtThnAk, "Regex Tidak Sesuai");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((rbLakilaki.Checked == true || rbPerempuan.Checked == true) && numeric_TextBox1.Text != "" && charbox1.Text != "" && tbalamat.Text != "" && CbPs.Text != "" && txtThnAk.Text != "" && tbsemester.Text != "")
            {
                if (rbkulum2006.Checked == true)
                {
                    cbmrp.Enabled = false;
                    cbmrp.Enabled = true;
                    mnrp.Enabled = false;
                    cbpl.Enabled = false;
                }
                else if (rbkulum2010.Checked == true)
                {
                    cbmrp.Enabled = false;
                    cbmrp.Enabled = true;
                    cbmtk.Enabled = false;
                    cbpl.Enabled = false;
                }

                else if (rbkulum2014.Checked == true)
                {
                    cbmrp.Enabled = false;
                    cbmrp.Enabled = true;
                    cbmtk.Enabled = false;
                    mnrp.Enabled = false;
                }
            }

            Size = new Size(794, 557);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string kelas = " ";
                if (cbmtk.Checked) { kelas += cbmtk.Text; }
                if (cbpemro1.Checked) { kelas += cbpemro1.Text; }
                if (cbjarkom.Checked) { kelas += cbjarkom.Text; }
                if (cbso.Checked) { kelas += cbso.Text; }
                if (mnrp.Checked) { kelas += mnrp.Text; }
                if (cbpemro2.Checked) { kelas += cbpemro2.Text; }
                if (cbpemro3.Checked) { kelas += cbpemro3.Text; }
                if (cbpemro4.Checked) { kelas += cbpemro4.Text; }
                if (cbpemro5.Checked) { kelas += cbpemro5.Text; }
                if (cbpemro6.Checked) { kelas += cbpemro6.Text; }
                if (cbpemro7.Checked) { kelas += cbpemro7.Text; }
                if (cbpl.Checked) { kelas += cbpl.Text; }
                string lbJenisKelamin = rbLakilaki.Checked == true ? rbLakilaki.Text : rbPerempuan.Text;
                string kuri = "";
                if (rbkulum2006.Checked) { kuri = rbkulum2006.Text; } else if (rbkulum2010.Checked) { kuri = rbkulum2010.Text; } else if (rbkulum2014.Checked) { kuri = rbkulum2014.Text; }
                string message = String.Format("NIM : {0}\nNama : {1}\nJenis Kelamin : {2}\nAlamat : {3}\nProgram Studi : {4}\nTahun Akademik : {5}\nSemester : {6}\nKurikulum : {7}\nKelas : {8}\n", numeric_TextBox1.Text, charbox1.Text, lbJenisKelamin, tbalamat.Text, CbPs.Text, txtThnAk.Text, tbsemester.Text, kuri, kelas);
                MessageBox.Show(message);
            }
        }

        private void lbJenisKelamin_Click(object sender, EventArgs e)
        {

        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        
    }
}
