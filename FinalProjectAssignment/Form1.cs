namespace FinalProjectAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "md" && txtPass.Text == "123")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Usename หรือ Password ของคุณไม่ถูกต้อง");
        }
    }
}