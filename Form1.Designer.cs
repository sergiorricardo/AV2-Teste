namespace Teste.CSharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tela1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tela2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tela3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegadinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statustrip1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.formularioToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // formularioToolStripMenuItem
            // 
            this.formularioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tela1ToolStripMenuItem,
            this.tela2ToolStripMenuItem,
            this.tela3ToolStripMenuItem,
            this.pegadinhaToolStripMenuItem});
            this.formularioToolStripMenuItem.Name = "formularioToolStripMenuItem";
            this.formularioToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.formularioToolStripMenuItem.Text = "Formulario";
            this.formularioToolStripMenuItem.Click += new System.EventHandler(this.formularioToolStripMenuItem_Click);
            // 
            // tela1ToolStripMenuItem
            // 
            this.tela1ToolStripMenuItem.Name = "tela1ToolStripMenuItem";
            this.tela1ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.tela1ToolStripMenuItem.Text = "Pergunta";
            this.tela1ToolStripMenuItem.Click += new System.EventHandler(this.tela1ToolStripMenuItem_Click);
            // 
            // tela2ToolStripMenuItem
            // 
            this.tela2ToolStripMenuItem.Name = "tela2ToolStripMenuItem";
            this.tela2ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.tela2ToolStripMenuItem.Text = "Soma";
            this.tela2ToolStripMenuItem.Click += new System.EventHandler(this.tela2ToolStripMenuItem_Click);
            // 
            // tela3ToolStripMenuItem
            // 
            this.tela3ToolStripMenuItem.Name = "tela3ToolStripMenuItem";
            this.tela3ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.tela3ToolStripMenuItem.Text = "Teste";
            this.tela3ToolStripMenuItem.Click += new System.EventHandler(this.tela3ToolStripMenuItem_Click);
            // 
            // pegadinhaToolStripMenuItem
            // 
            this.pegadinhaToolStripMenuItem.Name = "pegadinhaToolStripMenuItem";
            this.pegadinhaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.pegadinhaToolStripMenuItem.Text = "Pegadinha";
            this.pegadinhaToolStripMenuItem.Click += new System.EventHandler(this.pegadinhaToolStripMenuItem_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomesToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // nomesToolStripMenuItem
            // 
            this.nomesToolStripMenuItem.Name = "nomesToolStripMenuItem";
            this.nomesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nomesToolStripMenuItem.Text = "Nomes";
            this.nomesToolStripMenuItem.Click += new System.EventHandler(this.nomesToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statustrip1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(759, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statustrip1
            // 
            this.statustrip1.Name = "statustrip1";
            this.statustrip1.Size = new System.Drawing.Size(42, 17);
            this.statustrip1.Text = "Online";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Teste.CSharp.Properties.Resources._1493354441_vector_65_08;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(759, 550);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tela1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tela2ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statustrip1;
        private System.Windows.Forms.ToolStripMenuItem tela3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegadinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

