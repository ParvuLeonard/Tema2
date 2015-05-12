using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMVC
{
    public interface Exporter
    {
        void export(DbSet<Product> Products);
    }
}
