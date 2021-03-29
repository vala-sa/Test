using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class ChildTest : BaseTest // Class inherited from class BaseTest
    {
        //------------------------------------------------------------------------------------------
        // Overridden methods of the base class inherited from BaseTest
        //------------------------------------------------------------------------------------------
        public override BaseTest Foo1(BaseTest bt) // public override method
        {
            return base.Foo1(bt);
        }

        protected override BaseTest Foo2(BaseTest bt) // protected override method
        {
            return base.Foo2(bt);
        }

        internal override BaseTest Foo3(BaseTest bt) // internal override method
        {
            return base.Foo3(bt);
        }

        public new BaseTest Foo4(BaseTest bt) // public hide method
        {
            return new BaseTest();
        }
    }
}
