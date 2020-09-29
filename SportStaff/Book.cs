using System;
using System.Collections.Generic;
using System.Text;

namespace SportStaff
{
    class Book<T>
    {
        protected string Name { get;  set; }
        protected T Price { get; set; }

        public Book()
        {
          
        }
        //public void SetPrice(T price)
        //{
        //    Price = price;
        //}

        //public void SetName(string name)
        //{
        //    Name = name;
        //}

        public void Show()
        {
            Console.WriteLine($"Цена{Price}\nИмя:{Name}");
        }

    }
}
