namespace SismosAntioquia
{
    partial class Form1
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
            this.dataGridViewDetalleSismo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewConsolidadoRegion = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewSismosMes = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSismoJson = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSismoXML = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSismoInfo = new System.Windows.Forms.TextBox();
            this.txtIdSismoDetalle = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.botonGeneraDetalleSismo = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.botonAgregarSismo = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfundidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMagnitud = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboRegionesAgregarSismo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtIdSismoEditar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.botonBuscarSismo = new System.Windows.Forms.Button();
            this.grupoEditarSismo = new System.Windows.Forms.GroupBox();
            this.etiquetaIdSismo = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.botonCancelarEdicion = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.selectorHoraEditar = new System.Windows.Forms.DateTimePicker();
            this.btnActualizarSismo = new System.Windows.Forms.Button();
            this.selectorFechaEditar = new System.Windows.Forms.DateTimePicker();
            this.txtLongitudEditar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLatitudEditar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProfundidadEditar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMagnitudEditar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxRegionesEditar = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnBorrarSismo = new System.Windows.Forms.Button();
            this.txtIdSismoBorrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleSismo)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsolidadoRegion)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSismosMes)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.grupoEditarSismo.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDetalleSismo
            // 
            this.dataGridViewDetalleSismo.AllowUserToAddRows = false;
            this.dataGridViewDetalleSismo.AllowUserToDeleteRows = false;
            this.dataGridViewDetalleSismo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleSismo.Location = new System.Drawing.Point(6, 23);
            this.dataGridViewDetalleSismo.Name = "dataGridViewDetalleSismo";
            this.dataGridViewDetalleSismo.ReadOnly = true;
            this.dataGridViewDetalleSismo.Size = new System.Drawing.Size(497, 381);
            this.dataGridViewDetalleSismo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sismos Registrados:";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage1);
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Location = new System.Drawing.Point(323, 50);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(529, 436);
            this.tabControl3.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewDetalleSismo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(521, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Información detallada";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewConsolidadoRegion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(521, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consolidado por region";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewConsolidadoRegion
            // 
            this.dataGridViewConsolidadoRegion.AllowUserToAddRows = false;
            this.dataGridViewConsolidadoRegion.AllowUserToDeleteRows = false;
            this.dataGridViewConsolidadoRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsolidadoRegion.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewConsolidadoRegion.Name = "dataGridViewConsolidadoRegion";
            this.dataGridViewConsolidadoRegion.ReadOnly = true;
            this.dataGridViewConsolidadoRegion.Size = new System.Drawing.Size(509, 398);
            this.dataGridViewConsolidadoRegion.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewSismosMes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(521, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consolidado por mes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSismosMes
            // 
            this.dataGridViewSismosMes.AllowUserToAddRows = false;
            this.dataGridViewSismosMes.AllowUserToDeleteRows = false;
            this.dataGridViewSismosMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSismosMes.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewSismosMes.Name = "dataGridViewSismosMes";
            this.dataGridViewSismosMes.ReadOnly = true;
            this.dataGridViewSismosMes.Size = new System.Drawing.Size(426, 397);
            this.dataGridViewSismosMes.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label23);
            this.tabPage7.Controls.Add(this.txtSismoJson);
            this.tabPage7.Controls.Add(this.label22);
            this.tabPage7.Controls.Add(this.txtSismoXML);
            this.tabPage7.Controls.Add(this.label21);
            this.tabPage7.Controls.Add(this.txtSismoInfo);
            this.tabPage7.Controls.Add(this.txtIdSismoDetalle);
            this.tabPage7.Controls.Add(this.label20);
            this.tabPage7.Controls.Add(this.botonGeneraDetalleSismo);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(521, 410);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "Detalle del Sismo";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(35, 298);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 13);
            this.label23.TabIndex = 31;
            this.label23.Text = "Detalle Sismo en JSON:";
            // 
            // txtSismoJson
            // 
            this.txtSismoJson.Location = new System.Drawing.Point(38, 317);
            this.txtSismoJson.Multiline = true;
            this.txtSismoJson.Name = "txtSismoJson";
            this.txtSismoJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSismoJson.Size = new System.Drawing.Size(460, 69);
            this.txtSismoJson.TabIndex = 30;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(35, 192);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(114, 13);
            this.label22.TabIndex = 29;
            this.label22.Text = "Detalle Sismo en XML:";
            // 
            // txtSismoXML
            // 
            this.txtSismoXML.Location = new System.Drawing.Point(38, 211);
            this.txtSismoXML.Multiline = true;
            this.txtSismoXML.Name = "txtSismoXML";
            this.txtSismoXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSismoXML.Size = new System.Drawing.Size(460, 69);
            this.txtSismoXML.TabIndex = 28;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(35, 76);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Detalle Sismo:";
            // 
            // txtSismoInfo
            // 
            this.txtSismoInfo.Location = new System.Drawing.Point(38, 95);
            this.txtSismoInfo.Multiline = true;
            this.txtSismoInfo.Name = "txtSismoInfo";
            this.txtSismoInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSismoInfo.Size = new System.Drawing.Size(460, 69);
            this.txtSismoInfo.TabIndex = 26;
            // 
            // txtIdSismoDetalle
            // 
            this.txtIdSismoDetalle.Location = new System.Drawing.Point(201, 16);
            this.txtIdSismoDetalle.Name = "txtIdSismoDetalle";
            this.txtIdSismoDetalle.Size = new System.Drawing.Size(66, 20);
            this.txtIdSismoDetalle.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(142, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "Id sismo:";
            // 
            // botonGeneraDetalleSismo
            // 
            this.botonGeneraDetalleSismo.Location = new System.Drawing.Point(277, 13);
            this.botonGeneraDetalleSismo.Name = "botonGeneraDetalleSismo";
            this.botonGeneraDetalleSismo.Size = new System.Drawing.Size(75, 23);
            this.botonGeneraDetalleSismo.TabIndex = 23;
            this.botonGeneraDetalleSismo.Text = "Buscar";
            this.botonGeneraDetalleSismo.UseVisualStyleBackColor = true;
            this.botonGeneraDetalleSismo.Click += new System.EventHandler(this.botonGeneraDetalleSismo_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(12, 50);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(276, 440);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.dtpHora);
            this.tabPage4.Controls.Add(this.botonAgregarSismo);
            this.tabPage4.Controls.Add(this.dtpFecha);
            this.tabPage4.Controls.Add(this.txtLongitud);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.txtLatitud);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.txtProfundidad);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.txtMagnitud);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.comboRegionesAgregarSismo);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(268, 414);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Agregar Sismo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha:";
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm:ss";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(79, 228);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(100, 20);
            this.dtpHora.TabIndex = 14;
            // 
            // botonAgregarSismo
            // 
            this.botonAgregarSismo.Location = new System.Drawing.Point(67, 275);
            this.botonAgregarSismo.Name = "botonAgregarSismo";
            this.botonAgregarSismo.Size = new System.Drawing.Size(112, 23);
            this.botonAgregarSismo.TabIndex = 13;
            this.botonAgregarSismo.Text = "Agregar Sismo";
            this.botonAgregarSismo.UseVisualStyleBackColor = true;
            this.botonAgregarSismo.Click += new System.EventHandler(this.botonAgregarSismo_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(79, 201);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 12;
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(79, 165);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(100, 20);
            this.txtLongitud.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Longitud";
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(79, 130);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(100, 20);
            this.txtLatitud.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Latitud";
            // 
            // txtProfundidad
            // 
            this.txtProfundidad.Location = new System.Drawing.Point(79, 95);
            this.txtProfundidad.Name = "txtProfundidad";
            this.txtProfundidad.Size = new System.Drawing.Size(100, 20);
            this.txtProfundidad.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Profundidad";
            // 
            // txtMagnitud
            // 
            this.txtMagnitud.Location = new System.Drawing.Point(79, 57);
            this.txtMagnitud.Name = "txtMagnitud";
            this.txtMagnitud.Size = new System.Drawing.Size(100, 20);
            this.txtMagnitud.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Magnitud:";
            // 
            // comboRegionesAgregarSismo
            // 
            this.comboRegionesAgregarSismo.FormattingEnabled = true;
            this.comboRegionesAgregarSismo.Location = new System.Drawing.Point(67, 21);
            this.comboRegionesAgregarSismo.Name = "comboRegionesAgregarSismo";
            this.comboRegionesAgregarSismo.Size = new System.Drawing.Size(163, 21);
            this.comboRegionesAgregarSismo.TabIndex = 3;
            this.comboRegionesAgregarSismo.SelectedIndexChanged += new System.EventHandler(this.comboRegionesAgregarSismo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Región:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtIdSismoEditar);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.botonBuscarSismo);
            this.tabPage5.Controls.Add(this.grupoEditarSismo);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(268, 414);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Editar Sismo";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtIdSismoEditar
            // 
            this.txtIdSismoEditar.Location = new System.Drawing.Point(87, 17);
            this.txtIdSismoEditar.Name = "txtIdSismoEditar";
            this.txtIdSismoEditar.Size = new System.Drawing.Size(66, 20);
            this.txtIdSismoEditar.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Id sismo:";
            // 
            // botonBuscarSismo
            // 
            this.botonBuscarSismo.Location = new System.Drawing.Point(163, 14);
            this.botonBuscarSismo.Name = "botonBuscarSismo";
            this.botonBuscarSismo.Size = new System.Drawing.Size(75, 23);
            this.botonBuscarSismo.TabIndex = 1;
            this.botonBuscarSismo.Text = "Buscar";
            this.botonBuscarSismo.UseVisualStyleBackColor = true;
            this.botonBuscarSismo.Click += new System.EventHandler(this.botonBuscarSismo_Click);
            // 
            // grupoEditarSismo
            // 
            this.grupoEditarSismo.Controls.Add(this.etiquetaIdSismo);
            this.grupoEditarSismo.Controls.Add(this.label19);
            this.grupoEditarSismo.Controls.Add(this.botonCancelarEdicion);
            this.grupoEditarSismo.Controls.Add(this.label10);
            this.grupoEditarSismo.Controls.Add(this.label11);
            this.grupoEditarSismo.Controls.Add(this.selectorHoraEditar);
            this.grupoEditarSismo.Controls.Add(this.btnActualizarSismo);
            this.grupoEditarSismo.Controls.Add(this.selectorFechaEditar);
            this.grupoEditarSismo.Controls.Add(this.txtLongitudEditar);
            this.grupoEditarSismo.Controls.Add(this.label12);
            this.grupoEditarSismo.Controls.Add(this.txtLatitudEditar);
            this.grupoEditarSismo.Controls.Add(this.label13);
            this.grupoEditarSismo.Controls.Add(this.txtProfundidadEditar);
            this.grupoEditarSismo.Controls.Add(this.label14);
            this.grupoEditarSismo.Controls.Add(this.txtMagnitudEditar);
            this.grupoEditarSismo.Controls.Add(this.label15);
            this.grupoEditarSismo.Controls.Add(this.comboBoxRegionesEditar);
            this.grupoEditarSismo.Controls.Add(this.label16);
            this.grupoEditarSismo.Location = new System.Drawing.Point(6, 56);
            this.grupoEditarSismo.Name = "grupoEditarSismo";
            this.grupoEditarSismo.Size = new System.Drawing.Size(245, 340);
            this.grupoEditarSismo.TabIndex = 0;
            this.grupoEditarSismo.TabStop = false;
            this.grupoEditarSismo.Text = "Editar Sismo:";
            this.grupoEditarSismo.Visible = false;
            // 
            // etiquetaIdSismo
            // 
            this.etiquetaIdSismo.BackColor = System.Drawing.Color.LightGray;
            this.etiquetaIdSismo.Location = new System.Drawing.Point(78, 20);
            this.etiquetaIdSismo.Name = "etiquetaIdSismo";
            this.etiquetaIdSismo.Size = new System.Drawing.Size(83, 20);
            this.etiquetaIdSismo.TabIndex = 34;
            this.etiquetaIdSismo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Id Sismo:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // botonCancelarEdicion
            // 
            this.botonCancelarEdicion.Location = new System.Drawing.Point(15, 297);
            this.botonCancelarEdicion.Name = "botonCancelarEdicion";
            this.botonCancelarEdicion.Size = new System.Drawing.Size(75, 23);
            this.botonCancelarEdicion.TabIndex = 32;
            this.botonCancelarEdicion.Text = "Cancelar";
            this.botonCancelarEdicion.UseVisualStyleBackColor = true;
            this.botonCancelarEdicion.Click += new System.EventHandler(this.botonCancelarEdicion_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Hora:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Fecha:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // selectorHoraEditar
            // 
            this.selectorHoraEditar.CustomFormat = "HH:mm:ss";
            this.selectorHoraEditar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectorHoraEditar.Location = new System.Drawing.Point(81, 262);
            this.selectorHoraEditar.Name = "selectorHoraEditar";
            this.selectorHoraEditar.Size = new System.Drawing.Size(100, 20);
            this.selectorHoraEditar.TabIndex = 29;
            // 
            // btnActualizarSismo
            // 
            this.btnActualizarSismo.Location = new System.Drawing.Point(111, 297);
            this.btnActualizarSismo.Name = "btnActualizarSismo";
            this.btnActualizarSismo.Size = new System.Drawing.Size(112, 23);
            this.btnActualizarSismo.TabIndex = 28;
            this.btnActualizarSismo.Text = "Actualizar Sismo";
            this.btnActualizarSismo.UseVisualStyleBackColor = true;
            this.btnActualizarSismo.Click += new System.EventHandler(this.btnActualizarSismo_Click);
            // 
            // selectorFechaEditar
            // 
            this.selectorFechaEditar.CustomFormat = "dd/MM/yyyy";
            this.selectorFechaEditar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectorFechaEditar.Location = new System.Drawing.Point(81, 235);
            this.selectorFechaEditar.Name = "selectorFechaEditar";
            this.selectorFechaEditar.Size = new System.Drawing.Size(100, 20);
            this.selectorFechaEditar.TabIndex = 27;
            // 
            // txtLongitudEditar
            // 
            this.txtLongitudEditar.Location = new System.Drawing.Point(81, 199);
            this.txtLongitudEditar.Name = "txtLongitudEditar";
            this.txtLongitudEditar.Size = new System.Drawing.Size(100, 20);
            this.txtLongitudEditar.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Longitud";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLatitudEditar
            // 
            this.txtLatitudEditar.Location = new System.Drawing.Point(81, 164);
            this.txtLatitudEditar.Name = "txtLatitudEditar";
            this.txtLatitudEditar.Size = new System.Drawing.Size(100, 20);
            this.txtLatitudEditar.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Latitud";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProfundidadEditar
            // 
            this.txtProfundidadEditar.Location = new System.Drawing.Point(81, 129);
            this.txtProfundidadEditar.Name = "txtProfundidadEditar";
            this.txtProfundidadEditar.Size = new System.Drawing.Size(100, 20);
            this.txtProfundidadEditar.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Profundidad";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMagnitudEditar
            // 
            this.txtMagnitudEditar.Location = new System.Drawing.Point(81, 91);
            this.txtMagnitudEditar.Name = "txtMagnitudEditar";
            this.txtMagnitudEditar.Size = new System.Drawing.Size(100, 20);
            this.txtMagnitudEditar.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Magnitud:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxRegionesEditar
            // 
            this.comboBoxRegionesEditar.FormattingEnabled = true;
            this.comboBoxRegionesEditar.Location = new System.Drawing.Point(81, 55);
            this.comboBoxRegionesEditar.Name = "comboBoxRegionesEditar";
            this.comboBoxRegionesEditar.Size = new System.Drawing.Size(151, 21);
            this.comboBoxRegionesEditar.TabIndex = 18;
            this.comboBoxRegionesEditar.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegionesEditar_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Región:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnBorrarSismo);
            this.tabPage6.Controls.Add(this.txtIdSismoBorrar);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(268, 414);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Borrar Sismo";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnBorrarSismo
            // 
            this.btnBorrarSismo.Location = new System.Drawing.Point(30, 92);
            this.btnBorrarSismo.Name = "btnBorrarSismo";
            this.btnBorrarSismo.Size = new System.Drawing.Size(153, 23);
            this.btnBorrarSismo.TabIndex = 2;
            this.btnBorrarSismo.Text = "Borrar Sismo";
            this.btnBorrarSismo.UseVisualStyleBackColor = true;
            this.btnBorrarSismo.Click += new System.EventHandler(this.btnBorrarSismo_Click);
            // 
            // txtIdSismoBorrar
            // 
            this.txtIdSismoBorrar.Location = new System.Drawing.Point(83, 44);
            this.txtIdSismoBorrar.Name = "txtIdSismoBorrar";
            this.txtIdSismoBorrar.Size = new System.Drawing.Size(100, 20);
            this.txtIdSismoBorrar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Sismo:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Green;
            this.label18.Location = new System.Drawing.Point(12, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(305, 24);
            this.label18.TabIndex = 6;
            this.label18.Text = "Sismos Antioquia 2019 - 2022";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 512);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sismos Antioquia 2019 - 2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleSismo)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsolidadoRegion)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSismosMes)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.grupoEditarSismo.ResumeLayout(false);
            this.grupoEditarSismo.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDetalleSismo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewConsolidadoRegion;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox comboRegionesAgregarSismo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Button botonAgregarSismo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProfundidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMagnitud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBorrarSismo;
        private System.Windows.Forms.TextBox txtIdSismoBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewSismosMes;
        private System.Windows.Forms.GroupBox grupoEditarSismo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker selectorHoraEditar;
        private System.Windows.Forms.Button btnActualizarSismo;
        private System.Windows.Forms.DateTimePicker selectorFechaEditar;
        private System.Windows.Forms.TextBox txtLongitudEditar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLatitudEditar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProfundidadEditar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMagnitudEditar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxRegionesEditar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button botonBuscarSismo;
        private System.Windows.Forms.TextBox txtIdSismoEditar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label etiquetaIdSismo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button botonCancelarEdicion;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox txtIdSismoDetalle;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button botonGeneraDetalleSismo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSismoInfo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSismoJson;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtSismoXML;
    }
}

