using Entities;
using Entities.CRUDs;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Interface.Admin
{
    public partial class AdminUsers : Form
    {
        private List<Person> Persons { get; set; }
        private Person SelectedPerson { get; set; }
        public AdminUsers()
        {
            InitializeComponent();

            Persons = Select<Person>.SelectAll("person");

            dgvUsers.ColumnCount = 6;

            // Set the column header style.

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            dgvUsers.ColumnHeadersDefaultCellStyle = columnHeaderStyle;


            // Set the column header names.
            dgvUsers.Columns[0].Name = "Nombre";
            dgvUsers.Columns[1].Name = "Apellido";
            dgvUsers.Columns[2].Name = "Username";
            dgvUsers.Columns[3].Name = "Email";
            dgvUsers.Columns[4].Name = "Admin";
            dgvUsers.Columns[5].Name = "Ban";

            dgvUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsers.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvUsers.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvUsers.RowHeadersVisible = false;

            dgvUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvUsers.AllowUserToResizeRows = false;

            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.None;


            if (Persons.Count > 0)
            {
                PrintGrid(Persons);
                SelectedPerson = Persons[0];
                PrintPerson(SelectedPerson);
            }
        }

        private void PrintGrid(List<Person> lista)
        {
            try
            {
                dgvUsers.Rows.Clear();
                foreach (Person person in lista)
                {
                    string ban;
                    string admin;

                    ban = "";
                    admin = "";

                    if (person.ban)
                    {
                        ban = "Si";
                    }

                    if (person.admin)
                    {
                        admin = "Si";
                    }

                    string[] rowArray = new string[] { person.nombre, person.apellido, person.username, person.email, admin, ban };
                    dgvUsers.Rows.Add(rowArray);
                }
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void PrintPerson(Person persona)
        {
            try
            {
                lblUltimoViaje.Visible = true;
                lblSubesActivadas.Visible = true;
                lblTarjetasActivadasTitle.Visible = true;
                lblUltimoViajeTitle.Visible = true;
                btnBanearUsuario.Enabled = true;
                btnVerViajes.Enabled = true;

                lblNombre.Text = persona.nombre;
                lblApellido.Text = persona.apellido;
                lblEmail.Text = persona.email;
                lblUsername.Text = persona.username;
                cbAdmin.Checked = persona.admin;

                SubeCRUD subeCRUD = new SubeCRUD();
                List<Sube> subes = subeCRUD.GetByFK(persona.username);

                lblSubesActivadas.Text = subes.Count().ToString();

                if (subes.Count() > 0)
                {
                    ViajeCRUD viajeCRUD = new ViajeCRUD();
                    List<Viaje> viajes = viajeCRUD.GetByFK(persona.username);

                    lblUltimoViaje.Text = $"{viajes[viajes.Count() - 1].origen} - {viajes[viajes.Count() - 1].destino}";
                }
                else
                {
                    lblUltimoViaje.Text = "No realizo ningun viaje";
                }

                if (persona.admin)
                {
                    lblUltimoViaje.Visible = false;
                    lblSubesActivadas.Visible = false;
                    lblTarjetasActivadasTitle.Visible = false;
                    lblUltimoViajeTitle.Visible = false;
                    btnBanearUsuario.Enabled = false;
                    btnVerViajes.Enabled = false;
                }

                if (persona.ban)
                {
                    btnBanearUsuario.Text = "Desbanear Usuario";
                    lblBaneado.Visible = true;
                }
                else
                {
                    btnBanearUsuario.Text = "Banear Usuario";
                    lblBaneado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }

        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;
                index = e.RowIndex;

                if (index >= 0)
                {
                    SelectedPerson = Persons[index];
                }
                PrintPerson(SelectedPerson);
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }

        }

        private void btnVerViajes_Click(object sender, EventArgs e)
        {
            AdminViajes adminViajes = new AdminViajes(SelectedPerson);
            adminViajes.Show();
        }

        private void btnBanearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedPerson.ban)
                {
                    UnbanDialog unban = new UnbanDialog(SelectedPerson);
                    unban.ShowDialog();

                    if (unban.DialogResult == DialogResult.OK)
                    {
                        Persons = Select<Person>.SelectAll("person");
                        PrintGrid(Persons);
                        SelectedPerson = Persons[0];
                        PrintPerson(SelectedPerson);
                    }
                    else
                    {
                        unban.Close();
                    }
                }
                else
                {
                    BanDialog ban = new BanDialog(SelectedPerson);
                    ban.ShowDialog();

                    if (ban.DialogResult == DialogResult.OK)
                    {
                        Persons = Select<Person>.SelectAll("person");
                        PrintGrid(Persons);
                        SelectedPerson = Persons[0];
                        PrintPerson(SelectedPerson);
                    }
                    else
                    {
                        ban.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }

        }
    }
}
