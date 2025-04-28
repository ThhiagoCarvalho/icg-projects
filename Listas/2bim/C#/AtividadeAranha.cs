using System.Drawing;

/*Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 26 / 04 / 2025
 * Autores do Projeto: Rodrigo Roda Oliveto Alves
 *                     Thiago Alexander Moreira Mancilla
 *                     Thiago César Carvalho
 *
 * Turma: 3°H
 * Atividade Proposta em aula
 * Observação: Após o mapemento dos 80 pontos, percebemos que a imagem formada foi a de uma Aranha
 * 
 * 
 * ******************************************************************/


/*  Resposta da Questão 6 - Perguntas a dissertar
 *  a) Para o desenvolvimento dos 5 exercícios, utilizamos as primitivas de reta, cor e estilo/caneta. Usamos
 *  essas ferramentas para desenvolvermos as novas primitivas/métodos de triângulo, estrela, retângulo, pentágono e aranha.
 *  b) Dentre as citadas no item anterior, a principal foi a primitiva de retas.
 *  c) Para os novos métodos que produzimos, todos tinham algo em comum: partiam do princípio de desenhar uma reta e, repetindo
 *  este processo, formar a nova forma desejada. Dentre todas as primitivas, a da reta era totalmente indispensável na resolução
 *  da problemática.
 *  d) Seguindo o que aprendemos nas aulas, que primitivas são métodos os quais realizam alterações gráficas, com esta atividade
 *  prática foi capaz de compreender de escalar as primtivas, partindo do mais simples e, com esta função simples, construir aquilo
 *  que é mais complexo. Da forma que aprendemos durante as aulas e implementamos agora na prática, conseguimos obter um código limpo,
 *  de fácil manutentabilidade, aprimoramento e de fácil leitura. Esta atividade agregou muito não só nos conhecimento de Computação
 *  Gráfica, mas também para aprendermos como organizar nosso código de maneira mais eficiente e profissional.
 */


namespace Atividade80Pontos
{
    public partial class Form1 : Form
    {
        int[] pontos = new int[160];

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

        public void aranha(PaintEventArgs e, int[] pontos, Pen caneta)
        {
            for (int i = 0; i < 157; i += 2)
            {
                reta(pontos[i], pontos[i + 1], pontos[i + 2], pontos[i + 3], caneta, e);
            }
            reta(pontos[158], pontos[159], pontos[0], pontos[1], caneta, e);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen caneta = caneta_estilo(1, cor(255, 0, 0));

            pontos[0] = 113; pontos[1] = 66;
            pontos[2] = 100; pontos[3] = 201;
            pontos[4] = 109; pontos[5] = 334;
            pontos[6] = 165; pontos[7] = 341;
            pontos[8] = 147; pontos[9] = 321;
            pontos[10] = 143; pontos[11] = 249;
            pontos[12] = 160; pontos[13] = 133;
            pontos[14] = 202; pontos[15] = 41;
            pontos[16] = 180; pontos[17] = 210;
            pontos[18] = 187; pontos[19] = 323;
            pontos[20] = 252; pontos[21] = 325;
            pontos[22] = 228; pontos[23] = 295;
            pontos[24] = 221; pontos[25] = 251;
            pontos[26] = 227; pontos[27] = 204;
            pontos[28] = 257; pontos[29] = 171;
            pontos[30] = 287; pontos[31] = 173;
            pontos[32] = 310; pontos[33] = 209;
            pontos[34] = 316; pontos[35] = 258;
            pontos[36] = 305; pontos[37] = 296;
            pontos[38] = 283; pontos[39] = 323;
            pontos[40] = 334; pontos[41] = 330;
            pontos[42] = 353; pontos[43] = 304;
            pontos[44] = 356; pontos[45] = 211;
            pontos[46] = 350; pontos[47] = 123;
            pontos[48] = 339; pontos[49] = 40;
            pontos[50] = 382; pontos[51] = 131;
            pontos[52] = 394; pontos[53] = 234;
            pontos[54] = 390; pontos[55] = 308;
            pontos[56] = 371; pontos[57] = 337;
            pontos[58] = 424; pontos[59] = 337;
            pontos[60] = 443; pontos[61] = 260;
            pontos[62] = 435; pontos[63] = 161;
            pontos[64] = 426; pontos[65] = 64;
            pontos[66] = 459; pontos[67] = 147;
            pontos[68] = 472; pontos[69] = 234;
            pontos[70] = 475; pontos[71] = 308;
            pontos[72] = 465; pontos[73] = 368;
            pontos[74] = 402; pontos[75] = 375;
            pontos[76] = 327; pontos[77] = 368;
            pontos[78] = 404; pontos[79] = 400;
            pontos[80] = 496; pontos[81] = 447;
            pontos[82] = 487; pontos[83] = 537;
            pontos[84] = 446; pontos[85] = 652;
            pontos[86] = 399; pontos[87] = 738;
            pontos[88] = 422; pontos[89] = 649;
            pontos[90] = 442; pontos[91] = 566;
            pontos[92] = 456; pontos[93] = 477;
            pontos[94] = 408; pontos[95] = 442;
            pontos[96] = 407; pontos[97] = 522;
            pontos[98] = 384; pontos[99] = 604;
            pontos[100] = 339; pontos[101] = 706;
            pontos[102] = 362; pontos[103] = 588;
            pontos[104] = 370; pontos[105] = 467;
            pontos[106] = 337; pontos[107] = 418;
            pontos[108] = 336; pontos[109] = 518;
            pontos[110] = 319; pontos[111] = 601;
            pontos[112] = 284; pontos[113] = 664;
            pontos[114] = 265; pontos[115] = 675;
            pontos[116] = 245; pontos[117] = 666;
            pontos[118] = 210; pontos[119] = 610;
            pontos[120] = 195; pontos[121] = 542;
            pontos[122] = 196; pontos[123] = 416;
            pontos[124] = 163; pontos[125] = 442;
            pontos[126] = 159; pontos[127] = 498;
            pontos[128] = 169; pontos[129] = 589;
            pontos[130] = 189; pontos[131] = 708;
            pontos[132] = 133; pontos[133] = 566;
            pontos[134] = 119; pontos[135] = 483;
            pontos[136] = 129; pontos[137] = 440;
            pontos[138] = 74; pontos[139] = 479;
            pontos[140] = 95; pontos[141] = 610;
            pontos[142] = 126; pontos[143] = 737;
            pontos[144] = 65; pontos[145] = 597;
            pontos[146] = 42; pontos[147] = 529;
            pontos[148] = 38; pontos[149] = 439;
            pontos[150] = 113; pontos[151] = 401;
            pontos[152] = 203; pontos[153] = 368;
            pontos[154] = 73; pontos[155] = 377;
            pontos[156] = 63; pontos[157] = 267;
            pontos[158] = 75; pontos[159] = 167;


            aranha(e, pontos, caneta);
        }

    }
}
