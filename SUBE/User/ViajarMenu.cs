using Entities;
using Entities.CRUDs;
using Entities.Entidades;
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
        public ViajarMenu(Person persona, Action<Control> PaintLabel, Config settings)
        {
            InitializeComponent();

            Persona = persona;

            this.BackColor = settings.BackgroundColor;
            PaintLabel(this);

            Colection = new List<string>();

            rbtnLaPlata.Checked = true;
            Ramal = "La Plata";

            HandleColection(Ramal);

            SubeCRUD subeCRUD = new SubeCRUD();
            List<Sube> listaSubes = subeCRUD.GetByFK(Persona.username);

            if (listaSubes.Count == 0)
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
            try
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

                    PersonCRUD personCRUD = new PersonCRUD();
                    Person persona = personCRUD.GetByPK(Persona.username);

                    Persona = persona;

                    ViajarConfirmacion viajarConfirmacion = new ViajarConfirmacion(origen, destino, costo, Persona);
                    viajarConfirmacion.ShowDialog();
                    if (viajarConfirmacion.DialogResult == DialogResult.OK)
                    {
                        viajarConfirmacion.Close();
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
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
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

            List<Estacion> lista;
            lista = new List<Estacion>();
            EstacionCRUD estacionCRUD = new EstacionCRUD();

            switch (ramal)
            {
                case "La Plata":

                    lista.Clear();
                    lista = estacionCRUD.GetByFK("La Plata");
                    foreach (Estacion e in lista)
                    {
                        Colection.Add(e.nombre);
                    }
                    break;

                case "Gutierrez":

                    lista.Clear();
                    lista = estacionCRUD.GetByFK("Gutierrez");
                    foreach (Estacion e in lista)
                    {
                        Colection.Add(e.nombre);
                    }
                    break;

                case "Chascomus":
                    lista.Clear();
                    lista = estacionCRUD.GetByFK("Chascomus");
                    foreach (Estacion e in lista)
                    {
                        Colection.Add(e.nombre);
                    }
                    break;

                case "Cañuelas":
                    lista.Clear();
                    lista = estacionCRUD.GetByFK("Cañuelas");
                    foreach (Estacion e in lista)
                    {
                        Colection.Add(e.nombre);
                    }
                    break;
                case "Haedo":
                    lista.Clear();
                    lista = estacionCRUD.GetByFK("Haedo");
                    foreach (Estacion e in lista)
                    {
                        Colection.Add(e.nombre);
                    }
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
