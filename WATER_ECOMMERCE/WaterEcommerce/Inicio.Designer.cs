namespace WaterEcommerce
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Usuarios = new FontAwesome.Sharp.IconMenuItem();
            this.Inventario = new FontAwesome.Sharp.IconMenuItem();
            this.Ventas = new FontAwesome.Sharp.IconMenuItem();
            this.Roles = new FontAwesome.Sharp.IconMenuItem();
            this.Cupones = new FontAwesome.Sharp.IconMenuItem();
            this.Reportes = new FontAwesome.Sharp.IconMenuItem();
            this.Categorias = new FontAwesome.Sharp.IconMenuItem();
            this.Clientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.Productos = new FontAwesome.Sharp.IconMenuItem();
            this.Compras = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(760, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios,
            this.Inventario,
            this.Roles,
            this.Ventas,
            this.Cupones,
            this.Reportes,
            this.Categorias,
            this.Clientes,
            this.Productos,
            this.Compras});
            this.menuStrip1.Location = new System.Drawing.Point(0, 100);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1920, 104);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // Usuarios
            // 
            this.Usuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Usuarios.ForeColor = System.Drawing.Color.White;
            this.Usuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.Usuarios.IconColor = System.Drawing.Color.White;
            this.Usuarios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Usuarios.IconSize = 72;
            this.Usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Usuarios.Size = new System.Drawing.Size(137, 104);
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Inventario
            // 
            this.Inventario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Inventario.ForeColor = System.Drawing.Color.White;
            this.Inventario.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.Inventario.IconColor = System.Drawing.Color.White;
            this.Inventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Inventario.IconSize = 72;
            this.Inventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Inventario.Name = "Inventario";
            this.Inventario.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Inventario.Size = new System.Drawing.Size(141, 104);
            this.Inventario.Text = "Invetario";
            this.Inventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Inventario.Click += new System.EventHandler(this.iconMenuItem4_Click);
            // 
            // Ventas
            // 
            this.Ventas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Ventas.ForeColor = System.Drawing.Color.White;
            this.Ventas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.Ventas.IconColor = System.Drawing.Color.White;
            this.Ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ventas.IconSize = 72;
            this.Ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Ventas.Name = "Ventas";
            this.Ventas.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Ventas.Size = new System.Drawing.Size(119, 104);
            this.Ventas.Text = "Ventas";
            this.Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Ventas.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // Roles
            // 
            this.Roles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Roles.ForeColor = System.Drawing.Color.White;
            this.Roles.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.Roles.IconColor = System.Drawing.Color.White;
            this.Roles.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Roles.IconSize = 72;
            this.Roles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Roles.Name = "Roles";
            this.Roles.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Roles.Size = new System.Drawing.Size(116, 104);
            this.Roles.Text = "Roles";
            this.Roles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Roles.Click += new System.EventHandler(this.iconMenuItem1_Click_2);
            // 
            // Cupones
            // 
            this.Cupones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Cupones.ForeColor = System.Drawing.Color.White;
            this.Cupones.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.Cupones.IconColor = System.Drawing.Color.White;
            this.Cupones.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Cupones.IconSize = 72;
            this.Cupones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Cupones.Name = "Cupones";
            this.Cupones.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Cupones.Size = new System.Drawing.Size(136, 104);
            this.Cupones.Text = "Cupones";
            this.Cupones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cupones.Click += new System.EventHandler(this.iconMenuItem2_Click_1);
            // 
            // Reportes
            // 
            this.Reportes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Reportes.ForeColor = System.Drawing.Color.White;
            this.Reportes.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.Reportes.IconColor = System.Drawing.Color.White;
            this.Reportes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Reportes.IconSize = 72;
            this.Reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Reportes.Name = "Reportes";
            this.Reportes.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Reportes.Size = new System.Drawing.Size(141, 104);
            this.Reportes.Text = "Reportes";
            this.Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Reportes.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // Categorias
            // 
            this.Categorias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Categorias.ForeColor = System.Drawing.Color.White;
            this.Categorias.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.Categorias.IconColor = System.Drawing.Color.White;
            this.Categorias.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Categorias.IconSize = 72;
            this.Categorias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Categorias.Name = "Categorias";
            this.Categorias.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Categorias.Size = new System.Drawing.Size(156, 104);
            this.Categorias.Text = "Categorias";
            this.Categorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Categorias.Click += new System.EventHandler(this.iconMenuItem4_Click_1);
            // 
            // Clientes
            // 
            this.Clientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Clientes.ForeColor = System.Drawing.Color.White;
            this.Clientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.Clientes.IconColor = System.Drawing.Color.White;
            this.Clientes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Clientes.IconSize = 72;
            this.Clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Clientes.Size = new System.Drawing.Size(131, 104);
            this.Clientes.Text = "Clientes";
            this.Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Clientes.Click += new System.EventHandler(this.iconMenuItem5_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1920, 100);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked_1);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(1699, 148);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(122, 29);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "lblUsuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1699, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.MediumPurple;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 204);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1920, 876);
            this.contenedor.TabIndex = 4;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // Productos
            // 
            this.Productos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Productos.ForeColor = System.Drawing.Color.White;
            this.Productos.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.Productos.IconColor = System.Drawing.Color.White;
            this.Productos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Productos.IconSize = 72;
            this.Productos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Productos.Name = "Productos";
            this.Productos.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Productos.Size = new System.Drawing.Size(151, 104);
            this.Productos.Text = "Productos";
            this.Productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Compras
            // 
            this.Compras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Compras.ForeColor = System.Drawing.Color.White;
            this.Compras.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.Compras.IconColor = System.Drawing.Color.White;
            this.Compras.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Compras.IconSize = 72;
            this.Compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Compras.Name = "Compras";
            this.Compras.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Compras.Size = new System.Drawing.Size(138, 104);
            this.Compras.Text = "Compras";
            this.Compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem Inventario;
        private FontAwesome.Sharp.IconMenuItem Ventas;
        private FontAwesome.Sharp.IconMenuItem Usuarios;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem Roles;
        private FontAwesome.Sharp.IconMenuItem Cupones;
        private FontAwesome.Sharp.IconMenuItem Reportes;
        private FontAwesome.Sharp.IconMenuItem Categorias;
        private FontAwesome.Sharp.IconMenuItem Clientes;
        private FontAwesome.Sharp.IconMenuItem Productos;
        private FontAwesome.Sharp.IconMenuItem Compras;
    }
}

