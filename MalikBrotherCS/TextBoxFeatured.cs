using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalikBrotherCS
{
    public partial class TextBoxFeatured : UserControl
    {
        public TextBoxFeatured()
        {
            InitializeComponent();
        }
        private void textBoxCus_MouseHover(object sender, EventArgs e)
        {
            pnCus.BackColor = Color.DarkBlue;
            this.Focus();
        }

        private void textBoxCus_Leave(object sender, EventArgs e)
        {
            pnCus.BackColor = Color.Black;
        }

    }
}
