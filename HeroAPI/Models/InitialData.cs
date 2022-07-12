namespace HeroAPI.Models
{
    public static class InitialData
    {
        public static void Seed(this HeroDbContext dbContext)
        {
            if (!dbContext.Heroes.Any())
            {
                dbContext.Heroes.Add(new Hero
                {
                    Name = "NameNoN",
                    Type = "TypeNoN",
                    SkillOne = "SkillOneNoN",
                    SkillTwo = "SkillTwoNoN",
                    SkillThree = "SkillThreeNoN",
                    SkillFour = "SkillTFourNoN",
                    SkillFive = "SkillTFiveNoN"
                });
                dbContext.SaveChanges();
            }
        }
    }
}
