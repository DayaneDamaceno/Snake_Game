
namespace Cobra
{
    partial class frGameAdivinhaNum
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
            this.txtNum = new System.Windows.Forms.NumericUpDown();
            this.lblRes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picCoracao3 = new System.Windows.Forms.PictureBox();
            this.picCoracao2 = new System.Windows.Forms.PictureBox();
            this.picCoracao1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoracao3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoracao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoracao1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.Location = new System.Drawing.Point(177, 145);
            this.txtNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(204, 30);
            this.txtNum.TabIndex = 1;
            this.txtNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRes
            // 
            this.lblRes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(122, 216);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(315, 61);
            this.lblRes.TabIndex = 4;
            this.lblRes.Text = "Resposta";
            this.lblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picCoracao3);
            this.panel1.Controls.Add(this.picCoracao2);
            this.panel1.Controls.Add(this.picCoracao1);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblRes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 375);
            this.panel1.TabIndex = 6;
            // 
            // picCoracao3
            // 
            this.picCoracao3.Image = global::Cobra.Properties.Resources.coracao;
            this.picCoracao3.Location = new System.Drawing.Point(329, 193);
            this.picCoracao3.Name = "picCoracao3";
            this.picCoracao3.Size = new System.Drawing.Size(29, 31);
            this.picCoracao3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoracao3.TabIndex = 9;
            this.picCoracao3.TabStop = false;
            // 
            // picCoracao2
            // 
            this.picCoracao2.Image = global::Cobra.Properties.Resources.coracao;
            this.picCoracao2.Location = new System.Drawing.Point(268, 193);
            this.picCoracao2.Name = "picCoracao2";
            this.picCoracao2.Size = new System.Drawing.Size(29, 31);
            this.picCoracao2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoracao2.TabIndex = 8;
            this.picCoracao2.TabStop = false;
            // 
            // picCoracao1
            // 
            this.picCoracao1.Image = global::Cobra.Properties.Resources.coracao;
            this.picCoracao1.Location = new System.Drawing.Point(207, 193);
            this.picCoracao1.Name = "picCoracao1";
            this.picCoracao1.Size = new System.Drawing.Size(29, 31);
            this.picCoracao1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoracao1.TabIndex = 7;
            this.picCoracao1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira um número de 1 a 10";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(563, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adivinhe o número que o computador esta pensando, você terá 3 tentativas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frGameAdivinhaNum
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(566, 375);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frGameAdivinhaNum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Game - Adivinhar Número";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frGameAdivinhaNum_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCoracao3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoracao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoracao1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtNum;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picCoracao1;
        private System.Windows.Forms.PictureBox picCoracao3;
        private System.Windows.Forms.PictureBox picCoracao2;
    }
}