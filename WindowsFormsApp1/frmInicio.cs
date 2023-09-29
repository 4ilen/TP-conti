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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }

        #region Metodos menu
        private void PersonalizarDiseño()
        {
            panelSubMenuCliente.Visible = false;
            panelSubMenuGestionAlquiler.Visible = false;
            panelSubMenuGestionLibro.Visible = false;
            panelSubMenuIdioma.Visible = false;
        }

        private void OcultarSubmenu()
        {
            if (panelSubMenuGestionAlquiler.Visible == true)
            {
                panelSubMenuGestionAlquiler.Visible = false;
            }
            if (panelSubMenuCliente.Visible == true)
            {
                panelSubMenuCliente.Visible = false;
            }
            if (panelSubMenuGestionLibro.Visible == true)
            {
                panelSubMenuGestionLibro.Visible = false;
            }
            if (panelSubMenuIdioma.Visible == true)
            {
                panelSubMenuIdioma.Visible = false;
            }
        }

        private void MostrarSubmenu(Panel submenu)
        {
            if(!submenu.Visible)
            {
                OcultarSubmenu();
                submenu.Visible= true;
            }
            else
            {
                submenu.Visible= false;
            }
        }
        #endregion

        #region Mostrar sub menus
        private void btnPanelGestionCliente_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelSubMenuCliente);
        }
        private void btnPanelGestionAlquiler_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelSubMenuGestionAlquiler);
        }

        private void btnPanelGestionLibro_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelSubMenuGestionLibro);
        }
        private void btnIdioma_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelSubMenuIdioma);
        }
        #endregion

        #region Botones Cliente
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            abrirFormularios(new frmRegistoCliente());
            OcultarSubmenu(); //Despues de seleccionarlo lo ocultamos
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            abrirFormularios(new frmConsultarCliente());
            OcultarSubmenu();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            abrirFormularios(new frmEliminarCliente());
            OcultarSubmenu();
        }
        #endregion
        #region Botones Alquiler
        private void btnIniciarAlquiler_Click(object sender, EventArgs e)
        {
            abrirFormularios(new frmInicioalquiler());
            OcultarSubmenu();
        }

        private void btnRenovarAlquiler_Click(object sender, EventArgs e)
        {
            abrirFormularios(new frmRenovacionAlquiler());
            OcultarSubmenu();
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            abrirFormularios(new frmDevoluciónAlquiler());
            OcultarSubmenu();
        }

        private void btnAlquilerDelMes_Click(object sender, EventArgs e)
        {
            abrirFormularios(new frmAlquileresMes());
            OcultarSubmenu();
        }
        #endregion
        #region Botones Libros
        private void btnCargaLibro_Click(object sender, EventArgs e)
        {
            abrirFormularios(new frmCargaLibro());
            OcultarSubmenu();
        }

        private void btnLibroNoDevuelto_Click(object sender, EventArgs e)
        {
            abrirFormularios(new frmConsulta());
            OcultarSubmenu();
        }
        #endregion

        #region Mostrar formularios
        private Form formularioActivo = null;
        private void abrirFormularios(Form formularioHijo)
        {
            if(formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
