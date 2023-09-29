using BLL.Excepcion;
using SL.Servicio.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmConsultarCliente : Form
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoCliente.Text))
            {
                MessageBox.Show("Debe indicar el código del cliente");
                return;
            }
            try
            {
                using (TP_TCEntities db = new TP_TCEntities())
                {
                    int buscarID = Convert.ToInt32(txtCodigoCliente.Text);
                    CLIENTE cE = db.CLIENTE.Find(buscarID);
                    if( cE == null )
                    {
                        throw new ClienteInexistente();
                        
                    }
                    else
                    {
                        MessageBox.Show($"DATOS DEL CLIENTE: {cE.ID_CLIENTE} \n\n NOMBRE: {cE.NOMBRE_CLIENTE} " +
                        $"\n APELLIDO: {cE.APELLIDO_CLIENTE} \n CORREO: {cE.CORREO_CLIENTE}", "INFORMACIÓN", MessageBoxButtons.OK);
                    }
                  
                }
            }
            catch (ClienteInexistente ex)
            {
                txtCodigoCliente.Clear();
                txtNombreCliente.Clear();
                MessageBox.Show(ex.Message);
                LoggerService.WriteLog(ex.Message, "Ailen Aranda");
            }
        }
    }
}
