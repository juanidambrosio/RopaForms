namespace Presentacion
{
    partial class frmPedidos
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
            this.rbPedidoFreddy = new System.Windows.Forms.RadioButton();
            this.rbEntrega = new System.Windows.Forms.RadioButton();
            this.rbDevolucion = new System.Windows.Forms.RadioButton();
            this.panelOpcionesPedido = new System.Windows.Forms.Panel();
            this.lblRecordatorio = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.SiNo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioComisionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOpcionesPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // rbPedidoFreddy
            // 
            this.rbPedidoFreddy.AutoSize = true;
            this.rbPedidoFreddy.Location = new System.Drawing.Point(39, 26);
            this.rbPedidoFreddy.Margin = new System.Windows.Forms.Padding(4);
            this.rbPedidoFreddy.Name = "rbPedidoFreddy";
            this.rbPedidoFreddy.Size = new System.Drawing.Size(143, 22);
            this.rbPedidoFreddy.TabIndex = 0;
            this.rbPedidoFreddy.TabStop = true;
            this.rbPedidoFreddy.Text = "Pedido a Freddy";
            this.rbPedidoFreddy.UseVisualStyleBackColor = true;
            // 
            // rbEntrega
            // 
            this.rbEntrega.AutoSize = true;
            this.rbEntrega.Location = new System.Drawing.Point(225, 26);
            this.rbEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.rbEntrega.Name = "rbEntrega";
            this.rbEntrega.Size = new System.Drawing.Size(166, 22);
            this.rbEntrega.TabIndex = 1;
            this.rbEntrega.TabStop = true;
            this.rbEntrega.Text = "Entrega a Vendedor";
            this.rbEntrega.UseVisualStyleBackColor = true;
            // 
            // rbDevolucion
            // 
            this.rbDevolucion.AutoSize = true;
            this.rbDevolucion.Location = new System.Drawing.Point(447, 26);
            this.rbDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.rbDevolucion.Name = "rbDevolucion";
            this.rbDevolucion.Size = new System.Drawing.Size(103, 22);
            this.rbDevolucion.TabIndex = 2;
            this.rbDevolucion.TabStop = true;
            this.rbDevolucion.Text = "Devolución";
            this.rbDevolucion.UseVisualStyleBackColor = true;
            // 
            // panelOpcionesPedido
            // 
            this.panelOpcionesPedido.Controls.Add(this.rbPedidoFreddy);
            this.panelOpcionesPedido.Controls.Add(this.rbDevolucion);
            this.panelOpcionesPedido.Controls.Add(this.rbEntrega);
            this.panelOpcionesPedido.Location = new System.Drawing.Point(250, 75);
            this.panelOpcionesPedido.Margin = new System.Windows.Forms.Padding(4);
            this.panelOpcionesPedido.Name = "panelOpcionesPedido";
            this.panelOpcionesPedido.Size = new System.Drawing.Size(585, 86);
            this.panelOpcionesPedido.TabIndex = 3;
            // 
            // lblRecordatorio
            // 
            this.lblRecordatorio.AutoSize = true;
            this.lblRecordatorio.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordatorio.Location = new System.Drawing.Point(343, 22);
            this.lblRecordatorio.Name = "lblRecordatorio";
            this.lblRecordatorio.Size = new System.Drawing.Size(433, 32);
            this.lblRecordatorio.TabIndex = 4;
            this.lblRecordatorio.Text = "ELEGIR UNA DE LAS OPCIONES";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiNo,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Total,
            this.PrecioComisionado});
            this.dgvPedido.Location = new System.Drawing.Point(202, 189);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(692, 265);
            this.dgvPedido.TabIndex = 5;
            // 
            // SiNo
            // 
            this.SiNo.HeaderText = "Si/No";
            this.SiNo.Name = "SiNo";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Precio
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.Precio.HeaderText = "Precio por unidad (ARS)";
            this.Precio.Name = "Precio";
            this.Precio.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // PrecioComisionado
            // 
            this.PrecioComisionado.HeaderText = "Precio con Comisiones";
            this.PrecioComisionado.Name = "PrecioComisionado";
            this.PrecioComisionado.ReadOnly = true;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 568);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.lblRecordatorio);
            this.Controls.Add(this.panelOpcionesPedido);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPedidos";
            this.Text = "Gestión de Pedidos";
            this.panelOpcionesPedido.ResumeLayout(false);
            this.panelOpcionesPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPedidoFreddy;
        private System.Windows.Forms.RadioButton rbEntrega;
        private System.Windows.Forms.RadioButton rbDevolucion;
        private System.Windows.Forms.Panel panelOpcionesPedido;
        private System.Windows.Forms.Label lblRecordatorio;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SiNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioComisionado;
    }
}