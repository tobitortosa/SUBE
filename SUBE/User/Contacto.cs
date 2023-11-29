using Entities;
using Entities.Entidades;
using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Contacto : Form
    {
        private Person Persona { get; set; }
        public Contacto(Person persona, Action<Control> PaintLabel, Config settings)
        {
            InitializeComponent();
            this.BackColor = settings.BackgroundColor;
            PaintLabel(this);
            Persona = persona;
            lblEmail.Text = Persona.email;
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtAsunto.TextLength > 0 && txtMensaje.TextLength > 0)
            {
                lblError.Visible = false;
                StringBuilder mensajeBuilder = new StringBuilder();

                mensajeBuilder.Append(txtMensaje.Text.Trim());

                lblEnviando.Visible = true;

                bool correoEnviado = await ControladoraAdmin.EnviarCorreoAsync(mensajeBuilder, DateTime.Now, Persona.email, "tobiastortosacontact@gmail.com", txtAsunto.Text.Trim(), Persona);
                lblEnviado.Visible = true;
                lblEnviando.Visible = false;

                if (!correoEnviado)
                {
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Complete los campos de texto";
            }
        }
    }
}
