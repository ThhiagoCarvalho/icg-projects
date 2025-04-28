using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadePentagono
{
    public partial class Form1 : Form
    {
        int[] pontos = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        public Color cor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
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

        public void pentagono(PaintEventArgs e, int[] pontos, Pen caneta)
        {
            for (int i = 0; i < 7; i += 2)
            {
                reta(pontos[i], pontos[i + 1], pontos[i + 2], pontos[i + 3], caneta, e);
            }
            reta(pontos[8], pontos[9], pontos[0], pontos[1], caneta, e);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen caneta = caneta_estilo(1, cor(255, 0, 0));

            pontos[0] = 100; pontos[1] = 100;   
            pontos[2] = 50; pontos[3] = 150;  
            pontos[4] = 50; pontos[5] = 220;  
            pontos[6] = 150; pontos[7] = 220;  
            pontos[8] = 150; pontos[9] = 150;  

            pentagono(e, pontos, caneta);
        }
    }
}
