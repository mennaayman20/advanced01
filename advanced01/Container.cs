

namespace advanced01
{
    public class Container<T>
    {
        private T item;

        public void Add(T value)
        {
            item = value;
        }

        public T Get()
        {
            return item;
        }
    }
}
