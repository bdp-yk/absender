﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenderAPI.Models.UniversityModels
{
    public class Module
    {
        public int Id_Module { get; set; }
        public string Designation_Module { get; set; }

        public int Fk_Filiere { get; set; }
        public Filiere Ref_Filiere { get; set; }

        public List<Matiere> Matiere_Associees { get; set; }
    }
}
