using System;
namespace marvel.Models.Domain
{
    public class Thumbnail
    {
        public Uri Path { get; set; }
        public string Extension { get; set; }

        public string FullImagePath { get => $"{Path}.{Extension}"; }
    }
}
