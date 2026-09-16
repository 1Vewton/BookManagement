using System.Drawing;

namespace BookManagementApplication.Form
{
    // Color defines the color
    public class RawColor
    {
        int r;
        int g;
        int b;
        int alpha;
        
        // Constructor creates a color from rgb scale of 0-255
        public RawColor(
            int r,
            int g,
            int b
        )
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.alpha = 255;
        }

        // Constructor creates a color from rgba scale of 0-255
        public RawColor(
            int r,
            int g,
            int b,
            int a
        )
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.alpha = a;
        }

        // ToColor converts color to color of system
        public Color ToColor()
        {
            return Color.FromArgb(
                this.alpha,
                this.r,
                this.g,
                this.b
            );
        }
    }
}