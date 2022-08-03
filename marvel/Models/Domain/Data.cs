namespace marvel.Models.Domain
{
    public class Data
    {
        public long Offset { get; set; }
        public long Limit { get; set; }
        public long Total { get; set; }
        public long Count { get; set; }
        public MarvelCharacter[] Results { get; set; }
    }
}
