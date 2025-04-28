using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeEstrela
{
    public partial class Form1 : Form
    {
        int[] pontos = new int[20];

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

        public void estrela(PaintEventArgs e, int[] pontos, Pen caneta)
        {
            for (int i = 0; i < 17; i += 2)
            {
                reta(pontos[i], pontos[i + 1], pontos[i + 2], pontos[i + 3], caneta, e);
            }
            reta(pontos[18], pontos[19], pontos[0], pontos[1], caneta, e);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen caneta = caneta_estilo(1, cor(255, 0, 0));

            pontos[0] = 250; pontos[1] = 50;   // Ponto 1 (topo)
            pontos[2] = 300; pontos[3] = 150;  // Ponto 2 (direita superior)
            pontos[4] = 450; pontos[5] = 150;  // Ponto 3 (direita)
            pontos[6] = 325; pontos[7] = 225;  // Ponto 4 (direita inferior)
            pontos[8] = 375; pontos[9] = 375;  // Ponto 5 (baixo direito)
            pontos[10] = 250; pontos[11] = 300; // Ponto 6 (centro baixo)
            pontos[12] = 125; pontos[13] = 375; // Ponto 7 (baixo esquerdo)
            pontos[14] = 175; pontos[15] = 225; // Ponto 8 (esquerda inferior)
            pontos[16] = 50; pontos[17] = 150; // Ponto 9 (esquerda)
            pontos[18] = 200; pontos[19] = 150; // Ponto 10 (esquerda superior)

            estrela(e, pontos, caneta);
        }
    }
}
