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
    public partial class frmEliminarCliente : Form
    {
        public frmEliminarCliente()
        {
            InitializeComponent();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
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
                    
                    DialogResult resultado = MessageBox.Show($"¿Desea eliminar el cliente: \n NOMBRE: {cE.NOMBRE_CLIENTE} " +
                        $"\n APELLIDO: {cE.APELLIDO_CLIENTE} \n CORREO: {cE.CORREO_CLIENTE} ?", "CONFIRMACION", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        db.CLIENTE.Remove(cE);
                        db.SaveChanges();
                        MessageBox.Show("Se ha eliminado el cliente.");
                        txtNombreCliente.Clear();
                        txtCodigoCliente.Clear();
                    }
                    else
                    {
                        txtCodigoCliente.Clear();
                        txtNombreCliente.Clear();
                        MessageBox.Show("Operación cancelada.");
                        return;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
