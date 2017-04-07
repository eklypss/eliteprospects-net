namespace eliteprospects_net.Source.Model.Parameters
{
    public class Limit
    {
        public int ResultLimit { get; set; }

        public Limit(int limit)
        {
            ResultLimit = limit;
        }
    }
}