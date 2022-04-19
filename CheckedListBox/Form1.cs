using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] diller = { "Türkçe", "İngilizce", "Almanca", "Arapça",
                "Fransızca", "Azerice", "Çince","Osmanlıca",
                "İtalyanca", "Japonca", "Korece", "Rusça"};

            checkedListBox1.Items.AddRange(diller);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.CheckOnClick = true;
            button2.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = textBox1.Text;
            string diller = "", mezuniyeti = "";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                diller += ", " + checkedListBox1.CheckedItems[i];
            }
            diller = diller.Substring(2);
            label7.Text = diller;
            if (radioButton1.Checked)
            {
                mezuniyeti = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                mezuniyeti = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                mezuniyeti = radioButton4.Text;
            }
            else if (radioButton4.Checked)
            {
                mezuniyeti = radioButton4.Text;
            }
            label8.Text = mezuniyeti;
            textBox1.Text = ""; textBox2.Text = "";
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                button2.Enabled = false;
            else
                button2.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (checkedListBox1.Items.Contains(textBox2.Text) == false)
                    checkedListBox1.Items.Add(textBox2.Text);
                else
                    MessageBox.Show("Belirtilen dil zaten eklidir!");
                textBox2.Text = "";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedIndices.Count > 0)
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
        }
    }
}