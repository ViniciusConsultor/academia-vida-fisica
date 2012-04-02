namespace Academia.exemplos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_imagem = new System.Windows.Forms.PictureBox();
            this.button_iniciar = new System.Windows.Forms.Button();
            this.comboBox_camera = new System.Windows.Forms.ComboBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.statusStrip_barra = new System.Windows.Forms.StatusStrip();
            this.button_salvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox_imagem);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 247);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox_imagem
            // 
            this.pictureBox_imagem.Location = new System.Drawing.Point(12, 13);
            this.pictureBox_imagem.Name = "pictureBox_imagem";
            this.pictureBox_imagem.Size = new System.Drawing.Size(518, 219);
            this.pictureBox_imagem.TabIndex = 0;
            this.pictureBox_imagem.TabStop = false;
            // 
            // button_iniciar
            // 
            this.button_iniciar.Location = new System.Drawing.Point(161, 302);
            this.button_iniciar.Name = "button_iniciar";
            this.button_iniciar.Size = new System.Drawing.Size(75, 23);
            this.button_iniciar.TabIndex = 1;
            this.button_iniciar.Text = "Iniciar";
            this.button_iniciar.UseVisualStyleBackColor = true;
            this.button_iniciar.Click += new System.EventHandler(this.button_iniciar_Click);
            // 
            // comboBox_camera
            // 
            this.comboBox_camera.FormattingEnabled = true;
            this.comboBox_camera.Location = new System.Drawing.Point(24, 304);
            this.comboBox_camera.Name = "comboBox_camera";
            this.comboBox_camera.Size = new System.Drawing.Size(120, 21);
            this.comboBox_camera.TabIndex = 2;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(95, 16);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(58, 13);
            this.label_nome.TabIndex = 3;
            this.label_nome.Text = "Dispositivo";
            // 
            // statusStrip_barra
            // 
            this.statusStrip_barra.Location = new System.Drawing.Point(0, 428);
            this.statusStrip_barra.Name = "statusStrip_barra";
            this.statusStrip_barra.Size = new System.Drawing.Size(574, 22);
            this.statusStrip_barra.TabIndex = 4;
            this.statusStrip_barra.Text = "Progresso";
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(251, 302);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 23);
            this.button_salvar.TabIndex = 5;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.statusStrip_barra);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.comboBox_camera);
            this.Controls.Add(this.button_iniciar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_imagem;
        private System.Windows.Forms.Button button_iniciar;
        private System.Windows.Forms.ComboBox comboBox_camera;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.StatusStrip statusStrip_barra;
        private System.Windows.Forms.Button button_salvar;
    }
}

