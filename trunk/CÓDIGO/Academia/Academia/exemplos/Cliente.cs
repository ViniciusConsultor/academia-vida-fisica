using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Academia.exemplos
{
    public class Cliente
    {
        // String de conexão
        private string stringConnection = ConfigurationManager.ConnectionStrings["WebCamImage.Properties.Settings.exerciciosConnectionString"].ConnectionString;

        // Consultas SQL
        private const string insert = "INSERT INTO TB_CLIENTE VALUES (@CD_CLIENTE, @NM_CLIENTE)";
        private const string update = "UPDATE TB_CLIENTE SET NM_CLIENTE = @NOME WHERE CD_CLIENTE = @CODIGO";
        private const string delete = "DELETE FROM TB_CLIENTE WHERE CD_CLIENTE = @CODIGO";
        private const string select = "SELECT * FROM TB_CLIENTE";

        public void Inserir(int codigo, string nome)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection)) 
            {
                using (SqlCommand command = new SqlCommand(insert, connection)) 
                {
                    command.Parameters.AddWithValue("@CD_CLIENTE", codigo);
                    command.Parameters.AddWithValue("@NM_CLIENTE", nome);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        public void Atualizar(int codigo, string nome)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                using (SqlCommand command = new SqlCommand(update, connection))
                {
                    command.Parameters.AddWithValue("@CODIGO", codigo);
                    command.Parameters.AddWithValue("@NOME", nome);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        public void Deletar(int codigo)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                using (SqlCommand command = new SqlCommand(delete, connection))
                {
                    command.Parameters.AddWithValue("@CODIGO", codigo);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        public DataTable Select()
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(select, connection))
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
