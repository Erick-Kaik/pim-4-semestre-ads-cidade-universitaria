using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaMenuPIM
{
    public partial class FormQ67 : Form
    {
        Thread Q37;
        Thread Q89;
        void AbrirQuarto37(object obj)
        {
            Application.Run(new FormQ37());
        }
        void AbrirQuarto89(object obj)
        {
            Application.Run(new FormQ89());
        }
        public FormQ67()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSetaDir_Click(object sender, EventArgs e)
        {
            Q89 = new Thread(AbrirQuarto89);
            Q89.SetApartmentState(ApartmentState.STA);
            Q89.Start();
            Close();
        }

        private void BtnSetaEsq_Click(object sender, EventArgs e)
        {
            Q37 = new Thread(AbrirQuarto37);
            Q37.SetApartmentState(ApartmentState.STA);
            Q37.Start();
            Close();
        }
    }
}
