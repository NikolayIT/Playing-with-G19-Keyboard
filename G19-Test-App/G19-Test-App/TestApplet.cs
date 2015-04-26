namespace G19_Test_App
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;

    public delegate void BitmapChangedHandler(object sender, BitmapChangedEventArgs e);

    public class TestApplet : IAppletProgram
    {
        private readonly Bitmap bitmap;

        private readonly Graphics graphics;

        public TestApplet()
        {
            this.bitmap = new Bitmap(320, 240, PixelFormat.Format32bppArgb);
            this.graphics = Graphics.FromImage(this.bitmap);
            this.graphics.SmoothingMode = SmoothingMode.AntiAlias;
            this.graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            this.graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
        }

        public event BitmapChangedHandler BitmapChanged;

        public string Name
        {
            get
            {
                return "Nikolay.IT";
            }
        }

        public void Initialize()
        {
            this.graphics.DrawString("Hello, world from Nikolay.IT!", new Font("Consolas", 12), Brushes.White, new PointF(20, 20));
            this.BitmapChangedInvoke();
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
