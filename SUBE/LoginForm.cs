using Entities;
using Interface.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Interface;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Common;
using System.Collections.Generic;
using Entities.Entidades;
using System.Threading.Tasks;

namespace SUBE
{
    public partial class LoginForm : Form
    {
        Action<Person> pasarPersona;
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            bool logStatus;
            Person logPerson;

            username = txtUser.Text;
            password = txtPassword.Text;
            
            Menu menu = new Menu();

            try
            {
                lblError.Visible = false;
                (logStatus, logPerson) = Controladora.Login(username, password);

                if (txtUser.Text == "sa" && txtPassword.Text == "sa")
                {
                    SuperAdmin superAdmin = new SuperAdmin();
                    superAdmin.Show();
                    this.Hide();
                }
                else if (logStatus)
                {
                    lblError.Visible = true;
                    lblError.Text = "Usuario o Contrase�a Incorrectos";
                    throw new Exception("Usuario o Contrase�a Incorrectos");
                }
                else if (logPerson.ban)
                {
                    lblError.Visible = true;
                    lblError.Text = "Usuario Baneado";

                    lblRazon.Visible = true;
                    rtxtRazon.Visible = true;
                    rtxtRazon.Text = logPerson.ban_text;
                }
                else
                {
                    if (logPerson.username == "sa" && logPerson.password == "sa")
                    {
                        SuperAdmin superAdmin = new SuperAdmin();
                        superAdmin.Show();
                        this.Hide();
                    }
                    else if (logPerson.admin)
                    {
                        AdminMenu adminMenu = new AdminMenu(logPerson);
                        adminMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        await Task.Run(() => SuscribirEvento(menu, logPerson));
                        menu.Show();
                        this.Hide();
                    }

                    Serializadora<Person>.EscribirJson(logPerson, Paths.LogPerson);
                }
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
            finally
            {
                await Task.Run(() => DesuscribirEvento(menu));
            }

        }

        private void SuscribirEvento(Menu menu, Person persona)
        {
            try
            {
                pasarPersona += menu.RecivirPersona;
                pasarPersona(persona);
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void DesuscribirEvento(Menu menu)
        {
            try
            {
                pasarPersona -= menu.RecivirPersona;

            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
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
            try
            {
                Person logPerson;
                logPerson = new Person();

                if (!File.Exists(Paths.LogPerson))
                {
                    Serializadora<Person>.EscribirJson(logPerson, Paths.LogPerson);
                }
                else
                {
                    logPerson = Serializadora<Person>.LeerJson(Paths.LogPerson);
                    txtUser.Text = logPerson.username;
                    txtPassword.Text = logPerson.password;
                }
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }
    }
}