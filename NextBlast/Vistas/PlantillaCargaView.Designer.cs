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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantillaCargaView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbtipotaladro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiametro = new System.Windows.Forms.NumericUpDown();
            this.txtprofundidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rblongitud = new System.Windows.Forms.RadioButton();
            this.rbmasa = new System.Windows.Forms.RadioButton();
            this.btneliminaatCarguio = new System.Windows.Forms.Button();
            this.btnagregarCarguio = new System.Windows.Forms.Button();
            this.panelgrafico = new System.Windows.Forms.Panel();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbversion = new System.Windows.Forms.Label();
            this.lbtitle = new System.Windows.Forms.Label();
            this.dgvCarguio = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Explosivo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.calcular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.longitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprofundidad)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarguio)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(9, 44);
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
            this.txtdiametro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdiametro.Value = new decimal(new int[] {
            270,
            0,
            0,
            0});
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
            this.txtprofundidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtprofundidad.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
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
            // rblongitud
            // 
            this.rblongitud.AutoSize = true;
            this.rblongitud.Checked = true;
            this.rblongitud.Location = new System.Drawing.Point(9, 198);
            this.rblongitud.Name = "rblongitud";
            this.rblongitud.Size = new System.Drawing.Size(136, 19);
            this.rblongitud.TabIndex = 2;
            this.rblongitud.TabStop = true;
            this.rblongitud.Text = "Longitud / Unidades";
            this.rblongitud.UseVisualStyleBackColor = true;
            this.rblongitud.CheckedChanged += new System.EventHandler(this.rblongitud_CheckedChanged);
            // 
            // rbmasa
            // 
            this.rbmasa.AutoSize = true;
            this.rbmasa.Location = new System.Drawing.Point(151, 198);
            this.rbmasa.Name = "rbmasa";
            this.rbmasa.Size = new System.Drawing.Size(55, 19);
            this.rbmasa.TabIndex = 3;
            this.rbmasa.Text = "Masa";
            this.rbmasa.UseVisualStyleBackColor = true;
            this.rbmasa.CheckedChanged += new System.EventHandler(this.rbmasa_CheckedChanged);
            // 
            // btneliminaatCarguio
            // 
            this.btneliminaatCarguio.BackColor = System.Drawing.Color.Transparent;
            this.btneliminaatCarguio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminaatCarguio.BackgroundImage")));
            this.btneliminaatCarguio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminaatCarguio.CausesValidation = false;
            this.btneliminaatCarguio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminaatCarguio.FlatAppearance.BorderSize = 0;
            this.btneliminaatCarguio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btneliminaatCarguio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btneliminaatCarguio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminaatCarguio.Location = new System.Drawing.Point(273, 192);
            this.btneliminaatCarguio.Name = "btneliminaatCarguio";
            this.btneliminaatCarguio.Size = new System.Drawing.Size(30, 30);
            this.btneliminaatCarguio.TabIndex = 1;
            this.btneliminaatCarguio.UseVisualStyleBackColor = false;
            this.btneliminaatCarguio.Click += new System.EventHandler(this.btneliminaatCarguio_Click);
            // 
            // btnagregarCarguio
            // 
            this.btnagregarCarguio.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarCarguio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregarCarguio.BackgroundImage")));
            this.btnagregarCarguio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregarCarguio.CausesValidation = false;
            this.btnagregarCarguio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarCarguio.FlatAppearance.BorderSize = 0;
            this.btnagregarCarguio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnagregarCarguio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnagregarCarguio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarCarguio.Location = new System.Drawing.Point(237, 192);
            this.btnagregarCarguio.Name = "btnagregarCarguio";
            this.btnagregarCarguio.Size = new System.Drawing.Size(30, 30);
            this.btnagregarCarguio.TabIndex = 0;
            this.btnagregarCarguio.UseVisualStyleBackColor = false;
            this.btnagregarCarguio.Click += new System.EventHandler(this.btnagregarCarguio_Click);
            // 
            // panelgrafico
            // 
            this.panelgrafico.BackColor = System.Drawing.Color.Silver;
            this.panelgrafico.Location = new System.Drawing.Point(415, 44);
            this.panelgrafico.Name = "panelgrafico";
            this.panelgrafico.Size = new System.Drawing.Size(171, 535);
            this.panelgrafico.TabIndex = 6;
            this.panelgrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.panelgrafico_Paint);
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
            this.btnaceptar.Location = new System.Drawing.Point(9, 552);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(398, 27);
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
            this.panelHeader.Size = new System.Drawing.Size(595, 31);
            this.panelHeader.TabIndex = 63;
            // 
            // lbversion
            // 
            this.lbversion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbversion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbversion.ForeColor = System.Drawing.Color.White;
            this.lbversion.Location = new System.Drawing.Point(473, 0);
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
            // dgvCarguio
            // 
            this.dgvCarguio.AllowUserToAddRows = false;
            this.dgvCarguio.AllowUserToResizeColumns = false;
            this.dgvCarguio.AllowUserToResizeRows = false;
            this.dgvCarguio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarguio.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvCarguio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarguio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarguio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarguio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Explosivo,
            this.calcular,
            this.longitud,
            this.kg});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarguio.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCarguio.Location = new System.Drawing.Point(9, 235);
            this.dgvCarguio.MultiSelect = false;
            this.dgvCarguio.Name = "dgvCarguio";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarguio.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCarguio.RowHeadersVisible = false;
            this.dgvCarguio.Size = new System.Drawing.Size(398, 311);
            this.dgvCarguio.TabIndex = 64;
            this.dgvCarguio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarguio_CellContentClick);
            this.dgvCarguio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCarguio_KeyDown_1);
            this.dgvCarguio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCarguio_KeyUp);
            this.dgvCarguio.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvCarguio_MouseUp);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            // 
            // Explosivo
            // 
            this.Explosivo.FillWeight = 182.7411F;
            this.Explosivo.HeaderText = "Explosivo";
            this.Explosivo.Name = "Explosivo";
            // 
            // calcular
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            this.calcular.DefaultCellStyle = dataGridViewCellStyle2;
            this.calcular.FillWeight = 58.68907F;
            this.calcular.HeaderText = "Calc.";
            this.calcular.Name = "calcular";
            this.calcular.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // longitud
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.longitud.DefaultCellStyle = dataGridViewCellStyle3;
            this.longitud.FillWeight = 79.2849F;
            this.longitud.HeaderText = "Canti.";
            this.longitud.Name = "longitud";
            this.longitud.ReadOnly = true;
            this.longitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kg
            // 
            this.kg.FillWeight = 79.2849F;
            this.kg.HeaderText = "Expl. (kg)";
            this.kg.Name = "kg";
            this.kg.ReadOnly = true;
            this.kg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PlantillaCargaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(595, 589);
            this.Controls.Add(this.dgvCarguio);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.panelgrafico);
            this.Controls.Add(this.btneliminaatCarguio);
            this.Controls.Add(this.btnagregarCarguio);
            this.Controls.Add(this.rbmasa);
            this.Controls.Add(this.rblongitud);
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
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarguio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtdiametro;
        private System.Windows.Forms.NumericUpDown txtprofundidad;
        private System.Windows.Forms.RadioButton rblongitud;
        private System.Windows.Forms.RadioButton rbmasa;
        private System.Windows.Forms.Button btneliminaatCarguio;
        private System.Windows.Forms.Button btnagregarCarguio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbtipotaladro;
        private System.Windows.Forms.Panel panelgrafico;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Label lbversion;
        private System.Windows.Forms.DataGridView dgvCarguio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewComboBoxColumn Explosivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn calcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn kg;
    }
}