namespace Almacén_Virtual_Proyect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbcalmacen = new System.Windows.Forms.TabControl();
            this.tpRegistro = new System.Windows.Forms.TabPage();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.tpAlmacen = new System.Windows.Forms.TabPage();
            this.tsBoorartodo = new System.Windows.Forms.ToolStrip();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsBorrartodo = new System.Windows.Forms.ToolStripButton();
            this.dgvProducAlmacenados = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tpConsulta = new System.Windows.Forms.TabPage();
            this.rbMayores = new System.Windows.Forms.RadioButton();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtConsultao = new System.Windows.Forms.TextBox();
            this.rbMenores = new System.Windows.Forms.RadioButton();
            this.dgvConsculta = new System.Windows.Forms.DataGridView();
            this.lblProductosComparacion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.epAdvertencia = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbcalmacen.SuspendLayout();
            this.tpRegistro.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpAlmacen.SuspendLayout();
            this.tsBoorartodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducAlmacenados)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsculta)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAdvertencia)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcalmacen
            // 
            this.tbcalmacen.Controls.Add(this.tpRegistro);
            this.tbcalmacen.Controls.Add(this.tpAlmacen);
            this.tbcalmacen.Controls.Add(this.tpConsulta);
            this.tbcalmacen.Location = new System.Drawing.Point(1, 1);
            this.tbcalmacen.Name = "tbcalmacen";
            this.tbcalmacen.SelectedIndex = 0;
            this.tbcalmacen.Size = new System.Drawing.Size(887, 579);
            this.tbcalmacen.TabIndex = 1;
            // 
            // tpRegistro
            // 
            this.tpRegistro.BackColor = System.Drawing.Color.Silver;
            this.tpRegistro.Controls.Add(this.txtMarca);
            this.tpRegistro.Controls.Add(this.label5);
            this.tpRegistro.Controls.Add(this.txtIDproducto);
            this.tpRegistro.Controls.Add(this.label2);
            this.tpRegistro.Controls.Add(this.txtPrecio);
            this.tpRegistro.Controls.Add(this.lblPrecio);
            this.tpRegistro.Controls.Add(this.txtCantidad);
            this.tpRegistro.Controls.Add(this.lblExistencia);
            this.tpRegistro.Controls.Add(this.txtProducto);
            this.tpRegistro.Controls.Add(this.lblProducto);
            this.tpRegistro.Controls.Add(this.panel2);
            this.tpRegistro.Controls.Add(this.panel3);
            this.tpRegistro.Location = new System.Drawing.Point(4, 24);
            this.tpRegistro.Name = "tpRegistro";
            this.tpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistro.Size = new System.Drawing.Size(879, 551);
            this.tpRegistro.TabIndex = 0;
            this.tpRegistro.Text = "Registro";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(306, 340);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(82, 23);
            this.txtMarca.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(306, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Marca";
            // 
            // txtIDproducto
            // 
            this.txtIDproducto.Enabled = false;
            this.txtIDproducto.Location = new System.Drawing.Point(306, 269);
            this.txtIDproducto.Name = "txtIDproducto";
            this.txtIDproducto.Size = new System.Drawing.Size(210, 23);
            this.txtIDproducto.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(306, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(669, 269);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 23);
            this.txtPrecio.TabIndex = 16;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(669, 247);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(114, 19);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "precio unidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(669, 207);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(102, 23);
            this.txtCantidad.TabIndex = 14;
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExistencia.Location = new System.Drawing.Point(669, 185);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(84, 19);
            this.lblExistencia.TabIndex = 13;
            this.lblExistencia.Text = "Existencia";
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(306, 206);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(256, 23);
            this.txtProducto.TabIndex = 12;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProducto.Location = new System.Drawing.Point(306, 184);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(78, 19);
            this.lblProducto.TabIndex = 11;
            this.lblProducto.Text = "producto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 138);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(216, 138);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(242, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de productos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnRegistro);
            this.panel3.Location = new System.Drawing.Point(0, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 431);
            this.panel3.TabIndex = 21;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(6, 88);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DimGray;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.Location = new System.Drawing.Point(0, 88);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(78, 0, 0, 0);
            this.btnNuevo.Size = new System.Drawing.Size(219, 66);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.DimGray;
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistro.Enabled = false;
            this.btnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRegistro.Location = new System.Drawing.Point(0, 0);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Padding = new System.Windows.Forms.Padding(78, 0, 0, 0);
            this.btnRegistro.Size = new System.Drawing.Size(219, 66);
            this.btnRegistro.TabIndex = 20;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // tpAlmacen
            // 
            this.tpAlmacen.BackColor = System.Drawing.Color.Silver;
            this.tpAlmacen.Controls.Add(this.tsBoorartodo);
            this.tpAlmacen.Controls.Add(this.dgvProducAlmacenados);
            this.tpAlmacen.Controls.Add(this.btnBuscar);
            this.tpAlmacen.Controls.Add(this.label4);
            this.tpAlmacen.Controls.Add(this.txtBuscar);
            this.tpAlmacen.Controls.Add(this.panel1);
            this.tpAlmacen.Location = new System.Drawing.Point(4, 24);
            this.tpAlmacen.Name = "tpAlmacen";
            this.tpAlmacen.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlmacen.Size = new System.Drawing.Size(879, 551);
            this.tpAlmacen.TabIndex = 1;
            this.tpAlmacen.Text = "Almacén";
            // 
            // tsBoorartodo
            // 
            this.tsBoorartodo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEditar,
            this.toolStripSeparator1,
            this.tsbBorrar,
            this.tsBorrartodo});
            this.tsBoorartodo.Location = new System.Drawing.Point(3, 141);
            this.tsBoorartodo.Name = "tsBoorartodo";
            this.tsBoorartodo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsBoorartodo.Size = new System.Drawing.Size(873, 25);
            this.tsBoorartodo.TabIndex = 11;
            this.tsBoorartodo.Text = "toolStrip1";
            this.tsBoorartodo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsBoorartodo_ItemClicked);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBorrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBorrar.Image")));
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(23, 22);
            this.tsbBorrar.Text = "Borrar";
            this.tsbBorrar.Click += new System.EventHandler(this.tsbBorrar_Click);
            // 
            // tsBorrartodo
            // 
            this.tsBorrartodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBorrartodo.Image = ((System.Drawing.Image)(resources.GetObject("tsBorrartodo.Image")));
            this.tsBorrartodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBorrartodo.Name = "tsBorrartodo";
            this.tsBorrartodo.Size = new System.Drawing.Size(23, 22);
            this.tsBorrartodo.Text = "Borrar todo";
            this.tsBorrartodo.Click += new System.EventHandler(this.tsBorrartodo_Click);
            // 
            // dgvProducAlmacenados
            // 
            this.dgvProducAlmacenados.AllowUserToAddRows = false;
            this.dgvProducAlmacenados.AllowUserToResizeColumns = false;
            this.dgvProducAlmacenados.AllowUserToResizeRows = false;
            this.dgvProducAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducAlmacenados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column5});
            this.dgvProducAlmacenados.Location = new System.Drawing.Point(94, 258);
            this.dgvProducAlmacenados.Name = "dgvProducAlmacenados";
            this.dgvProducAlmacenados.RowTemplate.Height = 25;
            this.dgvProducAlmacenados.Size = new System.Drawing.Size(693, 262);
            this.dgvProducAlmacenados.TabIndex = 10;
            this.dgvProducAlmacenados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducAlmacenados_CellClick);
            this.dgvProducAlmacenados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducAlmacenados_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre del producto";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio Unidad";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID producto";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Existencia";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Marca";
            this.Column5.Name = "Column5";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageKey = "buscar.png";
            this.btnBuscar.ImageList = this.imageList1;
            this.btnBuscar.Location = new System.Drawing.Point(638, 214);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buscar.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Buscar producto:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Enabled = false;
            this.txtBuscar.Location = new System.Drawing.Point(263, 214);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(369, 23);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 138);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(413, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "Almacén";
            // 
            // tpConsulta
            // 
            this.tpConsulta.BackColor = System.Drawing.Color.Silver;
            this.tpConsulta.Controls.Add(this.rbMayores);
            this.tpConsulta.Controls.Add(this.btnConsulta);
            this.tpConsulta.Controls.Add(this.txtConsultao);
            this.tpConsulta.Controls.Add(this.rbMenores);
            this.tpConsulta.Controls.Add(this.dgvConsculta);
            this.tpConsulta.Controls.Add(this.lblProductosComparacion);
            this.tpConsulta.Controls.Add(this.label8);
            this.tpConsulta.Controls.Add(this.label7);
            this.tpConsulta.Controls.Add(this.panel4);
            this.tpConsulta.Location = new System.Drawing.Point(4, 24);
            this.tpConsulta.Name = "tpConsulta";
            this.tpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsulta.Size = new System.Drawing.Size(879, 551);
            this.tpConsulta.TabIndex = 2;
            this.tpConsulta.Text = "Consulta";
            // 
            // rbMayores
            // 
            this.rbMayores.AutoSize = true;
            this.rbMayores.Location = new System.Drawing.Point(689, 366);
            this.rbMayores.Name = "rbMayores";
            this.rbMayores.Size = new System.Drawing.Size(79, 19);
            this.rbMayores.TabIndex = 17;
            this.rbMayores.TabStop = true;
            this.rbMayores.Text = "Mayores a";
            this.rbMayores.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(695, 487);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(94, 28);
            this.btnConsulta.TabIndex = 16;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtConsultao
            // 
            this.txtConsultao.Location = new System.Drawing.Point(689, 259);
            this.txtConsultao.Name = "txtConsultao";
            this.txtConsultao.Size = new System.Drawing.Size(100, 23);
            this.txtConsultao.TabIndex = 15;
            // 
            // rbMenores
            // 
            this.rbMenores.AutoSize = true;
            this.rbMenores.Location = new System.Drawing.Point(689, 330);
            this.rbMenores.Name = "rbMenores";
            this.rbMenores.Size = new System.Drawing.Size(80, 19);
            this.rbMenores.TabIndex = 14;
            this.rbMenores.TabStop = true;
            this.rbMenores.Text = "Menores a";
            this.rbMenores.UseVisualStyleBackColor = true;
            this.rbMenores.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dgvConsculta
            // 
            this.dgvConsculta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsculta.Location = new System.Drawing.Point(80, 262);
            this.dgvConsculta.Name = "dgvConsculta";
            this.dgvConsculta.RowTemplate.Height = 25;
            this.dgvConsculta.Size = new System.Drawing.Size(527, 253);
            this.dgvConsculta.TabIndex = 13;
            // 
            // lblProductosComparacion
            // 
            this.lblProductosComparacion.AutoSize = true;
            this.lblProductosComparacion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductosComparacion.Location = new System.Drawing.Point(227, 198);
            this.lblProductosComparacion.Name = "lblProductosComparacion";
            this.lblProductosComparacion.Size = new System.Drawing.Size(209, 19);
            this.lblProductosComparacion.TabIndex = 12;
            this.lblProductosComparacion.Text = "Productos de comparación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(873, 138);
            this.panel4.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 138);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(413, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 55);
            this.label6.TabIndex = 0;
            this.label6.Text = "Almacén";
            // 
            // epAdvertencia
            // 
            this.epAdvertencia.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 582);
            this.Controls.Add(this.tbcalmacen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Almacén Virtual";
            this.tbcalmacen.ResumeLayout(false);
            this.tpRegistro.ResumeLayout(false);
            this.tpRegistro.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpAlmacen.ResumeLayout(false);
            this.tpAlmacen.PerformLayout();
            this.tsBoorartodo.ResumeLayout(false);
            this.tsBoorartodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducAlmacenados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tpConsulta.ResumeLayout(false);
            this.tpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsculta)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAdvertencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbcalmacen;
        private TabPage tpRegistro;
        private TextBox txtMarca;
        private Label label5;
        private TextBox txtIDproducto;
        private Label label2;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtCantidad;
        private Label lblExistencia;
        private TextBox txtProducto;
        private Label lblProducto;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox5;
        private Button btnNuevo;
        private PictureBox pictureBox1;
        private Button btnRegistro;
        private TabPage tpAlmacen;
        private ToolStrip tsBoorartodo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private DataGridView dgvProducAlmacenados;
        private Button btnBuscar;
        private Label label4;
        private TextBox txtBuscar;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private ImageList imageList1;
        private ToolStripButton tsBorrartodo;
        private ErrorProvider epAdvertencia;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TabPage tpConsulta;
        private Label lblProductosComparacion;
        private Label label8;
        private Label label7;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label label6;
        private RadioButton rbMenores;
        private DataGridView dgvConsculta;
        private Button btnConsulta;
        private TextBox txtConsultao;
        private RadioButton rbMayores;
    }
}