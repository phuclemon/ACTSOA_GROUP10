﻿using ACTSOA_GROUP10.CoreLayer.Entities;

namespace ACTSOA_GROUP10.CoreLayer.Entities
{
    public class MovieSeriesTag
    {
        public int MovieSeriesId { get; set; }
        public int TagId { get; set; }
        public Movie Movie { get; set; }
        public Tag Tag { get; set; }
    }
}