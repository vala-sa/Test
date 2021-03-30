using Library;

namespace Project
{
    //------------------------------------------------------------------------------------------
    // Internal class InternalBase. With the same type as in Library
    //------------------------------------------------------------------------------------------
    internal class InternalBase
    {
        private class Child : InternalBase
        {

        } 
    }

    //------------------------------------------------------------------------------------------
    // Partial class PartialBase
    //------------------------------------------------------------------------------------------
    public partial class PartialBase
    {
        private BaseTest BaseTest(BaseTest bt)
        {
            return new BaseTest();
        }
    }
}
