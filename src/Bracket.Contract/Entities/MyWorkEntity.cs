namespace Bracket.Contract.Entities
{
    internal class MyWorkEntity
    {
        public required string WorkTitle { get; set; }

        public string? Image { get; set; }

        public string? ProjectUrl { get; set; }

        public required string Overview { get; set; }

        public string? Description { get; set; }
    }
}
