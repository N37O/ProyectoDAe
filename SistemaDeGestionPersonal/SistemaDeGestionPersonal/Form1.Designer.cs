namespace SistemaDeGestionPersonal
{
    partial class frmPrincipal
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
            btnEmpleados = new Button();
            btmAsistencias = new Button();
            btnCalcularPago = new Button();
            btnConsulta = new Button();
            SuspendLayout();
            // 
            // btnEmpleados
            // 
            btnEmpleados.Location = new Point(75, 37);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(132, 49);
            btnEmpleados.TabIndex = 0;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btmAsistencias
            // 
            btmAsistencias.Location = new Point(75, 117);
            btmAsistencias.Name = "btmAsistencias";
            btmAsistencias.Size = new Size(132, 49);
            btmAsistencias.TabIndex = 2;
            btmAsistencias.Text = "Asistencias";
            btmAsistencias.UseVisualStyleBackColor = true;
            btmAsistencias.Click += btmAsistencias_Click;
            // 
            // btnCalcularPago
            // 
            btnCalcularPago.Location = new Point(362, 37);
            btnCalcularPago.Name = "btnCalcularPago";
            btnCalcularPago.Size = new Size(132, 49);
            btnCalcularPago.TabIndex = 3;
            btnCalcularPago.Text = "Calcular pago ";
            btnCalcularPago.UseVisualStyleBackColor = true;
            btnCalcularPago.Click += btnCalcularPago_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(362, 117);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(132, 49);
            btnConsulta.TabIndex = 4;
            btnConsulta.Text = "Consultas";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(608, 312);
            Controls.Add(btnConsulta);
            Controls.Add(btnCalcularPago);
            Controls.Add(btmAsistencias);
            Controls.Add(btnEmpleados);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmpleados;
        private Button btmAsistencias;
        private Button btnCalcularPago;
        private Button btnConsulta;
    }
}
