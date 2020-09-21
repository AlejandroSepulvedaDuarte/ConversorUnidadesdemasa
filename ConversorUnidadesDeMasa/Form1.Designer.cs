namespace ConversorUnidadesDeMasa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.gbOperador = new System.Windows.Forms.GroupBox();
            this.rbdag = new System.Windows.Forms.RadioButton();
            this.rbgramos = new System.Windows.Forms.RadioButton();
            this.rbmg = new System.Windows.Forms.RadioButton();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.btnconvertirnuevopeso = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.gbOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversión De Unidades De Masa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(0, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa un peso en Kilogramos:\r\n";
            // 
            // txtpeso
            // 
            this.txtpeso.Font = new System.Drawing.Font("Arial", 14F);
            this.txtpeso.ForeColor = System.Drawing.Color.Maroon;
            this.txtpeso.Location = new System.Drawing.Point(336, 115);
            this.txtpeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(109, 29);
            this.txtpeso.TabIndex = 2;
            // 
            // gbOperador
            // 
            this.gbOperador.Controls.Add(this.rbdag);
            this.gbOperador.Controls.Add(this.rbgramos);
            this.gbOperador.Controls.Add(this.rbmg);
            this.gbOperador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperador.Location = new System.Drawing.Point(473, 115);
            this.gbOperador.Margin = new System.Windows.Forms.Padding(4);
            this.gbOperador.Name = "gbOperador";
            this.gbOperador.Padding = new System.Windows.Forms.Padding(4);
            this.gbOperador.Size = new System.Drawing.Size(211, 132);
            this.gbOperador.TabIndex = 3;
            this.gbOperador.TabStop = false;
            this.gbOperador.Text = "Unidades de masa";
            // 
            // rbdag
            // 
            this.rbdag.AutoSize = true;
            this.rbdag.Checked = true;
            this.rbdag.ForeColor = System.Drawing.Color.Maroon;
            this.rbdag.Location = new System.Drawing.Point(8, 27);
            this.rbdag.Margin = new System.Windows.Forms.Padding(4);
            this.rbdag.Name = "rbdag";
            this.rbdag.Size = new System.Drawing.Size(130, 23);
            this.rbdag.TabIndex = 2;
            this.rbdag.TabStop = true;
            this.rbdag.Text = "Decagramos:";
            this.rbdag.UseVisualStyleBackColor = true;
            // 
            // rbgramos
            // 
            this.rbgramos.AutoSize = true;
            this.rbgramos.ForeColor = System.Drawing.Color.Maroon;
            this.rbgramos.Location = new System.Drawing.Point(8, 89);
            this.rbgramos.Margin = new System.Windows.Forms.Padding(4);
            this.rbgramos.Name = "rbgramos";
            this.rbgramos.Size = new System.Drawing.Size(93, 23);
            this.rbgramos.TabIndex = 1;
            this.rbgramos.TabStop = true;
            this.rbgramos.Text = "Gramos:";
            this.rbgramos.UseVisualStyleBackColor = true;
            // 
            // rbmg
            // 
            this.rbmg.AutoSize = true;
            this.rbmg.ForeColor = System.Drawing.Color.Maroon;
            this.rbmg.Location = new System.Drawing.Point(8, 58);
            this.rbmg.Margin = new System.Windows.Forms.Padding(4);
            this.rbmg.Name = "rbmg";
            this.rbmg.Size = new System.Drawing.Size(116, 23);
            this.rbmg.TabIndex = 0;
            this.rbmg.Text = "Miligramos:";
            this.rbmg.UseVisualStyleBackColor = true;
            // 
            // btnconvertir
            // 
            this.btnconvertir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertir.Location = new System.Drawing.Point(336, 164);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(109, 32);
            this.btnconvertir.TabIndex = 4;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // btnconvertirnuevopeso
            // 
            this.btnconvertirnuevopeso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertirnuevopeso.Location = new System.Drawing.Point(473, 254);
            this.btnconvertirnuevopeso.Name = "btnconvertirnuevopeso";
            this.btnconvertirnuevopeso.Size = new System.Drawing.Size(211, 32);
            this.btnconvertirnuevopeso.TabIndex = 7;
            this.btnconvertirnuevopeso.Text = "Ingresar un nuevo peso ";
            this.btnconvertirnuevopeso.UseVisualStyleBackColor = true;
            this.btnconvertirnuevopeso.Click += new System.EventHandler(this.btnconvertirnuevopeso_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.ForeColor = System.Drawing.Color.Navy;
            this.lblresultado.Location = new System.Drawing.Point(13, 273);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(127, 24);
            this.lblresultado.TabIndex = 8;
            this.lblresultado.Text = "Conversion";
            this.lblresultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 311);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnconvertirnuevopeso);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.gbOperador);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbOperador.ResumeLayout(false);
            this.gbOperador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.GroupBox gbOperador;
        private System.Windows.Forms.RadioButton rbdag;
        private System.Windows.Forms.RadioButton rbgramos;
        private System.Windows.Forms.RadioButton rbmg;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Button btnconvertirnuevopeso;
        private System.Windows.Forms.Label lblresultado;
    }
}

