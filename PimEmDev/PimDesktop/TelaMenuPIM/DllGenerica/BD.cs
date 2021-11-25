using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DllConfiguracoesCamadas;
using System.Windows.Forms;

namespace DllGenerica
{
    public class BD
    {
        string strConexao { get; set; }
            
        public BD(string chave)
        {
            strConexao = ConfiguracaoSistema.StringConexao(chave);
        }

        
        public DataTable ConsultarTabela(string Query)
        {
            DataTable ret = new DataTable();

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlDataAdapter da = new SqlDataAdapter(Query, conexao);


            try
            {
                da.Fill(ret);
            }
            catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public bool Incluir(string Query)
        {
            string MSG = "";
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MSG = "Os Dados Foram Inserido Com sucesso:";
                return true;
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                MSG = "ERRO: " + erro;
                return false;
            }
            finally
            {
                conexao.Close();
                MessageBox.Show(MSG, "Aviso!!");
            }
            
        }

        public bool Atualizar(string Query)
        {
            string MSG = "";
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MSG = "Os Dados Foram Atualizados com Sucesso Com sucesso:";
                return true;
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                MSG = "ERRO: " + erro;
                return false;
            }
            finally
            {
                conexao.Close();
                MessageBox.Show(MSG, "Aviso!!");
            }

        }


    }
}
