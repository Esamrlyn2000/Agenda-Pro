using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda
{
    public partial class contactos : Form
    {
        public contactos()
        {
            InitializeComponent();
        }

        private void btnAad_Click(object sender, EventArgs e)
        {
            AbrirRegitro();  
        }

        private void AbrirRegitro()
        {
            infoContacto infoContacto = new infoContacto();
            infoContacto.ShowDialog();
        }
    }
}
