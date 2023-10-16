using Entities;
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

        private string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
        private string nombreArchivo = @"\personas.xml";
        public SuperAdmin()
        {
            InitializeComponent();

            Persons = new List<Person>();
            AllPersons = new List<Person>();

            string nombreArchivo;
            string ruta;
            string path;

            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            nombreArchivo = @"\personas.xml";
            path = ruta + nombreArchivo;

            Persons = Serializadora.LeerPersonaXML(path);
            AllPersons = Serializadora.LeerPersonaXML(path);

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
                string[] rowArray = new string[] { person.Nombre, person.Apellido, person.Username, person.IsAdmin.ToString() };
                dataGridView1.Rows.Add(rowArray);
            }

            SelectedPerson = Persons[0];
        }

        public List<Person> Persons { get => _persons; set => _persons = value; }
        public Person SelectedPerson { get => _selectedPerson; set => _selectedPerson = value; }
        public List<Person> AllPersons { get => _allPersons; set => _allPersons = value; }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;

            if (Persons.Count != index && index >= 0)
            {
                SelectedPerson = Persons[index];
            }
        }

        private void btnHacerAdmin_Click(object sender, EventArgs e)
        {
            string path = ruta + nombreArchivo;
            SelectedPerson.IsAdmin = true;
            Serializadora.EscribirPersonaXML(path, Persons);

            dataGridView1.Rows.Clear();

            foreach (Person person in Persons)
            {
                if (person == SelectedPerson)
                {
                    person.IsAdmin = true;
                }

                string[] rowArray = new string[] { person.Nombre, person.Apellido, person.Username, person.IsAdmin.ToString() };
                dataGridView1.Rows.Add(rowArray);
            }

            dataGridView1.ClearSelection();
            dataGridView1.Rows[Persons.IndexOf(SelectedPerson)].Selected = true;
        }

        private void txtBuscarPersona_TextChanged(object sender, EventArgs e)
        {
            string input = txtBuscarPersona.Text.ToUpper();
            List<Person> listaFiltrada = new List<Person>();

            Persons = AllPersons;
            foreach (Person person in Persons)
            {
                if (person.Username.ToUpper().Contains(input) || person.Nombre.ToUpper().Contains(input) || person.Apellido.ToUpper().Contains(input))
                {
                    listaFiltrada.Add(person);
                }
            }
            Persons = listaFiltrada;

            dataGridView1.Rows.Clear();
            foreach (Person person in Persons)
            {
                string[] rowArray = new string[] { person.Nombre, person.Apellido, person.Username, person.IsAdmin.ToString() };
                dataGridView1.Rows.Add(rowArray);
            }
        }

        private void btnEliminarAdmin_Click(object sender, EventArgs e)
        {
            string path = ruta + nombreArchivo;
            SelectedPerson.IsAdmin = false;
            Serializadora.EscribirPersonaXML(path, Persons);

            dataGridView1.Rows.Clear();

            foreach (Person person in Persons)
            {
                if (person == SelectedPerson)
                {
                    person.IsAdmin = false;
                }

                string[] rowArray = new string[] { person.Nombre, person.Apellido, person.Username, person.IsAdmin.ToString() };
                dataGridView1.Rows.Add(rowArray);
            }

            dataGridView1.ClearSelection();
            dataGridView1.Rows[Persons.IndexOf(SelectedPerson)].Selected = true;
        }
    }
}
