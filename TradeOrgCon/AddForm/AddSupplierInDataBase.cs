using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

namespace TradeOrgCon.AddForm
{
    static class AddSupplierInDataBase
    {
        public static void CheckOnCorrectInput(string orgName, string adress, string phone, string type)
        {
            if (orgName.Length == 0 || adress.Length == 0 || adress.Length == 0 || type.Length == 0)
            {
                throw new ArgumentException("Не все поля заполнены!");
            }
        }

        public static void InsertClientIntoDB(string orgName, string adress, string phone, string type)
        {
            SqlConnection sqlConnection = null;
            try
            {

                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand("Insert Into Поставщики(Наименование_поставщика, Адрес, Телефон, Категория)" +
                       " " + $"Values(@Наименование_поставщика, @Адрес, @Телефон, @Категория)", sqlConnection);
                sqlCommand.Parameters.Add("@Наименование_поставщика", SqlDbType.NVarChar).Value = orgName;
                sqlCommand.Parameters.Add("@Адрес", SqlDbType.NVarChar).Value = adress;
                sqlCommand.Parameters.Add("@Телефон", SqlDbType.NVarChar).Value = phone;
                sqlCommand.Parameters.Add("@Категория", SqlDbType.NVarChar).Value = type;
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
