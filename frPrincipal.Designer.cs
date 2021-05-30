namespace Cobra
{
    partial class frPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPrincipal));
            this.lblScore = new System.Windows.Forms.Label();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnRecordes = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPlusGames = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(51, 49);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(106, 29);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // picFood
            // 
            this.picFood.BackColor = System.Drawing.Color.Transparent;
            this.picFood.BackgroundImage = global::Cobra.Properties.Resources.Maça;
            this.picFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFood.Location = new System.Drawing.Point(337, 122);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(21, 21);
            this.picFood.TabIndex = 2;
            this.picFood.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.picFood);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 500);
            this.panel1.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(52, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Catarina";
            // 
            // btnRecordes
            // 
            this.btnRecordes.BackColor = System.Drawing.Color.Transparent;
            this.btnRecordes.FlatAppearance.BorderSize = 0;
            this.btnRecordes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordes.Image = global::Cobra.Properties.Resources.Button_Recordes;
            this.btnRecordes.Location = new System.Drawing.Point(142, 16);
            this.btnRecordes.Name = "btnRecordes";
            this.btnRecordes.Size = new System.Drawing.Size(50, 50);
            this.btnRecordes.TabIndex = 5;
            this.btnRecordes.TabStop = false;
            this.btnRecordes.UseVisualStyleBackColor = false;
            this.btnRecordes.Click += new System.EventHandler(this.btnRecordes_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.Transparent;
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Image = global::Cobra.Properties.Resources.Button_Sobre;
            this.btnSobre.Location = new System.Drawing.Point(491, 16);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(113, 50);
            this.btnSobre.TabIndex = 6;
            this.btnSobre.TabStop = false;
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(286, 16);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(50, 50);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.TabStop = false;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Image = global::Cobra.Properties.Resources.Button_ComoJogar;
            this.btnAjuda.Location = new System.Drawing.Point(214, 16);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(50, 50);
            this.btnAjuda.TabIndex = 8;
            this.btnAjuda.TabStop = false;
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnPlusGames);
            this.panel2.Controls.Add(this.btnAjuda);
            this.panel2.Controls.Add(this.btnRecordes);
            this.panel2.Controls.Add(this.btnConfig);
            this.panel2.Controls.Add(this.btnSobre);
            this.panel2.Location = new System.Drawing.Point(350, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 81);
            this.panel2.TabIndex = 9;
            this.panel2.TabStop = true;
            // 
            // btnPlusGames
            // 
            this.btnPlusGames.BackColor = System.Drawing.Color.Transparent;
            this.btnPlusGames.FlatAppearance.BorderSize = 0;
            this.btnPlusGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusGames.Image = global::Cobra.Properties.Resources.Button_plusGames;
            this.btnPlusGames.Location = new System.Drawing.Point(358, 16);
            this.btnPlusGames.Name = "btnPlusGames";
            this.btnPlusGames.Size = new System.Drawing.Size(111, 50);
            this.btnPlusGames.TabIndex = 9;
            this.btnPlusGames.TabStop = false;
            this.btnPlusGames.UseVisualStyleBackColor = false;
            this.btnPlusGames.Click += new System.EventHandler(this.btnPlusGames_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Cobra.Properties.Resources.Fundo1;
            this.ClientSize = new System.Drawing.Size(997, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game cobrinha";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picFood;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnRecordes;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnPlusGames;
    }
}

