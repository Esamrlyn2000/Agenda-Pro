using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda
{
    public class Acceso
    {
        public SqlConnection conn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Agenda;Data Source=COMPUTOS6\SQLEXPRESS");

        public void insertar(Contacto contacto)
        {
            try
            {
                conn.Open();
                string query = @"
                    INSERT INTO Contactos (Nombre, Apellido, Telefono, Direccion)
                    VALUES (@Nombre, @Apellido, @Telefono, @Direccion) ";
                SqlParameter nombre = new SqlParameter();
                nombre.ParameterName = "@Nombre";
                nombre.Value = contacto.nombre;
                nombre.DbType = System.Data.DbType.String;

                SqlParameter apellido = new SqlParameter("@Apellido", contacto.apellido);
                SqlParameter telefono = new SqlParameter("@Telefono", contacto.telefono);
                SqlParameter Direccion = new SqlParameter("@Direccion", contacto.dirreccion);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(nombre);
                command.Parameters.Add(apellido);
                command.Parameters.Add(telefono);
                command.Parameters.Add(Direccion);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ex.Message,"Mensaje de notificacion",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
