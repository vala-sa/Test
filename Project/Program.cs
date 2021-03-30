using System;
using System.Collections.Generic;
using Library;
using External;

namespace Project
{
    class Program
    {
        //------------------------------------------------------------------------------------------
        // Declaration delegates. Type BaseTest delegate. Generalized type BaseTest delegate
        //------------------------------------------------------------------------------------------
        delegate BaseTest Del(BaseTest bt);
        delegate T Del1<T, K>(K val);

        //------------------------------------------------------------------------------------------
        // Method type BaseTest. Method takes type BaseTest and return type BaseTest
        //------------------------------------------------------------------------------------------
        public static BaseTest Foo(BaseTest bt) => new BaseTest();
   
        //------------------------------------------------------------------------------------------
        // Generalized method type BaseTest
        //------------------------------------------------------------------------------------------
        Generalized<BaseTest> FooGen<BaseTest>(BaseTest bt)
        {
            return new Generalized<BaseTest>();
        }

        static void Main(string[] args)
        {
            //------------------------------------------------------------------------------------------
            // Third party library with the same interface class types and methods
            //------------------------------------------------------------------------------------------
            External.BaseTestExternal ext = new BaseTestExternal();

            //------------------------------------------------------------------------------------------
            // Class implementation (BaseTest, Child, Generalized)
            //------------------------------------------------------------------------------------------
            BaseTest bt = new BaseTest();
            Child cd = new Child();
            Generalized<BaseTest> gt = new Generalized<BaseTest>();

            //------------------------------------------------------------------------------------------
            // Tuple with two types Child, BaseTest
            //------------------------------------------------------------------------------------------
            (Child, BaseTest) tuple = (new Child(), new BaseTest());

            //------------------------------------------------------------------------------------------
            // Dictionary with two types Child, BaseTest
            //------------------------------------------------------------------------------------------
            Dictionary<Child, BaseTest> dict = new Dictionary<Child, BaseTest>();

            //------------------------------------------------------------------------------------------
            // Delegates
            //------------------------------------------------------------------------------------------
            Del del = (BaseTest bt11) => new BaseTest();
            Del1<BaseTest, Child> del1 = Foo;

            //------------------------------------------------------------------------------------------
            // Casts of type BaseTest
            //------------------------------------------------------------------------------------------
            BaseTest bt1 = cd as BaseTest;
            bool var = cd is BaseTest;

            Console.WriteLine("Hello World!");
        }
    }
}
