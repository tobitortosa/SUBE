using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class SuperAdmin : Form
    {
        public SuperAdmin()
        {
            InitializeComponent();

            List<Person> persons;
            persons = new List<Person>();

            string nombreArchivo;
            string ruta;
            string path;

            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SubeDB";
            nombreArchivo = @"\personas.xml";
            path = ruta + nombreArchivo;

            persons = Serializadora.LeerPersonaXML(path);


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

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

            foreach (Person person in persons)
            {
                string[] rowArray = new string[] { person.Nombre, person.Apellido, person.Username, person.IsAdmin.ToString() };
                dataGridView1.Rows.Add(rowArray);
            }



        }



        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.dataGridView1.ClearSelection();
                    this.dataGridView1.Rows[rowSelected].Selected = true;
                }
                // you now have the selected row with the context menu showing for the user to delete etc.
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.Rows[hti.RowIndex].Selected = true;
                dataGridView1.Rows.RemoveAt(2);
                dataGridView1.ClearSelection();
            }
        }
    }
}
