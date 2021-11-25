using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using DllConfiguracoesCamadas;
using DllEspecifica;
using System.Threading;


namespace TelaMenuPIM
{
    public partial class FrmMenu : Form
    {
        Thread Q13;
        Thread Q15;
        Thread Q29;
        Thread Q37;
        Thread Q67;
        Thread Q89;

        int contador = 0;
        int contadorId = 0; 
        
        public int StatusGlobal { get; set; }
        void AbrirQuarto13(object obj)
        {
            Application.Run(new FormQuartos());
        }
        void AbrirQuarto15(object obj)
        {
            Application.Run(new FormQ15());
        }
        void AbrirQuarto29(object obj)
        {
            Application.Run(new FormQ29());
        }
        void AbrirQuarto37(object obj)
        {
            Application.Run(new FormQ37());
        }
        void AbrirQuarto67(object obj)
        {
            Application.Run(new FormQ67());
        }
        void AbrirQuarto89(object obj)
        {
            Application.Run(new FormQ89());
        }


        void PopulaNomeFrn()
        {
            BDFornecedores fornecedor = new BDFornecedores("BancoDeDados");
            DbxNomeFrn.DataSource = fornecedor.PuxaNomeFrn();
            DbxNomeFrn.DisplayMember = "Nome_Fornecedor";
            DbxNomeFrn.ValueMember = "Id_Fornecedor";
        }

        void PopulaProdutoFrn()
        {
            BDFornecedores fornecedor = new BDFornecedores("BancoDeDados");
            DbxProdutoFrn.DataSource = fornecedor.PuxarProduto();
            DbxProdutoFrn.DisplayMember = "Nome_Produto";
            DbxProdutoFrn.ValueMember = "Id_Produto";
        }

        void PopulaID()
        {
            BDReserva reserva = new BDReserva("BancoDeDados");
            DbxRID.DataSource = reserva.BuscarID();
            DbxRID.DisplayMember = "Id_Reserva";
            DbxRID.ValueMember = "R_Status";
        }

        void PopulaProduto()
        {
            BDProdutos produto = new BDProdutos("BancoDeDados");
            DbxNProduto.DataSource = produto.PuxarNomeValor();
            DbxNProduto.DisplayMember = "Nome_Produto";
            DbxNProduto.ValueMember = "Valor_Compra";
        }

        void PopulaQuarto()
        {
            BDReserva reserva = new BDReserva("BancoDeDados");

            DbxQuarto.DataSource = reserva.PuxarQuartos();
            DbxQuarto.DisplayMember = "Tipo_Quarto";
            DbxQuarto.ValueMember = "Numero_Quarto";
        }

        void PopulaNum()
        {
            BDReserva reserva = new BDReserva("BancoDeDados");
            DbxNum.DataSource = reserva.BuscarQuarto(DbxQuarto.Text);
            DbxNum.DisplayMember = "Numero_Quarto";
            DbxNum.ValueMember = "Id_Quarto";
        }

        void PopulaNome()
        {
            BDReserva reserva = new BDReserva("BancoDeDados");

            DbxNome2.DataSource = reserva.BuscarHospede();
            DbxNome2.ValueMember = "Id_Hospede";
            DbxNome2.DisplayMember = "Nome";
        }

