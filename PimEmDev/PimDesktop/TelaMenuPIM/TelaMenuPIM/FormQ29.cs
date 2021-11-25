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
    public partial class FormQ29 : Form
    {
        Thread Q15;
        Thread Q37;
        void AbrirQuarto15(object obj)
        {
            Application.Run(new FormQ15());
        }
        void AbrirQuarto37(object obj)
        {
            Application.Run(new FormQ37());
        }
        public FormQ29()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSetaDir_Click(object sender, EventArgs e)
        {
            Q37 = new Thread(AbrirQuarto37);
            Q37.SetApartmentState(ApartmentState.STA);
            Q37.Start();
            Close();
        }

        private void BtnSetaEsq_Click(object sender, EventArgs e)
        {
            Q15 = new Thread(AbrirQuarto15);
            Q15.SetApartmentState(ApartmentState.STA);
            Q15.Start();
            Close();
        }
    }
}
