using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exo2.Service
{
    public class Service2Imp : IService2
    {
        IService1 S1;

        public Service2Imp(IService1 s1)
        {
            S1 = s1;
        }

        public int calcul(int cle, int x)
        {
            return x * (S1.GetDonnee(cle));
        }
    }
}