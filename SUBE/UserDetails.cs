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

namespace Interface
{
    public partial class UserDetails : Form
    {
        private Person persona;

        public UserDetails(Person persona)
        {
            InitializeComponent();
            this.Persona = persona;
            lblNombre.Text = persona.Nombre;
            lblApellido.Text = persona.Apellido;
            lblEmail.Text = persona.Email;
            lblUsername.Text = persona.Username;

            if (persona.ListaSube.Count == 0)
            {
                pbSube.Visible = false;
                lblNombreCompleto.Visible = false;
                lblSaldo.Visible = false;
                lblNumeroSube.Visible = false;

                lblNoSube.Visible = true;
                btnComprarSube.Visible = true;
            }

            if (persona.ListaSube.Count == 1)
            {
                pbSube.Visible = true;
                lblNombreCompleto.Visible = true;
                lblSaldo.Visible = true;
                lblNumeroSube.Visible = true;

                lblNoSube.Visible = false;
                btnComprarSube.Visible = false;
            }

            if (persona.ListaSube.Count == 2)
            {
                pbSube2.Visible = true;
                lblNombreCompleto2.Visible = true;
                lblSaldo2.Visible = true;
                lblNumeroSube2.Visible = true;

                lblNoSube.Visible = false;
                btnComprarSube.Visible = false;
            }
        }

        public Person Persona { get => persona; set => persona = value; }

    }
}
