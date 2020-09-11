using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_Cadastro.DAL
{
    public class PerfilDAL
    {
        public List<PerfilDTO> ConsultarPerfil()
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM Perfil;";
                CM.Connection = sqlCon;


                SqlDataReader DR;
                List<PerfilDTO> listPerfilDTO = new List<PerfilDTO>();

                sqlCon.Open();
                DR = CM.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        PerfilDTO perf = new PerfilDTO();
                        perf.Id_Perfil = Convert.ToInt32(DR["Id_Perfil"]);
                        perf.Perfil = Convert.ToString(DR["Perfil"]);
                        perf.Id_Funcionalidade = Convert.ToInt32(DR["Id_Funcionalidade"]);

                        listPerfilDTO.Add(perf);
                    }
                }
                return listPerfilDTO;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int InserePerfil(PerfilDTO PERF)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO Perfil (Perfil, Id_Funcionalidade) VALUES (@Perfil, @Id_Funcionalidade);";
                CM.Parameters.Add("Perfil", System.Data.SqlDbType.VarChar).Value = PERF.Perfil;
                CM.Parameters.Add("Id_Funcionalidade", System.Data.SqlDbType.Int).Value = PERF.Id_Funcionalidade;
                CM.Connection = sqlCon;
                sqlCon.Open();
                return CM.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int EditaPerfil(PerfilDTO PERF)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "UPDATE Perfil SET Perfil=@Perfil, Id_Funcionalidade=@Id_Funcionalidade WHERE Id_Perfil=@Id_Perfil;";
                CM.Parameters.Add("Id_Perfil", System.Data.SqlDbType.Int).Value = PERF.Id_Perfil;
                CM.Parameters.Add("Perfil", System.Data.SqlDbType.VarChar).Value = PERF.Perfil;
                CM.Parameters.Add("Id_Funcionalidade", System.Data.SqlDbType.Int).Value = PERF.Id_Funcionalidade;
                CM.Connection = sqlCon;
                sqlCon.Open();
                return CM.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeletarPerfil(PerfilDTO PERF)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "DELETE Perfil WHERE Id_Perfil = @Id_Perfil;";
                CM.Parameters.Add("Id_Perfil", System.Data.SqlDbType.Int).Value = PERF.Id_Perfil;
                CM.Connection = sqlCon;
                sqlCon.Open();
                return CM.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}