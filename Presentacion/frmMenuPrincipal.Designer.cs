namespace Presentacion
{
    partial class frmMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarModificarEliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarModificarEliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.historialesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarModificarEliminarToolStripMenuItem1,
            this.listaDePreciosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarModificarEliminarToolStripMenuItem1
            // 
            this.agregarModificarEliminarToolStripMenuItem1.Name = "agregarModificarEliminarToolStripMenuItem1";
            this.agregarModificarEliminarToolStripMenuItem1.Size = new System.Drawing.Size(220, 22);
            this.agregarModificarEliminarToolStripMenuItem1.Text = "Agregar/Modificar/Eliminar";
            this.agregarModificarEliminarToolStripMenuItem1.Click += new System.EventHandler(this.agregarModificarEliminarToolStripMenuItem1_Click);
            // 
            // listaDePreciosToolStripMenuItem
            // 
            this.listaDePreciosToolStripMenuItem.Name = "listaDePreciosToolStripMenuItem";
            this.listaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.listaDePreciosToolStripMenuItem.Text = "Lista de Precios";
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarModificarEliminarToolStripMenuItem,
            this.movimientosDeStockToolStripMenuItem});
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // agregarModificarEliminarToolStripMenuItem
            // 
            this.agregarModificarEliminarToolStripMenuItem.Name = "agregarModificarEliminarToolStripMenuItem";
            this.agregarModificarEliminarToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.agregarModificarEliminarToolStripMenuItem.Text = "Agregar/Modificar/Eliminar";
            this.agregarModificarEliminarToolStripMenuItem.Click += new System.EventHandler(this.agregarModificarEliminarToolStripMenuItem_Click);
            // 
            // movimientosDeStockToolStripMenuItem
            // 
            this.movimientosDeStockToolStripMenuItem.Name = "movimientosDeStockToolStripMenuItem";
            this.movimientosDeStockToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.movimientosDeStockToolStripMenuItem.Text = "Movimientos de Stock";
            // 
            // historialesToolStripMenuItem
            // 
            this.historialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.egresosToolStripMenuItem});
            this.historialesToolStripMenuItem.Name = "historialesToolStripMenuItem";
            this.historialesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.historialesToolStripMenuItem.Text = "Historiales";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ingresosToolStripMenuItem.Text = "Ingreso de Stock";
            // 
            // egresosToolStripMenuItem
            // 
            this.egresosToolStripMenuItem.Name = "egresosToolStripMenuItem";
            this.egresosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.egresosToolStripMenuItem.Text = "Egreso de Stock";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 401);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = "NTQP";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarModificarEliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarModificarEliminarToolStripMenuItem1;
    }
}