namespace advanced01
{
    internal class Program
    {
        //swap method
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
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

            #region Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
            Pair<int, string> student =
            new Pair<int, string>(101, "Menna");

            Console.WriteLine(student.Key);
            Console.WriteLine(student.Value);
            #endregion

            #region Q4: What is a generic method? Write Swap<T> method.
            int x = 10;
            int y = 20;

            Swap(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);


            #endregion

        }
    }
}
