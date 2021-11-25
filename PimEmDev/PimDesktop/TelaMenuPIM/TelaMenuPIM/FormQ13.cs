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
    public partial class FormQuartos : Form
    {
        Thread Q15;
        Thread Q89;
        void AbrirQuarto15(object obj)
        {
            Application.Run(new FormQ15());
        }
        void AbrirQuarto89(object obj)
        {
            Application.Run(new FormQ89());
        }
        public FormQuartos()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSetaDir_Click(object sender, EventArgs e)
        {
            Q15 = new Thread(AbrirQuarto15);
            Q15.SetApartmentState(ApartmentState.STA);
            Q15.Start();
            Close();
        }

        private void BtnSetaEsq_Click(object sender, EventArgs e)
        {
            Q89 = new Thread(AbrirQuarto89);
            Q89.SetApartmentState(ApartmentState.STA);
            Q89.Start();
            Close();
        }
    }
}
