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


namespace TelaMenuPIM
{   
    public partial class FormLogin : Form
    {
        Thread c1;
        Thread m1;
        void TelaCadastro(object obj)
        {
            Application.Run(new FormCadastro());
        }

        void Menu(object obj)
        {
            Application.Run(new FrmMenu());
        }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void LinkBtnCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            c1 = new Thread(TelaCadastro);
            c1.SetApartmentState(ApartmentState.STA);
            c1.Start();
            Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Banco = ConfiguracaoSistema.BancoDeDados("Banco");
            CadastroLogin cadastro = new CadastroLogin(Banco);
            

            if (TxtUser.Text != "" && TxtPassaword.Text != "")
            {
                cadastro.Usuario = TxtUser.Text;
                cadastro.Senha = TxtPassaword.Text;
                cadastro.Login();

                if(cadastro.permissao>0)
                {
                    m1 = new Thread(Menu);
                    m1.SetApartmentState(ApartmentState.STA);
                    m1.Start();
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUser.Clear();
                    TxtPassaword.Clear();
                }
            }
            else
            {
                MessageBox.Show("Os campos devem ser preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUser.Clear();
                TxtPassaword.Clear();
            }
        }
    }
}
