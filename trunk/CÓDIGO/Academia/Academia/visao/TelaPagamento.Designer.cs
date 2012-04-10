namespace Academia.visao
{
    partial class TelaPagamento
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_pagar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_mes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_cliente = new System.Windows.Forms.DataGridView();
            this.button_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_enome = new System.Windows.Forms.TextBox();
            this.button_ebuscar = new System.Windows.Forms.Button();
            this.dataGridView_ecliente = new System.Windows.Forms.DataGridView();
            this.dataGridView_mes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_evalor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_emes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_eano = new System.Windows.Forms.TextBox();
            this.button_editar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ecliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 497);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_pagar);
            this.tabPage1.Controls.Add(this.maskedTextBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBox_mes);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox_valor);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dataGridView_cliente);
            this.tabPage1.Controls.Add(this.button_buscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_nome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pagamento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_pagar
            // 
            this.button_pagar.Location = new System.Drawing.Point(355, 400);
            this.button_pagar.Name = "button_pagar";
            this.button_pagar.Size = new System.Drawing.Size(75, 23);
            this.button_pagar.TabIndex = 11;
            this.button_pagar.Text = "Pagar";
            this.button_pagar.UseVisualStyleBackColor = true;
            this.button_pagar.Click += new System.EventHandler(this.button_pagar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(523, 355);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(57, 20);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ano";
            // 
            // comboBox_mes
            // 
            this.comboBox_mes.FormattingEnabled = true;
            this.comboBox_mes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Desembro"});
            this.comboBox_mes.Location = new System.Drawing.Point(345, 355);
            this.comboBox_mes.Name = "comboBox_mes";
            this.comboBox_mes.Size = new System.Drawing.Size(121, 21);
            this.comboBox_mes.TabIndex = 7;
            this.comboBox_mes.Text = "Escolha o Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mes";
            // 
            // textBox_valor
            // 
            this.textBox_valor.Location = new System.Drawing.Point(225, 355);
            this.textBox_valor.Name = "textBox_valor";
            this.textBox_valor.Size = new System.Drawing.Size(61, 20);
            this.textBox_valor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor";
            // 
            // dataGridView_cliente
            // 
            this.dataGridView_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cliente.Location = new System.Drawing.Point(24, 73);
            this.dataGridView_cliente.MultiSelect = false;
            this.dataGridView_cliente.Name = "dataGridView_cliente";
            this.dataGridView_cliente.ReadOnly = true;
            this.dataGridView_cliente.Size = new System.Drawing.Size(729, 246);
            this.dataGridView_cliente.TabIndex = 3;
            this.dataGridView_cliente.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_cliente_RowHeaderMouseClick);
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(538, 26);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 2;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(206, 30);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(308, 20);
            this.textBox_nome.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_editar);
            this.tabPage2.Controls.Add(this.textBox_eano);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox_emes);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox_evalor);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataGridView_mes);
            this.tabPage2.Controls.Add(this.dataGridView_ecliente);
            this.tabPage2.Controls.Add(this.button_ebuscar);
            this.tabPage2.Controls.Add(this.textBox_enome);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Pagamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome";
            // 
            // textBox_enome
            // 
            this.textBox_enome.Location = new System.Drawing.Point(206, 26);
            this.textBox_enome.Name = "textBox_enome";
            this.textBox_enome.Size = new System.Drawing.Size(303, 20);
            this.textBox_enome.TabIndex = 1;
            // 
            // button_ebuscar
            // 
            this.button_ebuscar.Location = new System.Drawing.Point(533, 25);
            this.button_ebuscar.Name = "button_ebuscar";
            this.button_ebuscar.Size = new System.Drawing.Size(75, 23);
            this.button_ebuscar.TabIndex = 2;
            this.button_ebuscar.Text = "Buscar";
            this.button_ebuscar.UseVisualStyleBackColor = true;
            this.button_ebuscar.Click += new System.EventHandler(this.button_ebuscar_Click);
            // 
            // dataGridView_ecliente
            // 
            this.dataGridView_ecliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ecliente.Location = new System.Drawing.Point(21, 67);
            this.dataGridView_ecliente.MultiSelect = false;
            this.dataGridView_ecliente.Name = "dataGridView_ecliente";
            this.dataGridView_ecliente.ReadOnly = true;
            this.dataGridView_ecliente.Size = new System.Drawing.Size(731, 155);
            this.dataGridView_ecliente.TabIndex = 3;
            this.dataGridView_ecliente.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ecliente_RowHeaderMouseClick);
            // 
            // dataGridView_mes
            // 
            this.dataGridView_mes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mes.Location = new System.Drawing.Point(21, 228);
            this.dataGridView_mes.MultiSelect = false;
            this.dataGridView_mes.Name = "dataGridView_mes";
            this.dataGridView_mes.ReadOnly = true;
            this.dataGridView_mes.Size = new System.Drawing.Size(731, 128);
            this.dataGridView_mes.TabIndex = 4;
            this.dataGridView_mes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_mes_RowHeaderMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor";
            // 
            // textBox_evalor
            // 
            this.textBox_evalor.Location = new System.Drawing.Point(206, 382);
            this.textBox_evalor.Name = "textBox_evalor";
            this.textBox_evalor.Size = new System.Drawing.Size(55, 20);
            this.textBox_evalor.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mes";
            // 
            // textBox_emes
            // 
            this.textBox_emes.BackColor = System.Drawing.Color.White;
            this.textBox_emes.Enabled = false;
            this.textBox_emes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_emes.Location = new System.Drawing.Point(347, 382);
            this.textBox_emes.Name = "textBox_emes";
            this.textBox_emes.Size = new System.Drawing.Size(67, 20);
            this.textBox_emes.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ano";
            // 
            // textBox_eano
            // 
            this.textBox_eano.BackColor = System.Drawing.Color.White;
            this.textBox_eano.Enabled = false;
            this.textBox_eano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_eano.Location = new System.Drawing.Point(533, 382);
            this.textBox_eano.Name = "textBox_eano";
            this.textBox_eano.Size = new System.Drawing.Size(48, 20);
            this.textBox_eano.TabIndex = 10;
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(349, 416);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(75, 23);
            this.button_editar.TabIndex = 11;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // TelaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 547);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ecliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_cliente;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_mes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button_pagar;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.TextBox textBox_eano;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_emes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_evalor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_mes;
        private System.Windows.Forms.DataGridView dataGridView_ecliente;
        private System.Windows.Forms.Button button_ebuscar;
        private System.Windows.Forms.TextBox textBox_enome;
        private System.Windows.Forms.Label label5;
    }
}