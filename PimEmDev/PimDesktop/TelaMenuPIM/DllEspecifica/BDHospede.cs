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
    public class BDHospede : BD
    {

        public string NewID { get; set; }
        public string Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string TelefoneAlt { get; set; }
        public int Status { get; set; }
        public string Pesquisa { get; set; }
        public string StatusString { get; set; }

        public BDHospede(string chave) : base(chave)
        {

        }

        public DataTable Consultar()
        {
            DataTable ret = new DataTable();
            string Query = "select Id_Hospede as 'ID', Nome, Email, CPF, FORMAT(Data_de_Nascimento, 'dd/MM/yyyy') as 'Data de Nascimento', H_Status as 'Status' ,Telefone, Telefone_Alt as 'Telefone Alt' from Hospedes where H_Status = 1";
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

        public DataTable ConsultarTodos()
        {
            DataTable ret = new DataTable();
            string Query = "select Id_Hospede as 'ID', Nome, Email, CPF, FORMAT(Data_de_Nascimento, 'dd/MM/yyyy') as 'Data de Nascimento', H_Status as 'Status' ,Telefone, Telefone_Alt as 'Telefone Alt' from Hospedes";
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
            string Query = "select Id_Hospede as 'ID', Nome, CPF, H_Status as 'Status' from Hospedes where H_Status = 1";
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
            string Query = "select Id_Hospede as 'ID', Nome, CPF, H_Status as 'Status' from Hospedes where H_Status = 0";
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
            string Query = "select Id_Hospede as 'ID', Nome, Email, Telefone, Telefone_Alt as 'Telefone Alt' from Hospedes";
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

        public DataTable PesquisarUsuario()
        {                   
            DataTable ret = new DataTable();
            try
            {
                if (Pesquisa.Length > 0)
                {
                    string Query = "SELECT Id_Hospede as 'ID', Nome, Email, Telefone, Telefone_Alt as 'Telefone Alt', H_Status as 'Status' from Hospedes WHERE Nome LIKE '" + Pesquisa + "%'";
                    ret = ConsultarTabela(Query);

                    int contador = 0;
                    foreach (DataRow linha in ret.Rows)
                    {
                        foreach(DataColumn coluna in ret.Columns)
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
                                    Telefone = linha[coluna].ToString();
                                    break;
                                case 4:
                                    TelefoneAlt = linha[coluna].ToString();
                                    break;
                                case 5:
                                    Status = Convert.ToInt32(linha[coluna]);
                                    break;
                                default:
                                    break;

                            }
                            contador++;

                            //break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }  
            return ret;    
        }

        public bool InserirHospede()
        {
            bool ret = false;
            string Query = "insert into Hospedes (Nome, Email, CPF, Data_de_Nascimento, Telefone, Telefone_Alt, H_Status) values ('" + Nome + "','" + Email + "','" + CPF + "','"+DataNascimento+"','" + Telefone + "','" + TelefoneAlt + "', 1)";
            try
            {
                ret = Incluir(Query);
                return ret = true;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return false;
            }
        }

        public bool AtualizarHospede()
        {
            bool ret = false;
            string Query = "update Hospedes set Nome = '" + Nome + "', Email = '" + Email + "', H_Status = '"+Status+"' ,Telefone = '" + Telefone + "', Telefone_Alt = '" + TelefoneAlt + "'where Id_Hospede = '" + Id + "'";
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
