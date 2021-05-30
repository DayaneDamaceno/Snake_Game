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
    public partial class frGameAdivinhaTecla : Form
    {
        public int tentativas = 0;
        Random geraAleatorio = new Random();
        int decAleatorio;
        char letra;
        char letraUser;

        SoundPlayer musicaFundo = new SoundPlayer(Properties.Resources.fundoSonoro);

        public frGameAdivinhaTecla()
        {
            InitializeComponent();
            lblRes.Text = "";
            if (DadosUser.Som)
                musicaFundo.PlayLooping();

            decAleatorio = geraAleatorio.Next(65, 91);
            letra = Convert.ToChar(decAleatorio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarAcerto())
            {
                MessageBox.Show("OAL!! Você acertou!", "PARABENS!!");
                musicaFundo.Stop();
                this.Close();
                return;
            }

            tentativas++;

            switch (tentativas)
            {
                case 1:
                    picCoracao1.Visible = false;
                    break;
                case 2:
                    picCoracao2.Visible = false;
                    break;
                case 3:
                    picCoracao3.Visible = false;
                    MessageBox.Show("Poxa suas vidas acabaram, até a proxima", "Perdeu!");
                    musicaFundo.Stop();
                    this.Close();
                    break;
                default:
                    break;
            }
        }
        private bool VerificarAcerto()
        {
            if (letra == letraUser)
            {
                lblRes.Text = $"{letra} - {letraUser} - Wow brabissimo você acertou";
                lblRes.ForeColor = Color.DarkGreen;
                return true;
            }
            else
            {
                lblRes.Text = "Puts! errou";
                lblRes.ForeColor = Color.Red;
                return false;
            }
        }

        private void frGameAdivinhaTecla_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                letraUser = Convert.ToChar(e.KeyData);
                lblRes.Text = $"Você digitou {letraUser}";
                lblRes.ForeColor = Color.Black;
            }
            catch 
            {
                lblRes.Text = "Insira apenas letras A a Z"; 
                lblRes.ForeColor = Color.Red;
            }
        }

        private void frGameAdivinhaTecla_FormClosing(object sender, FormClosingEventArgs e)
        {
            musicaFundo.Stop();
        }
    }
}
