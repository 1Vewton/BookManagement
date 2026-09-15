namespace BookManagementApplication.Form
{
    // BookForm defines the form to store book
    public class BookForm
    {
        string title;
        int totalChapters;
        int currentChapter;
        // Constructor
        public BookForm(
            string title,
            int totalChapters
        )
        {
            this.title = title;
            this.totalChapters = totalChapters;
            this.currentChapter = 0;
        }
    }
}