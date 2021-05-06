using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

namespace TradeOrgCon.AddForm
{
    class AddSellersInDataBase
    {
        public static void CheckOnCorrectInput(string surname, string name, string salary, string tradeOrgId)
        {
            if (surname.Length == 0 || name.Length == 0 || salary.Length == 0 || tradeOrgId.Length == 0)
            {
                throw new ArgumentException("Не все поля заполнены!");
            }

            if (float.Parse(salary) < 0 || long.Parse(tradeOrgId) < 0)
            {
                throw new ArgumentException("Некорректный формат данных!");
            }
        }

        public static void InsertSellerIntoDB(string surname, string name, string salary, string tradeOrgId)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand("Insert Into Продавцы([Фамилия], [Имя], Оклад, Id_торговой_точки)" +
                       " " + $"Values(@Фамилия, @Имя, @Оклад, @Id_торговой_точки)", sqlConnection);
                sqlCommand.Parameters.Add("@Фамилия", SqlDbType.NVarChar).Value = surname;
                sqlCommand.Parameters.Add("@Имя", SqlDbType.NVarChar).Value = name;
                sqlCommand.Parameters.Add("@Оклад", SqlDbType.Float).Value = salary;
                sqlCommand.Parameters.Add("@Id_торговой_точки", SqlDbType.BigInt).Value = tradeOrgId;
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
