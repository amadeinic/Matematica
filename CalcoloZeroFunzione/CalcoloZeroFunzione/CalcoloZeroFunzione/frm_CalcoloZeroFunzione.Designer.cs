namespace CalcoloZeroFunzione
{
    partial class frm_CalcoloZeroFunzione
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.nUD = new System.Windows.Forms.NumericUpDown();
            this.cmb_funzione = new System.Windows.Forms.ComboBox();
            this.btn_calcola = new System.Windows.Forms.Button();
            this.lbl_funzione = new System.Windows.Forms.Label();
            this.lbl_precisione = new System.Windows.Forms.Label();
            this.txtB_a = new System.Windows.Forms.TextBox();
            this.lbl_a = new System.Windows.Forms.Label();
            this.txtB_b = new System.Windows.Forms.TextBox();
            this.lbl_b = new System.Windows.Forms.Label();
            this.chrtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lstLista = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // nUD
            // 
            this.nUD.Location = new System.Drawing.Point(123, 129);
            this.nUD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD.Name = "nUD";
            this.nUD.Size = new System.Drawing.Size(140, 26);
            this.nUD.TabIndex = 0;
            this.nUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmb_funzione
            // 
            this.cmb_funzione.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_funzione.FormattingEnabled = true;
            this.cmb_funzione.Items.AddRange(new object[] {
            "x^3+x-7",
            "e^x-3x-5",
            "2x+sen(x)-8",
            "x^3+3x+sen(x)-7",
            "e^2x+x-5",
            "x^3 -5X -1"});
            this.cmb_funzione.Location = new System.Drawing.Point(122, 19);
            this.cmb_funzione.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_funzione.Name = "cmb_funzione";
            this.cmb_funzione.Size = new System.Drawing.Size(415, 28);
            this.cmb_funzione.TabIndex = 1;
            // 
            // btn_calcola
            // 
            this.btn_calcola.Location = new System.Drawing.Point(17, 164);
            this.btn_calcola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_calcola.Name = "btn_calcola";
            this.btn_calcola.Size = new System.Drawing.Size(246, 35);
            this.btn_calcola.TabIndex = 2;
            this.btn_calcola.Text = "Trova gli zeri";
            this.btn_calcola.UseVisualStyleBackColor = true;
            this.btn_calcola.Click += new System.EventHandler(this.btn_calcola_Click);
            // 
            // lbl_funzione
            // 
            this.lbl_funzione.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_funzione.AutoSize = true;
            this.lbl_funzione.Location = new System.Drawing.Point(13, 22);
            this.lbl_funzione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_funzione.Name = "lbl_funzione";
            this.lbl_funzione.Size = new System.Drawing.Size(79, 20);
            this.lbl_funzione.TabIndex = 3;
            this.lbl_funzione.Text = "Funzione:";
            // 
            // lbl_precisione
            // 
            this.lbl_precisione.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_precisione.AutoSize = true;
            this.lbl_precisione.Location = new System.Drawing.Point(13, 131);
            this.lbl_precisione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precisione.Name = "lbl_precisione";
            this.lbl_precisione.Size = new System.Drawing.Size(86, 20);
            this.lbl_precisione.TabIndex = 4;
            this.lbl_precisione.Text = "Precisione:";
            // 
            // txtB_a
            // 
            this.txtB_a.Location = new System.Drawing.Point(122, 57);
            this.txtB_a.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtB_a.Name = "txtB_a";
            this.txtB_a.Size = new System.Drawing.Size(141, 26);
            this.txtB_a.TabIndex = 5;
            // 
            // lbl_a
            // 
            this.lbl_a.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(13, 60);
            this.lbl_a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(99, 20);
            this.lbl_a.TabIndex = 6;
            this.lbl_a.Text = "Estremo Sx :";
            // 
            // txtB_b
            // 
            this.txtB_b.Location = new System.Drawing.Point(123, 93);
            this.txtB_b.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtB_b.Name = "txtB_b";
            this.txtB_b.Size = new System.Drawing.Size(140, 26);
            this.txtB_b.TabIndex = 5;
            // 
            // lbl_b
            // 
            this.lbl_b.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(13, 96);
            this.lbl_b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(100, 20);
            this.lbl_b.TabIndex = 6;
            this.lbl_b.Text = "Estremo Dx :";
            // 
            // chrtGrafico
            // 
            this.chrtGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chrtGrafico.ChartAreas.Add(chartArea1);
            this.chrtGrafico.Location = new System.Drawing.Point(12, 207);
            this.chrtGrafico.Name = "chrtGrafico";
            this.chrtGrafico.Size = new System.Drawing.Size(525, 279);
            this.chrtGrafico.TabIndex = 8;
            this.chrtGrafico.Text = "chart1";
            // 
            // lstLista
            // 
            this.lstLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 20;
            this.lstLista.Location = new System.Drawing.Point(269, 55);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(268, 144);
            this.lstLista.TabIndex = 9;
            // 
            // frm_CalcoloZeroFunzione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 498);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.chrtGrafico);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.txtB_b);
            this.Controls.Add(this.txtB_a);
            this.Controls.Add(this.lbl_precisione);
            this.Controls.Add(this.lbl_funzione);
            this.Controls.Add(this.btn_calcola);
            this.Controls.Add(this.cmb_funzione);
            this.Controls.Add(this.nUD);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(488, 554);
            this.Name = "frm_CalcoloZeroFunzione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zero di una funzione";
            this.Load += new System.EventHandler(this.frm_CalcoloZeroFunzione_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUD;
        private System.Windows.Forms.ComboBox cmb_funzione;
        private System.Windows.Forms.Button btn_calcola;
        private System.Windows.Forms.Label lbl_funzione;
        private System.Windows.Forms.Label lbl_precisione;
        private System.Windows.Forms.TextBox txtB_a;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.TextBox txtB_b;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtGrafico;
        private System.Windows.Forms.ListBox lstLista;
    }
}

