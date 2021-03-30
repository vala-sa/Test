namespace Library
{
    public class ChildTest : BaseTest // Class inherited from class BaseTest
    {
        //------------------------------------------------------------------------------------------
        // Overridden methods of the base class inherited from BaseTest
        //------------------------------------------------------------------------------------------
        public override BaseTest Foo1(BaseTest bt) // public override method
        {
            return new BaseTest();
        }

        protected override BaseTest Foo2(BaseTest bt) // protected override method
        {
            return new BaseTest();
        }

        internal override BaseTest Foo3(BaseTest bt) // internal override method
        {
            return new BaseTest();
        }

        public new BaseTest Foo4(BaseTest bt) // public hide method
        {
            return new BaseTest();
        }
    }
}
