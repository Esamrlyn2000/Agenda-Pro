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
        private Logistica _logistica;
        public contactos()
        {
            InitializeComponent();
            _logistica = new Logistica();
        }

        private void btnAad_Click(object sender, EventArgs e)
        {
            AbrirRegitro();  
        }

        private void AbrirRegitro()
        {
            infoContacto infoContacto = new infoContacto();
            infoContacto.ShowDialog(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridContactos.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            if(cell.Value.ToString() == "Edit")
            {
                infoContacto infoContacto = new infoContacto();
                infoContacto.LoadContac(new Contacto
                {
                    Id = int.Parse((gridContactos.Rows[e.RowIndex].Cells[0]).Value.ToString()),
                    nombre = gridContactos.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    apellido = gridContactos.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    telefono = gridContactos.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    dirreccion = gridContactos.Rows[e.RowIndex].Cells[4].Value.ToString()
                });
                infoContacto.ShowDialog(this);
            }
            else if(cell.Value.ToString() == "Eliminar")
            {
                EliminaContacto(int.Parse((gridContactos.Rows[e.RowIndex].Cells[0]).Value.ToString()));
                PopulateContacts();
            }
        }

        private void EliminaContacto(int id)
        {
            _logistica.EliminaContacto(id);
        }

        private void contactos_Load(object sender, EventArgs e)
        {
            PopulateContacts();
        }

        public void PopulateContacts(string buscaTexto = null)
        {
            List<Contacto> contactos = _logistica.GetContactos(buscaTexto);
            gridContactos.DataSource = contactos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PopulateContacts(txtBuscar.Text);
            txtBuscar.Text = string.Empty;
        }
    }
}
