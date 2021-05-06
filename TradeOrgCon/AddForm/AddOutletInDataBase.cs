using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TradeOrgCon.AddForm
{
    static class AddOutletInDataBase
    {
        public static void CheckOnCorrectInput(string countOfPlace)
        {
            if (countOfPlace.Length == 0)
            {
                throw new ArgumentException("Не все поля заполнены!");
            }

            if (int.Parse(countOfPlace) <= 0)
            {
                throw new ArgumentException("Некорректный формат данных!");
            }

        }

        public static void InsertOutletIntoDB(string type, string countOfPlace)
        {
            SqlConnection sqlConnection = null;
            try
            {

                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand("Insert Into Торговая_точка([Тип_торговой_точки], [Число_торговых_залов])" +
                       " " + $"Values(@Тип_торговой_точки, @Число_торговых_залов)", sqlConnection);
                sqlCommand.Parameters.Add("@Тип_торговой_точки", SqlDbType.NVarChar).Value = type;
                sqlCommand.Parameters.Add("@Число_торговых_залов", SqlDbType.Int).Value = countOfPlace;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (!(sqlConnection is null))
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
