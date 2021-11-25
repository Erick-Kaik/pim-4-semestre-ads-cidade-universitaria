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
    public class BDFuncionario : BD
    {
        //Construtores
        public string NewID { get; set; }
        public string ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public string Telefone { get; set; }
        public string TelefoneAlt { get; set; }
        public string DataAdmissao { get; set; }
        public string Pesquisa { get; set; }
        public int Status { get; set; }

        public BDFuncionario(string chave) : base(chave)
        {

        }

        public DataTable Consultar()
        {
            DataTable ret = new DataTable();
            string Query = "SELECT Id_Funcionario as 'ID', Nome, CPF, RG, Email, Cargo, FORMAT(Salario, 'c', 'pt-BR') AS Salario, Telefone, Telefone_Alt as 'Telefone Alt', FORMAT(Data_de_Admissão, 'dd/MM/yyyy') AS 'Data de Adimissão', F_Status as 'Status' FROM Funcionarios where F_Status = 1";
            try
            {
                ret = ConsultarTabela(Query);
            }catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }
        public DataTable ConsultarTodos()
        {
            DataTable ret = new DataTable();
            string Query = "SELECT Id_Funcionario as 'ID', Nome, CPF, RG, Email, Cargo, FORMAT(Salario, 'c', 'pt-BR') AS Salario, Telefone, Telefone_Alt as 'Telefone Alt', FORMAT(Data_de_Admissão, 'dd/MM/yyyy') AS 'Data de Adimissão', F_Status as 'Status' FROM Funcionarios";
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
        public DataTable ConsultarAtivos()
        {
            DataTable ret = new DataTable();
            string Query = "SELECT Id_Funcionario as 'ID', Nome, CPF, Cargo, FORMAT(Salario, 'c', 'pt-BR') AS Salario, FORMAT(Data_de_Admissão, 'dd/MM/yyyy') AS 'Data de Adimissão', F_Status as 'Status' FROM Funcionarios where F_Status = 1";
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
        public DataTable ConsultarDesativos()
        {
            DataTable ret = new DataTable();
            string Query = "SELECT Id_Funcionario as 'ID', Nome, CPF, Cargo, FORMAT(Salario, 'c', 'pt-BR') AS Salario, FORMAT(Data_de_Admissão, 'dd/MM/yyyy') AS 'Data de Adimissão', F_Status as 'Status' FROM Funcionarios where F_Status = 0";
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

        public DataTable ConsultarAlter()
        {
            DataTable ret = new DataTable();
            string Query = "select Id_Funcionario as  'ID', Nome, Email, Cargo, FORMAT(Salario,'c','pt-BR') as Salario, Telefone_Alt as 'Telefone Alt' from Funcionarios";
            try
            {
                ret = ConsultarTabela(Query);
            }catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public DataTable PesquisarFuncionario()
        {
            DataTable ret = new DataTable();
            try
            {
                if(Pesquisa.Length > 0)
                {
                    string Query = "SELECT Id_Funcionario as 'ID', Nome, Email, Cargo, FORMAT(Salario,'c','pt-BR') as Salario, Telefone_Alt as 'Telefone Alt', F_Status as 'Status' from Funcionarios WHERE Nome LIKE  '" + Pesquisa+"%'";
                    ret = ConsultarTabela(Query);

                    int contador = 0;
                    foreach (DataRow linha in ret.Rows)
                    {
                        foreach (DataColumn coluna in ret.Columns)
                        {
                            switch (contador)
                            {
                                case 0:
                                    NewID = linha[coluna].ToString();
                                    break;
                                case 1:
                                    Nome = linha[coluna].ToString();
                                    break;
                                case 2:
                                    Email = linha[coluna].ToString();
                                    break;
                                case 3:
                                    Cargo = linha[coluna].ToString();
                                    break;
                                case 4:
                                    Salario = double.Parse(linha[coluna].ToString());
                                    break;
                                case 5:
                                    TelefoneAlt = linha[coluna].ToString();
                                    break;
                                case 6:
                                    Status = Convert.ToInt32(linha[coluna]);
                                    break;
                                default:
                                    break;
                            }
                            contador++;
                        }
                    }
                }
            }catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public bool InserirFuncionario()
        {
            bool ret = false;
            string Query = "INSERT INTO Funcionarios(Nome,CPF,RG,Email,Cargo,Telefone,Telefone_Alt,Salario,Data_de_Admissão,F_Status)VALUES('" + Nome+"','"+CPF+"','"+RG+"','"+Email+"','"+Cargo+"','"+Telefone+"','"+TelefoneAlt+"','"+Salario+"','"+DataAdmissao+"',1)";
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

        public bool AtualizarFuncionario()
        {
            bool ret = false;
            string Query = "UPDATE Funcionarios SET Email = '"+Email+"', Cargo = '"+Cargo+"', Telefone_Alt = '"+TelefoneAlt+"', Salario = '"+Salario+"'where Id_Funcionario = '"+ID+"'";
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
