using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRACTICA_OIB
{
    public partial class registration_window : Form
    {
        public registration_window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = user_name.Text;
            string password = user_password.Text;

            bool isValid = isValidPassword(name, password);

           
            if (isValid)
            {
                Form2 newF = new Form2();
                newF.Show();
                this.Hide();

                newF.label2.Text = name;

                string directoryPath = String.Format(@"D:\pr7\{0}\", name);

                try
                {
                    string[] files = Directory.GetFiles(directoryPath);

                    foreach (string file in files)
                    {
                        ListViewItem item = new ListViewItem(Path.GetFileName(file));

                        newF.listView1.Items.Add(item);

                    }
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine($"Directory not found: {directoryPath}");
                }

            }

        }

        public bool isValidPassword(string name, string password)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"D:\pr7\users.txt", System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] user = line.Split(' '); 


                        if (name.Equals(user[0]) && PasswordHasher.VerifyPassword(password, user[1]))
                        {
                            return true;
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e){}
        private void textBox2_TextChanged(object sender, EventArgs e){}

    }
}