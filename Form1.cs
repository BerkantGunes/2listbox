using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Text = listBox1.Text;
            if(listBox1.SelectedIndex == 0)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("kadikoy");
                listBox2.Items.Add("besiktas");
                listBox2.Items.Add("uskudar");
                listBox2.Items.Add("sisli");
            }
            if (listBox1.SelectedIndex == 1)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("cankaya");
                listBox2.Items.Add("etimesgut");
                listBox2.Items.Add("mamak");
                listBox2.Items.Add("kecioren");
            }
            if (listBox1.SelectedIndex == 2)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("cesme");
                listBox2.Items.Add("karsiyaka");
                listBox2.Items.Add("alsancak");
                listBox2.Items.Add("konak");
            }
            if (listBox1.SelectedIndex == 3)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("gemlik");
                listBox2.Items.Add("osmangazi");
                listBox2.Items.Add("karacabey");
                listBox2.Items.Add("nilufer");
            }
            if (listBox1.SelectedIndex == 4)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("merkez");
                listBox2.Items.Add("ezine");
                listBox2.Items.Add("ayvacik");
                listBox2.Items.Add("eceabat");
            }
        }
    }
}
