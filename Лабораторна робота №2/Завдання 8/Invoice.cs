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
        private string article;
        private int quantity;

        public Invoice(int acc, string cust, string prov, string artic, int quant)
        {
            this.Price = acc;
            this.Customer = cust;
            this.Provider = prov;
            this.article = artic;
            this.quantity = quant;
        }
        public double NDSprice()
        {
            double lastprice = Price * quantity;
            double NDSprice = lastprice - (lastprice * 0.175);
            return NDSprice;
        }
        public double WithoutNDSprice()
        {
            double lastprice = Price * quantity;

            return lastprice;
        }
    }
}
