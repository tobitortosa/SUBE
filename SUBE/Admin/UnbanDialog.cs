using Entities;
using Entities.CRUDs;
using Entities.Entidades;
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

            lblNombre.Text = persona.nombre;
            lblApellido.Text = persona.apellido;
            lblUsername.Text = persona.username;
            lblEmail.Text = persona.email;

            rtxtRazon.Text = persona.ban_text;
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Persona.ban = false;
                Persona.ban_text = "";

                PersonCRUD personCRUD = new PersonCRUD();
                personCRUD.Update(Persona);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Person Persona { get => _persona; set => _persona = value; }
    }
}
