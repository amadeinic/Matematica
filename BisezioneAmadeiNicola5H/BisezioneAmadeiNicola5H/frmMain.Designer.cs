namespace BisezioneAmadeiNicola5H
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.cmbScelta = new System.Windows.Forms.ComboBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.crtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rdbBisezione = new System.Windows.Forms.RadioButton();
            this.rdbTangenti = new System.Windows.Forms.RadioButton();
            this.gbpExe = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.crtGrafico)).BeginInit();
            this.gbpExe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estremo A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estremo B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "f(x)";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(73, 8);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(108, 20);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(73, 32);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(108, 20);
            this.txtB.TabIndex = 4;
            // 
            // cmbScelta
            // 
            this.cmbScelta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScelta.FormattingEnabled = true;
            this.cmbScelta.Items.AddRange(new object[] {
            "x^3+x-7",
            "e^x-3x-5",
            "2x+sen(x)-8",
            "x^3+3x+sen(x)-7",
            "e^2x+x-5",
            "x^3 -5X -1"});
            this.cmbScelta.Location = new System.Drawing.Point(73, 55);
            this.cmbScelta.Margin = new System.Windows.Forms.Padding(2);
            this.cmbScelta.Name = "cmbScelta";
            this.cmbScelta.Size = new System.Drawing.Size(108, 21);
            this.cmbScelta.TabIndex = 5;
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(6, 41);
            this.btnCalcola.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(157, 43);
            this.btnCalcola.TabIndex = 6;
            this.btnCalcola.Text = "Calcola!";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDisplay.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(185, 8);
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(566, 186);
            this.lstDisplay.TabIndex = 7;
            // 
            // txtPrec
            // 
            this.txtPrec.Location = new System.Drawing.Point(114, 80);
            this.txtPrec.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(67, 20);
            this.txtPrec.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precisione (N. cifre)";
            // 
            // crtGrafico
            // 
            this.crtGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.crtGrafico.ChartAreas.Add(chartArea1);
            this.crtGrafico.Location = new System.Drawing.Point(12, 205);
            this.crtGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.crtGrafico.Name = "crtGrafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.crtGrafico.Series.Add(series1);
            this.crtGrafico.Size = new System.Drawing.Size(739, 321);
            this.crtGrafico.TabIndex = 10;
            this.crtGrafico.Text = "chart1";
            // 
            // rdbBisezione
            // 
            this.rdbBisezione.AutoSize = true;
            this.rdbBisezione.Checked = true;
            this.rdbBisezione.Location = new System.Drawing.Point(6, 19);
            this.rdbBisezione.Name = "rdbBisezione";
            this.rdbBisezione.Size = new System.Drawing.Size(70, 17);
            this.rdbBisezione.TabIndex = 11;
            this.rdbBisezione.TabStop = true;
            this.rdbBisezione.Text = "Bisezione";
            this.rdbBisezione.UseVisualStyleBackColor = true;
            // 
            // rdbTangenti
            // 
            this.rdbTangenti.AutoSize = true;
            this.rdbTangenti.Location = new System.Drawing.Point(100, 19);
            this.rdbTangenti.Name = "rdbTangenti";
            this.rdbTangenti.Size = new System.Drawing.Size(67, 17);
            this.rdbTangenti.TabIndex = 12;
            this.rdbTangenti.TabStop = true;
            this.rdbTangenti.Text = "Tangenti";
            this.rdbTangenti.UseVisualStyleBackColor = true;
            // 
            // gbpExe
            // 
            this.gbpExe.Controls.Add(this.rdbTangenti);
            this.gbpExe.Controls.Add(this.rdbBisezione);
            this.gbpExe.Controls.Add(this.btnCalcola);
            this.gbpExe.Location = new System.Drawing.Point(13, 105);
            this.gbpExe.Name = "gbpExe";
            this.gbpExe.Size = new System.Drawing.Size(168, 89);
            this.gbpExe.TabIndex = 13;
            this.gbpExe.TabStop = false;
            this.gbpExe.Text = "Esegui";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 544);
            this.Controls.Add(this.gbpExe);
            this.Controls.Add(this.crtGrafico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrec);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.cmbScelta);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Metodo di Bisezione - Nicola Amadei 2015";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtGrafico)).EndInit();
            this.gbpExe.ResumeLayout(false);
            this.gbpExe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.ComboBox cmbScelta;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.TextBox txtPrec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtGrafico;
        private System.Windows.Forms.RadioButton rdbBisezione;
        private System.Windows.Forms.RadioButton rdbTangenti;
        private System.Windows.Forms.GroupBox gbpExe;
    }
}

