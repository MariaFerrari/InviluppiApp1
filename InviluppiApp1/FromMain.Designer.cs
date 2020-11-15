namespace InviluppiApp1
{
    partial class FromMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.inviluppoControl1 = new InviluppiApp1.InviluppoControl();
            this.SuspendLayout();
            // 
            // inviluppoControl1
            // 
            this.inviluppoControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inviluppoControl1.BackColor = System.Drawing.Color.DarkGray;
            this.inviluppoControl1.Location = new System.Drawing.Point(163, 45);
            this.inviluppoControl1.N = 10;
            this.inviluppoControl1.Name = "inviluppoControl1";
            this.inviluppoControl1.Size = new System.Drawing.Size(445, 445);
            this.inviluppoControl1.TabIndex = 0;
            this.inviluppoControl1.Text = "inviluppoControl1";
            // 
            // FromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.inviluppoControl1);
            this.Name = "FromMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private InviluppoControl inviluppoControl1;
    }
}

