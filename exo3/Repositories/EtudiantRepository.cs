using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using exo3.Models;

namespace exo3.Repositories
{
    public class EtudiantRepository : IEtudiantRepository
    {
        private EcoleEntities db = new EcoleEntities();
        public void CreateNewEtudiant(etudiant etud)
        {
            db.etudiants.Add(etud);
            db.SaveChanges();
        }

        public IEnumerable<etudiant> GetAllEtudiant()
        {
            return db.etudiants.ToList();
        }
    }
}