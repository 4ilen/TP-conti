namespace WindowsFormsApp1
{
    partial class frmDevoluciónAlquiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarDevolución = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbLibro = new System.Windows.Forms.CheckBox();
            this.cbAlquiler = new System.Windows.Forms.CheckBox();
            this.cbCliente = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 425);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.cbAlquiler);
            this.groupBox1.Controls.Add(this.cbLibro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRegistrarDevolución);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(57, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 202);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÓDIGO";
            // 
            // btnRegistrarDevolución
            // 
            this.btnRegistrarDevolución.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegistrarDevolución.FlatAppearance.BorderSize = 0;
            this.btnRegistrarDevolución.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDevolución.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDevolución.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarDevolución.Location = new System.Drawing.Point(47, 139);
            this.btnRegistrarDevolución.Name = "btnRegistrarDevolución";
            this.btnRegistrarDevolución.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistrarDevolución.Size = new System.Drawing.Size(248, 35);
            this.btnRegistrarDevolución.TabIndex = 5;
            this.btnRegistrarDevolución.Text = "REGISTRAR DEVOLUCIÓN";
            this.btnRegistrarDevolución.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarDevolución.UseVisualStyleBackColor = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(47, 61);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(141, 26);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbLibro
            // 
            this.cbLibro.AutoSize = true;
            this.cbLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLibro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbLibro.Location = new System.Drawing.Point(279, 31);
            this.cbLibro.Name = "cbLibro";
            this.cbLibro.Size = new System.Drawing.Size(65, 20);
            this.cbLibro.TabIndex = 7;
            this.cbLibro.Text = "LIBRO";
            this.cbLibro.UseVisualStyleBackColor = true;
            // 
            // cbAlquiler
            // 
            this.cbAlquiler.AutoSize = true;
            this.cbAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlquiler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbAlquiler.Location = new System.Drawing.Point(279, 91);
            this.cbAlquiler.Name = "cbAlquiler";
            this.cbAlquiler.Size = new System.Drawing.Size(91, 20);
            this.cbAlquiler.TabIndex = 8;
            this.cbAlquiler.Text = "ALQUILER";
            this.cbAlquiler.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            this.cbCliente.AutoSize = true;
            this.cbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbCliente.Location = new System.Drawing.Point(279, 61);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(82, 20);
            this.cbCliente.TabIndex = 9;
            this.cbCliente.Text = "CLIENTE";
            this.cbCliente.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 425);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarDevolución;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.CheckBox cbCliente;
        private System.Windows.Forms.CheckBox cbAlquiler;
        private System.Windows.Forms.CheckBox cbLibro;
    }
}