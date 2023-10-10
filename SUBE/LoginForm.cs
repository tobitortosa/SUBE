using Entities;
using Interface.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Interface;

namespace SUBE
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            bool logStatus;
            Person logPerson;

            username = txtUser.Text;
            password = txtPassword.Text;

            try
            {
                (logStatus, logPerson) = User.Login(username, password);

                if (logStatus)
                {
                    lblError.Text = "Usuario o Contraseña Incorrectos";
                }
                else
                {
                    if(logPerson.Username == "sa" && logPerson.Password == "sa")
                    {
                        SuperAdmin superAdmin = new SuperAdmin();    
                        superAdmin.Show();
                        this.Hide();
                    } 
                    else if (logPerson.IsAdmin)
                    {
                        AdminMenu adminMenu = new AdminMenu(logPerson);
                        adminMenu.Show();
                        this.Hide();
                    } 
                    else
                    {
                        Menu menu = new Menu(logPerson);
                        menu.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }
    }
}