using Entities;
using Entities.CRUDs;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface
{
    public partial class ViajarConfirmacion : Form
    {
        private Person _persona;
        private Sube _selectedSube;
        private List<Sube> _allSubes;
        private double _costo;
        private string _origen;
        private string _destino;

        public ViajarConfirmacion(string origen, string destino, double costo, Person persona)
        {
            InitializeComponent();
            lblOrigen.Text = origen;
            lblDestino.Text = destino;
            lblCosto.Text = "$" + costo.ToString();

            Origen = origen;
            Destino = destino;

            Persona = persona;

            SubeCRUD subeCRUD = new SubeCRUD();
            List<Sube> listaSubes = subeCRUD.GetByFK(Persona.username);

            SelectedSube = listaSubes[0];
            Costo = costo;

            ImprimirSube(SelectedSube);

            cbSube.Items.Clear();
            foreach (Sube sube in listaSubes)
            {
                cbSube.Items.Add(sube.numeroDeTarjeta);
            }
        }

        public Person Persona { get => _persona; set => _persona = value; }
        public Sube SelectedSube { get => _selectedSube; set => _selectedSube = value; }
        public List<Sube> AllSubes { get => _allSubes; set => _allSubes = value; }
        public double Costo { get => _costo; set => _costo = value; }
        public string Origen { get => _origen; set => _origen = value; }
        public string Destino { get => _destino; set => _destino = value; }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(SelectedSube.saldo);
                if (SelectedSube.saldo - Costo > 0)
                {
                    ViajeCRUD viajeCRUD = new ViajeCRUD();  

                    Viaje nuevoViaje = new Viaje(Origen, Destino, Costo, DateTime.Now, SelectedSube.saldo, Persona.username);
                    viajeCRUD.Insert(nuevoViaje);

                    SelectedSube.saldo -= Costo;
                    SubeCRUD subeCRUD = new SubeCRUD();
                    subeCRUD.Update(SelectedSube);

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Saldo insuficiente";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Controladora.HandleException(ex);
            }

        }
        private void ViajarConfirmacion_Load(object sender, EventArgs e)
        {
            cbSube.SelectedItem = null;
            cbSube.SelectedText = SelectedSube.numeroDeTarjeta;
        }

        private void cbSube_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SubeCRUD subeCRUD = new SubeCRUD();
                List<Sube> listaSubes = subeCRUD.GetByFK(Persona.username);

                foreach (Sube sube in listaSubes)
                {
                    if (sube.numeroDeTarjeta == cbSube.Text)
                    {
                        SelectedSube = sube;
                    }
                }
                Console.WriteLine(SelectedSube.saldo);
                ImprimirSube(SelectedSube);
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void ImprimirSube(Sube sube)
        {
            lblNumeroSube.Text = sube.numeroDeTarjeta;
            lblSaldo.Text = "$" + sube.saldo.ToString();
            lblUsuarioPropietario.Text = Persona.nombre + " " + Persona.apellido;
        }
    }
}
