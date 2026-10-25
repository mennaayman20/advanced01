

namespace advanced01
{
    public class SafeList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item) => items.Add(item);

        public T GetAt(int index)
        {
            if (index >= 0 && index < items.Count)
                return items[index];

            return default(T); // لو الإندكس غلط، نرجع القيمة الافتراضية بأمان
        }
    }
}
