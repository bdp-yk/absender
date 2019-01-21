﻿using AbsenderAPI.Models.UniversityModels.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenderAPI.Models.UniversityModels
{
    public class Groupe
    {
        [Key]
        public int Id_groupe { get; set; }
        public string Designation_groupe { get; set; }

        public int Fk_filiere { get; set; }
        [ForeignKey("fk_filiere")]
        public Filiere Ref_filiere { get; set; }

        public List<Etudiant> Liste_Etudiants { get; set; }
        public List<Seance> Emploie{ get; set; }
    }
}
