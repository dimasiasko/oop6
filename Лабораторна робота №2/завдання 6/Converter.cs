using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_6
{
    public class Converter
    {
        public double USD { get; }
        public double EUR { get; }
        public double RUB { get; }

        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public double ToUSD(double value)
        {
            return value / USD;
        }

        public double ToEUR(double value)
        {
            return value / EUR;
        }

        public double ToRUB(double value)
        {
            return value / RUB;
        }

        public double FromUSD(double value)
        {
            return USD * value;
        }

        public double FromEUR(double value)
        {
            return EUR * value;
        }

        public double FromRUB(double value)
        {
            return RUB * value;
        }
    }
}
