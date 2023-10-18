namespace Parte_do_Gerente
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Atualizar_pedido = new System.Windows.Forms.Button();
            this.Excluirpedido = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BORDAS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MASSAS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SABORES = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STATUS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ALTERAR_PEDIDO = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ID2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BORDA2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MASSA2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STATUS2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.atualizarpedido = new System.Windows.Forms.Button();
            this.Statuspp2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.INSERIR = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.REGISTRO_MASSAS = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.REGISTRAR_SABOR = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.REGISTRO_BORDAS = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ALTERAR_PEDIDO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.INSERIR.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.ALTERAR_PEDIDO);
            this.tabControl1.Controls.Add(this.INSERIR);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Atualizar_pedido);
            this.tabPage1.Controls.Add(this.Excluirpedido);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(633, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GERENCIADOR DE PEDIDOS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(345, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Atualizar Pedidos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "\"Na nossa pizzaria, cada pizza é uma obra-prima, e cada cliente é um convidado es" +
    "pecial.\"";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Atualizar_pedido
            // 
            this.Atualizar_pedido.BackColor = System.Drawing.Color.Black;
            this.Atualizar_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Atualizar_pedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Atualizar_pedido.Location = new System.Drawing.Point(493, 197);
            this.Atualizar_pedido.Name = "Atualizar_pedido";
            this.Atualizar_pedido.Size = new System.Drawing.Size(134, 38);
            this.Atualizar_pedido.TabIndex = 4;
            this.Atualizar_pedido.Text = "Atualizar Listas";
            this.Atualizar_pedido.UseVisualStyleBackColor = false;
            this.Atualizar_pedido.Click += new System.EventHandler(this.Atualizar_pedido_Click);
            // 
            // Excluirpedido
            // 
            this.Excluirpedido.BackColor = System.Drawing.Color.Black;
            this.Excluirpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Excluirpedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Excluirpedido.Location = new System.Drawing.Point(251, 197);
            this.Excluirpedido.Name = "Excluirpedido";
            this.Excluirpedido.Size = new System.Drawing.Size(88, 38);
            this.Excluirpedido.TabIndex = 3;
            this.Excluirpedido.Text = "Excluir";
            this.Excluirpedido.UseVisualStyleBackColor = false;
            this.Excluirpedido.Click += new System.EventHandler(this.Excluirpedido_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.BORDAS,
            this.MASSAS,
            this.SABORES,
            this.STATUS});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 241);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(621, 327);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "PEDIDO #";
            this.ID.Width = 63;
            // 
            // BORDAS
            // 
            this.BORDAS.Text = "BORDAS";
            this.BORDAS.Width = 125;
            // 
            // MASSAS
            // 
            this.MASSAS.Text = "MASSAS";
            this.MASSAS.Width = 132;
            // 
            // SABORES
            // 
            this.SABORES.Text = "SABORES";
            this.SABORES.Width = 123;
            // 
            // STATUS
            // 
            this.STATUS.Text = "STATUS";
            this.STATUS.Width = 167;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "GERENCIADOR DE PEDIDOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parte_do_Gerente.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ALTERAR_PEDIDO
            // 
            this.ALTERAR_PEDIDO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.ALTERAR_PEDIDO.Controls.Add(this.textBox2);
            this.ALTERAR_PEDIDO.Controls.Add(this.label7);
            this.ALTERAR_PEDIDO.Controls.Add(this.listView2);
            this.ALTERAR_PEDIDO.Controls.Add(this.atualizarpedido);
            this.ALTERAR_PEDIDO.Controls.Add(this.Statuspp2);
            this.ALTERAR_PEDIDO.Controls.Add(this.label6);
            this.ALTERAR_PEDIDO.Controls.Add(this.label5);
            this.ALTERAR_PEDIDO.Controls.Add(this.textBox1);
            this.ALTERAR_PEDIDO.Controls.Add(this.label4);
            this.ALTERAR_PEDIDO.Controls.Add(this.label3);
            this.ALTERAR_PEDIDO.Controls.Add(this.pictureBox2);
            this.ALTERAR_PEDIDO.Location = new System.Drawing.Point(4, 22);
            this.ALTERAR_PEDIDO.Name = "ALTERAR_PEDIDO";
            this.ALTERAR_PEDIDO.Size = new System.Drawing.Size(633, 574);
            this.ALTERAR_PEDIDO.TabIndex = 1;
            this.ALTERAR_PEDIDO.Text = "ALTERAÇÃO DE PEDIDO";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 306);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(423, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 62);
            this.label7.TabIndex = 10;
            this.label7.Text = "STATUS ATUAL:  ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID2,
            this.BORDA2,
            this.MASSA2,
            this.STATUS2});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(133, 348);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(423, 97);
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // ID2
            // 
            this.ID2.Text = "ID";
            this.ID2.Width = 36;
            // 
            // BORDA2
            // 
            this.BORDA2.Text = "BORDA";
            this.BORDA2.Width = 126;
            // 
            // MASSA2
            // 
            this.MASSA2.Text = "MASSAS";
            this.MASSA2.Width = 138;
            // 
            // STATUS2
            // 
            this.STATUS2.Text = "STATUS";
            this.STATUS2.Width = 117;
            // 
            // atualizarpedido
            // 
            this.atualizarpedido.BackColor = System.Drawing.Color.Black;
            this.atualizarpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.atualizarpedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.atualizarpedido.Location = new System.Drawing.Point(466, 508);
            this.atualizarpedido.Name = "atualizarpedido";
            this.atualizarpedido.Size = new System.Drawing.Size(154, 46);
            this.atualizarpedido.TabIndex = 7;
            this.atualizarpedido.Text = "Atualizar ";
            this.atualizarpedido.UseVisualStyleBackColor = false;
            this.atualizarpedido.Click += new System.EventHandler(this.atualizarpedido_Click);
            // 
            // Statuspp2
            // 
            this.Statuspp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuspp2.FormattingEnabled = true;
            this.Statuspp2.Items.AddRange(new object[] {
            "Selecione o Status"});
            this.Statuspp2.Location = new System.Drawing.Point(135, 461);
            this.Statuspp2.Name = "Statuspp2";
            this.Statuspp2.Size = new System.Drawing.Size(421, 28);
            this.Statuspp2.TabIndex = 6;
            this.Statuspp2.SelectedIndexChanged += new System.EventHandler(this.Statuspp2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "STATUS: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "PEDIDO #:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(423, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(291, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 67);
            this.label4.TabIndex = 2;
            this.label4.Text = "\"Na nossa pizzaria, cada pizza é uma obra-prima, e cada cliente é um convidado es" +
    "pecial.\"";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(267, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 113);
            this.label3.TabIndex = 1;
            this.label3.Text = "GERENCIADOR DE PEDIDOS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Parte_do_Gerente.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 214);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // INSERIR
            // 
            this.INSERIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.INSERIR.Controls.Add(this.groupBox3);
            this.INSERIR.Controls.Add(this.groupBox1);
            this.INSERIR.Controls.Add(this.groupBox2);
            this.INSERIR.Controls.Add(this.label9);
            this.INSERIR.Controls.Add(this.label8);
            this.INSERIR.Controls.Add(this.pictureBox3);
            this.INSERIR.Location = new System.Drawing.Point(4, 22);
            this.INSERIR.Name = "INSERIR";
            this.INSERIR.Size = new System.Drawing.Size(633, 574);
            this.INSERIR.TabIndex = 2;
            this.INSERIR.Text = "INSERIR PRODUTOS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.REGISTRO_MASSAS);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Location = new System.Drawing.Point(232, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 108);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MASSAS";
            // 
            // REGISTRO_MASSAS
            // 
            this.REGISTRO_MASSAS.BackColor = System.Drawing.Color.Black;
            this.REGISTRO_MASSAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTRO_MASSAS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.REGISTRO_MASSAS.Location = new System.Drawing.Point(25, 76);
            this.REGISTRO_MASSAS.Name = "REGISTRO_MASSAS";
            this.REGISTRO_MASSAS.Size = new System.Drawing.Size(139, 32);
            this.REGISTRO_MASSAS.TabIndex = 9;
            this.REGISTRO_MASSAS.Text = "REGISTRAR";
            this.REGISTRO_MASSAS.UseVisualStyleBackColor = false;
            this.REGISTRO_MASSAS.Click += new System.EventHandler(this.REGISTRO_MASSAS_Click);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(6, 36);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(184, 20);
            this.textBox14.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.REGISTRAR_SABOR);
            this.groupBox1.Location = new System.Drawing.Point(23, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 109);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SABORES";
            // 
            // REGISTRAR_SABOR
            // 
            this.REGISTRAR_SABOR.BackColor = System.Drawing.Color.Black;
            this.REGISTRAR_SABOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTRAR_SABOR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.REGISTRAR_SABOR.Location = new System.Drawing.Point(22, 71);
            this.REGISTRAR_SABOR.Name = "REGISTRAR_SABOR";
            this.REGISTRAR_SABOR.Size = new System.Drawing.Size(139, 32);
            this.REGISTRAR_SABOR.TabIndex = 11;
            this.REGISTRAR_SABOR.Text = "REGISTRAR";
            this.REGISTRAR_SABOR.UseVisualStyleBackColor = false;
            this.REGISTRAR_SABOR.Click += new System.EventHandler(this.REGISTRAR_SABOR_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.REGISTRO_BORDAS);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Location = new System.Drawing.Point(437, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 108);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BORDAS";
            // 
            // REGISTRO_BORDAS
            // 
            this.REGISTRO_BORDAS.BackColor = System.Drawing.Color.Black;
            this.REGISTRO_BORDAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTRO_BORDAS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.REGISTRO_BORDAS.Location = new System.Drawing.Point(24, 70);
            this.REGISTRO_BORDAS.Name = "REGISTRO_BORDAS";
            this.REGISTRO_BORDAS.Size = new System.Drawing.Size(139, 32);
            this.REGISTRO_BORDAS.TabIndex = 9;
            this.REGISTRO_BORDAS.Text = "REGISTRAR";
            this.REGISTRO_BORDAS.UseVisualStyleBackColor = false;
            this.REGISTRO_BORDAS.Click += new System.EventHandler(this.REGISTRO_BORDAS_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(6, 32);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(184, 20);
            this.textBox9.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(134, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(398, 64);
            this.label9.TabIndex = 2;
            this.label9.Text = "\"Na nossa pizzaria, cada pizza é uma obra-prima, e cada cliente é um convidado es" +
    "pecial.\"";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label8.Location = new System.Drawing.Point(17, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(607, 64);
            this.label8.TabIndex = 1;
            this.label8.Text = "GERENCIADOR DE PRODUTOS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Parte_do_Gerente.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(202, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(226, 227);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 20);
            this.textBox3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(665, 614);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(681, 653);
            this.MinimumSize = new System.Drawing.Size(681, 653);
            this.Name = "Form1";
            this.Text = "PizzariaExpress";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ALTERAR_PEDIDO.ResumeLayout(false);
            this.ALTERAR_PEDIDO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.INSERIR.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader BORDAS;
        private System.Windows.Forms.ColumnHeader MASSAS;
        private System.Windows.Forms.ColumnHeader STATUS;
        private System.Windows.Forms.Button Excluirpedido;
        private System.Windows.Forms.ColumnHeader SABORES;
        private System.Windows.Forms.Button Atualizar_pedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage ALTERAR_PEDIDO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Statuspp2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader ID2;
        private System.Windows.Forms.ColumnHeader BORDA2;
        private System.Windows.Forms.ColumnHeader MASSA2;
        private System.Windows.Forms.ColumnHeader STATUS2;
        private System.Windows.Forms.Button atualizarpedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage INSERIR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button REGISTRO_MASSAS;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button REGISTRAR_SABOR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button REGISTRO_BORDAS;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

