namespace NextBlast.vistas
{
    partial class importarView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(importarView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbversion = new System.Windows.Forms.Label();
            this.btndeleterow = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.lbetiquetasrepetidas = new System.Windows.Forms.Label();
            this.lbtaladroscortos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.chbxTaladroAdicional = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbversion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 22);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = " IMPORTAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbversion
            // 
            this.lbversion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbversion.ForeColor = System.Drawing.Color.White;
            this.lbversion.Location = new System.Drawing.Point(488, 0);
            this.lbversion.Name = "lbversion";
            this.lbversion.Size = new System.Drawing.Size(143, 22);
            this.lbversion.TabIndex = 1;
            this.lbversion.Text = "Version";
            this.lbversion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btndeleterow
            // 
            this.btndeleterow.BackColor = System.Drawing.Color.White;
            this.btndeleterow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndeleterow.BackgroundImage")));
            this.btndeleterow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndeleterow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeleterow.FlatAppearance.BorderSize = 0;
            this.btndeleterow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btndeleterow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btndeleterow.Location = new System.Drawing.Point(7, 119);
            this.btndeleterow.Name = "btndeleterow";
            this.btndeleterow.Size = new System.Drawing.Size(39, 41);
            this.btndeleterow.TabIndex = 51;
            this.btndeleterow.UseVisualStyleBackColor = false;
            this.btndeleterow.Click += new System.EventHandler(this.btndeleterow_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.White;
            this.btnImportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImportar.BackgroundImage")));
            this.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnImportar.Location = new System.Drawing.Point(7, 72);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(39, 41);
            this.btnImportar.TabIndex = 50;
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // dgvdatos
            // 
            this.dgvdatos.AllowUserToAddRows = false;
            this.dgvdatos.AllowUserToResizeColumns = false;
            this.dgvdatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvdatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvdatos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvdatos.ColumnHeadersHeight = 25;
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvdatos.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvdatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvdatos.GridColor = System.Drawing.Color.LightGray;
            this.dgvdatos.Location = new System.Drawing.Point(60, 72);
            this.dgvdatos.Name = "dgvdatos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvdatos.RowHeadersVisible = false;
            this.dgvdatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvdatos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatos.Size = new System.Drawing.Size(571, 285);
            this.dgvdatos.TabIndex = 53;
            this.dgvdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatos_CellContentClick);
            this.dgvdatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatos_CellValueChanged);
            this.dgvdatos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvdatos_KeyUp);
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.Color.White;
            this.btnaceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaceptar.BackgroundImage")));
            this.btnaceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnaceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaceptar.FlatAppearance.BorderSize = 0;
            this.btnaceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnaceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnaceptar.Location = new System.Drawing.Point(7, 318);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(39, 39);
            this.btnaceptar.TabIndex = 54;
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // lbetiquetasrepetidas
            // 
            this.lbetiquetasrepetidas.AutoSize = true;
            this.lbetiquetasrepetidas.Location = new System.Drawing.Point(49, 370);
            this.lbetiquetasrepetidas.Name = "lbetiquetasrepetidas";
            this.lbetiquetasrepetidas.Size = new System.Drawing.Size(246, 16);
            this.lbetiquetasrepetidas.TabIndex = 55;
            this.lbetiquetasrepetidas.Text = "- Taladros con Etiqueta/Label Repetidos :";
            // 
            // lbtaladroscortos
            // 
            this.lbtaladroscortos.AutoSize = true;
            this.lbtaladroscortos.Location = new System.Drawing.Point(49, 395);
            this.lbtaladroscortos.Name = "lbtaladroscortos";
            this.lbtaladroscortos.Size = new System.Drawing.Size(106, 16);
            this.lbtaladroscortos.TabIndex = 56;
            this.lbtaladroscortos.Text = "- Taladros < 4m :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Color:";
            this.label4.Visible = false;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(208, 35);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(74, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Visible = false;
            // 
            // chbxTaladroAdicional
            // 
            this.chbxTaladroAdicional.AutoSize = true;
            this.chbxTaladroAdicional.Location = new System.Drawing.Point(7, 37);
            this.chbxTaladroAdicional.Name = "chbxTaladroAdicional";
            this.chbxTaladroAdicional.Size = new System.Drawing.Size(145, 20);
            this.chbxTaladroAdicional.TabIndex = 0;
            this.chbxTaladroAdicional.Text = "Taladros Adicionales";
            this.chbxTaladroAdicional.UseVisualStyleBackColor = true;
            // 
            // importarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(631, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lbtaladroscortos);
            this.Controls.Add(this.chbxTaladroAdicional);
            this.Controls.Add(this.lbetiquetasrepetidas);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dgvdatos);
            this.Controls.Add(this.btndeleterow);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "importarView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.importarView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbversion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndeleterow;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label lbetiquetasrepetidas;
        private System.Windows.Forms.Label lbtaladroscortos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.CheckBox chbxTaladroAdicional;
    }
}