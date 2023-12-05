namespace TrabalhoPaises
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_paises = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_informações = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_flags = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_status2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_gini1 = new System.Windows.Forms.Label();
            this.lbl_subregiao = new System.Windows.Forms.Label();
            this.lbl_populacao = new System.Windows.Forms.Label();
            this.lbl_regiao = new System.Windows.Forms.Label();
            this.lbl_capital = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_flags)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_paises
            // 
            this.comboBox_paises.FormattingEnabled = true;
            this.comboBox_paises.Location = new System.Drawing.Point(29, 68);
            this.comboBox_paises.Name = "comboBox_paises";
            this.comboBox_paises.Size = new System.Drawing.Size(240, 23);
            this.comboBox_paises.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(102, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_status
            // 
            this.lbl_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(850, 140);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(348, 47);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(0, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1190, 39);
            this.progressBar1.TabIndex = 3;
            // 
            // btn_informações
            // 
            this.btn_informações.FlatAppearance.BorderSize = 0;
            this.btn_informações.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_informações.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_informações.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_informações.Location = new System.Drawing.Point(45, 112);
            this.btn_informações.Name = "btn_informações";
            this.btn_informações.Size = new System.Drawing.Size(187, 45);
            this.btn_informações.TabIndex = 4;
            this.btn_informações.Text = "Get Information";
            this.btn_informações.UseVisualStyleBackColor = true;
            this.btn_informações.Click += new System.EventHandler(this.btn_informações_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_flags
            // 
            this.pictureBox_flags.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_flags.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_flags.Location = new System.Drawing.Point(571, 204);
            this.pictureBox_flags.Name = "pictureBox_flags";
            this.pictureBox_flags.Size = new System.Drawing.Size(464, 304);
            this.pictureBox_flags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_flags.TabIndex = 18;
            this.pictureBox_flags.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(3, 579);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Index Gini:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(5, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Population:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(2, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sub-Region:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(4, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Region:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Capital:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_status2
            // 
            this.lbl_status2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_status2.Location = new System.Drawing.Point(192, 62);
            this.lbl_status2.Name = "lbl_status2";
            this.lbl_status2.Size = new System.Drawing.Size(575, 26);
            this.lbl_status2.TabIndex = 19;
            this.lbl_status2.Text = "Status";
            this.lbl_status2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btn_informações);
            this.panel1.Controls.Add(this.lbl_gini1);
            this.panel1.Controls.Add(this.comboBox_paises);
            this.panel1.Controls.Add(this.lbl_subregiao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_populacao);
            this.panel1.Controls.Add(this.lbl_regiao);
            this.panel1.Controls.Add(this.lbl_capital);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 670);
            this.panel1.TabIndex = 20;
            // 
            // lbl_gini1
            // 
            this.lbl_gini1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gini1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gini1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_gini1.Location = new System.Drawing.Point(103, 579);
            this.lbl_gini1.Name = "lbl_gini1";
            this.lbl_gini1.Size = new System.Drawing.Size(129, 23);
            this.lbl_gini1.TabIndex = 25;
            // 
            // lbl_subregiao
            // 
            this.lbl_subregiao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subregiao.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subregiao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_subregiao.Location = new System.Drawing.Point(102, 439);
            this.lbl_subregiao.Name = "lbl_subregiao";
            this.lbl_subregiao.Size = new System.Drawing.Size(167, 23);
            this.lbl_subregiao.TabIndex = 24;
            // 
            // lbl_populacao
            // 
            this.lbl_populacao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_populacao.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_populacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_populacao.Location = new System.Drawing.Point(104, 506);
            this.lbl_populacao.Name = "lbl_populacao";
            this.lbl_populacao.Size = new System.Drawing.Size(167, 23);
            this.lbl_populacao.TabIndex = 23;
            // 
            // lbl_regiao
            // 
            this.lbl_regiao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_regiao.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regiao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_regiao.Location = new System.Drawing.Point(105, 384);
            this.lbl_regiao.Name = "lbl_regiao";
            this.lbl_regiao.Size = new System.Drawing.Size(167, 23);
            this.lbl_regiao.TabIndex = 22;
            // 
            // lbl_capital
            // 
            this.lbl_capital.BackColor = System.Drawing.Color.Transparent;
            this.lbl_capital.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_capital.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_capital.Location = new System.Drawing.Point(102, 318);
            this.lbl_capital.Name = "lbl_capital";
            this.lbl_capital.Size = new System.Drawing.Size(167, 23);
            this.lbl_capital.TabIndex = 21;
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_name.Location = new System.Drawing.Point(102, 259);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(167, 23);
            this.lbl_name.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.lbl_status2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(282, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 100);
            this.panel2.TabIndex = 21;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(935, 61);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(122, 29);
            this.btn_close.TabIndex = 20;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(282, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 100);
            this.panel3.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(353, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(343, 72);
            this.label10.TabIndex = 0;
            this.label10.Text = "Countries";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1060, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1342, 670);
            this.Controls.Add(this.pictureBox_flags);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_flags)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_paises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_informações;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_flags;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_status2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_gini1;
        private System.Windows.Forms.Label lbl_subregiao;
        private System.Windows.Forms.Label lbl_populacao;
        private System.Windows.Forms.Label lbl_regiao;
        private System.Windows.Forms.Label lbl_capital;
    }
}

