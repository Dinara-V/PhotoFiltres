using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapFiltres
{
    class Red : IFilter
    {
        private Bitmap _oldImage;
        private Bitmap _newImage;
        public Red(Bitmap image)
        {
            _oldImage = image;
        }
        public Bitmap Apply()
        {
            Color pixel;//RGB (0..255)
            int height = _oldImage.Height;
            int width = _oldImage.Width;

            _newImage = new Bitmap(width, height);

            for (int h = 0; h < height; h++)
                for (int w = 0; w < width; w++)
                {
                    pixel = _oldImage.GetPixel(w, h);
                    pixel = Color.FromArgb(pixel.R, 0, 0);
                    _newImage.SetPixel(w, h, pixel);
                }
            return _newImage;
        }

        public Bitmap Cancel()
        {
            return _oldImage;
        }

        public void changeImage(Bitmap image)
        {
            _oldImage = image;
        }
    }
}
