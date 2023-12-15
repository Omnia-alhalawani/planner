using System;
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
    }
}
