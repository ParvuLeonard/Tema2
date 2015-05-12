using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreMVC
{
    public class ExporterFactory
    {
        public Exporter getExporter(String exporterType)
        {
            if (exporterType.Equals("json"))
            {
                return new JsonExporter();
            }

            if (exporterType.Equals("csv"))
            {
                return new CsvExporter();
            }

            return null;
        }
    }
}