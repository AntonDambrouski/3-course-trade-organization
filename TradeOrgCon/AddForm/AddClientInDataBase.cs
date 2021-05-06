using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

namespace TradeOrgCon.AddForm
{
    static class AddClientInDataBase
    {
        public static void CheckOnCorrectInput(int nameLength, int surnameLength)
        {
            if (nameLength == 0 || surnameLength == 0)
            {
                throw new ArgumentException("Не все поля заполнены!");
            }
        }

        public static void InsertClientIntoDB(string name, string surname)
        {
            SqlConnection sqlConnection = null;
            try
            {
                
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand("Insert Into Покупатели([Фамилия], [Имя])" +
                       " " + $"Values(@Фамилия, @Имя)", sqlConnection);
                sqlCommand.Parameters.Add("@Фамилия", SqlDbType.NVarChar).Value = surname;
                sqlCommand.Parameters.Add("@Имя", SqlDbType.NVarChar).Value = name;
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
