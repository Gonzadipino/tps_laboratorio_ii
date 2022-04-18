namespace Calculadora_TP1
{
    partial class FormCalculadora
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
            this.Operador = new System.Windows.Forms.ComboBox();
            this.Muestreo = new System.Windows.Forms.ListBox();
            this.Operar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.ConvertirABinario = new System.Windows.Forms.Button();
            this.ConvertirADecimal = new System.Windows.Forms.Button();
            this.textNumero1 = new System.Windows.Forms.TextBox();
            this.textNumero2 = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Operador
            // 
            this.Operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Operador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Operador.FormattingEnabled = true;
            this.Operador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.Operador.Location = new System.Drawing.Point(187, 73);
            this.Operador.Name = "Operador";
            this.Operador.Size = new System.Drawing.Size(38, 31);
            this.Operador.TabIndex = 0;
            this.Operador.SelectedIndexChanged += new System.EventHandler(this.Operador_SelectedIndexChanged);
            // 
            // Muestreo
            // 
            this.Muestreo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Muestreo.FormattingEnabled = true;
            this.Muestreo.ItemHeight = 23;
            this.Muestreo.Location = new System.Drawing.Point(419, 12);
            this.Muestreo.Name = "Muestreo";
            this.Muestreo.Size = new System.Drawing.Size(408, 257);
            this.Muestreo.TabIndex = 1;
            this.Muestreo.SelectedIndexChanged += new System.EventHandler(this.Muestreo_SelectedIndexChanged);
            // 
            // Operar
            // 
            this.Operar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Operar.Location = new System.Drawing.Point(12, 159);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(94, 29);
            this.Operar.TabIndex = 2;
            this.Operar.Text = "Operar";
            this.Operar.UseVisualStyleBackColor = true;
            this.Operar.Click += new System.EventHandler(this.Operar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Limpiar.Location = new System.Drawing.Point(157, 159);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(94, 29);
            this.Limpiar.TabIndex = 3;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cerrar.Location = new System.Drawing.Point(305, 159);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(94, 29);
            this.Cerrar.TabIndex = 4;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // ConvertirABinario
            // 
            this.ConvertirABinario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConvertirABinario.Location = new System.Drawing.Point(12, 236);
            this.ConvertirABinario.Name = "ConvertirABinario";
            this.ConvertirABinario.Size = new System.Drawing.Size(171, 29);
            this.ConvertirABinario.TabIndex = 5;
            this.ConvertirABinario.Text = "Convertir a Binario";
            this.ConvertirABinario.UseVisualStyleBackColor = true;
            this.ConvertirABinario.Click += new System.EventHandler(this.ConvertirABinario_Click);
            // 
            // ConvertirADecimal
            // 
            this.ConvertirADecimal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConvertirADecimal.Location = new System.Drawing.Point(217, 236);
            this.ConvertirADecimal.Name = "ConvertirADecimal";
            this.ConvertirADecimal.Size = new System.Drawing.Size(182, 29);
            this.ConvertirADecimal.TabIndex = 6;
            this.ConvertirADecimal.Text = "Convertir a Decimal";
            this.ConvertirADecimal.UseVisualStyleBackColor = true;
            this.ConvertirADecimal.Click += new System.EventHandler(this.ConvertirADecimal_Click);
            // 
            // textNumero1
            // 
            this.textNumero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNumero1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNumero1.Location = new System.Drawing.Point(12, 73);
            this.textNumero1.Name = "textNumero1";
            this.textNumero1.Size = new System.Drawing.Size(125, 30);
            this.textNumero1.TabIndex = 1;
            this.textNumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textNumero2
            // 
            this.textNumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNumero2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNumero2.Location = new System.Drawing.Point(274, 73);
            this.textNumero2.Name = "textNumero2";
            this.textNumero2.Size = new System.Drawing.Size(125, 30);
            this.textNumero2.TabIndex = 1;
            this.textNumero2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelResultado
            // 
            this.labelResultado.BackColor = System.Drawing.SystemColors.Control;
            this.labelResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResultado.Location = new System.Drawing.Point(12, 12);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(387, 37);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.Text = "0";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 281);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textNumero2);
            this.Controls.Add(this.textNumero1);
            this.Controls.Add(this.ConvertirADecimal);
            this.Controls.Add(this.ConvertirABinario);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Operar);
            this.Controls.Add(this.Muestreo);
            this.Controls.Add(this.Operador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Gonzalo Di Pino 2°C";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Operador;
        private System.Windows.Forms.ListBox Muestreo;
        private System.Windows.Forms.Button Operar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button ConvertirABinario;
        private System.Windows.Forms.Button ConvertirADecimal;
        private System.Windows.Forms.TextBox textNumero1;
        private System.Windows.Forms.TextBox textNumero2;
        private System.Windows.Forms.Label labelResultado;
    }
}
