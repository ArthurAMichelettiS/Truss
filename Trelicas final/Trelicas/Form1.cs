using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Trelicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //cores
        Brush corApoios = Brushes.DarkCyan;
        Color corBarras = Color.DimGray;
        Color corBarrasRemovendo= Color.DarkMagenta;
        Brush corDosPontos = Brushes.DarkOrange;
        int raioDosPontos = 12;
        //

        float zoom = 1;

        Bitmap b;
        Graphics g;

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pbTela.Width, pbTela.Height);
            g = Graphics.FromImage(b);
            KeyPreview = true;
        }

        string[] alfabeto = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z".Split(' ');

        List<Forca> forcas = new List<Forca>();

        Dictionary<string, Point> pontos = new Dictionary<string, Point>();

        List<string[]> barras = new List<string[]>(); //pares de strings que guardam pares de nomes dos pontos q os formam

        string apoioMovel = "";
        string apoioFixo = "";

        string ptoSelecionado = ""; //pto selecionado no modo mover/selecionar

        string ptoLigando = ""; //primeiro pto escolhido ao ligar 2 ptos e formar uma barra
        bool ligandoEhNovo = false;

        string[] barraSelec = { "", "" }; //barra onde o mouse está posicionado no modo remover

        double forcaAplica = -1;

        Forca possivelNovaForca;

        private void LigarPontos(string pto1, string pto2)
        {
            string[] liga = { pto1, pto2};
            if (pto1 == pto2|| barras.Contains(liga))
                return;
            

            if(pontos[pto1].Y< pontos[pto2].Y)
            {
                string[] s = { pto1, pto2 };
                barras.Add(s);
                string[] s2 = { pto2, pto1 };
                barras.Add(s2);
            }
            else
            {
                string[] s = { pto2, pto1 };
                barras.Add(s);
                string[] s2 = { pto1, pto2 };
                barras.Add(s2);
            }
        } 

        private Bitmap UpdateDesenho()
        {
            g.Clear(pbTela.BackColor);

            Pen linha = new Pen(corBarras, 15);


            for (int i = 0; i < barras.Count; i+=2)
            {
                if (ptosEmTracao != null&&forcasBarras[i/2]!=0)
                    if (ptosEmTracao[i / 2])
                        linha = new Pen(Color.ForestGreen, 15);
                    else
                        linha = new Pen(Color.OrangeRed, 15);
                g.DrawLine(linha, pontos[barras[i][0]], pontos[barras[i][1]]);
            }

            if (rbRemov.Checked && barraSelec[0] != "")
            {
                linha = new Pen(corBarrasRemovendo, 15);
                g.DrawLine(linha, pontos[barraSelec[0]], pontos[barraSelec[1]]);
            }

            linha = new Pen(corBarras, 15);

            if(ptoLigando != "")
            {
                Point mouse = Point.Subtract(PointToClient(Cursor.Position), new Size(pbTela.Location));
                mouse.X = Convert.ToInt32(Math.Round(mouse.X / zoom));
                mouse.Y = Convert.ToInt32(Math.Round(mouse.Y / zoom));

                g.DrawLine(linha, pontos[ptoLigando], mouse);
            }

            foreach (var pt in pontos)
            {
                g.FillEllipse(corDosPontos, new Rectangle(pt.Value.X - raioDosPontos,
                    pt.Value.Y - raioDosPontos, 2 * raioDosPontos, 2 * raioDosPontos));
            }

            if(ptoSelecionado != "")
            {
                Brush aux = corDosPontos;
                corDosPontos = Brushes.GreenYellow;
                g.FillEllipse(corDosPontos, new Rectangle(pontos[ptoSelecionado].X - raioDosPontos,
                        pontos[ptoSelecionado].Y - raioDosPontos, 2 * raioDosPontos, 2 * raioDosPontos));
                corDosPontos = aux;
            }


            if(possivelNovaForca!=null)
            {
                DesenhaSeta(possivelNovaForca,15);
            }

            foreach (var f in forcas)
            {
                DesenhaSeta(f);
            }

            int tamanhoApoio = 25;
            //Brush corApoio = Brushes.DarkCyan;
            if(apoioFixo != "")
            {
                g.FillPie(corApoios, new Rectangle(pontos[apoioFixo].X - tamanhoApoio,
                   pontos[apoioFixo].Y - tamanhoApoio, 2 * tamanhoApoio, 2 * tamanhoApoio),
                   90 - 15, 30);
            }

            if (apoioMovel != "")
            {
                g.FillPie(corApoios, new Rectangle(pontos[apoioMovel].X - tamanhoApoio,
                   pontos[apoioMovel].Y - tamanhoApoio, 2 * tamanhoApoio, 2 * tamanhoApoio),
                   90 - 15, 30);
                g.FillEllipse(corApoios, new Rectangle(pontos[apoioMovel].X - 10,
                   pontos[apoioMovel].Y + tamanhoApoio, 2 * 5, 2 * 5));
                g.FillEllipse(corApoios, new Rectangle(pontos[apoioMovel].X,
                   pontos[apoioMovel].Y + tamanhoApoio, 2 * 5, 2 * 5));

            }

            return b;
        }

        private void DesenhaSeta(Forca f, int dExtra = 0)
        {
            Pen vetor = new Pen(Color.Black, 5);

            Point ptoAux = new Point();
            int rotacao = 0;
            int comprimentoSeta = 65;
            Point ptoAux2 = new Point(new Size(pontos[f.ponto]));
            int tamanhoSeta = 30;
            Font fonte = new Font(lblTeste.Font.FontFamily, 10);
            if (f.emX == 0)
            {
                if (f.emY < 0)
                {
                    ptoAux.X = pontos[f.ponto].X;
                    ptoAux.Y = pontos[f.ponto].Y - comprimentoSeta;
                    ptoAux2.Offset(0, -(tamanhoSeta - 5));
                    rotacao = 1;
                }
                else
                {
                    ptoAux.X = pontos[f.ponto].X;
                    ptoAux.Y = pontos[f.ponto].Y + comprimentoSeta;
                    ptoAux2.Offset(0, (tamanhoSeta - 5));
                    rotacao = 3;
                }

                g.DrawString(Math.Abs(Math.Round(f.emY,2)).ToString()+" N", fonte, Brushes.Black, new Point(ptoAux.X+5, ptoAux.Y-dExtra-(int)(Font.Size/2)));

            }
            else
            {
                if (f.emX < 0)
                {
                    ptoAux.X = pontos[f.ponto].X + comprimentoSeta;
                    ptoAux.Y = pontos[f.ponto].Y;
                    ptoAux2.Offset((tamanhoSeta - 5), 0);
                    rotacao = 2;
                }
                else
                {
                    ptoAux.X = pontos[f.ponto].X - comprimentoSeta;
                    ptoAux.Y = pontos[f.ponto].Y;
                    ptoAux2.Offset(-(tamanhoSeta - 5), 0);
                    rotacao = 4;
                }

                g.DrawString(Math.Abs(Math.Round(f.emX, 2)).ToString() + " N", fonte, Brushes.Black, new Point(ptoAux.X-15, ptoAux.Y-15-dExtra - (int)(Font.Size / 2)));
            }
            g.DrawLine(vetor, ptoAux2, ptoAux);
            g.FillPie(Brushes.Black, new Rectangle(pontos[f.ponto].X - tamanhoSeta,
                   pontos[f.ponto].Y - tamanhoSeta, 2 * tamanhoSeta, 2 * tamanhoSeta),
                   90 * rotacao - 15 - 180, 30);
        }

        private string AcharProximoNomePto()
        {
            foreach (string letra in alfabeto)
            {
                if (!pontos.ContainsKey(letra))
                {
                    return letra;
                }
            }
            return "0";
        }

        private string NumeroPraLetra(int numero)
        {
            char c = (char)(65 + (numero - 1));

            return c.ToString();
        }

        private string ProximoAUmPonto(Point p, Point mouse)
        {
            int menorDistancia = -1;
            string pontoProximo = "";
            foreach (var pt in pontos)
            {
                double d = Math.Sqrt((pt.Value.X-mouse.X) * (pt.Value.X - mouse.X) + 
                    (pt.Value.Y - mouse.Y) * (pt.Value.Y-mouse.Y));
                if (menorDistancia == -1)
                {
                    menorDistancia = (int)d;
                    pontoProximo = pt.Key;
                }
                else if (menorDistancia > d)
                {
                    menorDistancia = (int)d;
                    pontoProximo = pt.Key;
                }
            }

            if (menorDistancia < 40)
                return pontoProximo;
            else
                return "";
        }

        private int quadranteMouse(Point centro)
        {
            Point mouse = Point.Subtract(PointToClient(Cursor.Position), new Size(pbTela.Location));
            mouse.X = Convert.ToInt32(Math.Round(mouse.X / zoom));
            mouse.Y = Convert.ToInt32(Math.Round(mouse.Y / zoom));

            if (!pbTela.Bounds.Contains(PointToClient(Cursor.Position)))
                return -1;

            Point relativo = Point.Subtract(centro, new Size(mouse));

            if (relativo.X + relativo.Y > 0)
            {
                if (relativo.X - relativo.Y > 0)
                    return 1;
                else
                    return 2;
            }
            else
            {
                if (relativo.X - relativo.Y < 0)
                    return 3;
                else
                    return 4;
            }

        }

        private void pbTela_MouseClick(object sender, MouseEventArgs e)
        {
            Point mouse = e.Location;
            mouse.X = Convert.ToInt32(Math.Round(mouse.X / zoom));
            mouse.Y = Convert.ToInt32(Math.Round(mouse.Y / zoom));
            string ptoProximo = ProximoAUmPonto(new Point(mouse.X, mouse.Y), mouse);

            if (possivelNovaForca != null)
            {
                bool achou = false;
                for (int i = 0; i < forcas.Count; i++)
                {
                    if(forcas[i].ponto == possivelNovaForca.ponto&&
                        ((forcas[i].emX == 0&& possivelNovaForca.emX==0)|| 
                        (forcas[i].emY == 0 && possivelNovaForca.emY==0)))
                    {
                        achou = true;
                        forcas[i].emX += possivelNovaForca.emX;
                        forcas[i].emY += possivelNovaForca.emY;
                        if (forcas[i].emY == 0 && forcas[i].emX == 0)
                            forcas.RemoveAt(i);
                        break;
                    }
                }
                if(!achou)
                    forcas.Add(possivelNovaForca);
                possivelNovaForca = null;
                forcaAplica = -1;
                btnForca.Text = "Adicionar Força";
                return;
            }

            if (rbAdicionar.Checked)
            {
                if (ptoLigando == "")
                {
                    if (ptoProximo != "")
                    {
                        ptoLigando = ptoProximo;
                        ligandoEhNovo = false;
                    }
                    else
                    {
                        string novoPonto = AcharProximoNomePto();

                        pontos.Add(novoPonto, new Point(mouse.X, mouse.Y));

                        ptoLigando = novoPonto;
                        ligandoEhNovo = true;
                    }
                }
                else
                {
                    if (ptoProximo != "")
                    {
                        LigarPontos(ptoProximo, ptoLigando);
                    }
                    else if(!ligandoEhNovo||pontos.Count<2)
                    {
                        string novoPonto = AcharProximoNomePto();

                        pontos.Add(novoPonto, new Point(mouse.X, mouse.Y));

                        LigarPontos(novoPonto, ptoLigando);
                    }
                    else
                    {
                        pontos.Remove(ptoLigando);
                    }
                    
                    ptoLigando = "";
                }
            }
            else if (rbMover.Checked)
            {
                if (ptoProximo != "")
                {
                    ptoSelecionado = ptoProximo;
                    AtualizaPtosTxt();
                }
            }
            else if (rbRemov.Checked)
            {
                if(barraSelec[0] != "")
                {
                    for (int i = 0; i < barras.Count; i+=2)
                    {
                        if(barras[i][0] == barraSelec[0]&& barras[i][1] == barraSelec[1])
                        {
                            barras.RemoveAt(i);
                            barras.RemoveAt(i);
                            break;
                        }
                    }

                    foreach (var pto in pontos)
                    {
                        bool temUso = false;

                        for (int i = 0; i < barras.Count; i++)
                        {
                            if(barras[i][0] == pto.Key)
                            {
                                temUso = true;
                                break;
                            }
                        }

                        if (!temUso)
                        {
                            for (int i = 0; i < forcas.Count; i++)
                            {
                                if(forcas[i].ponto == pto.Key)
                                {
                                    forcas.RemoveAt(i);
                                    i--;
                                }
                            }

                            if (apoioMovel == pto.Key)
                                apoioMovel = "";

                            if (apoioFixo == pto.Key)
                                apoioFixo = "";

                            pontos.Remove(pto.Key);
                            if(pontos.Count == 1||barras.Count == 0)
                            {
                                pontos = new Dictionary<string, Point>();
                                ptoSelecionado = "";
                                apoioFixo = "";
                                apoioMovel = "";
                                forcas = new List<Forca>();
                            }
                            break;
                        }

                    }
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (ptoSelecionado!=""&& forcaAplica!=-1)
            {
                int onde = quadranteMouse(pontos[ptoSelecionado]);

                possivelNovaForca = new Forca(ptoSelecionado);
                switch (onde)
                {
                    case 1:
                        possivelNovaForca.emX = forcaAplica;
                        break;
                    case 2:
                        possivelNovaForca.emY = -forcaAplica;
                        break;
                    case 3:
                        possivelNovaForca.emX = -forcaAplica;
                        break;
                    case 4:
                        possivelNovaForca.emY = forcaAplica;
                        break;
                }
            }

            if (rbRemov.Checked)
            {
                bool selecionou = false;

                for (int i = 0; i < barras.Count; i += 2)
                {
                    if (MouseNaBarra(pontos[barras[i][0]], pontos[barras[i][1]]))
                    {
                        barraSelec[0] = barras[i][0];
                        barraSelec[1] = barras[i][1];
                        selecionou = true;
                        break;
                    }
                }

                if (!selecionou)
                {
                    barraSelec[0] = "";
                    barraSelec[1] = "";
                }
            }

            pbTela.Image = UpdateDesenho();
        }

        private void rbMover_CheckedChanged(object sender, EventArgs e)
        {
            ptoSelecionado = "";
            panelPto.Visible = true;
        }

        private void rbAdicionar_CheckedChanged(object sender, EventArgs e)
        {
            ptoSelecionado = "";
            panelPto.Visible = false;
        }

        private bool MouseNaBarra(Point p1, Point p2)
        {
            int x1 = p1.X;
            int y1 = p1.Y;

            int x2 = p2.X;
            int y2 = p2.Y;

            int tolerancia = 15;

            Point mouse = Point.Subtract(PointToClient(Cursor.Position), new Size(pbTela.Location));
            mouse.X = Convert.ToInt32(Math.Round(mouse.X / zoom));
            mouse.Y = Convert.ToInt32(Math.Round(mouse.Y / zoom));

            if ((mouse.Y < y1 || mouse.Y > y2)&& Math.Abs(y1 - y2) > tolerancia)
                return false;
            double m;

            if (x2 - x1 != 0 && Math.Abs(m = (y2 - y1) / (double)(x2 - x1)) <= 1)
            {
                //lblTeste.Text = Math.Abs(mouse.Y - (y1 + m * (mouse.X - x1))).ToString();
                if (Math.Abs(y1 - y2) <= tolerancia)
                {
                    if(x1<x2&&(mouse.X<x1|| mouse.X > x2))
                        return false;
                    if (x2 < x1 && (mouse.X < x2 || mouse.X > x1))
                        return false;
                }
                return Math.Abs(mouse.Y - (y1 + m * (mouse.X - x1))) <= tolerancia;
            }
            else
            {
                if (x1 < x2)
                {
                    m = (x2 - x1) / (double)(y2 - y1);

                    return Math.Abs(mouse.X - (x1 + m * (mouse.Y - y1))) <= tolerancia;
                }
                else
                {
                    m = (x1 - x2) / (double)(y1 - y2);

                    return Math.Abs(mouse.X - (x2 + m * (mouse.Y - y2))) <= tolerancia;
                }
            }
        }

        private void txtPtoX_Leave(object sender, EventArgs e)
        {
            if(ptoSelecionado != "")
            {
                try
                {
                    pontos[ptoSelecionado] = new Point(Convert.ToInt32(txtPtoX.Text), pontos[ptoSelecionado].Y);
                }
                catch
                {
                    if(txtPtoX.Text.Contains(",")|| txtPtoX.Text.Contains("."))
                        MessageBox.Show("Digite apenas números inteiros", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Valor inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPtoX.Text = pontos[ptoSelecionado].X.ToString();
                }
            }
        }

        private void txtPtoY_Leave(object sender, EventArgs e)
        {
            if (ptoSelecionado != "")
            {
                try
                {
                    pontos[ptoSelecionado] = new Point(pontos[ptoSelecionado].X, pbTela.Height - Convert.ToInt32(txtPtoY.Text));
                }
                catch
                {
                    if (txtPtoY.Text.Contains(",") || txtPtoY.Text.Contains("."))
                        MessageBox.Show("Digite apenas números inteiros", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Valor inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    AtualizaPtosTxt();
                }
            }
             
        }

        private void txtPtoX_KeyDown(object sender, KeyEventArgs e)
        {
            if(Keys.Enter == e.KeyCode)
            {
                lblTeste.Select();
            }   
        }

        private void txtPtoY_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                lblTeste.Select();
            }
        }

        private double Cosseno(double x1, double y1, double x2, double y2)
        {
            double distanciaX = x2 - x1;
            double distanciaY = y2 - y1;
            double tamanho = Math.Sqrt(distanciaX * distanciaX + distanciaY * distanciaY);
            return distanciaX / tamanho;
        }
        private double Seno(double x1, double y1, double x2, double y2)
        {
            double distanciaX = x2 - x1;
            double distanciaY = y2 - y1;
            double tamanho = Math.Sqrt(distanciaX * distanciaX + distanciaY * distanciaY);
            return -distanciaY / tamanho;
        }

        private double[,] GeraMatriz()
        {
            double[,] matriz = new double[pontos.Count * 2,barras.Count / 2 + 3 + 1];
            
            int cont = 0;
            foreach (var pto in pontos)
            {
                List<Forca> fs = forcas.FindAll(delegate (Forca f) { return f.ponto == pto.Key; });
                double totalX = 0;
                double totalY = 0;

                foreach (var f in fs)
                {
                    totalX += f.emX;
                    totalY += f.emY;
                }

                matriz[cont*2,matriz.GetLength(1)-1] = totalX;
                matriz[cont*2+1,matriz.GetLength(1)-1] = totalY;

                if (pto.Key == apoioFixo)
                {
                    matriz[cont*2,0] = 1;
                    matriz[cont*2+1,1] = 1;
                }
                else if (pto.Key == apoioMovel)
                {
                    matriz[cont*2+1,2] = 1;
                }

                for (int j = 0; j < barras.Count; j++)
                {
                    if (pto.Key == barras[j][0])
                    {
                        Point pt1 = pontos[barras[j][0]];
                        Point pt2 = pontos[barras[j][1]];

                        matriz[cont*2,(j / 2) + 3] = Cosseno(pt1.X, pt1.Y, pt2.X, pt2.Y);
                        matriz[cont*2+1, (j / 2) + 3] = Seno(pt1.X, pt1.Y, pt2.X, pt2.Y);
                    }
                }
                cont++;
            }
            
            return matriz;
        }

        static double[] resolveMatriz(double[,] matrS)
        {
            double[,] A = new double[matrS.GetLength(0), matrS.GetLength(1)-1];

            double[] b = new double[matrS.GetLength(0)];

            for (int i = 0; i < matrS.GetLength(0); i++)
            {
                for (int j = 0; j < matrS.GetLength(1)-1; j++)
                {
                    A[i, j] = matrS[i, j];
                }
                b[i] = matrS[i, matrS.GetLength(1)-1];
            }


            //var n = A.GetLength(1);
            var n = (int)Math.Sqrt(A.Length);    //Determina índice da matriz    

            for (int k = 0; k < n - 1; k++)
            {
                //procura o maior k (coeficiente) em módulo
                double max = Math.Abs(A[k, k]);
                int maxIndex = k;
                for (int i = k + 1; i < n; i++)
                {
                    if (max < Math.Abs(A[i, k]))
                    {
                        max = Math.Abs(A[i, k]);
                        maxIndex = i;
                    }
                }

                if (maxIndex != k)
                {
                    /*
                    troca a equação k pela equação com o
                    maior k em módulo
                    */
                    //double temp = 0;

                    for (int j = 0; j < n; j++)
                    {
                        double temp = A[k, j];
                        A[k, j] = A[maxIndex, j];
                        A[maxIndex, j] = temp;
                    }
                    double temp2 = b[k];
                    b[k] = b[maxIndex];
                    b[maxIndex] = temp2;
                }

                //Se A[k][k] é zero, então o sistema não tem solução
                //det A = 0
                if (A[k, k] == 0)
                {
                    return null;
                }
                else
                {
                    //realiza o escalonamento
                    for (int m = k + 1; m < n; m++)
                    {
                        double F = -A[m, k] / A[k, k];
                        A[m, k] = 0; //evita uma iteração
                        b[m] = b[m] + F * b[k];
                        for (int l = k + 1; l < n; l++)
                        {
                            A[m, l] = A[m, l] + F * A[k, l];
                        }
                    }
                }
            }
            //ETAPA DE RESOLUÇÃO DO SISTEMA
            double[] X = new double[n];

            for (int i = n - 1; i >= 0; i--)
            {
                X[i] = b[i];
                for (int j = i + 1; j < n; j++)
                {
                    X[i] = X[i] - X[j] * A[i, j];
                }
                X[i] = X[i] / A[i, i];
            }
            return X;
            //negativo -> tração
            //positivo -> compressão
        }

        private void btnForca_Click(object sender, EventArgs e)
        {
            if(btnForca.Text == "Cancelar")
            {
                possivelNovaForca = null;
                forcaAplica = -1;
                btnForca.Text = "Adicionar Força";
                return;
            }

            

            try
            {
                if (txtForca.Text[0] == '-')
                {
                    MessageBox.Show("Digite apenas valores positivos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                forcaAplica = Convert.ToDouble(txtForca.Text.Replace('.', ','));
                rbMover.Checked = true;
                btnForca.Text = "Cancelar";

                if (ptoSelecionado == "")
                {
                    MessageBox.Show("Selecione um ponto", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rbMover.Checked = true;
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Valor inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnApFixo_Click(object sender, EventArgs e)
        {
            
            if (ptoSelecionado != "")
            {
                if (ptoSelecionado == apoioMovel)
                    apoioMovel = "";
                apoioFixo = ptoSelecionado;
            }
            else
            {
                MessageBox.Show("Selecione um ponto", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rbMover.Checked = true;
            }
        }

        private void btnApMovel_Click(object sender, EventArgs e)
        {
            
            if (ptoSelecionado != "")
            {
                if (ptoSelecionado == apoioFixo)
                    apoioFixo = "";
                apoioMovel = ptoSelecionado;
            }
            else
            {
                MessageBox.Show("Selecione um ponto", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rbMover.Checked = true;
            }
        }

        private void btnRemvForcas_Click(object sender, EventArgs e)
        {
            if (ptoSelecionado != "")
            {
                for (int i = 0; i < forcas.Count; i++)
                {
                    if (forcas[i].ponto == ptoSelecionado)
                    {
                        forcas.RemoveAt(i);
                        i--;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um ponto", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        bool[] ptosEmTracao = null;
        double[] forcasBarras = null;
        Label[] lblTensoes;
        private void btnCalcula_Click(object sender, EventArgs e)
        {
            
            if (lblTensoes != null)
            {
                for (int i = 0; i < lblTensoes.Length; i++)
                {
                    lblTensoes[i].Dispose();
                }
                lblTensoes = null;
                ptosEmTracao = null;
                OnOffEditar();
                btnCalcula.Text = "Calcula Forças";
                return;
            }

            if (apoioFixo == ""||apoioMovel == "")
            {
                MessageBox.Show("Selecione um ponto fixo e um movel", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (barras.Count / 2 + 3 != pontos.Count * 2)
            {
                MessageBox.Show("Treliça inválida, para ser calculada neste software deve seguir o padrão:" 
                    + Environment.NewLine + "Número de apoios (3) + número de barras = número de pontos * 2", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            int b = 2;
            double[] variaveisResposta = resolveMatriz(GeraMatriz());
            ptosEmTracao = new bool[variaveisResposta.Length-3];
            forcasBarras = new double[variaveisResposta.Length-3];

            if(lblTensoes != null)
            {
                for (int i = 0; i < lblTensoes.Length; i++)
                {
                    lblTensoes[i].Dispose();
                }
            }

            lblTensoes = new Label[variaveisResposta.Length-3];


            for (int i = 0; i < variaveisResposta.Length-3; i++)
            {
                lblTensoes[i] = new Label();
                Controls.Add(lblTensoes[i]);
                lblTensoes[i].AutoSize = true;
                lblTensoes[i].BringToFront();
                forcasBarras[i] = variaveisResposta[i + 3];
                lblTensoes[i].Text =Math.Abs(Math.Round(variaveisResposta[i + 3], 2)).ToString() + "N";
                lblTensoes[i].Parent = pbTela;
                lblTensoes[i].Font = new Font(lblTensoes[i].Font.FontFamily, 11 * zoom);
                Point local = Point.Subtract(PontoMeio(pontos[barras[i * 2][0]], pontos[barras[i * 2][1]]), 
                    new Size(lblTensoes[i].Width/2, lblTensoes[i].Height / 2));
                lblTensoes[i].Location = new Point (Convert.ToInt32(local.X*zoom), Convert.ToInt32(local.Y*zoom));
                ptosEmTracao[i] = variaveisResposta[i + 3] < 0;
            }

            rbMover.Checked = true;
            OnOffEditar();

            btnCalcula.Text = "Voltar a editar";
        }

        private void OnOffEditar()
        {
            panelLegenda.Visible = !panelLegenda.Visible;
            panelForca.Enabled = !panelForca.Enabled;
            panelPto.Enabled = !panelPto.Enabled;
            btnApFixo.Enabled = !btnApFixo.Enabled;
            btnApMovel.Enabled = !btnApMovel.Enabled;
            rbMover.Checked = !rbMover.Checked;
            rbMover.Enabled = !rbMover.Enabled;
            rbRemov.Enabled = !rbRemov.Enabled;
            btnLimpa.Enabled = !btnLimpa.Enabled;
            rbAdicionar.Enabled = !rbAdicionar.Enabled;
            ptoSelecionado = "";
        }

        private Point PontoMeio(Point A, Point B)
        {
            return new Point((A.X+B.X)/2, (A.Y + B.Y) / 2);
        }

        private void pbTela_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveEsq_Click(object sender, EventArgs e)
        {
            MoveTelaPontos(new Size(-1, 0));
        }

        private void btnMoveDir_Click(object sender, EventArgs e)
        {
            MoveTelaPontos(new Size(1, 0));
        }

        private void btnMoveCima_Click(object sender, EventArgs e)
        {
            MoveTelaPontos(new Size(0, -1));
        }

        private void btnMoveBaixo_Click(object sender, EventArgs e)
        {
            MoveTelaPontos(new Size(0, 1));
        }

        private void MoveTelaPontos(Size offset, int d = 10)
        {
            if (rbMovPonto.Checked && ptoSelecionado=="")
            {
                MessageBox.Show("Selecione um ponto para mover", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] pts = new string[pontos.Count];

            pontos.Keys.CopyTo(pts, 0);

            if (rbMovPonto.Checked)
                d = d/10;

            d *= (tbPassoMov.Value + 1);

            offset.Height *= d;
            offset.Width *= d;

            for (int i = 0; i < pts.Length; i++)
            {
                if (rbMovTela.Checked || (ptoSelecionado == pts[i] && rbMovPonto.Checked))
                {
                    pontos[pts[i]] = Point.Add(pontos[pts[i]], offset);
                    if (ptoSelecionado == pts[i])
                    {
                        AtualizaPtosTxt();
                    }
                }
            }

            if (lblTensoes != null&&rbMovTela.Checked)
            {
                for (int i = 0; i < lblTensoes.Length; i++)
                {
                    lblTensoes[i].Location = Point.Add(lblTensoes[i].Location,offset);
                }
            }
        }

        
        private void rbRemov_CheckedChanged(object sender, EventArgs e)
        {
            panelPto.Visible = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblPasso.Text = "Passo:  x" + (tbPassoMov.Value+1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pontos = new Dictionary<string, Point>();
            ptoSelecionado = "";
            apoioFixo = "";
            apoioMovel = "";
            forcas = new List<Forca>();
            barras = new List<string[]>();
        }

        private void AtualizaPtosTxt()
        {
            txtPtoX.Text = pontos[ptoSelecionado].X.ToString();
            txtPtoY.Text = (pbTela.Height - pontos[ptoSelecionado].Y).ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            g.ScaleTransform(1f/zoom, 1f/zoom);
            //double oldZoom = zoom;
            zoom = (vScrollBar1.Value+1) / 50f;
            g.ScaleTransform(zoom, zoom);

            //double alteraZoom = zoom / oldZoom;

            //string[] pts = new string[pontos.Count];

            //pontos.Keys.CopyTo(pts, 0);

            //for (int i = 0; i < pts.Length; i++)
            //{
            //    pontos[pts[i]] = Point.Add(pontos[pts[i]], new Size(Convert.ToInt32(pbTela.Width/2/alteraZoom), Convert.ToInt32(pbTela.Height / 2 / alteraZoom)));
            //    if (ptoSelecionado == pts[i])
            //    {
            //        AtualizaPtosTxt();
            //    }
            //}

            if (lblTensoes != null)
            {
                for (int i = 0; i < lblTensoes.Length; i++)
                {
                    lblTensoes[i].Font = new Font(lblTensoes[i].Font.FontFamily, 11*zoom);
                    Point local = Point.Subtract(PontoMeio(pontos[barras[i * 2][0]], pontos[barras[i * 2][1]]), new Size(lblTensoes[i].Width/2, lblTensoes[i].Height / 2));
                    lblTensoes[i].Location = new Point(Convert.ToInt32(local.X * zoom), Convert.ToInt32(local.Y * zoom));
                }
            }
        }
    }
}
