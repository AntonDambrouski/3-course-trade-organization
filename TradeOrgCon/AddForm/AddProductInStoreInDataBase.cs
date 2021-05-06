using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace TradeOrgCon.AddForm
{
    class AddProductInStoreInDataBase
    {
        public static void CheckOnCorrectInput(string productName, string count)
        {
            if (productName.Length == 0 || count.Length == 0)
            {
                throw new ArgumentException("Не все поля заполнены!");
            }

            if (!int.TryParse(count, out int v))
            {
                throw new Exception("Некорректный формат данных!");
            }
        }

        public static void InsertProductIntoDB(string productName, string count)
        {
            SqlConnection sqlConnection = null;
            try
            {

                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand("Insert Into Склад_организации(Наименование_товара, Количество)" +
                       " " + $"Values(@Наименование_товара, @Количество)", sqlConnection);
                sqlCommand.Parameters.Add("@Наименование_товара", SqlDbType.NVarChar).Value = productName;
                sqlCommand.Parameters.Add("@Количество", SqlDbType.NVarChar).Value = count;
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
