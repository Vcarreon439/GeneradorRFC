using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorRFC
{
    class RFC
    {
        List<char> vocales = new List<char> { 'A','E','I','O','U'};
        Random rd = new Random();

        public RFC() 
        {

        }

        public string GenerarRFCs() 
        {
            string rfc = "";

            rfc += (char)rd.Next('A', 'Z');
            rfc += vocales[rd.Next(0,5)];
            rfc += (char) rd.Next('A', 'Z');
            rfc += (char) rd.Next('A', 'Z');

            int val =  rd.Next(0, 99);

            if (val<10)
                rfc += $"0{val}";
            else
                rfc += val;

            for (int i = 0; i < 3; i++)
                rfc += (char)rd.Next('A', 'Z');

            return rfc;
        }

    }
}
