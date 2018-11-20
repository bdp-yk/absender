﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenderAPI.Models.UniversityModels
{
    public class Matiere
    {
        [Key]
        public int IdMatiere { get; set; }
        //RS
        public int IdPanier { get; set; }
        [ForeignKey("IdPanier")]
        public Panier Panier { get; set; }

        public List<Seance> Seances { get; set; }

    }
}
