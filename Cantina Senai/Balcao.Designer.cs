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
            listBox4 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnEntregue = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-81, -150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // listBox4
            // 
            listBox4.BackColor = Color.FromArgb(230, 255, 0);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(41, 352);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(755, 199);
            listBox4.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 89);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 14;
            label1.Text = "Pedidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 332);
            label2.Name = "label2";
            label2.Size = new Size(111, 17);
            label2.TabIndex = 15;
            label2.Text = "Histórico Pedidos";
            // 
            // btnEntregue
            // 
            btnEntregue.BackColor = Color.FromArgb(230, 255, 0);
            btnEntregue.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntregue.Location = new Point(802, 109);
            btnEntregue.Name = "btnEntregue";
            btnEntregue.Size = new Size(75, 23);
            btnEntregue.TabIndex = 16;
            btnEntregue.Text = "Entregue";
            btnEntregue.UseVisualStyleBackColor = false;
            btnEntregue.Click += btnEntregue_Click;
            // 
            // button1
            // 
            button1.Location = new Point(513, 55);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(323, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 19;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(41, 109);
            listView1.Name = "listView1";
            listView1.Size = new Size(755, 199);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Pedido";
            columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Status";
            columnHeader2.Width = 400;
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1079, 563);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(btnEntregue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox4);
            Controls.Add(pictureBox1);
            Name = "Balcao";
            Text = "Balcão";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listBox4;
        private Label label1;
        private Label label2;
        private Button btnEntregue;
        private Button button1;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}