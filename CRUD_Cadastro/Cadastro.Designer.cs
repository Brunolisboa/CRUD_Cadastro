namespace CRUD_Cadastro {
    partial class Cadastro {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.btnLimparUsuario = new System.Windows.Forms.Button();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.gridUsuario = new System.Windows.Forms.DataGridView();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.cbxPerfil = new System.Windows.Forms.ComboBox();
            this.labelPerfil = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.tabPerfil = new System.Windows.Forms.TabPage();
            this.btnLimparPerfil = new System.Windows.Forms.Button();
            this.cbxFuncionalidade = new System.Windows.Forms.ComboBox();
            this.funcionalidadeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroDataSet1 = new CRUD_Cadastro.UI.CadastroDataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.gridPerfil = new System.Windows.Forms.DataGridView();
            this.btnDeletarPerfil = new System.Windows.Forms.Button();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.btnInserirPerfil = new System.Windows.Forms.Button();
            this.labelFuncionalidade = new System.Windows.Forms.Label();
            this.txbPerfil = new System.Windows.Forms.TextBox();
            this.labelPerffil = new System.Windows.Forms.Label();
            this.tabFuncionalidade = new System.Windows.Forms.TabPage();
            this.btnLimparFuncionalidade = new System.Windows.Forms.Button();
            this.txbcampo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridFuncionalidade = new System.Windows.Forms.DataGridView();
            this.btnDeletarfuncionalidade = new System.Windows.Forms.Button();
            this.btnEditarfuncionalidade = new System.Windows.Forms.Button();
            this.btnInserirfuncionalidade = new System.Windows.Forms.Button();
            this.labelCampo = new System.Windows.Forms.Label();
            this.txbFunci = new System.Windows.Forms.TextBox();
            this.labelFuncionalidadeFunci = new System.Windows.Forms.Label();
            this.cadastroDataSet = new CRUD_Cadastro.UI.CadastroDataSet();
            this.funcionalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionalidadeTableAdapter = new CRUD_Cadastro.UI.CadastroDataSetTableAdapters.FuncionalidadeTableAdapter();
            this.funcionalidadeTableAdapter1 = new CRUD_Cadastro.UI.CadastroDataSet1TableAdapters.FuncionalidadeTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).BeginInit();
            this.tabPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerfil)).BeginInit();
            this.tabFuncionalidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionalidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUsuario);
            this.tabControl1.Controls.Add(this.tabPerfil);
            this.tabControl1.Controls.Add(this.tabFuncionalidade);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 468);
            this.tabControl1.TabIndex = 1;
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.btnLimparUsuario);
            this.tabUsuario.Controls.Add(this.labelMensagem);
            this.tabUsuario.Controls.Add(this.gridUsuario);
            this.tabUsuario.Controls.Add(this.btnDeletar);
            this.tabUsuario.Controls.Add(this.btnEditar);
            this.tabUsuario.Controls.Add(this.btnInserir);
            this.tabUsuario.Controls.Add(this.cbxPerfil);
            this.tabUsuario.Controls.Add(this.labelPerfil);
            this.tabUsuario.Controls.Add(this.txbSenha);
            this.tabUsuario.Controls.Add(this.labelSenha);
            this.tabUsuario.Controls.Add(this.txbEmail);
            this.tabUsuario.Controls.Add(this.labelEmail);
            this.tabUsuario.Controls.Add(this.txbLogin);
            this.tabUsuario.Controls.Add(this.labelLogin);
            this.tabUsuario.Controls.Add(this.txbNome);
            this.tabUsuario.Controls.Add(this.labelNome);
            this.tabUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(501, 442);
            this.tabUsuario.TabIndex = 0;
            this.tabUsuario.Text = "Usuário";
            this.tabUsuario.UseVisualStyleBackColor = true;
            this.tabUsuario.Click += new System.EventHandler(this.TabUsuario_Click);
            // 
            // btnLimparUsuario
            // 
            this.btnLimparUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparUsuario.Location = new System.Drawing.Point(311, 220);
            this.btnLimparUsuario.Name = "btnLimparUsuario";
            this.btnLimparUsuario.Size = new System.Drawing.Size(76, 29);
            this.btnLimparUsuario.TabIndex = 74;
            this.btnLimparUsuario.Text = "Limpar";
            this.btnLimparUsuario.UseVisualStyleBackColor = false;
            this.btnLimparUsuario.Click += new System.EventHandler(this.btnLimparUsuario_Click);
            // 
            // labelMensagem
            // 
            this.labelMensagem.AutoSize = true;
            this.labelMensagem.Location = new System.Drawing.Point(422, 157);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(0, 13);
            this.labelMensagem.TabIndex = 35;
            // 
            // gridUsuario
            // 
            this.gridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuario.Location = new System.Drawing.Point(20, 266);
            this.gridUsuario.Name = "gridUsuario";
            this.gridUsuario.Size = new System.Drawing.Size(460, 155);
            this.gridUsuario.TabIndex = 34;
            this.gridUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsuario_CellContentClick);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeletar.Location = new System.Drawing.Point(121, 220);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(76, 29);
            this.btnDeletar.TabIndex = 33;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Location = new System.Drawing.Point(216, 220);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 29);
            this.btnEditar.TabIndex = 32;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInserir.Location = new System.Drawing.Point(404, 220);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(76, 29);
            this.btnInserir.TabIndex = 31;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // cbxPerfil
            // 
            this.cbxPerfil.FormattingEnabled = true;
            this.cbxPerfil.Location = new System.Drawing.Point(70, 177);
            this.cbxPerfil.Name = "cbxPerfil";
            this.cbxPerfil.Size = new System.Drawing.Size(410, 21);
            this.cbxPerfil.TabIndex = 29;
            this.cbxPerfil.Text = "Selecione um Perfil";
            // 
            // labelPerfil
            // 
            this.labelPerfil.AutoSize = true;
            this.labelPerfil.Location = new System.Drawing.Point(20, 180);
            this.labelPerfil.Name = "labelPerfil";
            this.labelPerfil.Size = new System.Drawing.Size(37, 13);
            this.labelPerfil.TabIndex = 28;
            this.labelPerfil.Text = "Perfil:*";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(70, 137);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(410, 20);
            this.txbSenha.TabIndex = 27;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(20, 140);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(45, 13);
            this.labelSenha.TabIndex = 26;
            this.labelSenha.Text = "Senha:*";
            this.labelSenha.Click += new System.EventHandler(this.labelSenha_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(70, 57);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(410, 20);
            this.txbEmail.TabIndex = 25;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(20, 60);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 13);
            this.labelEmail.TabIndex = 24;
            this.labelEmail.Text = "E-mail:*";
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(70, 97);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(410, 20);
            this.txbLogin.TabIndex = 23;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(20, 100);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(40, 13);
            this.labelLogin.TabIndex = 22;
            this.labelLogin.Text = "Login:*";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(70, 17);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(410, 20);
            this.txbNome.TabIndex = 21;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(20, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(42, 13);
            this.labelNome.TabIndex = 20;
            this.labelNome.Text = "Nome:*";
            // 
            // tabPerfil
            // 
            this.tabPerfil.Controls.Add(this.btnLimparPerfil);
            this.tabPerfil.Controls.Add(this.cbxFuncionalidade);
            this.tabPerfil.Controls.Add(this.label5);
            this.tabPerfil.Controls.Add(this.gridPerfil);
            this.tabPerfil.Controls.Add(this.btnDeletarPerfil);
            this.tabPerfil.Controls.Add(this.btnEditarPerfil);
            this.tabPerfil.Controls.Add(this.btnInserirPerfil);
            this.tabPerfil.Controls.Add(this.labelFuncionalidade);
            this.tabPerfil.Controls.Add(this.txbPerfil);
            this.tabPerfil.Controls.Add(this.labelPerffil);
            this.tabPerfil.Location = new System.Drawing.Point(4, 22);
            this.tabPerfil.Name = "tabPerfil";
            this.tabPerfil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerfil.Size = new System.Drawing.Size(501, 442);
            this.tabPerfil.TabIndex = 1;
            this.tabPerfil.Text = "Perfil";
            this.tabPerfil.UseVisualStyleBackColor = true;
            this.tabPerfil.Click += new System.EventHandler(this.TabPerfil_Click);
            // 
            // btnLimparPerfil
            // 
            this.btnLimparPerfil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparPerfil.Location = new System.Drawing.Point(307, 98);
            this.btnLimparPerfil.Name = "btnLimparPerfil";
            this.btnLimparPerfil.Size = new System.Drawing.Size(76, 29);
            this.btnLimparPerfil.TabIndex = 74;
            this.btnLimparPerfil.Text = "Limpar";
            this.btnLimparPerfil.UseVisualStyleBackColor = false;
            this.btnLimparPerfil.Click += new System.EventHandler(this.btnLimparPerfil_Click);
            // 
            // cbxFuncionalidade
            // 
            this.cbxFuncionalidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxFuncionalidade.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.funcionalidadeBindingSource1, "Funcionalidade", true));
            this.cbxFuncionalidade.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionalidadeBindingSource1, "Id_Funcionalidade", true));
            this.cbxFuncionalidade.FormattingEnabled = true;
            this.cbxFuncionalidade.Location = new System.Drawing.Point(116, 57);
            this.cbxFuncionalidade.Name = "cbxFuncionalidade";
            this.cbxFuncionalidade.Size = new System.Drawing.Size(362, 21);
            this.cbxFuncionalidade.TabIndex = 60;
            this.cbxFuncionalidade.Text = "Selecione uma Funcionalidade";
            // 
            // funcionalidadeBindingSource1
            // 
            this.funcionalidadeBindingSource1.DataMember = "Funcionalidade";
            this.funcionalidadeBindingSource1.DataSource = this.cadastroDataSet1;
            // 
            // cadastroDataSet1
            // 
            this.cadastroDataSet1.DataSetName = "CadastroDataSet1";
            this.cadastroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 59;
            // 
            // gridPerfil
            // 
            this.gridPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPerfil.Location = new System.Drawing.Point(20, 146);
            this.gridPerfil.Name = "gridPerfil";
            this.gridPerfil.Size = new System.Drawing.Size(460, 155);
            this.gridPerfil.TabIndex = 58;
            this.gridPerfil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPerfil_CellContentClick);
            // 
            // btnDeletarPerfil
            // 
            this.btnDeletarPerfil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeletarPerfil.Location = new System.Drawing.Point(120, 98);
            this.btnDeletarPerfil.Name = "btnDeletarPerfil";
            this.btnDeletarPerfil.Size = new System.Drawing.Size(76, 29);
            this.btnDeletarPerfil.TabIndex = 57;
            this.btnDeletarPerfil.Text = "Deletar";
            this.btnDeletarPerfil.UseVisualStyleBackColor = false;
            this.btnDeletarPerfil.Click += new System.EventHandler(this.btnDeletarPerfil_Click);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditarPerfil.Location = new System.Drawing.Point(213, 98);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(76, 29);
            this.btnEditarPerfil.TabIndex = 56;
            this.btnEditarPerfil.Text = "Editar";
            this.btnEditarPerfil.UseVisualStyleBackColor = false;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // btnInserirPerfil
            // 
            this.btnInserirPerfil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInserirPerfil.Location = new System.Drawing.Point(402, 98);
            this.btnInserirPerfil.Name = "btnInserirPerfil";
            this.btnInserirPerfil.Size = new System.Drawing.Size(76, 29);
            this.btnInserirPerfil.TabIndex = 55;
            this.btnInserirPerfil.Text = "Inserir";
            this.btnInserirPerfil.UseVisualStyleBackColor = false;
            this.btnInserirPerfil.Click += new System.EventHandler(this.btnInserirPerfil_Click);
            // 
            // labelFuncionalidade
            // 
            this.labelFuncionalidade.AutoSize = true;
            this.labelFuncionalidade.Location = new System.Drawing.Point(20, 60);
            this.labelFuncionalidade.Name = "labelFuncionalidade";
            this.labelFuncionalidade.Size = new System.Drawing.Size(86, 13);
            this.labelFuncionalidade.TabIndex = 48;
            this.labelFuncionalidade.Text = "Funcionalidade:*";
            // 
            // txbPerfil
            // 
            this.txbPerfil.Location = new System.Drawing.Point(68, 17);
            this.txbPerfil.Name = "txbPerfil";
            this.txbPerfil.Size = new System.Drawing.Size(410, 20);
            this.txbPerfil.TabIndex = 45;
            // 
            // labelPerffil
            // 
            this.labelPerffil.AutoSize = true;
            this.labelPerffil.Location = new System.Drawing.Point(20, 20);
            this.labelPerffil.Name = "labelPerffil";
            this.labelPerffil.Size = new System.Drawing.Size(37, 13);
            this.labelPerffil.TabIndex = 44;
            this.labelPerffil.Text = "Perfil:*";
            // 
            // tabFuncionalidade
            // 
            this.tabFuncionalidade.Controls.Add(this.btnLimparFuncionalidade);
            this.tabFuncionalidade.Controls.Add(this.txbcampo);
            this.tabFuncionalidade.Controls.Add(this.label1);
            this.tabFuncionalidade.Controls.Add(this.gridFuncionalidade);
            this.tabFuncionalidade.Controls.Add(this.btnDeletarfuncionalidade);
            this.tabFuncionalidade.Controls.Add(this.btnEditarfuncionalidade);
            this.tabFuncionalidade.Controls.Add(this.btnInserirfuncionalidade);
            this.tabFuncionalidade.Controls.Add(this.labelCampo);
            this.tabFuncionalidade.Controls.Add(this.txbFunci);
            this.tabFuncionalidade.Controls.Add(this.labelFuncionalidadeFunci);
            this.tabFuncionalidade.Location = new System.Drawing.Point(4, 22);
            this.tabFuncionalidade.Name = "tabFuncionalidade";
            this.tabFuncionalidade.Padding = new System.Windows.Forms.Padding(3);
            this.tabFuncionalidade.Size = new System.Drawing.Size(501, 442);
            this.tabFuncionalidade.TabIndex = 2;
            this.tabFuncionalidade.Text = "Funcionalidade";
            this.tabFuncionalidade.UseVisualStyleBackColor = true;
            // 
            // btnLimparFuncionalidade
            // 
            this.btnLimparFuncionalidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparFuncionalidade.Location = new System.Drawing.Point(307, 98);
            this.btnLimparFuncionalidade.Name = "btnLimparFuncionalidade";
            this.btnLimparFuncionalidade.Size = new System.Drawing.Size(76, 29);
            this.btnLimparFuncionalidade.TabIndex = 73;
            this.btnLimparFuncionalidade.Text = "Limpar";
            this.btnLimparFuncionalidade.UseVisualStyleBackColor = false;
            this.btnLimparFuncionalidade.Click += new System.EventHandler(this.btnLimparFuncionalidade_Click);
            // 
            // txbcampo
            // 
            this.txbcampo.Location = new System.Drawing.Point(76, 57);
            this.txbcampo.Name = "txbcampo";
            this.txbcampo.Size = new System.Drawing.Size(404, 20);
            this.txbcampo.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 71;
            // 
            // gridFuncionalidade
            // 
            this.gridFuncionalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncionalidade.Location = new System.Drawing.Point(20, 146);
            this.gridFuncionalidade.Name = "gridFuncionalidade";
            this.gridFuncionalidade.Size = new System.Drawing.Size(460, 155);
            this.gridFuncionalidade.TabIndex = 70;
            this.gridFuncionalidade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFuncionalidade_CellContentClick);
            // 
            // btnDeletarfuncionalidade
            // 
            this.btnDeletarfuncionalidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeletarfuncionalidade.Location = new System.Drawing.Point(118, 98);
            this.btnDeletarfuncionalidade.Name = "btnDeletarfuncionalidade";
            this.btnDeletarfuncionalidade.Size = new System.Drawing.Size(76, 29);
            this.btnDeletarfuncionalidade.TabIndex = 69;
            this.btnDeletarfuncionalidade.Text = "Deletar";
            this.btnDeletarfuncionalidade.UseVisualStyleBackColor = false;
            this.btnDeletarfuncionalidade.Click += new System.EventHandler(this.btnDeletarfuncionalidade_Click);
            // 
            // btnEditarfuncionalidade
            // 
            this.btnEditarfuncionalidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditarfuncionalidade.Location = new System.Drawing.Point(212, 98);
            this.btnEditarfuncionalidade.Name = "btnEditarfuncionalidade";
            this.btnEditarfuncionalidade.Size = new System.Drawing.Size(76, 29);
            this.btnEditarfuncionalidade.TabIndex = 68;
            this.btnEditarfuncionalidade.Text = "Editar";
            this.btnEditarfuncionalidade.UseVisualStyleBackColor = false;
            this.btnEditarfuncionalidade.Click += new System.EventHandler(this.btnEditarfuncionalidade_Click);
            // 
            // btnInserirfuncionalidade
            // 
            this.btnInserirfuncionalidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInserirfuncionalidade.Location = new System.Drawing.Point(403, 98);
            this.btnInserirfuncionalidade.Name = "btnInserirfuncionalidade";
            this.btnInserirfuncionalidade.Size = new System.Drawing.Size(76, 29);
            this.btnInserirfuncionalidade.TabIndex = 67;
            this.btnInserirfuncionalidade.Text = "Inserir";
            this.btnInserirfuncionalidade.UseVisualStyleBackColor = false;
            this.btnInserirfuncionalidade.Click += new System.EventHandler(this.btnInserirfuncionalidade_Click);
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(20, 60);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(50, 13);
            this.labelCampo.TabIndex = 65;
            this.labelCampo.Text = "Campo: *";
            // 
            // txbFunci
            // 
            this.txbFunci.Location = new System.Drawing.Point(115, 17);
            this.txbFunci.Name = "txbFunci";
            this.txbFunci.Size = new System.Drawing.Size(365, 20);
            this.txbFunci.TabIndex = 64;
            // 
            // labelFuncionalidadeFunci
            // 
            this.labelFuncionalidadeFunci.AutoSize = true;
            this.labelFuncionalidadeFunci.Location = new System.Drawing.Point(20, 20);
            this.labelFuncionalidadeFunci.Name = "labelFuncionalidadeFunci";
            this.labelFuncionalidadeFunci.Size = new System.Drawing.Size(89, 13);
            this.labelFuncionalidadeFunci.TabIndex = 63;
            this.labelFuncionalidadeFunci.Text = "Funcionalidade: *";
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionalidadeBindingSource
            // 
            this.funcionalidadeBindingSource.DataMember = "Funcionalidade";
            this.funcionalidadeBindingSource.DataSource = this.cadastroDataSet;
            // 
            // funcionalidadeTableAdapter
            // 
            this.funcionalidadeTableAdapter.ClearBeforeFill = true;
            // 
            // funcionalidadeTableAdapter1
            // 
            this.funcionalidadeTableAdapter1.ClearBeforeFill = true;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 465);
            this.Controls.Add(this.tabControl1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabUsuario.ResumeLayout(false);
            this.tabUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).EndInit();
            this.tabPerfil.ResumeLayout(false);
            this.tabPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerfil)).EndInit();
            this.tabFuncionalidade.ResumeLayout(false);
            this.tabFuncionalidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionalidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.TabPage tabPerfil;
        private System.Windows.Forms.TabPage tabFuncionalidade;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.DataGridView gridUsuario;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ComboBox cbxPerfil;
        private System.Windows.Forms.Label labelPerfil;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridPerfil;
        private System.Windows.Forms.Button btnDeletarPerfil;
        private System.Windows.Forms.Button btnEditarPerfil;
        private System.Windows.Forms.Button btnInserirPerfil;
        private System.Windows.Forms.Label labelFuncionalidade;
        private System.Windows.Forms.TextBox txbPerfil;
        private System.Windows.Forms.Label labelPerffil;
        private System.Windows.Forms.ComboBox cbxFuncionalidade;
        private System.Windows.Forms.TextBox txbcampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridFuncionalidade;
        private System.Windows.Forms.Button btnDeletarfuncionalidade;
        private System.Windows.Forms.Button btnEditarfuncionalidade;
        private System.Windows.Forms.Button btnInserirfuncionalidade;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.TextBox txbFunci;
        private System.Windows.Forms.Label labelFuncionalidadeFunci;
        private System.Windows.Forms.Button btnLimparUsuario;
        private System.Windows.Forms.Button btnLimparPerfil;
        private System.Windows.Forms.Button btnLimparFuncionalidade;
        private UI.CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource funcionalidadeBindingSource;
        private UI.CadastroDataSetTableAdapters.FuncionalidadeTableAdapter funcionalidadeTableAdapter;
        private UI.CadastroDataSet1 cadastroDataSet1;
        private System.Windows.Forms.BindingSource funcionalidadeBindingSource1;
        private UI.CadastroDataSet1TableAdapters.FuncionalidadeTableAdapter funcionalidadeTableAdapter1;
    }
}

