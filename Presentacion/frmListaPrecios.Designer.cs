namespace Presentacion
{
    partial class frmListaPrecios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaPrecios = new System.Windows.Forms.DataGridView();
            this.btnGanancia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioARS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionFreddy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaPrecios
            // 
            this.dgvListaPrecios.AllowUserToAddRows = false;
            this.dgvListaPrecios.AllowUserToDeleteRows = false;
            this.dgvListaPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Producto,
            this.PrecioPER,
            this.PrecioUS,
            this.PrecioARS,
            this.ComisionFreddy,
            this.ComisionPeso,
            this.PrecioFinal});
            this.dgvListaPrecios.Location = new System.Drawing.Point(0, 4);
            this.dgvListaPrecios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaPrecios.Name = "dgvListaPrecios";
            this.dgvListaPrecios.ReadOnly = true;
            this.dgvListaPrecios.Size = new System.Drawing.Size(851, 518);
            this.dgvListaPrecios.TabIndex = 0;
            // 
            // btnGanancia
            // 
            this.btnGanancia.Location = new System.Drawing.Point(885, 47);
            this.btnGanancia.Name = "btnGanancia";
            this.btnGanancia.Size = new System.Drawing.Size(113, 55);
            this.btnGanancia.TabIndex = 1;
            this.btnGanancia.Text = "Actualizar";
            this.btnGanancia.UseVisualStyleBackColor = true;
            this.btnGanancia.Click += new System.EventHandler(this.btnGanancia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(919, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtros";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // PrecioPER
            // 
            this.PrecioPER.DataPropertyName = "Precio PER";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.PrecioPER.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrecioPER.HeaderText = "Precio PER";
            this.PrecioPER.Name = "PrecioPER";
            this.PrecioPER.ReadOnly = true;
            // 
            // PrecioUS
            // 
            this.PrecioUS.DataPropertyName = "Precio US";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.PrecioUS.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecioUS.HeaderText = "Precio US";
            this.PrecioUS.Name = "PrecioUS";
            this.PrecioUS.ReadOnly = true;
            // 
            // PrecioARS
            // 
            this.PrecioARS.DataPropertyName = "Precio ARS";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.PrecioARS.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrecioARS.HeaderText = "Precio ARS";
            this.PrecioARS.Name = "PrecioARS";
            this.PrecioARS.ReadOnly = true;
            // 
            // ComisionFreddy
            // 
            this.ComisionFreddy.DataPropertyName = "Comision Freddy";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.ComisionFreddy.DefaultCellStyle = dataGridViewCellStyle4;
            this.ComisionFreddy.HeaderText = "Comision Freddy";
            this.ComisionFreddy.Name = "ComisionFreddy";
            this.ComisionFreddy.ReadOnly = true;
            // 
            // ComisionPeso
            // 
            this.ComisionPeso.DataPropertyName = "Comision Peso";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.ComisionPeso.DefaultCellStyle = dataGridViewCellStyle5;
            this.ComisionPeso.HeaderText = "Comision Peso";
            this.ComisionPeso.Name = "ComisionPeso";
            this.ComisionPeso.ReadOnly = true;
            // 
            // PrecioFinal
            // 
            this.PrecioFinal.DataPropertyName = "Precio Final";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.PrecioFinal.DefaultCellStyle = dataGridViewCellStyle6;
            this.PrecioFinal.HeaderText = "Precio Final";
            this.PrecioFinal.Name = "PrecioFinal";
            this.PrecioFinal.ReadOnly = true;
            // 
            // frmListaPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGanancia);
            this.Controls.Add(this.dgvListaPrecios);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmListaPrecios";
            this.Text = "Lista de Precios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaPrecios;
        private System.Windows.Forms.Button btnGanancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioARS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionFreddy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinal;
    }
}