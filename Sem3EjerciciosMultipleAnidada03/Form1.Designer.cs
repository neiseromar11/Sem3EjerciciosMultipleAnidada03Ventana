namespace Sem3EjerciciosMultipleAnidada03
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnCalcular = new Button();
            txtPago = new TextBox();
            txtDescuento = new TextBox();
            txtIncreSueldo = new TextBox();
            txtAumento = new TextBox();
            txtNroHijos = new TextBox();
            txtSueldo = new TextBox();
            cmbCat = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 34);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 95);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 1;
            label2.Text = "Sueldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 133);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 2;
            label3.Text = "Nro de Hijos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(36, 179);
            label4.Name = "label4";
            label4.Size = new Size(132, 17);
            label4.TabIndex = 3;
            label4.Text = "Incremento Sueldo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(36, 290);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 4;
            label5.Text = "Neto pago";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(36, 218);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 5;
            label6.Text = "Aumento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(36, 253);
            label7.Name = "label7";
            label7.Size = new Size(115, 17);
            label7.TabIndex = 6;
            label7.Text = "Descuento (3%)";
            label7.Click += label7_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(36, 329);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 39);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(261, 329);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 39);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(148, 329);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(82, 39);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button3_Click;
            // 
            // txtPago
            // 
            txtPago.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPago.Location = new Point(194, 281);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(100, 26);
            txtPago.TabIndex = 10;
            // 
            // txtDescuento
            // 
            txtDescuento.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescuento.Location = new Point(194, 244);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 26);
            txtDescuento.TabIndex = 11;
            // 
            // txtIncreSueldo
            // 
            txtIncreSueldo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtIncreSueldo.Location = new Point(194, 170);
            txtIncreSueldo.Name = "txtIncreSueldo";
            txtIncreSueldo.Size = new Size(100, 26);
            txtIncreSueldo.TabIndex = 12;
            // 
            // txtAumento
            // 
            txtAumento.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtAumento.Location = new Point(194, 209);
            txtAumento.Name = "txtAumento";
            txtAumento.Size = new Size(100, 26);
            txtAumento.TabIndex = 13;
            // 
            // txtNroHijos
            // 
            txtNroHijos.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNroHijos.Location = new Point(194, 124);
            txtNroHijos.Name = "txtNroHijos";
            txtNroHijos.Size = new Size(121, 26);
            txtNroHijos.TabIndex = 14;
            // 
            // txtSueldo
            // 
            txtSueldo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSueldo.Location = new Point(194, 86);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(121, 26);
            txtSueldo.TabIndex = 15;
            // 
            // cmbCat
            // 
            cmbCat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbCat.FormattingEnabled = true;
            cmbCat.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cmbCat.Location = new Point(194, 23);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(121, 27);
            cmbCat.TabIndex = 16;
            cmbCat.Text = "Elige";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 402);
            Controls.Add(cmbCat);
            Controls.Add(txtSueldo);
            Controls.Add(txtNroHijos);
            Controls.Add(txtAumento);
            Controls.Add(txtIncreSueldo);
            Controls.Add(txtDescuento);
            Controls.Add(txtPago);
            Controls.Add(btnCalcular);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Empleados";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnCalcular;
        private TextBox txtPago;
        private TextBox txtDescuento;
        private TextBox txtIncreSueldo;
        private TextBox txtAumento;
        private TextBox txtNroHijos;
        private TextBox txtSueldo;
        private ComboBox cmbCat;
    }
}