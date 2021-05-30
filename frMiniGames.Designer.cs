
namespace Cobra
{
    partial class frMiniGames
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGameNum = new System.Windows.Forms.Button();
            this.btnGameForca = new System.Windows.Forms.Button();
            this.btnGameTecla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha um entre os 3 Mini Games abaixo";
            // 
            // btnGameNum
            // 
            this.btnGameNum.BackColor = System.Drawing.Color.Transparent;
            this.btnGameNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGameNum.FlatAppearance.BorderSize = 0;
            this.btnGameNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameNum.Image = global::Cobra.Properties.Resources.GameNum;
            this.btnGameNum.Location = new System.Drawing.Point(34, 132);
            this.btnGameNum.Name = "btnGameNum";
            this.btnGameNum.Size = new System.Drawing.Size(359, 238);
            this.btnGameNum.TabIndex = 10;
            this.btnGameNum.TabStop = false;
            this.btnGameNum.UseVisualStyleBackColor = false;
            this.btnGameNum.Click += new System.EventHandler(this.btnGameNum_Click);
            // 
            // btnGameForca
            // 
            this.btnGameForca.BackColor = System.Drawing.Color.Transparent;
            this.btnGameForca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGameForca.FlatAppearance.BorderSize = 0;
            this.btnGameForca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameForca.Image = global::Cobra.Properties.Resources.GameForca;
            this.btnGameForca.Location = new System.Drawing.Point(399, 132);
            this.btnGameForca.Name = "btnGameForca";
            this.btnGameForca.Size = new System.Drawing.Size(359, 238);
            this.btnGameForca.TabIndex = 11;
            this.btnGameForca.TabStop = false;
            this.btnGameForca.UseVisualStyleBackColor = false;
            this.btnGameForca.Click += new System.EventHandler(this.btnGameForca_Click);
            // 
            // btnGameTecla
            // 
            this.btnGameTecla.BackColor = System.Drawing.Color.Transparent;
            this.btnGameTecla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGameTecla.FlatAppearance.BorderSize = 0;
            this.btnGameTecla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameTecla.Image = global::Cobra.Properties.Resources.GameTecla;
            this.btnGameTecla.Location = new System.Drawing.Point(220, 390);
            this.btnGameTecla.Name = "btnGameTecla";
            this.btnGameTecla.Size = new System.Drawing.Size(359, 238);
            this.btnGameTecla.TabIndex = 12;
            this.btnGameTecla.TabStop = false;
            this.btnGameTecla.UseVisualStyleBackColor = false;
            this.btnGameTecla.Click += new System.EventHandler(this.btnGameTecla_Click);
            // 
            // frMiniGames
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(803, 687);
            this.Controls.Add(this.btnGameTecla);
            this.Controls.Add(this.btnGameForca);
            this.Controls.Add(this.btnGameNum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frMiniGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniGames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGameNum;
        private System.Windows.Forms.Button btnGameForca;
        private System.Windows.Forms.Button btnGameTecla;
    }
}