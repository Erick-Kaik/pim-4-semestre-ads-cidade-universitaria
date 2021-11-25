using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
