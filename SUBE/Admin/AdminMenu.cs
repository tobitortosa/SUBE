using Entities;
using Interface.Admin;
using SUBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class AdminMenu : Form
    {
        private AdminSube _adminSube;
        private AdminUsers _adminUsers;
        private Person _admin;

        public AdminMenu(Person admin)
        {
            InitializeComponent();
            IsMdiContainer = true;
            Person = admin;

            AdminSube = new AdminSube(admin);
            AdminUsers = new AdminUsers();

            AdminSube.MdiParent = this;
            AdminUsers.MdiParent = this;

            AdminUsers.Show();
        }

        public AdminSube AdminSube { get => _adminSube; set => _adminSube = value; }
        public Person Person { get => _admin; set => _admin = value; }
        public AdminUsers AdminUsers { get => _adminUsers; set => _adminUsers = value; }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void sUBESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSube.Show();
            AdminUsers.Hide();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminUsers.Show();
            AdminSube.Hide();
        }
    }
}
