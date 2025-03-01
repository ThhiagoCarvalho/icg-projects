using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0, y = 0, r = 0, g = 0, b = 0;

        private void Pintap(int x, int y, int r, int g, int b, PaintEventArgs e)
        {
            Color cor = new Color();
            cor = Color.FromArgb(r, g, b);
            Pen caneta = new Pen(cor, 12);
            e.Graphics.DrawLine(caneta, x, y, x + 1, y);
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        Pintap(x, y, r, g, b, e);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Lines.Length != 2 || textBox2.Lines.Length != 3)
            {
                erro("Digite corretamente as entradas de dados para as coordenadas e para RGB");
                return;
            }
            else
            {
                x = int.Parse(textBox1.Lines[0].ToString());
                y = int.Parse(textBox1.Lines[1].ToString());

                r = int.Parse(textBox2.Lines[0].ToString());
                g = int.Parse(textBox2.Lines[1].ToString());
                b = int.Parse(textBox2.Lines[2].ToString());

                listBox1.Items.Add("Coordenada X: " + x);
                listBox1.Items.Add("Coordenada Y: " + y);
                Refresh();

            }
        }

        public void erro  (string txt)
        {
            label1.ForeColor = Color.Red;
            label1.Text = txt;
        }
    }
}
