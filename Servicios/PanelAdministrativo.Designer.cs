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
            this.lblPAPassword = new System.Windows.Forms.Label();
            this.txtPAPassword = new System.Windows.Forms.TextBox();
            this.lblPAEmail = new System.Windows.Forms.Label();
            this.txtPAEmail = new System.Windows.Forms.TextBox();
            this.lblPATusuario = new System.Windows.Forms.Label();
            this.txtPATUsuario = new System.Windows.Forms.TextBox();
            this.lblPAApellidoM = new System.Windows.Forms.Label();
            this.txtPAApellidoM = new System.Windows.Forms.TextBox();
            this.lblPAApellidoP = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.lblPAUsuario = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.txtPAApellidoP = new System.Windows.Forms.TextBox();
            this.txtPANombre = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.DGUsuarios = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBAccionesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPBUsuario
            // 
            this.LblPBUsuario.AutoSize = true;
            this.LblPBUsuario.Location = new System.Drawing.Point(592, 9);
            this.LblPBUsuario.Name = "LblPBUsuario";
            this.LblPBUsuario.Size = new System.Drawing.Size(46, 13);
            this.LblPBUsuario.TabIndex = 0;
            this.LblPBUsuario.Text = "Usuario:";
            // 
            // lblPAResUsuario
            // 
            this.lblPAResUsuario.AutoSize = true;
            this.lblPAResUsuario.Location = new System.Drawing.Point(648, 9);
            this.lblPAResUsuario.Name = "lblPAResUsuario";
            this.lblPAResUsuario.Size = new System.Drawing.Size(37, 13);
            this.lblPAResUsuario.TabIndex = 1;
            this.lblPAResUsuario.Text = "..........";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(30, 31);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(67, 43);
            this.BtnCrear.TabIndex = 2;
            this.BtnCrear.Text = "Registrar";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // GBAccionesUsuario
            // 
            this.GBAccionesUsuario.Controls.Add(this.btnMostrar);
            this.GBAccionesUsuario.Controls.Add(this.lblPAPassword);
            this.GBAccionesUsuario.Controls.Add(this.txtPAPassword);
            this.GBAccionesUsuario.Controls.Add(this.lblPAEmail);
            this.GBAccionesUsuario.Controls.Add(this.txtPAEmail);
            this.GBAccionesUsuario.Controls.Add(this.lblPATusuario);
            this.GBAccionesUsuario.Controls.Add(this.txtPATUsuario);
            this.GBAccionesUsuario.Controls.Add(this.lblPAApellidoM);
            this.GBAccionesUsuario.Controls.Add(this.txtPAApellidoM);
            this.GBAccionesUsuario.Controls.Add(this.lblPAApellidoP);
            this.GBAccionesUsuario.Controls.Add(this.BtnModificar);
            this.GBAccionesUsuario.Controls.Add(this.lblPAUsuario);
            this.GBAccionesUsuario.Controls.Add(this.BtnEliminar);
            this.GBAccionesUsuario.Controls.Add(this.txtPAApellidoP);
            this.GBAccionesUsuario.Controls.Add(this.txtPANombre);
            this.GBAccionesUsuario.Controls.Add(this.BtnCrear);
            this.GBAccionesUsuario.Location = new System.Drawing.Point(26, 23);
            this.GBAccionesUsuario.Name = "GBAccionesUsuario";
            this.GBAccionesUsuario.Size = new System.Drawing.Size(419, 190);
            this.GBAccionesUsuario.TabIndex = 3;
            this.GBAccionesUsuario.TabStop = false;
            this.GBAccionesUsuario.Text = "Acciones Para usuarios";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(309, 31);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(80, 43);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblPAPassword
            // 
            this.lblPAPassword.AutoSize = true;
            this.lblPAPassword.Location = new System.Drawing.Point(212, 113);
            this.lblPAPassword.Name = "lblPAPassword";
            this.lblPAPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPAPassword.TabIndex = 15;
            this.lblPAPassword.Text = "Password:";
            // 
            // txtPAPassword
            // 
            this.txtPAPassword.Location = new System.Drawing.Point(274, 110);
            this.txtPAPassword.Name = "txtPAPassword";
            this.txtPAPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPAPassword.TabIndex = 14;
            // 
            // lblPAEmail
            // 
            this.lblPAEmail.AutoSize = true;
            this.lblPAEmail.Location = new System.Drawing.Point(233, 91);
            this.lblPAEmail.Name = "lblPAEmail";
            this.lblPAEmail.Size = new System.Drawing.Size(35, 13);
            this.lblPAEmail.TabIndex = 13;
            this.lblPAEmail.Text = "Email:";
            // 
            // txtPAEmail
            // 
            this.txtPAEmail.Location = new System.Drawing.Point(274, 85);
            this.txtPAEmail.Name = "txtPAEmail";
            this.txtPAEmail.Size = new System.Drawing.Size(100, 20);
            this.txtPAEmail.TabIndex = 12;
            // 
            // lblPATusuario
            // 
            this.lblPATusuario.AutoSize = true;
            this.lblPATusuario.Location = new System.Drawing.Point(12, 166);
            this.lblPATusuario.Name = "lblPATusuario";
            this.lblPATusuario.Size = new System.Drawing.Size(85, 13);
            this.lblPATusuario.TabIndex = 11;
            this.lblPATusuario.Text = "Tipo de Usuario:";
            // 
            // txtPATUsuario
            // 
            this.txtPATUsuario.Location = new System.Drawing.Point(103, 166);
            this.txtPATUsuario.Name = "txtPATUsuario";
            this.txtPATUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtPATUsuario.TabIndex = 10;
            // 
            // lblPAApellidoM
            // 
            this.lblPAApellidoM.AutoSize = true;
            this.lblPAApellidoM.Location = new System.Drawing.Point(11, 143);
            this.lblPAApellidoM.Name = "lblPAApellidoM";
            this.lblPAApellidoM.Size = new System.Drawing.Size(86, 13);
            this.lblPAApellidoM.TabIndex = 9;
            this.lblPAApellidoM.Text = "Apellido Materno";
            // 
            // txtPAApellidoM
            // 
            this.txtPAApellidoM.Location = new System.Drawing.Point(103, 143);
            this.txtPAApellidoM.Name = "txtPAApellidoM";
            this.txtPAApellidoM.Size = new System.Drawing.Size(100, 20);
            this.txtPAApellidoM.TabIndex = 8;
            // 
            // lblPAApellidoP
            // 
            this.lblPAApellidoP.AutoSize = true;
            this.lblPAApellidoP.Location = new System.Drawing.Point(11, 117);
            this.lblPAApellidoP.Name = "lblPAApellidoP";
            this.lblPAApellidoP.Size = new System.Drawing.Size(84, 13);
            this.lblPAApellidoP.TabIndex = 7;
            this.lblPAApellidoP.Text = "Apellido Paterno";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(103, 31);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(77, 43);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // lblPAUsuario
            // 
            this.lblPAUsuario.AutoSize = true;
            this.lblPAUsuario.Location = new System.Drawing.Point(53, 91);
            this.lblPAUsuario.Name = "lblPAUsuario";
            this.lblPAUsuario.Size = new System.Drawing.Size(42, 13);
            this.lblPAUsuario.TabIndex = 6;
            this.lblPAUsuario.Text = "nombre";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(186, 31);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(77, 43);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtPAApellidoP
            // 
            this.txtPAApellidoP.Location = new System.Drawing.Point(103, 117);
            this.txtPAApellidoP.Name = "txtPAApellidoP";
            this.txtPAApellidoP.Size = new System.Drawing.Size(100, 20);
            this.txtPAApellidoP.TabIndex = 5;
            // 
            // txtPANombre
            // 
            this.txtPANombre.Location = new System.Drawing.Point(103, 91);
            this.txtPANombre.Name = "txtPANombre";
            this.txtPANombre.Size = new System.Drawing.Size(100, 20);
            this.txtPANombre.TabIndex = 4;
            // 
            // DGUsuarios
            // 
            this.DGUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.C6,
            this.c4,
            this.c5,
            this.c7});
            this.DGUsuarios.Location = new System.Drawing.Point(12, 236);
            this.DGUsuarios.Name = "DGUsuarios";
            this.DGUsuarios.Size = new System.Drawing.Size(673, 213);
            this.DGUsuarios.TabIndex = 4;
            // 
            // c1
            // 
            this.c1.HeaderText = "Tipo de Usuario";
            this.c1.Name = "c1";
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
            // PanelAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 461);
            this.Controls.Add(this.DGUsuarios);
            this.Controls.Add(this.GBAccionesUsuario);
            this.Controls.Add(this.lblPAResUsuario);
            this.Controls.Add(this.LblPBUsuario);
            this.Name = "PanelAdministrativo";
            this.Text = "Panel Administrativo";
            this.GBAccionesUsuario.ResumeLayout(false);
            this.GBAccionesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).EndInit();
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
        private System.Windows.Forms.TextBox txtPANombre;
        private System.Windows.Forms.TextBox txtPAApellidoP;
        private System.Windows.Forms.Label lblPAUsuario;
        private System.Windows.Forms.Label lblPAApellidoP;
        private System.Windows.Forms.Label lblPAEmail;
        private System.Windows.Forms.TextBox txtPAEmail;
        private System.Windows.Forms.Label lblPATusuario;
        private System.Windows.Forms.TextBox txtPATUsuario;
        private System.Windows.Forms.Label lblPAApellidoM;
        private System.Windows.Forms.TextBox txtPAApellidoM;
        private System.Windows.Forms.Label lblPAPassword;
        private System.Windows.Forms.TextBox txtPAPassword;
        private System.Windows.Forms.Button btnMostrar;
        public System.Windows.Forms.DataGridView DGUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C6;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7;
    }
}