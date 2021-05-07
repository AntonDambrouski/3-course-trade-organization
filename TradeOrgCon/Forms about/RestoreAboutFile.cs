﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TradeOrgCon.Forms_about
{
    static class RestoreAboutFile
    {
        public static void CreateReadMeFile()
        {
            StreamWriter streamWriter = File.CreateText("Readme.txt");
            string textAbout = @"Приложение созданно для автоматизации работы торговых организаций

-------------------------------------------------------------------
Данное программное обеспечение позволяет выполнить следующие задачи:
1) Получить перечень и общее число поставщиков, поставляющих
указанный вид товара, либо некоторый товар в объеме, не менее
заданного, за весь период сотрудничества, либо за указанный период.

2) Получить сведения о поставках определенного товара указанным
за все время поставок, либо за некоторый период.

3) Получить номенклатуру и объем товаров в указанной торговой точке.

4) Получить перечень и общее число покупателей, купивших указанный вид
товара за некоторый период, либо сделавших покупку товара в объеме, не
менее заданного.

5) Получить сведения о покупателях указанного товара за обозначенный,
либо за весь период, по всем торговым точкам, по торговым точкам
указанного типа, по данной торговой точке.

6) Получить сведения о наиболее активных покупателях по всем торговым
точкам, по торговым точкам указанного типа, по данной торговой точке.

7) Получить данные о выработке отдельно взятого продавца отдельно взятой
торговой точки за указанный период.

8) Получить данные о заработной плате продавцов по всем торговым
точкам, по торговым точкам заданного типа, по конкретной торговой
точке.

9) Получить данные об отношении объема продаж к объему торговых
площадей, либо к числу торговых залов, либо к числу прилавков по
торговым точкам указанного типа, о выработке отдельно взятого
продавца торговой точки, по заданной торговой точке.

10) Получить данные о рентабельности торговой точки: соотношение объема
продаж к накладным расходам (суммарная заработная плата продавцов +
платежи за аренду, коммунальные услуги) за указанный период.

11) Получить данные о товарообороте торговой точки, либо всех торговых
определенной группы за указанный период.

12) Получить данные об объеме продаж указанного товара за некоторый
период по всем торговым точкам, по торговым точкам заданного типа, по
конкретной торговой точке.

13) Получить сведения об объеме и ценах на указанный товар по всем
торговым точкам, по торговым точкам заданного типа, по конкретной
торговой точке.
--------------------------------------------------------------------

Для работы приложения необходимо наличие на компьютере:
ОС Windows 7 и выше
.NET Framework 4.6.1 и выше.
Windows NT

Интерфейс простой и интуитвно понятный.
Приятной работы!";

            streamWriter.Write(textAbout);
            streamWriter.Close();
        }

    }
}
