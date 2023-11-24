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

namespace Interface.Admin
{
    public partial class AdminViajes : Form
    {
        private Person Persona {  get; set; }
        public AdminViajes(Person persona)
        {
            InitializeComponent();

            Persona = persona;

            lblNombreCompleto.Text = persona.nombre + " " + persona.apellido;

            dgvViajes.ColumnCount = 5;

            // Set the column header style.

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            dgvViajes.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dgvViajes.Columns[0].Name = "Fecha y hora";
            dgvViajes.Columns[1].Name = "Origen";
            dgvViajes.Columns[2].Name = "Destino";
            dgvViajes.Columns[3].Name = "Costo";
            dgvViajes.Columns[4].Name = "Saldo anterior";

            dgvViajes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvViajes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvViajes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvViajes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvViajes.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvViajes.RowHeadersVisible = false;

            dgvViajes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvViajes.AllowUserToResizeRows = false;

            dgvViajes.CellBorderStyle = DataGridViewCellBorderStyle.None;

            ViajeCRUD viajeCRUD = new ViajeCRUD();
            List<Viaje> viajes = viajeCRUD.GetByFK(persona.username);

            foreach (Viaje viaje in viajes)
            {
                string[] rowArray = new string[] { viaje.fecha.ToString(), viaje.origen, viaje.destino, "$" + viaje.costo.ToString(), "$" + viaje.saldoAnterior.ToString() };

                dgvViajes.Rows.Add(rowArray);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ViajeCRUD viajeCRUD = new ViajeCRUD();
            List<Viaje> viajes = viajeCRUD.GetByFK(Persona.username);
            Serializadora<Viaje>.EscribirXML(Paths.InformeViajes, viajes);
        }
    }
}
