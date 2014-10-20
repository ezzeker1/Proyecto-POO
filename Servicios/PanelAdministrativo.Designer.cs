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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.CBTUsuario = new System.Windows.Forms.ComboBox();
            this.lblPAPassword = new System.Windows.Forms.Label();
            this.txtPAPassword = new System.Windows.Forms.TextBox();
            this.lblPAEmail = new System.Windows.Forms.Label();
            this.txtPAEmail = new System.Windows.Forms.TextBox();
            this.lblPATusuario = new System.Windows.Forms.Label();
            this.lblPAApellidoM = new System.Windows.Forms.Label();
            this.txtPAApellidoM = new System.Windows.Forms.TextBox();
            this.lblPAApellidoP = new System.Windows.Forms.Label();
            this.lblPAUsuario = new System.Windows.Forms.Label();
            this.txtPAApellidoP = new System.Windows.Forms.TextBox();
            this.txtPANombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GBAdmUsuarios = new System.Windows.Forms.GroupBox();
            this.GBAccionesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).BeginInit();
            this.GBPermisos.SuspendLayout();
            this.GBAdmUsuarios.SuspendLayout();
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
            this.BtnCrear.Location = new System.Drawing.Point(16, 19);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(80, 22);
            this.BtnCrear.TabIndex = 2;
            this.BtnCrear.Text = "Registrar";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // GBAccionesUsuario
            // 
            this.GBAccionesUsuario.Controls.Add(this.txtUsuario);
            this.GBAccionesUsuario.Controls.Add(this.lblUsuario);
            this.GBAccionesUsuario.Controls.Add(this.CBTUsuario);
            this.GBAccionesUsuario.Controls.Add(this.lblPAPassword);
            this.GBAccionesUsuario.Controls.Add(this.txtPAPassword);
            this.GBAccionesUsuario.Controls.Add(this.lblPAEmail);
            this.GBAccionesUsuario.Controls.Add(this.txtPAEmail);
            this.GBAccionesUsuario.Controls.Add(this.lblPATusuario);
            this.GBAccionesUsuario.Controls.Add(this.lblPAApellidoM);
            this.GBAccionesUsuario.Controls.Add(this.txtPAApellidoM);
            this.GBAccionesUsuario.Controls.Add(this.lblPAApellidoP);
            this.GBAccionesUsuario.Controls.Add(this.lblPAUsuario);
            this.GBAccionesUsuario.Controls.Add(this.txtPAApellidoP);
            this.GBAccionesUsuario.Controls.Add(this.txtPANombre);
            this.GBAccionesUsuario.Controls.Add(this.BtnCrear);
            this.GBAccionesUsuario.Location = new System.Drawing.Point(26, 23);
            this.GBAccionesUsuario.Name = "GBAccionesUsuario";
            this.GBAccionesUsuario.Size = new System.Drawing.Size(362, 241);
            this.GBAccionesUsuario.TabIndex = 3;
            this.GBAccionesUsuario.TabStop = false;
            this.GBAccionesUsuario.Text = "Registrar usuarios";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(172, 26);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(80, 22);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Listar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(6, 26);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(77, 22);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(89, 26);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(77, 22);
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
            this.DGUsuarios.Location = new System.Drawing.Point(12, 289);
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
            this.btnPermisos.Size = new System.Drawing.Size(113, 23);
            this.btnPermisos.TabIndex = 5;
            this.btnPermisos.Text = "Asignar Permisos";
            this.btnPermisos.UseVisualStyleBackColor = true;
            // 
            // GBPermisos
            // 
            this.GBPermisos.Controls.Add(this.button1);
            this.GBPermisos.Controls.Add(this.btnPermisos);
            this.GBPermisos.Location = new System.Drawing.Point(405, 25);
            this.GBPermisos.Name = "GBPermisos";
            this.GBPermisos.Size = new System.Drawing.Size(305, 62);
            this.GBPermisos.TabIndex = 6;
            this.GBPermisos.TabStop = false;
            this.GBPermisos.Text = "Funciones Administrativas";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(102, 53);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(144, 20);
            this.txtUsuario.TabIndex = 46;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(52, 60);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 45;
            this.lblUsuario.Text = "Usuario:";
            // 
            // CBTUsuario
            // 
            this.CBTUsuario.FormattingEnabled = true;
            this.CBTUsuario.Location = new System.Drawing.Point(102, 158);
            this.CBTUsuario.Name = "CBTUsuario";
            this.CBTUsuario.Size = new System.Drawing.Size(121, 21);
            this.CBTUsuario.TabIndex = 44;
            // 
            // lblPAPassword
            // 
            this.lblPAPassword.AutoSize = true;
            this.lblPAPassword.Location = new System.Drawing.Point(40, 218);
            this.lblPAPassword.Name = "lblPAPassword";
            this.lblPAPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPAPassword.TabIndex = 43;
            this.lblPAPassword.Text = "Password:";
            // 
            // txtPAPassword
            // 
            this.txtPAPassword.Location = new System.Drawing.Point(102, 211);
            this.txtPAPassword.Name = "txtPAPassword";
            this.txtPAPassword.PasswordChar = '*';
            this.txtPAPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPAPassword.TabIndex = 42;
            // 
            // lblPAEmail
            // 
            this.lblPAEmail.AutoSize = true;
            this.lblPAEmail.Location = new System.Drawing.Point(61, 192);
            this.lblPAEmail.Name = "lblPAEmail";
            this.lblPAEmail.Size = new System.Drawing.Size(35, 13);
            this.lblPAEmail.TabIndex = 41;
            this.lblPAEmail.Text = "Email:";
            // 
            // txtPAEmail
            // 
            this.txtPAEmail.Location = new System.Drawing.Point(102, 185);
            this.txtPAEmail.Name = "txtPAEmail";
            this.txtPAEmail.Size = new System.Drawing.Size(196, 20);
            this.txtPAEmail.TabIndex = 40;
            // 
            // lblPATusuario
            // 
            this.lblPATusuario.AutoSize = true;
            this.lblPATusuario.Location = new System.Drawing.Point(11, 166);
            this.lblPATusuario.Name = "lblPATusuario";
            this.lblPATusuario.Size = new System.Drawing.Size(85, 13);
            this.lblPATusuario.TabIndex = 39;
            this.lblPATusuario.Text = "Tipo de Usuario:";
            // 
            // lblPAApellidoM
            // 
            this.lblPAApellidoM.AutoSize = true;
            this.lblPAApellidoM.Location = new System.Drawing.Point(9, 140);
            this.lblPAApellidoM.Name = "lblPAApellidoM";
            this.lblPAApellidoM.Size = new System.Drawing.Size(89, 13);
            this.lblPAApellidoM.TabIndex = 38;
            this.lblPAApellidoM.Text = "Apellido Materno:";
            // 
            // txtPAApellidoM
            // 
            this.txtPAApellidoM.Location = new System.Drawing.Point(102, 133);
            this.txtPAApellidoM.Name = "txtPAApellidoM";
            this.txtPAApellidoM.Size = new System.Drawing.Size(100, 20);
            this.txtPAApellidoM.TabIndex = 37;
            // 
            // lblPAApellidoP
            // 
            this.lblPAApellidoP.AutoSize = true;
            this.lblPAApellidoP.Location = new System.Drawing.Point(8, 110);
            this.lblPAApellidoP.Name = "lblPAApellidoP";
            this.lblPAApellidoP.Size = new System.Drawing.Size(87, 13);
            this.lblPAApellidoP.TabIndex = 36;
            this.lblPAApellidoP.Text = "Apellido Paterno:";
            // 
            // lblPAUsuario
            // 
            this.lblPAUsuario.AutoSize = true;
            this.lblPAUsuario.Location = new System.Drawing.Point(44, 84);
            this.lblPAUsuario.Name = "lblPAUsuario";
            this.lblPAUsuario.Size = new System.Drawing.Size(52, 13);
            this.lblPAUsuario.TabIndex = 35;
            this.lblPAUsuario.Text = "Nombres:";
            // 
            // txtPAApellidoP
            // 
            this.txtPAApellidoP.Location = new System.Drawing.Point(102, 107);
            this.txtPAApellidoP.Name = "txtPAApellidoP";
            this.txtPAApellidoP.Size = new System.Drawing.Size(102, 20);
            this.txtPAApellidoP.TabIndex = 34;
            // 
            // txtPANombre
            // 
            this.txtPANombre.Location = new System.Drawing.Point(102, 81);
            this.txtPANombre.Name = "txtPANombre";
            this.txtPANombre.Size = new System.Drawing.Size(225, 20);
            this.txtPANombre.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "dd";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GBAdmUsuarios
            // 
            this.GBAdmUsuarios.Controls.Add(this.btnMostrar);
            this.GBAdmUsuarios.Controls.Add(this.BtnEliminar);
            this.GBAdmUsuarios.Controls.Add(this.BtnModificar);
            this.GBAdmUsuarios.Location = new System.Drawing.Point(405, 102);
            this.GBAdmUsuarios.Name = "GBAdmUsuarios";
            this.GBAdmUsuarios.Size = new System.Drawing.Size(266, 100);
            this.GBAdmUsuarios.TabIndex = 7;
            this.GBAdmUsuarios.TabStop = false;
            this.GBAdmUsuarios.Text = "Administrar Usuarios";
            // 
            // PanelAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 514);
            this.Controls.Add(this.GBAdmUsuarios);
            this.Controls.Add(this.GBPermisos);
            this.Controls.Add(this.DGUsuarios);
            this.Controls.Add(this.GBAccionesUsuario);
            this.Controls.Add(this.lblPAResUsuario);
            this.Controls.Add(this.LblPBUsuario);
            this.Name = "PanelAdministrativo";
            this.Text = "Panel Administrativo";
            this.Load += new System.EventHandler(this.PanelAdministrativo_Load);
            this.GBAccionesUsuario.ResumeLayout(false);
            this.GBAccionesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).EndInit();
            this.GBPermisos.ResumeLayout(false);
            this.GBAdmUsuarios.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox CBTUsuario;
        private System.Windows.Forms.Label lblPAPassword;
        private System.Windows.Forms.TextBox txtPAPassword;
        private System.Windows.Forms.Label lblPAEmail;
        private System.Windows.Forms.TextBox txtPAEmail;
        private System.Windows.Forms.Label lblPATusuario;
        private System.Windows.Forms.Label lblPAApellidoM;
        private System.Windows.Forms.TextBox txtPAApellidoM;
        private System.Windows.Forms.Label lblPAApellidoP;
        private System.Windows.Forms.Label lblPAUsuario;
        private System.Windows.Forms.TextBox txtPAApellidoP;
        private System.Windows.Forms.TextBox txtPANombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GBAdmUsuarios;
    }
}