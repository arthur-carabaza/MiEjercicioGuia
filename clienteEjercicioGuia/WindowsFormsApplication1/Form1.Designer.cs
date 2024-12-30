using System;

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
            this.conectar = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            this.contlbl = new System.Windows.Forms.Label();
            this.nuevoForms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(16, 85);
            this.conectar.Margin = new System.Windows.Forms.Padding(4);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(175, 47);
            this.conectar.TabIndex = 7;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(16, 140);
            this.desconectar.Margin = new System.Windows.Forms.Padding(4);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(175, 47);
            this.desconectar.TabIndex = 8;
            this.desconectar.Text = "Desconectar";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // contlbl
            // 
            this.contlbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.contlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contlbl.Location = new System.Drawing.Point(261, 141);
            this.contlbl.Name = "contlbl";
            this.contlbl.Size = new System.Drawing.Size(169, 59);
            this.contlbl.TabIndex = 9;
            // 
            // nuevoForms
            // 
            this.nuevoForms.Location = new System.Drawing.Point(16, 195);
            this.nuevoForms.Margin = new System.Windows.Forms.Padding(4);
            this.nuevoForms.Name = "nuevoForms";
            this.nuevoForms.Size = new System.Drawing.Size(175, 47);
            this.nuevoForms.TabIndex = 10;
            this.nuevoForms.Text = "Nuevo Formulario";
            this.nuevoForms.UseVisualStyleBackColor = true;
            this.nuevoForms.Click += new System.EventHandler(this.nuevoForms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 330);
            this.Controls.Add(this.nuevoForms);
            this.Controls.Add(this.contlbl);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.conectar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button desconectar;
        private System.Windows.Forms.Label contlbl;
        private System.Windows.Forms.Button nuevoForms;
    }
}

