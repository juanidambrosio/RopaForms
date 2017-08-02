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
            this.dgvListaPrecios = new System.Windows.Forms.DataGridView();
            this.btnGanancia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioArs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisiónEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionFreddy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaPrecios
            // 
            this.dgvListaPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioSol,
            this.PrecioDolares,
            this.PrecioArs,
            this.ComisiónEnvio,
            this.ComisionFreddy,
            this.ComisionPeso,
            this.PrecioFinal});
            this.dgvListaPrecios.Location = new System.Drawing.Point(0, 4);
            this.dgvListaPrecios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaPrecios.Name = "dgvListaPrecios";
            this.dgvListaPrecios.Size = new System.Drawing.Size(851, 518);
            this.dgvListaPrecios.TabIndex = 0;
            // 
            // btnGanancia
            // 
            this.btnGanancia.Location = new System.Drawing.Point(885, 47);
            this.btnGanancia.Name = "btnGanancia";
            this.btnGanancia.Size = new System.Drawing.Size(113, 55);
            this.btnGanancia.TabIndex = 1;
            this.btnGanancia.Text = "Proyectar Ganancia";
            this.btnGanancia.UseVisualStyleBackColor = true;
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
            // Producto
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // PrecioSol
            // 
            this.PrecioSol.HeaderText = "Precio (PER)";
            this.PrecioSol.Name = "PrecioSol";
            // 
            // PrecioDolares
            // 
            this.PrecioDolares.HeaderText = "Precio (US$)";
            this.PrecioDolares.Name = "PrecioDolares";
            this.PrecioDolares.ReadOnly = true;
            // 
            // PrecioArs
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioArs.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecioArs.HeaderText = "Precio (ARS)";
            this.PrecioArs.Name = "PrecioArs";
            // 
            // ComisiónEnvio
            // 
            this.ComisiónEnvio.HeaderText = "Comisión Por Envío";
            this.ComisiónEnvio.Name = "ComisiónEnvio";
            this.ComisiónEnvio.ReadOnly = true;
            // 
            // ComisionFreddy
            // 
            this.ComisionFreddy.HeaderText = "Comisión a Freddy";
            this.ComisionFreddy.Name = "ComisionFreddy";
            this.ComisionFreddy.ReadOnly = true;
            // 
            // ComisionPeso
            // 
            this.ComisionPeso.HeaderText = "Comisión por Peso";
            this.ComisionPeso.Name = "ComisionPeso";
            this.ComisionPeso.ReadOnly = true;
            // 
            // PrecioFinal
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioFinal.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrecioFinal.HeaderText = "Precio Final (ARS)";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioArs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisiónEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionFreddy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinal;
    }
}