using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exo2.Service
{
    public class Stub : IService1
    {
        public int GetDonnee(int cle)
        {
            if (cle == 1)
                return 10;
            return 1;
        }
    }
}