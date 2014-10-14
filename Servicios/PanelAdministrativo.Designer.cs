namespace Servicios
{
    partial class PanelAdministrativo
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
            this.LblPBUsuario = new System.Windows.Forms.Label();
            this.lblPAResUsuario = new System.Windows.Forms.Label();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.GBAccionesUsuario = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.DGUsuarios = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPermisos = new System.Windows.Forms.Button();
            this.GBPermisos = new System.Windows.Forms.GroupBox();
            this.GBAccionesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).BeginInit();
            this.GBPermisos.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPBUsuario
            // 
            this.LblPBUsuario.AutoSize = true;
            this.LblPBUsuario.Location = new System.Drawing.Point(663, 9);
            this.LblPBUsuario.Name = "LblPBUsuario";
            this.LblPBUsuario.Size = new System.Drawing.Size(46, 13);
            this.LblPBUsuario.TabIndex = 0;
            this.LblPBUsuario.Text = "Usuario:";
            // 
            // lblPAResUsuario
            // 
            this.lblPAResUsuario.AutoSize = true;
            this.lblPAResUsuario.Location = new System.Drawing.Point(719, 9);
            this.lblPAResUsuario.Name = "lblPAResUsuario";
            this.lblPAResUsuario.Size = new System.Drawing.Size(37, 13);
            this.lblPAResUsuario.TabIndex = 1;
            this.lblPAResUsuario.Text = "..........";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(17, 40);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(80, 34);
            this.BtnCrear.TabIndex = 2;
            this.BtnCrear.Text = "Registrar";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // GBAccionesUsuario
            // 
            this.GBAccionesUsuario.Controls.Add(this.btnMostrar);
            this.GBAccionesUsuario.Controls.Add(this.BtnModificar);
            this.GBAccionesUsuario.Controls.Add(this.BtnEliminar);
            this.GBAccionesUsuario.Controls.Add(this.BtnCrear);
            this.GBAccionesUsuario.Location = new System.Drawing.Point(26, 23);
            this.GBAccionesUsuario.Name = "GBAccionesUsuario";
            this.GBAccionesUsuario.Size = new System.Drawing.Size(237, 159);
            this.GBAccionesUsuario.TabIndex = 3;
            this.GBAccionesUsuario.TabStop = false;
            this.GBAccionesUsuario.Text = "Acciones Para usuarios";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(17, 102);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(80, 30);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Listar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(127, 40);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(77, 34);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(127, 102);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(77, 30);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // DGUsuarios
            // 
            this.DGUsuarios.AllowUserToOrderColumns = true;
            this.DGUsuarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c8,
            this.c2,
            this.c3,
            this.C6,
            this.c4,
            this.c5,
            this.c7});
            this.DGUsuarios.Location = new System.Drawing.Point(10, 236);
            this.DGUsuarios.Name = "DGUsuarios";
            this.DGUsuarios.Size = new System.Drawing.Size(746, 213);
            this.DGUsuarios.TabIndex = 4;
            // 
            // c1
            // 
            this.c1.HeaderText = "Tipo de Usuario";
            this.c1.Name = "c1";
            // 
            // c8
            // 
            this.c8.HeaderText = "Usuario";
            this.c8.Name = "c8";
            this.c8.Width = 70;
            // 
            // c2
            // 
            this.c2.HeaderText = "Nombre";
            this.c2.Name = "c2";
            // 
            // c3
            // 
            this.c3.HeaderText = "Apellido Paterno";
            this.c3.Name = "c3";
            // 
            // C6
            // 
            this.C6.HeaderText = "Apellido Materno";
            this.C6.Name = "C6";
            // 
            // c4
            // 
            this.c4.HeaderText = "Contraseña";
            this.c4.Name = "c4";
            this.c4.Width = 70;
            // 
            // c5
            // 
            this.c5.HeaderText = "Email";
            this.c5.Name = "c5";
            // 
            // c7
            // 
            this.c7.HeaderText = "Teléfono";
            this.c7.Name = "c7";
            this.c7.Width = 60;
            // 
            // btnPermisos
            // 
            this.btnPermisos.Location = new System.Drawing.Point(17, 29);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(113, 43);
            this.btnPermisos.TabIndex = 5;
            this.btnPermisos.Text = "Asignar Permisos";
            this.btnPermisos.UseVisualStyleBackColor = true;
            // 
            // GBPermisos
            // 
            this.GBPermisos.Controls.Add(this.btnPermisos);
            this.GBPermisos.Location = new System.Drawing.Point(451, 34);
            this.GBPermisos.Name = "GBPermisos";
            this.GBPermisos.Size = new System.Drawing.Size(305, 179);
            this.GBPermisos.TabIndex = 6;
            this.GBPermisos.TabStop = false;
            this.GBPermisos.Text = "Administrar Permisos";
            // 
            // PanelAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 461);
            this.Controls.Add(this.GBPermisos);
            this.Controls.Add(this.DGUsuarios);
            this.Controls.Add(this.GBAccionesUsuario);
            this.Controls.Add(this.lblPAResUsuario);
            this.Controls.Add(this.LblPBUsuario);
            this.Name = "PanelAdministrativo";
            this.Text = "Panel Administrativo";
            this.Load += new System.EventHandler(this.PanelAdministrativo_Load);
            this.GBAccionesUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).EndInit();
            this.GBPermisos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPBUsuario;
        private System.Windows.Forms.Label lblPAResUsuario;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.GroupBox GBAccionesUsuario;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnMostrar;
        public System.Windows.Forms.DataGridView DGUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c8;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C6;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.GroupBox GBPermisos;
    }
}