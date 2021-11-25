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
    public partial class FormQ15 : Form
    {
        Thread Q13;
        Thread Q29;
        void AbrirQuarto13(object obj)
        {
            Application.Run(new FormQuartos());
        }
        void AbrirQuarto29(object obj)
        {
            Application.Run(new FormQ29());
        }
        public FormQ15()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSetaDir_Click(object sender, EventArgs e)
        {
            Q29 = new Thread(AbrirQuarto29);
            Q29.SetApartmentState(ApartmentState.STA);
            Q29.Start();
            Close();
        }

        private void BtnSetaEsq_Click(object sender, EventArgs e)
        {
            Q13 = new Thread(AbrirQuarto13);
            Q13.SetApartmentState(ApartmentState.STA);
            Q13.Start();
            Close();
        }
    }
}
