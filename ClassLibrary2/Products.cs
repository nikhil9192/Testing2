using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

        public void AcceptData(int pid,string pname,int cost)
        { 
            ProductId=pid;
            ProductName = pname;
            Price = cost;

        }
    }
}
