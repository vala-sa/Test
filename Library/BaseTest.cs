using alias = Library.BaseTest; // Alias for class BaseTest

namespace Library
{
    public class BaseTest : IBase, IInternal 
    {
        //------------------------------------------------------------------------------------------
        // Nested class contains nested class with the same type BaseTest
        //------------------------------------------------------------------------------------------
        private class NewBaseTest
        {
            private class BaseTest
            {
                //------------------------------------------------------------------------------------------
                // Nested function type BaseTest
                //------------------------------------------------------------------------------------------
                private BaseTest BaseTestFoo(BaseTest bt)
                {
                    BaseTest BaseTestFoo1(BaseTest bt1)
                    {
                        return new BaseTest();
                    }
                    return new BaseTest();
                }

            }
        }

        //------------------------------------------------------------------------------------------
        // An explicit implementation of an interfaces IBase, IInternal
        // that has a method with a type BaseTest
        //------------------------------------------------------------------------------------------
        BaseTest IBase.BaseTest(BaseTest bt)
        {
            return new BaseTest();
        }

        BaseTest IInternal.BaseTest(BaseTest bt)
        {
            return new BaseTest();
        }

        //------------------------------------------------------------------------------------------
        // Constructor`s scope
        //------------------------------------------------------------------------------------------
        static BaseTest() // static constructor
        {

        }

        public BaseTest() // public constructor without params
        {

        }
        public BaseTest(BaseTest bt) // public constructor with params BaseTest type
        {

        }

        private BaseTest(params  BaseTest[] bt) // private constructor with params
        {

        }

        protected BaseTest(bool bt) // protected constructor 
        {

        }

        internal BaseTest(string bt) // internal constructor
        {

        }

        //------------------------------------------------------------------------------------------
        // Class BaseTest readonly member
        //------------------------------------------------------------------------------------------

        private readonly BaseTest _bt = new BaseTest();

        //------------------------------------------------------------------------------------------
        // Property sets and returns the object type BaseTest
        //------------------------------------------------------------------------------------------
        public BaseTest Property
        {
            set
            {
                BaseTest prop = new BaseTest();
            }

            get => new BaseTest();
        }

        //------------------------------------------------------------------------------------------
        // Method`s scopes. Method to be overridden in the child classes ChildTest and Child
        // Method to hide in the child.
        //------------------------------------------------------------------------------------------
        private BaseTest Foo( BaseTest bt) // private method take and return the type BaseTest 
        {
            return new BaseTest(bt);
        }

        public virtual BaseTest Foo1(BaseTest bt) // public method overlaid in the child classes ChildTest and Child
        {
            return new BaseTest();
        }

        protected virtual BaseTest Foo2(BaseTest bt) // protected method overlaid in the child classes ChildTest and Child
        {
            return new BaseTest();
        }

        internal virtual BaseTest Foo3(BaseTest bt) //internal method overridden in the child class ChildTest
        {
            return new BaseTest();
        }

        public BaseTest Foo4(BaseTest bt) // public method hidden in the child classes ChildTest and Child
        {
            return new BaseTest();
        }

        //------------------------------------------------------------------------------------------
        // Implicit and explicit type conversion. Implementation in Program.
        //------------------------------------------------------------------------------------------

        public static implicit operator int(BaseTest bt)
        {
            return 1;
        }

        public static explicit operator BaseTest(int x)
        {
            return new BaseTest();
        }
    }
}