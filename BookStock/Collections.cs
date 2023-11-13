namespace BookStock
{
    public interface Collections
    {
        void add(object e);
        void remove(object e);
        bool contains(object e);
        int size();
        bool isEmpty();
    }
}