using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConectadoVsDesconectado
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"data source=DESKTOP-8DIVAMC\SQLEXPRESS;initial catalog = Neptuno;  User Id=usrNeptuno ; Password=123456");
            List<Empleado> empleados = new List<Empleado>();
            try
            {
               //Abrir la conexión
                connection.Open();

                //SqlCommand command = new SqlCommand("Select * from empleados where nombre like "
                //+ "'%"+ txtNombres.Text +"%' or apellidos like '%" +  txtApellidos.Text+ "%'", connection);
                //Usando procedimientos almacenados
                SqlCommand command = new SqlCommand("USP_BuscarEmpleados",connection);                
                command.CommandType = CommandType.StoredProcedure;

                //Creando parámetros
                SqlParameter parameter1 = new SqlParameter();
                parameter1.Value = txtNombres.Text.Trim();
                parameter1.ParameterName = "@Nombre";
                parameter1.SqlDbType = SqlDbType.VarChar;

                SqlParameter parameter2 = new SqlParameter();
                parameter2.Value = txtApellidos.Text.Trim();
                parameter2.ParameterName = "@Apellidos";
                parameter2.SqlDbType = SqlDbType.VarChar;

                command.Parameters.Add(parameter1);
                command.Parameters.Add(parameter2);


                //Usando el datareader
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    empleados.Add(new Empleado
                    {
                        Id = Convert.ToInt32(reader["IdEmpleado"]),
                        Nombres = Convert.ToString(reader["Nombre"]),
                        Apellidos = Convert.ToString(reader["Apellidos"]),
                    }
                   );
                }
              
                dgvEmpleados.DataSource = empleados;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();

            }
           




        }
    }
}
