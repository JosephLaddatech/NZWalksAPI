namespace NZWalks.API.Models.DTO
{
    public class WalkDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageURl { get; set; }

        public RegionDto Region { get; set; }
        public DifficultyDto Difficulty { get; set; }

    }
}
