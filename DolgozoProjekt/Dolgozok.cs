using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozoProjekt
{
    public class Dolgozo
    {
        public string Vezeteknev;
        public string Keresztnev;
        public string Neme;
        public int Kor;
        public int Fizetes;

        public Dolgozo(string vezeteknev, string keresztnev, string neme, int kor, int fizetes)
        {
            Vezeteknev = vezeteknev;
            Keresztnev = keresztnev;
            Neme = neme;
            Kor = kor;
            Fizetes = fizetes;
        }
    }
}
