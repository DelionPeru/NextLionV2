namespace NextBlast.Vistas
{
    partial class PlantillaCargaView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantillaCargaView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbtipotaladro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiametro = new System.Windows.Forms.NumericUpDown();
            this.txtprofundidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCarguio = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rblongitud = new System.Windows.Forms.RadioButton();
            this.tbmasa = new System.Windows.Forms.RadioButton();
            this.btneliminaatCarguio = new System.Windows.Forms.Button();
            this.btnagregarCarguio = new System.Windows.Forms.Button();
            this.dgvPrimado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelgrafico = new System.Windows.Forms.Panel();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbversion = new System.Windows.Forms.Label();
            this.lbtitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprofundidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarguio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimado)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.cmbtipotaladro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdiametro);
            this.groupBox1.Controls.Add(this.txtprofundidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // cmbtipotaladro
            // 
            this.cmbtipotaladro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipotaladro.FormattingEnabled = true;
            this.cmbtipotaladro.Location = new System.Drawing.Point(141, 33);
            this.cmbtipotaladro.Name = "cmbtipotaladro";
            this.cmbtipotaladro.Size = new System.Drawing.Size(129, 23);
            this.cmbtipotaladro.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Taladro :";
            // 
            // txtdiametro
            // 
            this.txtdiametro.DecimalPlaces = 2;
            this.txtdiametro.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtdiametro.Location = new System.Drawing.Point(141, 64);
            this.txtdiametro.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtdiametro.Name = "txtdiametro";
            this.txtdiametro.Size = new System.Drawing.Size(129, 21);
            this.txtdiametro.TabIndex = 1;
            this.txtdiametro.ValueChanged += new System.EventHandler(this.txtdiametro_ValueChanged);
            this.txtdiametro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdiametro_KeyUp);
            // 
            // txtprofundidad
            // 
            this.txtprofundidad.DecimalPlaces = 2;
            this.txtprofundidad.Location = new System.Drawing.Point(141, 93);
            this.txtprofundidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtprofundidad.Name = "txtprofundidad";
            this.txtprofundidad.Size = new System.Drawing.Size(129, 21);
            this.txtprofundidad.TabIndex = 2;
            this.txtprofundidad.ValueChanged += new System.EventHandler(this.txtprofundidad_ValueChanged);
            this.txtprofundidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtprofundidad_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profundidad (mm) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diámetro (mm) :";
            // 
            // dgvCarguio
            // 
            this.dgvCarguio.AllowUserToAddRows = false;
            this.dgvCarguio.AllowUserToDeleteRows = false;
            this.dgvCarguio.AllowUserToResizeColumns = false;
            this.dgvCarguio.AllowUserToResizeRows = false;
            this.dgvCarguio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarguio.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvCarguio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle61.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarguio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle61;
            this.dgvCarguio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarguio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.dataGridViewTextBoxColumn6,
            this.Column4,
            this.dataGridViewTextBoxColumn7,
            this.Column2});
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarguio.DefaultCellStyle = dataGridViewCellStyle64;
            this.dgvCarguio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarguio.Location = new System.Drawing.Point(22, 224);
            this.dgvCarguio.MultiSelect = false;
            this.dgvCarguio.Name = "dgvCarguio";
            this.dgvCarguio.ReadOnly = true;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle65.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarguio.RowHeadersDefaultCellStyle = dataGridViewCellStyle65;
            this.dgvCarguio.RowHeadersVisible = false;
            dataGridViewCellStyle66.ForeColor = System.Drawing.Color.Black;
            this.dgvCarguio.RowsDefaultCellStyle = dataGridViewCellStyle66;
            this.dgvCarguio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarguio.Size = new System.Drawing.Size(294, 174);
            this.dgvCarguio.TabIndex = 4;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 120.5333F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Explosivo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Calcular";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle62.Format = "N2";
            dataGridViewCellStyle62.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle62;
            this.dataGridViewTextBoxColumn7.FillWeight = 95.63796F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Longitud [m]";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            dataGridViewCellStyle63.Format = "N2";
            dataGridViewCellStyle63.NullValue = null;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle63;
            this.Column2.FillWeight = 123.0439F;
            this.Column2.HeaderText = "Kg";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rblongitud
            // 
            this.rblongitud.AutoSize = true;
            this.rblongitud.Checked = true;
            this.rblongitud.Location = new System.Drawing.Point(22, 194);
            this.rblongitud.Name = "rblongitud";
            this.rblongitud.Size = new System.Drawing.Size(73, 19);
            this.rblongitud.TabIndex = 2;
            this.rblongitud.TabStop = true;
            this.rblongitud.Text = "Longitud";
            this.rblongitud.UseVisualStyleBackColor = true;
            // 
            // tbmasa
            // 
            this.tbmasa.AutoSize = true;
            this.tbmasa.Location = new System.Drawing.Point(118, 194);
            this.tbmasa.Name = "tbmasa";
            this.tbmasa.Size = new System.Drawing.Size(55, 19);
            this.tbmasa.TabIndex = 3;
            this.tbmasa.Text = "Masa";
            this.tbmasa.UseVisualStyleBackColor = true;
            // 
            // btneliminaatCarguio
            // 
            this.btneliminaatCarguio.BackColor = System.Drawing.Color.Transparent;
            this.btneliminaatCarguio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminaatCarguio.BackgroundImage")));
            this.btneliminaatCarguio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminaatCarguio.CausesValidation = false;
            this.btneliminaatCarguio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminaatCarguio.Enabled = false;
            this.btneliminaatCarguio.FlatAppearance.BorderSize = 0;
            this.btneliminaatCarguio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btneliminaatCarguio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btneliminaatCarguio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminaatCarguio.Location = new System.Drawing.Point(286, 188);
            this.btneliminaatCarguio.Name = "btneliminaatCarguio";
            this.btneliminaatCarguio.Size = new System.Drawing.Size(30, 30);
            this.btneliminaatCarguio.TabIndex = 1;
            this.btneliminaatCarguio.UseVisualStyleBackColor = false;
            // 
            // btnagregarCarguio
            // 
            this.btnagregarCarguio.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarCarguio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregarCarguio.BackgroundImage")));
            this.btnagregarCarguio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregarCarguio.CausesValidation = false;
            this.btnagregarCarguio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarCarguio.Enabled = false;
            this.btnagregarCarguio.FlatAppearance.BorderSize = 0;
            this.btnagregarCarguio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnagregarCarguio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnagregarCarguio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarCarguio.Location = new System.Drawing.Point(250, 188);
            this.btnagregarCarguio.Name = "btnagregarCarguio";
            this.btnagregarCarguio.Size = new System.Drawing.Size(30, 30);
            this.btnagregarCarguio.TabIndex = 0;
            this.btnagregarCarguio.UseVisualStyleBackColor = false;
            // 
            // dgvPrimado
            // 
            this.dgvPrimado.AllowUserToAddRows = false;
            this.dgvPrimado.AllowUserToResizeColumns = false;
            this.dgvPrimado.AllowUserToResizeRows = false;
            this.dgvPrimado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrimado.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvPrimado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle67.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle67.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle67.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle67.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle67.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrimado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle67;
            this.dgvPrimado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column3});
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle70.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle70.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrimado.DefaultCellStyle = dataGridViewCellStyle70;
            this.dgvPrimado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPrimado.Location = new System.Drawing.Point(22, 404);
            this.dgvPrimado.MultiSelect = false;
            this.dgvPrimado.Name = "dgvPrimado";
            this.dgvPrimado.ReadOnly = true;
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle71.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrimado.RowHeadersDefaultCellStyle = dataGridViewCellStyle71;
            this.dgvPrimado.RowHeadersVisible = false;
            dataGridViewCellStyle72.ForeColor = System.Drawing.Color.Black;
            this.dgvPrimado.RowsDefaultCellStyle = dataGridViewCellStyle72;
            this.dgvPrimado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrimado.Size = new System.Drawing.Size(294, 142);
            this.dgvPrimado.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 132.2999F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Iniciador";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle68.Format = "N2";
            dataGridViewCellStyle68.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle68;
            this.dataGridViewTextBoxColumn3.FillWeight = 104.9742F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Detonador";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle69.Format = "N2";
            dataGridViewCellStyle69.NullValue = null;
            dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle69;
            this.dataGridViewTextBoxColumn4.FillWeight = 135.0555F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Backup";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 66.88555F;
            this.Column3.HeaderText = "Pos";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // panelgrafico
            // 
            this.panelgrafico.BackColor = System.Drawing.Color.Silver;
            this.panelgrafico.Location = new System.Drawing.Point(322, 44);
            this.panelgrafico.Name = "panelgrafico";
            this.panelgrafico.Size = new System.Drawing.Size(135, 502);
            this.panelgrafico.TabIndex = 6;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.Green;
            this.btnaceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaceptar.FlatAppearance.BorderSize = 0;
            this.btnaceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnaceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Location = new System.Drawing.Point(22, 552);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(442, 27);
            this.btnaceptar.TabIndex = 62;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.panelHeader.Controls.Add(this.lbversion);
            this.panelHeader.Controls.Add(this.lbtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(476, 31);
            this.panelHeader.TabIndex = 63;
            // 
            // lbversion
            // 
            this.lbversion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbversion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbversion.ForeColor = System.Drawing.Color.White;
            this.lbversion.Location = new System.Drawing.Point(354, 0);
            this.lbversion.Name = "lbversion";
            this.lbversion.Size = new System.Drawing.Size(122, 31);
            this.lbversion.TabIndex = 0;
            this.lbversion.Text = "--";
            this.lbversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.ForeColor = System.Drawing.Color.White;
            this.lbtitle.Location = new System.Drawing.Point(16, 8);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(151, 16);
            this.lbtitle.TabIndex = 1;
            this.lbtitle.Text = "PLANTILLA DE CARGA";
            // 
            // PlantillaCargaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(476, 589);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.panelgrafico);
            this.Controls.Add(this.dgvPrimado);
            this.Controls.Add(this.btneliminaatCarguio);
            this.Controls.Add(this.btnagregarCarguio);
            this.Controls.Add(this.tbmasa);
            this.Controls.Add(this.rblongitud);
            this.Controls.Add(this.dgvCarguio);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlantillaCargaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PlantillaCargaView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprofundidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarguio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimado)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtdiametro;
        private System.Windows.Forms.NumericUpDown txtprofundidad;
        public System.Windows.Forms.DataGridView dgvCarguio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.RadioButton rblongitud;
        private System.Windows.Forms.RadioButton tbmasa;
        private System.Windows.Forms.Button btneliminaatCarguio;
        private System.Windows.Forms.Button btnagregarCarguio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbtipotaladro;
        private System.Windows.Forms.DataGridView dgvPrimado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panelgrafico;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Label lbversion;
    }
}