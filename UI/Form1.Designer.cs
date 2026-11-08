namespace UI
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
            groupBox1 = new GroupBox();
            btnConfirmar = new Button();
            btnBorrador = new Button();
            btnAlta = new Button();
            dtpFechaAlquiler = new DateTimePicker();
            label3 = new Label();
            txtImporteTotal = new TextBox();
            label5 = new Label();
            txtDniCliente = new TextBox();
            label2 = new Label();
            cbTipoBicicleta = new ComboBox();
            label1 = new Label();
            dgvAlquileres = new DataGridView();
            label4 = new Label();
            txtIdEliminar = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            txtIdModificar = new TextBox();
            label6 = new Label();
            txtNuevoImporte = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dtpNuevaFecha = new DateTimePicker();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Controls.Add(btnBorrador);
            groupBox1.Controls.Add(btnAlta);
            groupBox1.Controls.Add(dtpFechaAlquiler);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtImporteTotal);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDniCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbTipoBicicleta);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Alquiler";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(212, 258);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(96, 40);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar borrador";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnBorrador
            // 
            btnBorrador.Location = new Point(64, 258);
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(97, 40);
            btnBorrador.TabIndex = 9;
            btnBorrador.Text = "Agregar Borrador";
            btnBorrador.UseVisualStyleBackColor = true;
            btnBorrador.Click += btnBorrador_Click;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(119, 198);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(76, 40);
            btnAlta.TabIndex = 8;
            btnAlta.Text = "Guardar";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // dtpFechaAlquiler
            // 
            dtpFechaAlquiler.Location = new Point(94, 159);
            dtpFechaAlquiler.Name = "dtpFechaAlquiler";
            dtpFechaAlquiler.Size = new Size(214, 23);
            dtpFechaAlquiler.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 165);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 6;
            label3.Text = "Fecha Alquiler";
            // 
            // txtImporteTotal
            // 
            txtImporteTotal.Location = new Point(90, 115);
            txtImporteTotal.Name = "txtImporteTotal";
            txtImporteTotal.Size = new Size(218, 23);
            txtImporteTotal.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 123);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 4;
            label5.Text = "Importe Total";
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(90, 70);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(218, 23);
            txtDniCliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "DNI Cliente";
            // 
            // cbTipoBicicleta
            // 
            cbTipoBicicleta.FormattingEnabled = true;
            cbTipoBicicleta.Location = new Point(90, 31);
            cbTipoBicicleta.Name = "cbTipoBicicleta";
            cbTipoBicicleta.Size = new Size(218, 23);
            cbTipoBicicleta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo Bicicleta";
            // 
            // dgvAlquileres
            // 
            dgvAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlquileres.Location = new Point(395, 47);
            dgvAlquileres.MultiSelect = false;
            dgvAlquileres.Name = "dgvAlquileres";
            dgvAlquileres.ReadOnly = true;
            dgvAlquileres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlquileres.Size = new Size(738, 329);
            dgvAlquileres.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 50);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 2;
            label4.Text = "Id a Eliminar";
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(107, 47);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(141, 23);
            txtIdEliminar.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(107, 102);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 40);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eiminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(401, 101);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 42);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtIdModificar
            // 
            txtIdModificar.Location = new Point(147, 71);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(214, 23);
            txtIdModificar.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 77);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 5;
            label6.Text = "Id a Editar";
            // 
            // txtNuevoImporte
            // 
            txtNuevoImporte.Location = new Point(147, 112);
            txtNuevoImporte.Name = "txtNuevoImporte";
            txtNuevoImporte.Size = new Size(214, 23);
            txtNuevoImporte.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 120);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 8;
            label7.Text = "Nuevo Importe";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 158);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 10;
            label8.Text = "Nueva Fecha";
            // 
            // dtpNuevaFecha
            // 
            dtpNuevaFecha.Location = new Point(147, 152);
            dtpNuevaFecha.Name = "dtpNuevaFecha";
            dtpNuevaFecha.Size = new Size(214, 23);
            dtpNuevaFecha.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtIdEliminar);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Location = new Point(24, 404);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 197);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar Alquiler";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtIdModificar);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(dtpNuevaFecha);
            groupBox3.Controls.Add(btnEditar);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtNuevoImporte);
            groupBox3.Location = new Point(395, 404);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(538, 202);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Editar Alquiler";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 631);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dgvAlquileres);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtImporteTotal;
        private Label label5;
        private TextBox txtDniCliente;
        private Label label2;
        private ComboBox cbTipoBicicleta;
        private Label label1;
        private Button btnAlta;
        private DateTimePicker dtpFechaAlquiler;
        private Label label3;
        private DataGridView dgvAlquileres;
        private Label label4;
        private TextBox txtIdEliminar;
        private Button btnEliminar;
        private Button btnEditar;
        private TextBox txtIdModificar;
        private Label label6;
        private TextBox txtNuevoImporte;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpNuevaFecha;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnConfirmar;
        private Button btnBorrador;
    }
}
