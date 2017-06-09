namespace Teste.CSharp
{
    partial class Tela4
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
            this.label1 = new System.Windows.Forms.Label();
            this.Certa = new System.Windows.Forms.RadioButton();
            this.Errada = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = " Uma pata nascida no Chile bota um ovo na divisa Brasil-Chile. Segundo o Itamarat" +
    "y, a quem pertence o ovo?";
            // 
            // Certa
            // 
            this.Certa.AutoSize = true;
            this.Certa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Certa.Location = new System.Drawing.Point(121, 279);
            this.Certa.Name = "Certa";
            this.Certa.Size = new System.Drawing.Size(248, 22);
            this.Certa.TabIndex = 1;
            this.Certa.Text = "Brasil e Chile não fazem fronteira.";
            this.Certa.UseVisualStyleBackColor = true;
            this.Certa.CheckedChanged += new System.EventHandler(this.Certa_CheckedChanged);
            // 
            // Errada
            // 
            this.Errada.AutoSize = true;
            this.Errada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Errada.Location = new System.Drawing.Point(466, 279);
            this.Errada.Name = "Errada";
            this.Errada.Size = new System.Drawing.Size(57, 22);
            this.Errada.TabIndex = 2;
            this.Errada.Text = "Pato";
            this.Errada.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Teste.CSharp.Properties.Resources.e13873cfd49439371c74c044d37bb557;
            this.pictureBox1.Location = new System.Drawing.Point(168, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tela4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 519);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Errada);
            this.Controls.Add(this.Certa);
            this.Controls.Add(this.label1);
            this.Name = "Tela4";
            this.Text = "Tela4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Certa;
        private System.Windows.Forms.RadioButton Errada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}