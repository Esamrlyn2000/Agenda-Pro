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
    public partial class infoContacto : Form
    {
        private Logistica _logistica;
        public infoContacto()
        {
            InitializeComponent();
            _logistica = new Logistica();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto();
            contacto.nombre = txtNombre.Text;
            contacto.apellido = txtApellido.Text;
            contacto.telefono = txtTelefono.Text;
            contacto.dirreccion = txtDireccion.Text;
        }
    }
}
