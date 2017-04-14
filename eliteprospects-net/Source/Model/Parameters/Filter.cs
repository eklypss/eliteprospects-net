namespace eliteprospects_net
{
    public class Filter
    {
        public string SearchFilter { get; set; }

        public Filter(string filter)
        {
            SearchFilter = filter.Replace(" ", "%20");
        }
    }
}