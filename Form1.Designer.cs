namespace MikeFinalProyect
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
            this.label1 = new System.Windows.Forms.Label();
            this.pcbEliminar = new System.Windows.Forms.PictureBox();
            this.pcbAñadir = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbEditar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPoder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFraseFav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVestimenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLatitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLongitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAñadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(755, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar Personaje";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pcbEliminar
            // 
            this.pcbEliminar.Image = global::MikeFinalProyect.Properties.Resources.ssj_dios_vegeta;
            this.pcbEliminar.Location = new System.Drawing.Point(786, 315);
            this.pcbEliminar.Name = "pcbEliminar";
            this.pcbEliminar.Size = new System.Drawing.Size(70, 70);
            this.pcbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEliminar.TabIndex = 2;
            this.pcbEliminar.TabStop = false;
            // 
            // pcbAñadir
            // 
            this.pcbAñadir.Image = global::MikeFinalProyect.Properties.Resources._365_3659689_goku_thumbs_up_png_transparent_png;
            this.pcbAñadir.Location = new System.Drawing.Point(786, 37);
            this.pcbAñadir.Name = "pcbAñadir";
            this.pcbAñadir.Size = new System.Drawing.Size(70, 70);
            this.pcbAñadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAñadir.TabIndex = 0;
            this.pcbAñadir.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(755, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eliminar personaje";
            // 
            // pcbEditar
            // 
            this.pcbEditar.Image = global::MikeFinalProyect.Properties.Resources.download;
            this.pcbEditar.Location = new System.Drawing.Point(786, 172);
            this.pcbEditar.Name = "pcbEditar";
            this.pcbEditar.Size = new System.Drawing.Size(70, 70);
            this.pcbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEditar.TabIndex = 4;
            this.pcbEditar.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(755, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Editar Personaje";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNombre,
            this.ColumnSerie,
            this.ColumnPoder,
            this.ColumnFraseFav,
            this.ColumnVestimenta,
            this.ColumnAltura,
            this.ColumnSexo,
            this.ColumnEstado,
            this.ColumnDireccion,
            this.ColumnLatitud,
            this.ColumnLongitud});
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 282);
            this.dataGridView1.TabIndex = 6;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnSerie
            // 
            this.ColumnSerie.HeaderText = "Serie";
            this.ColumnSerie.Name = "ColumnSerie";
            // 
            // ColumnPoder
            // 
            this.ColumnPoder.HeaderText = "Poder";
            this.ColumnPoder.Name = "ColumnPoder";
            // 
            // ColumnFraseFav
            // 
            this.ColumnFraseFav.HeaderText = "FraseFav";
            this.ColumnFraseFav.Name = "ColumnFraseFav";
            // 
            // ColumnVestimenta
            // 
            this.ColumnVestimenta.HeaderText = "Vestimenta";
            this.ColumnVestimenta.Name = "ColumnVestimenta";
            // 
            // ColumnAltura
            // 
            this.ColumnAltura.HeaderText = "Altura";
            this.ColumnAltura.Name = "ColumnAltura";
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Name = "ColumnEstado";
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.HeaderText = "Direccion";
            this.ColumnDireccion.Name = "ColumnDireccion";
            // 
            // ColumnLatitud
            // 
            this.ColumnLatitud.HeaderText = "Latitud";
            this.ColumnLatitud.Name = "ColumnLatitud";
            // 
            // ColumnLongitud
            // 
            this.ColumnLongitud.HeaderText = "Longitud";
            this.ColumnLongitud.Name = "ColumnLongitud";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MikeFinalProyect.Properties.Resources.Screenshot_1;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcbEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbAñadir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAñadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbAñadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPoder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFraseFav;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVestimenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLatitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLongitud;
    }
}

