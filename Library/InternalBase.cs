namespace Library
{
    //------------------------------------------------------------------------------------------
    // Internal class InternalBase. With the same type as in Project
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
        private BaseTest BaseTest1(BaseTest bt1)
        {
            return new BaseTest();
        }
    }
}