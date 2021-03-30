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
            return new BaseTest();
        }

        protected override BaseTest Foo2(BaseTest bt) // protected method
        {
            return new BaseTest();
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
    public class Child1 : AbstractNegative
    {

    }

    //------------------------------------------------------------------------------------------
    // Child class of class Generalized<BaseTest>
    //------------------------------------------------------------------------------------------
    public class Child2 : Generalized<BaseTest>
    {

    }
}
