using Entities;
using System.Windows.Forms;

namespace Interface
{
    public partial class UserDetails : Form
    {
        private Person _persona;

        public UserDetails(Person persona)
        {
            InitializeComponent();
            Persona = persona;

            lblNombre.Text = Persona.Nombre;
            lblApellido.Text = Persona.Apellido;
            lblEmail.Text = Persona.Email;
            lblUsername.Text = Persona.Username;

            if (Persona.ListaSube.Count == 0)
            {
                lblNoSube.Visible = true;
            }
            else if (Persona.ListaSube.Count == 1)
            {
                PrintSube1(persona.ListaSube[0]);
            }
            else if (Persona.ListaSube.Count == 2)
            {
                PrintSube1(persona.ListaSube[0]);
                PrintSube2(persona.ListaSube[1]);
            }
            else if (Persona.ListaSube.Count == 3)
            {
                PrintSube1(persona.ListaSube[0]);
                PrintSube2(persona.ListaSube[1]);
                PrintSube3(persona.ListaSube[2]);
            }
            else
            {
                PrintSube1(persona.ListaSube[0]);
                PrintSube2(persona.ListaSube[1]);
                PrintSube3(persona.ListaSube[2]);
                PrintSube4(persona.ListaSube[3]);
            }
        }

        private void PrintSube1(Sube sube)
        {
            pbSube.Visible = true;

            lblNombreCompleto.Visible = true;
            lblNombreCompleto.Text = sube.NombreCompletoPropietario;

            lblSaldo.Visible = true;
            lblSaldo.Text = "$" + sube.Saldo.ToString();

            lblNumeroSube.Visible = true;
            lblNumeroSube.Text = sube.NumeroDeTarjeta;
        }

        private void PrintSube2(Sube sube)
        {
            pbSube2.Visible = true;

            lblNombreCompleto2.Visible = true;
            lblNombreCompleto2.Text = sube.NombreCompletoPropietario;

            lblSaldo2.Visible = true;
            lblSaldo2.Text = "$" + sube.Saldo.ToString();

            lblNumeroSube2.Visible = true;
            lblNumeroSube2.Text = sube.NumeroDeTarjeta;
        }

        private void PrintSube3(Sube sube)
        {
            pbSube3.Visible = true;

            lblNombreCompleto3.Visible = true;
            lblNombreCompleto3.Text = sube.NombreCompletoPropietario;

            lblSaldo3.Visible = true;
            lblSaldo3.Text = "$" + sube.Saldo.ToString();

            lblNumeroSube3.Visible = true;
            lblNumeroSube3.Text = sube.NumeroDeTarjeta;
        }

        private void PrintSube4(Sube sube)
        {
            pbSube4.Visible = true;

            lblNombreCompleto4.Visible = true;
            lblNombreCompleto4.Text = sube.NombreCompletoPropietario;

            lblSaldo4.Visible = true;
            lblSaldo4.Text = "$" + sube.Saldo.ToString();

            lblNumeroSube4.Visible = true;
            lblNumeroSube4.Text = sube.NumeroDeTarjeta;
        }

        public Person Persona { get => _persona; set => _persona = value; }
    }
}
