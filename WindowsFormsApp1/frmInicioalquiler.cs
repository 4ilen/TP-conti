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
    public partial class frmInicioalquiler : Form
    {
        public frmInicioalquiler()
        {
            InitializeComponent();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLibro.Text) || string.IsNullOrEmpty(txtCliente.Text) || string.IsNullOrEmpty(txtTotalAlquiler.Text))
            {
                MessageBox.Show("Debe completar todos los campos con el asterisco ' * ' ");
                return;
            }
            try
            {
                using (TP_TCEntities db = new TP_TCEntities())
                {
                    //Convierto variables que voy a usar
                    decimal monto = Convert.ToDecimal(txtTotalAlquiler.Text);
                    DateTime fechaFin = Convert.ToDateTime(dtFechaDevolución.Value);
                    DateTime fechaHoy = DateTime.Now;

                    //buscar cliente ID
                    int idCliente = Convert.ToInt32(txtCliente.Text);
                    CLIENTE cliente = db.CLIENTE.Find(idCliente); //tengo ID del cliente

                    //buscar libro ID
                    int idLibro = Convert.ToInt32(txtLibro.Text); //Convierto
                    LIBRO libro = db.LIBRO.Find(idLibro); //busco ID, para ponerlo en alquiler
                    //Cambio estado del libro
                    libro.ESTADO_LIBRO = "NO DISPONIBLE"; 
                    db.Entry(libro).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges(); //Guardo en SQL

                    //monto pago insertar
                    MONTO_PAGO montonuevo = new MONTO_PAGO()
                    {
                        FECHA_MONTO_PAGO = DateTime.Now,
                        MONTO_PAGO1 = monto
                    };
                    db.MONTO_PAGO.Add(montonuevo); //persistir
                    db.SaveChanges(); //insertar en sql

                    //obtener el ultimo ID que cree
                    int idMonto = db.MONTO_PAGO.Max(x => x.ID_MONTO_PAGO);

                    //Insertar en alquiler
                    DETALLE_ALQUILER alquiler = new DETALLE_ALQUILER()
                    {
                        ID_MONTO_PAGO = idMonto,
                        ID_LIBRO = idLibro,
                        ID_CLIENTE = idCliente,
                        FECHA_INICIO = fechaHoy,
                        FECHA_FIN = fechaFin, //dudoso porque es date time
                        ESTADO = "PENDIENTE"
                    };
                    db.DETALLE_ALQUILER.Add(alquiler);
                    db.SaveChanges();

                    MessageBox.Show($"Alquiler del \n libro: {libro.TITULO_LIBRO} \n al cliente: {cliente.NOMBRE_CLIENTE} {cliente.APELLIDO_CLIENTE} \n REGISTRADO.");

                    #region limpiarBotones
                    txtCliente.Clear();
                    txtLibro.Clear();
                    txtTotalAlquiler.Clear();
                    #endregion
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
