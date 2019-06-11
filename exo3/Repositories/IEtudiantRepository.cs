using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo3.Models;

namespace exo3.Repositories
{
 public   interface IEtudiantRepository
    {
        IEnumerable<etudiant> GetAllEtudiant();
        void CreateNewEtudiant(etudiant etud);
    }
}
