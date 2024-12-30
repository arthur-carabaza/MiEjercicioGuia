namespace WindowsFormsApplication1
{
    partial class FormsServ
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
            this.codForm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Palindromo = new System.Windows.Forms.RadioButton();
            this.mayusculas = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.TextBox();
            this.Alto = new System.Windows.Forms.RadioButton();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codForm
            // 
            this.codForm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.codForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codForm.Location = new System.Drawing.Point(589, 50);
            this.codForm.Name = "codForm";
            this.codForm.Size = new System.Drawing.Size(169, 59);
            this.codForm.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.Palindromo);
            this.groupBox1.Controls.Add(this.mayusculas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Altura);
            this.groupBox1.Controls.Add(this.Alto);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(42, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 347);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // Palindromo
            // 
            this.Palindromo.AutoSize = true;
            this.Palindromo.Location = new System.Drawing.Point(155, 226);
            this.Palindromo.Margin = new System.Windows.Forms.Padding(4);
            this.Palindromo.Name = "Palindromo";
            this.Palindromo.Size = new System.Drawing.Size(225, 20);
            this.Palindromo.TabIndex = 12;
            this.Palindromo.TabStop = true;
            this.Palindromo.Text = "Dime si mi nombre el Palindromo";
            this.Palindromo.UseVisualStyleBackColor = true;
            // 
            // mayusculas
            // 
            this.mayusculas.AutoSize = true;
            this.mayusculas.Location = new System.Drawing.Point(155, 254);
            this.mayusculas.Margin = new System.Windows.Forms.Padding(4);
            this.mayusculas.Name = "mayusculas";
            this.mayusculas.Size = new System.Drawing.Size(264, 20);
            this.mayusculas.TabIndex = 11;
            this.mayusculas.TabStop = true;
            this.mayusculas.Text = "Devuelveme mi nombre en mayúsculas\r\n";
            this.mayusculas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Altura";
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(155, 77);
            this.Altura.Margin = new System.Windows.Forms.Padding(4);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(217, 22);
            this.Altura.TabIndex = 9;
            // 
            // Alto
            // 
            this.Alto.AutoSize = true;
            this.Alto.Location = new System.Drawing.Point(155, 198);
            this.Alto.Margin = new System.Windows.Forms.Padding(4);
            this.Alto.Name = "Alto";
            this.Alto.Size = new System.Drawing.Size(123, 20);
            this.Alto.TabIndex = 8;
            this.Alto.TabStop = true;
            this.Alto.Text = "Dime si soy alto";
            this.Alto.UseVisualStyleBackColor = true;
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(155, 170);
            this.Longitud.Margin = new System.Windows.Forms.Padding(4);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(209, 20);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(155, 142);
            this.Bonito.Margin = new System.Windows.Forms.Padding(4);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(197, 20);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(155, 38);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 22);
            this.nombre.TabIndex = 3;
            // 
            // FormsServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 525);
            this.Controls.Add(this.codForm);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormsServ";
            this.Text = "FormsServ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label codForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Palindromo;
        private System.Windows.Forms.RadioButton mayusculas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Altura;
        private System.Windows.Forms.RadioButton Alto;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nombre;
    }
}