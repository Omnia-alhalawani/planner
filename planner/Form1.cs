using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private Stopwatch m=new Stopwatch();
        

        private void Form1_Load(object sender, EventArgs e)
        {
         
        
        }

        private void Jan_Click(object sender, EventArgs e)//to form 2
        {
             this.Hide();
            // Form2 form2 = new Form2();
            //form2.Show();
            Form2 formjan = new Form2("January");
            formjan.ShowDialog();
        }

        private void Feb_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            Form2 formfeb = new Form2("February");
            formfeb.ShowDialog();
           
        }

        private void Mar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formmar = new Form2("March");
            formmar.Show();
        }

        private void Apr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formapr = new Form2("April");
            formapr.Show();
        }

        private void May_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formmay = new Form2("May");
            formmay.Show();
        }

        private void Jun_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formjune = new Form2("June");
            formjune.Show();
        }

        private void Jul_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formjul = new Form2("July");
            formjul.Show();
        }

        private void Aug_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formaug = new Form2("August");
            formaug.Show();
        }

        private void Sep_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formsep = new Form2("September");
            formsep.Show();
        }

        private void Oct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formoct = new Form2("October");
            formoct.Show();
        }

        private void Nov_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formnov = new Form2("Novemeber");
            formnov.Show();
        }

        private void Dec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formdec = new Form2("December");
            formdec.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = m.Elapsed;
            label2.Text = $" {elapsed.ToString(@"hh\:mm\:ss")}";
        }

        private void start_Click(object sender, EventArgs e)
        {
            m.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            m.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NotePad nt = new NotePad();
            nt.Show();
        }
    }
}
