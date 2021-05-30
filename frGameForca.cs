using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cobra
{
    public partial class frGameForca : Form
    {
        string[] Palavras = { "eduardo", "viotti", "exame", "windows", "termomecanica", "computador", "bimestre", "pneumoultramicroscopicosilicovulcanoconiotico" };
        string PalavraGerada;
        string palavraEscondida;
        int Tentativas = 0;
        SoundPlayer musicaFundo = new SoundPlayer(Properties.Resources.fundoSonoro);

        public frGameForca()
        {
            InitializeComponent();
            lbl_foram.Text = "";
            lbl_palavra.Text = "";
            if (DadosUser.Som)
                musicaFundo.PlayLooping();
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            Random gerador = new Random();
            int Valor = gerador.Next(0, 8);

            PalavraGerada = Palavras[Valor];
            palavraEscondida = "";
            for (int i = 0; i < PalavraGerada.Length; i++)
            {
                palavraEscondida = palavraEscondida + "#";
            }
            lbl_palavra.Text = palavraEscondida;
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (txt_letra.Text == "")
            {
                MessageBox.Show("Digite uma letra");
            }
            else
            {
                txt_letra.MaxLength = 1;

                char Letra = Convert.ToChar(txt_letra.Text.ToLower());

                string Texto = "";
                bool existe = false;

                for (int i = 0; i < PalavraGerada.Length; i++)
                {
                    if (PalavraGerada[i] == Letra)
                    {
                        Texto += txt_letra.Text;
                        existe = true;
                    }
                    else
                    {
                        Texto += palavraEscondida[i];
                    }
                }

                if (Texto == PalavraGerada)
                {
                    MessageBox.Show("OAL!! Você acertou!", "PARABENS!!");
                    musicaFundo.Stop();
                    this.Close();
                    return;
                }

                if (existe == false)
                {
                    Tentativas += 1;
                }

                switch (Tentativas)
                {
                    case 1:
                        pic_vida.Visible = false;
                        break;
                    case 2:
                        pic_vida2.Visible = false;
                        break;
                    case 3:
                        pic_vida3.Visible = false;
                        MessageBox.Show("Você perdeu!");
                        musicaFundo.Stop();
                        this.Close();
                        break;
                    default:
                        break;
                }

                lbl_foram.Text += $" {txt_letra.Text}";
                txt_letra.Text = "";
                palavraEscondida = Texto;
                lbl_palavra.Text = palavraEscondida;
                existe = false;
            }

            
        }

        private void frGameForca_FormClosing(object sender, FormClosingEventArgs e)
        {
            musicaFundo.Stop();
        }
    }
}
