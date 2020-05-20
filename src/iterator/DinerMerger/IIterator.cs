namespace DinerMerger
{
    public interface IIterator
    {
        bool HasNext();
        MenuItem Next();
    }
}