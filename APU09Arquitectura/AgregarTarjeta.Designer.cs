namespace APU09Arquitectura
{
    partial class AgregarTarjeta
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
            this.bt_Agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_clave = new System.Windows.Forms.ComboBox();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Agregar
            // 
            this.bt_Agregar.Location = new System.Drawing.Point(60, 209);
            this.bt_Agregar.Name = "bt_Agregar";
            this.bt_Agregar.Size = new System.Drawing.Size(169, 37);
            this.bt_Agregar.TabIndex = 86;
            this.bt_Agregar.Text = "Agregar al Presupuesto";
            this.bt_Agregar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "Buscar por clave";
            // 
            // cb_clave
            // 
            this.cb_clave.FormattingEnabled = true;
            this.cb_clave.Location = new System.Drawing.Point(15, 27);
            this.cb_clave.Name = "cb_clave";
            this.cb_clave.Size = new System.Drawing.Size(226, 21);
            this.cb_clave.TabIndex = 84;
            // 
            // txtPU
            // 
            this.txtPU.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPU.Location = new System.Drawing.Point(133, 151);
            this.txtPU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(108, 32);
            this.txtPU.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 83;
            this.label5.Text = "Precio Unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 82;
            this.label3.Text = "Unidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 78;
            this.label1.Text = "Descripción";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidad.Location = new System.Drawing.Point(20, 151);
            this.txtUnidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(77, 32);
            this.txtUnidad.TabIndex = 80;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(15, 70);
            this.txtConcepto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConcepto.Size = new System.Drawing.Size(226, 58);
            this.txtConcepto.TabIndex = 79;
            // 
            // AgregarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 262);
            this.Controls.Add(this.bt_Agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_clave);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtConcepto);
            this.MaximizeBox = false;
            this.Name = "AgregarTarjeta";
            this.Text = "Agregar Tarjeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Agregar;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_clave;
        public System.Windows.Forms.TextBox txtPU;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtUnidad;
        public System.Windows.Forms.TextBox txtConcepto;
    }
}