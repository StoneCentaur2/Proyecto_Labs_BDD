namespace Proyecto_Labs_BDD
{
    partial class Solicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solicitud));
            this.btn_Agg = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_agg_Usuario = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbx_Solicitud = new System.Windows.Forms.TextBox();
            this.cmbx_Docente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Agg
            // 
            this.btn_Agg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Agg.BackgroundImage")));
            this.btn_Agg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Agg.Location = new System.Drawing.Point(881, 448);
            this.btn_Agg.Name = "btn_Agg";
            this.btn_Agg.Size = new System.Drawing.Size(80, 76);
            this.btn_Agg.TabIndex = 0;
            this.btn_Agg.UseVisualStyleBackColor = true;
            this.btn_Agg.Click += new System.EventHandler(this.btn_Agg_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Home.BackgroundImage")));
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Home.Location = new System.Drawing.Point(977, 448);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(80, 76);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_agg_Usuario
            // 
            this.btn_agg_Usuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agg_Usuario.BackgroundImage")));
            this.btn_agg_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agg_Usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agg_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agg_Usuario.Location = new System.Drawing.Point(690, 448);
            this.btn_agg_Usuario.Name = "btn_agg_Usuario";
            this.btn_agg_Usuario.Size = new System.Drawing.Size(80, 76);
            this.btn_agg_Usuario.TabIndex = 2;
            this.btn_agg_Usuario.UseVisualStyleBackColor = true;
            this.btn_agg_Usuario.Visible = false;
            this.btn_agg_Usuario.Click += new System.EventHandler(this.btn_agg_Usuario_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 324);
            this.dataGridView1.TabIndex = 4;
            // 
            // tbx_Solicitud
            // 
            this.tbx_Solicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Solicitud.Location = new System.Drawing.Point(23, 56);
            this.tbx_Solicitud.Name = "tbx_Solicitud";
            this.tbx_Solicitud.Size = new System.Drawing.Size(277, 30);
            this.tbx_Solicitud.TabIndex = 5;
            // 
            // cmbx_Docente
            // 
            this.cmbx_Docente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Docente.FormattingEnabled = true;
            this.cmbx_Docente.Location = new System.Drawing.Point(315, 54);
            this.cmbx_Docente.Name = "cmbx_Docente";
            this.cmbx_Docente.Size = new System.Drawing.Size(378, 33);
            this.cmbx_Docente.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Herramienta a solicitar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(310, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Docente encargado";
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Borrar.BackgroundImage")));
            this.btn_Borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Borrar.Location = new System.Drawing.Point(785, 448);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(80, 76);
            this.btn_Borrar.TabIndex = 9;
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(801, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1069, 536);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbx_Docente);
            this.Controls.Add(this.tbx_Solicitud);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_agg_Usuario);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_Agg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Solicitud";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud";
            this.Load += new System.EventHandler(this.Solicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agg;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_agg_Usuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbx_Solicitud;
        private System.Windows.Forms.ComboBox cmbx_Docente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}