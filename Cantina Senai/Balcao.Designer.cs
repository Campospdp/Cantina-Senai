namespace Cantina_Senai
{
    partial class Balcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balcao));
            pictureBox1 = new PictureBox();
            listEntregues = new ListBox();
            label1 = new Label();
            lblEntregue = new Label();
            btnEntregue = new Button();
            listPedido = new ListBox();
            label7 = new Label();
            btnTelaVendasBalcao = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCozinhaBalcao = new Button();
            btnChamada = new Button();
            label5 = new Label();
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
            // listEntregues
            // 
            listEntregues.BackColor = Color.FromArgb(230, 255, 0);
            listEntregues.BorderStyle = BorderStyle.None;
            listEntregues.Enabled = false;
            listEntregues.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listEntregues.ForeColor = SystemColors.GrayText;
            listEntregues.FormattingEnabled = true;
            listEntregues.ItemHeight = 17;
            listEntregues.Location = new Point(671, 216);
            listEntregues.Name = "listEntregues";
            listEntregues.Size = new Size(396, 187);
            listEntregues.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 196);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 14;
            label1.Text = "Pedidos";
            // 
            // lblEntregue
            // 
            lblEntregue.AutoSize = true;
            lblEntregue.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntregue.Location = new Point(671, 196);
            lblEntregue.Name = "lblEntregue";
            lblEntregue.Size = new Size(67, 17);
            lblEntregue.TabIndex = 15;
            lblEntregue.Text = "Entregues";
            // 
            // btnEntregue
            // 
            btnEntregue.BackColor = Color.FromArgb(230, 255, 0);
            btnEntregue.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntregue.Location = new Point(333, 187);
            btnEntregue.Name = "btnEntregue";
            btnEntregue.Size = new Size(75, 23);
            btnEntregue.TabIndex = 16;
            btnEntregue.Text = "Entregue";
            btnEntregue.UseVisualStyleBackColor = false;
            btnEntregue.Click += btnEntregue_Click;
            // 
            // listPedido
            // 
            listPedido.BackColor = Color.FromArgb(230, 255, 0);
            listPedido.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listPedido.FormattingEnabled = true;
            listPedido.HorizontalScrollbar = true;
            listPedido.IntegralHeight = false;
            listPedido.ItemHeight = 17;
            listPedido.Location = new Point(12, 216);
            listPedido.Name = "listPedido";
            listPedido.ScrollAlwaysVisible = true;
            listPedido.Size = new Size(396, 199);
            listPedido.TabIndex = 17;
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
            // btnTelaVendasBalcao
            // 
            btnTelaVendasBalcao.BackColor = Color.FromArgb(230, 255, 0);
            btnTelaVendasBalcao.Font = new Font("Inter Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTelaVendasBalcao.Location = new Point(61, 6);
            btnTelaVendasBalcao.Name = "btnTelaVendasBalcao";
            btnTelaVendasBalcao.Size = new Size(75, 23);
            btnTelaVendasBalcao.TabIndex = 31;
            btnTelaVendasBalcao.Text = "Vendas";
            btnTelaVendasBalcao.UseVisualStyleBackColor = false;
            btnTelaVendasBalcao.Click += btnTelaVendas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 191);
            label2.Name = "label2";
            label2.Size = new Size(33, 23);
            label2.TabIndex = 32;
            label2.Text = "📖";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(744, 195);
            label3.Name = "label3";
            label3.Size = new Size(27, 18);
            label3.TabIndex = 33;
            label3.Text = "✅";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 35);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 34;
            label4.Text = "ADM:";
            // 
            // btnCozinhaBalcao
            // 
            btnCozinhaBalcao.BackColor = Color.FromArgb(230, 255, 0);
            btnCozinhaBalcao.Font = new Font("Inter Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCozinhaBalcao.Location = new Point(61, 29);
            btnCozinhaBalcao.Name = "btnCozinhaBalcao";
            btnCozinhaBalcao.Size = new Size(75, 23);
            btnCozinhaBalcao.TabIndex = 35;
            btnCozinhaBalcao.Text = "Cozinha";
            btnCozinhaBalcao.UseVisualStyleBackColor = false;
            btnCozinhaBalcao.Click += btnCozinha_Click;
            // 
            // btnChamada
            // 
            btnChamada.BackColor = Color.FromArgb(230, 255, 0);
            btnChamada.Font = new Font("Inter Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamada.Location = new Point(61, 52);
            btnChamada.Name = "btnChamada";
            btnChamada.Size = new Size(75, 23);
            btnChamada.TabIndex = 36;
            btnChamada.Text = "Chamada";
            btnChamada.UseVisualStyleBackColor = false;
            btnChamada.Click += btnChamada_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 58);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 37;
            label5.Text = "ADM:";
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1079, 563);
            Controls.Add(label5);
            Controls.Add(btnChamada);
            Controls.Add(btnCozinhaBalcao);
            Controls.Add(label4);
            Controls.Add(btnTelaVendasBalcao);
            Controls.Add(label7);
            Controls.Add(listPedido);
            Controls.Add(btnEntregue);
            Controls.Add(lblEntregue);
            Controls.Add(label1);
            Controls.Add(listEntregues);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "Balcao";
            Text = "Balcão";
            Load += Balcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listEntregues;
        private Label label1;
        private Label lblEntregue;
        private Button btnEntregue;
        private ListBox listPedido;
        private Label label7;
        private Button btnTelaVendasBalcao;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCozinhaBalcao;
        private Button btnChamada;
        private Label label5;
    }
}