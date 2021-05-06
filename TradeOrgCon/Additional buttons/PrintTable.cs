using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace TradeOrgCon.Additional_buttons
{
    static class PrintTable
    {
        public static Bitmap GetBmpForPrint(DataGridView dataGridView, Rectangle bounds)
        {
            Font defaultFont = dataGridView.Font;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView.AutoResizeColumns();
            dataGridView.Font = new Font("Consolas", 10, FontStyle.Regular);
            Bitmap bmp = new Bitmap(dataGridView.Width + 10, dataGridView.Height + 10);
            dataGridView.DrawToBitmap(bmp, bounds);       
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Font = defaultFont;
            return bmp;
        }
    }
}
