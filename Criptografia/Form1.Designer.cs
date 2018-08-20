namespace Criptografia
{
    partial class Form1
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
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbChave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLimaHomo = new System.Windows.Forms.Button();
            this.btnDecriptaHomofona = new System.Windows.Forms.Button();
            this.tbHomofonaDecriptografada = new System.Windows.Forms.TextBox();
            this.tbCriptografiaHomofona = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.gerarHomofona = new System.Windows.Forms.Button();
            this.tbEntradaHomofona = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLimparDados = new System.Windows.Forms.Button();
            this.btnDecriptaViginere = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFraseDecriptografada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbResultadoCriptografia = new System.Windows.Forms.TextBox();
            this.tbTextoViginere = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbChaveVigi = new System.Windows.Forms.TextBox();
            this.btnGerarViginere = new System.Windows.Forms.Button();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEntrada
            // 
            this.tbEntrada.Location = new System.Drawing.Point(99, 130);
            this.tbEntrada.MaxLength = 200;
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(519, 20);
            this.tbEntrada.TabIndex = 4;
            this.tbEntrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEntrada_KeyDown);
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Image = global::Criptografia.Properties.Resources._2683_32x32;
            this.btnCriptografar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriptografar.Location = new System.Drawing.Point(644, 116);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(192, 47);
            this.btnCriptografar.TabIndex = 5;
            this.btnCriptografar.Text = "Gerar Criptografia";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 433);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 121);
            this.listBox1.TabIndex = 10;
            // 
            // tbChave
            // 
            this.tbChave.Location = new System.Drawing.Point(150, 67);
            this.tbChave.MaxLength = 6;
            this.tbChave.Name = "tbChave";
            this.tbChave.Size = new System.Drawing.Size(68, 20);
            this.tbChave.TabIndex = 3;
            this.tbChave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbChave_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chave de Criptografia:\r\n";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(38, 191);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1243, 69);
            this.listBox2.TabIndex = 8;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab1);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(26, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1342, 610);
            this.tabControl.TabIndex = 6;
            // 
            // tab1
            // 
            this.tab1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab1.Controls.Add(this.label14);
            this.tab1.Controls.Add(this.btnLimpar);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.listBox7);
            this.tab1.Controls.Add(this.button1);
            this.tab1.Controls.Add(this.listBox6);
            this.tab1.Controls.Add(this.tbEntrada);
            this.tab1.Controls.Add(this.tbChave);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.listBox2);
            this.tab1.Controls.Add(this.btnCriptografar);
            this.tab1.Controls.Add(this.listBox1);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1334, 584);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "transposição de colunas utilizando palavra-chave";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Frase:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::Criptografia.Properties.Resources.ccleaner_114;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(1089, 116);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(192, 45);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "FRASE DECRIPTOGRAFADA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "MATRIZ CRIPTOGRAFADA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "FRASE CRIPTOGRAFADA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "MATRIZ FRASE";
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Location = new System.Drawing.Point(38, 305);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(1243, 69);
            this.listBox7.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Image = global::Criptografia.Properties.Resources.setas;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(866, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Decriptografar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(370, 433);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(230, 121);
            this.listBox6.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnLimaHomo);
            this.tabPage1.Controls.Add(this.btnDecriptaHomofona);
            this.tabPage1.Controls.Add(this.tbHomofonaDecriptografada);
            this.tabPage1.Controls.Add(this.tbCriptografiaHomofona);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.listBox4);
            this.tabPage1.Controls.Add(this.gerarHomofona);
            this.tabPage1.Controls.Add(this.tbEntradaHomofona);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1334, 584);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Cifra de Substituição Homófona";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Tabela Homófona:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Decriptografia:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Criptografia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Texto:";
            // 
            // btnLimaHomo
            // 
            this.btnLimaHomo.Image = global::Criptografia.Properties.Resources.ccleaner_114;
            this.btnLimaHomo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimaHomo.Location = new System.Drawing.Point(721, 152);
            this.btnLimaHomo.Name = "btnLimaHomo";
            this.btnLimaHomo.Size = new System.Drawing.Size(214, 36);
            this.btnLimaHomo.TabIndex = 15;
            this.btnLimaHomo.Text = "Limpar Campos";
            this.btnLimaHomo.UseVisualStyleBackColor = true;
            // 
            // btnDecriptaHomofona
            // 
            this.btnDecriptaHomofona.Image = global::Criptografia.Properties.Resources.setas;
            this.btnDecriptaHomofona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecriptaHomofona.Location = new System.Drawing.Point(721, 97);
            this.btnDecriptaHomofona.Name = "btnDecriptaHomofona";
            this.btnDecriptaHomofona.Size = new System.Drawing.Size(214, 39);
            this.btnDecriptaHomofona.TabIndex = 14;
            this.btnDecriptaHomofona.Text = "Decriptografar";
            this.btnDecriptaHomofona.UseVisualStyleBackColor = true;
            this.btnDecriptaHomofona.Click += new System.EventHandler(this.btnDecriptaHomofona_Click);
            // 
            // tbHomofonaDecriptografada
            // 
            this.tbHomofonaDecriptografada.Location = new System.Drawing.Point(148, 165);
            this.tbHomofonaDecriptografada.Name = "tbHomofonaDecriptografada";
            this.tbHomofonaDecriptografada.Size = new System.Drawing.Size(519, 20);
            this.tbHomofonaDecriptografada.TabIndex = 13;
            // 
            // tbCriptografiaHomofona
            // 
            this.tbCriptografiaHomofona.Location = new System.Drawing.Point(148, 115);
            this.tbCriptografiaHomofona.Name = "tbCriptografiaHomofona";
            this.tbCriptografiaHomofona.Size = new System.Drawing.Size(519, 20);
            this.tbCriptografiaHomofona.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(650, 393);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(422, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "i-------------d-----------";
            this.textBox6.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(650, 367);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(422, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "7---t---------W--C--------";
            this.textBox5.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(650, 341);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(422, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "K-sNq---J--ac-2--TeYh-----";
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(650, 315);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(422, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "z-kmxnBu0--OAv5p-Ryf4g----";
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(650, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(422, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "8FHG3l1LEIwoMX6QPbV9aZSDjr";
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(650, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "abcdefghijklmnopqrstuvwxyz";
            this.textBox1.Visible = false;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(148, 237);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(209, 134);
            this.listBox4.TabIndex = 4;
            // 
            // gerarHomofona
            // 
            this.gerarHomofona.Image = global::Criptografia.Properties.Resources._2683_32x32;
            this.gerarHomofona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gerarHomofona.Location = new System.Drawing.Point(721, 38);
            this.gerarHomofona.Name = "gerarHomofona";
            this.gerarHomofona.Size = new System.Drawing.Size(214, 41);
            this.gerarHomofona.TabIndex = 2;
            this.gerarHomofona.Text = "Gerar Criptografia Homófona";
            this.gerarHomofona.UseVisualStyleBackColor = true;
            this.gerarHomofona.Click += new System.EventHandler(this.gerarHomofona_Click);
            // 
            // tbEntradaHomofona
            // 
            this.tbEntradaHomofona.Location = new System.Drawing.Point(148, 59);
            this.tbEntradaHomofona.MaxLength = 200;
            this.tbEntradaHomofona.Name = "tbEntradaHomofona";
            this.tbEntradaHomofona.Size = new System.Drawing.Size(519, 20);
            this.tbEntradaHomofona.TabIndex = 1;
            this.tbEntradaHomofona.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEntradaHomofona_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btnLimparDados);
            this.tabPage2.Controls.Add(this.btnDecriptaViginere);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbFraseDecriptografada);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbResultadoCriptografia);
            this.tabPage2.Controls.Add(this.tbTextoViginere);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbChaveVigi);
            this.tabPage2.Controls.Add(this.btnGerarViginere);
            this.tabPage2.Controls.Add(this.listBox8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1334, 584);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Cifra Viginere";
            // 
            // btnLimparDados
            // 
            this.btnLimparDados.Image = global::Criptografia.Properties.Resources.ccleaner_114;
            this.btnLimparDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparDados.Location = new System.Drawing.Point(664, 27);
            this.btnLimparDados.Name = "btnLimparDados";
            this.btnLimparDados.Size = new System.Drawing.Size(154, 44);
            this.btnLimparDados.TabIndex = 3;
            this.btnLimparDados.Text = "Limpar Campos";
            this.btnLimparDados.UseVisualStyleBackColor = true;
            this.btnLimparDados.Click += new System.EventHandler(this.btnLimparDados_Click);
            // 
            // btnDecriptaViginere
            // 
            this.btnDecriptaViginere.Image = global::Criptografia.Properties.Resources.setas;
            this.btnDecriptaViginere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecriptaViginere.Location = new System.Drawing.Point(453, 27);
            this.btnDecriptaViginere.Name = "btnDecriptaViginere";
            this.btnDecriptaViginere.Size = new System.Drawing.Size(151, 44);
            this.btnDecriptaViginere.TabIndex = 2;
            this.btnDecriptaViginere.Text = "Decriptografar";
            this.btnDecriptaViginere.UseVisualStyleBackColor = true;
            this.btnDecriptaViginere.Click += new System.EventHandler(this.btnDecriptaViginere_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Frase Decriptografada";
            // 
            // tbFraseDecriptografada
            // 
            this.tbFraseDecriptografada.Location = new System.Drawing.Point(96, 171);
            this.tbFraseDecriptografada.Name = "tbFraseDecriptografada";
            this.tbFraseDecriptografada.Size = new System.Drawing.Size(745, 20);
            this.tbFraseDecriptografada.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cifra:";
            // 
            // tbResultadoCriptografia
            // 
            this.tbResultadoCriptografia.Location = new System.Drawing.Point(96, 118);
            this.tbResultadoCriptografia.Name = "tbResultadoCriptografia";
            this.tbResultadoCriptografia.Size = new System.Drawing.Size(745, 20);
            this.tbResultadoCriptografia.TabIndex = 5;
            // 
            // tbTextoViginere
            // 
            this.tbTextoViginere.Location = new System.Drawing.Point(96, 83);
            this.tbTextoViginere.MaxLength = 200;
            this.tbTextoViginere.Name = "tbTextoViginere";
            this.tbTextoViginere.Size = new System.Drawing.Size(745, 20);
            this.tbTextoViginere.TabIndex = 4;
            this.tbTextoViginere.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTexto_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Frase:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chave:";
            // 
            // tbChaveVigi
            // 
            this.tbChaveVigi.Location = new System.Drawing.Point(96, 40);
            this.tbChaveVigi.MaxLength = 5;
            this.tbChaveVigi.Name = "tbChaveVigi";
            this.tbChaveVigi.Size = new System.Drawing.Size(73, 20);
            this.tbChaveVigi.TabIndex = 0;
            this.tbChaveVigi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbChaveVigi_KeyPress);
            // 
            // btnGerarViginere
            // 
            this.btnGerarViginere.Image = global::Criptografia.Properties.Resources._2683_32x32;
            this.btnGerarViginere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarViginere.Location = new System.Drawing.Point(246, 27);
            this.btnGerarViginere.Name = "btnGerarViginere";
            this.btnGerarViginere.Size = new System.Drawing.Size(161, 44);
            this.btnGerarViginere.TabIndex = 1;
            this.btnGerarViginere.Text = "Gerar Criptografia";
            this.btnGerarViginere.UseVisualStyleBackColor = true;
            this.btnGerarViginere.Click += new System.EventHandler(this.btnGerarViginere_Click);
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.Location = new System.Drawing.Point(96, 211);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(288, 355);
            this.listBox8.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 667);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbChave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbEntradaHomofona;
        private System.Windows.Forms.Button gerarHomofona;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGerarViginere;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbChaveVigi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTextoViginere;
        private System.Windows.Forms.TextBox tbResultadoCriptografia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDecriptaViginere;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFraseDecriptografada;
        private System.Windows.Forms.Button btnLimparDados;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbCriptografiaHomofona;
        private System.Windows.Forms.Button btnDecriptaHomofona;
        private System.Windows.Forms.TextBox tbHomofonaDecriptografada;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLimaHomo;
        private System.Windows.Forms.Label label14;
    }
}

