using Entities;
using Interface.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Interface;
using System.Windows.Forms;
using System;

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
                lblError.Visible = false;
                (logStatus, logPerson) = User.Login(username, password);

                if (txtUser.Text == "sa" && txtPassword.Text == "sa")
                {
                    SuperAdmin superAdmin = new SuperAdmin();
                    superAdmin.Show();
                    this.Hide();
                }
                else if (logStatus)
                {
                    lblError.Visible = true;
                    lblError.Text = "Usuario o Contraseña Incorrectos";
                }
                else if (logPerson.IsBanned)
                {
                    lblError.Visible = true;
                    lblError.Text = "Usuario Baneado";

                    lblRazon.Visible = true;
                    rtxtRazon.Visible = true;
                    rtxtRazon.Text = logPerson.BanText;
                }
                else
                {
                    if (logPerson.Username == "sa" && logPerson.Password == "sa")
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

                    string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
                    string nombreArchivo = @"\logPerson.json";
                    string path = ruta + nombreArchivo;

                    Serializadora.EscribirJson(path, logPerson);
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            string nombreArchivo = @"\logPerson.json";
            string path = ruta + nombreArchivo;

            Person logPerson;
            logPerson = new Person();

            if (!File.Exists(path))
            {
                Serializadora.EscribirJson(path, logPerson);
            }
            else
            {
                logPerson = Serializadora.LeerJson(path);
                txtUser.Text = logPerson.Username;
                txtPassword.Text = logPerson.Password;
            }
        }
    }
}