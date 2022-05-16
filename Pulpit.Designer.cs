namespace Algorytm_Floyda_Warshalla
{
    partial class Pulpit
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.mpBTNLab = new System.Windows.Forms.Button();
            this.mpBTNProjekt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mpBTNLab
            // 
            this.mpBTNLab.Location = new System.Drawing.Point(12, 12);
            this.mpBTNLab.Name = "mpBTNLab";
            this.mpBTNLab.Size = new System.Drawing.Size(75, 23);
            this.mpBTNLab.TabIndex = 0;
            this.mpBTNLab.Text = "Laboratoria";
            this.mpBTNLab.UseVisualStyleBackColor = true;
            this.mpBTNLab.Click += new System.EventHandler(this.mpBTNLab_Click);
            // 
            // mpBTNProjekt
            // 
            this.mpBTNProjekt.Location = new System.Drawing.Point(93, 12);
            this.mpBTNProjekt.Name = "mpBTNProjekt";
            this.mpBTNProjekt.Size = new System.Drawing.Size(110, 23);
            this.mpBTNProjekt.TabIndex = 1;
            this.mpBTNProjekt.Text = "ProjektNr3_53262";
            this.mpBTNProjekt.UseVisualStyleBackColor = true;
            this.mpBTNProjekt.Click += new System.EventHandler(this.mpBTNProjekt_Click);
            // 
            // Pulpit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 43);
            this.Controls.Add(this.mpBTNProjekt);
            this.Controls.Add(this.mpBTNLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Pulpit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pulpit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pulpit_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mpBTNLab;
        private System.Windows.Forms.Button mpBTNProjekt;
    }
}

