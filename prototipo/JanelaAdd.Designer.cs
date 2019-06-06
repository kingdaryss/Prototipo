namespace prototipo
{
    partial class JanelaAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textIpv4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPatrimonio = new System.Windows.Forms.TextBox();
            this.textSala = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textDescricao = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textNome
            // 
            this.textNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textNome.Location = new System.Drawing.Point(63, 14);
            this.textNome.MaxLength = 12;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(221, 20);
            this.textNome.TabIndex = 1;
            this.textNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IPV4:";
            // 
            // textIpv4
            // 
            this.textIpv4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textIpv4.Location = new System.Drawing.Point(63, 45);
            this.textIpv4.MaxLength = 12;
            this.textIpv4.Name = "textIpv4";
            this.textIpv4.Size = new System.Drawing.Size(221, 20);
            this.textIpv4.TabIndex = 3;
            this.textIpv4.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textIpv4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIpv4_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patrimônio:";
            // 
            // textPatrimonio
            // 
            this.textPatrimonio.Location = new System.Drawing.Point(63, 76);
            this.textPatrimonio.Name = "textPatrimonio";
            this.textPatrimonio.Size = new System.Drawing.Size(221, 20);
            this.textPatrimonio.TabIndex = 5;
            this.textPatrimonio.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textSala
            // 
            this.textSala.Location = new System.Drawing.Point(63, 107);
            this.textSala.MaxLength = 20;
            this.textSala.Name = "textSala";
            this.textSala.Size = new System.Drawing.Size(221, 20);
            this.textSala.TabIndex = 6;
            this.textSala.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sala:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(120, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clique Aqui";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Conexão Remota:";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(247, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(166, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Descrição:";
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(5, 200);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(311, 108);
            this.textDescricao.TabIndex = 14;
            this.textDescricao.Text = "";
            this.textDescricao.TextChanged += new System.EventHandler(this.textDescricao_TextChanged);
            // 
            // JanelaAdd
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 342);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSala);
            this.Controls.Add(this.textPatrimonio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textIpv4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(344, 381);
            this.MinimumSize = new System.Drawing.Size(344, 381);
            this.Name = "JanelaAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textIpv4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textPatrimonio;
        public System.Windows.Forms.TextBox textSala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RichTextBox textDescricao;
    }
}