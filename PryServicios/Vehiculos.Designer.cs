namespace PryServicios
{
    partial class Vehiculos
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
            this.GBDetallesAuto = new System.Windows.Forms.GroupBox();
            this.CBAnio = new System.Windows.Forms.ComboBox();
            this.CBModelo = new System.Windows.Forms.ComboBox();
            this.CBMarca = new System.Windows.Forms.ComboBox();
            this.CBTVehiculo = new System.Windows.Forms.ComboBox();
            this.lblTVehiculo = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.GBEstadoVehiculo = new System.Windows.Forms.GroupBox();
            this.CBKilometraje = new System.Windows.Forms.ComboBox();
            this.CBCondicion = new System.Windows.Forms.ComboBox();
            this.lblKilometros = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.DGVehiculos = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblResUsuario = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.GBDetallesAuto.SuspendLayout();
            this.GBEstadoVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // GBDetallesAuto
            // 
            this.GBDetallesAuto.Controls.Add(this.CBAnio);
            this.GBDetallesAuto.Controls.Add(this.CBModelo);
            this.GBDetallesAuto.Controls.Add(this.CBMarca);
            this.GBDetallesAuto.Controls.Add(this.CBTVehiculo);
            this.GBDetallesAuto.Controls.Add(this.lblTVehiculo);
            this.GBDetallesAuto.Controls.Add(this.lblModelo);
            this.GBDetallesAuto.Controls.Add(this.lblAnio);
            this.GBDetallesAuto.Controls.Add(this.lblMarca);
            this.GBDetallesAuto.Location = new System.Drawing.Point(46, 26);
            this.GBDetallesAuto.Name = "GBDetallesAuto";
            this.GBDetallesAuto.Size = new System.Drawing.Size(241, 166);
            this.GBDetallesAuto.TabIndex = 0;
            this.GBDetallesAuto.TabStop = false;
            this.GBDetallesAuto.Text = "Detalles del Vehiculo";
            // 
            // CBAnio
            // 
            this.CBAnio.FormattingEnabled = true;
            this.CBAnio.Location = new System.Drawing.Point(103, 128);
            this.CBAnio.Name = "CBAnio";
            this.CBAnio.Size = new System.Drawing.Size(121, 21);
            this.CBAnio.TabIndex = 11;
            // 
            // CBModelo
            // 
            this.CBModelo.FormattingEnabled = true;
            this.CBModelo.Location = new System.Drawing.Point(102, 96);
            this.CBModelo.Name = "CBModelo";
            this.CBModelo.Size = new System.Drawing.Size(121, 21);
            this.CBModelo.TabIndex = 10;
            // 
            // CBMarca
            // 
            this.CBMarca.FormattingEnabled = true;
            this.CBMarca.Location = new System.Drawing.Point(102, 61);
            this.CBMarca.Name = "CBMarca";
            this.CBMarca.Size = new System.Drawing.Size(121, 21);
            this.CBMarca.TabIndex = 9;
            this.CBMarca.SelectedValueChanged += new System.EventHandler(this.CBMarca_SelectedValueChanged);
            // 
            // CBTVehiculo
            // 
            this.CBTVehiculo.FormattingEnabled = true;
            this.CBTVehiculo.Location = new System.Drawing.Point(102, 28);
            this.CBTVehiculo.Name = "CBTVehiculo";
            this.CBTVehiculo.Size = new System.Drawing.Size(121, 21);
            this.CBTVehiculo.TabIndex = 8;
            // 
            // lblTVehiculo
            // 
            this.lblTVehiculo.AutoSize = true;
            this.lblTVehiculo.Location = new System.Drawing.Point(6, 31);
            this.lblTVehiculo.Name = "lblTVehiculo";
            this.lblTVehiculo.Size = new System.Drawing.Size(90, 13);
            this.lblTVehiculo.TabIndex = 7;
            this.lblTVehiculo.Text = "Tipo de Vehiculo:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(51, 96);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(67, 137);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 1;
            this.lblAnio.Text = "Año:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(56, 64);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // GBEstadoVehiculo
            // 
            this.GBEstadoVehiculo.Controls.Add(this.CBKilometraje);
            this.GBEstadoVehiculo.Controls.Add(this.CBCondicion);
            this.GBEstadoVehiculo.Controls.Add(this.lblKilometros);
            this.GBEstadoVehiculo.Controls.Add(this.lblCondicion);
            this.GBEstadoVehiculo.Location = new System.Drawing.Point(455, 26);
            this.GBEstadoVehiculo.Name = "GBEstadoVehiculo";
            this.GBEstadoVehiculo.Size = new System.Drawing.Size(237, 166);
            this.GBEstadoVehiculo.TabIndex = 1;
            this.GBEstadoVehiculo.TabStop = false;
            this.GBEstadoVehiculo.Text = "Estado del Vehiculo";
            // 
            // CBKilometraje
            // 
            this.CBKilometraje.FormattingEnabled = true;
            this.CBKilometraje.Location = new System.Drawing.Point(95, 64);
            this.CBKilometraje.Name = "CBKilometraje";
            this.CBKilometraje.Size = new System.Drawing.Size(121, 21);
            this.CBKilometraje.TabIndex = 8;
            // 
            // CBCondicion
            // 
            this.CBCondicion.FormattingEnabled = true;
            this.CBCondicion.Location = new System.Drawing.Point(95, 22);
            this.CBCondicion.Name = "CBCondicion";
            this.CBCondicion.Size = new System.Drawing.Size(121, 21);
            this.CBCondicion.TabIndex = 7;
            // 
            // lblKilometros
            // 
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.Location = new System.Drawing.Point(18, 64);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(61, 13);
            this.lblKilometros.TabIndex = 4;
            this.lblKilometros.Text = "Kilometraje:";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(22, 31);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(57, 13);
            this.lblCondicion.TabIndex = 3;
            this.lblCondicion.Text = "Condición:";
            // 
            // DGVehiculos
            // 
            this.DGVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6});
            this.DGVehiculos.Location = new System.Drawing.Point(23, 353);
            this.DGVehiculos.Name = "DGVehiculos";
            this.DGVehiculos.Size = new System.Drawing.Size(739, 226);
            this.DGVehiculos.TabIndex = 3;
            // 
            // c1
            // 
            this.c1.HeaderText = "ID";
            this.c1.Name = "c1";
            this.c1.Width = 40;
            // 
            // c2
            // 
            this.c2.HeaderText = "Tipo de Vehiculo";
            this.c2.Name = "c2";
            // 
            // c3
            // 
            this.c3.HeaderText = "Marca";
            this.c3.Name = "c3";
            // 
            // c4
            // 
            this.c4.HeaderText = "Modelo";
            this.c4.Name = "c4";
            // 
            // c5
            // 
            this.c5.HeaderText = "Condición";
            this.c5.Name = "c5";
            // 
            // c6
            // 
            this.c6.HeaderText = "Precio";
            this.c6.Name = "c6";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(684, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblResUsuario
            // 
            this.lblResUsuario.AutoSize = true;
            this.lblResUsuario.Location = new System.Drawing.Point(736, 9);
            this.lblResUsuario.Name = "lblResUsuario";
            this.lblResUsuario.Size = new System.Drawing.Size(49, 13);
            this.lblResUsuario.TabIndex = 5;
            this.lblResUsuario.Text = "..............";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(23, 298);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 33);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(675, 308);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(87, 24);
            this.btnDetalles.TabIndex = 8;
            this.btnDetalles.Text = "Ver Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(629, 311);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 20);
            this.txtId.TabIndex = 9;
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 591);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblResUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.DGVehiculos);
            this.Controls.Add(this.GBEstadoVehiculo);
            this.Controls.Add(this.GBDetallesAuto);
            this.Name = "Vehiculos";
            this.Text = "Vehiculos";
            this.GBDetallesAuto.ResumeLayout(false);
            this.GBDetallesAuto.PerformLayout();
            this.GBEstadoVehiculo.ResumeLayout(false);
            this.GBEstadoVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBDetallesAuto;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox GBEstadoVehiculo;
        private System.Windows.Forms.Label lblKilometros;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.DataGridView DGVehiculos;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblResUsuario;
        private System.Windows.Forms.Label lblTVehiculo;
        private System.Windows.Forms.ComboBox CBAnio;
        private System.Windows.Forms.ComboBox CBModelo;
        private System.Windows.Forms.ComboBox CBMarca;
        private System.Windows.Forms.ComboBox CBTVehiculo;
        private System.Windows.Forms.ComboBox CBKilometraje;
        private System.Windows.Forms.ComboBox CBCondicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.TextBox txtId;
    }
}