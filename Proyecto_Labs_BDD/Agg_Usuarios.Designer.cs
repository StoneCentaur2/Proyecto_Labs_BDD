namespace Proyecto_Labs_BDD
{
    partial class Agg_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agg_Usuarios));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_SearchUsers = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_ModUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Docente = new System.Windows.Forms.ComboBox();
            this.cmb_Encargado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Nom = new System.Windows.Forms.TextBox();
            this.tbx_Contraseña = new System.Windows.Forms.TextBox();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.btn_Eliminar_text = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmb_DocentePres = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_NamePres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_DescrPres = new System.Windows.Forms.TextBox();
            this.tbx_IDPres = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btn_Devuelto = new System.Windows.Forms.Button();
            this.btn_SearchPrestamo = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.tbx_HerraInvent = new System.Windows.Forms.TextBox();
            this.tbx_CantInvent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbx_MarcaInvent = new System.Windows.Forms.TextBox();
            this.tbx_ModeloInvent = new System.Windows.Forms.TextBox();
            this.tbx_SerieInvent = new System.Windows.Forms.TextBox();
            this.btn_Inven = new System.Windows.Forms.Button();
            this.btn_deleteInvent = new System.Windows.Forms.Button();
            this.btn_ModInvent = new System.Windows.Forms.Button();
            this.btn_ClearInvent = new System.Windows.Forms.Button();
            this.btn_AggInvent = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1103, 550);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_SearchUsers);
            this.tabPage1.Controls.Add(this.btn_DeleteUser);
            this.tabPage1.Controls.Add(this.btn_ModUser);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmb_Docente);
            this.tabPage1.Controls.Add(this.cmb_Encargado);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbx_Nom);
            this.tabPage1.Controls.Add(this.tbx_Contraseña);
            this.tabPage1.Controls.Add(this.tbx_ID);
            this.tabPage1.Controls.Add(this.btn_Eliminar_text);
            this.tabPage1.Controls.Add(this.btn_AddUser);
            this.tabPage1.Controls.Add(this.dgvUsuarios);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1095, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_SearchUsers
            // 
            this.btn_SearchUsers.BackgroundImage = global::Proyecto_Labs_BDD.Properties.Resources.buscar_alt;
            this.btn_SearchUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SearchUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SearchUsers.Location = new System.Drawing.Point(627, 430);
            this.btn_SearchUsers.Name = "btn_SearchUsers";
            this.btn_SearchUsers.Size = new System.Drawing.Size(80, 76);
            this.btn_SearchUsers.TabIndex = 23;
            this.btn_SearchUsers.UseVisualStyleBackColor = true;
            this.btn_SearchUsers.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.BackgroundImage = global::Proyecto_Labs_BDD.Properties.Resources.basura;
            this.btn_DeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeleteUser.Location = new System.Drawing.Point(817, 430);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(80, 76);
            this.btn_DeleteUser.TabIndex = 22;
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_EliminateUser_Click);
            // 
            // btn_ModUser
            // 
            this.btn_ModUser.BackgroundImage = global::Proyecto_Labs_BDD.Properties.Resources.lapiz;
            this.btn_ModUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ModUser.Location = new System.Drawing.Point(907, 430);
            this.btn_ModUser.Name = "btn_ModUser";
            this.btn_ModUser.Size = new System.Drawing.Size(80, 76);
            this.btn_ModUser.TabIndex = 21;
            this.btn_ModUser.UseVisualStyleBackColor = true;
            this.btn_ModUser.Click += new System.EventHandler(this.btn_ModUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(948, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 58);
            this.label7.TabIndex = 20;
            this.label7.Text = "1 = sí\r\n0 = no";
            // 
            // cmb_Docente
            // 
            this.cmb_Docente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Docente.FormattingEnabled = true;
            this.cmb_Docente.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cmb_Docente.Location = new System.Drawing.Point(827, 56);
            this.cmb_Docente.Name = "cmb_Docente";
            this.cmb_Docente.Size = new System.Drawing.Size(98, 33);
            this.cmb_Docente.TabIndex = 19;
            // 
            // cmb_Encargado
            // 
            this.cmb_Encargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Encargado.FormattingEnabled = true;
            this.cmb_Encargado.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cmb_Encargado.Location = new System.Drawing.Point(686, 56);
            this.cmb_Encargado.Name = "cmb_Encargado";
            this.cmb_Encargado.Size = new System.Drawing.Size(103, 33);
            this.cmb_Encargado.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(822, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Docente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(681, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Encargado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // tbx_Nom
            // 
            this.tbx_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Nom.Location = new System.Drawing.Point(348, 56);
            this.tbx_Nom.Name = "tbx_Nom";
            this.tbx_Nom.Size = new System.Drawing.Size(319, 30);
            this.tbx_Nom.TabIndex = 8;
            // 
            // tbx_Contraseña
            // 
            this.tbx_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Contraseña.Location = new System.Drawing.Point(151, 56);
            this.tbx_Contraseña.Name = "tbx_Contraseña";
            this.tbx_Contraseña.Size = new System.Drawing.Size(165, 30);
            this.tbx_Contraseña.TabIndex = 6;
            // 
            // tbx_ID
            // 
            this.tbx_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_ID.Location = new System.Drawing.Point(7, 56);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.Size = new System.Drawing.Size(123, 30);
            this.tbx_ID.TabIndex = 5;
            // 
            // btn_Eliminar_text
            // 
            this.btn_Eliminar_text.BackgroundImage = global::Proyecto_Labs_BDD.Properties.Resources.circulo_cruzado;
            this.btn_Eliminar_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar_text.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Eliminar_text.Location = new System.Drawing.Point(997, 430);
            this.btn_Eliminar_text.Name = "btn_Eliminar_text";
            this.btn_Eliminar_text.Size = new System.Drawing.Size(80, 76);
            this.btn_Eliminar_text.TabIndex = 2;
            this.btn_Eliminar_text.UseVisualStyleBackColor = true;
            this.btn_Eliminar_text.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.BackgroundImage = global::Proyecto_Labs_BDD.Properties.Resources.agregar_usuario;
            this.btn_AddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddUser.Location = new System.Drawing.Point(722, 430);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(80, 76);
            this.btn_AddUser.TabIndex = 1;
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(7, 109);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(1069, 304);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmb_DocentePres);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbx_NamePres);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbx_DescrPres);
            this.tabPage2.Controls.Add(this.tbx_IDPres);
            this.tabPage2.Controls.Add(this.Descripcion);
            this.tabPage2.Controls.Add(this.dgvPrestamos);
            this.tabPage2.Controls.Add(this.btn_Devuelto);
            this.tabPage2.Controls.Add(this.btn_SearchPrestamo);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1095, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Prestamos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmb_DocentePres
            // 
            this.cmb_DocentePres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DocentePres.FormattingEnabled = true;
            this.cmb_DocentePres.Location = new System.Drawing.Point(783, 49);
            this.cmb_DocentePres.Name = "cmb_DocentePres";
            this.cmb_DocentePres.Size = new System.Drawing.Size(289, 33);
            this.cmb_DocentePres.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(778, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "Docente encargado";
            // 
            // tbx_NamePres
            // 
            this.tbx_NamePres.Location = new System.Drawing.Point(488, 52);
            this.tbx_NamePres.Name = "tbx_NamePres";
            this.tbx_NamePres.Size = new System.Drawing.Size(258, 30);
            this.tbx_NamePres.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nombre al prestado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID ";
            // 
            // tbx_DescrPres
            // 
            this.tbx_DescrPres.Location = new System.Drawing.Point(140, 52);
            this.tbx_DescrPres.Name = "tbx_DescrPres";
            this.tbx_DescrPres.Size = new System.Drawing.Size(320, 30);
            this.tbx_DescrPres.TabIndex = 28;
            // 
            // tbx_IDPres
            // 
            this.tbx_IDPres.Location = new System.Drawing.Point(7, 52);
            this.tbx_IDPres.Name = "tbx_IDPres";
            this.tbx_IDPres.Size = new System.Drawing.Size(104, 30);
            this.tbx_IDPres.TabIndex = 27;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(135, 15);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(179, 25);
            this.Descripcion.TabIndex = 26;
            this.Descripcion.Text = "Nombre del articulo";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(7, 100);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.Size = new System.Drawing.Size(1065, 333);
            this.dgvPrestamos.TabIndex = 0;
            // 
            // btn_Devuelto
            // 
            this.btn_Devuelto.BackgroundImage = global::Proyecto_Labs_BDD.Properties.Resources.descargar__1_;
            this.btn_Devuelto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Devuelto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Devuelto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Devuelto.Location = new System.Drawing.Point(980, 439);
            this.btn_Devuelto.Name = "btn_Devuelto";
            this.btn_Devuelto.Size = new System.Drawing.Size(80, 76);
            this.btn_Devuelto.TabIndex = 25;
            this.btn_Devuelto.UseVisualStyleBackColor = true;
            this.btn_Devuelto.Click += new System.EventHandler(this.btn_Devuelto_Click);
            // 
            // btn_SearchPrestamo
            // 
            this.btn_SearchPrestamo.BackgroundImage = global::Proyecto_Labs_BDD.Properties.Resources.buscar_alt;
            this.btn_SearchPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SearchPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SearchPrestamo.Location = new System.Drawing.Point(877, 439);
            this.btn_SearchPrestamo.Name = "btn_SearchPrestamo";
            this.btn_SearchPrestamo.Size = new System.Drawing.Size(80, 76);
            this.btn_SearchPrestamo.TabIndex = 24;
            this.btn_SearchPrestamo.UseVisualStyleBackColor = true;
            this.btn_SearchPrestamo.Click += new System.EventHandler(this.btn_SearchPrestamo_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_Inven);
            this.tabPage3.Controls.Add(this.btn_deleteInvent);
            this.tabPage3.Controls.Add(this.btn_ModInvent);
            this.tabPage3.Controls.Add(this.btn_ClearInvent);
            this.tabPage3.Controls.Add(this.btn_AggInvent);
            this.tabPage3.Controls.Add(this.tbx_SerieInvent);
            this.tabPage3.Controls.Add(this.tbx_ModeloInvent);
            this.tabPage3.Controls.Add(this.tbx_MarcaInvent);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tbx_CantInvent);
            this.tabPage3.Controls.Add(this.tbx_HerraInvent);
            this.tabPage3.Controls.Add(this.dgvInventario);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1095, 521);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inventario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(7, 82);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(1082, 351);
            this.dgvInventario.TabIndex = 0;
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Regresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Regresar.BackgroundImage")));
            this.btn_Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Regresar.Location = new System.Drawing.Point(892, -1);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(75, 61);
            this.btn_Regresar.TabIndex = 3;
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Home.BackgroundImage")));
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Home.Location = new System.Drawing.Point(986, -1);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(77, 61);
            this.btn_Home.TabIndex = 15;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // tbx_HerraInvent
            // 
            this.tbx_HerraInvent.Location = new System.Drawing.Point(11, 42);
            this.tbx_HerraInvent.Name = "tbx_HerraInvent";
            this.tbx_HerraInvent.Size = new System.Drawing.Size(293, 30);
            this.tbx_HerraInvent.TabIndex = 2;
            // 
            // tbx_CantInvent
            // 
            this.tbx_CantInvent.Location = new System.Drawing.Point(320, 42);
            this.tbx_CantInvent.Name = "tbx_CantInvent";
            this.tbx_CantInvent.Size = new System.Drawing.Size(99, 30);
            this.tbx_CantInvent.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Herramienta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(320, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "Cantidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(434, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 25);
            this.label13.TabIndex = 6;
            this.label13.Text = "Marca";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(660, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 25);
            this.label14.TabIndex = 7;
            this.label14.Text = "Modelo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(898, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 25);
            this.label15.TabIndex = 8;
            this.label15.Text = "Serie";
            // 
            // tbx_MarcaInvent
            // 
            this.tbx_MarcaInvent.Location = new System.Drawing.Point(439, 42);
            this.tbx_MarcaInvent.Name = "tbx_MarcaInvent";
            this.tbx_MarcaInvent.Size = new System.Drawing.Size(206, 30);
            this.tbx_MarcaInvent.TabIndex = 9;
            // 
            // tbx_ModeloInvent
            // 
            this.tbx_ModeloInvent.Location = new System.Drawing.Point(665, 42);
            this.tbx_ModeloInvent.Name = "tbx_ModeloInvent";
            this.tbx_ModeloInvent.Size = new System.Drawing.Size(211, 30);
            this.tbx_ModeloInvent.TabIndex = 10;
            // 
            // tbx_SerieInvent
            // 
            this.tbx_SerieInvent.Location = new System.Drawing.Point(903, 42);
            this.tbx_SerieInvent.Name = "tbx_SerieInvent";
            this.tbx_SerieInvent.Size = new System.Drawing.Size(182, 30);
            this.tbx_SerieInvent.TabIndex = 11;
            // 
            // btn_Inven
            // 
            this.btn_Inven.BackgroundImage = global::Proyecto_Labs_BDD.Properties.Resources.buscar_alt;
            this.btn_Inven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Inven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Inven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Inven.Location = new System.Drawing.Point(637, 439);
            this.btn_Inven.Name = "btn_Inven";
            this.btn_Inven.Size = new System.Drawing.Size(80, 76);
            this.btn_Inven.TabIndex = 28;
            this.btn_Inven.UseVisualStyleBackColor = true;
            this.btn_Inven.Click += new System.EventHandler(this.btn_Inven_Click);
            // 
            // btn_deleteInvent
            // 
            this.btn_deleteInvent.BackgroundImage = global::Proyecto_Labs_BDD.Properties.Resources.basura;
            this.btn_deleteInvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deleteInvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteInvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deleteInvent.Location = new System.Drawing.Point(827, 439);
            this.btn_deleteInvent.Name = "btn_deleteInvent";
            this.btn_deleteInvent.Size = new System.Drawing.Size(80, 76);
            this.btn_deleteInvent.TabIndex = 27;
            this.btn_deleteInvent.UseVisualStyleBackColor = true;
            // 
            // btn_ModInvent
            // 
            this.btn_ModInvent.BackgroundImage = global::Proyecto_Labs_BDD.Properties.Resources.lapiz;
            this.btn_ModInvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModInvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModInvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ModInvent.Location = new System.Drawing.Point(917, 439);
            this.btn_ModInvent.Name = "btn_ModInvent";
            this.btn_ModInvent.Size = new System.Drawing.Size(80, 76);
            this.btn_ModInvent.TabIndex = 26;
            this.btn_ModInvent.UseVisualStyleBackColor = true;
            // 
            // btn_ClearInvent
            // 
            this.btn_ClearInvent.BackgroundImage = global::Proyecto_Labs_BDD.Properties.Resources.circulo_cruzado;
            this.btn_ClearInvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ClearInvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClearInvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClearInvent.Location = new System.Drawing.Point(1007, 439);
            this.btn_ClearInvent.Name = "btn_ClearInvent";
            this.btn_ClearInvent.Size = new System.Drawing.Size(80, 76);
            this.btn_ClearInvent.TabIndex = 25;
            this.btn_ClearInvent.UseVisualStyleBackColor = true;
            this.btn_ClearInvent.Click += new System.EventHandler(this.btn_ClearInvent_Click);
            // 
            // btn_AggInvent
            // 
            this.btn_AggInvent.BackgroundImage = global::Proyecto_Labs_BDD.Properties.Resources.agregar_usuario;
            this.btn_AggInvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AggInvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AggInvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AggInvent.Location = new System.Drawing.Point(732, 439);
            this.btn_AggInvent.Name = "btn_AggInvent";
            this.btn_AggInvent.Size = new System.Drawing.Size(80, 76);
            this.btn_AggInvent.TabIndex = 24;
            this.btn_AggInvent.UseVisualStyleBackColor = true;
            // 
            // Agg_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1128, 612);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agg_Usuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agg_Usuarios";
            this.Load += new System.EventHandler(this.Agg_Usuarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Button btn_Eliminar_text;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Nom;
        private System.Windows.Forms.TextBox tbx_Contraseña;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Docente;
        private System.Windows.Forms.ComboBox cmb_Encargado;
        private System.Windows.Forms.Button btn_ModUser;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_SearchUsers;
        private System.Windows.Forms.Button btn_Devuelto;
        private System.Windows.Forms.Button btn_SearchPrestamo;
        private System.Windows.Forms.TextBox tbx_NamePres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_DescrPres;
        private System.Windows.Forms.TextBox tbx_IDPres;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.ComboBox cmb_DocentePres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Inven;
        private System.Windows.Forms.Button btn_deleteInvent;
        private System.Windows.Forms.Button btn_ModInvent;
        private System.Windows.Forms.Button btn_ClearInvent;
        private System.Windows.Forms.Button btn_AggInvent;
        private System.Windows.Forms.TextBox tbx_SerieInvent;
        private System.Windows.Forms.TextBox tbx_ModeloInvent;
        private System.Windows.Forms.TextBox tbx_MarcaInvent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_CantInvent;
        private System.Windows.Forms.TextBox tbx_HerraInvent;
    }
}