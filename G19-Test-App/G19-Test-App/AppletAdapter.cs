namespace G19_Test_App
{
    using System.Drawing;
    using System.Drawing.Imaging;

    using LgLcd;

    public class AppletAdapter : Applet
    {
        private readonly Bitmap bitmap;

        private readonly Device device;

        public AppletAdapter()
        {
            this.bitmap = new Bitmap(320, 240, PixelFormat.Format32bppArgb);
            this.bitmap.SetPixel(100, 100, Color.Yellow);

            this.Connect("Nikolay.IT Test", true, AppletCapabilities.Qvga);

            this.device = new Device();
            this.device.Open(this, DeviceType.Qvga);
            this.device.UpdateBitmap(this.bitmap, Priority.Normal);
        }
    }
}