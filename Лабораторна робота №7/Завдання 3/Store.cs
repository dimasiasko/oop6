using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Завдання_3
{
    class Store
    {
        public ObservableCollection<Article> Articles { get; set; }
        private Article selectedArticle;

        public Article SelectedArticle
        {
            get { return selectedArticle; }
            set
            {
                selectedArticle = value;
            }
        }
        public Store()
        {
            Articles = new ObservableCollection<Article>()
            {
                new Article()
                {
                    NameArticle = "T086.402.22.036", NameStore = "Tissot", Price = 1450
                },
                new Article()
                {
                    NameArticle = "Datejust-69173", NameStore = "Rolex", Price = 6300
                },
                new Article()
                {
                    NameArticle = "Explorer 216570", NameStore = "Rolex", Price = 11999
                },
                new Article()
                {
                    NameArticle = "Octava-96C", NameStore = "Bulova", Price = 890
                }
            };
        }
    }
}
