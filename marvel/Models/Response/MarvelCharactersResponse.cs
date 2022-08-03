﻿using System;
using marvel.Models.Domain;

namespace marvel.Models.Response
{
    public class MarvelCharactersResponse
    {
        public long Code { get; set; }
        public string Status { get; set; }
        public string Copyright { get; set; }
        public string AttributionText { get; set; }
        public string AttributionHtml { get; set; }
        public string Etag { get; set; }
        public Data Data { get; set; }
    }
}
