namespace APU09Maker
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSIniciarSesion = new System.Windows.Forms.ToolStripButton();
            this.tSNuevoUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBVerMateriales = new System.Windows.Forms.ToolStripButton();
            this.tSBAgregarMaterial = new System.Windows.Forms.ToolStripButton();
            this.tSBEditarMaterial = new System.Windows.Forms.ToolStripButton();
            this.tSBEliminarMaterial = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBVerMano = new System.Windows.Forms.ToolStripButton();
            this.tSBAgregarMano = new System.Windows.Forms.ToolStripButton();
            this.tSBEditarMano = new System.Windows.Forms.ToolStripButton();
            this.tSBEliminarMano = new System.Windows.Forms.ToolStripButton();
            this.DatosPpales = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBVerEQ = new System.Windows.Forms.ToolStripButton();
            this.tSBAgregarEQ = new System.Windows.Forms.ToolStripButton();
            this.tSBEditarEQ = new System.Windows.Forms.ToolStripButton();
            this.tSBEliminarEQ = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_AbrirTarjeta = new System.Windows.Forms.ToolStripButton();
            this.tls_Presupuestos = new System.Windows.Forms.ToolStripButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_Temp = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBAcercade = new System.Windows.Forms.ToolStripButton();
            this.tSBAyuda = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Temp)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSIniciarSesion,
            this.tSNuevoUsuario,
            this.toolStripSeparator1,
            this.tSBVerMateriales,
            this.tSBAgregarMaterial,
            this.tSBEditarMaterial,
            this.tSBEliminarMaterial,
            this.toolStripSeparator2,
            this.tSBVerMano,
            this.tSBAgregarMano,
            this.tSBEditarMano,
            this.tSBEliminarMano,
            this.DatosPpales,
            this.toolStripSeparator3,
            this.tSBVerEQ,
            this.tSBAgregarEQ,
            this.tSBEditarEQ,
            this.tSBEliminarEQ,
            this.toolStripSeparator4,
            this.tls_AbrirTarjeta,
            this.tls_Presupuestos,
            this.toolStripSeparator5,
            this.tSBAcercade,
            this.tSBAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1155, 45);
            this.toolStrip1.TabIndex = 81;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSIniciarSesion
            // 
            this.tSIniciarSesion.AutoSize = false;
            this.tSIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tSIniciarSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSIniciarSesion.Image = ((System.Drawing.Image)(resources.GetObject("tSIniciarSesion.Image")));
            this.tSIniciarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSIniciarSesion.Name = "tSIniciarSesion";
            this.tSIniciarSesion.Size = new System.Drawing.Size(24, 31);
            this.tSIniciarSesion.Text = "Iniciar Sesión";
            this.tSIniciarSesion.Click += new System.EventHandler(this.tSIniciarSesion_Click);
            // 
            // tSNuevoUsuario
            // 
            this.tSNuevoUsuario.AutoSize = false;
            this.tSNuevoUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.tSNuevoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tSNuevoUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSNuevoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tSNuevoUsuario.Image")));
            this.tSNuevoUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSNuevoUsuario.Name = "tSNuevoUsuario";
            this.tSNuevoUsuario.Size = new System.Drawing.Size(24, 31);
            this.tSNuevoUsuario.Text = "Nuevo Usuario";
            this.tSNuevoUsuario.Click += new System.EventHandler(this.tSNuevoUsuario_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // tSBVerMateriales
            // 
            this.tSBVerMateriales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBVerMateriales.Image = ((System.Drawing.Image)(resources.GetObject("tSBVerMateriales.Image")));
            this.tSBVerMateriales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBVerMateriales.Name = "tSBVerMateriales";
            this.tSBVerMateriales.Size = new System.Drawing.Size(24, 42);
            this.tSBVerMateriales.Text = "Ver";
            this.tSBVerMateriales.Click += new System.EventHandler(this.tSBVerMateriales_Click);
            // 
            // tSBAgregarMaterial
            // 
            this.tSBAgregarMaterial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBAgregarMaterial.Image = ((System.Drawing.Image)(resources.GetObject("tSBAgregarMaterial.Image")));
            this.tSBAgregarMaterial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBAgregarMaterial.Name = "tSBAgregarMaterial";
            this.tSBAgregarMaterial.Size = new System.Drawing.Size(24, 42);
            this.tSBAgregarMaterial.Text = "Agregar Material";
            this.tSBAgregarMaterial.Click += new System.EventHandler(this.tSBAgregarMaterial_Click);
            // 
            // tSBEditarMaterial
            // 
            this.tSBEditarMaterial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBEditarMaterial.Image = ((System.Drawing.Image)(resources.GetObject("tSBEditarMaterial.Image")));
            this.tSBEditarMaterial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBEditarMaterial.Name = "tSBEditarMaterial";
            this.tSBEditarMaterial.Size = new System.Drawing.Size(24, 42);
            this.tSBEditarMaterial.Text = "Editar Material";
            this.tSBEditarMaterial.Click += new System.EventHandler(this.tSBEditarMaterial_Click);
            // 
            // tSBEliminarMaterial
            // 
            this.tSBEliminarMaterial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBEliminarMaterial.Image = ((System.Drawing.Image)(resources.GetObject("tSBEliminarMaterial.Image")));
            this.tSBEliminarMaterial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBEliminarMaterial.Name = "tSBEliminarMaterial";
            this.tSBEliminarMaterial.Size = new System.Drawing.Size(24, 42);
            this.tSBEliminarMaterial.Text = "Eliminar Material";
            this.tSBEliminarMaterial.Click += new System.EventHandler(this.tSBEliminarMaterial_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // tSBVerMano
            // 
            this.tSBVerMano.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBVerMano.Image = ((System.Drawing.Image)(resources.GetObject("tSBVerMano.Image")));
            this.tSBVerMano.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBVerMano.Name = "tSBVerMano";
            this.tSBVerMano.Size = new System.Drawing.Size(24, 42);
            this.tSBVerMano.Text = "Ver";
            this.tSBVerMano.Click += new System.EventHandler(this.tSBVerMano_Click);
            // 
            // tSBAgregarMano
            // 
            this.tSBAgregarMano.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBAgregarMano.Image = ((System.Drawing.Image)(resources.GetObject("tSBAgregarMano.Image")));
            this.tSBAgregarMano.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBAgregarMano.Name = "tSBAgregarMano";
            this.tSBAgregarMano.Size = new System.Drawing.Size(24, 42);
            this.tSBAgregarMano.Text = "Agregar Mano de Obra";
            this.tSBAgregarMano.Click += new System.EventHandler(this.tSBAgregarMano_Click);
            // 
            // tSBEditarMano
            // 
            this.tSBEditarMano.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBEditarMano.Image = ((System.Drawing.Image)(resources.GetObject("tSBEditarMano.Image")));
            this.tSBEditarMano.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBEditarMano.Name = "tSBEditarMano";
            this.tSBEditarMano.Size = new System.Drawing.Size(24, 42);
            this.tSBEditarMano.Text = "Editar Mano de Obra";
            this.tSBEditarMano.Click += new System.EventHandler(this.tSBEditarMano_Click);
            // 
            // tSBEliminarMano
            // 
            this.tSBEliminarMano.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBEliminarMano.Image = ((System.Drawing.Image)(resources.GetObject("tSBEliminarMano.Image")));
            this.tSBEliminarMano.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBEliminarMano.Name = "tSBEliminarMano";
            this.tSBEliminarMano.Size = new System.Drawing.Size(24, 42);
            this.tSBEliminarMano.Text = "Eliminar Mano de Obra";
            this.tSBEliminarMano.Click += new System.EventHandler(this.tSBEliminarMano_Click);
            // 
            // DatosPpales
            // 
            this.DatosPpales.Image = ((System.Drawing.Image)(resources.GetObject("DatosPpales.Image")));
            this.DatosPpales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DatosPpales.Name = "DatosPpales";
            this.DatosPpales.Size = new System.Drawing.Size(121, 42);
            this.DatosPpales.Text = "Datos Principales";
            this.DatosPpales.Click += new System.EventHandler(this.DatosPpales_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            // 
            // tSBVerEQ
            // 
            this.tSBVerEQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBVerEQ.Image = ((System.Drawing.Image)(resources.GetObject("tSBVerEQ.Image")));
            this.tSBVerEQ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBVerEQ.Name = "tSBVerEQ";
            this.tSBVerEQ.Size = new System.Drawing.Size(24, 42);
            this.tSBVerEQ.Text = "Ver Equipo/Maquinaria";
            this.tSBVerEQ.Click += new System.EventHandler(this.tSBVerEQ_Click);
            // 
            // tSBAgregarEQ
            // 
            this.tSBAgregarEQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBAgregarEQ.Image = ((System.Drawing.Image)(resources.GetObject("tSBAgregarEQ.Image")));
            this.tSBAgregarEQ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBAgregarEQ.Name = "tSBAgregarEQ";
            this.tSBAgregarEQ.Size = new System.Drawing.Size(24, 42);
            this.tSBAgregarEQ.Text = "Agregar Equipo/Maquinaria";
            this.tSBAgregarEQ.Click += new System.EventHandler(this.tSBAgregarEQ_Click);
            // 
            // tSBEditarEQ
            // 
            this.tSBEditarEQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBEditarEQ.Image = ((System.Drawing.Image)(resources.GetObject("tSBEditarEQ.Image")));
            this.tSBEditarEQ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBEditarEQ.Name = "tSBEditarEQ";
            this.tSBEditarEQ.Size = new System.Drawing.Size(24, 42);
            this.tSBEditarEQ.Text = "Editar Equipo/Maquinaria";
            this.tSBEditarEQ.Click += new System.EventHandler(this.tSBEditarEQ_Click);
            // 
            // tSBEliminarEQ
            // 
            this.tSBEliminarEQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBEliminarEQ.Image = ((System.Drawing.Image)(resources.GetObject("tSBEliminarEQ.Image")));
            this.tSBEliminarEQ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBEliminarEQ.Name = "tSBEliminarEQ";
            this.tSBEliminarEQ.Size = new System.Drawing.Size(24, 42);
            this.tSBEliminarEQ.Text = "Eliminar Equipo/Maquinaria";
            this.tSBEliminarEQ.Click += new System.EventHandler(this.tSBEliminarEQ_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 45);
            // 
            // tls_AbrirTarjeta
            // 
            this.tls_AbrirTarjeta.Image = ((System.Drawing.Image)(resources.GetObject("tls_AbrirTarjeta.Image")));
            this.tls_AbrirTarjeta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_AbrirTarjeta.Name = "tls_AbrirTarjeta";
            this.tls_AbrirTarjeta.Size = new System.Drawing.Size(96, 42);
            this.tls_AbrirTarjeta.Text = "Abrir Tarjeta";
            this.tls_AbrirTarjeta.Click += new System.EventHandler(this.tls_AbrirTarjeta_Click);
            // 
            // tls_Presupuestos
            // 
            this.tls_Presupuestos.Image = ((System.Drawing.Image)(resources.GetObject("tls_Presupuestos.Image")));
            this.tls_Presupuestos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_Presupuestos.Name = "tls_Presupuestos";
            this.tls_Presupuestos.Size = new System.Drawing.Size(101, 42);
            this.tls_Presupuestos.Text = "Presupuestos";
            this.tls_Presupuestos.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(943, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 83;
            this.dateTimePicker1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 85;
            this.label1.Visible = false;
            // 
            // dGV_Temp
            // 
            this.dGV_Temp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Temp.Location = new System.Drawing.Point(1078, 29);
            this.dGV_Temp.Name = "dGV_Temp";
            this.dGV_Temp.Size = new System.Drawing.Size(65, 43);
            this.dGV_Temp.TabIndex = 121;
            this.dGV_Temp.Visible = false;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 45);
            // 
            // tSBAcercade
            // 
            this.tSBAcercade.Image = ((System.Drawing.Image)(resources.GetObject("tSBAcercade.Image")));
            this.tSBAcercade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBAcercade.Name = "tSBAcercade";
            this.tSBAcercade.Size = new System.Drawing.Size(92, 42);
            this.tSBAcercade.Text = "Acerca de...";
            // 
            // tSBAyuda
            // 
            this.tSBAyuda.Image = ((System.Drawing.Image)(resources.GetObject("tSBAyuda.Image")));
            this.tSBAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBAyuda.Name = "tSBAyuda";
            this.tSBAyuda.Size = new System.Drawing.Size(65, 42);
            this.tSBAyuda.Text = "Ayuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 712);
            this.Controls.Add(this.dGV_Temp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "APU09Arquitectura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Temp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tSIniciarSesion;
        private System.Windows.Forms.ToolStripButton tSNuevoUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripButton tSBVerMateriales;
        private System.Windows.Forms.ToolStripButton tSBAgregarMaterial;
        private System.Windows.Forms.ToolStripButton tSBEditarMaterial;
        private System.Windows.Forms.ToolStripButton tSBEliminarMaterial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tSBVerMano;
        private System.Windows.Forms.ToolStripButton tSBAgregarMano;
        private System.Windows.Forms.ToolStripButton tSBEditarMano;
        private System.Windows.Forms.ToolStripButton tSBEliminarMano;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tSBVerEQ;
        private System.Windows.Forms.ToolStripButton tSBAgregarEQ;
        private System.Windows.Forms.ToolStripButton tSBEditarEQ;
        private System.Windows.Forms.ToolStripButton tSBEliminarEQ;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton DatosPpales;
        private System.Windows.Forms.ToolStripButton tls_Presupuestos;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tls_AbrirTarjeta;
        private System.Windows.Forms.DataGridView dGV_Temp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tSBAcercade;
        private System.Windows.Forms.ToolStripButton tSBAyuda;
    }
}

