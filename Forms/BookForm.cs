using Console = Colorful.Console;
using Newtonsoft.Json;

namespace BookManagementApplication.Form
{
    // BookForm defines the form to store book
    public class BookForm
    {
        string title;
        int totalChapters;
        int currentChapter;
        string description;
        RawColor color;

        // Constructor
        public BookForm(
            string title,
            int totalChapters, 
            string description
        )
        {
            this.title = title;
            this.totalChapters = totalChapters;
            this.currentChapter = 0;
            this.description = description;
            this.color = new RawColor(0, 0, 0);
        }

        // Show shows the info of the book
        public void Show()
        {
            Console.WriteLine(this.title, this.color.ToColor());
            Console.WriteLine(this.description);
            Console.WriteLine("");
        }

        // Convert converts this object to json string
        public string Convert()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}