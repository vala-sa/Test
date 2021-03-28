using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    internal interface IInternal
    {
        interface INewInterface
        {
            public IInternal BaseTest(IInternal var)
            {
                return new BaseTest();
            }
        }

        public IInternal Foo(IInternal var)
        {
            return var;
        }

        BaseTest BaseTest(BaseTest bt);
    }
}
