namespace APU09Maker
{
    partial class EliminarMano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarMano));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbEliminar = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.txtSSV = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbEliminar);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.txtOcupacion);
            this.groupBox2.Controls.Add(this.txtSSV);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Location = new System.Drawing.Point(14, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(376, 265);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            // 
            // cbEliminar
            // 
            this.cbEliminar.FormattingEnabled = true;
            this.cbEliminar.Location = new System.Drawing.Point(188, 28);
            this.cbEliminar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(174, 25);
            this.cbEliminar.TabIndex = 18;
            this.cbEliminar.SelectedIndexChanged += new System.EventHandler(this.cbEliminar_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(122, 31);
            this.label25.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 17);
            this.label25.TabIndex = 17;
            this.label25.Text = "Buscar";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(188, 74);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(174, 25);
            this.txtCodigo.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(123, 77);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(54, 17);
            this.label26.TabIndex = 0;
            this.label26.Text = "Código";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(98, 112);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(79, 17);
            this.label27.TabIndex = 2;
            this.label27.Text = "Ocupación";
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Location = new System.Drawing.Point(188, 109);
            this.txtOcupacion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtOcupacion.Multiline = true;
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.ReadOnly = true;
            this.txtOcupacion.Size = new System.Drawing.Size(174, 59);
            this.txtOcupacion.TabIndex = 3;
            // 
            // txtSSV
            // 
            this.txtSSV.Location = new System.Drawing.Point(188, 178);
            this.txtSSV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSSV.Name = "txtSSV";
            this.txtSSV.ReadOnly = true;
            this.txtSSV.Size = new System.Drawing.Size(174, 25);
            this.txtSSV.TabIndex = 4;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 181);
            this.label28.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(167, 17);
            this.label28.TabIndex = 8;
            this.label28.Text = "Sueldo Semanal Vigente";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(188, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 31);
            this.button1.TabIndex = 61;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EliminarMano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(402, 293);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "EliminarMano";
            this.Text = "Eliminar Mano de Obra";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbEliminar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.TextBox txtSSV;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button1;
    }
}