        public FrmMenu()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(panel1);
            bunifuFormDock1.SubscribeControlToDragEvents(panel2);
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            dropMenu1.MenuPrincipal1 = true;
        }


        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Indicator.Top = ((Control)sender).Top;
            TabPagBunifu.SetPage("Menu");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Indicator.Top = ((Control)sender).Top;
            dropMenu1.Show(btnConsultar, btnConsultar.Width, 0);
        }


        //hospede
        private void hóspedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPagBunifu.SetPage("Hospedes");
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDHospede hospede = new BDHospede(Banco);

            DgHospede.DataSource = hospede.Consultar();


        }
            //Incluir Hospede
        private void incluirHóspedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPagBunifu.SetPage("InsertHospede");
        }
                //Salvar 
        private void BtnHSaveIns_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDHospede hospede = new BDHospede(Banco);

            hospede.Nome = TxtHName.Text;
            hospede.CPF = TxtHCPF.Text;
            hospede.DataNascimento = TxtHDate.Value.ToString("yyyy-M-d");
            hospede.Email = TxtHEmail.Text;
            hospede.Telefone = TxtHTel1.Text;
            hospede.TelefoneAlt = TxtHTel2.Text;

            hospede.InserirHospede();
            DgInsertH.DataSource = hospede.Consultar();
        }

        private void BtnInsHAll_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDHospede hospede = new BDHospede(Banco);

            DgInsertH.DataSource = hospede.ConsultarTodos();
        }

        //Alterar Hospede
        private void alterarHóspedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPagBunifu.SetPage("AlterHospede");
        }

        private void BtnHStatus_CheckedChanged(object sender, BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                StatusGlobal = 1;
            }
            else
            {
                StatusGlobal = 0;
            }
        }

                //Atualizar Dados
        private void BtnNewHSave_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDHospede hospede = new BDHospede(Banco);

            hospede.Id = TxtNewIDH.Text;
            hospede.Nome = TxtNewHName.Text;
            hospede.Email = TxtNewHEmail.Text;
            hospede.Telefone = TxtNewHTel1.Text;
            hospede.TelefoneAlt = TxtNewHtel2.Text;
            hospede.Status = StatusGlobal;
            hospede.AtualizarHospede();

            DgNewHAtt.DataSource = hospede.ConsultarAlter();
        }
        private void BtnNewHAll_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDHospede hospede = new BDHospede(Banco);

            DgNewHAtt.DataSource = hospede.ConsultarTodos();
        }
        private void BtnNewHAtivos_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDHospede hospede = new BDHospede(Banco);

            DgNewHAtt.DataSource = hospede.ConsultarAtivos();
        }

        private void BtnNewHDesativos_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDHospede hospede = new BDHospede(Banco);

            DgNewHAtt.DataSource = hospede.ConsultarDesativos();
        }

                //Botão Pesquisar
        private void BtnSelectNewH_Click(object sender, EventArgs e)
        {
            PnIDH.Visible = true;
            PnNomeH.Visible = true;
            PnStatusH.Visible = true;
            PnEmailH.Visible = true;
            PnTelH.Visible = true;
            PnTel2H.Visible = true;
            BtnNewHSave.Visible = true;

            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDHospede hospede = new BDHospede(Banco);
            hospede.Pesquisa = TxtSelectNameH.Text;
            DgNewHAtt.DataSource = hospede.PesquisarUsuario();

            TxtNewIDH.Text = hospede.NewID;
            TxtNewHName.Text = hospede.Nome;
            TxtNewHEmail.Text = hospede.Email;
            TxtNewHTel1.Text = hospede.Telefone;
            TxtNewHtel2.Text = hospede.TelefoneAlt;
            if (hospede.Status == 1)
            {
                BtnHStatus.Checked = false;
            }
            else if(hospede.Status == 0)
            {
                BtnHStatus.Checked = true;
            }
        }

        //Funcionario
        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPagBunifu.SetPage("Funcionario");
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFuncionario funcionario = new BDFuncionario(Banco);
            DgFuncionarios.DataSource = funcionario.Consultar();
        }
            //Incluir Funcionario
        private void incluirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPagBunifu.SetPage("InsertFuncionario");
        }
                //Salvar Funcionário
        private void BtnFSave_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFuncionario funcionario = new BDFuncionario(Banco);

            funcionario.Nome = TxtFNome.Text;
            funcionario.Email = TxtFEmail.Text;
            funcionario.CPF = TxtFCPF.Text;
            funcionario.RG = TxtFRG.Text;
            funcionario.Cargo = TxtFCargo.Text;
            funcionario.DataAdmissao = TxtFDate.Value.ToString("yyyy-M-d");
            funcionario.Telefone = TxtFTel1.Text;
            funcionario.TelefoneAlt = TxtFTel2.Text;
            funcionario.Salario = double.Parse(TxtFSalario.Text);



            funcionario.InserirFuncionario();
        }

                //Tabela
        private void BtnFAll_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFuncionario funcionario = new BDFuncionario(Banco);
            DgInsertF.DataSource = funcionario.ConsultarTodos();
        }
            //Alterar Funcionario
        private void alterarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPagBunifu.SetPage("AlterFuncionario");
        }
        private void BtnNewFAtivos_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFuncionario funcionario = new BDFuncionario(Banco);
            DgNewFAtt.DataSource = funcionario.ConsultarAtivos();
        }

        private void BtnNewFAll_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFuncionario funcionario = new BDFuncionario(Banco);
            DgNewFAtt.DataSource = funcionario.ConsultarTodos();
        }

        private void BtnNewFDesativos_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFuncionario funcionario = new BDFuncionario(Banco);
            DgNewFAtt.DataSource = funcionario.ConsultarDesativos();
        }
                //Pesquisa Funcionario
        private void BtnSearchF_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFuncionario funcionario = new BDFuncionario(Banco);
            funcionario.Pesquisa = TxtSelectNameF.Text;
            DgNewFAtt.DataSource = funcionario.PesquisarFuncionario();

            SearchFID.Text = funcionario.NewID;
            PnFID.Visible = true;
            TxtNewFEmail.Text = funcionario.Email;
            PnFEmail.Visible = true;
            TxtNewFCargo.Text = funcionario.Cargo;
            PnFCargo.Visible = true;
            TxtNewFTel.Text = funcionario.TelefoneAlt;
            PnFTel2.Visible = true;
            TxtNewFSalario.Text = Convert.ToString(funcionario.Salario);
            PnFSalario.Visible = true;
            if (funcionario.Status == 1)
            {
                BtnHStatus.Checked = false;
            }
            else if (funcionario.Status == 0)
            {
                BtnFStatus.Checked = true;
            }
            PnFStatus.Visible = true;
            BtnFNewAtt.Visible = true;
            BtnFNewSave.Visible = true;
        }

        private void BtnFStatus_CheckedChanged(object sender, BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                StatusGlobal = 1;
            }
            else
            {
                StatusGlobal = 0;
            }
        }

                //Novos Dados Funcionaris
        private void BtnFNewSave_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFuncionario funcionario = new BDFuncionario(Banco);

            funcionario.ID = SearchFID.Text;
            funcionario.Email = TxtNewFEmail.Text;
            funcionario.Cargo = TxtNewFCargo.Text;
            funcionario.Salario = double.Parse(TxtNewFSalario.Text);
            funcionario.TelefoneAlt = TxtNewFTel.Text;
            funcionario.Status = StatusGlobal;

            funcionario.AtualizarFuncionario();
        }
                //Tabela
        private void BtnFNewAtt_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFuncionario funcionario = new BDFuncionario(Banco);
            DgNewFAtt.DataSource = funcionario.ConsultarAlter();
        }
        
        //Reserva
        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPagBunifu.SetPage("Reserva");
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDReserva reserva = new BDReserva(Banco);
            DgReserva.DataSource = reserva.Consultar();


        }
            //Realizar Reserva
        private void realizarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPagBunifu.SetPage("RealizarReserva");
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");


            PopulaQuarto();
            PopulaNome();
        }
                //Ver Quartos
        private void BtnVerQuartos_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDReserva reserva = new BDReserva(Banco);
            DgInsR.DataSource = reserva.PuxarQuartos();
        }


        private void DbxQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDReserva reserva = new BDReserva(Banco);

            reserva.TipoQuarto = DbxQuarto.Text;
            PopulaNum();
        }
        private void DbxNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDReserva reserva = new BDReserva(Banco);

            reserva.NumQuarto = DbxNum.Text;
            reserva.IdQuarto = DbxNum.SelectedValue.ToString();

        }

        private void DbxNome2_SelectedValueChanged(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDReserva reserva = new BDReserva(Banco);

            reserva.NomeHospede = DbxNome2.Text;
            reserva.IdHospede = DbxNome2.SelectedValue.ToString();
        }
                //Salvar Reserva
        private void BtnRSave_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDReserva reserva = new BDReserva(Banco);
            reserva.CheckIn = TxtRCheckIn.Value.ToString("yyyy-M-d");
            reserva.CheckOut = TxtRCheckOut.Value.ToString("yyyy-M-d");
            reserva.IdHospede = DbxNome2.SelectedValue.ToString();
            reserva.IdQuarto = DbxNum.SelectedValue.ToString();

            reserva.InserirReserva();
        }
        //Atualizar Tabela
        private void BtnRAll_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDReserva reserva = new BDReserva(Banco);
            DgInsR.DataSource = reserva.ConsultarAlter();
        }

        private void cancelarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPagBunifu.SetPage("CancelarReserva");
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDReserva reserva = new BDReserva(Banco);

            PopulaID();
        }

        private void BtnDelRAll_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDReserva reserva = new BDReserva(Banco);
            DgCancelarReserva.DataSource = reserva.ConsultarAlter();
        }

        private void DbxRID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDReserva reserva = new BDReserva(Banco);

            reserva.ID = DbxRID.Text;
            Console.WriteLine(DbxRID.SelectedValue);



            if (contadorId > 1)
            {
                reserva.Status = Convert.ToInt32(DbxRID.SelectedValue);
            }
            else
            {
                DbxRID.Text = "";
            }
            contadorId++;
        }

        private void BtnRStatus_CheckedChanged(object sender, BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                StatusGlobal = 0;
            }
            else
            {
                StatusGlobal = 1;
            }
        }

        private void BtnCancelarReserva_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDReserva reserva = new BDReserva(Banco);

            reserva.ID = DbxRID.Text;
            reserva.Status = StatusGlobal;

            reserva.CancelarReserva();
            DgCancelarReserva.DataSource = reserva.CancelarReservaTabela();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPagBunifu.SetPage("Forncedor");
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFornecedores fornecedores = new BDFornecedores(Banco);
            DgFornecedor.DataSource = fornecedores.Consultar();

        }

        private void incluirForncedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPagBunifu.SetPage("InsertFornecedor");
        }

        private void alterarForncedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPagBunifu.SetPage("AlterFornecedor");

            PopulaNomeFrn();
            PopulaProdutoFrn();
        }
    //Relátorios
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            Indicator.Top = ((Control)sender).Top;
            TabPagBunifu.SetPage("Relatórios");
        }
    //Quartos
        private void btnQuartos_Click(object sender, EventArgs e)
        {
            Indicator.Top = ((Control)sender).Top;
            TabPagBunifu.SetPage("Quartos");
        }
        private void BtnQ13_Click(object sender, EventArgs e)
        {
            Q13 = new Thread(AbrirQuarto13);
            Q13.SetApartmentState(ApartmentState.STA);
            Q13.Start();
        }
        private void BtnQ15_Click(object sender, EventArgs e)
        {
            Q15 = new Thread(AbrirQuarto15);
            Q15.SetApartmentState(ApartmentState.STA);
            Q15.Start();
        }

        private void BtnQ29_Click(object sender, EventArgs e)
        {
            Q29 = new Thread(AbrirQuarto29);
            Q29.SetApartmentState(ApartmentState.STA);
            Q29.Start();
        }

        private void BtnQ37_Click(object sender, EventArgs e)
        {
            Q37 = new Thread(AbrirQuarto37);
            Q37.SetApartmentState(ApartmentState.STA);
            Q37.Start();
        }
        private void BtnQ67_Click(object sender, EventArgs e)
        {
            Q67 = new Thread(AbrirQuarto67);
            Q67.SetApartmentState(ApartmentState.STA);
            Q67.Start();
        }
        private void BtnQ89_Click(object sender, EventArgs e)
        {
            Q89 = new Thread(AbrirQuarto89);
            Q89.SetApartmentState(ApartmentState.STA);
            Q89.Start();
        }
        //Produtos
        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            Indicator.Top = ((Control)sender).Top;
            TabPagBunifu.SetPage("SolicitarProduto");

            PopulaProduto();

            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDReserva reserva = new BDReserva(Banco);

        }

        private void TxtQProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void DbxNProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDProdutos produto = new BDProdutos(Banco);


            produto.NomeProduto = DbxNProduto.Text;
            if (contador > 1)
            {
                produto.ValorUnitario = double.Parse(DbxNProduto.SelectedValue.ToString());
                lblValorUnitario.Text = "R$ " + produto.ValorUnitario.ToString();
                PnlValorUnitario.Visible = true;
                PnlQuantidade.Visible = true;
                PnlPrecoTotal.Visible = true;
                BtnSolicitarProduto.Visible = true;
                TxtQProduto.Text = "1";
                lblPrecoTotal.Text = produto.ValorUnitario.ToString();
            }
            else
            {
                lblValorUnitario.Text = "R$ 00.00";
            }
            contador++;
        }

        private void TxtQProduto_TextChange(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDProdutos produto = new BDProdutos(Banco);

            if (TxtQProduto.Text != "")
            {
                produto.Quantidade = Convert.ToInt32(TxtQProduto.Text);
                produto.ValorUnitario = double.Parse(DbxNProduto.SelectedValue.ToString());

                lblPrecoTotal.Text = "R$ " + (produto.Quantidade * produto.ValorUnitario).ToString();


            }
            else
            {
                produto.Quantidade = 0;
            }
        }

        private void BtnSolicitarProduto_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDProdutos produto = new BDProdutos(Banco);

            produto.NomeProduto = DbxNProduto.Text;
            produto.Quantidade = Convert.ToInt32(TxtQProduto.Text);

            produto.SolicitarProduto();
        }

        private void BtnPAll_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDProdutos produto = new BDProdutos(Banco);

            DgProdutos.DataSource = produto.Consultar();
        }

        private void BtnFrnAll_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFornecedores fornecedor = new BDFornecedores(Banco);

            DgInsFornecedor.DataSource = fornecedor.Consultar();
        }

        private void BtnFrnSave_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFornecedores fornecedor = new BDFornecedores(Banco);

            fornecedor.Nome = TxtFrnName.Text;
            fornecedor.Telefone = TxtFrnTel.Text;
            fornecedor.Telefone_Alt = TxtFrnTel2.Text;

            fornecedor.InserirForncedor();
        }

        private void DbxNomeFrn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFornecedores fornecedor = new BDFornecedores(Banco);
            
            fornecedor.Nome = DbxNomeFrn.Text;
            fornecedor.ID = DbxNomeFrn.SelectedValue.ToString();

        }

        private void DbxProdutoFrn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFornecedores fornecedor = new BDFornecedores(Banco);

            fornecedor.NomeProduto = DbxProdutoFrn.Text;
            fornecedor.IdProduto = DbxProdutoFrn.SelectedValue.ToString();
        }

        private void BtnNewFrnSave_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFornecedores fornecedor = new BDFornecedores(Banco);

            fornecedor.ID = DbxNomeFrn.SelectedValue.ToString();
            fornecedor.IdProduto = DbxProdutoFrn.SelectedValue.ToString();
            fornecedor.Telefone = TxtNewFrnTel.Text;
            fornecedor.Telefone_Alt = TxtNewFrnTel2.Text;

            fornecedor.AtualizarForncedor();
        }

        private void BtnNewFrnAll_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFornecedores fornecedor = new BDFornecedores(Banco);

            DgUpdFornecedor.DataSource = fornecedor.Consultar();
        }

        private void BtnNewFrnFornecedor_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFornecedores fornecedor = new BDFornecedores(Banco);

            DgUpdFornecedor.DataSource = fornecedor.ConsultarFornecedores();
        }

        private void BtnNewProdutos_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            BDFornecedores fornecedor = new BDFornecedores(Banco);

            DgUpdFornecedor.DataSource = fornecedor.ConsultarProdutos();
        }
    }
}
