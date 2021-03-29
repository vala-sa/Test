using System;
using System.Collections.Generic;
using System.Text;
using Library;

namespace Project
{
    //------------------------------------------------------------------------------------------
    // Child class of class BaseTest.
    // A method in a nested class BaseTest type takes and returns a type BaseTest.
    //------------------------------------------------------------------------------------------
    public class Child : BaseTest
    {
        class NewChild
        {
            public BaseTest BaseTest(BaseTest bt)
            {
                return new BaseTest();
            }
        }

        //------------------------------------------------------------------------------------------
        // Overridden base class methods with different scopes
        //------------------------------------------------------------------------------------------
        public override BaseTest Foo1(BaseTest bt) // public method
        {
            return base.Foo1(bt);
        }

        protected override BaseTest Foo2(BaseTest bt) // protected method
        {
            return base.Foo2(bt);
        }

        public new BaseTest Foo4(BaseTest bt) // public hide method
        {
            return new BaseTest();
        }

        //------------------------------------------------------------------------------------------
        // Properties with base class type BaseTest
        //------------------------------------------------------------------------------------------
        public Child PropertyChild
        {
            set
            {
                BaseTest prop = new BaseTest();
            }

            get => (Child)new BaseTest();
        }
    }

    //------------------------------------------------------------------------------------------
    // Child class of class Abstract
    //------------------------------------------------------------------------------------------
    class Child1 : Abstract
    {

    }

    //------------------------------------------------------------------------------------------
    // Child class of class Generalized<BaseTest>
    //------------------------------------------------------------------------------------------
    class Child2 : Generalized<BaseTest>
    {

    }
}
