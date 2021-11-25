using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TelaMenuPIM.ButtonsPIM
{
    public class MenuColorTable : ProfessionalColorTable
    {
        private Color CorFundo;
        private Color CorColunaEsquerda;
        private Color CorBorda;
        private Color ItemMenuCorBorda;
        private Color ItemMenuSelecionadoCor;

        public MenuColorTable(bool MenuPrincipal, Color CorPrimaria)
        {
            if (MenuPrincipal)
            {
                CorFundo = Color.FromArgb(28, 38, 61);
                CorColunaEsquerda = Color.FromArgb(101, 100, 219);
                CorBorda = Color.FromArgb(28, 38, 61);
                ItemMenuCorBorda = CorPrimaria;
                ItemMenuSelecionadoCor = CorPrimaria;
            }
            else
            {
                CorFundo = Color.White;
                CorColunaEsquerda = Color.SlateBlue;
                CorBorda = Color.Pink;
                ItemMenuCorBorda = CorPrimaria;
                ItemMenuSelecionadoCor = CorPrimaria;
            }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return CorFundo;
            }
        }
        public override Color MenuBorder
        {
            get
            {
                return CorBorda;
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return ItemMenuCorBorda;
            }
        }
        public override Color MenuItemSelected
        {
            get
            {
                return ItemMenuSelecionadoCor;
            }
        }
        public override Color ImageMarginGradientBegin
        {
            get
            {
                return CorColunaEsquerda;
            }
        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return CorColunaEsquerda;
            }
        }
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return CorColunaEsquerda;
            }
        }

    }
}
