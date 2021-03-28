using Alias = Library.BaseTest;

namespace Library
{
    public class BaseTest : IBase, IInternal
    {
        private class NewBaseTest : IBase
        {
            public BaseTest BaseTest(BaseTest bt)
            {
                return new BaseTest();
            }
        }

        BaseTest IBase.BaseTest(BaseTest bt)
        {
            return new BaseTest();
        }

        BaseTest IInternal.BaseTest(BaseTest bt)
        {
            return new BaseTest();
        }
        static BaseTest()
        {

        }

        public BaseTest()
        {

        }
        public BaseTest(BaseTest bt)
        {

        }

        private BaseTest(int bt)
        {

        }

        protected BaseTest(bool bt)
        {

        }

        internal BaseTest(string bt)
        {

        }

        public BaseTest Property
        {
            set
            {
                BaseTest prop = new BaseTest();
            }

            get => new BaseTest();
        }

        private BaseTest bt = new BaseTest();

        private BaseTest Foo( BaseTest bt)
        {
            return new BaseTest(bt);
        }

        public virtual BaseTest Foo1(BaseTest bt)
        {
            return new BaseTest();
        }

        protected virtual BaseTest Foo2(BaseTest bt)
        {
            return new BaseTest();
        }

        internal virtual BaseTest Foo3(BaseTest bt)
        {
            return new BaseTest();
        }

        public BaseTest Foo4(BaseTest bt) //new
        {
            return new BaseTest();
        }

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