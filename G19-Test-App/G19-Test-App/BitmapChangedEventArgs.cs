namespace G19_Test_App
{
    using System;
    using System.Drawing;

    public class BitmapChangedEventArgs : EventArgs
    {
        private readonly Bitmap bitmap;

        public BitmapChangedEventArgs(Bitmap bitmap)
        {
            this.bitmap = bitmap;
        }

        public Bitmap Bitmap
        {
            get
            {
                return this.bitmap;
            }
        }
    }
}