using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cobra
{
    public partial class frInicial : Form
    {
        public frInicial()
        {
            InitializeComponent();
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtNome.Text.Length > 0)
            {
                this.Visible = false; // esconde a tela atual

                DadosUser.Name = txtNome.Text;

                //criando a tela 1
                frPrincipal jogoPrincipal = new frPrincipal();
                //exibir a tela 1
                jogoPrincipal.ShowDialog();

                txtNome.Text = "";
                this.Visible = true;
            }
            else
            {
                errorProvider1.SetError(txtNome, "Insira um nome");
                txtNome.Focus();
            }
        }
    }
}
