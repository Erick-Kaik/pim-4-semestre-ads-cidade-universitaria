using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DllConfiguracoesCamadas;
using DllEspecifica;
using System.Threading;
using DllGenerica;

namespace TelaMenuPIM
{
    public partial class FormCadastro : Form
    {
        Thread l1;
        void TelaLogin(object obj)
        {
            Application.Run(new FormLogin());
        }
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            PopulaNomeFunc();
        }

        void PopulaNomeFunc()
        {
            CadastroLogin cadastro = new CadastroLogin("BancoDeDados");
            DbxNomeFunc.DataSource = cadastro.PuxaNomeFunc();
            DbxNomeFunc.DisplayMember = "Nome";
            DbxNomeFunc.ValueMember = "Id_Funcionario";
        }

        private void BtnSetaVoltar_Click(object sender, EventArgs e)
        {
            l1 = new Thread(TelaLogin);
            l1.SetApartmentState(ApartmentState.STA);
            l1.Start();
            Close();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            l1 = new Thread(TelaLogin);
            l1.SetApartmentState(ApartmentState.STA);
            l1.Start();
            Close();
        }

        private void BtnCadUser_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            CadastroLogin cadastro = new CadastroLogin(Banco);

            cadastro.Usuario = TxtCadUsuario.Text;
            cadastro.IdFuncionario = DbxNomeFunc.SelectedValue.ToString();
            if(TxtSenha.Text == TxtConfirmSenha.Text && TxtSenha.Text != "" && TxtConfirmSenha.Text != "")
            {
                cadastro.Senha = TxtSenha.Text; 
                cadastro.CadastrarUsuario();
                l1 = new Thread(TelaLogin);
                l1.SetApartmentState(ApartmentState.STA);
                l1.Start();
                Close();
            }
            else
            {
                MessageBox.Show("A senha deve ser iguais no dois campos e não podem estar vazias!");
                TxtSenha.Clear();
                TxtConfirmSenha.Clear();
            }

        }
    }
}
