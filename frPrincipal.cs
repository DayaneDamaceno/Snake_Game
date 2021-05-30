using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.IO;

namespace Cobra
{

    public partial class frPrincipal : Form
    {
        int cols = 50, rows = 25, score = 0, dx = 0, dy = 0, front = 0, back = 0;
        Piece[] cobra;
        List<int> available;
        bool[,] visit;
        string somaLetras;

        public int[] scores = new int[100];

        SoundPlayer mordidaSom = new SoundPlayer(Properties.Resources.mordida);

        Random geraAleatorio = new Random();
        
        public frPrincipal()
        {
            InitializeComponent();
            cobra = new Piece[1250];
            available = new List<int>();
            lblUsername.Text = DadosUser.Name;
            DadosUser.velocidade = 80;
            DadosUser.Som = true;
            //scores[0] = 0;
            PosicaoInicial();
            IniciarTimer();
        }

        public void IniciarTimer()
        {
            timer.Tick += move;
            timer.Start();
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            dx = 0;
            dy = 0;

            if (e.KeyCode == Keys.Right)
            {
                dx = 20;
                return;
            }
            else if (e.KeyCode == Keys.Left)
            {
                dx = -20;
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                dy = -20;
                return;
            }
            else if (e.KeyCode == Keys.Down)
            {
                dy = 20;
                return;
            }
            else
            {
                somaLetras += Convert.ToString(e.KeyData);
            }

            if (somaLetras.ToUpper().Contains("WUO"))
            {
                MessageBox.Show("Espertinho rsrs");
                score += 100;
                lblScore.Text = $"Score: {score}";
                somaLetras = "";
            }

        }

        private void move(object sender, EventArgs e)
        {
            
            int x = cobra[front].Location.X;
            int y = cobra[front].Location.Y;

            if (dx == 0 && dy == 0) return;

            if (GameOver(x + dx, y + dy))
            {
                timer.Stop();
                MessageBox.Show("Game Over");
                Reset();
                return;
            }

            if (ColisaoComAFruta(x + dx, y + dy))
            {
                if (DadosUser.Som)
                    mordidaSom.Play();
                
                score += 1;
                lblScore.Text = "Score: " + score.ToString();

                if (hits((y + dy) / 20, (x + dx) / 20)) return;

                Piece head = new Piece(x + dx, y + dy);

                front = (front - 1 + 1250) % 1250;
                cobra[front] = head;

                visit[head.Location.Y / 20, head.Location.X / 20] = true;

                panel1.Controls.Add(head);

                GerarFrutaAleatoria();
            }
            else
            {
                if (hits((y + dy) / 20, (x + dx) / 20)) return;

                visit[cobra[back].Location.Y / 20, cobra[back].Location.X / 20] = false;
                front = (front - 1 + 1250) % 1250;
                cobra[front] = cobra[back];
                cobra[front].Location = new Point(x + dx, y + dy);
                back = (back - 1 + 1250) % 1250;
                visit[(y + dy) / 20, (x + dx) / 20] = true;
            }
        }

        private void GerarFrutaAleatoria()
        {
            available.Clear();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (!visit[i, j]) available.Add(i * cols + j);

            Width = 1000;

            int idx = geraAleatorio.Next(available.Count) % available.Count;
            picFood.Left = (available[idx] * 20) % Width;
            picFood.Top = (available[idx] * 20) / Width * 20;
        }

        private void btnPlusGames_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
            frMiniGames miniJogos = new frMiniGames();
            miniJogos.ShowDialog();
            this.Visible = true;
            panel1.Focus();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            frComoJogar comoJogar = new frComoJogar();
            comoJogar.ShowDialog();
            panel1.Focus();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frConfig configuracao = new frConfig();
            configuracao.ShowDialog();
            panel1.Focus();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = DadosUser.velocidade;
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frSobre sobre = new frSobre();
            sobre.ShowDialog();
            panel1.Focus();
            timer.Start();
        }

        private void btnRecordes_Click(object sender, EventArgs e)
        {
            int maior = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > maior)
                {
                    maior = scores[i];
                }
            }

            File.AppendAllText("dados.txt", $"{DadosUser.Name}|{maior}" + Environment.NewLine);
            
            this.Visible = false;
            frRecordes recordes = new frRecordes();
            recordes.ShowDialog();
            this.Visible = true;
            panel1.Focus();
        }

        private bool hits(int x, int y)
        {
            if (visit[x, y])
            {
                timer.Stop();
                MessageBox.Show("Game Over");
                Reset();
                return true;
            }
            return false;
        }

        private bool ColisaoComAFruta(int x, int y)
        {
            return x == picFood.Location.X && y == picFood.Location.Y;
        }

        private bool GameOver(int x, int y)
        {
            return x < 0 || y < 0 || x > 980 || y > 480; // AQUIIII 947; 399
        }

        private void PosicaoInicial()
        {
            Piece head = new Piece(20, 20);
            picFood.Location = new Point(100, 100);
            panel1.Controls.Add(head);

            visit = new bool[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    visit[i, j] = false;
                    available.Add(i * cols + j);    
                }
                
                visit[head.Location.Y / 20, head.Location.X / 20] = true;
                available.Remove(head.Location.Y / 20 * cols + head.Location.X / 20);
                cobra[front] = head;
            }
        }

        private void Reset()
        {
            for (int i = 0; i < scores.Length; i++)
            {
                if(scores[i] == 0)
                {
                    scores[i] = score;
                    break;
                }
            }
            score = 0;
            dx = 0;
            dy = 0;
            front = 0;
            back = 0;
            LimparArrays();

            lblScore.Text = "Score: 0";
            cobra = new Piece[1250];
            available = new List<int>();
            PosicaoInicial();
            timer.Start();

        }

        private void LimparArrays()
        {
            for (int i = 0; i < cobra.Length; i++)
            {
                if (cobra[i] != null)
                    panel1.Controls.Remove(cobra[i]);

                cobra[i] = null;
            }

            for (int i = 0; i < visit.GetLength(0); i++)
            {
                for (int j = 0; j < visit.GetLength(1); j++)
                    visit[i, j] = false;
            }
        }
    }
}
