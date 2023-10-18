using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Admin
{
    public partial class BanDialog : Form
    {
        private Person _persona;

        public Person Persona { get => _persona; set => _persona = value; }

        public BanDialog(Person persona)
        {
            InitializeComponent();

            Persona = persona;

            lblNombre.Text = persona.Nombre;
            lblApellido.Text = persona.Apellido;
            lblUsername.Text = persona.Username;
            lblEmail.Text = persona.Email;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (rtxtRazon.Text.Length == 0)
            {
                lblError.Visible = true;
                lblError.Text = "Ingrese la razón del baneo";
            }
            else if (rtxtRazon.Text.Length < 15)
            {
                lblError.Visible = true;
                lblError.Text = "Mínimo de 15 caracteres";
            }
            else
            {
                List<Person> list;
                list = Person.ListaCompleta();

                foreach (Person person in list)
                {
                    if (person.Username == Persona.Username)
                    {
                        person.IsBanned = true;
                        person.BanText = rtxtRazon.Text;
                    }
                }

                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
                string nombreArchivo = @"\personas.xml";
                string path = ruta + nombreArchivo;

                Serializadora.EscribirPersonaXML(path, list);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void rtxtRazon_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
