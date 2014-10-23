namespace PryServicios
{
    partial class ServiciosGeneral
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblResUsuario = new System.Windows.Forms.Label();
            this.PBServicios = new System.Windows.Forms.PictureBox();
            this.PBInmuebles = new System.Windows.Forms.PictureBox();
            this.PBVehiculos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBInmuebles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Que desea Buscar?";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(521, 13);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblResUsuario
            // 
            this.lblResUsuario.AutoSize = true;
            this.lblResUsuario.Location = new System.Drawing.Point(573, 13);
            this.lblResUsuario.Name = "lblResUsuario";
            this.lblResUsuario.Size = new System.Drawing.Size(52, 13);
            this.lblResUsuario.TabIndex = 2;
            this.lblResUsuario.Text = "...............";
            // 
            // PBServicios
            // 
            this.PBServicios.Image = global::PryServicios.Properties.Resources.servicios;
            this.PBServicios.Location = new System.Drawing.Point(408, 157);
            this.PBServicios.Name = "PBServicios";
            this.PBServicios.Size = new System.Drawing.Size(183, 153);
            this.PBServicios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBServicios.TabIndex = 5;
            this.PBServicios.TabStop = false;
            this.PBServicios.Click += new System.EventHandler(this.PBServicios_Click);
            // 
            // PBInmuebles
            // 
            this.PBInmuebles.Image = global::PryServicios.Properties.Resources.Inmuebles;
            this.PBInmuebles.Location = new System.Drawing.Point(222, 157);
            this.PBInmuebles.Name = "PBInmuebles";
            this.PBInmuebles.Size = new System.Drawing.Size(153, 153);
            this.PBInmuebles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBInmuebles.TabIndex = 4;
            this.PBInmuebles.TabStop = false;
            this.PBInmuebles.Click += new System.EventHandler(this.PBInmuebles_Click);
            // 
            // PBVehiculos
            // 
            this.PBVehiculos.Image = global::PryServicios.Properties.Resources.carros;
            this.PBVehiculos.Location = new System.Drawing.Point(26, 157);
            this.PBVehiculos.Name = "PBVehiculos";
            this.PBVehiculos.Size = new System.Drawing.Size(172, 153);
            this.PBVehiculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBVehiculos.TabIndex = 3;
            this.PBVehiculos.TabStop = false;
            this.PBVehiculos.Click += new System.EventHandler(this.PBVehiculos_Click);
            // 
            // ServiciosGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 490);
            this.Controls.Add(this.PBServicios);
            this.Controls.Add(this.PBInmuebles);
            this.Controls.Add(this.PBVehiculos);
            this.Controls.Add(this.lblResUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Name = "ServiciosGeneral";
            this.Text = "ServiciosGeneral";
            this.Load += new System.EventHandler(this.ServiciosGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBInmuebles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblResUsuario;
        private System.Windows.Forms.PictureBox PBVehiculos;
        private System.Windows.Forms.PictureBox PBInmuebles;
        private System.Windows.Forms.PictureBox PBServicios;
    }
}