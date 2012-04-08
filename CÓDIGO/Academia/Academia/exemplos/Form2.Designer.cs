namespace Academia.exemplos
{
    partial class Form2
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
            this.pictureBox_foto = new System.Windows.Forms.PictureBox();
            this.button_iniciar = new System.Windows.Forms.Button();
            this.button_foto = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.comboBox_dispositivo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_foto
            // 
            this.pictureBox_foto.Location = new System.Drawing.Point(142, 12);
            this.pictureBox_foto.Name = "pictureBox_foto";
            this.pictureBox_foto.Size = new System.Drawing.Size(310, 364);
            this.pictureBox_foto.TabIndex = 0;
            this.pictureBox_foto.TabStop = false;
            // 
            // button_iniciar
            // 
            this.button_iniciar.Location = new System.Drawing.Point(142, 408);
            this.button_iniciar.Name = "button_iniciar";
            this.button_iniciar.Size = new System.Drawing.Size(75, 23);
            this.button_iniciar.TabIndex = 1;
            this.button_iniciar.Text = "INICIAR";
            this.button_iniciar.UseVisualStyleBackColor = true;
            // 
            // button_foto
            // 
            this.button_foto.Location = new System.Drawing.Point(258, 408);
            this.button_foto.Name = "button_foto";
            this.button_foto.Size = new System.Drawing.Size(75, 23);
            this.button_foto.TabIndex = 2;
            this.button_foto.Text = "FOTO";
            this.button_foto.UseVisualStyleBackColor = true;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(377, 408);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 3;
            this.button_cancelar.Text = "CANCELAR";
            this.button_cancelar.UseMnemonic = false;
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // comboBox_dispositivo
            // 
            this.comboBox_dispositivo.FormattingEnabled = true;
            this.comboBox_dispositivo.Location = new System.Drawing.Point(12, 408);
            this.comboBox_dispositivo.Name = "comboBox_dispositivo";
            this.comboBox_dispositivo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_dispositivo.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 452);
            this.Controls.Add(this.comboBox_dispositivo);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_foto);
            this.Controls.Add(this.button_iniciar);
            this.Controls.Add(this.pictureBox_foto);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_foto;
        private System.Windows.Forms.Button button_iniciar;
        private System.Windows.Forms.Button button_foto;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.ComboBox comboBox_dispositivo;
    }
}