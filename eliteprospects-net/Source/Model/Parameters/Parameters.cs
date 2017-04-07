namespace eliteprospects_net.Source.Model.Parameters
{
    public class Parameters
    {
        public Filter Filter { get; set; }
        public Limit Limit { get; set; }

        public Parameters(Filter filter, Limit limit)
        {
            Filter = filter;
            Limit = limit;
        }
    }
}