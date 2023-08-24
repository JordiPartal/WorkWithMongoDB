
namespace X_Wing_Simulator
{
    partial class FrmPrincipal
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cmb_items = new System.Windows.Forms.ComboBox();
            this.tlp_tree_view = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_busqueda = new System.Windows.Forms.Label();
            this.tv_registros = new System.Windows.Forms.TreeView();
            this.tlp_info = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlp_tree_view.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.btn_buscar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_items, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1183, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_buscar.Location = new System.Drawing.Point(298, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(112, 34);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.ClickBotonBuscar);
            // 
            // cmb_items
            // 
            this.cmb_items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmb_items.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmb_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_items.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_items.ForeColor = System.Drawing.Color.White;
            this.cmb_items.FormattingEnabled = true;
            this.cmb_items.Location = new System.Drawing.Point(3, 3);
            this.cmb_items.Name = "cmb_items";
            this.cmb_items.Size = new System.Drawing.Size(230, 30);
            this.cmb_items.TabIndex = 0;
            this.cmb_items.SelectedIndexChanged += new System.EventHandler(this.SeleccionItem);
            // 
            // tlp_tree_view
            // 
            this.tlp_tree_view.ColumnCount = 1;
            this.tlp_tree_view.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_tree_view.Controls.Add(this.lbl_busqueda, 0, 0);
            this.tlp_tree_view.Controls.Add(this.tv_registros, 0, 1);
            this.tlp_tree_view.Location = new System.Drawing.Point(12, 59);
            this.tlp_tree_view.Name = "tlp_tree_view";
            this.tlp_tree_view.RowCount = 2;
            this.tlp_tree_view.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_tree_view.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_tree_view.Size = new System.Drawing.Size(415, 649);
            this.tlp_tree_view.TabIndex = 1;
            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busqueda.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_busqueda.Location = new System.Drawing.Point(3, 0);
            this.lbl_busqueda.Name = "lbl_busqueda";
            this.lbl_busqueda.Size = new System.Drawing.Size(408, 64);
            this.lbl_busqueda.TabIndex = 0;
            this.lbl_busqueda.Text = "[OPCION]";
            this.lbl_busqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tv_registros
            // 
            this.tv_registros.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tv_registros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tv_registros.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_registros.ForeColor = System.Drawing.Color.Lime;
            this.tv_registros.Location = new System.Drawing.Point(3, 67);
            this.tv_registros.Name = "tv_registros";
            this.tv_registros.Size = new System.Drawing.Size(409, 579);
            this.tv_registros.TabIndex = 1;
            this.tv_registros.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DespuesDeSeleccion);
            // 
            // tlp_info
            // 
            this.tlp_info.ColumnCount = 1;
            this.tlp_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_info.Location = new System.Drawing.Point(434, 59);
            this.tlp_info.Name = "tlp_info";
            this.tlp_info.RowCount = 1;
            this.tlp_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 650F));
            this.tlp_info.Size = new System.Drawing.Size(760, 650);
            this.tlp_info.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1208, 720);
            this.Controls.Add(this.tlp_info);
            this.Controls.Add(this.tlp_tree_view);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planetas";
            this.Load += new System.EventHandler(this.FrmCarga);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlp_tree_view.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmb_items;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TableLayoutPanel tlp_tree_view;
        private System.Windows.Forms.Label lbl_busqueda;
        private System.Windows.Forms.TreeView tv_registros;
        private System.Windows.Forms.TableLayoutPanel tlp_info;
    }
}

