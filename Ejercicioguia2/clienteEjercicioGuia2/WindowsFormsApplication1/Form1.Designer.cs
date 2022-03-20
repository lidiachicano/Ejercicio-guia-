namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.grados = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.far = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.celsius = new System.Windows.Forms.RadioButton();
            this.fahren = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "GRADOS";
            // 
            // grados
            // 
            this.grados.Location = new System.Drawing.Point(410, 80);
            this.grados.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grados.Name = "grados";
            this.grados.Size = new System.Drawing.Size(511, 44);
            this.grados.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(79, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(472, 88);
            this.button1.TabIndex = 4;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.far);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.celsius);
            this.groupBox1.Controls.Add(this.fahren);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grados);
            this.groupBox1.Location = new System.Drawing.Point(73, 296);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Size = new System.Drawing.Size(1150, 575);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(327, 107);
            this.button2.TabIndex = 12;
            this.button2.Text = "enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // far
            // 
            this.far.Location = new System.Drawing.Point(410, 167);
            this.far.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.far.Name = "far";
            this.far.Size = new System.Drawing.Size(511, 44);
            this.far.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 72);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fahrenheit";
            // 
            // celsius
            // 
            this.celsius.AutoSize = true;
            this.celsius.Location = new System.Drawing.Point(367, 234);
            this.celsius.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.celsius.Name = "celsius";
            this.celsius.Size = new System.Drawing.Size(487, 41);
            this.celsius.TabIndex = 7;
            this.celsius.TabStop = true;
            this.celsius.Text = "Convertir grados a Fahrenheit";
            this.celsius.UseVisualStyleBackColor = true;
            // 
            // fahren
            // 
            this.fahren.AutoSize = true;
            this.fahren.Location = new System.Drawing.Point(367, 293);
            this.fahren.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.fahren.Name = "fahren";
            this.fahren.Size = new System.Drawing.Size(487, 41);
            this.fahren.TabIndex = 7;
            this.fahren.TabStop = true;
            this.fahren.Text = "Convertir Fahrenheit a grados";
            this.fahren.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(79, 945);
            this.button3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(466, 151);
            this.button3.TabIndex = 10;
            this.button3.Text = "desconectar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2347, 1600);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox grados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton celsius;
        private System.Windows.Forms.RadioButton fahren;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox far;
        private System.Windows.Forms.Button button2;
    }
}

