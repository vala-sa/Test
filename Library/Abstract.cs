namespace Library
{
    //------------------------------------------------------------------------------------------
    // Abstract class. Method type BaseTest takes a type BaseTest and returns type BestTest
    //------------------------------------------------------------------------------------------
    public abstract class Abstract 
    {
        public BaseTest BaseTest(BaseTest bt)
        {
            return new BaseTest();
        }
    }
}
