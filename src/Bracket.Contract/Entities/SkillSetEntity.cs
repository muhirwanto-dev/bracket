namespace Bracket.Contract.Entities
{
    public class SkillSetEntity
    {
        public required string Name { get; set; }

        public string? IconPath { get; set; }

        public int Score { get; set; }
    }
}
