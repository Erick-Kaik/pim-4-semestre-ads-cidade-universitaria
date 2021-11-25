using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DllConfiguracoesCamadas;
using DllEspecifica;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaMenuPIM.Paginas
{
    public partial class PgAnalytics : UserControl
    {
        public PgAnalytics()
        {
            if (Program.IsInDesignMode(container:this)) return;
            InitializeComponent();
        }

        private void PgAnalytics_Load(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDReserva reserva = new BDReserva(Banco);
            BDProdutos produto = new BDProdutos(Banco);

            produto.Estoque();
            reserva.QuartosLivres();

            CircleEstoqueProgress.Value = produto.Estoque_Atual;
            CircleQuartoProgess.Value = reserva.PorcentagemQuartos;
        }
    }
}
