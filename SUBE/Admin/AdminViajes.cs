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

namespace Interface.Admin
{
    public partial class AdminViajes : Form
    {
        public AdminViajes(Person persona)
        {
            InitializeComponent();

            lblNombreCompleto.Text = persona.Nombre + " " + persona.Apellido;

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


            foreach (Viaje viaje in persona.ListaViajes)
            {
                string[] rowArray = new string[] { viaje.Fecha.ToString(), viaje.Origen, viaje.Destino, "$" + viaje.Costo.ToString(), "$" + viaje.SaldoAnterior.ToString() };

                dgvViajes.Rows.Add(rowArray);
            }
        }
    }
}
