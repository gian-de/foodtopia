namespace foodtopia.Helpers
{
    public class LeaderboardPagedResult<T>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public IReadOnlyList<T> Results { get; set; }
    }
}