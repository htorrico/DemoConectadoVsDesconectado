using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class DEmpleado
    {
        SqlConnection connection = new SqlConnection(@"data source=DESKTOP-8DIVAMC\SQLEXPRESS;initial catalog = Neptuno;  User Id=usrNeptuno ; Password=123456");
        public List<Empleado> GetEmpleados(string Nombres, string Apellidos)
        {
            

            List<Empleado> empleados = new List<Empleado>();
            try
            {
                //Abrir la conexión
                connection.Open();

                //SqlCommand command = new SqlCommand("Select * from empleados where nombre like "
                //+ "'%"+ txtNombres.Text +"%' or apellidos like '%" +  txtApellidos.Text+ "%'", connection);
                //Usando procedimientos almacenados
                SqlCommand command = new SqlCommand("USP_BuscarEmpleados", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Creando parámetros
                SqlParameter parameter1 = new SqlParameter();
                parameter1.Value = Nombres.Trim();
                parameter1.ParameterName = "@Nombre";
                parameter1.SqlDbType = SqlDbType.VarChar;

                SqlParameter parameter2 = new SqlParameter();
                parameter2.Value = Apellidos.Trim();
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

                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();

            }


            return empleados;
        }
    }
}
