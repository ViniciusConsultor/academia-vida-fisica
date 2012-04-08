namespace Academia.visao
{
    partial class AcademiaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcademiaPrincipal));
            this.button_matricula = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_relatorios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_matricula
            // 
            this.button_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_matricula.Image = ((System.Drawing.Image)(resources.GetObject("button_matricula.Image")));
            this.button_matricula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_matricula.Location = new System.Drawing.Point(62, 30);
            this.button_matricula.Name = "button_matricula";
            this.button_matricula.Size = new System.Drawing.Size(209, 115);
            this.button_matricula.TabIndex = 1;
            this.button_matricula.Text = "Matrícula";
            this.button_matricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_matricula.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(321, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 115);
            this.button3.TabIndex = 2;
            this.button3.Text = "Pagamento";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_relatorios
            // 
            this.button_relatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_relatorios.Image = ((System.Drawing.Image)(resources.GetObject("button_relatorios.Image")));
            this.button_relatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_relatorios.Location = new System.Drawing.Point(62, 177);
            this.button_relatorios.Name = "button_relatorios";
            this.button_relatorios.Size = new System.Drawing.Size(209, 115);
            this.button_relatorios.TabIndex = 3;
            this.button_relatorios.Text = "Relatórios";
            this.button_relatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_relatorios.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AcademiaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_relatorios);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_matricula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AcademiaPrincipal";
            this.Text = "AcademiaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_matricula;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_relatorios;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}