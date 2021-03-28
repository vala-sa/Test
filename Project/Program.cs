using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Library;

namespace Project
{
    class Program
    {
        delegate BaseTest Del(BaseTest bt);

        delegate T Del1<T, K>(K val);

        static BaseTest Foo(BaseTest bt)
        {
            return new BaseTest();
        }

        Generalized<BaseTest> FooGen<BaseTest>(BaseTest bt)
        {
            return new Generalized<BaseTest>();
        }


        static void Main(string[] args)
        {
            BaseTest bt = new BaseTest();
            Child cd = new Child();

            Del del = (BaseTest bt) => new BaseTest();
            Del1<BaseTest, Child> _del = Foo; //why?

            Dictionary<Child, BaseTest> dict = new Dictionary<Child, BaseTest>(); 

            cd = (Child) bt;
            BaseTest bt1 = cd as BaseTest;
            bool var = cd is BaseTest;

            Generalized<BaseTest> gt = new Generalized<BaseTest>();

            

            Console.WriteLine("Hello World!");
        }
    }
}
