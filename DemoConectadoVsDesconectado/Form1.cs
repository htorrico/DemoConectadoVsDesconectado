using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//Ado .net
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConectadoVsDesconectado
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("data source=DESKTOP-8DIVAMC;initial catalog = Neptuno; Integrated Security = True;");

                 connection.Open();

                SqlCommand command = new SqlCommand("Select * from empleados", connection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);                

                dataAdapter.Fill(dataTable);
                connection.Close();//DESCONECTADO
                //dgvEmpleados.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }         
        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<Empleado> empleados = new List<Empleado>();

            SqlConnection connection = new SqlConnection("data source=DESKTOP-8DIVAMC;initial catalog = Neptuno; Integrated Security = True;");

            connection.Open();

            SqlCommand command = new SqlCommand("Select * from empleados", connection);

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

            connection.Close();

            dgvEmpleados.DataSource = empleados;
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Empleado> empleados = new List<Empleado>();


            foreach (DataRow row in dataTable.Rows)
            {
                if(row["Jefe"].ToString() == "5"){
                    empleados.Add(
                        new Empleado
                        {
                            Id = Convert.ToInt32(row["IdEmpleado"]),
                            Nombres = Convert.ToString(row["Nombre"]),
                            Apellidos = Convert.ToString(row["Apellidos"])
                        }
                        );
                }
            }
            dgvJefes.DataSource = empleados;


        }

        
    }
}
