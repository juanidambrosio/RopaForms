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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioArs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisiónEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionFreddy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGanancia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioArs,
            this.PrecioSol,
            this.ComisiónEnvio,
            this.ComisionFreddy,
            this.ComisionPeso,
            this.PrecioFinal});
            this.dataGridView1.Location = new System.Drawing.Point(0, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 518);
            this.dataGridView1.TabIndex = 0;
            // 
            // Producto
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // PrecioArs
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioArs.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecioArs.HeaderText = "Precio (ARS)";
            this.PrecioArs.Name = "PrecioArs";
            // 
            // PrecioSol
            // 
            this.PrecioSol.HeaderText = "Precio (SOLES)";
            this.PrecioSol.Name = "PrecioSol";
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
            this.PrecioFinal.HeaderText = "Precio Final";
            this.PrecioFinal.Name = "PrecioFinal";
            this.PrecioFinal.ReadOnly = true;
            // 
            // btnGanancia
            // 
            this.btnGanancia.Location = new System.Drawing.Point(782, 37);
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
            this.label1.Location = new System.Drawing.Point(814, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtros";
            // 
            // frmListaPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGanancia);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmListaPrecios";
            this.Text = "Lista de Precios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioArs;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisiónEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionFreddy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinal;
        private System.Windows.Forms.Button btnGanancia;
        private System.Windows.Forms.Label label1;
    }
}