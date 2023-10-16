using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aylar = comboBox1.SelectedIndex;
            aylar++;
            if (aylar==3 || aylar==4 || aylar==5)
            {
                label1.Text = "İlkbahar";
            }
            else if (aylar==6 || aylar==7 || aylar==8)
            {
                label1.Text = "Yaz";
            }
            else if (aylar==9 || aylar==10 || aylar==11)
            {
                label1.Text = "Sonbahar";
            }
            else
            {
                label1.Text = "Kış";
            }

        }
    }
}
