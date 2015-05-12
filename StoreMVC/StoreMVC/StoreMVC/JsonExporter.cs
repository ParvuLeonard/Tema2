using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreMVC.Models;
using System.Data.Entity;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace StoreMVC
{
    public class JsonExporter : Exporter
    {
        public JsonExporter()
        {
            
        }
        public void export(DbSet<Product> Products)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outfile = new StreamWriter(mydocpath + @"\JsonExporter.txt");
            StringBuilder sb = new StringBuilder();
            foreach(var product in Products)
            {
                string json = JsonConvert.SerializeObject(product);
                sb.AppendLine(json);
                sb.AppendLine();
            }

            // Write the stream contents to a new file named "AllTxtFiles.txt".
            using (outfile)
            {
                outfile.Write(sb.ToString());
            }
            
        }
    }
}