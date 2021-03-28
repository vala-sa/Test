using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Generalized<T>
    {
        public Generalized<T> FooGen<T> (T t)
        {
            return new Generalized<T>();
        }
    }
}
