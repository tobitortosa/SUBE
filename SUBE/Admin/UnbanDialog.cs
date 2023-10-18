using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Admin
{
    public partial class UnbanDialog : Form
    {
        private Person _persona;
        public UnbanDialog(Person persona)
        {
            InitializeComponent();

            Persona = persona;

            lblNombre.Text = persona.Nombre;
            lblApellido.Text = persona.Apellido;
            lblUsername.Text = persona.Username;
            lblEmail.Text = persona.Email;

            rtxtRazon.Text = persona.BanText;
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            List<Person> list;
            list = Person.ListaCompleta();

            foreach (Person person in list)
            {
                if (person.Username == Persona.Username)
                {
                    person.IsBanned = false;
                    person.BanText = "";
                }
            }

            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            string nombreArchivo = @"\personas.xml";
            string path = ruta + nombreArchivo;

            Serializadora.EscribirPersonaXML(path, list);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Person Persona { get => _persona; set => _persona = value; }
    }
}
