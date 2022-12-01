using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace salary_Cal
{
    public partial class Frm_Cal : Form
    {
        public Frm_Cal()
        {
            InitializeComponent();
        }

        private void Frm_Cal_Load(object sender, EventArgs e)
        {
            lableUserName.Text = UserLog.userName;
            this.EmpolyeeName.Text = "";
            this.WorkH.Text = "";
            this.Leave.Text = "";
            this.Rate.Text = "";
            this.OT.Text = "";
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string employeeName = EmpolyeeName.Text;
            Class1.employeeName = EmpolyeeName.Text;

            this.Hide();
            Results fhh = new Results();
            fhh.Show();
        }

        private void DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.DropDown.SelectedItem == "Executive")
            {
                this.WorkH.Text = "";
                this.Leave.Text = "";
                Leave.ReadOnly = false;
                OT.ReadOnly = true;
                this.WorkH.Text = "8";
                this.Leave.Text = "3";
            }
            else if(this.DropDown.SelectedItem == "None Executive")
            {
                this.WorkH.Text = "";
                this.Leave.Text = "";
                OT.ReadOnly = false;
                Leave.ReadOnly = false;
                this.WorkH.Text = "8";
                this.Leave.Text = "2";
            }
            else if(this.DropDown.SelectedItem == "Casual Workers")
            {
                OT.ReadOnly = true;
                Leave.ReadOnly = true;
                this.WorkH.Text = "";
                this.Leave.Text = "";
            }
            
        }
    }
}
