namespace LinqToAnything
{
    public interface QueryInfo
    {
        int? Take { get; }
        int Skip { get; }
        OrderBy OrderBy { get; }
    }
}