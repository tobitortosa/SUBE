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
    public partial class AdminCreateSube : Form
    {
        private string _numeroTarjeta;
        private string _codigoDeSeguridad;
        private string _adminCreador;

        public AdminCreateSube(Person admin)
        {
            try
            {
                InitializeComponent();

                NumeroTarjeta = ControladoraAdmin.CrearCodigoTarjeta().Trim();
                NumeroTarjeta = "7887 2615 8248 2826";
                CodigoDeSeguridad = ControladoraAdmin.CrearCodigoSeguridad();

                List<Sube> listaCompleta;
                listaCompleta = Select<Sube>.SelectAll("sube");

                foreach (Sube sub in listaCompleta)
                {
                    if (sub.numeroDeTarjeta == NumeroTarjeta)
                    {
                        lblError.Visible = true;
                        lblError.Text = "Numero de Sube Duplicada. Archivo Generado";
                        btnCrearSube.Enabled = false;
                        throw new SubeDuplicadaException("Numero de Tarjeta duplicado en la creacion de Sube", sub);
                    }
                }

                lblCodigoDeSeguridad.Text = CodigoDeSeguridad;
                lblNumeroSube.Text = NumeroTarjeta;
                AdminCreador = admin.username;
                lblUsernameAdmin.Text = AdminCreador;
                lblFechaDeCreacion.Text = DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }

        }

        private void btnCrearSube_Click(object sender, EventArgs e)
        {
            try
            {
                Sube nuevaSube;
                nuevaSube = new Sube(NumeroTarjeta, CodigoDeSeguridad, AdminCreador, 500, false, null, DateTime.Now);

                SubeCRUD subeCRUD = new SubeCRUD();
                subeCRUD.Insert(nuevaSube);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Controladora.HandleException(ex);
            }
        }

        public string NumeroTarjeta { get => _numeroTarjeta; set => _numeroTarjeta = value; }
        public string CodigoDeSeguridad { get => _codigoDeSeguridad; set => _codigoDeSeguridad = value; }
        public string AdminCreador { get => _adminCreador; set => _adminCreador = value; }
    }
}
