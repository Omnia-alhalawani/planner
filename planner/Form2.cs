﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void back_btn_Click(object sender, EventArgs e)
        {

            Application.OpenForms[0].Show();//indx form
            this.Close();
            //close form 2 &show form 1 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_doubleclick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                DialogResult result = MessageBox.Show("Did you finish the task?", "Confirmation", MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {

                    MessageBox.Show("اشطر كتكوت");
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                else
                {

                    MessageBox.Show("احنا هناااااام");
                }
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            listBox1.Click += new EventHandler(listBox1_doubleclick);
            listBox2.Click += new EventHandler(listBox1_doubleclick);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {

                DialogResult result = MessageBox.Show("Did you finish the task?", "Confirmation", MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {

                    MessageBox.Show("اشطر كتكوت");
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                else
                {

                    MessageBox.Show("احنا هناااااام");
                }
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                listBox2.Items.Add(textBox2.Text);
                textBox2.Text = "";
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {

                DialogResult result = MessageBox.Show("Did you finish the task?", "Confirmation", MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {

                    MessageBox.Show("اشطر كتكوت");
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
                else
                {

                    MessageBox.Show("احنا هناااااام");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                listBox3.Items.Add(textBox3.Text);
                textBox3.Text = "";
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem != null)
            {

                DialogResult result = MessageBox.Show("Did you finish the task?", "Confirmation", MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {

                    MessageBox.Show("اشطر كتكوت");
                    listBox4.Items.Remove(listBox4.SelectedItem);
                }
                else
                {

                    MessageBox.Show("احنا هناااااام");
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                listBox4.Items.Add(textBox4.Text);
                textBox4.Text = "";
            }
        }

        private void notes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
