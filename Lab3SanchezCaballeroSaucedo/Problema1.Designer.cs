namespace Lab3SanchezCaballeroSaucedo
{
    partial class Problema1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnAbrirCuenta = new System.Windows.Forms.Button();
            this.rdbDepositos = new System.Windows.Forms.RadioButton();
            this.rdbRetiros = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstRetiros = new System.Windows.Forms.ListBox();
            this.lstDepositos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAbrirCuenta);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(140, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbRetiros);
            this.groupBox2.Controls.Add(this.rdbDepositos);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(140, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 116);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transacciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto Inicial :";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(241, 70);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(172, 28);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(241, 130);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(172, 28);
            this.txtMonto.TabIndex = 3;
            // 
            // btnAbrirCuenta
            // 
            this.btnAbrirCuenta.Location = new System.Drawing.Point(564, 87);
            this.btnAbrirCuenta.Name = "btnAbrirCuenta";
            this.btnAbrirCuenta.Size = new System.Drawing.Size(193, 52);
            this.btnAbrirCuenta.TabIndex = 4;
            this.btnAbrirCuenta.Text = "Abrir Cuenta";
            this.btnAbrirCuenta.UseVisualStyleBackColor = true;
            // 
            // rdbDepositos
            // 
            this.rdbDepositos.AutoSize = true;
            this.rdbDepositos.Location = new System.Drawing.Point(224, 52);
            this.rdbDepositos.Name = "rdbDepositos";
            this.rdbDepositos.Size = new System.Drawing.Size(110, 23);
            this.rdbDepositos.TabIndex = 0;
            this.rdbDepositos.TabStop = true;
            this.rdbDepositos.Text = "Depositos";
            this.rdbDepositos.UseVisualStyleBackColor = true;
            // 
            // rdbRetiros
            // 
            this.rdbRetiros.AutoSize = true;
            this.rdbRetiros.Location = new System.Drawing.Point(500, 52);
            this.rdbRetiros.Name = "rdbRetiros";
            this.rdbRetiros.Size = new System.Drawing.Size(83, 23);
            this.rdbRetiros.TabIndex = 1;
            this.rdbRetiros.TabStop = true;
            this.rdbRetiros.Text = "Retiros";
            this.rdbRetiros.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lstDepositos);
            this.groupBox3.Controls.Add(this.lstRetiros);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(140, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(818, 336);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuenta de Ahorros";
            // 
            // lstRetiros
            // 
            this.lstRetiros.FormattingEnabled = true;
            this.lstRetiros.ItemHeight = 19;
            this.lstRetiros.Location = new System.Drawing.Point(111, 91);
            this.lstRetiros.Name = "lstRetiros";
            this.lstRetiros.Size = new System.Drawing.Size(223, 213);
            this.lstRetiros.TabIndex = 3;
            // 
            // lstDepositos
            // 
            this.lstDepositos.FormattingEnabled = true;
            this.lstDepositos.ItemHeight = 19;
            this.lstDepositos.Location = new System.Drawing.Point(489, 91);
            this.lstDepositos.Name = "lstDepositos";
            this.lstDepositos.Size = new System.Drawing.Size(223, 213);
            this.lstDepositos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Retiros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Depositos";
            // 
            // Problema1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1105, 831);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Problema1";
            this.Text = "Gestion de Cuentas de Ahorro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrirCuenta;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbRetiros;
        private System.Windows.Forms.RadioButton rdbDepositos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstRetiros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDepositos;
    }
}