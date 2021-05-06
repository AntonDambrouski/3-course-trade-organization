using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;



namespace TradeOrgCon.Main_form
{
    static class LoadWorkerFormByChoosingButton
    {
        static SqlDataAdapter sqlDataAdapter;
        static DataTable dataTable;
        public static void LoadSuppliers(DataGridView dataGridView, out Dictionary<string, string> searchBy, out Dictionary<string, string> rangeBy)
        {
            searchBy = new Dictionary<string, string>
            {
                { "Наименование_поставщика","Поставщики" },
                { "Адрес","Поставщики" },
                { "Телефон","Поставщики" },
                { "Категория","Поставщики" },
                { "Id","Склад_организации" },
                { "Наименование_товара","Склад_организации" },
                { "Количество","Склад_организации" }
            };

            rangeBy = new Dictionary<string, string>
            {
                { "Количество", "Склад_организации" }
            };

            try
            {
                LoadTable(dataGridView,
@"SELECT dbo.Поставщики.Наименование_поставщика,
       dbo.Поставщики.Адрес,
       dbo.Поставщики.Телефон,
       dbo.Поставщики.Категория,
       dbo.Склад_организации.Id,
       dbo.Склад_организации.Наименование_товара,
       dbo.Склад_организации.Количество
FROM dbo.Поставщики
JOIN dbo.Заявки ON Заявки.Код_поставщика = Поставщики.Id
JOIN dbo.Склад_организации ON Заявки.Код_товара = dbo.Склад_организации.Id");

                dataGridView.Columns["Наименование_поставщика"].DisplayIndex = 0;
                dataGridView.Columns["Адрес"].DisplayIndex = 1;
                dataGridView.Columns["Телефон"].DisplayIndex = 2;
                dataGridView.Columns["Категория"].DisplayIndex = 3;
                dataGridView.Columns["Id"].DisplayIndex = 4;
                dataGridView.Columns["Наименование_товара"].DisplayIndex = 5;
                dataGridView.Columns["Количество"].DisplayIndex = 6;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void LoadSales(DataGridView dataGridView, out Dictionary<string, string> searchBy, out Dictionary<string, string> rangeBy)
        {
            searchBy = new Dictionary<string, string>
            {
                { "Id_торговой_точки", "Продавцы" },
                { "Тип_торговой_точки", "Торговая_точка"},
                { "Число_торговых_залов", "Торговая_точка" },
                { "Дата_покупки", "Продажи" },
                { "Наименование_товара", "Склад_организации" },
                { "Количество", "Продажи"},
                { "Цена", "Продажи"},
            };

            rangeBy = new Dictionary<string, string>
            {
                {"Дата_покупки", "Продажи" },
                { "Количество", "Продажи"},
                { "Цена", "Продажи"}
            };

            try
            {
                LoadTable(dataGridView,
@"SELECT dbo.Продавцы.Id_торговой_точки,
	   dbo.Торговая_точка.Тип_торговой_точки,
	   dbo.Торговая_точка.Число_торговых_залов,
	   dbo.Продажи.Дата_покупки,
	   dbo.Продажи.Id_товара,
	   dbo.Склад_организации.Наименование_товара,
	   dbo.Продажи.Количество,
	   dbo.Продажи.Цена
FROM dbo.Продажи
JOIN dbo.Продавцы ON Продавцы.Id = Продажи.Id_продавца
JOIN dbo.Торговая_точка ON Торговая_точка.Id = Продавцы.Id_торговой_точки
JOIN dbo.Склад_организации ON Продажи.Id_товара = Склад_организации.Id");

                dataGridView.Columns["Id_торговой_точки"].DisplayIndex = 0;
                dataGridView.Columns["Тип_торговой_точки"].DisplayIndex = 1;
                dataGridView.Columns["Число_торговых_залов"].DisplayIndex = 2;
                dataGridView.Columns["Дата_покупки"].DisplayIndex = 3;
                dataGridView.Columns["Id_товара"].DisplayIndex = 4;
                dataGridView.Columns["Наименование_товара"].DisplayIndex = 5;
                dataGridView.Columns["Количество"].DisplayIndex = 6;
                dataGridView.Columns["Цена"].DisplayIndex = 7;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void LoadClients(DataGridView dataGridView, out Dictionary<string, string> searchBy, out Dictionary<string, string> rangeBy)
        {
            searchBy = new Dictionary<string, string>
            {
                {"Id", "Склад_организации" },
                {"Наименование_товара", "Склад_организации" },
                {"Дата_покупки","Продажи" },
                {"Количество","Продажи" },
                {"Цена", "Продажи" },
                {"Имя", "Покупатели" },
                {"Фамилия", "Покупатели" }
            };

            rangeBy = new Dictionary<string, string>
            {
                {"Дата_покупки","Продажи" },
                {"Количество","Продажи" },
                {"Цена", "Продажи" },
            };

            try
            {
                LoadTable(dataGridView,
@"SELECT dbo.Склад_организации.Id,
	   dbo.Склад_организации.Наименование_товара,
	   dbo.Продажи.Дата_покупки,
	   dbo.Продажи.Количество,
	   dbo.Продажи.Цена,
	   dbo.Продажи.Id_покупателя,
	   dbo.Покупатели.Имя,
	   dbo.Покупатели.Фамилия
FROM dbo.Склад_организации
JOIN dbo.Продажи ON Продажи.Id_товара = Склад_организации.Id
LEFT OUTER JOIN dbo.Покупатели ON Покупатели.Id = Продажи.Id_покупателя");

                dataGridView.Columns["Id"].DisplayIndex = 0;
                dataGridView.Columns["Наименование_товара"].DisplayIndex = 1;
                dataGridView.Columns["Дата_покупки"].DisplayIndex = 2;
                dataGridView.Columns["Количество"].DisplayIndex = 3;
                dataGridView.Columns["Цена"].DisplayIndex = 4;
                dataGridView.Columns["Id_покупателя"].DisplayIndex = 5;
                dataGridView.Columns["Имя"].DisplayIndex = 6;
                dataGridView.Columns["Фамилия"].DisplayIndex = 7;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void LoadSellers(DataGridView dataGridView, out Dictionary<string, string> searchBy, out Dictionary<string, string> rangeBy)
        {
            searchBy = new Dictionary<string, string>
            {
                {"Id", "Продавцы" },
                {"Фамилия", "Продавцы" },
                {"Имя", "Продавцы" },
                {"Оклад", "Продавцы" },
                {"Id_торговой_точки", "Продавцы" },
                {"Тип_торговой_точки", "Торговая_точка" },
                {"Число_торговых_залов", "Торговая_точка" }
            };

            rangeBy = new Dictionary<string, string>
            {
                {"Оклад", "Продавцы" },
                {"Число_торговых_залов", "Торговая_точка" }
            };

            try
            {
                LoadTable(dataGridView,
@"SELECT dbo.Продавцы.Id_торговой_точки,
	   dbo.Торговая_точка.Тип_торговой_точки,
	   dbo.Торговая_точка.Число_торговых_залов,
	   dbo.Продавцы.Id,
	   Продавцы.Фамилия,
	   dbo.Продавцы.Имя,
	   dbo.Продавцы.Оклад
FROM dbo.Продавцы
JOIN dbo.Торговая_точка ON	Торговая_точка.Id = Продавцы.Id_торговой_точки");

                dataGridView.Columns["Id_торговой_точки"].DisplayIndex = 0;
                dataGridView.Columns["Тип_торговой_точки"].DisplayIndex = 1;
                dataGridView.Columns["Число_торговых_залов"].DisplayIndex = 2;
                dataGridView.Columns["Id"].DisplayIndex = 3;
                dataGridView.Columns["Фамилия"].DisplayIndex = 4;
                dataGridView.Columns["Имя"].DisplayIndex = 5;
                dataGridView.Columns["Оклад"].DisplayIndex = 6;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

 public static void LoadTradePoint(DataGridView dataGridView, out Dictionary<string, string> searchBy, out Dictionary<string, string> rangeBy)
        {
            searchBy = new Dictionary<string, string>
            {
                {"Id_торговой_точки", "Продажи" },
                {"Тип_торговой_точки", "Торговая_точка" },
                {"Число_торговых_залов", "Торговая_точка" },
                {"Id_товара", "Продажи" },
                 {"Наименование_товара", "Склад_организации" },
                {"Дата_покупки", "Продажи" },
                {"Количество", "Продажи" },
                {"Цена", "Продажи" },
                {"Id_продавца", "Продажи" },
                {"Фамилия", "Продавцы" },
                {"Оклад", "Продавцы" }
            };

            rangeBy = new Dictionary<string, string>
            {
                {"Число_торговых_залов", "Торговая_точка" },
                {"Дата_покупки", "Продажи" },
                {"Количество", "Продажи" },
                {"Цена", "Продажи" },
                {"Оклад", "Продавцы" }
            };

            try
            {
                LoadTable(dataGridView,
@"SELECT dbo.Продавцы.Id_торговой_точки,
	   dbo.Торговая_точка.Тип_торговой_точки,
	   dbo.Торговая_точка.Число_торговых_залов,
	   dbo.Продажи.Id_товара,
	   dbo.Склад_организации.Наименование_товара,
	   dbo.Продажи.Дата_покупки,
	   dbo.Продажи.Количество,
	   dbo.Продажи.Цена,
	   dbo.Продажи.Id_продавца,
	   dbo.Продавцы.Фамилия,
	   dbo.Продавцы.Оклад
FROM dbo.Продажи
JOIN dbo.Продавцы ON Продажи.Id_продавца = Продавцы.Id
JOIN dbo.Торговая_точка ON Продавцы.Id_торговой_точки = Торговая_точка.Id
JOIN dbo.Склад_организации  ON Склад_организации.Id = Продажи.Id_товара");

                dataGridView.Columns["Id_торговой_точки"].DisplayIndex = 0;
                dataGridView.Columns["Тип_торговой_точки"].DisplayIndex = 1;
                dataGridView.Columns["Число_торговых_залов"].DisplayIndex = 2;
                dataGridView.Columns["Id_товара"].DisplayIndex = 3;
                dataGridView.Columns["Наименование_товара"].DisplayIndex = 4;
                dataGridView.Columns["Дата_покупки"].DisplayIndex = 5;
                dataGridView.Columns["Количество"].DisplayIndex = 6;
                dataGridView.Columns["Цена"].DisplayIndex = 7;
                dataGridView.Columns["Id_продавца"].DisplayIndex = 8;
                dataGridView.Columns["Фамилия"].DisplayIndex = 9;
                dataGridView.Columns["Оклад"].DisplayIndex = 10;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void LoadTable(DataGridView dataGridView, string sqlCommand)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["trdOrganization"].ConnectionString);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand, sqlConnection);
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
