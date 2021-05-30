
namespace Cobra
{
    partial class frConfig
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
            this.btnWuo = new System.Windows.Forms.Button();
            this.btnMarcio = new System.Windows.Forms.Button();
            this.picSom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWuo
            // 
            this.btnWuo.BackColor = System.Drawing.Color.Transparent;
            this.btnWuo.FlatAppearance.BorderSize = 0;
            this.btnWuo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWuo.Image = global::Cobra.Properties.Resources.wuo;
            this.btnWuo.Location = new System.Drawing.Point(67, 176);
            this.btnWuo.Margin = new System.Windows.Forms.Padding(0);
            this.btnWuo.Name = "btnWuo";
            this.btnWuo.Size = new System.Drawing.Size(147, 117);
            this.btnWuo.TabIndex = 9;
            this.btnWuo.TabStop = false;
            this.btnWuo.UseVisualStyleBackColor = false;
            this.btnWuo.Click += new System.EventHandler(this.btnWuo_Click);
            // 
            // btnMarcio
            // 
            this.btnMarcio.BackColor = System.Drawing.Color.Transparent;
            this.btnMarcio.FlatAppearance.BorderSize = 0;
            this.btnMarcio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcio.Image = global::Cobra.Properties.Resources.marcio;
            this.btnMarcio.Location = new System.Drawing.Point(245, 176);
            this.btnMarcio.Margin = new System.Windows.Forms.Padding(0);
            this.btnMarcio.Name = "btnMarcio";
            this.btnMarcio.Size = new System.Drawing.Size(144, 117);
            this.btnMarcio.TabIndex = 10;
            this.btnMarcio.TabStop = false;
            this.btnMarcio.UseVisualStyleBackColor = false;
            this.btnMarcio.Click += new System.EventHandler(this.btnMarcio_Click);
            // 
            // picSom
            // 
            this.picSom.BackColor = System.Drawing.Color.Transparent;
            this.picSom.Image = global::Cobra.Properties.Resources.somAtivado;
            this.picSom.Location = new System.Drawing.Point(67, 379);
            this.picSom.Name = "picSom";
            this.picSom.Size = new System.Drawing.Size(68, 66);
            this.picSom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSom.TabIndex = 11;
            this.picSom.TabStop = false;
            this.picSom.Click += new System.EventHandler(this.picSom_Click);
            // 
            // frConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Cobra.Properties.Resources.config;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 496);
            this.Controls.Add(this.picSom);
            this.Controls.Add(this.btnMarcio);
            this.Controls.Add(this.btnWuo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            ((System.ComponentModel.ISupportInitialize)(this.picSom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWuo;
        private System.Windows.Forms.Button btnMarcio;
        private System.Windows.Forms.PictureBox picSom;
    }
}