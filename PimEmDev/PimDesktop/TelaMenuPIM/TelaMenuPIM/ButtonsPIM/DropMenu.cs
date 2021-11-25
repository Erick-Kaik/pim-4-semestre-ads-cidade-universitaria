using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace TelaMenuPIM.ButtonsPIM
{
    public class DropMenu : ContextMenuStrip
    {
        private bool MenuPrincipal;
        private int ItemMenuHeight = 45;
        private Color ItemMenuCorTexto = Color.FromArgb(28, 38, 61);
        private Color CorPrimaria = Color.FromArgb(255,0,0);

        private Bitmap ItemMenuHeaderSize;

        public DropMenu(IContainer container) : base(container)
        {

        }
        [Browsable(false)]
        public bool MenuPrincipal1 { get => MenuPrincipal; set => MenuPrincipal = value; }
        [Browsable(false)]
        public int ItemMenuHeight1 { get => ItemMenuHeight; set => ItemMenuHeight = value; }
        [Browsable(false)]
        public Color ItemMenuCorTexto1 { get => ItemMenuCorTexto; set => ItemMenuCorTexto = value; }
        [Browsable(false)]
        public Color CorPrimaria1 { get => CorPrimaria; set => CorPrimaria = value; }

        private void LoadAparenciaItemMenu()
        {
            if (MenuPrincipal)
            {
                ItemMenuHeaderSize = new Bitmap(20,45);
                ItemMenuCorTexto = Color.FromArgb(255,255,255);
            }
            else
            {
                ItemMenuHeaderSize = new Bitmap(20, ItemMenuHeight);
            }

            foreach(ToolStripMenuItem ItemMenuL1 in this.Items)
            {
                ItemMenuL1.ForeColor = ItemMenuCorTexto;
                ItemMenuL1.ImageScaling = ToolStripItemImageScaling.None;
                if (ItemMenuL1.Image == null) ItemMenuL1.Image = ItemMenuHeaderSize;

                foreach (ToolStripMenuItem ItemMenuL2 in ItemMenuL1.DropDownItems)
                {
                    ItemMenuL2.ForeColor = ItemMenuCorTexto;
                    ItemMenuL2.ImageScaling = ToolStripItemImageScaling.None;
                    if (ItemMenuL2.Image == null) ItemMenuL2.Image = ItemMenuHeaderSize;
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.DesignMode == false)
            {
                LoadAparenciaItemMenu();
                this.Renderer = new MenuRender(MenuPrincipal, CorPrimaria, ItemMenuCorTexto);
                LoadAparenciaItemMenu();
            }
        }
    }
}
