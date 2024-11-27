namespace Bracket.Contract.Entities
{
    public class ProfileEntity
    {
        public string? AboutMe { get; set; }

        public required string FullName { get; set; }

        public string? Gravatar { get; set; }

        public required string NickName { get; set; }

        public required string Role { get; set; }

        public string? RoleDescription { get; set; }

        public IEnumerable<SkillSetEntity> SkillSet { get; set; } = Enumerable.Empty<SkillSetEntity>();
    }
}
