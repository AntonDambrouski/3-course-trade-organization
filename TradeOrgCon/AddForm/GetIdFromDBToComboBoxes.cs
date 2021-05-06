using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TradeOrgCon.AddForm
{
    static class GetIdFromDBToComboBoxes
    {
        public static void GetIdForComboBoxes(SqlCommand sqlCommand, out int[] comboBoxId)
        {
            SqlDataReader sqlDataReader = null;
            List<int> comboBoxIdList = new List<int>();
            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();
                while (sqlDataReader.Read())
                {
                    if (int.TryParse(sqlDataReader[0].ToString(), out int Id))
                    {
                        comboBoxIdList.Add(Id);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                comboBoxId = comboBoxIdList.ToArray();
                if (!(sqlDataReader is null) && !sqlDataReader.IsClosed)
                {
                    sqlDataReader.Close();
                }
            }
        }
    }
}
