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
using System.Xml.Serialization;

namespace Interface.Admin
{
    public partial class AdminUsers : Form
    {
        private List<Person> _persons;
        private Person _selectedPerson;
        public AdminUsers()
        {
            InitializeComponent();
            Persons = Person.ListaCompleta();

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
            dgvUsers.Rows.Clear();
            foreach (Person person in lista)
            {
                string ban;
                string admin;

                ban = "";
                admin = "";

                if (person.IsBanned)
                {
                    ban = "Si";
                }

                if (person.IsAdmin)
                {
                    admin = "Si";
                }

                string[] rowArray = new string[] { person.Nombre, person.Apellido, person.Username, person.Email, admin, ban };
                dgvUsers.Rows.Add(rowArray);
            }
        }

        private void PrintPerson(Person persona)
        {
            lblUltimoViaje.Visible = true;
            lblSubesActivadas.Visible = true;
            lblTarjetasActivadasTitle.Visible = true;
            lblUltimoViajeTitle.Visible = true;
            btnBanearUsuario.Enabled = true;
            btnVerViajes.Enabled = true;
            btnModificarUsuario.Enabled = true;

            lblNombre.Text = persona.Nombre;
            lblApellido.Text = persona.Apellido;
            lblEmail.Text = persona.Email;
            lblUsername.Text = persona.Username;
            cbAdmin.Checked = persona.IsAdmin;
            lblSubesActivadas.Text = persona.ListaSube.Count().ToString();

            if (persona.ListaViajes.Count() > 0)
            {
                lblUltimoViaje.Text = $"{persona.ListaViajes[persona.ListaViajes.Count() - 1].Origen} - {persona.ListaViajes[persona.ListaViajes.Count() - 1]?.Destino}";
            }
            else
            {
                lblUltimoViaje.Text = "No realizo ningun viaje";
            }

            if (persona.IsAdmin)
            {
                lblUltimoViaje.Visible = false;
                lblSubesActivadas.Visible = false;
                lblTarjetasActivadasTitle.Visible = false;
                lblUltimoViajeTitle.Visible = false;
                btnBanearUsuario.Enabled = false;
                btnVerViajes.Enabled = false;
                btnModificarUsuario.Enabled = false;
            }

            if (persona.IsBanned)
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

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;

            if (index >= 0)
            {
                Console.WriteLine("entro");
                SelectedPerson = Persons[index];
            }
            PrintPerson(SelectedPerson);
        }

        private void btnVerViajes_Click(object sender, EventArgs e)
        {
            AdminViajes adminViajes = new AdminViajes(SelectedPerson);
            adminViajes.Show();
        }

        private void btnBanearUsuario_Click(object sender, EventArgs e)
        {
            if (SelectedPerson.IsBanned)
            {
                UnbanDialog unban = new UnbanDialog(SelectedPerson);
                unban.ShowDialog();

                if (unban.DialogResult == DialogResult.OK)
                {
                    Persons = Person.ListaCompleta();
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
                    Persons = Person.ListaCompleta();
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

        public List<Person> Persons { get => _persons; set => _persons = value; }
        public Person SelectedPerson { get => _selectedPerson; set => _selectedPerson = value; }
    }
}
