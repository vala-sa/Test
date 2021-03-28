using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Child : BaseTest
    {
        public override BaseTest Foo1(BaseTest bt)
        {
            return base.Foo1(bt);
        }

        protected override BaseTest Foo2(BaseTest bt)
        {
            return base.Foo2(bt);
        }

        internal override BaseTest Foo3(BaseTest bt)
        {
            return base.Foo3(bt);
        }

        public new BaseTest Foo4(BaseTest bt)
        {
            return new BaseTest();
        }
    }

    internal class InternalChild : InternalBase
    {
        private class InternalChild1 : InternalBase
        {
            
        }

    }

}
