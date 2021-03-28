using System;
using System.Collections.Generic;
using System.Text;
using Library;

namespace Project
{
    class Child : BaseTest
    {
        class NewChild
        {
            public BaseTest BaseTest(BaseTest bt)
            {
                return new BaseTest();
            }
        }
        public override BaseTest Foo1(BaseTest bt)
        {
            return base.Foo1(bt);
        }

        protected override BaseTest Foo2(BaseTest bt)
        {
            return base.Foo2(bt);
        }

        public Child PropertyChild
        {
            set
            {
                BaseTest prop = new BaseTest();
            }

            get => (Child)new BaseTest();
        }

        private (Child, BaseTest) tuple = (new Child(), new BaseTest());
    }

    class Child1 : Abstract
    {

    }

    class Child2 : Generalized<BaseTest>
    {

    }
}
