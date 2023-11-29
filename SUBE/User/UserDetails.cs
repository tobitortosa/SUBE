using Entities;
using Entities.CRUDs;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Interface
{
    public partial class UserDetails : Form
    {
        private Person Persona;
        public UserDetails(Person persona, Action<Control> PaintLabel, Config settings)
        {
            InitializeComponent();
            Persona = persona;

            this.BackColor = settings.BackgroundColor;
            PaintLabel(this);

            lblNombre.Text = Persona.nombre;
            lblApellido.Text = Persona.apellido;
            lblEmail.Text = Persona.email;
            lblUsername.Text = Persona.username;

            SubeCRUD subeCRUD = new SubeCRUD(); 
            List<Sube> listaSubes = subeCRUD.GetByFK(Persona.username);

            if (listaSubes.Count == 0)
            {
                lblNoSube.Visible = true;
            }
            else if (listaSubes.Count == 1)
            {
                PrintSube1(listaSubes[0]);
            }
            else if (listaSubes.Count == 2)
            {
                PrintSube1(listaSubes[0]);
                PrintSube2(listaSubes[1]);
            }
            else if (listaSubes.Count == 3)
            {
                PrintSube1(listaSubes[0]);
                PrintSube2(listaSubes[1]);
                PrintSube3(listaSubes[2]);
            }
            else
            {
                PrintSube1(listaSubes[0]);
                PrintSube2(listaSubes[1]);
                PrintSube3(listaSubes[2]);
                PrintSube4(listaSubes[3]);
            }
        }

        public void TraerPersona(Person persona)
        {
            Persona = persona;
        }

    private void PrintSube1(Sube sube)
        {
            pbSube.Visible = true;

            lblNombreCompleto.Visible = true;
            lblNombreCompleto.Text = Persona.nombre + " " + Persona.apellido;

            lblSaldo.Visible = true;
            lblSaldo.Text = "$" + sube.saldo.ToString();

            lblNumeroSube.Visible = true;
            lblNumeroSube.Text = sube.numeroDeTarjeta;
        }

        private void PrintSube2(Sube sube)
        {
            pbSube2.Visible = true;

            lblNombreCompleto2.Visible = true;
            lblNombreCompleto2.Text = Persona.nombre + " " + Persona.apellido;

            lblSaldo2.Visible = true;
            lblSaldo2.Text = "$" + sube.saldo.ToString();

            lblNumeroSube2.Visible = true;
            lblNumeroSube2.Text = sube.numeroDeTarjeta;
        }

        private void PrintSube3(Sube sube)
        {
            pbSube3.Visible = true;

            lblNombreCompleto3.Visible = true;
            lblNombreCompleto3.Text = Persona.nombre + " " + Persona.apellido;

            lblSaldo3.Visible = true;
            lblSaldo3.Text = "$" + sube.saldo.ToString();

            lblNumeroSube3.Visible = true;
            lblNumeroSube3.Text = sube.numeroDeTarjeta;
        }

        private void PrintSube4(Sube sube)
        {
            pbSube4.Visible = true;

            lblNombreCompleto4.Visible = true;
            lblNombreCompleto4.Text = Persona.nombre + " " + Persona.apellido;

            lblSaldo4.Visible = true;
            lblSaldo4.Text = "$" + sube.saldo.ToString();

            lblNumeroSube4.Visible = true;
            lblNumeroSube4.Text = sube.numeroDeTarjeta;
        }

        private void lblEmail_Click(object sender, System.EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, System.EventArgs e)
        {
        }

        private void lblUsername_Click(object sender, System.EventArgs e)
        {
        }
    }
}
