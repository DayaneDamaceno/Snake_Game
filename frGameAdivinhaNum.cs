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
    public partial class frGameAdivinhaNum : Form
    {
        public int tentativas = 0;
        Random geraAleatorio = new Random();
        int numAleatorio;

        SoundPlayer musicaFundo = new SoundPlayer(Properties.Resources.fundoSonoro);

        public frGameAdivinhaNum()
        {
            InitializeComponent();
            lblRes.Text = "";
            if(DadosUser.Som)
                musicaFundo.PlayLooping();
            numAleatorio = geraAleatorio.Next(1, 11);
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
            int numero = Convert.ToInt32(txtNum.Value);

            if (numAleatorio == numero)
            {
                lblRes.Text = $"{numAleatorio} - Wow brabissimo você acertou";
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

        private void frGameAdivinhaNum_FormClosing(object sender, FormClosingEventArgs e)
        {
            musicaFundo.Stop();
        
        }
    }
}
