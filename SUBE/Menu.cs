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
using static System.Windows.Forms.DataFormats;

namespace Interface
{
    public partial class Menu : Form
    {
        private UserDetails _userDetails;
        private ActivarSube _activarSube;

        private Person _person;

        public Menu(Person person)
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            this.Person = person;

            UserDetails = new UserDetails(person);
            ActivarSube = new ActivarSube();

            UserDetails.MdiParent = this;
            ActivarSube.MdiParent = this;

            UserDetails.Show();
            ActivarSube.Hide();

        }
        private void activarSubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivarSube.Show();
            UserDetails.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetails.Show();
            ActivarSube.Hide();
        }

        public Person Person { get => _person; set => _person = value; }
        public UserDetails UserDetails { get => _userDetails; set => _userDetails = value; }
        public ActivarSube ActivarSube { get => _activarSube; set => _activarSube = value; }

    }
}
