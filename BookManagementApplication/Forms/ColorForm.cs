using System.Drawing;

namespace BookManagementApplication.Form
{
    // Color defines the color
    public class RawColor
    {
        public int r;
        public int g;
        public int b;
        public int alpha;

        // Constructor for default
        public RawColor()
        {
            this.r = 0;
            this.g = 0;
            this.b = 0;
            this.alpha = 0;
        }
        
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

        // Equals checks if two colors are equal
        public bool Equals(RawColor another)
        {
            return (
                this.alpha == another.alpha
                && this.r == another.r
                && this.g == another.g
                && this.b == another.b
            );
        }
    }
}