using System;
using System.Linq;
using System.Windows.Forms;

namespace PRACTICA_OIB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e){}
        private void button1_Click_1(object sender, EventArgs e)
        {
            registration_window form1 = Application.OpenForms.OfType<registration_window>().FirstOrDefault();

            if (form1 != null)
            {
                form1.Show();
                this.Hide();
                form1.user_name.Clear();
                form1.user_password.Clear();
                listView1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Ошибка: первая форма не найдена.");
            }
        }
    }
}
