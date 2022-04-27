namespace VectoresCodigo
{
    partial class Verificar_Codigo
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
            this.buttonverificar = new System.Windows.Forms.Button();
            this.textBoxresultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxcodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonverificar
            // 
            this.buttonverificar.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonverificar.Location = new System.Drawing.Point(150, 75);
            this.buttonverificar.Name = "buttonverificar";
            this.buttonverificar.Size = new System.Drawing.Size(90, 38);
            this.buttonverificar.TabIndex = 9;
            this.buttonverificar.Text = "Verificar";
            this.buttonverificar.UseVisualStyleBackColor = true;
            this.buttonverificar.Click += new System.EventHandler(this.buttonverificar_Click);
            // 
            // textBoxresultado
            // 
            this.textBoxresultado.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxresultado.Location = new System.Drawing.Point(35, 119);
            this.textBoxresultado.Name = "textBoxresultado";
            this.textBoxresultado.Size = new System.Drawing.Size(319, 42);
            this.textBoxresultado.TabIndex = 8;
            this.textBoxresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxresultado.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresa aqui tu codigo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxcodigo
            // 
            this.textBoxcodigo.Location = new System.Drawing.Point(35, 46);
            this.textBoxcodigo.Name = "textBoxcodigo";
            this.textBoxcodigo.Size = new System.Drawing.Size(319, 23);
            this.textBoxcodigo.TabIndex = 5;
            this.textBoxcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Verificar_Codigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 178);
            this.Controls.Add(this.buttonverificar);
            this.Controls.Add(this.textBoxresultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxcodigo);
            this.Name = "Verificar_Codigo";
            this.Text = "Verificar_Codigo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonverificar;
        private TextBox textBoxresultado;
        private Label label1;
        private TextBox textBoxcodigo;
    }
}