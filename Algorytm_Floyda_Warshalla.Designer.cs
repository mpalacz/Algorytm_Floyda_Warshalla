namespace Algorytm_Floyda_Warshalla
{
    partial class Algorytm_Floyda_Warshalla
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
            this.mpErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mpTXTLiczbaWierzcholkowGrafu = new System.Windows.Forms.TextBox();
            this.mpBTNMacierzWag = new System.Windows.Forms.Button();
            this.mpBTNPrzykladowaMacierzWag = new System.Windows.Forms.Button();
            this.mpBTNAkceptacjaMacierzyWag = new System.Windows.Forms.Button();
            this.mpBTNWyznaczSciezkiWGrafie = new System.Windows.Forms.Button();
            this.mpBTNWypiszTrasy = new System.Windows.Forms.Button();
            this.mpLBLMacierzWag = new System.Windows.Forms.Label();
            this.mpLBLMacierzOdleglosci = new System.Windows.Forms.Label();
            this.mpLBLMacierzWezlowPosrednich = new System.Windows.Forms.Label();
            this.mpLBLTrasa = new System.Windows.Forms.Label();
            this.mpDGVMacierzWag = new System.Windows.Forms.DataGridView();
            this.mpDGVMacierzOdleglosci = new System.Windows.Forms.DataGridView();
            this.mpDGVMacierzWezlowPosrednich = new System.Windows.Forms.DataGridView();
            this.mpRTBTrasa = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mpErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpDGVMacierzWag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpDGVMacierzOdleglosci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpDGVMacierzWezlowPosrednich)).BeginInit();
            this.SuspendLayout();
            // 
            // mpErrorProvider1
            // 
            this.mpErrorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algorytm Floyda-Warshalla umożliwia wyznaczanie najkrótszych ścieżek\r\n(tras) pomi" +
    "ędzy wszystkimi wierzchołkami grafu skierowanego";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba wierzchołków grafu:";
            // 
            // mpTXTLiczbaWierzcholkowGrafu
            // 
            this.mpTXTLiczbaWierzcholkowGrafu.Location = new System.Drawing.Point(17, 36);
            this.mpTXTLiczbaWierzcholkowGrafu.Name = "mpTXTLiczbaWierzcholkowGrafu";
            this.mpTXTLiczbaWierzcholkowGrafu.Size = new System.Drawing.Size(179, 26);
            this.mpTXTLiczbaWierzcholkowGrafu.TabIndex = 2;
            this.mpTXTLiczbaWierzcholkowGrafu.TextChanged += new System.EventHandler(this.mpTXTLiczbaWierzcholkowGrafu_TextChanged);
            // 
            // mpBTNMacierzWag
            // 
            this.mpBTNMacierzWag.Enabled = false;
            this.mpBTNMacierzWag.Location = new System.Drawing.Point(17, 68);
            this.mpBTNMacierzWag.Name = "mpBTNMacierzWag";
            this.mpBTNMacierzWag.Size = new System.Drawing.Size(179, 53);
            this.mpBTNMacierzWag.TabIndex = 3;
            this.mpBTNMacierzWag.Text = "Utwórz i pokaż macierz wag (sasiedztwa)";
            this.mpBTNMacierzWag.UseVisualStyleBackColor = true;
            this.mpBTNMacierzWag.Click += new System.EventHandler(this.mpBTNMacierzWag_Click);
            // 
            // mpBTNPrzykladowaMacierzWag
            // 
            this.mpBTNPrzykladowaMacierzWag.Enabled = false;
            this.mpBTNPrzykladowaMacierzWag.Location = new System.Drawing.Point(17, 127);
            this.mpBTNPrzykladowaMacierzWag.Name = "mpBTNPrzykladowaMacierzWag";
            this.mpBTNPrzykladowaMacierzWag.Size = new System.Drawing.Size(179, 53);
            this.mpBTNPrzykladowaMacierzWag.TabIndex = 4;
            this.mpBTNPrzykladowaMacierzWag.Text = "Przykładowa macierz wag";
            this.mpBTNPrzykladowaMacierzWag.UseVisualStyleBackColor = true;
            this.mpBTNPrzykladowaMacierzWag.Click += new System.EventHandler(this.mpBTNPrzykladowaMacierzWag_Click);
            // 
            // mpBTNAkceptacjaMacierzyWag
            // 
            this.mpBTNAkceptacjaMacierzyWag.Enabled = false;
            this.mpBTNAkceptacjaMacierzyWag.Location = new System.Drawing.Point(17, 186);
            this.mpBTNAkceptacjaMacierzyWag.Name = "mpBTNAkceptacjaMacierzyWag";
            this.mpBTNAkceptacjaMacierzyWag.Size = new System.Drawing.Size(179, 49);
            this.mpBTNAkceptacjaMacierzyWag.TabIndex = 5;
            this.mpBTNAkceptacjaMacierzyWag.Text = "Zaakceptuje wprowadzone dane macierzy wag";
            this.mpBTNAkceptacjaMacierzyWag.UseVisualStyleBackColor = true;
            this.mpBTNAkceptacjaMacierzyWag.Click += new System.EventHandler(this.mpBTNAkceptacjaMacierzy_Click);
            // 
            // mpBTNWyznaczSciezkiWGrafie
            // 
            this.mpBTNWyznaczSciezkiWGrafie.Enabled = false;
            this.mpBTNWyznaczSciezkiWGrafie.Location = new System.Drawing.Point(17, 241);
            this.mpBTNWyznaczSciezkiWGrafie.Name = "mpBTNWyznaczSciezkiWGrafie";
            this.mpBTNWyznaczSciezkiWGrafie.Size = new System.Drawing.Size(179, 69);
            this.mpBTNWyznaczSciezkiWGrafie.TabIndex = 6;
            this.mpBTNWyznaczSciezkiWGrafie.Text = "Wyznacz najkrótsze ścieżki w grafie według algorytmu Floyda Warshalla";
            this.mpBTNWyznaczSciezkiWGrafie.UseVisualStyleBackColor = true;
            this.mpBTNWyznaczSciezkiWGrafie.Click += new System.EventHandler(this.mpBTNWyznaczSciezkiWGrafie_Click);
            // 
            // mpBTNWypiszTrasy
            // 
            this.mpBTNWypiszTrasy.Enabled = false;
            this.mpBTNWypiszTrasy.Location = new System.Drawing.Point(17, 316);
            this.mpBTNWypiszTrasy.Name = "mpBTNWypiszTrasy";
            this.mpBTNWypiszTrasy.Size = new System.Drawing.Size(179, 51);
            this.mpBTNWypiszTrasy.TabIndex = 7;
            this.mpBTNWypiszTrasy.Text = "Wypisz najkrótsze trasy między węzłami";
            this.mpBTNWypiszTrasy.UseVisualStyleBackColor = true;
            this.mpBTNWypiszTrasy.Click += new System.EventHandler(this.mpBTNWypiszTrasy_Click);
            // 
            // mpLBLMacierzWag
            // 
            this.mpLBLMacierzWag.AutoSize = true;
            this.mpLBLMacierzWag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mpLBLMacierzWag.Location = new System.Drawing.Point(202, 68);
            this.mpLBLMacierzWag.Name = "mpLBLMacierzWag";
            this.mpLBLMacierzWag.Size = new System.Drawing.Size(179, 19);
            this.mpLBLMacierzWag.TabIndex = 8;
            this.mpLBLMacierzWag.Text = "Macierz wag (sąsiedztwa):";
            this.mpLBLMacierzWag.Visible = false;
            // 
            // mpLBLMacierzOdleglosci
            // 
            this.mpLBLMacierzOdleglosci.AutoSize = true;
            this.mpLBLMacierzOdleglosci.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mpLBLMacierzOdleglosci.Location = new System.Drawing.Point(202, 243);
            this.mpLBLMacierzOdleglosci.Name = "mpLBLMacierzOdleglosci";
            this.mpLBLMacierzOdleglosci.Size = new System.Drawing.Size(276, 19);
            this.mpLBLMacierzOdleglosci.TabIndex = 9;
            this.mpLBLMacierzOdleglosci.Text = "Macierz odległości między węzłami grafu:";
            this.mpLBLMacierzOdleglosci.Visible = false;
            // 
            // mpLBLMacierzWezlowPosrednich
            // 
            this.mpLBLMacierzWezlowPosrednich.AutoSize = true;
            this.mpLBLMacierzWezlowPosrednich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mpLBLMacierzWezlowPosrednich.Location = new System.Drawing.Point(202, 418);
            this.mpLBLMacierzWezlowPosrednich.Name = "mpLBLMacierzWezlowPosrednich";
            this.mpLBLMacierzWezlowPosrednich.Size = new System.Drawing.Size(189, 19);
            this.mpLBLMacierzWezlowPosrednich.TabIndex = 10;
            this.mpLBLMacierzWezlowPosrednich.Text = "Macierz węzłów pośrednich:";
            this.mpLBLMacierzWezlowPosrednich.Visible = false;
            // 
            // mpLBLTrasa
            // 
            this.mpLBLTrasa.AutoSize = true;
            this.mpLBLTrasa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mpLBLTrasa.Location = new System.Drawing.Point(611, 68);
            this.mpLBLTrasa.Name = "mpLBLTrasa";
            this.mpLBLTrasa.Size = new System.Drawing.Size(263, 19);
            this.mpLBLTrasa.TabIndex = 11;
            this.mpLBLTrasa.Text = "Najkrótsze trasy między węzłami grafu:";
            this.mpLBLTrasa.Visible = false;
            // 
            // mpDGVMacierzWag
            // 
            this.mpDGVMacierzWag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mpDGVMacierzWag.Location = new System.Drawing.Point(206, 90);
            this.mpDGVMacierzWag.Name = "mpDGVMacierzWag";
            this.mpDGVMacierzWag.Size = new System.Drawing.Size(399, 150);
            this.mpDGVMacierzWag.TabIndex = 12;
            this.mpDGVMacierzWag.Visible = false;
            // 
            // mpDGVMacierzOdleglosci
            // 
            this.mpDGVMacierzOdleglosci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mpDGVMacierzOdleglosci.Location = new System.Drawing.Point(206, 265);
            this.mpDGVMacierzOdleglosci.Name = "mpDGVMacierzOdleglosci";
            this.mpDGVMacierzOdleglosci.Size = new System.Drawing.Size(399, 150);
            this.mpDGVMacierzOdleglosci.TabIndex = 13;
            this.mpDGVMacierzOdleglosci.Visible = false;
            // 
            // mpDGVMacierzWezlowPosrednich
            // 
            this.mpDGVMacierzWezlowPosrednich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mpDGVMacierzWezlowPosrednich.Location = new System.Drawing.Point(206, 440);
            this.mpDGVMacierzWezlowPosrednich.Name = "mpDGVMacierzWezlowPosrednich";
            this.mpDGVMacierzWezlowPosrednich.Size = new System.Drawing.Size(399, 150);
            this.mpDGVMacierzWezlowPosrednich.TabIndex = 14;
            this.mpDGVMacierzWezlowPosrednich.Visible = false;
            // 
            // mpRTBTrasa
            // 
            this.mpRTBTrasa.Location = new System.Drawing.Point(615, 91);
            this.mpRTBTrasa.Name = "mpRTBTrasa";
            this.mpRTBTrasa.Size = new System.Drawing.Size(465, 499);
            this.mpRTBTrasa.TabIndex = 15;
            this.mpRTBTrasa.Text = "";
            this.mpRTBTrasa.Visible = false;
            // 
            // Algorytm_Floyda_Warshalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.mpRTBTrasa);
            this.Controls.Add(this.mpDGVMacierzWezlowPosrednich);
            this.Controls.Add(this.mpDGVMacierzOdleglosci);
            this.Controls.Add(this.mpDGVMacierzWag);
            this.Controls.Add(this.mpLBLTrasa);
            this.Controls.Add(this.mpLBLMacierzWezlowPosrednich);
            this.Controls.Add(this.mpLBLMacierzOdleglosci);
            this.Controls.Add(this.mpLBLMacierzWag);
            this.Controls.Add(this.mpBTNWypiszTrasy);
            this.Controls.Add(this.mpBTNWyznaczSciezkiWGrafie);
            this.Controls.Add(this.mpBTNAkceptacjaMacierzyWag);
            this.Controls.Add(this.mpBTNPrzykladowaMacierzWag);
            this.Controls.Add(this.mpBTNMacierzWag);
            this.Controls.Add(this.mpTXTLiczbaWierzcholkowGrafu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Algorytm_Floyda_Warshalla";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algorytm_Floyda_Warshalla";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Algorytm_Floyda_Warshalla_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.mpErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpDGVMacierzWag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpDGVMacierzOdleglosci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpDGVMacierzWezlowPosrednich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider mpErrorProvider1;
        private System.Windows.Forms.Button mpBTNWypiszTrasy;
        private System.Windows.Forms.Button mpBTNWyznaczSciezkiWGrafie;
        private System.Windows.Forms.Button mpBTNAkceptacjaMacierzyWag;
        private System.Windows.Forms.Button mpBTNPrzykladowaMacierzWag;
        private System.Windows.Forms.Button mpBTNMacierzWag;
        private System.Windows.Forms.TextBox mpTXTLiczbaWierzcholkowGrafu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mpLBLTrasa;
        private System.Windows.Forms.Label mpLBLMacierzWezlowPosrednich;
        private System.Windows.Forms.Label mpLBLMacierzOdleglosci;
        private System.Windows.Forms.Label mpLBLMacierzWag;
        private System.Windows.Forms.DataGridView mpDGVMacierzWezlowPosrednich;
        private System.Windows.Forms.DataGridView mpDGVMacierzOdleglosci;
        private System.Windows.Forms.DataGridView mpDGVMacierzWag;
        private System.Windows.Forms.RichTextBox mpRTBTrasa;
    }
}