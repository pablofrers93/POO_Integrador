
namespace POO_Integrador.WINDOWS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraHerramientasToolStrip = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ActualizarToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.CantidadRegistrosLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarraHerramientasToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraHerramientasToolStrip
            // 
            this.BarraHerramientasToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton1,
            this.BorrarToolStripButton2,
            this.EditarToolStripButton3,
            this.ActualizarToolStripButton5,
            this.toolStripSeparator2,
            this.SalirToolStripButton6});
            this.BarraHerramientasToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientasToolStrip.Name = "BarraHerramientasToolStrip";
            this.BarraHerramientasToolStrip.Size = new System.Drawing.Size(904, 38);
            this.BarraHerramientasToolStrip.TabIndex = 0;
            this.BarraHerramientasToolStrip.Text = "toolStrip1";
            // 
            // NuevoToolStripButton1
            // 
            this.NuevoToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("NuevoToolStripButton1.Image")));
            this.NuevoToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton1.Name = "NuevoToolStripButton1";
            this.NuevoToolStripButton1.Size = new System.Drawing.Size(46, 35);
            this.NuevoToolStripButton1.Text = "Nuevo";
            this.NuevoToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton1.Click += new System.EventHandler(this.NuevoToolStripButton1_Click);
            // 
            // BorrarToolStripButton2
            // 
            this.BorrarToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("BorrarToolStripButton2.Image")));
            this.BorrarToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton2.Name = "BorrarToolStripButton2";
            this.BorrarToolStripButton2.Size = new System.Drawing.Size(43, 35);
            this.BorrarToolStripButton2.Text = "Borrar";
            this.BorrarToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton2.Click += new System.EventHandler(this.BorrarToolStripButton2_Click);
            // 
            // EditarToolStripButton3
            // 
            this.EditarToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("EditarToolStripButton3.Image")));
            this.EditarToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton3.Name = "EditarToolStripButton3";
            this.EditarToolStripButton3.Size = new System.Drawing.Size(41, 35);
            this.EditarToolStripButton3.Text = "Editar";
            this.EditarToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton3.Click += new System.EventHandler(this.EditarToolStripButton3_Click);
            // 
            // ActualizarToolStripButton5
            // 
            this.ActualizarToolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("ActualizarToolStripButton5.Image")));
            this.ActualizarToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarToolStripButton5.Name = "ActualizarToolStripButton5";
            this.ActualizarToolStripButton5.Size = new System.Drawing.Size(63, 35);
            this.ActualizarToolStripButton5.Text = "Actualizar";
            this.ActualizarToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ActualizarToolStripButton5.Click += new System.EventHandler(this.ActualizarToolStripButton5_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // SalirToolStripButton6
            // 
            this.SalirToolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("SalirToolStripButton6.Image")));
            this.SalirToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton6.Name = "SalirToolStripButton6";
            this.SalirToolStripButton6.Size = new System.Drawing.Size(33, 35);
            this.SalirToolStripButton6.Text = "Salir";
            this.SalirToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton6.Click += new System.EventHandler(this.SalirToolStripButton6_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatosDataGridView);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CantidadRegistrosLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(904, 412);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.AllowUserToOrderColumns = true;
            this.DatosDataGridView.AllowUserToResizeColumns = false;
            this.DatosDataGridView.AllowUserToResizeRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColEditorial,
            this.ColTema,
            this.ColPaginas,
            this.ColISBN,
            this.ColAutor});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(904, 266);
            this.DatosDataGridView.TabIndex = 0;
            this.DatosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CantidadRegistrosLabel
            // 
            this.CantidadRegistrosLabel.AutoSize = true;
            this.CantidadRegistrosLabel.Location = new System.Drawing.Point(139, 18);
            this.CantidadRegistrosLabel.Name = "CantidadRegistrosLabel";
            this.CantidadRegistrosLabel.Size = new System.Drawing.Size(13, 13);
            this.CantidadRegistrosLabel.TabIndex = 1;
            this.CantidadRegistrosLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Registros";
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 200;
            // 
            // ColEditorial
            // 
            this.ColEditorial.HeaderText = "Editorial";
            this.ColEditorial.Name = "ColEditorial";
            this.ColEditorial.ReadOnly = true;
            // 
            // ColTema
            // 
            this.ColTema.HeaderText = "Tema";
            this.ColTema.Name = "ColTema";
            this.ColTema.ReadOnly = true;
            // 
            // ColPaginas
            // 
            this.ColPaginas.HeaderText = "Paginas";
            this.ColPaginas.Name = "ColPaginas";
            this.ColPaginas.ReadOnly = true;
            // 
            // ColISBN
            // 
            this.ColISBN.HeaderText = "ISBN";
            this.ColISBN.Name = "ColISBN";
            this.ColISBN.ReadOnly = true;
            // 
            // ColAutor
            // 
            this.ColAutor.HeaderText = "Autor";
            this.ColAutor.Name = "ColAutor";
            this.ColAutor.ReadOnly = true;
            this.ColAutor.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.BarraHerramientasToolStrip);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca de Libros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraHerramientasToolStrip.ResumeLayout(false);
            this.BarraHerramientasToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraHerramientasToolStrip;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton1;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton2;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton3;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Label CantidadRegistrosLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTema;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAutor;
    }
}

