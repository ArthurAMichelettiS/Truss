namespace Trelicas
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
            this.components = new System.ComponentModel.Container();
            this.pbTela = new System.Windows.Forms.PictureBox();
            this.btnApFixo = new System.Windows.Forms.Button();
            this.btnApMovel = new System.Windows.Forms.Button();
            this.rbMover = new System.Windows.Forms.RadioButton();
            this.rbAdicionar = new System.Windows.Forms.RadioButton();
            this.rbRemov = new System.Windows.Forms.RadioButton();
            this.lblTeste = new System.Windows.Forms.Label();
            this.txtPtoX = new System.Windows.Forms.TextBox();
            this.txtPtoY = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtForca = new System.Windows.Forms.TextBox();
            this.btnForca = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRemvForcas = new System.Windows.Forms.Button();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.btnMoveEsq = new System.Windows.Forms.Button();
            this.btnMoveDir = new System.Windows.Forms.Button();
            this.btnMoveBaixo = new System.Windows.Forms.Button();
            this.btnMoveCima = new System.Windows.Forms.Button();
            this.panelPto = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelForca = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDirec = new System.Windows.Forms.Panel();
            this.tbPassoMov = new System.Windows.Forms.TrackBar();
            this.lblPasso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMovTela = new System.Windows.Forms.RadioButton();
            this.rbMovPonto = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panelLegenda = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTela)).BeginInit();
            this.panelPto.SuspendLayout();
            this.panelForca.SuspendLayout();
            this.panelDirec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassoMov)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelLegenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTela
            // 
            this.pbTela.BackColor = System.Drawing.Color.White;
            this.pbTela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbTela.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbTela.Location = new System.Drawing.Point(212, 24);
            this.pbTela.Name = "pbTela";
            this.pbTela.Size = new System.Drawing.Size(582, 426);
            this.pbTela.TabIndex = 0;
            this.pbTela.TabStop = false;
            this.pbTela.Click += new System.EventHandler(this.pbTela_Click);
            this.pbTela.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbTela_MouseClick);
            // 
            // btnApFixo
            // 
            this.btnApFixo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApFixo.FlatAppearance.BorderSize = 3;
            this.btnApFixo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApFixo.Location = new System.Drawing.Point(212, 473);
            this.btnApFixo.Name = "btnApFixo";
            this.btnApFixo.Size = new System.Drawing.Size(89, 50);
            this.btnApFixo.TabIndex = 1;
            this.btnApFixo.Text = "Apoio Fixo";
            this.btnApFixo.UseVisualStyleBackColor = true;
            this.btnApFixo.Click += new System.EventHandler(this.btnApFixo_Click);
            // 
            // btnApMovel
            // 
            this.btnApMovel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApMovel.FlatAppearance.BorderSize = 3;
            this.btnApMovel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApMovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApMovel.Location = new System.Drawing.Point(705, 470);
            this.btnApMovel.Name = "btnApMovel";
            this.btnApMovel.Size = new System.Drawing.Size(89, 50);
            this.btnApMovel.TabIndex = 2;
            this.btnApMovel.Text = "Apoio Movel";
            this.btnApMovel.UseVisualStyleBackColor = true;
            this.btnApMovel.Click += new System.EventHandler(this.btnApMovel_Click);
            // 
            // rbMover
            // 
            this.rbMover.AutoSize = true;
            this.rbMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMover.Location = new System.Drawing.Point(15, 147);
            this.rbMover.Name = "rbMover";
            this.rbMover.Size = new System.Drawing.Size(96, 22);
            this.rbMover.TabIndex = 3;
            this.rbMover.Text = "Selecionar";
            this.rbMover.UseVisualStyleBackColor = true;
            this.rbMover.CheckedChanged += new System.EventHandler(this.rbMover_CheckedChanged);
            // 
            // rbAdicionar
            // 
            this.rbAdicionar.AutoSize = true;
            this.rbAdicionar.Checked = true;
            this.rbAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdicionar.Location = new System.Drawing.Point(15, 83);
            this.rbAdicionar.Name = "rbAdicionar";
            this.rbAdicionar.Size = new System.Drawing.Size(87, 22);
            this.rbAdicionar.TabIndex = 4;
            this.rbAdicionar.TabStop = true;
            this.rbAdicionar.Text = "Adicionar";
            this.rbAdicionar.UseVisualStyleBackColor = true;
            this.rbAdicionar.CheckedChanged += new System.EventHandler(this.rbAdicionar_CheckedChanged);
            // 
            // rbRemov
            // 
            this.rbRemov.AutoSize = true;
            this.rbRemov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRemov.Location = new System.Drawing.Point(15, 114);
            this.rbRemov.Name = "rbRemov";
            this.rbRemov.Size = new System.Drawing.Size(87, 22);
            this.rbRemov.TabIndex = 5;
            this.rbRemov.Text = "Remover";
            this.rbRemov.UseVisualStyleBackColor = true;
            this.rbRemov.CheckedChanged += new System.EventHandler(this.rbRemov_CheckedChanged);
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeste.Location = new System.Drawing.Point(32, 0);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(135, 24);
            this.lblTeste.TabIndex = 8;
            this.lblTeste.Text = "Coordenadas";
            // 
            // txtPtoX
            // 
            this.txtPtoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtoX.Location = new System.Drawing.Point(3, 68);
            this.txtPtoX.Name = "txtPtoX";
            this.txtPtoX.Size = new System.Drawing.Size(138, 24);
            this.txtPtoX.TabIndex = 9;
            this.txtPtoX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPtoX_KeyDown);
            this.txtPtoX.Leave += new System.EventHandler(this.txtPtoX_Leave);
            // 
            // txtPtoY
            // 
            this.txtPtoY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtoY.Location = new System.Drawing.Point(6, 127);
            this.txtPtoY.Name = "txtPtoY";
            this.txtPtoY.Size = new System.Drawing.Size(135, 24);
            this.txtPtoY.TabIndex = 10;
            this.txtPtoY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPtoY_KeyDown);
            this.txtPtoY.Leave += new System.EventHandler(this.txtPtoY_Leave);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(3, 35);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(52, 20);
            this.lblX.TabIndex = 11;
            this.lblX.Text = "Em X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(3, 98);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(52, 20);
            this.lblY.TabIndex = 12;
            this.lblY.Text = "Em Y:";
            // 
            // txtForca
            // 
            this.txtForca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForca.Location = new System.Drawing.Point(20, 70);
            this.txtForca.Name = "txtForca";
            this.txtForca.Size = new System.Drawing.Size(121, 24);
            this.txtForca.TabIndex = 14;
            // 
            // btnForca
            // 
            this.btnForca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForca.FlatAppearance.BorderSize = 3;
            this.btnForca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForca.Location = new System.Drawing.Point(36, 112);
            this.btnForca.Name = "btnForca";
            this.btnForca.Size = new System.Drawing.Size(105, 38);
            this.btnForca.TabIndex = 15;
            this.btnForca.Text = "Adicionar Força";
            this.btnForca.UseVisualStyleBackColor = true;
            this.btnForca.Click += new System.EventHandler(this.btnForca_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "N";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRemvForcas
            // 
            this.btnRemvForcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemvForcas.FlatAppearance.BorderSize = 3;
            this.btnRemvForcas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemvForcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemvForcas.Location = new System.Drawing.Point(18, 169);
            this.btnRemvForcas.Name = "btnRemvForcas";
            this.btnRemvForcas.Size = new System.Drawing.Size(151, 42);
            this.btnRemvForcas.TabIndex = 17;
            this.btnRemvForcas.Text = "Remover forças no ponto";
            this.btnRemvForcas.UseVisualStyleBackColor = true;
            this.btnRemvForcas.Click += new System.EventHandler(this.btnRemvForcas_Click);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcula.FlatAppearance.BorderSize = 3;
            this.btnCalcula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.Location = new System.Drawing.Point(456, 473);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(104, 47);
            this.btnCalcula.TabIndex = 18;
            this.btnCalcula.Text = "Calcular Forças";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // btnMoveEsq
            // 
            this.btnMoveEsq.BackColor = System.Drawing.Color.Transparent;
            this.btnMoveEsq.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnMoveEsq.FlatAppearance.BorderSize = 0;
            this.btnMoveEsq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveEsq.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveEsq.Location = new System.Drawing.Point(5, 100);
            this.btnMoveEsq.Name = "btnMoveEsq";
            this.btnMoveEsq.Size = new System.Drawing.Size(50, 50);
            this.btnMoveEsq.TabIndex = 19;
            this.btnMoveEsq.Text = "<";
            this.btnMoveEsq.UseVisualStyleBackColor = false;
            this.btnMoveEsq.Click += new System.EventHandler(this.btnMoveEsq_Click);
            // 
            // btnMoveDir
            // 
            this.btnMoveDir.BackColor = System.Drawing.Color.Transparent;
            this.btnMoveDir.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.btnMoveDir.FlatAppearance.BorderSize = 0;
            this.btnMoveDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDir.Location = new System.Drawing.Point(117, 100);
            this.btnMoveDir.Name = "btnMoveDir";
            this.btnMoveDir.Size = new System.Drawing.Size(50, 50);
            this.btnMoveDir.TabIndex = 20;
            this.btnMoveDir.Text = ">";
            this.btnMoveDir.UseVisualStyleBackColor = false;
            this.btnMoveDir.Click += new System.EventHandler(this.btnMoveDir_Click);
            // 
            // btnMoveBaixo
            // 
            this.btnMoveBaixo.BackColor = System.Drawing.Color.Transparent;
            this.btnMoveBaixo.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.btnMoveBaixo.FlatAppearance.BorderSize = 0;
            this.btnMoveBaixo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveBaixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveBaixo.Location = new System.Drawing.Point(61, 148);
            this.btnMoveBaixo.Name = "btnMoveBaixo";
            this.btnMoveBaixo.Size = new System.Drawing.Size(50, 50);
            this.btnMoveBaixo.TabIndex = 21;
            this.btnMoveBaixo.Text = "v";
            this.btnMoveBaixo.UseVisualStyleBackColor = false;
            this.btnMoveBaixo.Click += new System.EventHandler(this.btnMoveBaixo_Click);
            // 
            // btnMoveCima
            // 
            this.btnMoveCima.BackColor = System.Drawing.Color.Transparent;
            this.btnMoveCima.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnMoveCima.FlatAppearance.BorderSize = 0;
            this.btnMoveCima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveCima.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveCima.Location = new System.Drawing.Point(61, 54);
            this.btnMoveCima.Name = "btnMoveCima";
            this.btnMoveCima.Size = new System.Drawing.Size(50, 50);
            this.btnMoveCima.TabIndex = 22;
            this.btnMoveCima.Text = "^";
            this.btnMoveCima.UseVisualStyleBackColor = false;
            this.btnMoveCima.Click += new System.EventHandler(this.btnMoveCima_Click);
            // 
            // panelPto
            // 
            this.panelPto.Controls.Add(this.button2);
            this.panelPto.Controls.Add(this.button1);
            this.panelPto.Controls.Add(this.lblTeste);
            this.panelPto.Controls.Add(this.txtPtoX);
            this.panelPto.Controls.Add(this.txtPtoY);
            this.panelPto.Controls.Add(this.lblX);
            this.panelPto.Controls.Add(this.lblY);
            this.panelPto.Location = new System.Drawing.Point(800, 24);
            this.panelPto.Name = "panelPto";
            this.panelPto.Size = new System.Drawing.Size(184, 167);
            this.panelPto.TabIndex = 23;
            this.panelPto.Visible = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(129, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 24);
            this.button2.TabIndex = 17;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(129, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 24);
            this.button1.TabIndex = 16;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelForca
            // 
            this.panelForca.Controls.Add(this.label1);
            this.panelForca.Controls.Add(this.txtForca);
            this.panelForca.Controls.Add(this.btnForca);
            this.panelForca.Controls.Add(this.label5);
            this.panelForca.Controls.Add(this.btnRemvForcas);
            this.panelForca.Location = new System.Drawing.Point(800, 220);
            this.panelForca.Name = "panelForca";
            this.panelForca.Size = new System.Drawing.Size(184, 231);
            this.panelForca.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Forças";
            // 
            // panelDirec
            // 
            this.panelDirec.Controls.Add(this.tbPassoMov);
            this.panelDirec.Controls.Add(this.lblPasso);
            this.panelDirec.Controls.Add(this.label3);
            this.panelDirec.Controls.Add(this.rbMovTela);
            this.panelDirec.Controls.Add(this.rbMovPonto);
            this.panelDirec.Controls.Add(this.btnMoveBaixo);
            this.panelDirec.Controls.Add(this.btnMoveEsq);
            this.panelDirec.Controls.Add(this.btnMoveDir);
            this.panelDirec.Controls.Add(this.btnMoveCima);
            this.panelDirec.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDirec.Location = new System.Drawing.Point(12, 220);
            this.panelDirec.Name = "panelDirec";
            this.panelDirec.Size = new System.Drawing.Size(173, 278);
            this.panelDirec.TabIndex = 25;
            // 
            // tbPassoMov
            // 
            this.tbPassoMov.BackColor = System.Drawing.Color.Gray;
            this.tbPassoMov.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbPassoMov.Location = new System.Drawing.Point(6, 227);
            this.tbPassoMov.Maximum = 9;
            this.tbPassoMov.Name = "tbPassoMov";
            this.tbPassoMov.Size = new System.Drawing.Size(161, 45);
            this.tbPassoMov.TabIndex = 23;
            this.tbPassoMov.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbPassoMov.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblPasso
            // 
            this.lblPasso.AutoSize = true;
            this.lblPasso.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPasso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasso.Location = new System.Drawing.Point(3, 206);
            this.lblPasso.Name = "lblPasso";
            this.lblPasso.Size = new System.Drawing.Size(88, 18);
            this.lblPasso.TabIndex = 29;
            this.lblPasso.Text = "Passo:  x1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mover";
            // 
            // rbMovTela
            // 
            this.rbMovTela.AutoSize = true;
            this.rbMovTela.Checked = true;
            this.rbMovTela.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbMovTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMovTela.Location = new System.Drawing.Point(98, 29);
            this.rbMovTela.Name = "rbMovTela";
            this.rbMovTela.Size = new System.Drawing.Size(54, 22);
            this.rbMovTela.TabIndex = 28;
            this.rbMovTela.TabStop = true;
            this.rbMovTela.Text = "Tela";
            this.rbMovTela.UseVisualStyleBackColor = true;
            // 
            // rbMovPonto
            // 
            this.rbMovPonto.AutoSize = true;
            this.rbMovPonto.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbMovPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMovPonto.Location = new System.Drawing.Point(19, 29);
            this.rbMovPonto.Name = "rbMovPonto";
            this.rbMovPonto.Size = new System.Drawing.Size(66, 22);
            this.rbMovPonto.TabIndex = 27;
            this.rbMovPonto.Text = "Ponto";
            this.rbMovPonto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbRemov);
            this.groupBox1.Controls.Add(this.rbAdicionar);
            this.groupBox1.Controls.Add(this.rbMover);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 208);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Desenhar Treliça";
            // 
            // btnLimpa
            // 
            this.btnLimpa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpa.FlatAppearance.BorderSize = 3;
            this.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.Location = new System.Drawing.Point(820, 470);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(163, 50);
            this.btnLimpa.TabIndex = 27;
            this.btnLimpa.Text = "Limpar tela";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.button3_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.vScrollBar1.Location = new System.Drawing.Point(772, 368);
            this.vScrollBar1.Maximum = 79;
            this.vScrollBar1.Minimum = 20;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(22, 76);
            this.vScrollBar1.TabIndex = 28;
            this.vScrollBar1.Value = 49;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // panelLegenda
            // 
            this.panelLegenda.Controls.Add(this.label4);
            this.panelLegenda.Controls.Add(this.pictureBox2);
            this.panelLegenda.Controls.Add(this.label6);
            this.panelLegenda.Controls.Add(this.pictureBox1);
            this.panelLegenda.Location = new System.Drawing.Point(221, 378);
            this.panelLegenda.Name = "panelLegenda";
            this.panelLegenda.Size = new System.Drawing.Size(135, 65);
            this.panelLegenda.TabIndex = 29;
            this.panelLegenda.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tração";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox2.Location = new System.Drawing.Point(3, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 26);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Compressão";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 26);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(995, 535);
            this.Controls.Add(this.panelLegenda);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelDirec);
            this.Controls.Add(this.panelForca);
            this.Controls.Add(this.panelPto);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.btnApMovel);
            this.Controls.Add(this.btnApFixo);
            this.Controls.Add(this.pbTela);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treliças";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTela)).EndInit();
            this.panelPto.ResumeLayout(false);
            this.panelPto.PerformLayout();
            this.panelForca.ResumeLayout(false);
            this.panelForca.PerformLayout();
            this.panelDirec.ResumeLayout(false);
            this.panelDirec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassoMov)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelLegenda.ResumeLayout(false);
            this.panelLegenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTela;
        private System.Windows.Forms.Button btnApFixo;
        private System.Windows.Forms.Button btnApMovel;
        private System.Windows.Forms.RadioButton rbMover;
        private System.Windows.Forms.RadioButton rbAdicionar;
        private System.Windows.Forms.RadioButton rbRemov;
        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.TextBox txtPtoX;
        private System.Windows.Forms.TextBox txtPtoY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtForca;
        private System.Windows.Forms.Button btnForca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRemvForcas;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Button btnMoveEsq;
        private System.Windows.Forms.Button btnMoveDir;
        private System.Windows.Forms.Button btnMoveBaixo;
        private System.Windows.Forms.Button btnMoveCima;
        private System.Windows.Forms.Panel panelPto;
        private System.Windows.Forms.Panel panelForca;
        private System.Windows.Forms.Panel panelDirec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar tbPassoMov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMovTela;
        private System.Windows.Forms.RadioButton rbMovPonto;
        private System.Windows.Forms.Label lblPasso;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panelLegenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

