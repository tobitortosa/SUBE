using Entities;
using Interface.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface
{
    public partial class ViajarMenu : Form
    {
        private string _ramal;
        private List<string> _colection;
        private Person _persona;
        public ViajarMenu(Person person)
        {
            InitializeComponent();

            Persona = person;

            Colection = new List<string>();

            rbtnLaPlata.Checked = true;
            Ramal = "La Plata";

            HandleColection(Ramal);

            if (Persona.ListaSube.Count == 0)
            {
                btnViajar.Enabled = false;
                lblError.Text = "Usted no posee ninguna SUBE activada";
                lblError.Visible = true;
            }
        }

        public string Ramal { get => _ramal; set => _ramal = value; }
        public List<string> Colection { get => _colection; set => _colection = value; }
        public Person Persona { get => _persona; set => _persona = value; }

        private void rbtnLaPlata_CheckedChanged(object sender, EventArgs e)
        {
            if (Ramal != "La Plata")
            {
                Ramal = "La Plata";
                HandleColection(Ramal);
                lblGasto.Text = "$0";
            }
        }

        private void rbtnGutierrez_CheckedChanged(object sender, EventArgs e)
        {
            if (Ramal != "Gutierrez")
            {
                Ramal = "Gutierrez";
                HandleColection(Ramal);
                lblGasto.Text = "$0";
            }
        }

        private void rbtnChascomus_CheckedChanged(object sender, EventArgs e)
        {
            if (Ramal != "Chascomus")
            {
                Ramal = "Chascomus";
                HandleColection(Ramal);
                lblGasto.Text = "$0";
            }
        }

        private void rbtnCañuelas_CheckedChanged(object sender, EventArgs e)
        {
            if (Ramal != "Cañuelas")
            {
                Ramal = "Cañuelas";
                HandleColection(Ramal);
                lblGasto.Text = "$0";
            }

        }

        private void rbtnHaedo_CheckedChanged(object sender, EventArgs e)
        {
            if (Ramal != "Haedo")
            {
                Ramal = "Haedo";
                HandleColection(Ramal);
                lblGasto.Text = "$0";
            }
        }

        private int HandleViajeCost(string origen, string destino)
        {
            int origenIndex;
            int destinoIndex;
            int resto;
            int costo;

            origenIndex = Colection.IndexOf(origen);
            destinoIndex = Colection.IndexOf(destino);

            resto = destinoIndex - origenIndex;

            costo = ConvertToPositive(resto);
            return costo * 4;
        }

        private void btnViajar_Click(object sender, EventArgs e)
        {
            int costo;
            string origen;
            string destino;

            origen = cbOrigen.Text;
            destino = cbDestino.Text;

            if (origen == "Seleccionar..." && destino == "Seleccionar...")
            {
                lblError.Visible = true;
                lblError.Text = "Elija un origen y un destino";
            }
            else if (origen == destino)
            {
                lblError.Visible = true;
                lblError.Text = "Elija un origen y destino distintos";
            }
            else if (origen != "Seleccionar..." && destino != "Seleccionar...")
            {
                lblError.Visible = false;

                costo = HandleViajeCost(origen, destino);

                List<Person> listaCompleta;
                listaCompleta = Person.ListaCompleta();

                foreach (Person person in listaCompleta)
                {
                    if(person.Username == Persona.Username)
                    {
                        Persona = person;
                    }
                }


                ViajarConfirmacion viajarConfirmacion = new ViajarConfirmacion(origen, destino, costo, Persona);
                viajarConfirmacion.ShowDialog();
                if (viajarConfirmacion.DialogResult == DialogResult.OK)
                {
                    viajarConfirmacion.Close();
                    Console.Write("Confirmado");
                }
            }
            else if (origen != "Seleccionar...")
            {
                lblError.Visible = true;
                lblError.Text = "Elija un Destino";
            }
            else if (destino != "Seleccionar...")
            {
                lblError.Visible = true;
                lblError.Text = "Elija un Origen";
            }
        }

        private static int ConvertToPositive(int i)
        {
            return (i + (i >> 31)) ^ (i >> 31);
        }
        private void cbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOrigen.Text != "" && cbDestino.Text != "")
            {
                lblOrigen.Text = cbOrigen.Text;
                lblGasto.Text = "$" + HandleViajeCost(cbOrigen.Text, cbDestino.Text).ToString();
            }
        }

        private void cbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOrigen.Text != "" && cbDestino.Text != "")
            {
                lblDestino.Text = cbDestino.Text;
                lblGasto.Text = "$" + HandleViajeCost(cbOrigen.Text, cbDestino.Text).ToString();
            }
        }
        private void HandleColection(string ramal)
        {
            cbOrigen.Items.Clear();
            cbDestino.Items.Clear();
            Colection.Clear();

            switch (ramal)
            {
                case "La Plata":
                    Colection.Add("Plaza Constitucion");
                    Colection.Add("Avellaneda");
                    Colection.Add("Sarandí");
                    Colection.Add("Villa Dominico");
                    Colection.Add("Wilde");
                    Colection.Add("Don Bosco");
                    Colection.Add("Bernal");
                    Colection.Add("Quilmes");
                    Colection.Add("Ezpeleta");
                    Colection.Add("Berazategui");
                    Colection.Add("Plátanos");
                    Colection.Add("Hudson");
                    Colection.Add("Pereyra");
                    Colection.Add("Villa Elisa");
                    Colection.Add("City Bell");
                    Colection.Add("Ringuelet");
                    Colection.Add("Tolosa");
                    Colection.Add("La Plata");
                    break;

                case "Gutierrez":
                    Colection.Add("Plaza Constitucion");
                    Colection.Add("Avellaneda");
                    Colection.Add("Sarandí");
                    Colection.Add("Villa Dominico");
                    Colection.Add("Wilde");
                    Colection.Add("Don Bosco");
                    Colection.Add("Bernal");
                    Colection.Add("Quilmes");
                    Colection.Add("Ezpeleta");
                    Colection.Add("Berazategui");
                    Colection.Add("Villa España");
                    Colection.Add("Ranelagh");
                    Colection.Add("Sourígues");
                    Colection.Add("Marmol");
                    Colection.Add("Rafael Calzada");
                    Colection.Add("Claypole");
                    Colection.Add("Ardigó");
                    Colection.Add("Florencio Varela");
                    Colection.Add("Zeballos");
                    Colection.Add("Bosques");
                    Colection.Add("Santa Sofía");
                    Colection.Add("Gutiérrez");
                    break;

                case "Chascomus":
                    Colection.Add("Plaza Constitucion");
                    Colection.Add("Hipolito Yrigoyen");
                    Colection.Add("Avellaneda");
                    Colection.Add("Gerli");
                    Colection.Add("Lanús");
                    Colection.Add("Remedios de Escalada");
                    Colection.Add("Banfield");
                    Colection.Add("Lomas de Zamora");
                    Colection.Add("Temperley");
                    Colection.Add("Adrogue");
                    Colection.Add("Burzaco");
                    Colection.Add("Longchamps");
                    Colection.Add("Glew");
                    Colection.Add("Guernica");
                    Colection.Add("Alejandro Korn");
                    Colection.Add("Brandsen");
                    Colection.Add("Jeppener");
                    Colection.Add("Altamirano");
                    Colection.Add("Chascomús");
                    break;

                case "Cañuelas":
                    Colection.Add("Plaza Constitucion");
                    Colection.Add("Hipolito Yrigoyen");
                    Colection.Add("Avellaneda");
                    Colection.Add("Gerli");
                    Colection.Add("Lanús");
                    Colection.Add("Remedios de Escalada");
                    Colection.Add("Banfield");
                    Colection.Add("Lomas de Zamora");
                    Colection.Add("Temperley");
                    Colection.Add("Turdera");
                    Colection.Add("Lavallol");
                    Colection.Add("Luis Guillón");
                    Colection.Add("Monte Grande");
                    Colection.Add("El Jaguel");
                    Colection.Add("Ezieza");
                    Colection.Add("Union Ferroviaria");
                    Colection.Add("Tristán Suárez");
                    Colection.Add("Spegazzini");
                    Colection.Add("Máximo Paz");
                    Colection.Add("Vicente Casares");
                    Colection.Add("Alexandre Petión");
                    Colection.Add("Klossterman");
                    Colection.Add("Ricardo Levene");
                    break;
                case "Haedo":
                    Colection.Add("Temperley");
                    Colection.Add("Hospital Español");
                    Colection.Add("Santa Catalina");
                    Colection.Add("Juan XXIII");
                    Colection.Add("Kim 34");
                    Colection.Add("Pedro Pablo Turner");
                    Colection.Add("De Elía");
                    Colection.Add("Tablada");
                    Colection.Add("San Justo");
                    Colection.Add("Brian");
                    Colection.Add("Haedo");
                    break;
            }





            foreach (string localidad in Colection)
            {
                cbOrigen.Items.Add(localidad);
                cbDestino.Items.Add(localidad);
            }
        }

        private void ViajarMenu_Load(object sender, EventArgs e)
        {
            cbOrigen.SelectedItem = null;
            cbOrigen.SelectedText = "Seleccionar...";

            cbDestino.SelectedItem = null;
            cbDestino.SelectedText = "Seleccionar...";
        }
    }
}
