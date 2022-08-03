using System;
namespace marvel.Models.Domain
{
    public class MarvelCharacter
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Modified { get; set; }
        public Thumbnail Thumbnail { get; set; }
        public Uri ResourceUri { get; set; }
    }
}
