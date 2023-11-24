using Entities;
using Entities.CRUDs;
using Entities.Entidades;
using SUBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class SuperAdmin : Form
    {
        private List<Person> _persons;
        private List<Person> _allPersons;
        private Person _selectedPerson;
        private string Input {  get; set; }
        public SuperAdmin()
        {
            InitializeComponent();

            Persons = Select<Person>.SelectAll("person");
            AllPersons = Persons;

            // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnCount = 4;

            // Set the column header style.

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;


            // Set the column header names.
            dataGridView1.Columns[0].Name = "Nombre";
            dataGridView1.Columns[1].Name = "Apellido";
            dataGridView1.Columns[2].Name = "Username";
            dataGridView1.Columns[3].Name = "Es Admin";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

            foreach (Person person in AllPersons)
            {
                string[] rowArray = new string[] { person.nombre, person.apellido, person.username, person.admin.ToString() };
                dataGridView1.Rows.Add(rowArray);
            }

            SelectedPerson = Persons[0];
        }

        public List<Person> Persons { get => _persons; set => _persons = value; }
        public Person SelectedPerson { get => _selectedPerson; set => _selectedPerson = value; }
        public List<Person> AllPersons { get => _allPersons; set => _allPersons = value; }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;
                index = e.RowIndex;

                if (Persons.Count != index && index >= 0)
                {
                    SelectedPerson = Persons[index];
                }
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void btnHacerAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedPerson.admin = true;
                PersonCRUD personCRUD = new PersonCRUD();
                personCRUD.Update(SelectedPerson);

                dataGridView1.Rows.Clear();

                foreach (Person person in Persons)
                {
                    if (person == SelectedPerson)
                    {
                        person.admin = true;
                    }

                    string[] rowArray = new string[] { person.nombre, person.apellido, person.username, person.admin.ToString() };
                    dataGridView1.Rows.Add(rowArray);
                }

                dataGridView1.ClearSelection();
                dataGridView1.Rows[Persons.IndexOf(SelectedPerson)].Selected = true;
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void txtBuscarPersona_TextChanged(object sender, EventArgs e)
        {
            Input = txtBuscarPersona.Text.ToUpper();
            if(Input != "")
            {
                Persons = Persons.Filtrar(p => p.username.ToUpper().Contains(Input) || p.nombre.ToUpper().Contains(Input) || p.apellido.ToUpper().Contains(Input));
            }
            else
            {
                Persons = AllPersons;
            }

            dataGridView1.Rows.Clear();
            foreach (Person person in Persons)
            {
                string[] rowArray = new string[] { person.nombre, person.apellido, person.username, person.admin.ToString() };
                dataGridView1.Rows.Add(rowArray);
            }
        }

        private void btnEliminarAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedPerson.admin = false;
                PersonCRUD personCRUD = new PersonCRUD();
                personCRUD.Update(SelectedPerson);

                dataGridView1.Rows.Clear();

                foreach (Person person in Persons)
                {
                    if (person == SelectedPerson)
                    {
                        person.admin = false;
                    }

                    string[] rowArray = new string[] { person.nombre, person.apellido, person.username, person.admin.ToString() };
                    dataGridView1.Rows.Add(rowArray);
                }

                dataGridView1.ClearSelection();
                dataGridView1.Rows[Persons.IndexOf(SelectedPerson)].Selected = true;
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
