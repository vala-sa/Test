namespace Library
{
    //------------------------------------------------------------------------------------------
    // Public interface with a method that accepts and returns the BaseTest type.
    // Explicitly implemented in class BaseTest
    //------------------------------------------------------------------------------------------
    public interface IBase
    {
        BaseTest BaseTest(BaseTest bt);
    }
}
