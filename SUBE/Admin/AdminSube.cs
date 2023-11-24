using Entities;
using Entities.CRUDs;
using Entities.Entidades;
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
        private Sube _selectedSube;

        public AdminSube(Person admin)
        {
            InitializeComponent();

            Admin = admin;

            Subes = new List<Sube>();
            Subes = Select<Sube>.SelectAll("sube");


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

            dgvSubes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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
                foreach (Sube sube in Subes)
                {
                    string[] rowArray = new string[] { sube.creator_username, sube.saldo.ToString(), sube.activada.ToString(), sube.diaCreada.ToString(), sube.codigoDeSeguridad, sube.numeroDeTarjeta };
                    dgvSubes.Rows.Add(rowArray);
                }

                SelectedSube = Subes[0];
                PrintSube();
            }
        }

        public Person Admin { get => _admin; set => _admin = value; }
        public Sube SelectedSube { get => _selectedSube; set => _selectedSube = value; }

        private void btnCrearSube_Click(object sender, EventArgs e)
        {
            try
            {
                AdminCreateSube adminCreateSube = new AdminCreateSube(Admin);
                adminCreateSube.ShowDialog();

                if (adminCreateSube.DialogResult == DialogResult.OK)
                {
                    Subes = Select<Sube>.SelectAll("sube");
                    dgvSubes.Rows.Clear();

                    foreach (Sube sube in Subes)
                    {
                        string[] rowArray = new string[] { sube.creator_username, sube.saldo.ToString(), sube.activada.ToString(), sube.diaCreada.ToString(), sube.codigoDeSeguridad, sube.numeroDeTarjeta };
                        dgvSubes.Rows.Add(rowArray);
                    }

                    SelectedSube = Subes[0];
                    PrintSube();
                    adminCreateSube.Close();
                }
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }

        }

        private void dgvSubes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;
                index = e.RowIndex;

                if (index >= 0)
                {
                    SelectedSube = Subes[index];
                }
                PrintSube();
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void PrintSube()
        {
            try
            {
                lblNumeroSube.Text = SelectedSube.numeroDeTarjeta;
                lblSaldo.Text = "$" + SelectedSube.saldo.ToString();

                if (SelectedSube.activada)
                {
                    PersonCRUD personCRUD = new PersonCRUD();
                    Person person = personCRUD.GetByPK(SelectedSube.person_username);
                    lblUsuarioPropietario.Text = person.nombre + " " + person.apellido;
                }
                else
                {
                    lblUsuarioPropietario.Text = "Desactivada";
                }
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void btnEliminarSube_Click(object sender, EventArgs e)
        {
            try
            {
                SubeCRUD subeCRUD = new SubeCRUD();
                subeCRUD.Delete(SelectedSube.numeroDeTarjeta);

                Subes = Select<Sube>.SelectAll("sube");

                dgvSubes.Rows.Clear();
                foreach (Sube sube in Subes)
                {
                    string[] rowArray = new string[] { sube.creator_username, sube.saldo.ToString(), sube.activada.ToString(), sube.diaCreada.ToString(), sube.codigoDeSeguridad, sube.numeroDeTarjeta };
                    dgvSubes.Rows.Add(rowArray);
                }

                if (Subes.Count > 0)
                {
                    SelectedSube = Subes[0];
                    PrintSube();
                }
                else
                {
                    lblUsuarioPropietario.Text = "Nombre Apellido";
                    lblNumeroSube.Text = "0000 0000 0000 0000";
                    lblSaldo.Text = "000";
                }
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void AdminSube_Load(object sender, EventArgs e)
        {

        }

        private void lblUsuarioPropietario_Click(object sender, EventArgs e)
        {
        }

        private void lblNumeroSube_Click(object sender, EventArgs e)
        {
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {
        }
    }
}
