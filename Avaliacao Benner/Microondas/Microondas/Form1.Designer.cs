namespace Microondas
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
            this.lbAlimento = new System.Windows.Forms.Label();
            this.tbAlimento = new System.Windows.Forms.TextBox();
            this.nboxPotencia = new System.Windows.Forms.NumericUpDown();
            this.lbPotencia = new System.Windows.Forms.Label();
            this.lbTempo = new System.Windows.Forms.Label();
            this.tbTempo = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnInicioRapido = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.RichTextBox();
            this.lbErros = new System.Windows.Forms.Label();
            this.cbProgAquec = new System.Windows.Forms.ComboBox();
            this.lbProgramas = new System.Windows.Forms.Label();
            this.tbCompatibilidade = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.lbCompat = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbProgAquecSelec = new System.Windows.Forms.RichTextBox();
            this.btnAquecerProg = new System.Windows.Forms.Button();
            this.btnAddProg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nboxPotencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAlimento
            // 
            this.lbAlimento.AutoSize = true;
            this.lbAlimento.Location = new System.Drawing.Point(9, 27);
            this.lbAlimento.Name = "lbAlimento";
            this.lbAlimento.Size = new System.Drawing.Size(47, 13);
            this.lbAlimento.TabIndex = 0;
            this.lbAlimento.Text = "Alimento";
            // 
            // tbAlimento
            // 
            this.tbAlimento.Location = new System.Drawing.Point(12, 43);
            this.tbAlimento.Name = "tbAlimento";
            this.tbAlimento.Size = new System.Drawing.Size(150, 20);
            this.tbAlimento.TabIndex = 1;
            // 
            // nboxPotencia
            // 
            this.nboxPotencia.Location = new System.Drawing.Point(691, 28);
            this.nboxPotencia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nboxPotencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nboxPotencia.Name = "nboxPotencia";
            this.nboxPotencia.ReadOnly = true;
            this.nboxPotencia.Size = new System.Drawing.Size(94, 20);
            this.nboxPotencia.TabIndex = 2;
            this.nboxPotencia.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nboxPotencia.ValueChanged += new System.EventHandler(this.nboxPotencia_ValueChanged);
            // 
            // lbPotencia
            // 
            this.lbPotencia.AutoSize = true;
            this.lbPotencia.Location = new System.Drawing.Point(691, 12);
            this.lbPotencia.Name = "lbPotencia";
            this.lbPotencia.Size = new System.Drawing.Size(49, 13);
            this.lbPotencia.TabIndex = 4;
            this.lbPotencia.Text = "Potência";
            this.lbPotencia.Click += new System.EventHandler(this.lbPotencia_Click);
            // 
            // lbTempo
            // 
            this.lbTempo.AutoSize = true;
            this.lbTempo.Location = new System.Drawing.Point(691, 51);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(40, 13);
            this.lbTempo.TabIndex = 5;
            this.lbTempo.Text = "Tempo";
            // 
            // tbTempo
            // 
            this.tbTempo.Location = new System.Drawing.Point(691, 67);
            this.tbTempo.Name = "tbTempo";
            this.tbTempo.Size = new System.Drawing.Size(94, 20);
            this.tbTempo.TabIndex = 6;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(676, 248);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(118, 36);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(12, 70);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(55, 13);
            this.lbResultado.TabIndex = 8;
            this.lbResultado.Text = "Resultado";
            // 
            // btnInicioRapido
            // 
            this.btnInicioRapido.Location = new System.Drawing.Point(676, 219);
            this.btnInicioRapido.Name = "btnInicioRapido";
            this.btnInicioRapido.Size = new System.Drawing.Size(118, 23);
            this.btnInicioRapido.TabIndex = 10;
            this.btnInicioRapido.Text = "Início Rápido";
            this.btnInicioRapido.UseVisualStyleBackColor = true;
            this.btnInicioRapido.Click += new System.EventHandler(this.btnInicioRapido_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(12, 87);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(240, 98);
            this.tbResultado.TabIndex = 11;
            this.tbResultado.Text = "";
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.Location = new System.Drawing.Point(9, 191);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 13);
            this.lbErros.TabIndex = 12;
            // 
            // cbProgAquec
            // 
            this.cbProgAquec.FormattingEnabled = true;
            this.cbProgAquec.Location = new System.Drawing.Point(307, 28);
            this.cbProgAquec.Name = "cbProgAquec";
            this.cbProgAquec.Size = new System.Drawing.Size(234, 21);
            this.cbProgAquec.TabIndex = 13;
            this.cbProgAquec.SelectedIndexChanged += new System.EventHandler(this.cbProgAquec_SelectedIndexChanged);
            // 
            // lbProgramas
            // 
            this.lbProgramas.AutoSize = true;
            this.lbProgramas.Location = new System.Drawing.Point(307, 9);
            this.lbProgramas.Name = "lbProgramas";
            this.lbProgramas.Size = new System.Drawing.Size(137, 13);
            this.lbProgramas.TabIndex = 14;
            this.lbProgramas.Text = "Programas de Aquecimento";
            // 
            // tbCompatibilidade
            // 
            this.tbCompatibilidade.Location = new System.Drawing.Point(307, 67);
            this.tbCompatibilidade.Name = "tbCompatibilidade";
            this.tbCompatibilidade.Size = new System.Drawing.Size(160, 20);
            this.tbCompatibilidade.TabIndex = 15;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(473, 57);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(89, 38);
            this.btnBusca.TabIndex = 16;
            this.btnBusca.Text = "Buscar compatibilidade";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // lbCompat
            // 
            this.lbCompat.AutoSize = true;
            this.lbCompat.Location = new System.Drawing.Point(307, 51);
            this.lbCompat.Name = "lbCompat";
            this.lbCompat.Size = new System.Drawing.Size(96, 13);
            this.lbCompat.TabIndex = 17;
            this.lbCompat.Text = "Digite um alimento:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(548, 28);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(49, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbProgAquecSelec
            // 
            this.tbProgAquecSelec.Location = new System.Drawing.Point(307, 101);
            this.tbProgAquecSelec.Name = "tbProgAquecSelec";
            this.tbProgAquecSelec.ReadOnly = true;
            this.tbProgAquecSelec.Size = new System.Drawing.Size(255, 141);
            this.tbProgAquecSelec.TabIndex = 19;
            this.tbProgAquecSelec.Text = "";
            this.tbProgAquecSelec.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnAquecerProg
            // 
            this.btnAquecerProg.Location = new System.Drawing.Point(487, 248);
            this.btnAquecerProg.Name = "btnAquecerProg";
            this.btnAquecerProg.Size = new System.Drawing.Size(75, 23);
            this.btnAquecerProg.TabIndex = 20;
            this.btnAquecerProg.Text = "Ativar";
            this.btnAquecerProg.UseVisualStyleBackColor = true;
            this.btnAquecerProg.Click += new System.EventHandler(this.btnAquecerProg_Click);
            // 
            // btnAddProg
            // 
            this.btnAddProg.Location = new System.Drawing.Point(603, 28);
            this.btnAddProg.Name = "btnAddProg";
            this.btnAddProg.Size = new System.Drawing.Size(46, 23);
            this.btnAddProg.TabIndex = 21;
            this.btnAddProg.Text = "Novo";
            this.btnAddProg.UseVisualStyleBackColor = true;
            this.btnAddProg.Click += new System.EventHandler(this.btnAddProg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tempo Restante:";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Location = new System.Drawing.Point(742, 104);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(28, 13);
            this.lbTimer.TabIndex = 23;
            this.lbTimer.Text = "0:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 287);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddProg);
            this.Controls.Add(this.btnAquecerProg);
            this.Controls.Add(this.tbProgAquecSelec);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbCompat);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.tbCompatibilidade);
            this.Controls.Add(this.lbProgramas);
            this.Controls.Add(this.cbProgAquec);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btnInicioRapido);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.tbTempo);
            this.Controls.Add(this.lbTempo);
            this.Controls.Add(this.lbPotencia);
            this.Controls.Add(this.nboxPotencia);
            this.Controls.Add(this.tbAlimento);
            this.Controls.Add(this.lbAlimento);
            this.Name = "Form1";
            this.Text = "Microondas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nboxPotencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAlimento;
        private System.Windows.Forms.TextBox tbAlimento;
        private System.Windows.Forms.NumericUpDown nboxPotencia;
        private System.Windows.Forms.Label lbPotencia;
        private System.Windows.Forms.Label lbTempo;
        private System.Windows.Forms.TextBox tbTempo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnInicioRapido;
        private System.Windows.Forms.RichTextBox tbResultado;
        private System.Windows.Forms.Label lbErros;
        private System.Windows.Forms.ComboBox cbProgAquec;
        private System.Windows.Forms.Label lbProgramas;
        private System.Windows.Forms.TextBox tbCompatibilidade;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label lbCompat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RichTextBox tbProgAquecSelec;
        private System.Windows.Forms.Button btnAquecerProg;
        private System.Windows.Forms.Button btnAddProg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTimer;
    }
}

