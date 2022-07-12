using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroAPI.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string SkillOne { get; set; }
        public string SkillTwo { get; set; }
        public string SkillThree { get; set; }
        public string SkillFour { get; set; }
        public string SkillFive { get; set; }
        public string SkillSix { get; set; }
    }
}
