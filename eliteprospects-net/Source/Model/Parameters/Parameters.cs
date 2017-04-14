namespace eliteprospects_net
{
    public class Parameters
    {
        public Filter Filter { get; set; }
        public Limit Limit { get; set; }
        public Sort Sort { get; set; }

        public Parameters(Filter filter, Limit limit, Sort sort)
        {
            Filter = filter;
            Limit = limit;
            Sort = sort;
        }
    }
}