using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_Cadastro.DAL
{
    public class FuncionalidadeDAL
    {
        public List<FuncionalidadeDTO> ConsultaFuncionalidade()
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM Funcionalidade;";
                CM.Connection = sqlCon;

                SqlDataReader DR;
                List<FuncionalidadeDTO> listFuncionalidadeDTO = new List<FuncionalidadeDTO>();

                sqlCon.Open();
                DR = CM.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        FuncionalidadeDTO func = new FuncionalidadeDTO();
                        func.Id_Funcionalidade = Convert.ToInt32(DR["Id_Funcionalidade"]);
                        func.Funcionalidade = Convert.ToString(DR["Funcionalidade"]);
                        func.Campo = Convert.ToString(DR["Campo"]);
                        listFuncionalidadeDTO.Add(func);
                    }
                }
                return listFuncionalidadeDTO;

            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public int InsereFuncionalidade(FuncionalidadeDTO FUNC)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO Funcionalidade (Funcionalidade, Campo) VALUES (@Funcionalidade, @Campo);";
                CM.Parameters.Add("Funcionalidade", System.Data.SqlDbType.VarChar).Value = FUNC.Funcionalidade;
                CM.Parameters.Add("Campo", System.Data.SqlDbType.VarChar).Value = FUNC.Campo;
                CM.Connection = sqlCon;
                sqlCon.Open();
                return CM.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int EditaFuncionalidade(FuncionalidadeDTO FUNC)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "UPDATE Funcionalidade SET Funcionalidade=@Funcionalidade, Campo=@Campo WHERE Id_Funcionalidade=@Id_Funcionalidade;";
                CM.Parameters.Add("Id_Funcionalidade", System.Data.SqlDbType.Int).Value = FUNC.Id_Funcionalidade;
                CM.Parameters.Add("Funcionalidade", System.Data.SqlDbType.VarChar).Value = FUNC.Funcionalidade;
                CM.Parameters.Add("Campo", System.Data.SqlDbType.VarChar).Value = FUNC.Campo;
                CM.Connection = sqlCon;
                sqlCon.Open();
                return CM.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeletarFuncionalidade(FuncionalidadeDTO FUNC)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "DELETE Funcionalidade WHERE Id_Funcionalidade = @Id_Funcionalidade;";
                CM.Parameters.Add("Id_Funcionalidade", System.Data.SqlDbType.Int).Value = FUNC.Id_Funcionalidade;
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
