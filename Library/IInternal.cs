using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    //------------------------------------------------------------------------------------------
    // Internal interface IInternal. With the same type as in Project
    // Nested interface with the same type IInternal.
    //------------------------------------------------------------------------------------------
    internal interface IInternal
    {
        interface INewInterface
        {
            interface IInternal
            {
                
            }
            //------------------------------------------------------------------------------------------
            // The type Library.IInternal method takes a type IInternal parameter
            // Return type BaseTest
            //------------------------------------------------------------------------------------------
            public Library.IInternal BaseTest(IInternal var)
            {
                return new BaseTest();
            }
        }
        //------------------------------------------------------------------------------------------
        // Explicit implementation of the interface in the class BaseTest
        //------------------------------------------------------------------------------------------
        BaseTest BaseTest(BaseTest bt);
    }
}
