using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Academia.dados;
using System.Data;
using System.Data.SqlClient;

namespace Academia.negocio
{
    public class PagamentoController
    {
        private PagamentoDB pagamentoDB = null;

        public PagamentoController()
        {
            this.pagamentoDB = new PagamentoDB();
        }

        public void Inserir(Pagamento pagamento)
        {
            int matricula = pagamento.IdMatricula;

            // verifica pagamento atrasado
            this.PagamentoAtrasado(matricula);

            // efetua o pagamento
            this.pagamentoDB.Inserir(pagamento);
        }

        public void Alterar(Pagamento pagamento)
        {
            this.pagamentoDB.Alterar(pagamento);
        }

        public DataTable GetClienteNome(string nome)
        {
            return this.pagamentoDB.GetClienteNome(nome);
        }

        public void PagamentoAtrasado(int id_matricula)
        {
            this.pagamentoDB.PagamentoAtrasado(id_matricula);
        }


        public DataTable GetPatamentosCliente(int matricula)
        {
            return this.pagamentoDB.GetPagamentosCliente(matricula);
        }
    }
}
