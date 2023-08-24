
namespace CC_Planetas
{
    partial class FrmPlaneta
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_principal = new System.Windows.Forms.TableLayoutPanel();
            this.gbx_ubicacion = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_parsecs = new System.Windows.Forms.Label();
            this.lbl_latitud = new System.Windows.Forms.Label();
            this.lbl_longitud = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_sector = new System.Windows.Forms.Label();
            this.gbx_info_general = new System.Windows.Forms.GroupBox();
            this.tlp_info_general = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_alianza = new System.Windows.Forms.Label();
            this.lbl_nativos = new System.Windows.Forms.Label();
            this.lbl_planeta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbx_rutas = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ruta_b = new System.Windows.Forms.Label();
            this.lbl_ruta_a = new System.Windows.Forms.Label();
            this.pic_planeta = new System.Windows.Forms.PictureBox();
            this.tlp_principal.SuspendLayout();
            this.gbx_ubicacion.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbx_info_general.SuspendLayout();
            this.tlp_info_general.SuspendLayout();
            this.gbx_rutas.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_planeta)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_principal
            // 
            this.tlp_principal.ColumnCount = 2;
            this.tlp_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_principal.Controls.Add(this.gbx_ubicacion, 1, 0);
            this.tlp_principal.Controls.Add(this.gbx_info_general, 0, 0);
            this.tlp_principal.Controls.Add(this.gbx_rutas, 0, 1);
            this.tlp_principal.Controls.Add(this.pic_planeta, 0, 2);
            this.tlp_principal.Location = new System.Drawing.Point(4, 4);
            this.tlp_principal.Name = "tlp_principal";
            this.tlp_principal.RowCount = 3;
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_principal.Size = new System.Drawing.Size(753, 643);
            this.tlp_principal.TabIndex = 0;
            // 
            // gbx_ubicacion
            // 
            this.gbx_ubicacion.Controls.Add(this.tableLayoutPanel1);
            this.gbx_ubicacion.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_ubicacion.ForeColor = System.Drawing.Color.Lime;
            this.gbx_ubicacion.Location = new System.Drawing.Point(379, 3);
            this.gbx_ubicacion.Name = "gbx_ubicacion";
            this.gbx_ubicacion.Size = new System.Drawing.Size(370, 154);
            this.gbx_ubicacion.TabIndex = 1;
            this.gbx_ubicacion.TabStop = false;
            this.gbx_ubicacion.Text = "Ubicación";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_parsecs, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_latitud, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_longitud, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_sector, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 122);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(3, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 30);
            this.label10.TabIndex = 6;
            this.label10.Text = "Sector:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_parsecs
            // 
            this.lbl_parsecs.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parsecs.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_parsecs.Location = new System.Drawing.Point(110, 60);
            this.lbl_parsecs.Name = "lbl_parsecs";
            this.lbl_parsecs.Size = new System.Drawing.Size(245, 30);
            this.lbl_parsecs.TabIndex = 5;
            this.lbl_parsecs.Text = "[PARSECS]";
            this.lbl_parsecs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_latitud
            // 
            this.lbl_latitud.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_latitud.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_latitud.Location = new System.Drawing.Point(110, 30);
            this.lbl_latitud.Name = "lbl_latitud";
            this.lbl_latitud.Size = new System.Drawing.Size(245, 30);
            this.lbl_latitud.TabIndex = 4;
            this.lbl_latitud.Text = "[LATITUD]";
            this.lbl_latitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_longitud
            // 
            this.lbl_longitud.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_longitud.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_longitud.Location = new System.Drawing.Point(110, 0);
            this.lbl_longitud.Name = "lbl_longitud";
            this.lbl_longitud.Size = new System.Drawing.Size(245, 30);
            this.lbl_longitud.TabIndex = 3;
            this.lbl_longitud.Text = "[LONGITUD]";
            this.lbl_longitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Longitud:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(3, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "Latitud:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(3, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "Parsecs:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_sector
            // 
            this.lbl_sector.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sector.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_sector.Location = new System.Drawing.Point(110, 90);
            this.lbl_sector.Name = "lbl_sector";
            this.lbl_sector.Size = new System.Drawing.Size(245, 30);
            this.lbl_sector.TabIndex = 7;
            this.lbl_sector.Text = "[SECTOR]";
            this.lbl_sector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbx_info_general
            // 
            this.gbx_info_general.Controls.Add(this.tlp_info_general);
            this.gbx_info_general.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_info_general.ForeColor = System.Drawing.Color.Lime;
            this.gbx_info_general.Location = new System.Drawing.Point(3, 3);
            this.gbx_info_general.Name = "gbx_info_general";
            this.gbx_info_general.Size = new System.Drawing.Size(370, 154);
            this.gbx_info_general.TabIndex = 0;
            this.gbx_info_general.TabStop = false;
            this.gbx_info_general.Text = "Inf. General";
            // 
            // tlp_info_general
            // 
            this.tlp_info_general.ColumnCount = 2;
            this.tlp_info_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_info_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_info_general.Controls.Add(this.lbl_alianza, 1, 2);
            this.tlp_info_general.Controls.Add(this.lbl_nativos, 1, 1);
            this.tlp_info_general.Controls.Add(this.lbl_planeta, 1, 0);
            this.tlp_info_general.Controls.Add(this.label1, 0, 0);
            this.tlp_info_general.Controls.Add(this.label2, 0, 1);
            this.tlp_info_general.Controls.Add(this.label3, 0, 2);
            this.tlp_info_general.Location = new System.Drawing.Point(6, 26);
            this.tlp_info_general.Name = "tlp_info_general";
            this.tlp_info_general.RowCount = 4;
            this.tlp_info_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_info_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_info_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_info_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_info_general.Size = new System.Drawing.Size(358, 122);
            this.tlp_info_general.TabIndex = 0;
            // 
            // lbl_alianza
            // 
            this.lbl_alianza.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alianza.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_alianza.Location = new System.Drawing.Point(110, 60);
            this.lbl_alianza.Name = "lbl_alianza";
            this.lbl_alianza.Size = new System.Drawing.Size(245, 30);
            this.lbl_alianza.TabIndex = 5;
            this.lbl_alianza.Text = "[ALIANZA]";
            this.lbl_alianza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_nativos
            // 
            this.lbl_nativos.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nativos.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_nativos.Location = new System.Drawing.Point(110, 30);
            this.lbl_nativos.Name = "lbl_nativos";
            this.lbl_nativos.Size = new System.Drawing.Size(245, 30);
            this.lbl_nativos.TabIndex = 4;
            this.lbl_nativos.Text = "[NATIVOS]";
            this.lbl_nativos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_planeta
            // 
            this.lbl_planeta.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_planeta.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_planeta.Location = new System.Drawing.Point(110, 0);
            this.lbl_planeta.Name = "lbl_planeta";
            this.lbl_planeta.Size = new System.Drawing.Size(245, 30);
            this.lbl_planeta.TabIndex = 3;
            this.lbl_planeta.Text = "[NOMBRE PLANETA]";
            this.lbl_planeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planeta:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nativos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alianza:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbx_rutas
            // 
            this.tlp_principal.SetColumnSpan(this.gbx_rutas, 2);
            this.gbx_rutas.Controls.Add(this.tableLayoutPanel2);
            this.gbx_rutas.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_rutas.ForeColor = System.Drawing.Color.Lime;
            this.gbx_rutas.Location = new System.Drawing.Point(3, 163);
            this.gbx_rutas.Name = "gbx_rutas";
            this.gbx_rutas.Size = new System.Drawing.Size(747, 90);
            this.gbx_rutas.TabIndex = 2;
            this.gbx_rutas.TabStop = false;
            this.gbx_rutas.Text = "Rutas Hiperespacio";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_ruta_b, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_ruta_a, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(731, 55);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbl_ruta_b
            // 
            this.lbl_ruta_b.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ruta_b.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_ruta_b.Location = new System.Drawing.Point(3, 27);
            this.lbl_ruta_b.Name = "lbl_ruta_b";
            this.lbl_ruta_b.Size = new System.Drawing.Size(725, 27);
            this.lbl_ruta_b.TabIndex = 6;
            this.lbl_ruta_b.Text = "[RUTA B]";
            this.lbl_ruta_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ruta_a
            // 
            this.lbl_ruta_a.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ruta_a.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_ruta_a.Location = new System.Drawing.Point(3, 0);
            this.lbl_ruta_a.Name = "lbl_ruta_a";
            this.lbl_ruta_a.Size = new System.Drawing.Size(725, 27);
            this.lbl_ruta_a.TabIndex = 5;
            this.lbl_ruta_a.Text = "[RUTA A]";
            this.lbl_ruta_a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_planeta
            // 
            this.tlp_principal.SetColumnSpan(this.pic_planeta, 2);
            this.pic_planeta.Location = new System.Drawing.Point(3, 259);
            this.pic_planeta.Name = "pic_planeta";
            this.pic_planeta.Size = new System.Drawing.Size(747, 381);
            this.pic_planeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_planeta.TabIndex = 3;
            this.pic_planeta.TabStop = false;
            // 
            // FrmPlaneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Controls.Add(this.tlp_principal);
            this.Name = "FrmPlaneta";
            this.Size = new System.Drawing.Size(760, 650);
            this.tlp_principal.ResumeLayout(false);
            this.gbx_ubicacion.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbx_info_general.ResumeLayout(false);
            this.tlp_info_general.ResumeLayout(false);
            this.gbx_rutas.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_planeta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_principal;
        private System.Windows.Forms.GroupBox gbx_ubicacion;
        private System.Windows.Forms.GroupBox gbx_info_general;
        private System.Windows.Forms.TableLayoutPanel tlp_info_general;
        private System.Windows.Forms.GroupBox gbx_rutas;
        private System.Windows.Forms.PictureBox pic_planeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_alianza;
        private System.Windows.Forms.Label lbl_nativos;
        private System.Windows.Forms.Label lbl_planeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_parsecs;
        private System.Windows.Forms.Label lbl_latitud;
        private System.Windows.Forms.Label lbl_longitud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_sector;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_ruta_a;
        private System.Windows.Forms.Label lbl_ruta_b;
    }
}
