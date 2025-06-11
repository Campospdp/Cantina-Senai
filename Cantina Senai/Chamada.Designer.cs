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
            listPreparando.FormattingEnabled = true;
            listPreparando.ItemHeight = 15;
            listPreparando.Location = new Point(275, 261);
            listPreparando.Name = "listPreparando";
            listPreparando.Size = new Size(249, 169);
            listPreparando.TabIndex = 13;
            // 
            // listPronto
            // 
            listPronto.FormattingEnabled = true;
            listPronto.ItemHeight = 15;
            listPronto.Location = new Point(591, 261);
            listPronto.Name = "listPronto";
            listPronto.Size = new Size(234, 169);
            listPronto.TabIndex = 14;
            // 
            // buttonVendas
            // 
            buttonVendas.Location = new Point(93, 142);
            buttonVendas.Name = "buttonVendas";
            buttonVendas.Size = new Size(75, 23);
            buttonVendas.TabIndex = 15;
            buttonVendas.Text = "button1";
            buttonVendas.UseVisualStyleBackColor = true;
            buttonVendas.Click += buttonVendas_Click;
            // 
            // Chamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 563);
            Controls.Add(buttonVendas);
            Controls.Add(listPronto);
            Controls.Add(listPreparando);
            Controls.Add(pictureBox1);
            Name = "Chamada";
            Text = "Chamada";
            Load += Chamada_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listPreparando;
        private ListBox listPronto;
        private Button buttonVendas;
    }
}