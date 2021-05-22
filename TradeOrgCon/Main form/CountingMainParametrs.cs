using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeOrgCon.Main_form
{
    static class CountingMainParametrs
    {
        public static string GetAllSalary(DataGridView dataGridView1)
        {
            double salary = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                salary += int.Parse(item.Cells["Оклад"].Value.ToString());
            }

            return salary.ToString();
        }

        public static string GetSumOfSales(DataGridView dataGridView1)
        {
            double price = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                price += int.Parse(item.Cells["Цена"].Value.ToString());
            }

            return price.ToString();
        }

        public static string GetTurnover(DataGridView dataGridView1)
        {
            double countOfSales = 0, price = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                price += int.Parse(item.Cells["Цена"].Value.ToString());
                countOfSales += int.Parse(item.Cells["Количество"].Value.ToString());
            }

            return Math.Round(countOfSales * price, 2).ToString();
        }

        public static string GetProfitability(DataGridView dataGridView1)
        {
            double V_sales = 0, salary = 0;
            Dictionary<int, int> sallerAndTheirSalary = new Dictionary<int, int>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                V_sales += int.Parse(item.Cells["Количество"].Value.ToString());
                sallerAndTheirSalary[int.Parse(item.Cells["Id_продавца"].Value.ToString())] = int.Parse(item.Cells["Оклад"].Value.ToString());
            }

            foreach (var item in sallerAndTheirSalary.Values)
            {
                salary += item;
            }

            return salary == 0 ? "0" : Math.Round(V_sales / salary, 4).ToString();
        }

        public static string GetVDivOnCountOfPlaces(DataGridView dataGridView1)
        {
            double V_sales = 0, countOfPlaces = 0;
            Dictionary<int, int> idAndCountOfHalls = new Dictionary<int, int>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                V_sales += int.Parse(item.Cells["Количество"].Value.ToString());
                idAndCountOfHalls[int.Parse(item.Cells["Id_торговой_точки"].Value.ToString())] = int.Parse(item.Cells["Число_торговых_залов"].Value.ToString());
            }

            foreach (int item in idAndCountOfHalls.Values)
            {
                countOfPlaces += item;
            }

            return countOfPlaces == 0 ? "0" : Math.Round(V_sales / countOfPlaces, 2).ToString();
        }

        public static string GetCountOfSaleProduct(DataGridView dataGridView1)
        {
            int result = 0;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                result += int.Parse(item.Cells["Количество"].Value.ToString());
            }

            return result.ToString();
        }

        
    }
}
