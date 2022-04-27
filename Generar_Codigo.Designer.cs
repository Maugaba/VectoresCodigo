namespace VectoresCodigo
{
    partial class Generar_Codigo
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
            this.textBoxcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelcod = new System.Windows.Forms.Label();
            this.textBoxcodfinal = new System.Windows.Forms.TextBox();
            this.buttongenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxcodigo
            // 
            this.textBoxcodigo.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxcodigo.Location = new System.Drawing.Point(35, 46);
            this.textBoxcodigo.Name = "textBoxcodigo";
            this.textBoxcodigo.Size = new System.Drawing.Size(319, 44);
            this.textBoxcodigo.TabIndex = 0;
            this.textBoxcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa aqui tu numero de carné: ";
            // 
            // labelcod
            // 
            this.labelcod.AutoSize = true;
            this.labelcod.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelcod.Location = new System.Drawing.Point(12, 130);
            this.labelcod.Name = "labelcod";
            this.labelcod.Size = new System.Drawing.Size(363, 34);
            this.labelcod.TabIndex = 2;
            this.labelcod.Text = "Este es el nuevo codigo de carné: ";
            this.labelcod.Visible = false;
            // 
            // textBoxcodfinal
            // 
            this.textBoxcodfinal.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxcodfinal.Location = new System.Drawing.Point(35, 167);
            this.textBoxcodfinal.Name = "textBoxcodfinal";
            this.textBoxcodfinal.Size = new System.Drawing.Size(319, 44);
            this.textBoxcodfinal.TabIndex = 3;
            this.textBoxcodfinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxcodfinal.Visible = false;
            // 
            // buttongenerar
            // 
            this.buttongenerar.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttongenerar.Location = new System.Drawing.Point(149, 96);
            this.buttongenerar.Name = "buttongenerar";
            this.buttongenerar.Size = new System.Drawing.Size(90, 38);
            this.buttongenerar.TabIndex = 4;
            this.buttongenerar.Text = "Generar";
            this.buttongenerar.UseVisualStyleBackColor = true;
            this.buttongenerar.Click += new System.EventHandler(this.buttongenerar_Click);
            // 
            // Generar_Codigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 224);
            this.Controls.Add(this.buttongenerar);
            this.Controls.Add(this.textBoxcodfinal);
            this.Controls.Add(this.labelcod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxcodigo);
            this.Name = "Generar_Codigo";
            this.Text = "Generar_Codigo";
            this.Load += new System.EventHandler(this.Generar_Codigo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxcodigo;
        private Label label1;
        private Label labelcod;
        private TextBox textBoxcodfinal;
        private Button buttongenerar;
    }
}