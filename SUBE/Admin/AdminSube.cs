using Entities;
using Interface.Admin;
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

namespace Interface
{

    public partial class AdminSube : Form
    {
        private Person _admin;
        private List<Sube> Subes;
        private List<Sube> AllSubes;
        private Sube _selectedSube;
        private string _ruta;
        private string _nombreArchivo;

        public AdminSube(Person admin)
        {
            InitializeComponent();

            Admin = admin;
            Subes = new List<Sube>();
            AllSubes = new List<Sube>();

            string nombreArchivo;
            string ruta;
            string path;

            Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            NombreArchivo = @"\subes.xml";
            path = Ruta + NombreArchivo;

            Sube.FileExist(path);

            Subes = Serializadora.LeerSubeXML(path);
            AllSubes = Subes;

            // Create an unbound DataGridView by declaring a column count.
            dgvSubes.ColumnCount = 6;

            // Set the column header style.

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            dgvSubes.ColumnHeadersDefaultCellStyle = columnHeaderStyle;


            // Set the column header names.
            dgvSubes.Columns[0].Name = "Creador";
            dgvSubes.Columns[1].Name = "Saldo";
            dgvSubes.Columns[2].Name = "Activada";
            dgvSubes.Columns[3].Name = "Fecha Creada";
            dgvSubes.Columns[4].Name = "Codigo de Seguridad";
            dgvSubes.Columns[5].Name = "Numero de Tarjeta";

            dgvSubes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSubes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSubes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSubes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSubes.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSubes.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSubes.RowHeadersVisible = false;

            dgvSubes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvSubes.AllowUserToResizeRows = false;

            dgvSubes.CellBorderStyle = DataGridViewCellBorderStyle.None;



            if (Subes.Count > 0)
            {
                foreach (Sube sube in AllSubes)
                {
                    string[] rowArray = new string[] { sube.UsernameAdminCreador, sube.Saldo.ToString(), sube.Activada.ToString(), sube.DiaCreada.ToString(), sube.CodigoDeSeguridad, sube.NumeroDeTarjeta };
                    dgvSubes.Rows.Add(rowArray);
                }
                SelectedSube = Subes[0];
                PrintSube();
            }
        }

        public Person Admin { get => _admin; set => _admin = value; }
        public string Ruta { get => _ruta; set => _ruta = value; }
        public string NombreArchivo { get => _nombreArchivo; set => _nombreArchivo = value; }
        public Sube SelectedSube { get => _selectedSube; set => _selectedSube = value; }

        private void btnCrearSube_Click(object sender, EventArgs e)
        {
            AdminCreateSube adminCreateSube = new AdminCreateSube(Admin);
            adminCreateSube.ShowDialog();

            if (adminCreateSube.DialogResult == DialogResult.OK)
            {
                string path;
                path = Ruta + NombreArchivo;
                Subes = Serializadora.LeerSubeXML(path);
                dgvSubes.Rows.Clear();
                foreach (Sube sube in Subes)
                {
                    string[] rowArray = new string[] { sube.UsernameAdminCreador, sube.Saldo.ToString(), sube.Activada.ToString(), sube.DiaCreada.ToString(), sube.CodigoDeSeguridad, sube.NumeroDeTarjeta };
                    dgvSubes.Rows.Add(rowArray);
                }
                SelectedSube = Subes[0];
                PrintSube();
                adminCreateSube.Close();
            }
        }

        private void dgvSubes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;

            Console.WriteLine(index);

            if (index >= 0)
            {
                SelectedSube = Subes[index];
            }
            PrintSube();
        }

        private void PrintSube()
        {
            lblNumeroSube.Text = SelectedSube.NumeroDeTarjeta;
            lblSaldo.Text = SelectedSube.Saldo.ToString();

            if (SelectedSube.Activada)
            {
                lblNombreCompleto.Text = "Tobias Tortosa";
            }
            else
            {
                lblNombreCompleto.Text = "Desactivada";
            }
        }

        private void btnEliminarSube_Click(object sender, EventArgs e)
        {
            List<Sube> listaFiltrada;
            listaFiltrada = new List<Sube>();
            string path;
            path = Ruta + NombreArchivo;

            foreach (Sube sube in Subes)
            {
                if (sube != SelectedSube)
                {
                    listaFiltrada.Add(sube);
                }
            }

            Serializadora.EscribirSubeXML(path, listaFiltrada);
            Console.WriteLine(listaFiltrada.Count.ToString());

            Subes = listaFiltrada;

            dgvSubes.Rows.Clear();
            foreach (Sube sube in Subes)
            {
                string[] rowArray = new string[] { sube.UsernameAdminCreador, sube.Saldo.ToString(), sube.Activada.ToString(), sube.DiaCreada.ToString(), sube.CodigoDeSeguridad, sube.NumeroDeTarjeta };
                dgvSubes.Rows.Add(rowArray);
            }

            if (Subes.Count > 0)
            {
                SelectedSube = Subes[0];
                PrintSube();
            } else
            {
                lblNombreCompleto.Text = "Nombre Completo";
                lblNumeroSube.Text = "0000 0000 0000 0000";
                lblSaldo.Text = "000";
            }

        }
    }
}
