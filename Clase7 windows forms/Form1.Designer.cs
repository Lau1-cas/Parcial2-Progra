
namespace Clase7_windows_forms
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
            this.btnArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.btnNombres = new System.Windows.Forms.Button();
            this.Ejer2 = new System.Windows.Forms.Button();
            this.Ejer3 = new System.Windows.Forms.Button();
            this.Ejer4 = new System.Windows.Forms.Button();
            this.Ejer5 = new System.Windows.Forms.Button();
            this.Ejer1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArreglo
            // 
            this.btnArreglo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnArreglo.Location = new System.Drawing.Point(740, 322);
            this.btnArreglo.Name = "btnArreglo";
            this.btnArreglo.Size = new System.Drawing.Size(75, 23);
            this.btnArreglo.TabIndex = 0;
            this.btnArreglo.Text = "Arreglo";
            this.btnArreglo.UseVisualStyleBackColor = false;
            this.btnArreglo.Click += new System.EventHandler(this.btnArreglo_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(463, 3);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(262, 342);
            this.listBoxResultado.TabIndex = 1;
            this.listBoxResultado.SelectedIndexChanged += new System.EventHandler(this.listBoxResultado_SelectedIndexChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCargar.FlatAppearance.BorderSize = 2;
            this.btnCargar.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(32, 42);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 37);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar archivo";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxContenido.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxContenido.Location = new System.Drawing.Point(125, 3);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContenido.Size = new System.Drawing.Size(262, 342);
            this.textBoxContenido.TabIndex = 3;
            // 
            // btnNombres
            // 
            this.btnNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNombres.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnNombres.FlatAppearance.BorderSize = 2;
            this.btnNombres.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombres.Location = new System.Drawing.Point(32, 100);
            this.btnNombres.Name = "btnNombres";
            this.btnNombres.Size = new System.Drawing.Size(75, 37);
            this.btnNombres.TabIndex = 4;
            this.btnNombres.Text = "Nombres";
            this.btnNombres.UseVisualStyleBackColor = false;
            this.btnNombres.Click += new System.EventHandler(this.btnNombres_Click);
            // 
            // Ejer2
            // 
            this.Ejer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ejer2.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejer2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ejer2.Location = new System.Drawing.Point(125, 375);
            this.Ejer2.Name = "Ejer2";
            this.Ejer2.Size = new System.Drawing.Size(262, 43);
            this.Ejer2.TabIndex = 5;
            this.Ejer2.Text = "Promedio Alumnos Por Sección";
            this.Ejer2.UseVisualStyleBackColor = false;
            this.Ejer2.Click += new System.EventHandler(this.Ejer2_Click);
            // 
            // Ejer3
            // 
            this.Ejer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ejer3.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejer3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ejer3.Location = new System.Drawing.Point(125, 424);
            this.Ejer3.Name = "Ejer3";
            this.Ejer3.Size = new System.Drawing.Size(262, 43);
            this.Ejer3.TabIndex = 6;
            this.Ejer3.Text = "Nombres Alumnos Por Sección";
            this.Ejer3.UseVisualStyleBackColor = false;
            this.Ejer3.Click += new System.EventHandler(this.Ejer3_Click);
            // 
            // Ejer4
            // 
            this.Ejer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ejer4.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejer4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ejer4.Location = new System.Drawing.Point(472, 375);
            this.Ejer4.Name = "Ejer4";
            this.Ejer4.Size = new System.Drawing.Size(262, 43);
            this.Ejer4.TabIndex = 7;
            this.Ejer4.Text = "Promedio Parcial Por Sección";
            this.Ejer4.UseVisualStyleBackColor = false;
            // 
            // Ejer5
            // 
            this.Ejer5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ejer5.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejer5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ejer5.Location = new System.Drawing.Point(472, 424);
            this.Ejer5.Name = "Ejer5";
            this.Ejer5.Size = new System.Drawing.Size(262, 43);
            this.Ejer5.TabIndex = 8;
            this.Ejer5.Text = "Nombre y sumatoria Parciales";
            this.Ejer5.UseVisualStyleBackColor = false;
            // 
            // Ejer1
            // 
            this.Ejer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ejer1.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejer1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ejer1.Location = new System.Drawing.Point(298, 477);
            this.Ejer1.Name = "Ejer1";
            this.Ejer1.Size = new System.Drawing.Size(262, 43);
            this.Ejer1.TabIndex = 9;
            this.Ejer1.Text = "Promedio de una columna especifica";
            this.Ejer1.UseVisualStyleBackColor = false;
            this.Ejer1.Click += new System.EventHandler(this.Ejer1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(32, 160);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 37);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(921, 532);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Ejer1);
            this.Controls.Add(this.Ejer5);
            this.Controls.Add(this.Ejer4);
            this.Controls.Add(this.Ejer3);
            this.Controls.Add(this.Ejer2);
            this.Controls.Add(this.btnNombres);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.btnArreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.Button btnNombres;
        private System.Windows.Forms.Button Ejer2;
        private System.Windows.Forms.Button Ejer3;
        private System.Windows.Forms.Button Ejer4;
        private System.Windows.Forms.Button Ejer5;
        private System.Windows.Forms.Button Ejer1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

