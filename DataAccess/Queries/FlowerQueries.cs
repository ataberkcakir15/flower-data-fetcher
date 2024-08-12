namespace DataAccess.Queries
{
    public class FlowerQueries
    {
        internal const string GET_FLOWER_INFORMATION = @"
SELECT Name, Colour
FROM [flower].[Flowers]";
    }
}
