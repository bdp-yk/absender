﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AbsenderAPI.Models.UniversityModels;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace AbsenderAPI.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string IdNational{ get; set; }
        public string IdUniversitaire{ get; set; }
        public string PhotoProfil{ get; set; }

        [JsonIgnore]
        public int IdContact{ get; set; }

        [JsonIgnore]
        [ForeignKey("IdContact")]
        public Contact ContactUtilisateur { get; set; }
    }
}
