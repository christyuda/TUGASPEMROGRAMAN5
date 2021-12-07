using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_1_1204025
{
   
    public partial class NumericTextBox: TextBox
    {
        public NumericTextBox()
        {
            InitializeComponent();
        }
        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                try
                {
                    int.Parse(value);
                    base.Text = value;
                    return;
                }
                catch
                { }
                if(value == null)
                {
                    base.Text = value;
                }
                
          }
        }

        //rising & overriding
        public delegate void InvalidUserEntryEvent(object sender, KeyPressEventArgs e);
        public event InvalidUserEntryEvent InvalidUserEntry;

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {

            int asciiInterger = Convert.ToInt32(e.KeyChar);
            if (asciiInterger >= 47 && asciiInterger <= 57)
            {
                // jika nilai dari ascii diubah kedalam type char maka represent 0-9
                // pass the event to window for default proces 
                e.Handled = false;
                return;
            }
            //if the value of the ascii converted to char represens backspace
            if (asciiInterger == 8)
            {
                e.Handled = false;
                return;


            }
            e.Handled = true;
            if (InvalidUserEntry != null)
                InvalidUserEntry(this, e);

        }


    }

}
