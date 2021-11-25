using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TelaMenuPIM.ButtonsPIM
{
    public class MenuRender : ToolStripProfessionalRenderer
    {
        private Color CorPrimaria;
        private Color CorTexto;
        private int Setinhas;

        public MenuRender(bool MenuPrincipal, Color CorPrimaria, Color CorTexto):base(new MenuColorTable(MenuPrincipal, CorPrimaria))
        {
            this.CorPrimaria = CorPrimaria;
            this.CorTexto = CorTexto;
            if (MenuPrincipal) Setinhas = 3;
            else Setinhas = 2;
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : CorTexto;
        }
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            var Grafico = e.Graphics;
            var TamanhoSetinha = new Size(5,12);
            var CorSetinha = e.Item.Selected ? Color.White : CorPrimaria;
            var Retangulo = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height - TamanhoSetinha.Height) / 2, TamanhoSetinha.Width, TamanhoSetinha.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen Caneta = new Pen(CorSetinha, Setinhas))
            {
                Grafico.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(Retangulo.Left, Retangulo.Top, Retangulo.Right, Retangulo.Top + Retangulo.Height / 2);
                path.AddLine(Retangulo.Right, Retangulo.Top + Retangulo.Height / 2, Retangulo.Left, Retangulo.Top + Retangulo.Height);
                Grafico.DrawPath(Caneta, path);
            }
            {

            }
        }

    }
}
