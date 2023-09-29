﻿using System.ComponentModel.DataAnnotations;

namespace SuperHeroesApp.Models
{
    public class SuperHero
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility{ get; set; }
        public string CatchPhrase{ get; set; }
    }
}
