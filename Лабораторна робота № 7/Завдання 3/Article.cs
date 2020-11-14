using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Завдання_3
{
    class Article
    {
        private string _nameArticle;
        private string _nameStore;
        private int _price;

        public string NameArticle
        {
            get { return _nameArticle; }
            set { _nameArticle = value; }
        }

        public string NameStore
        {
            get { return _nameStore; }
            set { _nameStore = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        

        
    }
}
