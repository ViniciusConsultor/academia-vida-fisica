using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Academia.dados;
using Academia.negocio;

namespace Academia.visao
{
    public partial class TelaPagamento : Form
    {
        private PagamentoController pagamentoControl = null;

        private int rowSelected = -1;
        private int eRowSelected = -1;
        private int mesRowSelected = -1;

        public TelaPagamento()
        {
            InitializeComponent();

            this.pagamentoControl = new PagamentoController();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            string nome = this.textBox_nome.Text;

            this.dataGridView_cliente.DataSource = this.pagamentoControl.GetClienteNome(nome);
        }

        private void dataGridView_cliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowCount = this.dataGridView_cliente.RowCount;
            int rowIndex = e.RowIndex;
            this.rowSelected = rowIndex;

            if (rowIndex < (rowCount - 1))
            {
                string valor = this.dataGridView_cliente.Rows[rowIndex].Cells[4].Value.ToString();
                this.textBox_valor.Text = valor;
            }
        }

        private void button_pagar_Click(object sender, EventArgs e)
        {
            int rowCount = this.dataGridView_cliente.RowCount;
            int rowIndex = this.rowSelected;

            if (rowIndex < (rowCount - 1))
            {
                string str_mat = this.dataGridView_cliente.Rows[this.rowSelected].Cells[0].Value.ToString();
                int matricula = Convert.ToInt32(str_mat);
                decimal valor = Convert.ToDecimal(this.textBox_valor.Text);
                DateTime data = DateTime.Now;
                int ano = Convert.ToInt32(this.maskedTextBox1.Text);
                int mes = this.comboBox_mes.SelectedIndex + 1;
                string status = "PAGO";

                Pagamento pagamento = new Pagamento();
                pagamento.IdMatricula = matricula;
                pagamento.Valor = valor;
                pagamento.DataPagamento = data;
                pagamento.Ano = ano;
                pagamento.Mes = mes;
                pagamento.StatusPag = status;

                this.pagamentoControl.Inserir(pagamento);

                MessageBox.Show("Pagamento Efetuado");
            }

        }

        private void button_ebuscar_Click(object sender, EventArgs e)
        {
            string nome = this.textBox_nome.Text;

            this.dataGridView_ecliente.DataSource = this.pagamentoControl.GetClienteNome(nome);
        }

        private void dataGridView_ecliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowCount = this.dataGridView_ecliente.RowCount;
            this.eRowSelected = e.RowIndex;

            if (this.eRowSelected < (rowCount - 1))
            {
                int matricula = Convert.ToInt32(this.dataGridView_ecliente.Rows[this.eRowSelected].Cells[0].Value.ToString());

                this.dataGridView_mes.DataSource = this.pagamentoControl.GetPatamentosCliente(matricula);
            }
        }

        private void dataGridView_mes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowCount = this.dataGridView_mes.RowCount;
            this.mesRowSelected = e.RowIndex;

            if (this.mesRowSelected < (rowCount - 1))
            {
                string valor = this.dataGridView_mes.Rows[this.mesRowSelected].Cells[2].Value.ToString();
                string ano = this.dataGridView_mes.Rows[this.mesRowSelected].Cells[4].Value.ToString();
                string mes = this.dataGridView_mes.Rows[this.mesRowSelected].Cells[5].Value.ToString();

                this.textBox_evalor.Text = valor;
                this.textBox_emes.Text = mes;
                this.textBox_eano.Text = ano;
            }
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            int rowCount = this.dataGridView_mes.RowCount;
            int rowIndex = this.mesRowSelected;

            if (rowIndex < (rowCount - 1))
            {
                int id_pagamento = Convert.ToInt32(this.dataGridView_mes.Rows[rowIndex].Cells[0].Value.ToString());
                int id_matricula = Convert.ToInt32(this.dataGridView_mes.Rows[rowIndex].Cells[1].Value.ToString());
                int ano = Convert.ToInt32(this.dataGridView_mes.Rows[rowIndex].Cells[4].Value.ToString());
                int mes = Convert.ToInt32(this.dataGridView_mes.Rows[rowIndex].Cells[5].Value.ToString());

                decimal valor = Convert.ToDecimal(this.textBox_evalor.Text);
                DateTime data = DateTime.Now;
                string status = "PAGO";

                Pagamento pagamento = new Pagamento();
                pagamento.IdPagamento = id_pagamento;
                pagamento.IdMatricula = id_matricula;
                pagamento.Valor = valor;
                pagamento.Ano = ano;
                pagamento.Mes = mes;
                pagamento.DataPagamento = data;
                pagamento.StatusPag = status;

                this.pagamentoControl.Alterar(pagamento);

                MessageBox.Show("Pagamento Editado com Sucesso!");
            }
        }
    }
}
