using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;

namespace StoreMVC
{
    public class CsvExporter : Exporter
    {
        public CsvExporter()
        {

        }

        public void export(DbSet<Product> Products)
        {
            string attachment = "attachment; filename=CsvExporter.csv";
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ClearHeaders();
            HttpContext.Current.Response.ClearContent();
            HttpContext.Current.Response.AddHeader("content-disposition", attachment);
            HttpContext.Current.Response.ContentType = "text/csv";
            HttpContext.Current.Response.AddHeader("Pragma", "public");
            WriteColumnName();
            foreach (var product in Products)
            {
                WriteUserInfo(product);
            }
            HttpContext.Current.Response.End();   
            //to do
        }

        public static void WriteUserInfo(Product product)
        {
            StringBuilder stringBuilder = new StringBuilder();
            AddComma(product.Name, stringBuilder);
            AddComma(product.Price.ToString(), stringBuilder);
            HttpContext.Current.Response.Write(stringBuilder.ToString());
            HttpContext.Current.Response.Write(Environment.NewLine);
        }

        public static void AddComma(string value, StringBuilder stringBuilder)
        {
            stringBuilder.Append(value.Replace(',', ' '));
            stringBuilder.Append(", ");
        }

        public static void WriteColumnName()
        {
            string columnNames = "Name, Price";
            HttpContext.Current.Response.Write(columnNames);
            HttpContext.Current.Response.Write(Environment.NewLine);
        }
    }
}