using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TradeOrgCon.Main_form
{
    static class LoadSearchAndChooseInfoByClickButton
    {
        static SqlDataAdapter sqlDataAdapter;
        static DataTable dataTable;
        public static void LoadSuppliers(DataGridView dataGridView, out string[] searchBy, out string[] rangeBy)
        {
            searchBy = new string[]
            {
                "Id", "Наименование_поставщика",
                "Адрес", "Телефон", "Категория"
            };

            rangeBy = null;

            try
            {
                LoadTable(dataGridView, "Поставщики");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void LoadSellers(DataGridView dataGridView, out string[] searchBy, out string[] rangeBy)
        {
            searchBy = new[]
            {
                "Id","Фамилия", "Имя",
                "Оклад", "Id_торговой_точки"
            };

            rangeBy = new string[]
            {
                "Оклад"
            };

            try
            {
                LoadTable(dataGridView, "Продавцы");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void LoadTradeOrganization(DataGridView dataGridView, out string[] searchBy, out string[] rangeBy)
        {
            searchBy = new[]
            {
                "Id","Тип_торговой_точки", "Число_торговых_залов"
            };

            rangeBy = new string[]
            {
                "Число_торговых_залов"
            };

            try
            {
                LoadTable(dataGridView, "Торговая_точка");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void LoadSales(DataGridView dataGridView, out string[] searchBy, out string[] rangeBy)
        {
            searchBy = new[]
            {
                "Id","Дата_покупки", "Количество",
                "Цена", "Id_товара", "Id_покупателя",
                "Id_продавца"
            };

            rangeBy = new string[]
            {
               "Дата_покупки", "Количество",
                "Цена", "Id_товара", "Id_покупателя",
                "Id_продавца"
            };

            try
            {
                LoadTable(dataGridView, "Продажи");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void LoadClients(DataGridView dataGridView, out string[] searchBy, out string[] rangeBy)
        {
            searchBy = new[]
            {
                "Id","Фамилия","Имя"
            };

            rangeBy = null;
            try
            {
                LoadTable(dataGridView, "Покупатели");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void LoadStore(DataGridView dataGridView, out string[] searchBy, out string[] rangeBy)
        {
            searchBy = new[]
            {
                "Id","Наименование_товара", "Количество"
            };

            rangeBy = new string[]
            {
                "Количество"
            };

            try
            {
                LoadTable(dataGridView, "Склад_организации");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void LoadUserAccounts(DataGridView dataGridView, out string[] searchBy, out string[] rangeBy)
        {
            searchBy = new string[]
            {
                "Id", "Имя", "Фамилия",
                "Должность", "login", "type"
            };

            rangeBy = null;
            try
            {
                LoadTable(dataGridView, "LoginPassword");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void LoadRequest(DataGridView dataGridView, out string[] searchBy, out string[] rangeBy)
        {
            searchBy = new[]
            {
                "Id","Дата_заявки", "Код_товара",
                "Код_поставщика", "Количество"
            };

            rangeBy = new string[]
            {
                "Дата_заявки","Код_товара",
                "Код_поставщика", "Количество"
            };

            try
            {
                LoadTable(dataGridView, "Заявки");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SaveChanges()
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                sqlDataAdapter.UpdateCommand = new SqlCommandBuilder(sqlDataAdapter).GetUpdateCommand();
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void LoadTable(DataGridView dataGridView, string table)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {table}", sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
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
