using DllGenerica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllEspecifica
{
    public class BDFornecedores : BD
    {
        public string ID { get; set; }
        public string Nome { get; set; }
        public string IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Telefone { get; set; }
        public string Telefone_Alt { get; set; }
        public int status { get; set; }

        public BDFornecedores(string chave) : base(chave)
        {

        }
        
        public DataTable Consultar()
        {
            DataTable ret = new DataTable();
            string Query = "SELECT Fornecedores.Id_Fornecedor as 'ID', Fornecedores.Nome_Fornecedor as 'Nome', Fornecedores.Id_Produto as 'ID do Produto',Produtos.Nome_Produto as 'Nome do Produto',FORMAT(Produtos.Valor_Compra, 'c','pt-BR') as 'Valor de Compra', Fornecedores.Telefone, Fornecedores.Telefone_Alt as 'Telefone Alt' FROM Fornecedores LEFT JOIN Produtos ON Fornecedores.Id_Produto = Produtos.Id_Produto";
            try
            {
                ret = ConsultarTabela(Query);
            }catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public DataTable ConsultarProdutos()
        {
            DataTable ret = new DataTable();
            string Query = "select Nome_Produto as 'Nome do Produto', Valor_Compra as 'Valor de Compra', Quantidade as 'Quantidade no Estoque' from Produtos";
            try
            {
                ret = ConsultarTabela(Query);
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }
        public DataTable ConsultarFornecedores()
        {
            DataTable ret = new DataTable();
            string Query = "SELECT Fornecedores.Nome_Fornecedor as 'Nome', Produtos.Nome_Produto as 'Nome do Produto',FORMAT(Produtos.Valor_Compra, 'c','pt-BR') as 'Valor de Compra', Fornecedores.Telefone, Fornecedores.Telefone_Alt as 'Telefone Alt' FROM Fornecedores LEFT JOIN Produtos ON Fornecedores.Id_Produto = Produtos.Id_Produto";
            try
            {
                ret = ConsultarTabela(Query);
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public DataTable PuxaNomeFrn()
        {
            DataTable ret = new DataTable();
            string Query = "SELECT Id_Fornecedor, Nome_Fornecedor  FROM Fornecedores ";
            try
            {
                ret = ConsultarTabela(Query);
            }catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public DataTable PuxarProduto()
        {
            DataTable ret = new DataTable();
            string Query = "SELECT Id_Produto ,Nome_Produto FROM Produtos";
            try
            {
                ret = ConsultarTabela(Query);
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public bool InserirForncedor()
        {
            bool ret = false;
            string Query = "insert into Fornecedores (Nome_Fornecedor, Telefone, Telefone_Alt, Fc_Status) values ('" + Nome+"','"+Telefone+"','"+Telefone_Alt+"',1)";
            try
            {
                ret = Incluir(Query);
                return ret = true;
            }catch(Exception ex)
            {
                string err = ex.Message;
                return false;
            }
        }

        public bool AtualizarForncedor()
        {
            bool ret = false;
            string Query = "update Fornecedores set Id_Produto = '"+IdProduto+"', Telefone = '"+Telefone+"', Telefone_Alt = '"+Telefone_Alt+"' where Id_Fornecedor = '"+ID+"'";
            try
            {
                ret = Atualizar(Query);
                return ret = true;
            }catch(Exception ex)
            {
                string err = ex.Message;
                return false;
            }
        }
    }
}
