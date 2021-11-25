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
    public class CadastroLogin : BD
    {

        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string IdFuncionario { get; set; }
        public int permissao { get; set; }

        public CadastroLogin(string chave) : base(chave)
        {

        }

        public DataTable PuxaNomeFunc()
        {
            DataTable ret = new DataTable();
            string Query = "DECLARE @contador INT = 1;DECLARE @qtdQuartos INT = (select count(*) from Funcionarios);DECLARE @Porcentagem INT = 0;create table #tabelaTemporario(ID int identity,Id_Funcionario int not null,Nome varchar(50) not null,constraint pk_tabelaTemporario primary key (ID))while(@contador <= @qtdQuartos)Begin;if((select count(*) from Usuarios where Id_Funcionario like @contador) = 0)Begin;insert into #tabelaTemporario select Id_Funcionario, Nome from Funcionarios where Id_Funcionario = @contador;End;set @contador = @contador + 1;End;SELECT Id_Funcionario,Nome FROM #tabelaTemporario;drop table #tabelaTemporario";
            try
            {
                ret = ConsultarTabela(Query);
            }catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public DataTable Login()
        {
            DataTable ret = new DataTable();
            string Query = "select count(Usuario) from Usuarios where Usuario = '" + Usuario+"' AND Senha = '"+Senha+"'";
            try
            {
                ret = ConsultarTabela(Query);
                foreach (DataRow linha in ret.Rows)
                {
                    foreach (DataColumn coluna in ret.Columns)
                    {
                        permissao = Convert.ToInt32(linha[coluna].ToString());
                        
                    }
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;

            }
            return ret;
        }
        public bool CadastrarUsuario()
        {
            bool ret = false;
            string Query = "insert into Usuarios (Usuario, Senha, Tipo, Id_Funcionario, U_Status) values ('"+Usuario+"','"+Senha+ "','Funcionario','"+IdFuncionario+"', 1)";
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

        

    }
}
