using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Academia.dados
{
    public class Pagamento
    {
        private int id_pagamento;
        private int id_matricula;
        private decimal valor;
        private DateTime data_pagamento;
        private int ano;
        private int mes;
        private string status_pag;

        public int IdPagamento
        {
            get { return id_pagamento; }
            set { id_pagamento = value; }
        }

        public int IdMatricula
        {
            get { return id_matricula; }
            set { id_matricula = value; }
        }

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public DateTime DataPagamento
        {
            get { return data_pagamento; }
            set { data_pagamento = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public string StatusPag
        {
            get { return status_pag; }
            set { status_pag = value; }
        }
    }

    public class PagamentoDB
    {
        private string string_connection = ConfigurationManager.ConnectionStrings["Academia.Properties.Settings.academiaConnectionString"].ConnectionString;

        public void Inserir(Pagamento pagamento)
        {
            using (SqlConnection connection = new SqlConnection(this.string_connection))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    string sql = @"INSERT INTO TB_PAGAMENTO (ID_MATRICULA, VALOR, DATA_PAGAMENTO, ANO, MES, STATUS_PAG)
                                        VALUES (@MATRICULA, @VALOR, @DATA, @ANO, @MES, @STATUS)";

                    command.Connection = connection;
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@MATRICULA", pagamento.IdMatricula);
                    command.Parameters.AddWithValue("@VALOR", pagamento.Valor);
                    command.Parameters.AddWithValue("@DATA", pagamento.DataPagamento);
                    command.Parameters.AddWithValue("@ANO", pagamento.Ano);
                    command.Parameters.AddWithValue("@MES", pagamento.Mes);
                    command.Parameters.AddWithValue("@STATUS", pagamento.StatusPag);


                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();

                }
            }
        }

        public void Alterar(Pagamento pagamento)
        {
            using (SqlConnection connection = new SqlConnection(this.string_connection))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    string sql = @"UPDATE TB_PAGAMENTO
                                    SET VALOR = @VALOR, DATA_PAGAMENTO = @DATA, STATUS_PAG = @STATUS
                                   WHERE ID_PAGAMENTO = @PAGAMENTO AND ID_MATRICULA = @MATRICULA AND
                                         ANO = @ANO AND MES = @MES";

                    command.Connection = connection;
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@PAGAMENTO", pagamento.IdPagamento);
                    command.Parameters.AddWithValue("@MATRICULA", pagamento.IdMatricula);
                    command.Parameters.AddWithValue("@VALOR", pagamento.Valor);
                    command.Parameters.AddWithValue("@DATA", pagamento.DataPagamento);
                    command.Parameters.AddWithValue("@ANO", pagamento.Ano);
                    command.Parameters.AddWithValue("@MES", pagamento.Mes);
                    command.Parameters.AddWithValue("@STATUS", pagamento.StatusPag);


                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();

                }
            }
        }

        public void PagamentoAtrasado(int id_matricula)
        {
            using (SqlConnection connection = new SqlConnection(this.string_connection))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    // PARÂMETRO @MATRICULA INT
                    string sql = @"dbo.SP_VERIFICA_ATRASO";
             
                    command.Connection = connection;
                    command.CommandText = sql;
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MATRICULA", id_matricula);

                    connection.Open();

                    command.ExecuteScalar();
                    
                    connection.Close();

                }
            }
        }

        public DataTable GetPagamentosCliente(int matricula)
        {
            using (SqlConnection connection = new SqlConnection(this.string_connection))
            {
                string sql = @"SELECT * FROM TB_PAGAMENTO WHERE ID_MATRICULA = @MATRICULA";

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@MATRICULA", matricula);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        connection.Close();

                        return dataTable;
                    }
                }
            }
        }

        public DataTable GetClienteNome(string nome)
        {
            nome = nome.ToLower();

            string sql = @"SELECT ID_MATRICULA, NOME, CPF, MAT_STATUS, VALOR FROM TB_MATRICULA WHERE LOWER(NOME) LIKE @NOME";

            using (SqlConnection connection = new SqlConnection(this.string_connection))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@NOME", nome + "%");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        connection.Close();

                        return dataTable;
                    }
                }
            }
        }
    }
}
