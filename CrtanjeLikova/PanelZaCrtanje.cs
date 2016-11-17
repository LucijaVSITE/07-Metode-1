using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrtanjeLikova.GeometrijskiLikovi;

namespace CrtanjeLikova
{
    public partial class PanelZaCrtanje : System.Windows.Forms.Panel
    {
        public PanelZaCrtanje()
        {
            InitializeComponent();
            SložiCrtež();
        }

        public void PomakniLikove(float dx, float dy)
        {
            foreach (GeometrijskiLik lik in crtež)
                lik.Pomakni(dx, dy);
            Invalidate();
        }

        public void UvećajLikove(float faktor)
        {
            foreach (GeometrijskiLik lik in crtež)
                lik.Uvećaj(faktor);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            foreach (GeometrijskiLik lik in crtež)
                lik.Nacrtaj(pe.Graphics);
            base.OnPaint(pe);
        }

        private void SložiCrtež()
        {
            crtež.Add(new Pravokutnik(10, 10, 40, 30));
            crtež.Add(new Elipsa(80, 60, 60, 40));
            crtež.Add(new Pravokutnik(100, 120, 50, 20));
            crtež.Add(new Elipsa(180, 80, 50, 80));
            crtež.Add(new Trokut(200, 100, 300, 13, 222, 333));
        }

        List<GeometrijskiLik> crtež = new List<GeometrijskiLik>();
    }
}
