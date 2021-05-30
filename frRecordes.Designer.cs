
namespace Cobra
{
    partial class frRecordes
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
            this.llbLista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llbLista
            // 
            this.llbLista.AutoSize = true;
            this.llbLista.BackColor = System.Drawing.Color.Transparent;
            this.llbLista.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLista.ForeColor = System.Drawing.SystemColors.ControlText;
            this.llbLista.Location = new System.Drawing.Point(85, 152);
            this.llbLista.Name = "llbLista";
            this.llbLista.Size = new System.Drawing.Size(0, 23);
            this.llbLista.TabIndex = 0;
            // 
            // frRecordes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Cobra.Properties.Resources.recordes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.llbLista);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frRecordes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recordes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llbLista;
    }
}