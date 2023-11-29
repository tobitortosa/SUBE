using SUBE;
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Serialization;
using Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Entities.CRUDs;
using Entities.Entidades;

namespace Interface.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void llblRegister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string name;
            string lastName;
            string username;
            string email;
            string password;
            string repeatedPassword;

            name = txtName.Text;
            lastName = txtLastName.Text;
            username = txtUsername.Text;
            email = txtEmail.Text;
            password = txtPassword.Text;
            repeatedPassword = txtRepeatedPassword.Text;

            HandleRegister(name, lastName, username, email, password, repeatedPassword);
        }


        public delegate void RegistroEventHandler(Person persona);
        public event RegistroEventHandler Registrado;
        protected virtual void OnRegistro(Person persona)
        {
            if (Registrado != null)
            {
                Registrado(persona);
            }
        }


        private void HandleRegister(string name, string lastName, string username, string email, string password, string repeatedPassword)
        {
            try
            {
                if (!IsValidEmail(email))
                {
                    lblError.Text = "Ingrese un email valido";
                }
                else if (name == "" || lastName == "" || email == "" || password == "" || repeatedPassword == "")
                {
                    lblError.Text = "Todavía faltan datos por completar";
                }
                else if (HandleErrorStringHasWhiteSpace(name))
                {
                    lblError.Text = "Ingrese un nombre valido";
                }
                else if (HandleErrorStringHasWhiteSpace(lastName))
                {
                    lblError.Text = "Ingrese un apellido valido";
                }
                else if (HandleErrorStringHasWhiteSpace(username))
                {
                    lblError.Text = "Ingrese un username sin espacios";
                }
                else if (password == repeatedPassword)
                {
                    Person newPerson = new Person(username, name, lastName, email, password, false, "", false);

                    PersonCRUD personCrud = new PersonCRUD();
                    bool res = personCrud.Insert(newPerson);

                    try
                    {
                        if (!res)
                        {
                            lblError.Text = "Nombre de Usuario en Uso";
                        }

                        else
                        {
                            ControladoraAdmin controlAdmin = new ControladoraAdmin();
                            Registrado += controlAdmin.HandleCreateConfig;
                            OnRegistro(newPerson);

                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex}");
                    }
                }

            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private bool HandleErrorStringHasWhiteSpace(string input)
        {
            bool res;
            res = false;

            if (input.Any(Char.IsWhiteSpace))
            {
                res = true;
            }

            return res;
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void txtRepeatedPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtRepeatedPassword.Text)
            {
                lblError.Text = "Contraseña Invalida";
            }
            else
            {
                lblError.Text = "";
            }
        }

        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            else if (HandleErrorStringHasWhiteSpace(email))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
