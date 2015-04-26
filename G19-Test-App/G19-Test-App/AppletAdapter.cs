namespace G19_Test_App
{
    using System;

    using LgLcd;

    public class AppletAdapter : Applet
    {
        private readonly IAppletProgram appletProgram;

        private readonly Device device;

        public AppletAdapter(IAppletProgram appletProgram)
        {
            this.appletProgram = appletProgram;
            this.appletProgram.BitmapChanged += this.AppletProgramBitmapChanged;

            this.Connect(appletProgram.Name, true, AppletCapabilities.Qvga);

            this.device = new Device();
            this.device.Open(this, DeviceType.Qvga);

            this.appletProgram.Initialize();
        }

        private void AppletProgramBitmapChanged(object sender, BitmapChangedEventArgs e)
        {
            this.device.UpdateBitmap(e.Bitmap, Priority.Normal);
        }
    }
}