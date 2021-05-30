
namespace Cobra
{
    partial class frGameAdivinhaTecla
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picCoracao3 = new System.Windows.Forms.PictureBox();
            this.picCoracao2 = new System.Windows.Forms.PictureBox();
            this.picCoracao1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCoracao3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoracao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoracao1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(129, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 61);
            this.button1.TabIndex = 14;
            this.button1.TabStop = false;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aperte uma tecla de A a Z";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRes
            // 
            this.lblRes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(129, 230);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(315, 61);
            this.lblRes.TabIndex = 13;
            this.lblRes.Text = "Resposta";
            this.lblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(563, 53);
            this.label2.TabIndex = 12;
            this.label2.Text = "Adivinhe a tecla que o computador esta pensando, você terá 3 tentativas\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCoracao3
            // 
            this.picCoracao3.Image = global::Cobra.Properties.Resources.coracao;
            this.picCoracao3.Location = new System.Drawing.Point(336, 181);
            this.picCoracao3.Name = "picCoracao3";
            this.picCoracao3.Size = new System.Drawing.Size(29, 31);
            this.picCoracao3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoracao3.TabIndex = 17;
            this.picCoracao3.TabStop = false;
            // 
            // picCoracao2
            // 
            this.picCoracao2.Image = global::Cobra.Properties.Resources.coracao;
            this.picCoracao2.Location = new System.Drawing.Point(275, 181);
            this.picCoracao2.Name = "picCoracao2";
            this.picCoracao2.Size = new System.Drawing.Size(29, 31);
            this.picCoracao2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoracao2.TabIndex = 16;
            this.picCoracao2.TabStop = false;
            // 
            // picCoracao1
            // 
            this.picCoracao1.Image = global::Cobra.Properties.Resources.coracao;
            this.picCoracao1.Location = new System.Drawing.Point(214, 181);
            this.picCoracao1.Name = "picCoracao1";
            this.picCoracao1.Size = new System.Drawing.Size(29, 31);
            this.picCoracao1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoracao1.TabIndex = 15;
            this.picCoracao1.TabStop = false;
            // 
            // frGameAdivinhaTecla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.picCoracao3);
            this.Controls.Add(this.picCoracao2);
            this.Controls.Add(this.picCoracao1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "frGameAdivinhaTecla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frGameAdivinhaTecla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frGameAdivinhaTecla_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frGameAdivinhaTecla_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picCoracao3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoracao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoracao1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCoracao3;
        private System.Windows.Forms.PictureBox picCoracao2;
        private System.Windows.Forms.PictureBox picCoracao1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label label2;
    }
}