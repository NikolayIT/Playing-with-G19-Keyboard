namespace G19_Test_App
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;

    public delegate void BitmapChangedHandler(object sender, BitmapChangedEventArgs e);

    public class TestApplet : IAppletProgram
    {
        private Bitmap bitmap;

        public TestApplet()
        {
            this.bitmap = new Bitmap(320, 240, PixelFormat.Format32bppArgb);
        }

        public void Initialize()
        {
            this.bitmap.SetPixel(100, 100, Color.Yellow);
            this.BitmapChangedInvoke();
        }

        public event BitmapChangedHandler BitmapChanged;

        public string Name
        {
            get
            {
                return "Nikolay.IT";
            }
        }

        private void BitmapChangedInvoke()
        {
            if (this.BitmapChanged != null)
            {
                this.BitmapChanged(this, new BitmapChangedEventArgs(this.bitmap));
            }
        }
    }
}
