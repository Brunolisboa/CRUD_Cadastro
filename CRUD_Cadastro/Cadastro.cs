using CRUD_Cadastro.BLL;
using CRUD_Cadastro.DTO;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_Cadastro
{
    public partial class Cadastro : Form 
    {
        public string modo = "";
        int codUsuarioSelecionado = -1;
        int codPerfilSelecionado = -1;
        int codFunciSelecionado = -1;

        public Cadastro() 
        {
            InitializeComponent();
        }
        private void Cadastro_Load(object sender, EventArgs e) 
        {
            this.funcionalidadeTableAdapter1.Fill(this.cadastroDataSet1.Funcionalidade);
            // TODO: This line of code loads data into the 'cadastroDataSet.Funcionalidade' table. You can move, or remove it, as needed.
            this.funcionalidadeTableAdapter.Fill(this.cadastroDataSet.Funcionalidade);

            carregaGridFuncionalidade();
            carregaGridPerfil();
            carregaGridUsuario();
            PreencherComboBoxUsuario();
        }
        private void limpar_camposFuncionalidade()
        {
            txbFunci.Text = "";
            txbcampo.Text = "";
            codFunciSelecionado = -1;
        }
        private void limpar_camposPerfil()
        {
            txbPerfil.Text = "";
            codPerfilSelecionado = -1;
        }
        private void limpar_camposUsuario()
        {
            txbNome.Text = "";
            txbEmail.Text = "";
            txbLogin.Text = "";
            txbSenha.Text = "";
            codUsuarioSelecionado = -1;
        }
        private void PreencherComboBoxPerfil()
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();//Define a conexão com o Banco de Dados
                sqlCon.ConnectionString = UI.Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand("SELECT * FROM Funcionalidade ORDER BY Funcionalidade ASC");//Cria um objeto para para executar o comando SQL
                CM.Connection = sqlCon;
                sqlCon.Open(); //Abre a conexão com o Banco de Daddos
                SqlDataReader DR;
                DataTable DT = new DataTable(); //Cria uma tabela genérica 
                DR = CM.ExecuteReader();
                DT.Columns.Add("Id_Funcionalidade", typeof(string));
                DT.Columns.Add("Funcionalidade", typeof(string));
                DT.Load(DR);//Carrega os dados para a Data Table
                cbxFuncionalidade.ValueMember = "Id_Funcionalidade";//Define qual coluna será manipulada via código
                cbxFuncionalidade.DisplayMember = "Funcionalidade";//Define qual coluna será exibida 
                cbxFuncionalidade.DataSource = DT;//Define a fonte de onde os dados vem       
                sqlCon.Close();//Fecha a conexão com o Banco de Dados
                cbxFuncionalidade.Text = "Selecione uma Funcionalidade";//Texto inicial da combobox
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }
        private void PreencherComboBoxUsuario()
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();//Define a conexão com o Banco de Dados
                sqlCon.ConnectionString = UI.Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand("SELECT * FROM Perfil ORDER BY Perfil ASC");//Cria um objeto para para executar o comando SQL
                CM.Connection = sqlCon;
                sqlCon.Open(); //Abre a conexão com o Banco de Daddos
                SqlDataReader DR;
                DataTable DT = new DataTable(); //Cria uma tabela genérica 
                DR = CM.ExecuteReader();
                DT.Columns.Add("Id_Perfil", typeof(string));
                DT.Columns.Add("Perfil", typeof(string));
                DT.Load(DR);//Carrega os dados para a Data Table
                cbxPerfil.ValueMember = "Id_Perfil";//Define qual coluna será manipulada via código
                cbxPerfil.DisplayMember = "Perfil";//Define qual coluna será exibida 
                cbxPerfil.DataSource = DT;//Define a fonte de onde os dados vem       
                sqlCon.Close();//Fecha a conexão com o Banco de Dados
                cbxPerfil.Text = "Selecione um Perfil";//Texto inicial da combobox
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }
        private void carregaGridUsuario()
        {
            List<Usuario> listUsuario_DTO = new List<Usuario>();
            listUsuario_DTO = new UsuarioBLL().ConsultarUsuario();
            gridUsuario.DataSource = listUsuario_DTO;
        }
        private void carregaGridPerfil()
        {
            List<PerfilDTO> listPerfil_DTO = new List<PerfilDTO>();
            listPerfil_DTO = new PerfilBLL().ConsultarPerfil();
            gridPerfil.DataSource = listPerfil_DTO;
        }
        private void carregaGridFuncionalidade()
        {
            List<FuncionalidadeDTO> listFuncionalidade_DTO = new List<FuncionalidadeDTO>();
            listFuncionalidade_DTO = new FuncionalidadeBLL().ConsultarFuncionalidade();
            gridFuncionalidade.DataSource = listFuncionalidade_DTO;
        }
        private void TabUsuario_Click(object sender, EventArgs e)
        {
            PreencherComboBoxUsuario();//Chama o Metodo Preencher ComboBox Usuario
        }
        private void TabPerfil_Click(object sender, EventArgs e)
        {
            PreencherComboBoxPerfil();//Chama o Metodo Preencher ComboBox Perfil
        }
        private void btnInserirfuncionalidade_Click(object sender, EventArgs e)
        {
            if (txbFunci.Text == "" || txbcampo.Text == "")
            {
                MessageBox.Show("Por favor, preencha os campos obrigatórios...");
            }
            else
            {
                FuncionalidadeDTO FUNC = new FuncionalidadeDTO();
                FUNC.Funcionalidade = txbFunci.Text;
                FUNC.Campo = txbcampo.Text;

                int retorno = new BLL.FuncionalidadeBLL().InsereFuncionalidade(FUNC);
                if (retorno > 0)
                {
                    MessageBox.Show("Gravado com Sucesso");
                    codFunciSelecionado = -1;
                    carregaGridFuncionalidade();
                    txbFunci.Text = "";
                    txbcampo.Text = "";
                }
            }
            
        }
        private void btnLimparFuncionalidade_Click(object sender, EventArgs e)
        {
            limpar_camposFuncionalidade();
            modo = "";
        }
        private void btnEditarfuncionalidade_Click(object sender, EventArgs e) 
        {
            if (codFunciSelecionado < 0) 
            {
                MessageBox.Show("Clique em um registro na grid antes de prosseguir!");
            }
            else
            {
                FuncionalidadeDTO FUNC = new FuncionalidadeDTO();
                FUNC.Id_Funcionalidade = codFunciSelecionado;
                FUNC.Funcionalidade = txbFunci.Text;
                FUNC.Campo = txbcampo.Text;

                int retorno = new BLL.FuncionalidadeBLL().EditaFuncionalidade(FUNC);
                if (retorno > 0)
                {
                    MessageBox.Show("Alterado com Sucesso");
                    codFunciSelecionado = -1;
                    carregaGridFuncionalidade();
                    txbFunci.Text = "";
                    txbcampo.Text = "";
                }
            }
        }
        private void btnDeletarfuncionalidade_Click(object sender, EventArgs e) 
        {
            if (codFunciSelecionado < 0)
            {
                MessageBox.Show("Clique em um registro na grid antes de prosseguir!");
            } 
            else 
            {
                FuncionalidadeDTO FUNC = new FuncionalidadeDTO();
                FUNC.Id_Funcionalidade = codFunciSelecionado;

                int retorno = new BLL.FuncionalidadeBLL().DeletarFuncionalidade(FUNC);
                if (retorno > 0)
                {
                    MessageBox.Show("Excluído com Sucesso");
                    codFunciSelecionado = -1;
                    carregaGridFuncionalidade();
                    txbFunci.Text = "";
                    txbcampo.Text = "";
                }
            }
        }
        private void gridFuncionalidade_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            int sel = gridFuncionalidade.CurrentRow.Index;
            codFunciSelecionado = Convert.ToInt32(gridFuncionalidade["Id_Funcionalidade", sel].Value);
            txbFunci.Text = Convert.ToString(gridFuncionalidade["Funcionalidade", sel].Value);
            txbcampo.Text = Convert.ToString(gridFuncionalidade["Campo", sel].Value);
            labelMensagem.Text = "";
        }
        private void btnInserirPerfil_Click(object sender, EventArgs e) 
        {
            if (txbPerfil.Text == "" || cbxFuncionalidade.Text == "")
            {
                MessageBox.Show("Por favor, preencha os campos obrigatórios...");
            }
            else
            {
                PerfilDTO PERF = new PerfilDTO();
                PERF.Perfil = txbPerfil.Text;
                PERF.Id_Funcionalidade = Convert.ToInt32(cbxFuncionalidade.SelectedValue);

                int retorno = new BLL.PerfilBLL().InserePerfil(PERF);
                if (retorno > 0)
                {
                    MessageBox.Show("Gravado com Sucesso");
                    codPerfilSelecionado = -1;
                    carregaGridPerfil();
                    txbPerfil.Text = "";
                    cbxFuncionalidade.Text = "";
                }
            }
        }
        private void btnLimparPerfil_Click(object sender, EventArgs e)
        {
            limpar_camposPerfil();
            modo = "";
        }
        private void btnEditarPerfil_Click(object sender, EventArgs e) 
        {
            if (codPerfilSelecionado < 0)
            {
                MessageBox.Show("Clique em um registro na grid antes de prosseguir!");
            }
            else
            {
                PerfilDTO PERF = new PerfilDTO();
                PERF.Id_Perfil = codPerfilSelecionado;
                PERF.Perfil = txbPerfil.Text;
                PERF.Id_Funcionalidade = Convert.ToInt32(cbxFuncionalidade.SelectedValue);

                int retorno = new BLL.PerfilBLL().EditaPerfil(PERF);
                if (retorno > 0)
                {
                    MessageBox.Show("Alterado com Sucesso");
                    codPerfilSelecionado = -1;
                    carregaGridPerfil();
                    txbPerfil.Text = "";
                    cbxFuncionalidade.Text = "";
                }
            }

        }
        private void btnDeletarPerfil_Click(object sender, EventArgs e) 
        {
            if (codPerfilSelecionado < 0)
            {
                MessageBox.Show("Clique em um registro na grid antes de prosseguir!");
            }
            else
            {
                PerfilDTO PERF = new PerfilDTO();
                PERF.Id_Perfil = codPerfilSelecionado;
                               int retorno = new BLL.PerfilBLL().DeletarPerfil(PERF);
                if (retorno > 0)
                {
                    MessageBox.Show("Excluído com Sucesso");
                    codPerfilSelecionado = -1;
                    carregaGridPerfil();
                    txbPerfil.Text = "";
                    cbxFuncionalidade.Text = "";
                }
            }
        }
        private void gridPerfil_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            int sel = gridPerfil.CurrentRow.Index;
            codPerfilSelecionado = Convert.ToInt32(gridPerfil["Id_Perfil", sel].Value);
            txbPerfil.Text = Convert.ToString(gridPerfil["Perfil", sel].Value);
            cbxFuncionalidade.SelectedValue = Convert.ToInt32(gridPerfil["Id_Funcionalidade", sel].Value);
            labelMensagem.Text = "";
        }
        private void btnInserir_Click(object sender, EventArgs e) 
        {
            if (txbNome.Text == "" || txbEmail.Text == "" || txbLogin.Text == "" || txbSenha.Text == "" || cbxPerfil.Text == "")
            {
                MessageBox.Show("Por favor, preencha os campos obrigatórios...");
            }
            else
            {
                Usuario USU = new Usuario();
                USU.Nome = txbNome.Text;
                USU.Email = txbEmail.Text;
                USU.Login = txbLogin.Text;
                USU.Senha = txbSenha.Text;
                USU.Id_Perfil = Convert.ToInt32(cbxPerfil.SelectedValue);

                int retorno = new BLL.UsuarioBLL().InsereUsuario(USU);
                if (retorno > 0)
                {
                    MessageBox.Show("Gravado com Sucesso");
                    codUsuarioSelecionado = -1;
                    carregaGridUsuario();
                    txbNome.Text = "";
                    txbEmail.Text = "";
                    txbLogin.Text = "";
                    txbSenha.Text = "";
                    cbxPerfil.Text = "";
                }
            }
        }
        private void btnLimparUsuario_Click(object sender, EventArgs e)
        {
            limpar_camposUsuario();
            modo = "";
        }
        private void btnEditar_Click(object sender, EventArgs e) 
        {
            if (codUsuarioSelecionado < 0)
            {
                MessageBox.Show("Clique em um registro na grid antes de prosseguir!");
            }
            else
            {
                Usuario USU = new Usuario();
                USU.Id_Nome = codUsuarioSelecionado;
                USU.Nome = txbNome.Text;
                USU.Email = txbEmail.Text;
                USU.Login = txbLogin.Text;
                USU.Senha = txbSenha.Text;
                USU.Id_Perfil = Convert.ToInt32(cbxPerfil.SelectedValue);

                int retorno = new BLL.UsuarioBLL().EditarUsuario(USU);
                if (retorno > 0)
                {
                    MessageBox.Show("Alterado com Sucesso");
                    codUsuarioSelecionado = -1;
                    carregaGridUsuario();
                    txbNome.Text = "";
                    txbEmail.Text = "";
                    txbLogin.Text = "";
                    txbSenha.Text = "";
                    cbxPerfil.Text = "";
                }
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (codUsuarioSelecionado < 0)
            {
                MessageBox.Show("Clique em um registro na grid antes de prosseguir!");
            }
            else
            {
                Usuario USU = new Usuario();
                USU.Id_Nome = codUsuarioSelecionado;

                int retorno = new BLL.UsuarioBLL().DeletarUsuario(USU);
                if (retorno > 0)
                {
                    MessageBox.Show("Excluído com Sucesso");
                    codUsuarioSelecionado = -1;
                    carregaGridUsuario();
                    txbNome.Text = "";
                    txbEmail.Text = "";
                    txbLogin.Text = "";
                    txbSenha.Text = "";
                    cbxPerfil.Text = "";

                }
            }



        }
        private void gridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                int sel = gridUsuario.CurrentRow.Index;
                codUsuarioSelecionado = Convert.ToInt32(gridUsuario["Id_Nome", sel].Value);
                txbNome.Text = Convert.ToString(gridUsuario["Nome", sel].Value);
                txbEmail.Text = Convert.ToString(gridUsuario["Email", sel].Value);
                txbLogin.Text = Convert.ToString(gridUsuario["Login", sel].Value);
                txbSenha.Text = Convert.ToString(gridUsuario["Senha", sel].Value);
                cbxPerfil.SelectedValue = Convert.ToInt32(gridUsuario["Id_Perfil", sel].Value);
                labelMensagem.Text = "";
            
        }

        private void labelSenha_Click(object sender, EventArgs e)
        {

        }
    }    
}

