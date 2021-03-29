namespace Library
{
    //------------------------------------------------------------------------------------------
    // Generic class and method. Implementation in Program with type BaseTest
    //------------------------------------------------------------------------------------------
    public class Generalized<T>
    {
        public Generalized<T> FooGen<T> (T t)
        {
            return new Generalized<T>();
        }
    }
}
