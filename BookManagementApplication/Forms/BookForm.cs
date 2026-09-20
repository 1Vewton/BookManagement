using Console = Colorful.Console;
using Newtonsoft.Json;

namespace BookManagementApplication.Form
{
    // BookForm defines the form to store book
    public class BookForm
    {
        public string title;
        public int totalChapters;
        public int currentChapter;
        public string description;
        public RawColor color;
        string fileName;

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
            this.fileName = string.Format(
                "{0}.json",
                this.title
            );
        }

        // NewBookFormFromFile returns a new book form
        public static BookForm NewBookFormFromFile(
            string path
        )
        {
            StreamReader reader = new StreamReader(path);
            string text = reader.ReadToEnd();
            reader.Close();
            BookForm? newBookForm = JsonConvert.DeserializeObject<BookForm>(
                text
            );
            if (newBookForm == null) {
                throw new Exception("some problems occured, causing it to return an error");
            }
            newBookForm.fileName = path;
            return newBookForm;
        }

        // GetFileName gets file name
        public string GetFileName() {
            return this.fileName;
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

        // ToFile stores this object to a json file
        public void ToFile()
        {
            string content = this.Convert();
            string[] contents = new string[1];
            contents[0] = content;
            File.WriteAllLines(
                this.GetFileName(), 
                contents
            );
        }

        // Equals checks if this object is equals to another object
        public bool Equals(BookForm another)
        {
            return (
                this.color.Equals(another.color)
                && this.title.Equals(another.title)
                && this.description.Equals(another.description)
                && this.currentChapter == another.currentChapter
                && this.totalChapters == another.totalChapters
            );
        }
    }
}