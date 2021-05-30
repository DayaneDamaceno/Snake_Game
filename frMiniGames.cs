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
    public partial class frMiniGames : Form
    {
        public frMiniGames()
        {
            InitializeComponent();
        }

        private void btnGameNum_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frGameAdivinhaNum gameNum = new frGameAdivinhaNum();
            gameNum.ShowDialog();
            this.Visible = true;
        }

        private void btnGameForca_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frGameForca gameForca = new frGameForca();
            gameForca.ShowDialog();
            this.Visible = true;
        }

        private void btnGameTecla_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frGameAdivinhaTecla gameTecla = new frGameAdivinhaTecla();
            gameTecla.ShowDialog();
            this.Visible = true;
        }
    }
}
