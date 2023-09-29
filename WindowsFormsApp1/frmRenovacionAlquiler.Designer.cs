namespace WindowsFormsApp1
{
    partial class frmRenovacionAlquiler
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
            this.txtCodLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRenovarAlquiler = new System.Windows.Forms.Button();
            this.txtCodigoAlquiler = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(587, 406);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodLibro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRenovarAlquiler);
            this.groupBox1.Controls.Add(this.txtCodigoAlquiler);
            this.groupBox1.Location = new System.Drawing.Point(57, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 237);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÓDIGO ALQUILER";
            // 
            // txtCodLibro
            // 
            this.txtCodLibro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCodLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLibro.Location = new System.Drawing.Point(125, 86);
            this.txtCodLibro.Name = "txtCodLibro";
            this.txtCodLibro.Size = new System.Drawing.Size(141, 26);
            this.txtCodLibro.TabIndex = 9;
            this.txtCodLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CÓDIGO LIBRO";
            // 
            // btnRenovarAlquiler
            // 
            this.btnRenovarAlquiler.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRenovarAlquiler.FlatAppearance.BorderSize = 0;
            this.btnRenovarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovarAlquiler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRenovarAlquiler.Location = new System.Drawing.Point(183, 181);
            this.btnRenovarAlquiler.Name = "btnRenovarAlquiler";
            this.btnRenovarAlquiler.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRenovarAlquiler.Size = new System.Drawing.Size(224, 35);
            this.btnRenovarAlquiler.TabIndex = 5;
            this.btnRenovarAlquiler.Text = "RENOVAR ALQUILER";
            this.btnRenovarAlquiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenovarAlquiler.UseVisualStyleBackColor = false;
            // 
            // txtCodigoAlquiler
            // 
            this.txtCodigoAlquiler.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCodigoAlquiler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAlquiler.Location = new System.Drawing.Point(125, 54);
            this.txtCodigoAlquiler.Name = "txtCodigoAlquiler";
            this.txtCodigoAlquiler.Size = new System.Drawing.Size(141, 26);
            this.txtCodigoAlquiler.TabIndex = 6;
            this.txtCodigoAlquiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(125, 118);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(141, 26);
            this.txtCodCliente.TabIndex = 10;
            this.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(14, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CÓDIGO CLIENTE";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 406);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Text = "Form7";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRenovarAlquiler;
        private System.Windows.Forms.TextBox txtCodigoAlquiler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodCliente;
    }
}