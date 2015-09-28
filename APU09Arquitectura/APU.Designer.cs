namespace APU09Maker
{
    partial class AnPrUn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnPrUn));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_ImporteMAT = new System.Windows.Forms.Label();
            this.dGVMateriales = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btEliminarMaterial = new System.Windows.Forms.Button();
            this.SumImMat = new System.Windows.Forms.TextBox();
            this.btEditarMaterial = new System.Windows.Forms.Button();
            this.btAgregarMaterial = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVManoBoton = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btEliminarMano = new System.Windows.Forms.Button();
            this.btEditarMano = new System.Windows.Forms.Button();
            this.btAgregarMano = new System.Windows.Forms.Button();
            this.SumImMano = new System.Windows.Forms.TextBox();
            this.dGVMano = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btEliminarEQ = new System.Windows.Forms.Button();
            this.btEditarEQ = new System.Windows.Forms.Button();
            this.btAgregarEQ = new System.Windows.Forms.Button();
            this.SumImEQ = new System.Windows.Forms.TextBox();
            this.dGVEquipo = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btFiltrarMat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMateriales)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVManoBoton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMano)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_ImporteMAT);
            this.tabPage1.Controls.Add(this.dGVMateriales);
            this.tabPage1.Controls.Add(this.btEliminarMaterial);
            this.tabPage1.Controls.Add(this.SumImMat);
            this.tabPage1.Controls.Add(this.btEditarMaterial);
            this.tabPage1.Controls.Add(this.btAgregarMaterial);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(687, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Materiales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_ImporteMAT
            // 
            this.lbl_ImporteMAT.AutoSize = true;
            this.lbl_ImporteMAT.Location = new System.Drawing.Point(471, 337);
            this.lbl_ImporteMAT.Name = "lbl_ImporteMAT";
            this.lbl_ImporteMAT.Size = new System.Drawing.Size(89, 16);
            this.lbl_ImporteMAT.TabIndex = 73;
            this.lbl_ImporteMAT.Text = "Suma Importe";
            // 
            // dGVMateriales
            // 
            this.dGVMateriales.AllowUserToAddRows = false;
            this.dGVMateriales.AllowUserToDeleteRows = false;
            this.dGVMateriales.BackgroundColor = System.Drawing.Color.White;
            this.dGVMateriales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dGVMateriales.Location = new System.Drawing.Point(11, 9);
            this.dGVMateriales.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dGVMateriales.Name = "dGVMateriales";
            this.dGVMateriales.RowHeadersVisible = false;
            this.dGVMateriales.Size = new System.Drawing.Size(662, 304);
            this.dGVMateriales.TabIndex = 65;
            this.dGVMateriales.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVMateriales_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btEliminarMaterial
            // 
            this.btEliminarMaterial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEliminarMaterial.BackgroundImage")));
            this.btEliminarMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEliminarMaterial.Location = new System.Drawing.Point(110, 322);
            this.btEliminarMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEliminarMaterial.Name = "btEliminarMaterial";
            this.btEliminarMaterial.Size = new System.Drawing.Size(43, 46);
            this.btEliminarMaterial.TabIndex = 72;
            this.btEliminarMaterial.UseVisualStyleBackColor = true;
            this.btEliminarMaterial.Click += new System.EventHandler(this.btEliminarMaterial_Click);
            // 
            // SumImMat
            // 
            this.SumImMat.Location = new System.Drawing.Point(565, 334);
            this.SumImMat.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.SumImMat.Name = "SumImMat";
            this.SumImMat.Size = new System.Drawing.Size(108, 22);
            this.SumImMat.TabIndex = 66;
            this.SumImMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumImMat_KeyPress);
            // 
            // btEditarMaterial
            // 
            this.btEditarMaterial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditarMaterial.BackgroundImage")));
            this.btEditarMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEditarMaterial.Location = new System.Drawing.Point(61, 322);
            this.btEditarMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditarMaterial.Name = "btEditarMaterial";
            this.btEditarMaterial.Size = new System.Drawing.Size(43, 46);
            this.btEditarMaterial.TabIndex = 71;
            this.btEditarMaterial.UseVisualStyleBackColor = true;
            this.btEditarMaterial.Click += new System.EventHandler(this.btEditarMaterial_Click);
            // 
            // btAgregarMaterial
            // 
            this.btAgregarMaterial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAgregarMaterial.BackgroundImage")));
            this.btAgregarMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAgregarMaterial.Location = new System.Drawing.Point(11, 322);
            this.btAgregarMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAgregarMaterial.Name = "btAgregarMaterial";
            this.btAgregarMaterial.Size = new System.Drawing.Size(43, 46);
            this.btAgregarMaterial.TabIndex = 70;
            this.btAgregarMaterial.UseVisualStyleBackColor = true;
            this.btAgregarMaterial.Click += new System.EventHandler(this.btAgregarMaterial_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dGVManoBoton);
            this.tabPage2.Controls.Add(this.btEliminarMano);
            this.tabPage2.Controls.Add(this.btEditarMano);
            this.tabPage2.Controls.Add(this.btAgregarMano);
            this.tabPage2.Controls.Add(this.SumImMano);
            this.tabPage2.Controls.Add(this.dGVMano);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(687, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mano de Obra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "Suma Importe";
            // 
            // dGVManoBoton
            // 
            this.dGVManoBoton.AllowUserToAddRows = false;
            this.dGVManoBoton.AllowUserToDeleteRows = false;
            this.dGVManoBoton.BackgroundColor = System.Drawing.Color.White;
            this.dGVManoBoton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVManoBoton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVManoBoton.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn4});
            this.dGVManoBoton.Location = new System.Drawing.Point(11, 9);
            this.dGVManoBoton.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dGVManoBoton.Name = "dGVManoBoton";
            this.dGVManoBoton.RowHeadersVisible = false;
            this.dGVManoBoton.RowHeadersWidth = 20;
            this.dGVManoBoton.Size = new System.Drawing.Size(662, 304);
            this.dGVManoBoton.TabIndex = 77;
            this.dGVManoBoton.Visible = false;
            this.dGVManoBoton.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVManoBoton_CellContentClick);
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.HeaderText = "";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btEliminarMano
            // 
            this.btEliminarMano.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEliminarMano.BackgroundImage")));
            this.btEliminarMano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEliminarMano.Location = new System.Drawing.Point(110, 322);
            this.btEliminarMano.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEliminarMano.Name = "btEliminarMano";
            this.btEliminarMano.Size = new System.Drawing.Size(43, 46);
            this.btEliminarMano.TabIndex = 78;
            this.btEliminarMano.UseVisualStyleBackColor = true;
            this.btEliminarMano.Click += new System.EventHandler(this.btEliminarMano_Click_1);
            // 
            // btEditarMano
            // 
            this.btEditarMano.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditarMano.BackgroundImage")));
            this.btEditarMano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEditarMano.Location = new System.Drawing.Point(61, 322);
            this.btEditarMano.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditarMano.Name = "btEditarMano";
            this.btEditarMano.Size = new System.Drawing.Size(43, 46);
            this.btEditarMano.TabIndex = 77;
            this.btEditarMano.UseVisualStyleBackColor = true;
            this.btEditarMano.Click += new System.EventHandler(this.btEditarMano_Click_1);
            // 
            // btAgregarMano
            // 
            this.btAgregarMano.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAgregarMano.BackgroundImage")));
            this.btAgregarMano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAgregarMano.Location = new System.Drawing.Point(11, 322);
            this.btAgregarMano.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAgregarMano.Name = "btAgregarMano";
            this.btAgregarMano.Size = new System.Drawing.Size(43, 46);
            this.btAgregarMano.TabIndex = 76;
            this.btAgregarMano.UseVisualStyleBackColor = true;
            this.btAgregarMano.Click += new System.EventHandler(this.btAgregarMano_Click_1);
            // 
            // SumImMano
            // 
            this.SumImMano.Location = new System.Drawing.Point(565, 334);
            this.SumImMano.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.SumImMano.Name = "SumImMano";
            this.SumImMano.Size = new System.Drawing.Size(108, 22);
            this.SumImMano.TabIndex = 75;
            this.SumImMano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumImMano_KeyPress);
            // 
            // dGVMano
            // 
            this.dGVMano.AllowUserToAddRows = false;
            this.dGVMano.AllowUserToDeleteRows = false;
            this.dGVMano.BackgroundColor = System.Drawing.Color.White;
            this.dGVMano.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVMano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMano.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dGVMano.Location = new System.Drawing.Point(11, 9);
            this.dGVMano.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dGVMano.Name = "dGVMano";
            this.dGVMano.RowHeadersVisible = false;
            this.dGVMano.RowHeadersWidth = 20;
            this.dGVMano.Size = new System.Drawing.Size(662, 304);
            this.dGVMano.TabIndex = 74;
            this.dGVMano.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVMano_CellEndEdit);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btEliminarEQ);
            this.tabPage3.Controls.Add(this.btEditarEQ);
            this.tabPage3.Controls.Add(this.btAgregarEQ);
            this.tabPage3.Controls.Add(this.SumImEQ);
            this.tabPage3.Controls.Add(this.dGVEquipo);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(687, 382);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Equipo/Maquinaria";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "Suma Importe";
            // 
            // btEliminarEQ
            // 
            this.btEliminarEQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEliminarEQ.BackgroundImage")));
            this.btEliminarEQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEliminarEQ.Location = new System.Drawing.Point(110, 322);
            this.btEliminarEQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEliminarEQ.Name = "btEliminarEQ";
            this.btEliminarEQ.Size = new System.Drawing.Size(43, 46);
            this.btEliminarEQ.TabIndex = 83;
            this.btEliminarEQ.UseVisualStyleBackColor = true;
            this.btEliminarEQ.Click += new System.EventHandler(this.btEliminarEQ_Click);
            // 
            // btEditarEQ
            // 
            this.btEditarEQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditarEQ.BackgroundImage")));
            this.btEditarEQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEditarEQ.Location = new System.Drawing.Point(61, 322);
            this.btEditarEQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditarEQ.Name = "btEditarEQ";
            this.btEditarEQ.Size = new System.Drawing.Size(43, 46);
            this.btEditarEQ.TabIndex = 82;
            this.btEditarEQ.UseVisualStyleBackColor = true;
            this.btEditarEQ.Click += new System.EventHandler(this.btEditarEQ_Click);
            // 
            // btAgregarEQ
            // 
            this.btAgregarEQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAgregarEQ.BackgroundImage")));
            this.btAgregarEQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAgregarEQ.Location = new System.Drawing.Point(11, 322);
            this.btAgregarEQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAgregarEQ.Name = "btAgregarEQ";
            this.btAgregarEQ.Size = new System.Drawing.Size(43, 46);
            this.btAgregarEQ.TabIndex = 81;
            this.btAgregarEQ.UseVisualStyleBackColor = true;
            this.btAgregarEQ.Click += new System.EventHandler(this.btAgregarEQ_Click);
            // 
            // SumImEQ
            // 
            this.SumImEQ.Location = new System.Drawing.Point(565, 334);
            this.SumImEQ.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.SumImEQ.Name = "SumImEQ";
            this.SumImEQ.Size = new System.Drawing.Size(108, 22);
            this.SumImEQ.TabIndex = 80;
            this.SumImEQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumImEQ_KeyPress);
            // 
            // dGVEquipo
            // 
            this.dGVEquipo.AllowUserToAddRows = false;
            this.dGVEquipo.AllowUserToDeleteRows = false;
            this.dGVEquipo.BackgroundColor = System.Drawing.Color.White;
            this.dGVEquipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2});
            this.dGVEquipo.Location = new System.Drawing.Point(11, 9);
            this.dGVEquipo.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dGVEquipo.Name = "dGVEquipo";
            this.dGVEquipo.RowHeadersVisible = false;
            this.dGVEquipo.Size = new System.Drawing.Size(662, 304);
            this.dGVEquipo.TabIndex = 44;
            this.dGVEquipo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVEquipo_CellEndEdit);
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btFiltrarMat
            // 
            this.btFiltrarMat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btFiltrarMat.BackgroundImage")));
            this.btFiltrarMat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFiltrarMat.Location = new System.Drawing.Point(573, 4);
            this.btFiltrarMat.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btFiltrarMat.Name = "btFiltrarMat";
            this.btFiltrarMat.Size = new System.Drawing.Size(30, 30);
            this.btFiltrarMat.TabIndex = 64;
            this.btFiltrarMat.UseVisualStyleBackColor = true;
            this.btFiltrarMat.Click += new System.EventHandler(this.btFiltrarMat_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(658, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 76;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btActualizar.BackgroundImage")));
            this.btActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btActualizar.Location = new System.Drawing.Point(616, 3);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(30, 30);
            this.btActualizar.TabIndex = 77;
            this.btActualizar.UseVisualStyleBackColor = true;
            // 
            // AnPrUn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 444);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btFiltrarMat);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AnPrUn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análisis de Precios Unitarios";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMateriales)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVManoBoton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMano)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEquipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.Button btFiltrarMat;
        public System.Windows.Forms.DataGridView dGVMateriales;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        public System.Windows.Forms.Button btEliminarMaterial;
        public System.Windows.Forms.TextBox SumImMat;
        public System.Windows.Forms.Button btEditarMaterial;
        public System.Windows.Forms.Button btAgregarMaterial;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btEliminarMano;
        public System.Windows.Forms.Button btEditarMano;
        public System.Windows.Forms.Button btAgregarMano;
        public System.Windows.Forms.TextBox SumImMano;
        public System.Windows.Forms.DataGridView dGVMano;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        public System.Windows.Forms.Button btEliminarEQ;
        public System.Windows.Forms.Button btEditarEQ;
        public System.Windows.Forms.Button btAgregarEQ;
        public System.Windows.Forms.TextBox SumImEQ;
        public System.Windows.Forms.DataGridView dGVEquipo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        public System.Windows.Forms.DataGridView dGVManoBoton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.Label lbl_ImporteMAT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btActualizar;
    }
}