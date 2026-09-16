using System.Drawing;

namespace BookManagementApplication.Utils
{
    public class ColorUrils
    {
        // GetColor gets color from string
        public static Color GetColor(
            string colorName
        )
        {
            string lowerColorName = colorName.ToLower();
            switch (lowerColorName) {
                case "red":
                    return Color.Red;
                case "blue":
                    return Color.Blue;
                default:
                    return Color.Black;
            }
        }
    }
}