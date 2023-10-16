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

namespace Interface
{
    public partial class AdminMenu : Form
    {
        private AdminSube _adminSube;
        private Person _admin;

        public AdminMenu(Person admin)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.Person = admin;

            AdminSube = new AdminSube(admin);
            AdminSube.MdiParent = this;
            AdminSube.Show();
        }

        public AdminSube AdminSube { get => _adminSube; set => _adminSube = value; }
        public Person Person { get => _admin; set => _admin = value; }

    }
}
