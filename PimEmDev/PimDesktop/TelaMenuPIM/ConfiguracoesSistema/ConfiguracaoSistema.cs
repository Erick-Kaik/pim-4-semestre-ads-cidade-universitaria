using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DllConfiguracoesCamadas
{
    public static class ConfiguracaoSistema
    {
        public static string StringConexao(string chave)
        {
            string ret = "";
            try
            {
                ret = ConfigurationManager.ConnectionStrings[chave].ConnectionString;
            }
            catch(Exception ex)
            {
                string err = ex.Message;
                ret = "";
            }

            return ret;
        }

        public static string BancoDeDados(string chave)
        {
            string ret = "";

            try
            {
                ret = ConfigurationManager.AppSettings[chave];
            }
            catch(Exception ex)
            {
                string err = ex.Message;
                ret = "";
            }
            return ret;
        }
    }
}
