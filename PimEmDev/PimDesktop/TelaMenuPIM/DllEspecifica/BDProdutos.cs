using DllGenerica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DllEspecifica
{
    public class BDProdutos : BD
    {
        public string ID { get; set; }
        public string NomeProduto { get; set; }
        public double ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public int Estoque_Atual { get; set; }

        

        public BDProdutos(string chave) : base(chave)
        {

        }

        public DataTable Consultar()
        {
            DataTable ret = new DataTable();
            string Query = "select Id_Produto as 'ID', Nome_Produto as 'Nome do Produto', Estoque_Inicial as 'Estoque Inicial', Quantidade as 'Estoque atual', Valor_Compra as 'Valor de Compra' from Produtos";
            try
            {
                ret = ConsultarTabela(Query);
            }catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public DataTable PuxarNomeValor()
        {
            DataTable ret = new DataTable();
            string Query = "select Nome_Produto, Valor_Compra from Produtos";

            try
            {
                ret = ConsultarTabela(Query);
            }catch(Exception ex)
            {

            }
            return ret;
        }

        public bool SolicitarProduto()
        {
            bool ret = false;
            string Query = "UPDATE Produtos SET Estoque_Inicial = Estoque_Inicial + '"+Quantidade+"', Quantidade = Quantidade + '"+Quantidade+"' WHERE Nome_Produto = '"+NomeProduto+"'";
            try
            {
                ret = Atualizar(Query);
                return ret = true;
            }catch(Exception ex)
            {
                string err = ex.Message;
                return ret = false;
            }
        }

        public DataTable Estoque()
        {
            DataTable ret = new DataTable();
             try
            {
                string Query = "Declare @Estoque_Inicial INT = 0;Declare @Quantidade INT = 0;Declare @Porcentagem INT = 0;select @Estoque_Inicial =  sum(Estoque_Inicial),@Quantidade = sum(Quantidade) from Produtos;SET @Porcentagem = (@Quantidade * 100) / @Estoque_Inicial;select @Porcentagem as '%'";
                ret = ConsultarTabela(Query);
                int contador = 0;

                foreach(DataRow linha in ret.Rows)
                {
                    foreach(DataColumn coluna in ret.Columns)
                    {
                        Estoque_Atual = Convert.ToInt32(linha[coluna].ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }
    }
}
