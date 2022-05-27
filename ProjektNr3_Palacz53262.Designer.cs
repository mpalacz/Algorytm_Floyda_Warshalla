namespace Algorytm_Floyda_Warshalla
{
    partial class ProjektNr3_Palacz53262
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
            this.mpDGVListaSasiedztwa = new System.Windows.Forms.DataGridView();
            this.mpZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpWaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpLBLListaSasiedztwa = new System.Windows.Forms.Label();
            this.mpBTNWyznaczSciezkiWGrafie = new System.Windows.Forms.Button();
            this.mpBTNPrzykladowaListaSasiedztwa = new System.Windows.Forms.Button();
            this.mpDGVWynikTablica = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpLBLWynikTablica = new System.Windows.Forms.Label();
            this.mpLBLKosztCzasowy = new System.Windows.Forms.Label();
            this.mpTXTKosztCzasowy = new System.Windows.Forms.TextBox();
            this.mpTXTKosztPamieciowy = new System.Windows.Forms.TextBox();
            this.mpLBLKosztPamieciowy = new System.Windows.Forms.Label();
            this.mpLBLWizualizacjaScierzki = new System.Windows.Forms.Label();
            this.mpRTBWizualizacjaScierzki = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mpDGVListaSasiedztwa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpDGVWynikTablica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(396, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProjektNr3_Palacz53262";
            // 
            // mpDGVListaSasiedztwa
            // 
            this.mpDGVListaSasiedztwa.AllowUserToAddRows = false;
            this.mpDGVListaSasiedztwa.AllowUserToDeleteRows = false;
            this.mpDGVListaSasiedztwa.AllowUserToResizeColumns = false;
            this.mpDGVListaSasiedztwa.AllowUserToResizeRows = false;
            this.mpDGVListaSasiedztwa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.mpDGVListaSasiedztwa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.mpDGVListaSasiedztwa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mpDGVListaSasiedztwa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mpZ,
            this.mpDo,
            this.mpWaga});
            this.mpDGVListaSasiedztwa.Location = new System.Drawing.Point(197, 58);
            this.mpDGVListaSasiedztwa.Name = "mpDGVListaSasiedztwa";
            this.mpDGVListaSasiedztwa.ReadOnly = true;
            this.mpDGVListaSasiedztwa.Size = new System.Drawing.Size(214, 236);
            this.mpDGVListaSasiedztwa.TabIndex = 20;
            this.mpDGVListaSasiedztwa.Visible = false;
            // 
            // mpZ
            // 
            this.mpZ.HeaderText = "Z";
            this.mpZ.Name = "mpZ";
            this.mpZ.ReadOnly = true;
            this.mpZ.Width = 43;
            // 
            // mpDo
            // 
            this.mpDo.HeaderText = "Do";
            this.mpDo.Name = "mpDo";
            this.mpDo.ReadOnly = true;
            this.mpDo.Width = 54;
            // 
            // mpWaga
            // 
            this.mpWaga.HeaderText = "Waga";
            this.mpWaga.Name = "mpWaga";
            this.mpWaga.ReadOnly = true;
            this.mpWaga.Width = 72;
            // 
            // mpLBLListaSasiedztwa
            // 
            this.mpLBLListaSasiedztwa.AutoSize = true;
            this.mpLBLListaSasiedztwa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mpLBLListaSasiedztwa.Location = new System.Drawing.Point(193, 36);
            this.mpLBLListaSasiedztwa.Name = "mpLBLListaSasiedztwa";
            this.mpLBLListaSasiedztwa.Size = new System.Drawing.Size(184, 19);
            this.mpLBLListaSasiedztwa.TabIndex = 17;
            this.mpLBLListaSasiedztwa.Text = "Lista sąsiedztwa z wagami:";
            this.mpLBLListaSasiedztwa.Visible = false;
            // 
            // mpBTNWyznaczSciezkiWGrafie
            // 
            this.mpBTNWyznaczSciezkiWGrafie.Enabled = false;
            this.mpBTNWyznaczSciezkiWGrafie.Location = new System.Drawing.Point(12, 117);
            this.mpBTNWyznaczSciezkiWGrafie.Name = "mpBTNWyznaczSciezkiWGrafie";
            this.mpBTNWyznaczSciezkiWGrafie.Size = new System.Drawing.Size(179, 69);
            this.mpBTNWyznaczSciezkiWGrafie.TabIndex = 16;
            this.mpBTNWyznaczSciezkiWGrafie.Text = "Wyznacz najkrótsze ścieżki w grafie według algorytmu Dijkstry";
            this.mpBTNWyznaczSciezkiWGrafie.UseVisualStyleBackColor = true;
            this.mpBTNWyznaczSciezkiWGrafie.Click += new System.EventHandler(this.mpBTNWyznaczSciezkiWGrafie_Click);
            // 
            // mpBTNPrzykladowaListaSasiedztwa
            // 
            this.mpBTNPrzykladowaListaSasiedztwa.Location = new System.Drawing.Point(12, 58);
            this.mpBTNPrzykladowaListaSasiedztwa.Name = "mpBTNPrzykladowaListaSasiedztwa";
            this.mpBTNPrzykladowaListaSasiedztwa.Size = new System.Drawing.Size(179, 53);
            this.mpBTNPrzykladowaListaSasiedztwa.TabIndex = 15;
            this.mpBTNPrzykladowaListaSasiedztwa.Text = "Przykładowa lista sasiedztwa";
            this.mpBTNPrzykladowaListaSasiedztwa.UseVisualStyleBackColor = true;
            this.mpBTNPrzykladowaListaSasiedztwa.Click += new System.EventHandler(this.mpBTNPrzykladowaListaSasiedztwa_Click);
            // 
            // mpDGVWynikTablica
            // 
            this.mpDGVWynikTablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mpDGVWynikTablica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.mpDGVWynikTablica.Location = new System.Drawing.Point(418, 58);
            this.mpDGVWynikTablica.Name = "mpDGVWynikTablica";
            this.mpDGVWynikTablica.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mpDGVWynikTablica.Size = new System.Drawing.Size(268, 236);
            this.mpDGVWynikTablica.TabIndex = 21;
            this.mpDGVWynikTablica.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Koszt przejścia";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ostatni wierzchołek ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // mpLBLWynikTablica
            // 
            this.mpLBLWynikTablica.AutoSize = true;
            this.mpLBLWynikTablica.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.mpLBLWynikTablica.Location = new System.Drawing.Point(414, 36);
            this.mpLBLWynikTablica.Name = "mpLBLWynikTablica";
            this.mpLBLWynikTablica.Size = new System.Drawing.Size(57, 19);
            this.mpLBLWynikTablica.TabIndex = 22;
            this.mpLBLWynikTablica.Text = "Wyniki:";
            this.mpLBLWynikTablica.Visible = false;
            // 
            // mpLBLKosztCzasowy
            // 
            this.mpLBLKosztCzasowy.AutoSize = true;
            this.mpLBLKosztCzasowy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.mpLBLKosztCzasowy.Location = new System.Drawing.Point(12, 189);
            this.mpLBLKosztCzasowy.Name = "mpLBLKosztCzasowy";
            this.mpLBLKosztCzasowy.Size = new System.Drawing.Size(107, 19);
            this.mpLBLKosztCzasowy.TabIndex = 23;
            this.mpLBLKosztCzasowy.Text = "Koszt czasowy:";
            this.mpLBLKosztCzasowy.Visible = false;
            // 
            // mpTXTKosztCzasowy
            // 
            this.mpTXTKosztCzasowy.Location = new System.Drawing.Point(12, 211);
            this.mpTXTKosztCzasowy.Name = "mpTXTKosztCzasowy";
            this.mpTXTKosztCzasowy.ReadOnly = true;
            this.mpTXTKosztCzasowy.Size = new System.Drawing.Size(179, 26);
            this.mpTXTKosztCzasowy.TabIndex = 24;
            this.mpTXTKosztCzasowy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mpTXTKosztCzasowy.Visible = false;
            // 
            // mpTXTKosztPamieciowy
            // 
            this.mpTXTKosztPamieciowy.Location = new System.Drawing.Point(12, 268);
            this.mpTXTKosztPamieciowy.Name = "mpTXTKosztPamieciowy";
            this.mpTXTKosztPamieciowy.ReadOnly = true;
            this.mpTXTKosztPamieciowy.Size = new System.Drawing.Size(179, 26);
            this.mpTXTKosztPamieciowy.TabIndex = 26;
            this.mpTXTKosztPamieciowy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mpTXTKosztPamieciowy.Visible = false;
            // 
            // mpLBLKosztPamieciowy
            // 
            this.mpLBLKosztPamieciowy.AutoSize = true;
            this.mpLBLKosztPamieciowy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.mpLBLKosztPamieciowy.Location = new System.Drawing.Point(12, 246);
            this.mpLBLKosztPamieciowy.Name = "mpLBLKosztPamieciowy";
            this.mpLBLKosztPamieciowy.Size = new System.Drawing.Size(130, 19);
            this.mpLBLKosztPamieciowy.TabIndex = 25;
            this.mpLBLKosztPamieciowy.Text = "Koszt pamięciowy:";
            this.mpLBLKosztPamieciowy.Visible = false;
            // 
            // mpLBLWizualizacjaScierzki
            // 
            this.mpLBLWizualizacjaScierzki.AutoSize = true;
            this.mpLBLWizualizacjaScierzki.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.mpLBLWizualizacjaScierzki.Location = new System.Drawing.Point(689, 36);
            this.mpLBLWizualizacjaScierzki.Name = "mpLBLWizualizacjaScierzki";
            this.mpLBLWizualizacjaScierzki.Size = new System.Drawing.Size(140, 19);
            this.mpLBLWizualizacjaScierzki.TabIndex = 27;
            this.mpLBLWizualizacjaScierzki.Text = "Wizualizacja ścieżki:";
            this.mpLBLWizualizacjaScierzki.Visible = false;
            // 
            // mpRTBWizualizacjaScierzki
            // 
            this.mpRTBWizualizacjaScierzki.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.mpRTBWizualizacjaScierzki.Location = new System.Drawing.Point(693, 58);
            this.mpRTBWizualizacjaScierzki.Name = "mpRTBWizualizacjaScierzki";
            this.mpRTBWizualizacjaScierzki.Size = new System.Drawing.Size(268, 236);
            this.mpRTBWizualizacjaScierzki.TabIndex = 28;
            this.mpRTBWizualizacjaScierzki.Text = "";
            this.mpRTBWizualizacjaScierzki.Visible = false;
            // 
            // ProjektNr3_Palacz53262
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 301);
            this.Controls.Add(this.mpRTBWizualizacjaScierzki);
            this.Controls.Add(this.mpLBLWizualizacjaScierzki);
            this.Controls.Add(this.mpTXTKosztPamieciowy);
            this.Controls.Add(this.mpLBLKosztPamieciowy);
            this.Controls.Add(this.mpTXTKosztCzasowy);
            this.Controls.Add(this.mpLBLKosztCzasowy);
            this.Controls.Add(this.mpLBLWynikTablica);
            this.Controls.Add(this.mpDGVWynikTablica);
            this.Controls.Add(this.mpDGVListaSasiedztwa);
            this.Controls.Add(this.mpLBLListaSasiedztwa);
            this.Controls.Add(this.mpBTNWyznaczSciezkiWGrafie);
            this.Controls.Add(this.mpBTNPrzykladowaListaSasiedztwa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ProjektNr3_Palacz53262";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjektNr3_Palacz53262";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjektNr3_Palacz53262_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.mpDGVListaSasiedztwa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpDGVWynikTablica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView mpDGVListaSasiedztwa;
        private System.Windows.Forms.Label mpLBLListaSasiedztwa;
        private System.Windows.Forms.Button mpBTNWyznaczSciezkiWGrafie;
        private System.Windows.Forms.Button mpBTNPrzykladowaListaSasiedztwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpWaga;
        private System.Windows.Forms.DataGridView mpDGVWynikTablica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label mpLBLWynikTablica;
        private System.Windows.Forms.Label mpLBLKosztCzasowy;
        private System.Windows.Forms.TextBox mpTXTKosztCzasowy;
        private System.Windows.Forms.TextBox mpTXTKosztPamieciowy;
        private System.Windows.Forms.Label mpLBLKosztPamieciowy;
        private System.Windows.Forms.Label mpLBLWizualizacjaScierzki;
        private System.Windows.Forms.RichTextBox mpRTBWizualizacjaScierzki;
    }
}