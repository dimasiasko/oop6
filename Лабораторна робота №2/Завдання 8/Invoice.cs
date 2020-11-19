using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_8
{
    class Invoice
    {
        public int Price { get; private set; }
        public string Customer { get; private set; }
        public string Provider { get; private set; }
        private string Article { get; set; }
        private int Quantity { get; set; }

        public Invoice(int acc, string cust, string prov, string artic, int quant)
        {
            this.Price = acc;
            this.Customer = cust;
            this.Provider = prov;
            this.Article = artic;
            this.Quantity = quant;
        }
        public double NDSprice()
        {
            double lastprice = Price * Quantity;
            double NDSprice = lastprice - (lastprice * 0.175);
            return NDSprice;
        }
        public double WithoutNDSprice()
        {
            double lastprice = Price * Quantity;

            return lastprice;
        }
    }
}
