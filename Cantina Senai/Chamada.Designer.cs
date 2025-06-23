namespace Cantina_Senai
{
    partial class Chamada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chamada));
            pictureBox1 = new PictureBox();
            listPreparando = new ListBox();
            listPronto = new ListBox();
            buttonVendas = new Button();
            btnBalcao = new Button();
            btnCozinha = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(343, -159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // listPreparando
            // 
            listPreparando.BackColor = Color.FromArgb(230, 255, 0);
            listPreparando.Enabled = false;
            listPreparando.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listPreparando.FormattingEnabled = true;
            listPreparando.ItemHeight = 17;
            listPreparando.Location = new Point(12, 261);
            listPreparando.Name = "listPreparando";
            listPreparando.Size = new Size(497, 293);
            listPreparando.TabIndex = 13;
            // 
            // listPronto
            // 
            listPronto.BackColor = Color.FromArgb(230, 255, 0);
            listPronto.Enabled = false;
            listPronto.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listPronto.FormattingEnabled = true;
            listPronto.ItemHeight = 17;
            listPronto.Location = new Point(570, 262);
            listPronto.Name = "listPronto";
            listPronto.Size = new Size(497, 293);
            listPronto.TabIndex = 14;
            // 
            // buttonVendas
            // 
            buttonVendas.BackColor = Color.FromArgb(230, 255, 0);
            buttonVendas.Font = new Font("Inter Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVendas.Location = new Point(61, 6);
            buttonVendas.Name = "buttonVendas";
            buttonVendas.Size = new Size(75, 23);
            buttonVendas.TabIndex = 15;
            buttonVendas.Text = "Vendas";
            buttonVendas.UseVisualStyleBackColor = false;
            buttonVendas.Click += buttonVendas_Click;
            // 
            // btnBalcao
            // 
            btnBalcao.BackColor = Color.FromArgb(230, 255, 0);
            btnBalcao.Font = new Font("Inter Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBalcao.Location = new Point(61, 29);
            btnBalcao.Name = "btnBalcao";
            btnBalcao.Size = new Size(75, 23);
            btnBalcao.TabIndex = 16;
            btnBalcao.Text = "Balcao";
            btnBalcao.UseVisualStyleBackColor = false;
            btnBalcao.Click += btnBalcao_Click;
            // 
            // btnCozinha
            // 
            btnCozinha.BackColor = Color.FromArgb(230, 255, 0);
            btnCozinha.Font = new Font("Inter Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCozinha.Location = new Point(61, 52);
            btnCozinha.Name = "btnCozinha";
            btnCozinha.Size = new Size(75, 23);
            btnCozinha.TabIndex = 17;
            btnCozinha.Text = "Cozinha";
            btnCozinha.UseVisualStyleBackColor = false;
            btnCozinha.Click += btnCozinha_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 32;
            label1.Text = "ADM:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 35);
            label2.Name = "label2";
            label2.Size = new Size(41, 17);
            label2.TabIndex = 33;
            label2.Text = "ADM:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 58);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 34;
            label3.Text = "ADM:";
            // 
            // Chamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 563);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCozinha);
            Controls.Add(btnBalcao);
            Controls.Add(buttonVendas);
            Controls.Add(listPronto);
            Controls.Add(listPreparando);
            Controls.Add(pictureBox1);
            Name = "Chamada";
            Text = "Chamada";
            Load += Chamada_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listPreparando;
        private ListBox listPronto;
        private Button buttonVendas;
        private Button btnBalcao;
        private Button btnCozinha;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}