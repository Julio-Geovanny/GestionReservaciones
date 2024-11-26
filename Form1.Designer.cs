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
        }


    }
}
