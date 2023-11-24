using Entities;
using Entities.CRUDs;
using Entities.Entidades;
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

            lblNombre.Text = persona.nombre;
            lblApellido.Text = persona.apellido;
            lblUsername.Text = persona.username;
            lblEmail.Text = persona.email;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
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
                    Persona.ban = true;
                    Persona.ban_text = rtxtRazon.Text;

                    PersonCRUD personCRUD = new PersonCRUD();
                    personCRUD.Update(Persona);

                    DialogResult = DialogResult.OK;
                }
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

        private void rtxtRazon_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
