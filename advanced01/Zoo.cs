

namespace advanced01
{
    internal class Zoo<T> where T : Animal
    {
        public T ?AnimalInCage { get; set; }
    }
}
