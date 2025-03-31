namespace pryGuadalupeLunaGestionInventario
{
    partial class frmGestion
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
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.lblStockMod = new System.Windows.Forms.Label();
            this.lblPrecioMod = new System.Windows.Forms.Label();
            this.numStockMod = new System.Windows.Forms.NumericUpDown();
            this.numPrecioMod = new System.Windows.Forms.NumericUpDown();
            this.lblDescMod = new System.Windows.Forms.Label();
            this.txtDescMod = new System.Windows.Forms.TextBox();
            this.lblNomMod = new System.Windows.Forms.Label();
            this.txtNomMod = new System.Windows.Forms.TextBox();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.lblStockBuscar = new System.Windows.Forms.Label();
            this.lblPrecioBuscar = new System.Windows.Forms.Label();
            this.numStockBuscar = new System.Windows.Forms.NumericUpDown();
            this.numPrecioBuscar = new System.Windows.Forms.NumericUpDown();
            this.lblDescBuscar = new System.Windows.Forms.Label();
            this.txtDescBuscar = new System.Windows.Forms.TextBox();
            this.lblNomBuscar = new System.Windows.Forms.Label();
            this.txtNomBuscar = new System.Windows.Forms.TextBox();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.lblStockEliminar = new System.Windows.Forms.Label();
            this.lblPrecioEliminar = new System.Windows.Forms.Label();
            this.numStockEliminar = new System.Windows.Forms.NumericUpDown();
            this.numPrecioEliminar = new System.Windows.Forms.NumericUpDown();
            this.lblDescEliminar = new System.Windows.Forms.Label();
            this.txtDescEliminar = new System.Windows.Forms.TextBox();
            this.lblNomEliminar = new System.Windows.Forms.Label();
            this.txtNomEliminar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.grpModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioMod)).BeginInit();
            this.grpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioBuscar)).BeginInit();
            this.grpEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Nombre,
            this.descripción,
            this.precio,
            this.stock});
            this.dgvInventario.Location = new System.Drawing.Point(196, 24);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(543, 503);
            this.dgvInventario.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.numStock);
            this.groupBox1.Controls.Add(this.numPrecio);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(26, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // descripción
            // 
            this.descripción.HeaderText = "Descripción";
            this.descripción.Name = "descripción";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(19, 80);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(22, 96);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(22, 138);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(100, 20);
            this.numPrecio.TabIndex = 4;
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(22, 182);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(100, 20);
            this.numStock.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(19, 122);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(19, 166);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock";
            // 
            // grpModificar
            // 
            this.grpModificar.Controls.Add(this.lblStockMod);
            this.grpModificar.Controls.Add(this.lblPrecioMod);
            this.grpModificar.Controls.Add(this.numStockMod);
            this.grpModificar.Controls.Add(this.numPrecioMod);
            this.grpModificar.Controls.Add(this.lblDescMod);
            this.grpModificar.Controls.Add(this.txtDescMod);
            this.grpModificar.Controls.Add(this.lblNomMod);
            this.grpModificar.Controls.Add(this.txtNomMod);
            this.grpModificar.Location = new System.Drawing.Point(26, 290);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Size = new System.Drawing.Size(153, 237);
            this.grpModificar.TabIndex = 8;
            this.grpModificar.TabStop = false;
            this.grpModificar.Text = "Modificar";
            // 
            // lblStockMod
            // 
            this.lblStockMod.AutoSize = true;
            this.lblStockMod.Location = new System.Drawing.Point(19, 166);
            this.lblStockMod.Name = "lblStockMod";
            this.lblStockMod.Size = new System.Drawing.Size(35, 13);
            this.lblStockMod.TabIndex = 7;
            this.lblStockMod.Text = "Stock";
            // 
            // lblPrecioMod
            // 
            this.lblPrecioMod.AutoSize = true;
            this.lblPrecioMod.Location = new System.Drawing.Point(19, 122);
            this.lblPrecioMod.Name = "lblPrecioMod";
            this.lblPrecioMod.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioMod.TabIndex = 6;
            this.lblPrecioMod.Text = "Precio";
            // 
            // numStockMod
            // 
            this.numStockMod.Location = new System.Drawing.Point(22, 182);
            this.numStockMod.Name = "numStockMod";
            this.numStockMod.Size = new System.Drawing.Size(100, 20);
            this.numStockMod.TabIndex = 5;
            // 
            // numPrecioMod
            // 
            this.numPrecioMod.Location = new System.Drawing.Point(22, 138);
            this.numPrecioMod.Name = "numPrecioMod";
            this.numPrecioMod.Size = new System.Drawing.Size(100, 20);
            this.numPrecioMod.TabIndex = 4;
            // 
            // lblDescMod
            // 
            this.lblDescMod.AutoSize = true;
            this.lblDescMod.Location = new System.Drawing.Point(19, 80);
            this.lblDescMod.Name = "lblDescMod";
            this.lblDescMod.Size = new System.Drawing.Size(63, 13);
            this.lblDescMod.TabIndex = 3;
            this.lblDescMod.Text = "Descripción";
            // 
            // txtDescMod
            // 
            this.txtDescMod.Location = new System.Drawing.Point(22, 96);
            this.txtDescMod.Name = "txtDescMod";
            this.txtDescMod.Size = new System.Drawing.Size(100, 20);
            this.txtDescMod.TabIndex = 2;
            // 
            // lblNomMod
            // 
            this.lblNomMod.AutoSize = true;
            this.lblNomMod.Location = new System.Drawing.Point(19, 35);
            this.lblNomMod.Name = "lblNomMod";
            this.lblNomMod.Size = new System.Drawing.Size(44, 13);
            this.lblNomMod.TabIndex = 1;
            this.lblNomMod.Text = "Nombre";
            // 
            // txtNomMod
            // 
            this.txtNomMod.Location = new System.Drawing.Point(22, 51);
            this.txtNomMod.Name = "txtNomMod";
            this.txtNomMod.Size = new System.Drawing.Size(100, 20);
            this.txtNomMod.TabIndex = 0;
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.lblStockBuscar);
            this.grpBuscar.Controls.Add(this.lblPrecioBuscar);
            this.grpBuscar.Controls.Add(this.numStockBuscar);
            this.grpBuscar.Controls.Add(this.numPrecioBuscar);
            this.grpBuscar.Controls.Add(this.lblDescBuscar);
            this.grpBuscar.Controls.Add(this.txtDescBuscar);
            this.grpBuscar.Controls.Add(this.lblNomBuscar);
            this.grpBuscar.Controls.Add(this.txtNomBuscar);
            this.grpBuscar.Location = new System.Drawing.Point(757, 24);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(153, 237);
            this.grpBuscar.TabIndex = 9;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // lblStockBuscar
            // 
            this.lblStockBuscar.AutoSize = true;
            this.lblStockBuscar.Location = new System.Drawing.Point(19, 166);
            this.lblStockBuscar.Name = "lblStockBuscar";
            this.lblStockBuscar.Size = new System.Drawing.Size(35, 13);
            this.lblStockBuscar.TabIndex = 7;
            this.lblStockBuscar.Text = "Stock";
            // 
            // lblPrecioBuscar
            // 
            this.lblPrecioBuscar.AutoSize = true;
            this.lblPrecioBuscar.Location = new System.Drawing.Point(19, 122);
            this.lblPrecioBuscar.Name = "lblPrecioBuscar";
            this.lblPrecioBuscar.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioBuscar.TabIndex = 6;
            this.lblPrecioBuscar.Text = "Precio";
            // 
            // numStockBuscar
            // 
            this.numStockBuscar.Location = new System.Drawing.Point(22, 182);
            this.numStockBuscar.Name = "numStockBuscar";
            this.numStockBuscar.Size = new System.Drawing.Size(100, 20);
            this.numStockBuscar.TabIndex = 5;
            // 
            // numPrecioBuscar
            // 
            this.numPrecioBuscar.Location = new System.Drawing.Point(22, 138);
            this.numPrecioBuscar.Name = "numPrecioBuscar";
            this.numPrecioBuscar.Size = new System.Drawing.Size(100, 20);
            this.numPrecioBuscar.TabIndex = 4;
            // 
            // lblDescBuscar
            // 
            this.lblDescBuscar.AutoSize = true;
            this.lblDescBuscar.Location = new System.Drawing.Point(19, 80);
            this.lblDescBuscar.Name = "lblDescBuscar";
            this.lblDescBuscar.Size = new System.Drawing.Size(63, 13);
            this.lblDescBuscar.TabIndex = 3;
            this.lblDescBuscar.Text = "Descripción";
            // 
            // txtDescBuscar
            // 
            this.txtDescBuscar.Location = new System.Drawing.Point(22, 96);
            this.txtDescBuscar.Name = "txtDescBuscar";
            this.txtDescBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtDescBuscar.TabIndex = 2;
            // 
            // lblNomBuscar
            // 
            this.lblNomBuscar.AutoSize = true;
            this.lblNomBuscar.Location = new System.Drawing.Point(19, 35);
            this.lblNomBuscar.Name = "lblNomBuscar";
            this.lblNomBuscar.Size = new System.Drawing.Size(44, 13);
            this.lblNomBuscar.TabIndex = 1;
            this.lblNomBuscar.Text = "Nombre";
            // 
            // txtNomBuscar
            // 
            this.txtNomBuscar.Location = new System.Drawing.Point(22, 51);
            this.txtNomBuscar.Name = "txtNomBuscar";
            this.txtNomBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtNomBuscar.TabIndex = 0;
            // 
            // grpEliminar
            // 
            this.grpEliminar.Controls.Add(this.lblStockEliminar);
            this.grpEliminar.Controls.Add(this.lblPrecioEliminar);
            this.grpEliminar.Controls.Add(this.numStockEliminar);
            this.grpEliminar.Controls.Add(this.numPrecioEliminar);
            this.grpEliminar.Controls.Add(this.lblDescEliminar);
            this.grpEliminar.Controls.Add(this.txtDescEliminar);
            this.grpEliminar.Controls.Add(this.lblNomEliminar);
            this.grpEliminar.Controls.Add(this.txtNomEliminar);
            this.grpEliminar.Location = new System.Drawing.Point(757, 290);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Size = new System.Drawing.Size(153, 237);
            this.grpEliminar.TabIndex = 8;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "Eliminar";
            // 
            // lblStockEliminar
            // 
            this.lblStockEliminar.AutoSize = true;
            this.lblStockEliminar.Location = new System.Drawing.Point(19, 166);
            this.lblStockEliminar.Name = "lblStockEliminar";
            this.lblStockEliminar.Size = new System.Drawing.Size(35, 13);
            this.lblStockEliminar.TabIndex = 7;
            this.lblStockEliminar.Text = "Stock";
            // 
            // lblPrecioEliminar
            // 
            this.lblPrecioEliminar.AutoSize = true;
            this.lblPrecioEliminar.Location = new System.Drawing.Point(19, 122);
            this.lblPrecioEliminar.Name = "lblPrecioEliminar";
            this.lblPrecioEliminar.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioEliminar.TabIndex = 6;
            this.lblPrecioEliminar.Text = "Precio";
            // 
            // numStockEliminar
            // 
            this.numStockEliminar.Location = new System.Drawing.Point(22, 182);
            this.numStockEliminar.Name = "numStockEliminar";
            this.numStockEliminar.Size = new System.Drawing.Size(100, 20);
            this.numStockEliminar.TabIndex = 5;
            // 
            // numPrecioEliminar
            // 
            this.numPrecioEliminar.Location = new System.Drawing.Point(22, 138);
            this.numPrecioEliminar.Name = "numPrecioEliminar";
            this.numPrecioEliminar.Size = new System.Drawing.Size(100, 20);
            this.numPrecioEliminar.TabIndex = 4;
            // 
            // lblDescEliminar
            // 
            this.lblDescEliminar.AutoSize = true;
            this.lblDescEliminar.Location = new System.Drawing.Point(19, 80);
            this.lblDescEliminar.Name = "lblDescEliminar";
            this.lblDescEliminar.Size = new System.Drawing.Size(63, 13);
            this.lblDescEliminar.TabIndex = 3;
            this.lblDescEliminar.Text = "Descripción";
            // 
            // txtDescEliminar
            // 
            this.txtDescEliminar.Location = new System.Drawing.Point(22, 96);
            this.txtDescEliminar.Name = "txtDescEliminar";
            this.txtDescEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtDescEliminar.TabIndex = 2;
            // 
            // lblNomEliminar
            // 
            this.lblNomEliminar.AutoSize = true;
            this.lblNomEliminar.Location = new System.Drawing.Point(19, 35);
            this.lblNomEliminar.Name = "lblNomEliminar";
            this.lblNomEliminar.Size = new System.Drawing.Size(44, 13);
            this.lblNomEliminar.TabIndex = 1;
            this.lblNomEliminar.Text = "Nombre";
            // 
            // txtNomEliminar
            // 
            this.txtNomEliminar.Location = new System.Drawing.Point(22, 51);
            this.txtNomEliminar.Name = "txtNomEliminar";
            this.txtNomEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtNomEliminar.TabIndex = 0;
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 579);
            this.Controls.Add(this.grpEliminar);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.grpModificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvInventario);
            this.Name = "frmGestion";
            this.Text = "Gestion de inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.grpModificar.ResumeLayout(false);
            this.grpModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioMod)).EndInit();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioBuscar)).EndInit();
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox grpModificar;
        private System.Windows.Forms.Label lblStockMod;
        private System.Windows.Forms.Label lblPrecioMod;
        private System.Windows.Forms.NumericUpDown numStockMod;
        private System.Windows.Forms.NumericUpDown numPrecioMod;
        private System.Windows.Forms.Label lblDescMod;
        private System.Windows.Forms.TextBox txtDescMod;
        private System.Windows.Forms.Label lblNomMod;
        private System.Windows.Forms.TextBox txtNomMod;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Label lblStockBuscar;
        private System.Windows.Forms.Label lblPrecioBuscar;
        private System.Windows.Forms.NumericUpDown numStockBuscar;
        private System.Windows.Forms.NumericUpDown numPrecioBuscar;
        private System.Windows.Forms.Label lblDescBuscar;
        private System.Windows.Forms.TextBox txtDescBuscar;
        private System.Windows.Forms.Label lblNomBuscar;
        private System.Windows.Forms.TextBox txtNomBuscar;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.Label lblStockEliminar;
        private System.Windows.Forms.Label lblPrecioEliminar;
        private System.Windows.Forms.NumericUpDown numStockEliminar;
        private System.Windows.Forms.NumericUpDown numPrecioEliminar;
        private System.Windows.Forms.Label lblDescEliminar;
        private System.Windows.Forms.TextBox txtDescEliminar;
        private System.Windows.Forms.Label lblNomEliminar;
        private System.Windows.Forms.TextBox txtNomEliminar;
    }
}

