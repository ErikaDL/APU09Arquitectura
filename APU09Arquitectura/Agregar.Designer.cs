namespace APU09Arquitectura
{
    partial class Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_CostoHr = new System.Windows.Forms.Label();
            this.lbl_Salario = new System.Windows.Forms.Label();
            this.lbl_Sueldo = new System.Windows.Forms.Label();
            this.lbl_Ocupacion = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbl_Costo = new System.Windows.Forms.Label();
            this.lbl_Unidad = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Agregar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB_EqMaq = new System.Windows.Forms.RadioButton();
            this.rB_ManodeObra = new System.Windows.Forms.RadioButton();
            this.rb_Materiales = new System.Windows.Forms.RadioButton();
            this.dGV_Temp = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Temp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbl_CostoHr);
            this.groupBox2.Controls.Add(this.lbl_Salario);
            this.groupBox2.Controls.Add(this.lbl_Sueldo);
            this.groupBox2.Controls.Add(this.lbl_Ocupacion);
            this.groupBox2.Controls.Add(this.btActualizar);
            this.groupBox2.Controls.Add(this.txtCosto);
            this.groupBox2.Controls.Add(this.txtUnidad);
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.lbl_Costo);
            this.groupBox2.Controls.Add(this.lbl_Unidad);
            this.groupBox2.Controls.Add(this.lbl_Descripcion);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(15, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(307, 225);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar";
            // 
            // lbl_CostoHr
            // 
            this.lbl_CostoHr.AutoSize = true;
            this.lbl_CostoHr.Location = new System.Drawing.Point(62, 152);
            this.lbl_CostoHr.Name = "lbl_CostoHr";
            this.lbl_CostoHr.Size = new System.Drawing.Size(62, 17);
            this.lbl_CostoHr.TabIndex = 20;
            this.lbl_CostoHr.Text = "CostoHr";
            this.lbl_CostoHr.Visible = false;
            // 
            // lbl_Salario
            // 
            this.lbl_Salario.AutoSize = true;
            this.lbl_Salario.Location = new System.Drawing.Point(37, 152);
            this.lbl_Salario.Name = "lbl_Salario";
            this.lbl_Salario.Size = new System.Drawing.Size(87, 17);
            this.lbl_Salario.TabIndex = 19;
            this.lbl_Salario.Text = "Salario Total";
            // 
            // lbl_Sueldo
            // 
            this.lbl_Sueldo.AutoSize = true;
            this.lbl_Sueldo.Location = new System.Drawing.Point(7, 120);
            this.lbl_Sueldo.Name = "lbl_Sueldo";
            this.lbl_Sueldo.Size = new System.Drawing.Size(120, 17);
            this.lbl_Sueldo.TabIndex = 18;
            this.lbl_Sueldo.Text = "Sueldo Sem. Vig.";
            this.lbl_Sueldo.Visible = false;
            // 
            // lbl_Ocupacion
            // 
            this.lbl_Ocupacion.AutoSize = true;
            this.lbl_Ocupacion.Location = new System.Drawing.Point(50, 56);
            this.lbl_Ocupacion.Name = "lbl_Ocupacion";
            this.lbl_Ocupacion.Size = new System.Drawing.Size(79, 17);
            this.lbl_Ocupacion.TabIndex = 17;
            this.lbl_Ocupacion.Text = "Ocupación";
            this.lbl_Ocupacion.Visible = false;
            // 
            // btActualizar
            // 
            this.btActualizar.ForeColor = System.Drawing.Color.Black;
            this.btActualizar.Location = new System.Drawing.Point(10, 182);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(5);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(287, 30);
            this.btActualizar.TabIndex = 5;
            this.btActualizar.Text = "Agregar Material";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(137, 150);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(5);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(160, 22);
            this.txtCosto.TabIndex = 4;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidad.Location = new System.Drawing.Point(137, 118);
            this.txtUnidad.Margin = new System.Windows.Forms.Padding(5);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(160, 22);
            this.txtUnidad.TabIndex = 3;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(137, 54);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(5);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(160, 54);
            this.txtDesc.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(137, 22);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(160, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // lbl_Costo
            // 
            this.lbl_Costo.AutoSize = true;
            this.lbl_Costo.Location = new System.Drawing.Point(76, 152);
            this.lbl_Costo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Costo.Name = "lbl_Costo";
            this.lbl_Costo.Size = new System.Drawing.Size(47, 17);
            this.lbl_Costo.TabIndex = 12;
            this.lbl_Costo.Text = "Costo";
            // 
            // lbl_Unidad
            // 
            this.lbl_Unidad.AutoSize = true;
            this.lbl_Unidad.Location = new System.Drawing.Point(74, 120);
            this.lbl_Unidad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Unidad.Name = "lbl_Unidad";
            this.lbl_Unidad.Size = new System.Drawing.Size(53, 17);
            this.lbl_Unidad.TabIndex = 11;
            this.lbl_Unidad.Text = "Unidad";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(41, 56);
            this.lbl_Descripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(86, 17);
            this.lbl_Descripcion.TabIndex = 10;
            this.lbl_Descripcion.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código";
            // 
            // cb_Agregar
            // 
            this.cb_Agregar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Agregar.FormattingEnabled = true;
            this.cb_Agregar.Location = new System.Drawing.Point(174, 31);
            this.cb_Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Agregar.Name = "cb_Agregar";
            this.cb_Agregar.Size = new System.Drawing.Size(148, 24);
            this.cb_Agregar.TabIndex = 15;
            this.cb_Agregar.SelectedIndexChanged += new System.EventHandler(this.cb_Agregar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(175, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Buscar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rB_EqMaq);
            this.groupBox1.Controls.Add(this.rB_ManodeObra);
            this.groupBox1.Controls.Add(this.rb_Materiales);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 108);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona";
            // 
            // rB_EqMaq
            // 
            this.rB_EqMaq.AutoSize = true;
            this.rB_EqMaq.Location = new System.Drawing.Point(6, 78);
            this.rB_EqMaq.Name = "rB_EqMaq";
            this.rB_EqMaq.Size = new System.Drawing.Size(145, 21);
            this.rB_EqMaq.TabIndex = 2;
            this.rB_EqMaq.Text = "Equipo/Maquinaria";
            this.rB_EqMaq.UseVisualStyleBackColor = true;
            this.rB_EqMaq.CheckedChanged += new System.EventHandler(this.rB_EqMaq_CheckedChanged);
            // 
            // rB_ManodeObra
            // 
            this.rB_ManodeObra.AutoSize = true;
            this.rB_ManodeObra.Location = new System.Drawing.Point(6, 51);
            this.rB_ManodeObra.Name = "rB_ManodeObra";
            this.rB_ManodeObra.Size = new System.Drawing.Size(118, 21);
            this.rB_ManodeObra.TabIndex = 1;
            this.rB_ManodeObra.Text = "Mano de Obra";
            this.rB_ManodeObra.UseVisualStyleBackColor = true;
            this.rB_ManodeObra.CheckedChanged += new System.EventHandler(this.rB_ManodeObra_CheckedChanged);
            // 
            // rb_Materiales
            // 
            this.rb_Materiales.AutoSize = true;
            this.rb_Materiales.Checked = true;
            this.rb_Materiales.Location = new System.Drawing.Point(6, 24);
            this.rb_Materiales.Name = "rb_Materiales";
            this.rb_Materiales.Size = new System.Drawing.Size(92, 21);
            this.rb_Materiales.TabIndex = 0;
            this.rb_Materiales.TabStop = true;
            this.rb_Materiales.Text = "Materiales";
            this.rb_Materiales.UseVisualStyleBackColor = true;
            this.rb_Materiales.CheckedChanged += new System.EventHandler(this.rb_Materiales_CheckedChanged);
            // 
            // dGV_Temp
            // 
            this.dGV_Temp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Temp.Location = new System.Drawing.Point(258, 66);
            this.dGV_Temp.Name = "dGV_Temp";
            this.dGV_Temp.Size = new System.Drawing.Size(65, 43);
            this.dGV_Temp.TabIndex = 121;
            this.dGV_Temp.Visible = false;
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(335, 361);
            this.Controls.Add(this.dGV_Temp);
            this.Controls.Add(this.cb_Agregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Temp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_Agregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbl_Costo;
        private System.Windows.Forms.Label lbl_Unidad;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB_EqMaq;
        private System.Windows.Forms.RadioButton rB_ManodeObra;
        private System.Windows.Forms.RadioButton rb_Materiales;
        private System.Windows.Forms.Label lbl_Ocupacion;
        private System.Windows.Forms.Label lbl_Sueldo;
        private System.Windows.Forms.Label lbl_Salario;
        private System.Windows.Forms.Label lbl_CostoHr;
        private System.Windows.Forms.DataGridView dGV_Temp;
    }
}