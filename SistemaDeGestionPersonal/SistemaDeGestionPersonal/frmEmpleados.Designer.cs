namespace SistemaDeGestionPersonal
{
    partial class frmEmpleados
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            label3 = new Label();
            txtDui = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtContacto = new TextBox();
            label6 = new Label();
            txtSalario = new TextBox();
            cmbCargo = new ComboBox();
            label7 = new Label();
            cmbEstado = new ComboBox();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(229, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 29);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 2;
            label2.Text = "Codigo de empleado:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(229, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(184, 29);
            txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 4;
            label3.Text = "Dui:";
            // 
            // txtDui
            // 
            txtDui.Location = new Point(229, 115);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(184, 29);
            txtDui.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 169);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 6;
            label4.Text = "Cargo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 226);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 8;
            label5.Text = "Contacto";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(229, 226);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(184, 29);
            txtContacto.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 279);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 10;
            label6.Text = "Salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(229, 279);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(184, 29);
            txtSalario.TabIndex = 11;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Jefe", "Sud jefe", "Empleado" });
            cmbCargo.Location = new Point(229, 169);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(184, 29);
            cmbCargo.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 324);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 13;
            label7.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Desactivo" });
            cmbEstado.Location = new Point(229, 324);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(184, 29);
            cmbEstado.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(538, 20);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(185, 67);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(538, 149);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(185, 67);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(538, 286);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(185, 67);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(label7);
            Controls.Add(cmbCargo);
            Controls.Add(txtSalario);
            Controls.Add(label6);
            Controls.Add(txtContacto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDui);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtCodigo;
        private Label label3;
        private TextBox txtDui;
        private Label label4;
        private Label label5;
        private TextBox txtContacto;
        private Label label6;
        private TextBox txtSalario;
        private ComboBox cmbCargo;
        private Label label7;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}