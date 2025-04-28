using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeWagner2BIM
{
    public partial class Form1 : Form
    {
        int x1, y1, x2, y2, x3, y3;
        
        public Form1()
        {
            InitializeComponent();
        }

        public Color cor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen caneta = caneta_estilo(1, cor(255, 0, 0));
            triangulo(e, 100, 100, 400, 120, 250, 400, caneta);
        }

        public Pen caneta_estilo(int espessura, Color cor, float[] estilo = null)
        {
            Pen caneta = new Pen(cor, espessura);
            if (estilo != null) caneta.DashPattern = estilo;
            return caneta;
        }

        public void reta(int x0, int y0, int x1, int y1, Pen caneta, PaintEventArgs e)
        {
            e.Graphics.DrawLine(caneta, x0, y0, x1, y1);
        }

        public void triangulo(PaintEventArgs e, int x0, int y0, int x1, int y1, int x2, int y2, Pen caneta)
        {
            reta(x0, y0, x1, y1, caneta, e);
            reta(x1, y1, x2, y2, caneta, e);
            reta(x2, y2, x0, y0, caneta, e);
        }
    }
}
