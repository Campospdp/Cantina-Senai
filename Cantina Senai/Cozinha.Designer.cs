namespace Cantina_Senai
{
    partial class Cozinha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cozinha));
            pictureBox1 = new PictureBox();
            listCozinha = new ListBox();
            btnEntregarChapa = new Button();
            btnBalcaoCozinha = new Button();
            btnVendasCozinha = new Button();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnChamada = new Button();
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
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // listCozinha
            // 
            listCozinha.BackColor = Color.FromArgb(230, 255, 0);
            listCozinha.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listCozinha.FormattingEnabled = true;
            listCozinha.ItemHeight = 17;
            listCozinha.Location = new Point(278, 207);
            listCozinha.Name = "listCozinha";
            listCozinha.Size = new Size(497, 293);
            listCozinha.TabIndex = 12;
            // 
            // btnEntregarChapa
            // 
            btnEntregarChapa.BackColor = Color.FromArgb(230, 255, 0);
            btnEntregarChapa.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntregarChapa.Location = new Point(801, 207);
            btnEntregarChapa.Name = "btnEntregarChapa";
            btnEntregarChapa.Size = new Size(75, 23);
            btnEntregarChapa.TabIndex = 13;
            btnEntregarChapa.Text = "Entregar";
            btnEntregarChapa.UseVisualStyleBackColor = false;
            btnEntregarChapa.Click += btnEntregarChapa_Click_1;
            // 
            // btnBalcaoCozinha
            // 
            btnBalcaoCozinha.BackColor = Color.FromArgb(230, 255, 0);
            btnBalcaoCozinha.Font = new Font("Inter Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBalcaoCozinha.Location = new Point(61, 6);
            btnBalcaoCozinha.Name = "btnBalcaoCozinha";
            btnBalcaoCozinha.Size = new Size(75, 23);
            btnBalcaoCozinha.TabIndex = 14;
            btnBalcaoCozinha.Text = "Balcão";
            btnBalcaoCozinha.UseVisualStyleBackColor = false;
            btnBalcaoCozinha.Click += button1_Click;
            // 
            // btnVendasCozinha
            // 
            btnVendasCozinha.BackColor = Color.FromArgb(230, 255, 0);
            btnVendasCozinha.Font = new Font("Inter Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVendasCozinha.Location = new Point(61, 29);
            btnVendasCozinha.Name = "btnVendasCozinha";
            btnVendasCozinha.Size = new Size(75, 23);
            btnVendasCozinha.TabIndex = 15;
            btnVendasCozinha.Text = "Vendas";
            btnVendasCozinha.UseVisualStyleBackColor = false;
            btnVendasCozinha.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 12);
            label7.Name = "label7";
            label7.Size = new Size(41, 17);
            label7.TabIndex = 30;
            label7.Text = "ADM:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 35);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 31;
            label1.Text = "ADM:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(278, 187);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 32;
            label2.Text = "\U0001f9d1‍🍳\U0001f9d1‍🍳\U0001f9d1‍🍳";
            // 
            // btnChamada
            // 
            btnChamada.BackColor = Color.FromArgb(230, 255, 0);
            btnChamada.Font = new Font("Inter Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamada.Location = new Point(61, 52);
            btnChamada.Name = "btnChamada";
            btnChamada.Size = new Size(75, 23);
            btnChamada.TabIndex = 33;
            btnChamada.Text = "Chamada";
            btnChamada.UseVisualStyleBackColor = false;
            btnChamada.Click += button1_Click_1;
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
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1079, 563);
            Controls.Add(label3);
            Controls.Add(btnChamada);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(btnVendasCozinha);
            Controls.Add(btnBalcaoCozinha);
            Controls.Add(btnEntregarChapa);
            Controls.Add(listCozinha);
            Controls.Add(pictureBox1);
            Name = "Cozinha";
            Text = "Cozinha";
            Load += Cozinha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listCozinha;
        private Button btnEntregarChapa;
        private Button btnBalcaoCozinha;
        private Button btnVendasCozinha;
        private Label label7;
        private Label label1;
        private Label label2;
        private Button btnChamada;
        private Label label3;
    }
}