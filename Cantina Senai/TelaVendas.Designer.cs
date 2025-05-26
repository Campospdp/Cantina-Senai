namespace Cantina_Senai
{
    partial class TelaVendas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVendas));
            listCardapio = new ListBox();
            listCarrinho = new ListBox();
            btnAdicionar = new Button();
            btnQuantidade = new NumericUpDown();
            btnRemover = new Button();
            btnFinalizar = new Button();
            pictureBox1 = new PictureBox();
            lblTotal = new Label();
            cmbPagamento = new ComboBox();
            txtnomeCliente = new TextBox();
            txtValorPago = new TextBox();
            labelN = new Label();
            label3 = new Label();
            labelV = new Label();
            txtTroco = new TextBox();
            labelT = new Label();
            cmbViagem = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnBalcao = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listCardapio
            // 
            listCardapio.BackColor = Color.FromArgb(230, 255, 0);
            listCardapio.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listCardapio.FormattingEnabled = true;
            listCardapio.ItemHeight = 17;
            listCardapio.Location = new Point(87, 228);
            listCardapio.Name = "listCardapio";
            listCardapio.Size = new Size(250, 191);
            listCardapio.TabIndex = 1;
            // 
            // listCarrinho
            // 
            listCarrinho.BackColor = Color.FromArgb(230, 255, 0);
            listCarrinho.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listCarrinho.FormattingEnabled = true;
            listCarrinho.ItemHeight = 17;
            listCarrinho.Location = new Point(727, 228);
            listCarrinho.Name = "listCarrinho";
            listCarrinho.Size = new Size(250, 191);
            listCarrinho.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(230, 255, 0);
            btnAdicionar.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(87, 151);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(86, 26);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnQuantidade
            // 
            btnQuantidade.BackColor = Color.FromArgb(230, 255, 0);
            btnQuantidade.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuantidade.Location = new Point(217, 151);
            btnQuantidade.Name = "btnQuantidade";
            btnQuantidade.Size = new Size(120, 22);
            btnQuantidade.TabIndex = 2;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(230, 255, 0);
            btnRemover.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(727, 152);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(86, 26);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.FromArgb(230, 255, 0);
            btnFinalizar.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.Location = new Point(891, 485);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(86, 26);
            btnFinalizar.TabIndex = 5;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(345, -55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(727, 428);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(20, 17);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "...";
            // 
            // cmbPagamento
            // 
            cmbPagamento.BackColor = Color.FromArgb(230, 255, 0);
            cmbPagamento.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPagamento.FormattingEnabled = true;
            cmbPagamento.Location = new Point(557, 240);
            cmbPagamento.Name = "cmbPagamento";
            cmbPagamento.Size = new Size(138, 25);
            cmbPagamento.TabIndex = 13;
            cmbPagamento.SelectedIndexChanged += cmbPagamento_SelectedIndexChanged;
            // 
            // txtnomeCliente
            // 
            txtnomeCliente.BackColor = Color.FromArgb(230, 255, 0);
            txtnomeCliente.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnomeCliente.Location = new Point(371, 240);
            txtnomeCliente.Name = "txtnomeCliente";
            txtnomeCliente.Size = new Size(138, 22);
            txtnomeCliente.TabIndex = 14;
            // 
            // txtValorPago
            // 
            txtValorPago.BackColor = Color.FromArgb(230, 255, 0);
            txtValorPago.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValorPago.Location = new Point(371, 307);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(138, 22);
            txtValorPago.TabIndex = 15;
            // 
            // labelN
            // 
            labelN.AutoSize = true;
            labelN.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelN.Location = new Point(371, 217);
            labelN.Name = "labelN";
            labelN.Size = new Size(46, 17);
            labelN.TabIndex = 16;
            labelN.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(557, 217);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 17;
            label3.Text = "Pagamento:";
            // 
            // labelV
            // 
            labelV.AutoSize = true;
            labelV.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelV.Location = new Point(371, 284);
            labelV.Name = "labelV";
            labelV.Size = new Size(42, 17);
            labelV.TabIndex = 19;
            labelV.Text = "Valor:";
            // 
            // txtTroco
            // 
            txtTroco.BackColor = Color.FromArgb(230, 255, 0);
            txtTroco.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTroco.Location = new Point(557, 307);
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(138, 22);
            txtTroco.TabIndex = 20;
            // 
            // labelT
            // 
            labelT.AutoSize = true;
            labelT.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelT.Location = new Point(557, 284);
            labelT.Name = "labelT";
            labelT.Size = new Size(45, 17);
            labelT.TabIndex = 21;
            labelT.Text = "Troco:";
            // 
            // cmbViagem
            // 
            cmbViagem.BackColor = Color.FromArgb(230, 255, 0);
            cmbViagem.FormattingEnabled = true;
            cmbViagem.Location = new Point(727, 486);
            cmbViagem.Name = "cmbViagem";
            cmbViagem.Size = new Size(138, 25);
            cmbViagem.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(727, 464);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);
            label1.TabIndex = 23;
            label1.Text = "Viagem:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 202);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 24;
            label2.Text = "Cardápio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(727, 202);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 25;
            label4.Text = "Carrinho";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(162, 202);
            label5.Name = "label5";
            label5.Size = new Size(33, 23);
            label5.TabIndex = 26;
            label5.Text = "🍔";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(799, 202);
            label6.Name = "label6";
            label6.Size = new Size(33, 23);
            label6.TabIndex = 27;
            label6.Text = "\U0001f6d2";
            // 
            // btnBalcao
            // 
            btnBalcao.BackColor = Color.FromArgb(230, 255, 0);
            btnBalcao.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBalcao.Location = new Point(82, 484);
            btnBalcao.Name = "btnBalcao";
            btnBalcao.Size = new Size(86, 27);
            btnBalcao.TabIndex = 28;
            btnBalcao.Text = "Balcão";
            btnBalcao.UseVisualStyleBackColor = false;
            btnBalcao.Click += btnBalcao_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 490);
            label7.Name = "label7";
            label7.Size = new Size(41, 17);
            label7.TabIndex = 29;
            label7.Text = "ADM:";
            // 
            // TelaVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1079, 563);
            Controls.Add(label7);
            Controls.Add(btnBalcao);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbViagem);
            Controls.Add(labelT);
            Controls.Add(txtTroco);
            Controls.Add(labelV);
            Controls.Add(label3);
            Controls.Add(labelN);
            Controls.Add(txtValorPago);
            Controls.Add(txtnomeCliente);
            Controls.Add(cmbPagamento);
            Controls.Add(lblTotal);
            Controls.Add(btnFinalizar);
            Controls.Add(btnRemover);
            Controls.Add(btnQuantidade);
            Controls.Add(btnAdicionar);
            Controls.Add(listCarrinho);
            Controls.Add(listCardapio);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "TelaVendas";
            ((System.ComponentModel.ISupportInitialize)btnQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listCardapio;
        private ListBox listCarrinho;
        private Button btnAdicionar;
        private NumericUpDown btnQuantidade;
        private Button btnRemover;
        private Button btnFinalizar;
        private PictureBox pictureBox1;
        private Label lblTotal;
        private ComboBox cmbPagamento;
        private TextBox txtnomeCliente;
        private TextBox txtValorPago;
        private Label labelN;
        private Label label3;
        private Label labelV;
        private TextBox txtTroco;
        private Label labelT;
        private ComboBox cmbViagem;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnBalcao;
        private Label label7;
    }
}
