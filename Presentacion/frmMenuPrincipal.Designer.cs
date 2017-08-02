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
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.pedidosToolStripMenuItem});
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
            this.listaDePreciosToolStripMenuItem.Click += new System.EventHandler(this.listaDePreciosToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarModificarEliminarToolStripMenuItem,
            this.verStockToolStripMenuItem});
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
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDePedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // gestiónDePedidosToolStripMenuItem
            // 
            this.gestiónDePedidosToolStripMenuItem.Name = "gestiónDePedidosToolStripMenuItem";
            this.gestiónDePedidosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.gestiónDePedidosToolStripMenuItem.Text = "Gestión de Pedidos";
            this.gestiónDePedidosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDePedidosToolStripMenuItem_Click);
            // 
            // verStockToolStripMenuItem
            // 
            this.verStockToolStripMenuItem.Name = "verStockToolStripMenuItem";
            this.verStockToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.verStockToolStripMenuItem.Text = "Ver Stock";
            this.verStockToolStripMenuItem.Click += new System.EventHandler(this.verStockToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem agregarModificarEliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verStockToolStripMenuItem;
    }
}