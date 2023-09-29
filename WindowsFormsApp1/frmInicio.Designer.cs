namespace WindowsFormsApp1
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubMenuGestionLibro = new System.Windows.Forms.Panel();
            this.btnLibroNoDevuelto = new System.Windows.Forms.Button();
            this.btnCargaLibro = new System.Windows.Forms.Button();
            this.btnPanelGestionLibro = new System.Windows.Forms.Button();
            this.panelSubMenuGestionAlquiler = new System.Windows.Forms.Panel();
            this.btnAlquilerDelMes = new System.Windows.Forms.Button();
            this.btnRegistrarDevolucion = new System.Windows.Forms.Button();
            this.btnRenovarAlquiler = new System.Windows.Forms.Button();
            this.btnIniciarAlquiler = new System.Windows.Forms.Button();
            this.btnPanelGestionAlquiler = new System.Windows.Forms.Button();
            this.panelSubMenuCliente = new System.Windows.Forms.Panel();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.btnPanelGestionCliente = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelInferior = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelSubMenuIdioma = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIdioma = new System.Windows.Forms.Button();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelSubMenuGestionLibro.SuspendLayout();
            this.panelSubMenuGestionAlquiler.SuspendLayout();
            this.panelSubMenuCliente.SuspendLayout();
            this.panelSubMenuIdioma.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenu.Controls.Add(this.btnCerrarSesión);
            this.panelMenu.Controls.Add(this.panelSubMenuIdioma);
            this.panelMenu.Controls.Add(this.btnIdioma);
            this.panelMenu.Controls.Add(this.panelSubMenuGestionLibro);
            this.panelMenu.Controls.Add(this.btnPanelGestionLibro);
            this.panelMenu.Controls.Add(this.panelSubMenuGestionAlquiler);
            this.panelMenu.Controls.Add(this.btnPanelGestionAlquiler);
            this.panelMenu.Controls.Add(this.panelSubMenuCliente);
            this.panelMenu.Controls.Add(this.btnPanelGestionCliente);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 571);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSubMenuGestionLibro
            // 
            this.panelSubMenuGestionLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuGestionLibro.Controls.Add(this.btnLibroNoDevuelto);
            this.panelSubMenuGestionLibro.Controls.Add(this.btnCargaLibro);
            this.panelSubMenuGestionLibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuGestionLibro.Location = new System.Drawing.Point(0, 509);
            this.panelSubMenuGestionLibro.Name = "panelSubMenuGestionLibro";
            this.panelSubMenuGestionLibro.Size = new System.Drawing.Size(233, 77);
            this.panelSubMenuGestionLibro.TabIndex = 6;
            // 
            // btnLibroNoDevuelto
            // 
            this.btnLibroNoDevuelto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibroNoDevuelto.FlatAppearance.BorderSize = 0;
            this.btnLibroNoDevuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibroNoDevuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibroNoDevuelto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLibroNoDevuelto.Location = new System.Drawing.Point(0, 35);
            this.btnLibroNoDevuelto.Name = "btnLibroNoDevuelto";
            this.btnLibroNoDevuelto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLibroNoDevuelto.Size = new System.Drawing.Size(233, 32);
            this.btnLibroNoDevuelto.TabIndex = 1;
            this.btnLibroNoDevuelto.Text = "Libros no devueltos";
            this.btnLibroNoDevuelto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibroNoDevuelto.UseVisualStyleBackColor = true;
            this.btnLibroNoDevuelto.Click += new System.EventHandler(this.btnLibroNoDevuelto_Click);
            // 
            // btnCargaLibro
            // 
            this.btnCargaLibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargaLibro.FlatAppearance.BorderSize = 0;
            this.btnCargaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargaLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargaLibro.Location = new System.Drawing.Point(0, 0);
            this.btnCargaLibro.Name = "btnCargaLibro";
            this.btnCargaLibro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCargaLibro.Size = new System.Drawing.Size(233, 35);
            this.btnCargaLibro.TabIndex = 0;
            this.btnCargaLibro.Text = "Cargar libro";
            this.btnCargaLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargaLibro.UseVisualStyleBackColor = true;
            this.btnCargaLibro.Click += new System.EventHandler(this.btnCargaLibro_Click);
            // 
            // btnPanelGestionLibro
            // 
            this.btnPanelGestionLibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanelGestionLibro.FlatAppearance.BorderSize = 0;
            this.btnPanelGestionLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelGestionLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelGestionLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPanelGestionLibro.Location = new System.Drawing.Point(0, 464);
            this.btnPanelGestionLibro.Name = "btnPanelGestionLibro";
            this.btnPanelGestionLibro.Size = new System.Drawing.Size(233, 45);
            this.btnPanelGestionLibro.TabIndex = 5;
            this.btnPanelGestionLibro.Text = "Gestión libro";
            this.btnPanelGestionLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelGestionLibro.UseVisualStyleBackColor = true;
            this.btnPanelGestionLibro.Click += new System.EventHandler(this.btnPanelGestionLibro_Click);
            // 
            // panelSubMenuGestionAlquiler
            // 
            this.panelSubMenuGestionAlquiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuGestionAlquiler.Controls.Add(this.btnAlquilerDelMes);
            this.panelSubMenuGestionAlquiler.Controls.Add(this.btnRegistrarDevolucion);
            this.panelSubMenuGestionAlquiler.Controls.Add(this.btnRenovarAlquiler);
            this.panelSubMenuGestionAlquiler.Controls.Add(this.btnIniciarAlquiler);
            this.panelSubMenuGestionAlquiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuGestionAlquiler.Location = new System.Drawing.Point(0, 310);
            this.panelSubMenuGestionAlquiler.Name = "panelSubMenuGestionAlquiler";
            this.panelSubMenuGestionAlquiler.Size = new System.Drawing.Size(233, 154);
            this.panelSubMenuGestionAlquiler.TabIndex = 4;
            // 
            // btnAlquilerDelMes
            // 
            this.btnAlquilerDelMes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlquilerDelMes.FlatAppearance.BorderSize = 0;
            this.btnAlquilerDelMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlquilerDelMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlquilerDelMes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlquilerDelMes.Location = new System.Drawing.Point(0, 105);
            this.btnAlquilerDelMes.Name = "btnAlquilerDelMes";
            this.btnAlquilerDelMes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAlquilerDelMes.Size = new System.Drawing.Size(233, 37);
            this.btnAlquilerDelMes.TabIndex = 3;
            this.btnAlquilerDelMes.Text = "Alquileres del mes";
            this.btnAlquilerDelMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlquilerDelMes.UseVisualStyleBackColor = true;
            this.btnAlquilerDelMes.Click += new System.EventHandler(this.btnAlquilerDelMes_Click);
            // 
            // btnRegistrarDevolucion
            // 
            this.btnRegistrarDevolucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            this.btnRegistrarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDevolucion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarDevolucion.Location = new System.Drawing.Point(0, 70);
            this.btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            this.btnRegistrarDevolucion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistrarDevolucion.Size = new System.Drawing.Size(233, 35);
            this.btnRegistrarDevolucion.TabIndex = 2;
            this.btnRegistrarDevolucion.Text = "Registrar devolución";
            this.btnRegistrarDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarDevolucion.UseVisualStyleBackColor = true;
            this.btnRegistrarDevolucion.Click += new System.EventHandler(this.btnRegistrarDevolucion_Click);
            // 
            // btnRenovarAlquiler
            // 
            this.btnRenovarAlquiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRenovarAlquiler.FlatAppearance.BorderSize = 0;
            this.btnRenovarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovarAlquiler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRenovarAlquiler.Location = new System.Drawing.Point(0, 35);
            this.btnRenovarAlquiler.Name = "btnRenovarAlquiler";
            this.btnRenovarAlquiler.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRenovarAlquiler.Size = new System.Drawing.Size(233, 35);
            this.btnRenovarAlquiler.TabIndex = 1;
            this.btnRenovarAlquiler.Text = "Renovar alquiler";
            this.btnRenovarAlquiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenovarAlquiler.UseVisualStyleBackColor = true;
            this.btnRenovarAlquiler.Click += new System.EventHandler(this.btnRenovarAlquiler_Click);
            // 
            // btnIniciarAlquiler
            // 
            this.btnIniciarAlquiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIniciarAlquiler.FlatAppearance.BorderSize = 0;
            this.btnIniciarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarAlquiler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIniciarAlquiler.Location = new System.Drawing.Point(0, 0);
            this.btnIniciarAlquiler.Name = "btnIniciarAlquiler";
            this.btnIniciarAlquiler.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnIniciarAlquiler.Size = new System.Drawing.Size(233, 35);
            this.btnIniciarAlquiler.TabIndex = 0;
            this.btnIniciarAlquiler.Text = "Iniciar alquiler";
            this.btnIniciarAlquiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarAlquiler.UseVisualStyleBackColor = true;
            this.btnIniciarAlquiler.Click += new System.EventHandler(this.btnIniciarAlquiler_Click);
            // 
            // btnPanelGestionAlquiler
            // 
            this.btnPanelGestionAlquiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanelGestionAlquiler.FlatAppearance.BorderSize = 0;
            this.btnPanelGestionAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelGestionAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelGestionAlquiler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPanelGestionAlquiler.Location = new System.Drawing.Point(0, 265);
            this.btnPanelGestionAlquiler.Name = "btnPanelGestionAlquiler";
            this.btnPanelGestionAlquiler.Size = new System.Drawing.Size(233, 45);
            this.btnPanelGestionAlquiler.TabIndex = 3;
            this.btnPanelGestionAlquiler.Text = "Gestión Alquiler";
            this.btnPanelGestionAlquiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelGestionAlquiler.UseVisualStyleBackColor = true;
            this.btnPanelGestionAlquiler.Click += new System.EventHandler(this.btnPanelGestionAlquiler_Click);
            // 
            // panelSubMenuCliente
            // 
            this.panelSubMenuCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuCliente.Controls.Add(this.btnEliminarCliente);
            this.panelSubMenuCliente.Controls.Add(this.btnConsultarCliente);
            this.panelSubMenuCliente.Controls.Add(this.btnRegistrarCliente);
            this.panelSubMenuCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCliente.Location = new System.Drawing.Point(0, 154);
            this.panelSubMenuCliente.Name = "panelSubMenuCliente";
            this.panelSubMenuCliente.Size = new System.Drawing.Size(233, 111);
            this.panelSubMenuCliente.TabIndex = 2;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarCliente.Location = new System.Drawing.Point(0, 70);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminarCliente.Size = new System.Drawing.Size(233, 37);
            this.btnEliminarCliente.TabIndex = 3;
            this.btnEliminarCliente.Text = "Eliminar cliente";
            this.btnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarCliente.FlatAppearance.BorderSize = 0;
            this.btnConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarCliente.Location = new System.Drawing.Point(0, 35);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarCliente.Size = new System.Drawing.Size(233, 35);
            this.btnConsultarCliente.TabIndex = 1;
            this.btnConsultarCliente.Text = "Consultar cliente";
            this.btnConsultarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarCliente.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistrarCliente.Size = new System.Drawing.Size(233, 35);
            this.btnRegistrarCliente.TabIndex = 0;
            this.btnRegistrarCliente.Text = "Registrar cliente";
            this.btnRegistrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // btnPanelGestionCliente
            // 
            this.btnPanelGestionCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanelGestionCliente.FlatAppearance.BorderSize = 0;
            this.btnPanelGestionCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelGestionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelGestionCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPanelGestionCliente.Location = new System.Drawing.Point(0, 109);
            this.btnPanelGestionCliente.Name = "btnPanelGestionCliente";
            this.btnPanelGestionCliente.Size = new System.Drawing.Size(233, 45);
            this.btnPanelGestionCliente.TabIndex = 1;
            this.btnPanelGestionCliente.Text = "Gestión cliente";
            this.btnPanelGestionCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelGestionCliente.UseVisualStyleBackColor = true;
            this.btnPanelGestionCliente.Click += new System.EventHandler(this.btnPanelGestionCliente_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 109);
            this.panelLogo.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelInferior.Location = new System.Drawing.Point(250, 471);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(684, 100);
            this.panelInferior.TabIndex = 2;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(684, 471);
            this.panelContenedor.TabIndex = 3;
            // 
            // panelSubMenuIdioma
            // 
            this.panelSubMenuIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuIdioma.Controls.Add(this.button1);
            this.panelSubMenuIdioma.Controls.Add(this.button2);
            this.panelSubMenuIdioma.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuIdioma.Location = new System.Drawing.Point(0, 631);
            this.panelSubMenuIdioma.Name = "panelSubMenuIdioma";
            this.panelSubMenuIdioma.Size = new System.Drawing.Size(233, 75);
            this.panelSubMenuIdioma.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 35);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(233, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Inglés (Estados Unidos)";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(233, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "Español (Argentina)";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnIdioma
            // 
            this.btnIdioma.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIdioma.FlatAppearance.BorderSize = 0;
            this.btnIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdioma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIdioma.Location = new System.Drawing.Point(0, 586);
            this.btnIdioma.Name = "btnIdioma";
            this.btnIdioma.Size = new System.Drawing.Size(233, 45);
            this.btnIdioma.TabIndex = 7;
            this.btnIdioma.Text = "Idioma";
            this.btnIdioma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIdioma.UseVisualStyleBackColor = true;
            this.btnIdioma.Click += new System.EventHandler(this.btnIdioma_Click);
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesión.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesión.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesión.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarSesión.Location = new System.Drawing.Point(0, 706);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(233, 45);
            this.btnCerrarSesión.TabIndex = 9;
            this.btnCerrarSesión.Text = "Cerrar sesión";
            this.btnCerrarSesión.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(934, 571);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "INICIO SIGAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenuGestionLibro.ResumeLayout(false);
            this.panelSubMenuGestionAlquiler.ResumeLayout(false);
            this.panelSubMenuCliente.ResumeLayout(false);
            this.panelSubMenuIdioma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnPanelGestionCliente;
        private System.Windows.Forms.Panel panelSubMenuCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Panel panelSubMenuGestionLibro;
        private System.Windows.Forms.Button btnLibroNoDevuelto;
        private System.Windows.Forms.Button btnCargaLibro;
        private System.Windows.Forms.Button btnPanelGestionLibro;
        private System.Windows.Forms.Panel panelSubMenuGestionAlquiler;
        private System.Windows.Forms.Button btnAlquilerDelMes;
        private System.Windows.Forms.Button btnRegistrarDevolucion;
        private System.Windows.Forms.Button btnRenovarAlquiler;
        private System.Windows.Forms.Button btnIniciarAlquiler;
        private System.Windows.Forms.Button btnPanelGestionAlquiler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Panel panelSubMenuIdioma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIdioma;
    }
}

