namespace ACTSOA_GROUP10.CoreLayer.Entities
{
    public class Tag
    {
        public int id { get; set; }
        public string Name { get; set; }
        public ICollection<MovieSeriesTag> MovieSeriesTags { get; set; }
    }
}
