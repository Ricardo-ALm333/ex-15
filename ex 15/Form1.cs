namespace ex_15
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();    
            textBox3.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
           
        }
    }
}