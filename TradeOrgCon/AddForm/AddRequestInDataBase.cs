using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TradeOrgCon.AddForm
{
    class AddRequestInDataBase
    {
        public static void CheckOnCorrectInput(string date, string productId, string supplierId, string count)
        {
            if (date.Length == 0 || productId.Length == 0 || supplierId.Length == 0 || count.Length == 0)
            {
                throw new ArgumentException("Не все поля заполнены!");
            }

            if (!int.TryParse(count, out int a) || !long.TryParse(productId, out long prodId)
                || !long.TryParse(supplierId, out long supId) || !DateTime.TryParse(date, out var dateOfRequest))
            {
                throw new ArgumentException("Некорректный формат данных!");
            }
        }

        private static void UpdateProductInStore(int count, string productId)
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
                    count += sqlDataReader.GetInt32(0);
                }

                sqlDataReader.Close();
                sqlCommand.CommandText = $"UPDATE Склад_организации SET Количество = {count} WHERE Id = {productId}";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Update error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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

        public static void InsertRequestIntoDB(string date, string productId, string supplierId, string count)
        {
            SqlConnection sqlConnection = null;
            try
            {

                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand("Insert Into Заявки([Дата_заявки], [Код_товара], Код_поставщика, Количество)" +
                       " " + $"Values(@Дата_заявки, @Код_товара, @Код_поставщика, @Количество)", sqlConnection);
                sqlCommand.Parameters.Add("@Дата_заявки", SqlDbType.DateTime).Value = date;
                sqlCommand.Parameters.Add("@Код_товара", SqlDbType.BigInt).Value = productId;
                sqlCommand.Parameters.Add("@Код_поставщика", SqlDbType.BigInt).Value = supplierId;
                sqlCommand.Parameters.Add("@Количество", SqlDbType.Int).Value = count;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                UpdateProductInStore(int.Parse(count), productId);
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
