
namespace CALCULADORA.NET
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnPercentagem = new System.Windows.Forms.Button();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnApagarTudo = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btmUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.btnMaisMenos = new System.Windows.Forms.Button();
            this.btnEuller = new System.Windows.Forms.Button();
            this.btnParentFecha = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnFatorial = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnCosseno = new System.Windows.Forms.Button();
            this.btnTangente = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 52);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(302, 32);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPercentagem
            // 
            this.btnPercentagem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPercentagem.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentagem.Location = new System.Drawing.Point(12, 205);
            this.btnPercentagem.Name = "btnPercentagem";
            this.btnPercentagem.Size = new System.Drawing.Size(71, 47);
            this.btnPercentagem.TabIndex = 1;
            this.btnPercentagem.Tag = "%";
            this.btnPercentagem.Text = "%";
            this.btnPercentagem.UseVisualStyleBackColor = false;
            this.btnPercentagem.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuadrado.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuadrado.Location = new System.Drawing.Point(89, 205);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(71, 47);
            this.btnQuadrado.TabIndex = 2;
            this.btnQuadrado.Tag = "²";
            this.btnQuadrado.Text = "x²";
            this.btnQuadrado.UseVisualStyleBackColor = false;
            this.btnQuadrado.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRaiz.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(166, 205);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(71, 47);
            this.btnRaiz.TabIndex = 3;
            this.btnRaiz.Tag = "√";
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(12, 258);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(71, 47);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "CE";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnApagarTudo
            // 
            this.btnApagarTudo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApagarTudo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarTudo.Location = new System.Drawing.Point(89, 258);
            this.btnApagarTudo.Name = "btnApagarTudo";
            this.btnApagarTudo.Size = new System.Drawing.Size(71, 47);
            this.btnApagarTudo.TabIndex = 6;
            this.btnApagarTudo.Text = "C";
            this.btnApagarTudo.UseVisualStyleBackColor = false;
            this.btnApagarTudo.Click += new System.EventHandler(this.btnApagarTudo_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(166, 258);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(71, 47);
            this.btnDeletar.TabIndex = 7;
            this.btnDeletar.Text = "DEL.";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(243, 257);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(71, 47);
            this.btnDivisao.TabIndex = 8;
            this.btnDivisao.Tag = "÷";
            this.btnDivisao.Text = "÷";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btnSete
            // 
            this.btnSete.BackColor = System.Drawing.Color.Black;
            this.btnSete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.ForeColor = System.Drawing.Color.White;
            this.btnSete.Location = new System.Drawing.Point(12, 311);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(71, 47);
            this.btnSete.TabIndex = 9;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.aplicarNumero);
            // 
            // btnOito
            // 
            this.btnOito.BackColor = System.Drawing.Color.Black;
            this.btnOito.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.ForeColor = System.Drawing.Color.White;
            this.btnOito.Location = new System.Drawing.Point(89, 311);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(71, 47);
            this.btnOito.TabIndex = 10;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.aplicarNumero);
            // 
            // btnNove
            // 
            this.btnNove.BackColor = System.Drawing.Color.Black;
            this.btnNove.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.ForeColor = System.Drawing.Color.White;
            this.btnNove.Location = new System.Drawing.Point(166, 311);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(71, 47);
            this.btnNove.TabIndex = 11;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.aplicarNumero);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.Location = new System.Drawing.Point(245, 311);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(71, 47);
            this.btnMultiplicacao.TabIndex = 12;
            this.btnMultiplicacao.Tag = "×";
            this.btnMultiplicacao.Text = "×";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btnQuatro
            // 
            this.btnQuatro.BackColor = System.Drawing.Color.Black;
            this.btnQuatro.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.ForeColor = System.Drawing.Color.White;
            this.btnQuatro.Location = new System.Drawing.Point(12, 364);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(71, 47);
            this.btnQuatro.TabIndex = 13;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.aplicarNumero);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.Black;
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.Color.White;
            this.btnCinco.Location = new System.Drawing.Point(89, 364);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(71, 47);
            this.btnCinco.TabIndex = 14;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.aplicarNumero);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.Black;
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.Color.White;
            this.btnSeis.Location = new System.Drawing.Point(166, 364);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(71, 47);
            this.btnSeis.TabIndex = 15;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.aplicarNumero);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.Location = new System.Drawing.Point(245, 364);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(71, 47);
            this.btnSubtracao.TabIndex = 16;
            this.btnSubtracao.Tag = "-";
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btmUm
            // 
            this.btmUm.BackColor = System.Drawing.Color.Black;
            this.btmUm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmUm.ForeColor = System.Drawing.Color.White;
            this.btmUm.Location = new System.Drawing.Point(12, 417);
            this.btmUm.Name = "btmUm";
            this.btmUm.Size = new System.Drawing.Size(71, 47);
            this.btmUm.TabIndex = 17;
            this.btmUm.Text = "1";
            this.btmUm.UseVisualStyleBackColor = false;
            this.btmUm.Click += new System.EventHandler(this.aplicarNumero);
            // 
            // btnDois
            // 
            this.btnDois.BackColor = System.Drawing.Color.Black;
            this.btnDois.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.ForeColor = System.Drawing.Color.White;
            this.btnDois.Location = new System.Drawing.Point(89, 417);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(71, 47);
            this.btnDois.TabIndex = 18;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.aplicarNumero);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.Black;
            this.btnTres.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.Color.White;
            this.btnTres.Location = new System.Drawing.Point(166, 419);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(71, 47);
            this.btnTres.TabIndex = 19;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.aplicarNumero);
            // 
            // btnAdicao
            // 
            this.btnAdicao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.Location = new System.Drawing.Point(245, 417);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(71, 47);
            this.btnAdicao.TabIndex = 20;
            this.btnAdicao.Tag = "+";
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = false;
            this.btnAdicao.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(243, 470);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(71, 47);
            this.btnIgual.TabIndex = 24;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonto.Location = new System.Drawing.Point(166, 471);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(71, 47);
            this.btnPonto.TabIndex = 23;
            this.btnPonto.Text = ",";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Black;
            this.button22.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(89, 472);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(71, 47);
            this.button22.TabIndex = 22;
            this.button22.Text = "0";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.aplicarNumero);
            // 
            // btnMaisMenos
            // 
            this.btnMaisMenos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaisMenos.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisMenos.Location = new System.Drawing.Point(12, 472);
            this.btnMaisMenos.Name = "btnMaisMenos";
            this.btnMaisMenos.Size = new System.Drawing.Size(71, 47);
            this.btnMaisMenos.TabIndex = 21;
            this.btnMaisMenos.Text = "±";
            this.btnMaisMenos.UseVisualStyleBackColor = false;
            this.btnMaisMenos.Click += new System.EventHandler(this.btnMaisMenos_Click);
            // 
            // btnEuller
            // 
            this.btnEuller.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEuller.Location = new System.Drawing.Point(245, 204);
            this.btnEuller.Name = "btnEuller";
            this.btnEuller.Size = new System.Drawing.Size(71, 47);
            this.btnEuller.TabIndex = 25;
            this.btnEuller.Tag = "e";
            this.btnEuller.Text = "e";
            this.btnEuller.UseVisualStyleBackColor = true;
            this.btnEuller.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btnParentFecha
            // 
            this.btnParentFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParentFecha.Location = new System.Drawing.Point(245, 152);
            this.btnParentFecha.Name = "btnParentFecha";
            this.btnParentFecha.Size = new System.Drawing.Size(71, 47);
            this.btnParentFecha.TabIndex = 26;
            this.btnParentFecha.Text = "()";
            this.btnParentFecha.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(166, 152);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(71, 47);
            this.btnLog.TabIndex = 27;
            this.btnLog.Tag = "l";
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.Location = new System.Drawing.Point(89, 152);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(71, 47);
            this.btnPi.TabIndex = 28;
            this.btnPi.Tag = "π";
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btnFatorial
            // 
            this.btnFatorial.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFatorial.Location = new System.Drawing.Point(12, 152);
            this.btnFatorial.Name = "btnFatorial";
            this.btnFatorial.Size = new System.Drawing.Size(71, 47);
            this.btnFatorial.TabIndex = 29;
            this.btnFatorial.Tag = "!";
            this.btnFatorial.Text = "!";
            this.btnFatorial.UseVisualStyleBackColor = true;
            this.btnFatorial.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btnSeno
            // 
            this.btnSeno.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeno.Location = new System.Drawing.Point(12, 99);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(71, 47);
            this.btnSeno.TabIndex = 30;
            this.btnSeno.Tag = "s";
            this.btnSeno.Text = "sin";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btnCosseno
            // 
            this.btnCosseno.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosseno.Location = new System.Drawing.Point(89, 99);
            this.btnCosseno.Name = "btnCosseno";
            this.btnCosseno.Size = new System.Drawing.Size(71, 47);
            this.btnCosseno.TabIndex = 31;
            this.btnCosseno.Tag = "c";
            this.btnCosseno.Text = "cos";
            this.btnCosseno.UseVisualStyleBackColor = true;
            this.btnCosseno.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btnTangente
            // 
            this.btnTangente.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangente.Location = new System.Drawing.Point(166, 99);
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.Size = new System.Drawing.Size(71, 47);
            this.btnTangente.TabIndex = 32;
            this.btnTangente.Tag = "t";
            this.btnTangente.Text = "tag";
            this.btnTangente.UseVisualStyleBackColor = true;
            this.btnTangente.Click += new System.EventHandler(this.clicarOperador);
            // 
            // btnModulo
            // 
            this.btnModulo.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulo.Location = new System.Drawing.Point(245, 99);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(71, 47);
            this.btnModulo.TabIndex = 33;
            this.btnModulo.Tag = "m";
            this.btnModulo.Text = "ǀxǀ";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.clicarOperador);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.2317F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.76829F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 32);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(275, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "×";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALCULADORA .NET";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(328, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnTangente);
            this.Controls.Add(this.btnCosseno);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.btnFatorial);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnParentFecha);
            this.Controls.Add(this.btnEuller);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.btnMaisMenos);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btmUm);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnApagarTudo);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnQuadrado);
            this.Controls.Add(this.btnPercentagem);
            this.Controls.Add(this.txtResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA .NET";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnPercentagem;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnApagarTudo;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btmUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button btnMaisMenos;
        private System.Windows.Forms.Button btnEuller;
        private System.Windows.Forms.Button btnParentFecha;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnFatorial;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnCosseno;
        private System.Windows.Forms.Button btnTangente;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

