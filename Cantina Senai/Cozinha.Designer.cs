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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(345, -49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // listCozinha
            // 
            listCozinha.FormattingEnabled = true;
            listCozinha.ItemHeight = 15;
            listCozinha.Location = new Point(278, 207);
            listCozinha.Name = "listCozinha";
            listCozinha.Size = new Size(497, 304);
            listCozinha.TabIndex = 12;
            // 
            // btnEntregarChapa
            // 
            btnEntregarChapa.Location = new Point(801, 207);
            btnEntregarChapa.Name = "btnEntregarChapa";
            btnEntregarChapa.Size = new Size(75, 23);
            btnEntregarChapa.TabIndex = 13;
            btnEntregarChapa.Text = "Entregar";
            btnEntregarChapa.UseVisualStyleBackColor = true;
            btnEntregarChapa.Click += btnEntregarChapa_Click_1;
            // 
            // btnBalcaoCozinha
            // 
            btnBalcaoCozinha.Location = new Point(61, 166);
            btnBalcaoCozinha.Name = "btnBalcaoCozinha";
            btnBalcaoCozinha.Size = new Size(75, 23);
            btnBalcaoCozinha.TabIndex = 14;
            btnBalcaoCozinha.Text = "Balcão";
            btnBalcaoCozinha.UseVisualStyleBackColor = true;
            btnBalcaoCozinha.Click += button1_Click;
            // 
            // btnVendasCozinha
            // 
            btnVendasCozinha.Location = new Point(61, 195);
            btnVendasCozinha.Name = "btnVendasCozinha";
            btnVendasCozinha.Size = new Size(75, 23);
            btnVendasCozinha.TabIndex = 15;
            btnVendasCozinha.Text = "Vendas";
            btnVendasCozinha.UseVisualStyleBackColor = true;
            btnVendasCozinha.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 174);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 30;
            label7.Text = "ADM:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 195);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 31;
            label1.Text = "ADM:";
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 563);
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
    }
}