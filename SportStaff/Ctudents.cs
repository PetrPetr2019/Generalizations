using System;
using System.Collections.Generic;
using System.Text;

namespace SportStaff
{
      public class Ctudents<T, S>
       {
        private int age;
        private int cours;
        private bool stipuha;
        private int otmetka;

        public string Name { get;}
        public T Age { get; set; }
        public T Cours { get; set; }
        public T Stipuha { get; set; }
        public T Otmetka { get; set; }
        public Ctudents(string name, T age, T cours,  T stipuha, T otmetka)
        {
            this.Name = name;
            this.Age = age;
            this.Cours = cours;
            this.Stipuha = stipuha;
            this.Otmetka = otmetka;
        }

        public Ctudents(string name, int age, int cours, bool stipuha, int otmetka)
        {
            Name = name;
            this.age = age;
            this.cours = cours;
            this.stipuha = stipuha;
            this.otmetka = otmetka;
        }

        
        public  void ShowStudent()
        {
            Console.WriteLine($"\nИмя:{Name}\nВозраст:{age}\nКурс:{cours}\nСтипендия:{stipuha}\nОтметка:{otmetka}");

        }
    }
}
