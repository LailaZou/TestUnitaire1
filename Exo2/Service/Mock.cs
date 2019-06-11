using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exo2.Service
{
    public class Mock : IService1
    {
        public bool IsCalled = false;
        public int GetDonnee(int cle)
        {
            IsCalled = true;
            return 1;
        }
    }
}