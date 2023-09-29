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
    public partial class frmRegistoCliente : Form
    {
        public frmRegistoCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCliente.Text) || string.IsNullOrEmpty(txtApellidoCliente.Text) || string.IsNullOrEmpty(txtCorreoCliente.Text)) 
            {
                MessageBox.Show("Debe completar todos los campos con el asterisco ' * ' ");
                return;
            }
            
            try
            {
                using (TP_TCEntities db = new TP_TCEntities())
                {
                    CLIENTE c2 = new CLIENTE()
                    {
                        NOMBRE_CLIENTE = txtNombreCliente.Text,
                        APELLIDO_CLIENTE = txtApellidoCliente.Text,
                        CORREO_CLIENTE = txtCorreoCliente.Text
                    };
                    db.CLIENTE.Add(c2);
                    db.SaveChanges();
                    CLIENTE c = new CLIENTE()
                    {
                        NOMBRE_CLIENTE = txtNombreCliente.Text,
                        APELLIDO_CLIENTE = txtApellidoCliente.Text,
                        CORREO_CLIENTE = txtCorreoCliente.Text
                    };
                    
                    BLL.Servicio.ClienteServicio.Instance.Insertar(c);
                    MessageBox.Show($"El cliente: {c.NOMBRE_CLIENTE} - {c.APELLIDO_CLIENTE}, se ha creado.");
                    #region limpiarBotones
                    txtNombreCliente.Clear();
                    txtApellidoCliente.Clear();
                    txtCorreoCliente.Clear();
                    #endregion
                }
            }
            catch (Exception ex)
            {
                LoggerService.WriteLog(ex.Message, "Ailen Aranda");
            }
        }
    }
}
