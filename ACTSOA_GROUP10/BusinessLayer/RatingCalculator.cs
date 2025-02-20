using ACTSOA_GROUP10.CoreLayer.Entities;

namespace ACTSOA_GROUP10.BusinessLayer
{
    public static class RatingCalculator
    {
        public static decimal CalculateAverageRating(IEnumerable<Rating> ratings)
        {
            if (ratings == null || !ratings.Any())
                return 0;

            return ratings.Average(r => r.Value);
        }
    }
}