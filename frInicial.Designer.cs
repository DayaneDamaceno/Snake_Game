
namespace Cobra
{
    partial class frInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frInicial));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pic_maca = new System.Windows.Forms.PictureBox();
            this.pic_cobrinha = new System.Windows.Forms.PictureBox();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbl_inserir = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_maca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cobrinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_titulo.Location = new System.Drawing.Point(311, 126);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(164, 39);
            this.lbl_titulo.TabIndex = 11;
            this.lbl_titulo.Text = "Cobrinha";
            // 
            // pic_maca
            // 
            this.pic_maca.BackColor = System.Drawing.Color.Transparent;
            this.pic_maca.Image = ((System.Drawing.Image)(resources.GetObject("pic_maca.Image")));
            this.pic_maca.Location = new System.Drawing.Point(505, 114);
            this.pic_maca.Margin = new System.Windows.Forms.Padding(4);
            this.pic_maca.Name = "pic_maca";
            this.pic_maca.Size = new System.Drawing.Size(64, 63);
            this.pic_maca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_maca.TabIndex = 10;
            this.pic_maca.TabStop = false;
            // 
            // pic_cobrinha
            // 
            this.pic_cobrinha.BackColor = System.Drawing.Color.Transparent;
            this.pic_cobrinha.Image = ((System.Drawing.Image)(resources.GetObject("pic_cobrinha.Image")));
            this.pic_cobrinha.Location = new System.Drawing.Point(210, 114);
            this.pic_cobrinha.Margin = new System.Windows.Forms.Padding(4);
            this.pic_cobrinha.Name = "pic_cobrinha";
            this.pic_cobrinha.Size = new System.Drawing.Size(77, 63);
            this.pic_cobrinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cobrinha.TabIndex = 9;
            this.pic_cobrinha.TabStop = false;
            // 
            // btn_jogar
            // 
            this.btn_jogar.BackColor = System.Drawing.Color.Yellow;
            this.btn_jogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_jogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jogar.Location = new System.Drawing.Point(285, 337);
            this.btn_jogar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(221, 66);
            this.btn_jogar.TabIndex = 8;
            this.btn_jogar.Text = "Iniciar Jogo";
            this.btn_jogar.UseVisualStyleBackColor = false;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(285, 272);
            this.txtNome.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 23);
            this.txtNome.TabIndex = 7;
            // 
            // lbl_inserir
            // 
            this.lbl_inserir.AutoSize = true;
            this.lbl_inserir.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inserir.Location = new System.Drawing.Point(285, 235);
            this.lbl_inserir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inserir.Name = "lbl_inserir";
            this.lbl_inserir.Size = new System.Drawing.Size(178, 25);
            this.lbl_inserir.TabIndex = 6;
            this.lbl_inserir.Text = "Insira seu nome: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::Cobra.Properties.Resources.corVerde;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.pic_maca);
            this.Controls.Add(this.pic_cobrinha);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbl_inserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - Jogo cobrinha";
            ((System.ComponentModel.ISupportInitialize)(this.pic_maca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cobrinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pic_maca;
        private System.Windows.Forms.PictureBox pic_cobrinha;
        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbl_inserir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}