namespace advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            // A generic class is a class that can work with any data type.
            // It allows you to define a class with a placeholder for the data type, which can be specified when creating an instance of the class. This provides type safety and code reusability,
            // as you can create a single class that can handle different data types without duplicating code.

            #endregion

            #region Q2: Write a generic class Container<T> with Add and Get methods.
            Container<int> box = new Container<int>();

            box.Add(10);

            int result = box.Get();

            Console.WriteLine(result);
            #endregion
        }
    }
}
