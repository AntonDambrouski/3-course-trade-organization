using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace TradeOrgCon.Authorization
{
    static class CheckInputAndLoadForm
    {
        public static void CheckInputFields(int loginLength, int passwLength)
        {
            if (loginLength == 0 || passwLength == 0)
            {
                throw new ArgumentException("Не все поля заполнены!");
            }
        }

        public static string CheckInputDataReturnType(string login, string password)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TradeOrganization.mdf;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand($"SELECT password, [type] FROM LoginPassword WHERE login = N'{login}'", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();
                return GetType(sqlDataReader, password);
            }
            catch (ArgumentException ex)
            {
                throw ex;
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

        private static string GetType(SqlDataReader sqlDataReader, string password)
        {
            try
            {
                if (sqlDataReader.Read())
                {
                    if (Convert.ToString(sqlDataReader[0]) == password)
                    {
                        string type = Convert.ToString(sqlDataReader[1]);
                        return type;
                    }
                    else
                    {
                        throw new ArgumentException("Неверный логин или пароль");
                    }
                }
                else
                {
                    throw new ArgumentException("Неверный логин или пароль");
                }
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlDataReader.Close();
            }
        }
    }
}
