namespace Pizzaria_do_joao
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PEDIDOS = new System.Windows.Forms.TabPage();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.Retirando_sabor = new System.Windows.Forms.Button();
            this.add_sabor = new System.Windows.Forms.Button();
            this.lblsabor = new System.Windows.Forms.Label();
            this.combobox_sabor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Gerenciador = new System.Windows.Forms.TabPage();
            this.numeropedido = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Procurar_pedido = new System.Windows.Forms.Button();
            this.statuspedido = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_dono = new System.Windows.Forms.Label();
            this.Sistema = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.PEDIDOS.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Gerenciador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(6, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(410, 85);
            label1.TabIndex = 0;
            label1.Text = "MONTE A PIZZA COMO DESEJAR:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PEDIDOS
            // 
            this.PEDIDOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.PEDIDOS.Controls.Add(this.comboBox4);
            this.PEDIDOS.Controls.Add(this.Retirando_sabor);
            this.PEDIDOS.Controls.Add(this.add_sabor);
            this.PEDIDOS.Controls.Add(this.lblsabor);
            this.PEDIDOS.Controls.Add(this.combobox_sabor);
            this.PEDIDOS.Controls.Add(this.label6);
            this.PEDIDOS.Controls.Add(this.label5);
            this.PEDIDOS.Controls.Add(this.button1);
            this.PEDIDOS.Controls.Add(this.label4);
            this.PEDIDOS.Controls.Add(this.comboBox2);
            this.PEDIDOS.Controls.Add(this.label3);
            this.PEDIDOS.Controls.Add(this.comboBox1);
            this.PEDIDOS.Controls.Add(this.label2);
            this.PEDIDOS.Controls.Add(label1);
            this.PEDIDOS.Location = new System.Drawing.Point(4, 22);
            this.PEDIDOS.Name = "PEDIDOS";
            this.PEDIDOS.Padding = new System.Windows.Forms.Padding(3);
            this.PEDIDOS.Size = new System.Drawing.Size(419, 511);
            this.PEDIDOS.TabIndex = 0;
            this.PEDIDOS.Text = "FAÇA O SEU PEDIDO";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Selecione os sabores"});
            this.comboBox4.Location = new System.Drawing.Point(24, 368);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(370, 28);
            this.comboBox4.TabIndex = 16;
            this.comboBox4.Text = " Selecione os Sabores 2";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // Retirando_sabor
            // 
            this.Retirando_sabor.BackColor = System.Drawing.Color.Black;
            this.Retirando_sabor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Retirando_sabor.Location = new System.Drawing.Point(120, 402);
            this.Retirando_sabor.Name = "Retirando_sabor";
            this.Retirando_sabor.Size = new System.Drawing.Size(90, 23);
            this.Retirando_sabor.TabIndex = 15;
            this.Retirando_sabor.Text = "Retirar";
            this.Retirando_sabor.UseVisualStyleBackColor = false;
            this.Retirando_sabor.Click += new System.EventHandler(this.Retirando_sabor_Click);
            // 
            // add_sabor
            // 
            this.add_sabor.BackColor = System.Drawing.Color.Black;
            this.add_sabor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_sabor.Location = new System.Drawing.Point(24, 402);
            this.add_sabor.Name = "add_sabor";
            this.add_sabor.Size = new System.Drawing.Size(90, 23);
            this.add_sabor.TabIndex = 14;
            this.add_sabor.Text = "Adicionar";
            this.add_sabor.UseVisualStyleBackColor = false;
            this.add_sabor.Click += new System.EventHandler(this.add_sabor_Click);
            // 
            // lblsabor
            // 
            this.lblsabor.BackColor = System.Drawing.SystemColors.Window;
            this.lblsabor.Location = new System.Drawing.Point(24, 294);
            this.lblsabor.Name = "lblsabor";
            this.lblsabor.Size = new System.Drawing.Size(370, 37);
            this.lblsabor.TabIndex = 13;
            this.lblsabor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combobox_sabor
            // 
            this.combobox_sabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_sabor.FormattingEnabled = true;
            this.combobox_sabor.Items.AddRange(new object[] {
            "Selecione os sabores"});
            this.combobox_sabor.Location = new System.Drawing.Point(24, 334);
            this.combobox_sabor.Name = "combobox_sabor";
            this.combobox_sabor.Size = new System.Drawing.Size(370, 28);
            this.combobox_sabor.TabIndex = 12;
            this.combobox_sabor.Text = " Selecione os Sabores 1";
            this.combobox_sabor.SelectedIndexChanged += new System.EventHandler(this.combobox_sabor_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Selecione até 2 sabores";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 47);
            this.label5.TabIndex = 9;
            this.label5.Text = "Delicie-se com cada mordida e sinta o sabor da tradição em cada fatia!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(174, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Fazer Pedido!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sabores:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Selecione a Massa"});
            this.comboBox2.Location = new System.Drawing.Point(24, 209);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(370, 28);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = " Selecione a Massa";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Massas:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Selecione a borda"});
            this.comboBox1.Location = new System.Drawing.Point(24, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = " Selecione a borda";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bordas:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.PEDIDOS);
            this.tabControl1.Controls.Add(this.Gerenciador);
            this.tabControl1.Location = new System.Drawing.Point(13, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // Gerenciador
            // 
            this.Gerenciador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.Gerenciador.Controls.Add(this.Sistema);
            this.Gerenciador.Controls.Add(this.numeropedido);
            this.Gerenciador.Controls.Add(this.pictureBox1);
            this.Gerenciador.Controls.Add(this.Procurar_pedido);
            this.Gerenciador.Controls.Add(this.statuspedido);
            this.Gerenciador.Controls.Add(this.label9);
            this.Gerenciador.Controls.Add(this.label7);
            this.Gerenciador.Controls.Add(this.lbl_dono);
            this.Gerenciador.Location = new System.Drawing.Point(4, 22);
            this.Gerenciador.Name = "Gerenciador";
            this.Gerenciador.Padding = new System.Windows.Forms.Padding(3);
            this.Gerenciador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Gerenciador.Size = new System.Drawing.Size(419, 511);
            this.Gerenciador.TabIndex = 1;
            this.Gerenciador.Text = "STATUS DO PEDIDO";
            // 
            // numeropedido
            // 
            this.numeropedido.Location = new System.Drawing.Point(80, 359);
            this.numeropedido.Name = "numeropedido";
            this.numeropedido.Size = new System.Drawing.Size(333, 20);
            this.numeropedido.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizzaria_do_joao.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(80, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Procurar_pedido
            // 
            this.Procurar_pedido.BackColor = System.Drawing.Color.Black;
            this.Procurar_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Procurar_pedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Procurar_pedido.Location = new System.Drawing.Point(290, 457);
            this.Procurar_pedido.Name = "Procurar_pedido";
            this.Procurar_pedido.Size = new System.Drawing.Size(112, 36);
            this.Procurar_pedido.TabIndex = 10;
            this.Procurar_pedido.Text = "Procurar";
            this.Procurar_pedido.UseVisualStyleBackColor = false;
            this.Procurar_pedido.Click += new System.EventHandler(this.Procurar_pedido_Click);
            // 
            // statuspedido
            // 
            this.statuspedido.BackColor = System.Drawing.Color.White;
            this.statuspedido.Location = new System.Drawing.Point(80, 407);
            this.statuspedido.Name = "statuspedido";
            this.statuspedido.Size = new System.Drawing.Size(333, 23);
            this.statuspedido.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "STATUS";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "PEDIDO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dono
            // 
            this.lbl_dono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dono.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_dono.Location = new System.Drawing.Point(7, -16);
            this.lbl_dono.Name = "lbl_dono";
            this.lbl_dono.Size = new System.Drawing.Size(416, 90);
            this.lbl_dono.TabIndex = 0;
            this.lbl_dono.Text = "STATUS DO PEDIDO";
            this.lbl_dono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sistema
            // 
            this.Sistema.BackColor = System.Drawing.Color.Black;
            this.Sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Sistema.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sistema.Location = new System.Drawing.Point(6, 457);
            this.Sistema.Name = "Sistema";
            this.Sistema.Size = new System.Drawing.Size(162, 36);
            this.Sistema.TabIndex = 13;
            this.Sistema.Text = "Sistema de pedidos";
            this.Sistema.UseVisualStyleBackColor = false;
            this.Sistema.Click += new System.EventHandler(this.Sistema_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(452, 543);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(468, 582);
            this.MinimumSize = new System.Drawing.Size(468, 582);
            this.Name = "Form1";
            this.Text = "PizzaExpress";
            this.PEDIDOS.ResumeLayout(false);
            this.PEDIDOS.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Gerenciador.ResumeLayout(false);
            this.Gerenciador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage PEDIDOS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblsabor;
        private System.Windows.Forms.ComboBox combobox_sabor;
        private System.Windows.Forms.Button Retirando_sabor;
        private System.Windows.Forms.Button add_sabor;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TabPage Gerenciador;
        private System.Windows.Forms.TextBox numeropedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Procurar_pedido;
        private System.Windows.Forms.Label statuspedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_dono;
        private System.Windows.Forms.Button Sistema;
    }
}

