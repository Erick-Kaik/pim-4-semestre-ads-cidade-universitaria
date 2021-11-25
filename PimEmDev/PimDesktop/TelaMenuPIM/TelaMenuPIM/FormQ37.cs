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
    public partial class FormQ37 : Form
    {
        Thread Q29;
        Thread Q67;
        void AbrirQuarto29(object obj)
        {
            Application.Run(new FormQ29());
        }
        void AbrirQuarto67(object obj)
        {
            Application.Run(new FormQ67());
        }
        public FormQ37()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSetaDir_Click(object sender, EventArgs e)
        {
            Q67 = new Thread(AbrirQuarto67);
            Q67.SetApartmentState(ApartmentState.STA);
            Q67.Start();
            Close();
        }

        private void BtnSetaEsq_Click(object sender, EventArgs e)
        {
            Q29 = new Thread(AbrirQuarto29);
            Q29.SetApartmentState(ApartmentState.STA);
            Q29.Start();
            Close();
        }
    }
}
