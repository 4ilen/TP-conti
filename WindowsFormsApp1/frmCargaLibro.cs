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
    public partial class frmCargaLibro : Form
    {
        public frmCargaLibro()
        {
            InitializeComponent();
        }

        private void btnCargarLibro_Click(object sender, EventArgs e)
        { //validacion de info
            if (string.IsNullOrEmpty(txtTituloLibro.Text) || string.IsNullOrEmpty(txtISBN.Text) || string.IsNullOrEmpty(txtNombreAutor.Text) || 
                string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtNombreEditorial.Text) || string.IsNullOrEmpty(txtPais.Text))
            {
                MessageBox.Show("Debe completar el titulo del libro.");
                return;
            }

            try
            {
                using (TP_TCEntities db = new TP_TCEntities())
                {
                    //Cargo editorial
                    EDITORIAL edi = new EDITORIAL()
                    {
                        NOMBRE_EDITORIAL = txtNombreEditorial.Text,
                        DIRECCION = txtDireccion.Text,
                        PAIS = txtPais.Text
                    };
                    //Cargo autor
                    AUTOR aut = new AUTOR()
                    {
                        NOMBRE_AUTOR = txtNombreAutor.Text,
                        APELLIDO_AUTOR = txtNacimientoAutor.Text
                    };
                    //Persistir 
                    db.EDITORIAL.Add(edi);
                    db.AUTOR.Add(aut);
                    //Ejecutar en sql
                    db.SaveChanges();
                    //Busco los ultimos creados, el ID de cada uno
                    int ultAutor = db.AUTOR.Max(x => x.ID_AUTOR);
                    int ultEdi = db.EDITORIAL.Max(x => x.ID_EDITORIAL);
                    //Cargo libro
                    LIBRO lib = new LIBRO()
                    {
                        TITULO_LIBRO = txtTituloLibro.Text,
                        ESTADO_LIBRO = "DISPONIBLE",
                        ANO_LIBRO = Convert.ToInt16(txtAno.Text),
                        CONTENIDO = txtContenido.Text,
                        ISBN = txtISBN.Text,
                        ID_EDITORIAL_LIBRO = ultEdi,
                        ID_AUTOR_LIBRO = ultAutor
                    };
                    db.LIBRO.Add(lib); //Persistir
                    db.SaveChanges(); //Ejecutar en sql
                    //informo
                    MessageBox.Show("--------SE HA REGISTRADO CON EXITO EL LIBRO-------------");

                    #region limpiarBotones
                    txtAno.Clear();
                    txtApellido.Clear();
                    txtContenido.Clear();
                    txtDireccion.Clear();
                    txtISBN.Clear();
                    txtNacimientoAutor.Clear();
                    txtNombreAutor.Clear();
                    txtNombreEditorial.Clear();
                    txtPais.Clear();
                    txtTelefonoEditorial.Clear();
                    txtTituloLibro.Clear();
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
