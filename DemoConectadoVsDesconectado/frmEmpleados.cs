using Entidad;
using Negocio;
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
        NEmpleado negocio = new NEmpleado();
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {           
            dgvEmpleados.DataSource = negocio.GetEmpleados(txtNombres.Text, txtApellidos.Text);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"data source=DESKTOP-8DIVAMC\SQLEXPRESS;initial catalog = Neptuno;  User Id=usrNeptuno ; Password=123456");
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("USP_InsertarEmpleados", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Creando parámetros
                SqlParameter parameter1 = new SqlParameter();
                parameter1.Value =Convert.ToInt32( txtId.Text.Trim());
                parameter1.ParameterName = "@IdEmpleado";
                parameter1.SqlDbType = SqlDbType.Int;

                SqlParameter parameter2 = new SqlParameter();
                parameter2.Value = txtNombresInsertar.Text.Trim();
                parameter2.ParameterName = "@Nombres";
                parameter2.SqlDbType = SqlDbType.VarChar;

                SqlParameter parameter3 = new SqlParameter();
                parameter3.Value = txtApellidosInsertar.Text.Trim();
                parameter3.ParameterName = "@Apellidos";
                parameter3.SqlDbType = SqlDbType.VarChar;

                command.Parameters.Add(parameter1);
                command.Parameters.Add(parameter2);
                command.Parameters.Add(parameter3);


                command.ExecuteNonQuery();
                MessageBox.Show("Registró Correctamente");

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
