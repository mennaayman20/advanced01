
namespace advanced01
{
    public class Creator<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T(); 
        }
    }
}
