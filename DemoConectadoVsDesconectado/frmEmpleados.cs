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
            try
            {
                negocio.InsEmpleadoAutoincremental(new Empleado
                {                   
                    Nombres = txtNombresInsertar.Text,
                    Apellidos = txtApellidosInsertar.Text
                });



                //negocio.InsEmpleado(new Empleado
                //{
                //    Id = Convert.ToInt32(txtId.Text),
                //    Nombres = txtNombresInsertar.Text,
                //    Apellidos = txtApellidosInsertar.Text
                //});
                MessageBox.Show("Registro Correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                
            }
            
        }
    }
}
