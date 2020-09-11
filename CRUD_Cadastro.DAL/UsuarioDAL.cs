using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CRUD_Cadastro.DAL
{
    public class UsuarioDAL
    {
        public List<DTO.Usuario> ConsultarUsuario() 
        {
            try 
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM Usuario";
                CM.Connection = sqlCon;

                SqlDataReader DR;
                List<DTO.Usuario> listUsuarioDTO = new List<DTO.Usuario>();

                sqlCon.Open();
                DR = CM.ExecuteReader();
                if (DR.HasRows) 
                {
                    while (DR.Read()) 
                    {
                        DTO.Usuario usu = new DTO.Usuario();
                        usu. Id_Nome= Convert.ToInt32(DR["Id_Nome"]);
                        usu.Nome = Convert.ToString(DR["Nome"]);
                        usu.Email = Convert.ToString(DR["Email"]);
                        usu.Login = Convert.ToString(DR["Login"]);
                        usu.Senha = Convert.ToString(DR["Senha"]);
                        usu.Id_Perfil = Convert.ToInt32(DR["Id_Perfil"]);

                        listUsuarioDTO.Add(usu);
                    }
                }
                return listUsuarioDTO;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        public int InsereUsuario(DTO.Usuario USU) 
        {
            try 
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO Usuario (Nome, Email, Login, Senha, Id_Perfil) VALUES (@Nome, @Email, @Login, @Senha, @Id_Perfil);";
                CM.Parameters.Add("Nome", System.Data.SqlDbType.VarChar).Value = USU.Nome;
                CM.Parameters.Add("Email", System.Data.SqlDbType.VarChar).Value = USU.Email;
                CM.Parameters.Add("Login", System.Data.SqlDbType.VarChar).Value = USU.Login;
                CM.Parameters.Add("Senha", System.Data.SqlDbType.VarChar).Value = USU.Senha;
                CM.Parameters.Add("Id_Perfil", System.Data.SqlDbType.Int).Value = USU.Id_Perfil;
                CM.Connection = sqlCon;
                sqlCon.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            } 
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        public int EditarUsuario(DTO.Usuario USU) 
        {
            try 
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "UPDATE Usuario SET Nome=@Nome, Email=@Email, Login=@Login, Senha=@Senha, Id_Perfil=@Id_Perfil WHERE Id_Nome=@Id_Nome;";
                CM.Parameters.Add("Id_Nome", System.Data.SqlDbType.Int).Value = USU.Id_Nome;
                CM.Parameters.Add("Nome", System.Data.SqlDbType.VarChar).Value = USU.Nome;
                CM.Parameters.Add("Email", System.Data.SqlDbType.VarChar).Value = USU.Email;
                CM.Parameters.Add("Login", System.Data.SqlDbType.VarChar).Value = USU.Login;
                CM.Parameters.Add("Senha", System.Data.SqlDbType.VarChar).Value = USU.Senha;
                CM.Parameters.Add("Id_Perfil", System.Data.SqlDbType.Int).Value = USU.Id_Perfil;
                CM.Connection = sqlCon;
                sqlCon.Open();
                return CM.ExecuteNonQuery();
            } 
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        public int DeletaUsuario(DTO.Usuario USU) 
        {
            try 
            {
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "DELETE Usuario WHERE Id_Nome = @Id_Nome";
                CM.Parameters.Add("Id_Nome", System.Data.SqlDbType.Int).Value = USU.Id_Nome;
                CM.Connection = CON;
                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            } 
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
