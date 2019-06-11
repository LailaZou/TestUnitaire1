using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exo2.Service
{
    public class Service1Imp:IService1
    {
        private static Dictionary<int, int> ValeurParametre = new Dictionary<int, int>
        {
            {1,10 },
            {3,100},
            {4,27 },
            {5,31 }
        };

        public int GetDonnee(int cle)
        {
            return (ValeurParametre.ContainsKey(cle) ? ValeurParametre[cle] : 1);
        }
    }
}