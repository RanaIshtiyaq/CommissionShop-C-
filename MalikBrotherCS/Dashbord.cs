using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalikBrotherCS
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }
        public void showForm(Form f)
        {
            pnDb.Controls.Clear();

            f.TopLevel = false;
            pnDb.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnDashord_Click(object sender, EventArgs e)
        {

            pnDb.Controls.Clear();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            newEntry ne = new newEntry();
            showForm(ne);
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
