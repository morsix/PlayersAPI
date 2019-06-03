namespace PlayersAPI.Helpers
{
    public class PaginationInfo
    {
        public int Page { get; set; }

        public int PageSize { get; set; }

        public string Keyword { get; set; }

        public string SortBy { get; set; }

        public bool Order { get; set; }
    }
}
