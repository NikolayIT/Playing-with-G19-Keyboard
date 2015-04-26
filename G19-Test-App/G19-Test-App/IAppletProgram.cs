namespace G19_Test_App
{
    public interface IAppletProgram
    {
        void Initialize();

        event BitmapChangedHandler BitmapChanged;

        string Name { get; }
    }
}
