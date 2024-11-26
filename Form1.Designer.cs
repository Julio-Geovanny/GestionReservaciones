namespace GestionReservaciones
{
    partial class Form1
    {
        private System.Windows.Forms.ComboBox cmbHabitacion;
        private System.Windows.Forms.DataGridView dgvReservaciones;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            cmbHabitacion = new ComboBox();
            dgvReservaciones = new DataGridView();
            btnEliminarHistorial = new Button();
            txtTitulo = new Label();
            txtxEntrada = new Label();
            txtNombreCliente = new TextBox();
            dtpIngreso = new DateTimePicker();
            txtHabitacion = new Label();
            dtpSalida = new DateTimePicker();
            txtSalida = new Label();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnGuardar = new Button();
            btnMostrarReservaciones = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // cmbHabitacion
            // 
            cmbHabitacion.BackColor = Color.White;
            cmbHabitacion.Items.AddRange(new object[] { "Simple", "Doble", "Suite" });
            cmbHabitacion.Location = new Point(278, 214);
            cmbHabitacion.Name = "cmbHabitacion";
            cmbHabitacion.Size = new Size(200, 28);
            cmbHabitacion.TabIndex = 1;
            // 
            // dgvReservaciones
            // 
            dataGridViewCellStyle4.BackColor = Color.Tan;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvReservaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvReservaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReservaciones.BackgroundColor = Color.Tan;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvReservaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvReservaciones.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Tan;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(128, 64, 0);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvReservaciones.DefaultCellStyle = dataGridViewCellStyle6;
            dgvReservaciones.GridColor = SystemColors.Desktop;
            dgvReservaciones.Location = new Point(604, 139);
            dgvReservaciones.Name = "dgvReservaciones";
            dgvReservaciones.RowHeadersWidth = 51;
            dgvReservaciones.Size = new Size(412, 265);
            dgvReservaciones.TabIndex = 6;
            dgvReservaciones.CellContentClick += dgvReservaciones_CellContentClick;
            // 
            // btnEliminarHistorial
            // 
            btnEliminarHistorial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminarHistorial.BackColor = Color.Tan;
            btnEliminarHistorial.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarHistorial.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminarHistorial.Image = Properties.Resources.foto;
            btnEliminarHistorial.Location = new Point(645, 421);
            btnEliminarHistorial.Name = "btnEliminarHistorial";
            btnEliminarHistorial.Size = new Size(193, 38);
            btnEliminarHistorial.TabIndex = 7;
            btnEliminarHistorial.Text = "Eliminar historial";
            btnEliminarHistorial.UseVisualStyleBackColor = false;
            btnEliminarHistorial.Click += btnEliminarHistorial_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitulo.BackColor = Color.Transparent;
            txtTitulo.Font = new Font("Mongolian Baiti", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = SystemColors.ActiveCaptionText;
            txtTitulo.Image = Properties.Resources.foto;
            txtTitulo.ImageAlign = ContentAlignment.TopCenter;
            txtTitulo.Location = new Point(104, 31);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(864, 53);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "BIENVENIDO A FOUR SEASONS RESORT ";
            txtTitulo.TextAlign = ContentAlignment.MiddleCenter;
            txtTitulo.Click += txtTitulo_Click;
            // 
            // txtxEntrada
            // 
            txtxEntrada.AutoSize = true;
            txtxEntrada.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtxEntrada.ForeColor = SystemColors.ButtonHighlight;
            txtxEntrada.Image = Properties.Resources.foto;
            txtxEntrada.ImageAlign = ContentAlignment.MiddleRight;
            txtxEntrada.Location = new Point(78, 302);
            txtxEntrada.Name = "txtxEntrada";
            txtxEntrada.Size = new Size(103, 25);
            txtxEntrada.TabIndex = 7;
            txtxEntrada.Text = "Entrada:\r\n";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BackColor = Color.White;
            txtNombreCliente.ForeColor = Color.Black;
            txtNombreCliente.Location = new Point(166, 138);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.PlaceholderText = "Nombre del cliente";
            txtNombreCliente.Size = new Size(200, 27);
            txtNombreCliente.TabIndex = 0;
            // 
            // dtpIngreso
            // 
            dtpIngreso.CalendarMonthBackground = Color.FromArgb(255, 192, 255);
            dtpIngreso.CalendarTitleBackColor = Color.FromArgb(255, 192, 255);
            dtpIngreso.CalendarTrailingForeColor = Color.Black;
            dtpIngreso.Location = new Point(278, 302);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(200, 27);
            dtpIngreso.TabIndex = 2;
            // 
            // txtHabitacion
            // 
            txtHabitacion.AutoSize = true;
            txtHabitacion.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHabitacion.ForeColor = Color.White;
            txtHabitacion.Image = Properties.Resources.foto;
            txtHabitacion.ImageAlign = ContentAlignment.MiddleRight;
            txtHabitacion.Location = new Point(78, 217);
            txtHabitacion.Name = "txtHabitacion";
            txtHabitacion.Size = new Size(129, 25);
            txtHabitacion.TabIndex = 8;
            txtHabitacion.Text = "Habitaciòn:";
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(278, 379);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(200, 27);
            dtpSalida.TabIndex = 3;
            // 
            // txtSalida
            // 
            txtSalida.AutoSize = true;
            txtSalida.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalida.ForeColor = Color.White;
            txtSalida.Image = Properties.Resources.foto;
            txtSalida.ImageAlign = ContentAlignment.MiddleRight;
            txtSalida.Location = new Point(78, 379);
            txtSalida.Name = "txtSalida";
            txtSalida.Size = new Size(80, 25);
            txtSalida.TabIndex = 9;
            txtSalida.Text = "Salida:";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalir.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Image = Properties.Resources.foto;
            btnSalir.Location = new Point(864, 421);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 35);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.foto;
            pictureBox1.Location = new Point(-40, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1271, 573);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Beige;
            pictureBox2.Image = Properties.Resources.browser;
            pictureBox2.Location = new Point(184, 379);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Tan;
            pictureBox3.Image = Properties.Resources.images;
            pictureBox3.Location = new Point(187, 302);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = Properties.Resources.foto;
            btnGuardar.ImageAlign = ContentAlignment.BottomLeft;
            btnGuardar.Location = new Point(78, 440);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(203, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar reservación";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnMostrarReservaciones
            // 
            btnMostrarReservaciones.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarReservaciones.ForeColor = Color.White;
            btnMostrarReservaciones.Image = Properties.Resources.foto;
            btnMostrarReservaciones.ImageAlign = ContentAlignment.BottomLeft;
            btnMostrarReservaciones.Location = new Point(312, 440);
            btnMostrarReservaciones.Name = "btnMostrarReservaciones";
            btnMostrarReservaciones.Size = new Size(191, 29);
            btnMostrarReservaciones.TabIndex = 15;
            btnMostrarReservaciones.Text = "Mostrar reservaciones";
            btnMostrarReservaciones.UseVisualStyleBackColor = true;
            btnMostrarReservaciones.Click += btnMostrarReservaciones_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1064, 481);
            Controls.Add(btnMostrarReservaciones);
            Controls.Add(btnGuardar);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnSalir);
            Controls.Add(txtSalida);
            Controls.Add(dtpSalida);
            Controls.Add(btnEliminarHistorial);
            Controls.Add(dtpIngreso);
            Controls.Add(txtTitulo);
            Controls.Add(dgvReservaciones);
            Controls.Add(txtHabitacion);
            Controls.Add(cmbHabitacion);
            Controls.Add(txtxEntrada);
            Controls.Add(txtNombreCliente);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Gestión de Reservaciones Four Seasons Resort";
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnEliminarHistorial;
        private Label txtTitulo;
        private Label txtxEntrada;
        private TextBox txtNombreCliente;
        private DateTimePicker dtpIngreso;
        private Label txtHabitacion;
        private DateTimePicker dtpSalida;
        private Label txtSalida;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnGuardar;
        private Button btnMostrarReservaciones;
    }
}
