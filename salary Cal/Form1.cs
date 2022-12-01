namespace salary_Cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string userName = UserName.Text;
            string password = Password.Text;
            if(userName.Equals("Bhathika") && password.Equals("bgm990714")){
                UserLog.userName = UserName.Text;
                this.Hide();
                Frm_Cal fh= new Frm_Cal();
                fh.Show();
            }
            else
            {
                MessageBox.Show("Yor Cradential is worng! Please check user name and password");
                UserName.Text = "";
                Password.Text = "";
            }
        }
    }
}