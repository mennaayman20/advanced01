
namespace advanced01
{
    internal class Manager<T> where T : ILogger
    {
        public void DoLog(T obj)
        {
            obj.Log(); 
        }

    }
}
