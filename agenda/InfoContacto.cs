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
        private Contacto _contacto;
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
            guardaContacto();
            this.Close();
    
            ((contactos)this.Owner).PopulateContacts();
        }


        private void guardaContacto()
        {
            SaveContact();
        }

        private void SaveContact()
        {
            Contacto contacto = new Contacto();
            contacto.nombre = txtNombre.Text;
            contacto.apellido = txtApellido.Text;
            contacto.telefono = txtTelefono.Text;
            contacto.dirreccion = txtDireccion.Text;

            contacto.Id = _contacto != null ? _contacto.Id : 0;

            _logistica.SalvaContactos(contacto);
        }

        public void LoadContac(Contacto contacto)
        {
            _contacto = contacto;
            if (contacto != null)
            {
                ClearForm();

                txtNombre.Text = contacto.nombre;
                txtApellido.Text = contacto.apellido;
                txtTelefono.Text = contacto.telefono;   
                txtDireccion.Text = contacto.dirreccion;

            }
        }

        private void ClearForm()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }

    }
}
