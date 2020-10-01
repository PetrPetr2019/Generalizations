using System;
using System.Collections.Generic;
using System.Text;

namespace SportStaff
{
    class Stipuha:Students<int, bool>
    {

        public Stipuha(string name, int age, int cours, bool stipuha, int otmetka):base(name, age, cours, stipuha,  otmetka)
        {
        }
    }
}
