using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Threading.Tasks;

namespace TradeOrgCon.AddForm
{
    class AddSalesInDataBase
    {
        public static void CheckOnCorrectInput(string date, string productId, string sellerId, string count, string price)
        {
            if (count.Length == 0 || productId.Length == 0 || price.Length == 0
                || sellerId.Length == 0 || date.Length == 0)
            {
                throw new ArgumentException("Не все поля заполнены!");
            }

            if (!int.TryParse(count, out int a) || !long.TryParse(productId, out long b) || !float.TryParse(price, out float c)
                || !long.TryParse(sellerId, out long d) || !DateTime.TryParse(date, out var dateOfRequest))
            {
                throw new ArgumentException("Некорректный формат данных!");
            }
        }

        public static void InsertSalesIntoDB(string date, string clientId, string productId, string sellerId, string count, string price)
        {
            SqlConnection sqlConnection = null;
            try
            {
                if(!CheckOnCountInStore(int.Parse(count), productId))
                {
                    throw new ArgumentException("Недостаточно товара на складе!");
                }

                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                string sqlInsertCommand = clientId is null ? "Insert Into Продажи([Дата_покупки], [Количество], Цена, Id_товара, Id_покупателя, Id_продавца)" +
                       " " + $"Values(@Дата_покупки, @Количество, @Цена, @Id_товара, null, @Id_продавца)" : "Insert Into Продажи([Дата_покупки], [Количество], Цена, Id_товара, Id_покупателя, Id_продавца)" +
                       " " + $"Values(@Дата_покупки, @Количество, @Цена, @Id_товара, @Id_покупателя, @Id_продавца)";

                SqlCommand sqlCommand = new SqlCommand(sqlInsertCommand, sqlConnection);
                sqlCommand.Parameters.Add("@Дата_покупки", SqlDbType.DateTime).Value = date;
                sqlCommand.Parameters.Add("@Цена", SqlDbType.Float).Value = price;
                sqlCommand.Parameters.Add("@Id_товара", SqlDbType.BigInt).Value = productId;
                sqlCommand.Parameters.Add("@Количество", SqlDbType.Int).Value = count;
                sqlCommand.Parameters.Add("@Id_продавца", SqlDbType.BigInt).Value = sellerId;
                if (!(clientId is null))
                {
                    sqlCommand.Parameters.Add("@Id_покупателя", SqlDbType.BigInt).Value = clientId;
                }
                
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                SaveChangesInStore(int.Parse(count), productId);
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

        private static void SaveChangesInStore(int count, string productId)
        {
            SqlConnection sqlConnection = null;
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand($"SELECT Количество FROM Склад_организации WHERE Id = {productId}", sqlConnection);
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    count = sqlDataReader.GetInt32(0) - count;
                }

                sqlDataReader.Close();
                sqlCommand.CommandText = $"UPDATE Склад_организации SET Количество = {count} WHERE Id = {productId}";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Check Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                if (!(sqlConnection is null))
                {
                    sqlConnection.Close();
                }

                if (!(sqlDataReader is null) && !sqlDataReader.IsClosed)
                {
                    sqlDataReader.Close();
                }
            }
        }

        private static bool CheckOnCountInStore(int count, string productId)
        {
            SqlConnection sqlConnection = null;
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand($"SELECT Количество FROM Склад_организации WHERE Id = {productId}", sqlConnection);
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    if (sqlDataReader.GetInt32(0) >= count)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Check Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                if (!(sqlConnection is null))
                {
                    sqlConnection.Close();
                }

                if (!(sqlDataReader is null) && !sqlDataReader.IsClosed)
                {
                    sqlDataReader.Close();
                }
            }

            return false;
        }
    }
}
