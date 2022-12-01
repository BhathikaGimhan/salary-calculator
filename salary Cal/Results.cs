using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salary_Cal
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }
        private void EMRate_Click(object sender, EventArgs e)
        {
            
        }

        private void Results_Load(object sender, EventArgs e)
        {
            EMName.Text = Class1.employeeName;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Cal fh = new Frm_Cal();
            fh.Show();
            
        }
    }
}
