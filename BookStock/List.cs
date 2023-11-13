namespace BookStock
{
    public interface List : Collections
    {
        void add(int index, object e);
        void remove(int index);
        object get(int index);
        void set(int index, object e);
        int indexOf(object e);
    }
}