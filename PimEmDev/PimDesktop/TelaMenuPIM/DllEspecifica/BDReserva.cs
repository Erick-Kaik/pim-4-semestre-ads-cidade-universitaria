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
    public class BDReserva : BD 
    {
        public string ID { get; set; }
        public string NomeHospede { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string IdQuarto { get; set; }
        public string IdHospede { get; set; }
        public string NumQuarto { get; set; }
        public string TipoQuarto { get; set; }
        public int Status { get; set; }
        public int PorcentagemQuartos { get; set; }

        public BDReserva(string chave) : base(chave)
        {

        }

        public DataTable Consultar()
        {
            DataTable ret = new DataTable();
            string Query = "SELECT Reservas.Id_Reserva, FORMAT(Reservas.CheckIn, 'dd/MM/yyyy') as CheckIn, FORMAT(Reservas.CheckOut, 'dd/MM/yyyy') as CheckOut, Hospedes.Nome, Quartos.Numero_Quarto, Quartos.Tipo_Quarto FROM Reservas INNER JOIN Hospedes ON Reservas.Id_Hospede = Hospedes.Id_Hospede INNER JOIN Quartos ON Reservas.Id_Quarto = Quartos.Id_Quarto where R_Status = 1";
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
            string Query = "SELECT Reservas.Id_Reserva, Hospedes.Nome, Quartos.Tipo_Quarto, Quartos.Numero_Quarto, Reservas.CheckIn, Reservas.CheckOut FROM Reservas INNER JOIN Hospedes ON Reservas.Id_Hospede = Hospedes.Id_Hospede INNER JOIN Quartos ON Reservas.Id_Quarto = Quartos.Id_Quarto";
            try
            {
                ret = ConsultarTabela(Query);
            }catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public DataTable PuxarQuartos()
        {
            DataTable ret = new DataTable();
            string Query = "select Numero_Quarto, Tipo_Quarto from Quartos";
            try
            {
                ret = ConsultarTabela(Query);
            }
            catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public DataTable CancelarReservaTabela()
        {
            DataTable ret = new DataTable();
            string Query = "SELECT Reservas.Id_Reserva, Hospedes.Nome,Quartos.Numero_Quarto, Quartos.Tipo_Quarto FROM Reservas INNER JOIN Hospedes ON Reservas.Id_Hospede = Hospedes.Id_Hospede INNER JOIN Quartos ON Reservas.Id_Quarto = Quartos.Id_Quarto where R_Status = 1";
            try
            {
                ret = ConsultarTabela(Query);
            }catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public DataTable BuscarID()
        {
            DataTable ret = new DataTable();
            string Query = "select Id_Reserva, R_Status from Reservas";
            try
            {
                ret = ConsultarTabela(Query);
            }catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public DataTable BuscarHospede()
        {
            DataTable ret = new DataTable();
            string Query = "select Id_Hospede, Nome from Hospedes where H_Status = 1";
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

        public DataTable BuscarQuarto(string entrada)
        {
            DataTable ret = new DataTable();
            try
            {
                string Query = "select Id_Quarto, Numero_Quarto, Tipo_Quarto from Quartos where Tipo_Quarto = '" + entrada + "'";
                ret = ConsultarTabela(Query);

                int contador = 0;
                foreach(DataRow linha in ret.Rows)
                {
                    foreach (DataColumn coluna in ret.Columns)
                    {
                        IdHospede = linha[coluna].ToString();
                    }
                    contador++;
                }
            }catch(Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }

        public bool InserirReserva()
        {
            bool ret = false;
            string Query = "insert into Reservas (CheckIn, CheckOut, Id_Hospede, Id_Quarto, R_Status) values ('" + CheckIn+"','"+CheckOut+"','"+IdHospede+"','"+IdQuarto+"', 1)";
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

        public bool CancelarReserva()
        {
            bool ret = false;
            string Query = "update Reservas set R_Status = '"+Status+"' where Id_Reserva = "+ID;
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

        public DataTable QuartosLivres()
        {
            DataTable ret = new DataTable();
            try
            {
                string Query = "DECLARE @contador INT = 1;DECLARE @qtdQuartos INT = (select count(*) from Quartos);DECLARE @Porcentagem INT = 0;create table #tabelaTemporario(ID int identity,Id_Quarto int not null,constraint pk_tabelaTemporario primary key (ID))while(@contador <= @qtdQuartos)Begin;if((select count(*) from Reservas where Id_Quarto like @contador) = 0)Begin;insert into #tabelaTemporario select Id_Quarto from Quartos where Id_Quarto = @contador;End;set @contador = @contador + 1;End;SET @Porcentagem = ((Select count(Id_Quarto) from #tabelaTemporario) * 100) / @qtdQuartos;select @Porcentagem as '%';drop table #tabelaTemporario";
                ret = ConsultarTabela(Query);
                int contador = 0;

                foreach (DataRow linha in ret.Rows)
                {
                    foreach (DataColumn coluna in ret.Columns)
                    {
                        PorcentagemQuartos = Convert.ToInt32(linha[coluna].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            return ret;
        }
    }
}
