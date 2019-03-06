using System;
using System.Collections.Generic;
using System.Text;

namespace HwQueryMasterTest
{
    internal class QueryManager
    {
        internal static string GetInsert(Product product)
        {
            string query =
                $"INSERT INTO Urun (UrunAdi,Fiyat,Kategori,Stokta) Values ('{product.Title}',{product.ListPrice},{product.CategoryId})";
            return query;
        }

        internal static StringBuilder GetInsertMany(List<Product> products)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in products)
            {
                sb.AppendLine($"INSERT INTO Urun (UrunAdi,Fiyat,Kategori,Stokta) Values ('{product.Title}',{product.ListPrice},{product.CategoryId})");
            }

            return sb;
        }
    }
}