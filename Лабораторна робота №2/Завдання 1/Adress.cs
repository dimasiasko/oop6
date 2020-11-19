using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_1
{
    class Adress
    {
        public int index;
        public int Index
        {
            get { return index; }
            set
            {
                index = value;
            }
        }

        public string country;
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
            }
        }

        public string city;
        public string City
        {
            get { return city; }
            set
            {
                city = value;
            }
        }

        public string street;
        public string Street
        {
            get { return street; }
            set
            {
                street = value;
            }
        }

        public int house;
        public int House
        {
            get { return house; }
            set
            {
                house = value;
            }
        }

        public int apartment;
        public int Apartment
        {
            get { return apartment; }
            set
            {
                apartment = value;
            }
        }
    }
}
