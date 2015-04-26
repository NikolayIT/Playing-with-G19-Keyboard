namespace G19_Test_App
{
    using System;

    using LgBackLight;

    public static class Program
    {
        public static void Main()
        {
            var applet = new AppletAdapter(new TestApplet());
            Console.ReadLine();
        }
    }
}
