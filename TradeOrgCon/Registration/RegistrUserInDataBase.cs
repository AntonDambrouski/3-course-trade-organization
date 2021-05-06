using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TradeOrgCon.Registration
{
    static class RegistrUserInDataBase
    {
        public static void CheckInputFields(TextBox[] textBoxes)
        {
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text.Length == 0)
                {
                    throw new ArgumentException("Не все поля заполнены!");
                }
            }
        }

        public static void AddNewUser(string name, string surname, string position, string login, string password, string type)
        {
            SqlConnection sqlConnection = null;
            try
            {
                CheckOnCorrectInput(name, surname, position, login, password, type);
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand("Insert Into LoginPassword([Имя], [Фамилия], [Должность], [login], [password], [type])" +
                        " " + $"Values(@Имя, @Фамилия, @Должность, @login, @password, @type)", sqlConnection);
                sqlCommand.Parameters.Add("@Имя", SqlDbType.NVarChar, 30).Value = name;
                sqlCommand.Parameters.Add("@Фамилия", SqlDbType.NVarChar, 30).Value = surname;
                sqlCommand.Parameters.Add("@Должность", SqlDbType.NVarChar, 50).Value = position;
                sqlCommand.Parameters.Add("@login", SqlDbType.NVarChar, 50).Value = login;
                sqlCommand.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = password;
                sqlCommand.Parameters.Add("@type", SqlDbType.NVarChar, 3).Value = type;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
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

        private static void CheckOnCorrectInput(string name, string surname, string position, string login, string password, string type)
        {
            if (name.Length == 0 || surname.Length == 0 || position.Length == 0 
                || login.Length == 0 || password.Length == 0 || type.Length == 0)
            {
                throw new ArgumentException("Не все поля заполнены!");
            }
        }

        public static void AddNewUser(TextBox[] textBoxes, string type)
        {
            SqlConnection sqlConnection = null;
            try
            {
                if (textBoxes[5].Text != textBoxes[4].Text)
                {
                    throw new ArgumentException("Пароли не совпадают!");
                }

                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand("Insert Into LoginPassword([Имя], [Фамилия], [Должность], [login], [password], [type])" +
                        " " + $"Values(@Имя, @Фамилия, @Должность, @login, @password, @type)", sqlConnection);
                sqlCommand.Parameters.Add("@Имя", SqlDbType.NVarChar, 30).Value = textBoxes[0].Text;
                sqlCommand.Parameters.Add("@Фамилия", SqlDbType.NVarChar, 30).Value = textBoxes[1].Text;
                sqlCommand.Parameters.Add("@Должность", SqlDbType.NVarChar, 50).Value = textBoxes[2].Text;
                sqlCommand.Parameters.Add("@login", SqlDbType.NVarChar, 50).Value = textBoxes[3].Text;
                sqlCommand.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = textBoxes[4].Text;
                sqlCommand.Parameters.Add("@type", SqlDbType.NVarChar, 3).Value = type;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
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
    }
}
