
namespace _2.claseObjeto_PlanillaDeEmpleados
{
    partial class fmrPlanilla
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAños = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFechaConsulta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblGratificacion = new System.Windows.Forms.Label();
            this.lblSueldoBasico = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCooperativa = new System.Windows.Forms.Label();
            this.lblAfp = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSeguroSocial = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotalNeto = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblTotalAportaciones = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblTotalDescuentos = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblTotalIngresos = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtMes);
            this.groupBox1.Controls.Add(this.txtAños);
            this.groupBox1.Controls.Add(this.txtEmpleado);
            this.groupBox1.Controls.Add(this.cboCargo);
            this.groupBox1.Controls.Add(this.dtFechaIngreso);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblFechaConsulta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion General del Empleado";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(287, 73);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(107, 21);
            this.txtMes.TabIndex = 14;
            // 
            // txtAños
            // 
            this.txtAños.Location = new System.Drawing.Point(552, 72);
            this.txtAños.Name = "txtAños";
            this.txtAños.Size = new System.Drawing.Size(40, 21);
            this.txtAños.TabIndex = 13;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(84, 27);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(168, 21);
            this.txtEmpleado.TabIndex = 12;
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Jefe",
            "Capacitador",
            "Coordinador",
            "Asistente"});
            this.cboCargo.Location = new System.Drawing.Point(84, 57);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(168, 23);
            this.cboCargo.TabIndex = 11;
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaIngreso.Location = new System.Drawing.Point(287, 27);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(200, 21);
            this.dtFechaIngreso.TabIndex = 10;
            this.dtFechaIngreso.Value = new System.DateTime(2021, 8, 3, 1, 18, 25, 0);
            this.dtFechaIngreso.ValueChanged += new System.EventHandler(this.dtFechaIngreso_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(518, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Años de Servicio";
            // 
            // lblFechaConsulta
            // 
            this.lblFechaConsulta.AutoSize = true;
            this.lblFechaConsulta.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaConsulta.Location = new System.Drawing.Point(549, 24);
            this.lblFechaConsulta.Name = "lblFechaConsulta";
            this.lblFechaConsulta.Size = new System.Drawing.Size(52, 18);
            this.lblFechaConsulta.TabIndex = 7;
            this.lblFechaConsulta.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fecha de Consulta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mes Consultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empleado";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.lblComision);
            this.groupBox2.Controls.Add(this.lblGratificacion);
            this.groupBox2.Controls.Add(this.lblSueldoBasico);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresos";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComision.Location = new System.Drawing.Point(108, 107);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(61, 18);
            this.lblComision.TabIndex = 5;
            this.lblComision.Text = "label16";
            // 
            // lblGratificacion
            // 
            this.lblGratificacion.AutoSize = true;
            this.lblGratificacion.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGratificacion.Location = new System.Drawing.Point(108, 68);
            this.lblGratificacion.Name = "lblGratificacion";
            this.lblGratificacion.Size = new System.Drawing.Size(61, 18);
            this.lblGratificacion.TabIndex = 4;
            this.lblGratificacion.Text = "label15";
            // 
            // lblSueldoBasico
            // 
            this.lblSueldoBasico.AutoSize = true;
            this.lblSueldoBasico.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoBasico.Location = new System.Drawing.Point(108, 28);
            this.lblSueldoBasico.Name = "lblSueldoBasico";
            this.lblSueldoBasico.Size = new System.Drawing.Size(61, 18);
            this.lblSueldoBasico.TabIndex = 3;
            this.lblSueldoBasico.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Comision";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Gratificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sueldo Basico";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.lblCooperativa);
            this.groupBox3.Controls.Add(this.lblAfp);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(233, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Descuentos";
            // 
            // lblCooperativa
            // 
            this.lblCooperativa.AutoSize = true;
            this.lblCooperativa.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCooperativa.Location = new System.Drawing.Point(90, 68);
            this.lblCooperativa.Name = "lblCooperativa";
            this.lblCooperativa.Size = new System.Drawing.Size(61, 18);
            this.lblCooperativa.TabIndex = 3;
            this.lblCooperativa.Text = "label20";
            // 
            // lblAfp
            // 
            this.lblAfp.AutoSize = true;
            this.lblAfp.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfp.Location = new System.Drawing.Point(90, 28);
            this.lblAfp.Name = "lblAfp";
            this.lblAfp.Size = new System.Drawing.Size(61, 18);
            this.lblAfp.TabIndex = 2;
            this.lblAfp.Text = "label19";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 15);
            this.label18.TabIndex = 1;
            this.label18.Text = "Cooperativa";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "AFP";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.lblSeguroSocial);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(443, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 58);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aportaciones";
            // 
            // lblSeguroSocial
            // 
            this.lblSeguroSocial.AutoSize = true;
            this.lblSeguroSocial.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguroSocial.Location = new System.Drawing.Point(115, 27);
            this.lblSeguroSocial.Name = "lblSeguroSocial";
            this.lblSeguroSocial.Size = new System.Drawing.Size(61, 18);
            this.lblSeguroSocial.TabIndex = 1;
            this.lblSeguroSocial.Text = "label22";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "Seguro Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "PLANILLA DE PAGO DE EMPLEADOS";
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProcesar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(24, 437);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(121, 40);
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(151, 436);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 41);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(309, 436);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 41);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox5.Controls.Add(this.lblTotalNeto);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.lblTotalAportaciones);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.lblTotalDescuentos);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.lblTotalIngresos);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Location = new System.Drawing.Point(12, 306);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(680, 99);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            // 
            // lblTotalNeto
            // 
            this.lblTotalNeto.AutoSize = true;
            this.lblTotalNeto.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNeto.Location = new System.Drawing.Point(561, 67);
            this.lblTotalNeto.Name = "lblTotalNeto";
            this.lblTotalNeto.Size = new System.Drawing.Size(70, 22);
            this.lblTotalNeto.TabIndex = 21;
            this.lblTotalNeto.Text = "label30";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(482, 71);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(81, 16);
            this.label29.TabIndex = 20;
            this.label29.Text = "Total Neto";
            // 
            // lblTotalAportaciones
            // 
            this.lblTotalAportaciones.AutoSize = true;
            this.lblTotalAportaciones.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAportaciones.Location = new System.Drawing.Point(583, 16);
            this.lblTotalAportaciones.Name = "lblTotalAportaciones";
            this.lblTotalAportaciones.Size = new System.Drawing.Size(61, 18);
            this.lblTotalAportaciones.TabIndex = 19;
            this.lblTotalAportaciones.Text = "label28";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(451, 14);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(126, 15);
            this.label27.TabIndex = 18;
            this.label27.Text = "Total Aportaciones";
            // 
            // lblTotalDescuentos
            // 
            this.lblTotalDescuentos.AutoSize = true;
            this.lblTotalDescuentos.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDescuentos.Location = new System.Drawing.Point(341, 16);
            this.lblTotalDescuentos.Name = "lblTotalDescuentos";
            this.lblTotalDescuentos.Size = new System.Drawing.Size(61, 18);
            this.lblTotalDescuentos.TabIndex = 17;
            this.lblTotalDescuentos.Text = "label26";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(217, 14);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(118, 15);
            this.label25.TabIndex = 16;
            this.label25.Text = "Total Descuentos";
            // 
            // lblTotalIngresos
            // 
            this.lblTotalIngresos.AutoSize = true;
            this.lblTotalIngresos.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngresos.Location = new System.Drawing.Point(110, 19);
            this.lblTotalIngresos.Name = "lblTotalIngresos";
            this.lblTotalIngresos.Size = new System.Drawing.Size(61, 18);
            this.lblTotalIngresos.TabIndex = 15;
            this.lblTotalIngresos.Text = "label24";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(8, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 15);
            this.label23.TabIndex = 14;
            this.label23.Text = "Total Ingresos";
            // 
            // fmrPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(705, 489);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmrPlanilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planilla de Pago de Empleados";
            this.Load += new System.EventHandler(this.fmrPlanilla_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.DateTimePicker dtFechaIngreso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFechaConsulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblGratificacion;
        private System.Windows.Forms.Label lblSueldoBasico;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCooperativa;
        private System.Windows.Forms.Label lblAfp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSeguroSocial;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtAños;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTotalNeto;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblTotalAportaciones;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblTotalDescuentos;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblTotalIngresos;
        private System.Windows.Forms.Label label23;
    }
}

